# Io.Gate.GateApi.Api.AccountApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAccountDetail**](AccountApi.md#getaccountdetail) | **GET** /account/detail | Get account detail.
[**GetAccountRateLimit**](AccountApi.md#getaccountratelimit) | **GET** /account/rate_limit | Get user transaction rate limit information.
[**ListSTPGroups**](AccountApi.md#liststpgroups) | **GET** /account/stp_groups | List STP Groups.
[**CreateSTPGroup**](AccountApi.md#createstpgroup) | **POST** /account/stp_groups | Create STP Group.
[**ListSTPGroupsUsers**](AccountApi.md#liststpgroupsusers) | **GET** /account/stp_groups/{stp_id}/users | List users of the STP group.
[**AddSTPGroupUsers**](AccountApi.md#addstpgroupusers) | **POST** /account/stp_groups/{stp_id}/users | Add users to the STP group.
[**DeleteSTPGroupUsers**](AccountApi.md#deletestpgroupusers) | **DELETE** /account/stp_groups/{stp_id}/users | Delete the user in the STP group.
[**GetDebitFee**](AccountApi.md#getdebitfee) | **GET** /account/debit_fee | Query GT deduction configuration.
[**SetDebitFee**](AccountApi.md#setdebitfee) | **POST** /account/debit_fee | Set GT deduction.


<a name="getaccountdetail"></a>
# **GetAccountDetail**
> AccountDetail GetAccountDetail ()

Get account detail.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetAccountDetailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new AccountApi(config);

            try
            {
                // Get account detail.
                AccountDetail result = apiInstance.GetAccountDetail();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AccountApi.GetAccountDetail: " + e.Message);
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

[**AccountDetail**](AccountDetail.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountratelimit"></a>
# **GetAccountRateLimit**
> List&lt;AccountRateLimit&gt; GetAccountRateLimit ()

Get user transaction rate limit information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetAccountRateLimitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new AccountApi(config);

            try
            {
                // Get user transaction rate limit information.
                List<AccountRateLimit> result = apiInstance.GetAccountRateLimit();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AccountApi.GetAccountRateLimit: " + e.Message);
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

[**List&lt;AccountRateLimit&gt;**](AccountRateLimit.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="liststpgroups"></a>
# **ListSTPGroups**
> List&lt;StpGroup&gt; ListSTPGroups (string name = null)

List STP Groups.

Retrieve the list of STP groups created by the main account user only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSTPGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new AccountApi(config);
            var name = "group";  // string | Perform a fuzzy search based on the name. (optional) 

            try
            {
                // List STP Groups.
                List<StpGroup> result = apiInstance.ListSTPGroups(name);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AccountApi.ListSTPGroups: " + e.Message);
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
 **name** | **string**| Perform a fuzzy search based on the name. | [optional] 

### Return type

[**List&lt;StpGroup&gt;**](StpGroup.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createstpgroup"></a>
# **CreateSTPGroup**
> StpGroup CreateSTPGroup (StpGroup stpGroup)

Create STP Group.

Only the main account is allowed to create a new STP user group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateSTPGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new AccountApi(config);
            var stpGroup = new StpGroup(); // StpGroup | 

            try
            {
                // Create STP Group.
                StpGroup result = apiInstance.CreateSTPGroup(stpGroup);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AccountApi.CreateSTPGroup: " + e.Message);
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
 **stpGroup** | [**StpGroup**](StpGroup.md)|  | 

### Return type

[**StpGroup**](StpGroup.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User added successfully. Returning the current users within the STP group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="liststpgroupsusers"></a>
# **ListSTPGroupsUsers**
> List&lt;StpGroupUser&gt; ListSTPGroupsUsers (long stpId)

List users of the STP group.

Only the main account that created this STP group can query the account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSTPGroupsUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new AccountApi(config);
            var stpId = 1;  // long | STP Group ID.

            try
            {
                // List users of the STP group.
                List<StpGroupUser> result = apiInstance.ListSTPGroupsUsers(stpId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AccountApi.ListSTPGroupsUsers: " + e.Message);
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
 **stpId** | **long**| STP Group ID. | 

### Return type

[**List&lt;StpGroupUser&gt;**](StpGroupUser.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addstpgroupusers"></a>
# **AddSTPGroupUsers**
> List&lt;StpGroupUser&gt; AddSTPGroupUsers (long stpId, List<long> requestBody)

Add users to the STP group.

- Only the master account that created the STP user group is allowed to add users group.- Only accounts under the main account are allowed to be added. Cross-account is not permitted

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class AddSTPGroupUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new AccountApi(config);
            var stpId = 1;  // long | STP Group ID.
            var requestBody = new List<long>(); // List<long> | User ID.

            try
            {
                // Add users to the STP group.
                List<StpGroupUser> result = apiInstance.AddSTPGroupUsers(stpId, requestBody);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AccountApi.AddSTPGroupUsers: " + e.Message);
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
 **stpId** | **long**| STP Group ID. | 
 **requestBody** | [**List&lt;long&gt;**](long.md)| User ID. | 

### Return type

[**List&lt;StpGroupUser&gt;**](StpGroupUser.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User added successfully. Returning the current users within the STP group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletestpgroupusers"></a>
# **DeleteSTPGroupUsers**
> List&lt;StpGroupUser&gt; DeleteSTPGroupUsers (long stpId, long userId)

Delete the user in the STP group.

- Only the main account that created this STP group is allowed to delete users from the STP user group - Deletion is limited to accounts under the current main account; cross-account deletion is not permitted

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class DeleteSTPGroupUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new AccountApi(config);
            var stpId = 1;  // long | STP Group ID.
            var userId = 1;  // long | STP user ID, multiple can be separated by commas.

            try
            {
                // Delete the user in the STP group.
                List<StpGroupUser> result = apiInstance.DeleteSTPGroupUsers(stpId, userId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AccountApi.DeleteSTPGroupUsers: " + e.Message);
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
 **stpId** | **long**| STP Group ID. | 
 **userId** | **long**| STP user ID, multiple can be separated by commas. | 

### Return type

[**List&lt;StpGroupUser&gt;**](StpGroupUser.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdebitfee"></a>
# **GetDebitFee**
> DebitFee GetDebitFee ()

Query GT deduction configuration.

Query the current GT deduction configuration for the account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetDebitFeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new AccountApi(config);

            try
            {
                // Query GT deduction configuration.
                DebitFee result = apiInstance.GetDebitFee();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AccountApi.GetDebitFee: " + e.Message);
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

[**DebitFee**](DebitFee.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setdebitfee"></a>
# **SetDebitFee**
> void SetDebitFee (DebitFee debitFee)

Set GT deduction.

Enable or disable GT deduction for the current account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class SetDebitFeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new AccountApi(config);
            var debitFee = new DebitFee(); // DebitFee | 

            try
            {
                // Set GT deduction.
                apiInstance.SetDebitFee(debitFee);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AccountApi.SetDebitFee: " + e.Message);
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
 **debitFee** | [**DebitFee**](DebitFee.md)|  | 

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
| **200** | Success. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

