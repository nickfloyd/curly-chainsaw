# OpenapiClient::ActionsSetGithubActionsPermissionsOrganizationRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enabled_repositories** | **String** | The policy that controls the repositories in the organization that are allowed to run GitHub Actions. |  |
| **allowed_actions** | **String** | The permissions policy that controls the actions and reusable workflows that are allowed to run. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ActionsSetGithubActionsPermissionsOrganizationRequest.new(
  enabled_repositories: null,
  allowed_actions: null
)
```

