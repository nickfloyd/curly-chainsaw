# Org.OpenAPITools.Model.CheckSuite

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | 
**NodeId** | **string** |  | 
**HeadBranch** | **string** |  | 
**HeadSha** | **string** | The SHA of the head commit that is being checked. | 
**Status** | **string** |  | 
**Conclusion** | **string** |  | 
**Url** | **string** |  | 
**Before** | **string** |  | 
**After** | **string** |  | 
**PullRequests** | [**List<PullRequestMinimal>**](PullRequestMinimal.md) |  | 
**App** | [**GitHubApp1**](GitHubApp1.md) |  | 
**Repository** | [**MinimalRepository**](MinimalRepository.md) |  | 
**CreatedAt** | **DateTime?** |  | 
**UpdatedAt** | **DateTime?** |  | 
**HeadCommit** | [**SimpleCommit1**](SimpleCommit1.md) |  | 
**LatestCheckRunsCount** | **int?** |  | 
**CheckRunsUrl** | **string** |  | 
**Rerequestable** | **bool?** |  | [optional] 
**RunsRerequestable** | **bool?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

