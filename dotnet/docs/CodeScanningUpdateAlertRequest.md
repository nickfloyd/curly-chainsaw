# Org.OpenAPITools.Model.CodeScanningUpdateAlertRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **string** | Sets the state of the code scanning alert. You must provide &#x60;dismissed_reason&#x60; when you set the state to &#x60;dismissed&#x60;. | 
**DismissedReason** | **string** | **Required when the state is dismissed.** The reason for dismissing or closing the alert. | [optional] 
**DismissedComment** | **string** | The dismissal comment associated with the dismissal of the alert. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

