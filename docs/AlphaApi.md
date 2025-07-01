# Io.Gate.GateApi.Api.AlphaApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListAlphaAccounts**](AlphaApi.md#listalphaaccounts) | **GET** /alpha/accounts | API for Alpha Accounts
[**ListAlphaAccountBook**](AlphaApi.md#listalphaaccountbook) | **GET** /alpha/account_book | Alpha Asset Transaction API
[**QuoteAlphaOrder**](AlphaApi.md#quotealphaorder) | **POST** /alpha/quote | Alpha Quotation API
[**ListAlphaOrder**](AlphaApi.md#listalphaorder) | **GET** /alpha/orders | Alpha 查询订单列表接口
[**PlaceAlphaOrder**](AlphaApi.md#placealphaorder) | **POST** /alpha/orders | Alpha Order Placement API
[**GetAlphaOrder**](AlphaApi.md#getalphaorder) | **GET** /alpha/order | Alpha 查询单个订单接口
[**ListAlphaCurrencies**](AlphaApi.md#listalphacurrencies) | **GET** /alpha/currencies | 查询币种信息
[**ListAlphaTickers**](AlphaApi.md#listalphatickers) | **GET** /alpha/tickers | 查询币种ticker


<a name="listalphaaccounts"></a>
# **ListAlphaAccounts**
> List&lt;AccountsResponse&gt; ListAlphaAccounts ()

API for Alpha Accounts

Query Position Assets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListAlphaAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new AlphaApi(config);

            try
            {
                // API for Alpha Accounts
                List<AccountsResponse> result = apiInstance.ListAlphaAccounts();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AlphaApi.ListAlphaAccounts: " + e.Message);
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

[**List&lt;AccountsResponse&gt;**](AccountsResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 查询持仓成功 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listalphaaccountbook"></a>
# **ListAlphaAccountBook**
> List&lt;AccountBookResponse&gt; ListAlphaAccountBook (long from, long? to = null, int? page = null, int? limit = null)

Alpha Asset Transaction API

Query Asset Transactions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListAlphaAccountBookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new AlphaApi(config);
            var from = 56;  // long | Start timestamp of the query
            var to = 56;  // long? | Time range ending, default to current time (optional) 
            var page = 56;  // int? | Page number (optional) 
            var limit = 56;  // int? | The maximum number of items per page is 100 (optional) 

            try
            {
                // Alpha Asset Transaction API
                List<AccountBookResponse> result = apiInstance.ListAlphaAccountBook(from, to, page, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AlphaApi.ListAlphaAccountBook: " + e.Message);
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
 **from** | **long**| Start timestamp of the query | 
 **to** | **long?**| Time range ending, default to current time | [optional] 
 **page** | **int?**| Page number | [optional] 
 **limit** | **int?**| The maximum number of items per page is 100 | [optional] 

### Return type

[**List&lt;AccountBookResponse&gt;**](AccountBookResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 查询流水成功 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotealphaorder"></a>
# **QuoteAlphaOrder**
> QuoteResponse QuoteAlphaOrder (QuoteRequest quoteRequest)

Alpha Quotation API

The quote_id returned by the quotation API is valid for one minute.You must place the order within this time window;otherwise, the quote will expire and a new quotation request is required

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QuoteAlphaOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new AlphaApi(config);
            var quoteRequest = new QuoteRequest(); // QuoteRequest | 

            try
            {
                // Alpha Quotation API
                QuoteResponse result = apiInstance.QuoteAlphaOrder(quoteRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AlphaApi.QuoteAlphaOrder: " + e.Message);
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
 **quoteRequest** | [**QuoteRequest**](QuoteRequest.md)|  | 

### Return type

[**QuoteResponse**](QuoteResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 询价成功 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listalphaorder"></a>
# **ListAlphaOrder**
> List&lt;OrderResponse&gt; ListAlphaOrder (string currency, string side, int status, long? from = null, long? to = null, int? limit = null, int? page = null)

Alpha 查询订单列表接口

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListAlphaOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new AlphaApi(config);
            var currency = "memeboxsst";  // string | Trading Symbol
            var side = "buy";  // string | 买单或者卖单 - buy - sell
            var status = 2;  // int | Order Status - `0` : All - `1` : Processing - `2` : Successful - `3` : Failed - `4` : Canceled - `5` : Buy order placed but transfer not completed - `6` : Cancelled order with transfer not complete
            var from = 1627706330;  // long? | 查询订单的起始时间 (optional) 
            var to = 1635329650;  // long? | 查询订单的结束时间，不指定则默认为当前时间 (optional) 
            var limit = 100;  // int? | Maximum response items.  Default: 100, minimum: 1, Maximum: 100 (optional)  (default to 100)
            var page = 1;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Alpha 查询订单列表接口
                List<OrderResponse> result = apiInstance.ListAlphaOrder(currency, side, status, from, to, limit, page);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AlphaApi.ListAlphaOrder: " + e.Message);
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
 **currency** | **string**| Trading Symbol | 
 **side** | **string**| 买单或者卖单 - buy - sell | 
 **status** | **int**| Order Status - &#x60;0&#x60; : All - &#x60;1&#x60; : Processing - &#x60;2&#x60; : Successful - &#x60;3&#x60; : Failed - &#x60;4&#x60; : Canceled - &#x60;5&#x60; : Buy order placed but transfer not completed - &#x60;6&#x60; : Cancelled order with transfer not complete | 
 **from** | **long?**| 查询订单的起始时间 | [optional] 
 **to** | **long?**| 查询订单的结束时间，不指定则默认为当前时间 | [optional] 
 **limit** | **int?**| Maximum response items.  Default: 100, minimum: 1, Maximum: 100 | [optional] [default to 100]
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**List&lt;OrderResponse&gt;**](OrderResponse.md)

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

<a name="placealphaorder"></a>
# **PlaceAlphaOrder**
> PlaceOrderResponse PlaceAlphaOrder (PlaceOrderRequest placeOrderRequest)

Alpha Order Placement API

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class PlaceAlphaOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new AlphaApi(config);
            var placeOrderRequest = new PlaceOrderRequest(); // PlaceOrderRequest | 

            try
            {
                // Alpha Order Placement API
                PlaceOrderResponse result = apiInstance.PlaceAlphaOrder(placeOrderRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AlphaApi.PlaceAlphaOrder: " + e.Message);
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
 **placeOrderRequest** | [**PlaceOrderRequest**](PlaceOrderRequest.md)|  | 

### Return type

[**PlaceOrderResponse**](PlaceOrderResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalphaorder"></a>
# **GetAlphaOrder**
> OrderResponse GetAlphaOrder (string orderId)

Alpha 查询单个订单接口

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetAlphaOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new AlphaApi(config);
            var orderId = "fdaf12321";  // string | Order ID

            try
            {
                // Alpha 查询单个订单接口
                OrderResponse result = apiInstance.GetAlphaOrder(orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AlphaApi.GetAlphaOrder: " + e.Message);
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
 **orderId** | **string**| Order ID | 

### Return type

[**OrderResponse**](OrderResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 订单查询成功 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listalphacurrencies"></a>
# **ListAlphaCurrencies**
> List&lt;Currency2&gt; ListAlphaCurrencies (string currency = null, int? limit = null, int? page = null)

查询币种信息

When the currency parameter is provided, query and return information for the specified currency. When the currency parameter is not provided, return a paginated list of currencies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListAlphaCurrenciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new AlphaApi(config);
            var currency = "memeboxtrump";  // string | 根据币种符号查询币种信息 (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var page = 1;  // int? | Page number (optional)  (default to 1)

            try
            {
                // 查询币种信息
                List<Currency2> result = apiInstance.ListAlphaCurrencies(currency, limit, page);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AlphaApi.ListAlphaCurrencies: " + e.Message);
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
 **currency** | **string**| 根据币种符号查询币种信息 | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**List&lt;Currency2&gt;**](Currency2.md)

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

<a name="listalphatickers"></a>
# **ListAlphaTickers**
> List&lt;Ticker2&gt; ListAlphaTickers (string currency = null, int? limit = null, int? page = null)

查询币种ticker

When the currency parameter is provided, query and return information for the specified ticker, When the currency parameter is not provided, return a paginated list of tickers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListAlphaTickersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new AlphaApi(config);
            var currency = "memeboxtrump";  // string | Retrieve data of the specified currency (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var page = 1;  // int? | Page number (optional)  (default to 1)

            try
            {
                // 查询币种ticker
                List<Ticker2> result = apiInstance.ListAlphaTickers(currency, limit, page);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AlphaApi.ListAlphaTickers: " + e.Message);
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
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**List&lt;Ticker2&gt;**](Ticker2.md)

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

