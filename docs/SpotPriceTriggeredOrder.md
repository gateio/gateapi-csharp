
# Io.Gate.GateApi.Model.SpotPriceTriggeredOrder

Spot order detail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Trigger** | [**SpotPriceTrigger**](SpotPriceTrigger.md) |  | 
**Put** | [**SpotPricePutOrder**](SpotPricePutOrder.md) |  | 
**Id** | **long** | Auto order ID | [optional] [readonly] 
**User** | **int** | User ID | [optional] [readonly] 
**Market** | **string** | Currency pair | 
**Ctime** | **long** | Creation time | [optional] [readonly] 
**Ftime** | **long** | Finished time | [optional] [readonly] 
**FiredOrderId** | **long** | ID of the newly created order on condition triggered | [optional] [readonly] 
**Status** | **string** | Status  - open: open - cancelled: being manually cancelled - finish: successfully executed - failed: failed to execute - expired - expired  | [optional] [readonly] 
**Reason** | **string** | Additional remarks on how the order was finished | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
