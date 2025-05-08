# Io.Gate.GateApi.Api.CollateralLoanApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListCollateralLoanOrders**](CollateralLoanApi.md#listcollateralloanorders) | **GET** /loan/collateral/orders | List Orders
[**CreateCollateralLoan**](CollateralLoanApi.md#createcollateralloan) | **POST** /loan/collateral/orders | Place order
[**GetCollateralLoanOrderDetail**](CollateralLoanApi.md#getcollateralloanorderdetail) | **GET** /loan/collateral/orders/{order_id} | Get a single order
[**RepayCollateralLoan**](CollateralLoanApi.md#repaycollateralloan) | **POST** /loan/collateral/repay | Repayment
[**ListRepayRecords**](CollateralLoanApi.md#listrepayrecords) | **GET** /loan/collateral/repay_records | Repayment history
[**ListCollateralRecords**](CollateralLoanApi.md#listcollateralrecords) | **GET** /loan/collateral/collaterals | Query collateral adjustment records
[**OperateCollateral**](CollateralLoanApi.md#operatecollateral) | **POST** /loan/collateral/collaterals | Increase or redeem collateral
[**GetUserTotalAmount**](CollateralLoanApi.md#getusertotalamount) | **GET** /loan/collateral/total_amount | Query the total borrowing and collateral amount for the user
[**GetUserLtvInfo**](CollateralLoanApi.md#getuserltvinfo) | **GET** /loan/collateral/ltv | Query user&#39;s collateralization ratio
[**ListCollateralCurrencies**](CollateralLoanApi.md#listcollateralcurrencies) | **GET** /loan/collateral/currencies | Query supported borrowing and collateral currencies


<a name="listcollateralloanorders"></a>
# **ListCollateralLoanOrders**
> List&lt;CollateralOrder&gt; ListCollateralLoanOrders (int? page = null, int? limit = null, string collateralCurrency = null, string borrowCurrency = null)

List Orders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListCollateralLoanOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new CollateralLoanApi(config);
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var collateralCurrency = "BTC";  // string | Collateral (optional) 
            var borrowCurrency = "USDT";  // string | Borrowed currency (optional) 

            try
            {
                // List Orders
                List<CollateralOrder> result = apiInstance.ListCollateralLoanOrders(page, limit, collateralCurrency, borrowCurrency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling CollateralLoanApi.ListCollateralLoanOrders: " + e.Message);
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
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **collateralCurrency** | **string**| Collateral | [optional] 
 **borrowCurrency** | **string**| Borrowed currency | [optional] 

### Return type

[**List&lt;CollateralOrder&gt;**](CollateralOrder.md)

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

<a name="createcollateralloan"></a>
# **CreateCollateralLoan**
> OrderResp CreateCollateralLoan (CreateCollateralOrder createCollateralOrder)

Place order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateCollateralLoanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new CollateralLoanApi(config);
            var createCollateralOrder = new CreateCollateralOrder(); // CreateCollateralOrder | 

            try
            {
                // Place order
                OrderResp result = apiInstance.CreateCollateralLoan(createCollateralOrder);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling CollateralLoanApi.CreateCollateralLoan: " + e.Message);
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
 **createCollateralOrder** | [**CreateCollateralOrder**](CreateCollateralOrder.md)|  | 

### Return type

[**OrderResp**](OrderResp.md)

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

<a name="getcollateralloanorderdetail"></a>
# **GetCollateralLoanOrderDetail**
> CollateralOrder GetCollateralLoanOrderDetail (long orderId)

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
    public class GetCollateralLoanOrderDetailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new CollateralLoanApi(config);
            var orderId = 100001;  // long | Order ID returned on successful order creation

            try
            {
                // Get a single order
                CollateralOrder result = apiInstance.GetCollateralLoanOrderDetail(orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling CollateralLoanApi.GetCollateralLoanOrderDetail: " + e.Message);
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

[**CollateralOrder**](CollateralOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repaycollateralloan"></a>
# **RepayCollateralLoan**
> RepayResp RepayCollateralLoan (RepayLoan repayLoan)

Repayment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class RepayCollateralLoanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new CollateralLoanApi(config);
            var repayLoan = new RepayLoan(); // RepayLoan | 

            try
            {
                // Repayment
                RepayResp result = apiInstance.RepayCollateralLoan(repayLoan);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling CollateralLoanApi.RepayCollateralLoan: " + e.Message);
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
 **repayLoan** | [**RepayLoan**](RepayLoan.md)|  | 

### Return type

[**RepayResp**](RepayResp.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Operated successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listrepayrecords"></a>
# **ListRepayRecords**
> List&lt;RepayRecord&gt; ListRepayRecords (string source, string borrowCurrency = null, string collateralCurrency = null, int? page = null, int? limit = null, long? from = null, long? to = null)

Repayment history

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListRepayRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new CollateralLoanApi(config);
            var source = "repay";  // string | Operation type: repay - Regular repayment, liquidate - Liquidation
            var borrowCurrency = "USDT";  // string | Borrowed currency (optional) 
            var collateralCurrency = "BTC";  // string | Collateral (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var from = 1609459200;  // long? | Start timestamp of the query (optional) 
            var to = 1609459200;  // long? | Time range ending, default to current time (optional) 

            try
            {
                // Repayment history
                List<RepayRecord> result = apiInstance.ListRepayRecords(source, borrowCurrency, collateralCurrency, page, limit, from, to);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling CollateralLoanApi.ListRepayRecords: " + e.Message);
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
 **source** | **string**| Operation type: repay - Regular repayment, liquidate - Liquidation | 
 **borrowCurrency** | **string**| Borrowed currency | [optional] 
 **collateralCurrency** | **string**| Collateral | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **from** | **long?**| Start timestamp of the query | [optional] 
 **to** | **long?**| Time range ending, default to current time | [optional] 

### Return type

[**List&lt;RepayRecord&gt;**](RepayRecord.md)

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

<a name="listcollateralrecords"></a>
# **ListCollateralRecords**
> List&lt;CollateralRecord&gt; ListCollateralRecords (int? page = null, int? limit = null, long? from = null, long? to = null, string borrowCurrency = null, string collateralCurrency = null)

Query collateral adjustment records

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListCollateralRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new CollateralLoanApi(config);
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum number of records to be returned in a single list (optional)  (default to 100)
            var from = 1609459200;  // long? | Start timestamp of the query (optional) 
            var to = 1609459200;  // long? | Time range ending, default to current time (optional) 
            var borrowCurrency = "USDT";  // string | Borrowed currency (optional) 
            var collateralCurrency = "BTC";  // string | Collateral (optional) 

            try
            {
                // Query collateral adjustment records
                List<CollateralRecord> result = apiInstance.ListCollateralRecords(page, limit, from, to, borrowCurrency, collateralCurrency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling CollateralLoanApi.ListCollateralRecords: " + e.Message);
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
 **limit** | **int?**| Maximum number of records to be returned in a single list | [optional] [default to 100]
 **from** | **long?**| Start timestamp of the query | [optional] 
 **to** | **long?**| Time range ending, default to current time | [optional] 
 **borrowCurrency** | **string**| Borrowed currency | [optional] 
 **collateralCurrency** | **string**| Collateral | [optional] 

### Return type

[**List&lt;CollateralRecord&gt;**](CollateralRecord.md)

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

<a name="operatecollateral"></a>
# **OperateCollateral**
> void OperateCollateral (CollateralAlign collateralAlign)

Increase or redeem collateral

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class OperateCollateralExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new CollateralLoanApi(config);
            var collateralAlign = new CollateralAlign(); // CollateralAlign | 

            try
            {
                // Increase or redeem collateral
                apiInstance.OperateCollateral(collateralAlign);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling CollateralLoanApi.OperateCollateral: " + e.Message);
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
 **collateralAlign** | [**CollateralAlign**](CollateralAlign.md)|  | 

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

<a name="getusertotalamount"></a>
# **GetUserTotalAmount**
> UserTotalAmount GetUserTotalAmount ()

Query the total borrowing and collateral amount for the user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUserTotalAmountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new CollateralLoanApi(config);

            try
            {
                // Query the total borrowing and collateral amount for the user
                UserTotalAmount result = apiInstance.GetUserTotalAmount();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling CollateralLoanApi.GetUserTotalAmount: " + e.Message);
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

[**UserTotalAmount**](UserTotalAmount.md)

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

<a name="getuserltvinfo"></a>
# **GetUserLtvInfo**
> UserLtvInfo GetUserLtvInfo (string collateralCurrency, string borrowCurrency)

Query user's collateralization ratio

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUserLtvInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new CollateralLoanApi(config);
            var collateralCurrency = "BTC";  // string | Collateral
            var borrowCurrency = "USDT";  // string | Borrowed currency

            try
            {
                // Query user's collateralization ratio
                UserLtvInfo result = apiInstance.GetUserLtvInfo(collateralCurrency, borrowCurrency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling CollateralLoanApi.GetUserLtvInfo: " + e.Message);
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
 **collateralCurrency** | **string**| Collateral | 
 **borrowCurrency** | **string**| Borrowed currency | 

### Return type

[**UserLtvInfo**](UserLtvInfo.md)

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

<a name="listcollateralcurrencies"></a>
# **ListCollateralCurrencies**
> List&lt;CollateralLoanCurrency&gt; ListCollateralCurrencies (string loanCurrency = null)

Query supported borrowing and collateral currencies

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListCollateralCurrenciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new CollateralLoanApi(config);
            var loanCurrency = "BTC";  // string | The parameter loan_currency is used to specify the borrowing currency. If loan_currency is not provided, the API will return all supported borrowing currencies. If loan_currency is provided, the API will return an array of collateral currencies supported for the specified borrowing currency. (optional) 

            try
            {
                // Query supported borrowing and collateral currencies
                List<CollateralLoanCurrency> result = apiInstance.ListCollateralCurrencies(loanCurrency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling CollateralLoanApi.ListCollateralCurrencies: " + e.Message);
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
 **loanCurrency** | **string**| The parameter loan_currency is used to specify the borrowing currency. If loan_currency is not provided, the API will return all supported borrowing currencies. If loan_currency is provided, the API will return an array of collateral currencies supported for the specified borrowing currency. | [optional] 

### Return type

[**List&lt;CollateralLoanCurrency&gt;**](CollateralLoanCurrency.md)

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

