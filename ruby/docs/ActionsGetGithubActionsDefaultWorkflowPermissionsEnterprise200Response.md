# OpenapiClient::ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **default_workflow_permissions** | **String** | The default workflow permissions granted to the GITHUB_TOKEN when running workflows. |  |
| **can_approve_pull_request_reviews** | **Boolean** | Whether GitHub Actions can approve pull requests. Enabling this can be a security risk. |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response.new(
  default_workflow_permissions: null,
  can_approve_pull_request_reviews: null
)
```

