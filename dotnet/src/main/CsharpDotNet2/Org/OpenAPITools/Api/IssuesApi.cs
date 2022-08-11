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
    public interface IIssuesApi
    {
        /// <summary>
        /// Add assignees to an issue Adds up to 10 assignees to an issue. Users already assigned to an issue are not replaced.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="issuesAddAssigneesRequest"></param>
        /// <returns>Issue</returns>
        Issue IssuesAddAssignees (string owner, string repo, int? issueNumber, IssuesAddAssigneesRequest issuesAddAssigneesRequest);
        /// <summary>
        /// Add labels to an issue 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="issuesAddLabelsRequest"></param>
        /// <returns>List&lt;Label&gt;</returns>
        List<Label> IssuesAddLabels (string owner, string repo, int? issueNumber, IssuesAddLabelsRequest issuesAddLabelsRequest);
        /// <summary>
        /// Check if a user can be assigned Checks if a user has permission to be assigned to an issue in this repository.  If the &#x60;assignee&#x60; can be assigned to issues in the repository, a &#x60;204&#x60; header with no content is returned.  Otherwise a &#x60;404&#x60; status code is returned.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="assignee"></param>
        /// <returns></returns>
        void IssuesCheckUserCanBeAssigned (string owner, string repo, string assignee);
        /// <summary>
        /// Create an issue Any user with pull access to a repository can create an issue. If [issues are disabled in the repository](https://docs.github.com/articles/disabling-issues/), the API returns a &#x60;410 Gone&#x60; status.  This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issuesCreateRequest"></param>
        /// <returns>Issue</returns>
        Issue IssuesCreate (string owner, string repo, IssuesCreateRequest issuesCreateRequest);
        /// <summary>
        /// Create an issue comment This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="issuesUpdateCommentRequest"></param>
        /// <returns>IssueComment</returns>
        IssueComment IssuesCreateComment (string owner, string repo, int? issueNumber, IssuesUpdateCommentRequest issuesUpdateCommentRequest);
        /// <summary>
        /// Create a label 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issuesCreateLabelRequest"></param>
        /// <returns>Label</returns>
        Label IssuesCreateLabel (string owner, string repo, IssuesCreateLabelRequest issuesCreateLabelRequest);
        /// <summary>
        /// Create a milestone 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issuesCreateMilestoneRequest"></param>
        /// <returns>Milestone1</returns>
        Milestone1 IssuesCreateMilestone (string owner, string repo, IssuesCreateMilestoneRequest issuesCreateMilestoneRequest);
        /// <summary>
        /// Delete an issue comment 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <returns></returns>
        void IssuesDeleteComment (string owner, string repo, int? commentId);
        /// <summary>
        /// Delete a label 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="name"></param>
        /// <returns></returns>
        void IssuesDeleteLabel (string owner, string repo, string name);
        /// <summary>
        /// Delete a milestone 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="milestoneNumber">The number that identifies the milestone.</param>
        /// <returns></returns>
        void IssuesDeleteMilestone (string owner, string repo, int? milestoneNumber);
        /// <summary>
        /// Get an issue The API returns a [&#x60;301 Moved Permanently&#x60; status](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-redirects-redirects) if the issue was [transferred](https://docs.github.com/articles/transferring-an-issue-to-another-repository/) to another repository. If the issue was transferred to or deleted from a repository where the authenticated user lacks read access, the API returns a &#x60;404 Not Found&#x60; status. If the issue was deleted from a repository where the authenticated user has read access, the API returns a &#x60;410 Gone&#x60; status. To receive webhook events for transferred and deleted issues, subscribe to the [&#x60;issues&#x60;](https://docs.github.com/webhooks/event-payloads/#issues) webhook.  **Note**: GitHub&#39;s REST API v3 considers every pull request an issue, but not every issue is a pull request. For this reason, \&quot;Issues\&quot; endpoints may return both issues and pull requests in the response. You can identify pull requests by the &#x60;pull_request&#x60; key. Be aware that the &#x60;id&#x60; of a pull request returned from \&quot;Issues\&quot; endpoints will be an _issue id_. To find out the pull request id, use the \&quot;[List pull requests](https://docs.github.com/rest/reference/pulls#list-pull-requests)\&quot; endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <returns>Issue</returns>
        Issue IssuesGet (string owner, string repo, int? issueNumber);
        /// <summary>
        /// Get an issue comment 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <returns>IssueComment</returns>
        IssueComment IssuesGetComment (string owner, string repo, int? commentId);
        /// <summary>
        /// Get an issue event 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="eventId"></param>
        /// <returns>IssueEvent</returns>
        IssueEvent IssuesGetEvent (string owner, string repo, int? eventId);
        /// <summary>
        /// Get a label 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="name"></param>
        /// <returns>Label</returns>
        Label IssuesGetLabel (string owner, string repo, string name);
        /// <summary>
        /// Get a milestone 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="milestoneNumber">The number that identifies the milestone.</param>
        /// <returns>Milestone1</returns>
        Milestone1 IssuesGetMilestone (string owner, string repo, int? milestoneNumber);
        /// <summary>
        /// List issues assigned to the authenticated user List issues assigned to the authenticated user across all visible repositories including owned repositories, member repositories, and organization repositories. You can use the &#x60;filter&#x60; query parameter to fetch issues that are not necessarily assigned to you.   **Note**: GitHub&#39;s REST API v3 considers every pull request an issue, but not every issue is a pull request. For this reason, \&quot;Issues\&quot; endpoints may return both issues and pull requests in the response. You can identify pull requests by the &#x60;pull_request&#x60; key. Be aware that the &#x60;id&#x60; of a pull request returned from \&quot;Issues\&quot; endpoints will be an _issue id_. To find out the pull request id, use the \&quot;[List pull requests](https://docs.github.com/rest/reference/pulls#list-pull-requests)\&quot; endpoint.
        /// </summary>
        /// <param name="filter">Indicates which sorts of issues to return. &#x60;assigned&#x60; means issues assigned to you. &#x60;created&#x60; means issues created by you. &#x60;mentioned&#x60; means issues mentioning you. &#x60;subscribed&#x60; means issues you&#39;re subscribed to updates for. &#x60;all&#x60; or &#x60;repos&#x60; means all issues you can see, regardless of participation or creation.</param>
        /// <param name="state">Indicates the state of the issues to return. Can be either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;.</param>
        /// <param name="labels">A list of comma separated label names. Example: &#x60;bug,ui,@high&#x60;</param>
        /// <param name="sort">What to sort results by. Can be either &#x60;created&#x60;, &#x60;updated&#x60;, &#x60;comments&#x60;.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="collab"></param>
        /// <param name="orgs"></param>
        /// <param name="owned"></param>
        /// <param name="pulls"></param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Issue&gt;</returns>
        List<Issue> IssuesList (string filter, string state, string labels, string sort, string direction, DateTime? since, bool? collab, bool? orgs, bool? owned, bool? pulls, int? perPage, int? page);
        /// <summary>
        /// List assignees Lists the [available assignees](https://docs.github.com/articles/assigning-issues-and-pull-requests-to-other-github-users/) for issues in a repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        List<SimpleUser1> IssuesListAssignees (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// List issue comments Issue Comments are ordered by ascending ID.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;IssueComment&gt;</returns>
        List<IssueComment> IssuesListComments (string owner, string repo, int? issueNumber, DateTime? since, int? perPage, int? page);
        /// <summary>
        /// List issue comments for a repository By default, Issue Comments are ordered by ascending ID.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="sort">The property to sort the results by. &#x60;created&#x60; means when the repository was starred. &#x60;updated&#x60; means when the repository was last pushed to.</param>
        /// <param name="direction">Either &#x60;asc&#x60; or &#x60;desc&#x60;. Ignored without the &#x60;sort&#x60; parameter.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;IssueComment&gt;</returns>
        List<IssueComment> IssuesListCommentsForRepo (string owner, string repo, string sort, string direction, DateTime? since, int? perPage, int? page);
        /// <summary>
        /// List issue events 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;IssueEventForIssue&gt;</returns>
        List<IssueEventForIssue> IssuesListEvents (string owner, string repo, int? issueNumber, int? perPage, int? page);
        /// <summary>
        /// List issue events for a repository 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;IssueEvent&gt;</returns>
        List<IssueEvent> IssuesListEventsForRepo (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// List timeline events for an issue 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;TimelineEvent&gt;</returns>
        List<TimelineEvent> IssuesListEventsForTimeline (string owner, string repo, int? issueNumber, int? perPage, int? page);
        /// <summary>
        /// List user account issues assigned to the authenticated user List issues across owned and member repositories assigned to the authenticated user.  **Note**: GitHub&#39;s REST API v3 considers every pull request an issue, but not every issue is a pull request. For this reason, \&quot;Issues\&quot; endpoints may return both issues and pull requests in the response. You can identify pull requests by the &#x60;pull_request&#x60; key. Be aware that the &#x60;id&#x60; of a pull request returned from \&quot;Issues\&quot; endpoints will be an _issue id_. To find out the pull request id, use the \&quot;[List pull requests](https://docs.github.com/rest/reference/pulls#list-pull-requests)\&quot; endpoint.
        /// </summary>
        /// <param name="filter">Indicates which sorts of issues to return. &#x60;assigned&#x60; means issues assigned to you. &#x60;created&#x60; means issues created by you. &#x60;mentioned&#x60; means issues mentioning you. &#x60;subscribed&#x60; means issues you&#39;re subscribed to updates for. &#x60;all&#x60; or &#x60;repos&#x60; means all issues you can see, regardless of participation or creation.</param>
        /// <param name="state">Indicates the state of the issues to return. Can be either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;.</param>
        /// <param name="labels">A list of comma separated label names. Example: &#x60;bug,ui,@high&#x60;</param>
        /// <param name="sort">What to sort results by. Can be either &#x60;created&#x60;, &#x60;updated&#x60;, &#x60;comments&#x60;.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Issue&gt;</returns>
        List<Issue> IssuesListForAuthenticatedUser (string filter, string state, string labels, string sort, string direction, DateTime? since, int? perPage, int? page);
        /// <summary>
        /// List organization issues assigned to the authenticated user List issues in an organization assigned to the authenticated user.  **Note**: GitHub&#39;s REST API v3 considers every pull request an issue, but not every issue is a pull request. For this reason, \&quot;Issues\&quot; endpoints may return both issues and pull requests in the response. You can identify pull requests by the &#x60;pull_request&#x60; key. Be aware that the &#x60;id&#x60; of a pull request returned from \&quot;Issues\&quot; endpoints will be an _issue id_. To find out the pull request id, use the \&quot;[List pull requests](https://docs.github.com/rest/reference/pulls#list-pull-requests)\&quot; endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="filter">Indicates which sorts of issues to return. &#x60;assigned&#x60; means issues assigned to you. &#x60;created&#x60; means issues created by you. &#x60;mentioned&#x60; means issues mentioning you. &#x60;subscribed&#x60; means issues you&#39;re subscribed to updates for. &#x60;all&#x60; or &#x60;repos&#x60; means all issues you can see, regardless of participation or creation.</param>
        /// <param name="state">Indicates the state of the issues to return. Can be either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;.</param>
        /// <param name="labels">A list of comma separated label names. Example: &#x60;bug,ui,@high&#x60;</param>
        /// <param name="sort">What to sort results by. Can be either &#x60;created&#x60;, &#x60;updated&#x60;, &#x60;comments&#x60;.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Issue&gt;</returns>
        List<Issue> IssuesListForOrg (string org, string filter, string state, string labels, string sort, string direction, DateTime? since, int? perPage, int? page);
        /// <summary>
        /// List repository issues List issues in a repository.  **Note**: GitHub&#39;s REST API v3 considers every pull request an issue, but not every issue is a pull request. For this reason, \&quot;Issues\&quot; endpoints may return both issues and pull requests in the response. You can identify pull requests by the &#x60;pull_request&#x60; key. Be aware that the &#x60;id&#x60; of a pull request returned from \&quot;Issues\&quot; endpoints will be an _issue id_. To find out the pull request id, use the \&quot;[List pull requests](https://docs.github.com/rest/reference/pulls#list-pull-requests)\&quot; endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="milestone">If an &#x60;integer&#x60; is passed, it should refer to a milestone by its &#x60;number&#x60; field. If the string &#x60;*&#x60; is passed, issues with any milestone are accepted. If the string &#x60;none&#x60; is passed, issues without milestones are returned.</param>
        /// <param name="state">Indicates the state of the issues to return. Can be either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;.</param>
        /// <param name="assignee">Can be the name of a user. Pass in &#x60;none&#x60; for issues with no assigned user, and &#x60;*&#x60; for issues assigned to any user.</param>
        /// <param name="creator">The user that created the issue.</param>
        /// <param name="mentioned">A user that&#39;s mentioned in the issue.</param>
        /// <param name="labels">A list of comma separated label names. Example: &#x60;bug,ui,@high&#x60;</param>
        /// <param name="sort">What to sort results by. Can be either &#x60;created&#x60;, &#x60;updated&#x60;, &#x60;comments&#x60;.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Issue&gt;</returns>
        List<Issue> IssuesListForRepo (string owner, string repo, string milestone, string state, string assignee, string creator, string mentioned, string labels, string sort, string direction, DateTime? since, int? perPage, int? page);
        /// <summary>
        /// List labels for issues in a milestone 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="milestoneNumber">The number that identifies the milestone.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Label&gt;</returns>
        List<Label> IssuesListLabelsForMilestone (string owner, string repo, int? milestoneNumber, int? perPage, int? page);
        /// <summary>
        /// List labels for a repository 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Label&gt;</returns>
        List<Label> IssuesListLabelsForRepo (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// List labels for an issue 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Label&gt;</returns>
        List<Label> IssuesListLabelsOnIssue (string owner, string repo, int? issueNumber, int? perPage, int? page);
        /// <summary>
        /// List milestones 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="state">The state of the milestone. Either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;.</param>
        /// <param name="sort">What to sort results by. Either &#x60;due_on&#x60; or &#x60;completeness&#x60;.</param>
        /// <param name="direction">The direction of the sort. Either &#x60;asc&#x60; or &#x60;desc&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Milestone1&gt;</returns>
        List<Milestone1> IssuesListMilestones (string owner, string repo, string state, string sort, string direction, int? perPage, int? page);
        /// <summary>
        /// Lock an issue Users with push access can lock an issue or pull request&#39;s conversation.  Note that, if you choose not to pass any parameters, you&#39;ll need to set &#x60;Content-Length&#x60; to zero when calling out to this endpoint. For more information, see \&quot;[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\&quot;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="issuesLockRequest"></param>
        /// <returns></returns>
        void IssuesLock (string owner, string repo, int? issueNumber, IssuesLockRequest issuesLockRequest);
        /// <summary>
        /// Remove all labels from an issue 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <returns></returns>
        void IssuesRemoveAllLabels (string owner, string repo, int? issueNumber);
        /// <summary>
        /// Remove assignees from an issue Removes one or more assignees from an issue.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="issuesRemoveAssigneesRequest"></param>
        /// <returns>Issue</returns>
        Issue IssuesRemoveAssignees (string owner, string repo, int? issueNumber, IssuesRemoveAssigneesRequest issuesRemoveAssigneesRequest);
        /// <summary>
        /// Remove a label from an issue Removes the specified label from the issue, and returns the remaining labels on the issue. This endpoint returns a &#x60;404 Not Found&#x60; status if the label does not exist.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="name"></param>
        /// <returns>List&lt;Label&gt;</returns>
        List<Label> IssuesRemoveLabel (string owner, string repo, int? issueNumber, string name);
        /// <summary>
        /// Set labels for an issue Removes any previous labels and sets the new labels for an issue.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="issuesSetLabelsRequest"></param>
        /// <returns>List&lt;Label&gt;</returns>
        List<Label> IssuesSetLabels (string owner, string repo, int? issueNumber, IssuesSetLabelsRequest issuesSetLabelsRequest);
        /// <summary>
        /// Unlock an issue Users with push access can unlock an issue&#39;s conversation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <returns></returns>
        void IssuesUnlock (string owner, string repo, int? issueNumber);
        /// <summary>
        /// Update an issue Issue owners and users with push access can edit an issue.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="issuesUpdateRequest"></param>
        /// <returns>Issue</returns>
        Issue IssuesUpdate (string owner, string repo, int? issueNumber, IssuesUpdateRequest issuesUpdateRequest);
        /// <summary>
        /// Update an issue comment 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="issuesUpdateCommentRequest"></param>
        /// <returns>IssueComment</returns>
        IssueComment IssuesUpdateComment (string owner, string repo, int? commentId, IssuesUpdateCommentRequest issuesUpdateCommentRequest);
        /// <summary>
        /// Update a label 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="name"></param>
        /// <param name="issuesUpdateLabelRequest"></param>
        /// <returns>Label</returns>
        Label IssuesUpdateLabel (string owner, string repo, string name, IssuesUpdateLabelRequest issuesUpdateLabelRequest);
        /// <summary>
        /// Update a milestone 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="milestoneNumber">The number that identifies the milestone.</param>
        /// <param name="issuesUpdateMilestoneRequest"></param>
        /// <returns>Milestone1</returns>
        Milestone1 IssuesUpdateMilestone (string owner, string repo, int? milestoneNumber, IssuesUpdateMilestoneRequest issuesUpdateMilestoneRequest);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class IssuesApi : IIssuesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public IssuesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IssuesApi(String basePath)
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
        /// Add assignees to an issue Adds up to 10 assignees to an issue. Users already assigned to an issue are not replaced.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="issuesAddAssigneesRequest"></param>
        /// <returns>Issue</returns>
        public Issue IssuesAddAssignees (string owner, string repo, int? issueNumber, IssuesAddAssigneesRequest issuesAddAssigneesRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesAddAssignees");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesAddAssignees");
            
            // verify the required parameter 'issueNumber' is set
            if (issueNumber == null) throw new ApiException(400, "Missing required parameter 'issueNumber' when calling IssuesAddAssignees");
            

            var path = "/repos/{owner}/{repo}/issues/{issue_number}/assignees";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "issue_number" + "}", ApiClient.ParameterToString(issueNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(issuesAddAssigneesRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesAddAssignees: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesAddAssignees: " + response.ErrorMessage, response.ErrorMessage);

            return (Issue) ApiClient.Deserialize(response.Content, typeof(Issue), response.Headers);
        }

        /// <summary>
        /// Add labels to an issue 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="issuesAddLabelsRequest"></param>
        /// <returns>List&lt;Label&gt;</returns>
        public List<Label> IssuesAddLabels (string owner, string repo, int? issueNumber, IssuesAddLabelsRequest issuesAddLabelsRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesAddLabels");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesAddLabels");
            
            // verify the required parameter 'issueNumber' is set
            if (issueNumber == null) throw new ApiException(400, "Missing required parameter 'issueNumber' when calling IssuesAddLabels");
            

            var path = "/repos/{owner}/{repo}/issues/{issue_number}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "issue_number" + "}", ApiClient.ParameterToString(issueNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(issuesAddLabelsRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesAddLabels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesAddLabels: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Label>) ApiClient.Deserialize(response.Content, typeof(List<Label>), response.Headers);
        }

        /// <summary>
        /// Check if a user can be assigned Checks if a user has permission to be assigned to an issue in this repository.  If the &#x60;assignee&#x60; can be assigned to issues in the repository, a &#x60;204&#x60; header with no content is returned.  Otherwise a &#x60;404&#x60; status code is returned.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="assignee"></param>
        /// <returns></returns>
        public void IssuesCheckUserCanBeAssigned (string owner, string repo, string assignee)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesCheckUserCanBeAssigned");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesCheckUserCanBeAssigned");
            
            // verify the required parameter 'assignee' is set
            if (assignee == null) throw new ApiException(400, "Missing required parameter 'assignee' when calling IssuesCheckUserCanBeAssigned");
            

            var path = "/repos/{owner}/{repo}/assignees/{assignee}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "assignee" + "}", ApiClient.ParameterToString(assignee));

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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesCheckUserCanBeAssigned: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesCheckUserCanBeAssigned: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Create an issue Any user with pull access to a repository can create an issue. If [issues are disabled in the repository](https://docs.github.com/articles/disabling-issues/), the API returns a &#x60;410 Gone&#x60; status.  This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issuesCreateRequest"></param>
        /// <returns>Issue</returns>
        public Issue IssuesCreate (string owner, string repo, IssuesCreateRequest issuesCreateRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesCreate");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesCreate");
            
            // verify the required parameter 'issuesCreateRequest' is set
            if (issuesCreateRequest == null) throw new ApiException(400, "Missing required parameter 'issuesCreateRequest' when calling IssuesCreate");
            

            var path = "/repos/{owner}/{repo}/issues";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(issuesCreateRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesCreate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesCreate: " + response.ErrorMessage, response.ErrorMessage);

            return (Issue) ApiClient.Deserialize(response.Content, typeof(Issue), response.Headers);
        }

        /// <summary>
        /// Create an issue comment This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="issuesUpdateCommentRequest"></param>
        /// <returns>IssueComment</returns>
        public IssueComment IssuesCreateComment (string owner, string repo, int? issueNumber, IssuesUpdateCommentRequest issuesUpdateCommentRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesCreateComment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesCreateComment");
            
            // verify the required parameter 'issueNumber' is set
            if (issueNumber == null) throw new ApiException(400, "Missing required parameter 'issueNumber' when calling IssuesCreateComment");
            
            // verify the required parameter 'issuesUpdateCommentRequest' is set
            if (issuesUpdateCommentRequest == null) throw new ApiException(400, "Missing required parameter 'issuesUpdateCommentRequest' when calling IssuesCreateComment");
            

            var path = "/repos/{owner}/{repo}/issues/{issue_number}/comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "issue_number" + "}", ApiClient.ParameterToString(issueNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(issuesUpdateCommentRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesCreateComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesCreateComment: " + response.ErrorMessage, response.ErrorMessage);

            return (IssueComment) ApiClient.Deserialize(response.Content, typeof(IssueComment), response.Headers);
        }

        /// <summary>
        /// Create a label 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issuesCreateLabelRequest"></param>
        /// <returns>Label</returns>
        public Label IssuesCreateLabel (string owner, string repo, IssuesCreateLabelRequest issuesCreateLabelRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesCreateLabel");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesCreateLabel");
            
            // verify the required parameter 'issuesCreateLabelRequest' is set
            if (issuesCreateLabelRequest == null) throw new ApiException(400, "Missing required parameter 'issuesCreateLabelRequest' when calling IssuesCreateLabel");
            

            var path = "/repos/{owner}/{repo}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(issuesCreateLabelRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesCreateLabel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesCreateLabel: " + response.ErrorMessage, response.ErrorMessage);

            return (Label) ApiClient.Deserialize(response.Content, typeof(Label), response.Headers);
        }

        /// <summary>
        /// Create a milestone 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issuesCreateMilestoneRequest"></param>
        /// <returns>Milestone1</returns>
        public Milestone1 IssuesCreateMilestone (string owner, string repo, IssuesCreateMilestoneRequest issuesCreateMilestoneRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesCreateMilestone");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesCreateMilestone");
            
            // verify the required parameter 'issuesCreateMilestoneRequest' is set
            if (issuesCreateMilestoneRequest == null) throw new ApiException(400, "Missing required parameter 'issuesCreateMilestoneRequest' when calling IssuesCreateMilestone");
            

            var path = "/repos/{owner}/{repo}/milestones";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(issuesCreateMilestoneRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesCreateMilestone: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesCreateMilestone: " + response.ErrorMessage, response.ErrorMessage);

            return (Milestone1) ApiClient.Deserialize(response.Content, typeof(Milestone1), response.Headers);
        }

        /// <summary>
        /// Delete an issue comment 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <returns></returns>
        public void IssuesDeleteComment (string owner, string repo, int? commentId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesDeleteComment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesDeleteComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling IssuesDeleteComment");
            

            var path = "/repos/{owner}/{repo}/issues/comments/{comment_id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesDeleteComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesDeleteComment: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a label 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="name"></param>
        /// <returns></returns>
        public void IssuesDeleteLabel (string owner, string repo, string name)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesDeleteLabel");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesDeleteLabel");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling IssuesDeleteLabel");
            

            var path = "/repos/{owner}/{repo}/labels/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));

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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesDeleteLabel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesDeleteLabel: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a milestone 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="milestoneNumber">The number that identifies the milestone.</param>
        /// <returns></returns>
        public void IssuesDeleteMilestone (string owner, string repo, int? milestoneNumber)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesDeleteMilestone");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesDeleteMilestone");
            
            // verify the required parameter 'milestoneNumber' is set
            if (milestoneNumber == null) throw new ApiException(400, "Missing required parameter 'milestoneNumber' when calling IssuesDeleteMilestone");
            

            var path = "/repos/{owner}/{repo}/milestones/{milestone_number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "milestone_number" + "}", ApiClient.ParameterToString(milestoneNumber));

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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesDeleteMilestone: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesDeleteMilestone: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get an issue The API returns a [&#x60;301 Moved Permanently&#x60; status](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-redirects-redirects) if the issue was [transferred](https://docs.github.com/articles/transferring-an-issue-to-another-repository/) to another repository. If the issue was transferred to or deleted from a repository where the authenticated user lacks read access, the API returns a &#x60;404 Not Found&#x60; status. If the issue was deleted from a repository where the authenticated user has read access, the API returns a &#x60;410 Gone&#x60; status. To receive webhook events for transferred and deleted issues, subscribe to the [&#x60;issues&#x60;](https://docs.github.com/webhooks/event-payloads/#issues) webhook.  **Note**: GitHub&#39;s REST API v3 considers every pull request an issue, but not every issue is a pull request. For this reason, \&quot;Issues\&quot; endpoints may return both issues and pull requests in the response. You can identify pull requests by the &#x60;pull_request&#x60; key. Be aware that the &#x60;id&#x60; of a pull request returned from \&quot;Issues\&quot; endpoints will be an _issue id_. To find out the pull request id, use the \&quot;[List pull requests](https://docs.github.com/rest/reference/pulls#list-pull-requests)\&quot; endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <returns>Issue</returns>
        public Issue IssuesGet (string owner, string repo, int? issueNumber)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesGet");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesGet");
            
            // verify the required parameter 'issueNumber' is set
            if (issueNumber == null) throw new ApiException(400, "Missing required parameter 'issueNumber' when calling IssuesGet");
            

            var path = "/repos/{owner}/{repo}/issues/{issue_number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "issue_number" + "}", ApiClient.ParameterToString(issueNumber));

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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesGet: " + response.ErrorMessage, response.ErrorMessage);

            return (Issue) ApiClient.Deserialize(response.Content, typeof(Issue), response.Headers);
        }

        /// <summary>
        /// Get an issue comment 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <returns>IssueComment</returns>
        public IssueComment IssuesGetComment (string owner, string repo, int? commentId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesGetComment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesGetComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling IssuesGetComment");
            

            var path = "/repos/{owner}/{repo}/issues/comments/{comment_id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesGetComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesGetComment: " + response.ErrorMessage, response.ErrorMessage);

            return (IssueComment) ApiClient.Deserialize(response.Content, typeof(IssueComment), response.Headers);
        }

        /// <summary>
        /// Get an issue event 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="eventId"></param>
        /// <returns>IssueEvent</returns>
        public IssueEvent IssuesGetEvent (string owner, string repo, int? eventId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesGetEvent");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesGetEvent");
            
            // verify the required parameter 'eventId' is set
            if (eventId == null) throw new ApiException(400, "Missing required parameter 'eventId' when calling IssuesGetEvent");
            

            var path = "/repos/{owner}/{repo}/issues/events/{event_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "event_id" + "}", ApiClient.ParameterToString(eventId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesGetEvent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesGetEvent: " + response.ErrorMessage, response.ErrorMessage);

            return (IssueEvent) ApiClient.Deserialize(response.Content, typeof(IssueEvent), response.Headers);
        }

        /// <summary>
        /// Get a label 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="name"></param>
        /// <returns>Label</returns>
        public Label IssuesGetLabel (string owner, string repo, string name)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesGetLabel");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesGetLabel");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling IssuesGetLabel");
            

            var path = "/repos/{owner}/{repo}/labels/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));

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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesGetLabel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesGetLabel: " + response.ErrorMessage, response.ErrorMessage);

            return (Label) ApiClient.Deserialize(response.Content, typeof(Label), response.Headers);
        }

        /// <summary>
        /// Get a milestone 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="milestoneNumber">The number that identifies the milestone.</param>
        /// <returns>Milestone1</returns>
        public Milestone1 IssuesGetMilestone (string owner, string repo, int? milestoneNumber)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesGetMilestone");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesGetMilestone");
            
            // verify the required parameter 'milestoneNumber' is set
            if (milestoneNumber == null) throw new ApiException(400, "Missing required parameter 'milestoneNumber' when calling IssuesGetMilestone");
            

            var path = "/repos/{owner}/{repo}/milestones/{milestone_number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "milestone_number" + "}", ApiClient.ParameterToString(milestoneNumber));

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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesGetMilestone: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesGetMilestone: " + response.ErrorMessage, response.ErrorMessage);

            return (Milestone1) ApiClient.Deserialize(response.Content, typeof(Milestone1), response.Headers);
        }

        /// <summary>
        /// List issues assigned to the authenticated user List issues assigned to the authenticated user across all visible repositories including owned repositories, member repositories, and organization repositories. You can use the &#x60;filter&#x60; query parameter to fetch issues that are not necessarily assigned to you.   **Note**: GitHub&#39;s REST API v3 considers every pull request an issue, but not every issue is a pull request. For this reason, \&quot;Issues\&quot; endpoints may return both issues and pull requests in the response. You can identify pull requests by the &#x60;pull_request&#x60; key. Be aware that the &#x60;id&#x60; of a pull request returned from \&quot;Issues\&quot; endpoints will be an _issue id_. To find out the pull request id, use the \&quot;[List pull requests](https://docs.github.com/rest/reference/pulls#list-pull-requests)\&quot; endpoint.
        /// </summary>
        /// <param name="filter">Indicates which sorts of issues to return. &#x60;assigned&#x60; means issues assigned to you. &#x60;created&#x60; means issues created by you. &#x60;mentioned&#x60; means issues mentioning you. &#x60;subscribed&#x60; means issues you&#39;re subscribed to updates for. &#x60;all&#x60; or &#x60;repos&#x60; means all issues you can see, regardless of participation or creation.</param>
        /// <param name="state">Indicates the state of the issues to return. Can be either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;.</param>
        /// <param name="labels">A list of comma separated label names. Example: &#x60;bug,ui,@high&#x60;</param>
        /// <param name="sort">What to sort results by. Can be either &#x60;created&#x60;, &#x60;updated&#x60;, &#x60;comments&#x60;.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="collab"></param>
        /// <param name="orgs"></param>
        /// <param name="owned"></param>
        /// <param name="pulls"></param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Issue&gt;</returns>
        public List<Issue> IssuesList (string filter, string state, string labels, string sort, string direction, DateTime? since, bool? collab, bool? orgs, bool? owned, bool? pulls, int? perPage, int? page)
        {
            

            var path = "/issues";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
 if (labels != null) queryParams.Add("labels", ApiClient.ParameterToString(labels)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
 if (collab != null) queryParams.Add("collab", ApiClient.ParameterToString(collab)); // query parameter
 if (orgs != null) queryParams.Add("orgs", ApiClient.ParameterToString(orgs)); // query parameter
 if (owned != null) queryParams.Add("owned", ApiClient.ParameterToString(owned)); // query parameter
 if (pulls != null) queryParams.Add("pulls", ApiClient.ParameterToString(pulls)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesList: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Issue>) ApiClient.Deserialize(response.Content, typeof(List<Issue>), response.Headers);
        }

        /// <summary>
        /// List assignees Lists the [available assignees](https://docs.github.com/articles/assigning-issues-and-pull-requests-to-other-github-users/) for issues in a repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        public List<SimpleUser1> IssuesListAssignees (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesListAssignees");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesListAssignees");
            

            var path = "/repos/{owner}/{repo}/assignees";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListAssignees: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListAssignees: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SimpleUser1>) ApiClient.Deserialize(response.Content, typeof(List<SimpleUser1>), response.Headers);
        }

        /// <summary>
        /// List issue comments Issue Comments are ordered by ascending ID.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;IssueComment&gt;</returns>
        public List<IssueComment> IssuesListComments (string owner, string repo, int? issueNumber, DateTime? since, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesListComments");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesListComments");
            
            // verify the required parameter 'issueNumber' is set
            if (issueNumber == null) throw new ApiException(400, "Missing required parameter 'issueNumber' when calling IssuesListComments");
            

            var path = "/repos/{owner}/{repo}/issues/{issue_number}/comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "issue_number" + "}", ApiClient.ParameterToString(issueNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListComments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListComments: " + response.ErrorMessage, response.ErrorMessage);

            return (List<IssueComment>) ApiClient.Deserialize(response.Content, typeof(List<IssueComment>), response.Headers);
        }

        /// <summary>
        /// List issue comments for a repository By default, Issue Comments are ordered by ascending ID.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="sort">The property to sort the results by. &#x60;created&#x60; means when the repository was starred. &#x60;updated&#x60; means when the repository was last pushed to.</param>
        /// <param name="direction">Either &#x60;asc&#x60; or &#x60;desc&#x60;. Ignored without the &#x60;sort&#x60; parameter.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;IssueComment&gt;</returns>
        public List<IssueComment> IssuesListCommentsForRepo (string owner, string repo, string sort, string direction, DateTime? since, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesListCommentsForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesListCommentsForRepo");
            

            var path = "/repos/{owner}/{repo}/issues/comments";
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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListCommentsForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListCommentsForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (List<IssueComment>) ApiClient.Deserialize(response.Content, typeof(List<IssueComment>), response.Headers);
        }

        /// <summary>
        /// List issue events 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;IssueEventForIssue&gt;</returns>
        public List<IssueEventForIssue> IssuesListEvents (string owner, string repo, int? issueNumber, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesListEvents");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesListEvents");
            
            // verify the required parameter 'issueNumber' is set
            if (issueNumber == null) throw new ApiException(400, "Missing required parameter 'issueNumber' when calling IssuesListEvents");
            

            var path = "/repos/{owner}/{repo}/issues/{issue_number}/events";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "issue_number" + "}", ApiClient.ParameterToString(issueNumber));

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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListEvents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListEvents: " + response.ErrorMessage, response.ErrorMessage);

            return (List<IssueEventForIssue>) ApiClient.Deserialize(response.Content, typeof(List<IssueEventForIssue>), response.Headers);
        }

        /// <summary>
        /// List issue events for a repository 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;IssueEvent&gt;</returns>
        public List<IssueEvent> IssuesListEventsForRepo (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesListEventsForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesListEventsForRepo");
            

            var path = "/repos/{owner}/{repo}/issues/events";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListEventsForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListEventsForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (List<IssueEvent>) ApiClient.Deserialize(response.Content, typeof(List<IssueEvent>), response.Headers);
        }

        /// <summary>
        /// List timeline events for an issue 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;TimelineEvent&gt;</returns>
        public List<TimelineEvent> IssuesListEventsForTimeline (string owner, string repo, int? issueNumber, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesListEventsForTimeline");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesListEventsForTimeline");
            
            // verify the required parameter 'issueNumber' is set
            if (issueNumber == null) throw new ApiException(400, "Missing required parameter 'issueNumber' when calling IssuesListEventsForTimeline");
            

            var path = "/repos/{owner}/{repo}/issues/{issue_number}/timeline";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "issue_number" + "}", ApiClient.ParameterToString(issueNumber));

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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListEventsForTimeline: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListEventsForTimeline: " + response.ErrorMessage, response.ErrorMessage);

            return (List<TimelineEvent>) ApiClient.Deserialize(response.Content, typeof(List<TimelineEvent>), response.Headers);
        }

        /// <summary>
        /// List user account issues assigned to the authenticated user List issues across owned and member repositories assigned to the authenticated user.  **Note**: GitHub&#39;s REST API v3 considers every pull request an issue, but not every issue is a pull request. For this reason, \&quot;Issues\&quot; endpoints may return both issues and pull requests in the response. You can identify pull requests by the &#x60;pull_request&#x60; key. Be aware that the &#x60;id&#x60; of a pull request returned from \&quot;Issues\&quot; endpoints will be an _issue id_. To find out the pull request id, use the \&quot;[List pull requests](https://docs.github.com/rest/reference/pulls#list-pull-requests)\&quot; endpoint.
        /// </summary>
        /// <param name="filter">Indicates which sorts of issues to return. &#x60;assigned&#x60; means issues assigned to you. &#x60;created&#x60; means issues created by you. &#x60;mentioned&#x60; means issues mentioning you. &#x60;subscribed&#x60; means issues you&#39;re subscribed to updates for. &#x60;all&#x60; or &#x60;repos&#x60; means all issues you can see, regardless of participation or creation.</param>
        /// <param name="state">Indicates the state of the issues to return. Can be either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;.</param>
        /// <param name="labels">A list of comma separated label names. Example: &#x60;bug,ui,@high&#x60;</param>
        /// <param name="sort">What to sort results by. Can be either &#x60;created&#x60;, &#x60;updated&#x60;, &#x60;comments&#x60;.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Issue&gt;</returns>
        public List<Issue> IssuesListForAuthenticatedUser (string filter, string state, string labels, string sort, string direction, DateTime? since, int? perPage, int? page)
        {
            

            var path = "/user/issues";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
 if (labels != null) queryParams.Add("labels", ApiClient.ParameterToString(labels)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Issue>) ApiClient.Deserialize(response.Content, typeof(List<Issue>), response.Headers);
        }

        /// <summary>
        /// List organization issues assigned to the authenticated user List issues in an organization assigned to the authenticated user.  **Note**: GitHub&#39;s REST API v3 considers every pull request an issue, but not every issue is a pull request. For this reason, \&quot;Issues\&quot; endpoints may return both issues and pull requests in the response. You can identify pull requests by the &#x60;pull_request&#x60; key. Be aware that the &#x60;id&#x60; of a pull request returned from \&quot;Issues\&quot; endpoints will be an _issue id_. To find out the pull request id, use the \&quot;[List pull requests](https://docs.github.com/rest/reference/pulls#list-pull-requests)\&quot; endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="filter">Indicates which sorts of issues to return. &#x60;assigned&#x60; means issues assigned to you. &#x60;created&#x60; means issues created by you. &#x60;mentioned&#x60; means issues mentioning you. &#x60;subscribed&#x60; means issues you&#39;re subscribed to updates for. &#x60;all&#x60; or &#x60;repos&#x60; means all issues you can see, regardless of participation or creation.</param>
        /// <param name="state">Indicates the state of the issues to return. Can be either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;.</param>
        /// <param name="labels">A list of comma separated label names. Example: &#x60;bug,ui,@high&#x60;</param>
        /// <param name="sort">What to sort results by. Can be either &#x60;created&#x60;, &#x60;updated&#x60;, &#x60;comments&#x60;.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Issue&gt;</returns>
        public List<Issue> IssuesListForOrg (string org, string filter, string state, string labels, string sort, string direction, DateTime? since, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling IssuesListForOrg");
            

            var path = "/orgs/{org}/issues";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
 if (labels != null) queryParams.Add("labels", ApiClient.ParameterToString(labels)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Issue>) ApiClient.Deserialize(response.Content, typeof(List<Issue>), response.Headers);
        }

        /// <summary>
        /// List repository issues List issues in a repository.  **Note**: GitHub&#39;s REST API v3 considers every pull request an issue, but not every issue is a pull request. For this reason, \&quot;Issues\&quot; endpoints may return both issues and pull requests in the response. You can identify pull requests by the &#x60;pull_request&#x60; key. Be aware that the &#x60;id&#x60; of a pull request returned from \&quot;Issues\&quot; endpoints will be an _issue id_. To find out the pull request id, use the \&quot;[List pull requests](https://docs.github.com/rest/reference/pulls#list-pull-requests)\&quot; endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="milestone">If an &#x60;integer&#x60; is passed, it should refer to a milestone by its &#x60;number&#x60; field. If the string &#x60;*&#x60; is passed, issues with any milestone are accepted. If the string &#x60;none&#x60; is passed, issues without milestones are returned.</param>
        /// <param name="state">Indicates the state of the issues to return. Can be either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;.</param>
        /// <param name="assignee">Can be the name of a user. Pass in &#x60;none&#x60; for issues with no assigned user, and &#x60;*&#x60; for issues assigned to any user.</param>
        /// <param name="creator">The user that created the issue.</param>
        /// <param name="mentioned">A user that&#39;s mentioned in the issue.</param>
        /// <param name="labels">A list of comma separated label names. Example: &#x60;bug,ui,@high&#x60;</param>
        /// <param name="sort">What to sort results by. Can be either &#x60;created&#x60;, &#x60;updated&#x60;, &#x60;comments&#x60;.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Issue&gt;</returns>
        public List<Issue> IssuesListForRepo (string owner, string repo, string milestone, string state, string assignee, string creator, string mentioned, string labels, string sort, string direction, DateTime? since, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesListForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesListForRepo");
            

            var path = "/repos/{owner}/{repo}/issues";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (milestone != null) queryParams.Add("milestone", ApiClient.ParameterToString(milestone)); // query parameter
 if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
 if (assignee != null) queryParams.Add("assignee", ApiClient.ParameterToString(assignee)); // query parameter
 if (creator != null) queryParams.Add("creator", ApiClient.ParameterToString(creator)); // query parameter
 if (mentioned != null) queryParams.Add("mentioned", ApiClient.ParameterToString(mentioned)); // query parameter
 if (labels != null) queryParams.Add("labels", ApiClient.ParameterToString(labels)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Issue>) ApiClient.Deserialize(response.Content, typeof(List<Issue>), response.Headers);
        }

        /// <summary>
        /// List labels for issues in a milestone 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="milestoneNumber">The number that identifies the milestone.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Label&gt;</returns>
        public List<Label> IssuesListLabelsForMilestone (string owner, string repo, int? milestoneNumber, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesListLabelsForMilestone");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesListLabelsForMilestone");
            
            // verify the required parameter 'milestoneNumber' is set
            if (milestoneNumber == null) throw new ApiException(400, "Missing required parameter 'milestoneNumber' when calling IssuesListLabelsForMilestone");
            

            var path = "/repos/{owner}/{repo}/milestones/{milestone_number}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "milestone_number" + "}", ApiClient.ParameterToString(milestoneNumber));

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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListLabelsForMilestone: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListLabelsForMilestone: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Label>) ApiClient.Deserialize(response.Content, typeof(List<Label>), response.Headers);
        }

        /// <summary>
        /// List labels for a repository 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Label&gt;</returns>
        public List<Label> IssuesListLabelsForRepo (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesListLabelsForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesListLabelsForRepo");
            

            var path = "/repos/{owner}/{repo}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListLabelsForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListLabelsForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Label>) ApiClient.Deserialize(response.Content, typeof(List<Label>), response.Headers);
        }

        /// <summary>
        /// List labels for an issue 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Label&gt;</returns>
        public List<Label> IssuesListLabelsOnIssue (string owner, string repo, int? issueNumber, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesListLabelsOnIssue");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesListLabelsOnIssue");
            
            // verify the required parameter 'issueNumber' is set
            if (issueNumber == null) throw new ApiException(400, "Missing required parameter 'issueNumber' when calling IssuesListLabelsOnIssue");
            

            var path = "/repos/{owner}/{repo}/issues/{issue_number}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "issue_number" + "}", ApiClient.ParameterToString(issueNumber));

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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListLabelsOnIssue: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListLabelsOnIssue: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Label>) ApiClient.Deserialize(response.Content, typeof(List<Label>), response.Headers);
        }

        /// <summary>
        /// List milestones 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="state">The state of the milestone. Either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;.</param>
        /// <param name="sort">What to sort results by. Either &#x60;due_on&#x60; or &#x60;completeness&#x60;.</param>
        /// <param name="direction">The direction of the sort. Either &#x60;asc&#x60; or &#x60;desc&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Milestone1&gt;</returns>
        public List<Milestone1> IssuesListMilestones (string owner, string repo, string state, string sort, string direction, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesListMilestones");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesListMilestones");
            

            var path = "/repos/{owner}/{repo}/milestones";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListMilestones: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesListMilestones: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Milestone1>) ApiClient.Deserialize(response.Content, typeof(List<Milestone1>), response.Headers);
        }

        /// <summary>
        /// Lock an issue Users with push access can lock an issue or pull request&#39;s conversation.  Note that, if you choose not to pass any parameters, you&#39;ll need to set &#x60;Content-Length&#x60; to zero when calling out to this endpoint. For more information, see \&quot;[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\&quot;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="issuesLockRequest"></param>
        /// <returns></returns>
        public void IssuesLock (string owner, string repo, int? issueNumber, IssuesLockRequest issuesLockRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesLock");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesLock");
            
            // verify the required parameter 'issueNumber' is set
            if (issueNumber == null) throw new ApiException(400, "Missing required parameter 'issueNumber' when calling IssuesLock");
            

            var path = "/repos/{owner}/{repo}/issues/{issue_number}/lock";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "issue_number" + "}", ApiClient.ParameterToString(issueNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(issuesLockRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesLock: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesLock: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Remove all labels from an issue 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <returns></returns>
        public void IssuesRemoveAllLabels (string owner, string repo, int? issueNumber)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesRemoveAllLabels");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesRemoveAllLabels");
            
            // verify the required parameter 'issueNumber' is set
            if (issueNumber == null) throw new ApiException(400, "Missing required parameter 'issueNumber' when calling IssuesRemoveAllLabels");
            

            var path = "/repos/{owner}/{repo}/issues/{issue_number}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "issue_number" + "}", ApiClient.ParameterToString(issueNumber));

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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesRemoveAllLabels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesRemoveAllLabels: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Remove assignees from an issue Removes one or more assignees from an issue.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="issuesRemoveAssigneesRequest"></param>
        /// <returns>Issue</returns>
        public Issue IssuesRemoveAssignees (string owner, string repo, int? issueNumber, IssuesRemoveAssigneesRequest issuesRemoveAssigneesRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesRemoveAssignees");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesRemoveAssignees");
            
            // verify the required parameter 'issueNumber' is set
            if (issueNumber == null) throw new ApiException(400, "Missing required parameter 'issueNumber' when calling IssuesRemoveAssignees");
            

            var path = "/repos/{owner}/{repo}/issues/{issue_number}/assignees";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "issue_number" + "}", ApiClient.ParameterToString(issueNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(issuesRemoveAssigneesRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesRemoveAssignees: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesRemoveAssignees: " + response.ErrorMessage, response.ErrorMessage);

            return (Issue) ApiClient.Deserialize(response.Content, typeof(Issue), response.Headers);
        }

        /// <summary>
        /// Remove a label from an issue Removes the specified label from the issue, and returns the remaining labels on the issue. This endpoint returns a &#x60;404 Not Found&#x60; status if the label does not exist.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="name"></param>
        /// <returns>List&lt;Label&gt;</returns>
        public List<Label> IssuesRemoveLabel (string owner, string repo, int? issueNumber, string name)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesRemoveLabel");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesRemoveLabel");
            
            // verify the required parameter 'issueNumber' is set
            if (issueNumber == null) throw new ApiException(400, "Missing required parameter 'issueNumber' when calling IssuesRemoveLabel");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling IssuesRemoveLabel");
            

            var path = "/repos/{owner}/{repo}/issues/{issue_number}/labels/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "issue_number" + "}", ApiClient.ParameterToString(issueNumber));
