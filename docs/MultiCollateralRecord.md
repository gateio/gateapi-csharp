
# Io.Gate.GateApi.Model.MultiCollateralRecord

Multi-Collateral adjustment record.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **long** | Order ID | [optional] 
**RecordId** | **long** | Collateral record ID | [optional] 
**BeforeLtv** | **string** | The collateral ratio before adjustment | [optional] 
**AfterLtv** | **string** | The collateral ratio before adjustment | [optional] 
**OperateTime** | **long** | Operation time, timestamp in seconds. | [optional] 
**BorrowCurrencies** | [**List&lt;MultiCollateralRecordCurrency&gt;**](MultiCollateralRecordCurrency.md) | Borrowing Currency List | [optional] 
**CollateralCurrencies** | [**List&lt;MultiCollateralRecordCurrency&gt;**](MultiCollateralRecordCurrency.md) | Collateral Currency List | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
