
# Io.Gate.GateApi.Model.OrderBook

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | Order book ID, which is updated whenever the order book is changed. Valid only when &#x60;with_id&#x60; is set to &#x60;true&#x60; | [optional] 
**Current** | **long** | Response data generation timestamp in milliseconds | [optional] 
**Update** | **long** | Order book changed timestamp in milliseconds | [optional] 
**Asks** | **List&lt;List&lt;string&gt;&gt;** | Asks order depth | 
**Bids** | **List&lt;List&lt;string&gt;&gt;** | Bids order depth | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