path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));

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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesRemoveLabel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesRemoveLabel: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Label>) ApiClient.Deserialize(response.Content, typeof(List<Label>), response.Headers);
        }

        /// <summary>
        /// Set labels for an issue Removes any previous labels and sets the new labels for an issue.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="issuesSetLabelsRequest"></param>
        /// <returns>List&lt;Label&gt;</returns>
        public List<Label> IssuesSetLabels (string owner, string repo, int? issueNumber, IssuesSetLabelsRequest issuesSetLabelsRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesSetLabels");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesSetLabels");
            
            // verify the required parameter 'issueNumber' is set
            if (issueNumber == null) throw new ApiException(400, "Missing required parameter 'issueNumber' when calling IssuesSetLabels");
            

            var path = "/repos/{owner}/{repo}/issues/{issue_number}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "issue_number" + "}", ApiClient.ParameterToString(issueNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(issuesSetLabelsRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesSetLabels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesSetLabels: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Label>) ApiClient.Deserialize(response.Content, typeof(List<Label>), response.Headers);
        }

        /// <summary>
        /// Unlock an issue Users with push access can unlock an issue&#39;s conversation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <returns></returns>
        public void IssuesUnlock (string owner, string repo, int? issueNumber)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesUnlock");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesUnlock");
            
            // verify the required parameter 'issueNumber' is set
            if (issueNumber == null) throw new ApiException(400, "Missing required parameter 'issueNumber' when calling IssuesUnlock");
            

            var path = "/repos/{owner}/{repo}/issues/{issue_number}/lock";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "issue_number" + "}", ApiClient.ParameterToString(issueNumber));

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
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesUnlock: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesUnlock: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Update an issue Issue owners and users with push access can edit an issue.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="issueNumber">The number that identifies the issue.</param>
        /// <param name="issuesUpdateRequest"></param>
        /// <returns>Issue</returns>
        public Issue IssuesUpdate (string owner, string repo, int? issueNumber, IssuesUpdateRequest issuesUpdateRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesUpdate");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesUpdate");
            
            // verify the required parameter 'issueNumber' is set
            if (issueNumber == null) throw new ApiException(400, "Missing required parameter 'issueNumber' when calling IssuesUpdate");
            

            var path = "/repos/{owner}/{repo}/issues/{issue_number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "issue_number" + "}", ApiClient.ParameterToString(issueNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(issuesUpdateRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesUpdate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesUpdate: " + response.ErrorMessage, response.ErrorMessage);

            return (Issue) ApiClient.Deserialize(response.Content, typeof(Issue), response.Headers);
        }

        /// <summary>
        /// Update an issue comment 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="issuesUpdateCommentRequest"></param>
        /// <returns>IssueComment</returns>
        public IssueComment IssuesUpdateComment (string owner, string repo, int? commentId, IssuesUpdateCommentRequest issuesUpdateCommentRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesUpdateComment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesUpdateComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling IssuesUpdateComment");
            
            // verify the required parameter 'issuesUpdateCommentRequest' is set
            if (issuesUpdateCommentRequest == null) throw new ApiException(400, "Missing required parameter 'issuesUpdateCommentRequest' when calling IssuesUpdateComment");
            

            var path = "/repos/{owner}/{repo}/issues/comments/{comment_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "comment_id" + "}", ApiClient.ParameterToString(commentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(issuesUpdateCommentRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesUpdateComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesUpdateComment: " + response.ErrorMessage, response.ErrorMessage);

            return (IssueComment) ApiClient.Deserialize(response.Content, typeof(IssueComment), response.Headers);
        }

        /// <summary>
        /// Update a label 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="name"></param>
        /// <param name="issuesUpdateLabelRequest"></param>
        /// <returns>Label</returns>
        public Label IssuesUpdateLabel (string owner, string repo, string name, IssuesUpdateLabelRequest issuesUpdateLabelRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesUpdateLabel");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesUpdateLabel");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling IssuesUpdateLabel");
            

            var path = "/repos/{owner}/{repo}/labels/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(issuesUpdateLabelRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesUpdateLabel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesUpdateLabel: " + response.ErrorMessage, response.ErrorMessage);

            return (Label) ApiClient.Deserialize(response.Content, typeof(Label), response.Headers);
        }

        /// <summary>
        /// Update a milestone 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="milestoneNumber">The number that identifies the milestone.</param>
        /// <param name="issuesUpdateMilestoneRequest"></param>
        /// <returns>Milestone1</returns>
        public Milestone1 IssuesUpdateMilestone (string owner, string repo, int? milestoneNumber, IssuesUpdateMilestoneRequest issuesUpdateMilestoneRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling IssuesUpdateMilestone");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling IssuesUpdateMilestone");
            
            // verify the required parameter 'milestoneNumber' is set
            if (milestoneNumber == null) throw new ApiException(400, "Missing required parameter 'milestoneNumber' when calling IssuesUpdateMilestone");
            

            var path = "/repos/{owner}/{repo}/milestones/{milestone_number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "milestone_number" + "}", ApiClient.ParameterToString(milestoneNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(issuesUpdateMilestoneRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesUpdateMilestone: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IssuesUpdateMilestone: " + response.ErrorMessage, response.ErrorMessage);

            return (Milestone1) ApiClient.Deserialize(response.Content, typeof(Milestone1), response.Headers);
        }

    }
}
