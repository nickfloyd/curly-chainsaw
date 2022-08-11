# OpenapiClient::PullRequestReviewComment

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **url** | **String** | URL for the pull request review comment |  |
| **pull_request_review_id** | **Integer** | The ID of the pull request review to which the comment belongs. |  |
| **id** | **Integer** | The ID of the pull request review comment. |  |
| **node_id** | **String** | The node ID of the pull request review comment. |  |
| **diff_hunk** | **String** | The diff of the line that the comment refers to. |  |
| **path** | **String** | The relative path of the file to which the comment applies. |  |
| **position** | **Integer** | The line index in the diff to which the comment applies. This field is deprecated; use &#x60;line&#x60; instead. |  |
| **original_position** | **Integer** | The index of the original line in the diff to which the comment applies. This field is deprecated; use &#x60;original_line&#x60; instead. |  |
| **commit_id** | **String** | The SHA of the commit to which the comment applies. |  |
| **original_commit_id** | **String** | The SHA of the original commit to which the comment applies. |  |
| **in_reply_to_id** | **Integer** | The comment ID to reply to. | [optional] |
| **user** | [**SimpleUser1**](SimpleUser1.md) |  |  |
| **body** | **String** | The text of the comment. |  |
| **created_at** | **Time** |  |  |
| **updated_at** | **Time** |  |  |
| **html_url** | **String** | HTML URL for the pull request review comment. |  |
| **pull_request_url** | **String** | URL for the pull request that the review comment belongs to. |  |
| **author_association** | **String** | How the author is associated with the repository. |  |
| **_links** | [**PullRequestReviewCommentLinks**](PullRequestReviewCommentLinks.md) |  |  |
| **start_line** | **Integer** | The first line of the range for a multi-line comment. | [optional] |
| **original_start_line** | **Integer** | The first line of the range for a multi-line comment. | [optional] |
| **start_side** | **String** | The side of the first line of the range for a multi-line comment. | [optional][default to &#39;RIGHT&#39;] |
| **line** | **Integer** | The line of the blob to which the comment applies. The last line of the range for a multi-line comment | [optional] |
| **original_line** | **Integer** | The line of the blob to which the comment applies. The last line of the range for a multi-line comment | [optional] |
| **side** | **String** | The side of the diff to which the comment applies. The side of the last line of the range for a multi-line comment | [optional][default to &#39;RIGHT&#39;] |
| **reactions** | [**ReactionRollup**](ReactionRollup.md) |  | [optional] |
| **body_html** | **String** |  | [optional] |
| **body_text** | **String** |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::PullRequestReviewComment.new(
  url: https://api.github.com/repos/octocat/Hello-World/pulls/comments/1,
  pull_request_review_id: 42,
  id: 1,
  node_id: MDI0OlB1bGxSZXF1ZXN0UmV2aWV3Q29tbWVudDEw,
  diff_hunk: @@ -16,33 +16,40 @@ public class Connection : IConnection...,
  path: config/database.yaml,
  position: 1,
  original_position: 4,
  commit_id: 6dcb09b5b57875f334f61aebed695e2e4193db5e,
  original_commit_id: 9c48853fa3dc5c1c3d6f1f1cd1f2743e72652840,
  in_reply_to_id: 8,
  user: null,
  body: We should probably include a check for null values here.,
  created_at: 2011-04-14T16:00:49Z,
  updated_at: 2011-04-14T16:00:49Z,
  html_url: https://github.com/octocat/Hello-World/pull/1#discussion-diff-1,
  pull_request_url: https://api.github.com/repos/octocat/Hello-World/pulls/1,
  author_association: OWNER,
  _links: null,
  start_line: 2,
  original_start_line: 2,
  start_side: null,
  line: 2,
  original_line: 2,
  side: null,
  reactions: null,
  body_html: &quot;&lt;p&gt;comment body&lt;/p&gt;&quot;,
  body_text: &quot;comment body&quot;
)
```

