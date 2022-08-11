# Org.OpenAPITools.Model.DeploymentStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** |  | 
**Id** | **int?** |  | 
**NodeId** | **string** |  | 
**State** | **string** | The state of the status. | 
**Creator** | [**SimpleUser**](SimpleUser.md) |  | 
**Description** | **string** | A short description of the status. | [default to ""]
**Environment** | **string** | The environment of the deployment that the status is for. | [optional] [default to ""]
**TargetUrl** | **string** | Deprecated: the URL to associate with this status. | [default to ""]
**CreatedAt** | **DateTime?** |  | 
**UpdatedAt** | **DateTime?** |  | 
**DeploymentUrl** | **string** |  | 
**RepositoryUrl** | **string** |  | 
**EnvironmentUrl** | **string** | The URL for accessing your environment. | [optional] [default to ""]
**LogUrl** | **string** | The URL to associate with this status. | [optional] [default to ""]
**PerformedViaGithubApp** | [**GitHubApp1**](GitHubApp1.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

