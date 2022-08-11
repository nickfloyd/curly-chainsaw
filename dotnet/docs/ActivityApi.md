# Org.OpenAPITools.Api.ActivityApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivityCheckRepoIsStarredByAuthenticatedUser**](ActivityApi.md#activitycheckrepoisstarredbyauthenticateduser) | **GET** /user/starred/{owner}/{repo} | Check if a repository is starred by the authenticated user
[**ActivityDeleteRepoSubscription**](ActivityApi.md#activitydeletereposubscription) | **DELETE** /repos/{owner}/{repo}/subscription | Delete a repository subscription
[**ActivityDeleteThreadSubscription**](ActivityApi.md#activitydeletethreadsubscription) | **DELETE** /notifications/threads/{thread_id}/subscription | Delete a thread subscription
[**ActivityGetFeeds**](ActivityApi.md#activitygetfeeds) | **GET** /feeds | Get feeds
[**ActivityGetRepoSubscription**](ActivityApi.md#activitygetreposubscription) | **GET** /repos/{owner}/{repo}/subscription | Get a repository subscription
[**ActivityGetThread**](ActivityApi.md#activitygetthread) | **GET** /notifications/threads/{thread_id} | Get a thread
[**ActivityGetThreadSubscriptionForAuthenticatedUser**](ActivityApi.md#activitygetthreadsubscriptionforauthenticateduser) | **GET** /notifications/threads/{thread_id}/subscription | Get a thread subscription for the authenticated user
[**ActivityListEventsForAuthenticatedUser**](ActivityApi.md#activitylisteventsforauthenticateduser) | **GET** /users/{username}/events | List events for the authenticated user
[**ActivityListNotificationsForAuthenticatedUser**](ActivityApi.md#activitylistnotificationsforauthenticateduser) | **GET** /notifications | List notifications for the authenticated user
[**ActivityListOrgEventsForAuthenticatedUser**](ActivityApi.md#activitylistorgeventsforauthenticateduser) | **GET** /users/{username}/events/orgs/{org} | List organization events for the authenticated user
[**ActivityListPublicEvents**](ActivityApi.md#activitylistpublicevents) | **GET** /events | List public events
[**ActivityListPublicEventsForRepoNetwork**](ActivityApi.md#activitylistpubliceventsforreponetwork) | **GET** /networks/{owner}/{repo}/events | List public events for a network of repositories
[**ActivityListPublicEventsForUser**](ActivityApi.md#activitylistpubliceventsforuser) | **GET** /users/{username}/events/public | List public events for a user
[**ActivityListPublicOrgEvents**](ActivityApi.md#activitylistpublicorgevents) | **GET** /orgs/{org}/events | List public organization events
[**ActivityListReceivedEventsForUser**](ActivityApi.md#activitylistreceivedeventsforuser) | **GET** /users/{username}/received_events | List events received by the authenticated user
[**ActivityListReceivedPublicEventsForUser**](ActivityApi.md#activitylistreceivedpubliceventsforuser) | **GET** /users/{username}/received_events/public | List public events received by a user
[**ActivityListRepoEvents**](ActivityApi.md#activitylistrepoevents) | **GET** /repos/{owner}/{repo}/events | List repository events
[**ActivityListRepoNotificationsForAuthenticatedUser**](ActivityApi.md#activitylistreponotificationsforauthenticateduser) | **GET** /repos/{owner}/{repo}/notifications | List repository notifications for the authenticated user
[**ActivityListReposStarredByAuthenticatedUser**](ActivityApi.md#activitylistreposstarredbyauthenticateduser) | **GET** /user/starred | List repositories starred by the authenticated user
[**ActivityListReposStarredByUser**](ActivityApi.md#activitylistreposstarredbyuser) | **GET** /users/{username}/starred | List repositories starred by a user
[**ActivityListReposWatchedByUser**](ActivityApi.md#activitylistreposwatchedbyuser) | **GET** /users/{username}/subscriptions | List repositories watched by a user
[**ActivityListStargazersForRepo**](ActivityApi.md#activityliststargazersforrepo) | **GET** /repos/{owner}/{repo}/stargazers | List stargazers
[**ActivityListWatchedReposForAuthenticatedUser**](ActivityApi.md#activitylistwatchedreposforauthenticateduser) | **GET** /user/subscriptions | List repositories watched by the authenticated user
[**ActivityListWatchersForRepo**](ActivityApi.md#activitylistwatchersforrepo) | **GET** /repos/{owner}/{repo}/subscribers | List watchers
[**ActivityMarkNotificationsAsRead**](ActivityApi.md#activitymarknotificationsasread) | **PUT** /notifications | Mark notifications as read
[**ActivityMarkRepoNotificationsAsRead**](ActivityApi.md#activitymarkreponotificationsasread) | **PUT** /repos/{owner}/{repo}/notifications | Mark repository notifications as read
[**ActivityMarkThreadAsRead**](ActivityApi.md#activitymarkthreadasread) | **PATCH** /notifications/threads/{thread_id} | Mark a thread as read
[**ActivitySetRepoSubscription**](ActivityApi.md#activitysetreposubscription) | **PUT** /repos/{owner}/{repo}/subscription | Set a repository subscription
[**ActivitySetThreadSubscription**](ActivityApi.md#activitysetthreadsubscription) | **PUT** /notifications/threads/{thread_id}/subscription | Set a thread subscription
[**ActivityStarRepoForAuthenticatedUser**](ActivityApi.md#activitystarrepoforauthenticateduser) | **PUT** /user/starred/{owner}/{repo} | Star a repository for the authenticated user
[**ActivityUnstarRepoForAuthenticatedUser**](ActivityApi.md#activityunstarrepoforauthenticateduser) | **DELETE** /user/starred/{owner}/{repo} | Unstar a repository for the authenticated user


<a name="activitycheckrepoisstarredbyauthenticateduser"></a>
# **ActivityCheckRepoIsStarredByAuthenticatedUser**
> void ActivityCheckRepoIsStarredByAuthenticatedUser (string owner, string repo)

Check if a repository is starred by the authenticated user



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityCheckRepoIsStarredByAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Check if a repository is starred by the authenticated user
                apiInstance.ActivityCheckRepoIsStarredByAuthenticatedUser(owner, repo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityCheckRepoIsStarredByAuthenticatedUser: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitydeletereposubscription"></a>
# **ActivityDeleteRepoSubscription**
> void ActivityDeleteRepoSubscription (string owner, string repo)

Delete a repository subscription

This endpoint should only be used to stop watching a repository. To control whether or not you wish to receive notifications from a repository, [set the repository's subscription manually](https://docs.github.com/rest/reference/activity#set-a-repository-subscription).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityDeleteRepoSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Delete a repository subscription
                apiInstance.ActivityDeleteRepoSubscription(owner, repo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityDeleteRepoSubscription: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitydeletethreadsubscription"></a>
# **ActivityDeleteThreadSubscription**
> void ActivityDeleteThreadSubscription (int? threadId)

Delete a thread subscription

Mutes all future notifications for a conversation until you comment on the thread or get an **@mention**. If you are watching the repository of the thread, you will still receive notifications. To ignore future notifications for a repository you are watching, use the [Set a thread subscription](https://docs.github.com/rest/reference/activity#set-a-thread-subscription) endpoint and set `ignore` to `true`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityDeleteThreadSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var threadId = 56;  // int? | The unique identifier of the pull request thread.

            try
            {
                // Delete a thread subscription
                apiInstance.ActivityDeleteThreadSubscription(threadId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityDeleteThreadSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **int?**| The unique identifier of the pull request thread. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitygetfeeds"></a>
# **ActivityGetFeeds**
> Feed ActivityGetFeeds ()

Get feeds

GitHub provides several timeline resources in [Atom](http://en.wikipedia.org/wiki/Atom_(standard)) format. The Feeds API lists all the feeds available to the authenticated user:  *   **Timeline**: The GitHub global public timeline *   **User**: The public timeline for any user, using [URI template](https://docs.github.com/rest/overview/resources-in-the-rest-api#hypermedia) *   **Current user public**: The public timeline for the authenticated user *   **Current user**: The private timeline for the authenticated user *   **Current user actor**: The private timeline for activity created by the authenticated user *   **Current user organizations**: The private timeline for the organizations the authenticated user is a member of. *   **Security advisories**: A collection of public announcements that provide information about security-related vulnerabilities in software on GitHub.  **Note**: Private feeds are only returned when [authenticating via Basic Auth](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) since current feed URIs use the older, non revocable auth tokens.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityGetFeedsExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();

            try
            {
                // Get feeds
                Feed result = apiInstance.ActivityGetFeeds();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityGetFeeds: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Feed**](Feed.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitygetreposubscription"></a>
# **ActivityGetRepoSubscription**
> RepositoryInvitation1 ActivityGetRepoSubscription (string owner, string repo)

Get a repository subscription



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityGetRepoSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get a repository subscription
                RepositoryInvitation1 result = apiInstance.ActivityGetRepoSubscription(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityGetRepoSubscription: " + e.Message );
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

### Return type

[**RepositoryInvitation1**](RepositoryInvitation1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitygetthread"></a>
# **ActivityGetThread**
> Thread ActivityGetThread (int? threadId)

Get a thread



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityGetThreadExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var threadId = 56;  // int? | The unique identifier of the pull request thread.

            try
            {
                // Get a thread
                Thread result = apiInstance.ActivityGetThread(threadId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityGetThread: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **int?**| The unique identifier of the pull request thread. | 

### Return type

[**Thread**](Thread.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitygetthreadsubscriptionforauthenticateduser"></a>
# **ActivityGetThreadSubscriptionForAuthenticatedUser**
> ThreadSubscription ActivityGetThreadSubscriptionForAuthenticatedUser (int? threadId)

Get a thread subscription for the authenticated user

This checks to see if the current user is subscribed to a thread. You can also [get a repository subscription](https://docs.github.com/rest/reference/activity#get-a-repository-subscription).  Note that subscriptions are only generated if a user is participating in a conversation- -for example, they've replied to the thread, were **@mentioned**, or manually subscribe to a thread.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityGetThreadSubscriptionForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var threadId = 56;  // int? | The unique identifier of the pull request thread.

            try
            {
                // Get a thread subscription for the authenticated user
                ThreadSubscription result = apiInstance.ActivityGetThreadSubscriptionForAuthenticatedUser(threadId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityGetThreadSubscriptionForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **int?**| The unique identifier of the pull request thread. | 

### Return type

[**ThreadSubscription**](ThreadSubscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitylisteventsforauthenticateduser"></a>
# **ActivityListEventsForAuthenticatedUser**
> List<Event> ActivityListEventsForAuthenticatedUser (string username, int? perPage, int? page)

List events for the authenticated user

If you are authenticated as the given user, you will see your private events. Otherwise, you'll only see public events.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityListEventsForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var username = "username_example";  // string | The handle for the GitHub user account.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List events for the authenticated user
                List&lt;Event&gt; result = apiInstance.ActivityListEventsForAuthenticatedUser(username, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityListEventsForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Event>**](Event.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitylistnotificationsforauthenticateduser"></a>
# **ActivityListNotificationsForAuthenticatedUser**
> List<Thread> ActivityListNotificationsForAuthenticatedUser (bool? all, bool? participating, DateTime? since, DateTime? before, int? page, int? perPage)

List notifications for the authenticated user

List all notifications for the current user, sorted by most recently updated.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityListNotificationsForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var all = false;  // bool? | If `true`, show notifications marked as read. (optional)  (default to false)
            var participating = false;  // bool? | If `true`, only shows notifications in which the user is directly participating or mentioned. (optional)  (default to false)
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show notifications updated before the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. (optional) 
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var perPage = 50;  // int? | The number of results per page (max 50). (optional)  (default to 50)

            try
            {
                // List notifications for the authenticated user
                List&lt;Thread&gt; result = apiInstance.ActivityListNotificationsForAuthenticatedUser(all, participating, since, before, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityListNotificationsForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **all** | **bool?**| If &#x60;true&#x60;, show notifications marked as read. | [optional] [default to false]
 **participating** | **bool?**| If &#x60;true&#x60;, only shows notifications in which the user is directly participating or mentioned. | [optional] [default to false]
 **since** | **DateTime?**| Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
 **before** | **DateTime?**| Only show notifications updated before the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **perPage** | **int?**| The number of results per page (max 50). | [optional] [default to 50]

### Return type

[**List<Thread>**](Thread.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitylistorgeventsforauthenticateduser"></a>
# **ActivityListOrgEventsForAuthenticatedUser**
> List<Event> ActivityListOrgEventsForAuthenticatedUser (string username, string org, int? perPage, int? page)

List organization events for the authenticated user

This is the user's organization dashboard. You must be authenticated as the user to view this.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityListOrgEventsForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var username = "username_example";  // string | The handle for the GitHub user account.
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List organization events for the authenticated user
                List&lt;Event&gt; result = apiInstance.ActivityListOrgEventsForAuthenticatedUser(username, org, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityListOrgEventsForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Event>**](Event.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitylistpublicevents"></a>
# **ActivityListPublicEvents**
> List<Event> ActivityListPublicEvents (int? perPage, int? page)

List public events

We delay the public events feed by five minutes, which means the most recent event returned by the public events API actually occurred at least five minutes ago.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityListPublicEventsExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List public events
                List&lt;Event&gt; result = apiInstance.ActivityListPublicEvents(perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityListPublicEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Event>**](Event.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitylistpubliceventsforreponetwork"></a>
# **ActivityListPublicEventsForRepoNetwork**
> List<Event> ActivityListPublicEventsForRepoNetwork (string owner, string repo, int? perPage, int? page)

List public events for a network of repositories



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityListPublicEventsForRepoNetworkExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List public events for a network of repositories
                List&lt;Event&gt; result = apiInstance.ActivityListPublicEventsForRepoNetwork(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityListPublicEventsForRepoNetwork: " + e.Message );
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
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Event>**](Event.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitylistpubliceventsforuser"></a>
# **ActivityListPublicEventsForUser**
> List<Event> ActivityListPublicEventsForUser (string username, int? perPage, int? page)

List public events for a user



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityListPublicEventsForUserExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var username = "username_example";  // string | The handle for the GitHub user account.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List public events for a user
                List&lt;Event&gt; result = apiInstance.ActivityListPublicEventsForUser(username, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityListPublicEventsForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Event>**](Event.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitylistpublicorgevents"></a>
# **ActivityListPublicOrgEvents**
> List<Event> ActivityListPublicOrgEvents (string org, int? perPage, int? page)

List public organization events



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityListPublicOrgEventsExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List public organization events
                List&lt;Event&gt; result = apiInstance.ActivityListPublicOrgEvents(org, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityListPublicOrgEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Event>**](Event.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitylistreceivedeventsforuser"></a>
# **ActivityListReceivedEventsForUser**
> List<Event> ActivityListReceivedEventsForUser (string username, int? perPage, int? page)

List events received by the authenticated user

These are events that you've received by watching repos and following users. If you are authenticated as the given user, you will see private events. Otherwise, you'll only see public events.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityListReceivedEventsForUserExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var username = "username_example";  // string | The handle for the GitHub user account.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List events received by the authenticated user
                List&lt;Event&gt; result = apiInstance.ActivityListReceivedEventsForUser(username, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityListReceivedEventsForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Event>**](Event.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitylistreceivedpubliceventsforuser"></a>
# **ActivityListReceivedPublicEventsForUser**
> List<Event> ActivityListReceivedPublicEventsForUser (string username, int? perPage, int? page)

List public events received by a user



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityListReceivedPublicEventsForUserExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var username = "username_example";  // string | The handle for the GitHub user account.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List public events received by a user
                List&lt;Event&gt; result = apiInstance.ActivityListReceivedPublicEventsForUser(username, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityListReceivedPublicEventsForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Event>**](Event.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitylistrepoevents"></a>
# **ActivityListRepoEvents**
> List<Event> ActivityListRepoEvents (string owner, string repo, int? perPage, int? page)

List repository events



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityListRepoEventsExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repository events
                List&lt;Event&gt; result = apiInstance.ActivityListRepoEvents(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityListRepoEvents: " + e.Message );
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
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Event>**](Event.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitylistreponotificationsforauthenticateduser"></a>
# **ActivityListRepoNotificationsForAuthenticatedUser**
> List<Thread> ActivityListRepoNotificationsForAuthenticatedUser (string owner, string repo, bool? all, bool? participating, DateTime? since, DateTime? before, int? perPage, int? page)

List repository notifications for the authenticated user

List all notifications for the current user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityListRepoNotificationsForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var all = false;  // bool? | If `true`, show notifications marked as read. (optional)  (default to false)
            var participating = false;  // bool? | If `true`, only shows notifications in which the user is directly participating or mentioned. (optional)  (default to false)
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show notifications updated before the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repository notifications for the authenticated user
                List&lt;Thread&gt; result = apiInstance.ActivityListRepoNotificationsForAuthenticatedUser(owner, repo, all, participating, since, before, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityListRepoNotificationsForAuthenticatedUser: " + e.Message );
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
 **all** | **bool?**| If &#x60;true&#x60;, show notifications marked as read. | [optional] [default to false]
 **participating** | **bool?**| If &#x60;true&#x60;, only shows notifications in which the user is directly participating or mentioned. | [optional] [default to false]
 **since** | **DateTime?**| Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
 **before** | **DateTime?**| Only show notifications updated before the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Thread>**](Thread.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitylistreposstarredbyauthenticateduser"></a>
# **ActivityListReposStarredByAuthenticatedUser**
> List<Repository> ActivityListReposStarredByAuthenticatedUser (string sort, string direction, int? perPage, int? page)

List repositories starred by the authenticated user

Lists repositories the authenticated user has starred.  You can also find out _when_ stars were created by passing the following custom [media type](https://docs.github.com/rest/overview/media-types/) via the `Accept` header:

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityListReposStarredByAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var sort = "created";  // string | The property to sort the results by. `created` means when the repository was starred. `updated` means when the repository was last pushed to. (optional)  (default to created)
            var direction = "asc";  // string | The direction to sort the results by. (optional)  (default to desc)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repositories starred by the authenticated user
                List&lt;Repository&gt; result = apiInstance.ActivityListReposStarredByAuthenticatedUser(sort, direction, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityListReposStarredByAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sort** | **string**| The property to sort the results by. &#x60;created&#x60; means when the repository was starred. &#x60;updated&#x60; means when the repository was last pushed to. | [optional] [default to created]
 **direction** | **string**| The direction to sort the results by. | [optional] [default to desc]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Repository>**](Repository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.github.v3.star+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitylistreposstarredbyuser"></a>
# **ActivityListReposStarredByUser**
> ActivityListReposStarredByUser200Response ActivityListReposStarredByUser (string username, string sort, string direction, int? perPage, int? page)

List repositories starred by a user

Lists repositories a user has starred.  You can also find out _when_ stars were created by passing the following custom [media type](https://docs.github.com/rest/overview/media-types/) via the `Accept` header:

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityListReposStarredByUserExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var username = "username_example";  // string | The handle for the GitHub user account.
            var sort = "created";  // string | The property to sort the results by. `created` means when the repository was starred. `updated` means when the repository was last pushed to. (optional)  (default to created)
            var direction = "asc";  // string | The direction to sort the results by. (optional)  (default to desc)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repositories starred by a user
                ActivityListReposStarredByUser200Response result = apiInstance.ActivityListReposStarredByUser(username, sort, direction, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityListReposStarredByUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 
 **sort** | **string**| The property to sort the results by. &#x60;created&#x60; means when the repository was starred. &#x60;updated&#x60; means when the repository was last pushed to. | [optional] [default to created]
 **direction** | **string**| The direction to sort the results by. | [optional] [default to desc]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**ActivityListReposStarredByUser200Response**](ActivityListReposStarredByUser200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitylistreposwatchedbyuser"></a>
# **ActivityListReposWatchedByUser**
> List<MinimalRepository> ActivityListReposWatchedByUser (string username, int? perPage, int? page)

List repositories watched by a user

Lists repositories a user is watching.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityListReposWatchedByUserExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var username = "username_example";  // string | The handle for the GitHub user account.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repositories watched by a user
                List&lt;MinimalRepository&gt; result = apiInstance.ActivityListReposWatchedByUser(username, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityListReposWatchedByUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<MinimalRepository>**](MinimalRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activityliststargazersforrepo"></a>
# **ActivityListStargazersForRepo**
> ActivityListStargazersForRepo200Response ActivityListStargazersForRepo (string owner, string repo, int? perPage, int? page)

List stargazers

Lists the people that have starred the repository.  You can also find out _when_ stars were created by passing the following custom [media type](https://docs.github.com/rest/overview/media-types/) via the `Accept` header:

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityListStargazersForRepoExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List stargazers
                ActivityListStargazersForRepo200Response result = apiInstance.ActivityListStargazersForRepo(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityListStargazersForRepo: " + e.Message );
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
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**ActivityListStargazersForRepo200Response**](ActivityListStargazersForRepo200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitylistwatchedreposforauthenticateduser"></a>
# **ActivityListWatchedReposForAuthenticatedUser**
> List<MinimalRepository> ActivityListWatchedReposForAuthenticatedUser (int? perPage, int? page)

List repositories watched by the authenticated user

Lists repositories the authenticated user is watching.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityListWatchedReposForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repositories watched by the authenticated user
                List&lt;MinimalRepository&gt; result = apiInstance.ActivityListWatchedReposForAuthenticatedUser(perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityListWatchedReposForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<MinimalRepository>**](MinimalRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitylistwatchersforrepo"></a>
# **ActivityListWatchersForRepo**
> List<SimpleUser1> ActivityListWatchersForRepo (string owner, string repo, int? perPage, int? page)

List watchers

Lists the people watching the specified repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityListWatchersForRepoExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List watchers
                List&lt;SimpleUser1&gt; result = apiInstance.ActivityListWatchersForRepo(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityListWatchersForRepo: " + e.Message );
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
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<SimpleUser1>**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitymarknotificationsasread"></a>
# **ActivityMarkNotificationsAsRead**
> ActivityMarkNotificationsAsRead202Response ActivityMarkNotificationsAsRead (ActivityMarkNotificationsAsReadRequest activityMarkNotificationsAsReadRequest)

Mark notifications as read

Marks all notifications as \"read\" removes it from the [default view on GitHub](https://github.com/notifications). If the number of notifications is too large to complete in one request, you will receive a `202 Accepted` status and GitHub will run an asynchronous process to mark notifications as \"read.\" To check whether any \"unread\" notifications remain, you can use the [List notifications for the authenticated user](https://docs.github.com/rest/reference/activity#list-notifications-for-the-authenticated-user) endpoint and pass the query parameter `all=false`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityMarkNotificationsAsReadExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var activityMarkNotificationsAsReadRequest = new ActivityMarkNotificationsAsReadRequest(); // ActivityMarkNotificationsAsReadRequest |  (optional) 

            try
            {
                // Mark notifications as read
                ActivityMarkNotificationsAsRead202Response result = apiInstance.ActivityMarkNotificationsAsRead(activityMarkNotificationsAsReadRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityMarkNotificationsAsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityMarkNotificationsAsReadRequest** | [**ActivityMarkNotificationsAsReadRequest**](ActivityMarkNotificationsAsReadRequest.md)|  | [optional] 

### Return type

[**ActivityMarkNotificationsAsRead202Response**](ActivityMarkNotificationsAsRead202Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitymarkreponotificationsasread"></a>
# **ActivityMarkRepoNotificationsAsRead**
> ActivityMarkRepoNotificationsAsRead202Response ActivityMarkRepoNotificationsAsRead (string owner, string repo, ActivityMarkRepoNotificationsAsReadRequest activityMarkRepoNotificationsAsReadRequest)

Mark repository notifications as read

Marks all notifications in a repository as \"read\" removes them from the [default view on GitHub](https://github.com/notifications). If the number of notifications is too large to complete in one request, you will receive a `202 Accepted` status and GitHub will run an asynchronous process to mark notifications as \"read.\" To check whether any \"unread\" notifications remain, you can use the [List repository notifications for the authenticated user](https://docs.github.com/rest/reference/activity#list-repository-notifications-for-the-authenticated-user) endpoint and pass the query parameter `all=false`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityMarkRepoNotificationsAsReadExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var activityMarkRepoNotificationsAsReadRequest = new ActivityMarkRepoNotificationsAsReadRequest(); // ActivityMarkRepoNotificationsAsReadRequest |  (optional) 

            try
            {
                // Mark repository notifications as read
                ActivityMarkRepoNotificationsAsRead202Response result = apiInstance.ActivityMarkRepoNotificationsAsRead(owner, repo, activityMarkRepoNotificationsAsReadRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityMarkRepoNotificationsAsRead: " + e.Message );
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
 **activityMarkRepoNotificationsAsReadRequest** | [**ActivityMarkRepoNotificationsAsReadRequest**](ActivityMarkRepoNotificationsAsReadRequest.md)|  | [optional] 

### Return type

[**ActivityMarkRepoNotificationsAsRead202Response**](ActivityMarkRepoNotificationsAsRead202Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitymarkthreadasread"></a>
# **ActivityMarkThreadAsRead**
> void ActivityMarkThreadAsRead (int? threadId)

Mark a thread as read



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityMarkThreadAsReadExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var threadId = 56;  // int? | The unique identifier of the pull request thread.

            try
            {
                // Mark a thread as read
                apiInstance.ActivityMarkThreadAsRead(threadId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityMarkThreadAsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **int?**| The unique identifier of the pull request thread. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitysetreposubscription"></a>
# **ActivitySetRepoSubscription**
> RepositoryInvitation1 ActivitySetRepoSubscription (string owner, string repo, ActivitySetRepoSubscriptionRequest activitySetRepoSubscriptionRequest)

Set a repository subscription

If you would like to watch a repository, set `subscribed` to `true`. If you would like to ignore notifications made within a repository, set `ignored` to `true`. If you would like to stop watching a repository, [delete the repository's subscription](https://docs.github.com/rest/reference/activity#delete-a-repository-subscription) completely.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivitySetRepoSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var activitySetRepoSubscriptionRequest = new ActivitySetRepoSubscriptionRequest(); // ActivitySetRepoSubscriptionRequest |  (optional) 

            try
            {
                // Set a repository subscription
                RepositoryInvitation1 result = apiInstance.ActivitySetRepoSubscription(owner, repo, activitySetRepoSubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivitySetRepoSubscription: " + e.Message );
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
 **activitySetRepoSubscriptionRequest** | [**ActivitySetRepoSubscriptionRequest**](ActivitySetRepoSubscriptionRequest.md)|  | [optional] 

### Return type

[**RepositoryInvitation1**](RepositoryInvitation1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitysetthreadsubscription"></a>
# **ActivitySetThreadSubscription**
> ThreadSubscription ActivitySetThreadSubscription (int? threadId, ActivitySetThreadSubscriptionRequest activitySetThreadSubscriptionRequest)

Set a thread subscription

If you are watching a repository, you receive notifications for all threads by default. Use this endpoint to ignore future notifications for threads until you comment on the thread or get an **@mention**.  You can also use this endpoint to subscribe to threads that you are currently not receiving notifications for or to subscribed to threads that you have previously ignored.  Unsubscribing from a conversation in a repository that you are not watching is functionally equivalent to the [Delete a thread subscription](https://docs.github.com/rest/reference/activity#delete-a-thread-subscription) endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivitySetThreadSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var threadId = 56;  // int? | The unique identifier of the pull request thread.
            var activitySetThreadSubscriptionRequest = new ActivitySetThreadSubscriptionRequest(); // ActivitySetThreadSubscriptionRequest |  (optional) 

            try
            {
                // Set a thread subscription
                ThreadSubscription result = apiInstance.ActivitySetThreadSubscription(threadId, activitySetThreadSubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivitySetThreadSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **int?**| The unique identifier of the pull request thread. | 
 **activitySetThreadSubscriptionRequest** | [**ActivitySetThreadSubscriptionRequest**](ActivitySetThreadSubscriptionRequest.md)|  | [optional] 

### Return type

[**ThreadSubscription**](ThreadSubscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activitystarrepoforauthenticateduser"></a>
# **ActivityStarRepoForAuthenticatedUser**
> void ActivityStarRepoForAuthenticatedUser (string owner, string repo)

Star a repository for the authenticated user

Note that you'll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see \"[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityStarRepoForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Star a repository for the authenticated user
                apiInstance.ActivityStarRepoForAuthenticatedUser(owner, repo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityStarRepoForAuthenticatedUser: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="activityunstarrepoforauthenticateduser"></a>
# **ActivityUnstarRepoForAuthenticatedUser**
> void ActivityUnstarRepoForAuthenticatedUser (string owner, string repo)

Unstar a repository for the authenticated user



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActivityUnstarRepoForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new ActivityApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Unstar a repository for the authenticated user
                apiInstance.ActivityUnstarRepoForAuthenticatedUser(owner, repo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ActivityUnstarRepoForAuthenticatedUser: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

