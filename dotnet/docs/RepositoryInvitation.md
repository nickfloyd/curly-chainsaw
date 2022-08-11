# Org.OpenAPITools.Model.RepositoryInvitation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Unique identifier of the repository invitation. | 
**Repository** | [**MinimalRepository**](MinimalRepository.md) |  | 
**Invitee** | [**SimpleUser**](SimpleUser.md) |  | 
**Inviter** | [**SimpleUser**](SimpleUser.md) |  | 
**Permissions** | **string** | The permission associated with the invitation. | 
**CreatedAt** | **DateTime?** |  | 
**Expired** | **bool?** | Whether or not the invitation has expired | [optional] 
**Url** | **string** | URL for the repository invitation | 
**HtmlUrl** | **string** |  | 
**NodeId** | **string** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

