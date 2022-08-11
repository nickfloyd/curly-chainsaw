# Org.OpenAPITools.Model.TeamsUpdateLegacyRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the team. | 
**Description** | **string** | The description of the team. | [optional] 
**Privacy** | **string** | The level of privacy this team should have. Editing teams without specifying this parameter leaves &#x60;privacy&#x60; intact. The options are:   **For a non-nested team:**   \\* &#x60;secret&#x60; - only visible to organization owners and members of this team.   \\* &#x60;closed&#x60; - visible to all members of this organization.   **For a parent or child team:**   \\* &#x60;closed&#x60; - visible to all members of this organization. | [optional] 
**Permission** | **string** | **Deprecated**. The permission that new repositories will be added to the team with when none is specified. | [optional] [default to PermissionEnum.PullEnum]
**ParentTeamId** | **int?** | The ID of a team to set as the parent team. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

