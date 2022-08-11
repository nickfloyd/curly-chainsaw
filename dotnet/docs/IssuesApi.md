# Org.OpenAPITools.Api.IssuesApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IssuesAddAssignees**](IssuesApi.md#issuesaddassignees) | **POST** /repos/{owner}/{repo}/issues/{issue_number}/assignees | Add assignees to an issue
[**IssuesAddLabels**](IssuesApi.md#issuesaddlabels) | **POST** /repos/{owner}/{repo}/issues/{issue_number}/labels | Add labels to an issue
[**IssuesCheckUserCanBeAssigned**](IssuesApi.md#issuescheckusercanbeassigned) | **GET** /repos/{owner}/{repo}/assignees/{assignee} | Check if a user can be assigned
[**IssuesCreate**](IssuesApi.md#issuescreate) | **POST** /repos/{owner}/{repo}/issues | Create an issue
[**IssuesCreateComment**](IssuesApi.md#issuescreatecomment) | **POST** /repos/{owner}/{repo}/issues/{issue_number}/comments | Create an issue comment
[**IssuesCreateLabel**](IssuesApi.md#issuescreatelabel) | **POST** /repos/{owner}/{repo}/labels | Create a label
[**IssuesCreateMilestone**](IssuesApi.md#issuescreatemilestone) | **POST** /repos/{owner}/{repo}/milestones | Create a milestone
[**IssuesDeleteComment**](IssuesApi.md#issuesdeletecomment) | **DELETE** /repos/{owner}/{repo}/issues/comments/{comment_id} | Delete an issue comment
[**IssuesDeleteLabel**](IssuesApi.md#issuesdeletelabel) | **DELETE** /repos/{owner}/{repo}/labels/{name} | Delete a label
[**IssuesDeleteMilestone**](IssuesApi.md#issuesdeletemilestone) | **DELETE** /repos/{owner}/{repo}/milestones/{milestone_number} | Delete a milestone
[**IssuesGet**](IssuesApi.md#issuesget) | **GET** /repos/{owner}/{repo}/issues/{issue_number} | Get an issue
[**IssuesGetComment**](IssuesApi.md#issuesgetcomment) | **GET** /repos/{owner}/{repo}/issues/comments/{comment_id} | Get an issue comment
[**IssuesGetEvent**](IssuesApi.md#issuesgetevent) | **GET** /repos/{owner}/{repo}/issues/events/{event_id} | Get an issue event
[**IssuesGetLabel**](IssuesApi.md#issuesgetlabel) | **GET** /repos/{owner}/{repo}/labels/{name} | Get a label
[**IssuesGetMilestone**](IssuesApi.md#issuesgetmilestone) | **GET** /repos/{owner}/{repo}/milestones/{milestone_number} | Get a milestone
[**IssuesList**](IssuesApi.md#issueslist) | **GET** /issues | List issues assigned to the authenticated user
[**IssuesListAssignees**](IssuesApi.md#issueslistassignees) | **GET** /repos/{owner}/{repo}/assignees | List assignees
[**IssuesListComments**](IssuesApi.md#issueslistcomments) | **GET** /repos/{owner}/{repo}/issues/{issue_number}/comments | List issue comments
[**IssuesListCommentsForRepo**](IssuesApi.md#issueslistcommentsforrepo) | **GET** /repos/{owner}/{repo}/issues/comments | List issue comments for a repository
[**IssuesListEvents**](IssuesApi.md#issueslistevents) | **GET** /repos/{owner}/{repo}/issues/{issue_number}/events | List issue events
[**IssuesListEventsForRepo**](IssuesApi.md#issueslisteventsforrepo) | **GET** /repos/{owner}/{repo}/issues/events | List issue events for a repository
[**IssuesListEventsForTimeline**](IssuesApi.md#issueslisteventsfortimeline) | **GET** /repos/{owner}/{repo}/issues/{issue_number}/timeline | List timeline events for an issue
[**IssuesListForAuthenticatedUser**](IssuesApi.md#issueslistforauthenticateduser) | **GET** /user/issues | List user account issues assigned to the authenticated user
[**IssuesListForOrg**](IssuesApi.md#issueslistfororg) | **GET** /orgs/{org}/issues | List organization issues assigned to the authenticated user
[**IssuesListForRepo**](IssuesApi.md#issueslistforrepo) | **GET** /repos/{owner}/{repo}/issues | List repository issues
[**IssuesListLabelsForMilestone**](IssuesApi.md#issueslistlabelsformilestone) | **GET** /repos/{owner}/{repo}/milestones/{milestone_number}/labels | List labels for issues in a milestone
[**IssuesListLabelsForRepo**](IssuesApi.md#issueslistlabelsforrepo) | **GET** /repos/{owner}/{repo}/labels | List labels for a repository
[**IssuesListLabelsOnIssue**](IssuesApi.md#issueslistlabelsonissue) | **GET** /repos/{owner}/{repo}/issues/{issue_number}/labels | List labels for an issue
[**IssuesListMilestones**](IssuesApi.md#issueslistmilestones) | **GET** /repos/{owner}/{repo}/milestones | List milestones
[**IssuesLock**](IssuesApi.md#issueslock) | **PUT** /repos/{owner}/{repo}/issues/{issue_number}/lock | Lock an issue
[**IssuesRemoveAllLabels**](IssuesApi.md#issuesremovealllabels) | **DELETE** /repos/{owner}/{repo}/issues/{issue_number}/labels | Remove all labels from an issue
[**IssuesRemoveAssignees**](IssuesApi.md#issuesremoveassignees) | **DELETE** /repos/{owner}/{repo}/issues/{issue_number}/assignees | Remove assignees from an issue
[**IssuesRemoveLabel**](IssuesApi.md#issuesremovelabel) | **DELETE** /repos/{owner}/{repo}/issues/{issue_number}/labels/{name} | Remove a label from an issue
[**IssuesSetLabels**](IssuesApi.md#issuessetlabels) | **PUT** /repos/{owner}/{repo}/issues/{issue_number}/labels | Set labels for an issue
[**IssuesUnlock**](IssuesApi.md#issuesunlock) | **DELETE** /repos/{owner}/{repo}/issues/{issue_number}/lock | Unlock an issue
[**IssuesUpdate**](IssuesApi.md#issuesupdate) | **PATCH** /repos/{owner}/{repo}/issues/{issue_number} | Update an issue
[**IssuesUpdateComment**](IssuesApi.md#issuesupdatecomment) | **PATCH** /repos/{owner}/{repo}/issues/comments/{comment_id} | Update an issue comment
[**IssuesUpdateLabel**](IssuesApi.md#issuesupdatelabel) | **PATCH** /repos/{owner}/{repo}/labels/{name} | Update a label
[**IssuesUpdateMilestone**](IssuesApi.md#issuesupdatemilestone) | **PATCH** /repos/{owner}/{repo}/milestones/{milestone_number} | Update a milestone


<a name="issuesaddassignees"></a>
# **IssuesAddAssignees**
> Issue IssuesAddAssignees (string owner, string repo, int? issueNumber, IssuesAddAssigneesRequest issuesAddAssigneesRequest)

Add assignees to an issue

Adds up to 10 assignees to an issue. Users already assigned to an issue are not replaced.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesAddAssigneesExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var issueNumber = 56;  // int? | The number that identifies the issue.
            var issuesAddAssigneesRequest = new IssuesAddAssigneesRequest(); // IssuesAddAssigneesRequest |  (optional) 

            try
            {
                // Add assignees to an issue
                Issue result = apiInstance.IssuesAddAssignees(owner, repo, issueNumber, issuesAddAssigneesRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesAddAssignees: " + e.Message );
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
 **issueNumber** | **int?**| The number that identifies the issue. | 
 **issuesAddAssigneesRequest** | [**IssuesAddAssigneesRequest**](IssuesAddAssigneesRequest.md)|  | [optional] 

### Return type

[**Issue**](Issue.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuesaddlabels"></a>
# **IssuesAddLabels**
> List<Label> IssuesAddLabels (string owner, string repo, int? issueNumber, IssuesAddLabelsRequest issuesAddLabelsRequest)

Add labels to an issue



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesAddLabelsExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var issueNumber = 56;  // int? | The number that identifies the issue.
            var issuesAddLabelsRequest = new IssuesAddLabelsRequest(); // IssuesAddLabelsRequest |  (optional) 

            try
            {
                // Add labels to an issue
                List&lt;Label&gt; result = apiInstance.IssuesAddLabels(owner, repo, issueNumber, issuesAddLabelsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesAddLabels: " + e.Message );
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
 **issueNumber** | **int?**| The number that identifies the issue. | 
 **issuesAddLabelsRequest** | [**IssuesAddLabelsRequest**](IssuesAddLabelsRequest.md)|  | [optional] 

### Return type

[**List<Label>**](Label.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuescheckusercanbeassigned"></a>
# **IssuesCheckUserCanBeAssigned**
> void IssuesCheckUserCanBeAssigned (string owner, string repo, string assignee)

Check if a user can be assigned

Checks if a user has permission to be assigned to an issue in this repository.  If the `assignee` can be assigned to issues in the repository, a `204` header with no content is returned.  Otherwise a `404` status code is returned.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesCheckUserCanBeAssignedExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var assignee = "assignee_example";  // string | 

            try
            {
                // Check if a user can be assigned
                apiInstance.IssuesCheckUserCanBeAssigned(owner, repo, assignee);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesCheckUserCanBeAssigned: " + e.Message );
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
 **assignee** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuescreate"></a>
# **IssuesCreate**
> Issue IssuesCreate (string owner, string repo, IssuesCreateRequest issuesCreateRequest)

Create an issue

Any user with pull access to a repository can create an issue. If [issues are disabled in the repository](https://docs.github.com/articles/disabling-issues/), the API returns a `410 Gone` status.  This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \"[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\" and \"[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\" for details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesCreateExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var issuesCreateRequest = new IssuesCreateRequest(); // IssuesCreateRequest | 

            try
            {
                // Create an issue
                Issue result = apiInstance.IssuesCreate(owner, repo, issuesCreateRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesCreate: " + e.Message );
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
 **issuesCreateRequest** | [**IssuesCreateRequest**](IssuesCreateRequest.md)|  | 

### Return type

[**Issue**](Issue.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuescreatecomment"></a>
# **IssuesCreateComment**
> IssueComment IssuesCreateComment (string owner, string repo, int? issueNumber, IssuesUpdateCommentRequest issuesUpdateCommentRequest)

Create an issue comment

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
    public class IssuesCreateCommentExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var issueNumber = 56;  // int? | The number that identifies the issue.
            var issuesUpdateCommentRequest = new IssuesUpdateCommentRequest(); // IssuesUpdateCommentRequest | 

            try
            {
                // Create an issue comment
                IssueComment result = apiInstance.IssuesCreateComment(owner, repo, issueNumber, issuesUpdateCommentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesCreateComment: " + e.Message );
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
 **issueNumber** | **int?**| The number that identifies the issue. | 
 **issuesUpdateCommentRequest** | [**IssuesUpdateCommentRequest**](IssuesUpdateCommentRequest.md)|  | 

### Return type

[**IssueComment**](IssueComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuescreatelabel"></a>
# **IssuesCreateLabel**
> Label IssuesCreateLabel (string owner, string repo, IssuesCreateLabelRequest issuesCreateLabelRequest)

Create a label



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesCreateLabelExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var issuesCreateLabelRequest = new IssuesCreateLabelRequest(); // IssuesCreateLabelRequest | 

            try
            {
                // Create a label
                Label result = apiInstance.IssuesCreateLabel(owner, repo, issuesCreateLabelRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesCreateLabel: " + e.Message );
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
 **issuesCreateLabelRequest** | [**IssuesCreateLabelRequest**](IssuesCreateLabelRequest.md)|  | 

### Return type

[**Label**](Label.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuescreatemilestone"></a>
# **IssuesCreateMilestone**
> Milestone1 IssuesCreateMilestone (string owner, string repo, IssuesCreateMilestoneRequest issuesCreateMilestoneRequest)

Create a milestone



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesCreateMilestoneExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var issuesCreateMilestoneRequest = new IssuesCreateMilestoneRequest(); // IssuesCreateMilestoneRequest | 

            try
            {
                // Create a milestone
                Milestone1 result = apiInstance.IssuesCreateMilestone(owner, repo, issuesCreateMilestoneRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesCreateMilestone: " + e.Message );
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
 **issuesCreateMilestoneRequest** | [**IssuesCreateMilestoneRequest**](IssuesCreateMilestoneRequest.md)|  | 

### Return type

[**Milestone1**](Milestone1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuesdeletecomment"></a>
# **IssuesDeleteComment**
> void IssuesDeleteComment (string owner, string repo, int? commentId)

Delete an issue comment



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesDeleteCommentExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commentId = 56;  // int? | The unique identifier of the comment.

            try
            {
                // Delete an issue comment
                apiInstance.IssuesDeleteComment(owner, repo, commentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesDeleteComment: " + e.Message );
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
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuesdeletelabel"></a>
# **IssuesDeleteLabel**
> void IssuesDeleteLabel (string owner, string repo, string name)

Delete a label



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesDeleteLabelExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var name = "name_example";  // string | 

            try
            {
                // Delete a label
                apiInstance.IssuesDeleteLabel(owner, repo, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesDeleteLabel: " + e.Message );
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
 **name** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuesdeletemilestone"></a>
# **IssuesDeleteMilestone**
> void IssuesDeleteMilestone (string owner, string repo, int? milestoneNumber)

Delete a milestone



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesDeleteMilestoneExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var milestoneNumber = 56;  // int? | The number that identifies the milestone.

            try
            {
                // Delete a milestone
                apiInstance.IssuesDeleteMilestone(owner, repo, milestoneNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesDeleteMilestone: " + e.Message );
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
 **milestoneNumber** | **int?**| The number that identifies the milestone. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuesget"></a>
# **IssuesGet**
> Issue IssuesGet (string owner, string repo, int? issueNumber)

Get an issue

The API returns a [`301 Moved Permanently` status](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-redirects-redirects) if the issue was [transferred](https://docs.github.com/articles/transferring-an-issue-to-another-repository/) to another repository. If the issue was transferred to or deleted from a repository where the authenticated user lacks read access, the API returns a `404 Not Found` status. If the issue was deleted from a repository where the authenticated user has read access, the API returns a `410 Gone` status. To receive webhook events for transferred and deleted issues, subscribe to the [`issues`](https://docs.github.com/webhooks/event-payloads/#issues) webhook.  **Note**: GitHub's REST API v3 considers every pull request an issue, but not every issue is a pull request. For this reason, \"Issues\" endpoints may return both issues and pull requests in the response. You can identify pull requests by the `pull_request` key. Be aware that the `id` of a pull request returned from \"Issues\" endpoints will be an _issue id_. To find out the pull request id, use the \"[List pull requests](https://docs.github.com/rest/reference/pulls#list-pull-requests)\" endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesGetExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var issueNumber = 56;  // int? | The number that identifies the issue.

            try
            {
                // Get an issue
                Issue result = apiInstance.IssuesGet(owner, repo, issueNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesGet: " + e.Message );
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
 **issueNumber** | **int?**| The number that identifies the issue. | 

### Return type

[**Issue**](Issue.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuesgetcomment"></a>
# **IssuesGetComment**
> IssueComment IssuesGetComment (string owner, string repo, int? commentId)

Get an issue comment



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesGetCommentExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commentId = 56;  // int? | The unique identifier of the comment.

            try
            {
                // Get an issue comment
                IssueComment result = apiInstance.IssuesGetComment(owner, repo, commentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesGetComment: " + e.Message );
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

[**IssueComment**](IssueComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuesgetevent"></a>
# **IssuesGetEvent**
> IssueEvent IssuesGetEvent (string owner, string repo, int? eventId)

Get an issue event



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesGetEventExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var eventId = 56;  // int? | 

            try
            {
                // Get an issue event
                IssueEvent result = apiInstance.IssuesGetEvent(owner, repo, eventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesGetEvent: " + e.Message );
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
 **eventId** | **int?**|  | 

### Return type

[**IssueEvent**](IssueEvent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuesgetlabel"></a>
# **IssuesGetLabel**
> Label IssuesGetLabel (string owner, string repo, string name)

Get a label



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesGetLabelExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var name = "name_example";  // string | 

            try
            {
                // Get a label
                Label result = apiInstance.IssuesGetLabel(owner, repo, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesGetLabel: " + e.Message );
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
 **name** | **string**|  | 

### Return type

[**Label**](Label.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuesgetmilestone"></a>
# **IssuesGetMilestone**
> Milestone1 IssuesGetMilestone (string owner, string repo, int? milestoneNumber)

Get a milestone



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesGetMilestoneExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var milestoneNumber = 56;  // int? | The number that identifies the milestone.

            try
            {
                // Get a milestone
                Milestone1 result = apiInstance.IssuesGetMilestone(owner, repo, milestoneNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesGetMilestone: " + e.Message );
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
 **milestoneNumber** | **int?**| The number that identifies the milestone. | 

### Return type

[**Milestone1**](Milestone1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issueslist"></a>
# **IssuesList**
> List<Issue> IssuesList (string filter, string state, string labels, string sort, string direction, DateTime? since, bool? collab, bool? orgs, bool? owned, bool? pulls, int? perPage, int? page)

List issues assigned to the authenticated user

List issues assigned to the authenticated user across all visible repositories including owned repositories, member repositories, and organization repositories. You can use the `filter` query parameter to fetch issues that are not necessarily assigned to you.   **Note**: GitHub's REST API v3 considers every pull request an issue, but not every issue is a pull request. For this reason, \"Issues\" endpoints may return both issues and pull requests in the response. You can identify pull requests by the `pull_request` key. Be aware that the `id` of a pull request returned from \"Issues\" endpoints will be an _issue id_. To find out the pull request id, use the \"[List pull requests](https://docs.github.com/rest/reference/pulls#list-pull-requests)\" endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesListExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var filter = "assigned";  // string | Indicates which sorts of issues to return. `assigned` means issues assigned to you. `created` means issues created by you. `mentioned` means issues mentioning you. `subscribed` means issues you're subscribed to updates for. `all` or `repos` means all issues you can see, regardless of participation or creation. (optional)  (default to assigned)
            var state = "open";  // string | Indicates the state of the issues to return. Can be either `open`, `closed`, or `all`. (optional)  (default to open)
            var labels = "labels_example";  // string | A list of comma separated label names. Example: `bug,ui,@high` (optional) 
            var sort = "created";  // string | What to sort results by. Can be either `created`, `updated`, `comments`. (optional)  (default to created)
            var direction = "asc";  // string | The direction to sort the results by. (optional)  (default to desc)
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. (optional) 
            var collab = true;  // bool? |  (optional) 
            var orgs = true;  // bool? |  (optional) 
            var owned = true;  // bool? |  (optional) 
            var pulls = true;  // bool? |  (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List issues assigned to the authenticated user
                List&lt;Issue&gt; result = apiInstance.IssuesList(filter, state, labels, sort, direction, since, collab, orgs, owned, pulls, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Indicates which sorts of issues to return. &#x60;assigned&#x60; means issues assigned to you. &#x60;created&#x60; means issues created by you. &#x60;mentioned&#x60; means issues mentioning you. &#x60;subscribed&#x60; means issues you&#39;re subscribed to updates for. &#x60;all&#x60; or &#x60;repos&#x60; means all issues you can see, regardless of participation or creation. | [optional] [default to assigned]
 **state** | **string**| Indicates the state of the issues to return. Can be either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;. | [optional] [default to open]
 **labels** | **string**| A list of comma separated label names. Example: &#x60;bug,ui,@high&#x60; | [optional] 
 **sort** | **string**| What to sort results by. Can be either &#x60;created&#x60;, &#x60;updated&#x60;, &#x60;comments&#x60;. | [optional] [default to created]
 **direction** | **string**| The direction to sort the results by. | [optional] [default to desc]
 **since** | **DateTime?**| Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
 **collab** | **bool?**|  | [optional] 
 **orgs** | **bool?**|  | [optional] 
 **owned** | **bool?**|  | [optional] 
 **pulls** | **bool?**|  | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Issue>**](Issue.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issueslistassignees"></a>
# **IssuesListAssignees**
> List<SimpleUser1> IssuesListAssignees (string owner, string repo, int? perPage, int? page)

List assignees

Lists the [available assignees](https://docs.github.com/articles/assigning-issues-and-pull-requests-to-other-github-users/) for issues in a repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesListAssigneesExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List assignees
                List&lt;SimpleUser1&gt; result = apiInstance.IssuesListAssignees(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesListAssignees: " + e.Message );
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

<a name="issueslistcomments"></a>
# **IssuesListComments**
> List<IssueComment> IssuesListComments (string owner, string repo, int? issueNumber, DateTime? since, int? perPage, int? page)

List issue comments

Issue Comments are ordered by ascending ID.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesListCommentsExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var issueNumber = 56;  // int? | The number that identifies the issue.
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List issue comments
                List&lt;IssueComment&gt; result = apiInstance.IssuesListComments(owner, repo, issueNumber, since, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesListComments: " + e.Message );
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
 **issueNumber** | **int?**| The number that identifies the issue. | 
 **since** | **DateTime?**| Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<IssueComment>**](IssueComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issueslistcommentsforrepo"></a>
# **IssuesListCommentsForRepo**
> List<IssueComment> IssuesListCommentsForRepo (string owner, string repo, string sort, string direction, DateTime? since, int? perPage, int? page)

List issue comments for a repository

By default, Issue Comments are ordered by ascending ID.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesListCommentsForRepoExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var sort = "created";  // string | The property to sort the results by. `created` means when the repository was starred. `updated` means when the repository was last pushed to. (optional)  (default to created)
            var direction = "asc";  // string | Either `asc` or `desc`. Ignored without the `sort` parameter. (optional) 
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List issue comments for a repository
                List&lt;IssueComment&gt; result = apiInstance.IssuesListCommentsForRepo(owner, repo, sort, direction, since, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesListCommentsForRepo: " + e.Message );
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
 **sort** | **string**| The property to sort the results by. &#x60;created&#x60; means when the repository was starred. &#x60;updated&#x60; means when the repository was last pushed to. | [optional] [default to created]
 **direction** | **string**| Either &#x60;asc&#x60; or &#x60;desc&#x60;. Ignored without the &#x60;sort&#x60; parameter. | [optional] 
 **since** | **DateTime?**| Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<IssueComment>**](IssueComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issueslistevents"></a>
# **IssuesListEvents**
> List<IssueEventForIssue> IssuesListEvents (string owner, string repo, int? issueNumber, int? perPage, int? page)

List issue events



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesListEventsExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var issueNumber = 56;  // int? | The number that identifies the issue.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List issue events
                List&lt;IssueEventForIssue&gt; result = apiInstance.IssuesListEvents(owner, repo, issueNumber, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesListEvents: " + e.Message );
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
 **issueNumber** | **int?**| The number that identifies the issue. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<IssueEventForIssue>**](IssueEventForIssue.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issueslisteventsforrepo"></a>
# **IssuesListEventsForRepo**
> List<IssueEvent> IssuesListEventsForRepo (string owner, string repo, int? perPage, int? page)

List issue events for a repository



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesListEventsForRepoExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List issue events for a repository
                List&lt;IssueEvent&gt; result = apiInstance.IssuesListEventsForRepo(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesListEventsForRepo: " + e.Message );
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

[**List<IssueEvent>**](IssueEvent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issueslisteventsfortimeline"></a>
# **IssuesListEventsForTimeline**
> List<TimelineEvent> IssuesListEventsForTimeline (string owner, string repo, int? issueNumber, int? perPage, int? page)

List timeline events for an issue



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesListEventsForTimelineExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var issueNumber = 56;  // int? | The number that identifies the issue.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List timeline events for an issue
                List&lt;TimelineEvent&gt; result = apiInstance.IssuesListEventsForTimeline(owner, repo, issueNumber, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesListEventsForTimeline: " + e.Message );
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
 **issueNumber** | **int?**| The number that identifies the issue. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<TimelineEvent>**](TimelineEvent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issueslistforauthenticateduser"></a>
# **IssuesListForAuthenticatedUser**
> List<Issue> IssuesListForAuthenticatedUser (string filter, string state, string labels, string sort, string direction, DateTime? since, int? perPage, int? page)

List user account issues assigned to the authenticated user

List issues across owned and member repositories assigned to the authenticated user.  **Note**: GitHub's REST API v3 considers every pull request an issue, but not every issue is a pull request. For this reason, \"Issues\" endpoints may return both issues and pull requests in the response. You can identify pull requests by the `pull_request` key. Be aware that the `id` of a pull request returned from \"Issues\" endpoints will be an _issue id_. To find out the pull request id, use the \"[List pull requests](https://docs.github.com/rest/reference/pulls#list-pull-requests)\" endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesListForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var filter = "assigned";  // string | Indicates which sorts of issues to return. `assigned` means issues assigned to you. `created` means issues created by you. `mentioned` means issues mentioning you. `subscribed` means issues you're subscribed to updates for. `all` or `repos` means all issues you can see, regardless of participation or creation. (optional)  (default to assigned)
            var state = "open";  // string | Indicates the state of the issues to return. Can be either `open`, `closed`, or `all`. (optional)  (default to open)
            var labels = "labels_example";  // string | A list of comma separated label names. Example: `bug,ui,@high` (optional) 
            var sort = "created";  // string | What to sort results by. Can be either `created`, `updated`, `comments`. (optional)  (default to created)
            var direction = "asc";  // string | The direction to sort the results by. (optional)  (default to desc)
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List user account issues assigned to the authenticated user
                List&lt;Issue&gt; result = apiInstance.IssuesListForAuthenticatedUser(filter, state, labels, sort, direction, since, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesListForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Indicates which sorts of issues to return. &#x60;assigned&#x60; means issues assigned to you. &#x60;created&#x60; means issues created by you. &#x60;mentioned&#x60; means issues mentioning you. &#x60;subscribed&#x60; means issues you&#39;re subscribed to updates for. &#x60;all&#x60; or &#x60;repos&#x60; means all issues you can see, regardless of participation or creation. | [optional] [default to assigned]
 **state** | **string**| Indicates the state of the issues to return. Can be either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;. | [optional] [default to open]
 **labels** | **string**| A list of comma separated label names. Example: &#x60;bug,ui,@high&#x60; | [optional] 
 **sort** | **string**| What to sort results by. Can be either &#x60;created&#x60;, &#x60;updated&#x60;, &#x60;comments&#x60;. | [optional] [default to created]
 **direction** | **string**| The direction to sort the results by. | [optional] [default to desc]
 **since** | **DateTime?**| Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Issue>**](Issue.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issueslistfororg"></a>
# **IssuesListForOrg**
> List<Issue> IssuesListForOrg (string org, string filter, string state, string labels, string sort, string direction, DateTime? since, int? perPage, int? page)

List organization issues assigned to the authenticated user

List issues in an organization assigned to the authenticated user.  **Note**: GitHub's REST API v3 considers every pull request an issue, but not every issue is a pull request. For this reason, \"Issues\" endpoints may return both issues and pull requests in the response. You can identify pull requests by the `pull_request` key. Be aware that the `id` of a pull request returned from \"Issues\" endpoints will be an _issue id_. To find out the pull request id, use the \"[List pull requests](https://docs.github.com/rest/reference/pulls#list-pull-requests)\" endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesListForOrgExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var filter = "assigned";  // string | Indicates which sorts of issues to return. `assigned` means issues assigned to you. `created` means issues created by you. `mentioned` means issues mentioning you. `subscribed` means issues you're subscribed to updates for. `all` or `repos` means all issues you can see, regardless of participation or creation. (optional)  (default to assigned)
            var state = "open";  // string | Indicates the state of the issues to return. Can be either `open`, `closed`, or `all`. (optional)  (default to open)
            var labels = "labels_example";  // string | A list of comma separated label names. Example: `bug,ui,@high` (optional) 
            var sort = "created";  // string | What to sort results by. Can be either `created`, `updated`, `comments`. (optional)  (default to created)
            var direction = "asc";  // string | The direction to sort the results by. (optional)  (default to desc)
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List organization issues assigned to the authenticated user
                List&lt;Issue&gt; result = apiInstance.IssuesListForOrg(org, filter, state, labels, sort, direction, since, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesListForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **filter** | **string**| Indicates which sorts of issues to return. &#x60;assigned&#x60; means issues assigned to you. &#x60;created&#x60; means issues created by you. &#x60;mentioned&#x60; means issues mentioning you. &#x60;subscribed&#x60; means issues you&#39;re subscribed to updates for. &#x60;all&#x60; or &#x60;repos&#x60; means all issues you can see, regardless of participation or creation. | [optional] [default to assigned]
 **state** | **string**| Indicates the state of the issues to return. Can be either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;. | [optional] [default to open]
 **labels** | **string**| A list of comma separated label names. Example: &#x60;bug,ui,@high&#x60; | [optional] 
 **sort** | **string**| What to sort results by. Can be either &#x60;created&#x60;, &#x60;updated&#x60;, &#x60;comments&#x60;. | [optional] [default to created]
 **direction** | **string**| The direction to sort the results by. | [optional] [default to desc]
 **since** | **DateTime?**| Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Issue>**](Issue.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issueslistforrepo"></a>
# **IssuesListForRepo**
> List<Issue> IssuesListForRepo (string owner, string repo, string milestone, string state, string assignee, string creator, string mentioned, string labels, string sort, string direction, DateTime? since, int? perPage, int? page)

List repository issues

List issues in a repository.  **Note**: GitHub's REST API v3 considers every pull request an issue, but not every issue is a pull request. For this reason, \"Issues\" endpoints may return both issues and pull requests in the response. You can identify pull requests by the `pull_request` key. Be aware that the `id` of a pull request returned from \"Issues\" endpoints will be an _issue id_. To find out the pull request id, use the \"[List pull requests](https://docs.github.com/rest/reference/pulls#list-pull-requests)\" endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesListForRepoExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var milestone = "milestone_example";  // string | If an `integer` is passed, it should refer to a milestone by its `number` field. If the string `*` is passed, issues with any milestone are accepted. If the string `none` is passed, issues without milestones are returned. (optional) 
            var state = "open";  // string | Indicates the state of the issues to return. Can be either `open`, `closed`, or `all`. (optional)  (default to open)
            var assignee = "assignee_example";  // string | Can be the name of a user. Pass in `none` for issues with no assigned user, and `*` for issues assigned to any user. (optional) 
            var creator = "creator_example";  // string | The user that created the issue. (optional) 
            var mentioned = "mentioned_example";  // string | A user that's mentioned in the issue. (optional) 
            var labels = "labels_example";  // string | A list of comma separated label names. Example: `bug,ui,@high` (optional) 
            var sort = "created";  // string | What to sort results by. Can be either `created`, `updated`, `comments`. (optional)  (default to created)
            var direction = "asc";  // string | The direction to sort the results by. (optional)  (default to desc)
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repository issues
                List&lt;Issue&gt; result = apiInstance.IssuesListForRepo(owner, repo, milestone, state, assignee, creator, mentioned, labels, sort, direction, since, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesListForRepo: " + e.Message );
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
 **milestone** | **string**| If an &#x60;integer&#x60; is passed, it should refer to a milestone by its &#x60;number&#x60; field. If the string &#x60;*&#x60; is passed, issues with any milestone are accepted. If the string &#x60;none&#x60; is passed, issues without milestones are returned. | [optional] 
 **state** | **string**| Indicates the state of the issues to return. Can be either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;. | [optional] [default to open]
 **assignee** | **string**| Can be the name of a user. Pass in &#x60;none&#x60; for issues with no assigned user, and &#x60;*&#x60; for issues assigned to any user. | [optional] 
 **creator** | **string**| The user that created the issue. | [optional] 
 **mentioned** | **string**| A user that&#39;s mentioned in the issue. | [optional] 
 **labels** | **string**| A list of comma separated label names. Example: &#x60;bug,ui,@high&#x60; | [optional] 
 **sort** | **string**| What to sort results by. Can be either &#x60;created&#x60;, &#x60;updated&#x60;, &#x60;comments&#x60;. | [optional] [default to created]
 **direction** | **string**| The direction to sort the results by. | [optional] [default to desc]
 **since** | **DateTime?**| Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Issue>**](Issue.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issueslistlabelsformilestone"></a>
# **IssuesListLabelsForMilestone**
> List<Label> IssuesListLabelsForMilestone (string owner, string repo, int? milestoneNumber, int? perPage, int? page)

List labels for issues in a milestone



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesListLabelsForMilestoneExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var milestoneNumber = 56;  // int? | The number that identifies the milestone.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List labels for issues in a milestone
                List&lt;Label&gt; result = apiInstance.IssuesListLabelsForMilestone(owner, repo, milestoneNumber, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesListLabelsForMilestone: " + e.Message );
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
 **milestoneNumber** | **int?**| The number that identifies the milestone. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Label>**](Label.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issueslistlabelsforrepo"></a>
# **IssuesListLabelsForRepo**
> List<Label> IssuesListLabelsForRepo (string owner, string repo, int? perPage, int? page)

List labels for a repository



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesListLabelsForRepoExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List labels for a repository
                List&lt;Label&gt; result = apiInstance.IssuesListLabelsForRepo(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesListLabelsForRepo: " + e.Message );
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

[**List<Label>**](Label.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issueslistlabelsonissue"></a>
# **IssuesListLabelsOnIssue**
> List<Label> IssuesListLabelsOnIssue (string owner, string repo, int? issueNumber, int? perPage, int? page)

List labels for an issue



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesListLabelsOnIssueExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var issueNumber = 56;  // int? | The number that identifies the issue.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List labels for an issue
                List&lt;Label&gt; result = apiInstance.IssuesListLabelsOnIssue(owner, repo, issueNumber, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesListLabelsOnIssue: " + e.Message );
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
 **issueNumber** | **int?**| The number that identifies the issue. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Label>**](Label.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issueslistmilestones"></a>
# **IssuesListMilestones**
> List<Milestone1> IssuesListMilestones (string owner, string repo, string state, string sort, string direction, int? perPage, int? page)

List milestones



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesListMilestonesExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var state = "open";  // string | The state of the milestone. Either `open`, `closed`, or `all`. (optional)  (default to open)
            var sort = "due_on";  // string | What to sort results by. Either `due_on` or `completeness`. (optional)  (default to due_on)
            var direction = "asc";  // string | The direction of the sort. Either `asc` or `desc`. (optional)  (default to asc)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List milestones
                List&lt;Milestone1&gt; result = apiInstance.IssuesListMilestones(owner, repo, state, sort, direction, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesListMilestones: " + e.Message );
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
 **state** | **string**| The state of the milestone. Either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;. | [optional] [default to open]
 **sort** | **string**| What to sort results by. Either &#x60;due_on&#x60; or &#x60;completeness&#x60;. | [optional] [default to due_on]
 **direction** | **string**| The direction of the sort. Either &#x60;asc&#x60; or &#x60;desc&#x60;. | [optional] [default to asc]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Milestone1>**](Milestone1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issueslock"></a>
# **IssuesLock**
> void IssuesLock (string owner, string repo, int? issueNumber, IssuesLockRequest issuesLockRequest)

Lock an issue

Users with push access can lock an issue or pull request's conversation.  Note that, if you choose not to pass any parameters, you'll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see \"[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesLockExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var issueNumber = 56;  // int? | The number that identifies the issue.
            var issuesLockRequest = new IssuesLockRequest(); // IssuesLockRequest |  (optional) 

            try
            {
                // Lock an issue
                apiInstance.IssuesLock(owner, repo, issueNumber, issuesLockRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesLock: " + e.Message );
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
 **issueNumber** | **int?**| The number that identifies the issue. | 
 **issuesLockRequest** | [**IssuesLockRequest**](IssuesLockRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuesremovealllabels"></a>
# **IssuesRemoveAllLabels**
> void IssuesRemoveAllLabels (string owner, string repo, int? issueNumber)

Remove all labels from an issue



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesRemoveAllLabelsExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var issueNumber = 56;  // int? | The number that identifies the issue.

            try
            {
                // Remove all labels from an issue
                apiInstance.IssuesRemoveAllLabels(owner, repo, issueNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesRemoveAllLabels: " + e.Message );
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
 **issueNumber** | **int?**| The number that identifies the issue. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuesremoveassignees"></a>
# **IssuesRemoveAssignees**
> Issue IssuesRemoveAssignees (string owner, string repo, int? issueNumber, IssuesRemoveAssigneesRequest issuesRemoveAssigneesRequest)

Remove assignees from an issue

Removes one or more assignees from an issue.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesRemoveAssigneesExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var issueNumber = 56;  // int? | The number that identifies the issue.
            var issuesRemoveAssigneesRequest = new IssuesRemoveAssigneesRequest(); // IssuesRemoveAssigneesRequest |  (optional) 

            try
            {
                // Remove assignees from an issue
                Issue result = apiInstance.IssuesRemoveAssignees(owner, repo, issueNumber, issuesRemoveAssigneesRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesRemoveAssignees: " + e.Message );
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
 **issueNumber** | **int?**| The number that identifies the issue. | 
 **issuesRemoveAssigneesRequest** | [**IssuesRemoveAssigneesRequest**](IssuesRemoveAssigneesRequest.md)|  | [optional] 

### Return type

[**Issue**](Issue.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuesremovelabel"></a>
# **IssuesRemoveLabel**
> List<Label> IssuesRemoveLabel (string owner, string repo, int? issueNumber, string name)

Remove a label from an issue

Removes the specified label from the issue, and returns the remaining labels on the issue. This endpoint returns a `404 Not Found` status if the label does not exist.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesRemoveLabelExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var issueNumber = 56;  // int? | The number that identifies the issue.
            var name = "name_example";  // string | 

            try
            {
                // Remove a label from an issue
                List&lt;Label&gt; result = apiInstance.IssuesRemoveLabel(owner, repo, issueNumber, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesRemoveLabel: " + e.Message );
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
 **issueNumber** | **int?**| The number that identifies the issue. | 
 **name** | **string**|  | 

### Return type

[**List<Label>**](Label.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuessetlabels"></a>
# **IssuesSetLabels**
> List<Label> IssuesSetLabels (string owner, string repo, int? issueNumber, IssuesSetLabelsRequest issuesSetLabelsRequest)

Set labels for an issue

Removes any previous labels and sets the new labels for an issue.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesSetLabelsExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var issueNumber = 56;  // int? | The number that identifies the issue.
            var issuesSetLabelsRequest = new IssuesSetLabelsRequest(); // IssuesSetLabelsRequest |  (optional) 

            try
            {
                // Set labels for an issue
                List&lt;Label&gt; result = apiInstance.IssuesSetLabels(owner, repo, issueNumber, issuesSetLabelsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesSetLabels: " + e.Message );
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
 **issueNumber** | **int?**| The number that identifies the issue. | 
 **issuesSetLabelsRequest** | [**IssuesSetLabelsRequest**](IssuesSetLabelsRequest.md)|  | [optional] 

### Return type

[**List<Label>**](Label.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuesunlock"></a>
# **IssuesUnlock**
> void IssuesUnlock (string owner, string repo, int? issueNumber)

Unlock an issue

Users with push access can unlock an issue's conversation.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesUnlockExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var issueNumber = 56;  // int? | The number that identifies the issue.

            try
            {
                // Unlock an issue
                apiInstance.IssuesUnlock(owner, repo, issueNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesUnlock: " + e.Message );
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
 **issueNumber** | **int?**| The number that identifies the issue. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuesupdate"></a>
# **IssuesUpdate**
> Issue IssuesUpdate (string owner, string repo, int? issueNumber, IssuesUpdateRequest issuesUpdateRequest)

Update an issue

Issue owners and users with push access can edit an issue.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesUpdateExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var issueNumber = 56;  // int? | The number that identifies the issue.
            var issuesUpdateRequest = new IssuesUpdateRequest(); // IssuesUpdateRequest |  (optional) 

            try
            {
                // Update an issue
                Issue result = apiInstance.IssuesUpdate(owner, repo, issueNumber, issuesUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesUpdate: " + e.Message );
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
 **issueNumber** | **int?**| The number that identifies the issue. | 
 **issuesUpdateRequest** | [**IssuesUpdateRequest**](IssuesUpdateRequest.md)|  | [optional] 

### Return type

[**Issue**](Issue.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuesupdatecomment"></a>
# **IssuesUpdateComment**
> IssueComment IssuesUpdateComment (string owner, string repo, int? commentId, IssuesUpdateCommentRequest issuesUpdateCommentRequest)

Update an issue comment



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesUpdateCommentExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commentId = 56;  // int? | The unique identifier of the comment.
            var issuesUpdateCommentRequest = new IssuesUpdateCommentRequest(); // IssuesUpdateCommentRequest | 

            try
            {
                // Update an issue comment
                IssueComment result = apiInstance.IssuesUpdateComment(owner, repo, commentId, issuesUpdateCommentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesUpdateComment: " + e.Message );
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
 **issuesUpdateCommentRequest** | [**IssuesUpdateCommentRequest**](IssuesUpdateCommentRequest.md)|  | 

### Return type

[**IssueComment**](IssueComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuesupdatelabel"></a>
# **IssuesUpdateLabel**
> Label IssuesUpdateLabel (string owner, string repo, string name, IssuesUpdateLabelRequest issuesUpdateLabelRequest)

Update a label



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesUpdateLabelExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var name = "name_example";  // string | 
            var issuesUpdateLabelRequest = new IssuesUpdateLabelRequest(); // IssuesUpdateLabelRequest |  (optional) 

            try
            {
                // Update a label
                Label result = apiInstance.IssuesUpdateLabel(owner, repo, name, issuesUpdateLabelRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesUpdateLabel: " + e.Message );
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
 **name** | **string**|  | 
 **issuesUpdateLabelRequest** | [**IssuesUpdateLabelRequest**](IssuesUpdateLabelRequest.md)|  | [optional] 

### Return type

[**Label**](Label.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuesupdatemilestone"></a>
# **IssuesUpdateMilestone**
> Milestone1 IssuesUpdateMilestone (string owner, string repo, int? milestoneNumber, IssuesUpdateMilestoneRequest issuesUpdateMilestoneRequest)

Update a milestone



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuesUpdateMilestoneExample
    {
        public void main()
        {
            var apiInstance = new IssuesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var milestoneNumber = 56;  // int? | The number that identifies the milestone.
            var issuesUpdateMilestoneRequest = new IssuesUpdateMilestoneRequest(); // IssuesUpdateMilestoneRequest |  (optional) 

            try
            {
                // Update a milestone
                Milestone1 result = apiInstance.IssuesUpdateMilestone(owner, repo, milestoneNumber, issuesUpdateMilestoneRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesUpdateMilestone: " + e.Message );
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
 **milestoneNumber** | **int?**| The number that identifies the milestone. | 
 **issuesUpdateMilestoneRequest** | [**IssuesUpdateMilestoneRequest**](IssuesUpdateMilestoneRequest.md)|  | [optional] 

### Return type

[**Milestone1**](Milestone1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

