# Org.OpenAPITools.Model.AppsScopeTokenRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessToken** | **string** | The OAuth access token used to authenticate to the GitHub API. | 
**Target** | **string** | The name of the user or organization to scope the user-to-server access token to. **Required** unless &#x60;target_id&#x60; is specified. | [optional] 
**TargetId** | **int?** | The ID of the user or organization to scope the user-to-server access token to. **Required** unless &#x60;target&#x60; is specified. | [optional] 
**Repositories** | **List<string>** | The list of repository names to scope the user-to-server access token to. &#x60;repositories&#x60; may not be specified if &#x60;repository_ids&#x60; is specified. | [optional] 
**RepositoryIds** | **List<int?>** | The list of repository IDs to scope the user-to-server access token to. &#x60;repository_ids&#x60; may not be specified if &#x60;repositories&#x60; is specified. | [optional] 
**Permissions** | [**AppPermissions**](AppPermissions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

