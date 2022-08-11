# Org.OpenAPITools.Model.CodeScanningListRecentAnalyses200ResponseInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ref** | **string** | The full Git reference, formatted as &#x60;refs/heads/&lt;branch name&gt;&#x60;, &#x60;refs/pull/&lt;number&gt;/merge&#x60;, or &#x60;refs/pull/&lt;number&gt;/head&#x60;. | 
**CommitSha** | **string** | The SHA of the commit to which the analysis you are uploading relates. | 
**AnalysisKey** | **string** | Identifies the configuration under which the analysis was executed. For example, in GitHub Actions this includes the workflow filename and job name. | 
**Environment** | **string** | Identifies the variable values associated with the environment in which this analysis was performed. | 
**Category** | **string** | Identifies the configuration under which the analysis was executed. Used to distinguish between multiple analyses for the same tool and commit, but performed on different languages or different parts of the code. | [optional] 
**Error** | **string** |  | 
**CreatedAt** | **DateTime?** | The time that the analysis was created in ISO 8601 format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [readonly] 
**ResultsCount** | **int?** | The total number of results in the analysis. | 
**RulesCount** | **int?** | The total number of rules used in the analysis. | 
**Id** | **int?** | Unique identifier for this analysis. | 
**Url** | **string** | The REST API URL of the analysis resource. | [readonly] 
**SarifId** | **string** | An identifier for the upload. | 
**Tool** | [**CodeScanningListAlertsForEnterprise200ResponseInnerTool**](CodeScanningListAlertsForEnterprise200ResponseInnerTool.md) |  | 
**Deletable** | **bool?** |  | 
**Warning** | **string** | Warning generated when processing the analysis | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

