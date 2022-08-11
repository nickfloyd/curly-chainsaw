# Org.OpenAPITools.Api.TeamsApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TeamsAddMemberLegacy**](TeamsApi.md#teamsaddmemberlegacy) | **PUT** /teams/{team_id}/members/{username} | Add team member (Legacy)
[**TeamsAddOrUpdateMembershipForUserInOrg**](TeamsApi.md#teamsaddorupdatemembershipforuserinorg) | **PUT** /orgs/{org}/teams/{team_slug}/memberships/{username} | Add or update team membership for a user
[**TeamsAddOrUpdateMembershipForUserLegacy**](TeamsApi.md#teamsaddorupdatemembershipforuserlegacy) | **PUT** /teams/{team_id}/memberships/{username} | Add or update team membership for a user (Legacy)
[**TeamsAddOrUpdateProjectPermissionsInOrg**](TeamsApi.md#teamsaddorupdateprojectpermissionsinorg) | **PUT** /orgs/{org}/teams/{team_slug}/projects/{project_id} | Add or update team project permissions
[**TeamsAddOrUpdateProjectPermissionsLegacy**](TeamsApi.md#teamsaddorupdateprojectpermissionslegacy) | **PUT** /teams/{team_id}/projects/{project_id} | Add or update team project permissions (Legacy)
[**TeamsAddOrUpdateRepoPermissionsInOrg**](TeamsApi.md#teamsaddorupdaterepopermissionsinorg) | **PUT** /orgs/{org}/teams/{team_slug}/repos/{owner}/{repo} | Add or update team repository permissions
[**TeamsAddOrUpdateRepoPermissionsLegacy**](TeamsApi.md#teamsaddorupdaterepopermissionslegacy) | **PUT** /teams/{team_id}/repos/{owner}/{repo} | Add or update team repository permissions (Legacy)
[**TeamsCheckPermissionsForProjectInOrg**](TeamsApi.md#teamscheckpermissionsforprojectinorg) | **GET** /orgs/{org}/teams/{team_slug}/projects/{project_id} | Check team permissions for a project
[**TeamsCheckPermissionsForProjectLegacy**](TeamsApi.md#teamscheckpermissionsforprojectlegacy) | **GET** /teams/{team_id}/projects/{project_id} | Check team permissions for a project (Legacy)
[**TeamsCheckPermissionsForRepoInOrg**](TeamsApi.md#teamscheckpermissionsforrepoinorg) | **GET** /orgs/{org}/teams/{team_slug}/repos/{owner}/{repo} | Check team permissions for a repository
[**TeamsCheckPermissionsForRepoLegacy**](TeamsApi.md#teamscheckpermissionsforrepolegacy) | **GET** /teams/{team_id}/repos/{owner}/{repo} | Check team permissions for a repository (Legacy)
[**TeamsCreate**](TeamsApi.md#teamscreate) | **POST** /orgs/{org}/teams | Create a team
[**TeamsCreateDiscussionCommentInOrg**](TeamsApi.md#teamscreatediscussioncommentinorg) | **POST** /orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/comments | Create a discussion comment
[**TeamsCreateDiscussionCommentLegacy**](TeamsApi.md#teamscreatediscussioncommentlegacy) | **POST** /teams/{team_id}/discussions/{discussion_number}/comments | Create a discussion comment (Legacy)
[**TeamsCreateDiscussionInOrg**](TeamsApi.md#teamscreatediscussioninorg) | **POST** /orgs/{org}/teams/{team_slug}/discussions | Create a discussion
[**TeamsCreateDiscussionLegacy**](TeamsApi.md#teamscreatediscussionlegacy) | **POST** /teams/{team_id}/discussions | Create a discussion (Legacy)
[**TeamsCreateOrUpdateIdpGroupConnectionsInOrg**](TeamsApi.md#teamscreateorupdateidpgroupconnectionsinorg) | **PATCH** /orgs/{org}/teams/{team_slug}/team-sync/group-mappings | Create or update IdP group connections
[**TeamsCreateOrUpdateIdpGroupConnectionsLegacy**](TeamsApi.md#teamscreateorupdateidpgroupconnectionslegacy) | **PATCH** /teams/{team_id}/team-sync/group-mappings | Create or update IdP group connections (Legacy)
[**TeamsDeleteDiscussionCommentInOrg**](TeamsApi.md#teamsdeletediscussioncommentinorg) | **DELETE** /orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/comments/{comment_number} | Delete a discussion comment
[**TeamsDeleteDiscussionCommentLegacy**](TeamsApi.md#teamsdeletediscussioncommentlegacy) | **DELETE** /teams/{team_id}/discussions/{discussion_number}/comments/{comment_number} | Delete a discussion comment (Legacy)
[**TeamsDeleteDiscussionInOrg**](TeamsApi.md#teamsdeletediscussioninorg) | **DELETE** /orgs/{org}/teams/{team_slug}/discussions/{discussion_number} | Delete a discussion
[**TeamsDeleteDiscussionLegacy**](TeamsApi.md#teamsdeletediscussionlegacy) | **DELETE** /teams/{team_id}/discussions/{discussion_number} | Delete a discussion (Legacy)
[**TeamsDeleteInOrg**](TeamsApi.md#teamsdeleteinorg) | **DELETE** /orgs/{org}/teams/{team_slug} | Delete a team
[**TeamsDeleteLegacy**](TeamsApi.md#teamsdeletelegacy) | **DELETE** /teams/{team_id} | Delete a team (Legacy)
[**TeamsExternalIdpGroupInfoForOrg**](TeamsApi.md#teamsexternalidpgroupinfofororg) | **GET** /orgs/{org}/external-group/{group_id} | Get an external group
[**TeamsGetByName**](TeamsApi.md#teamsgetbyname) | **GET** /orgs/{org}/teams/{team_slug} | Get a team by name
[**TeamsGetDiscussionCommentInOrg**](TeamsApi.md#teamsgetdiscussioncommentinorg) | **GET** /orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/comments/{comment_number} | Get a discussion comment
[**TeamsGetDiscussionCommentLegacy**](TeamsApi.md#teamsgetdiscussioncommentlegacy) | **GET** /teams/{team_id}/discussions/{discussion_number}/comments/{comment_number} | Get a discussion comment (Legacy)
[**TeamsGetDiscussionInOrg**](TeamsApi.md#teamsgetdiscussioninorg) | **GET** /orgs/{org}/teams/{team_slug}/discussions/{discussion_number} | Get a discussion
[**TeamsGetDiscussionLegacy**](TeamsApi.md#teamsgetdiscussionlegacy) | **GET** /teams/{team_id}/discussions/{discussion_number} | Get a discussion (Legacy)
[**TeamsGetLegacy**](TeamsApi.md#teamsgetlegacy) | **GET** /teams/{team_id} | Get a team (Legacy)
[**TeamsGetMemberLegacy**](TeamsApi.md#teamsgetmemberlegacy) | **GET** /teams/{team_id}/members/{username} | Get team member (Legacy)
[**TeamsGetMembershipForUserInOrg**](TeamsApi.md#teamsgetmembershipforuserinorg) | **GET** /orgs/{org}/teams/{team_slug}/memberships/{username} | Get team membership for a user
[**TeamsGetMembershipForUserLegacy**](TeamsApi.md#teamsgetmembershipforuserlegacy) | **GET** /teams/{team_id}/memberships/{username} | Get team membership for a user (Legacy)
[**TeamsLinkExternalIdpGroupToTeamForOrg**](TeamsApi.md#teamslinkexternalidpgrouptoteamfororg) | **PATCH** /orgs/{org}/teams/{team_slug}/external-groups | Update the connection between an external group and a team
[**TeamsList**](TeamsApi.md#teamslist) | **GET** /orgs/{org}/teams | List teams
[**TeamsListChildInOrg**](TeamsApi.md#teamslistchildinorg) | **GET** /orgs/{org}/teams/{team_slug}/teams | List child teams
[**TeamsListChildLegacy**](TeamsApi.md#teamslistchildlegacy) | **GET** /teams/{team_id}/teams | List child teams (Legacy)
[**TeamsListDiscussionCommentsInOrg**](TeamsApi.md#teamslistdiscussioncommentsinorg) | **GET** /orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/comments | List discussion comments
[**TeamsListDiscussionCommentsLegacy**](TeamsApi.md#teamslistdiscussioncommentslegacy) | **GET** /teams/{team_id}/discussions/{discussion_number}/comments | List discussion comments (Legacy)
[**TeamsListDiscussionsInOrg**](TeamsApi.md#teamslistdiscussionsinorg) | **GET** /orgs/{org}/teams/{team_slug}/discussions | List discussions
[**TeamsListDiscussionsLegacy**](TeamsApi.md#teamslistdiscussionslegacy) | **GET** /teams/{team_id}/discussions | List discussions (Legacy)
[**TeamsListExternalIdpGroupsForOrg**](TeamsApi.md#teamslistexternalidpgroupsfororg) | **GET** /orgs/{org}/external-groups | List external groups in an organization
[**TeamsListForAuthenticatedUser**](TeamsApi.md#teamslistforauthenticateduser) | **GET** /user/teams | List teams for the authenticated user
[**TeamsListIdpGroupsForLegacy**](TeamsApi.md#teamslistidpgroupsforlegacy) | **GET** /teams/{team_id}/team-sync/group-mappings | List IdP groups for a team (Legacy)
[**TeamsListIdpGroupsForOrg**](TeamsApi.md#teamslistidpgroupsfororg) | **GET** /orgs/{org}/team-sync/groups | List IdP groups for an organization
[**TeamsListIdpGroupsInOrg**](TeamsApi.md#teamslistidpgroupsinorg) | **GET** /orgs/{org}/teams/{team_slug}/team-sync/group-mappings | List IdP groups for a team
[**TeamsListLinkedExternalIdpGroupsToTeamForOrg**](TeamsApi.md#teamslistlinkedexternalidpgroupstoteamfororg) | **GET** /orgs/{org}/teams/{team_slug}/external-groups | List a connection between an external group and a team
[**TeamsListMembersInOrg**](TeamsApi.md#teamslistmembersinorg) | **GET** /orgs/{org}/teams/{team_slug}/members | List team members
[**TeamsListMembersLegacy**](TeamsApi.md#teamslistmemberslegacy) | **GET** /teams/{team_id}/members | List team members (Legacy)
[**TeamsListPendingInvitationsInOrg**](TeamsApi.md#teamslistpendinginvitationsinorg) | **GET** /orgs/{org}/teams/{team_slug}/invitations | List pending team invitations
[**TeamsListPendingInvitationsLegacy**](TeamsApi.md#teamslistpendinginvitationslegacy) | **GET** /teams/{team_id}/invitations | List pending team invitations (Legacy)
[**TeamsListProjectsInOrg**](TeamsApi.md#teamslistprojectsinorg) | **GET** /orgs/{org}/teams/{team_slug}/projects | List team projects
[**TeamsListProjectsLegacy**](TeamsApi.md#teamslistprojectslegacy) | **GET** /teams/{team_id}/projects | List team projects (Legacy)
[**TeamsListReposInOrg**](TeamsApi.md#teamslistreposinorg) | **GET** /orgs/{org}/teams/{team_slug}/repos | List team repositories
[**TeamsListReposLegacy**](TeamsApi.md#teamslistreposlegacy) | **GET** /teams/{team_id}/repos | List team repositories (Legacy)
[**TeamsRemoveMemberLegacy**](TeamsApi.md#teamsremovememberlegacy) | **DELETE** /teams/{team_id}/members/{username} | Remove team member (Legacy)
[**TeamsRemoveMembershipForUserInOrg**](TeamsApi.md#teamsremovemembershipforuserinorg) | **DELETE** /orgs/{org}/teams/{team_slug}/memberships/{username} | Remove team membership for a user
[**TeamsRemoveMembershipForUserLegacy**](TeamsApi.md#teamsremovemembershipforuserlegacy) | **DELETE** /teams/{team_id}/memberships/{username} | Remove team membership for a user (Legacy)
[**TeamsRemoveProjectInOrg**](TeamsApi.md#teamsremoveprojectinorg) | **DELETE** /orgs/{org}/teams/{team_slug}/projects/{project_id} | Remove a project from a team
[**TeamsRemoveProjectLegacy**](TeamsApi.md#teamsremoveprojectlegacy) | **DELETE** /teams/{team_id}/projects/{project_id} | Remove a project from a team (Legacy)
[**TeamsRemoveRepoInOrg**](TeamsApi.md#teamsremoverepoinorg) | **DELETE** /orgs/{org}/teams/{team_slug}/repos/{owner}/{repo} | Remove a repository from a team
[**TeamsRemoveRepoLegacy**](TeamsApi.md#teamsremoverepolegacy) | **DELETE** /teams/{team_id}/repos/{owner}/{repo} | Remove a repository from a team (Legacy)
[**TeamsUnlinkExternalIdpGroupFromTeamForOrg**](TeamsApi.md#teamsunlinkexternalidpgroupfromteamfororg) | **DELETE** /orgs/{org}/teams/{team_slug}/external-groups | Remove the connection between an external group and a team
[**TeamsUpdateDiscussionCommentInOrg**](TeamsApi.md#teamsupdatediscussioncommentinorg) | **PATCH** /orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/comments/{comment_number} | Update a discussion comment
[**TeamsUpdateDiscussionCommentLegacy**](TeamsApi.md#teamsupdatediscussioncommentlegacy) | **PATCH** /teams/{team_id}/discussions/{discussion_number}/comments/{comment_number} | Update a discussion comment (Legacy)
[**TeamsUpdateDiscussionInOrg**](TeamsApi.md#teamsupdatediscussioninorg) | **PATCH** /orgs/{org}/teams/{team_slug}/discussions/{discussion_number} | Update a discussion
[**TeamsUpdateDiscussionLegacy**](TeamsApi.md#teamsupdatediscussionlegacy) | **PATCH** /teams/{team_id}/discussions/{discussion_number} | Update a discussion (Legacy)
[**TeamsUpdateInOrg**](TeamsApi.md#teamsupdateinorg) | **PATCH** /orgs/{org}/teams/{team_slug} | Update a team
[**TeamsUpdateLegacy**](TeamsApi.md#teamsupdatelegacy) | **PATCH** /teams/{team_id} | Update a team (Legacy)


<a name="teamsaddmemberlegacy"></a>
# **TeamsAddMemberLegacy**
> void TeamsAddMemberLegacy (int? teamId, string username)

Add team member (Legacy)

The \"Add team member\" endpoint (described below) is deprecated.  We recommend using the [Add or update team membership for a user](https://docs.github.com/rest/reference/teams#add-or-update-team-membership-for-a-user) endpoint instead. It allows you to invite new organization members to your teams.  Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  To add someone to a team, the authenticated user must be an organization owner or a team maintainer in the team they're changing. The person being added to the team must be a member of the team's organization.  **Note:** When you have team synchronization set up for a team with your organization's identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team's membership. If you have access to manage group membership in your IdP, you can manage GitHub team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see \"[Synchronizing teams between your identity provider and GitHub](https://docs.github.com/articles/synchronizing-teams-between-your-identity-provider-and-github/).\"  Note that you'll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see \"[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsAddMemberLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Add team member (Legacy)
                apiInstance.TeamsAddMemberLegacy(teamId, username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsAddMemberLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsaddorupdatemembershipforuserinorg"></a>
# **TeamsAddOrUpdateMembershipForUserInOrg**
> TeamMembership TeamsAddOrUpdateMembershipForUserInOrg (string org, string teamSlug, string username, TeamsAddOrUpdateMembershipForUserInOrgRequest teamsAddOrUpdateMembershipForUserInOrgRequest)

Add or update team membership for a user

Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Adds an organization member to a team. An authenticated organization owner or team maintainer can add organization members to a team.  **Note:** When you have team synchronization set up for a team with your organization's identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team's membership. If you have access to manage group membership in your IdP, you can manage GitHub team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see \"[Synchronizing teams between your identity provider and GitHub](https://docs.github.com/articles/synchronizing-teams-between-your-identity-provider-and-github/).\"  An organization owner can add someone who is not part of the team's organization to a team. When an organization owner adds someone to a team who is not an organization member, this endpoint will send an invitation to the person via email. This newly-created membership will be in the \"pending\" state until the person accepts the invitation, at which point the membership will transition to the \"active\" state and the user will be added as a member of the team.  If the user is already a member of the team, this endpoint will update the role of the team member's role. To update the membership of a team member, the authenticated user must be an organization owner or a team maintainer.  **Note:** You can also specify a team by `org_id` and `team_id` using the route `PUT /organizations/{org_id}/team/{team_id}/memberships/{username}`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsAddOrUpdateMembershipForUserInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var username = "username_example";  // string | The handle for the GitHub user account.
            var teamsAddOrUpdateMembershipForUserInOrgRequest = new TeamsAddOrUpdateMembershipForUserInOrgRequest(); // TeamsAddOrUpdateMembershipForUserInOrgRequest |  (optional) 

            try
            {
                // Add or update team membership for a user
                TeamMembership result = apiInstance.TeamsAddOrUpdateMembershipForUserInOrg(org, teamSlug, username, teamsAddOrUpdateMembershipForUserInOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsAddOrUpdateMembershipForUserInOrg: " + e.Message );
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
 **username** | **string**| The handle for the GitHub user account. | 
 **teamsAddOrUpdateMembershipForUserInOrgRequest** | [**TeamsAddOrUpdateMembershipForUserInOrgRequest**](TeamsAddOrUpdateMembershipForUserInOrgRequest.md)|  | [optional] 

### Return type

[**TeamMembership**](TeamMembership.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsaddorupdatemembershipforuserlegacy"></a>
# **TeamsAddOrUpdateMembershipForUserLegacy**
> TeamMembership TeamsAddOrUpdateMembershipForUserLegacy (int? teamId, string username, TeamsAddOrUpdateMembershipForUserInOrgRequest teamsAddOrUpdateMembershipForUserInOrgRequest)

Add or update team membership for a user (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Add or update team membership for a user](https://docs.github.com/rest/reference/teams#add-or-update-team-membership-for-a-user) endpoint.  Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  If the user is already a member of the team's organization, this endpoint will add the user to the team. To add a membership between an organization member and a team, the authenticated user must be an organization owner or a team maintainer.  **Note:** When you have team synchronization set up for a team with your organization's identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team's membership. If you have access to manage group membership in your IdP, you can manage GitHub team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see \"[Synchronizing teams between your identity provider and GitHub](https://docs.github.com/articles/synchronizing-teams-between-your-identity-provider-and-github/).\"  If the user is unaffiliated with the team's organization, this endpoint will send an invitation to the user via email. This newly-created membership will be in the \"pending\" state until the user accepts the invitation, at which point the membership will transition to the \"active\" state and the user will be added as a member of the team. To add a membership between an unaffiliated user and a team, the authenticated user must be an organization owner.  If the user is already a member of the team, this endpoint will update the role of the team member's role. To update the membership of a team member, the authenticated user must be an organization owner or a team maintainer.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsAddOrUpdateMembershipForUserLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var username = "username_example";  // string | The handle for the GitHub user account.
            var teamsAddOrUpdateMembershipForUserInOrgRequest = new TeamsAddOrUpdateMembershipForUserInOrgRequest(); // TeamsAddOrUpdateMembershipForUserInOrgRequest |  (optional) 

            try
            {
                // Add or update team membership for a user (Legacy)
                TeamMembership result = apiInstance.TeamsAddOrUpdateMembershipForUserLegacy(teamId, username, teamsAddOrUpdateMembershipForUserInOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsAddOrUpdateMembershipForUserLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **username** | **string**| The handle for the GitHub user account. | 
 **teamsAddOrUpdateMembershipForUserInOrgRequest** | [**TeamsAddOrUpdateMembershipForUserInOrgRequest**](TeamsAddOrUpdateMembershipForUserInOrgRequest.md)|  | [optional] 

### Return type

[**TeamMembership**](TeamMembership.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsaddorupdateprojectpermissionsinorg"></a>
# **TeamsAddOrUpdateProjectPermissionsInOrg**
> void TeamsAddOrUpdateProjectPermissionsInOrg (string org, string teamSlug, int? projectId, TeamsAddOrUpdateProjectPermissionsInOrgRequest teamsAddOrUpdateProjectPermissionsInOrgRequest)

Add or update team project permissions

Adds an organization project to a team. To add a project to a team or update the team's permission on a project, the authenticated user must have `admin` permissions for the project. The project and team must be part of the same organization.  **Note:** You can also specify a team by `org_id` and `team_id` using the route `PUT /organizations/{org_id}/team/{team_id}/projects/{project_id}`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsAddOrUpdateProjectPermissionsInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var projectId = 56;  // int? | The unique identifier of the project.
            var teamsAddOrUpdateProjectPermissionsInOrgRequest = new TeamsAddOrUpdateProjectPermissionsInOrgRequest(); // TeamsAddOrUpdateProjectPermissionsInOrgRequest |  (optional) 

            try
            {
                // Add or update team project permissions
                apiInstance.TeamsAddOrUpdateProjectPermissionsInOrg(org, teamSlug, projectId, teamsAddOrUpdateProjectPermissionsInOrgRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsAddOrUpdateProjectPermissionsInOrg: " + e.Message );
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
 **projectId** | **int?**| The unique identifier of the project. | 
 **teamsAddOrUpdateProjectPermissionsInOrgRequest** | [**TeamsAddOrUpdateProjectPermissionsInOrgRequest**](TeamsAddOrUpdateProjectPermissionsInOrgRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsaddorupdateprojectpermissionslegacy"></a>
# **TeamsAddOrUpdateProjectPermissionsLegacy**
> void TeamsAddOrUpdateProjectPermissionsLegacy (int? teamId, int? projectId, TeamsAddOrUpdateProjectPermissionsLegacyRequest teamsAddOrUpdateProjectPermissionsLegacyRequest)

Add or update team project permissions (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Add or update team project permissions](https://docs.github.com/rest/reference/teams#add-or-update-team-project-permissions) endpoint.  Adds an organization project to a team. To add a project to a team or update the team's permission on a project, the authenticated user must have `admin` permissions for the project. The project and team must be part of the same organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsAddOrUpdateProjectPermissionsLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var projectId = 56;  // int? | The unique identifier of the project.
            var teamsAddOrUpdateProjectPermissionsLegacyRequest = new TeamsAddOrUpdateProjectPermissionsLegacyRequest(); // TeamsAddOrUpdateProjectPermissionsLegacyRequest |  (optional) 

            try
            {
                // Add or update team project permissions (Legacy)
                apiInstance.TeamsAddOrUpdateProjectPermissionsLegacy(teamId, projectId, teamsAddOrUpdateProjectPermissionsLegacyRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsAddOrUpdateProjectPermissionsLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **projectId** | **int?**| The unique identifier of the project. | 
 **teamsAddOrUpdateProjectPermissionsLegacyRequest** | [**TeamsAddOrUpdateProjectPermissionsLegacyRequest**](TeamsAddOrUpdateProjectPermissionsLegacyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsaddorupdaterepopermissionsinorg"></a>
# **TeamsAddOrUpdateRepoPermissionsInOrg**
> void TeamsAddOrUpdateRepoPermissionsInOrg (string org, string teamSlug, string owner, string repo, TeamsAddOrUpdateRepoPermissionsInOrgRequest teamsAddOrUpdateRepoPermissionsInOrgRequest)

Add or update team repository permissions

To add a repository to a team or update the team's permission on a repository, the authenticated user must have admin access to the repository, and must be able to see the team. The repository must be owned by the organization, or a direct fork of a repository owned by the organization. You will get a `422 Unprocessable Entity` status if you attempt to add a repository to a team that is not owned by the organization. Note that, if you choose not to pass any parameters, you'll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see \"[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\"  **Note:** You can also specify a team by `org_id` and `team_id` using the route `PUT /organizations/{org_id}/team/{team_id}/repos/{owner}/{repo}`.  For more information about the permission levels, see \"[Repository permission levels for an organization](https://docs.github.com/en/github/setting-up-and-managing-organizations-and-teams/repository-permission-levels-for-an-organization#permission-levels-for-repositories-owned-by-an-organization)\".

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsAddOrUpdateRepoPermissionsInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var teamsAddOrUpdateRepoPermissionsInOrgRequest = new TeamsAddOrUpdateRepoPermissionsInOrgRequest(); // TeamsAddOrUpdateRepoPermissionsInOrgRequest |  (optional) 

            try
            {
                // Add or update team repository permissions
                apiInstance.TeamsAddOrUpdateRepoPermissionsInOrg(org, teamSlug, owner, repo, teamsAddOrUpdateRepoPermissionsInOrgRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsAddOrUpdateRepoPermissionsInOrg: " + e.Message );
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
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **teamsAddOrUpdateRepoPermissionsInOrgRequest** | [**TeamsAddOrUpdateRepoPermissionsInOrgRequest**](TeamsAddOrUpdateRepoPermissionsInOrgRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsaddorupdaterepopermissionslegacy"></a>
# **TeamsAddOrUpdateRepoPermissionsLegacy**
> void TeamsAddOrUpdateRepoPermissionsLegacy (int? teamId, string owner, string repo, TeamsAddOrUpdateRepoPermissionsLegacyRequest teamsAddOrUpdateRepoPermissionsLegacyRequest)

Add or update team repository permissions (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new \"[Add or update team repository permissions](https://docs.github.com/rest/reference/teams#add-or-update-team-repository-permissions)\" endpoint.  To add a repository to a team or update the team's permission on a repository, the authenticated user must have admin access to the repository, and must be able to see the team. The repository must be owned by the organization, or a direct fork of a repository owned by the organization. You will get a `422 Unprocessable Entity` status if you attempt to add a repository to a team that is not owned by the organization.  Note that, if you choose not to pass any parameters, you'll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see \"[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsAddOrUpdateRepoPermissionsLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var teamsAddOrUpdateRepoPermissionsLegacyRequest = new TeamsAddOrUpdateRepoPermissionsLegacyRequest(); // TeamsAddOrUpdateRepoPermissionsLegacyRequest |  (optional) 

            try
            {
                // Add or update team repository permissions (Legacy)
                apiInstance.TeamsAddOrUpdateRepoPermissionsLegacy(teamId, owner, repo, teamsAddOrUpdateRepoPermissionsLegacyRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsAddOrUpdateRepoPermissionsLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **teamsAddOrUpdateRepoPermissionsLegacyRequest** | [**TeamsAddOrUpdateRepoPermissionsLegacyRequest**](TeamsAddOrUpdateRepoPermissionsLegacyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamscheckpermissionsforprojectinorg"></a>
# **TeamsCheckPermissionsForProjectInOrg**
> TeamProject TeamsCheckPermissionsForProjectInOrg (string org, string teamSlug, int? projectId)

Check team permissions for a project

Checks whether a team has `read`, `write`, or `admin` permissions for an organization project. The response includes projects inherited from a parent team.  **Note:** You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/projects/{project_id}`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsCheckPermissionsForProjectInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var projectId = 56;  // int? | The unique identifier of the project.

            try
            {
                // Check team permissions for a project
                TeamProject result = apiInstance.TeamsCheckPermissionsForProjectInOrg(org, teamSlug, projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsCheckPermissionsForProjectInOrg: " + e.Message );
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
 **projectId** | **int?**| The unique identifier of the project. | 

### Return type

[**TeamProject**](TeamProject.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamscheckpermissionsforprojectlegacy"></a>
# **TeamsCheckPermissionsForProjectLegacy**
> TeamProject TeamsCheckPermissionsForProjectLegacy (int? teamId, int? projectId)

Check team permissions for a project (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Check team permissions for a project](https://docs.github.com/rest/reference/teams#check-team-permissions-for-a-project) endpoint.  Checks whether a team has `read`, `write`, or `admin` permissions for an organization project. The response includes projects inherited from a parent team.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsCheckPermissionsForProjectLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var projectId = 56;  // int? | The unique identifier of the project.

            try
            {
                // Check team permissions for a project (Legacy)
                TeamProject result = apiInstance.TeamsCheckPermissionsForProjectLegacy(teamId, projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsCheckPermissionsForProjectLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **projectId** | **int?**| The unique identifier of the project. | 

### Return type

[**TeamProject**](TeamProject.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamscheckpermissionsforrepoinorg"></a>
# **TeamsCheckPermissionsForRepoInOrg**
> TeamRepository TeamsCheckPermissionsForRepoInOrg (string org, string teamSlug, string owner, string repo)

Check team permissions for a repository

Checks whether a team has `admin`, `push`, `maintain`, `triage`, or `pull` permission for a repository. Repositories inherited through a parent team will also be checked.  You can also get information about the specified repository, including what permissions the team grants on it, by passing the following custom [media type](https://docs.github.com/rest/overview/media-types/) via the `application/vnd.github.v3.repository+json` accept header.  If a team doesn't have permission for the repository, you will receive a `404 Not Found` response status.  **Note:** You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/repos/{owner}/{repo}`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsCheckPermissionsForRepoInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Check team permissions for a repository
                TeamRepository result = apiInstance.TeamsCheckPermissionsForRepoInOrg(org, teamSlug, owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsCheckPermissionsForRepoInOrg: " + e.Message );
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
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 

### Return type

[**TeamRepository**](TeamRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamscheckpermissionsforrepolegacy"></a>
# **TeamsCheckPermissionsForRepoLegacy**
> TeamRepository TeamsCheckPermissionsForRepoLegacy (int? teamId, string owner, string repo)

Check team permissions for a repository (Legacy)

**Note**: Repositories inherited through a parent team will also be checked.  **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Check team permissions for a repository](https://docs.github.com/rest/reference/teams#check-team-permissions-for-a-repository) endpoint.  You can also get information about the specified repository, including what permissions the team grants on it, by passing the following custom [media type](https://docs.github.com/rest/overview/media-types/) via the `Accept` header:

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsCheckPermissionsForRepoLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Check team permissions for a repository (Legacy)
                TeamRepository result = apiInstance.TeamsCheckPermissionsForRepoLegacy(teamId, owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsCheckPermissionsForRepoLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 

### Return type

[**TeamRepository**](TeamRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamscreate"></a>
# **TeamsCreate**
> FullTeam TeamsCreate (string org, TeamsCreateRequest teamsCreateRequest)

Create a team

To create a team, the authenticated user must be a member or owner of `{org}`. By default, organization members can create teams. Organization owners can limit team creation to organization owners. For more information, see \"[Setting team creation permissions](https://docs.github.com/en/articles/setting-team-creation-permissions-in-your-organization).\"  When you create a new team, you automatically become a team maintainer without explicitly adding yourself to the optional array of `maintainers`. For more information, see \"[About teams](https://docs.github.com/en/github/setting-up-and-managing-organizations-and-teams/about-teams)\".

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsCreateExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamsCreateRequest = new TeamsCreateRequest(); // TeamsCreateRequest | 

            try
            {
                // Create a team
                FullTeam result = apiInstance.TeamsCreate(org, teamsCreateRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **teamsCreateRequest** | [**TeamsCreateRequest**](TeamsCreateRequest.md)|  | 

### Return type

[**FullTeam**](FullTeam.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamscreatediscussioncommentinorg"></a>
# **TeamsCreateDiscussionCommentInOrg**
> TeamDiscussionComment TeamsCreateDiscussionCommentInOrg (string org, string teamSlug, int? discussionNumber, TeamsCreateDiscussionCommentInOrgRequest teamsCreateDiscussionCommentInOrgRequest)

Create a discussion comment

Creates a new comment on a team discussion. OAuth access tokens require the `write:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \"[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\" and \"[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\" for details.  **Note:** You can also specify a team by `org_id` and `team_id` using the route `POST /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}/comments`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsCreateDiscussionCommentInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.
            var teamsCreateDiscussionCommentInOrgRequest = new TeamsCreateDiscussionCommentInOrgRequest(); // TeamsCreateDiscussionCommentInOrgRequest | 

            try
            {
                // Create a discussion comment
                TeamDiscussionComment result = apiInstance.TeamsCreateDiscussionCommentInOrg(org, teamSlug, discussionNumber, teamsCreateDiscussionCommentInOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsCreateDiscussionCommentInOrg: " + e.Message );
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
 **teamsCreateDiscussionCommentInOrgRequest** | [**TeamsCreateDiscussionCommentInOrgRequest**](TeamsCreateDiscussionCommentInOrgRequest.md)|  | 

### Return type

[**TeamDiscussionComment**](TeamDiscussionComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamscreatediscussioncommentlegacy"></a>
# **TeamsCreateDiscussionCommentLegacy**
> TeamDiscussionComment TeamsCreateDiscussionCommentLegacy (int? teamId, int? discussionNumber, TeamsCreateDiscussionCommentInOrgRequest teamsCreateDiscussionCommentInOrgRequest)

Create a discussion comment (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Create a discussion comment](https://docs.github.com/rest/reference/teams#create-a-discussion-comment) endpoint.  Creates a new comment on a team discussion. OAuth access tokens require the `write:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \"[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\" and \"[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\" for details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsCreateDiscussionCommentLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.
            var teamsCreateDiscussionCommentInOrgRequest = new TeamsCreateDiscussionCommentInOrgRequest(); // TeamsCreateDiscussionCommentInOrgRequest | 

            try
            {
                // Create a discussion comment (Legacy)
                TeamDiscussionComment result = apiInstance.TeamsCreateDiscussionCommentLegacy(teamId, discussionNumber, teamsCreateDiscussionCommentInOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsCreateDiscussionCommentLegacy: " + e.Message );
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
 **teamsCreateDiscussionCommentInOrgRequest** | [**TeamsCreateDiscussionCommentInOrgRequest**](TeamsCreateDiscussionCommentInOrgRequest.md)|  | 

### Return type

[**TeamDiscussionComment**](TeamDiscussionComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamscreatediscussioninorg"></a>
# **TeamsCreateDiscussionInOrg**
> TeamDiscussion TeamsCreateDiscussionInOrg (string org, string teamSlug, TeamsCreateDiscussionInOrgRequest teamsCreateDiscussionInOrgRequest)

Create a discussion

Creates a new discussion post on a team's page. OAuth access tokens require the `write:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \"[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\" and \"[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\" for details.  **Note:** You can also specify a team by `org_id` and `team_id` using the route `POST /organizations/{org_id}/team/{team_id}/discussions`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsCreateDiscussionInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var teamsCreateDiscussionInOrgRequest = new TeamsCreateDiscussionInOrgRequest(); // TeamsCreateDiscussionInOrgRequest | 

            try
            {
                // Create a discussion
                TeamDiscussion result = apiInstance.TeamsCreateDiscussionInOrg(org, teamSlug, teamsCreateDiscussionInOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsCreateDiscussionInOrg: " + e.Message );
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
 **teamsCreateDiscussionInOrgRequest** | [**TeamsCreateDiscussionInOrgRequest**](TeamsCreateDiscussionInOrgRequest.md)|  | 

### Return type

[**TeamDiscussion**](TeamDiscussion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamscreatediscussionlegacy"></a>
# **TeamsCreateDiscussionLegacy**
> TeamDiscussion TeamsCreateDiscussionLegacy (int? teamId, TeamsCreateDiscussionInOrgRequest teamsCreateDiscussionInOrgRequest)

Create a discussion (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [`Create a discussion`](https://docs.github.com/rest/reference/teams#create-a-discussion) endpoint.  Creates a new discussion post on a team's page. OAuth access tokens require the `write:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \"[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\" and \"[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\" for details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsCreateDiscussionLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var teamsCreateDiscussionInOrgRequest = new TeamsCreateDiscussionInOrgRequest(); // TeamsCreateDiscussionInOrgRequest | 

            try
            {
                // Create a discussion (Legacy)
                TeamDiscussion result = apiInstance.TeamsCreateDiscussionLegacy(teamId, teamsCreateDiscussionInOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsCreateDiscussionLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **teamsCreateDiscussionInOrgRequest** | [**TeamsCreateDiscussionInOrgRequest**](TeamsCreateDiscussionInOrgRequest.md)|  | 

### Return type

[**TeamDiscussion**](TeamDiscussion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamscreateorupdateidpgroupconnectionsinorg"></a>
# **TeamsCreateOrUpdateIdpGroupConnectionsInOrg**
> GroupMapping TeamsCreateOrUpdateIdpGroupConnectionsInOrg (string org, string teamSlug, TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequest teamsCreateOrUpdateIdpGroupConnectionsInOrgRequest)

Create or update IdP group connections

Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Creates, updates, or removes a connection between a team and an IdP group. When adding groups to a team, you must include all new and existing groups to avoid replacing existing groups with the new ones. Specifying an empty `groups` array will remove all connections for a team.  **Note:** You can also specify a team by `org_id` and `team_id` using the route `PATCH /organizations/{org_id}/team/{team_id}/team-sync/group-mappings`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsCreateOrUpdateIdpGroupConnectionsInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var teamsCreateOrUpdateIdpGroupConnectionsInOrgRequest = new TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequest(); // TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequest | 

            try
            {
                // Create or update IdP group connections
                GroupMapping result = apiInstance.TeamsCreateOrUpdateIdpGroupConnectionsInOrg(org, teamSlug, teamsCreateOrUpdateIdpGroupConnectionsInOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsCreateOrUpdateIdpGroupConnectionsInOrg: " + e.Message );
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
 **teamsCreateOrUpdateIdpGroupConnectionsInOrgRequest** | [**TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequest**](TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequest.md)|  | 

### Return type

[**GroupMapping**](GroupMapping.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamscreateorupdateidpgroupconnectionslegacy"></a>
# **TeamsCreateOrUpdateIdpGroupConnectionsLegacy**
> GroupMapping TeamsCreateOrUpdateIdpGroupConnectionsLegacy (int? teamId, TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequest teamsCreateOrUpdateIdpGroupConnectionsLegacyRequest)

Create or update IdP group connections (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [`Create or update IdP group connections`](https://docs.github.com/rest/reference/teams#create-or-update-idp-group-connections) endpoint.  Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Creates, updates, or removes a connection between a team and an IdP group. When adding groups to a team, you must include all new and existing groups to avoid replacing existing groups with the new ones. Specifying an empty `groups` array will remove all connections for a team.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsCreateOrUpdateIdpGroupConnectionsLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var teamsCreateOrUpdateIdpGroupConnectionsLegacyRequest = new TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequest(); // TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequest | 

            try
            {
                // Create or update IdP group connections (Legacy)
                GroupMapping result = apiInstance.TeamsCreateOrUpdateIdpGroupConnectionsLegacy(teamId, teamsCreateOrUpdateIdpGroupConnectionsLegacyRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsCreateOrUpdateIdpGroupConnectionsLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **teamsCreateOrUpdateIdpGroupConnectionsLegacyRequest** | [**TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequest**](TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequest.md)|  | 

### Return type

[**GroupMapping**](GroupMapping.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsdeletediscussioncommentinorg"></a>
# **TeamsDeleteDiscussionCommentInOrg**
> void TeamsDeleteDiscussionCommentInOrg (string org, string teamSlug, int? discussionNumber, int? commentNumber)

Delete a discussion comment

Deletes a comment on a team discussion. OAuth access tokens require the `write:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by `org_id` and `team_id` using the route `DELETE /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}/comments/{comment_number}`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsDeleteDiscussionCommentInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.
            var commentNumber = 56;  // int? | The number that identifies the comment.

            try
            {
                // Delete a discussion comment
                apiInstance.TeamsDeleteDiscussionCommentInOrg(org, teamSlug, discussionNumber, commentNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsDeleteDiscussionCommentInOrg: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsdeletediscussioncommentlegacy"></a>
# **TeamsDeleteDiscussionCommentLegacy**
> void TeamsDeleteDiscussionCommentLegacy (int? teamId, int? discussionNumber, int? commentNumber)

Delete a discussion comment (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Delete a discussion comment](https://docs.github.com/rest/reference/teams#delete-a-discussion-comment) endpoint.  Deletes a comment on a team discussion. OAuth access tokens require the `write:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsDeleteDiscussionCommentLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.
            var commentNumber = 56;  // int? | The number that identifies the comment.

            try
            {
                // Delete a discussion comment (Legacy)
                apiInstance.TeamsDeleteDiscussionCommentLegacy(teamId, discussionNumber, commentNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsDeleteDiscussionCommentLegacy: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsdeletediscussioninorg"></a>
# **TeamsDeleteDiscussionInOrg**
> void TeamsDeleteDiscussionInOrg (string org, string teamSlug, int? discussionNumber)

Delete a discussion

Delete a discussion from a team's page. OAuth access tokens require the `write:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by `org_id` and `team_id` using the route `DELETE /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsDeleteDiscussionInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.

            try
            {
                // Delete a discussion
                apiInstance.TeamsDeleteDiscussionInOrg(org, teamSlug, discussionNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsDeleteDiscussionInOrg: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsdeletediscussionlegacy"></a>
# **TeamsDeleteDiscussionLegacy**
> void TeamsDeleteDiscussionLegacy (int? teamId, int? discussionNumber)

Delete a discussion (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [`Delete a discussion`](https://docs.github.com/rest/reference/teams#delete-a-discussion) endpoint.  Delete a discussion from a team's page. OAuth access tokens require the `write:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsDeleteDiscussionLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.

            try
            {
                // Delete a discussion (Legacy)
                apiInstance.TeamsDeleteDiscussionLegacy(teamId, discussionNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsDeleteDiscussionLegacy: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsdeleteinorg"></a>
# **TeamsDeleteInOrg**
> void TeamsDeleteInOrg (string org, string teamSlug)

Delete a team

To delete a team, the authenticated user must be an organization owner or team maintainer.  If you are an organization owner, deleting a parent team will delete all of its child teams as well.  **Note:** You can also specify a team by `org_id` and `team_id` using the route `DELETE /organizations/{org_id}/team/{team_id}`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsDeleteInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.

            try
            {
                // Delete a team
                apiInstance.TeamsDeleteInOrg(org, teamSlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsDeleteInOrg: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsdeletelegacy"></a>
# **TeamsDeleteLegacy**
> void TeamsDeleteLegacy (int? teamId)

Delete a team (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Delete a team](https://docs.github.com/rest/reference/teams#delete-a-team) endpoint.  To delete a team, the authenticated user must be an organization owner or team maintainer.  If you are an organization owner, deleting a parent team will delete all of its child teams as well.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsDeleteLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.

            try
            {
                // Delete a team (Legacy)
                apiInstance.TeamsDeleteLegacy(teamId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsDeleteLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsexternalidpgroupinfofororg"></a>
# **TeamsExternalIdpGroupInfoForOrg**
> ExternalGroup TeamsExternalIdpGroupInfoForOrg (string org, int? groupId)

Get an external group

Displays information about the specific group's usage.  Provides a list of the group's external members as well as a list of teams that this group is connected to.  You can manage team membership with your identity provider using Enterprise Managed Users for GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products)\" in the GitHub Help documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsExternalIdpGroupInfoForOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var groupId = 56;  // int? | The unique identifier of the group.

            try
            {
                // Get an external group
                ExternalGroup result = apiInstance.TeamsExternalIdpGroupInfoForOrg(org, groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsExternalIdpGroupInfoForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **groupId** | **int?**| The unique identifier of the group. | 

### Return type

[**ExternalGroup**](ExternalGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsgetbyname"></a>
# **TeamsGetByName**
> FullTeam TeamsGetByName (string org, string teamSlug)

Get a team by name

Gets a team using the team's `slug`. GitHub generates the `slug` from the team `name`.  **Note:** You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsGetByNameExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.

            try
            {
                // Get a team by name
                FullTeam result = apiInstance.TeamsGetByName(org, teamSlug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsGetByName: " + e.Message );
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

### Return type

[**FullTeam**](FullTeam.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsgetdiscussioncommentinorg"></a>
# **TeamsGetDiscussionCommentInOrg**
> TeamDiscussionComment TeamsGetDiscussionCommentInOrg (string org, string teamSlug, int? discussionNumber, int? commentNumber)

Get a discussion comment

Get a specific comment on a team discussion. OAuth access tokens require the `read:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}/comments/{comment_number}`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsGetDiscussionCommentInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.
            var commentNumber = 56;  // int? | The number that identifies the comment.

            try
            {
                // Get a discussion comment
                TeamDiscussionComment result = apiInstance.TeamsGetDiscussionCommentInOrg(org, teamSlug, discussionNumber, commentNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsGetDiscussionCommentInOrg: " + e.Message );
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

### Return type

[**TeamDiscussionComment**](TeamDiscussionComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsgetdiscussioncommentlegacy"></a>
# **TeamsGetDiscussionCommentLegacy**
> TeamDiscussionComment TeamsGetDiscussionCommentLegacy (int? teamId, int? discussionNumber, int? commentNumber)

Get a discussion comment (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Get a discussion comment](https://docs.github.com/rest/reference/teams#get-a-discussion-comment) endpoint.  Get a specific comment on a team discussion. OAuth access tokens require the `read:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsGetDiscussionCommentLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.
            var commentNumber = 56;  // int? | The number that identifies the comment.

            try
            {
                // Get a discussion comment (Legacy)
                TeamDiscussionComment result = apiInstance.TeamsGetDiscussionCommentLegacy(teamId, discussionNumber, commentNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsGetDiscussionCommentLegacy: " + e.Message );
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

### Return type

[**TeamDiscussionComment**](TeamDiscussionComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsgetdiscussioninorg"></a>
# **TeamsGetDiscussionInOrg**
> TeamDiscussion TeamsGetDiscussionInOrg (string org, string teamSlug, int? discussionNumber)

Get a discussion

Get a specific discussion on a team's page. OAuth access tokens require the `read:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsGetDiscussionInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.

            try
            {
                // Get a discussion
                TeamDiscussion result = apiInstance.TeamsGetDiscussionInOrg(org, teamSlug, discussionNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsGetDiscussionInOrg: " + e.Message );
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

### Return type

[**TeamDiscussion**](TeamDiscussion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsgetdiscussionlegacy"></a>
# **TeamsGetDiscussionLegacy**
> TeamDiscussion TeamsGetDiscussionLegacy (int? teamId, int? discussionNumber)

Get a discussion (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Get a discussion](https://docs.github.com/rest/reference/teams#get-a-discussion) endpoint.  Get a specific discussion on a team's page. OAuth access tokens require the `read:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsGetDiscussionLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.

            try
            {
                // Get a discussion (Legacy)
                TeamDiscussion result = apiInstance.TeamsGetDiscussionLegacy(teamId, discussionNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsGetDiscussionLegacy: " + e.Message );
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

### Return type

[**TeamDiscussion**](TeamDiscussion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsgetlegacy"></a>
# **TeamsGetLegacy**
> FullTeam TeamsGetLegacy (int? teamId)

Get a team (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the [Get a team by name](https://docs.github.com/rest/reference/teams#get-a-team-by-name) endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsGetLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.

            try
            {
                // Get a team (Legacy)
                FullTeam result = apiInstance.TeamsGetLegacy(teamId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsGetLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 

### Return type

[**FullTeam**](FullTeam.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsgetmemberlegacy"></a>
# **TeamsGetMemberLegacy**
> void TeamsGetMemberLegacy (int? teamId, string username)

Get team member (Legacy)

The \"Get team member\" endpoint (described below) is deprecated.  We recommend using the [Get team membership for a user](https://docs.github.com/rest/reference/teams#get-team-membership-for-a-user) endpoint instead. It allows you to get both active and pending memberships.  To list members in a team, the team must be visible to the authenticated user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsGetMemberLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Get team member (Legacy)
                apiInstance.TeamsGetMemberLegacy(teamId, username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsGetMemberLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsgetmembershipforuserinorg"></a>
# **TeamsGetMembershipForUserInOrg**
> TeamMembership TeamsGetMembershipForUserInOrg (string org, string teamSlug, string username)

Get team membership for a user

Team members will include the members of child teams.  To get a user's membership with a team, the team must be visible to the authenticated user.  **Note:** You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/memberships/{username}`.  **Note:** The response contains the `state` of the membership and the member's `role`.  The `role` for organization owners is set to `maintainer`. For more information about `maintainer` roles, see see [Create a team](https://docs.github.com/rest/reference/teams#create-a-team).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsGetMembershipForUserInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Get team membership for a user
                TeamMembership result = apiInstance.TeamsGetMembershipForUserInOrg(org, teamSlug, username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsGetMembershipForUserInOrg: " + e.Message );
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
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

[**TeamMembership**](TeamMembership.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsgetmembershipforuserlegacy"></a>
# **TeamsGetMembershipForUserLegacy**
> TeamMembership TeamsGetMembershipForUserLegacy (int? teamId, string username)

Get team membership for a user (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Get team membership for a user](https://docs.github.com/rest/reference/teams#get-team-membership-for-a-user) endpoint.  Team members will include the members of child teams.  To get a user's membership with a team, the team must be visible to the authenticated user.  **Note:** The response contains the `state` of the membership and the member's `role`.  The `role` for organization owners is set to `maintainer`. For more information about `maintainer` roles, see [Create a team](https://docs.github.com/rest/reference/teams#create-a-team).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsGetMembershipForUserLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Get team membership for a user (Legacy)
                TeamMembership result = apiInstance.TeamsGetMembershipForUserLegacy(teamId, username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsGetMembershipForUserLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

[**TeamMembership**](TeamMembership.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamslinkexternalidpgrouptoteamfororg"></a>
# **TeamsLinkExternalIdpGroupToTeamForOrg**
> ExternalGroup TeamsLinkExternalIdpGroupToTeamForOrg (string org, string teamSlug, TeamsLinkExternalIdpGroupToTeamForOrgRequest teamsLinkExternalIdpGroupToTeamForOrgRequest)

Update the connection between an external group and a team

Creates a connection between a team and an external group.  Only one external group can be linked to a team.  You can manage team membership with your identity provider using Enterprise Managed Users for GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products)\" in the GitHub Help documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsLinkExternalIdpGroupToTeamForOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var teamsLinkExternalIdpGroupToTeamForOrgRequest = new TeamsLinkExternalIdpGroupToTeamForOrgRequest(); // TeamsLinkExternalIdpGroupToTeamForOrgRequest | 

            try
            {
                // Update the connection between an external group and a team
                ExternalGroup result = apiInstance.TeamsLinkExternalIdpGroupToTeamForOrg(org, teamSlug, teamsLinkExternalIdpGroupToTeamForOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsLinkExternalIdpGroupToTeamForOrg: " + e.Message );
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
 **teamsLinkExternalIdpGroupToTeamForOrgRequest** | [**TeamsLinkExternalIdpGroupToTeamForOrgRequest**](TeamsLinkExternalIdpGroupToTeamForOrgRequest.md)|  | 

### Return type

[**ExternalGroup**](ExternalGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamslist"></a>
# **TeamsList**
> List<Team> TeamsList (string org, int? perPage, int? page)

List teams

Lists all teams in an organization that are visible to the authenticated user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsListExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List teams
                List&lt;Team&gt; result = apiInstance.TeamsList(org, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsList: " + e.Message );
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

[**List<Team>**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamslistchildinorg"></a>
# **TeamsListChildInOrg**
> List<Team> TeamsListChildInOrg (string org, string teamSlug, int? perPage, int? page)

List child teams

Lists the child teams of the team specified by `{team_slug}`.  **Note:** You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/teams`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsListChildInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List child teams
                List&lt;Team&gt; result = apiInstance.TeamsListChildInOrg(org, teamSlug, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsListChildInOrg: " + e.Message );
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
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Team>**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamslistchildlegacy"></a>
# **TeamsListChildLegacy**
> List<Team> TeamsListChildLegacy (int? teamId, int? perPage, int? page)

List child teams (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [`List child teams`](https://docs.github.com/rest/reference/teams#list-child-teams) endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsListChildLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List child teams (Legacy)
                List&lt;Team&gt; result = apiInstance.TeamsListChildLegacy(teamId, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsListChildLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Team>**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamslistdiscussioncommentsinorg"></a>
# **TeamsListDiscussionCommentsInOrg**
> List<TeamDiscussionComment> TeamsListDiscussionCommentsInOrg (string org, string teamSlug, int? discussionNumber, string direction, int? perPage, int? page)

List discussion comments

List all comments on a team discussion. OAuth access tokens require the `read:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}/comments`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsListDiscussionCommentsInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.
            var direction = "asc";  // string | The direction to sort the results by. (optional)  (default to desc)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List discussion comments
                List&lt;TeamDiscussionComment&gt; result = apiInstance.TeamsListDiscussionCommentsInOrg(org, teamSlug, discussionNumber, direction, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsListDiscussionCommentsInOrg: " + e.Message );
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
 **direction** | **string**| The direction to sort the results by. | [optional] [default to desc]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<TeamDiscussionComment>**](TeamDiscussionComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamslistdiscussioncommentslegacy"></a>
# **TeamsListDiscussionCommentsLegacy**
> List<TeamDiscussionComment> TeamsListDiscussionCommentsLegacy (int? teamId, int? discussionNumber, string direction, int? perPage, int? page)

List discussion comments (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [List discussion comments](https://docs.github.com/rest/reference/teams#list-discussion-comments) endpoint.  List all comments on a team discussion. OAuth access tokens require the `read:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsListDiscussionCommentsLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.
            var direction = "asc";  // string | The direction to sort the results by. (optional)  (default to desc)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List discussion comments (Legacy)
                List&lt;TeamDiscussionComment&gt; result = apiInstance.TeamsListDiscussionCommentsLegacy(teamId, discussionNumber, direction, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsListDiscussionCommentsLegacy: " + e.Message );
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
 **direction** | **string**| The direction to sort the results by. | [optional] [default to desc]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<TeamDiscussionComment>**](TeamDiscussionComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamslistdiscussionsinorg"></a>
# **TeamsListDiscussionsInOrg**
> List<TeamDiscussion> TeamsListDiscussionsInOrg (string org, string teamSlug, string direction, int? perPage, int? page, string pinned)

List discussions

List all discussions on a team's page. OAuth access tokens require the `read:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/discussions`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsListDiscussionsInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var direction = "asc";  // string | The direction to sort the results by. (optional)  (default to desc)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var pinned = "pinned_example";  // string | Pinned discussions only filter (optional) 

            try
            {
                // List discussions
                List&lt;TeamDiscussion&gt; result = apiInstance.TeamsListDiscussionsInOrg(org, teamSlug, direction, perPage, page, pinned);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsListDiscussionsInOrg: " + e.Message );
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
 **direction** | **string**| The direction to sort the results by. | [optional] [default to desc]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **pinned** | **string**| Pinned discussions only filter | [optional] 

### Return type

[**List<TeamDiscussion>**](TeamDiscussion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamslistdiscussionslegacy"></a>
# **TeamsListDiscussionsLegacy**
> List<TeamDiscussion> TeamsListDiscussionsLegacy (int? teamId, string direction, int? perPage, int? page)

List discussions (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [`List discussions`](https://docs.github.com/rest/reference/teams#list-discussions) endpoint.  List all discussions on a team's page. OAuth access tokens require the `read:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsListDiscussionsLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var direction = "asc";  // string | The direction to sort the results by. (optional)  (default to desc)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List discussions (Legacy)
                List&lt;TeamDiscussion&gt; result = apiInstance.TeamsListDiscussionsLegacy(teamId, direction, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsListDiscussionsLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **direction** | **string**| The direction to sort the results by. | [optional] [default to desc]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<TeamDiscussion>**](TeamDiscussion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamslistexternalidpgroupsfororg"></a>
# **TeamsListExternalIdpGroupsForOrg**
> ExternalGroups TeamsListExternalIdpGroupsForOrg (string org, int? perPage, int? page, string displayName)

List external groups in an organization

Lists external groups available in an organization. You can query the groups using the `display_name` parameter, only groups with a `group_name` containing the text provided in the `display_name` parameter will be returned.  You can also limit your page results using the `per_page` parameter. GitHub generates a url-encoded `page` token using a cursor value for where the next page begins. For more information on cursor pagination, see \"[Offset and Cursor Pagination explained](https://dev.to/jackmarchant/offset-and-cursor-pagination-explained-b89).\"  You can manage team membership with your identity provider using Enterprise Managed Users for GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products)\" in the GitHub Help documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsListExternalIdpGroupsForOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 56;  // int? | Page token (optional) 
            var displayName = "displayName_example";  // string | Limits the list to groups containing the text in the group name (optional) 

            try
            {
                // List external groups in an organization
                ExternalGroups result = apiInstance.TeamsListExternalIdpGroupsForOrg(org, perPage, page, displayName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsListExternalIdpGroupsForOrg: " + e.Message );
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
 **page** | **int?**| Page token | [optional] 
 **displayName** | **string**| Limits the list to groups containing the text in the group name | [optional] 

### Return type

[**ExternalGroups**](ExternalGroups.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamslistforauthenticateduser"></a>
# **TeamsListForAuthenticatedUser**
> List<FullTeam> TeamsListForAuthenticatedUser (int? perPage, int? page)

List teams for the authenticated user

List all of the teams across all of the organizations to which the authenticated user belongs. This method requires `user`, `repo`, or `read:org` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/) when authenticating via [OAuth](https://docs.github.com/apps/building-oauth-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsListForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List teams for the authenticated user
                List&lt;FullTeam&gt; result = apiInstance.TeamsListForAuthenticatedUser(perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsListForAuthenticatedUser: " + e.Message );
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

[**List<FullTeam>**](FullTeam.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamslistidpgroupsforlegacy"></a>
# **TeamsListIdpGroupsForLegacy**
> GroupMapping TeamsListIdpGroupsForLegacy (int? teamId)

List IdP groups for a team (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [`List IdP groups for a team`](https://docs.github.com/rest/reference/teams#list-idp-groups-for-a-team) endpoint.  Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  List IdP groups connected to a team on GitHub.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsListIdpGroupsForLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.

            try
            {
                // List IdP groups for a team (Legacy)
                GroupMapping result = apiInstance.TeamsListIdpGroupsForLegacy(teamId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsListIdpGroupsForLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 

### Return type

[**GroupMapping**](GroupMapping.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamslistidpgroupsfororg"></a>
# **TeamsListIdpGroupsForOrg**
> GroupMapping TeamsListIdpGroupsForOrg (string org, int? perPage, string page)

List IdP groups for an organization

Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  List IdP groups available in an organization. You can limit your page results using the `per_page` parameter. GitHub generates a url-encoded `page` token using a cursor value for where the next page begins. For more information on cursor pagination, see \"[Offset and Cursor Pagination explained](https://dev.to/jackmarchant/offset-and-cursor-pagination-explained-b89).\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsListIdpGroupsForOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = "page_example";  // string | Page token (optional) 

            try
            {
                // List IdP groups for an organization
                GroupMapping result = apiInstance.TeamsListIdpGroupsForOrg(org, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsListIdpGroupsForOrg: " + e.Message );
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
 **page** | **string**| Page token | [optional] 

### Return type

[**GroupMapping**](GroupMapping.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamslistidpgroupsinorg"></a>
# **TeamsListIdpGroupsInOrg**
> GroupMapping TeamsListIdpGroupsInOrg (string org, string teamSlug)

List IdP groups for a team

Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  List IdP groups connected to a team on GitHub.  **Note:** You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/team-sync/group-mappings`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsListIdpGroupsInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.

            try
            {
                // List IdP groups for a team
                GroupMapping result = apiInstance.TeamsListIdpGroupsInOrg(org, teamSlug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsListIdpGroupsInOrg: " + e.Message );
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

### Return type

[**GroupMapping**](GroupMapping.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamslistlinkedexternalidpgroupstoteamfororg"></a>
# **TeamsListLinkedExternalIdpGroupsToTeamForOrg**
> ExternalGroups TeamsListLinkedExternalIdpGroupsToTeamForOrg (string org, string teamSlug)

List a connection between an external group and a team

Lists a connection between a team and an external group.  You can manage team membership with your identity provider using Enterprise Managed Users for GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products)\" in the GitHub Help documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsListLinkedExternalIdpGroupsToTeamForOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.

            try
            {
                // List a connection between an external group and a team
                ExternalGroups result = apiInstance.TeamsListLinkedExternalIdpGroupsToTeamForOrg(org, teamSlug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsListLinkedExternalIdpGroupsToTeamForOrg: " + e.Message );
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

### Return type

[**ExternalGroups**](ExternalGroups.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamslistmembersinorg"></a>
# **TeamsListMembersInOrg**
> List<SimpleUser1> TeamsListMembersInOrg (string org, string teamSlug, string role, int? perPage, int? page)

List team members

Team members will include the members of child teams.  To list members in a team, the team must be visible to the authenticated user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsListMembersInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var role = "member";  // string | Filters members returned by their role in the team. (optional)  (default to all)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List team members
                List&lt;SimpleUser1&gt; result = apiInstance.TeamsListMembersInOrg(org, teamSlug, role, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsListMembersInOrg: " + e.Message );
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
 **role** | **string**| Filters members returned by their role in the team. | [optional] [default to all]
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

<a name="teamslistmemberslegacy"></a>
# **TeamsListMembersLegacy**
> List<SimpleUser1> TeamsListMembersLegacy (int? teamId, string role, int? perPage, int? page)

List team members (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [`List team members`](https://docs.github.com/rest/reference/teams#list-team-members) endpoint.  Team members will include the members of child teams.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsListMembersLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var role = "member";  // string | Filters members returned by their role in the team. (optional)  (default to all)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List team members (Legacy)
                List&lt;SimpleUser1&gt; result = apiInstance.TeamsListMembersLegacy(teamId, role, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsListMembersLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **role** | **string**| Filters members returned by their role in the team. | [optional] [default to all]
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

<a name="teamslistpendinginvitationsinorg"></a>
# **TeamsListPendingInvitationsInOrg**
> List<OrganizationInvitation> TeamsListPendingInvitationsInOrg (string org, string teamSlug, int? perPage, int? page)

List pending team invitations

The return hash contains a `role` field which refers to the Organization Invitation role and will be one of the following values: `direct_member`, `admin`, `billing_manager`, `hiring_manager`, or `reinstate`. If the invitee is not a GitHub member, the `login` field in the return hash will be `null`.  **Note:** You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/invitations`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsListPendingInvitationsInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List pending team invitations
                List&lt;OrganizationInvitation&gt; result = apiInstance.TeamsListPendingInvitationsInOrg(org, teamSlug, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsListPendingInvitationsInOrg: " + e.Message );
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
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<OrganizationInvitation>**](OrganizationInvitation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamslistpendinginvitationslegacy"></a>
# **TeamsListPendingInvitationsLegacy**
> List<OrganizationInvitation> TeamsListPendingInvitationsLegacy (int? teamId, int? perPage, int? page)

List pending team invitations (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [`List pending team invitations`](https://docs.github.com/rest/reference/teams#list-pending-team-invitations) endpoint.  The return hash contains a `role` field which refers to the Organization Invitation role and will be one of the following values: `direct_member`, `admin`, `billing_manager`, `hiring_manager`, or `reinstate`. If the invitee is not a GitHub member, the `login` field in the return hash will be `null`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsListPendingInvitationsLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List pending team invitations (Legacy)
                List&lt;OrganizationInvitation&gt; result = apiInstance.TeamsListPendingInvitationsLegacy(teamId, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsListPendingInvitationsLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<OrganizationInvitation>**](OrganizationInvitation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamslistprojectsinorg"></a>
# **TeamsListProjectsInOrg**
> List<TeamProject> TeamsListProjectsInOrg (string org, string teamSlug, int? perPage, int? page)

List team projects

Lists the organization projects for a team.  **Note:** You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/projects`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsListProjectsInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List team projects
                List&lt;TeamProject&gt; result = apiInstance.TeamsListProjectsInOrg(org, teamSlug, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsListProjectsInOrg: " + e.Message );
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
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<TeamProject>**](TeamProject.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamslistprojectslegacy"></a>
# **TeamsListProjectsLegacy**
> List<TeamProject> TeamsListProjectsLegacy (int? teamId, int? perPage, int? page)

List team projects (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [`List team projects`](https://docs.github.com/rest/reference/teams#list-team-projects) endpoint.  Lists the organization projects for a team.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsListProjectsLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List team projects (Legacy)
                List&lt;TeamProject&gt; result = apiInstance.TeamsListProjectsLegacy(teamId, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsListProjectsLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<TeamProject>**](TeamProject.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamslistreposinorg"></a>
# **TeamsListReposInOrg**
> List<MinimalRepository> TeamsListReposInOrg (string org, string teamSlug, int? perPage, int? page)

List team repositories

Lists a team's repositories visible to the authenticated user.  **Note:** You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/repos`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsListReposInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List team repositories
                List&lt;MinimalRepository&gt; result = apiInstance.TeamsListReposInOrg(org, teamSlug, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsListReposInOrg: " + e.Message );
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

<a name="teamslistreposlegacy"></a>
# **TeamsListReposLegacy**
> List<MinimalRepository> TeamsListReposLegacy (int? teamId, int? perPage, int? page)

List team repositories (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [List team repositories](https://docs.github.com/rest/reference/teams#list-team-repositories) endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsListReposLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List team repositories (Legacy)
                List&lt;MinimalRepository&gt; result = apiInstance.TeamsListReposLegacy(teamId, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsListReposLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
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

<a name="teamsremovememberlegacy"></a>
# **TeamsRemoveMemberLegacy**
> void TeamsRemoveMemberLegacy (int? teamId, string username)

Remove team member (Legacy)

The \"Remove team member\" endpoint (described below) is deprecated.  We recommend using the [Remove team membership for a user](https://docs.github.com/rest/reference/teams#remove-team-membership-for-a-user) endpoint instead. It allows you to remove both active and pending memberships.  Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  To remove a team member, the authenticated user must have 'admin' permissions to the team or be an owner of the org that the team is associated with. Removing a team member does not delete the user, it just removes them from the team.  **Note:** When you have team synchronization set up for a team with your organization's identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team's membership. If you have access to manage group membership in your IdP, you can manage GitHub team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see \"[Synchronizing teams between your identity provider and GitHub](https://docs.github.com/articles/synchronizing-teams-between-your-identity-provider-and-github/).\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsRemoveMemberLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Remove team member (Legacy)
                apiInstance.TeamsRemoveMemberLegacy(teamId, username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsRemoveMemberLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsremovemembershipforuserinorg"></a>
# **TeamsRemoveMembershipForUserInOrg**
> void TeamsRemoveMembershipForUserInOrg (string org, string teamSlug, string username)

Remove team membership for a user

Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  To remove a membership between a user and a team, the authenticated user must have 'admin' permissions to the team or be an owner of the organization that the team is associated with. Removing team membership does not delete the user, it just removes their membership from the team.  **Note:** When you have team synchronization set up for a team with your organization's identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team's membership. If you have access to manage group membership in your IdP, you can manage GitHub team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see \"[Synchronizing teams between your identity provider and GitHub](https://docs.github.com/articles/synchronizing-teams-between-your-identity-provider-and-github/).\"  **Note:** You can also specify a team by `org_id` and `team_id` using the route `DELETE /organizations/{org_id}/team/{team_id}/memberships/{username}`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsRemoveMembershipForUserInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Remove team membership for a user
                apiInstance.TeamsRemoveMembershipForUserInOrg(org, teamSlug, username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsRemoveMembershipForUserInOrg: " + e.Message );
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
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsremovemembershipforuserlegacy"></a>
# **TeamsRemoveMembershipForUserLegacy**
> void TeamsRemoveMembershipForUserLegacy (int? teamId, string username)

Remove team membership for a user (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Remove team membership for a user](https://docs.github.com/rest/reference/teams#remove-team-membership-for-a-user) endpoint.  Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  To remove a membership between a user and a team, the authenticated user must have 'admin' permissions to the team or be an owner of the organization that the team is associated with. Removing team membership does not delete the user, it just removes their membership from the team.  **Note:** When you have team synchronization set up for a team with your organization's identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team's membership. If you have access to manage group membership in your IdP, you can manage GitHub team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see \"[Synchronizing teams between your identity provider and GitHub](https://docs.github.com/articles/synchronizing-teams-between-your-identity-provider-and-github/).\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsRemoveMembershipForUserLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Remove team membership for a user (Legacy)
                apiInstance.TeamsRemoveMembershipForUserLegacy(teamId, username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsRemoveMembershipForUserLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsremoveprojectinorg"></a>
# **TeamsRemoveProjectInOrg**
> void TeamsRemoveProjectInOrg (string org, string teamSlug, int? projectId)

Remove a project from a team

Removes an organization project from a team. An organization owner or a team maintainer can remove any project from the team. To remove a project from a team as an organization member, the authenticated user must have `read` access to both the team and project, or `admin` access to the team or project. This endpoint removes the project from the team, but does not delete the project.  **Note:** You can also specify a team by `org_id` and `team_id` using the route `DELETE /organizations/{org_id}/team/{team_id}/projects/{project_id}`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsRemoveProjectInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var projectId = 56;  // int? | The unique identifier of the project.

            try
            {
                // Remove a project from a team
                apiInstance.TeamsRemoveProjectInOrg(org, teamSlug, projectId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsRemoveProjectInOrg: " + e.Message );
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
 **projectId** | **int?**| The unique identifier of the project. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsremoveprojectlegacy"></a>
# **TeamsRemoveProjectLegacy**
> void TeamsRemoveProjectLegacy (int? teamId, int? projectId)

Remove a project from a team (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Remove a project from a team](https://docs.github.com/rest/reference/teams#remove-a-project-from-a-team) endpoint.  Removes an organization project from a team. An organization owner or a team maintainer can remove any project from the team. To remove a project from a team as an organization member, the authenticated user must have `read` access to both the team and project, or `admin` access to the team or project. **Note:** This endpoint removes the project from the team, but does not delete it.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsRemoveProjectLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var projectId = 56;  // int? | The unique identifier of the project.

            try
            {
                // Remove a project from a team (Legacy)
                apiInstance.TeamsRemoveProjectLegacy(teamId, projectId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsRemoveProjectLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **projectId** | **int?**| The unique identifier of the project. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsremoverepoinorg"></a>
# **TeamsRemoveRepoInOrg**
> void TeamsRemoveRepoInOrg (string org, string teamSlug, string owner, string repo)

Remove a repository from a team

If the authenticated user is an organization owner or a team maintainer, they can remove any repositories from the team. To remove a repository from a team as an organization member, the authenticated user must have admin access to the repository and must be able to see the team. This does not delete the repository, it just removes it from the team.  **Note:** You can also specify a team by `org_id` and `team_id` using the route `DELETE /organizations/{org_id}/team/{team_id}/repos/{owner}/{repo}`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsRemoveRepoInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Remove a repository from a team
                apiInstance.TeamsRemoveRepoInOrg(org, teamSlug, owner, repo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsRemoveRepoInOrg: " + e.Message );
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

<a name="teamsremoverepolegacy"></a>
# **TeamsRemoveRepoLegacy**
> void TeamsRemoveRepoLegacy (int? teamId, string owner, string repo)

Remove a repository from a team (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Remove a repository from a team](https://docs.github.com/rest/reference/teams#remove-a-repository-from-a-team) endpoint.  If the authenticated user is an organization owner or a team maintainer, they can remove any repositories from the team. To remove a repository from a team as an organization member, the authenticated user must have admin access to the repository and must be able to see the team. NOTE: This does not delete the repository, it just removes it from the team.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsRemoveRepoLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Remove a repository from a team (Legacy)
                apiInstance.TeamsRemoveRepoLegacy(teamId, owner, repo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsRemoveRepoLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
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

<a name="teamsunlinkexternalidpgroupfromteamfororg"></a>
# **TeamsUnlinkExternalIdpGroupFromTeamForOrg**
> void TeamsUnlinkExternalIdpGroupFromTeamForOrg (string org, string teamSlug)

Remove the connection between an external group and a team

Deletes a connection between a team and an external group.  You can manage team membership with your IdP using Enterprise Managed Users for GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsUnlinkExternalIdpGroupFromTeamForOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.

            try
            {
                // Remove the connection between an external group and a team
                apiInstance.TeamsUnlinkExternalIdpGroupFromTeamForOrg(org, teamSlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsUnlinkExternalIdpGroupFromTeamForOrg: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsupdatediscussioncommentinorg"></a>
# **TeamsUpdateDiscussionCommentInOrg**
> TeamDiscussionComment TeamsUpdateDiscussionCommentInOrg (string org, string teamSlug, int? discussionNumber, int? commentNumber, TeamsCreateDiscussionCommentInOrgRequest teamsCreateDiscussionCommentInOrgRequest)

Update a discussion comment

Edits the body text of a discussion comment. OAuth access tokens require the `write:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by `org_id` and `team_id` using the route `PATCH /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}/comments/{comment_number}`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsUpdateDiscussionCommentInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.
            var commentNumber = 56;  // int? | The number that identifies the comment.
            var teamsCreateDiscussionCommentInOrgRequest = new TeamsCreateDiscussionCommentInOrgRequest(); // TeamsCreateDiscussionCommentInOrgRequest | 

            try
            {
                // Update a discussion comment
                TeamDiscussionComment result = apiInstance.TeamsUpdateDiscussionCommentInOrg(org, teamSlug, discussionNumber, commentNumber, teamsCreateDiscussionCommentInOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsUpdateDiscussionCommentInOrg: " + e.Message );
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
 **teamsCreateDiscussionCommentInOrgRequest** | [**TeamsCreateDiscussionCommentInOrgRequest**](TeamsCreateDiscussionCommentInOrgRequest.md)|  | 

### Return type

[**TeamDiscussionComment**](TeamDiscussionComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsupdatediscussioncommentlegacy"></a>
# **TeamsUpdateDiscussionCommentLegacy**
> TeamDiscussionComment TeamsUpdateDiscussionCommentLegacy (int? teamId, int? discussionNumber, int? commentNumber, TeamsCreateDiscussionCommentInOrgRequest teamsCreateDiscussionCommentInOrgRequest)

Update a discussion comment (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Update a discussion comment](https://docs.github.com/rest/reference/teams#update-a-discussion-comment) endpoint.  Edits the body text of a discussion comment. OAuth access tokens require the `write:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsUpdateDiscussionCommentLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.
            var commentNumber = 56;  // int? | The number that identifies the comment.
            var teamsCreateDiscussionCommentInOrgRequest = new TeamsCreateDiscussionCommentInOrgRequest(); // TeamsCreateDiscussionCommentInOrgRequest | 

            try
            {
                // Update a discussion comment (Legacy)
                TeamDiscussionComment result = apiInstance.TeamsUpdateDiscussionCommentLegacy(teamId, discussionNumber, commentNumber, teamsCreateDiscussionCommentInOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsUpdateDiscussionCommentLegacy: " + e.Message );
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
 **teamsCreateDiscussionCommentInOrgRequest** | [**TeamsCreateDiscussionCommentInOrgRequest**](TeamsCreateDiscussionCommentInOrgRequest.md)|  | 

### Return type

[**TeamDiscussionComment**](TeamDiscussionComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsupdatediscussioninorg"></a>
# **TeamsUpdateDiscussionInOrg**
> TeamDiscussion TeamsUpdateDiscussionInOrg (string org, string teamSlug, int? discussionNumber, TeamsUpdateDiscussionInOrgRequest teamsUpdateDiscussionInOrgRequest)

Update a discussion

Edits the title and body text of a discussion post. Only the parameters you provide are updated. OAuth access tokens require the `write:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by `org_id` and `team_id` using the route `PATCH /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsUpdateDiscussionInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.
            var teamsUpdateDiscussionInOrgRequest = new TeamsUpdateDiscussionInOrgRequest(); // TeamsUpdateDiscussionInOrgRequest |  (optional) 

            try
            {
                // Update a discussion
                TeamDiscussion result = apiInstance.TeamsUpdateDiscussionInOrg(org, teamSlug, discussionNumber, teamsUpdateDiscussionInOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsUpdateDiscussionInOrg: " + e.Message );
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
 **teamsUpdateDiscussionInOrgRequest** | [**TeamsUpdateDiscussionInOrgRequest**](TeamsUpdateDiscussionInOrgRequest.md)|  | [optional] 

### Return type

[**TeamDiscussion**](TeamDiscussion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsupdatediscussionlegacy"></a>
# **TeamsUpdateDiscussionLegacy**
> TeamDiscussion TeamsUpdateDiscussionLegacy (int? teamId, int? discussionNumber, TeamsUpdateDiscussionInOrgRequest teamsUpdateDiscussionInOrgRequest)

Update a discussion (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Update a discussion](https://docs.github.com/rest/reference/teams#update-a-discussion) endpoint.  Edits the title and body text of a discussion post. Only the parameters you provide are updated. OAuth access tokens require the `write:discussion` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsUpdateDiscussionLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var discussionNumber = 56;  // int? | The number that identifies the discussion.
            var teamsUpdateDiscussionInOrgRequest = new TeamsUpdateDiscussionInOrgRequest(); // TeamsUpdateDiscussionInOrgRequest |  (optional) 

            try
            {
                // Update a discussion (Legacy)
                TeamDiscussion result = apiInstance.TeamsUpdateDiscussionLegacy(teamId, discussionNumber, teamsUpdateDiscussionInOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsUpdateDiscussionLegacy: " + e.Message );
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
 **teamsUpdateDiscussionInOrgRequest** | [**TeamsUpdateDiscussionInOrgRequest**](TeamsUpdateDiscussionInOrgRequest.md)|  | [optional] 

### Return type

[**TeamDiscussion**](TeamDiscussion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsupdateinorg"></a>
# **TeamsUpdateInOrg**
> FullTeam TeamsUpdateInOrg (string org, string teamSlug, TeamsUpdateInOrgRequest teamsUpdateInOrgRequest)

Update a team

To edit a team, the authenticated user must either be an organization owner or a team maintainer.  **Note:** You can also specify a team by `org_id` and `team_id` using the route `PATCH /organizations/{org_id}/team/{team_id}`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsUpdateInOrgExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.
            var teamsUpdateInOrgRequest = new TeamsUpdateInOrgRequest(); // TeamsUpdateInOrgRequest |  (optional) 

            try
            {
                // Update a team
                FullTeam result = apiInstance.TeamsUpdateInOrg(org, teamSlug, teamsUpdateInOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsUpdateInOrg: " + e.Message );
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
 **teamsUpdateInOrgRequest** | [**TeamsUpdateInOrgRequest**](TeamsUpdateInOrgRequest.md)|  | [optional] 

### Return type

[**FullTeam**](FullTeam.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsupdatelegacy"></a>
# **TeamsUpdateLegacy**
> FullTeam TeamsUpdateLegacy (int? teamId, TeamsUpdateLegacyRequest teamsUpdateLegacyRequest)

Update a team (Legacy)

**Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Update a team](https://docs.github.com/rest/reference/teams#update-a-team) endpoint.  To edit a team, the authenticated user must either be an organization owner or a team maintainer.  **Note:** With nested teams, the `privacy` for parent teams cannot be `secret`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TeamsUpdateLegacyExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamId = 56;  // int? | The unique identifier of the team.
            var teamsUpdateLegacyRequest = new TeamsUpdateLegacyRequest(); // TeamsUpdateLegacyRequest | 

            try
            {
                // Update a team (Legacy)
                FullTeam result = apiInstance.TeamsUpdateLegacy(teamId, teamsUpdateLegacyRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsUpdateLegacy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| The unique identifier of the team. | 
 **teamsUpdateLegacyRequest** | [**TeamsUpdateLegacyRequest**](TeamsUpdateLegacyRequest.md)|  | 

### Return type

[**FullTeam**](FullTeam.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

