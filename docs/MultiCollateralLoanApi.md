# Io.Gate.GateApi.Api.MultiCollateralLoanApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListMultiCollateralOrders**](MultiCollateralLoanApi.md#listmulticollateralorders) | **GET** /loan/multi_collateral/orders | List Multi-Collateral Orders.
[**CreateMultiCollateral**](MultiCollateralLoanApi.md#createmulticollateral) | **POST** /loan/multi_collateral/orders | Create Multi-Collateral Order.
[**GetMultiCollateralOrderDetail**](MultiCollateralLoanApi.md#getmulticollateralorderdetail) | **GET** /loan/multi_collateral/orders/{order_id} | Get Multi-Collateral Order Detail.
[**ListMultiRepayRecords**](MultiCollateralLoanApi.md#listmultirepayrecords) | **GET** /loan/multi_collateral/repay | List Multi-Collateral Repay Records.
[**RepayMultiCollateralLoan**](MultiCollateralLoanApi.md#repaymulticollateralloan) | **POST** /loan/multi_collateral/repay | Repay Multi-Collateral Loan.
[**ListMultiCollateralRecords**](MultiCollateralLoanApi.md#listmulticollateralrecords) | **GET** /loan/multi_collateral/mortgage | Query collateral adjustment records.
[**OperateMultiCollateral**](MultiCollateralLoanApi.md#operatemulticollateral) | **POST** /loan/multi_collateral/mortgage | Operate Multi-Collateral.
[**ListUserCurrencyQuota**](MultiCollateralLoanApi.md#listusercurrencyquota) | **GET** /loan/multi_collateral/currency_quota | List User Currency Quota.
[**ListMultiCollateralCurrencies**](MultiCollateralLoanApi.md#listmulticollateralcurrencies) | **GET** /loan/multi_collateral/currencies | Query supported borrowing and collateral currencies in Multi-Collateral.
[**GetMultiCollateralLtv**](MultiCollateralLoanApi.md#getmulticollateralltv) | **GET** /loan/multi_collateral/ltv | Get Multi-Collateral ratio.
[**GetMultiCollateralFixRate**](MultiCollateralLoanApi.md#getmulticollateralfixrate) | **GET** /loan/multi_collateral/fixed_rate | Query fixed interest rates for the currency for 7 days and 30 days.
[**GetMultiCollateralCurrentRate**](MultiCollateralLoanApi.md#getmulticollateralcurrentrate) | **GET** /loan/multi_collateral/current_rate | Query the current interest rate of the currency.


<a name="listmulticollateralorders"></a>
# **ListMultiCollateralOrders**
> List&lt;MultiCollateralOrder&gt; ListMultiCollateralOrders (int? page = null, int? limit = null, string sort = null, string orderType = null)

List Multi-Collateral Orders.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListMultiCollateralOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MultiCollateralLoanApi(config);
            var page = 1;  // int? | Page number. (optional)  (default to 1)
            var limit = 10;  // int? | Maximum number of records to be returned in a single list. (optional)  (default to 10)
            var sort = "ltv_asc";  // string | Query the current interest rate of the currency in the previous hour. (optional) 
            var orderType = "current";  // string | Order type: current - Query current orders, fixed - Query fixed orders, defaults to current orders if not specified (optional) 

            try
            {
                // List Multi-Collateral Orders.
                List<MultiCollateralOrder> result = apiInstance.ListMultiCollateralOrders(page, limit, sort, orderType);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.ListMultiCollateralOrders: " + e.Message);
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
 **page** | **int?**| Page number. | [optional] [default to 1]
 **limit** | **int?**| Maximum number of records to be returned in a single list. | [optional] [default to 10]
 **sort** | **string**| Query the current interest rate of the currency in the previous hour. | [optional] 
 **orderType** | **string**| Order type: current - Query current orders, fixed - Query fixed orders, defaults to current orders if not specified | [optional] 

### Return type

[**List&lt;MultiCollateralOrder&gt;**](MultiCollateralOrder.md)

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

<a name="createmulticollateral"></a>
# **CreateMultiCollateral**
> OrderResp CreateMultiCollateral (CreateMultiCollateralOrder createMultiCollateralOrder)

Create Multi-Collateral Order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateMultiCollateralExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MultiCollateralLoanApi(config);
            var createMultiCollateralOrder = new CreateMultiCollateralOrder(); // CreateMultiCollateralOrder | 

            try
            {
                // Create Multi-Collateral Order.
                OrderResp result = apiInstance.CreateMultiCollateral(createMultiCollateralOrder);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.CreateMultiCollateral: " + e.Message);
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
 **createMultiCollateralOrder** | [**CreateMultiCollateralOrder**](CreateMultiCollateralOrder.md)|  | 

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
| **200** | Success. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmulticollateralorderdetail"></a>
# **GetMultiCollateralOrderDetail**
> MultiCollateralOrder GetMultiCollateralOrderDetail (string orderId)

Get Multi-Collateral Order Detail.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetMultiCollateralOrderDetailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MultiCollateralLoanApi(config);
            var orderId = "12345";  // string | Order ID returned on successful order creation.

            try
            {
                // Get Multi-Collateral Order Detail.
                MultiCollateralOrder result = apiInstance.GetMultiCollateralOrderDetail(orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.GetMultiCollateralOrderDetail: " + e.Message);
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
 **orderId** | **string**| Order ID returned on successful order creation. | 

### Return type

[**MultiCollateralOrder**](MultiCollateralOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmultirepayrecords"></a>
# **ListMultiRepayRecords**
> List&lt;MultiRepayRecord&gt; ListMultiRepayRecords (string type, string borrowCurrency = null, int? page = null, int? limit = null, long? from = null, long? to = null)

List Multi-Collateral Repay Records.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListMultiRepayRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MultiCollateralLoanApi(config);
            var type = "repay";  // string | Operation type: repay - Regular repayment, liquidate - Liquidation.
            var borrowCurrency = "USDT";  // string | Borrowed currency. (optional) 
            var page = 1;  // int? | Page number. (optional)  (default to 1)
            var limit = 10;  // int? | Maximum number of records to be returned in a single list. (optional)  (default to 10)
            var from = 1609459200;  // long? | Start timestamp of the query. (optional) 
            var to = 1609459200;  // long? | Time range ending, default to current time. (optional) 

            try
            {
                // List Multi-Collateral Repay Records.
                List<MultiRepayRecord> result = apiInstance.ListMultiRepayRecords(type, borrowCurrency, page, limit, from, to);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.ListMultiRepayRecords: " + e.Message);
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
 **type** | **string**| Operation type: repay - Regular repayment, liquidate - Liquidation. | 
 **borrowCurrency** | **string**| Borrowed currency. | [optional] 
 **page** | **int?**| Page number. | [optional] [default to 1]
 **limit** | **int?**| Maximum number of records to be returned in a single list. | [optional] [default to 10]
 **from** | **long?**| Start timestamp of the query. | [optional] 
 **to** | **long?**| Time range ending, default to current time. | [optional] 

### Return type

[**List&lt;MultiRepayRecord&gt;**](MultiRepayRecord.md)

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

<a name="repaymulticollateralloan"></a>
# **RepayMultiCollateralLoan**
> MultiRepayResp RepayMultiCollateralLoan (RepayMultiLoan repayMultiLoan)

Repay Multi-Collateral Loan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class RepayMultiCollateralLoanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MultiCollateralLoanApi(config);
            var repayMultiLoan = new RepayMultiLoan(); // RepayMultiLoan | 

            try
            {
                // Repay Multi-Collateral Loan.
                MultiRepayResp result = apiInstance.RepayMultiCollateralLoan(repayMultiLoan);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.RepayMultiCollateralLoan: " + e.Message);
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
 **repayMultiLoan** | [**RepayMultiLoan**](RepayMultiLoan.md)|  | 

### Return type

[**MultiRepayResp**](MultiRepayResp.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Operated successfully. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmulticollateralrecords"></a>
# **ListMultiCollateralRecords**
> List&lt;MultiCollateralRecord&gt; ListMultiCollateralRecords (int? page = null, int? limit = null, long? from = null, long? to = null, string collateralCurrency = null)

Query collateral adjustment records.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListMultiCollateralRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MultiCollateralLoanApi(config);
            var page = 1;  // int? | Page number. (optional)  (default to 1)
            var limit = 10;  // int? | Maximum number of records to be returned in a single list. (optional)  (default to 10)
            var from = 1609459200;  // long? | Start timestamp of the query. (optional) 
            var to = 1609459200;  // long? | Time range ending, default to current time. (optional) 
            var collateralCurrency = "BTC";  // string | Collateral. (optional) 

            try
            {
                // Query collateral adjustment records.
                List<MultiCollateralRecord> result = apiInstance.ListMultiCollateralRecords(page, limit, from, to, collateralCurrency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.ListMultiCollateralRecords: " + e.Message);
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
 **page** | **int?**| Page number. | [optional] [default to 1]
 **limit** | **int?**| Maximum number of records to be returned in a single list. | [optional] [default to 10]
 **from** | **long?**| Start timestamp of the query. | [optional] 
 **to** | **long?**| Time range ending, default to current time. | [optional] 
 **collateralCurrency** | **string**| Collateral. | [optional] 

### Return type

[**List&lt;MultiCollateralRecord&gt;**](MultiCollateralRecord.md)

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

<a name="operatemulticollateral"></a>
# **OperateMultiCollateral**
> CollateralAdjustRes OperateMultiCollateral (CollateralAdjust collateralAdjust)

Operate Multi-Collateral.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class OperateMultiCollateralExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MultiCollateralLoanApi(config);
            var collateralAdjust = new CollateralAdjust(); // CollateralAdjust | 

            try
            {
                // Operate Multi-Collateral.
                CollateralAdjustRes result = apiInstance.OperateMultiCollateral(collateralAdjust);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.OperateMultiCollateral: " + e.Message);
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
 **collateralAdjust** | [**CollateralAdjust**](CollateralAdjust.md)|  | 

### Return type

[**CollateralAdjustRes**](CollateralAdjustRes.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Operated successfully. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listusercurrencyquota"></a>
# **ListUserCurrencyQuota**
> List&lt;CurrencyQuota&gt; ListUserCurrencyQuota (string type, string currency)

List User Currency Quota.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListUserCurrencyQuotaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new MultiCollateralLoanApi(config);
            var type = "collateral";  // string | Currency type: collateral - Collateral currency, borrow - Borrowing.
            var currency = "BTC";  // string | When it is a collateral currency, multiple currencies can be passed separated by commas; when it is a borrowing currency, only one currency can be passedseparated by commas; when it is a borrowing currency, only one currency can be passedseparated by commas; when it is a borrowing currency, only one commas; when it is a borrowing currency, only one currency can be passed

            try
            {
                // List User Currency Quota.
                List<CurrencyQuota> result = apiInstance.ListUserCurrencyQuota(type, currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.ListUserCurrencyQuota: " + e.Message);
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
 **type** | **string**| Currency type: collateral - Collateral currency, borrow - Borrowing. | 
 **currency** | **string**| When it is a collateral currency, multiple currencies can be passed separated by commas; when it is a borrowing currency, only one currency can be passedseparated by commas; when it is a borrowing currency, only one currency can be passedseparated by commas; when it is a borrowing currency, only one commas; when it is a borrowing currency, only one currency can be passed | 

### Return type

[**List&lt;CurrencyQuota&gt;**](CurrencyQuota.md)

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

<a name="listmulticollateralcurrencies"></a>
# **ListMultiCollateralCurrencies**
> MultiCollateralCurrency ListMultiCollateralCurrencies ()

Query supported borrowing and collateral currencies in Multi-Collateral.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListMultiCollateralCurrenciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new MultiCollateralLoanApi(config);

            try
            {
                // Query supported borrowing and collateral currencies in Multi-Collateral.
                MultiCollateralCurrency result = apiInstance.ListMultiCollateralCurrencies();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.ListMultiCollateralCurrencies: " + e.Message);
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

[**MultiCollateralCurrency**](MultiCollateralCurrency.md)

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

<a name="getmulticollateralltv"></a>
# **GetMultiCollateralLtv**
> CollateralLtv GetMultiCollateralLtv ()

Get Multi-Collateral ratio.

The Multi-Collateral ratio is fixed, irrespective of the currency.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetMultiCollateralLtvExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new MultiCollateralLoanApi(config);

            try
            {
                // Get Multi-Collateral ratio.
                CollateralLtv result = apiInstance.GetMultiCollateralLtv();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.GetMultiCollateralLtv: " + e.Message);
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

[**CollateralLtv**](CollateralLtv.md)

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

<a name="getmulticollateralfixrate"></a>
# **GetMultiCollateralFixRate**
> List&lt;CollateralFixRate&gt; GetMultiCollateralFixRate ()

Query fixed interest rates for the currency for 7 days and 30 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetMultiCollateralFixRateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new MultiCollateralLoanApi(config);

            try
            {
                // Query fixed interest rates for the currency for 7 days and 30 days.
                List<CollateralFixRate> result = apiInstance.GetMultiCollateralFixRate();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.GetMultiCollateralFixRate: " + e.Message);
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

[**List&lt;CollateralFixRate&gt;**](CollateralFixRate.md)

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

<a name="getmulticollateralcurrentrate"></a>
# **GetMultiCollateralCurrentRate**
> List&lt;CollateralCurrentRate&gt; GetMultiCollateralCurrentRate (List<string> currencies, string vipLevel = null)

Query the current interest rate of the currency.

Query the current interest rate of the currency in the previous hour.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetMultiCollateralCurrentRateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new MultiCollateralLoanApi(config);
            var currencies = new List<string>(); // List<string> | Specify currency name query array, separated by commas, maximum 100items.
            var vipLevel = "\"0\"";  // string | VIP level, defaults to 0 if not transferred. (optional)  (default to "0")

            try
            {
                // Query the current interest rate of the currency.
                List<CollateralCurrentRate> result = apiInstance.GetMultiCollateralCurrentRate(currencies, vipLevel);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling MultiCollateralLoanApi.GetMultiCollateralCurrentRate: " + e.Message);
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
 **currencies** | [**List&lt;string&gt;**](string.md)| Specify currency name query array, separated by commas, maximum 100items. | 
 **vipLevel** | **string**| VIP level, defaults to 0 if not transferred. | [optional] [default to &quot;0&quot;]

### Return type

[**List&lt;CollateralCurrentRate&gt;**](CollateralCurrentRate.md)

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

