# Org.OpenAPITools.Model.Installation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | The ID of the installation. | 
**Account** | [**InstallationAccount**](InstallationAccount.md) |  | 
**RepositorySelection** | **string** | Describe whether all repositories have been selected or there&#39;s a selection involved | 
**AccessTokensUrl** | **string** |  | 
**RepositoriesUrl** | **string** |  | 
**HtmlUrl** | **string** |  | 
**AppId** | **int?** |  | 
**TargetId** | **int?** | The ID of the user or organization this token is being scoped to. | 
**TargetType** | **string** |  | 
**Permissions** | [**AppPermissions**](AppPermissions.md) |  | 
**Events** | **List<string>** |  | 
**CreatedAt** | **DateTime?** |  | 
**UpdatedAt** | **DateTime?** |  | 
**SingleFileName** | **string** |  | 
**HasMultipleSingleFiles** | **bool?** |  | [optional] 
**SingleFilePaths** | **List<string>** |  | [optional] 
**AppSlug** | **string** |  | 
**SuspendedBy** | [**SimpleUser**](SimpleUser.md) |  | 
**SuspendedAt** | **DateTime?** |  | 
**ContactEmail** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

