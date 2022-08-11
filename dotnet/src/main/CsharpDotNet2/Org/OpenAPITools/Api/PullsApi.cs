using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPullsApi
    {
        /// <summary>
        /// Check if a pull request has been merged 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <returns></returns>
        void PullsCheckIfMerged (string owner, string repo, int? pullNumber);
        /// <summary>
        /// Create a pull request Draft pull requests are available in public repositories with GitHub Free and GitHub Free for organizations, GitHub Pro, and legacy per-repository billing plans, and in public and private repositories with GitHub Team and GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  To open or update a pull request in a public repository, you must have write access to the head or the source branch. For organization-owned repositories, you must be a member of the organization that owns the repository to open or update a pull request.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullsCreateRequest"></param>
        /// <returns>PullRequest</returns>
        PullRequest PullsCreate (string owner, string repo, PullsCreateRequest pullsCreateRequest);
        /// <summary>
        /// Create a reply for a review comment Creates a reply to a review comment for a pull request. For the &#x60;comment_id&#x60;, provide the ID of the review comment you are replying to. This must be the ID of a _top-level review comment_, not a reply to that comment. Replies to replies are not supported.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="pullsCreateReplyForReviewCommentRequest"></param>
        /// <returns>PullRequestReviewComment</returns>
        PullRequestReviewComment PullsCreateReplyForReviewComment (string owner, string repo, int? pullNumber, int? commentId, PullsCreateReplyForReviewCommentRequest pullsCreateReplyForReviewCommentRequest);
        /// <summary>
        /// Create a review for a pull request This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.  Pull request reviews created in the &#x60;PENDING&#x60; state do not include the &#x60;submitted_at&#x60; property in the response.  **Note:** To comment on a specific line in a file, you need to first determine the _position_ of that line in the diff. The GitHub REST API v3 offers the &#x60;application/vnd.github.v3.diff&#x60; [media type](https://docs.github.com/rest/overview/media-types#commits-commit-comparison-and-pull-requests). To see a pull request diff, add this media type to the &#x60;Accept&#x60; header of a call to the [single pull request](https://docs.github.com/rest/reference/pulls#get-a-pull-request) endpoint.  The &#x60;position&#x60; value equals the number of lines down from the first \&quot;@@\&quot; hunk header in the file you want to add a comment. The line just below the \&quot;@@\&quot; line is position 1, the next line is position 2, and so on. The position in the diff continues to increase through lines of whitespace and additional hunks until the beginning of a new file.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="pullsCreateReviewRequest"></param>
        /// <returns>PullRequestReview</returns>
        PullRequestReview PullsCreateReview (string owner, string repo, int? pullNumber, PullsCreateReviewRequest pullsCreateReviewRequest);
        /// <summary>
        /// Create a review comment for a pull request  Creates a review comment in the pull request diff. To add a regular comment to a pull request timeline, see \&quot;[Create an issue comment](https://docs.github.com/rest/reference/issues#create-an-issue-comment).\&quot; We recommend creating a review comment using &#x60;line&#x60;, &#x60;side&#x60;, and optionally &#x60;start_line&#x60; and &#x60;start_side&#x60; if your comment applies to more than one line in the pull request diff.  The &#x60;position&#x60; parameter is deprecated. If you use &#x60;position&#x60;, the &#x60;line&#x60;, &#x60;side&#x60;, &#x60;start_line&#x60;, and &#x60;start_side&#x60; parameters are not required.  **Note:** The position value equals the number of lines down from the first \&quot;@@\&quot; hunk header in the file you want to add a comment. The line just below the \&quot;@@\&quot; line is position 1, the next line is position 2, and so on. The position in the diff continues to increase through lines of whitespace and additional hunks until the beginning of a new file.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="pullsCreateReviewCommentRequest"></param>
        /// <returns>PullRequestReviewComment</returns>
        PullRequestReviewComment PullsCreateReviewComment (string owner, string repo, int? pullNumber, PullsCreateReviewCommentRequest pullsCreateReviewCommentRequest);
        /// <summary>
        /// Delete a pending review for a pull request 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="reviewId">The unique identifier of the review.</param>
        /// <returns>PullRequestReview</returns>
        PullRequestReview PullsDeletePendingReview (string owner, string repo, int? pullNumber, int? reviewId);
        /// <summary>
        /// Delete a review comment for a pull request Deletes a review comment.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <returns></returns>
        void PullsDeleteReviewComment (string owner, string repo, int? commentId);
        /// <summary>
        /// Dismiss a review for a pull request **Note:** To dismiss a pull request review on a [protected branch](https://docs.github.com/rest/reference/repos#branches), you must be a repository administrator or be included in the list of people or teams who can dismiss pull request reviews.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="reviewId">The unique identifier of the review.</param>
        /// <param name="pullsDismissReviewRequest"></param>
        /// <returns>PullRequestReview</returns>
        PullRequestReview PullsDismissReview (string owner, string repo, int? pullNumber, int? reviewId, PullsDismissReviewRequest pullsDismissReviewRequest);
        /// <summary>
        /// Get a pull request Draft pull requests are available in public repositories with GitHub Free and GitHub Free for organizations, GitHub Pro, and legacy per-repository billing plans, and in public and private repositories with GitHub Team and GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Lists details of a pull request by providing its number.  When you get, [create](https://docs.github.com/rest/reference/pulls/#create-a-pull-request), or [edit](https://docs.github.com/rest/reference/pulls#update-a-pull-request) a pull request, GitHub creates a merge commit to test whether the pull request can be automatically merged into the base branch. This test commit is not added to the base branch or the head branch. You can review the status of the test commit using the &#x60;mergeable&#x60; key. For more information, see \&quot;[Checking mergeability of pull requests](https://docs.github.com/rest/guides/getting-started-with-the-git-database-api#checking-mergeability-of-pull-requests)\&quot;.  The value of the &#x60;mergeable&#x60; attribute can be &#x60;true&#x60;, &#x60;false&#x60;, or &#x60;null&#x60;. If the value is &#x60;null&#x60;, then GitHub has started a background job to compute the mergeability. After giving the job time to complete, resubmit the request. When the job finishes, you will see a non-&#x60;null&#x60; value for the &#x60;mergeable&#x60; attribute in the response. If &#x60;mergeable&#x60; is &#x60;true&#x60;, then &#x60;merge_commit_sha&#x60; will be the SHA of the _test_ merge commit.  The value of the &#x60;merge_commit_sha&#x60; attribute changes depending on the state of the pull request. Before merging a pull request, the &#x60;merge_commit_sha&#x60; attribute holds the SHA of the _test_ merge commit. After merging a pull request, the &#x60;merge_commit_sha&#x60; attribute changes depending on how you merged the pull request:  *   If merged as a [merge commit](https://docs.github.com/articles/about-merge-methods-on-github/), &#x60;merge_commit_sha&#x60; represents the SHA of the merge commit. *   If merged via a [squash](https://docs.github.com/articles/about-merge-methods-on-github/#squashing-your-merge-commits), &#x60;merge_commit_sha&#x60; represents the SHA of the squashed commit on the base branch. *   If [rebased](https://docs.github.com/articles/about-merge-methods-on-github/#rebasing-and-merging-your-commits), &#x60;merge_commit_sha&#x60; represents the commit that the base branch was updated to.  Pass the appropriate [media type](https://docs.github.com/rest/overview/media-types/#commits-commit-comparison-and-pull-requests) to fetch diff and patch formats.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <returns>PullRequest</returns>
        PullRequest PullsGet (string owner, string repo, int? pullNumber);
        /// <summary>
        /// Get a review for a pull request 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="reviewId">The unique identifier of the review.</param>
        /// <returns>PullRequestReview</returns>
        PullRequestReview PullsGetReview (string owner, string repo, int? pullNumber, int? reviewId);
        /// <summary>
        /// Get a review comment for a pull request Provides details for a review comment.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <returns>PullRequestReviewComment</returns>
        PullRequestReviewComment PullsGetReviewComment (string owner, string repo, int? commentId);
        /// <summary>
        /// List pull requests Draft pull requests are available in public repositories with GitHub Free and GitHub Free for organizations, GitHub Pro, and legacy per-repository billing plans, and in public and private repositories with GitHub Team and GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="state">Either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60; to filter by state.</param>
        /// <param name="head">Filter pulls by head user or head organization and branch name in the format of &#x60;user:ref-name&#x60; or &#x60;organization:ref-name&#x60;. For example: &#x60;github:new-script-format&#x60; or &#x60;octocat:test-branch&#x60;.</param>
        /// <param name="_base">Filter pulls by base branch name. Example: &#x60;gh-pages&#x60;.</param>
        /// <param name="sort">What to sort results by. Can be either &#x60;created&#x60;, &#x60;updated&#x60;, &#x60;popularity&#x60; (comment count) or &#x60;long-running&#x60; (age, filtering by pulls updated in the last month).</param>
        /// <param name="direction">The direction of the sort. Can be either &#x60;asc&#x60; or &#x60;desc&#x60;. Default: &#x60;desc&#x60; when sort is &#x60;created&#x60; or sort is not specified, otherwise &#x60;asc&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;PullRequestSimple&gt;</returns>
        List<PullRequestSimple> PullsList (string owner, string repo, string state, string head, string _base, string sort, string direction, int? perPage, int? page);
        /// <summary>
        /// List comments for a pull request review List comments for a specific pull request review.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="reviewId">The unique identifier of the review.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;LegacyReviewComment&gt;</returns>
        List<LegacyReviewComment> PullsListCommentsForReview (string owner, string repo, int? pullNumber, int? reviewId, int? perPage, int? page);
        /// <summary>
        /// List commits on a pull request Lists a maximum of 250 commits for a pull request. To receive a complete commit list for pull requests with more than 250 commits, use the [List commits](https://docs.github.com/rest/reference/repos#list-commits) endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Commit&gt;</returns>
        List<Commit> PullsListCommits (string owner, string repo, int? pullNumber, int? perPage, int? page);
        /// <summary>
        /// List pull requests files **Note:** Responses include a maximum of 3000 files. The paginated response returns 30 files per page by default.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;DiffEntry&gt;</returns>
        List<DiffEntry> PullsListFiles (string owner, string repo, int? pullNumber, int? perPage, int? page);
        /// <summary>
        /// Get all requested reviewers for a pull request Gets the users or teams whose review is requested for a pull request. Once a requested reviewer submits a review, they are no longer considered a requested reviewer. Their review will instead be returned by the [List reviews for a pull request](https://docs.github.com/rest/pulls/reviews#list-reviews-for-a-pull-request) operation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <returns>PullRequestReviewRequest</returns>
        PullRequestReviewRequest PullsListRequestedReviewers (string owner, string repo, int? pullNumber);
        /// <summary>
        /// List review comments on a pull request Lists all review comments for a pull request. By default, review comments are in ascending order by ID.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="sort">The property to sort the results by. &#x60;created&#x60; means when the repository was starred. &#x60;updated&#x60; means when the repository was last pushed to.</param>
        /// <param name="direction">Can be either &#x60;asc&#x60; or &#x60;desc&#x60;. Ignored without &#x60;sort&#x60; parameter.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;PullRequestReviewComment&gt;</returns>
        List<PullRequestReviewComment> PullsListReviewComments (string owner, string repo, int? pullNumber, string sort, string direction, DateTime? since, int? perPage, int? page);
        /// <summary>
        /// List review comments in a repository Lists review comments for all pull requests in a repository. By default, review comments are in ascending order by ID.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="sort"></param>
        /// <param name="direction">Can be either &#x60;asc&#x60; or &#x60;desc&#x60;. Ignored without &#x60;sort&#x60; parameter.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;PullRequestReviewComment&gt;</returns>
        List<PullRequestReviewComment> PullsListReviewCommentsForRepo (string owner, string repo, string sort, string direction, DateTime? since, int? perPage, int? page);
        /// <summary>
        /// List reviews for a pull request The list of reviews returns in chronological order.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;PullRequestReview&gt;</returns>
        List<PullRequestReview> PullsListReviews (string owner, string repo, int? pullNumber, int? perPage, int? page);
        /// <summary>
        /// Merge a pull request This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="pullsMergeRequest"></param>
        /// <returns>PullRequestMergeResult</returns>
        PullRequestMergeResult PullsMerge (string owner, string repo, int? pullNumber, PullsMergeRequest pullsMergeRequest);
        /// <summary>
        /// Remove requested reviewers from a pull request 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="pullsRemoveRequestedReviewersRequest"></param>
        /// <returns>PullRequestSimple</returns>
        PullRequestSimple PullsRemoveRequestedReviewers (string owner, string repo, int? pullNumber, PullsRemoveRequestedReviewersRequest pullsRemoveRequestedReviewersRequest);
        /// <summary>
        /// Request reviewers for a pull request This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="pullsRequestReviewersRequest"></param>
        /// <returns>PullRequestSimple</returns>
        PullRequestSimple PullsRequestReviewers (string owner, string repo, int? pullNumber, PullsRequestReviewersRequest pullsRequestReviewersRequest);
        /// <summary>
        /// Submit a review for a pull request 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="reviewId">The unique identifier of the review.</param>
        /// <param name="pullsSubmitReviewRequest"></param>
        /// <returns>PullRequestReview</returns>
        PullRequestReview PullsSubmitReview (string owner, string repo, int? pullNumber, int? reviewId, PullsSubmitReviewRequest pullsSubmitReviewRequest);
        /// <summary>
        /// Update a pull request Draft pull requests are available in public repositories with GitHub Free and GitHub Free for organizations, GitHub Pro, and legacy per-repository billing plans, and in public and private repositories with GitHub Team and GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  To open or update a pull request in a public repository, you must have write access to the head or the source branch. For organization-owned repositories, you must be a member of the organization that owns the repository to open or update a pull request.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="pullsUpdateRequest"></param>
        /// <returns>PullRequest</returns>
        PullRequest PullsUpdate (string owner, string repo, int? pullNumber, PullsUpdateRequest pullsUpdateRequest);
        /// <summary>
        /// Update a pull request branch Updates the pull request branch with the latest upstream changes by merging HEAD from the base branch into the pull request branch.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="pullsUpdateBranchRequest"></param>
        /// <returns>ActivityMarkRepoNotificationsAsRead202Response</returns>
        ActivityMarkRepoNotificationsAsRead202Response PullsUpdateBranch (string owner, string repo, int? pullNumber, PullsUpdateBranchRequest pullsUpdateBranchRequest);
        /// <summary>
        /// Update a review for a pull request Update the review summary comment with new text.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="reviewId">The unique identifier of the review.</param>
        /// <param name="pullsUpdateReviewRequest"></param>
        /// <returns>PullRequestReview</returns>
        PullRequestReview PullsUpdateReview (string owner, string repo, int? pullNumber, int? reviewId, PullsUpdateReviewRequest pullsUpdateReviewRequest);
        /// <summary>
        /// Update a review comment for a pull request Enables you to edit a review comment.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="pullsUpdateReviewCommentRequest"></param>
        /// <returns>PullRequestReviewComment</returns>
        PullRequestReviewComment PullsUpdateReviewComment (string owner, string repo, int? commentId, PullsUpdateReviewCommentRequest pullsUpdateReviewCommentRequest);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PullsApi : IPullsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PullsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PullsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PullsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }

        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}

        /// <summary>
        /// Check if a pull request has been merged 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <returns></returns>
        public void PullsCheckIfMerged (string owner, string repo, int? pullNumber)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsCheckIfMerged");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsCheckIfMerged");
            
            // verify the required parameter 'pullNumber' is set
            if (pullNumber == null) throw new ApiException(400, "Missing required parameter 'pullNumber' when calling PullsCheckIfMerged");
            

            var path = "/repos/{owner}/{repo}/pulls/{pull_number}/merge";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "pull_number" + "}", ApiClient.ParameterToString(pullNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsCheckIfMerged: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsCheckIfMerged: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Create a pull request Draft pull requests are available in public repositories with GitHub Free and GitHub Free for organizations, GitHub Pro, and legacy per-repository billing plans, and in public and private repositories with GitHub Team and GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  To open or update a pull request in a public repository, you must have write access to the head or the source branch. For organization-owned repositories, you must be a member of the organization that owns the repository to open or update a pull request.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullsCreateRequest"></param>
        /// <returns>PullRequest</returns>
        public PullRequest PullsCreate (string owner, string repo, PullsCreateRequest pullsCreateRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsCreate");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsCreate");
            
            // verify the required parameter 'pullsCreateRequest' is set
            if (pullsCreateRequest == null) throw new ApiException(400, "Missing required parameter 'pullsCreateRequest' when calling PullsCreate");
            

            var path = "/repos/{owner}/{repo}/pulls";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(pullsCreateRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsCreate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsCreate: " + response.ErrorMessage, response.ErrorMessage);

            return (PullRequest) ApiClient.Deserialize(response.Content, typeof(PullRequest), response.Headers);
        }

        /// <summary>
        /// Create a reply for a review comment Creates a reply to a review comment for a pull request. For the &#x60;comment_id&#x60;, provide the ID of the review comment you are replying to. This must be the ID of a _top-level review comment_, not a reply to that comment. Replies to replies are not supported.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="pullsCreateReplyForReviewCommentRequest"></param>
        /// <returns>PullRequestReviewComment</returns>
        public PullRequestReviewComment PullsCreateReplyForReviewComment (string owner, string repo, int? pullNumber, int? commentId, PullsCreateReplyForReviewCommentRequest pullsCreateReplyForReviewCommentRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsCreateReplyForReviewComment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsCreateReplyForReviewComment");
            
            // verify the required parameter 'pullNumber' is set
            if (pullNumber == null) throw new ApiException(400, "Missing required parameter 'pullNumber' when calling PullsCreateReplyForReviewComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling PullsCreateReplyForReviewComment");
            
            // verify the required parameter 'pullsCreateReplyForReviewCommentRequest' is set
            if (pullsCreateReplyForReviewCommentRequest == null) throw new ApiException(400, "Missing required parameter 'pullsCreateReplyForReviewCommentRequest' when calling PullsCreateReplyForReviewComment");
            

            var path = "/repos/{owner}/{repo}/pulls/{pull_number}/comments/{comment_id}/replies";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "pull_number" + "}", ApiClient.ParameterToString(pullNumber));
path = path.Replace("{" + "comment_id" + "}", ApiClient.ParameterToString(commentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(pullsCreateReplyForReviewCommentRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsCreateReplyForReviewComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsCreateReplyForReviewComment: " + response.ErrorMessage, response.ErrorMessage);

            return (PullRequestReviewComment) ApiClient.Deserialize(response.Content, typeof(PullRequestReviewComment), response.Headers);
        }

        /// <summary>
        /// Create a review for a pull request This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.  Pull request reviews created in the &#x60;PENDING&#x60; state do not include the &#x60;submitted_at&#x60; property in the response.  **Note:** To comment on a specific line in a file, you need to first determine the _position_ of that line in the diff. The GitHub REST API v3 offers the &#x60;application/vnd.github.v3.diff&#x60; [media type](https://docs.github.com/rest/overview/media-types#commits-commit-comparison-and-pull-requests). To see a pull request diff, add this media type to the &#x60;Accept&#x60; header of a call to the [single pull request](https://docs.github.com/rest/reference/pulls#get-a-pull-request) endpoint.  The &#x60;position&#x60; value equals the number of lines down from the first \&quot;@@\&quot; hunk header in the file you want to add a comment. The line just below the \&quot;@@\&quot; line is position 1, the next line is position 2, and so on. The position in the diff continues to increase through lines of whitespace and additional hunks until the beginning of a new file.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="pullsCreateReviewRequest"></param>
        /// <returns>PullRequestReview</returns>
        public PullRequestReview PullsCreateReview (string owner, string repo, int? pullNumber, PullsCreateReviewRequest pullsCreateReviewRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsCreateReview");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsCreateReview");
            
            // verify the required parameter 'pullNumber' is set
            if (pullNumber == null) throw new ApiException(400, "Missing required parameter 'pullNumber' when calling PullsCreateReview");
            

            var path = "/repos/{owner}/{repo}/pulls/{pull_number}/reviews";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "pull_number" + "}", ApiClient.ParameterToString(pullNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(pullsCreateReviewRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsCreateReview: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsCreateReview: " + response.ErrorMessage, response.ErrorMessage);

            return (PullRequestReview) ApiClient.Deserialize(response.Content, typeof(PullRequestReview), response.Headers);
        }

        /// <summary>
        /// Create a review comment for a pull request  Creates a review comment in the pull request diff. To add a regular comment to a pull request timeline, see \&quot;[Create an issue comment](https://docs.github.com/rest/reference/issues#create-an-issue-comment).\&quot; We recommend creating a review comment using &#x60;line&#x60;, &#x60;side&#x60;, and optionally &#x60;start_line&#x60; and &#x60;start_side&#x60; if your comment applies to more than one line in the pull request diff.  The &#x60;position&#x60; parameter is deprecated. If you use &#x60;position&#x60;, the &#x60;line&#x60;, &#x60;side&#x60;, &#x60;start_line&#x60;, and &#x60;start_side&#x60; parameters are not required.  **Note:** The position value equals the number of lines down from the first \&quot;@@\&quot; hunk header in the file you want to add a comment. The line just below the \&quot;@@\&quot; line is position 1, the next line is position 2, and so on. The position in the diff continues to increase through lines of whitespace and additional hunks until the beginning of a new file.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="pullsCreateReviewCommentRequest"></param>
        /// <returns>PullRequestReviewComment</returns>
        public PullRequestReviewComment PullsCreateReviewComment (string owner, string repo, int? pullNumber, PullsCreateReviewCommentRequest pullsCreateReviewCommentRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsCreateReviewComment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsCreateReviewComment");
            
            // verify the required parameter 'pullNumber' is set
            if (pullNumber == null) throw new ApiException(400, "Missing required parameter 'pullNumber' when calling PullsCreateReviewComment");
            
            // verify the required parameter 'pullsCreateReviewCommentRequest' is set
            if (pullsCreateReviewCommentRequest == null) throw new ApiException(400, "Missing required parameter 'pullsCreateReviewCommentRequest' when calling PullsCreateReviewComment");
            

            var path = "/repos/{owner}/{repo}/pulls/{pull_number}/comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "pull_number" + "}", ApiClient.ParameterToString(pullNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(pullsCreateReviewCommentRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsCreateReviewComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsCreateReviewComment: " + response.ErrorMessage, response.ErrorMessage);

            return (PullRequestReviewComment) ApiClient.Deserialize(response.Content, typeof(PullRequestReviewComment), response.Headers);
        }

        /// <summary>
        /// Delete a pending review for a pull request 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="reviewId">The unique identifier of the review.</param>
        /// <returns>PullRequestReview</returns>
        public PullRequestReview PullsDeletePendingReview (string owner, string repo, int? pullNumber, int? reviewId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsDeletePendingReview");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsDeletePendingReview");
            
            // verify the required parameter 'pullNumber' is set
            if (pullNumber == null) throw new ApiException(400, "Missing required parameter 'pullNumber' when calling PullsDeletePendingReview");
            
            // verify the required parameter 'reviewId' is set
            if (reviewId == null) throw new ApiException(400, "Missing required parameter 'reviewId' when calling PullsDeletePendingReview");
            

            var path = "/repos/{owner}/{repo}/pulls/{pull_number}/reviews/{review_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "pull_number" + "}", ApiClient.ParameterToString(pullNumber));
path = path.Replace("{" + "review_id" + "}", ApiClient.ParameterToString(reviewId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsDeletePendingReview: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsDeletePendingReview: " + response.ErrorMessage, response.ErrorMessage);

            return (PullRequestReview) ApiClient.Deserialize(response.Content, typeof(PullRequestReview), response.Headers);
        }

        /// <summary>
        /// Delete a review comment for a pull request Deletes a review comment.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <returns></returns>
        public void PullsDeleteReviewComment (string owner, string repo, int? commentId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsDeleteReviewComment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsDeleteReviewComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling PullsDeleteReviewComment");
            

            var path = "/repos/{owner}/{repo}/pulls/comments/{comment_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "comment_id" + "}", ApiClient.ParameterToString(commentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsDeleteReviewComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsDeleteReviewComment: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Dismiss a review for a pull request **Note:** To dismiss a pull request review on a [protected branch](https://docs.github.com/rest/reference/repos#branches), you must be a repository administrator or be included in the list of people or teams who can dismiss pull request reviews.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="reviewId">The unique identifier of the review.</param>
        /// <param name="pullsDismissReviewRequest"></param>
        /// <returns>PullRequestReview</returns>
        public PullRequestReview PullsDismissReview (string owner, string repo, int? pullNumber, int? reviewId, PullsDismissReviewRequest pullsDismissReviewRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsDismissReview");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsDismissReview");
            
            // verify the required parameter 'pullNumber' is set
            if (pullNumber == null) throw new ApiException(400, "Missing required parameter 'pullNumber' when calling PullsDismissReview");
            
            // verify the required parameter 'reviewId' is set
            if (reviewId == null) throw new ApiException(400, "Missing required parameter 'reviewId' when calling PullsDismissReview");
            
            // verify the required parameter 'pullsDismissReviewRequest' is set
            if (pullsDismissReviewRequest == null) throw new ApiException(400, "Missing required parameter 'pullsDismissReviewRequest' when calling PullsDismissReview");
            

            var path = "/repos/{owner}/{repo}/pulls/{pull_number}/reviews/{review_id}/dismissals";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "pull_number" + "}", ApiClient.ParameterToString(pullNumber));
path = path.Replace("{" + "review_id" + "}", ApiClient.ParameterToString(reviewId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(pullsDismissReviewRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsDismissReview: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsDismissReview: " + response.ErrorMessage, response.ErrorMessage);

            return (PullRequestReview) ApiClient.Deserialize(response.Content, typeof(PullRequestReview), response.Headers);
        }

        /// <summary>
        /// Get a pull request Draft pull requests are available in public repositories with GitHub Free and GitHub Free for organizations, GitHub Pro, and legacy per-repository billing plans, and in public and private repositories with GitHub Team and GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Lists details of a pull request by providing its number.  When you get, [create](https://docs.github.com/rest/reference/pulls/#create-a-pull-request), or [edit](https://docs.github.com/rest/reference/pulls#update-a-pull-request) a pull request, GitHub creates a merge commit to test whether the pull request can be automatically merged into the base branch. This test commit is not added to the base branch or the head branch. You can review the status of the test commit using the &#x60;mergeable&#x60; key. For more information, see \&quot;[Checking mergeability of pull requests](https://docs.github.com/rest/guides/getting-started-with-the-git-database-api#checking-mergeability-of-pull-requests)\&quot;.  The value of the &#x60;mergeable&#x60; attribute can be &#x60;true&#x60;, &#x60;false&#x60;, or &#x60;null&#x60;. If the value is &#x60;null&#x60;, then GitHub has started a background job to compute the mergeability. After giving the job time to complete, resubmit the request. When the job finishes, you will see a non-&#x60;null&#x60; value for the &#x60;mergeable&#x60; attribute in the response. If &#x60;mergeable&#x60; is &#x60;true&#x60;, then &#x60;merge_commit_sha&#x60; will be the SHA of the _test_ merge commit.  The value of the &#x60;merge_commit_sha&#x60; attribute changes depending on the state of the pull request. Before merging a pull request, the &#x60;merge_commit_sha&#x60; attribute holds the SHA of the _test_ merge commit. After merging a pull request, the &#x60;merge_commit_sha&#x60; attribute changes depending on how you merged the pull request:  *   If merged as a [merge commit](https://docs.github.com/articles/about-merge-methods-on-github/), &#x60;merge_commit_sha&#x60; represents the SHA of the merge commit. *   If merged via a [squash](https://docs.github.com/articles/about-merge-methods-on-github/#squashing-your-merge-commits), &#x60;merge_commit_sha&#x60; represents the SHA of the squashed commit on the base branch. *   If [rebased](https://docs.github.com/articles/about-merge-methods-on-github/#rebasing-and-merging-your-commits), &#x60;merge_commit_sha&#x60; represents the commit that the base branch was updated to.  Pass the appropriate [media type](https://docs.github.com/rest/overview/media-types/#commits-commit-comparison-and-pull-requests) to fetch diff and patch formats.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <returns>PullRequest</returns>
        public PullRequest PullsGet (string owner, string repo, int? pullNumber)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsGet");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsGet");
            
            // verify the required parameter 'pullNumber' is set
            if (pullNumber == null) throw new ApiException(400, "Missing required parameter 'pullNumber' when calling PullsGet");
            

            var path = "/repos/{owner}/{repo}/pulls/{pull_number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "pull_number" + "}", ApiClient.ParameterToString(pullNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsGet: " + response.ErrorMessage, response.ErrorMessage);

            return (PullRequest) ApiClient.Deserialize(response.Content, typeof(PullRequest), response.Headers);
        }

        /// <summary>
        /// Get a review for a pull request 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="reviewId">The unique identifier of the review.</param>
        /// <returns>PullRequestReview</returns>
        public PullRequestReview PullsGetReview (string owner, string repo, int? pullNumber, int? reviewId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsGetReview");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsGetReview");
            
            // verify the required parameter 'pullNumber' is set
            if (pullNumber == null) throw new ApiException(400, "Missing required parameter 'pullNumber' when calling PullsGetReview");
            
            // verify the required parameter 'reviewId' is set
            if (reviewId == null) throw new ApiException(400, "Missing required parameter 'reviewId' when calling PullsGetReview");
            

            var path = "/repos/{owner}/{repo}/pulls/{pull_number}/reviews/{review_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "pull_number" + "}", ApiClient.ParameterToString(pullNumber));
