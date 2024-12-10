
# Io.Gate.GateApi.Model.UidPushOrder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | Order ID | [optional] 
**PushUid** | **long** | Initiator User ID | [optional] 
**ReceiveUid** | **long** | Recipient User ID | [optional] 
**Currency** | **string** | Currency name | [optional] 
**Amount** | **string** | Transfer amount | [optional] 
**CreateTime** | **long** | Creation time | [optional] 
**Status** | **string** | Withdrawal Status  - CREATING: Creating - PENDING: Waiting for receiving(Please contact the other party to accept the transfer on the Gate official website) - CANCELLING: Cancelling - CANCELLED: Revoked - REFUSING: Rejection - REFUSED: Rejected - RECEIVING: Receiving - RECEIVED: Success | [optional] 
**Message** | **string** | PENDING Reason Tips | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
