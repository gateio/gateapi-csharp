# Io.Gate.GateApi.Api.SubAccountApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListSubAccounts**](SubAccountApi.md#listsubaccounts) | **GET** /sub_accounts | List sub-accounts
[**CreateSubAccounts**](SubAccountApi.md#createsubaccounts) | **POST** /sub_accounts | Create a new sub-account
[**GetSubAccount**](SubAccountApi.md#getsubaccount) | **GET** /sub_accounts/{user_id} | Get the sub-account
[**ListSubAccountKeys**](SubAccountApi.md#listsubaccountkeys) | **GET** /sub_accounts/{user_id}/keys | List all API Key of the sub-account
[**CreateSubAccountKeys**](SubAccountApi.md#createsubaccountkeys) | **POST** /sub_accounts/{user_id}/keys | Create API Key of the sub-account
[**GetSubAccountKey**](SubAccountApi.md#getsubaccountkey) | **GET** /sub_accounts/{user_id}/keys/{key} | Get the API Key of the sub-account
[**UpdateSubAccountKeys**](SubAccountApi.md#updatesubaccountkeys) | **PUT** /sub_accounts/{user_id}/keys/{key} | Update API key of the sub-account
[**DeleteSubAccountKeys**](SubAccountApi.md#deletesubaccountkeys) | **DELETE** /sub_accounts/{user_id}/keys/{key} | Delete API key of the sub-account
[**LockSubAccount**](SubAccountApi.md#locksubaccount) | **POST** /sub_accounts/{user_id}/lock | Lock the sub-account
[**UnlockSubAccount**](SubAccountApi.md#unlocksubaccount) | **POST** /sub_accounts/{user_id}/unlock | Unlock the sub-account


<a name="listsubaccounts"></a>
# **ListSubAccounts**
> List&lt;SubAccount&gt; ListSubAccounts ()

List sub-accounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSubAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SubAccountApi(config);

            try
            {
                // List sub-accounts
                List<SubAccount> result = apiInstance.ListSubAccounts();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SubAccountApi.ListSubAccounts: " + e.Message);
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

[**List&lt;SubAccount&gt;**](SubAccount.md)

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

<a name="createsubaccounts"></a>
# **CreateSubAccounts**
> SubAccount CreateSubAccounts (SubAccount subAccount)

Create a new sub-account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateSubAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SubAccountApi(config);
            var subAccount = new SubAccount(); // SubAccount | 

            try
            {
                // Create a new sub-account
                SubAccount result = apiInstance.CreateSubAccounts(subAccount);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SubAccountApi.CreateSubAccounts: " + e.Message);
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
 **subAccount** | [**SubAccount**](SubAccount.md)|  | 

### Return type

[**SubAccount**](SubAccount.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created Successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubaccount"></a>
# **GetSubAccount**
> SubAccount GetSubAccount (long userId)

Get the sub-account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetSubAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SubAccountApi(config);
            var userId = 56;  // long | Sub-account user id

            try
            {
                // Get the sub-account
                SubAccount result = apiInstance.GetSubAccount(userId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SubAccountApi.GetSubAccount: " + e.Message);
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
 **userId** | **long**| Sub-account user id | 

### Return type

[**SubAccount**](SubAccount.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsubaccountkeys"></a>
# **ListSubAccountKeys**
> List&lt;SubAccountKey&gt; ListSubAccountKeys (int userId)

List all API Key of the sub-account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSubAccountKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SubAccountApi(config);
            var userId = 56;  // int | Sub-account user id

            try
            {
                // List all API Key of the sub-account
                List<SubAccountKey> result = apiInstance.ListSubAccountKeys(userId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SubAccountApi.ListSubAccountKeys: " + e.Message);
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
 **userId** | **int**| Sub-account user id | 

### Return type

[**List&lt;SubAccountKey&gt;**](SubAccountKey.md)

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

<a name="createsubaccountkeys"></a>
# **CreateSubAccountKeys**
> List&lt;SubAccountKey&gt; CreateSubAccountKeys (long userId, SubAccountKey subAccountKey)

Create API Key of the sub-account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateSubAccountKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SubAccountApi(config);
            var userId = 56;  // long | Sub-account user id
            var subAccountKey = new SubAccountKey(); // SubAccountKey | 

            try
            {
                // Create API Key of the sub-account
                List<SubAccountKey> result = apiInstance.CreateSubAccountKeys(userId, subAccountKey);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SubAccountApi.CreateSubAccountKeys: " + e.Message);
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
 **userId** | **long**| Sub-account user id | 
 **subAccountKey** | [**SubAccountKey**](SubAccountKey.md)|  | 

### Return type

[**List&lt;SubAccountKey&gt;**](SubAccountKey.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Created Successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubaccountkey"></a>
# **GetSubAccountKey**
> SubAccountKey GetSubAccountKey (int userId, string key)

Get the API Key of the sub-account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetSubAccountKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SubAccountApi(config);
            var userId = 56;  // int | Sub-account user id
            var key = "key_example";  // string | The API Key of the sub-account

            try
            {
                // Get the API Key of the sub-account
                SubAccountKey result = apiInstance.GetSubAccountKey(userId, key);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SubAccountApi.GetSubAccountKey: " + e.Message);
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
 **userId** | **int**| Sub-account user id | 
 **key** | **string**| The API Key of the sub-account | 

### Return type

[**SubAccountKey**](SubAccountKey.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesubaccountkeys"></a>
# **UpdateSubAccountKeys**
> void UpdateSubAccountKeys (int userId, string key, SubAccountKey subAccountKey)

Update API key of the sub-account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UpdateSubAccountKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SubAccountApi(config);
            var userId = 56;  // int | Sub-account user id
            var key = "key_example";  // string | The API Key of the sub-account
            var subAccountKey = new SubAccountKey(); // SubAccountKey | 

            try
            {
                // Update API key of the sub-account
                apiInstance.UpdateSubAccountKeys(userId, key, subAccountKey);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SubAccountApi.UpdateSubAccountKeys: " + e.Message);
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
 **userId** | **int**| Sub-account user id | 
 **key** | **string**| The API Key of the sub-account | 
 **subAccountKey** | [**SubAccountKey**](SubAccountKey.md)|  | 

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
| **204** | Updated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesubaccountkeys"></a>
# **DeleteSubAccountKeys**
> void DeleteSubAccountKeys (int userId, string key)

Delete API key of the sub-account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class DeleteSubAccountKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SubAccountApi(config);
            var userId = 56;  // int | Sub-account user id
            var key = "key_example";  // string | The API Key of the sub-account

            try
            {
                // Delete API key of the sub-account
                apiInstance.DeleteSubAccountKeys(userId, key);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SubAccountApi.DeleteSubAccountKeys: " + e.Message);
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
 **userId** | **int**| Sub-account user id | 
 **key** | **string**| The API Key of the sub-account | 

### Return type

void (empty response body)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Delete successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="locksubaccount"></a>
# **LockSubAccount**
> void LockSubAccount (long userId, Object body)

Lock the sub-account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class LockSubAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SubAccountApi(config);
            var userId = 56;  // long | The user id of the sub-account
            var body = null;  // Object | 

            try
            {
                // Lock the sub-account
                apiInstance.LockSubAccount(userId, body);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SubAccountApi.LockSubAccount: " + e.Message);
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
 **userId** | **long**| The user id of the sub-account | 
 **body** | **Object**|  | 

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
| **204** | Lock successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unlocksubaccount"></a>
# **UnlockSubAccount**
> void UnlockSubAccount (long userId, Object body)

Unlock the sub-account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UnlockSubAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SubAccountApi(config);
            var userId = 56;  // long | The user id of the sub-account
            var body = null;  // Object | 

            try
            {
                // Unlock the sub-account
                apiInstance.UnlockSubAccount(userId, body);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SubAccountApi.UnlockSubAccount: " + e.Message);
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
 **userId** | **long**| The user id of the sub-account | 
 **body** | **Object**|  | 

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
| **204** | Unlock successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

