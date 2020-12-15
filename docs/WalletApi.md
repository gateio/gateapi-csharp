# Io.Gate.GateApi.Api.WalletApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDepositAddress**](WalletApi.md#getdepositaddress) | **GET** /wallet/deposit_address | Generate currency deposit address
[**ListWithdrawals**](WalletApi.md#listwithdrawals) | **GET** /wallet/withdrawals | Retrieve withdrawal records
[**ListDeposits**](WalletApi.md#listdeposits) | **GET** /wallet/deposits | Retrieve deposit records
[**Transfer**](WalletApi.md#transfer) | **POST** /wallet/transfers | Transfer between trading accounts
[**ListSubAccountTransfers**](WalletApi.md#listsubaccounttransfers) | **GET** /wallet/sub_account_transfers | Transfer records between main and sub accounts
[**TransferWithSubAccount**](WalletApi.md#transferwithsubaccount) | **POST** /wallet/sub_account_transfers | Transfer between main and sub accounts
[**ListWithdrawStatus**](WalletApi.md#listwithdrawstatus) | **GET** /wallet/withdraw_status | Retrieve withdrawal status
[**ListSubAccountBalances**](WalletApi.md#listsubaccountbalances) | **GET** /wallet/sub_account_balances | Retrieve sub account balances


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
            var currency = "currency_example";  // string | Currency name

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
> List&lt;LedgerRecord&gt; ListWithdrawals (string currency = null, long? from = null, long? to = null, int? limit = null, int? offset = null)

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
            var limit = 100;  // int? | Maximum number of records returned in one list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)

            try
            {
                // Retrieve withdrawal records
                List<LedgerRecord> result = apiInstance.ListWithdrawals(currency, from, to, limit, offset);
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
 **limit** | **int?**| Maximum number of records returned in one list | [optional] [default to 100]
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
            var limit = 100;  // int? | Maximum number of records returned in one list (optional)  (default to 100)
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
 **limit** | **int?**| Maximum number of records returned in one list | [optional] [default to 100]
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
> void Transfer (Transfer transfer)

Transfer between trading accounts

Transfer between different accounts. Currently support transfers between the following:  1. spot - margin 2. spot - futures(perpetual) 3. spot - delivery

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
                apiInstance.Transfer(transfer);
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

void (empty response body)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Balance transferred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsubaccounttransfers"></a>
# **ListSubAccountTransfers**
> List&lt;SubAccountTransfer&gt; ListSubAccountTransfers (string subUid = null, long? from = null, long? to = null, int? limit = null, int? offset = null)

Transfer records between main and sub accounts

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
            var subUid = "10003";  // string | Sub account user ID. Return records related to all sub accounts if not specified (optional) 
            var from = 1602120000;  // long? | Time range beginning, default to 7 days before current time (optional) 
            var to = 1602123600;  // long? | Time range ending, default to current time (optional) 
            var limit = 100;  // int? | Maximum number of records returned in one list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)

            try
            {
                // Transfer records between main and sub accounts
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
 **subUid** | **string**| Sub account user ID. Return records related to all sub accounts if not specified | [optional] 
 **from** | **long?**| Time range beginning, default to 7 days before current time | [optional] 
 **to** | **long?**| Time range ending, default to current time | [optional] 
 **limit** | **int?**| Maximum number of records returned in one list | [optional] [default to 100]
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
> void TransferWithSubAccount (SubAccountTransfer subAccountTransfer)

Transfer between main and sub accounts

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
                apiInstance.TransferWithSubAccount(subAccountTransfer);
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

void (empty response body)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Balance transferred |  -  |

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
            var currency = "BTC";  // string | Retrieved specified currency related data (optional) 

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
 **currency** | **string**| Retrieved specified currency related data | [optional] 

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
            var subUid = "10003";  // string | Sub account user ID. Return records related to all sub accounts if not specified (optional) 

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
 **subUid** | **string**| Sub account user ID. Return records related to all sub accounts if not specified | [optional] 

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

