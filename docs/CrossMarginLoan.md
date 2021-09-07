
# Io.Gate.GateApi.Model.CrossMarginLoan

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Borrow loan ID | [optional] [readonly] 
**CreateTime** | **long** | Creation timestamp, in milliseconds | [optional] [readonly] 
**UpdateTime** | **long** | Update timestamp, in milliseconds | [optional] [readonly] 
**Currency** | **string** | Currency name | 
**Amount** | **string** | Borrowed amount | 
**Text** | **string** | User defined custom ID | [optional] 
**Status** | **int** | Borrow loan status, which includes:  - 1: failed to borrow - 2: borrowed but not repaid - 3: repayment complete | [optional] [readonly] 
**Repaid** | **string** | Repaid amount | [optional] [readonly] 
**RepaidInterest** | **string** | Repaid interest | [optional] [readonly] 
**UnpaidInterest** | **string** | Outstanding interest yet to be paid | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
