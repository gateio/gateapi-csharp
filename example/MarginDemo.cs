using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace GateApiDemo
{
    public class MarginDemo
    {
        private readonly RunConfig _runConfig;

        public MarginDemo(RunConfig runConfig)
        {
            this._runConfig = runConfig;
        }

        public void Run()
        {
            const string currencyPair = "BTC_USDT";
            string currency = currencyPair.Split('_')[1];
            
            Configuration config = new Configuration
            {
                // Setting basePath is optional. It defaults to https://api.gateio.ws/api/v4
                BasePath = _runConfig.HostUsed,
                ApiV4Key = _runConfig.ApiKey,
                ApiV4Secret = _runConfig.ApiSecret,
            };
            
            SpotApi spotApi = new SpotApi(config);
            MarginApi marginApi = new MarginApi(config);
            WalletApi walletApi = new WalletApi(config);

            List<Ticker> tickers = spotApi.ListTickers(currencyPair);
            Debug.Assert(tickers.Count == 1);
            string lastPrice = tickers[0].Last;
            Debug.Assert(lastPrice != null);
            Console.WriteLine("currency pair {0} last price: {1}", currencyPair, lastPrice);

            List<MarginCurrencyPair> pairs = marginApi.ListMarginCurrencyPairs();
            MarginCurrencyPair pair = pairs.Find(p => currencyPair.Equals(p.Id));
            decimal loanAmount = pair.MinQuoteAmount == null ? 0 : Convert.ToDecimal(pair.MinQuoteAmount);
            if (pair.MinBaseAmount != null)
            {
                decimal minLoanAmount = Convert.ToDecimal(pair.MinBaseAmount) * Convert.ToDecimal(lastPrice);
                if (loanAmount.CompareTo(minLoanAmount) < 0)
                {
                    loanAmount = minLoanAmount;
                }
            }
            Console.WriteLine("minimum loan amount in currency pair {0}: {1} {2}", currencyPair, loanAmount, currency);

            // example to lend
            Random random = new Random();
            List<FundingAccount> fundingAccounts = marginApi.ListFundingAccounts(currency);
            decimal lendAmount = decimal.Round(loanAmount + Convert.ToDecimal(random.NextDouble()), 8,
                MidpointRounding.AwayFromZero);
            if (fundingAccounts.Count == 1 && Convert.ToDecimal(fundingAccounts[0].Available).CompareTo(lendAmount) >= 0)
            {
                // lend with maximum rate
                Loan lendingLoan = new Loan(currency: currency, amount:lendAmount.ToString(CultureInfo.InvariantCulture))
                {
                    AutoRenew = false,
                    Days = 10,
                    Rate = "0.002",
                    Side = Loan.SideEnum.Lend,
                };
                Loan createdLoan = marginApi.CreateLoan(lendingLoan);
                Console.WriteLine("place a lending loan {0} with currency {1}, rate {2}, amount {3}", createdLoan.Id,
                    createdLoan.Currency, createdLoan.Rate, createdLoan.Amount);

                Loan loanResult = marginApi.GetLoan(createdLoan.Id, "lend");
                if (Loan.StatusEnum.Loaned.Equals(loanResult.Status))
                {
                    List<LoanRecord> records = marginApi.ListLoanRecords(loanResult.Id);
                    foreach (LoanRecord r in records)
                    {
                        Console.WriteLine("Loan {0} is borrowed with record ID {1}, amount {2}, current status: {3}",
                            r.LoanId, r.Id, r.Amount, r.Status);
                    }
                }
                else
                {
                    marginApi.CancelLoan(createdLoan.Id, currency);
                    Console.WriteLine("Lending loan {0} is cancelled", createdLoan.Id);
                }
            }

            decimal margin = decimal.Round(loanAmount / (Convert.ToDecimal(pair.Leverage) - 1), 8,
                MidpointRounding.AwayFromZero);
            List<MarginAccount> accounts = marginApi.ListMarginAccounts(currencyPair);
            Debug.Assert(accounts.Count == 1);
            decimal available = Convert.ToDecimal(accounts[0].Quote.Available);
            Console.WriteLine("Available margin balance of currency {0} in currency pair {1}: {2}", currency, currencyPair, available);

            if (margin.CompareTo(available) > 0)
            {
                // margin balance not enough, transfer to margin account
                Transfer transfer = new Transfer(currency: currency, amount: (margin - available).ToString(CultureInfo.InvariantCulture))
                {
                    CurrencyPair = currencyPair,
                    Currency = currency,
                    From = Transfer.FromEnum.Spot,
                    To = Transfer.ToEnum.Margin,
                };
                walletApi.Transfer(transfer);
                Console.WriteLine("Transferred {0} {1} to margin account in currency pair {2}", transfer.Amount,
                    transfer.Currency, transfer.CurrencyPair);
            }
            
            // find minimum rate available
            decimal minRate = marginApi.ListFundingBook(currency)
                .FindAll(x => loanAmount.CompareTo(Convert.ToDecimal(x.Amount)) < 0)
                .Min(x => Convert.ToDecimal(x.Rate));
            // example to borrow with minimum loan rate
            decimal borrowAmount = decimal.Round(loanAmount + Convert.ToDecimal(random.NextDouble()), 8,
                MidpointRounding.AwayFromZero);
            Loan loan = new Loan(currency: currency, amount: borrowAmount.ToString(CultureInfo.InvariantCulture))
            {
                Side = Loan.SideEnum.Borrow,
                Rate = minRate.ToString(CultureInfo.InvariantCulture),
                Days = 10,
                CurrencyPair = currencyPair,
            };
            Loan borrowed = marginApi.CreateLoan(loan);
            Console.WriteLine("Borrowed {0} {1} in currency pair {2} with rate {3}, id {4}", borrowed.Amount,
                borrowed.Currency, borrowed.CurrencyPair, borrowed.Rate, borrowed.Id);
            Debug.Assert(borrowed.Status == Loan.StatusEnum.Loaned);
            
            // create margin order
            string orderAmount = spotApi.GetCurrencyPair(currencyPair).MinQuoteAmount;
            Order order = new Order(currencyPair: currencyPair, amount: orderAmount ?? "1", price: lastPrice)
            {
                Account = Order.AccountEnum.Margin,
                AutoBorrow = false,
                Side = Order.SideEnum.Sell,
            };

            try
            {
                Order createdOrder = spotApi.CreateOrder(order);
                Console.WriteLine("order created with id {0}, status {1}", createdOrder.Id, createdOrder.Status);
            }
            catch (GateApiException e)
            {
                Console.Error.WriteLine("failed to create margin order: {0}", e);
            }

            RepayRequest repayRequest = new RepayRequest(currencyPair, currency, RepayRequest.ModeEnum.All);
            marginApi.RepayLoan(borrowed.Id, repayRequest);
            foreach (Repayment r in marginApi.ListLoanRepayments(borrowed.Id))
            {
                Console.WriteLine("loan {0} repaid {1} with interest {2}", borrowed.Id, r.Principal, r.Interest);
            }
        }
    }
}