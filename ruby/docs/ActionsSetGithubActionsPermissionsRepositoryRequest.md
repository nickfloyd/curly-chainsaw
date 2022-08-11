# OpenapiClient::ActionsSetGithubActionsPermissionsRepositoryRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enabled** | **Boolean** | Whether GitHub Actions is enabled on the repository. |  |
| **allowed_actions** | **String** | The permissions policy that controls the actions and reusable workflows that are allowed to run. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ActionsSetGithubActionsPermissionsRepositoryRequest.new(
  enabled: null,
  allowed_actions: null
)
```