path = path.Replace("{" + "review_id" + "}", ApiClient.ParameterToString(reviewId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsGetReview: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsGetReview: " + response.ErrorMessage, response.ErrorMessage);

            return (PullRequestReview) ApiClient.Deserialize(response.Content, typeof(PullRequestReview), response.Headers);
        }

        /// <summary>
        /// Get a review comment for a pull request Provides details for a review comment.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <returns>PullRequestReviewComment</returns>
        public PullRequestReviewComment PullsGetReviewComment (string owner, string repo, int? commentId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsGetReviewComment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsGetReviewComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling PullsGetReviewComment");
            

            var path = "/repos/{owner}/{repo}/pulls/comments/{comment_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "comment_id" + "}", ApiClient.ParameterToString(commentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsGetReviewComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsGetReviewComment: " + response.ErrorMessage, response.ErrorMessage);

            return (PullRequestReviewComment) ApiClient.Deserialize(response.Content, typeof(PullRequestReviewComment), response.Headers);
        }

        /// <summary>
        /// List pull requests Draft pull requests are available in public repositories with GitHub Free and GitHub Free for organizations, GitHub Pro, and legacy per-repository billing plans, and in public and private repositories with GitHub Team and GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="state">Either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60; to filter by state.</param>
        /// <param name="head">Filter pulls by head user or head organization and branch name in the format of &#x60;user:ref-name&#x60; or &#x60;organization:ref-name&#x60;. For example: &#x60;github:new-script-format&#x60; or &#x60;octocat:test-branch&#x60;.</param>
        /// <param name="_base">Filter pulls by base branch name. Example: &#x60;gh-pages&#x60;.</param>
        /// <param name="sort">What to sort results by. Can be either &#x60;created&#x60;, &#x60;updated&#x60;, &#x60;popularity&#x60; (comment count) or &#x60;long-running&#x60; (age, filtering by pulls updated in the last month).</param>
        /// <param name="direction">The direction of the sort. Can be either &#x60;asc&#x60; or &#x60;desc&#x60;. Default: &#x60;desc&#x60; when sort is &#x60;created&#x60; or sort is not specified, otherwise &#x60;asc&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;PullRequestSimple&gt;</returns>
        public List<PullRequestSimple> PullsList (string owner, string repo, string state, string head, string _base, string sort, string direction, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsList");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsList");
            

            var path = "/repos/{owner}/{repo}/pulls";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
 if (head != null) queryParams.Add("head", ApiClient.ParameterToString(head)); // query parameter
 if (_base != null) queryParams.Add("base", ApiClient.ParameterToString(_base)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsList: " + response.ErrorMessage, response.ErrorMessage);

            return (List<PullRequestSimple>) ApiClient.Deserialize(response.Content, typeof(List<PullRequestSimple>), response.Headers);
        }

        /// <summary>
        /// List comments for a pull request review List comments for a specific pull request review.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="reviewId">The unique identifier of the review.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;LegacyReviewComment&gt;</returns>
        public List<LegacyReviewComment> PullsListCommentsForReview (string owner, string repo, int? pullNumber, int? reviewId, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsListCommentsForReview");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsListCommentsForReview");
            
            // verify the required parameter 'pullNumber' is set
            if (pullNumber == null) throw new ApiException(400, "Missing required parameter 'pullNumber' when calling PullsListCommentsForReview");
            
            // verify the required parameter 'reviewId' is set
            if (reviewId == null) throw new ApiException(400, "Missing required parameter 'reviewId' when calling PullsListCommentsForReview");
            

            var path = "/repos/{owner}/{repo}/pulls/{pull_number}/reviews/{review_id}/comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "pull_number" + "}", ApiClient.ParameterToString(pullNumber));
