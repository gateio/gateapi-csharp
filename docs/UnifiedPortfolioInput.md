
# Io.Gate.GateApi.Model.UnifiedPortfolioInput

Input for the portfolio margin calculator.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SpotBalances** | [**List&lt;MockSpotBalance&gt;**](MockSpotBalance.md) | Spot. | [optional] 
**SpotOrders** | [**List&lt;MockSpotOrder&gt;**](MockSpotOrder.md) | Spot orders. | [optional] 
**FuturesPositions** | [**List&lt;MockFuturesPosition&gt;**](MockFuturesPosition.md) | Futures positions. | [optional] 
**FuturesOrders** | [**List&lt;MockFuturesOrder&gt;**](MockFuturesOrder.md) | Futures order. | [optional] 
**OptionsPositions** | [**List&lt;MockOptionsPosition&gt;**](MockOptionsPosition.md) | Options positions. | [optional] 
**OptionsOrders** | [**List&lt;MockOptionsOrder&gt;**](MockOptionsOrder.md) | Option orders. | [optional] 
**SpotHedge** | **bool** | Whether to enable spot hedging. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
