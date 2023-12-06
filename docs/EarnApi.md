# Io.Gate.GateApi.Api.EarnApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SwapETH2**](EarnApi.md#swapeth2) | **POST** /earn/staking/eth2/swap | ETH2 swap
[**ListDualInvestmentPlans**](EarnApi.md#listdualinvestmentplans) | **GET** /earn/dual/investment_plan | Dual Investment product list
[**ListDualOrders**](EarnApi.md#listdualorders) | **GET** /earn/dual/orders | Dual Investment order list
[**PlaceDualOrder**](EarnApi.md#placedualorder) | **POST** /earn/dual/orders | Place Dual Investment order
[**CancelDualOrder**](EarnApi.md#canceldualorder) | **DELETE** /earn/dual/orders/{order_id} | Cancel Dual Investment order
[**ListStructuredProducts**](EarnApi.md#liststructuredproducts) | **GET** /earn/structured/products | Structured Product List
[**ListStructuredOrders**](EarnApi.md#liststructuredorders) | **GET** /earn/structured/orders | Structured Product Order List
[**PlaceStructuredOrder**](EarnApi.md#placestructuredorder) | **POST** /earn/structured/orders | Place Structured Product Order


<a name="swapeth2"></a>
# **SwapETH2**
> void SwapETH2 (Eth2Swap eth2Swap)

ETH2 swap

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class SwapETH2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var eth2Swap = new Eth2Swap(); // Eth2Swap | 

            try
            {
                // ETH2 swap
                apiInstance.SwapETH2(eth2Swap);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.SwapETH2: " + e.Message);
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
 **eth2Swap** | [**Eth2Swap**](Eth2Swap.md)|  | 

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
| **200** | swap success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdualinvestmentplans"></a>
# **ListDualInvestmentPlans**
> List&lt;DualGetPlans&gt; ListDualInvestmentPlans ()

Dual Investment product list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListDualInvestmentPlansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new EarnApi(config);

            try
            {
                // Dual Investment product list
                List<DualGetPlans> result = apiInstance.ListDualInvestmentPlans();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.ListDualInvestmentPlans: " + e.Message);
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

[**List&lt;DualGetPlans&gt;**](DualGetPlans.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdualorders"></a>
# **ListDualOrders**
> List&lt;DualGetOrders&gt; ListDualOrders ()

Dual Investment order list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListDualOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);

            try
            {
                // Dual Investment order list
                List<DualGetOrders> result = apiInstance.ListDualOrders();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.ListDualOrders: " + e.Message);
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

[**List&lt;DualGetOrders&gt;**](DualGetOrders.md)

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

<a name="placedualorder"></a>
# **PlaceDualOrder**
> void PlaceDualOrder (PlaceDualInvestmentOrder placeDualInvestmentOrder)

Place Dual Investment order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class PlaceDualOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var placeDualInvestmentOrder = new PlaceDualInvestmentOrder(); // PlaceDualInvestmentOrder | 

            try
            {
                // Place Dual Investment order
                apiInstance.PlaceDualOrder(placeDualInvestmentOrder);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.PlaceDualOrder: " + e.Message);
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
 **placeDualInvestmentOrder** | [**PlaceDualInvestmentOrder**](PlaceDualInvestmentOrder.md)|  | 

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

<a name="canceldualorder"></a>
# **CancelDualOrder**
> void CancelDualOrder (int orderId)

Cancel Dual Investment order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelDualOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var orderId = 1;  // int | Order ID

            try
            {
                // Cancel Dual Investment order
                apiInstance.CancelDualOrder(orderId);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.CancelDualOrder: " + e.Message);
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
 **orderId** | **int**| Order ID | 

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
| **200** | Cancel success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="liststructuredproducts"></a>
# **ListStructuredProducts**
> List&lt;StructuredGetProjectList&gt; ListStructuredProducts (StructuredGetProjectListRequest structuredGetProjectListRequest)

Structured Product List

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListStructuredProductsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new EarnApi(config);
            var structuredGetProjectListRequest = new StructuredGetProjectListRequest(); // StructuredGetProjectListRequest | 

            try
            {
                // Structured Product List
                List<StructuredGetProjectList> result = apiInstance.ListStructuredProducts(structuredGetProjectListRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.ListStructuredProducts: " + e.Message);
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
 **structuredGetProjectListRequest** | [**StructuredGetProjectListRequest**](StructuredGetProjectListRequest.md)|  | 

### Return type

[**List&lt;StructuredGetProjectList&gt;**](StructuredGetProjectList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="liststructuredorders"></a>
# **ListStructuredOrders**
> List&lt;StructuredOrderList&gt; ListStructuredOrders (StructuredOrderListRequest structuredOrderListRequest)

Structured Product Order List

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListStructuredOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var structuredOrderListRequest = new StructuredOrderListRequest(); // StructuredOrderListRequest | 

            try
            {
                // Structured Product Order List
                List<StructuredOrderList> result = apiInstance.ListStructuredOrders(structuredOrderListRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.ListStructuredOrders: " + e.Message);
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
 **structuredOrderListRequest** | [**StructuredOrderListRequest**](StructuredOrderListRequest.md)|  | 

### Return type

[**List&lt;StructuredOrderList&gt;**](StructuredOrderList.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="placestructuredorder"></a>
# **PlaceStructuredOrder**
> void PlaceStructuredOrder (StructuredBuy structuredBuy)

Place Structured Product Order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class PlaceStructuredOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var structuredBuy = new StructuredBuy(); // StructuredBuy | 

            try
            {
                // Place Structured Product Order
                apiInstance.PlaceStructuredOrder(structuredBuy);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.PlaceStructuredOrder: " + e.Message);
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
 **structuredBuy** | [**StructuredBuy**](StructuredBuy.md)|  | 

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

