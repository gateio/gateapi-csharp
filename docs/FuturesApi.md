# Io.Gate.GateApi.Api.FuturesApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListFuturesContracts**](FuturesApi.md#listfuturescontracts) | **GET** /futures/{settle}/contracts | List all futures contracts
[**GetFuturesContract**](FuturesApi.md#getfuturescontract) | **GET** /futures/{settle}/contracts/{contract} | Get a single contract
[**ListFuturesOrderBook**](FuturesApi.md#listfuturesorderbook) | **GET** /futures/{settle}/order_book | Futures order book
[**ListFuturesTrades**](FuturesApi.md#listfuturestrades) | **GET** /futures/{settle}/trades | Futures trading history
[**ListFuturesCandlesticks**](FuturesApi.md#listfuturescandlesticks) | **GET** /futures/{settle}/candlesticks | Get futures candlesticks
[**ListFuturesPremiumIndex**](FuturesApi.md#listfuturespremiumindex) | **GET** /futures/{settle}/premium_index | Premium Index K-Line
[**ListFuturesTickers**](FuturesApi.md#listfuturestickers) | **GET** /futures/{settle}/tickers | List futures tickers
[**ListFuturesFundingRateHistory**](FuturesApi.md#listfuturesfundingratehistory) | **GET** /futures/{settle}/funding_rate | Funding rate history
[**ListFuturesInsuranceLedger**](FuturesApi.md#listfuturesinsuranceledger) | **GET** /futures/{settle}/insurance | Futures insurance balance history
[**ListContractStats**](FuturesApi.md#listcontractstats) | **GET** /futures/{settle}/contract_stats | Futures stats
[**GetIndexConstituents**](FuturesApi.md#getindexconstituents) | **GET** /futures/{settle}/index_constituents/{index} | Get index constituents
[**ListLiquidatedOrders**](FuturesApi.md#listliquidatedorders) | **GET** /futures/{settle}/liq_orders | Retrieve liquidation history
[**ListFuturesAccounts**](FuturesApi.md#listfuturesaccounts) | **GET** /futures/{settle}/accounts | Query futures account
[**ListFuturesAccountBook**](FuturesApi.md#listfuturesaccountbook) | **GET** /futures/{settle}/account_book | Query account book
[**ListPositions**](FuturesApi.md#listpositions) | **GET** /futures/{settle}/positions | List all positions of a user
[**GetPosition**](FuturesApi.md#getposition) | **GET** /futures/{settle}/positions/{contract} | Get single position
[**UpdatePositionMargin**](FuturesApi.md#updatepositionmargin) | **POST** /futures/{settle}/positions/{contract}/margin | Update position margin
[**UpdatePositionLeverage**](FuturesApi.md#updatepositionleverage) | **POST** /futures/{settle}/positions/{contract}/leverage | Update position leverage
[**UpdatePositionRiskLimit**](FuturesApi.md#updatepositionrisklimit) | **POST** /futures/{settle}/positions/{contract}/risk_limit | Update position risk limit
[**SetDualMode**](FuturesApi.md#setdualmode) | **POST** /futures/{settle}/dual_mode | Enable or disable dual mode
[**GetDualModePosition**](FuturesApi.md#getdualmodeposition) | **GET** /futures/{settle}/dual_comp/positions/{contract} | Retrieve position detail in dual mode
[**UpdateDualModePositionMargin**](FuturesApi.md#updatedualmodepositionmargin) | **POST** /futures/{settle}/dual_comp/positions/{contract}/margin | Update position margin in dual mode
[**UpdateDualModePositionLeverage**](FuturesApi.md#updatedualmodepositionleverage) | **POST** /futures/{settle}/dual_comp/positions/{contract}/leverage | Update position leverage in dual mode
[**UpdateDualModePositionRiskLimit**](FuturesApi.md#updatedualmodepositionrisklimit) | **POST** /futures/{settle}/dual_comp/positions/{contract}/risk_limit | Update position risk limit in dual mode
[**ListFuturesOrders**](FuturesApi.md#listfuturesorders) | **GET** /futures/{settle}/orders | List futures orders
[**CreateFuturesOrder**](FuturesApi.md#createfuturesorder) | **POST** /futures/{settle}/orders | Create a futures order
[**CancelFuturesOrders**](FuturesApi.md#cancelfuturesorders) | **DELETE** /futures/{settle}/orders | Cancel all &#x60;open&#x60; orders matched
[**CreateBatchFuturesOrder**](FuturesApi.md#createbatchfuturesorder) | **POST** /futures/{settle}/batch_orders | Create a batch of futures orders
[**GetFuturesOrder**](FuturesApi.md#getfuturesorder) | **GET** /futures/{settle}/orders/{order_id} | Get a single order
[**AmendFuturesOrder**](FuturesApi.md#amendfuturesorder) | **PUT** /futures/{settle}/orders/{order_id} | Amend an order
[**CancelFuturesOrder**](FuturesApi.md#cancelfuturesorder) | **DELETE** /futures/{settle}/orders/{order_id} | Cancel a single order
[**GetMyTrades**](FuturesApi.md#getmytrades) | **GET** /futures/{settle}/my_trades | List personal trading history
[**ListPositionClose**](FuturesApi.md#listpositionclose) | **GET** /futures/{settle}/position_close | List position close history
[**ListLiquidates**](FuturesApi.md#listliquidates) | **GET** /futures/{settle}/liquidates | List liquidation history
[**CountdownCancelAllFutures**](FuturesApi.md#countdowncancelallfutures) | **POST** /futures/{settle}/countdown_cancel_all | Countdown cancel orders
[**ListPriceTriggeredOrders**](FuturesApi.md#listpricetriggeredorders) | **GET** /futures/{settle}/price_orders | List all auto orders
[**CreatePriceTriggeredOrder**](FuturesApi.md#createpricetriggeredorder) | **POST** /futures/{settle}/price_orders | Create a price-triggered order
[**CancelPriceTriggeredOrderList**](FuturesApi.md#cancelpricetriggeredorderlist) | **DELETE** /futures/{settle}/price_orders | Cancel all open orders
[**GetPriceTriggeredOrder**](FuturesApi.md#getpricetriggeredorder) | **GET** /futures/{settle}/price_orders/{order_id} | Get a price-triggered order
[**CancelPriceTriggeredOrder**](FuturesApi.md#cancelpricetriggeredorder) | **DELETE** /futures/{settle}/price_orders/{order_id} | cancel a price-triggered order


<a name="listfuturescontracts"></a>
# **ListFuturesContracts**
> List&lt;Contract&gt; ListFuturesContracts (string settle)

List all futures contracts

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
            var settle = "usdt";  // string | Settle currency

            try
            {
                // List all futures contracts
                List<Contract> result = apiInstance.ListFuturesContracts(settle);
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
 **settle** | **string**| Settle currency | 

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
| **200** | List retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfuturescontract"></a>
# **GetFuturesContract**
> Contract GetFuturesContract (string settle, string contract)

Get a single contract

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract

            try
            {
                // Get a single contract
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 

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
| **200** | Contract information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturesorderbook"></a>
# **ListFuturesOrderBook**
> FuturesOrderBook ListFuturesOrderBook (string settle, string contract, string interval = null, int? limit = null, bool? withId = null)

Futures order book

Bids will be sorted by price from high to low, while asks sorted reversely

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var interval = "0";  // string | Order depth. 0 means no aggregation is applied. default to 0 (optional)  (default to 0)
            var limit = 10;  // int? | Maximum number of order depth data in asks or bids (optional)  (default to 10)
            var withId = false;  // bool? | Whether the order book update ID will be returned. This ID increases by 1 on every order book update (optional)  (default to false)

            try
            {
                // Futures order book
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **interval** | **string**| Order depth. 0 means no aggregation is applied. default to 0 | [optional] [default to 0]
 **limit** | **int?**| Maximum number of order depth data in asks or bids | [optional] [default to 10]
 **withId** | **bool?**| Whether the order book update ID will be returned. This ID increases by 1 on every order book update | [optional] [default to false]

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
| **200** | Order book retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturestrades"></a>
# **ListFuturesTrades**
> List&lt;FuturesTrade&gt; ListFuturesTrades (string settle, string contract, int? limit = null, int? offset = null, string lastId = null, long? from = null, long? to = null)

Futures trading history

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var lastId = "12345";  // string | Specify the starting point for this list based on a previously retrieved id  This parameter is deprecated. Use `from` and `to` instead to limit time range (optional) 
            var from = 1546905600;  // long? | Specify starting time in Unix seconds. If not specified, `to` and `limit` will be used to limit response items. If items between `from` and `to` are more than `limit`, only `limit` number will be returned.  (optional) 
            var to = 1546935600;  // long? | Specify end time in Unix seconds, default to current time (optional) 

            try
            {
                // Futures trading history
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **lastId** | **string**| Specify the starting point for this list based on a previously retrieved id  This parameter is deprecated. Use &#x60;from&#x60; and &#x60;to&#x60; instead to limit time range | [optional] 
 **from** | **long?**| Specify starting time in Unix seconds. If not specified, &#x60;to&#x60; and &#x60;limit&#x60; will be used to limit response items. If items between &#x60;from&#x60; and &#x60;to&#x60; are more than &#x60;limit&#x60;, only &#x60;limit&#x60; number will be returned.  | [optional] 
 **to** | **long?**| Specify end time in Unix seconds, default to current time | [optional] 

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
| **200** | List retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturescandlesticks"></a>
# **ListFuturesCandlesticks**
> List&lt;FuturesCandlestick&gt; ListFuturesCandlesticks (string settle, string contract, long? from = null, long? to = null, int? limit = null, string interval = null)

Get futures candlesticks

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var from = 1546905600;  // long? | Start time of candlesticks, formatted in Unix timestamp in seconds. Default to`to - 100 * interval` if not specified (optional) 
            var to = 1546935600;  // long? | End time of candlesticks, formatted in Unix timestamp in seconds. Default to current time (optional) 
            var limit = 100;  // int? | Maximum recent data points to return. `limit` is conflicted with `from` and `to`. If either `from` or `to` is specified, request will be rejected. (optional)  (default to 100)
            var interval = "5m";  // string | Interval time between data points. Note that `1w` means natual week(Mon-Sun), while `7d` means every 7d since unix 0 (optional)  (default to 5m)

            try
            {
                // Get futures candlesticks
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **from** | **long?**| Start time of candlesticks, formatted in Unix timestamp in seconds. Default to&#x60;to - 100 * interval&#x60; if not specified | [optional] 
 **to** | **long?**| End time of candlesticks, formatted in Unix timestamp in seconds. Default to current time | [optional] 
 **limit** | **int?**| Maximum recent data points to return. &#x60;limit&#x60; is conflicted with &#x60;from&#x60; and &#x60;to&#x60;. If either &#x60;from&#x60; or &#x60;to&#x60; is specified, request will be rejected. | [optional] [default to 100]
 **interval** | **string**| Interval time between data points. Note that &#x60;1w&#x60; means natual week(Mon-Sun), while &#x60;7d&#x60; means every 7d since unix 0 | [optional] [default to 5m]

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
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturespremiumindex"></a>
# **ListFuturesPremiumIndex**
> List&lt;FuturesPremiumIndex&gt; ListFuturesPremiumIndex (string settle, string contract, long? from = null, long? to = null, int? limit = null, string interval = null)

Premium Index K-Line

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var from = 1546905600;  // long? | Start time of candlesticks, formatted in Unix timestamp in seconds. Default to`to - 100 * interval` if not specified (optional) 
            var to = 1546935600;  // long? | End time of candlesticks, formatted in Unix timestamp in seconds. Default to current time (optional) 
            var limit = 100;  // int? | Maximum recent data points to return. `limit` is conflicted with `from` and `to`. If either `from` or `to` is specified, request will be rejected. (optional)  (default to 100)
            var interval = "5m";  // string | Interval time between data points (optional)  (default to 5m)

            try
            {
                // Premium Index K-Line
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **from** | **long?**| Start time of candlesticks, formatted in Unix timestamp in seconds. Default to&#x60;to - 100 * interval&#x60; if not specified | [optional] 
 **to** | **long?**| End time of candlesticks, formatted in Unix timestamp in seconds. Default to current time | [optional] 
 **limit** | **int?**| Maximum recent data points to return. &#x60;limit&#x60; is conflicted with &#x60;from&#x60; and &#x60;to&#x60;. If either &#x60;from&#x60; or &#x60;to&#x60; is specified, request will be rejected. | [optional] [default to 100]
 **interval** | **string**| Interval time between data points | [optional] [default to 5m]

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
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturestickers"></a>
# **ListFuturesTickers**
> List&lt;FuturesTicker&gt; ListFuturesTickers (string settle, string contract = null)

List futures tickers

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified (optional) 

            try
            {
                // List futures tickers
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract, return related data only if specified | [optional] 

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
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturesfundingratehistory"></a>
# **ListFuturesFundingRateHistory**
> List&lt;FundingRateRecord&gt; ListFuturesFundingRateHistory (string settle, string contract, int? limit = null)

Funding rate history

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)

            try
            {
                // Funding rate history
                List<FundingRateRecord> result = apiInstance.ListFuturesFundingRateHistory(settle, contract, limit);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]

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
| **200** | History retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturesinsuranceledger"></a>
# **ListFuturesInsuranceLedger**
> List&lt;InsuranceRecord&gt; ListFuturesInsuranceLedger (string settle, int? limit = null)

Futures insurance balance history

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
            var settle = "usdt";  // string | Settle currency
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)

            try
            {
                // Futures insurance balance history
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
 **settle** | **string**| Settle currency | 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]

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
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcontractstats"></a>
# **ListContractStats**
> List&lt;ContractStat&gt; ListContractStats (string settle, string contract, long? from = null, string interval = null, int? limit = null)

Futures stats

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var from = 1604561000;  // long? | Start timestamp (optional) 
            var interval = "5m";  // string |  (optional)  (default to 5m)
            var limit = 30;  // int? |  (optional)  (default to 30)

            try
            {
                // Futures stats
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **from** | **long?**| Start timestamp | [optional] 
 **interval** | **string**|  | [optional] [default to 5m]
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
| **200** | List retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getindexconstituents"></a>
# **GetIndexConstituents**
> FuturesIndexConstituents GetIndexConstituents (string settle, string index)

Get index constituents

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
            var settle = "usdt";  // string | Settle currency
            var index = "BTC_USDT";  // string | Index name

            try
            {
                // Get index constituents
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
 **settle** | **string**| Settle currency | 
 **index** | **string**| Index name | 

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
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listliquidatedorders"></a>
# **ListLiquidatedOrders**
> List&lt;FuturesLiquidate&gt; ListLiquidatedOrders (string settle, string contract = null, long? from = null, long? to = null, int? limit = null)

Retrieve liquidation history

Interval between `from` and `to` cannot exceeds 3600. Some private fields will not be returned in public endpoints. Refer to field description for detail.

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified (optional) 
            var from = 1547706332;  // long? | Start timestamp (optional) 
            var to = 1547706332;  // long? | End timestamp (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)

            try
            {
                // Retrieve liquidation history
                List<FuturesLiquidate> result = apiInstance.ListLiquidatedOrders(settle, contract, from, to, limit);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract, return related data only if specified | [optional] 
 **from** | **long?**| Start timestamp | [optional] 
 **to** | **long?**| End timestamp | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]

### Return type

[**List&lt;FuturesLiquidate&gt;**](FuturesLiquidate.md)

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

<a name="listfuturesaccounts"></a>
# **ListFuturesAccounts**
> FuturesAccount ListFuturesAccounts (string settle)

Query futures account

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
            var settle = "usdt";  // string | Settle currency

            try
            {
                // Query futures account
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
 **settle** | **string**| Settle currency | 

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
| **200** | List retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturesaccountbook"></a>
# **ListFuturesAccountBook**
> List&lt;FuturesAccountBook&gt; ListFuturesAccountBook (string settle, int? limit = null, long? from = null, long? to = null, string type = null)

Query account book

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
            var settle = "usdt";  // string | Settle currency
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var from = 1547706332;  // long? | Start timestamp (optional) 
            var to = 1547706332;  // long? | End timestamp (optional) 
            var type = "dnw";  // string | Changing Type: - dnw: Deposit & Withdraw - pnl: Profit & Loss by reducing position - fee: Trading fee - refr: Referrer rebate - fund: Funding - point_dnw: POINT Deposit & Withdraw - point_fee: POINT Trading fee - point_refr: POINT Referrer rebate (optional) 

            try
            {
                // Query account book
                List<FuturesAccountBook> result = apiInstance.ListFuturesAccountBook(settle, limit, from, to, type);
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
 **settle** | **string**| Settle currency | 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **from** | **long?**| Start timestamp | [optional] 
 **to** | **long?**| End timestamp | [optional] 
 **type** | **string**| Changing Type: - dnw: Deposit &amp; Withdraw - pnl: Profit &amp; Loss by reducing position - fee: Trading fee - refr: Referrer rebate - fund: Funding - point_dnw: POINT Deposit &amp; Withdraw - point_fee: POINT Trading fee - point_refr: POINT Referrer rebate | [optional] 

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
| **200** | List retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpositions"></a>
# **ListPositions**
> List&lt;Position&gt; ListPositions (string settle)

List all positions of a user

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
            var settle = "usdt";  // string | Settle currency

            try
            {
                // List all positions of a user
                List<Position> result = apiInstance.ListPositions(settle);
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
 **settle** | **string**| Settle currency | 

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
| **200** | List retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getposition"></a>
# **GetPosition**
> Position GetPosition (string settle, string contract)

Get single position

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract

            try
            {
                // Get single position
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 

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
| **200** | Position information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepositionmargin"></a>
# **UpdatePositionMargin**
> Position UpdatePositionMargin (string settle, string contract, string change)

Update position margin

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var change = "0.01";  // string | Margin change. Use positive number to increase margin, negative number otherwise.

            try
            {
                // Update position margin
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **change** | **string**| Margin change. Use positive number to increase margin, negative number otherwise. | 

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
| **200** | Position information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepositionleverage"></a>
# **UpdatePositionLeverage**
> Position UpdatePositionLeverage (string settle, string contract, string leverage, string crossLeverageLimit = null)

Update position leverage

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var leverage = "10";  // string | New position leverage
            var crossLeverageLimit = "10";  // string | Cross margin leverage(valid only when `leverage` is 0) (optional) 

            try
            {
                // Update position leverage
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **leverage** | **string**| New position leverage | 
 **crossLeverageLimit** | **string**| Cross margin leverage(valid only when &#x60;leverage&#x60; is 0) | [optional] 

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
| **200** | Position information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepositionrisklimit"></a>
# **UpdatePositionRiskLimit**
> Position UpdatePositionRiskLimit (string settle, string contract, string riskLimit)

Update position risk limit

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var riskLimit = "10";  // string | New position risk limit

            try
            {
                // Update position risk limit
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **riskLimit** | **string**| New position risk limit | 

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
| **200** | Position information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setdualmode"></a>
# **SetDualMode**
> FuturesAccount SetDualMode (string settle, bool dualMode)

Enable or disable dual mode

Before setting dual mode, make sure all positions are closed and no orders are open

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
            var settle = "usdt";  // string | Settle currency
            var dualMode = true;  // bool | Whether to enable dual mode

            try
            {
                // Enable or disable dual mode
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
 **settle** | **string**| Settle currency | 
 **dualMode** | **bool**| Whether to enable dual mode | 

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
| **200** | Updated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdualmodeposition"></a>
# **GetDualModePosition**
> List&lt;Position&gt; GetDualModePosition (string settle, string contract)

Retrieve position detail in dual mode

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract

            try
            {
                // Retrieve position detail in dual mode
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 

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
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedualmodepositionmargin"></a>
# **UpdateDualModePositionMargin**
> List&lt;Position&gt; UpdateDualModePositionMargin (string settle, string contract, string change, string dualSide)

Update position margin in dual mode

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var change = "0.01";  // string | Margin change. Use positive number to increase margin, negative number otherwise.
            var dualSide = "dual_long";  // string | Long or short position

            try
            {
                // Update position margin in dual mode
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **change** | **string**| Margin change. Use positive number to increase margin, negative number otherwise. | 
 **dualSide** | **string**| Long or short position | 

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
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedualmodepositionleverage"></a>
# **UpdateDualModePositionLeverage**
> List&lt;Position&gt; UpdateDualModePositionLeverage (string settle, string contract, string leverage, string crossLeverageLimit = null)

Update position leverage in dual mode

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var leverage = "10";  // string | New position leverage
            var crossLeverageLimit = "10";  // string | Cross margin leverage(valid only when `leverage` is 0) (optional) 

            try
            {
                // Update position leverage in dual mode
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **leverage** | **string**| New position leverage | 
 **crossLeverageLimit** | **string**| Cross margin leverage(valid only when &#x60;leverage&#x60; is 0) | [optional] 

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
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedualmodepositionrisklimit"></a>
# **UpdateDualModePositionRiskLimit**
> List&lt;Position&gt; UpdateDualModePositionRiskLimit (string settle, string contract, string riskLimit)

Update position risk limit in dual mode

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var riskLimit = "10";  // string | New position risk limit

            try
            {
                // Update position risk limit in dual mode
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **riskLimit** | **string**| New position risk limit | 

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
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfuturesorders"></a>
# **ListFuturesOrders**
> List&lt;FuturesOrder&gt; ListFuturesOrders (string settle, string contract, string status, int? limit = null, int? offset = null, string lastId = null)

List futures orders

Zero-filled order cannot be retrieved 10 minutes after order cancellation

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var status = "open";  // string | Only list the orders with this status
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var lastId = "12345";  // string | Specify list staring point using the `id` of last record in previous list-query results (optional) 

            try
            {
                // List futures orders
                List<FuturesOrder> result = apiInstance.ListFuturesOrders(settle, contract, status, limit, offset, lastId);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **status** | **string**| Only list the orders with this status | 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **lastId** | **string**| Specify list staring point using the &#x60;id&#x60; of last record in previous list-query results | [optional] 

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
| **200** | List retrieved |  * X-Pagination-Limit - Request limit specified <br>  * X-Pagination-Offset - Request offset specified <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfuturesorder"></a>
# **CreateFuturesOrder**
> FuturesOrder CreateFuturesOrder (string settle, FuturesOrder futuresOrder)

Create a futures order

- Creating futures orders requires `size`, which is number of contracts instead of currency amount. You can use `quanto_multiplier` in contract detail response to know how much currency 1 size contract represents - Zero-filled order cannot be retrieved 10 minutes after order cancellation. You will get a 404 not found for such orders - Set `reduce_only` to `true` can keep the position from changing side when reducing position size - In single position mode, to close a position, you need to set `size` to 0 and `close` to `true` - In dual position mode, to close one side position, you need to set `auto_size` side, `reduce_only` to true and `size` to 0

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
            var settle = "usdt";  // string | Settle currency
            var futuresOrder = new FuturesOrder(); // FuturesOrder | 

            try
            {
                // Create a futures order
                FuturesOrder result = apiInstance.CreateFuturesOrder(settle, futuresOrder);
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
 **settle** | **string**| Settle currency | 
 **futuresOrder** | [**FuturesOrder**](FuturesOrder.md)|  | 

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
| **201** | Order details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelfuturesorders"></a>
# **CancelFuturesOrders**
> List&lt;FuturesOrder&gt; CancelFuturesOrders (string settle, string contract, string side = null)

Cancel all `open` orders matched

Zero-filled order cannot be retrieved 10 minutes after order cancellation

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract
            var side = "ask";  // string | All bids or asks. Both included if not specified (optional) 

            try
            {
                // Cancel all `open` orders matched
                List<FuturesOrder> result = apiInstance.CancelFuturesOrders(settle, contract, side);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 
 **side** | **string**| All bids or asks. Both included if not specified | [optional] 

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
| **200** | All orders matched cancelled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createbatchfuturesorder"></a>
# **CreateBatchFuturesOrder**
> List&lt;BatchFuturesOrder&gt; CreateBatchFuturesOrder (string settle, List<FuturesOrder> futuresOrder)

Create a batch of futures orders

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
            var settle = "usdt";  // string | Settle currency
            var futuresOrder = new List<FuturesOrder>(); // List<FuturesOrder> | 

            try
            {
                // Create a batch of futures orders
                List<BatchFuturesOrder> result = apiInstance.CreateBatchFuturesOrder(settle, futuresOrder);
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
 **settle** | **string**| Settle currency | 
 **futuresOrder** | [**List&lt;FuturesOrder&gt;**](FuturesOrder.md)|  | 

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
| **200** | Request is completed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfuturesorder"></a>
# **GetFuturesOrder**
> FuturesOrder GetFuturesOrder (string settle, string orderId)

Get a single order

Zero-filled order cannot be retrieved 10 minutes after order cancellation

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
            var settle = "usdt";  // string | Settle currency
            var orderId = "12345";  // string | Order ID returned, or user custom ID(i.e., `text` field). Operations based on custom ID can only be checked when the order is in orderbook.  When the order is finished, it can be checked within 60 seconds after the end of the order.  After that, only order ID is accepted.

            try
            {
                // Get a single order
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
 **settle** | **string**| Settle currency | 
 **orderId** | **string**| Order ID returned, or user custom ID(i.e., &#x60;text&#x60; field). Operations based on custom ID can only be checked when the order is in orderbook.  When the order is finished, it can be checked within 60 seconds after the end of the order.  After that, only order ID is accepted. | 

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
| **200** | Order details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="amendfuturesorder"></a>
# **AmendFuturesOrder**
> FuturesOrder AmendFuturesOrder (string settle, string orderId, FuturesOrderAmendment futuresOrderAmendment)

Amend an order

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
            var settle = "usdt";  // string | Settle currency
            var orderId = "12345";  // string | Order ID returned, or user custom ID(i.e., `text` field). Operations based on custom ID can only be checked when the order is in orderbook.  When the order is finished, it can be checked within 60 seconds after the end of the order.  After that, only order ID is accepted.
            var futuresOrderAmendment = new FuturesOrderAmendment(); // FuturesOrderAmendment | 

            try
            {
                // Amend an order
                FuturesOrder result = apiInstance.AmendFuturesOrder(settle, orderId, futuresOrderAmendment);
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
 **settle** | **string**| Settle currency | 
 **orderId** | **string**| Order ID returned, or user custom ID(i.e., &#x60;text&#x60; field). Operations based on custom ID can only be checked when the order is in orderbook.  When the order is finished, it can be checked within 60 seconds after the end of the order.  After that, only order ID is accepted. | 
 **futuresOrderAmendment** | [**FuturesOrderAmendment**](FuturesOrderAmendment.md)|  | 

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
| **200** | Order details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelfuturesorder"></a>
# **CancelFuturesOrder**
> FuturesOrder CancelFuturesOrder (string settle, string orderId)

Cancel a single order

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
            var settle = "usdt";  // string | Settle currency
            var orderId = "12345";  // string | Order ID returned, or user custom ID(i.e., `text` field). Operations based on custom ID can only be checked when the order is in orderbook.  When the order is finished, it can be checked within 60 seconds after the end of the order.  After that, only order ID is accepted.

            try
            {
                // Cancel a single order
                FuturesOrder result = apiInstance.CancelFuturesOrder(settle, orderId);
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
 **settle** | **string**| Settle currency | 
 **orderId** | **string**| Order ID returned, or user custom ID(i.e., &#x60;text&#x60; field). Operations based on custom ID can only be checked when the order is in orderbook.  When the order is finished, it can be checked within 60 seconds after the end of the order.  After that, only order ID is accepted. | 

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
| **200** | Order details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmytrades"></a>
# **GetMyTrades**
> List&lt;MyFuturesTrade&gt; GetMyTrades (string settle, string contract = null, long? order = null, int? limit = null, int? offset = null, string lastId = null)

List personal trading history

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified (optional) 
            var order = 12345;  // long? | Futures order ID, return related data only if specified (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var lastId = "12345";  // string | Specify list staring point using the `id` of last record in previous list-query results (optional) 

            try
            {
                // List personal trading history
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract, return related data only if specified | [optional] 
 **order** | **long?**| Futures order ID, return related data only if specified | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **lastId** | **string**| Specify list staring point using the &#x60;id&#x60; of last record in previous list-query results | [optional] 

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
| **200** | List retrieved |  * X-Pagination-Limit - Request limit specified <br>  * X-Pagination-Offset - Request offset specified <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpositionclose"></a>
# **ListPositionClose**
> List&lt;PositionClose&gt; ListPositionClose (string settle, string contract = null, int? limit = null, int? offset = null, long? from = null, long? to = null)

List position close history

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var from = 1547706332;  // long? | Start timestamp (optional) 
            var to = 1547706332;  // long? | End timestamp (optional) 

            try
            {
                // List position close history
                List<PositionClose> result = apiInstance.ListPositionClose(settle, contract, limit, offset, from, to);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract, return related data only if specified | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **from** | **long?**| Start timestamp | [optional] 
 **to** | **long?**| End timestamp | [optional] 

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
| **200** | List retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listliquidates"></a>
# **ListLiquidates**
> List&lt;FuturesLiquidate&gt; ListLiquidates (string settle, string contract = null, int? limit = null, int? at = null)

List liquidation history

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var at = 0;  // int? | Specify a liquidation timestamp (optional)  (default to 0)

            try
            {
                // List liquidation history
                List<FuturesLiquidate> result = apiInstance.ListLiquidates(settle, contract, limit, at);
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract, return related data only if specified | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **at** | **int?**| Specify a liquidation timestamp | [optional] [default to 0]

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
| **200** | List retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="countdowncancelallfutures"></a>
# **CountdownCancelAllFutures**
> TriggerTime CountdownCancelAllFutures (string settle, CountdownCancelAllFuturesTask countdownCancelAllFuturesTask)

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
    public class CountdownCancelAllFuturesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var countdownCancelAllFuturesTask = new CountdownCancelAllFuturesTask(); // CountdownCancelAllFuturesTask | 

            try
            {
                // Countdown cancel orders
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
 **settle** | **string**| Settle currency | 
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
| **200** | Set countdown successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpricetriggeredorders"></a>
# **ListPriceTriggeredOrders**
> List&lt;FuturesPriceTriggeredOrder&gt; ListPriceTriggeredOrders (string settle, string status, string contract = null, int? limit = null, int? offset = null)

List all auto orders

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
            var settle = "usdt";  // string | Settle currency
            var status = "status_example";  // string | Only list the orders with this status
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)

            try
            {
                // List all auto orders
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
 **settle** | **string**| Settle currency | 
 **status** | **string**| Only list the orders with this status | 
 **contract** | **string**| Futures contract, return related data only if specified | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]

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
| **200** | List retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpricetriggeredorder"></a>
# **CreatePriceTriggeredOrder**
> TriggerOrderResponse CreatePriceTriggeredOrder (string settle, FuturesPriceTriggeredOrder futuresPriceTriggeredOrder)

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
    public class CreatePriceTriggeredOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var futuresPriceTriggeredOrder = new FuturesPriceTriggeredOrder(); // FuturesPriceTriggeredOrder | 

            try
            {
                // Create a price-triggered order
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
 **settle** | **string**| Settle currency | 
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
| **201** | Order created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelpricetriggeredorderlist"></a>
# **CancelPriceTriggeredOrderList**
> List&lt;FuturesPriceTriggeredOrder&gt; CancelPriceTriggeredOrderList (string settle, string contract)

Cancel all open orders

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
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract

            try
            {
                // Cancel all open orders
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
 **settle** | **string**| Settle currency | 
 **contract** | **string**| Futures contract | 

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
| **200** | Batch cancellation request accepted. Query order status by listing orders |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpricetriggeredorder"></a>
# **GetPriceTriggeredOrder**
> FuturesPriceTriggeredOrder GetPriceTriggeredOrder (string settle, string orderId)

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
    public class GetPriceTriggeredOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var orderId = "orderId_example";  // string | Retrieve the data of the order with the specified ID

            try
            {
                // Get a price-triggered order
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
 **settle** | **string**| Settle currency | 
 **orderId** | **string**| Retrieve the data of the order with the specified ID | 

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
| **200** | Auto order detail |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelpricetriggeredorder"></a>
# **CancelPriceTriggeredOrder**
> FuturesPriceTriggeredOrder CancelPriceTriggeredOrder (string settle, string orderId)

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
    public class CancelPriceTriggeredOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FuturesApi(config);
            var settle = "usdt";  // string | Settle currency
            var orderId = "orderId_example";  // string | Retrieve the data of the order with the specified ID

            try
            {
                // cancel a price-triggered order
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
 **settle** | **string**| Settle currency | 
 **orderId** | **string**| Retrieve the data of the order with the specified ID | 

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
| **200** | Auto order detail |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

