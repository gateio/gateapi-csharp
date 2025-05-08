
# Io.Gate.GateApi.Model.OptionsPosition

Options position information

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**User** | **int** | User ID | [optional] [readonly] 
**Underlying** | **string** | Underlying | [optional] [readonly] 
**UnderlyingPrice** | **string** | Underlying price (quote currency) | [optional] [readonly] 
**Contract** | **string** | Options contract name | [optional] [readonly] 
**Size** | **long** | Position size (contract size) | [optional] [readonly] 
**EntryPrice** | **string** | Entry size (quote currency) | [optional] [readonly] 
**MarkPrice** | **string** | Current mark price (quote currency) | [optional] [readonly] 
**MarkIv** | **string** | Implied volatility | [optional] [readonly] 
**RealisedPnl** | **string** | Realized PNL | [optional] [readonly] 
**UnrealisedPnl** | **string** | Unrealized PNL | [optional] [readonly] 
**PendingOrders** | **int** | Current open orders | [optional] [readonly] 
**CloseOrder** | [**OptionsPositionCloseOrder**](OptionsPositionCloseOrder.md) |  | [optional] 
**Delta** | **string** | Delta | [optional] [readonly] 
**Gamma** | **string** | Gamma | [optional] [readonly] 
**Vega** | **string** | Vega | [optional] [readonly] 
**Theta** | **string** | Theta | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
