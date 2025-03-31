# Io.Gate.GateApi.Api.SpotApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListCurrencies**](SpotApi.md#listcurrencies) | **GET** /spot/currencies | List all currencies&#39; details
[**GetCurrency**](SpotApi.md#getcurrency) | **GET** /spot/currencies/{currency} | Get details of a specific currency
[**ListCurrencyPairs**](SpotApi.md#listcurrencypairs) | **GET** /spot/currency_pairs | List all currency pairs supported
[**GetCurrencyPair**](SpotApi.md#getcurrencypair) | **GET** /spot/currency_pairs/{currency_pair} | Get details of a specifc currency pair
[**ListTickers**](SpotApi.md#listtickers) | **GET** /spot/tickers | Retrieve ticker information
[**ListOrderBook**](SpotApi.md#listorderbook) | **GET** /spot/order_book | Retrieve order book
[**ListTrades**](SpotApi.md#listtrades) | **GET** /spot/trades | Retrieve market trades
[**ListCandlesticks**](SpotApi.md#listcandlesticks) | **GET** /spot/candlesticks | Market candlesticks
[**GetFee**](SpotApi.md#getfee) | **GET** /spot/fee | Query user trading fee rates
[**GetBatchSpotFee**](SpotApi.md#getbatchspotfee) | **GET** /spot/batch_fee | Query a batch of user trading fee rates
[**ListSpotAccounts**](SpotApi.md#listspotaccounts) | **GET** /spot/accounts | List spot accounts
[**ListSpotAccountBook**](SpotApi.md#listspotaccountbook) | **GET** /spot/account_book | Query account book
[**CreateBatchOrders**](SpotApi.md#createbatchorders) | **POST** /spot/batch_orders | Create a batch of orders
[**ListAllOpenOrders**](SpotApi.md#listallopenorders) | **GET** /spot/open_orders | List all open orders
[**CreateCrossLiquidateOrder**](SpotApi.md#createcrossliquidateorder) | **POST** /spot/cross_liquidate_orders | close position when cross-currency is disabled
[**ListOrders**](SpotApi.md#listorders) | **GET** /spot/orders | List orders
[**CreateOrder**](SpotApi.md#createorder) | **POST** /spot/orders | Create an order
[**CancelOrders**](SpotApi.md#cancelorders) | **DELETE** /spot/orders | Cancel all &#x60;open&#x60; orders in specified currency pair
[**CancelBatchOrders**](SpotApi.md#cancelbatchorders) | **POST** /spot/cancel_batch_orders | Cancel a batch of orders with an ID list
[**GetOrder**](SpotApi.md#getorder) | **GET** /spot/orders/{order_id} | Get a single order
[**CancelOrder**](SpotApi.md#cancelorder) | **DELETE** /spot/orders/{order_id} | Cancel a single order
[**AmendOrder**](SpotApi.md#amendorder) | **PATCH** /spot/orders/{order_id} | Amend an order
[**ListMyTrades**](SpotApi.md#listmytrades) | **GET** /spot/my_trades | List personal trading history
[**GetSystemTime**](SpotApi.md#getsystemtime) | **GET** /spot/time | Get server current time
[**CountdownCancelAllSpot**](SpotApi.md#countdowncancelallspot) | **POST** /spot/countdown_cancel_all | Countdown cancel orders
[**AmendBatchOrders**](SpotApi.md#amendbatchorders) | **POST** /spot/amend_batch_orders | Batch modification of orders
[**GetSpotInsuranceHistory**](SpotApi.md#getspotinsurancehistory) | **GET** /spot/insurance_history | Query spot insurance fund historical data
[**ListSpotPriceTriggeredOrders**](SpotApi.md#listspotpricetriggeredorders) | **GET** /spot/price_orders | Retrieve running auto order list
[**CreateSpotPriceTriggeredOrder**](SpotApi.md#createspotpricetriggeredorder) | **POST** /spot/price_orders | Create a price-triggered order
[**CancelSpotPriceTriggeredOrderList**](SpotApi.md#cancelspotpricetriggeredorderlist) | **DELETE** /spot/price_orders | Cancel All Price-triggered Orders
[**GetSpotPriceTriggeredOrder**](SpotApi.md#getspotpricetriggeredorder) | **GET** /spot/price_orders/{order_id} | Get a price-triggered order
[**CancelSpotPriceTriggeredOrder**](SpotApi.md#cancelspotpricetriggeredorder) | **DELETE** /spot/price_orders/{order_id} | cancel a price-triggered order


<a name="listcurrencies"></a>
# **ListCurrencies**
> List&lt;Currency&gt; ListCurrencies ()

List all currencies' details

When a currency corresponds to multiple chains, you can query the information of multiple chains through the `chains` field, such as the charging and recharge status, identification, etc. of the chain.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListCurrenciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new SpotApi(config);

            try
            {
                // List all currencies' details
                List<Currency> result = apiInstance.ListCurrencies();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListCurrencies: " + e.Message);
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

[**List&lt;Currency&gt;**](Currency.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrency"></a>
# **GetCurrency**
> Currency GetCurrency (string currency)

Get details of a specific currency

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetCurrencyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new SpotApi(config);
            var currency = "GT";  // string | Currency name

            try
            {
                // Get details of a specific currency
                Currency result = apiInstance.GetCurrency(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.GetCurrency: " + e.Message);
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

[**Currency**](Currency.md)

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

<a name="listcurrencypairs"></a>
# **ListCurrencyPairs**
> List&lt;CurrencyPair&gt; ListCurrencyPairs ()

List all currency pairs supported

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListCurrencyPairsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new SpotApi(config);

            try
            {
                // List all currency pairs supported
                List<CurrencyPair> result = apiInstance.ListCurrencyPairs();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListCurrencyPairs: " + e.Message);
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

[**List&lt;CurrencyPair&gt;**](CurrencyPair.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All currency pairs retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrencypair"></a>
# **GetCurrencyPair**
> CurrencyPair GetCurrencyPair (string currencyPair)

Get details of a specifc currency pair

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetCurrencyPairExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new SpotApi(config);
            var currencyPair = "ETH_BTC";  // string | Currency pair

            try
            {
                // Get details of a specifc currency pair
                CurrencyPair result = apiInstance.GetCurrencyPair(currencyPair);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.GetCurrencyPair: " + e.Message);
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
 **currencyPair** | **string**| Currency pair | 

### Return type

[**CurrencyPair**](CurrencyPair.md)

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

<a name="listtickers"></a>
# **ListTickers**
> List&lt;Ticker&gt; ListTickers (string currencyPair = null, string timezone = null)

Retrieve ticker information

Return only related data if `currency_pair` is specified; otherwise return all of them

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListTickersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new SpotApi(config);
            var currencyPair = "BTC_USDT";  // string | Currency pair (optional) 
            var timezone = "utc0";  // string | Timezone (optional) 

            try
            {
                // Retrieve ticker information
                List<Ticker> result = apiInstance.ListTickers(currencyPair, timezone);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListTickers: " + e.Message);
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
 **currencyPair** | **string**| Currency pair | [optional] 
 **timezone** | **string**| Timezone | [optional] 

### Return type

[**List&lt;Ticker&gt;**](Ticker.md)

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

<a name="listorderbook"></a>
# **ListOrderBook**
> OrderBook ListOrderBook (string currencyPair, string interval = null, int? limit = null, bool? withId = null)

Retrieve order book

Order book will be sorted by price from high to low on bids; low to high on asks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListOrderBookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new SpotApi(config);
            var currencyPair = "BTC_USDT";  // string | Currency pair
            var interval = "\"0\"";  // string | Order depth. 0 means no aggregation is applied. default to 0 (optional)  (default to "0")
            var limit = 10;  // int? | Maximum number of order depth data in asks or bids (optional)  (default to 10)
            var withId = false;  // bool? | Return order book ID (optional)  (default to false)

            try
            {
                // Retrieve order book
                OrderBook result = apiInstance.ListOrderBook(currencyPair, interval, limit, withId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListOrderBook: " + e.Message);
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
 **currencyPair** | **string**| Currency pair | 
 **interval** | **string**| Order depth. 0 means no aggregation is applied. default to 0 | [optional] [default to &quot;0&quot;]
 **limit** | **int?**| Maximum number of order depth data in asks or bids | [optional] [default to 10]
 **withId** | **bool?**| Return order book ID | [optional] [default to false]

### Return type

[**OrderBook**](OrderBook.md)

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

<a name="listtrades"></a>
# **ListTrades**
> List&lt;Trade&gt; ListTrades (string currencyPair, int? limit = null, string lastId = null, bool? reverse = null, long? from = null, long? to = null, int? page = null)

Retrieve market trades

Supports `from` and `to` by time range query or page-turn query based on `last_id`. By default, query by time range is the last 30 days.  The query method based on `last_id` page turn is no longer recommended. If `last_id` is specified, the time range query parameters will be ignored.  The maximum number of pages when searching data using limit&page paging function is 100,000, that is, limit * (page - 1) <= 100,000.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListTradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new SpotApi(config);
            var currencyPair = "BTC_USDT";  // string | Currency pair
            var limit = 100;  // int? | Maximum number of records to be returned in a single list.  Default: 100, Minimum: 1, Maximum: 1000 (optional)  (default to 100)
            var lastId = "12345";  // string | Specify list staring point using the `id` of last record in previous list-query results (optional) 
            var reverse = false;  // bool? | Whether the id of records to be retrieved should be less than the last_id specified. Default to false.  When `last_id` is specified. Set `reverse` to `true` to trace back trading history; `false` to retrieve latest tradings.  No effect if `last_id` is not specified. (optional)  (default to false)
            var from = 1627706330;  // long? | Start timestamp of the query (optional) 
            var to = 1635329650;  // long? | Time range ending, default to current time (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Retrieve market trades
                List<Trade> result = apiInstance.ListTrades(currencyPair, limit, lastId, reverse, from, to, page);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListTrades: " + e.Message);
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
 **currencyPair** | **string**| Currency pair | 
 **limit** | **int?**| Maximum number of records to be returned in a single list.  Default: 100, Minimum: 1, Maximum: 1000 | [optional] [default to 100]
 **lastId** | **string**| Specify list staring point using the &#x60;id&#x60; of last record in previous list-query results | [optional] 
 **reverse** | **bool?**| Whether the id of records to be retrieved should be less than the last_id specified. Default to false.  When &#x60;last_id&#x60; is specified. Set &#x60;reverse&#x60; to &#x60;true&#x60; to trace back trading history; &#x60;false&#x60; to retrieve latest tradings.  No effect if &#x60;last_id&#x60; is not specified. | [optional] [default to false]
 **from** | **long?**| Start timestamp of the query | [optional] 
 **to** | **long?**| Time range ending, default to current time | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**List&lt;Trade&gt;**](Trade.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcandlesticks"></a>
# **ListCandlesticks**
> List&lt;List&lt;string&gt;&gt; ListCandlesticks (string currencyPair, int? limit = null, long? from = null, long? to = null, string interval = null)

Market candlesticks

Maximum of 1000 points can be returned in a query. Be sure not to exceed the limit when specifying from, to and interval

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListCandlesticksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new SpotApi(config);
            var currencyPair = "BTC_USDT";  // string | Currency pair
            var limit = 100;  // int? | Maximum recent data points to return. `limit` is conflicted with `from` and `to`. If either `from` or `to` is specified, request will be rejected. (optional)  (default to 100)
            var from = 1546905600;  // long? | Start time of candlesticks, formatted in Unix timestamp in seconds. Default to`to - 100 * interval` if not specified (optional) 
            var to = 1546935600;  // long? | End time of candlesticks, formatted in Unix timestamp in seconds. Default to current time (optional) 
            var interval = "30m";  // string | Interval time between data points. Note that `30d` means 1 natual month, not 30 days (optional)  (default to 30m)

            try
            {
                // Market candlesticks
                List<List<string>> result = apiInstance.ListCandlesticks(currencyPair, limit, from, to, interval);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListCandlesticks: " + e.Message);
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
 **currencyPair** | **string**| Currency pair | 
 **limit** | **int?**| Maximum recent data points to return. &#x60;limit&#x60; is conflicted with &#x60;from&#x60; and &#x60;to&#x60;. If either &#x60;from&#x60; or &#x60;to&#x60; is specified, request will be rejected. | [optional] [default to 100]
 **from** | **long?**| Start time of candlesticks, formatted in Unix timestamp in seconds. Default to&#x60;to - 100 * interval&#x60; if not specified | [optional] 
 **to** | **long?**| End time of candlesticks, formatted in Unix timestamp in seconds. Default to current time | [optional] 
 **interval** | **string**| Interval time between data points. Note that &#x60;30d&#x60; means 1 natual month, not 30 days | [optional] [default to 30m]

### Return type

**List<List<string>>**

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

<a name="getfee"></a>
# **GetFee**
> SpotFee GetFee (string currencyPair = null)

Query user trading fee rates

This API is deprecated in favour of new fee retrieving API `/wallet/fee`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetFeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var currencyPair = "BTC_USDT";  // string | Specify a currency pair to retrieve precise fee rate  This field is optional. In most cases, the fee rate is identical among all currency pairs (optional) 

            try
            {
                // Query user trading fee rates
                SpotFee result = apiInstance.GetFee(currencyPair);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.GetFee: " + e.Message);
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

### Return type

[**SpotFee**](SpotFee.md)

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

<a name="getbatchspotfee"></a>
# **GetBatchSpotFee**
> Dictionary&lt;string, SpotFee&gt; GetBatchSpotFee (string currencyPairs)

Query a batch of user trading fee rates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetBatchSpotFeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var currencyPairs = "BTC_USDT,ETH_USDT";  // string | A request can only query up to 50 currency pairs

            try
            {
                // Query a batch of user trading fee rates
                Dictionary<string, SpotFee> result = apiInstance.GetBatchSpotFee(currencyPairs);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.GetBatchSpotFee: " + e.Message);
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
 **currencyPairs** | **string**| A request can only query up to 50 currency pairs | 

### Return type

[**Dictionary&lt;string, SpotFee&gt;**](SpotFee.md)

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

<a name="listspotaccounts"></a>
# **ListSpotAccounts**
> List&lt;SpotAccount&gt; ListSpotAccounts (string currency = null)

List spot accounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSpotAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var currency = "BTC";  // string | Retrieve data of the specified currency (optional) 

            try
            {
                // List spot accounts
                List<SpotAccount> result = apiInstance.ListSpotAccounts(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListSpotAccounts: " + e.Message);
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

[**List&lt;SpotAccount&gt;**](SpotAccount.md)

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

<a name="listspotaccountbook"></a>
# **ListSpotAccountBook**
> List&lt;SpotAccountBook&gt; ListSpotAccountBook (string currency = null, long? from = null, long? to = null, int? page = null, int? limit = null, string type = null, string code = null)

Query account book

Record query time range is not allowed to exceed 30 days.  The maximum number of pages when searching data using limit&page paging function is 100,000, that is, limit * (page - 1) <= 100,000.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSpotAccountBookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var currency = "BTC";  // string | Retrieve data of the specified currency (optional) 
            var from = 1627706330;  // long? | Start timestamp of the query (optional) 
            var to = 1635329650;  // long? | Time range ending, default to current time (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var type = "lend";  // string | Only retrieve changes of the specified type. All types will be returned if not specified. (optional) 
            var code = "code_example";  // string | Specify account change code query, if not specified, all change types are included, and the priority is higher than `type` (optional) 

            try
            {
                // Query account book
                List<SpotAccountBook> result = apiInstance.ListSpotAccountBook(currency, from, to, page, limit, type, code);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListSpotAccountBook: " + e.Message);
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
 **from** | **long?**| Start timestamp of the query | [optional] 
 **to** | **long?**| Time range ending, default to current time | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **type** | **string**| Only retrieve changes of the specified type. All types will be returned if not specified. | [optional] 
 **code** | **string**| Specify account change code query, if not specified, all change types are included, and the priority is higher than &#x60;type&#x60; | [optional] 

### Return type

[**List&lt;SpotAccountBook&gt;**](SpotAccountBook.md)

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

<a name="createbatchorders"></a>
# **CreateBatchOrders**
> List&lt;BatchOrder&gt; CreateBatchOrders (List<Order> order, long? xGateExptime = null)

Create a batch of orders

Batch orders requirements:  1. custom order field `text` is required 2. At most 4 currency pairs, maximum 10 orders each, are allowed in one request 3. No mixture of spot orders and margin orders, i.e. `account` must be identical for all orders 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateBatchOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var order = new List<Order>(); // List<Order> | 
            var xGateExptime = 1689560679123;  // long? | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Create a batch of orders
                List<BatchOrder> result = apiInstance.CreateBatchOrders(order, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.CreateBatchOrders: " + e.Message);
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
 **order** | [**List&lt;Order&gt;**](Order.md)|  | 
 **xGateExptime** | **long?**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**List&lt;BatchOrder&gt;**](BatchOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request is completed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listallopenorders"></a>
# **ListAllOpenOrders**
> List&lt;OpenOrders&gt; ListAllOpenOrders (int? page = null, int? limit = null, string account = null)

List all open orders

Query the current order list of all trading pairs. Please note that the paging parameter controls the number of pending orders in each trading pair. There is no paging control for the number of trading pairs. All trading pairs with pending orders will be returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListAllOpenOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum number of records returned in one page in each currency pair (optional)  (default to 100)
            var account = "spot";  // string | Specify query account. (optional) 

            try
            {
                // List all open orders
                List<OpenOrders> result = apiInstance.ListAllOpenOrders(page, limit, account);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListAllOpenOrders: " + e.Message);
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
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum number of records returned in one page in each currency pair | [optional] [default to 100]
 **account** | **string**| Specify query account. | [optional] 

### Return type

[**List&lt;OpenOrders&gt;**](OpenOrders.md)

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

<a name="createcrossliquidateorder"></a>
# **CreateCrossLiquidateOrder**
> Order CreateCrossLiquidateOrder (LiquidateOrder liquidateOrder)

close position when cross-currency is disabled

Currently, only cross-margin accounts are supported to close position when cross currencies are disabled.  Maximum buy quantity = (unpaid principal and interest - currency balance - the amount of the currency in the order book) / 0.998

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateCrossLiquidateOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var liquidateOrder = new LiquidateOrder(); // LiquidateOrder | 

            try
            {
                // close position when cross-currency is disabled
                Order result = apiInstance.CreateCrossLiquidateOrder(liquidateOrder);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.CreateCrossLiquidateOrder: " + e.Message);
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
 **liquidateOrder** | [**LiquidateOrder**](LiquidateOrder.md)|  | 

### Return type

[**Order**](Order.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | order created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listorders"></a>
# **ListOrders**
> List&lt;Order&gt; ListOrders (string currencyPair, string status, int? page = null, int? limit = null, string account = null, long? from = null, long? to = null, string side = null)

List orders

Note that the query results are spot order lists for spot, unified account and warehouse-by-site leverage accounts by default.  `status` is set to `open`, that is, when querying the pending order list, only pagination control of `page` and `limit` is supported. `limit` Maximum setting is only allowed to 100 . The `side` and `from`, `to` parameters for time range query are not supported.  `status` is set to `finished`, that is, when querying historical delegations, in addition to pagination queries, `from` and `to` are also supported by time range queries. In addition, it supports setting the `side` parameter to filter one-side history.  The parameters of the time range filtering are processed according to the order end time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var currencyPair = "BTC_USDT";  // string | Retrieve results with specified currency pair. It is required for open orders, but optional for finished ones.
            var status = "open";  // string | List orders based on status  `open` - order is waiting to be filled `finished` - order has been filled or cancelled 
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum number of records to be returned. If `status` is `open`, maximum of `limit` is 100 (optional)  (default to 100)
            var account = "spot";  // string | Specify query account. (optional) 
            var from = 1627706330;  // long? | Start timestamp of the query (optional) 
            var to = 1635329650;  // long? | Time range ending, default to current time (optional) 
            var side = "sell";  // string | All bids or asks. Both included if not specified (optional) 

            try
            {
                // List orders
                List<Order> result = apiInstance.ListOrders(currencyPair, status, page, limit, account, from, to, side);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListOrders: " + e.Message);
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
 **currencyPair** | **string**| Retrieve results with specified currency pair. It is required for open orders, but optional for finished ones. | 
 **status** | **string**| List orders based on status  &#x60;open&#x60; - order is waiting to be filled &#x60;finished&#x60; - order has been filled or cancelled  | 
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum number of records to be returned. If &#x60;status&#x60; is &#x60;open&#x60;, maximum of &#x60;limit&#x60; is 100 | [optional] [default to 100]
 **account** | **string**| Specify query account. | [optional] 
 **from** | **long?**| Start timestamp of the query | [optional] 
 **to** | **long?**| Time range ending, default to current time | [optional] 
 **side** | **string**| All bids or asks. Both included if not specified | [optional] 

### Return type

[**List&lt;Order&gt;**](Order.md)

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

<a name="createorder"></a>
# **CreateOrder**
> Order CreateOrder (Order order, long? xGateExptime = null)

Create an order

Support spot, margin, leverage, and full-position leverage orders. Use different accounts through the `account` field, default is `spot`, that is, use the spot account to place an order if the user is `unified` account, default is to place an order with a unified account  When using leveraged account trading, that is, when `account` is set to `margin`, you can set `auto_borrow` to `true`, In the case of insufficient account balance, the system will automatically execute the `POST /margin/uni/loans` to borrow the insufficient part. Whether the assets obtained after the leveraged order is automatically used to return the borrowing orders of the leveraged account in a position-by-store leverage account depends on the automatic repayment settings of the user's position-by-store leverage account**, The account automatic repayment settings can be queried and set through `/margin/auto_repay`.  Use unified account transactions, that is, when `account` is set to `unified`, `auto_borrow` \" can also be enableTo realize the insufficient part of automatic borrowing, but unlike the leverage account, whether the entrustment of a unified account is automatically repayable depends on the   when placing an order`auto_repay` setting, this setting is only effective for the current entrustment, that is, only the assets obtained after the entrustment transaction will be used to repay the borrowing orders of the full-position leverage account. Unified account ordering currently supports `auto_borrow` and `auto_repay` at the same time.  Auto repayment will be triggered at the end of the order, i.e. `status` is `cancelled` or `closed` .  **Delegation Status**  The entrustment status in the pending order is `open`, which remains at `open` until all the quantity is traded. If it is eaten, the order ends and the status becomes `closed`. If the order is cancelled before all transactions are completed, regardless of whether there are partial transactions, the status will become `cancelled`  **Iceberg Entrustment**  `iceberg` is used to set the number of iceberg delegations displayed, and does not support complete hiding. Note that when hidden part of the transaction is charged according to the taker's handling rate.  **Restrict user transactions**  Set `stp_act` to decide to use strategies that limit user transactions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var order = new Order(); // Order | 
            var xGateExptime = 1689560679123;  // long? | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Create an order
                Order result = apiInstance.CreateOrder(order, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.CreateOrder: " + e.Message);
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
 **order** | [**Order**](Order.md)|  | 
 **xGateExptime** | **long?**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**Order**](Order.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Order created. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelorders"></a>
# **CancelOrders**
> List&lt;OrderCancel&gt; CancelOrders (string currencyPair = null, string side = null, string account = null, string actionMode = null, long? xGateExptime = null)

Cancel all `open` orders in specified currency pair

When the `account` parameter is not specified, all pending orders including spot, unified account, and position-by-position leverage will be cancelled. When `currency_pair` is not specified, all transaction pairs are revoked You can specify a certain account separately to cancel all orders under the specified account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var currencyPair = "BTC_USDT";  // string | Currency pair (optional) 
            var side = "sell";  // string | All bids or asks. Both included if not specified (optional) 
            var account = "spot";  // string | Specify Account Type  - Classic Account: If not specified, all include  - Unified Account: Specify `unified` (optional) 
            var actionMode = "ACK";  // string | Processing Mode  When placing an order, different fields are returned based on the action_mode  - ACK: Asynchronous mode, returns only key order fields - RESULT: No clearing information - FULL: Full mode (default) (optional) 
            var xGateExptime = 1689560679123;  // long? | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Cancel all `open` orders in specified currency pair
                List<OrderCancel> result = apiInstance.CancelOrders(currencyPair, side, account, actionMode, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.CancelOrders: " + e.Message);
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
 **currencyPair** | **string**| Currency pair | [optional] 
 **side** | **string**| All bids or asks. Both included if not specified | [optional] 
 **account** | **string**| Specify Account Type  - Classic Account: If not specified, all include  - Unified Account: Specify &#x60;unified&#x60; | [optional] 
 **actionMode** | **string**| Processing Mode  When placing an order, different fields are returned based on the action_mode  - ACK: Asynchronous mode, returns only key order fields - RESULT: No clearing information - FULL: Full mode (default) | [optional] 
 **xGateExptime** | **long?**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**List&lt;OrderCancel&gt;**](OrderCancel.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Batch cancellation request accepted. Query order status by listing orders |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelbatchorders"></a>
# **CancelBatchOrders**
> List&lt;CancelOrderResult&gt; CancelBatchOrders (List<CancelBatchOrder> cancelBatchOrder, long? xGateExptime = null)

Cancel a batch of orders with an ID list

Multiple currency pairs can be specified, but maximum 20 orders are allowed per request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelBatchOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var cancelBatchOrder = new List<CancelBatchOrder>(); // List<CancelBatchOrder> | 
            var xGateExptime = 1689560679123;  // long? | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Cancel a batch of orders with an ID list
                List<CancelOrderResult> result = apiInstance.CancelBatchOrders(cancelBatchOrder, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.CancelBatchOrders: " + e.Message);
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
 **cancelBatchOrder** | [**List&lt;CancelBatchOrder&gt;**](CancelBatchOrder.md)|  | 
 **xGateExptime** | **long?**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**List&lt;CancelOrderResult&gt;**](CancelOrderResult.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Batch cancellation completed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorder"></a>
# **GetOrder**
> Order GetOrder (string orderId, string currencyPair, string account = null)

Get a single order

By default, orders for spot, unified account and warehouse-by-site leverage account are checked.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var orderId = "12345";  // string | The order ID returned when the order was successfully created or the custom ID specified by the user's creation (i.e. the `text` field). Operations based on custom IDs can only be checked in pending orders. Only order ID can be used after the order is finished (transaction/cancel)
            var currencyPair = "BTC_USDT";  // string | Specify the transaction pair to query. If you are querying pending order records, this field is required. If you are querying traded records, this field can be left blank.
            var account = "spot";  // string | Specify query account. (optional) 

            try
            {
                // Get a single order
                Order result = apiInstance.GetOrder(orderId, currencyPair, account);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.GetOrder: " + e.Message);
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
 **orderId** | **string**| The order ID returned when the order was successfully created or the custom ID specified by the user&#39;s creation (i.e. the &#x60;text&#x60; field). Operations based on custom IDs can only be checked in pending orders. Only order ID can be used after the order is finished (transaction/cancel) | 
 **currencyPair** | **string**| Specify the transaction pair to query. If you are querying pending order records, this field is required. If you are querying traded records, this field can be left blank. | 
 **account** | **string**| Specify query account. | [optional] 

### Return type

[**Order**](Order.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Detail retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelorder"></a>
# **CancelOrder**
> Order CancelOrder (string orderId, string currencyPair, string account = null, string actionMode = null, long? xGateExptime = null)

Cancel a single order

By default, orders for spot, unified accounts and leveraged accounts are revoked.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var orderId = "12345";  // string | The order ID returned when the order was successfully created or the custom ID specified by the user's creation (i.e. the `text` field). Operations based on custom IDs can only be checked in pending orders. Only order ID can be used after the order is finished (transaction/cancel)
            var currencyPair = "BTC_USDT";  // string | Currency pair
            var account = "spot";  // string | Specify query account. (optional) 
            var actionMode = "ACK";  // string | Processing Mode  When placing an order, different fields are returned based on the action_mode  - ACK: Asynchronous mode, returns only key order fields - RESULT: No clearing information - FULL: Full mode (default) (optional) 
            var xGateExptime = 1689560679123;  // long? | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Cancel a single order
                Order result = apiInstance.CancelOrder(orderId, currencyPair, account, actionMode, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.CancelOrder: " + e.Message);
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
 **orderId** | **string**| The order ID returned when the order was successfully created or the custom ID specified by the user&#39;s creation (i.e. the &#x60;text&#x60; field). Operations based on custom IDs can only be checked in pending orders. Only order ID can be used after the order is finished (transaction/cancel) | 
 **currencyPair** | **string**| Currency pair | 
 **account** | **string**| Specify query account. | [optional] 
 **actionMode** | **string**| Processing Mode  When placing an order, different fields are returned based on the action_mode  - ACK: Asynchronous mode, returns only key order fields - RESULT: No clearing information - FULL: Full mode (default) | [optional] 
 **xGateExptime** | **long?**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**Order**](Order.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order cancelled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="amendorder"></a>
# **AmendOrder**
> Order AmendOrder (string orderId, OrderPatch orderPatch, string currencyPair = null, string account = null, long? xGateExptime = null)

Amend an order

By default modify orders for spot, unified account and leverage account.  At present, both the request body and query support currency_pair and account parameters, but the request body has higher priority  currency_pair must be filled in the request body or query   Currently, only the price or quantity modification (choose one of two)  About speed limit: Modify orders and create orders to share speed limit rules  About matching priority: Only modifying the quantity will become smaller and will not affect the priority of matching. If the price is modified or the quantity is modified, the priority will be adjusted to the end of the new price   Precautions: Modification quantity is less than the transaction quantity will trigger the order cancellation operation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class AmendOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var orderId = "12345";  // string | The order ID returned when the order was successfully created or the custom ID specified by the user's creation (i.e. the `text` field). Operations based on custom IDs can only be checked in pending orders. Only order ID can be used after the order is finished (transaction/cancel)
            var orderPatch = new OrderPatch(); // OrderPatch | 
            var currencyPair = "BTC_USDT";  // string | Currency pair (optional) 
            var account = "spot";  // string | Specify query account. (optional) 
            var xGateExptime = 1689560679123;  // long? | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Amend an order
                Order result = apiInstance.AmendOrder(orderId, orderPatch, currencyPair, account, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.AmendOrder: " + e.Message);
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
 **orderId** | **string**| The order ID returned when the order was successfully created or the custom ID specified by the user&#39;s creation (i.e. the &#x60;text&#x60; field). Operations based on custom IDs can only be checked in pending orders. Only order ID can be used after the order is finished (transaction/cancel) | 
 **orderPatch** | [**OrderPatch**](OrderPatch.md)|  | 
 **currencyPair** | **string**| Currency pair | [optional] 
 **account** | **string**| Specify query account. | [optional] 
 **xGateExptime** | **long?**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**Order**](Order.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmytrades"></a>
# **ListMyTrades**
> List&lt;Trade&gt; ListMyTrades (string currencyPair = null, int? limit = null, int? page = null, string orderId = null, string account = null, long? from = null, long? to = null)

List personal trading history

By default query of transaction records for spot, unified account and warehouse-by-site leverage accounts.  The history within a specified time range can be queried by specifying `from` or (and) `to`.  - If no time parameters are specified, only data for the last 7 days can be obtained. - If only any parameter of `from` or `to` is specified, only 7-day data from the start (or end) of the specified time is returned. - The range of `from` and `to` is not allowed to exceed 30 days.  The parameters of the time range filter are processed according to the order end time.  The maximum number of pages when searching data using limit&page paging function is 100,000, that is, limit * (page - 1) <= 100,000.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListMyTradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var currencyPair = "BTC_USDT";  // string | Retrieve results with specified currency pair (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list.  Default: 100, Minimum: 1, Maximum: 1000 (optional)  (default to 100)
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var orderId = "12345";  // string | Filter trades with specified order ID. `currency_pair` is also required if this field is present (optional) 
            var account = "spot";  // string | Specify query account. (optional) 
            var from = 1627706330;  // long? | Start timestamp of the query (optional) 
            var to = 1635329650;  // long? | Time range ending, default to current time (optional) 

            try
            {
                // List personal trading history
                List<Trade> result = apiInstance.ListMyTrades(currencyPair, limit, page, orderId, account, from, to);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListMyTrades: " + e.Message);
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
 **currencyPair** | **string**| Retrieve results with specified currency pair | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list.  Default: 100, Minimum: 1, Maximum: 1000 | [optional] [default to 100]
 **page** | **int?**| Page number | [optional] [default to 1]
 **orderId** | **string**| Filter trades with specified order ID. &#x60;currency_pair&#x60; is also required if this field is present | [optional] 
 **account** | **string**| Specify query account. | [optional] 
 **from** | **long?**| Start timestamp of the query | [optional] 
 **to** | **long?**| Time range ending, default to current time | [optional] 

### Return type

[**List&lt;Trade&gt;**](Trade.md)

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

<a name="getsystemtime"></a>
# **GetSystemTime**
> SystemTime GetSystemTime ()

Get server current time

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetSystemTimeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new SpotApi(config);

            try
            {
                // Get server current time
                SystemTime result = apiInstance.GetSystemTime();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.GetSystemTime: " + e.Message);
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

[**SystemTime**](SystemTime.md)

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

<a name="countdowncancelallspot"></a>
# **CountdownCancelAllSpot**
> TriggerTime CountdownCancelAllSpot (CountdownCancelAllSpotTask countdownCancelAllSpotTask)

Countdown cancel orders

When the timeout set by the user is reached, if there is no cancel or set a new countdown, the related pending orders will be automatically cancelled.  This endpoint can be called repeatedly to set a new countdown or cancel the countdown. For example, call this endpoint at 30s intervals, each countdown`timeout` is set to 30s. If this endpoint is not called again within 30 seconds, all pending orders on the specified `market` will be automatically cancelled, if no `market` is specified, all market pending orders will be cancelled. If the `timeout` is set to 0 within 30 seconds, the countdown timer will expire and the cacnel function will be cancelled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CountdownCancelAllSpotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var countdownCancelAllSpotTask = new CountdownCancelAllSpotTask(); // CountdownCancelAllSpotTask | 

            try
            {
                // Countdown cancel orders
                TriggerTime result = apiInstance.CountdownCancelAllSpot(countdownCancelAllSpotTask);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.CountdownCancelAllSpot: " + e.Message);
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
 **countdownCancelAllSpotTask** | [**CountdownCancelAllSpotTask**](CountdownCancelAllSpotTask.md)|  | 

### Return type

[**TriggerTime**](TriggerTime.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Set countdown successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="amendbatchorders"></a>
# **AmendBatchOrders**
> List&lt;BatchOrder&gt; AmendBatchOrders (List<BatchAmendItem> batchAmendItem, long? xGateExptime = null)

Batch modification of orders

By default modify orders for spot, unified account and leverage account. Currently, only the price or quantity modification (choose one of two) Modify unfinished orders, up to 5 orders can be modified in batches at a time. The request parameters should be passed in array format. When the order modification fails during batch modification, the modification of the order will continue to be executed. After execution, the failure information of the corresponding order will be carried The order of calling the batch modification order is consistent with the order list The order of return content of batch modification orders is consistent with the order list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class AmendBatchOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var batchAmendItem = new List<BatchAmendItem>(); // List<BatchAmendItem> | 
            var xGateExptime = 1689560679123;  // long? | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Batch modification of orders
                List<BatchOrder> result = apiInstance.AmendBatchOrders(batchAmendItem, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.AmendBatchOrders: " + e.Message);
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
 **batchAmendItem** | [**List&lt;BatchAmendItem&gt;**](BatchAmendItem.md)|  | 
 **xGateExptime** | **long?**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**List&lt;BatchOrder&gt;**](BatchOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order modification executed successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getspotinsurancehistory"></a>
# **GetSpotInsuranceHistory**
> List&lt;SpotInsuranceHistory&gt; GetSpotInsuranceHistory (string business, string currency, long from, long to, int? page = null, int? limit = null)

Query spot insurance fund historical data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetSpotInsuranceHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new SpotApi(config);
            var business = "margin";  // string | Leverage business, margin - position by position; unified - unified account
            var currency = "BTC";  // string | Currency
            var from = 1547706332;  // long | Start timestamp, seconds
            var to = 1547706332;  // long | End timestamp, in seconds
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 30;  // int? | The maximum number of items returned in the list, the default value is 30 (optional)  (default to 30)

            try
            {
                // Query spot insurance fund historical data
                List<SpotInsuranceHistory> result = apiInstance.GetSpotInsuranceHistory(business, currency, from, to, page, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.GetSpotInsuranceHistory: " + e.Message);
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
 **business** | **string**| Leverage business, margin - position by position; unified - unified account | 
 **currency** | **string**| Currency | 
 **from** | **long**| Start timestamp, seconds | 
 **to** | **long**| End timestamp, in seconds | 
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| The maximum number of items returned in the list, the default value is 30 | [optional] [default to 30]

### Return type

[**List&lt;SpotInsuranceHistory&gt;**](SpotInsuranceHistory.md)

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

<a name="listspotpricetriggeredorders"></a>
# **ListSpotPriceTriggeredOrders**
> List&lt;SpotPriceTriggeredOrder&gt; ListSpotPriceTriggeredOrders (string status, string market = null, string account = null, int? limit = null, int? offset = null)

Retrieve running auto order list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSpotPriceTriggeredOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var status = "status_example";  // string | Only list the orders with this status
            var market = "BTC_USDT";  // string | Currency pair (optional) 
            var account = "account_example";  // string | Trading account type.  Portfolio margin account must set to `unified` (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)

            try
            {
                // Retrieve running auto order list
                List<SpotPriceTriggeredOrder> result = apiInstance.ListSpotPriceTriggeredOrders(status, market, account, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.ListSpotPriceTriggeredOrders: " + e.Message);
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
 **status** | **string**| Only list the orders with this status | 
 **market** | **string**| Currency pair | [optional] 
 **account** | **string**| Trading account type.  Portfolio margin account must set to &#x60;unified&#x60; | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]

### Return type

[**List&lt;SpotPriceTriggeredOrder&gt;**](SpotPriceTriggeredOrder.md)

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

<a name="createspotpricetriggeredorder"></a>
# **CreateSpotPriceTriggeredOrder**
> TriggerOrderResponse CreateSpotPriceTriggeredOrder (SpotPriceTriggeredOrder spotPriceTriggeredOrder)

Create a price-triggered order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateSpotPriceTriggeredOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var spotPriceTriggeredOrder = new SpotPriceTriggeredOrder(); // SpotPriceTriggeredOrder | 

            try
            {
                // Create a price-triggered order
                TriggerOrderResponse result = apiInstance.CreateSpotPriceTriggeredOrder(spotPriceTriggeredOrder);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.CreateSpotPriceTriggeredOrder: " + e.Message);
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
 **spotPriceTriggeredOrder** | [**SpotPriceTriggeredOrder**](SpotPriceTriggeredOrder.md)|  | 

### Return type

[**TriggerOrderResponse**](TriggerOrderResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Order created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelspotpricetriggeredorderlist"></a>
# **CancelSpotPriceTriggeredOrderList**
> List&lt;SpotPriceTriggeredOrder&gt; CancelSpotPriceTriggeredOrderList (string market = null, string account = null)

Cancel All Price-triggered Orders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelSpotPriceTriggeredOrderListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var market = "BTC_USDT";  // string | Currency pair (optional) 
            var account = "account_example";  // string | Trading account type.  Portfolio margin account must set to `unified` (optional) 

            try
            {
                // Cancel All Price-triggered Orders
                List<SpotPriceTriggeredOrder> result = apiInstance.CancelSpotPriceTriggeredOrderList(market, account);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.CancelSpotPriceTriggeredOrderList: " + e.Message);
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
 **market** | **string**| Currency pair | [optional] 
 **account** | **string**| Trading account type.  Portfolio margin account must set to &#x60;unified&#x60; | [optional] 

### Return type

[**List&lt;SpotPriceTriggeredOrder&gt;**](SpotPriceTriggeredOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Batch cancellation request accepted. Query order status by listing orders |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getspotpricetriggeredorder"></a>
# **GetSpotPriceTriggeredOrder**
> SpotPriceTriggeredOrder GetSpotPriceTriggeredOrder (string orderId)

Get a price-triggered order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetSpotPriceTriggeredOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var orderId = "orderId_example";  // string | Retrieve the data of the order with the specified ID

            try
            {
                // Get a price-triggered order
                SpotPriceTriggeredOrder result = apiInstance.GetSpotPriceTriggeredOrder(orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.GetSpotPriceTriggeredOrder: " + e.Message);
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
 **orderId** | **string**| Retrieve the data of the order with the specified ID | 

### Return type

[**SpotPriceTriggeredOrder**](SpotPriceTriggeredOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Auto order detail |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelspotpricetriggeredorder"></a>
# **CancelSpotPriceTriggeredOrder**
> SpotPriceTriggeredOrder CancelSpotPriceTriggeredOrder (string orderId)

cancel a price-triggered order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelSpotPriceTriggeredOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new SpotApi(config);
            var orderId = "orderId_example";  // string | Retrieve the data of the order with the specified ID

            try
            {
                // cancel a price-triggered order
                SpotPriceTriggeredOrder result = apiInstance.CancelSpotPriceTriggeredOrder(orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SpotApi.CancelSpotPriceTriggeredOrder: " + e.Message);
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
 **orderId** | **string**| Retrieve the data of the order with the specified ID | 

### Return type

[**SpotPriceTriggeredOrder**](SpotPriceTriggeredOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Auto order detail |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

