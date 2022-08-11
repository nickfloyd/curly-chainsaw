# OpenapiClient::EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enabled_organizations** | **String** | The policy that controls the organizations in the enterprise that are allowed to run GitHub Actions. |  |
| **allowed_actions** | **String** | The permissions policy that controls the actions and reusable workflows that are allowed to run. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest.new(
  enabled_organizations: null,
  allowed_actions: null
)
```

