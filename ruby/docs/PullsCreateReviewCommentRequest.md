# OpenapiClient::PullsCreateReviewCommentRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **body** | **String** | The text of the review comment. |  |
| **commit_id** | **String** | The SHA of the commit needing a comment. Not using the latest commit SHA may render your comment outdated if a subsequent commit modifies the line you specify as the &#x60;position&#x60;. |  |
| **path** | **String** | The relative path to the file that necessitates a comment. |  |
| **position** | **Integer** | **This parameter is deprecated. Use &#x60;line&#x60; instead**. The position in the diff where you want to add a review comment. Note this value is not the same as the line number in the file. For help finding the position value, read the note above. | [optional] |
| **side** | **String** | In a split diff view, the side of the diff that the pull request&#39;s changes appear on. Can be &#x60;LEFT&#x60; or &#x60;RIGHT&#x60;. Use &#x60;LEFT&#x60; for deletions that appear in red. Use &#x60;RIGHT&#x60; for additions that appear in green or unchanged lines that appear in white and are shown for context. For a multi-line comment, side represents whether the last line of the comment range is a deletion or addition. For more information, see \&quot;[Diff view options](https://docs.github.com/en/articles/about-comparing-branches-in-pull-requests#diff-view-options)\&quot; in the GitHub Help documentation. | [optional] |
| **line** | **Integer** | The line of the blob in the pull request diff that the comment applies to. For a multi-line comment, the last line of the range that your comment applies to. |  |
| **start_line** | **Integer** | **Required when using multi-line comments unless using &#x60;in_reply_to&#x60;**. The &#x60;start_line&#x60; is the first line in the pull request diff that your multi-line comment applies to. To learn more about multi-line comments, see \&quot;[Commenting on a pull request](https://docs.github.com/en/articles/commenting-on-a-pull-request#adding-line-comments-to-a-pull-request)\&quot; in the GitHub Help documentation. | [optional] |
| **start_side** | **String** | **Required when using multi-line comments unless using &#x60;in_reply_to&#x60;**. The &#x60;start_side&#x60; is the starting side of the diff that the comment applies to. Can be &#x60;LEFT&#x60; or &#x60;RIGHT&#x60;. To learn more about multi-line comments, see \&quot;[Commenting on a pull request](https://docs.github.com/en/articles/commenting-on-a-pull-request#adding-line-comments-to-a-pull-request)\&quot; in the GitHub Help documentation. See &#x60;side&#x60; in this table for additional context. | [optional] |
| **in_reply_to** | **Integer** | The ID of the review comment to reply to. To find the ID of a review comment with [\&quot;List review comments on a pull request\&quot;](#list-review-comments-on-a-pull-request). When specified, all parameters other than &#x60;body&#x60; in the request body are ignored. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::PullsCreateReviewCommentRequest.new(
  body: null,
  commit_id: null,
  path: null,
  position: null,
  side: null,
  line: null,
  start_line: null,
  start_side: null,
  in_reply_to: 2
)
```

