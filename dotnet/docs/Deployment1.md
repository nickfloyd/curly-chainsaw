# Org.OpenAPITools.Model.Deployment1

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** |  | 
**Id** | **int?** | Unique identifier of the deployment | 
**NodeId** | **string** |  | 
**Task** | **string** | Parameter to specify a task to execute | 
**OriginalEnvironment** | **string** |  | [optional] 
**Environment** | **string** | Name for the target deployment environment. | 
**Description** | **string** |  | 
**CreatedAt** | **DateTime?** |  | 
**UpdatedAt** | **DateTime?** |  | 
**StatusesUrl** | **string** |  | 
**RepositoryUrl** | **string** |  | 
**TransientEnvironment** | **bool?** | Specifies if the given environment is will no longer exist at some point in the future. Default: false. | [optional] 
**ProductionEnvironment** | **bool?** | Specifies if the given environment is one that end-users directly interact with. Default: false. | [optional] 
**PerformedViaGithubApp** | [**GitHubApp1**](GitHubApp1.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

