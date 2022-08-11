# OpenapiClient::ReposUpdatePullRequestReviewProtectionRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **dismissal_restrictions** | [**ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsDismissalRestrictions**](ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsDismissalRestrictions.md) |  | [optional] |
| **dismiss_stale_reviews** | **Boolean** | Set to &#x60;true&#x60; if you want to automatically dismiss approving reviews when someone pushes a new commit. | [optional] |
| **require_code_owner_reviews** | **Boolean** | Blocks merging pull requests until [code owners](https://docs.github.com/articles/about-code-owners/) have reviewed. | [optional] |
| **required_approving_review_count** | **Integer** | Specifies the number of reviewers required to approve pull requests. Use a number between 1 and 6 or 0 to not require reviewers. | [optional] |
| **bypass_pull_request_allowances** | [**ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsBypassPullRequestAllowances**](ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsBypassPullRequestAllowances.md) |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ReposUpdatePullRequestReviewProtectionRequest.new(
  dismissal_restrictions: null,
  dismiss_stale_reviews: null,
  require_code_owner_reviews: null,
  required_approving_review_count: null,
  bypass_pull_request_allowances: null
)
```

