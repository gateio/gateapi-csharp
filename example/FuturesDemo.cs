using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace GateApiDemo
{
    public class FuturesDemo
    {
        private readonly RunConfig _runConfig;

        public FuturesDemo(RunConfig runConfig)
        {
            this._runConfig = runConfig;
        }

        public void Run()
        {
            const string settle = "usdt";
            const string contract = "BTC_USDT";
            
            Configuration config = new Configuration
            {
                BasePath = _runConfig.HostUsed,
                ApiV4Key = _runConfig.ApiKey,
                ApiV4Secret = _runConfig.ApiSecret,
            };
            
            FuturesApi futuresApi = new FuturesApi(config);
            
            // update position leverage
            const string leverage = "3";
            futuresApi.UpdatePositionLeverage(settle, contract, leverage);
            
            // retrieve position information
            long positionSize = 0L;
            try
            {
                Position position = futuresApi.GetPosition(settle, contract);
                positionSize = position.Size;
            }
            catch (GateApiException e)
            {
                // ignore no position error 
                if (!"POSITION_NOT_FOUND".Equals(e.ErrorLabel))
                {
                    throw;
                }
            }
            
            // set order size
            Contract futuresContract = futuresApi.GetFuturesContract(settle, contract);
            long orderSize = 10L;
            if (futuresContract.OrderSizeMin > orderSize)
            {
                orderSize = futuresContract.OrderSizeMin;
            }

            if (positionSize < 0)
            {
                // if short, set size to negative
                orderSize = -orderSize;
            }
            
            // example to update risk limit
            string riskLimit =
                (Convert.ToDecimal(futuresContract.RiskLimitBase) + Convert.ToDecimal(futuresContract.RiskLimitStep))
                .ToString(CultureInfo.InvariantCulture);
            futuresApi.UpdatePositionRiskLimit(settle, contract, riskLimit);
            
            // retrieve last price to calculate margin needed
            List<FuturesTicker> tickers = futuresApi.ListFuturesTickers(settle, contract);
            Debug.Assert(tickers.Count == 1);
            string lastPrice = tickers[0].Last;
            Console.WriteLine("last price of contract {0}: {1}", contract, lastPrice);

            decimal margin = decimal.Round(orderSize * Convert.ToDecimal(lastPrice) *
                Convert.ToDecimal(futuresContract.QuantoMultiplier) / Convert.ToDecimal(leverage) * 1.1m, 8,
                MidpointRounding.AwayFromZero);
            Console.WriteLine("needs margin amount: " + margin.ToString(CultureInfo.InvariantCulture));
            
            // if balance not enough, transfer from spot account
            string available = "0";
            try
            {
                available = futuresApi.ListFuturesAccounts(settle).Available;
            }
            catch (GateApiException e)
            {
                if (!"USER_NOT_FOUND".Equals(e.ErrorLabel))
                {
                    throw;
                }
            }
            Console.WriteLine("Futures account available: {0} {1}", available, settle.ToUpper());
            if (Convert.ToDecimal(available).CompareTo(margin) < 0)
            {
                if (_runConfig.UseTestNet)
                {
                    Console.Error.WriteLine("TestNet account balance not enough, make a transferal on web");
                    return;
                }
                Transfer transfer = new Transfer(currency: settle.ToUpper(), amount: margin.ToString(CultureInfo.InvariantCulture))
                {
                    From = Transfer.FromEnum.Spot,
                    To = Transfer.ToEnum.Futures,
                };
                WalletApi walletApi = new WalletApi(config);
                walletApi.Transfer(transfer);
            }
            
            // example to cancel all open orders in contract
            futuresApi.CancelFuturesOrders(settle, contract, "");
            
            FuturesOrder futuresOrder = new FuturesOrder(contract)
            {
                Size = orderSize,
                Price = "0",
                Tif = FuturesOrder.TifEnum.Ioc,
            };

            FuturesOrder orderResponse;
            try
            {
                orderResponse = futuresApi.CreateFuturesOrder(settle, futuresOrder);
            }
            catch (GateApiException e)
            {
                Console.Error.WriteLine(e);
                return;
            }
            Console.WriteLine("Order {0} created with status {1}", orderResponse.Id, orderResponse.Status);
            if (FuturesOrder.StatusEnum.Open.Equals(orderResponse.Status))
            {
                FuturesOrder order = futuresApi.GetFuturesOrder(settle, orderResponse.Id.ToString());
                Console.WriteLine("Order {0} status {1}, total size {2}, left {3}", order.Id, order.Status, order.Size,
                    order.Left);
                futuresApi.CancelFuturesOrder(settle, order.Id.ToString());
                Console.WriteLine("order {0} cancelled", order.Id);
            }
            else
            {
                List<MyFuturesTrade> orderTrades = futuresApi.GetMyTrades(settle, contract, orderResponse.Id);
                Debug.Assert(orderTrades.Count > 0);
                long tradeSize = 0L;
                foreach (MyFuturesTrade t in orderTrades)
                {
                    Debug.Assert(t.OrderId != null && t.OrderId.Equals(orderResponse.Id.ToString()));
                    tradeSize += t.Size;
                    Console.WriteLine("order {0} filled size {1} with price {2}", t.OrderId, t.Size, t.Price);
                }
                Debug.Assert(tradeSize == orderSize);
                
                // example to update position margin
                futuresApi.UpdatePositionMargin(settle, contract, "0.01");
            }
        }
        
    }
}