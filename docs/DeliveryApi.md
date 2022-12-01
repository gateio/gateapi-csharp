# Io.Gate.GateApi.Api.DeliveryApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListDeliveryContracts**](DeliveryApi.md#listdeliverycontracts) | **GET** /delivery/{settle}/contracts | List all futures contracts
[**GetDeliveryContract**](DeliveryApi.md#getdeliverycontract) | **GET** /delivery/{settle}/contracts/{contract} | Get a single contract
[**ListDeliveryOrderBook**](DeliveryApi.md#listdeliveryorderbook) | **GET** /delivery/{settle}/order_book | Futures order book
[**ListDeliveryTrades**](DeliveryApi.md#listdeliverytrades) | **GET** /delivery/{settle}/trades | Futures trading history
[**ListDeliveryCandlesticks**](DeliveryApi.md#listdeliverycandlesticks) | **GET** /delivery/{settle}/candlesticks | Get futures candlesticks
[**ListDeliveryTickers**](DeliveryApi.md#listdeliverytickers) | **GET** /delivery/{settle}/tickers | List futures tickers
[**ListDeliveryInsuranceLedger**](DeliveryApi.md#listdeliveryinsuranceledger) | **GET** /delivery/{settle}/insurance | Futures insurance balance history
[**ListDeliveryAccounts**](DeliveryApi.md#listdeliveryaccounts) | **GET** /delivery/{settle}/accounts | Query futures account
[**ListDeliveryAccountBook**](DeliveryApi.md#listdeliveryaccountbook) | **GET** /delivery/{settle}/account_book | Query account book
[**ListDeliveryPositions**](DeliveryApi.md#listdeliverypositions) | **GET** /delivery/{settle}/positions | List all positions of a user
[**GetDeliveryPosition**](DeliveryApi.md#getdeliveryposition) | **GET** /delivery/{settle}/positions/{contract} | Get single position
[**UpdateDeliveryPositionMargin**](DeliveryApi.md#updatedeliverypositionmargin) | **POST** /delivery/{settle}/positions/{contract}/margin | Update position margin
[**UpdateDeliveryPositionLeverage**](DeliveryApi.md#updatedeliverypositionleverage) | **POST** /delivery/{settle}/positions/{contract}/leverage | Update position leverage
[**UpdateDeliveryPositionRiskLimit**](DeliveryApi.md#updatedeliverypositionrisklimit) | **POST** /delivery/{settle}/positions/{contract}/risk_limit | Update position risk limit
[**ListDeliveryOrders**](DeliveryApi.md#listdeliveryorders) | **GET** /delivery/{settle}/orders | List futures orders
[**CreateDeliveryOrder**](DeliveryApi.md#createdeliveryorder) | **POST** /delivery/{settle}/orders | Create a futures order
[**CancelDeliveryOrders**](DeliveryApi.md#canceldeliveryorders) | **DELETE** /delivery/{settle}/orders | Cancel all &#x60;open&#x60; orders matched
[**GetDeliveryOrder**](DeliveryApi.md#getdeliveryorder) | **GET** /delivery/{settle}/orders/{order_id} | Get a single order
[**CancelDeliveryOrder**](DeliveryApi.md#canceldeliveryorder) | **DELETE** /delivery/{settle}/orders/{order_id} | Cancel a single order
[**GetMyDeliveryTrades**](DeliveryApi.md#getmydeliverytrades) | **GET** /delivery/{settle}/my_trades | List personal trading history
[**ListDeliveryPositionClose**](DeliveryApi.md#listdeliverypositionclose) | **GET** /delivery/{settle}/position_close | List position close history
[**ListDeliveryLiquidates**](DeliveryApi.md#listdeliveryliquidates) | **GET** /delivery/{settle}/liquidates | List liquidation history
[**ListDeliverySettlements**](DeliveryApi.md#listdeliverysettlements) | **GET** /delivery/{settle}/settlements | List settlement history
[**ListPriceTriggeredDeliveryOrders**](DeliveryApi.md#listpricetriggereddeliveryorders) | **GET** /delivery/{settle}/price_orders | List all auto orders
[**CreatePriceTriggeredDeliveryOrder**](DeliveryApi.md#createpricetriggereddeliveryorder) | **POST** /delivery/{settle}/price_orders | Create a price-triggered order
[**CancelPriceTriggeredDeliveryOrderList**](DeliveryApi.md#cancelpricetriggereddeliveryorderlist) | **DELETE** /delivery/{settle}/price_orders | Cancel all open orders
[**GetPriceTriggeredDeliveryOrder**](DeliveryApi.md#getpricetriggereddeliveryorder) | **GET** /delivery/{settle}/price_orders/{order_id} | Get a price-triggered order
[**CancelPriceTriggeredDeliveryOrder**](DeliveryApi.md#cancelpricetriggereddeliveryorder) | **DELETE** /delivery/{settle}/price_orders/{order_id} | cancel a price-triggered order


<a name="listdeliverycontracts"></a>
# **ListDeliveryContracts**
> List&lt;DeliveryContract&gt; ListDeliveryContracts (string settle)

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
    public class ListDeliveryContractsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency

            try
            {
                // List all futures contracts
                List<DeliveryContract> result = apiInstance.ListDeliveryContracts(settle);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.ListDeliveryContracts: " + e.Message);
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

[**List&lt;DeliveryContract&gt;**](DeliveryContract.md)

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

<a name="getdeliverycontract"></a>
# **GetDeliveryContract**
> DeliveryContract GetDeliveryContract (string settle, string contract)

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
    public class GetDeliveryContractExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT_20200814";  // string | Futures contract

            try
            {
                // Get a single contract
                DeliveryContract result = apiInstance.GetDeliveryContract(settle, contract);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.GetDeliveryContract: " + e.Message);
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

[**DeliveryContract**](DeliveryContract.md)

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

<a name="listdeliveryorderbook"></a>
# **ListDeliveryOrderBook**
> FuturesOrderBook ListDeliveryOrderBook (string settle, string contract, string interval = null, int? limit = null, bool? withId = null)

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
    public class ListDeliveryOrderBookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT_20200814";  // string | Futures contract
            var interval = "0";  // string | Order depth. 0 means no aggregation is applied. default to 0 (optional)  (default to 0)
            var limit = 10;  // int? | Maximum number of order depth data in asks or bids (optional)  (default to 10)
            var withId = false;  // bool? | Whether the order book update ID will be returned. This ID increases by 1 on every order book update (optional)  (default to false)

            try
            {
                // Futures order book
                FuturesOrderBook result = apiInstance.ListDeliveryOrderBook(settle, contract, interval, limit, withId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.ListDeliveryOrderBook: " + e.Message);
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

<a name="listdeliverytrades"></a>
# **ListDeliveryTrades**
> List&lt;FuturesTrade&gt; ListDeliveryTrades (string settle, string contract, int? limit = null, string lastId = null, long? from = null, long? to = null)

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
    public class ListDeliveryTradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT_20200814";  // string | Futures contract
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var lastId = "12345";  // string | Specify the starting point for this list based on a previously retrieved id  This parameter is deprecated. Use `from` and `to` instead to limit time range (optional) 
            var from = 1546905600;  // long? | Specify starting time in Unix seconds. If not specified, `to` and `limit` will be used to limit response items. If items between `from` and `to` are more than `limit`, only `limit` number will be returned.  (optional) 
            var to = 1546935600;  // long? | Specify end time in Unix seconds, default to current time (optional) 

            try
            {
                // Futures trading history
                List<FuturesTrade> result = apiInstance.ListDeliveryTrades(settle, contract, limit, lastId, from, to);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.ListDeliveryTrades: " + e.Message);
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

<a name="listdeliverycandlesticks"></a>
# **ListDeliveryCandlesticks**
> List&lt;FuturesCandlestick&gt; ListDeliveryCandlesticks (string settle, string contract, long? from = null, long? to = null, int? limit = null, string interval = null)

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
    public class ListDeliveryCandlesticksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT_20200814";  // string | Futures contract
            var from = 1546905600;  // long? | Start time of candlesticks, formatted in Unix timestamp in seconds. Default to`to - 100 * interval` if not specified (optional) 
            var to = 1546935600;  // long? | End time of candlesticks, formatted in Unix timestamp in seconds. Default to current time (optional) 
            var limit = 100;  // int? | Maximum recent data points to return. `limit` is conflicted with `from` and `to`. If either `from` or `to` is specified, request will be rejected. (optional)  (default to 100)
            var interval = "5m";  // string | Interval time between data points. Note that `1w` means natual week(Mon-Sun), while `7d` means every 7d since unix 0 (optional)  (default to 5m)

            try
            {
                // Get futures candlesticks
                List<FuturesCandlestick> result = apiInstance.ListDeliveryCandlesticks(settle, contract, from, to, limit, interval);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.ListDeliveryCandlesticks: " + e.Message);
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

<a name="listdeliverytickers"></a>
# **ListDeliveryTickers**
> List&lt;FuturesTicker&gt; ListDeliveryTickers (string settle, string contract = null)

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
    public class ListDeliveryTickersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT_20200814";  // string | Futures contract (optional) 

            try
            {
                // List futures tickers
                List<FuturesTicker> result = apiInstance.ListDeliveryTickers(settle, contract);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.ListDeliveryTickers: " + e.Message);
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
 **contract** | **string**| Futures contract | [optional] 

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

<a name="listdeliveryinsuranceledger"></a>
# **ListDeliveryInsuranceLedger**
> List&lt;InsuranceRecord&gt; ListDeliveryInsuranceLedger (string settle, int? limit = null)

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
    public class ListDeliveryInsuranceLedgerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)

            try
            {
                // Futures insurance balance history
                List<InsuranceRecord> result = apiInstance.ListDeliveryInsuranceLedger(settle, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.ListDeliveryInsuranceLedger: " + e.Message);
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

<a name="listdeliveryaccounts"></a>
# **ListDeliveryAccounts**
> FuturesAccount ListDeliveryAccounts (string settle)

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
    public class ListDeliveryAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency

            try
            {
                // Query futures account
                FuturesAccount result = apiInstance.ListDeliveryAccounts(settle);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.ListDeliveryAccounts: " + e.Message);
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

<a name="listdeliveryaccountbook"></a>
# **ListDeliveryAccountBook**
> List&lt;FuturesAccountBook&gt; ListDeliveryAccountBook (string settle, int? limit = null, long? from = null, long? to = null, string type = null)

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
    public class ListDeliveryAccountBookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var from = 1547706332;  // long? | Start timestamp (optional) 
            var to = 1547706332;  // long? | End timestamp (optional) 
            var type = "dnw";  // string | Changing Type: - dnw: Deposit & Withdraw - pnl: Profit & Loss by reducing position - fee: Trading fee - refr: Referrer rebate - fund: Funding - point_dnw: POINT Deposit & Withdraw - point_fee: POINT Trading fee - point_refr: POINT Referrer rebate (optional) 

            try
            {
                // Query account book
                List<FuturesAccountBook> result = apiInstance.ListDeliveryAccountBook(settle, limit, from, to, type);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.ListDeliveryAccountBook: " + e.Message);
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

<a name="listdeliverypositions"></a>
# **ListDeliveryPositions**
> List&lt;Position&gt; ListDeliveryPositions (string settle)

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
    public class ListDeliveryPositionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency

            try
            {
                // List all positions of a user
                List<Position> result = apiInstance.ListDeliveryPositions(settle);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.ListDeliveryPositions: " + e.Message);
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

<a name="getdeliveryposition"></a>
# **GetDeliveryPosition**
> Position GetDeliveryPosition (string settle, string contract)

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
    public class GetDeliveryPositionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT_20200814";  // string | Futures contract

            try
            {
                // Get single position
                Position result = apiInstance.GetDeliveryPosition(settle, contract);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.GetDeliveryPosition: " + e.Message);
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

<a name="updatedeliverypositionmargin"></a>
# **UpdateDeliveryPositionMargin**
> Position UpdateDeliveryPositionMargin (string settle, string contract, string change)

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
    public class UpdateDeliveryPositionMarginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT_20200814";  // string | Futures contract
            var change = "0.01";  // string | Margin change. Use positive number to increase margin, negative number otherwise.

            try
            {
                // Update position margin
                Position result = apiInstance.UpdateDeliveryPositionMargin(settle, contract, change);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.UpdateDeliveryPositionMargin: " + e.Message);
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

<a name="updatedeliverypositionleverage"></a>
# **UpdateDeliveryPositionLeverage**
> Position UpdateDeliveryPositionLeverage (string settle, string contract, string leverage)

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
    public class UpdateDeliveryPositionLeverageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT_20200814";  // string | Futures contract
            var leverage = "10";  // string | New position leverage

            try
            {
                // Update position leverage
                Position result = apiInstance.UpdateDeliveryPositionLeverage(settle, contract, leverage);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.UpdateDeliveryPositionLeverage: " + e.Message);
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

<a name="updatedeliverypositionrisklimit"></a>
# **UpdateDeliveryPositionRiskLimit**
> Position UpdateDeliveryPositionRiskLimit (string settle, string contract, string riskLimit)

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
    public class UpdateDeliveryPositionRiskLimitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT_20200814";  // string | Futures contract
            var riskLimit = "10";  // string | New position risk limit

            try
            {
                // Update position risk limit
                Position result = apiInstance.UpdateDeliveryPositionRiskLimit(settle, contract, riskLimit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.UpdateDeliveryPositionRiskLimit: " + e.Message);
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

<a name="listdeliveryorders"></a>
# **ListDeliveryOrders**
> List&lt;FuturesOrder&gt; ListDeliveryOrders (string settle, string status, string contract = null, int? limit = null, int? offset = null, string lastId = null, int? countTotal = null)

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
    public class ListDeliveryOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var status = "open";  // string | Only list the orders with this status
            var contract = "BTC_USDT_20200814";  // string | Futures contract (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var lastId = "12345";  // string | Specify list staring point using the `id` of last record in previous list-query results (optional) 
            var countTotal = 0;  // int? | Whether to return total number matched. Default to 0(no return) (optional)  (default to 0)

            try
            {
                // List futures orders
                List<FuturesOrder> result = apiInstance.ListDeliveryOrders(settle, status, contract, limit, offset, lastId, countTotal);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.ListDeliveryOrders: " + e.Message);
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
 **contract** | **string**| Futures contract | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **lastId** | **string**| Specify list staring point using the &#x60;id&#x60; of last record in previous list-query results | [optional] 
 **countTotal** | **int?**| Whether to return total number matched. Default to 0(no return) | [optional] [default to 0]

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
| **200** | List retrieved |  * X-Pagination-Limit - Request limit specified <br>  * X-Pagination-Offset - Request offset specified <br>  * X-Pagination-Total - Total number matched. Only returned if &#x60;count_total&#x60; set to 1 <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createdeliveryorder"></a>
# **CreateDeliveryOrder**
> FuturesOrder CreateDeliveryOrder (string settle, FuturesOrder futuresOrder)

Create a futures order

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
    public class CreateDeliveryOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var futuresOrder = new FuturesOrder(); // FuturesOrder | 

            try
            {
                // Create a futures order
                FuturesOrder result = apiInstance.CreateDeliveryOrder(settle, futuresOrder);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.CreateDeliveryOrder: " + e.Message);
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

<a name="canceldeliveryorders"></a>
# **CancelDeliveryOrders**
> List&lt;FuturesOrder&gt; CancelDeliveryOrders (string settle, string contract, string side = null)

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
    public class CancelDeliveryOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT_20200814";  // string | Futures contract
            var side = "ask";  // string | All bids or asks. Both included if not specified (optional) 

            try
            {
                // Cancel all `open` orders matched
                List<FuturesOrder> result = apiInstance.CancelDeliveryOrders(settle, contract, side);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.CancelDeliveryOrders: " + e.Message);
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

<a name="getdeliveryorder"></a>
# **GetDeliveryOrder**
> FuturesOrder GetDeliveryOrder (string settle, string orderId)

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
    public class GetDeliveryOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var orderId = "12345";  // string | Retrieve the data of the order with the specified ID

            try
            {
                // Get a single order
                FuturesOrder result = apiInstance.GetDeliveryOrder(settle, orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.GetDeliveryOrder: " + e.Message);
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

<a name="canceldeliveryorder"></a>
# **CancelDeliveryOrder**
> FuturesOrder CancelDeliveryOrder (string settle, string orderId)

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
    public class CancelDeliveryOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var orderId = "12345";  // string | Retrieve the data of the order with the specified ID

            try
            {
                // Cancel a single order
                FuturesOrder result = apiInstance.CancelDeliveryOrder(settle, orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.CancelDeliveryOrder: " + e.Message);
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

<a name="getmydeliverytrades"></a>
# **GetMyDeliveryTrades**
> List&lt;MyFuturesTrade&gt; GetMyDeliveryTrades (string settle, string contract = null, long? order = null, int? limit = null, int? offset = null, string lastId = null, int? countTotal = null)

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
    public class GetMyDeliveryTradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT_20200814";  // string | Futures contract (optional) 
            var order = 12345;  // long? | Futures order ID, return related data only if specified (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var lastId = "12345";  // string | Specify list staring point using the `id` of last record in previous list-query results (optional) 
            var countTotal = 0;  // int? | Whether to return total number matched. Default to 0(no return) (optional)  (default to 0)

            try
            {
                // List personal trading history
                List<MyFuturesTrade> result = apiInstance.GetMyDeliveryTrades(settle, contract, order, limit, offset, lastId, countTotal);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.GetMyDeliveryTrades: " + e.Message);
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
 **contract** | **string**| Futures contract | [optional] 
 **order** | **long?**| Futures order ID, return related data only if specified | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **lastId** | **string**| Specify list staring point using the &#x60;id&#x60; of last record in previous list-query results | [optional] 
 **countTotal** | **int?**| Whether to return total number matched. Default to 0(no return) | [optional] [default to 0]

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
| **200** | List retrieved |  * X-Pagination-Limit - Request limit specified <br>  * X-Pagination-Offset - Request offset specified <br>  * X-Pagination-Total - Total number matched. Only returned if &#x60;count_total&#x60; set to 1 <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdeliverypositionclose"></a>
# **ListDeliveryPositionClose**
> List&lt;PositionClose&gt; ListDeliveryPositionClose (string settle, string contract = null, int? limit = null)

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
    public class ListDeliveryPositionCloseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT_20200814";  // string | Futures contract (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)

            try
            {
                // List position close history
                List<PositionClose> result = apiInstance.ListDeliveryPositionClose(settle, contract, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.ListDeliveryPositionClose: " + e.Message);
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
 **contract** | **string**| Futures contract | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]

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

<a name="listdeliveryliquidates"></a>
# **ListDeliveryLiquidates**
> List&lt;FuturesLiquidate&gt; ListDeliveryLiquidates (string settle, string contract = null, int? limit = null, int? at = null)

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
    public class ListDeliveryLiquidatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT_20200814";  // string | Futures contract (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var at = 0;  // int? | Specify a liquidation timestamp (optional)  (default to 0)

            try
            {
                // List liquidation history
                List<FuturesLiquidate> result = apiInstance.ListDeliveryLiquidates(settle, contract, limit, at);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.ListDeliveryLiquidates: " + e.Message);
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
 **contract** | **string**| Futures contract | [optional] 
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

<a name="listdeliverysettlements"></a>
# **ListDeliverySettlements**
> List&lt;DeliverySettlement&gt; ListDeliverySettlements (string settle, string contract = null, int? limit = null, int? at = null)

List settlement history

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListDeliverySettlementsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT_20200814";  // string | Futures contract (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var at = 0;  // int? | Specify a settlement timestamp (optional)  (default to 0)

            try
            {
                // List settlement history
                List<DeliverySettlement> result = apiInstance.ListDeliverySettlements(settle, contract, limit, at);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.ListDeliverySettlements: " + e.Message);
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
 **contract** | **string**| Futures contract | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **at** | **int?**| Specify a settlement timestamp | [optional] [default to 0]

### Return type

[**List&lt;DeliverySettlement&gt;**](DeliverySettlement.md)

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

<a name="listpricetriggereddeliveryorders"></a>
# **ListPriceTriggeredDeliveryOrders**
> List&lt;FuturesPriceTriggeredOrder&gt; ListPriceTriggeredDeliveryOrders (string settle, string status, string contract = null, int? limit = null, int? offset = null)

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
    public class ListPriceTriggeredDeliveryOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var status = "status_example";  // string | Only list the orders with this status
            var contract = "BTC_USDT";  // string | Futures contract, return related data only if specified (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)

            try
            {
                // List all auto orders
                List<FuturesPriceTriggeredOrder> result = apiInstance.ListPriceTriggeredDeliveryOrders(settle, status, contract, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.ListPriceTriggeredDeliveryOrders: " + e.Message);
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

<a name="createpricetriggereddeliveryorder"></a>
# **CreatePriceTriggeredDeliveryOrder**
> TriggerOrderResponse CreatePriceTriggeredDeliveryOrder (string settle, FuturesPriceTriggeredOrder futuresPriceTriggeredOrder)

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
    public class CreatePriceTriggeredDeliveryOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var futuresPriceTriggeredOrder = new FuturesPriceTriggeredOrder(); // FuturesPriceTriggeredOrder | 

            try
            {
                // Create a price-triggered order
                TriggerOrderResponse result = apiInstance.CreatePriceTriggeredDeliveryOrder(settle, futuresPriceTriggeredOrder);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.CreatePriceTriggeredDeliveryOrder: " + e.Message);
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

<a name="cancelpricetriggereddeliveryorderlist"></a>
# **CancelPriceTriggeredDeliveryOrderList**
> List&lt;FuturesPriceTriggeredOrder&gt; CancelPriceTriggeredDeliveryOrderList (string settle, string contract)

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
    public class CancelPriceTriggeredDeliveryOrderListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var contract = "BTC_USDT";  // string | Futures contract

            try
            {
                // Cancel all open orders
                List<FuturesPriceTriggeredOrder> result = apiInstance.CancelPriceTriggeredDeliveryOrderList(settle, contract);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.CancelPriceTriggeredDeliveryOrderList: " + e.Message);
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

<a name="getpricetriggereddeliveryorder"></a>
# **GetPriceTriggeredDeliveryOrder**
> FuturesPriceTriggeredOrder GetPriceTriggeredDeliveryOrder (string settle, string orderId)

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
    public class GetPriceTriggeredDeliveryOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var orderId = "orderId_example";  // string | Retrieve the data of the order with the specified ID

            try
            {
                // Get a price-triggered order
                FuturesPriceTriggeredOrder result = apiInstance.GetPriceTriggeredDeliveryOrder(settle, orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.GetPriceTriggeredDeliveryOrder: " + e.Message);
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

<a name="cancelpricetriggereddeliveryorder"></a>
# **CancelPriceTriggeredDeliveryOrder**
> FuturesPriceTriggeredOrder CancelPriceTriggeredDeliveryOrder (string settle, string orderId)

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
    public class CancelPriceTriggeredDeliveryOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency
            var orderId = "orderId_example";  // string | Retrieve the data of the order with the specified ID

            try
            {
                // cancel a price-triggered order
                FuturesPriceTriggeredOrder result = apiInstance.CancelPriceTriggeredDeliveryOrder(settle, orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.CancelPriceTriggeredDeliveryOrder: " + e.Message);
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

