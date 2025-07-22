
# Io.Gate.GateApi.Model.UnifiedCollateralReq

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CollateralType** | **int** | User-set collateral mode0(all)-All currencies used as collateral, collateral; when collateral_type is 0(all), the enable_list and disable_list parameters are invalid | [optional] 
**EnableList** | **List&lt;string&gt;** | Currency list, where collateral_type&#x3D;1(custom) indicates the logic of addition | [optional] 
**DisableList** | **List&lt;string&gt;** | Cancellation list, indicating the logic of cancellation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
