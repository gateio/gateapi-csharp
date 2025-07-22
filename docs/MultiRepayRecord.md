
# Io.Gate.GateApi.Model.MultiRepayRecord

Mult Repay Record.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **long** | Order ID. | [optional] 
**RecordId** | **long** | Repayment record ID. | [optional] 
**InitLtv** | **string** | The initial collateralization rate. | [optional] 
**BeforeLtv** | **string** | Ltv before the operation. | [optional] 
**AfterLtv** | **string** | Ltv after the operation. | [optional] 
**BorrowTime** | **long** | Borrowing time, timestamp in seconds. | [optional] 
**RepayTime** | **long** | Repayment time, timestamp in seconds. | [optional] 
**BorrowCurrencies** | [**List&lt;RepayRecordCurrency&gt;**](RepayRecordCurrency.md) | List of borrowing information. | [optional] 
**CollateralCurrencies** | [**List&lt;RepayRecordCurrency&gt;**](RepayRecordCurrency.md) | List of collateral information. | [optional] 
**RepaidCurrencies** | [**List&lt;RepayRecordRepaidCurrency&gt;**](RepayRecordRepaidCurrency.md) | Repay Currency List. | [optional] 
**TotalInterestList** | [**List&lt;RepayRecordTotalInterest&gt;**](RepayRecordTotalInterest.md) | Total Interest List. | [optional] 
**LeftRepayInterestList** | [**List&lt;RepayRecordLeftInterest&gt;**](RepayRecordLeftInterest.md) | List of left repay interest. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
