
# Io.Gate.GateApi.Model.FuturesInitialOrder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Contract** | **string** | Futures contract | 
**Size** | **long** | Order size. Positive size means to buy, while negative one means to sell. Set to 0 to close the position | [optional] 
**Price** | **string** | Order price. Set to 0 to use market price | 
**Close** | **bool** | Set to true if trying to close the position | [optional] [default to false]
**Tif** | **string** | Time in force. If using market price, only &#x60;ioc&#x60; is supported.  - gtc: GoodTillCancelled - ioc: ImmediateOrCancelled | [optional] [default to TifEnum.Gtc]
**Text** | **string** | The source of the order, including: - web: web - api: api - app: app | [optional] 
**ReduceOnly** | **bool** | Set to true to create a reduce-only order | [optional] [default to false]
**AutoSize** | **string** | Set side to close dual-mode position. &#x60;close_long&#x60; closes the long side; while &#x60;close_short&#x60; the short one. Note &#x60;size&#x60; also needs to be set to 0 | [optional] 
**IsReduceOnly** | **bool** | Is the order reduce-only | [optional] [readonly] 
**IsClose** | **bool** | Is the order to close position | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
