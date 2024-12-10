
# Io.Gate.GateApi.Model.BatchAmendOrderReq

Modify contract order parameters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **long** | Order id, order_id and text must contain at least one | [optional] 
**Text** | **string** | User-defined order text, at least one of order_id and text must be passed | [optional] 
**Size** | **long** | The new order size, including the executed order size. - If it is less than or equal to the executed quantity, the order will be cancelled. - The new order direction must be consistent with the original one. - The size of the closing order cannot be modified. - For orders that only reduce positions, if the size is increased, other orders that only reduce positions may be kicked out. - If the price is not modified, reducing the size will not affect the depth of the queue, and increasing the size will place it at the end of the current price. | [optional] 
**Price** | **string** | New order price. | [optional] 
**AmendText** | **string** | Custom info during amending order | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
