# OpenapiClient::EnterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **name** | **String** | Name of the runner group. |  |
| **visibility** | **String** | Visibility of a runner group. You can select all organizations or select individual organization. | [optional] |
| **selected_organization_ids** | **Array&lt;Integer&gt;** | List of organization IDs that can access the runner group. | [optional] |
| **runners** | **Array&lt;Integer&gt;** | List of runner IDs to add to the runner group. | [optional] |
| **allows_public_repositories** | **Boolean** | Whether the runner group can be used by &#x60;public&#x60; repositories. | [optional][default to false] |
| **restricted_to_workflows** | **Boolean** | If &#x60;true&#x60;, the runner group will be restricted to running only the workflows specified in the &#x60;selected_workflows&#x60; array. | [optional][default to false] |
| **selected_workflows** | **Array&lt;String&gt;** | List of workflows the runner group should be allowed to run. This setting will be ignored unless &#x60;restricted_to_workflows&#x60; is set to &#x60;true&#x60;. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::EnterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest.new(
  name: null,
  visibility: null,
  selected_organization_ids: null,
  runners: null,
  allows_public_repositories: null,
  restricted_to_workflows: null,
  selected_workflows: null
)
```

