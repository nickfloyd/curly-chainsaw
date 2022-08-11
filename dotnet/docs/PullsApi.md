# Org.OpenAPITools.Api.PullsApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PullsCheckIfMerged**](PullsApi.md#pullscheckifmerged) | **GET** /repos/{owner}/{repo}/pulls/{pull_number}/merge | Check if a pull request has been merged
[**PullsCreate**](PullsApi.md#pullscreate) | **POST** /repos/{owner}/{repo}/pulls | Create a pull request
[**PullsCreateReplyForReviewComment**](PullsApi.md#pullscreatereplyforreviewcomment) | **POST** /repos/{owner}/{repo}/pulls/{pull_number}/comments/{comment_id}/replies | Create a reply for a review comment
[**PullsCreateReview**](PullsApi.md#pullscreatereview) | **POST** /repos/{owner}/{repo}/pulls/{pull_number}/reviews | Create a review for a pull request
[**PullsCreateReviewComment**](PullsApi.md#pullscreatereviewcomment) | **POST** /repos/{owner}/{repo}/pulls/{pull_number}/comments | Create a review comment for a pull request
[**PullsDeletePendingReview**](PullsApi.md#pullsdeletependingreview) | **DELETE** /repos/{owner}/{repo}/pulls/{pull_number}/reviews/{review_id} | Delete a pending review for a pull request
[**PullsDeleteReviewComment**](PullsApi.md#pullsdeletereviewcomment) | **DELETE** /repos/{owner}/{repo}/pulls/comments/{comment_id} | Delete a review comment for a pull request
[**PullsDismissReview**](PullsApi.md#pullsdismissreview) | **PUT** /repos/{owner}/{repo}/pulls/{pull_number}/reviews/{review_id}/dismissals | Dismiss a review for a pull request
[**PullsGet**](PullsApi.md#pullsget) | **GET** /repos/{owner}/{repo}/pulls/{pull_number} | Get a pull request
[**PullsGetReview**](PullsApi.md#pullsgetreview) | **GET** /repos/{owner}/{repo}/pulls/{pull_number}/reviews/{review_id} | Get a review for a pull request
[**PullsGetReviewComment**](PullsApi.md#pullsgetreviewcomment) | **GET** /repos/{owner}/{repo}/pulls/comments/{comment_id} | Get a review comment for a pull request
[**PullsList**](PullsApi.md#pullslist) | **GET** /repos/{owner}/{repo}/pulls | List pull requests
[**PullsListCommentsForReview**](PullsApi.md#pullslistcommentsforreview) | **GET** /repos/{owner}/{repo}/pulls/{pull_number}/reviews/{review_id}/comments | List comments for a pull request review
[**PullsListCommits**](PullsApi.md#pullslistcommits) | **GET** /repos/{owner}/{repo}/pulls/{pull_number}/commits | List commits on a pull request
[**PullsListFiles**](PullsApi.md#pullslistfiles) | **GET** /repos/{owner}/{repo}/pulls/{pull_number}/files | List pull requests files
[**PullsListRequestedReviewers**](PullsApi.md#pullslistrequestedreviewers) | **GET** /repos/{owner}/{repo}/pulls/{pull_number}/requested_reviewers | Get all requested reviewers for a pull request
[**PullsListReviewComments**](PullsApi.md#pullslistreviewcomments) | **GET** /repos/{owner}/{repo}/pulls/{pull_number}/comments | List review comments on a pull request
[**PullsListReviewCommentsForRepo**](PullsApi.md#pullslistreviewcommentsforrepo) | **GET** /repos/{owner}/{repo}/pulls/comments | List review comments in a repository
[**PullsListReviews**](PullsApi.md#pullslistreviews) | **GET** /repos/{owner}/{repo}/pulls/{pull_number}/reviews | List reviews for a pull request
[**PullsMerge**](PullsApi.md#pullsmerge) | **PUT** /repos/{owner}/{repo}/pulls/{pull_number}/merge | Merge a pull request
[**PullsRemoveRequestedReviewers**](PullsApi.md#pullsremoverequestedreviewers) | **DELETE** /repos/{owner}/{repo}/pulls/{pull_number}/requested_reviewers | Remove requested reviewers from a pull request
[**PullsRequestReviewers**](PullsApi.md#pullsrequestreviewers) | **POST** /repos/{owner}/{repo}/pulls/{pull_number}/requested_reviewers | Request reviewers for a pull request
[**PullsSubmitReview**](PullsApi.md#pullssubmitreview) | **POST** /repos/{owner}/{repo}/pulls/{pull_number}/reviews/{review_id}/events | Submit a review for a pull request
[**PullsUpdate**](PullsApi.md#pullsupdate) | **PATCH** /repos/{owner}/{repo}/pulls/{pull_number} | Update a pull request
[**PullsUpdateBranch**](PullsApi.md#pullsupdatebranch) | **PUT** /repos/{owner}/{repo}/pulls/{pull_number}/update-branch | Update a pull request branch
[**PullsUpdateReview**](PullsApi.md#pullsupdatereview) | **PUT** /repos/{owner}/{repo}/pulls/{pull_number}/reviews/{review_id} | Update a review for a pull request
[**PullsUpdateReviewComment**](PullsApi.md#pullsupdatereviewcomment) | **PATCH** /repos/{owner}/{repo}/pulls/comments/{comment_id} | Update a review comment for a pull request


<a name="pullscheckifmerged"></a>
# **PullsCheckIfMerged**
> void PullsCheckIfMerged (string owner, string repo, int? pullNumber)

Check if a pull request has been merged



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsCheckIfMergedExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullNumber = 56;  // int? | The number that identifies the pull request.

            try
            {
                // Check if a pull request has been merged
                apiInstance.PullsCheckIfMerged(owner, repo, pullNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsCheckIfMerged: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullNumber** | **int?**| The number that identifies the pull request. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullscreate"></a>
# **PullsCreate**
> PullRequest PullsCreate (string owner, string repo, PullsCreateRequest pullsCreateRequest)

Create a pull request

Draft pull requests are available in public repositories with GitHub Free and GitHub Free for organizations, GitHub Pro, and legacy per-repository billing plans, and in public and private repositories with GitHub Team and GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  To open or update a pull request in a public repository, you must have write access to the head or the source branch. For organization-owned repositories, you must be a member of the organization that owns the repository to open or update a pull request.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \"[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\" and \"[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-rate-limits)\" for details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsCreateExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullsCreateRequest = new PullsCreateRequest(); // PullsCreateRequest | 

            try
            {
                // Create a pull request
                PullRequest result = apiInstance.PullsCreate(owner, repo, pullsCreateRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullsCreateRequest** | [**PullsCreateRequest**](PullsCreateRequest.md)|  | 

### Return type

[**PullRequest**](PullRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullscreatereplyforreviewcomment"></a>
# **PullsCreateReplyForReviewComment**
> PullRequestReviewComment PullsCreateReplyForReviewComment (string owner, string repo, int? pullNumber, int? commentId, PullsCreateReplyForReviewCommentRequest pullsCreateReplyForReviewCommentRequest)

Create a reply for a review comment

Creates a reply to a review comment for a pull request. For the `comment_id`, provide the ID of the review comment you are replying to. This must be the ID of a _top-level review comment_, not a reply to that comment. Replies to replies are not supported.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \"[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\" and \"[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\" for details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsCreateReplyForReviewCommentExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullNumber = 56;  // int? | The number that identifies the pull request.
            var commentId = 56;  // int? | The unique identifier of the comment.
            var pullsCreateReplyForReviewCommentRequest = new PullsCreateReplyForReviewCommentRequest(); // PullsCreateReplyForReviewCommentRequest | 

            try
            {
                // Create a reply for a review comment
                PullRequestReviewComment result = apiInstance.PullsCreateReplyForReviewComment(owner, repo, pullNumber, commentId, pullsCreateReplyForReviewCommentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsCreateReplyForReviewComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullNumber** | **int?**| The number that identifies the pull request. | 
 **commentId** | **int?**| The unique identifier of the comment. | 
 **pullsCreateReplyForReviewCommentRequest** | [**PullsCreateReplyForReviewCommentRequest**](PullsCreateReplyForReviewCommentRequest.md)|  | 

### Return type

[**PullRequestReviewComment**](PullRequestReviewComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullscreatereview"></a>
# **PullsCreateReview**
> PullRequestReview PullsCreateReview (string owner, string repo, int? pullNumber, PullsCreateReviewRequest pullsCreateReviewRequest)

Create a review for a pull request

This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \"[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\" and \"[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\" for details.  Pull request reviews created in the `PENDING` state do not include the `submitted_at` property in the response.  **Note:** To comment on a specific line in a file, you need to first determine the _position_ of that line in the diff. The GitHub REST API v3 offers the `application/vnd.github.v3.diff` [media type](https://docs.github.com/rest/overview/media-types#commits-commit-comparison-and-pull-requests). To see a pull request diff, add this media type to the `Accept` header of a call to the [single pull request](https://docs.github.com/rest/reference/pulls#get-a-pull-request) endpoint.  The `position` value equals the number of lines down from the first \"@@\" hunk header in the file you want to add a comment. The line just below the \"@@\" line is position 1, the next line is position 2, and so on. The position in the diff continues to increase through lines of whitespace and additional hunks until the beginning of a new file.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsCreateReviewExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullNumber = 56;  // int? | The number that identifies the pull request.
            var pullsCreateReviewRequest = new PullsCreateReviewRequest(); // PullsCreateReviewRequest |  (optional) 

            try
            {
                // Create a review for a pull request
                PullRequestReview result = apiInstance.PullsCreateReview(owner, repo, pullNumber, pullsCreateReviewRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsCreateReview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullNumber** | **int?**| The number that identifies the pull request. | 
 **pullsCreateReviewRequest** | [**PullsCreateReviewRequest**](PullsCreateReviewRequest.md)|  | [optional] 

### Return type

[**PullRequestReview**](PullRequestReview.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullscreatereviewcomment"></a>
# **PullsCreateReviewComment**
> PullRequestReviewComment PullsCreateReviewComment (string owner, string repo, int? pullNumber, PullsCreateReviewCommentRequest pullsCreateReviewCommentRequest)

Create a review comment for a pull request

 Creates a review comment in the pull request diff. To add a regular comment to a pull request timeline, see \"[Create an issue comment](https://docs.github.com/rest/reference/issues#create-an-issue-comment).\" We recommend creating a review comment using `line`, `side`, and optionally `start_line` and `start_side` if your comment applies to more than one line in the pull request diff.  The `position` parameter is deprecated. If you use `position`, the `line`, `side`, `start_line`, and `start_side` parameters are not required.  **Note:** The position value equals the number of lines down from the first \"@@\" hunk header in the file you want to add a comment. The line just below the \"@@\" line is position 1, the next line is position 2, and so on. The position in the diff continues to increase through lines of whitespace and additional hunks until the beginning of a new file.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \"[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\" and \"[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\" for details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsCreateReviewCommentExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullNumber = 56;  // int? | The number that identifies the pull request.
            var pullsCreateReviewCommentRequest = new PullsCreateReviewCommentRequest(); // PullsCreateReviewCommentRequest | 

            try
            {
                // Create a review comment for a pull request
                PullRequestReviewComment result = apiInstance.PullsCreateReviewComment(owner, repo, pullNumber, pullsCreateReviewCommentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsCreateReviewComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullNumber** | **int?**| The number that identifies the pull request. | 
 **pullsCreateReviewCommentRequest** | [**PullsCreateReviewCommentRequest**](PullsCreateReviewCommentRequest.md)|  | 

### Return type

[**PullRequestReviewComment**](PullRequestReviewComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullsdeletependingreview"></a>
# **PullsDeletePendingReview**
> PullRequestReview PullsDeletePendingReview (string owner, string repo, int? pullNumber, int? reviewId)

Delete a pending review for a pull request



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsDeletePendingReviewExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullNumber = 56;  // int? | The number that identifies the pull request.
            var reviewId = 56;  // int? | The unique identifier of the review.

            try
            {
                // Delete a pending review for a pull request
                PullRequestReview result = apiInstance.PullsDeletePendingReview(owner, repo, pullNumber, reviewId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsDeletePendingReview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullNumber** | **int?**| The number that identifies the pull request. | 
 **reviewId** | **int?**| The unique identifier of the review. | 

### Return type

[**PullRequestReview**](PullRequestReview.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullsdeletereviewcomment"></a>
# **PullsDeleteReviewComment**
> void PullsDeleteReviewComment (string owner, string repo, int? commentId)

Delete a review comment for a pull request

Deletes a review comment.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsDeleteReviewCommentExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commentId = 56;  // int? | The unique identifier of the comment.

            try
            {
                // Delete a review comment for a pull request
                apiInstance.PullsDeleteReviewComment(owner, repo, commentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsDeleteReviewComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **commentId** | **int?**| The unique identifier of the comment. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullsdismissreview"></a>
# **PullsDismissReview**
> PullRequestReview PullsDismissReview (string owner, string repo, int? pullNumber, int? reviewId, PullsDismissReviewRequest pullsDismissReviewRequest)

Dismiss a review for a pull request

**Note:** To dismiss a pull request review on a [protected branch](https://docs.github.com/rest/reference/repos#branches), you must be a repository administrator or be included in the list of people or teams who can dismiss pull request reviews.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsDismissReviewExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullNumber = 56;  // int? | The number that identifies the pull request.
            var reviewId = 56;  // int? | The unique identifier of the review.
            var pullsDismissReviewRequest = new PullsDismissReviewRequest(); // PullsDismissReviewRequest | 

            try
            {
                // Dismiss a review for a pull request
                PullRequestReview result = apiInstance.PullsDismissReview(owner, repo, pullNumber, reviewId, pullsDismissReviewRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsDismissReview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullNumber** | **int?**| The number that identifies the pull request. | 
 **reviewId** | **int?**| The unique identifier of the review. | 
 **pullsDismissReviewRequest** | [**PullsDismissReviewRequest**](PullsDismissReviewRequest.md)|  | 

### Return type

[**PullRequestReview**](PullRequestReview.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullsget"></a>
# **PullsGet**
> PullRequest PullsGet (string owner, string repo, int? pullNumber)

Get a pull request

Draft pull requests are available in public repositories with GitHub Free and GitHub Free for organizations, GitHub Pro, and legacy per-repository billing plans, and in public and private repositories with GitHub Team and GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Lists details of a pull request by providing its number.  When you get, [create](https://docs.github.com/rest/reference/pulls/#create-a-pull-request), or [edit](https://docs.github.com/rest/reference/pulls#update-a-pull-request) a pull request, GitHub creates a merge commit to test whether the pull request can be automatically merged into the base branch. This test commit is not added to the base branch or the head branch. You can review the status of the test commit using the `mergeable` key. For more information, see \"[Checking mergeability of pull requests](https://docs.github.com/rest/guides/getting-started-with-the-git-database-api#checking-mergeability-of-pull-requests)\".  The value of the `mergeable` attribute can be `true`, `false`, or `null`. If the value is `null`, then GitHub has started a background job to compute the mergeability. After giving the job time to complete, resubmit the request. When the job finishes, you will see a non-`null` value for the `mergeable` attribute in the response. If `mergeable` is `true`, then `merge_commit_sha` will be the SHA of the _test_ merge commit.  The value of the `merge_commit_sha` attribute changes depending on the state of the pull request. Before merging a pull request, the `merge_commit_sha` attribute holds the SHA of the _test_ merge commit. After merging a pull request, the `merge_commit_sha` attribute changes depending on how you merged the pull request:  *   If merged as a [merge commit](https://docs.github.com/articles/about-merge-methods-on-github/), `merge_commit_sha` represents the SHA of the merge commit. *   If merged via a [squash](https://docs.github.com/articles/about-merge-methods-on-github/#squashing-your-merge-commits), `merge_commit_sha` represents the SHA of the squashed commit on the base branch. *   If [rebased](https://docs.github.com/articles/about-merge-methods-on-github/#rebasing-and-merging-your-commits), `merge_commit_sha` represents the commit that the base branch was updated to.  Pass the appropriate [media type](https://docs.github.com/rest/overview/media-types/#commits-commit-comparison-and-pull-requests) to fetch diff and patch formats.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsGetExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullNumber = 56;  // int? | The number that identifies the pull request.

            try
            {
                // Get a pull request
                PullRequest result = apiInstance.PullsGet(owner, repo, pullNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullNumber** | **int?**| The number that identifies the pull request. | 

### Return type

[**PullRequest**](PullRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullsgetreview"></a>
# **PullsGetReview**
> PullRequestReview PullsGetReview (string owner, string repo, int? pullNumber, int? reviewId)

Get a review for a pull request



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsGetReviewExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullNumber = 56;  // int? | The number that identifies the pull request.
            var reviewId = 56;  // int? | The unique identifier of the review.

            try
            {
                // Get a review for a pull request
                PullRequestReview result = apiInstance.PullsGetReview(owner, repo, pullNumber, reviewId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsGetReview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullNumber** | **int?**| The number that identifies the pull request. | 
 **reviewId** | **int?**| The unique identifier of the review. | 

### Return type

[**PullRequestReview**](PullRequestReview.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullsgetreviewcomment"></a>
# **PullsGetReviewComment**
> PullRequestReviewComment PullsGetReviewComment (string owner, string repo, int? commentId)

Get a review comment for a pull request

Provides details for a review comment.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsGetReviewCommentExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commentId = 56;  // int? | The unique identifier of the comment.

            try
            {
                // Get a review comment for a pull request
                PullRequestReviewComment result = apiInstance.PullsGetReviewComment(owner, repo, commentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsGetReviewComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **commentId** | **int?**| The unique identifier of the comment. | 

### Return type

[**PullRequestReviewComment**](PullRequestReviewComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullslist"></a>
# **PullsList**
> List<PullRequestSimple> PullsList (string owner, string repo, string state, string head, string _base, string sort, string direction, int? perPage, int? page)

List pull requests

Draft pull requests are available in public repositories with GitHub Free and GitHub Free for organizations, GitHub Pro, and legacy per-repository billing plans, and in public and private repositories with GitHub Team and GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsListExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var state = "open";  // string | Either `open`, `closed`, or `all` to filter by state. (optional)  (default to open)
            var head = "head_example";  // string | Filter pulls by head user or head organization and branch name in the format of `user:ref-name` or `organization:ref-name`. For example: `github:new-script-format` or `octocat:test-branch`. (optional) 
            var _base = "_base_example";  // string | Filter pulls by base branch name. Example: `gh-pages`. (optional) 
            var sort = "created";  // string | What to sort results by. Can be either `created`, `updated`, `popularity` (comment count) or `long-running` (age, filtering by pulls updated in the last month). (optional)  (default to created)
            var direction = "asc";  // string | The direction of the sort. Can be either `asc` or `desc`. Default: `desc` when sort is `created` or sort is not specified, otherwise `asc`. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List pull requests
                List&lt;PullRequestSimple&gt; result = apiInstance.PullsList(owner, repo, state, head, _base, sort, direction, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **state** | **string**| Either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60; to filter by state. | [optional] [default to open]
 **head** | **string**| Filter pulls by head user or head organization and branch name in the format of &#x60;user:ref-name&#x60; or &#x60;organization:ref-name&#x60;. For example: &#x60;github:new-script-format&#x60; or &#x60;octocat:test-branch&#x60;. | [optional] 
 **_base** | **string**| Filter pulls by base branch name. Example: &#x60;gh-pages&#x60;. | [optional] 
 **sort** | **string**| What to sort results by. Can be either &#x60;created&#x60;, &#x60;updated&#x60;, &#x60;popularity&#x60; (comment count) or &#x60;long-running&#x60; (age, filtering by pulls updated in the last month). | [optional] [default to created]
 **direction** | **string**| The direction of the sort. Can be either &#x60;asc&#x60; or &#x60;desc&#x60;. Default: &#x60;desc&#x60; when sort is &#x60;created&#x60; or sort is not specified, otherwise &#x60;asc&#x60;. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<PullRequestSimple>**](PullRequestSimple.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullslistcommentsforreview"></a>
# **PullsListCommentsForReview**
> List<LegacyReviewComment> PullsListCommentsForReview (string owner, string repo, int? pullNumber, int? reviewId, int? perPage, int? page)

List comments for a pull request review

List comments for a specific pull request review.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsListCommentsForReviewExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullNumber = 56;  // int? | The number that identifies the pull request.
            var reviewId = 56;  // int? | The unique identifier of the review.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List comments for a pull request review
                List&lt;LegacyReviewComment&gt; result = apiInstance.PullsListCommentsForReview(owner, repo, pullNumber, reviewId, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsListCommentsForReview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullNumber** | **int?**| The number that identifies the pull request. | 
 **reviewId** | **int?**| The unique identifier of the review. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<LegacyReviewComment>**](LegacyReviewComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullslistcommits"></a>
# **PullsListCommits**
> List<Commit> PullsListCommits (string owner, string repo, int? pullNumber, int? perPage, int? page)

List commits on a pull request

Lists a maximum of 250 commits for a pull request. To receive a complete commit list for pull requests with more than 250 commits, use the [List commits](https://docs.github.com/rest/reference/repos#list-commits) endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsListCommitsExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullNumber = 56;  // int? | The number that identifies the pull request.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List commits on a pull request
                List&lt;Commit&gt; result = apiInstance.PullsListCommits(owner, repo, pullNumber, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsListCommits: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullNumber** | **int?**| The number that identifies the pull request. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Commit>**](Commit.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullslistfiles"></a>
# **PullsListFiles**
> List<DiffEntry> PullsListFiles (string owner, string repo, int? pullNumber, int? perPage, int? page)

List pull requests files

**Note:** Responses include a maximum of 3000 files. The paginated response returns 30 files per page by default.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsListFilesExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullNumber = 56;  // int? | The number that identifies the pull request.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List pull requests files
                List&lt;DiffEntry&gt; result = apiInstance.PullsListFiles(owner, repo, pullNumber, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsListFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullNumber** | **int?**| The number that identifies the pull request. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<DiffEntry>**](DiffEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullslistrequestedreviewers"></a>
# **PullsListRequestedReviewers**
> PullRequestReviewRequest PullsListRequestedReviewers (string owner, string repo, int? pullNumber)

Get all requested reviewers for a pull request

Gets the users or teams whose review is requested for a pull request. Once a requested reviewer submits a review, they are no longer considered a requested reviewer. Their review will instead be returned by the [List reviews for a pull request](https://docs.github.com/rest/pulls/reviews#list-reviews-for-a-pull-request) operation.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsListRequestedReviewersExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullNumber = 56;  // int? | The number that identifies the pull request.

            try
            {
                // Get all requested reviewers for a pull request
                PullRequestReviewRequest result = apiInstance.PullsListRequestedReviewers(owner, repo, pullNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsListRequestedReviewers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullNumber** | **int?**| The number that identifies the pull request. | 

### Return type

[**PullRequestReviewRequest**](PullRequestReviewRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullslistreviewcomments"></a>
# **PullsListReviewComments**
> List<PullRequestReviewComment> PullsListReviewComments (string owner, string repo, int? pullNumber, string sort, string direction, DateTime? since, int? perPage, int? page)

List review comments on a pull request

Lists all review comments for a pull request. By default, review comments are in ascending order by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsListReviewCommentsExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullNumber = 56;  // int? | The number that identifies the pull request.
            var sort = "created";  // string | The property to sort the results by. `created` means when the repository was starred. `updated` means when the repository was last pushed to. (optional)  (default to created)
            var direction = "asc";  // string | Can be either `asc` or `desc`. Ignored without `sort` parameter. (optional) 
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List review comments on a pull request
                List&lt;PullRequestReviewComment&gt; result = apiInstance.PullsListReviewComments(owner, repo, pullNumber, sort, direction, since, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsListReviewComments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullNumber** | **int?**| The number that identifies the pull request. | 
 **sort** | **string**| The property to sort the results by. &#x60;created&#x60; means when the repository was starred. &#x60;updated&#x60; means when the repository was last pushed to. | [optional] [default to created]
 **direction** | **string**| Can be either &#x60;asc&#x60; or &#x60;desc&#x60;. Ignored without &#x60;sort&#x60; parameter. | [optional] 
 **since** | **DateTime?**| Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<PullRequestReviewComment>**](PullRequestReviewComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullslistreviewcommentsforrepo"></a>
# **PullsListReviewCommentsForRepo**
> List<PullRequestReviewComment> PullsListReviewCommentsForRepo (string owner, string repo, string sort, string direction, DateTime? since, int? perPage, int? page)

List review comments in a repository

Lists review comments for all pull requests in a repository. By default, review comments are in ascending order by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsListReviewCommentsForRepoExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var sort = "created";  // string |  (optional) 
            var direction = "asc";  // string | Can be either `asc` or `desc`. Ignored without `sort` parameter. (optional) 
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List review comments in a repository
                List&lt;PullRequestReviewComment&gt; result = apiInstance.PullsListReviewCommentsForRepo(owner, repo, sort, direction, since, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsListReviewCommentsForRepo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **sort** | **string**|  | [optional] 
 **direction** | **string**| Can be either &#x60;asc&#x60; or &#x60;desc&#x60;. Ignored without &#x60;sort&#x60; parameter. | [optional] 
 **since** | **DateTime?**| Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<PullRequestReviewComment>**](PullRequestReviewComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullslistreviews"></a>
# **PullsListReviews**
> List<PullRequestReview> PullsListReviews (string owner, string repo, int? pullNumber, int? perPage, int? page)

List reviews for a pull request

The list of reviews returns in chronological order.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsListReviewsExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullNumber = 56;  // int? | The number that identifies the pull request.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List reviews for a pull request
                List&lt;PullRequestReview&gt; result = apiInstance.PullsListReviews(owner, repo, pullNumber, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsListReviews: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullNumber** | **int?**| The number that identifies the pull request. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<PullRequestReview>**](PullRequestReview.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullsmerge"></a>
# **PullsMerge**
> PullRequestMergeResult PullsMerge (string owner, string repo, int? pullNumber, PullsMergeRequest pullsMergeRequest)

Merge a pull request

This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \"[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\" and \"[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\" for details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsMergeExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullNumber = 56;  // int? | The number that identifies the pull request.
            var pullsMergeRequest = new PullsMergeRequest(); // PullsMergeRequest |  (optional) 

            try
            {
                // Merge a pull request
                PullRequestMergeResult result = apiInstance.PullsMerge(owner, repo, pullNumber, pullsMergeRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsMerge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullNumber** | **int?**| The number that identifies the pull request. | 
 **pullsMergeRequest** | [**PullsMergeRequest**](PullsMergeRequest.md)|  | [optional] 

### Return type

[**PullRequestMergeResult**](PullRequestMergeResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullsremoverequestedreviewers"></a>
# **PullsRemoveRequestedReviewers**
> PullRequestSimple PullsRemoveRequestedReviewers (string owner, string repo, int? pullNumber, PullsRemoveRequestedReviewersRequest pullsRemoveRequestedReviewersRequest)

Remove requested reviewers from a pull request



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsRemoveRequestedReviewersExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullNumber = 56;  // int? | The number that identifies the pull request.
            var pullsRemoveRequestedReviewersRequest = new PullsRemoveRequestedReviewersRequest(); // PullsRemoveRequestedReviewersRequest | 

            try
            {
                // Remove requested reviewers from a pull request
                PullRequestSimple result = apiInstance.PullsRemoveRequestedReviewers(owner, repo, pullNumber, pullsRemoveRequestedReviewersRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsRemoveRequestedReviewers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullNumber** | **int?**| The number that identifies the pull request. | 
 **pullsRemoveRequestedReviewersRequest** | [**PullsRemoveRequestedReviewersRequest**](PullsRemoveRequestedReviewersRequest.md)|  | 

### Return type

[**PullRequestSimple**](PullRequestSimple.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullsrequestreviewers"></a>
# **PullsRequestReviewers**
> PullRequestSimple PullsRequestReviewers (string owner, string repo, int? pullNumber, PullsRequestReviewersRequest pullsRequestReviewersRequest)

Request reviewers for a pull request

This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \"[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\" and \"[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\" for details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsRequestReviewersExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullNumber = 56;  // int? | The number that identifies the pull request.
            var pullsRequestReviewersRequest = new PullsRequestReviewersRequest(); // PullsRequestReviewersRequest |  (optional) 

            try
            {
                // Request reviewers for a pull request
                PullRequestSimple result = apiInstance.PullsRequestReviewers(owner, repo, pullNumber, pullsRequestReviewersRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsRequestReviewers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullNumber** | **int?**| The number that identifies the pull request. | 
 **pullsRequestReviewersRequest** | [**PullsRequestReviewersRequest**](PullsRequestReviewersRequest.md)|  | [optional] 

### Return type

[**PullRequestSimple**](PullRequestSimple.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullssubmitreview"></a>
# **PullsSubmitReview**
> PullRequestReview PullsSubmitReview (string owner, string repo, int? pullNumber, int? reviewId, PullsSubmitReviewRequest pullsSubmitReviewRequest)

Submit a review for a pull request



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsSubmitReviewExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullNumber = 56;  // int? | The number that identifies the pull request.
            var reviewId = 56;  // int? | The unique identifier of the review.
            var pullsSubmitReviewRequest = new PullsSubmitReviewRequest(); // PullsSubmitReviewRequest | 

            try
            {
                // Submit a review for a pull request
                PullRequestReview result = apiInstance.PullsSubmitReview(owner, repo, pullNumber, reviewId, pullsSubmitReviewRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsSubmitReview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullNumber** | **int?**| The number that identifies the pull request. | 
 **reviewId** | **int?**| The unique identifier of the review. | 
 **pullsSubmitReviewRequest** | [**PullsSubmitReviewRequest**](PullsSubmitReviewRequest.md)|  | 

### Return type

[**PullRequestReview**](PullRequestReview.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullsupdate"></a>
# **PullsUpdate**
> PullRequest PullsUpdate (string owner, string repo, int? pullNumber, PullsUpdateRequest pullsUpdateRequest)

Update a pull request

Draft pull requests are available in public repositories with GitHub Free and GitHub Free for organizations, GitHub Pro, and legacy per-repository billing plans, and in public and private repositories with GitHub Team and GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  To open or update a pull request in a public repository, you must have write access to the head or the source branch. For organization-owned repositories, you must be a member of the organization that owns the repository to open or update a pull request.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsUpdateExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullNumber = 56;  // int? | The number that identifies the pull request.
            var pullsUpdateRequest = new PullsUpdateRequest(); // PullsUpdateRequest |  (optional) 

            try
            {
                // Update a pull request
                PullRequest result = apiInstance.PullsUpdate(owner, repo, pullNumber, pullsUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullNumber** | **int?**| The number that identifies the pull request. | 
 **pullsUpdateRequest** | [**PullsUpdateRequest**](PullsUpdateRequest.md)|  | [optional] 

### Return type

[**PullRequest**](PullRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullsupdatebranch"></a>
# **PullsUpdateBranch**
> ActivityMarkRepoNotificationsAsRead202Response PullsUpdateBranch (string owner, string repo, int? pullNumber, PullsUpdateBranchRequest pullsUpdateBranchRequest)

Update a pull request branch

Updates the pull request branch with the latest upstream changes by merging HEAD from the base branch into the pull request branch.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsUpdateBranchExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullNumber = 56;  // int? | The number that identifies the pull request.
            var pullsUpdateBranchRequest = new PullsUpdateBranchRequest(); // PullsUpdateBranchRequest |  (optional) 

            try
            {
                // Update a pull request branch
                ActivityMarkRepoNotificationsAsRead202Response result = apiInstance.PullsUpdateBranch(owner, repo, pullNumber, pullsUpdateBranchRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsUpdateBranch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullNumber** | **int?**| The number that identifies the pull request. | 
 **pullsUpdateBranchRequest** | [**PullsUpdateBranchRequest**](PullsUpdateBranchRequest.md)|  | [optional] 

### Return type

[**ActivityMarkRepoNotificationsAsRead202Response**](ActivityMarkRepoNotificationsAsRead202Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullsupdatereview"></a>
# **PullsUpdateReview**
> PullRequestReview PullsUpdateReview (string owner, string repo, int? pullNumber, int? reviewId, PullsUpdateReviewRequest pullsUpdateReviewRequest)

Update a review for a pull request

Update the review summary comment with new text.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsUpdateReviewExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullNumber = 56;  // int? | The number that identifies the pull request.
            var reviewId = 56;  // int? | The unique identifier of the review.
            var pullsUpdateReviewRequest = new PullsUpdateReviewRequest(); // PullsUpdateReviewRequest | 

            try
            {
                // Update a review for a pull request
                PullRequestReview result = apiInstance.PullsUpdateReview(owner, repo, pullNumber, reviewId, pullsUpdateReviewRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsUpdateReview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullNumber** | **int?**| The number that identifies the pull request. | 
 **reviewId** | **int?**| The unique identifier of the review. | 
 **pullsUpdateReviewRequest** | [**PullsUpdateReviewRequest**](PullsUpdateReviewRequest.md)|  | 

### Return type

[**PullRequestReview**](PullRequestReview.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pullsupdatereviewcomment"></a>
# **PullsUpdateReviewComment**
> PullRequestReviewComment PullsUpdateReviewComment (string owner, string repo, int? commentId, PullsUpdateReviewCommentRequest pullsUpdateReviewCommentRequest)

Update a review comment for a pull request

Enables you to edit a review comment.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PullsUpdateReviewCommentExample
    {
        public void main()
        {
            var apiInstance = new PullsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commentId = 56;  // int? | The unique identifier of the comment.
            var pullsUpdateReviewCommentRequest = new PullsUpdateReviewCommentRequest(); // PullsUpdateReviewCommentRequest | 

            try
            {
                // Update a review comment for a pull request
                PullRequestReviewComment result = apiInstance.PullsUpdateReviewComment(owner, repo, commentId, pullsUpdateReviewCommentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PullsApi.PullsUpdateReviewComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **commentId** | **int?**| The unique identifier of the comment. | 
 **pullsUpdateReviewCommentRequest** | [**PullsUpdateReviewCommentRequest**](PullsUpdateReviewCommentRequest.md)|  | 

### Return type

[**PullRequestReviewComment**](PullRequestReviewComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

