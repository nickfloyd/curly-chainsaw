# OpenapiClient::ProtectedBranchRequiredPullRequestReviewsBypassPullRequestAllowances

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **users** | [**Array&lt;SimpleUser1&gt;**](SimpleUser1.md) |  |  |
| **teams** | [**Array&lt;Team&gt;**](Team.md) |  |  |
| **apps** | [**Array&lt;GitHubApp&gt;**](GitHubApp.md) |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ProtectedBranchRequiredPullRequestReviewsBypassPullRequestAllowances.new(
  users: null,
  teams: null,
  apps: null
)
```

