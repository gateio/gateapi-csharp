# Io.Gate.GateApi.Api.FuturesApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListFuturesContracts**](FuturesApi.md#listfuturescontracts) | **GET** /futures/{settle}/contracts | List all futures contracts.
[**GetFuturesContract**](FuturesApi.md#getfuturescontract) | **GET** /futures/{settle}/contracts/{contract} | Get a single contract.
[**ListFuturesOrderBook**](FuturesApi.md#listfuturesorderbook) | **GET** /futures/{settle}/order_book | Futures order book.
[**ListFuturesTrades**](FuturesApi.md#listfuturestrades) | **GET** /futures/{settle}/trades | Futures trading history.
[**ListFuturesCandlesticks**](FuturesApi.md#listfuturescandlesticks) | **GET** /futures/{settle}/candlesticks | Get futures candlesticks.
[**ListFuturesPremiumIndex**](FuturesApi.md#listfuturespremiumindex) | **GET** /futures/{settle}/premium_index | Premium Index K-Line.
[**ListFuturesTickers**](FuturesApi.md#listfuturestickers) | **GET** /futures/{settle}/tickers | List futures tickers.
[**ListFuturesFundingRateHistory**](FuturesApi.md#listfuturesfundingratehistory) | **GET** /futures/{settle}/funding_rate | Funding rate history.
[**ListFuturesInsuranceLedger**](FuturesApi.md#listfuturesinsuranceledger) | **GET** /futures/{settle}/insurance | Futures insurance balance history.
[**ListContractStats**](FuturesApi.md#listcontractstats) | **GET** /futures/{settle}/contract_stats | Futures stats.
[**GetIndexConstituents**](FuturesApi.md#getindexconstituents) | **GET** /futures/{settle}/index_constituents/{index} | Get index constituents.
[**ListLiquidatedOrders**](FuturesApi.md#listliquidatedorders) | **GET** /futures/{settle}/liq_orders | Retrieve liquidation history.
[**ListFuturesRiskLimitTiers**](FuturesApi.md#listfuturesrisklimittiers) | **GET** /futures/{settle}/risk_limit_tiers | List risk limit tiers.
[**ListFuturesAccounts**](FuturesApi.md#listfuturesaccounts) | **GET** /futures/{settle}/accounts | Query futures account.
[**ListFuturesAccountBook**](FuturesApi.md#listfuturesaccountbook) | **GET** /futures/{settle}/account_book | Query account book.
[**ListPositions**](FuturesApi.md#listpositions) | **GET** /futures/{settle}/positions | List all positions of a user.
[**GetPosition**](FuturesApi.md#getposition) | **GET** /futures/{settle}/positions/{contract} | Get single position.
[**UpdatePositionMargin**](FuturesApi.md#updatepositionmargin) | **POST** /futures/{settle}/positions/{contract}/margin | Update position margin.
[**UpdatePositionLeverage**](FuturesApi.md#updatepositionleverage) | **POST** /futures/{settle}/positions/{contract}/leverage | Update position leverage.
[**UpdatePositionCrossMode**](FuturesApi.md#updatepositioncrossmode) | **POST** /futures/{settle}/positions/cross_mode | Switch to the full position-by-store mode.
[**UpdateDualCompPositionCrossMode**](FuturesApi.md#updatedualcomppositioncrossmode) | **POST** /futures/{settle}/dual_comp/positions/cross_mode | 双仓模式下切换全逐仓模式
[**UpdatePositionRiskLimit**](FuturesApi.md#updatepositionrisklimit) | **POST** /futures/{settle}/positions/{contract}/risk_limit | Update position risk limit.
[**SetDualMode**](FuturesApi.md#setdualmode) | **POST** /futures/{settle}/dual_mode | Enable or disable dual mode.
[**GetDualModePosition**](FuturesApi.md#getdualmodeposition) | **GET** /futures/{settle}/dual_comp/positions/{contract} | Retrieve position detail in dual mode.
[**UpdateDualModePositionMargin**](FuturesApi.md#updatedualmodepositionmargin) | **POST** /futures/{settle}/dual_comp/positions/{contract}/margin | Update position margin in dual mode.
[**UpdateDualModePositionLeverage**](FuturesApi.md#updatedualmodepositionleverage) | **POST** /futures/{settle}/dual_comp/positions/{contract}/leverage | Update position leverage in dual mode.
[**UpdateDualModePositionRiskLimit**](FuturesApi.md#updatedualmodepositionrisklimit) | **POST** /futures/{settle}/dual_comp/positions/{contract}/risk_limit | Update position risk limit in dual mode.
[**ListFuturesOrders**](FuturesApi.md#listfuturesorders) | **GET** /futures/{settle}/orders | List futures orders.
[**CreateFuturesOrder**](FuturesApi.md#createfuturesorder) | **POST** /futures/{settle}/orders | Create a futures order.
[**CancelFuturesOrders**](FuturesApi.md#cancelfuturesorders) | **DELETE** /futures/{settle}/orders | Cancel all &#x60;open&#x60; orders matched.
[**GetOrdersWithTimeRange**](FuturesApi.md#getorderswithtimerange) | **GET** /futures/{settle}/orders_timerange | List Futures Orders By Time Range.
[**CreateBatchFuturesOrder**](FuturesApi.md#createbatchfuturesorder) | **POST** /futures/{settle}/batch_orders | Create a batch of futures orders.
[**GetFuturesOrder**](FuturesApi.md#getfuturesorder) | **GET** /futures/{settle}/orders/{order_id} | Get a single order.
[**AmendFuturesOrder**](FuturesApi.md#amendfuturesorder) | **PUT** /futures/{settle}/orders/{order_id} | Amend an order.
[**CancelFuturesOrder**](FuturesApi.md#cancelfuturesorder) | **DELETE** /futures/{settle}/orders/{order_id} | Cancel a single order.
[**GetMyTrades**](FuturesApi.md#getmytrades) | **GET** /futures/{settle}/my_trades | List personal trading history.
[**GetMyTradesWithTimeRange**](FuturesApi.md#getmytradeswithtimerange) | **GET** /futures/{settle}/my_trades_timerange | List personal trading history by time range.
[**ListPositionClose**](FuturesApi.md#listpositionclose) | **GET** /futures/{settle}/position_close | List position close history.
[**ListLiquidates**](FuturesApi.md#listliquidates) | **GET** /futures/{settle}/liquidates | List liquidation history.
[**ListAutoDeleverages**](FuturesApi.md#listautodeleverages) | **GET** /futures/{settle}/auto_deleverages | List Auto-Deleveraging History.
[**CountdownCancelAllFutures**](FuturesApi.md#countdowncancelallfutures) | **POST** /futures/{settle}/countdown_cancel_all | Countdown cancel orders.
[**GetFuturesFee**](FuturesApi.md#getfuturesfee) | **GET** /futures/{settle}/fee | Query user trading fee rates.
[**CancelBatchFutureOrders**](FuturesApi.md#cancelbatchfutureorders) | **POST** /futures/{settle}/batch_cancel_orders | Cancel a batch of orders with an ID list.
[**AmendBatchFutureOrders**](FuturesApi.md#amendbatchfutureorders) | **POST** /futures/{settle}/batch_amend_orders | Batch modify orders with specified IDs.
[**GetFuturesRiskLimitTable**](FuturesApi.md#getfuturesrisklimittable) | **GET** /futures/{settle}/risk_limit_table | Query risk limit table by table_id.
[**ListPriceTriggeredOrders**](FuturesApi.md#listpricetriggeredorders) | **GET** /futures/{settle}/price_orders | List All Price-triggered Orders.
[**CreatePriceTriggeredOrder**](FuturesApi.md#createpricetriggeredorder) | **POST** /futures/{settle}/price_orders | Create a price-triggered order.
[**CancelPriceTriggeredOrderList**](FuturesApi.md#cancelpricetriggeredorderlist) | **DELETE** /futures/{settle}/price_orders | Cancel All Price-triggered Orders.
[**GetPriceTriggeredOrder**](FuturesApi.md#getpricetriggeredorder) | **GET** /futures/{settle}/price_orders/{order_id} | Get a price-triggered order.
[**CancelPriceTriggeredOrder**](FuturesApi.md#cancelpricetriggeredorder) | **DELETE** /futures/{settle}/price_orders/{order_id} | cancel a price-triggered order.


<a name="listfuturescontracts"></a>
# **ListFuturesContracts**
> List&lt;Contract&gt; ListFuturesContracts (string settle, int? limit = null, int? offset = null)

List all futures contracts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFuturesContractsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var limit = 100;  // int? | Maximum number of records to be returned in a single list. (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0. (optional)  (default to 0)

            try
            {
                // List all futures contracts.
                List<Contract> result = apiInstance.ListFuturesContracts(settle, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesContracts: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **limit** | **int?**| Maximum number of records to be returned in a single list. | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0. | [optional] [default to 0]

### Return type

[**List&lt;Contract&gt;**](Contract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfuturescontract"></a>
# **GetFuturesContract**
> Contract GetFuturesContract (string settle, string contract)

Get a single contract.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetFuturesContractExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract.

            try
            {
                // Get a single contract.
                Contract result = apiInstance.GetFuturesContract(settle, contract);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.GetFuturesContract: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract. | 

### Return type

[**Contract**](Contract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Contract information. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturesorderbook"></a>
# **ListFuturesOrderBook**
> FuturesOrderBook ListFuturesOrderBook (string settle, string contract, string interval = null, int? limit = null, bool? withId = null)

Futures order book.

Bids will be sorted by price from high to low, while asks sorted reversely.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFuturesOrderBookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract.
            var interval = "\"0\"";  // string | Order depth. 0 means no aggregation is applied. default to 0. (optional)  (default to "0")
            var limit = 10;  // int? | Maximum number of order depth data in asks or bids. (optional)  (default to 10)
            var withId = false;  // bool? | Whether to return depth update ID. This ID increments by 1 each time. (optional)  (default to false)

            try
            {
                // Futures order book.
                FuturesOrderBook result = apiInstance.ListFuturesOrderBook(settle, contract, interval, limit, withId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesOrderBook: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract. | 
 **interval** | **string**| Order depth. 0 means no aggregation is applied. default to 0. | [optional] [default to &quot;0&quot;]
 **limit** | **int?**| Maximum number of order depth data in asks or bids. | [optional] [default to 10]
 **withId** | **bool?**| Whether to return depth update ID. This ID increments by 1 each time. | [optional] [default to false]

### Return type

[**FuturesOrderBook**](FuturesOrderBook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Depth query successful. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturestrades"></a>
# **ListFuturesTrades**
> List&lt;FuturesTrade&gt; ListFuturesTrades (string settle, string contract, int? limit = null, int? offset = null, string lastId = null, long? from = null, long? to = null)

Futures trading history.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFuturesTradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract.
            var limit = 100;  // int? | Maximum number of records to be returned in a single list. (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0. (optional)  (default to 0)
            var lastId = "12345";  // string | Specify the starting point for this list based on a previously retrieved id  This parameter is deprecated. Use `from` and `to` instead to limit time range (optional) 
            var from = 1546905600;  // long? | Specify starting time in Unix seconds. If not specified, `to` and `limit` will be used to limit response items. If items between `from` and `to` are more than `limit`, only `limit` number will be returned.  (optional) 
            var to = 1546935600;  // long? | Specify end time in Unix seconds, default to current time. (optional) 

            try
            {
                // Futures trading history.
                List<FuturesTrade> result = apiInstance.ListFuturesTrades(settle, contract, limit, offset, lastId, from, to);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesTrades: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract. | 
 **limit** | **int?**| Maximum number of records to be returned in a single list. | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0. | [optional] [default to 0]
 **lastId** | **string**| Specify the starting point for this list based on a previously retrieved id  This parameter is deprecated. Use &#x60;from&#x60; and &#x60;to&#x60; instead to limit time range | [optional] 
 **from** | **long?**| Specify starting time in Unix seconds. If not specified, &#x60;to&#x60; and &#x60;limit&#x60; will be used to limit response items. If items between &#x60;from&#x60; and &#x60;to&#x60; are more than &#x60;limit&#x60;, only &#x60;limit&#x60; number will be returned.  | [optional] 
 **to** | **long?**| Specify end time in Unix seconds, default to current time. | [optional] 

### Return type

[**List&lt;FuturesTrade&gt;**](FuturesTrade.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturescandlesticks"></a>
# **ListFuturesCandlesticks**
> List&lt;FuturesCandlestick&gt; ListFuturesCandlesticks (string settle, string contract, long? from = null, long? to = null, int? limit = null, string interval = null)

Get futures candlesticks.

Return specified contract candlesticks. If prefix `contract` with `mark_`, the contract's mark price candlesticks are returned; if prefix with `index_`, index price candlesticks will be returned.  Maximum of 2000 points are returned in one query. Be sure not to exceed the limit when specifying `from`, `to` and `interval`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFuturesCandlesticksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract.
            var from = 1546905600;  // long? | Start time of candlesticks, formatted in Unix timestamp in seconds. Default to`to - 100 * interval` if not specified (optional) 
            var to = 1546935600;  // long? | Specify the end time of the K-line chart, defaults to current time if not specified, note that the time format is Unix timestamp with second precision specified (optional) 
            var limit = 100;  // int? | Maximum recent data points to return. `limit` is conflicted with `from` and `to`. If either `from` or `to` is specified, request will be rejected. (optional)  (default to 100)
            var interval = "5m";  // string | Interval time between data points. Note that `1w` means natual week(Mon-Sun), while `7d` means every 7d since unix 0. 1 natual month, not 30 days (optional)  (default to 5m)

            try
            {
                // Get futures candlesticks.
                List<FuturesCandlestick> result = apiInstance.ListFuturesCandlesticks(settle, contract, from, to, limit, interval);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesCandlesticks: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract. | 
 **from** | **long?**| Start time of candlesticks, formatted in Unix timestamp in seconds. Default to&#x60;to - 100 * interval&#x60; if not specified | [optional] 
 **to** | **long?**| Specify the end time of the K-line chart, defaults to current time if not specified, note that the time format is Unix timestamp with second precision specified | [optional] 
 **limit** | **int?**| Maximum recent data points to return. &#x60;limit&#x60; is conflicted with &#x60;from&#x60; and &#x60;to&#x60;. If either &#x60;from&#x60; or &#x60;to&#x60; is specified, request will be rejected. | [optional] [default to 100]
 **interval** | **string**| Interval time between data points. Note that &#x60;1w&#x60; means natual week(Mon-Sun), while &#x60;7d&#x60; means every 7d since unix 0. 1 natual month, not 30 days | [optional] [default to 5m]

### Return type

[**List&lt;FuturesCandlestick&gt;**](FuturesCandlestick.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturespremiumindex"></a>
# **ListFuturesPremiumIndex**
> List&lt;FuturesPremiumIndex&gt; ListFuturesPremiumIndex (string settle, string contract, long? from = null, long? to = null, int? limit = null, string interval = null)

Premium Index K-Line.

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
    public class ListFuturesPremiumIndexExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract.
            var from = 1546905600;  // long? | Start time of candlesticks, formatted in Unix timestamp in seconds. Default to`to - 100 * interval` if not specified (optional) 
            var to = 1546935600;  // long? | Specify the end time of the K-line chart, defaults to current time if not specified, note that the time format is Unix timestamp with second precision specified (optional) 
            var limit = 100;  // int? | Maximum recent data points to return. `limit` is conflicted with `from` and `to`. If either `from` or `to` is specified, request will be rejected. (optional)  (default to 100)
            var interval = "5m";  // string | Interval time between data points. (optional)  (default to 5m)

            try
            {
                // Premium Index K-Line.
                List<FuturesPremiumIndex> result = apiInstance.ListFuturesPremiumIndex(settle, contract, from, to, limit, interval);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesPremiumIndex: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract. | 
 **from** | **long?**| Start time of candlesticks, formatted in Unix timestamp in seconds. Default to&#x60;to - 100 * interval&#x60; if not specified | [optional] 
 **to** | **long?**| Specify the end time of the K-line chart, defaults to current time if not specified, note that the time format is Unix timestamp with second precision specified | [optional] 
 **limit** | **int?**| Maximum recent data points to return. &#x60;limit&#x60; is conflicted with &#x60;from&#x60; and &#x60;to&#x60;. If either &#x60;from&#x60; or &#x60;to&#x60; is specified, request will be rejected. | [optional] [default to 100]
 **interval** | **string**| Interval time between data points. | [optional] [default to 5m]

### Return type

[**List&lt;FuturesPremiumIndex&gt;**](FuturesPremiumIndex.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturestickers"></a>
# **ListFuturesTickers**
> List&lt;FuturesTicker&gt; ListFuturesTickers (string settle, string contract = null)

List futures tickers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFuturesTickersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified. (optional) 

            try
            {
                // List futures tickers.
                List<FuturesTicker> result = apiInstance.ListFuturesTickers(settle, contract);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesTickers: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract, return related data only if specified. | [optional] 

### Return type

[**List&lt;FuturesTicker&gt;**](FuturesTicker.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturesfundingratehistory"></a>
# **ListFuturesFundingRateHistory**
> List&lt;FundingRateRecord&gt; ListFuturesFundingRateHistory (string settle, string contract, int? limit = null, long? from = null, long? to = null)

Funding rate history.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFuturesFundingRateHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract.
            var limit = 100;  // int? | Maximum number of records to be returned in a single list. (optional)  (default to 100)
            var from = 1547706332;  // long? | Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) (optional) 
            var to = 1547706332;  // long? | Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp (optional) 

            try
            {
                // Funding rate history.
                List<FundingRateRecord> result = apiInstance.ListFuturesFundingRateHistory(settle, contract, limit, from, to);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesFundingRateHistory: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract. | 
 **limit** | **int?**| Maximum number of records to be returned in a single list. | [optional] [default to 100]
 **from** | **long?**| Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) | [optional] 
 **to** | **long?**| Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp | [optional] 

### Return type

[**List&lt;FundingRateRecord&gt;**](FundingRateRecord.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | History retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturesinsuranceledger"></a>
# **ListFuturesInsuranceLedger**
> List&lt;InsuranceRecord&gt; ListFuturesInsuranceLedger (string settle, int? limit = null)

Futures insurance balance history.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFuturesInsuranceLedgerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var limit = 100;  // int? | Maximum number of records to be returned in a single list. (optional)  (default to 100)

            try
            {
                // Futures insurance balance history.
                List<InsuranceRecord> result = apiInstance.ListFuturesInsuranceLedger(settle, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesInsuranceLedger: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **limit** | **int?**| Maximum number of records to be returned in a single list. | [optional] [default to 100]

### Return type

[**List&lt;InsuranceRecord&gt;**](InsuranceRecord.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcontractstats"></a>
# **ListContractStats**
> List&lt;ContractStat&gt; ListContractStats (string settle, string contract, long? from = null, string interval = null, int? limit = null)

Futures stats.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListContractStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract.
            var from = 1604561000;  // long? | Start timestamp. (optional) 
            var interval = "\"5m\"";  // string |  (optional)  (default to "5m")
            var limit = 30;  // int? |  (optional)  (default to 30)

            try
            {
                // Futures stats.
                List<ContractStat> result = apiInstance.ListContractStats(settle, contract, from, interval, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListContractStats: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract. | 
 **from** | **long?**| Start timestamp. | [optional] 
 **interval** | **string**|  | [optional] [default to &quot;5m&quot;]
 **limit** | **int?**|  | [optional] [default to 30]

### Return type

[**List&lt;ContractStat&gt;**](ContractStat.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getindexconstituents"></a>
# **GetIndexConstituents**
> FuturesIndexConstituents GetIndexConstituents (string settle, string index)

Get index constituents.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetIndexConstituentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var index = "BTC_USDT";  // string | Index name.

            try
            {
                // Get index constituents.
                FuturesIndexConstituents result = apiInstance.GetIndexConstituents(settle, index);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.GetIndexConstituents: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **index** | **string**| Index name. | 

### Return type

[**FuturesIndexConstituents**](FuturesIndexConstituents.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listliquidatedorders"></a>
# **ListLiquidatedOrders**
> List&lt;FuturesLiqOrder&gt; ListLiquidatedOrders (string settle, string contract = null, long? from = null, long? to = null, int? limit = null)

Retrieve liquidation history.

The time interval between from and to is maximum 3600. Some private fields are not returned by public interfaces, refer to field descriptions for interfaces, refer to field descriptions for details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListLiquidatedOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified. (optional) 
            var from = 1547706332;  // long? | Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) (optional) 
            var to = 1547706332;  // long? | Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list. (optional)  (default to 100)

            try
            {
                // Retrieve liquidation history.
                List<FuturesLiqOrder> result = apiInstance.ListLiquidatedOrders(settle, contract, from, to, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListLiquidatedOrders: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract, return related data only if specified. | [optional] 
 **from** | **long?**| Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) | [optional] 
 **to** | **long?**| Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list. | [optional] [default to 100]

### Return type

[**List&lt;FuturesLiqOrder&gt;**](FuturesLiqOrder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturesrisklimittiers"></a>
# **ListFuturesRiskLimitTiers**
> List&lt;FuturesLimitRiskTiers&gt; ListFuturesRiskLimitTiers (string settle, string contract = null, int? limit = null, int? offset = null)

List risk limit tiers.

When the 'contract' parameter is not passed, the default is to query the risk limits for the top 100 markets.'Limit' and 'offset' correspond to pagination queries at the market level, not to the length of the returned array. This only takes effect empty.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFuturesRiskLimitTiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified. (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list. (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0. (optional)  (default to 0)

            try
            {
                // List risk limit tiers.
                List<FuturesLimitRiskTiers> result = apiInstance.ListFuturesRiskLimitTiers(settle, contract, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesRiskLimitTiers: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract, return related data only if specified. | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list. | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0. | [optional] [default to 0]

### Return type

[**List&lt;FuturesLimitRiskTiers&gt;**](FuturesLimitRiskTiers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturesaccounts"></a>
# **ListFuturesAccounts**
> FuturesAccount ListFuturesAccounts (string settle)

Query futures account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFuturesAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.

            try
            {
                // Query futures account.
                FuturesAccount result = apiInstance.ListFuturesAccounts(settle);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesAccounts: " + e.Message);
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
 **settle** | **string**| Settle currency. | 

### Return type

[**FuturesAccount**](FuturesAccount.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturesaccountbook"></a>
# **ListFuturesAccountBook**
> List&lt;FuturesAccountBook&gt; ListFuturesAccountBook (string settle, string contract = null, int? limit = null, int? offset = null, long? from = null, long? to = null, string type = null)

Query account book.

If the contract field is passed, only records containing this field after 2023-10-30 can be filtered。 2023-10-30 can be filtered.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFuturesAccountBookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified. (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list. (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0. (optional)  (default to 0)
            var from = 1547706332;  // long? | Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) (optional) 
            var to = 1547706332;  // long? | Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp (optional) 
            var type = "dnw";  // string | Changing Type：  - dnw: Deposit & Withdraw - pnl: Profit & Loss by reducing position - fee: Trading fee - refr: Referrer rebate - fund: Funding - point_dnw: point_fee: POINT Trading fee - point_refr: POINT Referrer rebate - bonus_offset: bouns deduction (optional) 

            try
            {
                // Query account book.
                List<FuturesAccountBook> result = apiInstance.ListFuturesAccountBook(settle, contract, limit, offset, from, to, type);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesAccountBook: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract, return related data only if specified. | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list. | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0. | [optional] [default to 0]
 **from** | **long?**| Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) | [optional] 
 **to** | **long?**| Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp | [optional] 
 **type** | **string**| Changing Type：  - dnw: Deposit &amp; Withdraw - pnl: Profit &amp; Loss by reducing position - fee: Trading fee - refr: Referrer rebate - fund: Funding - point_dnw: point_fee: POINT Trading fee - point_refr: POINT Referrer rebate - bonus_offset: bouns deduction | [optional] 

### Return type

[**List&lt;FuturesAccountBook&gt;**](FuturesAccountBook.md)

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

<a name="listpositions"></a>
# **ListPositions**
> List&lt;Position&gt; ListPositions (string settle, bool? holding = null, int? limit = null, int? offset = null)

List all positions of a user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListPositionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var holding = true;  // bool? | Return only real positions - true, return all - false. (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list. (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0. (optional)  (default to 0)

            try
            {
                // List all positions of a user.
                List<Position> result = apiInstance.ListPositions(settle, holding, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListPositions: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **holding** | **bool?**| Return only real positions - true, return all - false. | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list. | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0. | [optional] [default to 0]

### Return type

[**List&lt;Position&gt;**](Position.md)

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

<a name="getposition"></a>
# **GetPosition**
> Position GetPosition (string settle, string contract)

Get single position.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetPositionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract.

            try
            {
                // Get single position.
                Position result = apiInstance.GetPosition(settle, contract);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.GetPosition: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract. | 

### Return type

[**Position**](Position.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Position information. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepositionmargin"></a>
# **UpdatePositionMargin**
> Position UpdatePositionMargin (string settle, string contract, string change)

Update position margin.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UpdatePositionMarginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract.
            var change = "0.01";  // string | Margin change amount, positive number increases, negative number.

            try
            {
                // Update position margin.
                Position result = apiInstance.UpdatePositionMargin(settle, contract, change);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.UpdatePositionMargin: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract. | 
 **change** | **string**| Margin change amount, positive number increases, negative number. | 

### Return type

[**Position**](Position.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Position information. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepositionleverage"></a>
# **UpdatePositionLeverage**
> Position UpdatePositionLeverage (string settle, string contract, string leverage, string crossLeverageLimit = null)

Update position leverage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UpdatePositionLeverageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract.
            var leverage = "10";  // string | New position leverage.
            var crossLeverageLimit = "10";  // string | Cross margin leverage(valid only when `leverage` is 0). (optional) 

            try
            {
                // Update position leverage.
                Position result = apiInstance.UpdatePositionLeverage(settle, contract, leverage, crossLeverageLimit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.UpdatePositionLeverage: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract. | 
 **leverage** | **string**| New position leverage. | 
 **crossLeverageLimit** | **string**| Cross margin leverage(valid only when &#x60;leverage&#x60; is 0). | [optional] 

### Return type

[**Position**](Position.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Position information. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepositioncrossmode"></a>
# **UpdatePositionCrossMode**
> Position UpdatePositionCrossMode (string settle, FuturesPositionCrossMode futuresPositionCrossMode)

Switch to the full position-by-store mode.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UpdatePositionCrossModeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var futuresPositionCrossMode = new FuturesPositionCrossMode(); // FuturesPositionCrossMode | 

            try
            {
                // Switch to the full position-by-store mode.
                Position result = apiInstance.UpdatePositionCrossMode(settle, futuresPositionCrossMode);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.UpdatePositionCrossMode: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **futuresPositionCrossMode** | [**FuturesPositionCrossMode**](FuturesPositionCrossMode.md)|  | 

### Return type

[**Position**](Position.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Position information. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedualcomppositioncrossmode"></a>
# **UpdateDualCompPositionCrossMode**
> List&lt;Position&gt; UpdateDualCompPositionCrossMode (string settle, InlineObject inlineObject)

双仓模式下切换全逐仓模式

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UpdateDualCompPositionCrossModeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var inlineObject = new InlineObject(); // InlineObject | 

            try
            {
                // 双仓模式下切换全逐仓模式
                List<Position> result = apiInstance.UpdateDualCompPositionCrossMode(settle, inlineObject);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.UpdateDualCompPositionCrossMode: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **inlineObject** | [**InlineObject**](InlineObject.md)|  | 

### Return type

[**List&lt;Position&gt;**](Position.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepositionrisklimit"></a>
# **UpdatePositionRiskLimit**
> Position UpdatePositionRiskLimit (string settle, string contract, string riskLimit)

Update position risk limit.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UpdatePositionRiskLimitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract.
            var riskLimit = "1000000";  // string | New Risk Limit Value.

            try
            {
                // Update position risk limit.
                Position result = apiInstance.UpdatePositionRiskLimit(settle, contract, riskLimit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.UpdatePositionRiskLimit: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract. | 
 **riskLimit** | **string**| New Risk Limit Value. | 

### Return type

[**Position**](Position.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Position information. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setdualmode"></a>
# **SetDualMode**
> FuturesAccount SetDualMode (string settle, bool dualMode)

Enable or disable dual mode.

The prerequisite for changing mode is that all positions have no holdings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class SetDualModeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var dualMode = true;  // bool | Whether to enable dual mode.

            try
            {
                // Enable or disable dual mode.
                FuturesAccount result = apiInstance.SetDualMode(settle, dualMode);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.SetDualMode: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **dualMode** | **bool**| Whether to enable dual mode. | 

### Return type

[**FuturesAccount**](FuturesAccount.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdualmodeposition"></a>
# **GetDualModePosition**
> List&lt;Position&gt; GetDualModePosition (string settle, string contract)

Retrieve position detail in dual mode.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetDualModePositionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract.

            try
            {
                // Retrieve position detail in dual mode.
                List<Position> result = apiInstance.GetDualModePosition(settle, contract);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.GetDualModePosition: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract. | 

### Return type

[**List&lt;Position&gt;**](Position.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedualmodepositionmargin"></a>
# **UpdateDualModePositionMargin**
> List&lt;Position&gt; UpdateDualModePositionMargin (string settle, string contract, string change, string dualSide)

Update position margin in dual mode.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UpdateDualModePositionMarginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract.
            var change = "0.01";  // string | Margin change amount, positive number increases, negative number.
            var dualSide = "dual_long";  // string | Long or short position.

            try
            {
                // Update position margin in dual mode.
                List<Position> result = apiInstance.UpdateDualModePositionMargin(settle, contract, change, dualSide);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.UpdateDualModePositionMargin: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract. | 
 **change** | **string**| Margin change amount, positive number increases, negative number. | 
 **dualSide** | **string**| Long or short position. | 

### Return type

[**List&lt;Position&gt;**](Position.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedualmodepositionleverage"></a>
# **UpdateDualModePositionLeverage**
> List&lt;Position&gt; UpdateDualModePositionLeverage (string settle, string contract, string leverage, string crossLeverageLimit = null)

Update position leverage in dual mode.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UpdateDualModePositionLeverageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract.
            var leverage = "10";  // string | New position leverage.
            var crossLeverageLimit = "10";  // string | Cross margin leverage(valid only when `leverage` is 0). (optional) 

            try
            {
                // Update position leverage in dual mode.
                List<Position> result = apiInstance.UpdateDualModePositionLeverage(settle, contract, leverage, crossLeverageLimit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.UpdateDualModePositionLeverage: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract. | 
 **leverage** | **string**| New position leverage. | 
 **crossLeverageLimit** | **string**| Cross margin leverage(valid only when &#x60;leverage&#x60; is 0). | [optional] 

### Return type

[**List&lt;Position&gt;**](Position.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedualmodepositionrisklimit"></a>
# **UpdateDualModePositionRiskLimit**
> List&lt;Position&gt; UpdateDualModePositionRiskLimit (string settle, string contract, string riskLimit)

Update position risk limit in dual mode.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UpdateDualModePositionRiskLimitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract.
            var riskLimit = "1000000";  // string | New Risk Limit Value.

            try
            {
                // Update position risk limit in dual mode.
                List<Position> result = apiInstance.UpdateDualModePositionRiskLimit(settle, contract, riskLimit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.UpdateDualModePositionRiskLimit: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract. | 
 **riskLimit** | **string**| New Risk Limit Value. | 

### Return type

[**List&lt;Position&gt;**](Position.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturesorders"></a>
# **ListFuturesOrders**
> List&lt;FuturesOrder&gt; ListFuturesOrders (string settle, string status, string contract = null, int? limit = null, int? offset = null, string lastId = null)

List futures orders.

- Zero-fill order cannot be retrieved for 10 minutes after cancellation - Historical orders, by default, only data within the past 6 months is supported.  If you need to query data for a longer period, please use `GET /futures/{settle}/orders_timerange`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFuturesOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var status = "open";  // string | Only list the orders with this status.
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified. (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list. (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0. (optional)  (default to 0)
            var lastId = "12345";  // string | Specify the currency name to query in batches, and support up to 100 pass parameters at a time. (optional) 

            try
            {
                // List futures orders.
                List<FuturesOrder> result = apiInstance.ListFuturesOrders(settle, status, contract, limit, offset, lastId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListFuturesOrders: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **status** | **string**| Only list the orders with this status. | 
 **contract** | **string**| Futures contract, return related data only if specified. | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list. | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0. | [optional] [default to 0]
 **lastId** | **string**| Specify the currency name to query in batches, and support up to 100 pass parameters at a time. | [optional] 

### Return type

[**List&lt;FuturesOrder&gt;**](FuturesOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved. |  * X-Pagination-Limit - Request limit specified. <br>  * X-Pagination-Offset - Request offset specified. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfuturesorder"></a>
# **CreateFuturesOrder**
> FuturesOrder CreateFuturesOrder (string settle, FuturesOrder futuresOrder, string xGateExptime = null)

Create a futures order.

- When placing an order, the number of contracts is specified `size`, not the number of coins. The number of coins corresponding to each contract is returned in the contract details interface `quanto_multiplier` - 0 The order that was completed cannot be obtained after 10 minutes of withdrawal, and the order will be mentioned that the order does not exist - Setting `reduce_only` to `true` can prevent the position from being penetrated when reducing the position - In single-position mode, if you need to close the position, you need to set `size` to 0 and `close` to `true` - In dual warehouse mode,   - Reduce position: reduce_only=true, size is a positive number that indicates short position, negative number that indicates long position  - Add number that indicates adding long positions, and negative numbers indicate adding short positions  - Close position: size=0, set the direction of closing position according to auto_size, and set `reduce_only` to true  at the same time - reduce_only: Make sure to only perform position reduction operations to prevent increased positions - Set `stp_act` to determine the use of a strategy that restricts user transactions. For detailed usage, refer to the body parameter `stp_act`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateFuturesOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var futuresOrder = new FuturesOrder(); // FuturesOrder | 
            var xGateExptime = "1689560679123";  // string | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Create a futures order.
                FuturesOrder result = apiInstance.CreateFuturesOrder(settle, futuresOrder, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.CreateFuturesOrder: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **futuresOrder** | [**FuturesOrder**](FuturesOrder.md)|  | 
 **xGateExptime** | **string**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**FuturesOrder**](FuturesOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Order details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelfuturesorders"></a>
# **CancelFuturesOrders**
> List&lt;FuturesOrder&gt; CancelFuturesOrders (string settle, string contract, string xGateExptime = null, string side = null)

Cancel all `open` orders matched.

Zero-filled order cannot be retrieved 10 minutes after order cancellation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelFuturesOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract.
            var xGateExptime = "1689560679123";  // string | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 
            var side = "ask";  // string | Specify all buy orders or all sell orders, both are included if not specified. Set to bid, set to ask to cancel all sell ordersspecified. Set to bid, set to ask to cancel all sell ordersspecified. Set to bid, set to ask to cancel all sell orders (optional) 

            try
            {
                // Cancel all `open` orders matched.
                List<FuturesOrder> result = apiInstance.CancelFuturesOrders(settle, contract, xGateExptime, side);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.CancelFuturesOrders: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract. | 
 **xGateExptime** | **string**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 
 **side** | **string**| Specify all buy orders or all sell orders, both are included if not specified. Set to bid, set to ask to cancel all sell ordersspecified. Set to bid, set to ask to cancel all sell ordersspecified. Set to bid, set to ask to cancel all sell orders | [optional] 

### Return type

[**List&lt;FuturesOrder&gt;**](FuturesOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All orders matched cancelled. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderswithtimerange"></a>
# **GetOrdersWithTimeRange**
> List&lt;FuturesOrder&gt; GetOrdersWithTimeRange (string settle, string contract = null, long? from = null, long? to = null, int? limit = null, int? offset = null)

List Futures Orders By Time Range.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetOrdersWithTimeRangeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified. (optional) 
            var from = 1547706332;  // long? | Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) (optional) 
            var to = 1547706332;  // long? | Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list. (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0. (optional)  (default to 0)

            try
            {
                // List Futures Orders By Time Range.
                List<FuturesOrder> result = apiInstance.GetOrdersWithTimeRange(settle, contract, from, to, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.GetOrdersWithTimeRange: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract, return related data only if specified. | [optional] 
 **from** | **long?**| Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) | [optional] 
 **to** | **long?**| Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list. | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0. | [optional] [default to 0]

### Return type

[**List&lt;FuturesOrder&gt;**](FuturesOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved. |  * X-Pagination-Limit - Request limit specified. <br>  * X-Pagination-Offset - Request offset specified. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createbatchfuturesorder"></a>
# **CreateBatchFuturesOrder**
> List&lt;BatchFuturesOrder&gt; CreateBatchFuturesOrder (string settle, List<FuturesOrder> futuresOrder, string xGateExptime = null)

Create a batch of futures orders.

- Up to 10 orders per request - If any of the order's parameters are missing or in the wrong format, all of them will not be executed, and a http status 400 error will be returned directly - If the parameters are checked and passed, all are executed. Even if there is a business logic error in the middle (such as insufficient funds), it will not affect other execution orders - The returned result is in array format, and the order corresponds to the orders in the request body - In the returned result, the `succeeded` field of type bool indicates whether the execution was successful or not - If the execution is successful, the normal order content is included; if the execution fails, the `label` field is included to indicate the cause of the error - In the rate limiting, each order is counted individually

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateBatchFuturesOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var futuresOrder = new List<FuturesOrder>(); // List<FuturesOrder> | 
            var xGateExptime = "1689560679123";  // string | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Create a batch of futures orders.
                List<BatchFuturesOrder> result = apiInstance.CreateBatchFuturesOrder(settle, futuresOrder, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.CreateBatchFuturesOrder: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **futuresOrder** | [**List&lt;FuturesOrder&gt;**](FuturesOrder.md)|  | 
 **xGateExptime** | **string**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**List&lt;BatchFuturesOrder&gt;**](BatchFuturesOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request is completed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfuturesorder"></a>
# **GetFuturesOrder**
> FuturesOrder GetFuturesOrder (string settle, string orderId)

Get a single order.

- Zero-fill order cannot be retrieved for 10 minutes after cancellation - Historical orders, by default, only data within the past 6 months is supported.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetFuturesOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var orderId = "12345";  // string | Order ID returned, or user custom ID(i.e., `text` field). Operations based on custom ID can only be checked when the order is in orderbook. finished, it can be checked within 60 seconds after the end of the order. After that, only order ID is accepted.

            try
            {
                // Get a single order.
                FuturesOrder result = apiInstance.GetFuturesOrder(settle, orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.GetFuturesOrder: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **orderId** | **string**| Order ID returned, or user custom ID(i.e., &#x60;text&#x60; field). Operations based on custom ID can only be checked when the order is in orderbook. finished, it can be checked within 60 seconds after the end of the order. After that, only order ID is accepted. | 

### Return type

[**FuturesOrder**](FuturesOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="amendfuturesorder"></a>
# **AmendFuturesOrder**
> FuturesOrder AmendFuturesOrder (string settle, string orderId, FuturesOrderAmendment futuresOrderAmendment, string xGateExptime = null)

Amend an order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class AmendFuturesOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var orderId = "12345";  // string | Order ID returned, or user custom ID(i.e., `text` field). Operations based on custom ID can only be checked when the order is in orderbook. finished, it can be checked within 60 seconds after the end of the order. After that, only order ID is accepted.
            var futuresOrderAmendment = new FuturesOrderAmendment(); // FuturesOrderAmendment | 
            var xGateExptime = "1689560679123";  // string | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Amend an order.
                FuturesOrder result = apiInstance.AmendFuturesOrder(settle, orderId, futuresOrderAmendment, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.AmendFuturesOrder: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **orderId** | **string**| Order ID returned, or user custom ID(i.e., &#x60;text&#x60; field). Operations based on custom ID can only be checked when the order is in orderbook. finished, it can be checked within 60 seconds after the end of the order. After that, only order ID is accepted. | 
 **futuresOrderAmendment** | [**FuturesOrderAmendment**](FuturesOrderAmendment.md)|  | 
 **xGateExptime** | **string**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**FuturesOrder**](FuturesOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelfuturesorder"></a>
# **CancelFuturesOrder**
> FuturesOrder CancelFuturesOrder (string settle, string orderId, string xGateExptime = null)

Cancel a single order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelFuturesOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var orderId = "12345";  // string | Order ID returned, or user custom ID(i.e., `text` field). Operations based on custom ID can only be checked when the order is in orderbook. finished, it can be checked within 60 seconds after the end of the order. After that, only order ID is accepted.
            var xGateExptime = "1689560679123";  // string | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Cancel a single order.
                FuturesOrder result = apiInstance.CancelFuturesOrder(settle, orderId, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.CancelFuturesOrder: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **orderId** | **string**| Order ID returned, or user custom ID(i.e., &#x60;text&#x60; field). Operations based on custom ID can only be checked when the order is in orderbook. finished, it can be checked within 60 seconds after the end of the order. After that, only order ID is accepted. | 
 **xGateExptime** | **string**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**FuturesOrder**](FuturesOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmytrades"></a>
# **GetMyTrades**
> List&lt;MyFuturesTrade&gt; GetMyTrades (string settle, string contract = null, long? order = null, int? limit = null, int? offset = null, string lastId = null)

List personal trading history.

By default, only data within the past 6 months is supported.  If you need to query data for a longer period, please use `GET /futures/{settle}/my_trades_timerange`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetMyTradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified. (optional) 
            var order = 12345;  // long? | Futures order ID, return related data only if specified. (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list. (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0. (optional)  (default to 0)
            var lastId = "12345";  // string | Specify the starting point for this list based on a previously retrieved id  This parameter is deprecated. If you need to iterate through and retrieve more records, we recommend using 'GET /futures/{settle}/my_trades_timerange'. (optional) 

            try
            {
                // List personal trading history.
                List<MyFuturesTrade> result = apiInstance.GetMyTrades(settle, contract, order, limit, offset, lastId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.GetMyTrades: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract, return related data only if specified. | [optional] 
 **order** | **long?**| Futures order ID, return related data only if specified. | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list. | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0. | [optional] [default to 0]
 **lastId** | **string**| Specify the starting point for this list based on a previously retrieved id  This parameter is deprecated. If you need to iterate through and retrieve more records, we recommend using &#39;GET /futures/{settle}/my_trades_timerange&#39;. | [optional] 

### Return type

[**List&lt;MyFuturesTrade&gt;**](MyFuturesTrade.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved. |  * X-Pagination-Limit - Request limit specified. <br>  * X-Pagination-Offset - Request offset specified. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmytradeswithtimerange"></a>
# **GetMyTradesWithTimeRange**
> List&lt;MyFuturesTradeTimeRange&gt; GetMyTradesWithTimeRange (string settle, string contract = null, long? from = null, long? to = null, int? limit = null, int? offset = null, string role = null)

List personal trading history by time range.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetMyTradesWithTimeRangeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified. (optional) 
            var from = 1547706332;  // long? | Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) (optional) 
            var to = 1547706332;  // long? | Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list. (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0. (optional)  (default to 0)
            var role = "maker";  // string | Query role, maker or taker. (optional) 

            try
            {
                // List personal trading history by time range.
                List<MyFuturesTradeTimeRange> result = apiInstance.GetMyTradesWithTimeRange(settle, contract, from, to, limit, offset, role);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.GetMyTradesWithTimeRange: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract, return related data only if specified. | [optional] 
 **from** | **long?**| Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) | [optional] 
 **to** | **long?**| Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list. | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0. | [optional] [default to 0]
 **role** | **string**| Query role, maker or taker. | [optional] 

### Return type

[**List&lt;MyFuturesTradeTimeRange&gt;**](MyFuturesTradeTimeRange.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved. |  * X-Pagination-Limit - Request limit specified. <br>  * X-Pagination-Offset - Request offset specified. <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpositionclose"></a>
# **ListPositionClose**
> List&lt;PositionClose&gt; ListPositionClose (string settle, string contract = null, int? limit = null, int? offset = null, long? from = null, long? to = null, string side = null, string pnl = null)

List position close history.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListPositionCloseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified. (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list. (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0. (optional)  (default to 0)
            var from = 1547706332;  // long? | Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) (optional) 
            var to = 1547706332;  // long? | Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp (optional) 
            var side = "short";  // string | Query side. long or shot. (optional) 
            var pnl = "profit";  // string | Query profit or loss. (optional) 

            try
            {
                // List position close history.
                List<PositionClose> result = apiInstance.ListPositionClose(settle, contract, limit, offset, from, to, side, pnl);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListPositionClose: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract, return related data only if specified. | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list. | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0. | [optional] [default to 0]
 **from** | **long?**| Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) | [optional] 
 **to** | **long?**| Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp | [optional] 
 **side** | **string**| Query side. long or shot. | [optional] 
 **pnl** | **string**| Query profit or loss. | [optional] 

### Return type

[**List&lt;PositionClose&gt;**](PositionClose.md)

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

<a name="listliquidates"></a>
# **ListLiquidates**
> List&lt;FuturesLiquidate&gt; ListLiquidates (string settle, string contract = null, int? limit = null, int? offset = null, long? from = null, long? to = null, int? at = null)

List liquidation history.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListLiquidatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified. (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list. (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0. (optional)  (default to 0)
            var from = 1547706332;  // long? | Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) (optional) 
            var to = 1547706332;  // long? | Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp (optional) 
            var at = 0;  // int? | Specify a liquidation timestamp. (optional)  (default to 0)

            try
            {
                // List liquidation history.
                List<FuturesLiquidate> result = apiInstance.ListLiquidates(settle, contract, limit, offset, from, to, at);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListLiquidates: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract, return related data only if specified. | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list. | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0. | [optional] [default to 0]
 **from** | **long?**| Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) | [optional] 
 **to** | **long?**| Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp | [optional] 
 **at** | **int?**| Specify a liquidation timestamp. | [optional] [default to 0]

### Return type

[**List&lt;FuturesLiquidate&gt;**](FuturesLiquidate.md)

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

<a name="listautodeleverages"></a>
# **ListAutoDeleverages**
> List&lt;FuturesAutoDeleverage&gt; ListAutoDeleverages (string settle, string contract = null, int? limit = null, int? offset = null, long? from = null, long? to = null, int? at = null)

List Auto-Deleveraging History.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListAutoDeleveragesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified. (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list. (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0. (optional)  (default to 0)
            var from = 1547706332;  // long? | Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) (optional) 
            var to = 1547706332;  // long? | Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp (optional) 
            var at = 0;  // int? | Specify an auto-deleveraging timestamp. (optional)  (default to 0)

            try
            {
                // List Auto-Deleveraging History.
                List<FuturesAutoDeleverage> result = apiInstance.ListAutoDeleverages(settle, contract, limit, offset, from, to, at);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListAutoDeleverages: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract, return related data only if specified. | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list. | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0. | [optional] [default to 0]
 **from** | **long?**| Start timestamp  Specify start time, time format is Unix timestamp. If not specified, it defaults to (the data start time of the time range actually returned by to and limit) | [optional] 
 **to** | **long?**| Termination Timestamp  Specify the end time. If not specified, it defaults to the current time, and the time format is a Unix timestamp | [optional] 
 **at** | **int?**| Specify an auto-deleveraging timestamp. | [optional] [default to 0]

### Return type

[**List&lt;FuturesAutoDeleverage&gt;**](FuturesAutoDeleverage.md)

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

<a name="countdowncancelallfutures"></a>
# **CountdownCancelAllFutures**
> TriggerTime CountdownCancelAllFutures (string settle, CountdownCancelAllFuturesTask countdownCancelAllFuturesTask)

Countdown cancel orders.

Heartbeat detection for contract orders: When the user-set `timeout` time is reached, if neither the existing countdown is canceled nor a new countdown is set, the relevant contract orders will be automatically canceled. This API can be called repeatedly to or cancel the countdown. Usage example: Repeatedly call this API at 30-second intervals, setting the `timeout` to 30 (seconds) each time. If this API is not called again within 30 seconds, all open orders on your specified `market` will be automatically canceled. If the `timeout` is set to 0 within 30 seconds, the countdown timer will terminate, and the automatic order cancellation function will be disabled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CountdownCancelAllFuturesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var countdownCancelAllFuturesTask = new CountdownCancelAllFuturesTask(); // CountdownCancelAllFuturesTask | 

            try
            {
                // Countdown cancel orders.
                TriggerTime result = apiInstance.CountdownCancelAllFutures(settle, countdownCancelAllFuturesTask);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.CountdownCancelAllFutures: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **countdownCancelAllFuturesTask** | [**CountdownCancelAllFuturesTask**](CountdownCancelAllFuturesTask.md)|  | 

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
| **200** | Set countdown successfully. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfuturesfee"></a>
# **GetFuturesFee**
> Dictionary&lt;string, FuturesFee&gt; GetFuturesFee (string settle, string contract = null)

Query user trading fee rates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetFuturesFeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified. (optional) 

            try
            {
                // Query user trading fee rates.
                Dictionary<string, FuturesFee> result = apiInstance.GetFuturesFee(settle, contract);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.GetFuturesFee: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract, return related data only if specified. | [optional] 

### Return type

[**Dictionary&lt;string, FuturesFee&gt;**](FuturesFee.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelbatchfutureorders"></a>
# **CancelBatchFutureOrders**
> List&lt;FutureCancelOrderResult&gt; CancelBatchFutureOrders (string settle, List<string> requestBody, string xGateExptime = null)

Cancel a batch of orders with an ID list.

Multiple different order IDs can be specified. A maximum of 20 records.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelBatchFutureOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var requestBody = new List<string>(); // List<string> | 
            var xGateExptime = "1689560679123";  // string | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Cancel a batch of orders with an ID list.
                List<FutureCancelOrderResult> result = apiInstance.CancelBatchFutureOrders(settle, requestBody, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.CancelBatchFutureOrders: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **requestBody** | [**List&lt;string&gt;**](string.md)|  | 
 **xGateExptime** | **string**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**List&lt;FutureCancelOrderResult&gt;**](FutureCancelOrderResult.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order cancellation operation completed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="amendbatchfutureorders"></a>
# **AmendBatchFutureOrders**
> List&lt;BatchFuturesOrder&gt; AmendBatchFutureOrders (string settle, List<BatchAmendOrderReq> batchAmendOrderReq, string xGateExptime = null)

Batch modify orders with specified IDs.

Multiple different order IDs can be specified. A maximum of 10 orders can.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class AmendBatchFutureOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var batchAmendOrderReq = new List<BatchAmendOrderReq>(); // List<BatchAmendOrderReq> | 
            var xGateExptime = "1689560679123";  // string | Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected (optional) 

            try
            {
                // Batch modify orders with specified IDs.
                List<BatchFuturesOrder> result = apiInstance.AmendBatchFutureOrders(settle, batchAmendOrderReq, xGateExptime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.AmendBatchFutureOrders: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **batchAmendOrderReq** | [**List&lt;BatchAmendOrderReq&gt;**](BatchAmendOrderReq.md)|  | 
 **xGateExptime** | **string**| Specify the expiration time (milliseconds); if the GATE receives the request time greater than the expiration time, the request will be rejected | [optional] 

### Return type

[**List&lt;BatchFuturesOrder&gt;**](BatchFuturesOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request is completed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfuturesrisklimittable"></a>
# **GetFuturesRiskLimitTable**
> List&lt;FuturesRiskLimitTier&gt; GetFuturesRiskLimitTable (string settle, string tableId)

Query risk limit table by table_id.

Just pass table_id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetFuturesRiskLimitTableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var tableId = "CYBER_USDT_20241122";  // string | Risk limit table ID.

            try
            {
                // Query risk limit table by table_id.
                List<FuturesRiskLimitTier> result = apiInstance.GetFuturesRiskLimitTable(settle, tableId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.GetFuturesRiskLimitTable: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **tableId** | **string**| Risk limit table ID. | 

### Return type

[**List&lt;FuturesRiskLimitTier&gt;**](FuturesRiskLimitTier.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpricetriggeredorders"></a>
# **ListPriceTriggeredOrders**
> List&lt;FuturesPriceTriggeredOrder&gt; ListPriceTriggeredOrders (string settle, string status, string contract = null, int? limit = null, int? offset = null)

List All Price-triggered Orders.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListPriceTriggeredOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var status = "status_example";  // string | Only list the orders with this status.
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified. (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list. (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0. (optional)  (default to 0)

            try
            {
                // List All Price-triggered Orders.
                List<FuturesPriceTriggeredOrder> result = apiInstance.ListPriceTriggeredOrders(settle, status, contract, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.ListPriceTriggeredOrders: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **status** | **string**| Only list the orders with this status. | 
 **contract** | **string**| Futures contract, return related data only if specified. | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list. | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0. | [optional] [default to 0]

### Return type

[**List&lt;FuturesPriceTriggeredOrder&gt;**](FuturesPriceTriggeredOrder.md)

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

<a name="createpricetriggeredorder"></a>
# **CreatePriceTriggeredOrder**
> TriggerOrderResponse CreatePriceTriggeredOrder (string settle, FuturesPriceTriggeredOrder futuresPriceTriggeredOrder)

Create a price-triggered order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreatePriceTriggeredOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var futuresPriceTriggeredOrder = new FuturesPriceTriggeredOrder(); // FuturesPriceTriggeredOrder | 

            try
            {
                // Create a price-triggered order.
                TriggerOrderResponse result = apiInstance.CreatePriceTriggeredOrder(settle, futuresPriceTriggeredOrder);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.CreatePriceTriggeredOrder: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **futuresPriceTriggeredOrder** | [**FuturesPriceTriggeredOrder**](FuturesPriceTriggeredOrder.md)|  | 

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
| **201** | Order created. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelpricetriggeredorderlist"></a>
# **CancelPriceTriggeredOrderList**
> List&lt;FuturesPriceTriggeredOrder&gt; CancelPriceTriggeredOrderList (string settle, string contract = null)

Cancel All Price-triggered Orders.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelPriceTriggeredOrderListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified. (optional) 

            try
            {
                // Cancel All Price-triggered Orders.
                List<FuturesPriceTriggeredOrder> result = apiInstance.CancelPriceTriggeredOrderList(settle, contract);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.CancelPriceTriggeredOrderList: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **contract** | **string**| Futures contract, return related data only if specified. | [optional] 

### Return type

[**List&lt;FuturesPriceTriggeredOrder&gt;**](FuturesPriceTriggeredOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Batch cancellation request accepted. Query order status by listing orders. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpricetriggeredorder"></a>
# **GetPriceTriggeredOrder**
> FuturesPriceTriggeredOrder GetPriceTriggeredOrder (string settle, string orderId)

Get a price-triggered order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetPriceTriggeredOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var orderId = "orderId_example";  // string | Retrieve the data of the order with the specified ID.

            try
            {
                // Get a price-triggered order.
                FuturesPriceTriggeredOrder result = apiInstance.GetPriceTriggeredOrder(settle, orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.GetPriceTriggeredOrder: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **orderId** | **string**| Retrieve the data of the order with the specified ID. | 

### Return type

[**FuturesPriceTriggeredOrder**](FuturesPriceTriggeredOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Auto order detail. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelpricetriggeredorder"></a>
# **CancelPriceTriggeredOrder**
> FuturesPriceTriggeredOrder CancelPriceTriggeredOrder (string settle, string orderId)

cancel a price-triggered order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelPriceTriggeredOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency.
            var orderId = "orderId_example";  // string | Retrieve the data of the order with the specified ID.

            try
            {
                // cancel a price-triggered order.
                FuturesPriceTriggeredOrder result = apiInstance.CancelPriceTriggeredOrder(settle, orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FuturesApi.CancelPriceTriggeredOrder: " + e.Message);
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
 **settle** | **string**| Settle currency. | 
 **orderId** | **string**| Retrieve the data of the order with the specified ID. | 

### Return type

[**FuturesPriceTriggeredOrder**](FuturesPriceTriggeredOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Auto order detail. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

