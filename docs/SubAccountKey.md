
# Io.Gate.GateApi.Model.SubAccountKey

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **string** | User ID | [optional] [readonly] 
**Mode** | **int** | Mode: 1 - classic 2 - portfolio account | [optional] 
**Name** | **string** | API key name | [optional] 
**Perms** | [**List&lt;SubAccountKeyPerms&gt;**](SubAccountKeyPerms.md) |  | [optional] 
**IpWhitelist** | **List&lt;string&gt;** | ip white list (list will be removed if no value is passed) | [optional] 
**Key** | **string** | API Key | [optional] [readonly] 
**State** | **int** | State 1 - normal 2 - locked 3 - frozen | [optional] [readonly] 
**CreatedAt** | **long** | Creation time | [optional] [readonly] 
**UpdatedAt** | **long** | Last update time | [optional] [readonly] 
**LastAccess** | **long** | Last access time | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
