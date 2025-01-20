# Io.Gate.GateApi.Api.WalletApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListCurrencyChains**](WalletApi.md#listcurrencychains) | **GET** /wallet/currency_chains | List chains supported for specified currency
[**GetDepositAddress**](WalletApi.md#getdepositaddress) | **GET** /wallet/deposit_address | Generate currency deposit address
[**ListWithdrawals**](WalletApi.md#listwithdrawals) | **GET** /wallet/withdrawals | Retrieve withdrawal records
[**ListDeposits**](WalletApi.md#listdeposits) | **GET** /wallet/deposits | Retrieve deposit records
[**Transfer**](WalletApi.md#transfer) | **POST** /wallet/transfers | Transfer between trading accounts
[**ListSubAccountTransfers**](WalletApi.md#listsubaccounttransfers) | **GET** /wallet/sub_account_transfers | Retrieve transfer records between main and sub accounts
[**TransferWithSubAccount**](WalletApi.md#transferwithsubaccount) | **POST** /wallet/sub_account_transfers | Transfer between main and sub accounts
[**SubAccountToSubAccount**](WalletApi.md#subaccounttosubaccount) | **POST** /wallet/sub_account_to_sub_account | Sub-account transfers to sub-account
[**GetTransferOrderStatus**](WalletApi.md#gettransferorderstatus) | **GET** /wallet/order_status | Transfer status query
[**ListWithdrawStatus**](WalletApi.md#listwithdrawstatus) | **GET** /wallet/withdraw_status | Retrieve withdrawal status
[**ListSubAccountBalances**](WalletApi.md#listsubaccountbalances) | **GET** /wallet/sub_account_balances | Retrieve sub account balances
[**ListSubAccountMarginBalances**](WalletApi.md#listsubaccountmarginbalances) | **GET** /wallet/sub_account_margin_balances | Query sub accounts&#39; margin balances
[**ListSubAccountFuturesBalances**](WalletApi.md#listsubaccountfuturesbalances) | **GET** /wallet/sub_account_futures_balances | Query sub accounts&#39; futures account balances
[**ListSubAccountCrossMarginBalances**](WalletApi.md#listsubaccountcrossmarginbalances) | **GET** /wallet/sub_account_cross_margin_balances | Query subaccount&#39;s cross_margin account info
[**ListSavedAddress**](WalletApi.md#listsavedaddress) | **GET** /wallet/saved_address | Query saved address
[**GetTradeFee**](WalletApi.md#gettradefee) | **GET** /wallet/fee | Retrieve personal trading fee
[**GetTotalBalance**](WalletApi.md#gettotalbalance) | **GET** /wallet/total_balance | Retrieve user&#39;s total balances
[**ListSmallBalance**](WalletApi.md#listsmallbalance) | **GET** /wallet/small_balance | List small balance
[**ConvertSmallBalance**](WalletApi.md#convertsmallbalance) | **POST** /wallet/small_balance | Convert small balance
[**ListSmallBalanceHistory**](WalletApi.md#listsmallbalancehistory) | **GET** /wallet/small_balance_history | List small balance history
[**ListPushOrders**](WalletApi.md#listpushorders) | **GET** /wallet/push | Retrieve the UID transfer history


<a name="listcurrencychains"></a>
# **ListCurrencyChains**
> List&lt;CurrencyChain&gt; ListCurrencyChains (string currency)

List chains supported for specified currency

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListCurrencyChainsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new WalletApi(config);
            var currency = "GT";  // string | Currency name

            try
            {
                // List chains supported for specified currency
                List<CurrencyChain> result = apiInstance.ListCurrencyChains(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListCurrencyChains: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Currency name | 

### Return type

[**List&lt;CurrencyChain&gt;**](CurrencyChain.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdepositaddress"></a>
# **GetDepositAddress**
> DepositAddress GetDepositAddress (string currency)

Generate currency deposit address

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetDepositAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var currency = "USDT";  // string | Currency name

            try
            {
                // Generate currency deposit address
                DepositAddress result = apiInstance.GetDepositAddress(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.GetDepositAddress: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Currency name | 

### Return type

[**DepositAddress**](DepositAddress.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Address successfully generated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listwithdrawals"></a>
# **ListWithdrawals**
> List&lt;WithdrawalRecord&gt; ListWithdrawals (string currency = null, long? from = null, long? to = null, int? limit = null, int? offset = null)

Retrieve withdrawal records

Record time range cannot exceed 30 days

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListWithdrawalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var currency = "BTC";  // string | Filter by currency. Return all currency records if not specified (optional) 
            var from = 1602120000;  // long? | Time range beginning, default to 7 days before current time (optional) 
            var to = 1602123600;  // long? | Time range ending, default to current time (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)

            try
            {
                // Retrieve withdrawal records
                List<WithdrawalRecord> result = apiInstance.ListWithdrawals(currency, from, to, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListWithdrawals: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Filter by currency. Return all currency records if not specified | [optional] 
 **from** | **long?**| Time range beginning, default to 7 days before current time | [optional] 
 **to** | **long?**| Time range ending, default to current time | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]

### Return type

[**List&lt;WithdrawalRecord&gt;**](WithdrawalRecord.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdeposits"></a>
# **ListDeposits**
> List&lt;LedgerRecord&gt; ListDeposits (string currency = null, long? from = null, long? to = null, int? limit = null, int? offset = null)

Retrieve deposit records

Record time range cannot exceed 30 days

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListDepositsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var currency = "BTC";  // string | Filter by currency. Return all currency records if not specified (optional) 
            var from = 1602120000;  // long? | Time range beginning, default to 7 days before current time (optional) 
            var to = 1602123600;  // long? | Time range ending, default to current time (optional) 
            var limit = 100;  // int? | The maximum number of entries returned in the list is limited to 500 transactions. (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)

            try
            {
                // Retrieve deposit records
                List<LedgerRecord> result = apiInstance.ListDeposits(currency, from, to, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListDeposits: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Filter by currency. Return all currency records if not specified | [optional] 
 **from** | **long?**| Time range beginning, default to 7 days before current time | [optional] 
 **to** | **long?**| Time range ending, default to current time | [optional] 
 **limit** | **int?**| The maximum number of entries returned in the list is limited to 500 transactions. | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]

### Return type

[**List&lt;LedgerRecord&gt;**](LedgerRecord.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transfer"></a>
# **Transfer**
> TransactionID Transfer (Transfer transfer)

Transfer between trading accounts

Transfer between different accounts. Currently support transfers between the following:  1. spot - margin 2. spot - futures(perpetual) 3. spot - delivery 4. spot - options

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class TransferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var transfer = new Transfer(); // Transfer | 

            try
            {
                // Transfer between trading accounts
                TransactionID result = apiInstance.Transfer(transfer);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.Transfer: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transfer** | [**Transfer**](Transfer.md)|  | 

### Return type

[**TransactionID**](TransactionID.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Balance transferred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsubaccounttransfers"></a>
# **ListSubAccountTransfers**
> List&lt;SubAccountTransfer&gt; ListSubAccountTransfers (string subUid = null, long? from = null, long? to = null, int? limit = null, int? offset = null)

Retrieve transfer records between main and sub accounts

Record time range cannot exceed 30 days  > Note: only records after 2020-04-10 can be retrieved

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSubAccountTransfersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var subUid = "10003";  // string | User ID of sub-account, you can query multiple records separated by `,`. If not specified, it will return the records of all sub accounts (optional) 
            var from = 1602120000;  // long? | Time range beginning, default to 7 days before current time (optional) 
            var to = 1602123600;  // long? | Time range ending, default to current time (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)

            try
            {
                // Retrieve transfer records between main and sub accounts
                List<SubAccountTransfer> result = apiInstance.ListSubAccountTransfers(subUid, from, to, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListSubAccountTransfers: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subUid** | **string**| User ID of sub-account, you can query multiple records separated by &#x60;,&#x60;. If not specified, it will return the records of all sub accounts | [optional] 
 **from** | **long?**| Time range beginning, default to 7 days before current time | [optional] 
 **to** | **long?**| Time range ending, default to current time | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]

### Return type

[**List&lt;SubAccountTransfer&gt;**](SubAccountTransfer.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transferwithsubaccount"></a>
# **TransferWithSubAccount**
> TransactionID TransferWithSubAccount (SubAccountTransfer subAccountTransfer)

Transfer between main and sub accounts

Support transferring with sub user's spot or futures account. Note that only main user's spot account is used no matter which sub user's account is operated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class TransferWithSubAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var subAccountTransfer = new SubAccountTransfer(); // SubAccountTransfer | 

            try
            {
                // Transfer between main and sub accounts
                TransactionID result = apiInstance.TransferWithSubAccount(subAccountTransfer);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.TransferWithSubAccount: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subAccountTransfer** | [**SubAccountTransfer**](SubAccountTransfer.md)|  | 

### Return type

[**TransactionID**](TransactionID.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Balance transferred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subaccounttosubaccount"></a>
# **SubAccountToSubAccount**
> TransactionID SubAccountToSubAccount (SubAccountToSubAccount subAccountToSubAccount)

Sub-account transfers to sub-account

It is possible to perform balance transfers between two sub-accounts under the same main account. You can use either the API Key of the main account or the API Key of the sub-account to initiate the transfer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class SubAccountToSubAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var subAccountToSubAccount = new SubAccountToSubAccount(); // SubAccountToSubAccount | 

            try
            {
                // Sub-account transfers to sub-account
                TransactionID result = apiInstance.SubAccountToSubAccount(subAccountToSubAccount);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.SubAccountToSubAccount: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subAccountToSubAccount** | [**SubAccountToSubAccount**](SubAccountToSubAccount.md)|  | 

### Return type

[**TransactionID**](TransactionID.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Balance transferred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransferorderstatus"></a>
# **GetTransferOrderStatus**
> InlineResponse200 GetTransferOrderStatus (string clientOrderId = null, string txId = null)

Transfer status query

Support querying transfer status based on user-defined client_order_id or tx_id returned by the transfer interface

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetTransferOrderStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var clientOrderId = "da3ce7a088c8b0372b741419c7829033";  // string | The custom ID provided by the customer serves as a safeguard against duplicate transfers. It can be a combination of letters (case-sensitive), numbers, hyphens '-', and underscores '_', with a length ranging from 1 to 64 characters. (optional) 
            var txId = "59636381286";  // string | The transfer operation number and client_order_id cannot be empty at the same time (optional) 

            try
            {
                // Transfer status query
                InlineResponse200 result = apiInstance.GetTransferOrderStatus(clientOrderId, txId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.GetTransferOrderStatus: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientOrderId** | **string**| The custom ID provided by the customer serves as a safeguard against duplicate transfers. It can be a combination of letters (case-sensitive), numbers, hyphens &#39;-&#39;, and underscores &#39;_&#39;, with a length ranging from 1 to 64 characters. | [optional] 
 **txId** | **string**| The transfer operation number and client_order_id cannot be empty at the same time | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Transfer status obtained successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listwithdrawstatus"></a>
# **ListWithdrawStatus**
> List&lt;WithdrawStatus&gt; ListWithdrawStatus (string currency = null)

Retrieve withdrawal status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListWithdrawStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var currency = "BTC";  // string | Retrieve data of the specified currency (optional) 

            try
            {
                // Retrieve withdrawal status
                List<WithdrawStatus> result = apiInstance.ListWithdrawStatus(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListWithdrawStatus: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Retrieve data of the specified currency | [optional] 

### Return type

[**List&lt;WithdrawStatus&gt;**](WithdrawStatus.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsubaccountbalances"></a>
# **ListSubAccountBalances**
> List&lt;SubAccountBalance&gt; ListSubAccountBalances (string subUid = null)

Retrieve sub account balances

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSubAccountBalancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var subUid = "10003";  // string | User ID of sub-account, you can query multiple records separated by `,`. If not specified, it will return the records of all sub accounts (optional) 

            try
            {
                // Retrieve sub account balances
                List<SubAccountBalance> result = apiInstance.ListSubAccountBalances(subUid);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListSubAccountBalances: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subUid** | **string**| User ID of sub-account, you can query multiple records separated by &#x60;,&#x60;. If not specified, it will return the records of all sub accounts | [optional] 

### Return type

[**List&lt;SubAccountBalance&gt;**](SubAccountBalance.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsubaccountmarginbalances"></a>
# **ListSubAccountMarginBalances**
> List&lt;SubAccountMarginBalance&gt; ListSubAccountMarginBalances (string subUid = null)

Query sub accounts' margin balances

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSubAccountMarginBalancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var subUid = "10003";  // string | User ID of sub-account, you can query multiple records separated by `,`. If not specified, it will return the records of all sub accounts (optional) 

            try
            {
                // Query sub accounts' margin balances
                List<SubAccountMarginBalance> result = apiInstance.ListSubAccountMarginBalances(subUid);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListSubAccountMarginBalances: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subUid** | **string**| User ID of sub-account, you can query multiple records separated by &#x60;,&#x60;. If not specified, it will return the records of all sub accounts | [optional] 

### Return type

[**List&lt;SubAccountMarginBalance&gt;**](SubAccountMarginBalance.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsubaccountfuturesbalances"></a>
# **ListSubAccountFuturesBalances**
> List&lt;SubAccountFuturesBalance&gt; ListSubAccountFuturesBalances (string subUid = null, string settle = null)

Query sub accounts' futures account balances

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSubAccountFuturesBalancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var subUid = "10003";  // string | User ID of sub-account, you can query multiple records separated by `,`. If not specified, it will return the records of all sub accounts (optional) 
            var settle = "usdt";  // string | Query only balances of specified settle currency (optional) 

            try
            {
                // Query sub accounts' futures account balances
                List<SubAccountFuturesBalance> result = apiInstance.ListSubAccountFuturesBalances(subUid, settle);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListSubAccountFuturesBalances: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subUid** | **string**| User ID of sub-account, you can query multiple records separated by &#x60;,&#x60;. If not specified, it will return the records of all sub accounts | [optional] 
 **settle** | **string**| Query only balances of specified settle currency | [optional] 

### Return type

[**List&lt;SubAccountFuturesBalance&gt;**](SubAccountFuturesBalance.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsubaccountcrossmarginbalances"></a>
# **ListSubAccountCrossMarginBalances**
> List&lt;SubAccountCrossMarginBalance&gt; ListSubAccountCrossMarginBalances (string subUid = null)

Query subaccount's cross_margin account info

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSubAccountCrossMarginBalancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var subUid = "10003";  // string | User ID of sub-account, you can query multiple records separated by `,`. If not specified, it will return the records of all sub accounts (optional) 

            try
            {
                // Query subaccount's cross_margin account info
                List<SubAccountCrossMarginBalance> result = apiInstance.ListSubAccountCrossMarginBalances(subUid);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListSubAccountCrossMarginBalances: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subUid** | **string**| User ID of sub-account, you can query multiple records separated by &#x60;,&#x60;. If not specified, it will return the records of all sub accounts | [optional] 

### Return type

[**List&lt;SubAccountCrossMarginBalance&gt;**](SubAccountCrossMarginBalance.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsavedaddress"></a>
# **ListSavedAddress**
> List&lt;SavedAddress&gt; ListSavedAddress (string currency, string chain = null, string limit = null, int? page = null)

Query saved address

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSavedAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var currency = "USDT";  // string | Currency
            var chain = "\"\"";  // string | Chain name (optional)  (default to "")
            var limit = "\"50\"";  // string | Maximum number returned, 100 at most (optional)  (default to "50")
            var page = 1;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Query saved address
                List<SavedAddress> result = apiInstance.ListSavedAddress(currency, chain, limit, page);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListSavedAddress: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Currency | 
 **chain** | **string**| Chain name | [optional] [default to &quot;&quot;]
 **limit** | **string**| Maximum number returned, 100 at most | [optional] [default to &quot;50&quot;]
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**List&lt;SavedAddress&gt;**](SavedAddress.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettradefee"></a>
# **GetTradeFee**
> TradeFee GetTradeFee (string currencyPair = null, string settle = null)

Retrieve personal trading fee

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetTradeFeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var currencyPair = "BTC_USDT";  // string | Specify a currency pair to retrieve precise fee rate  This field is optional. In most cases, the fee rate is identical among all currency pairs (optional) 
            var settle = "BTC";  // string | Specify the settlement currency of the contract to get more accurate rate settings  This field is optional. Generally, the rate settings for all settlement currencies are the same. (optional) 

            try
            {
                // Retrieve personal trading fee
                TradeFee result = apiInstance.GetTradeFee(currencyPair, settle);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.GetTradeFee: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currencyPair** | **string**| Specify a currency pair to retrieve precise fee rate  This field is optional. In most cases, the fee rate is identical among all currency pairs | [optional] 
 **settle** | **string**| Specify the settlement currency of the contract to get more accurate rate settings  This field is optional. Generally, the rate settings for all settlement currencies are the same. | [optional] 

### Return type

[**TradeFee**](TradeFee.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettotalbalance"></a>
# **GetTotalBalance**
> TotalBalance GetTotalBalance (string currency = null)

Retrieve user's total balances

This endpoint returns an approximate sum of exchanged amount from all currencies to input currency for each account.The exchange rate and account balance could have been cached for at most 1 minute. It is not recommended to use its result for any trading calculation.  For trading calculation, use the corresponding account query endpoint for each account type. For example:   - `GET /spot/accounts` to query spot account balance - `GET /margin/accounts` to query margin account balance - `GET /futures/{settle}/accounts` to query futures account balance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetTotalBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var currency = "\"USDT\"";  // string | Currency unit used to calculate the balance amount. BTC, CNY, USD and USDT are allowed. USDT is the default. (optional)  (default to "USDT")

            try
            {
                // Retrieve user's total balances
                TotalBalance result = apiInstance.GetTotalBalance(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.GetTotalBalance: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Currency unit used to calculate the balance amount. BTC, CNY, USD and USDT are allowed. USDT is the default. | [optional] [default to &quot;USDT&quot;]

### Return type

[**TotalBalance**](TotalBalance.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request is valid and is successfully responded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsmallbalance"></a>
# **ListSmallBalance**
> List&lt;SmallBalance&gt; ListSmallBalance ()

List small balance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSmallBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);

            try
            {
                // List small balance
                List<SmallBalance> result = apiInstance.ListSmallBalance();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListSmallBalance: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;SmallBalance&gt;**](SmallBalance.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertsmallbalance"></a>
# **ConvertSmallBalance**
> void ConvertSmallBalance (ConvertSmallBalance convertSmallBalance)

Convert small balance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ConvertSmallBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var convertSmallBalance = new ConvertSmallBalance(); // ConvertSmallBalance | 

            try
            {
                // Convert small balance
                apiInstance.ConvertSmallBalance(convertSmallBalance);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ConvertSmallBalance: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **convertSmallBalance** | [**ConvertSmallBalance**](ConvertSmallBalance.md)|  | 

### Return type

void (empty response body)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsmallbalancehistory"></a>
# **ListSmallBalanceHistory**
> List&lt;SmallBalanceHistory&gt; ListSmallBalanceHistory (string currency = null, int? page = null, int? limit = null)

List small balance history

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSmallBalanceHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var currency = "currency_example";  // string | Currency (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum response items.  Default: 100, minimum: 1, Maximum: 100 (optional)  (default to 100)

            try
            {
                // List small balance history
                List<SmallBalanceHistory> result = apiInstance.ListSmallBalanceHistory(currency, page, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListSmallBalanceHistory: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Currency | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum response items.  Default: 100, minimum: 1, Maximum: 100 | [optional] [default to 100]

### Return type

[**List&lt;SmallBalanceHistory&gt;**](SmallBalanceHistory.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpushorders"></a>
# **ListPushOrders**
> List&lt;UidPushOrder&gt; ListPushOrders (int? id = null, int? from = null, int? to = null, int? limit = null, int? offset = null, string transactionType = null)

Retrieve the UID transfer history

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListPushOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var id = 56;  // int? | Order ID (optional) 
            var from = 56;  // int? | The start time of the query record. If not specified, it defaults to 7 days forward from the current time, in seconds Unix timestamp (optional) 
            var to = 56;  // int? | The end time of the query record. If not specified, the default is the current time, which is a Unix timestamp in seconds. (optional) 
            var limit = 100;  // int? | The maximum number of items returned in the list, the default value is 100 (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var transactionType = "\"withdraw\"";  // string | The list returns the order type `withdraw`, `deposit`, the default is `withdraw`. (optional)  (default to "withdraw")

            try
            {
                // Retrieve the UID transfer history
                List<UidPushOrder> result = apiInstance.ListPushOrders(id, from, to, limit, offset, transactionType);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListPushOrders: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Order ID | [optional] 
 **from** | **int?**| The start time of the query record. If not specified, it defaults to 7 days forward from the current time, in seconds Unix timestamp | [optional] 
 **to** | **int?**| The end time of the query record. If not specified, the default is the current time, which is a Unix timestamp in seconds. | [optional] 
 **limit** | **int?**| The maximum number of items returned in the list, the default value is 100 | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **transactionType** | **string**| The list returns the order type &#x60;withdraw&#x60;, &#x60;deposit&#x60;, the default is &#x60;withdraw&#x60;. | [optional] [default to &quot;withdraw&quot;]

### Return type

[**List&lt;UidPushOrder&gt;**](UidPushOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

