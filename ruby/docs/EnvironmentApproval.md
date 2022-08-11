# OpenapiClient::EnvironmentApproval

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **environments** | [**Array&lt;EnvironmentApprovalEnvironmentsInner&gt;**](EnvironmentApprovalEnvironmentsInner.md) | The list of environments that were approved or rejected |  |
| **state** | **String** | Whether deployment to the environment(s) was approved or rejected |  |
| **user** | [**SimpleUser1**](SimpleUser1.md) |  |  |
| **comment** | **String** | The comment submitted with the deployment review |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::EnvironmentApproval.new(
  environments: null,
  state: approved,
  user: null,
  comment: Ship it!
)
```

