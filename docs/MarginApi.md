# Io.Gate.GateApi.Api.MarginApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListMarginAccounts**](MarginApi.md#listmarginaccounts) | **GET** /margin/accounts | Margin account list
[**GetUserMarginTier**](MarginApi.md#getusermargintier) | **GET** /margin/user/loan_margin_tiers | Check the user&#39;s own leverage lending gradient in the current market
[**GetMarketMarginTier**](MarginApi.md#getmarketmargintier) | **GET** /margin/loan_margin_tiers | Query the current market leverage lending gradient
[**SetUserMarketLeverage**](MarginApi.md#setusermarketleverage) | **POST** /margin/leverage/user_market_setting | Set the user market leverage multiple
[**ListMarginUserAccount**](MarginApi.md#listmarginuseraccount) | **GET** /margin/user/account | Query the user&#39;s leverage account list
[**ListMarginAccountBook**](MarginApi.md#listmarginaccountbook) | **GET** /margin/account_book | List margin account balance change history
[**ListFundingAccounts**](MarginApi.md#listfundingaccounts) | **GET** /margin/funding_accounts | Funding account list
[**GetAutoRepayStatus**](MarginApi.md#getautorepaystatus) | **GET** /margin/auto_repay | Retrieve user auto repayment setting
[**SetAutoRepay**](MarginApi.md#setautorepay) | **POST** /margin/auto_repay | Update user&#39;s auto repayment setting
[**GetMarginTransferable**](MarginApi.md#getmargintransferable) | **GET** /margin/transferable | Get the max transferable amount for a specific margin currency
[**ListCrossMarginLoans**](MarginApi.md#listcrossmarginloans) | **GET** /margin/cross/loans | List cross margin borrow history. (deprecated)
[**ListCrossMarginRepayments**](MarginApi.md#listcrossmarginrepayments) | **GET** /margin/cross/repayments | Retrieve cross margin repayments. (deprecated)


<a name="listmarginaccounts"></a>
# **ListMarginAccounts**
> List&lt;MarginAccount&gt; ListMarginAccounts (string currencyPair = null)

Margin account list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListMarginAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MarginApi(config);
            var currencyPair = "BTC_USDT";  // string | Currency pair (optional) 

            try
            {
                // Margin account list
                List<MarginAccount> result = apiInstance.ListMarginAccounts(currencyPair);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MarginApi.ListMarginAccounts: " + e.Message);
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

### Return type

[**List&lt;MarginAccount&gt;**](MarginAccount.md)

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

<a name="getusermargintier"></a>
# **GetUserMarginTier**
> List&lt;MarginLeverageTier&gt; GetUserMarginTier (string currencyPair)

Check the user's own leverage lending gradient in the current market

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUserMarginTierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MarginApi(config);
            var currencyPair = "BTC_USDT";  // string | Currency pair

            try
            {
                // Check the user's own leverage lending gradient in the current market
                List<MarginLeverageTier> result = apiInstance.GetUserMarginTier(currencyPair);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MarginApi.GetUserMarginTier: " + e.Message);
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

[**List&lt;MarginLeverageTier&gt;**](MarginLeverageTier.md)

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

<a name="getmarketmargintier"></a>
# **GetMarketMarginTier**
> List&lt;MarginLeverageTier&gt; GetMarketMarginTier (string currencyPair)

Query the current market leverage lending gradient

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetMarketMarginTierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new MarginApi(config);
            var currencyPair = "BTC_USDT";  // string | Currency pair

            try
            {
                // Query the current market leverage lending gradient
                List<MarginLeverageTier> result = apiInstance.GetMarketMarginTier(currencyPair);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MarginApi.GetMarketMarginTier: " + e.Message);
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

[**List&lt;MarginLeverageTier&gt;**](MarginLeverageTier.md)

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

<a name="setusermarketleverage"></a>
# **SetUserMarketLeverage**
> void SetUserMarketLeverage (MarginMarketLeverage marginMarketLeverage)

Set the user market leverage multiple

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class SetUserMarketLeverageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MarginApi(config);
            var marginMarketLeverage = new MarginMarketLeverage(); // MarginMarketLeverage | 

            try
            {
                // Set the user market leverage multiple
                apiInstance.SetUserMarketLeverage(marginMarketLeverage);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MarginApi.SetUserMarketLeverage: " + e.Message);
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
 **marginMarketLeverage** | [**MarginMarketLeverage**](MarginMarketLeverage.md)|  | 

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
| **204** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmarginuseraccount"></a>
# **ListMarginUserAccount**
> List&lt;MarginAccount&gt; ListMarginUserAccount (string currencyPair = null)

Query the user's leverage account list

Support querying risk rate per position account and margin rate per position account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListMarginUserAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MarginApi(config);
            var currencyPair = "BTC_USDT";  // string | Currency pair (optional) 

            try
            {
                // Query the user's leverage account list
                List<MarginAccount> result = apiInstance.ListMarginUserAccount(currencyPair);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MarginApi.ListMarginUserAccount: " + e.Message);
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

### Return type

[**List&lt;MarginAccount&gt;**](MarginAccount.md)

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

<a name="listmarginaccountbook"></a>
# **ListMarginAccountBook**
> List&lt;MarginAccountBook&gt; ListMarginAccountBook (string currency = null, string currencyPair = null, string type = null, long? from = null, long? to = null, int? page = null, int? limit = null)

List margin account balance change history

Only transferals from and to margin account are provided for now. Time range allows 30 days at most

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListMarginAccountBookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MarginApi(config);
            var currency = "currency_example";  // string | List records related to specified currency only. If specified, `currency_pair` is also required. (optional) 
            var currencyPair = "currencyPair_example";  // string | List records related to specified currency pair. Used in combination with `currency`. Ignored if `currency` is not provided (optional) 
            var type = "lend";  // string | Only retrieve changes of the specified type. All types will be returned if not specified. (optional) 
            var from = 1627706330;  // long? | Start timestamp of the query (optional) 
            var to = 1635329650;  // long? | Time range ending, default to current time (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)

            try
            {
                // List margin account balance change history
                List<MarginAccountBook> result = apiInstance.ListMarginAccountBook(currency, currencyPair, type, from, to, page, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MarginApi.ListMarginAccountBook: " + e.Message);
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
 **currency** | **string**| List records related to specified currency only. If specified, &#x60;currency_pair&#x60; is also required. | [optional] 
 **currencyPair** | **string**| List records related to specified currency pair. Used in combination with &#x60;currency&#x60;. Ignored if &#x60;currency&#x60; is not provided | [optional] 
 **type** | **string**| Only retrieve changes of the specified type. All types will be returned if not specified. | [optional] 
 **from** | **long?**| Start timestamp of the query | [optional] 
 **to** | **long?**| Time range ending, default to current time | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]

### Return type

[**List&lt;MarginAccountBook&gt;**](MarginAccountBook.md)

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

<a name="listfundingaccounts"></a>
# **ListFundingAccounts**
> List&lt;FundingAccount&gt; ListFundingAccounts (string currency = null)

Funding account list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFundingAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MarginApi(config);
            var currency = "BTC";  // string | Retrieve data of the specified currency (optional) 

            try
            {
                // Funding account list
                List<FundingAccount> result = apiInstance.ListFundingAccounts(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MarginApi.ListFundingAccounts: " + e.Message);
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

[**List&lt;FundingAccount&gt;**](FundingAccount.md)

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

<a name="getautorepaystatus"></a>
# **GetAutoRepayStatus**
> AutoRepaySetting GetAutoRepayStatus ()

Retrieve user auto repayment setting

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetAutoRepayStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MarginApi(config);

            try
            {
                // Retrieve user auto repayment setting
                AutoRepaySetting result = apiInstance.GetAutoRepayStatus();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MarginApi.GetAutoRepayStatus: " + e.Message);
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

[**AutoRepaySetting**](AutoRepaySetting.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Current auto repayment setting |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setautorepay"></a>
# **SetAutoRepay**
> AutoRepaySetting SetAutoRepay (string status)

Update user's auto repayment setting

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class SetAutoRepayExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MarginApi(config);
            var status = "on";  // string | New auto repayment status. `on` - enabled, `off` - disabled

            try
            {
                // Update user's auto repayment setting
                AutoRepaySetting result = apiInstance.SetAutoRepay(status);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MarginApi.SetAutoRepay: " + e.Message);
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
 **status** | **string**| New auto repayment status. &#x60;on&#x60; - enabled, &#x60;off&#x60; - disabled | 

### Return type

[**AutoRepaySetting**](AutoRepaySetting.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Current auto repayment setting |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmargintransferable"></a>
# **GetMarginTransferable**
> MarginTransferable GetMarginTransferable (string currency, string currencyPair = null)

Get the max transferable amount for a specific margin currency

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetMarginTransferableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MarginApi(config);
            var currency = "BTC";  // string | Retrieve data of the specified currency
            var currencyPair = "BTC_USDT";  // string | Currency pair (optional) 

            try
            {
                // Get the max transferable amount for a specific margin currency
                MarginTransferable result = apiInstance.GetMarginTransferable(currency, currencyPair);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MarginApi.GetMarginTransferable: " + e.Message);
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
 **currency** | **string**| Retrieve data of the specified currency | 
 **currencyPair** | **string**| Currency pair | [optional] 

### Return type

[**MarginTransferable**](MarginTransferable.md)

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

<a name="listcrossmarginloans"></a>
# **ListCrossMarginLoans**
> List&lt;CrossMarginLoan&gt; ListCrossMarginLoans (int status, string currency = null, int? limit = null, int? offset = null, bool? reverse = null)

List cross margin borrow history. (deprecated)

Sort by creation time in descending order by default. Set `reverse=false` to return ascending results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListCrossMarginLoansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MarginApi(config);
            var status = 56;  // int | Filter by status. Supported values are 2 and 3. (deprecated.)
            var currency = "currency_example";  // string | Filter by currency (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var reverse = true;  // bool? | Whether to sort in descending order, which is the default. Set `reverse=false` to return ascending results (optional)  (default to true)

            try
            {
                // List cross margin borrow history. (deprecated)
                List<CrossMarginLoan> result = apiInstance.ListCrossMarginLoans(status, currency, limit, offset, reverse);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MarginApi.ListCrossMarginLoans: " + e.Message);
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
 **status** | **int**| Filter by status. Supported values are 2 and 3. (deprecated.) | 
 **currency** | **string**| Filter by currency | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **reverse** | **bool?**| Whether to sort in descending order, which is the default. Set &#x60;reverse&#x3D;false&#x60; to return ascending results | [optional] [default to true]

### Return type

[**List&lt;CrossMarginLoan&gt;**](CrossMarginLoan.md)

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

<a name="listcrossmarginrepayments"></a>
# **ListCrossMarginRepayments**
> List&lt;CrossMarginRepayment&gt; ListCrossMarginRepayments (string currency = null, string loanId = null, int? limit = null, int? offset = null, bool? reverse = null)

Retrieve cross margin repayments. (deprecated)

Sort by creation time in descending order by default. Set `reverse=false` to return ascending results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListCrossMarginRepaymentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MarginApi(config);
            var currency = "BTC";  // string |  (optional) 
            var loanId = "12345";  // string |  (optional) 
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var reverse = true;  // bool? | Whether to sort in descending order, which is the default. Set `reverse=false` to return ascending results (optional)  (default to true)

            try
            {
                // Retrieve cross margin repayments. (deprecated)
                List<CrossMarginRepayment> result = apiInstance.ListCrossMarginRepayments(currency, loanId, limit, offset, reverse);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MarginApi.ListCrossMarginRepayments: " + e.Message);
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
 **currency** | **string**|  | [optional] 
 **loanId** | **string**|  | [optional] 
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **reverse** | **bool?**| Whether to sort in descending order, which is the default. Set &#x60;reverse&#x3D;false&#x60; to return ascending results | [optional] [default to true]

### Return type

[**List&lt;CrossMarginRepayment&gt;**](CrossMarginRepayment.md)

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

