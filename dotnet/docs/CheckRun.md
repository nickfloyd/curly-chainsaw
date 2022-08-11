# Org.OpenAPITools.Model.CheckRun

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | The id of the check. | 
**HeadSha** | **string** | The SHA of the commit that is being checked. | 
**NodeId** | **string** |  | 
**ExternalId** | **string** |  | 
**Url** | **string** |  | 
**HtmlUrl** | **string** |  | 
**DetailsUrl** | **string** |  | 
**Status** | **string** | The phase of the lifecycle that the check is currently in. | 
**Conclusion** | **string** |  | 
**StartedAt** | **DateTime?** |  | 
**CompletedAt** | **DateTime?** |  | 
**Output** | [**CheckRunOutput**](CheckRunOutput.md) |  | 
**Name** | **string** | The name of the check. | 
**CheckSuite** | [**CheckRunCheckSuite**](CheckRunCheckSuite.md) |  | 
**App** | [**GitHubApp1**](GitHubApp1.md) |  | 
**PullRequests** | [**List<PullRequestMinimal>**](PullRequestMinimal.md) |  | 
**Deployment** | [**Deployment1**](Deployment1.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

