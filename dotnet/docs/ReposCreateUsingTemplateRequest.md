# Org.OpenAPITools.Model.ReposCreateUsingTemplateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Owner** | **string** | The organization or person who will own the new repository. To create a new repository in an organization, the authenticated user must be a member of the specified organization. | [optional] 
**Name** | **string** | The name of the new repository. | 
**Description** | **string** | A short description of the new repository. | [optional] 
**IncludeAllBranches** | **bool?** | Set to &#x60;true&#x60; to include the directory structure and files from all branches in the template repository, and not just the default branch. Default: &#x60;false&#x60;. | [optional] [default to false]
**Private** | **bool?** | Either &#x60;true&#x60; to create a new private repository or &#x60;false&#x60; to create a new public one. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

