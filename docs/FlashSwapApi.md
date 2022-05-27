# Io.Gate.GateApi.Api.FlashSwapApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListFlashSwapCurrencies**](FlashSwapApi.md#listflashswapcurrencies) | **GET** /flash_swap/currencies | List all supported currencies in flash swap
[**ListFlashSwapOrders**](FlashSwapApi.md#listflashswaporders) | **GET** /flash_swap/orders | List all flash swap orders
[**CreateFlashSwapOrder**](FlashSwapApi.md#createflashswaporder) | **POST** /flash_swap/orders | Create a flash swap order
[**GetFlashSwapOrder**](FlashSwapApi.md#getflashswaporder) | **GET** /flash_swap/orders/{order_id} | Get a single flash swap order&#39;s detail
[**PreviewFlashSwapOrder**](FlashSwapApi.md#previewflashswaporder) | **POST** /flash_swap/orders/preview | Initiate a flash swap order preview


<a name="listflashswapcurrencies"></a>
# **ListFlashSwapCurrencies**
> List&lt;FlashSwapCurrency&gt; ListFlashSwapCurrencies ()

List all supported currencies in flash swap

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFlashSwapCurrenciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FlashSwapApi(config);

            try
            {
                // List all supported currencies in flash swap
                List<FlashSwapCurrency> result = apiInstance.ListFlashSwapCurrencies();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FlashSwapApi.ListFlashSwapCurrencies: " + e.Message);
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

[**List&lt;FlashSwapCurrency&gt;**](FlashSwapCurrency.md)

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

<a name="listflashswaporders"></a>
# **ListFlashSwapOrders**
> List&lt;FlashSwapOrder&gt; ListFlashSwapOrders (int? status = null, string sellCurrency = null, string buyCurrency = null, bool? reverse = null, int? limit = null, int? page = null)

List all flash swap orders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFlashSwapOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FlashSwapApi(config);
            var status = 1;  // int? | Flash swap order status  `1` - success `2` - failure (optional) 
            var sellCurrency = "BTC";  // string | Currency to sell which can be retrieved from supported currency list API `GET /flash_swap/currencies` (optional) 
            var buyCurrency = "BTC";  // string | Currency to buy which can be retrieved from supported currency list API `GET /flash_swap/currencies` (optional) 
            var reverse = true;  // bool? | If results are sorted by id in reverse order. Default to `true`  - `true`: sort by id in descending order(recent first) - `false`: sort by id in ascending order(oldest first) (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var page = 1;  // int? | Page number (optional)  (default to 1)

            try
            {
                // List all flash swap orders
                List<FlashSwapOrder> result = apiInstance.ListFlashSwapOrders(status, sellCurrency, buyCurrency, reverse, limit, page);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FlashSwapApi.ListFlashSwapOrders: " + e.Message);
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
 **status** | **int?**| Flash swap order status  &#x60;1&#x60; - success &#x60;2&#x60; - failure | [optional] 
 **sellCurrency** | **string**| Currency to sell which can be retrieved from supported currency list API &#x60;GET /flash_swap/currencies&#x60; | [optional] 
 **buyCurrency** | **string**| Currency to buy which can be retrieved from supported currency list API &#x60;GET /flash_swap/currencies&#x60; | [optional] 
 **reverse** | **bool?**| If results are sorted by id in reverse order. Default to &#x60;true&#x60;  - &#x60;true&#x60;: sort by id in descending order(recent first) - &#x60;false&#x60;: sort by id in ascending order(oldest first) | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**List&lt;FlashSwapOrder&gt;**](FlashSwapOrder.md)

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

<a name="createflashswaporder"></a>
# **CreateFlashSwapOrder**
> FlashSwapOrder CreateFlashSwapOrder (FlashSwapOrderRequest flashSwapOrderRequest)

Create a flash swap order

Initiate a flash swap preview in advance because order creation requires a preview result

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateFlashSwapOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FlashSwapApi(config);
            var flashSwapOrderRequest = new FlashSwapOrderRequest(); // FlashSwapOrderRequest | 

            try
            {
                // Create a flash swap order
                FlashSwapOrder result = apiInstance.CreateFlashSwapOrder(flashSwapOrderRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FlashSwapApi.CreateFlashSwapOrder: " + e.Message);
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
 **flashSwapOrderRequest** | [**FlashSwapOrderRequest**](FlashSwapOrderRequest.md)|  | 

### Return type

[**FlashSwapOrder**](FlashSwapOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The flash swap order is created successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflashswaporder"></a>
# **GetFlashSwapOrder**
> FlashSwapOrder GetFlashSwapOrder (int orderId)

Get a single flash swap order's detail

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetFlashSwapOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FlashSwapApi(config);
            var orderId = 1;  // int | Flash swap order ID

            try
            {
                // Get a single flash swap order's detail
                FlashSwapOrder result = apiInstance.GetFlashSwapOrder(orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FlashSwapApi.GetFlashSwapOrder: " + e.Message);
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
 **orderId** | **int**| Flash swap order ID | 

### Return type

[**FlashSwapOrder**](FlashSwapOrder.md)

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

<a name="previewflashswaporder"></a>
# **PreviewFlashSwapOrder**
> FlashSwapOrderPreview PreviewFlashSwapOrder (FlashSwapOrderRequest flashSwapOrderRequest)

Initiate a flash swap order preview

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class PreviewFlashSwapOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FlashSwapApi(config);
            var flashSwapOrderRequest = new FlashSwapOrderRequest(); // FlashSwapOrderRequest | 

            try
            {
                // Initiate a flash swap order preview
                FlashSwapOrderPreview result = apiInstance.PreviewFlashSwapOrder(flashSwapOrderRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FlashSwapApi.PreviewFlashSwapOrder: " + e.Message);
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
 **flashSwapOrderRequest** | [**FlashSwapOrderRequest**](FlashSwapOrderRequest.md)|  | 

### Return type

[**FlashSwapOrderPreview**](FlashSwapOrderPreview.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The flash swap order successfully previewed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

