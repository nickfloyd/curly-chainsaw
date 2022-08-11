# Org.OpenAPITools.Api.ReactionsApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReactionsCreateForCommitComment**](ReactionsApi.md#reactionscreateforcommitcomment) | **POST** /repos/{owner}/{repo}/comments/{comment_id}/reactions | Create reaction for a commit comment
[**ReactionsCreateForIssue**](ReactionsApi.md#reactionscreateforissue) | **POST** /repos/{owner}/{repo}/issues/{issue_number}/reactions | Create reaction for an issue
[**ReactionsCreateForIssueComment**](ReactionsApi.md#reactionscreateforissuecomment) | **POST** /repos/{owner}/{repo}/issues/comments/{comment_id}/reactions | Create reaction for an issue comment
[**ReactionsCreateForPullRequestReviewComment**](ReactionsApi.md#reactionscreateforpullrequestreviewcomment) | **POST** /repos/{owner}/{repo}/pulls/comments/{comment_id}/reactions | Create reaction for a pull request review comment
[**ReactionsCreateForRelease**](ReactionsApi.md#reactionscreateforrelease) | **POST** /repos/{owner}/{repo}/releases/{release_id}/reactions | Create reaction for a release
[**ReactionsCreateForTeamDiscussionCommentInOrg**](ReactionsApi.md#reactionscreateforteamdiscussioncommentinorg) | **POST** /orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/comments/{comment_number}/reactions | Create reaction for a team discussion comment
[**ReactionsCreateForTeamDiscussionCommentLegacy**](ReactionsApi.md#reactionscreateforteamdiscussioncommentlegacy) | **POST** /teams/{team_id}/discussions/{discussion_number}/comments/{comment_number}/reactions | Create reaction for a team discussion comment (Legacy)
[**ReactionsCreateForTeamDiscussionInOrg**](ReactionsApi.md#reactionscreateforteamdiscussioninorg) | **POST** /orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/reactions | Create reaction for a team discussion
[**ReactionsCreateForTeamDiscussionLegacy**](ReactionsApi.md#reactionscreateforteamdiscussionlegacy) | **POST** /teams/{team_id}/discussions/{discussion_number}/reactions | Create reaction for a team discussion (Legacy)
[**ReactionsDeleteForCommitComment**](ReactionsApi.md#reactionsdeleteforcommitcomment) | **DELETE** /repos/{owner}/{repo}/comments/{comment_id}/reactions/{reaction_id} | Delete a commit comment reaction
[**ReactionsDeleteForIssue**](ReactionsApi.md#reactionsdeleteforissue) | **DELETE** /repos/{owner}/{repo}/issues/{issue_number}/reactions/{reaction_id} | Delete an issue reaction
[**ReactionsDeleteForIssueComment**](ReactionsApi.md#reactionsdeleteforissuecomment) | **DELETE** /repos/{owner}/{repo}/issues/comments/{comment_id}/reactions/{reaction_id} | Delete an issue comment reaction
[**ReactionsDeleteForPullRequestComment**](ReactionsApi.md#reactionsdeleteforpullrequestcomment) | **DELETE** /repos/{owner}/{repo}/pulls/comments/{comment_id}/reactions/{reaction_id} | Delete a pull request comment reaction
[**ReactionsDeleteForRelease**](ReactionsApi.md#reactionsdeleteforrelease) | **DELETE** /repos/{owner}/{repo}/releases/{release_id}/reactions/{reaction_id} | Delete a release reaction
[**ReactionsDeleteForTeamDiscussion**](ReactionsApi.md#reactionsdeleteforteamdiscussion) | **DELETE** /orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/reactions/{reaction_id} | Delete team discussion reaction
[**ReactionsDeleteForTeamDiscussionComment**](ReactionsApi.md#reactionsdeleteforteamdiscussioncomment) | **DELETE** /orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/comments/{comment_number}/reactions/{reaction_id} | Delete team discussion comment reaction
[**ReactionsListForCommitComment**](ReactionsApi.md#reactionslistforcommitcomment) | **GET** /repos/{owner}/{repo}/comments/{comment_id}/reactions | List reactions for a commit comment
[**ReactionsListForIssue**](ReactionsApi.md#reactionslistforissue) | **GET** /repos/{owner}/{repo}/issues/{issue_number}/reactions | List reactions for an issue
[**ReactionsListForIssueComment**](ReactionsApi.md#reactionslistforissuecomment) | **GET** /repos/{owner}/{repo}/issues/comments/{comment_id}/reactions | List reactions for an issue comment
[**ReactionsListForPullRequestReviewComment**](ReactionsApi.md#reactionslistforpullrequestreviewcomment) | **GET** /repos/{owner}/{repo}/pulls/comments/{comment_id}/reactions | List reactions for a pull request review comment
[**ReactionsListForRelease**](ReactionsApi.md#reactionslistforrelease) | **GET** /repos/{owner}/{repo}/releases/{release_id}/reactions | List reactions for a release
[**ReactionsListForTeamDiscussionCommentInOrg**](ReactionsApi.md#reactionslistforteamdiscussioncommentinorg) | **GET** /orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/comments/{comment_number}/reactions | List reactions for a team discussion comment
[**ReactionsListForTeamDiscussionCommentLegacy**](ReactionsApi.md#reactionslistforteamdiscussioncommentlegacy) | **GET** /teams/{team_id}/discussions/{discussion_number}/comments/{comment_number}/reactions | List reactions for a team discussion comment (Legacy)
[**ReactionsListForTeamDiscussionInOrg**](ReactionsApi.md#reactionslistforteamdiscussioninorg) | **GET** /orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/reactions | List reactions for a team discussion
[**ReactionsListForTeamDiscussionLegacy**](ReactionsApi.md#reactionslistforteamdiscussionlegacy) | **GET** /teams/{team_id}/discussions/{discussion_number}/reactions | List reactions for a team discussion (Legacy)


<a name="reactionscreateforcommitcomment"></a>
# **ReactionsCreateForCommitComment**
> Reaction ReactionsCreateForCommitComment (string owner, string repo, int? commentId, ReactionsCreateForCommitCommentRequest reactionsCreateForCommitCommentRequest)

Create reaction for a commit comment

Create a reaction to a [commit comment](https://docs.github.com/rest/reference/repos#comments). A response with an HTTP `200` status means that you already added the reaction type to this commit comment.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsCreateForCommitCommentExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commentId = 56;  // int? | The unique identifier of the comment.
            var reactionsCreateForCommitCommentRequest = new ReactionsCreateForCommitCommentRequest(); // ReactionsCreateForCommitCommentRequest | 

            try
            {
                // Create reaction for a commit comment
                Reaction result = apiInstance.ReactionsCreateForCommitComment(owner, repo, commentId, reactionsCreateForCommitCommentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsCreateForCommitComment: " + e.Message );
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
 **reactionsCreateForCommitCommentRequest** | [**ReactionsCreateForCommitCommentRequest**](ReactionsCreateForCommitCommentRequest.md)|  | 

### Return type

[**Reaction**](Reaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionscreateforissue"></a>
# **ReactionsCreateForIssue**
> Reaction ReactionsCreateForIssue (string owner, string repo, int? issueNumber, ReactionsCreateForIssueRequest reactionsCreateForIssueRequest)

Create reaction for an issue

Create a reaction to an [issue](https://docs.github.com/rest/reference/issues/). A response with an HTTP `200` status means that you already added the reaction type to this issue.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsCreateForIssueExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var issueNumber = 56;  // int? | The number that identifies the issue.
            var reactionsCreateForIssueRequest = new ReactionsCreateForIssueRequest(); // ReactionsCreateForIssueRequest | 

            try
            {
                // Create reaction for an issue
                Reaction result = apiInstance.ReactionsCreateForIssue(owner, repo, issueNumber, reactionsCreateForIssueRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsCreateForIssue: " + e.Message );
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
 **reactionsCreateForIssueRequest** | [**ReactionsCreateForIssueRequest**](ReactionsCreateForIssueRequest.md)|  | 

### Return type

[**Reaction**](Reaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionscreateforissuecomment"></a>
# **ReactionsCreateForIssueComment**
> Reaction ReactionsCreateForIssueComment (string owner, string repo, int? commentId, ReactionsCreateForIssueCommentRequest reactionsCreateForIssueCommentRequest)

Create reaction for an issue comment

Create a reaction to an [issue comment](https://docs.github.com/rest/reference/issues#comments). A response with an HTTP `200` status means that you already added the reaction type to this issue comment.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsCreateForIssueCommentExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commentId = 56;  // int? | The unique identifier of the comment.
            var reactionsCreateForIssueCommentRequest = new ReactionsCreateForIssueCommentRequest(); // ReactionsCreateForIssueCommentRequest | 

            try
            {
                // Create reaction for an issue comment
                Reaction result = apiInstance.ReactionsCreateForIssueComment(owner, repo, commentId, reactionsCreateForIssueCommentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsCreateForIssueComment: " + e.Message );
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
 **reactionsCreateForIssueCommentRequest** | [**ReactionsCreateForIssueCommentRequest**](ReactionsCreateForIssueCommentRequest.md)|  | 

### Return type

[**Reaction**](Reaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionscreateforpullrequestreviewcomment"></a>
# **ReactionsCreateForPullRequestReviewComment**
> Reaction ReactionsCreateForPullRequestReviewComment (string owner, string repo, int? commentId, ReactionsCreateForPullRequestReviewCommentRequest reactionsCreateForPullRequestReviewCommentRequest)

Create reaction for a pull request review comment

Create a reaction to a [pull request review comment](https://docs.github.com/rest/reference/pulls#comments). A response with an HTTP `200` status means that you already added the reaction type to this pull request review comment.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsCreateForPullRequestReviewCommentExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commentId = 56;  // int? | The unique identifier of the comment.
            var reactionsCreateForPullRequestReviewCommentRequest = new ReactionsCreateForPullRequestReviewCommentRequest(); // ReactionsCreateForPullRequestReviewCommentRequest | 

            try
            {
                // Create reaction for a pull request review comment
                Reaction result = apiInstance.ReactionsCreateForPullRequestReviewComment(owner, repo, commentId, reactionsCreateForPullRequestReviewCommentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsCreateForPullRequestReviewComment: " + e.Message );
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
 **reactionsCreateForPullRequestReviewCommentRequest** | [**ReactionsCreateForPullRequestReviewCommentRequest**](ReactionsCreateForPullRequestReviewCommentRequest.md)|  | 

### Return type

[**Reaction**](Reaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionscreateforrelease"></a>
# **ReactionsCreateForRelease**
> Reaction ReactionsCreateForRelease (string owner, string repo, int? releaseId, ReactionsCreateForReleaseRequest reactionsCreateForReleaseRequest)

Create reaction for a release

Create a reaction to a [release](https://docs.github.com/rest/reference/repos#releases). A response with a `Status: 200 OK` means that you already added the reaction type to this release.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsCreateForReleaseExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var releaseId = 56;  // int? | The unique identifier of the release.
            var reactionsCreateForReleaseRequest = new ReactionsCreateForReleaseRequest(); // ReactionsCreateForReleaseRequest | 

            try
            {
                // Create reaction for a release
                Reaction result = apiInstance.ReactionsCreateForRelease(owner, repo, releaseId, reactionsCreateForReleaseRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsCreateForRelease: " + e.Message );
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
 **releaseId** | **int?**| The unique identifier of the release. | 
 **reactionsCreateForReleaseRequest** | [**ReactionsCreateForReleaseRequest**](ReactionsCreateForReleaseRequest.md)|  | 

### Return type

[**Reaction**](Reaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionscreateforteamdiscussioncommentinorg"></a>
# **ReactionsCreateForTeamDiscussionCommentInOrg**
> Reaction ReactionsCreateForTeamDiscussionCommentInOrg (string org, string teamSlug, int? discussionNumber, int? commentNumber, ReactionsCreateForTeamDiscussionCommentInOrgRequest reactionsCreateForTeamDiscussionCommentInOrgRequest)

Create reaction for a team discussion comment

Create a reaction to a [team discussion comment](https://docs.github.com/rest/reference/teams#discussion-comments). OAuth access tokens require the `write:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/). A response with an HTTP `200` status means that you already added the reaction type to this team discussion comment.  **Note:** You can also specify a team by `org_id` and `team_id` using the route `POST /organizations/:org_id/team/:team_id/discussions/:discussion_number/comments/:comment_number/reactions`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsCreateForTeamDiscussionCommentInOrgExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.
            var commentNumber = 56;  // int? | The number that identifies the comment.
            var reactionsCreateForTeamDiscussionCommentInOrgRequest = new ReactionsCreateForTeamDiscussionCommentInOrgRequest(); // ReactionsCreateForTeamDiscussionCommentInOrgRequest | 

            try
            {
                // Create reaction for a team discussion comment
                Reaction result = apiInstance.ReactionsCreateForTeamDiscussionCommentInOrg(org, teamSlug, discussionNumber, commentNumber, reactionsCreateForTeamDiscussionCommentInOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsCreateForTeamDiscussionCommentInOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **teamSlug** | **string**| The slug of the team name. | 
 **discussionNumber** | **int?**| The number that identifies the discussion. | 
 **commentNumber** | **int?**| The number that identifies the comment. | 
 **reactionsCreateForTeamDiscussionCommentInOrgRequest** | [**ReactionsCreateForTeamDiscussionCommentInOrgRequest**](ReactionsCreateForTeamDiscussionCommentInOrgRequest.md)|  | 

### Return type

[**Reaction**](Reaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionscreateforteamdiscussioncommentlegacy"></a>
# **ReactionsCreateForTeamDiscussionCommentLegacy**
> Reaction ReactionsCreateForTeamDiscussionCommentLegacy (int? teamId, int? discussionNumber, int? commentNumber, ReactionsCreateForTeamDiscussionCommentInOrgRequest reactionsCreateForTeamDiscussionCommentInOrgRequest)

Create reaction for a team discussion comment (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new \"[Create reaction for a team discussion comment](https://docs.github.com/rest/reference/reactions#create-reaction-for-a-team-discussion-comment)\" endpoint.  Create a reaction to a [team discussion comment](https://docs.github.com/rest/reference/teams#discussion-comments). OAuth access tokens require the `write:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/). A response with an HTTP `200` status means that you already added the reaction type to this team discussion comment.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsCreateForTeamDiscussionCommentLegacyExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.
            var commentNumber = 56;  // int? | The number that identifies the comment.
            var reactionsCreateForTeamDiscussionCommentInOrgRequest = new ReactionsCreateForTeamDiscussionCommentInOrgRequest(); // ReactionsCreateForTeamDiscussionCommentInOrgRequest | 

            try
            {
                // Create reaction for a team discussion comment (Legacy)
                Reaction result = apiInstance.ReactionsCreateForTeamDiscussionCommentLegacy(teamId, discussionNumber, commentNumber, reactionsCreateForTeamDiscussionCommentInOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsCreateForTeamDiscussionCommentLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **discussionNumber** | **int?**| The number that identifies the discussion. | 
 **commentNumber** | **int?**| The number that identifies the comment. | 
 **reactionsCreateForTeamDiscussionCommentInOrgRequest** | [**ReactionsCreateForTeamDiscussionCommentInOrgRequest**](ReactionsCreateForTeamDiscussionCommentInOrgRequest.md)|  | 

### Return type

[**Reaction**](Reaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionscreateforteamdiscussioninorg"></a>
# **ReactionsCreateForTeamDiscussionInOrg**
> Reaction ReactionsCreateForTeamDiscussionInOrg (string org, string teamSlug, int? discussionNumber, ReactionsCreateForTeamDiscussionInOrgRequest reactionsCreateForTeamDiscussionInOrgRequest)

Create reaction for a team discussion

Create a reaction to a [team discussion](https://docs.github.com/rest/reference/teams#discussions). OAuth access tokens require the `write:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/). A response with an HTTP `200` status means that you already added the reaction type to this team discussion.  **Note:** You can also specify a team by `org_id` and `team_id` using the route `POST /organizations/:org_id/team/:team_id/discussions/:discussion_number/reactions`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsCreateForTeamDiscussionInOrgExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.
            var reactionsCreateForTeamDiscussionInOrgRequest = new ReactionsCreateForTeamDiscussionInOrgRequest(); // ReactionsCreateForTeamDiscussionInOrgRequest | 

            try
            {
                // Create reaction for a team discussion
                Reaction result = apiInstance.ReactionsCreateForTeamDiscussionInOrg(org, teamSlug, discussionNumber, reactionsCreateForTeamDiscussionInOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsCreateForTeamDiscussionInOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **teamSlug** | **string**| The slug of the team name. | 
 **discussionNumber** | **int?**| The number that identifies the discussion. | 
 **reactionsCreateForTeamDiscussionInOrgRequest** | [**ReactionsCreateForTeamDiscussionInOrgRequest**](ReactionsCreateForTeamDiscussionInOrgRequest.md)|  | 

### Return type

[**Reaction**](Reaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionscreateforteamdiscussionlegacy"></a>
# **ReactionsCreateForTeamDiscussionLegacy**
> Reaction ReactionsCreateForTeamDiscussionLegacy (int? teamId, int? discussionNumber, ReactionsCreateForTeamDiscussionInOrgRequest reactionsCreateForTeamDiscussionInOrgRequest)

Create reaction for a team discussion (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [`Create reaction for a team discussion`](https://docs.github.com/rest/reference/reactions#create-reaction-for-a-team-discussion) endpoint.  Create a reaction to a [team discussion](https://docs.github.com/rest/reference/teams#discussions). OAuth access tokens require the `write:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/). A response with an HTTP `200` status means that you already added the reaction type to this team discussion.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsCreateForTeamDiscussionLegacyExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.
            var reactionsCreateForTeamDiscussionInOrgRequest = new ReactionsCreateForTeamDiscussionInOrgRequest(); // ReactionsCreateForTeamDiscussionInOrgRequest | 

            try
            {
                // Create reaction for a team discussion (Legacy)
                Reaction result = apiInstance.ReactionsCreateForTeamDiscussionLegacy(teamId, discussionNumber, reactionsCreateForTeamDiscussionInOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsCreateForTeamDiscussionLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **discussionNumber** | **int?**| The number that identifies the discussion. | 
 **reactionsCreateForTeamDiscussionInOrgRequest** | [**ReactionsCreateForTeamDiscussionInOrgRequest**](ReactionsCreateForTeamDiscussionInOrgRequest.md)|  | 

### Return type

[**Reaction**](Reaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionsdeleteforcommitcomment"></a>
# **ReactionsDeleteForCommitComment**
> void ReactionsDeleteForCommitComment (string owner, string repo, int? commentId, int? reactionId)

Delete a commit comment reaction

**Note:** You can also specify a repository by `repository_id` using the route `DELETE /repositories/:repository_id/comments/:comment_id/reactions/:reaction_id`.  Delete a reaction to a [commit comment](https://docs.github.com/rest/reference/repos#comments).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsDeleteForCommitCommentExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commentId = 56;  // int? | The unique identifier of the comment.
            var reactionId = 56;  // int? | The unique identifier of the reaction.

            try
            {
                // Delete a commit comment reaction
                apiInstance.ReactionsDeleteForCommitComment(owner, repo, commentId, reactionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsDeleteForCommitComment: " + e.Message );
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
 **reactionId** | **int?**| The unique identifier of the reaction. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionsdeleteforissue"></a>
# **ReactionsDeleteForIssue**
> void ReactionsDeleteForIssue (string owner, string repo, int? issueNumber, int? reactionId)

Delete an issue reaction

**Note:** You can also specify a repository by `repository_id` using the route `DELETE /repositories/:repository_id/issues/:issue_number/reactions/:reaction_id`.  Delete a reaction to an [issue](https://docs.github.com/rest/reference/issues/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsDeleteForIssueExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var issueNumber = 56;  // int? | The number that identifies the issue.
            var reactionId = 56;  // int? | The unique identifier of the reaction.

            try
            {
                // Delete an issue reaction
                apiInstance.ReactionsDeleteForIssue(owner, repo, issueNumber, reactionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsDeleteForIssue: " + e.Message );
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
 **reactionId** | **int?**| The unique identifier of the reaction. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionsdeleteforissuecomment"></a>
# **ReactionsDeleteForIssueComment**
> void ReactionsDeleteForIssueComment (string owner, string repo, int? commentId, int? reactionId)

Delete an issue comment reaction

**Note:** You can also specify a repository by `repository_id` using the route `DELETE delete /repositories/:repository_id/issues/comments/:comment_id/reactions/:reaction_id`.  Delete a reaction to an [issue comment](https://docs.github.com/rest/reference/issues#comments).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsDeleteForIssueCommentExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commentId = 56;  // int? | The unique identifier of the comment.
            var reactionId = 56;  // int? | The unique identifier of the reaction.

            try
            {
                // Delete an issue comment reaction
                apiInstance.ReactionsDeleteForIssueComment(owner, repo, commentId, reactionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsDeleteForIssueComment: " + e.Message );
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
 **reactionId** | **int?**| The unique identifier of the reaction. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionsdeleteforpullrequestcomment"></a>
# **ReactionsDeleteForPullRequestComment**
> void ReactionsDeleteForPullRequestComment (string owner, string repo, int? commentId, int? reactionId)

Delete a pull request comment reaction

**Note:** You can also specify a repository by `repository_id` using the route `DELETE /repositories/:repository_id/pulls/comments/:comment_id/reactions/:reaction_id.`  Delete a reaction to a [pull request review comment](https://docs.github.com/rest/reference/pulls#review-comments).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsDeleteForPullRequestCommentExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commentId = 56;  // int? | The unique identifier of the comment.
            var reactionId = 56;  // int? | The unique identifier of the reaction.

            try
            {
                // Delete a pull request comment reaction
                apiInstance.ReactionsDeleteForPullRequestComment(owner, repo, commentId, reactionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsDeleteForPullRequestComment: " + e.Message );
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
 **reactionId** | **int?**| The unique identifier of the reaction. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionsdeleteforrelease"></a>
# **ReactionsDeleteForRelease**
> void ReactionsDeleteForRelease (string owner, string repo, int? releaseId, int? reactionId)

Delete a release reaction

**Note:** You can also specify a repository by `repository_id` using the route `DELETE delete /repositories/:repository_id/releases/:release_id/reactions/:reaction_id`.  Delete a reaction to a [release](https://docs.github.com/rest/reference/repos#releases).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsDeleteForReleaseExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var releaseId = 56;  // int? | The unique identifier of the release.
            var reactionId = 56;  // int? | The unique identifier of the reaction.

            try
            {
                // Delete a release reaction
                apiInstance.ReactionsDeleteForRelease(owner, repo, releaseId, reactionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsDeleteForRelease: " + e.Message );
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
 **releaseId** | **int?**| The unique identifier of the release. | 
 **reactionId** | **int?**| The unique identifier of the reaction. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionsdeleteforteamdiscussion"></a>
# **ReactionsDeleteForTeamDiscussion**
> void ReactionsDeleteForTeamDiscussion (string org, string teamSlug, int? discussionNumber, int? reactionId)

Delete team discussion reaction

**Note:** You can also specify a team or organization with `team_id` and `org_id` using the route `DELETE /organizations/:org_id/team/:team_id/discussions/:discussion_number/reactions/:reaction_id`.  Delete a reaction to a [team discussion](https://docs.github.com/rest/reference/teams#discussions). OAuth access tokens require the `write:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsDeleteForTeamDiscussionExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.
            var reactionId = 56;  // int? | The unique identifier of the reaction.

            try
            {
                // Delete team discussion reaction
                apiInstance.ReactionsDeleteForTeamDiscussion(org, teamSlug, discussionNumber, reactionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsDeleteForTeamDiscussion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **teamSlug** | **string**| The slug of the team name. | 
 **discussionNumber** | **int?**| The number that identifies the discussion. | 
 **reactionId** | **int?**| The unique identifier of the reaction. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionsdeleteforteamdiscussioncomment"></a>
# **ReactionsDeleteForTeamDiscussionComment**
> void ReactionsDeleteForTeamDiscussionComment (string org, string teamSlug, int? discussionNumber, int? commentNumber, int? reactionId)

Delete team discussion comment reaction

**Note:** You can also specify a team or organization with `team_id` and `org_id` using the route `DELETE /organizations/:org_id/team/:team_id/discussions/:discussion_number/comments/:comment_number/reactions/:reaction_id`.  Delete a reaction to a [team discussion comment](https://docs.github.com/rest/reference/teams#discussion-comments). OAuth access tokens require the `write:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsDeleteForTeamDiscussionCommentExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.
            var commentNumber = 56;  // int? | The number that identifies the comment.
            var reactionId = 56;  // int? | The unique identifier of the reaction.

            try
            {
                // Delete team discussion comment reaction
                apiInstance.ReactionsDeleteForTeamDiscussionComment(org, teamSlug, discussionNumber, commentNumber, reactionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsDeleteForTeamDiscussionComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **teamSlug** | **string**| The slug of the team name. | 
 **discussionNumber** | **int?**| The number that identifies the discussion. | 
 **commentNumber** | **int?**| The number that identifies the comment. | 
 **reactionId** | **int?**| The unique identifier of the reaction. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionslistforcommitcomment"></a>
# **ReactionsListForCommitComment**
> List<Reaction> ReactionsListForCommitComment (string owner, string repo, int? commentId, string content, int? perPage, int? page)

List reactions for a commit comment

List the reactions to a [commit comment](https://docs.github.com/rest/reference/repos#comments).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsListForCommitCommentExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commentId = 56;  // int? | The unique identifier of the comment.
            var content = "+1";  // string | Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a commit comment. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List reactions for a commit comment
                List&lt;Reaction&gt; result = apiInstance.ReactionsListForCommitComment(owner, repo, commentId, content, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsListForCommitComment: " + e.Message );
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
 **content** | **string**| Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a commit comment. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Reaction>**](Reaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionslistforissue"></a>
# **ReactionsListForIssue**
> List<Reaction> ReactionsListForIssue (string owner, string repo, int? issueNumber, string content, int? perPage, int? page)

List reactions for an issue

List the reactions to an [issue](https://docs.github.com/rest/reference/issues).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsListForIssueExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var issueNumber = 56;  // int? | The number that identifies the issue.
            var content = "+1";  // string | Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to an issue. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List reactions for an issue
                List&lt;Reaction&gt; result = apiInstance.ReactionsListForIssue(owner, repo, issueNumber, content, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsListForIssue: " + e.Message );
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
 **content** | **string**| Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to an issue. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Reaction>**](Reaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionslistforissuecomment"></a>
# **ReactionsListForIssueComment**
> List<Reaction> ReactionsListForIssueComment (string owner, string repo, int? commentId, string content, int? perPage, int? page)

List reactions for an issue comment

List the reactions to an [issue comment](https://docs.github.com/rest/reference/issues#comments).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsListForIssueCommentExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commentId = 56;  // int? | The unique identifier of the comment.
            var content = "+1";  // string | Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to an issue comment. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List reactions for an issue comment
                List&lt;Reaction&gt; result = apiInstance.ReactionsListForIssueComment(owner, repo, commentId, content, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsListForIssueComment: " + e.Message );
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
 **content** | **string**| Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to an issue comment. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Reaction>**](Reaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionslistforpullrequestreviewcomment"></a>
# **ReactionsListForPullRequestReviewComment**
> List<Reaction> ReactionsListForPullRequestReviewComment (string owner, string repo, int? commentId, string content, int? perPage, int? page)

List reactions for a pull request review comment

List the reactions to a [pull request review comment](https://docs.github.com/rest/reference/pulls#review-comments).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsListForPullRequestReviewCommentExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commentId = 56;  // int? | The unique identifier of the comment.
            var content = "+1";  // string | Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a pull request review comment. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List reactions for a pull request review comment
                List&lt;Reaction&gt; result = apiInstance.ReactionsListForPullRequestReviewComment(owner, repo, commentId, content, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsListForPullRequestReviewComment: " + e.Message );
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
 **content** | **string**| Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a pull request review comment. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Reaction>**](Reaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionslistforrelease"></a>
# **ReactionsListForRelease**
> List<Reaction> ReactionsListForRelease (string owner, string repo, int? releaseId, string content, int? perPage, int? page)

List reactions for a release

List the reactions to a [release](https://docs.github.com/rest/reference/repos#releases).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsListForReleaseExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var releaseId = 56;  // int? | The unique identifier of the release.
            var content = "+1";  // string | Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a release. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List reactions for a release
                List&lt;Reaction&gt; result = apiInstance.ReactionsListForRelease(owner, repo, releaseId, content, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsListForRelease: " + e.Message );
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
 **releaseId** | **int?**| The unique identifier of the release. | 
 **content** | **string**| Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a release. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Reaction>**](Reaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionslistforteamdiscussioncommentinorg"></a>
# **ReactionsListForTeamDiscussionCommentInOrg**
> List<Reaction> ReactionsListForTeamDiscussionCommentInOrg (string org, string teamSlug, int? discussionNumber, int? commentNumber, string content, int? perPage, int? page)

List reactions for a team discussion comment

List the reactions to a [team discussion comment](https://docs.github.com/rest/reference/teams#discussion-comments/). OAuth access tokens require the `read:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/:org_id/team/:team_id/discussions/:discussion_number/comments/:comment_number/reactions`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsListForTeamDiscussionCommentInOrgExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.
            var commentNumber = 56;  // int? | The number that identifies the comment.
            var content = "+1";  // string | Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a team discussion comment. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List reactions for a team discussion comment
                List&lt;Reaction&gt; result = apiInstance.ReactionsListForTeamDiscussionCommentInOrg(org, teamSlug, discussionNumber, commentNumber, content, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsListForTeamDiscussionCommentInOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **teamSlug** | **string**| The slug of the team name. | 
 **discussionNumber** | **int?**| The number that identifies the discussion. | 
 **commentNumber** | **int?**| The number that identifies the comment. | 
 **content** | **string**| Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a team discussion comment. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Reaction>**](Reaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionslistforteamdiscussioncommentlegacy"></a>
# **ReactionsListForTeamDiscussionCommentLegacy**
> List<Reaction> ReactionsListForTeamDiscussionCommentLegacy (int? teamId, int? discussionNumber, int? commentNumber, string content, int? perPage, int? page)

List reactions for a team discussion comment (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [`List reactions for a team discussion comment`](https://docs.github.com/rest/reference/reactions#list-reactions-for-a-team-discussion-comment) endpoint.  List the reactions to a [team discussion comment](https://docs.github.com/rest/reference/teams#discussion-comments). OAuth access tokens require the `read:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsListForTeamDiscussionCommentLegacyExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.
            var commentNumber = 56;  // int? | The number that identifies the comment.
            var content = "+1";  // string | Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a team discussion comment. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List reactions for a team discussion comment (Legacy)
                List&lt;Reaction&gt; result = apiInstance.ReactionsListForTeamDiscussionCommentLegacy(teamId, discussionNumber, commentNumber, content, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsListForTeamDiscussionCommentLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **discussionNumber** | **int?**| The number that identifies the discussion. | 
 **commentNumber** | **int?**| The number that identifies the comment. | 
 **content** | **string**| Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a team discussion comment. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Reaction>**](Reaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionslistforteamdiscussioninorg"></a>
# **ReactionsListForTeamDiscussionInOrg**
> List<Reaction> ReactionsListForTeamDiscussionInOrg (string org, string teamSlug, int? discussionNumber, string content, int? perPage, int? page)

List reactions for a team discussion

List the reactions to a [team discussion](https://docs.github.com/rest/reference/teams#discussions). OAuth access tokens require the `read:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/:org_id/team/:team_id/discussions/:discussion_number/reactions`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsListForTeamDiscussionInOrgExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.
            var content = "+1";  // string | Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a team discussion. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List reactions for a team discussion
                List&lt;Reaction&gt; result = apiInstance.ReactionsListForTeamDiscussionInOrg(org, teamSlug, discussionNumber, content, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsListForTeamDiscussionInOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **teamSlug** | **string**| The slug of the team name. | 
 **discussionNumber** | **int?**| The number that identifies the discussion. | 
 **content** | **string**| Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a team discussion. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Reaction>**](Reaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionslistforteamdiscussionlegacy"></a>
# **ReactionsListForTeamDiscussionLegacy**
> List<Reaction> ReactionsListForTeamDiscussionLegacy (int? teamId, int? discussionNumber, string content, int? perPage, int? page)

List reactions for a team discussion (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [`List reactions for a team discussion`](https://docs.github.com/rest/reference/reactions#list-reactions-for-a-team-discussion) endpoint.  List the reactions to a [team discussion](https://docs.github.com/rest/reference/teams#discussions). OAuth access tokens require the `read:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReactionsListForTeamDiscussionLegacyExample
    {
        public void main()
        {
            var apiInstance = new ReactionsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.
            var content = "+1";  // string | Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a team discussion. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List reactions for a team discussion (Legacy)
                List&lt;Reaction&gt; result = apiInstance.ReactionsListForTeamDiscussionLegacy(teamId, discussionNumber, content, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsListForTeamDiscussionLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **discussionNumber** | **int?**| The number that identifies the discussion. | 
 **content** | **string**| Returns a single [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types). Omit this parameter to list all reactions to a team discussion. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Reaction>**](Reaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

