# OpenapiClient::PullRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **url** | **String** |  |  |
| **id** | **Integer** |  |  |
| **node_id** | **String** |  |  |
| **html_url** | **String** |  |  |
| **diff_url** | **String** |  |  |
| **patch_url** | **String** |  |  |
| **issue_url** | **String** |  |  |
| **commits_url** | **String** |  |  |
| **review_comments_url** | **String** |  |  |
| **review_comment_url** | **String** |  |  |
| **comments_url** | **String** |  |  |
| **statuses_url** | **String** |  |  |
| **number** | **Integer** | Number uniquely identifying the pull request within its repository. |  |
| **state** | **String** | State of this Pull Request. Either &#x60;open&#x60; or &#x60;closed&#x60;. |  |
| **locked** | **Boolean** |  |  |
| **title** | **String** | The title of the pull request. |  |
| **user** | [**SimpleUser**](SimpleUser.md) |  |  |
| **body** | **String** |  |  |
| **labels** | [**Array&lt;PullRequestLabelsInner&gt;**](PullRequestLabelsInner.md) |  |  |
| **milestone** | [**Milestone**](Milestone.md) |  |  |
| **active_lock_reason** | **String** |  | [optional] |
| **created_at** | **Time** |  |  |
| **updated_at** | **Time** |  |  |
| **closed_at** | **Time** |  |  |
| **merged_at** | **Time** |  |  |
| **merge_commit_sha** | **String** |  |  |
| **assignee** | [**SimpleUser**](SimpleUser.md) |  |  |
| **assignees** | [**Array&lt;SimpleUser1&gt;**](SimpleUser1.md) |  | [optional] |
| **requested_reviewers** | [**Array&lt;SimpleUser1&gt;**](SimpleUser1.md) |  | [optional] |
| **requested_teams** | [**Array&lt;TeamSimple1&gt;**](TeamSimple1.md) |  | [optional] |
| **head** | [**PullRequestHead**](PullRequestHead.md) |  |  |
| **base** | [**PullRequestBase**](PullRequestBase.md) |  |  |
| **_links** | [**PullRequestSimpleLinks**](PullRequestSimpleLinks.md) |  |  |
| **author_association** | **String** | How the author is associated with the repository. |  |
| **auto_merge** | [**AutoMerge**](AutoMerge.md) |  |  |
| **draft** | **Boolean** | Indicates whether or not the pull request is a draft. | [optional] |
| **merged** | **Boolean** |  |  |
| **mergeable** | **Boolean** |  |  |
| **rebaseable** | **Boolean** |  | [optional] |
| **mergeable_state** | **String** |  |  |
| **merged_by** | [**SimpleUser**](SimpleUser.md) |  |  |
| **comments** | **Integer** |  |  |
| **review_comments** | **Integer** |  |  |
| **maintainer_can_modify** | **Boolean** | Indicates whether maintainers can modify the pull request. |  |
| **commits** | **Integer** |  |  |
| **additions** | **Integer** |  |  |
| **deletions** | **Integer** |  |  |
| **changed_files** | **Integer** |  |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::PullRequest.new(
  url: https://api.github.com/repos/octocat/Hello-World/pulls/1347,
  id: 1,
  node_id: MDExOlB1bGxSZXF1ZXN0MQ&#x3D;&#x3D;,
  html_url: https://github.com/octocat/Hello-World/pull/1347,
  diff_url: https://github.com/octocat/Hello-World/pull/1347.diff,
  patch_url: https://github.com/octocat/Hello-World/pull/1347.patch,
  issue_url: https://api.github.com/repos/octocat/Hello-World/issues/1347,
  commits_url: https://api.github.com/repos/octocat/Hello-World/pulls/1347/commits,
  review_comments_url: https://api.github.com/repos/octocat/Hello-World/pulls/1347/comments,
  review_comment_url: https://api.github.com/repos/octocat/Hello-World/pulls/comments{/number},
  comments_url: https://api.github.com/repos/octocat/Hello-World/issues/1347/comments,
  statuses_url: https://api.github.com/repos/octocat/Hello-World/statuses/6dcb09b5b57875f334f61aebed695e2e4193db5e,
  number: 42,
  state: open,
  locked: true,
  title: Amazing new feature,
  user: null,
  body: Please pull these awesome changes,
  labels: null,
  milestone: null,
  active_lock_reason: too heated,
  created_at: 2011-01-26T19:01:12Z,
  updated_at: 2011-01-26T19:01:12Z,
  closed_at: 2011-01-26T19:01:12Z,
  merged_at: 2011-01-26T19:01:12Z,
  merge_commit_sha: e5bd3914e2e596debea16f433f57875b5b90bcd6,
  assignee: null,
  assignees: null,
  requested_reviewers: null,
  requested_teams: null,
  head: null,
  base: null,
  _links: null,
  author_association: OWNER,
  auto_merge: null,
  draft: false,
  merged: null,
  mergeable: true,
  rebaseable: true,
  mergeable_state: clean,
  merged_by: null,
  comments: 10,
  review_comments: 0,
  maintainer_can_modify: true,
  commits: 3,
  additions: 100,
  deletions: 3,
  changed_files: 5
)
```