path = path.Replace("{" + "review_id" + "}", ApiClient.ParameterToString(reviewId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsListCommentsForReview: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsListCommentsForReview: " + response.ErrorMessage, response.ErrorMessage);

            return (List<LegacyReviewComment>) ApiClient.Deserialize(response.Content, typeof(List<LegacyReviewComment>), response.Headers);
        }

        /// <summary>
        /// List commits on a pull request Lists a maximum of 250 commits for a pull request. To receive a complete commit list for pull requests with more than 250 commits, use the [List commits](https://docs.github.com/rest/reference/repos#list-commits) endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Commit&gt;</returns>
        public List<Commit> PullsListCommits (string owner, string repo, int? pullNumber, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsListCommits");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsListCommits");
            
            // verify the required parameter 'pullNumber' is set
            if (pullNumber == null) throw new ApiException(400, "Missing required parameter 'pullNumber' when calling PullsListCommits");
            

            var path = "/repos/{owner}/{repo}/pulls/{pull_number}/commits";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "pull_number" + "}", ApiClient.ParameterToString(pullNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsListCommits: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsListCommits: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Commit>) ApiClient.Deserialize(response.Content, typeof(List<Commit>), response.Headers);
        }

        /// <summary>
        /// List pull requests files **Note:** Responses include a maximum of 3000 files. The paginated response returns 30 files per page by default.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;DiffEntry&gt;</returns>
        public List<DiffEntry> PullsListFiles (string owner, string repo, int? pullNumber, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsListFiles");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsListFiles");
            
            // verify the required parameter 'pullNumber' is set
            if (pullNumber == null) throw new ApiException(400, "Missing required parameter 'pullNumber' when calling PullsListFiles");
            

            var path = "/repos/{owner}/{repo}/pulls/{pull_number}/files";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "pull_number" + "}", ApiClient.ParameterToString(pullNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsListFiles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsListFiles: " + response.ErrorMessage, response.ErrorMessage);

            return (List<DiffEntry>) ApiClient.Deserialize(response.Content, typeof(List<DiffEntry>), response.Headers);
        }

        /// <summary>
        /// Get all requested reviewers for a pull request Gets the users or teams whose review is requested for a pull request. Once a requested reviewer submits a review, they are no longer considered a requested reviewer. Their review will instead be returned by the [List reviews for a pull request](https://docs.github.com/rest/pulls/reviews#list-reviews-for-a-pull-request) operation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <returns>PullRequestReviewRequest</returns>
        public PullRequestReviewRequest PullsListRequestedReviewers (string owner, string repo, int? pullNumber)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsListRequestedReviewers");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsListRequestedReviewers");
            
            // verify the required parameter 'pullNumber' is set
            if (pullNumber == null) throw new ApiException(400, "Missing required parameter 'pullNumber' when calling PullsListRequestedReviewers");
            

            var path = "/repos/{owner}/{repo}/pulls/{pull_number}/requested_reviewers";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "pull_number" + "}", ApiClient.ParameterToString(pullNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsListRequestedReviewers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsListRequestedReviewers: " + response.ErrorMessage, response.ErrorMessage);

            return (PullRequestReviewRequest) ApiClient.Deserialize(response.Content, typeof(PullRequestReviewRequest), response.Headers);
        }

        /// <summary>
        /// List review comments on a pull request Lists all review comments for a pull request. By default, review comments are in ascending order by ID.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="sort">The property to sort the results by. &#x60;created&#x60; means when the repository was starred. &#x60;updated&#x60; means when the repository was last pushed to.</param>
        /// <param name="direction">Can be either &#x60;asc&#x60; or &#x60;desc&#x60;. Ignored without &#x60;sort&#x60; parameter.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;PullRequestReviewComment&gt;</returns>
        public List<PullRequestReviewComment> PullsListReviewComments (string owner, string repo, int? pullNumber, string sort, string direction, DateTime? since, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsListReviewComments");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsListReviewComments");
            
            // verify the required parameter 'pullNumber' is set
            if (pullNumber == null) throw new ApiException(400, "Missing required parameter 'pullNumber' when calling PullsListReviewComments");
            

            var path = "/repos/{owner}/{repo}/pulls/{pull_number}/comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "pull_number" + "}", ApiClient.ParameterToString(pullNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsListReviewComments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsListReviewComments: " + response.ErrorMessage, response.ErrorMessage);

            return (List<PullRequestReviewComment>) ApiClient.Deserialize(response.Content, typeof(List<PullRequestReviewComment>), response.Headers);
        }

        /// <summary>
        /// List review comments in a repository Lists review comments for all pull requests in a repository. By default, review comments are in ascending order by ID.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="sort"></param>
        /// <param name="direction">Can be either &#x60;asc&#x60; or &#x60;desc&#x60;. Ignored without &#x60;sort&#x60; parameter.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;PullRequestReviewComment&gt;</returns>
        public List<PullRequestReviewComment> PullsListReviewCommentsForRepo (string owner, string repo, string sort, string direction, DateTime? since, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsListReviewCommentsForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsListReviewCommentsForRepo");
            

            var path = "/repos/{owner}/{repo}/pulls/comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsListReviewCommentsForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsListReviewCommentsForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (List<PullRequestReviewComment>) ApiClient.Deserialize(response.Content, typeof(List<PullRequestReviewComment>), response.Headers);
        }

        /// <summary>
        /// List reviews for a pull request The list of reviews returns in chronological order.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;PullRequestReview&gt;</returns>
        public List<PullRequestReview> PullsListReviews (string owner, string repo, int? pullNumber, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsListReviews");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsListReviews");
            
            // verify the required parameter 'pullNumber' is set
            if (pullNumber == null) throw new ApiException(400, "Missing required parameter 'pullNumber' when calling PullsListReviews");
            

            var path = "/repos/{owner}/{repo}/pulls/{pull_number}/reviews";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "pull_number" + "}", ApiClient.ParameterToString(pullNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsListReviews: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsListReviews: " + response.ErrorMessage, response.ErrorMessage);

            return (List<PullRequestReview>) ApiClient.Deserialize(response.Content, typeof(List<PullRequestReview>), response.Headers);
        }

        /// <summary>
        /// Merge a pull request This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="pullsMergeRequest"></param>
        /// <returns>PullRequestMergeResult</returns>
        public PullRequestMergeResult PullsMerge (string owner, string repo, int? pullNumber, PullsMergeRequest pullsMergeRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsMerge");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsMerge");
            
            // verify the required parameter 'pullNumber' is set
            if (pullNumber == null) throw new ApiException(400, "Missing required parameter 'pullNumber' when calling PullsMerge");
            

            var path = "/repos/{owner}/{repo}/pulls/{pull_number}/merge";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "pull_number" + "}", ApiClient.ParameterToString(pullNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(pullsMergeRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsMerge: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsMerge: " + response.ErrorMessage, response.ErrorMessage);

            return (PullRequestMergeResult) ApiClient.Deserialize(response.Content, typeof(PullRequestMergeResult), response.Headers);
        }

        /// <summary>
        /// Remove requested reviewers from a pull request 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="pullsRemoveRequestedReviewersRequest"></param>
        /// <returns>PullRequestSimple</returns>
        public PullRequestSimple PullsRemoveRequestedReviewers (string owner, string repo, int? pullNumber, PullsRemoveRequestedReviewersRequest pullsRemoveRequestedReviewersRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsRemoveRequestedReviewers");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsRemoveRequestedReviewers");
            
            // verify the required parameter 'pullNumber' is set
            if (pullNumber == null) throw new ApiException(400, "Missing required parameter 'pullNumber' when calling PullsRemoveRequestedReviewers");
            
            // verify the required parameter 'pullsRemoveRequestedReviewersRequest' is set
            if (pullsRemoveRequestedReviewersRequest == null) throw new ApiException(400, "Missing required parameter 'pullsRemoveRequestedReviewersRequest' when calling PullsRemoveRequestedReviewers");
            

            var path = "/repos/{owner}/{repo}/pulls/{pull_number}/requested_reviewers";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "pull_number" + "}", ApiClient.ParameterToString(pullNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(pullsRemoveRequestedReviewersRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsRemoveRequestedReviewers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsRemoveRequestedReviewers: " + response.ErrorMessage, response.ErrorMessage);

            return (PullRequestSimple) ApiClient.Deserialize(response.Content, typeof(PullRequestSimple), response.Headers);
        }

        /// <summary>
        /// Request reviewers for a pull request This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="pullsRequestReviewersRequest"></param>
        /// <returns>PullRequestSimple</returns>
        public PullRequestSimple PullsRequestReviewers (string owner, string repo, int? pullNumber, PullsRequestReviewersRequest pullsRequestReviewersRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsRequestReviewers");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsRequestReviewers");
            
            // verify the required parameter 'pullNumber' is set
            if (pullNumber == null) throw new ApiException(400, "Missing required parameter 'pullNumber' when calling PullsRequestReviewers");
            

            var path = "/repos/{owner}/{repo}/pulls/{pull_number}/requested_reviewers";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "pull_number" + "}", ApiClient.ParameterToString(pullNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(pullsRequestReviewersRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsRequestReviewers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsRequestReviewers: " + response.ErrorMessage, response.ErrorMessage);

            return (PullRequestSimple) ApiClient.Deserialize(response.Content, typeof(PullRequestSimple), response.Headers);
        }

        /// <summary>
        /// Submit a review for a pull request 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="reviewId">The unique identifier of the review.</param>
        /// <param name="pullsSubmitReviewRequest"></param>
        /// <returns>PullRequestReview</returns>
        public PullRequestReview PullsSubmitReview (string owner, string repo, int? pullNumber, int? reviewId, PullsSubmitReviewRequest pullsSubmitReviewRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsSubmitReview");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsSubmitReview");
            
            // verify the required parameter 'pullNumber' is set
            if (pullNumber == null) throw new ApiException(400, "Missing required parameter 'pullNumber' when calling PullsSubmitReview");
            
            // verify the required parameter 'reviewId' is set
            if (reviewId == null) throw new ApiException(400, "Missing required parameter 'reviewId' when calling PullsSubmitReview");
            
            // verify the required parameter 'pullsSubmitReviewRequest' is set
            if (pullsSubmitReviewRequest == null) throw new ApiException(400, "Missing required parameter 'pullsSubmitReviewRequest' when calling PullsSubmitReview");
            

            var path = "/repos/{owner}/{repo}/pulls/{pull_number}/reviews/{review_id}/events";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "pull_number" + "}", ApiClient.ParameterToString(pullNumber));
path = path.Replace("{" + "review_id" + "}", ApiClient.ParameterToString(reviewId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(pullsSubmitReviewRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsSubmitReview: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsSubmitReview: " + response.ErrorMessage, response.ErrorMessage);

            return (PullRequestReview) ApiClient.Deserialize(response.Content, typeof(PullRequestReview), response.Headers);
        }

        /// <summary>
        /// Update a pull request Draft pull requests are available in public repositories with GitHub Free and GitHub Free for organizations, GitHub Pro, and legacy per-repository billing plans, and in public and private repositories with GitHub Team and GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  To open or update a pull request in a public repository, you must have write access to the head or the source branch. For organization-owned repositories, you must be a member of the organization that owns the repository to open or update a pull request.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="pullsUpdateRequest"></param>
        /// <returns>PullRequest</returns>
        public PullRequest PullsUpdate (string owner, string repo, int? pullNumber, PullsUpdateRequest pullsUpdateRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsUpdate");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsUpdate");
            
            // verify the required parameter 'pullNumber' is set
            if (pullNumber == null) throw new ApiException(400, "Missing required parameter 'pullNumber' when calling PullsUpdate");
            

            var path = "/repos/{owner}/{repo}/pulls/{pull_number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "pull_number" + "}", ApiClient.ParameterToString(pullNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(pullsUpdateRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsUpdate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsUpdate: " + response.ErrorMessage, response.ErrorMessage);

            return (PullRequest) ApiClient.Deserialize(response.Content, typeof(PullRequest), response.Headers);
        }

        /// <summary>
        /// Update a pull request branch Updates the pull request branch with the latest upstream changes by merging HEAD from the base branch into the pull request branch.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="pullsUpdateBranchRequest"></param>
        /// <returns>ActivityMarkRepoNotificationsAsRead202Response</returns>
        public ActivityMarkRepoNotificationsAsRead202Response PullsUpdateBranch (string owner, string repo, int? pullNumber, PullsUpdateBranchRequest pullsUpdateBranchRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsUpdateBranch");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsUpdateBranch");
            
            // verify the required parameter 'pullNumber' is set
            if (pullNumber == null) throw new ApiException(400, "Missing required parameter 'pullNumber' when calling PullsUpdateBranch");
            

            var path = "/repos/{owner}/{repo}/pulls/{pull_number}/update-branch";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "pull_number" + "}", ApiClient.ParameterToString(pullNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(pullsUpdateBranchRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsUpdateBranch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsUpdateBranch: " + response.ErrorMessage, response.ErrorMessage);

            return (ActivityMarkRepoNotificationsAsRead202Response) ApiClient.Deserialize(response.Content, typeof(ActivityMarkRepoNotificationsAsRead202Response), response.Headers);
        }

        /// <summary>
        /// Update a review for a pull request Update the review summary comment with new text.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="reviewId">The unique identifier of the review.</param>
        /// <param name="pullsUpdateReviewRequest"></param>
        /// <returns>PullRequestReview</returns>
        public PullRequestReview PullsUpdateReview (string owner, string repo, int? pullNumber, int? reviewId, PullsUpdateReviewRequest pullsUpdateReviewRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsUpdateReview");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsUpdateReview");
            
            // verify the required parameter 'pullNumber' is set
            if (pullNumber == null) throw new ApiException(400, "Missing required parameter 'pullNumber' when calling PullsUpdateReview");
            
            // verify the required parameter 'reviewId' is set
            if (reviewId == null) throw new ApiException(400, "Missing required parameter 'reviewId' when calling PullsUpdateReview");
            
            // verify the required parameter 'pullsUpdateReviewRequest' is set
            if (pullsUpdateReviewRequest == null) throw new ApiException(400, "Missing required parameter 'pullsUpdateReviewRequest' when calling PullsUpdateReview");
            

            var path = "/repos/{owner}/{repo}/pulls/{pull_number}/reviews/{review_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "pull_number" + "}", ApiClient.ParameterToString(pullNumber));
path = path.Replace("{" + "review_id" + "}", ApiClient.ParameterToString(reviewId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(pullsUpdateReviewRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsUpdateReview: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsUpdateReview: " + response.ErrorMessage, response.ErrorMessage);

            return (PullRequestReview) ApiClient.Deserialize(response.Content, typeof(PullRequestReview), response.Headers);
        }

        /// <summary>
        /// Update a review comment for a pull request Enables you to edit a review comment.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="pullsUpdateReviewCommentRequest"></param>
        /// <returns>PullRequestReviewComment</returns>
        public PullRequestReviewComment PullsUpdateReviewComment (string owner, string repo, int? commentId, PullsUpdateReviewCommentRequest pullsUpdateReviewCommentRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling PullsUpdateReviewComment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling PullsUpdateReviewComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling PullsUpdateReviewComment");
            
            // verify the required parameter 'pullsUpdateReviewCommentRequest' is set
            if (pullsUpdateReviewCommentRequest == null) throw new ApiException(400, "Missing required parameter 'pullsUpdateReviewCommentRequest' when calling PullsUpdateReviewComment");
            

            var path = "/repos/{owner}/{repo}/pulls/comments/{comment_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "comment_id" + "}", ApiClient.ParameterToString(commentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(pullsUpdateReviewCommentRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsUpdateReviewComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PullsUpdateReviewComment: " + response.ErrorMessage, response.ErrorMessage);

            return (PullRequestReviewComment) ApiClient.Deserialize(response.Content, typeof(PullRequestReviewComment), response.Headers);
        }

    }
}
