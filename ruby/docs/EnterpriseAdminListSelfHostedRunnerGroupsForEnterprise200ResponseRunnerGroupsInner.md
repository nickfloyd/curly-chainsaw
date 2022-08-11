# OpenapiClient::EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **id** | **Float** |  |  |
| **name** | **String** |  |  |
| **visibility** | **String** |  |  |
| **default** | **Boolean** |  |  |
| **selected_organizations_url** | **String** |  | [optional] |
| **runners_url** | **String** |  |  |
| **allows_public_repositories** | **Boolean** |  |  |
| **workflow_restrictions_read_only** | **Boolean** | If &#x60;true&#x60;, the &#x60;restricted_to_workflows&#x60; and &#x60;selected_workflows&#x60; fields cannot be modified. | [optional][default to false] |
| **restricted_to_workflows** | **Boolean** | If &#x60;true&#x60;, the runner group will be restricted to running only the workflows specified in the &#x60;selected_workflows&#x60; array. | [optional][default to false] |
| **selected_workflows** | **Array&lt;String&gt;** | List of workflows the runner group should be allowed to run. This setting will be ignored unless &#x60;restricted_to_workflows&#x60; is set to &#x60;true&#x60;. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner.new(
  id: null,
  name: null,
  visibility: null,
  default: null,
  selected_organizations_url: null,
  runners_url: null,
  allows_public_repositories: null,
  workflow_restrictions_read_only: null,
  restricted_to_workflows: null,
  selected_workflows: null
)
```

