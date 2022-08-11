# OpenapiClient::IssueEventForIssue

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
| **label** | [**LabeledIssueEventLabel**](LabeledIssueEventLabel.md) |  |  |
| **assignee** | [**SimpleUser1**](SimpleUser1.md) |  |  |
| **assigner** | [**SimpleUser1**](SimpleUser1.md) |  |  |
| **milestone** | [**MilestonedIssueEventMilestone**](MilestonedIssueEventMilestone.md) |  |  |
| **rename** | [**RenamedIssueEventRename**](RenamedIssueEventRename.md) |  |  |
| **review_requester** | [**SimpleUser1**](SimpleUser1.md) |  |  |
| **requested_team** | [**Team**](Team.md) |  | [optional] |
| **requested_reviewer** | [**SimpleUser1**](SimpleUser1.md) |  | [optional] |
| **dismissed_review** | [**ReviewDismissedIssueEventDismissedReview**](ReviewDismissedIssueEventDismissedReview.md) |  |  |
| **lock_reason** | **String** |  |  |
| **project_card** | [**AddedToProjectIssueEventProjectCard**](AddedToProjectIssueEventProjectCard.md) |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::IssueEventForIssue.new(
  id: null,
  node_id: null,
  url: null,
  actor: null,
  event: null,
  commit_id: null,
  commit_url: null,
  created_at: null,
  performed_via_github_app: null,
  label: null,
  assignee: null,
  assigner: null,
  milestone: null,
  rename: null,
  review_requester: null,
  requested_team: null,
  requested_reviewer: null,
  dismissed_review: null,
  lock_reason: &quot;off-topic&quot;,
  project_card: null
)
```

