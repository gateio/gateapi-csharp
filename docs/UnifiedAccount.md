
# Io.Gate.GateApi.Model.UnifiedAccount

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **long** | User ID | [optional] 
**RefreshTime** | **long** | Time of the most recent refresh | [optional] 
**Locked** | **bool** | Whether account is locked | [optional] 
**Balances** | [**Dictionary&lt;string, UnifiedBalance&gt;**](UnifiedBalance.md) |  | [optional] 
**Total** | **string** | Total account assets converted to USD, i.e. the sum of &#x60;(available + freeze) * price&#x60;  in all currencies (deprecated, to be deprecated, replaced by unified_account_total) | [optional] 
**Borrowed** | **string** | The total borrowed amount in USD, calculated as the sum of the product of &#x60;borrowed * price&#x60; for all currencies (excluding points cards). | [optional] 
**TotalInitialMargin** | **string** | Total initial margin | [optional] 
**TotalMarginBalance** | **string** | Total margin balance | [optional] 
**TotalMaintenanceMargin** | **string** | Total maintenance margin | [optional] 
**TotalInitialMarginRate** | **string** | Total initial margin rate | [optional] 
**TotalMaintenanceMarginRate** | **string** | Total maintenance margin rate | [optional] 
**TotalAvailableMargin** | **string** | Total available margin | [optional] 
**UnifiedAccountTotal** | **string** | Total amount of the portfolio margin account | [optional] 
**UnifiedAccountTotalLiab** | **string** | Total liabilities of the portfolio margin account | [optional] 
**UnifiedAccountTotalEquity** | **string** | Total equity of the portfolio margin account | [optional] 
**Leverage** | **string** | Leverage | [optional] [readonly] 
**SpotOrderLoss** | **string** | Total order loss, in USDT | [optional] 
**SpotHedge** | **bool** | Spot hedging status, true - enabled, false - not enabled. | [optional] 
**UseFunding** | **bool** | Whether to use funds as margin | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
