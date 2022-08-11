# Org.OpenAPITools.Model.TeamsCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the team. | 
**Description** | **string** | The description of the team. | [optional] 
**Maintainers** | **List<string>** | List GitHub IDs for organization members who will become team maintainers. | [optional] 
**RepoNames** | **List<string>** | The full name (e.g., \&quot;organization-name/repository-name\&quot;) of repositories to add the team to. | [optional] 
**Privacy** | **string** | The level of privacy this team should have. The options are:   **For a non-nested team:**   \\* &#x60;secret&#x60; - only visible to organization owners and members of this team.   \\* &#x60;closed&#x60; - visible to all members of this organization.   Default: &#x60;secret&#x60;   **For a parent or child team:**   \\* &#x60;closed&#x60; - visible to all members of this organization.   Default for child team: &#x60;closed&#x60; | [optional] 
**Permission** | **string** | **Deprecated**. The permission that new repositories will be added to the team with when none is specified. | [optional] [default to PermissionEnum.PullEnum]
**ParentTeamId** | **int?** | The ID of a team to set as the parent team. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

