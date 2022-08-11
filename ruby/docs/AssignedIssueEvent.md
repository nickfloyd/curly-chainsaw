# OpenapiClient::AssignedIssueEvent

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **id** | **Integer** |  |  |
| **node_id** | **String** |  |  |
| **url** | **String** |  |  |
| **actor** | [**SimpleUser1**](SimpleUser1.md) |  |  |
| **event** | **String** |  |  |
| **commit_id** | **String** |  |  |
| **commit_url** | **String** |  |  |
| **created_at** | **String** |  |  |
| **performed_via_github_app** | [**GitHubApp**](GitHubApp.md) |  |  |
| **assignee** | [**SimpleUser1**](SimpleUser1.md) |  |  |
| **assigner** | [**SimpleUser1**](SimpleUser1.md) |  |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::AssignedIssueEvent.new(
  id: null,
  node_id: null,
  url: null,
  actor: null,
  event: null,
  commit_id: null,
  commit_url: null,
  created_at: null,
  performed_via_github_app: null,
  assignee: null,
  assigner: null
)
```

