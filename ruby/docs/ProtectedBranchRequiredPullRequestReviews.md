# OpenapiClient::ProtectedBranchRequiredPullRequestReviews

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **url** | **String** |  |  |
| **dismiss_stale_reviews** | **Boolean** |  | [optional] |
| **require_code_owner_reviews** | **Boolean** |  | [optional] |
| **required_approving_review_count** | **Integer** |  | [optional] |
| **dismissal_restrictions** | [**ProtectedBranchRequiredPullRequestReviewsDismissalRestrictions**](ProtectedBranchRequiredPullRequestReviewsDismissalRestrictions.md) |  | [optional] |
| **bypass_pull_request_allowances** | [**ProtectedBranchRequiredPullRequestReviewsBypassPullRequestAllowances**](ProtectedBranchRequiredPullRequestReviewsBypassPullRequestAllowances.md) |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ProtectedBranchRequiredPullRequestReviews.new(
  url: null,
  dismiss_stale_reviews: null,
  require_code_owner_reviews: null,
  required_approving_review_count: null,
  dismissal_restrictions: null,
  bypass_pull_request_allowances: null
)
```

