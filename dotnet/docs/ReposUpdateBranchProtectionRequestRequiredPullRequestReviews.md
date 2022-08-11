# Org.OpenAPITools.Model.ReposUpdateBranchProtectionRequestRequiredPullRequestReviews

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DismissalRestrictions** | [**ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsDismissalRestrictions**](ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsDismissalRestrictions.md) |  | [optional] 
**DismissStaleReviews** | **bool?** | Set to &#x60;true&#x60; if you want to automatically dismiss approving reviews when someone pushes a new commit. | [optional] 
**RequireCodeOwnerReviews** | **bool?** | Blocks merging pull requests until [code owners](https://docs.github.com/articles/about-code-owners/) review them. | [optional] 
**RequiredApprovingReviewCount** | **int?** | Specify the number of reviewers required to approve pull requests. Use a number between 1 and 6 or 0 to not require reviewers. | [optional] 
**BypassPullRequestAllowances** | [**ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsBypassPullRequestAllowances**](ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsBypassPullRequestAllowances.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

