
# Io.Gate.GateApi.Model.OptionsMMPReset

MMP Reset

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Underlying** | **string** | Underlying | 
**Window** | **int** | 时间窗口（毫秒），1-5000之间，0表示停用MMP | [optional] [readonly] 
**FrozenPeriod** | **int** | 冻结时长（毫秒），0表示一直冻结，需要调用重置API解冻 | [optional] [readonly] 
**QtyLimit** | **string** | 成交量上限（正数，至多2位小数） | [optional] [readonly] 
**DeltaLimit** | **string** | 净delta值上限（正数，至多2位小数） | [optional] [readonly] 
**TriggerTimeMs** | **long** | 触发冻结时间（毫秒），0表示没有触发冻结 | [optional] [readonly] 
**FrozenUntilMs** | **long** | 解冻时间（毫秒），如果未配置冻结时长，触发冻结后无解冻时间 | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
