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
    public interface IReactionsApi
    {
        /// <summary>
        /// Create reaction for a commit comment Create a reaction to a [commit comment](https://docs.github.com/rest/reference/repos#comments). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this commit comment.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="reactionsCreateForCommitCommentRequest"></param>
        /// <returns>Reaction</returns>
        Reaction ReactionsCreateForCommitComment (string owner, string repo, int? commentId, ReactionsCreateForCommitCommentRequest reactionsCreateForCommitCommentRequest);
        /// <summary>
        /// Create reaction for an issue Create a reaction to an [issue](https://docs.github.com/rest/reference/issues/). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this issue.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="reactionsCreateForIssueRequest"></param>
        /// <returns>Reaction</returns>
        Reaction ReactionsCreateForIssue (string owner, string repo, int? issueNumber, ReactionsCreateForIssueRequest reactionsCreateForIssueRequest);
        /// <summary>
        /// Create reaction for an issue comment Create a reaction to an [issue comment](https://docs.github.com/rest/reference/issues#comments). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this issue comment.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="reactionsCreateForIssueCommentRequest"></param>
        /// <returns>Reaction</returns>
        Reaction ReactionsCreateForIssueComment (string owner, string repo, int? commentId, ReactionsCreateForIssueCommentRequest reactionsCreateForIssueCommentRequest);
        /// <summary>
        /// Create reaction for a pull request review comment Create a reaction to a [pull request review comment](https://docs.github.com/rest/reference/pulls#comments). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this pull request review comment.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="reactionsCreateForPullRequestReviewCommentRequest"></param>
        /// <returns>Reaction</returns>
        Reaction ReactionsCreateForPullRequestReviewComment (string owner, string repo, int? commentId, ReactionsCreateForPullRequestReviewCommentRequest reactionsCreateForPullRequestReviewCommentRequest);
        /// <summary>
        /// Create reaction for a release Create a reaction to a [release](https://docs.github.com/rest/reference/repos#releases). A response with a &#x60;Status: 200 OK&#x60; means that you already added the reaction type to this release.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="releaseId">The unique identifier of the release.</param>
        /// <param name="reactionsCreateForReleaseRequest"></param>
        /// <returns>Reaction</returns>
        Reaction ReactionsCreateForRelease (string owner, string repo, int? releaseId, ReactionsCreateForReleaseRequest reactionsCreateForReleaseRequest);
        /// <summary>
        /// Create reaction for a team discussion comment Create a reaction to a [team discussion comment](https://docs.github.com/rest/reference/teams#discussion-comments). OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this team discussion comment.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;POST /organizations/:org_id/team/:team_id/discussions/:discussion_number/comments/:comment_number/reactions&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="commentNumber">The number that identifies the comment.</param>
        /// <param name="reactionsCreateForTeamDiscussionCommentInOrgRequest"></param>
        /// <returns>Reaction</returns>
        Reaction ReactionsCreateForTeamDiscussionCommentInOrg (string org, string teamSlug, int? discussionNumber, int? commentNumber, ReactionsCreateForTeamDiscussionCommentInOrgRequest reactionsCreateForTeamDiscussionCommentInOrgRequest);
        /// <summary>
        /// Create reaction for a team discussion comment (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new \&quot;[Create reaction for a team discussion comment](https://docs.github.com/rest/reference/reactions#create-reaction-for-a-team-discussion-comment)\&quot; endpoint.  Create a reaction to a [team discussion comment](https://docs.github.com/rest/reference/teams#discussion-comments). OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this team discussion comment.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="commentNumber">The number that identifies the comment.</param>
        /// <param name="reactionsCreateForTeamDiscussionCommentInOrgRequest"></param>
        /// <returns>Reaction</returns>
        [Obsolete]
        Reaction ReactionsCreateForTeamDiscussionCommentLegacy (int? teamId, int? discussionNumber, int? commentNumber, ReactionsCreateForTeamDiscussionCommentInOrgRequest reactionsCreateForTeamDiscussionCommentInOrgRequest);
        /// <summary>
        /// Create reaction for a team discussion Create a reaction to a [team discussion](https://docs.github.com/rest/reference/teams#discussions). OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this team discussion.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;POST /organizations/:org_id/team/:team_id/discussions/:discussion_number/reactions&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="reactionsCreateForTeamDiscussionInOrgRequest"></param>
        /// <returns>Reaction</returns>
        Reaction ReactionsCreateForTeamDiscussionInOrg (string org, string teamSlug, int? discussionNumber, ReactionsCreateForTeamDiscussionInOrgRequest reactionsCreateForTeamDiscussionInOrgRequest);
        /// <summary>
        /// Create reaction for a team discussion (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;Create reaction for a team discussion&#x60;](https://docs.github.com/rest/reference/reactions#create-reaction-for-a-team-discussion) endpoint.  Create a reaction to a [team discussion](https://docs.github.com/rest/reference/teams#discussions). OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this team discussion.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="reactionsCreateForTeamDiscussionInOrgRequest"></param>
        /// <returns>Reaction</returns>
        [Obsolete]
        Reaction ReactionsCreateForTeamDiscussionLegacy (int? teamId, int? discussionNumber, ReactionsCreateForTeamDiscussionInOrgRequest reactionsCreateForTeamDiscussionInOrgRequest);
        /// <summary>
        /// Delete a commit comment reaction **Note:** You can also specify a repository by &#x60;repository_id&#x60; using the route &#x60;DELETE /repositories/:repository_id/comments/:comment_id/reactions/:reaction_id&#x60;.  Delete a reaction to a [commit comment](https://docs.github.com/rest/reference/repos#comments).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="reactionId">The unique identifier of the reaction.</param>
        /// <returns></returns>
        void ReactionsDeleteForCommitComment (string owner, string repo, int? commentId, int? reactionId);
        /// <summary>
        /// Delete an issue reaction **Note:** You can also specify a repository by &#x60;repository_id&#x60; using the route &#x60;DELETE /repositories/:repository_id/issues/:issue_number/reactions/:reaction_id&#x60;.  Delete a reaction to an [issue](https://docs.github.com/rest/reference/issues/).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="reactionId">The unique identifier of the reaction.</param>
        /// <returns></returns>
        void ReactionsDeleteForIssue (string owner, string repo, int? issueNumber, int? reactionId);
        /// <summary>
        /// Delete an issue comment reaction **Note:** You can also specify a repository by &#x60;repository_id&#x60; using the route &#x60;DELETE delete /repositories/:repository_id/issues/comments/:comment_id/reactions/:reaction_id&#x60;.  Delete a reaction to an [issue comment](https://docs.github.com/rest/reference/issues#comments).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="reactionId">The unique identifier of the reaction.</param>
        /// <returns></returns>
        void ReactionsDeleteForIssueComment (string owner, string repo, int? commentId, int? reactionId);
        /// <summary>
        /// Delete a pull request comment reaction **Note:** You can also specify a repository by &#x60;repository_id&#x60; using the route &#x60;DELETE /repositories/:repository_id/pulls/comments/:comment_id/reactions/:reaction_id.&#x60;  Delete a reaction to a [pull request review comment](https://docs.github.com/rest/reference/pulls#review-comments).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="reactionId">The unique identifier of the reaction.</param>
        /// <returns></returns>
        void ReactionsDeleteForPullRequestComment (string owner, string repo, int? commentId, int? reactionId);
        /// <summary>
        /// Delete a release reaction **Note:** You can also specify a repository by &#x60;repository_id&#x60; using the route &#x60;DELETE delete /repositories/:repository_id/releases/:release_id/reactions/:reaction_id&#x60;.  Delete a reaction to a [release](https://docs.github.com/rest/reference/repos#releases).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="releaseId">The unique identifier of the release.</param>
        /// <param name="reactionId">The unique identifier of the reaction.</param>
        /// <returns></returns>
        void ReactionsDeleteForRelease (string owner, string repo, int? releaseId, int? reactionId);
        /// <summary>
        /// Delete team discussion reaction **Note:** You can also specify a team or organization with &#x60;team_id&#x60; and &#x60;org_id&#x60; using the route &#x60;DELETE /organizations/:org_id/team/:team_id/discussions/:discussion_number/reactions/:reaction_id&#x60;.  Delete a reaction to a [team discussion](https://docs.github.com/rest/reference/teams#discussions). OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="reactionId">The unique identifier of the reaction.</param>
        /// <returns></returns>
        void ReactionsDeleteForTeamDiscussion (string org, string teamSlug, int? discussionNumber, int? reactionId);
        /// <summary>
        /// Delete team discussion comment reaction **Note:** You can also specify a team or organization with &#x60;team_id&#x60; and &#x60;org_id&#x60; using the route &#x60;DELETE /organizations/:org_id/team/:team_id/discussions/:discussion_number/comments/:comment_number/reactions/:reaction_id&#x60;.  Delete a reaction to a [team discussion comment](https://docs.github.com/rest/reference/teams#discussion-comments). OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="commentNumber">The number that identifies the comment.</param>
        /// <param name="reactionId">The unique identifier of the reaction.</param>
        /// <returns></returns>
        void ReactionsDeleteForTeamDiscussionComment (string org, string teamSlug, int? discussionNumber, int? commentNumber, int? reactionId);
        /// <summary>
        /// List reactions for a commit comment List the reactions to a [commit comment](https://docs.github.com/rest/reference/repos#comments).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="content">Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a commit comment.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Reaction&gt;</returns>
        List<Reaction> ReactionsListForCommitComment (string owner, string repo, int? commentId, string content, int? perPage, int? page);
        /// <summary>
        /// List reactions for an issue List the reactions to an [issue](https://docs.github.com/rest/reference/issues).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="content">Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to an issue.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Reaction&gt;</returns>
        List<Reaction> ReactionsListForIssue (string owner, string repo, int? issueNumber, string content, int? perPage, int? page);
        /// <summary>
        /// List reactions for an issue comment List the reactions to an [issue comment](https://docs.github.com/rest/reference/issues#comments).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="content">Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to an issue comment.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Reaction&gt;</returns>
        List<Reaction> ReactionsListForIssueComment (string owner, string repo, int? commentId, string content, int? perPage, int? page);
        /// <summary>
        /// List reactions for a pull request review comment List the reactions to a [pull request review comment](https://docs.github.com/rest/reference/pulls#review-comments).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="content">Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a pull request review comment.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Reaction&gt;</returns>
        List<Reaction> ReactionsListForPullRequestReviewComment (string owner, string repo, int? commentId, string content, int? perPage, int? page);
        /// <summary>
        /// List reactions for a release List the reactions to a [release](https://docs.github.com/rest/reference/repos#releases).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="releaseId">The unique identifier of the release.</param>
        /// <param name="content">Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a release.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Reaction&gt;</returns>
        List<Reaction> ReactionsListForRelease (string owner, string repo, int? releaseId, string content, int? perPage, int? page);
        /// <summary>
        /// List reactions for a team discussion comment List the reactions to a [team discussion comment](https://docs.github.com/rest/reference/teams#discussion-comments/). OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/:org_id/team/:team_id/discussions/:discussion_number/comments/:comment_number/reactions&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="commentNumber">The number that identifies the comment.</param>
        /// <param name="content">Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a team discussion comment.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Reaction&gt;</returns>
        List<Reaction> ReactionsListForTeamDiscussionCommentInOrg (string org, string teamSlug, int? discussionNumber, int? commentNumber, string content, int? perPage, int? page);
        /// <summary>
        /// List reactions for a team discussion comment (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;List reactions for a team discussion comment&#x60;](https://docs.github.com/rest/reference/reactions#list-reactions-for-a-team-discussion-comment) endpoint.  List the reactions to a [team discussion comment](https://docs.github.com/rest/reference/teams#discussion-comments). OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="commentNumber">The number that identifies the comment.</param>
        /// <param name="content">Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a team discussion comment.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Reaction&gt;</returns>
        [Obsolete]
        List<Reaction> ReactionsListForTeamDiscussionCommentLegacy (int? teamId, int? discussionNumber, int? commentNumber, string content, int? perPage, int? page);
        /// <summary>
        /// List reactions for a team discussion List the reactions to a [team discussion](https://docs.github.com/rest/reference/teams#discussions). OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/:org_id/team/:team_id/discussions/:discussion_number/reactions&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="content">Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a team discussion.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Reaction&gt;</returns>
        List<Reaction> ReactionsListForTeamDiscussionInOrg (string org, string teamSlug, int? discussionNumber, string content, int? perPage, int? page);
        /// <summary>
        /// List reactions for a team discussion (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;List reactions for a team discussion&#x60;](https://docs.github.com/rest/reference/reactions#list-reactions-for-a-team-discussion) endpoint.  List the reactions to a [team discussion](https://docs.github.com/rest/reference/teams#discussions). OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="content">Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a team discussion.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Reaction&gt;</returns>
        [Obsolete]
        List<Reaction> ReactionsListForTeamDiscussionLegacy (int? teamId, int? discussionNumber, string content, int? perPage, int? page);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReactionsApi : IReactionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReactionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReactionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReactionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReactionsApi(String basePath)
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
        /// Create reaction for a commit comment Create a reaction to a [commit comment](https://docs.github.com/rest/reference/repos#comments). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this commit comment.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="reactionsCreateForCommitCommentRequest"></param>
        /// <returns>Reaction</returns>
        public Reaction ReactionsCreateForCommitComment (string owner, string repo, int? commentId, ReactionsCreateForCommitCommentRequest reactionsCreateForCommitCommentRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReactionsCreateForCommitComment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReactionsCreateForCommitComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling ReactionsCreateForCommitComment");
            
            // verify the required parameter 'reactionsCreateForCommitCommentRequest' is set
            if (reactionsCreateForCommitCommentRequest == null) throw new ApiException(400, "Missing required parameter 'reactionsCreateForCommitCommentRequest' when calling ReactionsCreateForCommitComment");
            

            var path = "/repos/{owner}/{repo}/comments/{comment_id}/reactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "comment_id" + "}", ApiClient.ParameterToString(commentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reactionsCreateForCommitCommentRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsCreateForCommitComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsCreateForCommitComment: " + response.ErrorMessage, response.ErrorMessage);

            return (Reaction) ApiClient.Deserialize(response.Content, typeof(Reaction), response.Headers);
        }

        /// <summary>
        /// Create reaction for an issue Create a reaction to an [issue](https://docs.github.com/rest/reference/issues/). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this issue.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="reactionsCreateForIssueRequest"></param>
        /// <returns>Reaction</returns>
        public Reaction ReactionsCreateForIssue (string owner, string repo, int? issueNumber, ReactionsCreateForIssueRequest reactionsCreateForIssueRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReactionsCreateForIssue");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReactionsCreateForIssue");
            
            // verify the required parameter 'issueNumber' is set
            if (issueNumber == null) throw new ApiException(400, "Missing required parameter 'issueNumber' when calling ReactionsCreateForIssue");
            
            // verify the required parameter 'reactionsCreateForIssueRequest' is set
            if (reactionsCreateForIssueRequest == null) throw new ApiException(400, "Missing required parameter 'reactionsCreateForIssueRequest' when calling ReactionsCreateForIssue");
            

            var path = "/repos/{owner}/{repo}/issues/{issue_number}/reactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "issue_number" + "}", ApiClient.ParameterToString(issueNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reactionsCreateForIssueRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsCreateForIssue: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsCreateForIssue: " + response.ErrorMessage, response.ErrorMessage);

            return (Reaction) ApiClient.Deserialize(response.Content, typeof(Reaction), response.Headers);
        }

        /// <summary>
        /// Create reaction for an issue comment Create a reaction to an [issue comment](https://docs.github.com/rest/reference/issues#comments). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this issue comment.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="reactionsCreateForIssueCommentRequest"></param>
        /// <returns>Reaction</returns>
        public Reaction ReactionsCreateForIssueComment (string owner, string repo, int? commentId, ReactionsCreateForIssueCommentRequest reactionsCreateForIssueCommentRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReactionsCreateForIssueComment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReactionsCreateForIssueComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling ReactionsCreateForIssueComment");
            
            // verify the required parameter 'reactionsCreateForIssueCommentRequest' is set
            if (reactionsCreateForIssueCommentRequest == null) throw new ApiException(400, "Missing required parameter 'reactionsCreateForIssueCommentRequest' when calling ReactionsCreateForIssueComment");
            

            var path = "/repos/{owner}/{repo}/issues/comments/{comment_id}/reactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "comment_id" + "}", ApiClient.ParameterToString(commentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reactionsCreateForIssueCommentRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsCreateForIssueComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsCreateForIssueComment: " + response.ErrorMessage, response.ErrorMessage);

            return (Reaction) ApiClient.Deserialize(response.Content, typeof(Reaction), response.Headers);
        }

        /// <summary>
        /// Create reaction for a pull request review comment Create a reaction to a [pull request review comment](https://docs.github.com/rest/reference/pulls#comments). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this pull request review comment.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="reactionsCreateForPullRequestReviewCommentRequest"></param>
        /// <returns>Reaction</returns>
        public Reaction ReactionsCreateForPullRequestReviewComment (string owner, string repo, int? commentId, ReactionsCreateForPullRequestReviewCommentRequest reactionsCreateForPullRequestReviewCommentRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReactionsCreateForPullRequestReviewComment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReactionsCreateForPullRequestReviewComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling ReactionsCreateForPullRequestReviewComment");
            
            // verify the required parameter 'reactionsCreateForPullRequestReviewCommentRequest' is set
            if (reactionsCreateForPullRequestReviewCommentRequest == null) throw new ApiException(400, "Missing required parameter 'reactionsCreateForPullRequestReviewCommentRequest' when calling ReactionsCreateForPullRequestReviewComment");
            

            var path = "/repos/{owner}/{repo}/pulls/comments/{comment_id}/reactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "comment_id" + "}", ApiClient.ParameterToString(commentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reactionsCreateForPullRequestReviewCommentRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsCreateForPullRequestReviewComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsCreateForPullRequestReviewComment: " + response.ErrorMessage, response.ErrorMessage);

            return (Reaction) ApiClient.Deserialize(response.Content, typeof(Reaction), response.Headers);
        }

        /// <summary>
        /// Create reaction for a release Create a reaction to a [release](https://docs.github.com/rest/reference/repos#releases). A response with a &#x60;Status: 200 OK&#x60; means that you already added the reaction type to this release.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="releaseId">The unique identifier of the release.</param>
        /// <param name="reactionsCreateForReleaseRequest"></param>
        /// <returns>Reaction</returns>
        public Reaction ReactionsCreateForRelease (string owner, string repo, int? releaseId, ReactionsCreateForReleaseRequest reactionsCreateForReleaseRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReactionsCreateForRelease");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReactionsCreateForRelease");
            
            // verify the required parameter 'releaseId' is set
            if (releaseId == null) throw new ApiException(400, "Missing required parameter 'releaseId' when calling ReactionsCreateForRelease");
            
            // verify the required parameter 'reactionsCreateForReleaseRequest' is set
            if (reactionsCreateForReleaseRequest == null) throw new ApiException(400, "Missing required parameter 'reactionsCreateForReleaseRequest' when calling ReactionsCreateForRelease");
            

            var path = "/repos/{owner}/{repo}/releases/{release_id}/reactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "release_id" + "}", ApiClient.ParameterToString(releaseId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reactionsCreateForReleaseRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsCreateForRelease: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsCreateForRelease: " + response.ErrorMessage, response.ErrorMessage);

            return (Reaction) ApiClient.Deserialize(response.Content, typeof(Reaction), response.Headers);
        }

        /// <summary>
        /// Create reaction for a team discussion comment Create a reaction to a [team discussion comment](https://docs.github.com/rest/reference/teams#discussion-comments). OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this team discussion comment.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;POST /organizations/:org_id/team/:team_id/discussions/:discussion_number/comments/:comment_number/reactions&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="commentNumber">The number that identifies the comment.</param>
        /// <param name="reactionsCreateForTeamDiscussionCommentInOrgRequest"></param>
        /// <returns>Reaction</returns>
        public Reaction ReactionsCreateForTeamDiscussionCommentInOrg (string org, string teamSlug, int? discussionNumber, int? commentNumber, ReactionsCreateForTeamDiscussionCommentInOrgRequest reactionsCreateForTeamDiscussionCommentInOrgRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ReactionsCreateForTeamDiscussionCommentInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling ReactionsCreateForTeamDiscussionCommentInOrg");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling ReactionsCreateForTeamDiscussionCommentInOrg");
            
            // verify the required parameter 'commentNumber' is set
            if (commentNumber == null) throw new ApiException(400, "Missing required parameter 'commentNumber' when calling ReactionsCreateForTeamDiscussionCommentInOrg");
            
            // verify the required parameter 'reactionsCreateForTeamDiscussionCommentInOrgRequest' is set
            if (reactionsCreateForTeamDiscussionCommentInOrgRequest == null) throw new ApiException(400, "Missing required parameter 'reactionsCreateForTeamDiscussionCommentInOrgRequest' when calling ReactionsCreateForTeamDiscussionCommentInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/comments/{comment_number}/reactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));
path = path.Replace("{" + "comment_number" + "}", ApiClient.ParameterToString(commentNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reactionsCreateForTeamDiscussionCommentInOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsCreateForTeamDiscussionCommentInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsCreateForTeamDiscussionCommentInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (Reaction) ApiClient.Deserialize(response.Content, typeof(Reaction), response.Headers);
        }

        /// <summary>
        /// Create reaction for a team discussion comment (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new \&quot;[Create reaction for a team discussion comment](https://docs.github.com/rest/reference/reactions#create-reaction-for-a-team-discussion-comment)\&quot; endpoint.  Create a reaction to a [team discussion comment](https://docs.github.com/rest/reference/teams#discussion-comments). OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this team discussion comment.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="commentNumber">The number that identifies the comment.</param>
        /// <param name="reactionsCreateForTeamDiscussionCommentInOrgRequest"></param>
        /// <returns>Reaction</returns>
        [Obsolete]
        public Reaction ReactionsCreateForTeamDiscussionCommentLegacy (int? teamId, int? discussionNumber, int? commentNumber, ReactionsCreateForTeamDiscussionCommentInOrgRequest reactionsCreateForTeamDiscussionCommentInOrgRequest)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling ReactionsCreateForTeamDiscussionCommentLegacy");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling ReactionsCreateForTeamDiscussionCommentLegacy");
            
            // verify the required parameter 'commentNumber' is set
            if (commentNumber == null) throw new ApiException(400, "Missing required parameter 'commentNumber' when calling ReactionsCreateForTeamDiscussionCommentLegacy");
            
            // verify the required parameter 'reactionsCreateForTeamDiscussionCommentInOrgRequest' is set
            if (reactionsCreateForTeamDiscussionCommentInOrgRequest == null) throw new ApiException(400, "Missing required parameter 'reactionsCreateForTeamDiscussionCommentInOrgRequest' when calling ReactionsCreateForTeamDiscussionCommentLegacy");
            

            var path = "/teams/{team_id}/discussions/{discussion_number}/comments/{comment_number}/reactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));
path = path.Replace("{" + "comment_number" + "}", ApiClient.ParameterToString(commentNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reactionsCreateForTeamDiscussionCommentInOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsCreateForTeamDiscussionCommentLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsCreateForTeamDiscussionCommentLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (Reaction) ApiClient.Deserialize(response.Content, typeof(Reaction), response.Headers);
        }

        /// <summary>
        /// Create reaction for a team discussion Create a reaction to a [team discussion](https://docs.github.com/rest/reference/teams#discussions). OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this team discussion.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;POST /organizations/:org_id/team/:team_id/discussions/:discussion_number/reactions&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="reactionsCreateForTeamDiscussionInOrgRequest"></param>
        /// <returns>Reaction</returns>
        public Reaction ReactionsCreateForTeamDiscussionInOrg (string org, string teamSlug, int? discussionNumber, ReactionsCreateForTeamDiscussionInOrgRequest reactionsCreateForTeamDiscussionInOrgRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ReactionsCreateForTeamDiscussionInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling ReactionsCreateForTeamDiscussionInOrg");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling ReactionsCreateForTeamDiscussionInOrg");
            
            // verify the required parameter 'reactionsCreateForTeamDiscussionInOrgRequest' is set
            if (reactionsCreateForTeamDiscussionInOrgRequest == null) throw new ApiException(400, "Missing required parameter 'reactionsCreateForTeamDiscussionInOrgRequest' when calling ReactionsCreateForTeamDiscussionInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/reactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reactionsCreateForTeamDiscussionInOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsCreateForTeamDiscussionInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsCreateForTeamDiscussionInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (Reaction) ApiClient.Deserialize(response.Content, typeof(Reaction), response.Headers);
        }

        /// <summary>
        /// Create reaction for a team discussion (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;Create reaction for a team discussion&#x60;](https://docs.github.com/rest/reference/reactions#create-reaction-for-a-team-discussion) endpoint.  Create a reaction to a [team discussion](https://docs.github.com/rest/reference/teams#discussions). OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/). A response with an HTTP &#x60;200&#x60; status means that you already added the reaction type to this team discussion.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="reactionsCreateForTeamDiscussionInOrgRequest"></param>
        /// <returns>Reaction</returns>
        [Obsolete]
        public Reaction ReactionsCreateForTeamDiscussionLegacy (int? teamId, int? discussionNumber, ReactionsCreateForTeamDiscussionInOrgRequest reactionsCreateForTeamDiscussionInOrgRequest)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling ReactionsCreateForTeamDiscussionLegacy");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling ReactionsCreateForTeamDiscussionLegacy");
            
            // verify the required parameter 'reactionsCreateForTeamDiscussionInOrgRequest' is set
            if (reactionsCreateForTeamDiscussionInOrgRequest == null) throw new ApiException(400, "Missing required parameter 'reactionsCreateForTeamDiscussionInOrgRequest' when calling ReactionsCreateForTeamDiscussionLegacy");
            

            var path = "/teams/{team_id}/discussions/{discussion_number}/reactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reactionsCreateForTeamDiscussionInOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsCreateForTeamDiscussionLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsCreateForTeamDiscussionLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (Reaction) ApiClient.Deserialize(response.Content, typeof(Reaction), response.Headers);
        }

        /// <summary>
        /// Delete a commit comment reaction **Note:** You can also specify a repository by &#x60;repository_id&#x60; using the route &#x60;DELETE /repositories/:repository_id/comments/:comment_id/reactions/:reaction_id&#x60;.  Delete a reaction to a [commit comment](https://docs.github.com/rest/reference/repos#comments).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="reactionId">The unique identifier of the reaction.</param>
        /// <returns></returns>
        public void ReactionsDeleteForCommitComment (string owner, string repo, int? commentId, int? reactionId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReactionsDeleteForCommitComment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReactionsDeleteForCommitComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling ReactionsDeleteForCommitComment");
            
            // verify the required parameter 'reactionId' is set
            if (reactionId == null) throw new ApiException(400, "Missing required parameter 'reactionId' when calling ReactionsDeleteForCommitComment");
            

            var path = "/repos/{owner}/{repo}/comments/{comment_id}/reactions/{reaction_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "comment_id" + "}", ApiClient.ParameterToString(commentId));
