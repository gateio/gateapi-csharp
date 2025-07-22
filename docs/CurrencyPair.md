
# Io.Gate.GateApi.Model.CurrencyPair

Spot currency pair.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Currency pair. | [optional] 
**Base** | **string** | Base currency. | [optional] 
**BaseName** | **string** | Transaction currency name. | [optional] 
**Quote** | **string** | Quote currency. | [optional] 
**QuoteName** | **string** | Name of the denominated currency. | [optional] 
**Fee** | **string** | Trading fee. | [optional] 
**MinBaseAmount** | **string** | Minimum amount of base currency to trade, &#x60;null&#x60; means no limit. | [optional] 
**MinQuoteAmount** | **string** | Minimum amount of quote currency to trade, &#x60;null&#x60; means no limit. | [optional] 
**MaxBaseAmount** | **string** | Maximum amount of base currency to trade, &#x60;null&#x60; means no limit. | [optional] 
**MaxQuoteAmount** | **string** | Maximum amount of quote currency to trade, &#x60;null&#x60; means no limit. | [optional] 
**AmountPrecision** | **int** | Amount scale. | [optional] 
**Precision** | **int** | Price scale. | [optional] 
**TradeStatus** | **string** | How currency pair can be traded  - untradable: cannot be bought or sold - buyable: can be bought - sellable: can be sold - tradable: sold | [optional] 
**SellStart** | **long** | Sell start unix timestamp in seconds. | [optional] 
**BuyStart** | **long** | Buy start unix timestamp in seconds. | [optional] 
**DelistingTime** | **long** | Expected time to remove the shelves, Unix timestamp in seconds. | [optional] 
**Type** | **string** | Trading pair type, normal: normal, premarket: pre-market. | [optional] 
**TradeUrl** | **string** | Transaction link. | [optional] 
**StTag** | **bool** | Whether the trading pair is in ST risk assessment, false - No, true - Yes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
