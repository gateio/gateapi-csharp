
# Io.Gate.GateApi.Model.SpotPricePutOrder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Order type, default to &#x60;limit&#x60; | [optional] [default to "limit"]
**Side** | **string** | Order side  - buy: buy side - sell: sell side | 
**Price** | **string** | Order price | 
**Amount** | **string** | Order amount | 
**Account** | **string** | Trading type  - normal: spot trading - margin: margin trading | [default to AccountEnum.Normal]
**TimeInForce** | **string** | time_in_force  - gtc: GoodTillCancelled - ioc: ImmediateOrCancelled, taker only  | [optional] [default to TimeInForceEnum.Gtc]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
