
# Io.Gate.GateApi.Model.SubAccountTransferRecordItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timest** | **string** | Transfer timestamp. | [optional] [readonly] 
**Uid** | **string** | Main account user ID. | [optional] [readonly] 
**SubAccount** | **string** | Sub account user ID. | 
**SubAccountType** | **string** | Target sub user&#39;s account. &#x60;spot&#x60; - spot account, &#x60;futures&#x60; - perpetual contract account, &#x60;delivery&#x60; - delivery account | [optional] [default to "spot"]
**Currency** | **string** | Transfer currency name. | 
**Amount** | **string** | Transfer amount. | 
**Direction** | **string** | Transfer direction. to - transfer into sub account; from - transfer out from sub account | 
**Source** | **string** | Where the operation is initiated from. | [optional] [readonly] 
**ClientOrderId** | **string** | The custom ID provided by the customer serves as a safeguard against duplicate transfers. It can be a combination of letters (case-sensitive), numbers, hyphens &#39;-&#39;, and underscores &#39;_&#39;, with a length ranging from 1 to 64 characters. | [optional] 
**Status** | **string** | Sub-account transfer record status, currently only success. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
