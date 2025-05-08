# Io.Gate.GateApi.Api.WithdrawalApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Withdraw**](WithdrawalApi.md#withdraw) | **POST** /withdrawals | Withdraw
[**WithdrawPushOrder**](WithdrawalApi.md#withdrawpushorder) | **POST** /withdrawals/push | UID transfer
[**CancelWithdrawal**](WithdrawalApi.md#cancelwithdrawal) | **DELETE** /withdrawals/{withdrawal_id} | Cancel withdrawal with specified ID


<a name="withdraw"></a>
# **Withdraw**
> LedgerRecord Withdraw (LedgerRecord ledgerRecord)

Withdraw

Withdrawals to Gate addresses do not incur transaction fees.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class WithdrawExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WithdrawalApi(config);
            var ledgerRecord = new LedgerRecord(); // LedgerRecord | 

            try
            {
                // Withdraw
                LedgerRecord result = apiInstance.Withdraw(ledgerRecord);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WithdrawalApi.Withdraw: " + e.Message);
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
 **ledgerRecord** | [**LedgerRecord**](LedgerRecord.md)|  | 

### Return type

[**LedgerRecord**](LedgerRecord.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Withdraw request is accepted. Refer to withdrawal records for status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="withdrawpushorder"></a>
# **WithdrawPushOrder**
> UidPushWithdrawalResp WithdrawPushOrder (UidPushWithdrawal uidPushWithdrawal)

UID transfer

Transfers between main spot accounts are allowed; however, both parties cannot be sub-accounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class WithdrawPushOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WithdrawalApi(config);
            var uidPushWithdrawal = new UidPushWithdrawal(); // UidPushWithdrawal | 

            try
            {
                // UID transfer
                UidPushWithdrawalResp result = apiInstance.WithdrawPushOrder(uidPushWithdrawal);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WithdrawalApi.WithdrawPushOrder: " + e.Message);
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
 **uidPushWithdrawal** | [**UidPushWithdrawal**](UidPushWithdrawal.md)|  | 

### Return type

[**UidPushWithdrawalResp**](UidPushWithdrawalResp.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been accepted. Check the withdrawal record status for the processing result. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelwithdrawal"></a>
# **CancelWithdrawal**
> LedgerRecord CancelWithdrawal (string withdrawalId)

Cancel withdrawal with specified ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelWithdrawalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WithdrawalApi(config);
            var withdrawalId = "210496";  // string | 

            try
            {
                // Cancel withdrawal with specified ID
                LedgerRecord result = apiInstance.CancelWithdrawal(withdrawalId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WithdrawalApi.CancelWithdrawal: " + e.Message);
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
 **withdrawalId** | **string**|  | 

### Return type

[**LedgerRecord**](LedgerRecord.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Cancellation accepted. Refer to record status for the cancellation result |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

