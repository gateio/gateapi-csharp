
# Io.Gate.GateApi.Model.Transfer

Accounts available to transfer:  - &#x60;spot&#x60;: spot account - &#x60;margin&#x60;: margin account - &#x60;futures&#x60;: perpetual futures account - &#x60;delivery&#x60;: delivery futures account - &#x60;cross_margin&#x60;: cross margin account - &#x60;options&#x60;: options account

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Currency** | **string** | Transfer currency. For futures account, &#x60;currency&#x60; can be set to &#x60;POINT&#x60; or settle currency | 
**From** | **string** | Account to transfer from | 
**To** | **string** | Account to transfer to | 
**Amount** | **string** | Transfer amount | 
**CurrencyPair** | **string** | Margin currency pair. Required if transfer from or to margin account | [optional] 
**Settle** | **string** | Futures settle currency. Required if transferring from or to futures account | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
