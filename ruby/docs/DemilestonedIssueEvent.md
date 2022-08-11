# OpenapiClient::DemilestonedIssueEvent

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
| **performed_via_github_app** | [**GitHubApp1**](GitHubApp1.md) |  |  |
| **milestone** | [**MilestonedIssueEventMilestone**](MilestonedIssueEventMilestone.md) |  |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::DemilestonedIssueEvent.new(
  id: null,
  node_id: null,
  url: null,
  actor: null,
  event: null,
  commit_id: null,
  commit_url: null,
  created_at: null,
  performed_via_github_app: null,
  milestone: null
)
```

