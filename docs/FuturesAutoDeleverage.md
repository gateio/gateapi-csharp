
# Io.Gate.GateApi.Model.FuturesAutoDeleverage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Time** | **long** | Automatic deleveraging time | [optional] [readonly] 
**User** | **long** | User ID | [optional] [readonly] 
**OrderId** | **long** | Order ID. Order IDs before 2023-02-20 are null | [optional] [readonly] 
**Contract** | **string** | Futures contract | [optional] [readonly] 
**Leverage** | **string** | Position leverage | [optional] [readonly] 
**CrossLeverageLimit** | **string** | Cross margin leverage(valid only when &#x60;leverage&#x60; is 0) | [optional] [readonly] 
**EntryPrice** | **string** | Average entry price | [optional] [readonly] 
**FillPrice** | **string** | Average fill price | [optional] [readonly] 
**TradeSize** | **long** | Trading size | [optional] [readonly] 
**PositionSize** | **long** | Positions after auto-deleveraging | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
