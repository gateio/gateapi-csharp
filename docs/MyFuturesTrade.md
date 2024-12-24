
# Io.Gate.GateApi.Model.MyFuturesTrade

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | Trade ID | [optional] 
**CreateTime** | **double** | Trading time | [optional] 
**Contract** | **string** | Futures contract | [optional] 
**OrderId** | **string** | Order ID related | [optional] 
**Size** | **long** | Trading size | [optional] 
**CloseSize** | **long** | Number of closed positions:  close_size&#x3D;0 &amp;&amp; size＞0       Open long position close_size&#x3D;0 &amp;&amp; size＜0       Open short position close_size&gt;0 &amp;&amp; size&gt;0 &amp;&amp; size &lt;&#x3D; close_size Close short postion close_size&gt;0 &amp;&amp; size&gt;0 &amp;&amp; size &gt; close_size Close short position and open long position close_size&lt;0 &amp;&amp; size&lt;0 &amp;&amp; size &gt;&#x3D; close_size Close long postion close_size&lt;0 &amp;&amp; size&lt;0 &amp;&amp; size &lt; close_size Close long position and open short position | [optional] 
**Price** | **string** | Trading price | [optional] 
**Role** | **string** | Trade role. Available values are &#x60;taker&#x60; and &#x60;maker&#x60; | [optional] 
**Text** | **string** | User defined information | [optional] 
**Fee** | **string** | Fee deducted | [optional] 
**PointFee** | **string** | Points used to deduct fee | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)