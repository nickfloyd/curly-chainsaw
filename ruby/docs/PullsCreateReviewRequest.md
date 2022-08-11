# OpenapiClient::PullsCreateReviewRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **commit_id** | **String** | The SHA of the commit that needs a review. Not using the latest commit SHA may render your review comment outdated if a subsequent commit modifies the line you specify as the &#x60;position&#x60;. Defaults to the most recent commit in the pull request when you do not specify a value. | [optional] |
| **body** | **String** | **Required** when using &#x60;REQUEST_CHANGES&#x60; or &#x60;COMMENT&#x60; for the &#x60;event&#x60; parameter. The body text of the pull request review. | [optional] |
| **event** | **String** | The review action you want to perform. The review actions include: &#x60;APPROVE&#x60;, &#x60;REQUEST_CHANGES&#x60;, or &#x60;COMMENT&#x60;. By leaving this blank, you set the review action state to &#x60;PENDING&#x60;, which means you will need to [submit the pull request review](https://docs.github.com/rest/pulls#submit-a-review-for-a-pull-request) when you are ready. | [optional] |
| **comments** | [**Array&lt;PullsCreateReviewRequestCommentsInner&gt;**](PullsCreateReviewRequestCommentsInner.md) | Use the following table to specify the location, destination, and contents of the draft review comment. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::PullsCreateReviewRequest.new(
  commit_id: null,
  body: null,
  event: null,
  comments: null
)
```

