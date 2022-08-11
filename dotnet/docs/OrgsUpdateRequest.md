# Org.OpenAPITools.Model.OrgsUpdateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BillingEmail** | **string** | Billing email address. This address is not publicized. | [optional] 
**Company** | **string** | The company name. | [optional] 
**Email** | **string** | The publicly visible email address. | [optional] 
**TwitterUsername** | **string** | The Twitter username of the company. | [optional] 
**Location** | **string** | The location. | [optional] 
**Name** | **string** | The shorthand name of the company. | [optional] 
**Description** | **string** | The description of the company. | [optional] 
**HasOrganizationProjects** | **bool?** | Whether an organization can use organization projects. | [optional] 
**HasRepositoryProjects** | **bool?** | Whether repositories that belong to the organization can use repository projects. | [optional] 
**DefaultRepositoryPermission** | **string** | Default permission level members have for organization repositories. | [optional] [default to DefaultRepositoryPermissionEnum.ReadEnum]
**MembersCanCreateRepositories** | **bool?** | Whether of non-admin organization members can create repositories. **Note:** A parameter can override this parameter. See &#x60;members_allowed_repository_creation_type&#x60; in this table for details. | [optional] [default to true]
**MembersCanCreateInternalRepositories** | **bool?** | Whether organization members can create internal repositories, which are visible to all enterprise members. You can only allow members to create internal repositories if your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+. For more information, see \&quot;[Restricting repository creation in your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)\&quot; in the GitHub Help documentation. | [optional] 
**MembersCanCreatePrivateRepositories** | **bool?** | Whether organization members can create private repositories, which are visible to organization members with permission. For more information, see \&quot;[Restricting repository creation in your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)\&quot; in the GitHub Help documentation. | [optional] 
**MembersCanCreatePublicRepositories** | **bool?** | Whether organization members can create public repositories, which are visible to anyone. For more information, see \&quot;[Restricting repository creation in your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)\&quot; in the GitHub Help documentation. | [optional] 
**MembersAllowedRepositoryCreationType** | **string** | Specifies which types of repositories non-admin organization members can create. &#x60;private&#x60; is only available to repositories that are part of an organization on GitHub Enterprise Cloud.  **Note:** This parameter is deprecated and will be removed in the future. Its return value ignores internal repositories. Using this parameter overrides values set in &#x60;members_can_create_repositories&#x60;. See the parameter deprecation notice in the operation description for details. | [optional] 
**MembersCanCreatePages** | **bool?** | Whether organization members can create GitHub Pages sites. Existing published sites will not be impacted. | [optional] [default to true]
**MembersCanCreatePublicPages** | **bool?** | Whether organization members can create public GitHub Pages sites. Existing published sites will not be impacted. | [optional] [default to true]
**MembersCanCreatePrivatePages** | **bool?** | Whether organization members can create private GitHub Pages sites. Existing published sites will not be impacted. | [optional] [default to true]
**MembersCanForkPrivateRepositories** | **bool?** | Whether organization members can fork private organization repositories. | [optional] [default to false]
**Blog** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

