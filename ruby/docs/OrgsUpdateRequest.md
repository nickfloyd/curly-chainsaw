# OpenapiClient::OrgsUpdateRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **billing_email** | **String** | Billing email address. This address is not publicized. | [optional] |
| **company** | **String** | The company name. | [optional] |
| **email** | **String** | The publicly visible email address. | [optional] |
| **twitter_username** | **String** | The Twitter username of the company. | [optional] |
| **location** | **String** | The location. | [optional] |
| **name** | **String** | The shorthand name of the company. | [optional] |
| **description** | **String** | The description of the company. | [optional] |
| **has_organization_projects** | **Boolean** | Whether an organization can use organization projects. | [optional] |
| **has_repository_projects** | **Boolean** | Whether repositories that belong to the organization can use repository projects. | [optional] |
| **default_repository_permission** | **String** | Default permission level members have for organization repositories. | [optional][default to &#39;read&#39;] |
| **members_can_create_repositories** | **Boolean** | Whether of non-admin organization members can create repositories. **Note:** A parameter can override this parameter. See &#x60;members_allowed_repository_creation_type&#x60; in this table for details. | [optional][default to true] |
| **members_can_create_internal_repositories** | **Boolean** | Whether organization members can create internal repositories, which are visible to all enterprise members. You can only allow members to create internal repositories if your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+. For more information, see \&quot;[Restricting repository creation in your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)\&quot; in the GitHub Help documentation. | [optional] |
| **members_can_create_private_repositories** | **Boolean** | Whether organization members can create private repositories, which are visible to organization members with permission. For more information, see \&quot;[Restricting repository creation in your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)\&quot; in the GitHub Help documentation. | [optional] |
| **members_can_create_public_repositories** | **Boolean** | Whether organization members can create public repositories, which are visible to anyone. For more information, see \&quot;[Restricting repository creation in your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)\&quot; in the GitHub Help documentation. | [optional] |
| **members_allowed_repository_creation_type** | **String** | Specifies which types of repositories non-admin organization members can create. &#x60;private&#x60; is only available to repositories that are part of an organization on GitHub Enterprise Cloud.  **Note:** This parameter is deprecated and will be removed in the future. Its return value ignores internal repositories. Using this parameter overrides values set in &#x60;members_can_create_repositories&#x60;. See the parameter deprecation notice in the operation description for details. | [optional] |
| **members_can_create_pages** | **Boolean** | Whether organization members can create GitHub Pages sites. Existing published sites will not be impacted. | [optional][default to true] |
| **members_can_create_public_pages** | **Boolean** | Whether organization members can create public GitHub Pages sites. Existing published sites will not be impacted. | [optional][default to true] |
| **members_can_create_private_pages** | **Boolean** | Whether organization members can create private GitHub Pages sites. Existing published sites will not be impacted. | [optional][default to true] |
| **members_can_fork_private_repositories** | **Boolean** | Whether organization members can fork private organization repositories. | [optional][default to false] |
| **blog** | **String** |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::OrgsUpdateRequest.new(
  billing_email: null,
  company: null,
  email: null,
  twitter_username: null,
  location: null,
  name: null,
  description: null,
  has_organization_projects: null,
  has_repository_projects: null,
  default_repository_permission: null,
  members_can_create_repositories: null,
  members_can_create_internal_repositories: null,
  members_can_create_private_repositories: null,
  members_can_create_public_repositories: null,
  members_allowed_repository_creation_type: null,
  members_can_create_pages: null,
  members_can_create_public_pages: null,
  members_can_create_private_pages: null,
  members_can_fork_private_repositories: null,
  blog: &quot;http://github.blog&quot;
)
```

