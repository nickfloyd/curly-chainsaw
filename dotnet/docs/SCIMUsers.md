# Org.OpenAPITools.Model.SCIMUsers

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schemas** | **List<string>** | SCIM schema used. | 
**Id** | **string** | Unique identifier of an external identity | 
**ExternalId** | **string** | The ID of the User. | 
**UserName** | **string** | Configured by the admin. Could be an email, login, or username | 
**DisplayName** | **string** | The name of the user, suitable for display to end-users | [optional] 
**Name** | [**SCIMUsersName**](SCIMUsersName.md) |  | 
**Emails** | [**List<SCIMUsersEmailsInner>**](SCIMUsersEmailsInner.md) | user emails | 
**Active** | **bool?** | The active status of the User. | 
**Meta** | [**SCIMUsersMeta**](SCIMUsersMeta.md) |  | 
**OrganizationId** | **int?** | The ID of the organization. | [optional] 
**Operations** | [**List<SCIMUsersOperationsInner>**](SCIMUsersOperationsInner.md) | Set of operations to be performed | [optional] 
**Groups** | [**List<SCIMUsersGroupsInner>**](SCIMUsersGroupsInner.md) | associated groups | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

