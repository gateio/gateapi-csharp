# Io.Gate.GateApi.Api.MarginUniApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListUniCurrencyPairs**](MarginUniApi.md#listunicurrencypairs) | **GET** /margin/uni/currency_pairs | List lending markets
[**GetUniCurrencyPair**](MarginUniApi.md#getunicurrencypair) | **GET** /margin/uni/currency_pairs/{currency_pair} | Get detail of lending market
[**ListUniLoans**](MarginUniApi.md#listuniloans) | **GET** /margin/uni/loans | List loans
[**CreateUniLoan**](MarginUniApi.md#createuniloan) | **POST** /margin/uni/loans | Borrow or repay
[**ListUniLoanRecords**](MarginUniApi.md#listuniloanrecords) | **GET** /margin/uni/loan_records | Get load records
[**ListUniLoanInterestRecords**](MarginUniApi.md#listuniloaninterestrecords) | **GET** /margin/uni/interest_records | List interest records
[**GetUniBorrowable**](MarginUniApi.md#getuniborrowable) | **GET** /margin/uni/borrowable | Get maximum borrowable


<a name="listunicurrencypairs"></a>
# **ListUniCurrencyPairs**
> List&lt;UniCurrencyPair&gt; ListUniCurrencyPairs ()

List lending markets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListUniCurrencyPairsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new MarginUniApi(config);

            try
            {
                // List lending markets
                List<UniCurrencyPair> result = apiInstance.ListUniCurrencyPairs();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MarginUniApi.ListUniCurrencyPairs: " + e.Message);
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

[**List&lt;UniCurrencyPair&gt;**](UniCurrencyPair.md)

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

<a name="getunicurrencypair"></a>
# **GetUniCurrencyPair**
> UniCurrencyPair GetUniCurrencyPair (string currencyPair)

Get detail of lending market

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUniCurrencyPairExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new MarginUniApi(config);
            var currencyPair = "AE_USDT";  // string | Currency pair

            try
            {
                // Get detail of lending market
                UniCurrencyPair result = apiInstance.GetUniCurrencyPair(currencyPair);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MarginUniApi.GetUniCurrencyPair: " + e.Message);
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

[**UniCurrencyPair**](UniCurrencyPair.md)

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

<a name="listuniloans"></a>
# **ListUniLoans**
> List&lt;UniLoan&gt; ListUniLoans (string currencyPair = null, string currency = null, int? page = null, int? limit = null)

List loans

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListUniLoansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MarginUniApi(config);
            var currencyPair = "BTC_USDT";  // string | Currency pair (optional) 
            var currency = "BTC";  // string | Retrieve data of the specified currency (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum response items.  Default: 100, minimum: 1, Maximum: 100 (optional)  (default to 100)

            try
            {
                // List loans
                List<UniLoan> result = apiInstance.ListUniLoans(currencyPair, currency, page, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MarginUniApi.ListUniLoans: " + e.Message);
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
 **currency** | **string**| Retrieve data of the specified currency | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum response items.  Default: 100, minimum: 1, Maximum: 100 | [optional] [default to 100]

### Return type

[**List&lt;UniLoan&gt;**](UniLoan.md)

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

<a name="createuniloan"></a>
# **CreateUniLoan**
> void CreateUniLoan (CreateUniLoan createUniLoan)

Borrow or repay

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateUniLoanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MarginUniApi(config);
            var createUniLoan = new CreateUniLoan(); // CreateUniLoan | 

            try
            {
                // Borrow or repay
                apiInstance.CreateUniLoan(createUniLoan);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MarginUniApi.CreateUniLoan: " + e.Message);
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
 **createUniLoan** | [**CreateUniLoan**](CreateUniLoan.md)|  | 

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
| **204** | Operated successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listuniloanrecords"></a>
# **ListUniLoanRecords**
> List&lt;UniLoanRecord&gt; ListUniLoanRecords (string type = null, string currency = null, string currencyPair = null, int? page = null, int? limit = null)

Get load records

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListUniLoanRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MarginUniApi(config);
            var type = "type_example";  // string | type: borrow - borrow, repay - repay (optional) 
            var currency = "BTC";  // string | Retrieve data of the specified currency (optional) 
            var currencyPair = "BTC_USDT";  // string | Currency pair (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum response items.  Default: 100, minimum: 1, Maximum: 100 (optional)  (default to 100)

            try
            {
                // Get load records
                List<UniLoanRecord> result = apiInstance.ListUniLoanRecords(type, currency, currencyPair, page, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MarginUniApi.ListUniLoanRecords: " + e.Message);
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
 **type** | **string**| type: borrow - borrow, repay - repay | [optional] 
 **currency** | **string**| Retrieve data of the specified currency | [optional] 
 **currencyPair** | **string**| Currency pair | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum response items.  Default: 100, minimum: 1, Maximum: 100 | [optional] [default to 100]

### Return type

[**List&lt;UniLoanRecord&gt;**](UniLoanRecord.md)

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

<a name="listuniloaninterestrecords"></a>
# **ListUniLoanInterestRecords**
> List&lt;UniLoanInterestRecord&gt; ListUniLoanInterestRecords (string currencyPair = null, string currency = null, int? page = null, int? limit = null)

List interest records

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListUniLoanInterestRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MarginUniApi(config);
            var currencyPair = "BTC_USDT";  // string | Currency pair (optional) 
            var currency = "BTC";  // string | Retrieve data of the specified currency (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum response items.  Default: 100, minimum: 1, Maximum: 100 (optional)  (default to 100)

            try
            {
                // List interest records
                List<UniLoanInterestRecord> result = apiInstance.ListUniLoanInterestRecords(currencyPair, currency, page, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MarginUniApi.ListUniLoanInterestRecords: " + e.Message);
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
 **currency** | **string**| Retrieve data of the specified currency | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum response items.  Default: 100, minimum: 1, Maximum: 100 | [optional] [default to 100]

### Return type

[**List&lt;UniLoanInterestRecord&gt;**](UniLoanInterestRecord.md)

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

<a name="getuniborrowable"></a>
# **GetUniBorrowable**
> MaxUniBorrowable GetUniBorrowable (string currency, string currencyPair)

Get maximum borrowable

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUniBorrowableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MarginUniApi(config);
            var currency = "BTC";  // string | Retrieve data of the specified currency
            var currencyPair = "BTC_USDT";  // string | Currency pair

            try
            {
                // Get maximum borrowable
                MaxUniBorrowable result = apiInstance.GetUniBorrowable(currency, currencyPair);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MarginUniApi.GetUniBorrowable: " + e.Message);
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
 **currencyPair** | **string**| Currency pair | 

### Return type

[**MaxUniBorrowable**](MaxUniBorrowable.md)

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

