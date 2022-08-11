# Org.OpenAPITools.Model.CodeScanningListAlertsForRepo200ResponseInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Number** | **int?** | The security alert number. | [readonly] 
**CreatedAt** | **DateTime?** | The time that the alert was created in ISO 8601 format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [readonly] 
**UpdatedAt** | **DateTime?** | The time that the alert was last updated in ISO 8601 format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] [readonly] 
**Url** | **string** | The REST API URL of the alert resource. | [readonly] 
**HtmlUrl** | **string** | The GitHub URL of the alert resource. | [readonly] 
**InstancesUrl** | **string** | The REST API URL for fetching the list of instances for an alert. | [readonly] 
**State** | **string** | State of a code scanning alert. | 
**FixedAt** | **DateTime?** | The time that the alert was no longer detected and was considered fixed in ISO 8601 format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] [readonly] 
**DismissedBy** | [**SimpleUser**](SimpleUser.md) |  | 
**DismissedAt** | **DateTime?** | The time that the alert was dismissed in ISO 8601 format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [readonly] 
**DismissedReason** | **string** | **Required when the state is dismissed.** The reason for dismissing or closing the alert. | 
**DismissedComment** | **string** | The dismissal comment associated with the dismissal of the alert. | [optional] 
**Rule** | [**CodeScanningListAlertsForRepo200ResponseInnerRule**](CodeScanningListAlertsForRepo200ResponseInnerRule.md) |  | 
**Tool** | [**CodeScanningListAlertsForEnterprise200ResponseInnerTool**](CodeScanningListAlertsForEnterprise200ResponseInnerTool.md) |  | 
**MostRecentInstance** | [**CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance**](CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

