# Io.Gate.GateApi.Api.OptionsApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListOptionsUnderlyings**](OptionsApi.md#listoptionsunderlyings) | **GET** /options/underlyings | List all underlyings
[**ListOptionsExpirations**](OptionsApi.md#listoptionsexpirations) | **GET** /options/expirations | List all expiration times
[**ListOptionsContracts**](OptionsApi.md#listoptionscontracts) | **GET** /options/contracts | List all the contracts with specified underlying and expiration time
[**GetOptionsContract**](OptionsApi.md#getoptionscontract) | **GET** /options/contracts/{contract} | Query specified contract detail
[**ListOptionsSettlements**](OptionsApi.md#listoptionssettlements) | **GET** /options/settlements | List settlement history
[**GetOptionsSettlement**](OptionsApi.md#getoptionssettlement) | **GET** /options/settlements/{contract} | Get specified contract&#39;s settlement
[**ListMyOptionsSettlements**](OptionsApi.md#listmyoptionssettlements) | **GET** /options/my_settlements | List my options settlements
[**ListOptionsOrderBook**](OptionsApi.md#listoptionsorderbook) | **GET** /options/order_book | Options order book
[**ListOptionsTickers**](OptionsApi.md#listoptionstickers) | **GET** /options/tickers | List tickers of options contracts
[**ListOptionsUnderlyingTickers**](OptionsApi.md#listoptionsunderlyingtickers) | **GET** /options/underlying/tickers/{underlying} | Get underlying ticker
[**ListOptionsCandlesticks**](OptionsApi.md#listoptionscandlesticks) | **GET** /options/candlesticks | Get options candlesticks
[**ListOptionsUnderlyingCandlesticks**](OptionsApi.md#listoptionsunderlyingcandlesticks) | **GET** /options/underlying/candlesticks | Mark price candlesticks of an underlying
[**ListOptionsTrades**](OptionsApi.md#listoptionstrades) | **GET** /options/trades | Options trade history
[**ListOptionsAccount**](OptionsApi.md#listoptionsaccount) | **GET** /options/accounts | List options account
[**ListOptionsAccountBook**](OptionsApi.md#listoptionsaccountbook) | **GET** /options/account_book | List account changing history
[**ListOptionsPositions**](OptionsApi.md#listoptionspositions) | **GET** /options/positions | List user&#39;s positions of specified underlying
[**GetOptionsPosition**](OptionsApi.md#getoptionsposition) | **GET** /options/positions/{contract} | Get specified contract position
[**ListOptionsPositionClose**](OptionsApi.md#listoptionspositionclose) | **GET** /options/position_close | List user&#39;s liquidation history of specified underlying
[**ListOptionsOrders**](OptionsApi.md#listoptionsorders) | **GET** /options/orders | List options orders
[**CreateOptionsOrder**](OptionsApi.md#createoptionsorder) | **POST** /options/orders | Create an options order
[**CancelOptionsOrders**](OptionsApi.md#canceloptionsorders) | **DELETE** /options/orders | Cancel all &#x60;open&#x60; orders matched
[**GetOptionsOrder**](OptionsApi.md#getoptionsorder) | **GET** /options/orders/{order_id} | Get a single order
[**CancelOptionsOrder**](OptionsApi.md#canceloptionsorder) | **DELETE** /options/orders/{order_id} | Cancel a single order
[**ListMyOptionsTrades**](OptionsApi.md#listmyoptionstrades) | **GET** /options/my_trades | List personal trading history


<a name="listoptionsunderlyings"></a>
# **ListOptionsUnderlyings**
> List&lt;OptionsUnderlying&gt; ListOptionsUnderlyings ()

List all underlyings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListOptionsUnderlyingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new OptionsApi(config);

            try
            {
                // List all underlyings
                List<OptionsUnderlying> result = apiInstance.ListOptionsUnderlyings();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.ListOptionsUnderlyings: " + e.Message);
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

[**List&lt;OptionsUnderlying&gt;**](OptionsUnderlying.md)

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

<a name="listoptionsexpirations"></a>
# **ListOptionsExpirations**
> List&lt;long&gt; ListOptionsExpirations (string underlying)

List all expiration times

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListOptionsExpirationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new OptionsApi(config);
            var underlying = "BTC_USDT";  // string | Underlying (Obtained by listing underlying endpoint)

            try
            {
                // List all expiration times
                List<long> result = apiInstance.ListOptionsExpirations(underlying);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.ListOptionsExpirations: " + e.Message);
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
 **underlying** | **string**| Underlying (Obtained by listing underlying endpoint) | 

### Return type

**List<long>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List expiration times of specified underlying |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listoptionscontracts"></a>
# **ListOptionsContracts**
> List&lt;OptionsContract&gt; ListOptionsContracts (string underlying, long? expiration = null)

List all the contracts with specified underlying and expiration time

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListOptionsContractsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new OptionsApi(config);
            var underlying = "BTC_USDT";  // string | Underlying (Obtained by listing underlying endpoint)
            var expiration = 1636588800;  // long? | Unix timestamp of the expiration time (optional) 

            try
            {
                // List all the contracts with specified underlying and expiration time
                List<OptionsContract> result = apiInstance.ListOptionsContracts(underlying, expiration);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.ListOptionsContracts: " + e.Message);
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
 **underlying** | **string**| Underlying (Obtained by listing underlying endpoint) | 
 **expiration** | **long?**| Unix timestamp of the expiration time | [optional] 

### Return type

[**List&lt;OptionsContract&gt;**](OptionsContract.md)

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

<a name="getoptionscontract"></a>
# **GetOptionsContract**
> OptionsContract GetOptionsContract (string contract)

Query specified contract detail

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetOptionsContractExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new OptionsApi(config);
            var contract = "BTC_USDT-20211130-65000-C";  // string | 

            try
            {
                // Query specified contract detail
                OptionsContract result = apiInstance.GetOptionsContract(contract);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.GetOptionsContract: " + e.Message);
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
 **contract** | **string**|  | 

### Return type

[**OptionsContract**](OptionsContract.md)

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

<a name="listoptionssettlements"></a>
# **ListOptionsSettlements**
> List&lt;OptionsSettlement&gt; ListOptionsSettlements (string underlying, int? limit = null, int? offset = null, long? from = null, long? to = null)

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
    public class ListOptionsSettlementsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new OptionsApi(config);
            var underlying = "BTC_USDT";  // string | Underlying (Obtained by listing underlying endpoint)
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var from = 1547706332;  // long? | Start timestamp (optional) 
            var to = 1547706332;  // long? | End timestamp (optional) 

            try
            {
                // List settlement history
                List<OptionsSettlement> result = apiInstance.ListOptionsSettlements(underlying, limit, offset, from, to);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.ListOptionsSettlements: " + e.Message);
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
 **underlying** | **string**| Underlying (Obtained by listing underlying endpoint) | 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **from** | **long?**| Start timestamp | [optional] 
 **to** | **long?**| End timestamp | [optional] 

### Return type

[**List&lt;OptionsSettlement&gt;**](OptionsSettlement.md)

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

<a name="getoptionssettlement"></a>
# **GetOptionsSettlement**
> OptionsSettlement GetOptionsSettlement (string contract, string underlying, long at)

Get specified contract's settlement

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetOptionsSettlementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new OptionsApi(config);
            var contract = "BTC_USDT-20211130-65000-C";  // string | 
            var underlying = "BTC_USDT";  // string | Underlying (Obtained by listing underlying endpoint)
            var at = 56;  // long | 

            try
            {
                // Get specified contract's settlement
                OptionsSettlement result = apiInstance.GetOptionsSettlement(contract, underlying, at);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.GetOptionsSettlement: " + e.Message);
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
 **contract** | **string**|  | 
 **underlying** | **string**| Underlying (Obtained by listing underlying endpoint) | 
 **at** | **long**|  | 

### Return type

[**OptionsSettlement**](OptionsSettlement.md)

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

<a name="listmyoptionssettlements"></a>
# **ListMyOptionsSettlements**
> List&lt;OptionsMySettlements&gt; ListMyOptionsSettlements (string underlying, string contract = null, int? limit = null, int? offset = null, long? from = null, long? to = null)

List my options settlements

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListMyOptionsSettlementsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OptionsApi(config);
            var underlying = "BTC_USDT";  // string | Underlying (Obtained by listing underlying endpoint)
            var contract = "BTC_USDT-20210916-5000-C";  // string | Options contract name (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var from = 1547706332;  // long? | Start timestamp (optional) 
            var to = 1547706332;  // long? | End timestamp (optional) 

            try
            {
                // List my options settlements
                List<OptionsMySettlements> result = apiInstance.ListMyOptionsSettlements(underlying, contract, limit, offset, from, to);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.ListMyOptionsSettlements: " + e.Message);
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
 **underlying** | **string**| Underlying (Obtained by listing underlying endpoint) | 
 **contract** | **string**| Options contract name | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **from** | **long?**| Start timestamp | [optional] 
 **to** | **long?**| End timestamp | [optional] 

### Return type

[**List&lt;OptionsMySettlements&gt;**](OptionsMySettlements.md)

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

<a name="listoptionsorderbook"></a>
# **ListOptionsOrderBook**
> FuturesOrderBook ListOptionsOrderBook (string contract, string interval = null, int? limit = null, bool? withId = null)

Options order book

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
    public class ListOptionsOrderBookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new OptionsApi(config);
            var contract = "BTC_USDT-20210916-5000-C";  // string | Options contract name
            var interval = "0";  // string | Order depth. 0 means no aggregation is applied. default to 0 (optional)  (default to 0)
            var limit = 10;  // int? | Maximum number of order depth data in asks or bids (optional)  (default to 10)
            var withId = false;  // bool? | Whether the order book update ID will be returned. This ID increases by 1 on every order book update (optional)  (default to false)

            try
            {
                // Options order book
                FuturesOrderBook result = apiInstance.ListOptionsOrderBook(contract, interval, limit, withId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.ListOptionsOrderBook: " + e.Message);
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
 **contract** | **string**| Options contract name | 
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

<a name="listoptionstickers"></a>
# **ListOptionsTickers**
> List&lt;OptionsTicker&gt; ListOptionsTickers (string underlying)

List tickers of options contracts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListOptionsTickersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new OptionsApi(config);
            var underlying = "BTC_USDT";  // string | Underlying (Obtained by listing underlying endpoint)

            try
            {
                // List tickers of options contracts
                List<OptionsTicker> result = apiInstance.ListOptionsTickers(underlying);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.ListOptionsTickers: " + e.Message);
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
 **underlying** | **string**| Underlying (Obtained by listing underlying endpoint) | 

### Return type

[**List&lt;OptionsTicker&gt;**](OptionsTicker.md)

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

<a name="listoptionsunderlyingtickers"></a>
# **ListOptionsUnderlyingTickers**
> OptionsUnderlyingTicker ListOptionsUnderlyingTickers (string underlying)

Get underlying ticker

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListOptionsUnderlyingTickersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new OptionsApi(config);
            var underlying = "BTC_USDT";  // string | Underlying

            try
            {
                // Get underlying ticker
                OptionsUnderlyingTicker result = apiInstance.ListOptionsUnderlyingTickers(underlying);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.ListOptionsUnderlyingTickers: " + e.Message);
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
 **underlying** | **string**| Underlying | 

### Return type

[**OptionsUnderlyingTicker**](OptionsUnderlyingTicker.md)

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

<a name="listoptionscandlesticks"></a>
# **ListOptionsCandlesticks**
> List&lt;OptionsCandlestick&gt; ListOptionsCandlesticks (string contract, int? limit = null, long? from = null, long? to = null, string interval = null)

Get options candlesticks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListOptionsCandlesticksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new OptionsApi(config);
            var contract = "BTC_USDT-20210916-5000-C";  // string | Options contract name
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var from = 1547706332;  // long? | Start timestamp (optional) 
            var to = 1547706332;  // long? | End timestamp (optional) 
            var interval = "5m";  // string | Interval time between data points (optional)  (default to 5m)

            try
            {
                // Get options candlesticks
                List<OptionsCandlestick> result = apiInstance.ListOptionsCandlesticks(contract, limit, from, to, interval);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.ListOptionsCandlesticks: " + e.Message);
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
 **contract** | **string**| Options contract name | 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **from** | **long?**| Start timestamp | [optional] 
 **to** | **long?**| End timestamp | [optional] 
 **interval** | **string**| Interval time between data points | [optional] [default to 5m]

### Return type

[**List&lt;OptionsCandlestick&gt;**](OptionsCandlestick.md)

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

<a name="listoptionsunderlyingcandlesticks"></a>
# **ListOptionsUnderlyingCandlesticks**
> List&lt;FuturesCandlestick&gt; ListOptionsUnderlyingCandlesticks (string underlying, int? limit = null, long? from = null, long? to = null, string interval = null)

Mark price candlesticks of an underlying

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListOptionsUnderlyingCandlesticksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new OptionsApi(config);
            var underlying = "BTC_USDT";  // string | Underlying (Obtained by listing underlying endpoint)
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var from = 1547706332;  // long? | Start timestamp (optional) 
            var to = 1547706332;  // long? | End timestamp (optional) 
            var interval = "5m";  // string | Interval time between data points (optional)  (default to 5m)

            try
            {
                // Mark price candlesticks of an underlying
                List<FuturesCandlestick> result = apiInstance.ListOptionsUnderlyingCandlesticks(underlying, limit, from, to, interval);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.ListOptionsUnderlyingCandlesticks: " + e.Message);
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
 **underlying** | **string**| Underlying (Obtained by listing underlying endpoint) | 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **from** | **long?**| Start timestamp | [optional] 
 **to** | **long?**| End timestamp | [optional] 
 **interval** | **string**| Interval time between data points | [optional] [default to 5m]

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

<a name="listoptionstrades"></a>
# **ListOptionsTrades**
> List&lt;FuturesTrade&gt; ListOptionsTrades (string contract = null, string type = null, int? limit = null, int? offset = null, long? from = null, long? to = null)

Options trade history

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListOptionsTradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new OptionsApi(config);
            var contract = "BTC_USDT-20210916-5000-C";  // string | Options contract name (optional) 
            var type = "1546935600";  // string | `C` is call, while `P` is put (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var from = 1547706332;  // long? | Start timestamp (optional) 
            var to = 1547706332;  // long? | End timestamp (optional) 

            try
            {
                // Options trade history
                List<FuturesTrade> result = apiInstance.ListOptionsTrades(contract, type, limit, offset, from, to);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.ListOptionsTrades: " + e.Message);
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
 **contract** | **string**| Options contract name | [optional] 
 **type** | **string**| &#x60;C&#x60; is call, while &#x60;P&#x60; is put | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **from** | **long?**| Start timestamp | [optional] 
 **to** | **long?**| End timestamp | [optional] 

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

<a name="listoptionsaccount"></a>
# **ListOptionsAccount**
> OptionsAccount ListOptionsAccount ()

List options account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListOptionsAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OptionsApi(config);

            try
            {
                // List options account
                OptionsAccount result = apiInstance.ListOptionsAccount();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.ListOptionsAccount: " + e.Message);
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

[**OptionsAccount**](OptionsAccount.md)

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

<a name="listoptionsaccountbook"></a>
# **ListOptionsAccountBook**
> List&lt;OptionsAccountBook&gt; ListOptionsAccountBook (int? limit = null, int? offset = null, long? from = null, long? to = null, string type = null)

List account changing history

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListOptionsAccountBookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OptionsApi(config);
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var from = 1547706332;  // long? | Start timestamp (optional) 
            var to = 1547706332;  // long? | End timestamp (optional) 
            var type = "dnw";  // string | Changing Type: - dnw: Deposit & Withdraw - prem: Trading premium - fee: Trading fee - refr: Referrer rebate - set: settlement PNL  (optional) 

            try
            {
                // List account changing history
                List<OptionsAccountBook> result = apiInstance.ListOptionsAccountBook(limit, offset, from, to, type);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.ListOptionsAccountBook: " + e.Message);
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
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **from** | **long?**| Start timestamp | [optional] 
 **to** | **long?**| End timestamp | [optional] 
 **type** | **string**| Changing Type: - dnw: Deposit &amp; Withdraw - prem: Trading premium - fee: Trading fee - refr: Referrer rebate - set: settlement PNL  | [optional] 

### Return type

[**List&lt;OptionsAccountBook&gt;**](OptionsAccountBook.md)

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

<a name="listoptionspositions"></a>
# **ListOptionsPositions**
> List&lt;OptionsPosition&gt; ListOptionsPositions (string underlying = null)

List user's positions of specified underlying

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListOptionsPositionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OptionsApi(config);
            var underlying = "BTC_USDT";  // string | Underlying (optional) 

            try
            {
                // List user's positions of specified underlying
                List<OptionsPosition> result = apiInstance.ListOptionsPositions(underlying);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.ListOptionsPositions: " + e.Message);
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
 **underlying** | **string**| Underlying | [optional] 

### Return type

[**List&lt;OptionsPosition&gt;**](OptionsPosition.md)

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

<a name="getoptionsposition"></a>
# **GetOptionsPosition**
> OptionsPosition GetOptionsPosition (string contract)

Get specified contract position

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetOptionsPositionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OptionsApi(config);
            var contract = "BTC_USDT-20211130-65000-C";  // string | 

            try
            {
                // Get specified contract position
                OptionsPosition result = apiInstance.GetOptionsPosition(contract);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.GetOptionsPosition: " + e.Message);
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
 **contract** | **string**|  | 

### Return type

[**OptionsPosition**](OptionsPosition.md)

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

<a name="listoptionspositionclose"></a>
# **ListOptionsPositionClose**
> List&lt;OptionsPositionClose&gt; ListOptionsPositionClose (string underlying, string contract = null)

List user's liquidation history of specified underlying

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListOptionsPositionCloseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OptionsApi(config);
            var underlying = "BTC_USDT";  // string | Underlying (Obtained by listing underlying endpoint)
            var contract = "BTC_USDT-20210916-5000-C";  // string | Options contract name (optional) 

            try
            {
                // List user's liquidation history of specified underlying
                List<OptionsPositionClose> result = apiInstance.ListOptionsPositionClose(underlying, contract);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.ListOptionsPositionClose: " + e.Message);
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
 **underlying** | **string**| Underlying (Obtained by listing underlying endpoint) | 
 **contract** | **string**| Options contract name | [optional] 

### Return type

[**List&lt;OptionsPositionClose&gt;**](OptionsPositionClose.md)

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

<a name="listoptionsorders"></a>
# **ListOptionsOrders**
> List&lt;OptionsOrder&gt; ListOptionsOrders (string status, string contract = null, string underlying = null, int? limit = null, int? offset = null, long? from = null, long? to = null)

List options orders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListOptionsOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OptionsApi(config);
            var status = "open";  // string | Only list the orders with this status
            var contract = "BTC_USDT-20210916-5000-C";  // string | Options contract name (optional) 
            var underlying = "BTC_USDT";  // string | Underlying (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var from = 1547706332;  // long? | Start timestamp (optional) 
            var to = 1547706332;  // long? | End timestamp (optional) 

            try
            {
                // List options orders
                List<OptionsOrder> result = apiInstance.ListOptionsOrders(status, contract, underlying, limit, offset, from, to);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.ListOptionsOrders: " + e.Message);
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
 **contract** | **string**| Options contract name | [optional] 
 **underlying** | **string**| Underlying | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **from** | **long?**| Start timestamp | [optional] 
 **to** | **long?**| End timestamp | [optional] 

### Return type

[**List&lt;OptionsOrder&gt;**](OptionsOrder.md)

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

<a name="createoptionsorder"></a>
# **CreateOptionsOrder**
> OptionsOrder CreateOptionsOrder (OptionsOrder optionsOrder)

Create an options order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateOptionsOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OptionsApi(config);
            var optionsOrder = new OptionsOrder(); // OptionsOrder | 

            try
            {
                // Create an options order
                OptionsOrder result = apiInstance.CreateOptionsOrder(optionsOrder);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.CreateOptionsOrder: " + e.Message);
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
 **optionsOrder** | [**OptionsOrder**](OptionsOrder.md)|  | 

### Return type

[**OptionsOrder**](OptionsOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Order detail |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="canceloptionsorders"></a>
# **CancelOptionsOrders**
> List&lt;OptionsOrder&gt; CancelOptionsOrders (string contract = null, string underlying = null, string side = null)

Cancel all `open` orders matched

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelOptionsOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OptionsApi(config);
            var contract = "BTC_USDT-20210916-5000-C";  // string | Options contract name (optional) 
            var underlying = "BTC_USDT";  // string | Underlying (optional) 
            var side = "ask";  // string | All bids or asks. Both included if not specified (optional) 

            try
            {
                // Cancel all `open` orders matched
                List<OptionsOrder> result = apiInstance.CancelOptionsOrders(contract, underlying, side);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.CancelOptionsOrders: " + e.Message);
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
 **contract** | **string**| Options contract name | [optional] 
 **underlying** | **string**| Underlying | [optional] 
 **side** | **string**| All bids or asks. Both included if not specified | [optional] 

### Return type

[**List&lt;OptionsOrder&gt;**](OptionsOrder.md)

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

<a name="getoptionsorder"></a>
# **GetOptionsOrder**
> OptionsOrder GetOptionsOrder (long orderId)

Get a single order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetOptionsOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OptionsApi(config);
            var orderId = 12345;  // long | Order ID returned on successful order creation

            try
            {
                // Get a single order
                OptionsOrder result = apiInstance.GetOptionsOrder(orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.GetOptionsOrder: " + e.Message);
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
 **orderId** | **long**| Order ID returned on successful order creation | 

### Return type

[**OptionsOrder**](OptionsOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order detail |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="canceloptionsorder"></a>
# **CancelOptionsOrder**
> OptionsOrder CancelOptionsOrder (long orderId)

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
    public class CancelOptionsOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OptionsApi(config);
            var orderId = 12345;  // long | Order ID returned on successful order creation

            try
            {
                // Cancel a single order
                OptionsOrder result = apiInstance.CancelOptionsOrder(orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.CancelOptionsOrder: " + e.Message);
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
 **orderId** | **long**| Order ID returned on successful order creation | 

### Return type

[**OptionsOrder**](OptionsOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order detail |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmyoptionstrades"></a>
# **ListMyOptionsTrades**
> List&lt;OptionsMyTrade&gt; ListMyOptionsTrades (string underlying, string contract = null, int? limit = null, int? offset = null, long? from = null, long? to = null)

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
    public class ListMyOptionsTradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OptionsApi(config);
            var underlying = "BTC_USDT";  // string | Underlying (Obtained by listing underlying endpoint)
            var contract = "BTC_USDT-20210916-5000-C";  // string | Options contract name (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var from = 1547706332;  // long? | Start timestamp (optional) 
            var to = 1547706332;  // long? | End timestamp (optional) 

            try
            {
                // List personal trading history
                List<OptionsMyTrade> result = apiInstance.ListMyOptionsTrades(underlying, contract, limit, offset, from, to);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OptionsApi.ListMyOptionsTrades: " + e.Message);
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
 **underlying** | **string**| Underlying (Obtained by listing underlying endpoint) | 
 **contract** | **string**| Options contract name | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **from** | **long?**| Start timestamp | [optional] 
 **to** | **long?**| End timestamp | [optional] 

### Return type

[**List&lt;OptionsMyTrade&gt;**](OptionsMyTrade.md)

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

