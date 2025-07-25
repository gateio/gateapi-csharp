
# Io.Gate.GateApi.Model.DeliveryContract

Futures contract details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Futures contract. | [optional] 
**Underlying** | **string** | Underlying. | [optional] 
**Cycle** | **string** | Cycle type, e.g. WEEKLY, QUARTERLY. | [optional] 
**Type** | **string** | Futures contract type. | [optional] 
**QuantoMultiplier** | **string** | Multiplier used in converting from invoicing to settlement currency. | [optional] 
**LeverageMin** | **string** | Minimum leverage. | [optional] 
**LeverageMax** | **string** | Maximum leverage. | [optional] 
**MaintenanceRate** | **string** | Maintenance rate of margin. | [optional] 
**MarkType** | **string** | Mark price type, internal - based on internal trading, external index price | [optional] 
**MarkPrice** | **string** | Current mark price. | [optional] 
**IndexPrice** | **string** | Current index price. | [optional] 
**LastPrice** | **string** | Last trading price. | [optional] 
**MakerFeeRate** | **string** | Maker fee rate, where negative means rebate. | [optional] 
**TakerFeeRate** | **string** | Taker fee rate. | [optional] 
**OrderPriceRound** | **string** | Minimum order price increment. | [optional] 
**MarkPriceRound** | **string** | Minimum mark price increment. | [optional] 
**BasisRate** | **string** | Fair basis rate. | [optional] 
**BasisValue** | **string** | Fair basis value. | [optional] 
**BasisImpactValue** | **string** | Funding used for calculating impact bid, ask price. | [optional] 
**SettlePrice** | **string** | Settle price. | [optional] 
**SettlePriceInterval** | **int** | Settle price update interval. | [optional] 
**SettlePriceDuration** | **int** | Settle price update duration in seconds. | [optional] 
**ExpireTime** | **long** | Contract expiry timestamp. | [optional] 
**RiskLimitBase** | **string** | Risk limit base. | [optional] 
**RiskLimitStep** | **string** | Step of adjusting risk limit. | [optional] 
**RiskLimitMax** | **string** | Maximum risk limit the contract allowed. | [optional] 
**OrderSizeMin** | **long** | Minimum order size the contract allowed. | [optional] 
**OrderSizeMax** | **long** | Maximum order size the contract allowed. | [optional] 
**OrderPriceDeviate** | **string** | deviation between order price and current index price. If price of an order is denoted as order_price, it must meet the following condition:   abs(order_price - mark_price) &lt;&#x3D; mark_price * order_price_deviate | [optional] 
**RefDiscountRate** | **string** | Referral fee rate discount. | [optional] 
**RefRebateRate** | **string** | Referrer commission rate. | [optional] 
**OrderbookId** | **long** | Current orderbook ID. | [optional] 
**TradeId** | **long** | Current trade ID. | [optional] 
**TradeSize** | **long** | Historical accumulated trade size. | [optional] 
**PositionSize** | **long** | Current total long position size. | [optional] 
**ConfigChangeTime** | **double** | Last changed time of configuration. | [optional] 
**InDelisting** | **bool** | Contract is delisting. | [optional] 
**OrdersLimit** | **int** | Maximum number of open orders. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
