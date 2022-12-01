
# Io.Gate.GateApi.Model.SubAccountKey

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **string** | User ID | [optional] [readonly] 
**Name** | **string** | API key name | [optional] 
**Perms** | [**List&lt;ApiV4KeyPerm&gt;**](ApiV4KeyPerm.md) |  | [optional] 
**IpWhitelist** | **List&lt;string&gt;** | ip white list (list will be removed if no value is passed) | [optional] 
**Key** | **string** | API Key | [optional] [readonly] 
**State** | **int** | State 1 - normal 2 - locked 3 - frozen | [optional] [readonly] 
**CreatedAt** | **string** | Creation time | [optional] [readonly] 
**UpdatedAt** | **string** | Last update time | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
