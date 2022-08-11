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
    public interface IActivityApi
    {
        /// <summary>
        /// Check if a repository is starred by the authenticated user 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        void ActivityCheckRepoIsStarredByAuthenticatedUser (string owner, string repo);
        /// <summary>
        /// Delete a repository subscription This endpoint should only be used to stop watching a repository. To control whether or not you wish to receive notifications from a repository, [set the repository&#39;s subscription manually](https://docs.github.com/rest/reference/activity#set-a-repository-subscription).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        void ActivityDeleteRepoSubscription (string owner, string repo);
        /// <summary>
        /// Delete a thread subscription Mutes all future notifications for a conversation until you comment on the thread or get an **@mention**. If you are watching the repository of the thread, you will still receive notifications. To ignore future notifications for a repository you are watching, use the [Set a thread subscription](https://docs.github.com/rest/reference/activity#set-a-thread-subscription) endpoint and set &#x60;ignore&#x60; to &#x60;true&#x60;.
        /// </summary>
        /// <param name="threadId">The unique identifier of the pull request thread.</param>
        /// <returns></returns>
        void ActivityDeleteThreadSubscription (int? threadId);
        /// <summary>
        /// Get feeds GitHub provides several timeline resources in [Atom](http://en.wikipedia.org/wiki/Atom_(standard)) format. The Feeds API lists all the feeds available to the authenticated user:  *   **Timeline**: The GitHub global public timeline *   **User**: The public timeline for any user, using [URI template](https://docs.github.com/rest/overview/resources-in-the-rest-api#hypermedia) *   **Current user public**: The public timeline for the authenticated user *   **Current user**: The private timeline for the authenticated user *   **Current user actor**: The private timeline for activity created by the authenticated user *   **Current user organizations**: The private timeline for the organizations the authenticated user is a member of. *   **Security advisories**: A collection of public announcements that provide information about security-related vulnerabilities in software on GitHub.  **Note**: Private feeds are only returned when [authenticating via Basic Auth](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) since current feed URIs use the older, non revocable auth tokens.
        /// </summary>
        /// <returns>Feed</returns>
        Feed ActivityGetFeeds ();
        /// <summary>
        /// Get a repository subscription 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>RepositoryInvitation1</returns>
        RepositoryInvitation1 ActivityGetRepoSubscription (string owner, string repo);
        /// <summary>
        /// Get a thread 
        /// </summary>
        /// <param name="threadId">The unique identifier of the pull request thread.</param>
        /// <returns>Thread</returns>
        Thread ActivityGetThread (int? threadId);
        /// <summary>
        /// Get a thread subscription for the authenticated user This checks to see if the current user is subscribed to a thread. You can also [get a repository subscription](https://docs.github.com/rest/reference/activity#get-a-repository-subscription).  Note that subscriptions are only generated if a user is participating in a conversation- -for example, they&#39;ve replied to the thread, were **@mentioned**, or manually subscribe to a thread.
        /// </summary>
        /// <param name="threadId">The unique identifier of the pull request thread.</param>
        /// <returns>ThreadSubscription</returns>
        ThreadSubscription ActivityGetThreadSubscriptionForAuthenticatedUser (int? threadId);
        /// <summary>
        /// List events for the authenticated user If you are authenticated as the given user, you will see your private events. Otherwise, you&#39;ll only see public events.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Event&gt;</returns>
        List<Event> ActivityListEventsForAuthenticatedUser (string username, int? perPage, int? page);
        /// <summary>
        /// List notifications for the authenticated user List all notifications for the current user, sorted by most recently updated.
        /// </summary>
        /// <param name="all">If &#x60;true&#x60;, show notifications marked as read.</param>
        /// <param name="participating">If &#x60;true&#x60;, only shows notifications in which the user is directly participating or mentioned.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="before">Only show notifications updated before the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 50).</param>
        /// <returns>List&lt;Thread&gt;</returns>
        List<Thread> ActivityListNotificationsForAuthenticatedUser (bool? all, bool? participating, DateTime? since, DateTime? before, int? page, int? perPage);
        /// <summary>
        /// List organization events for the authenticated user This is the user&#39;s organization dashboard. You must be authenticated as the user to view this.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Event&gt;</returns>
        List<Event> ActivityListOrgEventsForAuthenticatedUser (string username, string org, int? perPage, int? page);
        /// <summary>
        /// List public events We delay the public events feed by five minutes, which means the most recent event returned by the public events API actually occurred at least five minutes ago.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Event&gt;</returns>
        List<Event> ActivityListPublicEvents (int? perPage, int? page);
        /// <summary>
        /// List public events for a network of repositories 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Event&gt;</returns>
        List<Event> ActivityListPublicEventsForRepoNetwork (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// List public events for a user 
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Event&gt;</returns>
        List<Event> ActivityListPublicEventsForUser (string username, int? perPage, int? page);
        /// <summary>
        /// List public organization events 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Event&gt;</returns>
        List<Event> ActivityListPublicOrgEvents (string org, int? perPage, int? page);
        /// <summary>
        /// List events received by the authenticated user These are events that you&#39;ve received by watching repos and following users. If you are authenticated as the given user, you will see private events. Otherwise, you&#39;ll only see public events.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Event&gt;</returns>
        List<Event> ActivityListReceivedEventsForUser (string username, int? perPage, int? page);
        /// <summary>
        /// List public events received by a user 
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Event&gt;</returns>
        List<Event> ActivityListReceivedPublicEventsForUser (string username, int? perPage, int? page);
        /// <summary>
        /// List repository events 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Event&gt;</returns>
        List<Event> ActivityListRepoEvents (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// List repository notifications for the authenticated user List all notifications for the current user.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="all">If &#x60;true&#x60;, show notifications marked as read.</param>
        /// <param name="participating">If &#x60;true&#x60;, only shows notifications in which the user is directly participating or mentioned.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="before">Only show notifications updated before the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Thread&gt;</returns>
        List<Thread> ActivityListRepoNotificationsForAuthenticatedUser (string owner, string repo, bool? all, bool? participating, DateTime? since, DateTime? before, int? perPage, int? page);
        /// <summary>
        /// List repositories starred by the authenticated user Lists repositories the authenticated user has starred.  You can also find out _when_ stars were created by passing the following custom [media type](https://docs.github.com/rest/overview/media-types/) via the &#x60;Accept&#x60; header:
        /// </summary>
        /// <param name="sort">The property to sort the results by. &#x60;created&#x60; means when the repository was starred. &#x60;updated&#x60; means when the repository was last pushed to.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Repository&gt;</returns>
        List<Repository> ActivityListReposStarredByAuthenticatedUser (string sort, string direction, int? perPage, int? page);
        /// <summary>
        /// List repositories starred by a user Lists repositories a user has starred.  You can also find out _when_ stars were created by passing the following custom [media type](https://docs.github.com/rest/overview/media-types/) via the &#x60;Accept&#x60; header:
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="sort">The property to sort the results by. &#x60;created&#x60; means when the repository was starred. &#x60;updated&#x60; means when the repository was last pushed to.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActivityListReposStarredByUser200Response</returns>
        ActivityListReposStarredByUser200Response ActivityListReposStarredByUser (string username, string sort, string direction, int? perPage, int? page);
        /// <summary>
        /// List repositories watched by a user Lists repositories a user is watching.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MinimalRepository&gt;</returns>
        List<MinimalRepository> ActivityListReposWatchedByUser (string username, int? perPage, int? page);
        /// <summary>
        /// List stargazers Lists the people that have starred the repository.  You can also find out _when_ stars were created by passing the following custom [media type](https://docs.github.com/rest/overview/media-types/) via the &#x60;Accept&#x60; header:
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActivityListStargazersForRepo200Response</returns>
        ActivityListStargazersForRepo200Response ActivityListStargazersForRepo (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// List repositories watched by the authenticated user Lists repositories the authenticated user is watching.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MinimalRepository&gt;</returns>
        List<MinimalRepository> ActivityListWatchedReposForAuthenticatedUser (int? perPage, int? page);
        /// <summary>
        /// List watchers Lists the people watching the specified repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        List<SimpleUser1> ActivityListWatchersForRepo (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// Mark notifications as read Marks all notifications as \&quot;read\&quot; removes it from the [default view on GitHub](https://github.com/notifications). If the number of notifications is too large to complete in one request, you will receive a &#x60;202 Accepted&#x60; status and GitHub will run an asynchronous process to mark notifications as \&quot;read.\&quot; To check whether any \&quot;unread\&quot; notifications remain, you can use the [List notifications for the authenticated user](https://docs.github.com/rest/reference/activity#list-notifications-for-the-authenticated-user) endpoint and pass the query parameter &#x60;all&#x3D;false&#x60;.
        /// </summary>
        /// <param name="activityMarkNotificationsAsReadRequest"></param>
        /// <returns>ActivityMarkNotificationsAsRead202Response</returns>
        ActivityMarkNotificationsAsRead202Response ActivityMarkNotificationsAsRead (ActivityMarkNotificationsAsReadRequest activityMarkNotificationsAsReadRequest);
        /// <summary>
        /// Mark repository notifications as read Marks all notifications in a repository as \&quot;read\&quot; removes them from the [default view on GitHub](https://github.com/notifications). If the number of notifications is too large to complete in one request, you will receive a &#x60;202 Accepted&#x60; status and GitHub will run an asynchronous process to mark notifications as \&quot;read.\&quot; To check whether any \&quot;unread\&quot; notifications remain, you can use the [List repository notifications for the authenticated user](https://docs.github.com/rest/reference/activity#list-repository-notifications-for-the-authenticated-user) endpoint and pass the query parameter &#x60;all&#x3D;false&#x60;.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="activityMarkRepoNotificationsAsReadRequest"></param>
        /// <returns>ActivityMarkRepoNotificationsAsRead202Response</returns>
        ActivityMarkRepoNotificationsAsRead202Response ActivityMarkRepoNotificationsAsRead (string owner, string repo, ActivityMarkRepoNotificationsAsReadRequest activityMarkRepoNotificationsAsReadRequest);
        /// <summary>
        /// Mark a thread as read 
        /// </summary>
        /// <param name="threadId">The unique identifier of the pull request thread.</param>
        /// <returns></returns>
        void ActivityMarkThreadAsRead (int? threadId);
        /// <summary>
        /// Set a repository subscription If you would like to watch a repository, set &#x60;subscribed&#x60; to &#x60;true&#x60;. If you would like to ignore notifications made within a repository, set &#x60;ignored&#x60; to &#x60;true&#x60;. If you would like to stop watching a repository, [delete the repository&#39;s subscription](https://docs.github.com/rest/reference/activity#delete-a-repository-subscription) completely.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="activitySetRepoSubscriptionRequest"></param>
        /// <returns>RepositoryInvitation1</returns>
        RepositoryInvitation1 ActivitySetRepoSubscription (string owner, string repo, ActivitySetRepoSubscriptionRequest activitySetRepoSubscriptionRequest);
        /// <summary>
        /// Set a thread subscription If you are watching a repository, you receive notifications for all threads by default. Use this endpoint to ignore future notifications for threads until you comment on the thread or get an **@mention**.  You can also use this endpoint to subscribe to threads that you are currently not receiving notifications for or to subscribed to threads that you have previously ignored.  Unsubscribing from a conversation in a repository that you are not watching is functionally equivalent to the [Delete a thread subscription](https://docs.github.com/rest/reference/activity#delete-a-thread-subscription) endpoint.
        /// </summary>
        /// <param name="threadId">The unique identifier of the pull request thread.</param>
        /// <param name="activitySetThreadSubscriptionRequest"></param>
        /// <returns>ThreadSubscription</returns>
        ThreadSubscription ActivitySetThreadSubscription (int? threadId, ActivitySetThreadSubscriptionRequest activitySetThreadSubscriptionRequest);
        /// <summary>
        /// Star a repository for the authenticated user Note that you&#39;ll need to set &#x60;Content-Length&#x60; to zero when calling out to this endpoint. For more information, see \&quot;[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\&quot;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        void ActivityStarRepoForAuthenticatedUser (string owner, string repo);
        /// <summary>
        /// Unstar a repository for the authenticated user 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        void ActivityUnstarRepoForAuthenticatedUser (string owner, string repo);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ActivityApi : IActivityApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ActivityApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ActivityApi(String basePath)
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
        /// Check if a repository is starred by the authenticated user 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        public void ActivityCheckRepoIsStarredByAuthenticatedUser (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActivityCheckRepoIsStarredByAuthenticatedUser");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActivityCheckRepoIsStarredByAuthenticatedUser");
            

            var path = "/user/starred/{owner}/{repo}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityCheckRepoIsStarredByAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityCheckRepoIsStarredByAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a repository subscription This endpoint should only be used to stop watching a repository. To control whether or not you wish to receive notifications from a repository, [set the repository&#39;s subscription manually](https://docs.github.com/rest/reference/activity#set-a-repository-subscription).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        public void ActivityDeleteRepoSubscription (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActivityDeleteRepoSubscription");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActivityDeleteRepoSubscription");
            

            var path = "/repos/{owner}/{repo}/subscription";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityDeleteRepoSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityDeleteRepoSubscription: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a thread subscription Mutes all future notifications for a conversation until you comment on the thread or get an **@mention**. If you are watching the repository of the thread, you will still receive notifications. To ignore future notifications for a repository you are watching, use the [Set a thread subscription](https://docs.github.com/rest/reference/activity#set-a-thread-subscription) endpoint and set &#x60;ignore&#x60; to &#x60;true&#x60;.
        /// </summary>
        /// <param name="threadId">The unique identifier of the pull request thread.</param>
        /// <returns></returns>
        public void ActivityDeleteThreadSubscription (int? threadId)
        {
            
            // verify the required parameter 'threadId' is set
            if (threadId == null) throw new ApiException(400, "Missing required parameter 'threadId' when calling ActivityDeleteThreadSubscription");
            

            var path = "/notifications/threads/{thread_id}/subscription";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "thread_id" + "}", ApiClient.ParameterToString(threadId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityDeleteThreadSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityDeleteThreadSubscription: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get feeds GitHub provides several timeline resources in [Atom](http://en.wikipedia.org/wiki/Atom_(standard)) format. The Feeds API lists all the feeds available to the authenticated user:  *   **Timeline**: The GitHub global public timeline *   **User**: The public timeline for any user, using [URI template](https://docs.github.com/rest/overview/resources-in-the-rest-api#hypermedia) *   **Current user public**: The public timeline for the authenticated user *   **Current user**: The private timeline for the authenticated user *   **Current user actor**: The private timeline for activity created by the authenticated user *   **Current user organizations**: The private timeline for the organizations the authenticated user is a member of. *   **Security advisories**: A collection of public announcements that provide information about security-related vulnerabilities in software on GitHub.  **Note**: Private feeds are only returned when [authenticating via Basic Auth](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) since current feed URIs use the older, non revocable auth tokens.
        /// </summary>
        /// <returns>Feed</returns>
        public Feed ActivityGetFeeds ()
        {
            

            var path = "/feeds";
            path = path.Replace("{format}", "json");
            
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityGetFeeds: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityGetFeeds: " + response.ErrorMessage, response.ErrorMessage);

            return (Feed) ApiClient.Deserialize(response.Content, typeof(Feed), response.Headers);
        }

        /// <summary>
        /// Get a repository subscription 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>RepositoryInvitation1</returns>
        public RepositoryInvitation1 ActivityGetRepoSubscription (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActivityGetRepoSubscription");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActivityGetRepoSubscription");
            

            var path = "/repos/{owner}/{repo}/subscription";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityGetRepoSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityGetRepoSubscription: " + response.ErrorMessage, response.ErrorMessage);

            return (RepositoryInvitation1) ApiClient.Deserialize(response.Content, typeof(RepositoryInvitation1), response.Headers);
        }

        /// <summary>
        /// Get a thread 
        /// </summary>
        /// <param name="threadId">The unique identifier of the pull request thread.</param>
        /// <returns>Thread</returns>
        public Thread ActivityGetThread (int? threadId)
        {
            
            // verify the required parameter 'threadId' is set
            if (threadId == null) throw new ApiException(400, "Missing required parameter 'threadId' when calling ActivityGetThread");
            

            var path = "/notifications/threads/{thread_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "thread_id" + "}", ApiClient.ParameterToString(threadId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityGetThread: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityGetThread: " + response.ErrorMessage, response.ErrorMessage);

            return (Thread) ApiClient.Deserialize(response.Content, typeof(Thread), response.Headers);
        }

        /// <summary>
        /// Get a thread subscription for the authenticated user This checks to see if the current user is subscribed to a thread. You can also [get a repository subscription](https://docs.github.com/rest/reference/activity#get-a-repository-subscription).  Note that subscriptions are only generated if a user is participating in a conversation- -for example, they&#39;ve replied to the thread, were **@mentioned**, or manually subscribe to a thread.
        /// </summary>
        /// <param name="threadId">The unique identifier of the pull request thread.</param>
        /// <returns>ThreadSubscription</returns>
        public ThreadSubscription ActivityGetThreadSubscriptionForAuthenticatedUser (int? threadId)
        {
            
            // verify the required parameter 'threadId' is set
            if (threadId == null) throw new ApiException(400, "Missing required parameter 'threadId' when calling ActivityGetThreadSubscriptionForAuthenticatedUser");
            

            var path = "/notifications/threads/{thread_id}/subscription";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "thread_id" + "}", ApiClient.ParameterToString(threadId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityGetThreadSubscriptionForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityGetThreadSubscriptionForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (ThreadSubscription) ApiClient.Deserialize(response.Content, typeof(ThreadSubscription), response.Headers);
        }

        /// <summary>
        /// List events for the authenticated user If you are authenticated as the given user, you will see your private events. Otherwise, you&#39;ll only see public events.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Event&gt;</returns>
        public List<Event> ActivityListEventsForAuthenticatedUser (string username, int? perPage, int? page)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling ActivityListEventsForAuthenticatedUser");
            

            var path = "/users/{username}/events";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListEventsForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListEventsForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Event>) ApiClient.Deserialize(response.Content, typeof(List<Event>), response.Headers);
        }

        /// <summary>
        /// List notifications for the authenticated user List all notifications for the current user, sorted by most recently updated.
        /// </summary>
        /// <param name="all">If &#x60;true&#x60;, show notifications marked as read.</param>
        /// <param name="participating">If &#x60;true&#x60;, only shows notifications in which the user is directly participating or mentioned.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="before">Only show notifications updated before the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 50).</param>
        /// <returns>List&lt;Thread&gt;</returns>
        public List<Thread> ActivityListNotificationsForAuthenticatedUser (bool? all, bool? participating, DateTime? since, DateTime? before, int? page, int? perPage)
        {
            

            var path = "/notifications";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (all != null) queryParams.Add("all", ApiClient.ParameterToString(all)); // query parameter
 if (participating != null) queryParams.Add("participating", ApiClient.ParameterToString(participating)); // query parameter
 if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
 if (before != null) queryParams.Add("before", ApiClient.ParameterToString(before)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListNotificationsForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListNotificationsForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Thread>) ApiClient.Deserialize(response.Content, typeof(List<Thread>), response.Headers);
        }

        /// <summary>
        /// List organization events for the authenticated user This is the user&#39;s organization dashboard. You must be authenticated as the user to view this.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Event&gt;</returns>
        public List<Event> ActivityListOrgEventsForAuthenticatedUser (string username, string org, int? perPage, int? page)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling ActivityListOrgEventsForAuthenticatedUser");
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActivityListOrgEventsForAuthenticatedUser");
            

            var path = "/users/{username}/events/orgs/{org}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));
path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListOrgEventsForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListOrgEventsForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Event>) ApiClient.Deserialize(response.Content, typeof(List<Event>), response.Headers);
        }

        /// <summary>
        /// List public events We delay the public events feed by five minutes, which means the most recent event returned by the public events API actually occurred at least five minutes ago.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Event&gt;</returns>
        public List<Event> ActivityListPublicEvents (int? perPage, int? page)
        {
            

            var path = "/events";
            path = path.Replace("{format}", "json");
            
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListPublicEvents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListPublicEvents: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Event>) ApiClient.Deserialize(response.Content, typeof(List<Event>), response.Headers);
        }

        /// <summary>
        /// List public events for a network of repositories 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Event&gt;</returns>
        public List<Event> ActivityListPublicEventsForRepoNetwork (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActivityListPublicEventsForRepoNetwork");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActivityListPublicEventsForRepoNetwork");
            

            var path = "/networks/{owner}/{repo}/events";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListPublicEventsForRepoNetwork: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListPublicEventsForRepoNetwork: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Event>) ApiClient.Deserialize(response.Content, typeof(List<Event>), response.Headers);
        }

        /// <summary>
        /// List public events for a user 
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Event&gt;</returns>
        public List<Event> ActivityListPublicEventsForUser (string username, int? perPage, int? page)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling ActivityListPublicEventsForUser");
            

            var path = "/users/{username}/events/public";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListPublicEventsForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListPublicEventsForUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Event>) ApiClient.Deserialize(response.Content, typeof(List<Event>), response.Headers);
        }

        /// <summary>
        /// List public organization events 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Event&gt;</returns>
        public List<Event> ActivityListPublicOrgEvents (string org, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActivityListPublicOrgEvents");
            

            var path = "/orgs/{org}/events";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListPublicOrgEvents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListPublicOrgEvents: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Event>) ApiClient.Deserialize(response.Content, typeof(List<Event>), response.Headers);
        }

        /// <summary>
        /// List events received by the authenticated user These are events that you&#39;ve received by watching repos and following users. If you are authenticated as the given user, you will see private events. Otherwise, you&#39;ll only see public events.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Event&gt;</returns>
        public List<Event> ActivityListReceivedEventsForUser (string username, int? perPage, int? page)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling ActivityListReceivedEventsForUser");
            

            var path = "/users/{username}/received_events";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListReceivedEventsForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListReceivedEventsForUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Event>) ApiClient.Deserialize(response.Content, typeof(List<Event>), response.Headers);
        }

        /// <summary>
        /// List public events received by a user 
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Event&gt;</returns>
        public List<Event> ActivityListReceivedPublicEventsForUser (string username, int? perPage, int? page)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling ActivityListReceivedPublicEventsForUser");
            

            var path = "/users/{username}/received_events/public";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListReceivedPublicEventsForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListReceivedPublicEventsForUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Event>) ApiClient.Deserialize(response.Content, typeof(List<Event>), response.Headers);
        }

        /// <summary>
        /// List repository events 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Event&gt;</returns>
        public List<Event> ActivityListRepoEvents (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActivityListRepoEvents");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActivityListRepoEvents");
            

            var path = "/repos/{owner}/{repo}/events";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListRepoEvents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListRepoEvents: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Event>) ApiClient.Deserialize(response.Content, typeof(List<Event>), response.Headers);
        }

        /// <summary>
        /// List repository notifications for the authenticated user List all notifications for the current user.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="all">If &#x60;true&#x60;, show notifications marked as read.</param>
        /// <param name="participating">If &#x60;true&#x60;, only shows notifications in which the user is directly participating or mentioned.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="before">Only show notifications updated before the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Thread&gt;</returns>
        public List<Thread> ActivityListRepoNotificationsForAuthenticatedUser (string owner, string repo, bool? all, bool? participating, DateTime? since, DateTime? before, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActivityListRepoNotificationsForAuthenticatedUser");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActivityListRepoNotificationsForAuthenticatedUser");
            

            var path = "/repos/{owner}/{repo}/notifications";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (all != null) queryParams.Add("all", ApiClient.ParameterToString(all)); // query parameter
 if (participating != null) queryParams.Add("participating", ApiClient.ParameterToString(participating)); // query parameter
 if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
 if (before != null) queryParams.Add("before", ApiClient.ParameterToString(before)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListRepoNotificationsForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListRepoNotificationsForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Thread>) ApiClient.Deserialize(response.Content, typeof(List<Thread>), response.Headers);
        }

        /// <summary>
        /// List repositories starred by the authenticated user Lists repositories the authenticated user has starred.  You can also find out _when_ stars were created by passing the following custom [media type](https://docs.github.com/rest/overview/media-types/) via the &#x60;Accept&#x60; header:
        /// </summary>
        /// <param name="sort">The property to sort the results by. &#x60;created&#x60; means when the repository was starred. &#x60;updated&#x60; means when the repository was last pushed to.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Repository&gt;</returns>
        public List<Repository> ActivityListReposStarredByAuthenticatedUser (string sort, string direction, int? perPage, int? page)
        {
            

            var path = "/user/starred";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListReposStarredByAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListReposStarredByAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Repository>) ApiClient.Deserialize(response.Content, typeof(List<Repository>), response.Headers);
        }

        /// <summary>
        /// List repositories starred by a user Lists repositories a user has starred.  You can also find out _when_ stars were created by passing the following custom [media type](https://docs.github.com/rest/overview/media-types/) via the &#x60;Accept&#x60; header:
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="sort">The property to sort the results by. &#x60;created&#x60; means when the repository was starred. &#x60;updated&#x60; means when the repository was last pushed to.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActivityListReposStarredByUser200Response</returns>
        public ActivityListReposStarredByUser200Response ActivityListReposStarredByUser (string username, string sort, string direction, int? perPage, int? page)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling ActivityListReposStarredByUser");
            

            var path = "/users/{username}/starred";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListReposStarredByUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListReposStarredByUser: " + response.ErrorMessage, response.ErrorMessage);

            return (ActivityListReposStarredByUser200Response) ApiClient.Deserialize(response.Content, typeof(ActivityListReposStarredByUser200Response), response.Headers);
        }

        /// <summary>
        /// List repositories watched by a user Lists repositories a user is watching.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MinimalRepository&gt;</returns>
        public List<MinimalRepository> ActivityListReposWatchedByUser (string username, int? perPage, int? page)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling ActivityListReposWatchedByUser");
            

            var path = "/users/{username}/subscriptions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListReposWatchedByUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListReposWatchedByUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<MinimalRepository>) ApiClient.Deserialize(response.Content, typeof(List<MinimalRepository>), response.Headers);
        }

        /// <summary>
        /// List stargazers Lists the people that have starred the repository.  You can also find out _when_ stars were created by passing the following custom [media type](https://docs.github.com/rest/overview/media-types/) via the &#x60;Accept&#x60; header:
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActivityListStargazersForRepo200Response</returns>
        public ActivityListStargazersForRepo200Response ActivityListStargazersForRepo (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActivityListStargazersForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActivityListStargazersForRepo");
            

            var path = "/repos/{owner}/{repo}/stargazers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListStargazersForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListStargazersForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (ActivityListStargazersForRepo200Response) ApiClient.Deserialize(response.Content, typeof(ActivityListStargazersForRepo200Response), response.Headers);
        }

        /// <summary>
        /// List repositories watched by the authenticated user Lists repositories the authenticated user is watching.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MinimalRepository&gt;</returns>
        public List<MinimalRepository> ActivityListWatchedReposForAuthenticatedUser (int? perPage, int? page)
        {
            

            var path = "/user/subscriptions";
            path = path.Replace("{format}", "json");
            
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListWatchedReposForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListWatchedReposForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<MinimalRepository>) ApiClient.Deserialize(response.Content, typeof(List<MinimalRepository>), response.Headers);
        }

        /// <summary>
        /// List watchers Lists the people watching the specified repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        public List<SimpleUser1> ActivityListWatchersForRepo (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActivityListWatchersForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActivityListWatchersForRepo");
            

            var path = "/repos/{owner}/{repo}/subscribers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListWatchersForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityListWatchersForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SimpleUser1>) ApiClient.Deserialize(response.Content, typeof(List<SimpleUser1>), response.Headers);
        }

        /// <summary>
        /// Mark notifications as read Marks all notifications as \&quot;read\&quot; removes it from the [default view on GitHub](https://github.com/notifications). If the number of notifications is too large to complete in one request, you will receive a &#x60;202 Accepted&#x60; status and GitHub will run an asynchronous process to mark notifications as \&quot;read.\&quot; To check whether any \&quot;unread\&quot; notifications remain, you can use the [List notifications for the authenticated user](https://docs.github.com/rest/reference/activity#list-notifications-for-the-authenticated-user) endpoint and pass the query parameter &#x60;all&#x3D;false&#x60;.
        /// </summary>
        /// <param name="activityMarkNotificationsAsReadRequest"></param>
        /// <returns>ActivityMarkNotificationsAsRead202Response</returns>
        public ActivityMarkNotificationsAsRead202Response ActivityMarkNotificationsAsRead (ActivityMarkNotificationsAsReadRequest activityMarkNotificationsAsReadRequest)
        {
            

            var path = "/notifications";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(activityMarkNotificationsAsReadRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityMarkNotificationsAsRead: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityMarkNotificationsAsRead: " + response.ErrorMessage, response.ErrorMessage);

            return (ActivityMarkNotificationsAsRead202Response) ApiClient.Deserialize(response.Content, typeof(ActivityMarkNotificationsAsRead202Response), response.Headers);
        }

        /// <summary>
        /// Mark repository notifications as read Marks all notifications in a repository as \&quot;read\&quot; removes them from the [default view on GitHub](https://github.com/notifications). If the number of notifications is too large to complete in one request, you will receive a &#x60;202 Accepted&#x60; status and GitHub will run an asynchronous process to mark notifications as \&quot;read.\&quot; To check whether any \&quot;unread\&quot; notifications remain, you can use the [List repository notifications for the authenticated user](https://docs.github.com/rest/reference/activity#list-repository-notifications-for-the-authenticated-user) endpoint and pass the query parameter &#x60;all&#x3D;false&#x60;.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="activityMarkRepoNotificationsAsReadRequest"></param>
        /// <returns>ActivityMarkRepoNotificationsAsRead202Response</returns>
        public ActivityMarkRepoNotificationsAsRead202Response ActivityMarkRepoNotificationsAsRead (string owner, string repo, ActivityMarkRepoNotificationsAsReadRequest activityMarkRepoNotificationsAsReadRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActivityMarkRepoNotificationsAsRead");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActivityMarkRepoNotificationsAsRead");
            

            var path = "/repos/{owner}/{repo}/notifications";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(activityMarkRepoNotificationsAsReadRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityMarkRepoNotificationsAsRead: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityMarkRepoNotificationsAsRead: " + response.ErrorMessage, response.ErrorMessage);

            return (ActivityMarkRepoNotificationsAsRead202Response) ApiClient.Deserialize(response.Content, typeof(ActivityMarkRepoNotificationsAsRead202Response), response.Headers);
        }

        /// <summary>
        /// Mark a thread as read 
        /// </summary>
        /// <param name="threadId">The unique identifier of the pull request thread.</param>
        /// <returns></returns>
        public void ActivityMarkThreadAsRead (int? threadId)
        {
            
            // verify the required parameter 'threadId' is set
            if (threadId == null) throw new ApiException(400, "Missing required parameter 'threadId' when calling ActivityMarkThreadAsRead");
            

            var path = "/notifications/threads/{thread_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "thread_id" + "}", ApiClient.ParameterToString(threadId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityMarkThreadAsRead: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityMarkThreadAsRead: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Set a repository subscription If you would like to watch a repository, set &#x60;subscribed&#x60; to &#x60;true&#x60;. If you would like to ignore notifications made within a repository, set &#x60;ignored&#x60; to &#x60;true&#x60;. If you would like to stop watching a repository, [delete the repository&#39;s subscription](https://docs.github.com/rest/reference/activity#delete-a-repository-subscription) completely.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="activitySetRepoSubscriptionRequest"></param>
        /// <returns>RepositoryInvitation1</returns>
        public RepositoryInvitation1 ActivitySetRepoSubscription (string owner, string repo, ActivitySetRepoSubscriptionRequest activitySetRepoSubscriptionRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActivitySetRepoSubscription");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActivitySetRepoSubscription");
            

            var path = "/repos/{owner}/{repo}/subscription";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(activitySetRepoSubscriptionRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivitySetRepoSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivitySetRepoSubscription: " + response.ErrorMessage, response.ErrorMessage);

            return (RepositoryInvitation1) ApiClient.Deserialize(response.Content, typeof(RepositoryInvitation1), response.Headers);
        }

        /// <summary>
        /// Set a thread subscription If you are watching a repository, you receive notifications for all threads by default. Use this endpoint to ignore future notifications for threads until you comment on the thread or get an **@mention**.  You can also use this endpoint to subscribe to threads that you are currently not receiving notifications for or to subscribed to threads that you have previously ignored.  Unsubscribing from a conversation in a repository that you are not watching is functionally equivalent to the [Delete a thread subscription](https://docs.github.com/rest/reference/activity#delete-a-thread-subscription) endpoint.
        /// </summary>
        /// <param name="threadId">The unique identifier of the pull request thread.</param>
        /// <param name="activitySetThreadSubscriptionRequest"></param>
        /// <returns>ThreadSubscription</returns>
        public ThreadSubscription ActivitySetThreadSubscription (int? threadId, ActivitySetThreadSubscriptionRequest activitySetThreadSubscriptionRequest)
        {
            
            // verify the required parameter 'threadId' is set
            if (threadId == null) throw new ApiException(400, "Missing required parameter 'threadId' when calling ActivitySetThreadSubscription");
            

            var path = "/notifications/threads/{thread_id}/subscription";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "thread_id" + "}", ApiClient.ParameterToString(threadId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(activitySetThreadSubscriptionRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivitySetThreadSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivitySetThreadSubscription: " + response.ErrorMessage, response.ErrorMessage);

            return (ThreadSubscription) ApiClient.Deserialize(response.Content, typeof(ThreadSubscription), response.Headers);
        }

        /// <summary>
        /// Star a repository for the authenticated user Note that you&#39;ll need to set &#x60;Content-Length&#x60; to zero when calling out to this endpoint. For more information, see \&quot;[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\&quot;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        public void ActivityStarRepoForAuthenticatedUser (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActivityStarRepoForAuthenticatedUser");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActivityStarRepoForAuthenticatedUser");
            

            var path = "/user/starred/{owner}/{repo}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityStarRepoForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityStarRepoForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Unstar a repository for the authenticated user 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        public void ActivityUnstarRepoForAuthenticatedUser (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActivityUnstarRepoForAuthenticatedUser");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActivityUnstarRepoForAuthenticatedUser");
            

            var path = "/user/starred/{owner}/{repo}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityUnstarRepoForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActivityUnstarRepoForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

    }
}
