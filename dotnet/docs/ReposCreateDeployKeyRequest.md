# Org.OpenAPITools.Model.ReposCreateDeployKeyRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | A name for the key. | [optional] 
**Key** | **string** | The contents of the key. | 
**ReadOnly** | **bool?** | If &#x60;true&#x60;, the key will only be able to read repository contents. Otherwise, the key will be able to read and write.      Deploy keys with write access can perform the same actions as an organization member with admin access, or a collaborator on a personal repository. For more information, see \&quot;[Repository permission levels for an organization](https://docs.github.com/articles/repository-permission-levels-for-an-organization/)\&quot; and \&quot;[Permission levels for a user account repository](https://docs.github.com/articles/permission-levels-for-a-user-account-repository/).\&quot; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

