# Org.OpenAPITools.Model.CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ref** | **string** | The full Git reference, formatted as &#x60;refs/heads/&lt;branch name&gt;&#x60;, &#x60;refs/pull/&lt;number&gt;/merge&#x60;, or &#x60;refs/pull/&lt;number&gt;/head&#x60;. | [optional] 
**AnalysisKey** | **string** | Identifies the configuration under which the analysis was executed. For example, in GitHub Actions this includes the workflow filename and job name. | [optional] 
**Environment** | **string** | Identifies the variable values associated with the environment in which the analysis that generated this alert instance was performed, such as the language that was analyzed. | [optional] 
**Category** | **string** | Identifies the configuration under which the analysis was executed. Used to distinguish between multiple analyses for the same tool and commit, but performed on different languages or different parts of the code. | [optional] 
**State** | **string** | State of a code scanning alert. | [optional] 
**CommitSha** | **string** |  | [optional] 
**Message** | [**CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstanceMessage**](CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstanceMessage.md) |  | [optional] 
**Location** | [**CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstanceLocation**](CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstanceLocation.md) |  | [optional] 
**HtmlUrl** | **string** |  | [optional] 
**Classifications** | **List<string>** | Classifications that have been applied to the file that triggered the alert. For example identifying it as documentation, or a generated file. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

