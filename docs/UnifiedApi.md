# Io.Gate.GateApi.Api.UnifiedApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListUnifiedAccounts**](UnifiedApi.md#listunifiedaccounts) | **GET** /unified/accounts | Get unified account information
[**GetUnifiedBorrowable**](UnifiedApi.md#getunifiedborrowable) | **GET** /unified/borrowable | Query about the maximum borrowing for the unified account
[**GetUnifiedTransferable**](UnifiedApi.md#getunifiedtransferable) | **GET** /unified/transferable | Query about the maximum transferable for the unified account
[**ListUnifiedLoans**](UnifiedApi.md#listunifiedloans) | **GET** /unified/loans | List loans
[**CreateUnifiedLoan**](UnifiedApi.md#createunifiedloan) | **POST** /unified/loans | Borrow or repay
[**ListUnifiedLoanRecords**](UnifiedApi.md#listunifiedloanrecords) | **GET** /unified/loan_records | Get load records
[**ListUnifiedLoanInterestRecords**](UnifiedApi.md#listunifiedloaninterestrecords) | **GET** /unified/interest_records | List interest records
[**GetUnifiedRiskUnits**](UnifiedApi.md#getunifiedriskunits) | **GET** /unified/risk_units | Retrieve user risk unit details, only valid in portfolio margin mode
[**GetUnifiedMode**](UnifiedApi.md#getunifiedmode) | **GET** /unified/unified_mode | Query mode of the unified account
[**SetUnifiedMode**](UnifiedApi.md#setunifiedmode) | **PUT** /unified/unified_mode | Set mode of the unified account
[**GetUnifiedEstimateRate**](UnifiedApi.md#getunifiedestimaterate) | **GET** /unified/estimate_rate | Get unified estimate rate
[**ListCurrencyDiscountTiers**](UnifiedApi.md#listcurrencydiscounttiers) | **GET** /unified/currency_discount_tiers | List currency discount tiers
[**ListLoanMarginTiers**](UnifiedApi.md#listloanmargintiers) | **GET** /unified/loan_margin_tiers | List loan margin tiers
[**CalculatePortfolioMargin**](UnifiedApi.md#calculateportfoliomargin) | **POST** /unified/portfolio_calculator | Portfolio margin calculator
[**GetUserLeverageCurrencyConfig**](UnifiedApi.md#getuserleveragecurrencyconfig) | **GET** /unified/leverage/user_currency_config | Minimum currency leverage that can be set
[**GetUserLeverageCurrencySetting**](UnifiedApi.md#getuserleveragecurrencysetting) | **GET** /unified/leverage/user_currency_setting | Get the user&#39;s currency leverage. If currency is not passed, query all currencies.
[**SetUserLeverageCurrencySetting**](UnifiedApi.md#setuserleveragecurrencysetting) | **POST** /unified/leverage/user_currency_setting | Set the loan currency leverage
[**GetHistoryLoanRate**](UnifiedApi.md#gethistoryloanrate) | **GET** /unified/history_loan_rate | get historical lending rates


<a name="listunifiedaccounts"></a>
# **ListUnifiedAccounts**
> UnifiedAccount ListUnifiedAccounts (string currency = null)

Get unified account information

The assets of each currency in the account will be adjusted according to their liquidity, defined by corresponding adjustment coefficients, and then uniformly converted to USD to calculate the total asset value and position value of the account.  You can refer to the [Formula](#portfolio-account) in the documentation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListUnifiedAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var currency = "BTC";  // string | Retrieve data of the specified currency (optional) 

            try
            {
                // Get unified account information
                UnifiedAccount result = apiInstance.ListUnifiedAccounts(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.ListUnifiedAccounts: " + e.Message);
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

[**UnifiedAccount**](UnifiedAccount.md)

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

<a name="getunifiedborrowable"></a>
# **GetUnifiedBorrowable**
> UnifiedBorrowable GetUnifiedBorrowable (string currency)

Query about the maximum borrowing for the unified account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUnifiedBorrowableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var currency = "BTC";  // string | Retrieve data of the specified currency

            try
            {
                // Query about the maximum borrowing for the unified account
                UnifiedBorrowable result = apiInstance.GetUnifiedBorrowable(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.GetUnifiedBorrowable: " + e.Message);
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

### Return type

[**UnifiedBorrowable**](UnifiedBorrowable.md)

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

<a name="getunifiedtransferable"></a>
# **GetUnifiedTransferable**
> UnifiedTransferable GetUnifiedTransferable (string currency)

Query about the maximum transferable for the unified account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUnifiedTransferableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var currency = "BTC";  // string | Retrieve data of the specified currency

            try
            {
                // Query about the maximum transferable for the unified account
                UnifiedTransferable result = apiInstance.GetUnifiedTransferable(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.GetUnifiedTransferable: " + e.Message);
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

### Return type

[**UnifiedTransferable**](UnifiedTransferable.md)

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

<a name="listunifiedloans"></a>
# **ListUnifiedLoans**
> List&lt;UniLoan&gt; ListUnifiedLoans (string currency = null, int? page = null, int? limit = null, string type = null)

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
    public class ListUnifiedLoansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var currency = "BTC";  // string | Retrieve data of the specified currency (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum response items.  Default: 100, minimum: 1, Maximum: 100 (optional)  (default to 100)
            var type = "platform";  // string | Loan type, platform - platform, margin - margin (optional) 

            try
            {
                // List loans
                List<UniLoan> result = apiInstance.ListUnifiedLoans(currency, page, limit, type);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.ListUnifiedLoans: " + e.Message);
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
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum response items.  Default: 100, minimum: 1, Maximum: 100 | [optional] [default to 100]
 **type** | **string**| Loan type, platform - platform, margin - margin | [optional] 

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

<a name="createunifiedloan"></a>
# **CreateUnifiedLoan**
> void CreateUnifiedLoan (UnifiedLoan unifiedLoan)

Borrow or repay

When borrowing, it is essential to ensure that the borrowed amount is not below the minimum borrowing threshold for the specific cryptocurrency and does not exceed the maximum borrowing limit set by the platform and the user.  The interest on the loan will be automatically deducted from the account at regular intervals. It is the user's responsibility to manage the repayment of the borrowed amount.  For repayment, the option to repay the entire borrowed amount is available by setting the parameter `repaid_all=true`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateUnifiedLoanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var unifiedLoan = new UnifiedLoan(); // UnifiedLoan | 

            try
            {
                // Borrow or repay
                apiInstance.CreateUnifiedLoan(unifiedLoan);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.CreateUnifiedLoan: " + e.Message);
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
 **unifiedLoan** | [**UnifiedLoan**](UnifiedLoan.md)|  | 

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

<a name="listunifiedloanrecords"></a>
# **ListUnifiedLoanRecords**
> List&lt;UnifiedLoanRecord&gt; ListUnifiedLoanRecords (string type = null, string currency = null, int? page = null, int? limit = null)

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
    public class ListUnifiedLoanRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var type = "type_example";  // string | The types of lending records, borrow - indicates the action of borrowing funds, repay - indicates the action of repaying the borrowed funds (optional) 
            var currency = "BTC";  // string | Retrieve data of the specified currency (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum response items.  Default: 100, minimum: 1, Maximum: 100 (optional)  (default to 100)

            try
            {
                // Get load records
                List<UnifiedLoanRecord> result = apiInstance.ListUnifiedLoanRecords(type, currency, page, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.ListUnifiedLoanRecords: " + e.Message);
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
 **type** | **string**| The types of lending records, borrow - indicates the action of borrowing funds, repay - indicates the action of repaying the borrowed funds | [optional] 
 **currency** | **string**| Retrieve data of the specified currency | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum response items.  Default: 100, minimum: 1, Maximum: 100 | [optional] [default to 100]

### Return type

[**List&lt;UnifiedLoanRecord&gt;**](UnifiedLoanRecord.md)

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

<a name="listunifiedloaninterestrecords"></a>
# **ListUnifiedLoanInterestRecords**
> List&lt;UniLoanInterestRecord&gt; ListUnifiedLoanInterestRecords (string currency = null, int? page = null, int? limit = null, long? from = null, long? to = null, string type = null)

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
    public class ListUnifiedLoanInterestRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var currency = "BTC";  // string | Retrieve data of the specified currency (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum response items.  Default: 100, minimum: 1, Maximum: 100 (optional)  (default to 100)
            var from = 1627706330;  // long? | Start timestamp of the query (optional) 
            var to = 1635329650;  // long? | Time range ending, default to current time (optional) 
            var type = "platform";  // string | Loan type, platform loan - platform, leverage loan - margin, if not passed, defaults to margin (optional) 

            try
            {
                // List interest records
                List<UniLoanInterestRecord> result = apiInstance.ListUnifiedLoanInterestRecords(currency, page, limit, from, to, type);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.ListUnifiedLoanInterestRecords: " + e.Message);
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
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum response items.  Default: 100, minimum: 1, Maximum: 100 | [optional] [default to 100]
 **from** | **long?**| Start timestamp of the query | [optional] 
 **to** | **long?**| Time range ending, default to current time | [optional] 
 **type** | **string**| Loan type, platform loan - platform, leverage loan - margin, if not passed, defaults to margin | [optional] 

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

<a name="getunifiedriskunits"></a>
# **GetUnifiedRiskUnits**
> UnifiedRiskUnits GetUnifiedRiskUnits ()

Retrieve user risk unit details, only valid in portfolio margin mode

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUnifiedRiskUnitsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);

            try
            {
                // Retrieve user risk unit details, only valid in portfolio margin mode
                UnifiedRiskUnits result = apiInstance.GetUnifiedRiskUnits();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.GetUnifiedRiskUnits: " + e.Message);
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

[**UnifiedRiskUnits**](UnifiedRiskUnits.md)

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

<a name="getunifiedmode"></a>
# **GetUnifiedMode**
> UnifiedModeSet GetUnifiedMode ()

Query mode of the unified account

Unified account mode: - `classic`: Classic account mode - `multi_currency`: Cross-currency margin mode - `portfolio`: Portfolio margin mode - `single_currency`: Single-currency margin mode

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUnifiedModeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);

            try
            {
                // Query mode of the unified account
                UnifiedModeSet result = apiInstance.GetUnifiedMode();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.GetUnifiedMode: " + e.Message);
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

[**UnifiedModeSet**](UnifiedModeSet.md)

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

<a name="setunifiedmode"></a>
# **SetUnifiedMode**
> void SetUnifiedMode (UnifiedModeSet unifiedModeSet)

Set mode of the unified account

Switching each account mode only requires passing the parameters of the corresponding account mode, and supports turning on or off the configuration switch in the corresponding account mode when switching the account mode  - When opening the classic account mode, mode=classic ```  PUT /unified/unified_mode  {  \"mode\": \"classic\"  } ``` - Open the cross-currency margin mode, mode=multi_currency ```  PUT /unified/unified_mode  {  \"mode\": \"multi_currency\",  \"settings\": {  \"usdt_futures\": true  }  } ``` - When the portfolio margin mode is enabled, mode=portfolio ```  PUT /unified/unified_mode  {  \"mode\": \"portfolio\",  \"settings\": {  \"spot_hedge\": true  }  } ``` - When the portfolio margin mode is enabled, mode=single_currency ```  PUT /unified/unified_mode  {  \"mode\": \"single_currency\"  } ```

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class SetUnifiedModeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var unifiedModeSet = new UnifiedModeSet(); // UnifiedModeSet | 

            try
            {
                // Set mode of the unified account
                apiInstance.SetUnifiedMode(unifiedModeSet);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.SetUnifiedMode: " + e.Message);
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
 **unifiedModeSet** | [**UnifiedModeSet**](UnifiedModeSet.md)|  | 

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

<a name="getunifiedestimaterate"></a>
# **GetUnifiedEstimateRate**
> Dictionary&lt;string, string&gt; GetUnifiedEstimateRate (List<string> currencies)

Get unified estimate rate

Due to fluctuations in lending depth, hourly interest rates may vary, and thus, I cannot provide exact rates. When a currency is not supported, the interest rate returned will be an empty string.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUnifiedEstimateRateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var currencies = new List<string>(); // List<string> | Specify the currency names for querying in an array, separated by commas, with a maximum of 10 currencies.

            try
            {
                // Get unified estimate rate
                Dictionary<string, string> result = apiInstance.GetUnifiedEstimateRate(currencies);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.GetUnifiedEstimateRate: " + e.Message);
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
 **currencies** | [**List&lt;string&gt;**](string.md)| Specify the currency names for querying in an array, separated by commas, with a maximum of 10 currencies. | 

### Return type

**Dictionary<string, string>**

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

<a name="listcurrencydiscounttiers"></a>
# **ListCurrencyDiscountTiers**
> List&lt;UnifiedDiscount&gt; ListCurrencyDiscountTiers ()

List currency discount tiers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListCurrencyDiscountTiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new UnifiedApi(config);

            try
            {
                // List currency discount tiers
                List<UnifiedDiscount> result = apiInstance.ListCurrencyDiscountTiers();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.ListCurrencyDiscountTiers: " + e.Message);
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

[**List&lt;UnifiedDiscount&gt;**](UnifiedDiscount.md)

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

<a name="listloanmargintiers"></a>
# **ListLoanMarginTiers**
> List&lt;UnifiedMarginTiers&gt; ListLoanMarginTiers ()

List loan margin tiers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListLoanMarginTiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new UnifiedApi(config);

            try
            {
                // List loan margin tiers
                List<UnifiedMarginTiers> result = apiInstance.ListLoanMarginTiers();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.ListLoanMarginTiers: " + e.Message);
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

[**List&lt;UnifiedMarginTiers&gt;**](UnifiedMarginTiers.md)

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

<a name="calculateportfoliomargin"></a>
# **CalculatePortfolioMargin**
> UnifiedPortfolioOutput CalculatePortfolioMargin (UnifiedPortfolioInput unifiedPortfolioInput)

Portfolio margin calculator

Portfolio Margin Calculator When inputting a simulated position portfolio, each position includes the position name and quantity held, supporting markets within the range of BTC and ETH perpetual contracts, options, and spot markets. When inputting simulated orders, each order includes the market identifier, order price, and order quantity,  supporting markets within the range of BTC and ETH perpetual contracts, options, and spot markets. Market orders are not included.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CalculatePortfolioMarginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new UnifiedApi(config);
            var unifiedPortfolioInput = new UnifiedPortfolioInput(); // UnifiedPortfolioInput | 

            try
            {
                // Portfolio margin calculator
                UnifiedPortfolioOutput result = apiInstance.CalculatePortfolioMargin(unifiedPortfolioInput);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.CalculatePortfolioMargin: " + e.Message);
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
 **unifiedPortfolioInput** | [**UnifiedPortfolioInput**](UnifiedPortfolioInput.md)|  | 

### Return type

[**UnifiedPortfolioOutput**](UnifiedPortfolioOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserleveragecurrencyconfig"></a>
# **GetUserLeverageCurrencyConfig**
> UnifiedLeverageConfig GetUserLeverageCurrencyConfig (string currency)

Minimum currency leverage that can be set

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUserLeverageCurrencyConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var currency = "BTC";  // string | Currency

            try
            {
                // Minimum currency leverage that can be set
                UnifiedLeverageConfig result = apiInstance.GetUserLeverageCurrencyConfig(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.GetUserLeverageCurrencyConfig: " + e.Message);
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
 **currency** | **string**| Currency | 

### Return type

[**UnifiedLeverageConfig**](UnifiedLeverageConfig.md)

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

<a name="getuserleveragecurrencysetting"></a>
# **GetUserLeverageCurrencySetting**
> UnifiedLeverageSetting GetUserLeverageCurrencySetting (string currency = null)

Get the user's currency leverage. If currency is not passed, query all currencies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUserLeverageCurrencySettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var currency = "BTC";  // string | Currency (optional) 

            try
            {
                // Get the user's currency leverage. If currency is not passed, query all currencies.
                UnifiedLeverageSetting result = apiInstance.GetUserLeverageCurrencySetting(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.GetUserLeverageCurrencySetting: " + e.Message);
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
 **currency** | **string**| Currency | [optional] 

### Return type

[**UnifiedLeverageSetting**](UnifiedLeverageSetting.md)

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

<a name="setuserleveragecurrencysetting"></a>
# **SetUserLeverageCurrencySetting**
> void SetUserLeverageCurrencySetting (UnifiedLeverageSetting unifiedLeverageSetting = null)

Set the loan currency leverage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class SetUserLeverageCurrencySettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var unifiedLeverageSetting = new UnifiedLeverageSetting(); // UnifiedLeverageSetting |  (optional) 

            try
            {
                // Set the loan currency leverage
                apiInstance.SetUserLeverageCurrencySetting(unifiedLeverageSetting);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.SetUserLeverageCurrencySetting: " + e.Message);
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
 **unifiedLeverageSetting** | [**UnifiedLeverageSetting**](UnifiedLeverageSetting.md)|  | [optional] 

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

<a name="gethistoryloanrate"></a>
# **GetHistoryLoanRate**
> UnifiedHistoryLoanRate GetHistoryLoanRate (string currency, string tier = null, int? page = null, int? limit = null)

get historical lending rates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetHistoryLoanRateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new UnifiedApi(config);
            var currency = "USDT";  // string | Currency
            var tier = "1";  // string | The VIP level of the floating rate that needs to be queried (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum response items.  Default: 100, minimum: 1, Maximum: 100 (optional)  (default to 100)

            try
            {
                // get historical lending rates
                UnifiedHistoryLoanRate result = apiInstance.GetHistoryLoanRate(currency, tier, page, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling UnifiedApi.GetHistoryLoanRate: " + e.Message);
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
 **currency** | **string**| Currency | 
 **tier** | **string**| The VIP level of the floating rate that needs to be queried | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum response items.  Default: 100, minimum: 1, Maximum: 100 | [optional] [default to 100]

### Return type

[**UnifiedHistoryLoanRate**](UnifiedHistoryLoanRate.md)

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