path = path.Replace("{" + "reaction_id" + "}", ApiClient.ParameterToString(reactionId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsDeleteForCommitComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsDeleteForCommitComment: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete an issue reaction **Note:** You can also specify a repository by &#x60;repository_id&#x60; using the route &#x60;DELETE /repositories/:repository_id/issues/:issue_number/reactions/:reaction_id&#x60;.  Delete a reaction to an [issue](https://docs.github.com/rest/reference/issues/).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="reactionId">The unique identifier of the reaction.</param>
        /// <returns></returns>
        public void ReactionsDeleteForIssue (string owner, string repo, int? issueNumber, int? reactionId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReactionsDeleteForIssue");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReactionsDeleteForIssue");
            
            // verify the required parameter 'issueNumber' is set
            if (issueNumber == null) throw new ApiException(400, "Missing required parameter 'issueNumber' when calling ReactionsDeleteForIssue");
            
            // verify the required parameter 'reactionId' is set
            if (reactionId == null) throw new ApiException(400, "Missing required parameter 'reactionId' when calling ReactionsDeleteForIssue");
            

            var path = "/repos/{owner}/{repo}/issues/{issue_number}/reactions/{reaction_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "issue_number" + "}", ApiClient.ParameterToString(issueNumber));
path = path.Replace("{" + "reaction_id" + "}", ApiClient.ParameterToString(reactionId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsDeleteForIssue: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsDeleteForIssue: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete an issue comment reaction **Note:** You can also specify a repository by &#x60;repository_id&#x60; using the route &#x60;DELETE delete /repositories/:repository_id/issues/comments/:comment_id/reactions/:reaction_id&#x60;.  Delete a reaction to an [issue comment](https://docs.github.com/rest/reference/issues#comments).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="reactionId">The unique identifier of the reaction.</param>
        /// <returns></returns>
        public void ReactionsDeleteForIssueComment (string owner, string repo, int? commentId, int? reactionId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReactionsDeleteForIssueComment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReactionsDeleteForIssueComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling ReactionsDeleteForIssueComment");
            
            // verify the required parameter 'reactionId' is set
            if (reactionId == null) throw new ApiException(400, "Missing required parameter 'reactionId' when calling ReactionsDeleteForIssueComment");
            

            var path = "/repos/{owner}/{repo}/issues/comments/{comment_id}/reactions/{reaction_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "comment_id" + "}", ApiClient.ParameterToString(commentId));
path = path.Replace("{" + "reaction_id" + "}", ApiClient.ParameterToString(reactionId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsDeleteForIssueComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsDeleteForIssueComment: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a pull request comment reaction **Note:** You can also specify a repository by &#x60;repository_id&#x60; using the route &#x60;DELETE /repositories/:repository_id/pulls/comments/:comment_id/reactions/:reaction_id.&#x60;  Delete a reaction to a [pull request review comment](https://docs.github.com/rest/reference/pulls#review-comments).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="reactionId">The unique identifier of the reaction.</param>
        /// <returns></returns>
        public void ReactionsDeleteForPullRequestComment (string owner, string repo, int? commentId, int? reactionId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReactionsDeleteForPullRequestComment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReactionsDeleteForPullRequestComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling ReactionsDeleteForPullRequestComment");
            
            // verify the required parameter 'reactionId' is set
            if (reactionId == null) throw new ApiException(400, "Missing required parameter 'reactionId' when calling ReactionsDeleteForPullRequestComment");
            

            var path = "/repos/{owner}/{repo}/pulls/comments/{comment_id}/reactions/{reaction_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "comment_id" + "}", ApiClient.ParameterToString(commentId));
path = path.Replace("{" + "reaction_id" + "}", ApiClient.ParameterToString(reactionId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsDeleteForPullRequestComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsDeleteForPullRequestComment: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a release reaction **Note:** You can also specify a repository by &#x60;repository_id&#x60; using the route &#x60;DELETE delete /repositories/:repository_id/releases/:release_id/reactions/:reaction_id&#x60;.  Delete a reaction to a [release](https://docs.github.com/rest/reference/repos#releases).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="releaseId">The unique identifier of the release.</param>
        /// <param name="reactionId">The unique identifier of the reaction.</param>
        /// <returns></returns>
        public void ReactionsDeleteForRelease (string owner, string repo, int? releaseId, int? reactionId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReactionsDeleteForRelease");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReactionsDeleteForRelease");
            
            // verify the required parameter 'releaseId' is set
            if (releaseId == null) throw new ApiException(400, "Missing required parameter 'releaseId' when calling ReactionsDeleteForRelease");
            
            // verify the required parameter 'reactionId' is set
            if (reactionId == null) throw new ApiException(400, "Missing required parameter 'reactionId' when calling ReactionsDeleteForRelease");
            

            var path = "/repos/{owner}/{repo}/releases/{release_id}/reactions/{reaction_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "release_id" + "}", ApiClient.ParameterToString(releaseId));
path = path.Replace("{" + "reaction_id" + "}", ApiClient.ParameterToString(reactionId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsDeleteForRelease: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsDeleteForRelease: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete team discussion reaction **Note:** You can also specify a team or organization with &#x60;team_id&#x60; and &#x60;org_id&#x60; using the route &#x60;DELETE /organizations/:org_id/team/:team_id/discussions/:discussion_number/reactions/:reaction_id&#x60;.  Delete a reaction to a [team discussion](https://docs.github.com/rest/reference/teams#discussions). OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="reactionId">The unique identifier of the reaction.</param>
        /// <returns></returns>
        public void ReactionsDeleteForTeamDiscussion (string org, string teamSlug, int? discussionNumber, int? reactionId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ReactionsDeleteForTeamDiscussion");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling ReactionsDeleteForTeamDiscussion");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling ReactionsDeleteForTeamDiscussion");
            
            // verify the required parameter 'reactionId' is set
            if (reactionId == null) throw new ApiException(400, "Missing required parameter 'reactionId' when calling ReactionsDeleteForTeamDiscussion");
            

            var path = "/orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/reactions/{reaction_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));
path = path.Replace("{" + "reaction_id" + "}", ApiClient.ParameterToString(reactionId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsDeleteForTeamDiscussion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsDeleteForTeamDiscussion: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete team discussion comment reaction **Note:** You can also specify a team or organization with &#x60;team_id&#x60; and &#x60;org_id&#x60; using the route &#x60;DELETE /organizations/:org_id/team/:team_id/discussions/:discussion_number/comments/:comment_number/reactions/:reaction_id&#x60;.  Delete a reaction to a [team discussion comment](https://docs.github.com/rest/reference/teams#discussion-comments). OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="commentNumber">The number that identifies the comment.</param>
        /// <param name="reactionId">The unique identifier of the reaction.</param>
        /// <returns></returns>
        public void ReactionsDeleteForTeamDiscussionComment (string org, string teamSlug, int? discussionNumber, int? commentNumber, int? reactionId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ReactionsDeleteForTeamDiscussionComment");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling ReactionsDeleteForTeamDiscussionComment");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling ReactionsDeleteForTeamDiscussionComment");
            
            // verify the required parameter 'commentNumber' is set
            if (commentNumber == null) throw new ApiException(400, "Missing required parameter 'commentNumber' when calling ReactionsDeleteForTeamDiscussionComment");
            
            // verify the required parameter 'reactionId' is set
            if (reactionId == null) throw new ApiException(400, "Missing required parameter 'reactionId' when calling ReactionsDeleteForTeamDiscussionComment");
            

            var path = "/orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/comments/{comment_number}/reactions/{reaction_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));
path = path.Replace("{" + "comment_number" + "}", ApiClient.ParameterToString(commentNumber));
path = path.Replace("{" + "reaction_id" + "}", ApiClient.ParameterToString(reactionId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsDeleteForTeamDiscussionComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsDeleteForTeamDiscussionComment: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// List reactions for a commit comment List the reactions to a [commit comment](https://docs.github.com/rest/reference/repos#comments).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="content">Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a commit comment.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Reaction&gt;</returns>
        public List<Reaction> ReactionsListForCommitComment (string owner, string repo, int? commentId, string content, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReactionsListForCommitComment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReactionsListForCommitComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling ReactionsListForCommitComment");
            

            var path = "/repos/{owner}/{repo}/comments/{comment_id}/reactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "comment_id" + "}", ApiClient.ParameterToString(commentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (content != null) queryParams.Add("content", ApiClient.ParameterToString(content)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsListForCommitComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsListForCommitComment: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Reaction>) ApiClient.Deserialize(response.Content, typeof(List<Reaction>), response.Headers);
        }

        /// <summary>
        /// List reactions for an issue List the reactions to an [issue](https://docs.github.com/rest/reference/issues).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="content">Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to an issue.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Reaction&gt;</returns>
        public List<Reaction> ReactionsListForIssue (string owner, string repo, int? issueNumber, string content, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReactionsListForIssue");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReactionsListForIssue");
            
            // verify the required parameter 'issueNumber' is set
            if (issueNumber == null) throw new ApiException(400, "Missing required parameter 'issueNumber' when calling ReactionsListForIssue");
            

            var path = "/repos/{owner}/{repo}/issues/{issue_number}/reactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "issue_number" + "}", ApiClient.ParameterToString(issueNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (content != null) queryParams.Add("content", ApiClient.ParameterToString(content)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsListForIssue: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsListForIssue: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Reaction>) ApiClient.Deserialize(response.Content, typeof(List<Reaction>), response.Headers);
        }

        /// <summary>
        /// List reactions for an issue comment List the reactions to an [issue comment](https://docs.github.com/rest/reference/issues#comments).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="content">Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to an issue comment.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Reaction&gt;</returns>
        public List<Reaction> ReactionsListForIssueComment (string owner, string repo, int? commentId, string content, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReactionsListForIssueComment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReactionsListForIssueComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling ReactionsListForIssueComment");
            

            var path = "/repos/{owner}/{repo}/issues/comments/{comment_id}/reactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "comment_id" + "}", ApiClient.ParameterToString(commentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (content != null) queryParams.Add("content", ApiClient.ParameterToString(content)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsListForIssueComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsListForIssueComment: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Reaction>) ApiClient.Deserialize(response.Content, typeof(List<Reaction>), response.Headers);
        }

        /// <summary>
        /// List reactions for a pull request review comment List the reactions to a [pull request review comment](https://docs.github.com/rest/reference/pulls#review-comments).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="content">Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a pull request review comment.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Reaction&gt;</returns>
        public List<Reaction> ReactionsListForPullRequestReviewComment (string owner, string repo, int? commentId, string content, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReactionsListForPullRequestReviewComment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReactionsListForPullRequestReviewComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling ReactionsListForPullRequestReviewComment");
            

            var path = "/repos/{owner}/{repo}/pulls/comments/{comment_id}/reactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "comment_id" + "}", ApiClient.ParameterToString(commentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (content != null) queryParams.Add("content", ApiClient.ParameterToString(content)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsListForPullRequestReviewComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsListForPullRequestReviewComment: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Reaction>) ApiClient.Deserialize(response.Content, typeof(List<Reaction>), response.Headers);
        }

        /// <summary>
        /// List reactions for a release List the reactions to a [release](https://docs.github.com/rest/reference/repos#releases).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="releaseId">The unique identifier of the release.</param>
        /// <param name="content">Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a release.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Reaction&gt;</returns>
        public List<Reaction> ReactionsListForRelease (string owner, string repo, int? releaseId, string content, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReactionsListForRelease");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReactionsListForRelease");
            
            // verify the required parameter 'releaseId' is set
            if (releaseId == null) throw new ApiException(400, "Missing required parameter 'releaseId' when calling ReactionsListForRelease");
            

            var path = "/repos/{owner}/{repo}/releases/{release_id}/reactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "release_id" + "}", ApiClient.ParameterToString(releaseId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (content != null) queryParams.Add("content", ApiClient.ParameterToString(content)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsListForRelease: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsListForRelease: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Reaction>) ApiClient.Deserialize(response.Content, typeof(List<Reaction>), response.Headers);
        }

        /// <summary>
        /// List reactions for a team discussion comment List the reactions to a [team discussion comment](https://docs.github.com/rest/reference/teams#discussion-comments/). OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/:org_id/team/:team_id/discussions/:discussion_number/comments/:comment_number/reactions&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="commentNumber">The number that identifies the comment.</param>
        /// <param name="content">Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a team discussion comment.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Reaction&gt;</returns>
        public List<Reaction> ReactionsListForTeamDiscussionCommentInOrg (string org, string teamSlug, int? discussionNumber, int? commentNumber, string content, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ReactionsListForTeamDiscussionCommentInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling ReactionsListForTeamDiscussionCommentInOrg");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling ReactionsListForTeamDiscussionCommentInOrg");
            
            // verify the required parameter 'commentNumber' is set
            if (commentNumber == null) throw new ApiException(400, "Missing required parameter 'commentNumber' when calling ReactionsListForTeamDiscussionCommentInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/comments/{comment_number}/reactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));
path = path.Replace("{" + "comment_number" + "}", ApiClient.ParameterToString(commentNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (content != null) queryParams.Add("content", ApiClient.ParameterToString(content)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsListForTeamDiscussionCommentInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsListForTeamDiscussionCommentInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Reaction>) ApiClient.Deserialize(response.Content, typeof(List<Reaction>), response.Headers);
        }

        /// <summary>
        /// List reactions for a team discussion comment (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;List reactions for a team discussion comment&#x60;](https://docs.github.com/rest/reference/reactions#list-reactions-for-a-team-discussion-comment) endpoint.  List the reactions to a [team discussion comment](https://docs.github.com/rest/reference/teams#discussion-comments). OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="commentNumber">The number that identifies the comment.</param>
        /// <param name="content">Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a team discussion comment.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Reaction&gt;</returns>
        [Obsolete]
        public List<Reaction> ReactionsListForTeamDiscussionCommentLegacy (int? teamId, int? discussionNumber, int? commentNumber, string content, int? perPage, int? page)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling ReactionsListForTeamDiscussionCommentLegacy");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling ReactionsListForTeamDiscussionCommentLegacy");
            
            // verify the required parameter 'commentNumber' is set
            if (commentNumber == null) throw new ApiException(400, "Missing required parameter 'commentNumber' when calling ReactionsListForTeamDiscussionCommentLegacy");
            

            var path = "/teams/{team_id}/discussions/{discussion_number}/comments/{comment_number}/reactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));
path = path.Replace("{" + "comment_number" + "}", ApiClient.ParameterToString(commentNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (content != null) queryParams.Add("content", ApiClient.ParameterToString(content)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsListForTeamDiscussionCommentLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsListForTeamDiscussionCommentLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Reaction>) ApiClient.Deserialize(response.Content, typeof(List<Reaction>), response.Headers);
        }

        /// <summary>
        /// List reactions for a team discussion List the reactions to a [team discussion](https://docs.github.com/rest/reference/teams#discussions). OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/:org_id/team/:team_id/discussions/:discussion_number/reactions&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="content">Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a team discussion.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Reaction&gt;</returns>
        public List<Reaction> ReactionsListForTeamDiscussionInOrg (string org, string teamSlug, int? discussionNumber, string content, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ReactionsListForTeamDiscussionInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling ReactionsListForTeamDiscussionInOrg");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling ReactionsListForTeamDiscussionInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/reactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (content != null) queryParams.Add("content", ApiClient.ParameterToString(content)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsListForTeamDiscussionInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsListForTeamDiscussionInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Reaction>) ApiClient.Deserialize(response.Content, typeof(List<Reaction>), response.Headers);
        }

        /// <summary>
        /// List reactions for a team discussion (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;List reactions for a team discussion&#x60;](https://docs.github.com/rest/reference/reactions#list-reactions-for-a-team-discussion) endpoint.  List the reactions to a [team discussion](https://docs.github.com/rest/reference/teams#discussions). OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="content">Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a team discussion.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Reaction&gt;</returns>
        [Obsolete]
        public List<Reaction> ReactionsListForTeamDiscussionLegacy (int? teamId, int? discussionNumber, string content, int? perPage, int? page)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling ReactionsListForTeamDiscussionLegacy");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling ReactionsListForTeamDiscussionLegacy");
            

            var path = "/teams/{team_id}/discussions/{discussion_number}/reactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (content != null) queryParams.Add("content", ApiClient.ParameterToString(content)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsListForTeamDiscussionLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReactionsListForTeamDiscussionLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Reaction>) ApiClient.Deserialize(response.Content, typeof(List<Reaction>), response.Headers);
        }

    }
}
