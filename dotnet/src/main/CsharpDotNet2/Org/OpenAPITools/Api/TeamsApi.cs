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
    public interface ITeamsApi
    {
        /// <summary>
        /// Add team member (Legacy) The \&quot;Add team member\&quot; endpoint (described below) is deprecated.  We recommend using the [Add or update team membership for a user](https://docs.github.com/rest/reference/teams#add-or-update-team-membership-for-a-user) endpoint instead. It allows you to invite new organization members to your teams.  Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  To add someone to a team, the authenticated user must be an organization owner or a team maintainer in the team they&#39;re changing. The person being added to the team must be a member of the team&#39;s organization.  **Note:** When you have team synchronization set up for a team with your organization&#39;s identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team&#39;s membership. If you have access to manage group membership in your IdP, you can manage GitHub team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see \&quot;[Synchronizing teams between your identity provider and GitHub](https://docs.github.com/articles/synchronizing-teams-between-your-identity-provider-and-github/).\&quot;  Note that you&#39;ll need to set &#x60;Content-Length&#x60; to zero when calling out to this endpoint. For more information, see \&quot;[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\&quot;
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        [Obsolete]
        void TeamsAddMemberLegacy (int? teamId, string username);
        /// <summary>
        /// Add or update team membership for a user Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Adds an organization member to a team. An authenticated organization owner or team maintainer can add organization members to a team.  **Note:** When you have team synchronization set up for a team with your organization&#39;s identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team&#39;s membership. If you have access to manage group membership in your IdP, you can manage GitHub team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see \&quot;[Synchronizing teams between your identity provider and GitHub](https://docs.github.com/articles/synchronizing-teams-between-your-identity-provider-and-github/).\&quot;  An organization owner can add someone who is not part of the team&#39;s organization to a team. When an organization owner adds someone to a team who is not an organization member, this endpoint will send an invitation to the person via email. This newly-created membership will be in the \&quot;pending\&quot; state until the person accepts the invitation, at which point the membership will transition to the \&quot;active\&quot; state and the user will be added as a member of the team.  If the user is already a member of the team, this endpoint will update the role of the team member&#39;s role. To update the membership of a team member, the authenticated user must be an organization owner or a team maintainer.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;PUT /organizations/{org_id}/team/{team_id}/memberships/{username}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="teamsAddOrUpdateMembershipForUserInOrgRequest"></param>
        /// <returns>TeamMembership</returns>
        TeamMembership TeamsAddOrUpdateMembershipForUserInOrg (string org, string teamSlug, string username, TeamsAddOrUpdateMembershipForUserInOrgRequest teamsAddOrUpdateMembershipForUserInOrgRequest);
        /// <summary>
        /// Add or update team membership for a user (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Add or update team membership for a user](https://docs.github.com/rest/reference/teams#add-or-update-team-membership-for-a-user) endpoint.  Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  If the user is already a member of the team&#39;s organization, this endpoint will add the user to the team. To add a membership between an organization member and a team, the authenticated user must be an organization owner or a team maintainer.  **Note:** When you have team synchronization set up for a team with your organization&#39;s identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team&#39;s membership. If you have access to manage group membership in your IdP, you can manage GitHub team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see \&quot;[Synchronizing teams between your identity provider and GitHub](https://docs.github.com/articles/synchronizing-teams-between-your-identity-provider-and-github/).\&quot;  If the user is unaffiliated with the team&#39;s organization, this endpoint will send an invitation to the user via email. This newly-created membership will be in the \&quot;pending\&quot; state until the user accepts the invitation, at which point the membership will transition to the \&quot;active\&quot; state and the user will be added as a member of the team. To add a membership between an unaffiliated user and a team, the authenticated user must be an organization owner.  If the user is already a member of the team, this endpoint will update the role of the team member&#39;s role. To update the membership of a team member, the authenticated user must be an organization owner or a team maintainer.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="teamsAddOrUpdateMembershipForUserInOrgRequest"></param>
        /// <returns>TeamMembership</returns>
        [Obsolete]
        TeamMembership TeamsAddOrUpdateMembershipForUserLegacy (int? teamId, string username, TeamsAddOrUpdateMembershipForUserInOrgRequest teamsAddOrUpdateMembershipForUserInOrgRequest);
        /// <summary>
        /// Add or update team project permissions Adds an organization project to a team. To add a project to a team or update the team&#39;s permission on a project, the authenticated user must have &#x60;admin&#x60; permissions for the project. The project and team must be part of the same organization.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;PUT /organizations/{org_id}/team/{team_id}/projects/{project_id}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <param name="teamsAddOrUpdateProjectPermissionsInOrgRequest"></param>
        /// <returns></returns>
        void TeamsAddOrUpdateProjectPermissionsInOrg (string org, string teamSlug, int? projectId, TeamsAddOrUpdateProjectPermissionsInOrgRequest teamsAddOrUpdateProjectPermissionsInOrgRequest);
        /// <summary>
        /// Add or update team project permissions (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Add or update team project permissions](https://docs.github.com/rest/reference/teams#add-or-update-team-project-permissions) endpoint.  Adds an organization project to a team. To add a project to a team or update the team&#39;s permission on a project, the authenticated user must have &#x60;admin&#x60; permissions for the project. The project and team must be part of the same organization.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <param name="teamsAddOrUpdateProjectPermissionsLegacyRequest"></param>
        /// <returns></returns>
        [Obsolete]
        void TeamsAddOrUpdateProjectPermissionsLegacy (int? teamId, int? projectId, TeamsAddOrUpdateProjectPermissionsLegacyRequest teamsAddOrUpdateProjectPermissionsLegacyRequest);
        /// <summary>
        /// Add or update team repository permissions To add a repository to a team or update the team&#39;s permission on a repository, the authenticated user must have admin access to the repository, and must be able to see the team. The repository must be owned by the organization, or a direct fork of a repository owned by the organization. You will get a &#x60;422 Unprocessable Entity&#x60; status if you attempt to add a repository to a team that is not owned by the organization. Note that, if you choose not to pass any parameters, you&#39;ll need to set &#x60;Content-Length&#x60; to zero when calling out to this endpoint. For more information, see \&quot;[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\&quot;  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;PUT /organizations/{org_id}/team/{team_id}/repos/{owner}/{repo}&#x60;.  For more information about the permission levels, see \&quot;[Repository permission levels for an organization](https://docs.github.com/en/github/setting-up-and-managing-organizations-and-teams/repository-permission-levels-for-an-organization#permission-levels-for-repositories-owned-by-an-organization)\&quot;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="teamsAddOrUpdateRepoPermissionsInOrgRequest"></param>
        /// <returns></returns>
        void TeamsAddOrUpdateRepoPermissionsInOrg (string org, string teamSlug, string owner, string repo, TeamsAddOrUpdateRepoPermissionsInOrgRequest teamsAddOrUpdateRepoPermissionsInOrgRequest);
        /// <summary>
        /// Add or update team repository permissions (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new \&quot;[Add or update team repository permissions](https://docs.github.com/rest/reference/teams#add-or-update-team-repository-permissions)\&quot; endpoint.  To add a repository to a team or update the team&#39;s permission on a repository, the authenticated user must have admin access to the repository, and must be able to see the team. The repository must be owned by the organization, or a direct fork of a repository owned by the organization. You will get a &#x60;422 Unprocessable Entity&#x60; status if you attempt to add a repository to a team that is not owned by the organization.  Note that, if you choose not to pass any parameters, you&#39;ll need to set &#x60;Content-Length&#x60; to zero when calling out to this endpoint. For more information, see \&quot;[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\&quot;
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="teamsAddOrUpdateRepoPermissionsLegacyRequest"></param>
        /// <returns></returns>
        [Obsolete]
        void TeamsAddOrUpdateRepoPermissionsLegacy (int? teamId, string owner, string repo, TeamsAddOrUpdateRepoPermissionsLegacyRequest teamsAddOrUpdateRepoPermissionsLegacyRequest);
        /// <summary>
        /// Check team permissions for a project Checks whether a team has &#x60;read&#x60;, &#x60;write&#x60;, or &#x60;admin&#x60; permissions for an organization project. The response includes projects inherited from a parent team.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/projects/{project_id}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <returns>TeamProject</returns>
        TeamProject TeamsCheckPermissionsForProjectInOrg (string org, string teamSlug, int? projectId);
        /// <summary>
        /// Check team permissions for a project (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Check team permissions for a project](https://docs.github.com/rest/reference/teams#check-team-permissions-for-a-project) endpoint.  Checks whether a team has &#x60;read&#x60;, &#x60;write&#x60;, or &#x60;admin&#x60; permissions for an organization project. The response includes projects inherited from a parent team.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <returns>TeamProject</returns>
        [Obsolete]
        TeamProject TeamsCheckPermissionsForProjectLegacy (int? teamId, int? projectId);
        /// <summary>
        /// Check team permissions for a repository Checks whether a team has &#x60;admin&#x60;, &#x60;push&#x60;, &#x60;maintain&#x60;, &#x60;triage&#x60;, or &#x60;pull&#x60; permission for a repository. Repositories inherited through a parent team will also be checked.  You can also get information about the specified repository, including what permissions the team grants on it, by passing the following custom [media type](https://docs.github.com/rest/overview/media-types/) via the &#x60;application/vnd.github.v3.repository+json&#x60; accept header.  If a team doesn&#39;t have permission for the repository, you will receive a &#x60;404 Not Found&#x60; response status.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/repos/{owner}/{repo}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>TeamRepository</returns>
        TeamRepository TeamsCheckPermissionsForRepoInOrg (string org, string teamSlug, string owner, string repo);
        /// <summary>
        /// Check team permissions for a repository (Legacy) **Note**: Repositories inherited through a parent team will also be checked.  **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Check team permissions for a repository](https://docs.github.com/rest/reference/teams#check-team-permissions-for-a-repository) endpoint.  You can also get information about the specified repository, including what permissions the team grants on it, by passing the following custom [media type](https://docs.github.com/rest/overview/media-types/) via the &#x60;Accept&#x60; header:
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>TeamRepository</returns>
        [Obsolete]
        TeamRepository TeamsCheckPermissionsForRepoLegacy (int? teamId, string owner, string repo);
        /// <summary>
        /// Create a team To create a team, the authenticated user must be a member or owner of &#x60;{org}&#x60;. By default, organization members can create teams. Organization owners can limit team creation to organization owners. For more information, see \&quot;[Setting team creation permissions](https://docs.github.com/en/articles/setting-team-creation-permissions-in-your-organization).\&quot;  When you create a new team, you automatically become a team maintainer without explicitly adding yourself to the optional array of &#x60;maintainers&#x60;. For more information, see \&quot;[About teams](https://docs.github.com/en/github/setting-up-and-managing-organizations-and-teams/about-teams)\&quot;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamsCreateRequest"></param>
        /// <returns>FullTeam</returns>
        FullTeam TeamsCreate (string org, TeamsCreateRequest teamsCreateRequest);
        /// <summary>
        /// Create a discussion comment Creates a new comment on a team discussion. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;POST /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}/comments&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="teamsCreateDiscussionCommentInOrgRequest"></param>
        /// <returns>TeamDiscussionComment</returns>
        TeamDiscussionComment TeamsCreateDiscussionCommentInOrg (string org, string teamSlug, int? discussionNumber, TeamsCreateDiscussionCommentInOrgRequest teamsCreateDiscussionCommentInOrgRequest);
        /// <summary>
        /// Create a discussion comment (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Create a discussion comment](https://docs.github.com/rest/reference/teams#create-a-discussion-comment) endpoint.  Creates a new comment on a team discussion. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="teamsCreateDiscussionCommentInOrgRequest"></param>
        /// <returns>TeamDiscussionComment</returns>
        [Obsolete]
        TeamDiscussionComment TeamsCreateDiscussionCommentLegacy (int? teamId, int? discussionNumber, TeamsCreateDiscussionCommentInOrgRequest teamsCreateDiscussionCommentInOrgRequest);
        /// <summary>
        /// Create a discussion Creates a new discussion post on a team&#39;s page. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;POST /organizations/{org_id}/team/{team_id}/discussions&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="teamsCreateDiscussionInOrgRequest"></param>
        /// <returns>TeamDiscussion</returns>
        TeamDiscussion TeamsCreateDiscussionInOrg (string org, string teamSlug, TeamsCreateDiscussionInOrgRequest teamsCreateDiscussionInOrgRequest);
        /// <summary>
        /// Create a discussion (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;Create a discussion&#x60;](https://docs.github.com/rest/reference/teams#create-a-discussion) endpoint.  Creates a new discussion post on a team&#39;s page. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="teamsCreateDiscussionInOrgRequest"></param>
        /// <returns>TeamDiscussion</returns>
        [Obsolete]
        TeamDiscussion TeamsCreateDiscussionLegacy (int? teamId, TeamsCreateDiscussionInOrgRequest teamsCreateDiscussionInOrgRequest);
        /// <summary>
        /// Create or update IdP group connections Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Creates, updates, or removes a connection between a team and an IdP group. When adding groups to a team, you must include all new and existing groups to avoid replacing existing groups with the new ones. Specifying an empty &#x60;groups&#x60; array will remove all connections for a team.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;PATCH /organizations/{org_id}/team/{team_id}/team-sync/group-mappings&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="teamsCreateOrUpdateIdpGroupConnectionsInOrgRequest"></param>
        /// <returns>GroupMapping</returns>
        GroupMapping TeamsCreateOrUpdateIdpGroupConnectionsInOrg (string org, string teamSlug, TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequest teamsCreateOrUpdateIdpGroupConnectionsInOrgRequest);
        /// <summary>
        /// Create or update IdP group connections (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;Create or update IdP group connections&#x60;](https://docs.github.com/rest/reference/teams#create-or-update-idp-group-connections) endpoint.  Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Creates, updates, or removes a connection between a team and an IdP group. When adding groups to a team, you must include all new and existing groups to avoid replacing existing groups with the new ones. Specifying an empty &#x60;groups&#x60; array will remove all connections for a team.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="teamsCreateOrUpdateIdpGroupConnectionsLegacyRequest"></param>
        /// <returns>GroupMapping</returns>
        [Obsolete]
        GroupMapping TeamsCreateOrUpdateIdpGroupConnectionsLegacy (int? teamId, TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequest teamsCreateOrUpdateIdpGroupConnectionsLegacyRequest);
        /// <summary>
        /// Delete a discussion comment Deletes a comment on a team discussion. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;DELETE /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}/comments/{comment_number}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="commentNumber">The number that identifies the comment.</param>
        /// <returns></returns>
        void TeamsDeleteDiscussionCommentInOrg (string org, string teamSlug, int? discussionNumber, int? commentNumber);
        /// <summary>
        /// Delete a discussion comment (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Delete a discussion comment](https://docs.github.com/rest/reference/teams#delete-a-discussion-comment) endpoint.  Deletes a comment on a team discussion. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="commentNumber">The number that identifies the comment.</param>
        /// <returns></returns>
        [Obsolete]
        void TeamsDeleteDiscussionCommentLegacy (int? teamId, int? discussionNumber, int? commentNumber);
        /// <summary>
        /// Delete a discussion Delete a discussion from a team&#39;s page. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;DELETE /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <returns></returns>
        void TeamsDeleteDiscussionInOrg (string org, string teamSlug, int? discussionNumber);
        /// <summary>
        /// Delete a discussion (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;Delete a discussion&#x60;](https://docs.github.com/rest/reference/teams#delete-a-discussion) endpoint.  Delete a discussion from a team&#39;s page. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <returns></returns>
        [Obsolete]
        void TeamsDeleteDiscussionLegacy (int? teamId, int? discussionNumber);
        /// <summary>
        /// Delete a team To delete a team, the authenticated user must be an organization owner or team maintainer.  If you are an organization owner, deleting a parent team will delete all of its child teams as well.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;DELETE /organizations/{org_id}/team/{team_id}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <returns></returns>
        void TeamsDeleteInOrg (string org, string teamSlug);
        /// <summary>
        /// Delete a team (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Delete a team](https://docs.github.com/rest/reference/teams#delete-a-team) endpoint.  To delete a team, the authenticated user must be an organization owner or team maintainer.  If you are an organization owner, deleting a parent team will delete all of its child teams as well.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <returns></returns>
        [Obsolete]
        void TeamsDeleteLegacy (int? teamId);
        /// <summary>
        /// Get an external group Displays information about the specific group&#39;s usage.  Provides a list of the group&#39;s external members as well as a list of teams that this group is connected to.  You can manage team membership with your identity provider using Enterprise Managed Users for GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products)\&quot; in the GitHub Help documentation.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="groupId">The unique identifier of the group.</param>
        /// <returns>ExternalGroup</returns>
        ExternalGroup TeamsExternalIdpGroupInfoForOrg (string org, int? groupId);
        /// <summary>
        /// Get a team by name Gets a team using the team&#39;s &#x60;slug&#x60;. GitHub generates the &#x60;slug&#x60; from the team &#x60;name&#x60;.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <returns>FullTeam</returns>
        FullTeam TeamsGetByName (string org, string teamSlug);
        /// <summary>
        /// Get a discussion comment Get a specific comment on a team discussion. OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}/comments/{comment_number}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="commentNumber">The number that identifies the comment.</param>
        /// <returns>TeamDiscussionComment</returns>
        TeamDiscussionComment TeamsGetDiscussionCommentInOrg (string org, string teamSlug, int? discussionNumber, int? commentNumber);
        /// <summary>
        /// Get a discussion comment (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Get a discussion comment](https://docs.github.com/rest/reference/teams#get-a-discussion-comment) endpoint.  Get a specific comment on a team discussion. OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="commentNumber">The number that identifies the comment.</param>
        /// <returns>TeamDiscussionComment</returns>
        [Obsolete]
        TeamDiscussionComment TeamsGetDiscussionCommentLegacy (int? teamId, int? discussionNumber, int? commentNumber);
        /// <summary>
        /// Get a discussion Get a specific discussion on a team&#39;s page. OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <returns>TeamDiscussion</returns>
        TeamDiscussion TeamsGetDiscussionInOrg (string org, string teamSlug, int? discussionNumber);
        /// <summary>
        /// Get a discussion (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Get a discussion](https://docs.github.com/rest/reference/teams#get-a-discussion) endpoint.  Get a specific discussion on a team&#39;s page. OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <returns>TeamDiscussion</returns>
        [Obsolete]
        TeamDiscussion TeamsGetDiscussionLegacy (int? teamId, int? discussionNumber);
        /// <summary>
        /// Get a team (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the [Get a team by name](https://docs.github.com/rest/reference/teams#get-a-team-by-name) endpoint.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <returns>FullTeam</returns>
        [Obsolete]
        FullTeam TeamsGetLegacy (int? teamId);
        /// <summary>
        /// Get team member (Legacy) The \&quot;Get team member\&quot; endpoint (described below) is deprecated.  We recommend using the [Get team membership for a user](https://docs.github.com/rest/reference/teams#get-team-membership-for-a-user) endpoint instead. It allows you to get both active and pending memberships.  To list members in a team, the team must be visible to the authenticated user.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        [Obsolete]
        void TeamsGetMemberLegacy (int? teamId, string username);
        /// <summary>
        /// Get team membership for a user Team members will include the members of child teams.  To get a user&#39;s membership with a team, the team must be visible to the authenticated user.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/memberships/{username}&#x60;.  **Note:** The response contains the &#x60;state&#x60; of the membership and the member&#39;s &#x60;role&#x60;.  The &#x60;role&#x60; for organization owners is set to &#x60;maintainer&#x60;. For more information about &#x60;maintainer&#x60; roles, see see [Create a team](https://docs.github.com/rest/reference/teams#create-a-team).
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>TeamMembership</returns>
        TeamMembership TeamsGetMembershipForUserInOrg (string org, string teamSlug, string username);
        /// <summary>
        /// Get team membership for a user (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Get team membership for a user](https://docs.github.com/rest/reference/teams#get-team-membership-for-a-user) endpoint.  Team members will include the members of child teams.  To get a user&#39;s membership with a team, the team must be visible to the authenticated user.  **Note:** The response contains the &#x60;state&#x60; of the membership and the member&#39;s &#x60;role&#x60;.  The &#x60;role&#x60; for organization owners is set to &#x60;maintainer&#x60;. For more information about &#x60;maintainer&#x60; roles, see [Create a team](https://docs.github.com/rest/reference/teams#create-a-team).
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>TeamMembership</returns>
        [Obsolete]
        TeamMembership TeamsGetMembershipForUserLegacy (int? teamId, string username);
        /// <summary>
        /// Update the connection between an external group and a team Creates a connection between a team and an external group.  Only one external group can be linked to a team.  You can manage team membership with your identity provider using Enterprise Managed Users for GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products)\&quot; in the GitHub Help documentation.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="teamsLinkExternalIdpGroupToTeamForOrgRequest"></param>
        /// <returns>ExternalGroup</returns>
        ExternalGroup TeamsLinkExternalIdpGroupToTeamForOrg (string org, string teamSlug, TeamsLinkExternalIdpGroupToTeamForOrgRequest teamsLinkExternalIdpGroupToTeamForOrgRequest);
        /// <summary>
        /// List teams Lists all teams in an organization that are visible to the authenticated user.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Team&gt;</returns>
        List<Team> TeamsList (string org, int? perPage, int? page);
        /// <summary>
        /// List child teams Lists the child teams of the team specified by &#x60;{team_slug}&#x60;.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/teams&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Team&gt;</returns>
        List<Team> TeamsListChildInOrg (string org, string teamSlug, int? perPage, int? page);
        /// <summary>
        /// List child teams (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;List child teams&#x60;](https://docs.github.com/rest/reference/teams#list-child-teams) endpoint.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Team&gt;</returns>
        [Obsolete]
        List<Team> TeamsListChildLegacy (int? teamId, int? perPage, int? page);
        /// <summary>
        /// List discussion comments List all comments on a team discussion. OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}/comments&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;TeamDiscussionComment&gt;</returns>
        List<TeamDiscussionComment> TeamsListDiscussionCommentsInOrg (string org, string teamSlug, int? discussionNumber, string direction, int? perPage, int? page);
        /// <summary>
        /// List discussion comments (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [List discussion comments](https://docs.github.com/rest/reference/teams#list-discussion-comments) endpoint.  List all comments on a team discussion. OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;TeamDiscussionComment&gt;</returns>
        [Obsolete]
        List<TeamDiscussionComment> TeamsListDiscussionCommentsLegacy (int? teamId, int? discussionNumber, string direction, int? perPage, int? page);
        /// <summary>
        /// List discussions List all discussions on a team&#39;s page. OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/discussions&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="pinned">Pinned discussions only filter</param>
        /// <returns>List&lt;TeamDiscussion&gt;</returns>
        List<TeamDiscussion> TeamsListDiscussionsInOrg (string org, string teamSlug, string direction, int? perPage, int? page, string pinned);
        /// <summary>
        /// List discussions (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;List discussions&#x60;](https://docs.github.com/rest/reference/teams#list-discussions) endpoint.  List all discussions on a team&#39;s page. OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;TeamDiscussion&gt;</returns>
        [Obsolete]
        List<TeamDiscussion> TeamsListDiscussionsLegacy (int? teamId, string direction, int? perPage, int? page);
        /// <summary>
        /// List external groups in an organization Lists external groups available in an organization. You can query the groups using the &#x60;display_name&#x60; parameter, only groups with a &#x60;group_name&#x60; containing the text provided in the &#x60;display_name&#x60; parameter will be returned.  You can also limit your page results using the &#x60;per_page&#x60; parameter. GitHub generates a url-encoded &#x60;page&#x60; token using a cursor value for where the next page begins. For more information on cursor pagination, see \&quot;[Offset and Cursor Pagination explained](https://dev.to/jackmarchant/offset-and-cursor-pagination-explained-b89).\&quot;  You can manage team membership with your identity provider using Enterprise Managed Users for GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products)\&quot; in the GitHub Help documentation.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page token</param>
        /// <param name="displayName">Limits the list to groups containing the text in the group name</param>
        /// <returns>ExternalGroups</returns>
        ExternalGroups TeamsListExternalIdpGroupsForOrg (string org, int? perPage, int? page, string displayName);
        /// <summary>
        /// List teams for the authenticated user List all of the teams across all of the organizations to which the authenticated user belongs. This method requires &#x60;user&#x60;, &#x60;repo&#x60;, or &#x60;read:org&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/) when authenticating via [OAuth](https://docs.github.com/apps/building-oauth-apps/).
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;FullTeam&gt;</returns>
        List<FullTeam> TeamsListForAuthenticatedUser (int? perPage, int? page);
        /// <summary>
        /// List IdP groups for a team (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;List IdP groups for a team&#x60;](https://docs.github.com/rest/reference/teams#list-idp-groups-for-a-team) endpoint.  Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  List IdP groups connected to a team on GitHub.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <returns>GroupMapping</returns>
        [Obsolete]
        GroupMapping TeamsListIdpGroupsForLegacy (int? teamId);
        /// <summary>
        /// List IdP groups for an organization Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  List IdP groups available in an organization. You can limit your page results using the &#x60;per_page&#x60; parameter. GitHub generates a url-encoded &#x60;page&#x60; token using a cursor value for where the next page begins. For more information on cursor pagination, see \&quot;[Offset and Cursor Pagination explained](https://dev.to/jackmarchant/offset-and-cursor-pagination-explained-b89).\&quot;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page token</param>
        /// <returns>GroupMapping</returns>
        GroupMapping TeamsListIdpGroupsForOrg (string org, int? perPage, string page);
        /// <summary>
        /// List IdP groups for a team Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  List IdP groups connected to a team on GitHub.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/team-sync/group-mappings&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <returns>GroupMapping</returns>
        GroupMapping TeamsListIdpGroupsInOrg (string org, string teamSlug);
        /// <summary>
        /// List a connection between an external group and a team Lists a connection between a team and an external group.  You can manage team membership with your identity provider using Enterprise Managed Users for GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products)\&quot; in the GitHub Help documentation.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <returns>ExternalGroups</returns>
        ExternalGroups TeamsListLinkedExternalIdpGroupsToTeamForOrg (string org, string teamSlug);
        /// <summary>
        /// List team members Team members will include the members of child teams.  To list members in a team, the team must be visible to the authenticated user.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="role">Filters members returned by their role in the team.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        List<SimpleUser1> TeamsListMembersInOrg (string org, string teamSlug, string role, int? perPage, int? page);
        /// <summary>
        /// List team members (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;List team members&#x60;](https://docs.github.com/rest/reference/teams#list-team-members) endpoint.  Team members will include the members of child teams.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="role">Filters members returned by their role in the team.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        [Obsolete]
        List<SimpleUser1> TeamsListMembersLegacy (int? teamId, string role, int? perPage, int? page);
        /// <summary>
        /// List pending team invitations The return hash contains a &#x60;role&#x60; field which refers to the Organization Invitation role and will be one of the following values: &#x60;direct_member&#x60;, &#x60;admin&#x60;, &#x60;billing_manager&#x60;, &#x60;hiring_manager&#x60;, or &#x60;reinstate&#x60;. If the invitee is not a GitHub member, the &#x60;login&#x60; field in the return hash will be &#x60;null&#x60;.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/invitations&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;OrganizationInvitation&gt;</returns>
        List<OrganizationInvitation> TeamsListPendingInvitationsInOrg (string org, string teamSlug, int? perPage, int? page);
        /// <summary>
        /// List pending team invitations (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;List pending team invitations&#x60;](https://docs.github.com/rest/reference/teams#list-pending-team-invitations) endpoint.  The return hash contains a &#x60;role&#x60; field which refers to the Organization Invitation role and will be one of the following values: &#x60;direct_member&#x60;, &#x60;admin&#x60;, &#x60;billing_manager&#x60;, &#x60;hiring_manager&#x60;, or &#x60;reinstate&#x60;. If the invitee is not a GitHub member, the &#x60;login&#x60; field in the return hash will be &#x60;null&#x60;.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;OrganizationInvitation&gt;</returns>
        [Obsolete]
        List<OrganizationInvitation> TeamsListPendingInvitationsLegacy (int? teamId, int? perPage, int? page);
        /// <summary>
        /// List team projects Lists the organization projects for a team.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/projects&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;TeamProject&gt;</returns>
        List<TeamProject> TeamsListProjectsInOrg (string org, string teamSlug, int? perPage, int? page);
        /// <summary>
        /// List team projects (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;List team projects&#x60;](https://docs.github.com/rest/reference/teams#list-team-projects) endpoint.  Lists the organization projects for a team.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;TeamProject&gt;</returns>
        [Obsolete]
        List<TeamProject> TeamsListProjectsLegacy (int? teamId, int? perPage, int? page);
        /// <summary>
        /// List team repositories Lists a team&#39;s repositories visible to the authenticated user.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/repos&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MinimalRepository&gt;</returns>
        List<MinimalRepository> TeamsListReposInOrg (string org, string teamSlug, int? perPage, int? page);
        /// <summary>
        /// List team repositories (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [List team repositories](https://docs.github.com/rest/reference/teams#list-team-repositories) endpoint.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MinimalRepository&gt;</returns>
        [Obsolete]
        List<MinimalRepository> TeamsListReposLegacy (int? teamId, int? perPage, int? page);
        /// <summary>
        /// Remove team member (Legacy) The \&quot;Remove team member\&quot; endpoint (described below) is deprecated.  We recommend using the [Remove team membership for a user](https://docs.github.com/rest/reference/teams#remove-team-membership-for-a-user) endpoint instead. It allows you to remove both active and pending memberships.  Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  To remove a team member, the authenticated user must have &#39;admin&#39; permissions to the team or be an owner of the org that the team is associated with. Removing a team member does not delete the user, it just removes them from the team.  **Note:** When you have team synchronization set up for a team with your organization&#39;s identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team&#39;s membership. If you have access to manage group membership in your IdP, you can manage GitHub team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see \&quot;[Synchronizing teams between your identity provider and GitHub](https://docs.github.com/articles/synchronizing-teams-between-your-identity-provider-and-github/).\&quot;
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        [Obsolete]
        void TeamsRemoveMemberLegacy (int? teamId, string username);
        /// <summary>
        /// Remove team membership for a user Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  To remove a membership between a user and a team, the authenticated user must have &#39;admin&#39; permissions to the team or be an owner of the organization that the team is associated with. Removing team membership does not delete the user, it just removes their membership from the team.  **Note:** When you have team synchronization set up for a team with your organization&#39;s identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team&#39;s membership. If you have access to manage group membership in your IdP, you can manage GitHub team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see \&quot;[Synchronizing teams between your identity provider and GitHub](https://docs.github.com/articles/synchronizing-teams-between-your-identity-provider-and-github/).\&quot;  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;DELETE /organizations/{org_id}/team/{team_id}/memberships/{username}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        void TeamsRemoveMembershipForUserInOrg (string org, string teamSlug, string username);
        /// <summary>
        /// Remove team membership for a user (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Remove team membership for a user](https://docs.github.com/rest/reference/teams#remove-team-membership-for-a-user) endpoint.  Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  To remove a membership between a user and a team, the authenticated user must have &#39;admin&#39; permissions to the team or be an owner of the organization that the team is associated with. Removing team membership does not delete the user, it just removes their membership from the team.  **Note:** When you have team synchronization set up for a team with your organization&#39;s identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team&#39;s membership. If you have access to manage group membership in your IdP, you can manage GitHub team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see \&quot;[Synchronizing teams between your identity provider and GitHub](https://docs.github.com/articles/synchronizing-teams-between-your-identity-provider-and-github/).\&quot;
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        [Obsolete]
        void TeamsRemoveMembershipForUserLegacy (int? teamId, string username);
        /// <summary>
        /// Remove a project from a team Removes an organization project from a team. An organization owner or a team maintainer can remove any project from the team. To remove a project from a team as an organization member, the authenticated user must have &#x60;read&#x60; access to both the team and project, or &#x60;admin&#x60; access to the team or project. This endpoint removes the project from the team, but does not delete the project.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;DELETE /organizations/{org_id}/team/{team_id}/projects/{project_id}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <returns></returns>
        void TeamsRemoveProjectInOrg (string org, string teamSlug, int? projectId);
        /// <summary>
        /// Remove a project from a team (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Remove a project from a team](https://docs.github.com/rest/reference/teams#remove-a-project-from-a-team) endpoint.  Removes an organization project from a team. An organization owner or a team maintainer can remove any project from the team. To remove a project from a team as an organization member, the authenticated user must have &#x60;read&#x60; access to both the team and project, or &#x60;admin&#x60; access to the team or project. **Note:** This endpoint removes the project from the team, but does not delete it.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <returns></returns>
        [Obsolete]
        void TeamsRemoveProjectLegacy (int? teamId, int? projectId);
        /// <summary>
        /// Remove a repository from a team If the authenticated user is an organization owner or a team maintainer, they can remove any repositories from the team. To remove a repository from a team as an organization member, the authenticated user must have admin access to the repository and must be able to see the team. This does not delete the repository, it just removes it from the team.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;DELETE /organizations/{org_id}/team/{team_id}/repos/{owner}/{repo}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        void TeamsRemoveRepoInOrg (string org, string teamSlug, string owner, string repo);
        /// <summary>
        /// Remove a repository from a team (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Remove a repository from a team](https://docs.github.com/rest/reference/teams#remove-a-repository-from-a-team) endpoint.  If the authenticated user is an organization owner or a team maintainer, they can remove any repositories from the team. To remove a repository from a team as an organization member, the authenticated user must have admin access to the repository and must be able to see the team. NOTE: This does not delete the repository, it just removes it from the team.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        [Obsolete]
        void TeamsRemoveRepoLegacy (int? teamId, string owner, string repo);
        /// <summary>
        /// Remove the connection between an external group and a team Deletes a connection between a team and an external group.  You can manage team membership with your IdP using Enterprise Managed Users for GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <returns></returns>
        void TeamsUnlinkExternalIdpGroupFromTeamForOrg (string org, string teamSlug);
        /// <summary>
        /// Update a discussion comment Edits the body text of a discussion comment. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;PATCH /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}/comments/{comment_number}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="commentNumber">The number that identifies the comment.</param>
        /// <param name="teamsCreateDiscussionCommentInOrgRequest"></param>
        /// <returns>TeamDiscussionComment</returns>
        TeamDiscussionComment TeamsUpdateDiscussionCommentInOrg (string org, string teamSlug, int? discussionNumber, int? commentNumber, TeamsCreateDiscussionCommentInOrgRequest teamsCreateDiscussionCommentInOrgRequest);
        /// <summary>
        /// Update a discussion comment (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Update a discussion comment](https://docs.github.com/rest/reference/teams#update-a-discussion-comment) endpoint.  Edits the body text of a discussion comment. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="commentNumber">The number that identifies the comment.</param>
        /// <param name="teamsCreateDiscussionCommentInOrgRequest"></param>
        /// <returns>TeamDiscussionComment</returns>
        [Obsolete]
        TeamDiscussionComment TeamsUpdateDiscussionCommentLegacy (int? teamId, int? discussionNumber, int? commentNumber, TeamsCreateDiscussionCommentInOrgRequest teamsCreateDiscussionCommentInOrgRequest);
        /// <summary>
        /// Update a discussion Edits the title and body text of a discussion post. Only the parameters you provide are updated. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;PATCH /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="teamsUpdateDiscussionInOrgRequest"></param>
        /// <returns>TeamDiscussion</returns>
        TeamDiscussion TeamsUpdateDiscussionInOrg (string org, string teamSlug, int? discussionNumber, TeamsUpdateDiscussionInOrgRequest teamsUpdateDiscussionInOrgRequest);
        /// <summary>
        /// Update a discussion (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Update a discussion](https://docs.github.com/rest/reference/teams#update-a-discussion) endpoint.  Edits the title and body text of a discussion post. Only the parameters you provide are updated. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="teamsUpdateDiscussionInOrgRequest"></param>
        /// <returns>TeamDiscussion</returns>
        [Obsolete]
        TeamDiscussion TeamsUpdateDiscussionLegacy (int? teamId, int? discussionNumber, TeamsUpdateDiscussionInOrgRequest teamsUpdateDiscussionInOrgRequest);
        /// <summary>
        /// Update a team To edit a team, the authenticated user must either be an organization owner or a team maintainer.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;PATCH /organizations/{org_id}/team/{team_id}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="teamsUpdateInOrgRequest"></param>
        /// <returns>FullTeam</returns>
        FullTeam TeamsUpdateInOrg (string org, string teamSlug, TeamsUpdateInOrgRequest teamsUpdateInOrgRequest);
        /// <summary>
        /// Update a team (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Update a team](https://docs.github.com/rest/reference/teams#update-a-team) endpoint.  To edit a team, the authenticated user must either be an organization owner or a team maintainer.  **Note:** With nested teams, the &#x60;privacy&#x60; for parent teams cannot be &#x60;secret&#x60;.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="teamsUpdateLegacyRequest"></param>
        /// <returns>FullTeam</returns>
        [Obsolete]
        FullTeam TeamsUpdateLegacy (int? teamId, TeamsUpdateLegacyRequest teamsUpdateLegacyRequest);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TeamsApi : ITeamsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TeamsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TeamsApi(String basePath)
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
        /// Add team member (Legacy) The \&quot;Add team member\&quot; endpoint (described below) is deprecated.  We recommend using the [Add or update team membership for a user](https://docs.github.com/rest/reference/teams#add-or-update-team-membership-for-a-user) endpoint instead. It allows you to invite new organization members to your teams.  Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  To add someone to a team, the authenticated user must be an organization owner or a team maintainer in the team they&#39;re changing. The person being added to the team must be a member of the team&#39;s organization.  **Note:** When you have team synchronization set up for a team with your organization&#39;s identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team&#39;s membership. If you have access to manage group membership in your IdP, you can manage GitHub team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see \&quot;[Synchronizing teams between your identity provider and GitHub](https://docs.github.com/articles/synchronizing-teams-between-your-identity-provider-and-github/).\&quot;  Note that you&#39;ll need to set &#x60;Content-Length&#x60; to zero when calling out to this endpoint. For more information, see \&quot;[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\&quot;
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        [Obsolete]
        public void TeamsAddMemberLegacy (int? teamId, string username)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsAddMemberLegacy");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling TeamsAddMemberLegacy");
            

            var path = "/teams/{team_id}/members/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsAddMemberLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsAddMemberLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Add or update team membership for a user Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Adds an organization member to a team. An authenticated organization owner or team maintainer can add organization members to a team.  **Note:** When you have team synchronization set up for a team with your organization&#39;s identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team&#39;s membership. If you have access to manage group membership in your IdP, you can manage GitHub team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see \&quot;[Synchronizing teams between your identity provider and GitHub](https://docs.github.com/articles/synchronizing-teams-between-your-identity-provider-and-github/).\&quot;  An organization owner can add someone who is not part of the team&#39;s organization to a team. When an organization owner adds someone to a team who is not an organization member, this endpoint will send an invitation to the person via email. This newly-created membership will be in the \&quot;pending\&quot; state until the person accepts the invitation, at which point the membership will transition to the \&quot;active\&quot; state and the user will be added as a member of the team.  If the user is already a member of the team, this endpoint will update the role of the team member&#39;s role. To update the membership of a team member, the authenticated user must be an organization owner or a team maintainer.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;PUT /organizations/{org_id}/team/{team_id}/memberships/{username}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="teamsAddOrUpdateMembershipForUserInOrgRequest"></param>
        /// <returns>TeamMembership</returns>
        public TeamMembership TeamsAddOrUpdateMembershipForUserInOrg (string org, string teamSlug, string username, TeamsAddOrUpdateMembershipForUserInOrgRequest teamsAddOrUpdateMembershipForUserInOrgRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsAddOrUpdateMembershipForUserInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsAddOrUpdateMembershipForUserInOrg");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling TeamsAddOrUpdateMembershipForUserInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/memberships/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));
path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(teamsAddOrUpdateMembershipForUserInOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsAddOrUpdateMembershipForUserInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsAddOrUpdateMembershipForUserInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamMembership) ApiClient.Deserialize(response.Content, typeof(TeamMembership), response.Headers);
        }

        /// <summary>
        /// Add or update team membership for a user (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Add or update team membership for a user](https://docs.github.com/rest/reference/teams#add-or-update-team-membership-for-a-user) endpoint.  Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  If the user is already a member of the team&#39;s organization, this endpoint will add the user to the team. To add a membership between an organization member and a team, the authenticated user must be an organization owner or a team maintainer.  **Note:** When you have team synchronization set up for a team with your organization&#39;s identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team&#39;s membership. If you have access to manage group membership in your IdP, you can manage GitHub team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see \&quot;[Synchronizing teams between your identity provider and GitHub](https://docs.github.com/articles/synchronizing-teams-between-your-identity-provider-and-github/).\&quot;  If the user is unaffiliated with the team&#39;s organization, this endpoint will send an invitation to the user via email. This newly-created membership will be in the \&quot;pending\&quot; state until the user accepts the invitation, at which point the membership will transition to the \&quot;active\&quot; state and the user will be added as a member of the team. To add a membership between an unaffiliated user and a team, the authenticated user must be an organization owner.  If the user is already a member of the team, this endpoint will update the role of the team member&#39;s role. To update the membership of a team member, the authenticated user must be an organization owner or a team maintainer.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="teamsAddOrUpdateMembershipForUserInOrgRequest"></param>
        /// <returns>TeamMembership</returns>
        [Obsolete]
        public TeamMembership TeamsAddOrUpdateMembershipForUserLegacy (int? teamId, string username, TeamsAddOrUpdateMembershipForUserInOrgRequest teamsAddOrUpdateMembershipForUserInOrgRequest)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsAddOrUpdateMembershipForUserLegacy");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling TeamsAddOrUpdateMembershipForUserLegacy");
            

            var path = "/teams/{team_id}/memberships/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(teamsAddOrUpdateMembershipForUserInOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsAddOrUpdateMembershipForUserLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsAddOrUpdateMembershipForUserLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamMembership) ApiClient.Deserialize(response.Content, typeof(TeamMembership), response.Headers);
        }

        /// <summary>
        /// Add or update team project permissions Adds an organization project to a team. To add a project to a team or update the team&#39;s permission on a project, the authenticated user must have &#x60;admin&#x60; permissions for the project. The project and team must be part of the same organization.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;PUT /organizations/{org_id}/team/{team_id}/projects/{project_id}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <param name="teamsAddOrUpdateProjectPermissionsInOrgRequest"></param>
        /// <returns></returns>
        public void TeamsAddOrUpdateProjectPermissionsInOrg (string org, string teamSlug, int? projectId, TeamsAddOrUpdateProjectPermissionsInOrgRequest teamsAddOrUpdateProjectPermissionsInOrgRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsAddOrUpdateProjectPermissionsInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsAddOrUpdateProjectPermissionsInOrg");
            
            // verify the required parameter 'projectId' is set
            if (projectId == null) throw new ApiException(400, "Missing required parameter 'projectId' when calling TeamsAddOrUpdateProjectPermissionsInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/projects/{project_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));
path = path.Replace("{" + "project_id" + "}", ApiClient.ParameterToString(projectId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(teamsAddOrUpdateProjectPermissionsInOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsAddOrUpdateProjectPermissionsInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsAddOrUpdateProjectPermissionsInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Add or update team project permissions (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Add or update team project permissions](https://docs.github.com/rest/reference/teams#add-or-update-team-project-permissions) endpoint.  Adds an organization project to a team. To add a project to a team or update the team&#39;s permission on a project, the authenticated user must have &#x60;admin&#x60; permissions for the project. The project and team must be part of the same organization.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <param name="teamsAddOrUpdateProjectPermissionsLegacyRequest"></param>
        /// <returns></returns>
        [Obsolete]
        public void TeamsAddOrUpdateProjectPermissionsLegacy (int? teamId, int? projectId, TeamsAddOrUpdateProjectPermissionsLegacyRequest teamsAddOrUpdateProjectPermissionsLegacyRequest)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsAddOrUpdateProjectPermissionsLegacy");
            
            // verify the required parameter 'projectId' is set
            if (projectId == null) throw new ApiException(400, "Missing required parameter 'projectId' when calling TeamsAddOrUpdateProjectPermissionsLegacy");
            

            var path = "/teams/{team_id}/projects/{project_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
path = path.Replace("{" + "project_id" + "}", ApiClient.ParameterToString(projectId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(teamsAddOrUpdateProjectPermissionsLegacyRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsAddOrUpdateProjectPermissionsLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsAddOrUpdateProjectPermissionsLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Add or update team repository permissions To add a repository to a team or update the team&#39;s permission on a repository, the authenticated user must have admin access to the repository, and must be able to see the team. The repository must be owned by the organization, or a direct fork of a repository owned by the organization. You will get a &#x60;422 Unprocessable Entity&#x60; status if you attempt to add a repository to a team that is not owned by the organization. Note that, if you choose not to pass any parameters, you&#39;ll need to set &#x60;Content-Length&#x60; to zero when calling out to this endpoint. For more information, see \&quot;[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\&quot;  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;PUT /organizations/{org_id}/team/{team_id}/repos/{owner}/{repo}&#x60;.  For more information about the permission levels, see \&quot;[Repository permission levels for an organization](https://docs.github.com/en/github/setting-up-and-managing-organizations-and-teams/repository-permission-levels-for-an-organization#permission-levels-for-repositories-owned-by-an-organization)\&quot;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="teamsAddOrUpdateRepoPermissionsInOrgRequest"></param>
        /// <returns></returns>
        public void TeamsAddOrUpdateRepoPermissionsInOrg (string org, string teamSlug, string owner, string repo, TeamsAddOrUpdateRepoPermissionsInOrgRequest teamsAddOrUpdateRepoPermissionsInOrgRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsAddOrUpdateRepoPermissionsInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsAddOrUpdateRepoPermissionsInOrg");
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling TeamsAddOrUpdateRepoPermissionsInOrg");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling TeamsAddOrUpdateRepoPermissionsInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/repos/{owner}/{repo}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));
path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(teamsAddOrUpdateRepoPermissionsInOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsAddOrUpdateRepoPermissionsInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsAddOrUpdateRepoPermissionsInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Add or update team repository permissions (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new \&quot;[Add or update team repository permissions](https://docs.github.com/rest/reference/teams#add-or-update-team-repository-permissions)\&quot; endpoint.  To add a repository to a team or update the team&#39;s permission on a repository, the authenticated user must have admin access to the repository, and must be able to see the team. The repository must be owned by the organization, or a direct fork of a repository owned by the organization. You will get a &#x60;422 Unprocessable Entity&#x60; status if you attempt to add a repository to a team that is not owned by the organization.  Note that, if you choose not to pass any parameters, you&#39;ll need to set &#x60;Content-Length&#x60; to zero when calling out to this endpoint. For more information, see \&quot;[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\&quot;
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="teamsAddOrUpdateRepoPermissionsLegacyRequest"></param>
        /// <returns></returns>
        [Obsolete]
        public void TeamsAddOrUpdateRepoPermissionsLegacy (int? teamId, string owner, string repo, TeamsAddOrUpdateRepoPermissionsLegacyRequest teamsAddOrUpdateRepoPermissionsLegacyRequest)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsAddOrUpdateRepoPermissionsLegacy");
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling TeamsAddOrUpdateRepoPermissionsLegacy");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling TeamsAddOrUpdateRepoPermissionsLegacy");
            

            var path = "/teams/{team_id}/repos/{owner}/{repo}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(teamsAddOrUpdateRepoPermissionsLegacyRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsAddOrUpdateRepoPermissionsLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsAddOrUpdateRepoPermissionsLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Check team permissions for a project Checks whether a team has &#x60;read&#x60;, &#x60;write&#x60;, or &#x60;admin&#x60; permissions for an organization project. The response includes projects inherited from a parent team.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/projects/{project_id}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <returns>TeamProject</returns>
        public TeamProject TeamsCheckPermissionsForProjectInOrg (string org, string teamSlug, int? projectId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsCheckPermissionsForProjectInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsCheckPermissionsForProjectInOrg");
            
            // verify the required parameter 'projectId' is set
            if (projectId == null) throw new ApiException(400, "Missing required parameter 'projectId' when calling TeamsCheckPermissionsForProjectInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/projects/{project_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));
path = path.Replace("{" + "project_id" + "}", ApiClient.ParameterToString(projectId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsCheckPermissionsForProjectInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsCheckPermissionsForProjectInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamProject) ApiClient.Deserialize(response.Content, typeof(TeamProject), response.Headers);
        }

        /// <summary>
        /// Check team permissions for a project (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Check team permissions for a project](https://docs.github.com/rest/reference/teams#check-team-permissions-for-a-project) endpoint.  Checks whether a team has &#x60;read&#x60;, &#x60;write&#x60;, or &#x60;admin&#x60; permissions for an organization project. The response includes projects inherited from a parent team.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <returns>TeamProject</returns>
        [Obsolete]
        public TeamProject TeamsCheckPermissionsForProjectLegacy (int? teamId, int? projectId)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsCheckPermissionsForProjectLegacy");
            
            // verify the required parameter 'projectId' is set
            if (projectId == null) throw new ApiException(400, "Missing required parameter 'projectId' when calling TeamsCheckPermissionsForProjectLegacy");
            

            var path = "/teams/{team_id}/projects/{project_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
path = path.Replace("{" + "project_id" + "}", ApiClient.ParameterToString(projectId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsCheckPermissionsForProjectLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsCheckPermissionsForProjectLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamProject) ApiClient.Deserialize(response.Content, typeof(TeamProject), response.Headers);
        }

        /// <summary>
        /// Check team permissions for a repository Checks whether a team has &#x60;admin&#x60;, &#x60;push&#x60;, &#x60;maintain&#x60;, &#x60;triage&#x60;, or &#x60;pull&#x60; permission for a repository. Repositories inherited through a parent team will also be checked.  You can also get information about the specified repository, including what permissions the team grants on it, by passing the following custom [media type](https://docs.github.com/rest/overview/media-types/) via the &#x60;application/vnd.github.v3.repository+json&#x60; accept header.  If a team doesn&#39;t have permission for the repository, you will receive a &#x60;404 Not Found&#x60; response status.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/repos/{owner}/{repo}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>TeamRepository</returns>
        public TeamRepository TeamsCheckPermissionsForRepoInOrg (string org, string teamSlug, string owner, string repo)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsCheckPermissionsForRepoInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsCheckPermissionsForRepoInOrg");
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling TeamsCheckPermissionsForRepoInOrg");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling TeamsCheckPermissionsForRepoInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/repos/{owner}/{repo}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));
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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsCheckPermissionsForRepoInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsCheckPermissionsForRepoInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamRepository) ApiClient.Deserialize(response.Content, typeof(TeamRepository), response.Headers);
        }

        /// <summary>
        /// Check team permissions for a repository (Legacy) **Note**: Repositories inherited through a parent team will also be checked.  **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Check team permissions for a repository](https://docs.github.com/rest/reference/teams#check-team-permissions-for-a-repository) endpoint.  You can also get information about the specified repository, including what permissions the team grants on it, by passing the following custom [media type](https://docs.github.com/rest/overview/media-types/) via the &#x60;Accept&#x60; header:
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>TeamRepository</returns>
        [Obsolete]
        public TeamRepository TeamsCheckPermissionsForRepoLegacy (int? teamId, string owner, string repo)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsCheckPermissionsForRepoLegacy");
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling TeamsCheckPermissionsForRepoLegacy");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling TeamsCheckPermissionsForRepoLegacy");
            

            var path = "/teams/{team_id}/repos/{owner}/{repo}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsCheckPermissionsForRepoLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsCheckPermissionsForRepoLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamRepository) ApiClient.Deserialize(response.Content, typeof(TeamRepository), response.Headers);
        }

        /// <summary>
        /// Create a team To create a team, the authenticated user must be a member or owner of &#x60;{org}&#x60;. By default, organization members can create teams. Organization owners can limit team creation to organization owners. For more information, see \&quot;[Setting team creation permissions](https://docs.github.com/en/articles/setting-team-creation-permissions-in-your-organization).\&quot;  When you create a new team, you automatically become a team maintainer without explicitly adding yourself to the optional array of &#x60;maintainers&#x60;. For more information, see \&quot;[About teams](https://docs.github.com/en/github/setting-up-and-managing-organizations-and-teams/about-teams)\&quot;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamsCreateRequest"></param>
        /// <returns>FullTeam</returns>
        public FullTeam TeamsCreate (string org, TeamsCreateRequest teamsCreateRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsCreate");
            
            // verify the required parameter 'teamsCreateRequest' is set
            if (teamsCreateRequest == null) throw new ApiException(400, "Missing required parameter 'teamsCreateRequest' when calling TeamsCreate");
            

            var path = "/orgs/{org}/teams";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(teamsCreateRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsCreate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsCreate: " + response.ErrorMessage, response.ErrorMessage);

            return (FullTeam) ApiClient.Deserialize(response.Content, typeof(FullTeam), response.Headers);
        }

        /// <summary>
        /// Create a discussion comment Creates a new comment on a team discussion. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;POST /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}/comments&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="teamsCreateDiscussionCommentInOrgRequest"></param>
        /// <returns>TeamDiscussionComment</returns>
        public TeamDiscussionComment TeamsCreateDiscussionCommentInOrg (string org, string teamSlug, int? discussionNumber, TeamsCreateDiscussionCommentInOrgRequest teamsCreateDiscussionCommentInOrgRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsCreateDiscussionCommentInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsCreateDiscussionCommentInOrg");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling TeamsCreateDiscussionCommentInOrg");
            
            // verify the required parameter 'teamsCreateDiscussionCommentInOrgRequest' is set
            if (teamsCreateDiscussionCommentInOrgRequest == null) throw new ApiException(400, "Missing required parameter 'teamsCreateDiscussionCommentInOrgRequest' when calling TeamsCreateDiscussionCommentInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(teamsCreateDiscussionCommentInOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsCreateDiscussionCommentInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsCreateDiscussionCommentInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamDiscussionComment) ApiClient.Deserialize(response.Content, typeof(TeamDiscussionComment), response.Headers);
        }

        /// <summary>
        /// Create a discussion comment (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Create a discussion comment](https://docs.github.com/rest/reference/teams#create-a-discussion-comment) endpoint.  Creates a new comment on a team discussion. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="teamsCreateDiscussionCommentInOrgRequest"></param>
        /// <returns>TeamDiscussionComment</returns>
        [Obsolete]
        public TeamDiscussionComment TeamsCreateDiscussionCommentLegacy (int? teamId, int? discussionNumber, TeamsCreateDiscussionCommentInOrgRequest teamsCreateDiscussionCommentInOrgRequest)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsCreateDiscussionCommentLegacy");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling TeamsCreateDiscussionCommentLegacy");
            
            // verify the required parameter 'teamsCreateDiscussionCommentInOrgRequest' is set
            if (teamsCreateDiscussionCommentInOrgRequest == null) throw new ApiException(400, "Missing required parameter 'teamsCreateDiscussionCommentInOrgRequest' when calling TeamsCreateDiscussionCommentLegacy");
            

            var path = "/teams/{team_id}/discussions/{discussion_number}/comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(teamsCreateDiscussionCommentInOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsCreateDiscussionCommentLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsCreateDiscussionCommentLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamDiscussionComment) ApiClient.Deserialize(response.Content, typeof(TeamDiscussionComment), response.Headers);
        }

        /// <summary>
        /// Create a discussion Creates a new discussion post on a team&#39;s page. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;POST /organizations/{org_id}/team/{team_id}/discussions&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="teamsCreateDiscussionInOrgRequest"></param>
        /// <returns>TeamDiscussion</returns>
        public TeamDiscussion TeamsCreateDiscussionInOrg (string org, string teamSlug, TeamsCreateDiscussionInOrgRequest teamsCreateDiscussionInOrgRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsCreateDiscussionInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsCreateDiscussionInOrg");
            
            // verify the required parameter 'teamsCreateDiscussionInOrgRequest' is set
            if (teamsCreateDiscussionInOrgRequest == null) throw new ApiException(400, "Missing required parameter 'teamsCreateDiscussionInOrgRequest' when calling TeamsCreateDiscussionInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/discussions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(teamsCreateDiscussionInOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsCreateDiscussionInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsCreateDiscussionInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamDiscussion) ApiClient.Deserialize(response.Content, typeof(TeamDiscussion), response.Headers);
        }

        /// <summary>
        /// Create a discussion (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;Create a discussion&#x60;](https://docs.github.com/rest/reference/teams#create-a-discussion) endpoint.  Creates a new discussion post on a team&#39;s page. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="teamsCreateDiscussionInOrgRequest"></param>
        /// <returns>TeamDiscussion</returns>
        [Obsolete]
        public TeamDiscussion TeamsCreateDiscussionLegacy (int? teamId, TeamsCreateDiscussionInOrgRequest teamsCreateDiscussionInOrgRequest)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsCreateDiscussionLegacy");
            
            // verify the required parameter 'teamsCreateDiscussionInOrgRequest' is set
            if (teamsCreateDiscussionInOrgRequest == null) throw new ApiException(400, "Missing required parameter 'teamsCreateDiscussionInOrgRequest' when calling TeamsCreateDiscussionLegacy");
            

            var path = "/teams/{team_id}/discussions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(teamsCreateDiscussionInOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsCreateDiscussionLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsCreateDiscussionLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamDiscussion) ApiClient.Deserialize(response.Content, typeof(TeamDiscussion), response.Headers);
        }

        /// <summary>
        /// Create or update IdP group connections Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Creates, updates, or removes a connection between a team and an IdP group. When adding groups to a team, you must include all new and existing groups to avoid replacing existing groups with the new ones. Specifying an empty &#x60;groups&#x60; array will remove all connections for a team.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;PATCH /organizations/{org_id}/team/{team_id}/team-sync/group-mappings&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="teamsCreateOrUpdateIdpGroupConnectionsInOrgRequest"></param>
        /// <returns>GroupMapping</returns>
        public GroupMapping TeamsCreateOrUpdateIdpGroupConnectionsInOrg (string org, string teamSlug, TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequest teamsCreateOrUpdateIdpGroupConnectionsInOrgRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsCreateOrUpdateIdpGroupConnectionsInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsCreateOrUpdateIdpGroupConnectionsInOrg");
            
            // verify the required parameter 'teamsCreateOrUpdateIdpGroupConnectionsInOrgRequest' is set
            if (teamsCreateOrUpdateIdpGroupConnectionsInOrgRequest == null) throw new ApiException(400, "Missing required parameter 'teamsCreateOrUpdateIdpGroupConnectionsInOrgRequest' when calling TeamsCreateOrUpdateIdpGroupConnectionsInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/team-sync/group-mappings";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(teamsCreateOrUpdateIdpGroupConnectionsInOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsCreateOrUpdateIdpGroupConnectionsInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsCreateOrUpdateIdpGroupConnectionsInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (GroupMapping) ApiClient.Deserialize(response.Content, typeof(GroupMapping), response.Headers);
        }

        /// <summary>
        /// Create or update IdP group connections (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;Create or update IdP group connections&#x60;](https://docs.github.com/rest/reference/teams#create-or-update-idp-group-connections) endpoint.  Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Creates, updates, or removes a connection between a team and an IdP group. When adding groups to a team, you must include all new and existing groups to avoid replacing existing groups with the new ones. Specifying an empty &#x60;groups&#x60; array will remove all connections for a team.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="teamsCreateOrUpdateIdpGroupConnectionsLegacyRequest"></param>
        /// <returns>GroupMapping</returns>
        [Obsolete]
        public GroupMapping TeamsCreateOrUpdateIdpGroupConnectionsLegacy (int? teamId, TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequest teamsCreateOrUpdateIdpGroupConnectionsLegacyRequest)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsCreateOrUpdateIdpGroupConnectionsLegacy");
            
            // verify the required parameter 'teamsCreateOrUpdateIdpGroupConnectionsLegacyRequest' is set
            if (teamsCreateOrUpdateIdpGroupConnectionsLegacyRequest == null) throw new ApiException(400, "Missing required parameter 'teamsCreateOrUpdateIdpGroupConnectionsLegacyRequest' when calling TeamsCreateOrUpdateIdpGroupConnectionsLegacy");
            

            var path = "/teams/{team_id}/team-sync/group-mappings";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(teamsCreateOrUpdateIdpGroupConnectionsLegacyRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsCreateOrUpdateIdpGroupConnectionsLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsCreateOrUpdateIdpGroupConnectionsLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (GroupMapping) ApiClient.Deserialize(response.Content, typeof(GroupMapping), response.Headers);
        }

        /// <summary>
        /// Delete a discussion comment Deletes a comment on a team discussion. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;DELETE /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}/comments/{comment_number}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="commentNumber">The number that identifies the comment.</param>
        /// <returns></returns>
        public void TeamsDeleteDiscussionCommentInOrg (string org, string teamSlug, int? discussionNumber, int? commentNumber)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsDeleteDiscussionCommentInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsDeleteDiscussionCommentInOrg");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling TeamsDeleteDiscussionCommentInOrg");
            
            // verify the required parameter 'commentNumber' is set
            if (commentNumber == null) throw new ApiException(400, "Missing required parameter 'commentNumber' when calling TeamsDeleteDiscussionCommentInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/comments/{comment_number}";
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

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsDeleteDiscussionCommentInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsDeleteDiscussionCommentInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a discussion comment (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Delete a discussion comment](https://docs.github.com/rest/reference/teams#delete-a-discussion-comment) endpoint.  Deletes a comment on a team discussion. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="commentNumber">The number that identifies the comment.</param>
        /// <returns></returns>
        [Obsolete]
        public void TeamsDeleteDiscussionCommentLegacy (int? teamId, int? discussionNumber, int? commentNumber)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsDeleteDiscussionCommentLegacy");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling TeamsDeleteDiscussionCommentLegacy");
            
            // verify the required parameter 'commentNumber' is set
            if (commentNumber == null) throw new ApiException(400, "Missing required parameter 'commentNumber' when calling TeamsDeleteDiscussionCommentLegacy");
            

            var path = "/teams/{team_id}/discussions/{discussion_number}/comments/{comment_number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));
path = path.Replace("{" + "comment_number" + "}", ApiClient.ParameterToString(commentNumber));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsDeleteDiscussionCommentLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsDeleteDiscussionCommentLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a discussion Delete a discussion from a team&#39;s page. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;DELETE /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <returns></returns>
        public void TeamsDeleteDiscussionInOrg (string org, string teamSlug, int? discussionNumber)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsDeleteDiscussionInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsDeleteDiscussionInOrg");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling TeamsDeleteDiscussionInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/discussions/{discussion_number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsDeleteDiscussionInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsDeleteDiscussionInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a discussion (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;Delete a discussion&#x60;](https://docs.github.com/rest/reference/teams#delete-a-discussion) endpoint.  Delete a discussion from a team&#39;s page. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <returns></returns>
        [Obsolete]
        public void TeamsDeleteDiscussionLegacy (int? teamId, int? discussionNumber)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsDeleteDiscussionLegacy");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling TeamsDeleteDiscussionLegacy");
            

            var path = "/teams/{team_id}/discussions/{discussion_number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsDeleteDiscussionLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsDeleteDiscussionLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a team To delete a team, the authenticated user must be an organization owner or team maintainer.  If you are an organization owner, deleting a parent team will delete all of its child teams as well.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;DELETE /organizations/{org_id}/team/{team_id}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <returns></returns>
        public void TeamsDeleteInOrg (string org, string teamSlug)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsDeleteInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsDeleteInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsDeleteInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsDeleteInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a team (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Delete a team](https://docs.github.com/rest/reference/teams#delete-a-team) endpoint.  To delete a team, the authenticated user must be an organization owner or team maintainer.  If you are an organization owner, deleting a parent team will delete all of its child teams as well.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <returns></returns>
        [Obsolete]
        public void TeamsDeleteLegacy (int? teamId)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsDeleteLegacy");
            

            var path = "/teams/{team_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsDeleteLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsDeleteLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get an external group Displays information about the specific group&#39;s usage.  Provides a list of the group&#39;s external members as well as a list of teams that this group is connected to.  You can manage team membership with your identity provider using Enterprise Managed Users for GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products)\&quot; in the GitHub Help documentation.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="groupId">The unique identifier of the group.</param>
        /// <returns>ExternalGroup</returns>
        public ExternalGroup TeamsExternalIdpGroupInfoForOrg (string org, int? groupId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsExternalIdpGroupInfoForOrg");
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling TeamsExternalIdpGroupInfoForOrg");
            

            var path = "/orgs/{org}/external-group/{group_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "group_id" + "}", ApiClient.ParameterToString(groupId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsExternalIdpGroupInfoForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsExternalIdpGroupInfoForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (ExternalGroup) ApiClient.Deserialize(response.Content, typeof(ExternalGroup), response.Headers);
        }

        /// <summary>
        /// Get a team by name Gets a team using the team&#39;s &#x60;slug&#x60;. GitHub generates the &#x60;slug&#x60; from the team &#x60;name&#x60;.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <returns>FullTeam</returns>
        public FullTeam TeamsGetByName (string org, string teamSlug)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsGetByName");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsGetByName");
            

            var path = "/orgs/{org}/teams/{team_slug}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsGetByName: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsGetByName: " + response.ErrorMessage, response.ErrorMessage);

            return (FullTeam) ApiClient.Deserialize(response.Content, typeof(FullTeam), response.Headers);
        }

        /// <summary>
        /// Get a discussion comment Get a specific comment on a team discussion. OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}/comments/{comment_number}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="commentNumber">The number that identifies the comment.</param>
        /// <returns>TeamDiscussionComment</returns>
        public TeamDiscussionComment TeamsGetDiscussionCommentInOrg (string org, string teamSlug, int? discussionNumber, int? commentNumber)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsGetDiscussionCommentInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsGetDiscussionCommentInOrg");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling TeamsGetDiscussionCommentInOrg");
            
            // verify the required parameter 'commentNumber' is set
            if (commentNumber == null) throw new ApiException(400, "Missing required parameter 'commentNumber' when calling TeamsGetDiscussionCommentInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/comments/{comment_number}";
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

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsGetDiscussionCommentInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsGetDiscussionCommentInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamDiscussionComment) ApiClient.Deserialize(response.Content, typeof(TeamDiscussionComment), response.Headers);
        }

        /// <summary>
        /// Get a discussion comment (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Get a discussion comment](https://docs.github.com/rest/reference/teams#get-a-discussion-comment) endpoint.  Get a specific comment on a team discussion. OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="commentNumber">The number that identifies the comment.</param>
        /// <returns>TeamDiscussionComment</returns>
        [Obsolete]
        public TeamDiscussionComment TeamsGetDiscussionCommentLegacy (int? teamId, int? discussionNumber, int? commentNumber)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsGetDiscussionCommentLegacy");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling TeamsGetDiscussionCommentLegacy");
            
            // verify the required parameter 'commentNumber' is set
            if (commentNumber == null) throw new ApiException(400, "Missing required parameter 'commentNumber' when calling TeamsGetDiscussionCommentLegacy");
            

            var path = "/teams/{team_id}/discussions/{discussion_number}/comments/{comment_number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));
path = path.Replace("{" + "comment_number" + "}", ApiClient.ParameterToString(commentNumber));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsGetDiscussionCommentLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsGetDiscussionCommentLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamDiscussionComment) ApiClient.Deserialize(response.Content, typeof(TeamDiscussionComment), response.Headers);
        }

        /// <summary>
        /// Get a discussion Get a specific discussion on a team&#39;s page. OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <returns>TeamDiscussion</returns>
        public TeamDiscussion TeamsGetDiscussionInOrg (string org, string teamSlug, int? discussionNumber)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsGetDiscussionInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsGetDiscussionInOrg");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling TeamsGetDiscussionInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/discussions/{discussion_number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsGetDiscussionInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsGetDiscussionInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamDiscussion) ApiClient.Deserialize(response.Content, typeof(TeamDiscussion), response.Headers);
        }

        /// <summary>
        /// Get a discussion (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Get a discussion](https://docs.github.com/rest/reference/teams#get-a-discussion) endpoint.  Get a specific discussion on a team&#39;s page. OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <returns>TeamDiscussion</returns>
        [Obsolete]
        public TeamDiscussion TeamsGetDiscussionLegacy (int? teamId, int? discussionNumber)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsGetDiscussionLegacy");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling TeamsGetDiscussionLegacy");
            

            var path = "/teams/{team_id}/discussions/{discussion_number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsGetDiscussionLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsGetDiscussionLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamDiscussion) ApiClient.Deserialize(response.Content, typeof(TeamDiscussion), response.Headers);
        }

        /// <summary>
        /// Get a team (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the [Get a team by name](https://docs.github.com/rest/reference/teams#get-a-team-by-name) endpoint.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <returns>FullTeam</returns>
        [Obsolete]
        public FullTeam TeamsGetLegacy (int? teamId)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsGetLegacy");
            

            var path = "/teams/{team_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsGetLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsGetLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (FullTeam) ApiClient.Deserialize(response.Content, typeof(FullTeam), response.Headers);
        }

        /// <summary>
        /// Get team member (Legacy) The \&quot;Get team member\&quot; endpoint (described below) is deprecated.  We recommend using the [Get team membership for a user](https://docs.github.com/rest/reference/teams#get-team-membership-for-a-user) endpoint instead. It allows you to get both active and pending memberships.  To list members in a team, the team must be visible to the authenticated user.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        [Obsolete]
        public void TeamsGetMemberLegacy (int? teamId, string username)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsGetMemberLegacy");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling TeamsGetMemberLegacy");
            

            var path = "/teams/{team_id}/members/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsGetMemberLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsGetMemberLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get team membership for a user Team members will include the members of child teams.  To get a user&#39;s membership with a team, the team must be visible to the authenticated user.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/memberships/{username}&#x60;.  **Note:** The response contains the &#x60;state&#x60; of the membership and the member&#39;s &#x60;role&#x60;.  The &#x60;role&#x60; for organization owners is set to &#x60;maintainer&#x60;. For more information about &#x60;maintainer&#x60; roles, see see [Create a team](https://docs.github.com/rest/reference/teams#create-a-team).
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>TeamMembership</returns>
        public TeamMembership TeamsGetMembershipForUserInOrg (string org, string teamSlug, string username)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsGetMembershipForUserInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsGetMembershipForUserInOrg");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling TeamsGetMembershipForUserInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/memberships/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));
path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsGetMembershipForUserInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsGetMembershipForUserInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamMembership) ApiClient.Deserialize(response.Content, typeof(TeamMembership), response.Headers);
        }

        /// <summary>
        /// Get team membership for a user (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Get team membership for a user](https://docs.github.com/rest/reference/teams#get-team-membership-for-a-user) endpoint.  Team members will include the members of child teams.  To get a user&#39;s membership with a team, the team must be visible to the authenticated user.  **Note:** The response contains the &#x60;state&#x60; of the membership and the member&#39;s &#x60;role&#x60;.  The &#x60;role&#x60; for organization owners is set to &#x60;maintainer&#x60;. For more information about &#x60;maintainer&#x60; roles, see [Create a team](https://docs.github.com/rest/reference/teams#create-a-team).
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>TeamMembership</returns>
        [Obsolete]
        public TeamMembership TeamsGetMembershipForUserLegacy (int? teamId, string username)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsGetMembershipForUserLegacy");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling TeamsGetMembershipForUserLegacy");
            

            var path = "/teams/{team_id}/memberships/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsGetMembershipForUserLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsGetMembershipForUserLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamMembership) ApiClient.Deserialize(response.Content, typeof(TeamMembership), response.Headers);
        }

        /// <summary>
        /// Update the connection between an external group and a team Creates a connection between a team and an external group.  Only one external group can be linked to a team.  You can manage team membership with your identity provider using Enterprise Managed Users for GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products)\&quot; in the GitHub Help documentation.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="teamsLinkExternalIdpGroupToTeamForOrgRequest"></param>
        /// <returns>ExternalGroup</returns>
        public ExternalGroup TeamsLinkExternalIdpGroupToTeamForOrg (string org, string teamSlug, TeamsLinkExternalIdpGroupToTeamForOrgRequest teamsLinkExternalIdpGroupToTeamForOrgRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsLinkExternalIdpGroupToTeamForOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsLinkExternalIdpGroupToTeamForOrg");
            
            // verify the required parameter 'teamsLinkExternalIdpGroupToTeamForOrgRequest' is set
            if (teamsLinkExternalIdpGroupToTeamForOrgRequest == null) throw new ApiException(400, "Missing required parameter 'teamsLinkExternalIdpGroupToTeamForOrgRequest' when calling TeamsLinkExternalIdpGroupToTeamForOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/external-groups";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(teamsLinkExternalIdpGroupToTeamForOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsLinkExternalIdpGroupToTeamForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsLinkExternalIdpGroupToTeamForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (ExternalGroup) ApiClient.Deserialize(response.Content, typeof(ExternalGroup), response.Headers);
        }

        /// <summary>
        /// List teams Lists all teams in an organization that are visible to the authenticated user.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Team&gt;</returns>
        public List<Team> TeamsList (string org, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsList");
            

            var path = "/orgs/{org}/teams";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsList: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Team>) ApiClient.Deserialize(response.Content, typeof(List<Team>), response.Headers);
        }

        /// <summary>
        /// List child teams Lists the child teams of the team specified by &#x60;{team_slug}&#x60;.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/teams&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Team&gt;</returns>
        public List<Team> TeamsListChildInOrg (string org, string teamSlug, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsListChildInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsListChildInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/teams";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListChildInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListChildInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Team>) ApiClient.Deserialize(response.Content, typeof(List<Team>), response.Headers);
        }

        /// <summary>
        /// List child teams (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;List child teams&#x60;](https://docs.github.com/rest/reference/teams#list-child-teams) endpoint.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Team&gt;</returns>
        [Obsolete]
        public List<Team> TeamsListChildLegacy (int? teamId, int? perPage, int? page)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsListChildLegacy");
            

            var path = "/teams/{team_id}/teams";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListChildLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListChildLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Team>) ApiClient.Deserialize(response.Content, typeof(List<Team>), response.Headers);
        }

        /// <summary>
        /// List discussion comments List all comments on a team discussion. OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}/comments&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;TeamDiscussionComment&gt;</returns>
        public List<TeamDiscussionComment> TeamsListDiscussionCommentsInOrg (string org, string teamSlug, int? discussionNumber, string direction, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsListDiscussionCommentsInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsListDiscussionCommentsInOrg");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling TeamsListDiscussionCommentsInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListDiscussionCommentsInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListDiscussionCommentsInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (List<TeamDiscussionComment>) ApiClient.Deserialize(response.Content, typeof(List<TeamDiscussionComment>), response.Headers);
        }

        /// <summary>
        /// List discussion comments (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [List discussion comments](https://docs.github.com/rest/reference/teams#list-discussion-comments) endpoint.  List all comments on a team discussion. OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;TeamDiscussionComment&gt;</returns>
        [Obsolete]
        public List<TeamDiscussionComment> TeamsListDiscussionCommentsLegacy (int? teamId, int? discussionNumber, string direction, int? perPage, int? page)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsListDiscussionCommentsLegacy");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling TeamsListDiscussionCommentsLegacy");
            

            var path = "/teams/{team_id}/discussions/{discussion_number}/comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListDiscussionCommentsLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListDiscussionCommentsLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (List<TeamDiscussionComment>) ApiClient.Deserialize(response.Content, typeof(List<TeamDiscussionComment>), response.Headers);
        }

        /// <summary>
        /// List discussions List all discussions on a team&#39;s page. OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/discussions&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="pinned">Pinned discussions only filter</param>
        /// <returns>List&lt;TeamDiscussion&gt;</returns>
        public List<TeamDiscussion> TeamsListDiscussionsInOrg (string org, string teamSlug, string direction, int? perPage, int? page, string pinned)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsListDiscussionsInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsListDiscussionsInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/discussions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (pinned != null) queryParams.Add("pinned", ApiClient.ParameterToString(pinned)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListDiscussionsInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListDiscussionsInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (List<TeamDiscussion>) ApiClient.Deserialize(response.Content, typeof(List<TeamDiscussion>), response.Headers);
        }

        /// <summary>
        /// List discussions (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;List discussions&#x60;](https://docs.github.com/rest/reference/teams#list-discussions) endpoint.  List all discussions on a team&#39;s page. OAuth access tokens require the &#x60;read:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;TeamDiscussion&gt;</returns>
        [Obsolete]
        public List<TeamDiscussion> TeamsListDiscussionsLegacy (int? teamId, string direction, int? perPage, int? page)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsListDiscussionsLegacy");
            

            var path = "/teams/{team_id}/discussions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListDiscussionsLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListDiscussionsLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (List<TeamDiscussion>) ApiClient.Deserialize(response.Content, typeof(List<TeamDiscussion>), response.Headers);
        }

        /// <summary>
        /// List external groups in an organization Lists external groups available in an organization. You can query the groups using the &#x60;display_name&#x60; parameter, only groups with a &#x60;group_name&#x60; containing the text provided in the &#x60;display_name&#x60; parameter will be returned.  You can also limit your page results using the &#x60;per_page&#x60; parameter. GitHub generates a url-encoded &#x60;page&#x60; token using a cursor value for where the next page begins. For more information on cursor pagination, see \&quot;[Offset and Cursor Pagination explained](https://dev.to/jackmarchant/offset-and-cursor-pagination-explained-b89).\&quot;  You can manage team membership with your identity provider using Enterprise Managed Users for GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products)\&quot; in the GitHub Help documentation.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page token</param>
        /// <param name="displayName">Limits the list to groups containing the text in the group name</param>
        /// <returns>ExternalGroups</returns>
        public ExternalGroups TeamsListExternalIdpGroupsForOrg (string org, int? perPage, int? page, string displayName)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsListExternalIdpGroupsForOrg");
            

            var path = "/orgs/{org}/external-groups";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (displayName != null) queryParams.Add("display_name", ApiClient.ParameterToString(displayName)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListExternalIdpGroupsForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListExternalIdpGroupsForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (ExternalGroups) ApiClient.Deserialize(response.Content, typeof(ExternalGroups), response.Headers);
        }

        /// <summary>
        /// List teams for the authenticated user List all of the teams across all of the organizations to which the authenticated user belongs. This method requires &#x60;user&#x60;, &#x60;repo&#x60;, or &#x60;read:org&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/) when authenticating via [OAuth](https://docs.github.com/apps/building-oauth-apps/).
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;FullTeam&gt;</returns>
        public List<FullTeam> TeamsListForAuthenticatedUser (int? perPage, int? page)
        {
            

            var path = "/user/teams";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<FullTeam>) ApiClient.Deserialize(response.Content, typeof(List<FullTeam>), response.Headers);
        }

        /// <summary>
        /// List IdP groups for a team (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;List IdP groups for a team&#x60;](https://docs.github.com/rest/reference/teams#list-idp-groups-for-a-team) endpoint.  Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  List IdP groups connected to a team on GitHub.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <returns>GroupMapping</returns>
        [Obsolete]
        public GroupMapping TeamsListIdpGroupsForLegacy (int? teamId)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsListIdpGroupsForLegacy");
            

            var path = "/teams/{team_id}/team-sync/group-mappings";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListIdpGroupsForLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListIdpGroupsForLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (GroupMapping) ApiClient.Deserialize(response.Content, typeof(GroupMapping), response.Headers);
        }

        /// <summary>
        /// List IdP groups for an organization Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  List IdP groups available in an organization. You can limit your page results using the &#x60;per_page&#x60; parameter. GitHub generates a url-encoded &#x60;page&#x60; token using a cursor value for where the next page begins. For more information on cursor pagination, see \&quot;[Offset and Cursor Pagination explained](https://dev.to/jackmarchant/offset-and-cursor-pagination-explained-b89).\&quot;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page token</param>
        /// <returns>GroupMapping</returns>
        public GroupMapping TeamsListIdpGroupsForOrg (string org, int? perPage, string page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsListIdpGroupsForOrg");
            

            var path = "/orgs/{org}/team-sync/groups";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListIdpGroupsForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListIdpGroupsForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (GroupMapping) ApiClient.Deserialize(response.Content, typeof(GroupMapping), response.Headers);
        }

        /// <summary>
        /// List IdP groups for a team Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  List IdP groups connected to a team on GitHub.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/team-sync/group-mappings&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <returns>GroupMapping</returns>
        public GroupMapping TeamsListIdpGroupsInOrg (string org, string teamSlug)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsListIdpGroupsInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsListIdpGroupsInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/team-sync/group-mappings";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListIdpGroupsInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListIdpGroupsInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (GroupMapping) ApiClient.Deserialize(response.Content, typeof(GroupMapping), response.Headers);
        }

        /// <summary>
        /// List a connection between an external group and a team Lists a connection between a team and an external group.  You can manage team membership with your identity provider using Enterprise Managed Users for GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products)\&quot; in the GitHub Help documentation.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <returns>ExternalGroups</returns>
        public ExternalGroups TeamsListLinkedExternalIdpGroupsToTeamForOrg (string org, string teamSlug)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsListLinkedExternalIdpGroupsToTeamForOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsListLinkedExternalIdpGroupsToTeamForOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/external-groups";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListLinkedExternalIdpGroupsToTeamForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListLinkedExternalIdpGroupsToTeamForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (ExternalGroups) ApiClient.Deserialize(response.Content, typeof(ExternalGroups), response.Headers);
        }

        /// <summary>
        /// List team members Team members will include the members of child teams.  To list members in a team, the team must be visible to the authenticated user.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="role">Filters members returned by their role in the team.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        public List<SimpleUser1> TeamsListMembersInOrg (string org, string teamSlug, string role, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsListMembersInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsListMembersInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/members";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (role != null) queryParams.Add("role", ApiClient.ParameterToString(role)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListMembersInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListMembersInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SimpleUser1>) ApiClient.Deserialize(response.Content, typeof(List<SimpleUser1>), response.Headers);
        }

        /// <summary>
        /// List team members (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;List team members&#x60;](https://docs.github.com/rest/reference/teams#list-team-members) endpoint.  Team members will include the members of child teams.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="role">Filters members returned by their role in the team.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        [Obsolete]
        public List<SimpleUser1> TeamsListMembersLegacy (int? teamId, string role, int? perPage, int? page)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsListMembersLegacy");
            

            var path = "/teams/{team_id}/members";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (role != null) queryParams.Add("role", ApiClient.ParameterToString(role)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListMembersLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListMembersLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SimpleUser1>) ApiClient.Deserialize(response.Content, typeof(List<SimpleUser1>), response.Headers);
        }

        /// <summary>
        /// List pending team invitations The return hash contains a &#x60;role&#x60; field which refers to the Organization Invitation role and will be one of the following values: &#x60;direct_member&#x60;, &#x60;admin&#x60;, &#x60;billing_manager&#x60;, &#x60;hiring_manager&#x60;, or &#x60;reinstate&#x60;. If the invitee is not a GitHub member, the &#x60;login&#x60; field in the return hash will be &#x60;null&#x60;.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/invitations&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;OrganizationInvitation&gt;</returns>
        public List<OrganizationInvitation> TeamsListPendingInvitationsInOrg (string org, string teamSlug, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsListPendingInvitationsInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsListPendingInvitationsInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/invitations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListPendingInvitationsInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListPendingInvitationsInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (List<OrganizationInvitation>) ApiClient.Deserialize(response.Content, typeof(List<OrganizationInvitation>), response.Headers);
        }

        /// <summary>
        /// List pending team invitations (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;List pending team invitations&#x60;](https://docs.github.com/rest/reference/teams#list-pending-team-invitations) endpoint.  The return hash contains a &#x60;role&#x60; field which refers to the Organization Invitation role and will be one of the following values: &#x60;direct_member&#x60;, &#x60;admin&#x60;, &#x60;billing_manager&#x60;, &#x60;hiring_manager&#x60;, or &#x60;reinstate&#x60;. If the invitee is not a GitHub member, the &#x60;login&#x60; field in the return hash will be &#x60;null&#x60;.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;OrganizationInvitation&gt;</returns>
        [Obsolete]
        public List<OrganizationInvitation> TeamsListPendingInvitationsLegacy (int? teamId, int? perPage, int? page)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsListPendingInvitationsLegacy");
            

            var path = "/teams/{team_id}/invitations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListPendingInvitationsLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListPendingInvitationsLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (List<OrganizationInvitation>) ApiClient.Deserialize(response.Content, typeof(List<OrganizationInvitation>), response.Headers);
        }

        /// <summary>
        /// List team projects Lists the organization projects for a team.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/projects&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;TeamProject&gt;</returns>
        public List<TeamProject> TeamsListProjectsInOrg (string org, string teamSlug, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsListProjectsInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsListProjectsInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/projects";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListProjectsInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListProjectsInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (List<TeamProject>) ApiClient.Deserialize(response.Content, typeof(List<TeamProject>), response.Headers);
        }

        /// <summary>
        /// List team projects (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [&#x60;List team projects&#x60;](https://docs.github.com/rest/reference/teams#list-team-projects) endpoint.  Lists the organization projects for a team.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;TeamProject&gt;</returns>
        [Obsolete]
        public List<TeamProject> TeamsListProjectsLegacy (int? teamId, int? perPage, int? page)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsListProjectsLegacy");
            

            var path = "/teams/{team_id}/projects";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListProjectsLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListProjectsLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (List<TeamProject>) ApiClient.Deserialize(response.Content, typeof(List<TeamProject>), response.Headers);
        }

        /// <summary>
        /// List team repositories Lists a team&#39;s repositories visible to the authenticated user.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;GET /organizations/{org_id}/team/{team_id}/repos&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MinimalRepository&gt;</returns>
        public List<MinimalRepository> TeamsListReposInOrg (string org, string teamSlug, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsListReposInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsListReposInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/repos";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListReposInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListReposInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (List<MinimalRepository>) ApiClient.Deserialize(response.Content, typeof(List<MinimalRepository>), response.Headers);
        }

        /// <summary>
        /// List team repositories (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [List team repositories](https://docs.github.com/rest/reference/teams#list-team-repositories) endpoint.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MinimalRepository&gt;</returns>
        [Obsolete]
        public List<MinimalRepository> TeamsListReposLegacy (int? teamId, int? perPage, int? page)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsListReposLegacy");
            

            var path = "/teams/{team_id}/repos";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListReposLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsListReposLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (List<MinimalRepository>) ApiClient.Deserialize(response.Content, typeof(List<MinimalRepository>), response.Headers);
        }

        /// <summary>
        /// Remove team member (Legacy) The \&quot;Remove team member\&quot; endpoint (described below) is deprecated.  We recommend using the [Remove team membership for a user](https://docs.github.com/rest/reference/teams#remove-team-membership-for-a-user) endpoint instead. It allows you to remove both active and pending memberships.  Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  To remove a team member, the authenticated user must have &#39;admin&#39; permissions to the team or be an owner of the org that the team is associated with. Removing a team member does not delete the user, it just removes them from the team.  **Note:** When you have team synchronization set up for a team with your organization&#39;s identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team&#39;s membership. If you have access to manage group membership in your IdP, you can manage GitHub team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see \&quot;[Synchronizing teams between your identity provider and GitHub](https://docs.github.com/articles/synchronizing-teams-between-your-identity-provider-and-github/).\&quot;
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        [Obsolete]
        public void TeamsRemoveMemberLegacy (int? teamId, string username)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsRemoveMemberLegacy");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling TeamsRemoveMemberLegacy");
            

            var path = "/teams/{team_id}/members/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsRemoveMemberLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsRemoveMemberLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Remove team membership for a user Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  To remove a membership between a user and a team, the authenticated user must have &#39;admin&#39; permissions to the team or be an owner of the organization that the team is associated with. Removing team membership does not delete the user, it just removes their membership from the team.  **Note:** When you have team synchronization set up for a team with your organization&#39;s identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team&#39;s membership. If you have access to manage group membership in your IdP, you can manage GitHub team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see \&quot;[Synchronizing teams between your identity provider and GitHub](https://docs.github.com/articles/synchronizing-teams-between-your-identity-provider-and-github/).\&quot;  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;DELETE /organizations/{org_id}/team/{team_id}/memberships/{username}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        public void TeamsRemoveMembershipForUserInOrg (string org, string teamSlug, string username)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsRemoveMembershipForUserInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsRemoveMembershipForUserInOrg");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling TeamsRemoveMembershipForUserInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/memberships/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));
path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsRemoveMembershipForUserInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsRemoveMembershipForUserInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Remove team membership for a user (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Remove team membership for a user](https://docs.github.com/rest/reference/teams#remove-team-membership-for-a-user) endpoint.  Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  To remove a membership between a user and a team, the authenticated user must have &#39;admin&#39; permissions to the team or be an owner of the organization that the team is associated with. Removing team membership does not delete the user, it just removes their membership from the team.  **Note:** When you have team synchronization set up for a team with your organization&#39;s identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team&#39;s membership. If you have access to manage group membership in your IdP, you can manage GitHub team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see \&quot;[Synchronizing teams between your identity provider and GitHub](https://docs.github.com/articles/synchronizing-teams-between-your-identity-provider-and-github/).\&quot;
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        [Obsolete]
        public void TeamsRemoveMembershipForUserLegacy (int? teamId, string username)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsRemoveMembershipForUserLegacy");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling TeamsRemoveMembershipForUserLegacy");
            

            var path = "/teams/{team_id}/memberships/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsRemoveMembershipForUserLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsRemoveMembershipForUserLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Remove a project from a team Removes an organization project from a team. An organization owner or a team maintainer can remove any project from the team. To remove a project from a team as an organization member, the authenticated user must have &#x60;read&#x60; access to both the team and project, or &#x60;admin&#x60; access to the team or project. This endpoint removes the project from the team, but does not delete the project.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;DELETE /organizations/{org_id}/team/{team_id}/projects/{project_id}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <returns></returns>
        public void TeamsRemoveProjectInOrg (string org, string teamSlug, int? projectId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsRemoveProjectInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsRemoveProjectInOrg");
            
            // verify the required parameter 'projectId' is set
            if (projectId == null) throw new ApiException(400, "Missing required parameter 'projectId' when calling TeamsRemoveProjectInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/projects/{project_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));
path = path.Replace("{" + "project_id" + "}", ApiClient.ParameterToString(projectId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsRemoveProjectInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsRemoveProjectInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Remove a project from a team (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Remove a project from a team](https://docs.github.com/rest/reference/teams#remove-a-project-from-a-team) endpoint.  Removes an organization project from a team. An organization owner or a team maintainer can remove any project from the team. To remove a project from a team as an organization member, the authenticated user must have &#x60;read&#x60; access to both the team and project, or &#x60;admin&#x60; access to the team or project. **Note:** This endpoint removes the project from the team, but does not delete it.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <returns></returns>
        [Obsolete]
        public void TeamsRemoveProjectLegacy (int? teamId, int? projectId)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsRemoveProjectLegacy");
            
            // verify the required parameter 'projectId' is set
            if (projectId == null) throw new ApiException(400, "Missing required parameter 'projectId' when calling TeamsRemoveProjectLegacy");
            

            var path = "/teams/{team_id}/projects/{project_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
path = path.Replace("{" + "project_id" + "}", ApiClient.ParameterToString(projectId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsRemoveProjectLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsRemoveProjectLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Remove a repository from a team If the authenticated user is an organization owner or a team maintainer, they can remove any repositories from the team. To remove a repository from a team as an organization member, the authenticated user must have admin access to the repository and must be able to see the team. This does not delete the repository, it just removes it from the team.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;DELETE /organizations/{org_id}/team/{team_id}/repos/{owner}/{repo}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        public void TeamsRemoveRepoInOrg (string org, string teamSlug, string owner, string repo)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsRemoveRepoInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsRemoveRepoInOrg");
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling TeamsRemoveRepoInOrg");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling TeamsRemoveRepoInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/repos/{owner}/{repo}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));
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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsRemoveRepoInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsRemoveRepoInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Remove a repository from a team (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Remove a repository from a team](https://docs.github.com/rest/reference/teams#remove-a-repository-from-a-team) endpoint.  If the authenticated user is an organization owner or a team maintainer, they can remove any repositories from the team. To remove a repository from a team as an organization member, the authenticated user must have admin access to the repository and must be able to see the team. NOTE: This does not delete the repository, it just removes it from the team.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        [Obsolete]
        public void TeamsRemoveRepoLegacy (int? teamId, string owner, string repo)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsRemoveRepoLegacy");
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling TeamsRemoveRepoLegacy");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling TeamsRemoveRepoLegacy");
            

            var path = "/teams/{team_id}/repos/{owner}/{repo}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsRemoveRepoLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsRemoveRepoLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Remove the connection between an external group and a team Deletes a connection between a team and an external group.  You can manage team membership with your IdP using Enterprise Managed Users for GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <returns></returns>
        public void TeamsUnlinkExternalIdpGroupFromTeamForOrg (string org, string teamSlug)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsUnlinkExternalIdpGroupFromTeamForOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsUnlinkExternalIdpGroupFromTeamForOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/external-groups";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));

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
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsUnlinkExternalIdpGroupFromTeamForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsUnlinkExternalIdpGroupFromTeamForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Update a discussion comment Edits the body text of a discussion comment. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;PATCH /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}/comments/{comment_number}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="commentNumber">The number that identifies the comment.</param>
        /// <param name="teamsCreateDiscussionCommentInOrgRequest"></param>
        /// <returns>TeamDiscussionComment</returns>
        public TeamDiscussionComment TeamsUpdateDiscussionCommentInOrg (string org, string teamSlug, int? discussionNumber, int? commentNumber, TeamsCreateDiscussionCommentInOrgRequest teamsCreateDiscussionCommentInOrgRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsUpdateDiscussionCommentInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsUpdateDiscussionCommentInOrg");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling TeamsUpdateDiscussionCommentInOrg");
            
            // verify the required parameter 'commentNumber' is set
            if (commentNumber == null) throw new ApiException(400, "Missing required parameter 'commentNumber' when calling TeamsUpdateDiscussionCommentInOrg");
            
            // verify the required parameter 'teamsCreateDiscussionCommentInOrgRequest' is set
            if (teamsCreateDiscussionCommentInOrgRequest == null) throw new ApiException(400, "Missing required parameter 'teamsCreateDiscussionCommentInOrgRequest' when calling TeamsUpdateDiscussionCommentInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/discussions/{discussion_number}/comments/{comment_number}";
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

                                                postBody = ApiClient.Serialize(teamsCreateDiscussionCommentInOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsUpdateDiscussionCommentInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsUpdateDiscussionCommentInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamDiscussionComment) ApiClient.Deserialize(response.Content, typeof(TeamDiscussionComment), response.Headers);
        }

        /// <summary>
        /// Update a discussion comment (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Update a discussion comment](https://docs.github.com/rest/reference/teams#update-a-discussion-comment) endpoint.  Edits the body text of a discussion comment. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="commentNumber">The number that identifies the comment.</param>
        /// <param name="teamsCreateDiscussionCommentInOrgRequest"></param>
        /// <returns>TeamDiscussionComment</returns>
        [Obsolete]
        public TeamDiscussionComment TeamsUpdateDiscussionCommentLegacy (int? teamId, int? discussionNumber, int? commentNumber, TeamsCreateDiscussionCommentInOrgRequest teamsCreateDiscussionCommentInOrgRequest)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsUpdateDiscussionCommentLegacy");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling TeamsUpdateDiscussionCommentLegacy");
            
            // verify the required parameter 'commentNumber' is set
            if (commentNumber == null) throw new ApiException(400, "Missing required parameter 'commentNumber' when calling TeamsUpdateDiscussionCommentLegacy");
            
            // verify the required parameter 'teamsCreateDiscussionCommentInOrgRequest' is set
            if (teamsCreateDiscussionCommentInOrgRequest == null) throw new ApiException(400, "Missing required parameter 'teamsCreateDiscussionCommentInOrgRequest' when calling TeamsUpdateDiscussionCommentLegacy");
            

            var path = "/teams/{team_id}/discussions/{discussion_number}/comments/{comment_number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));
path = path.Replace("{" + "comment_number" + "}", ApiClient.ParameterToString(commentNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(teamsCreateDiscussionCommentInOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsUpdateDiscussionCommentLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsUpdateDiscussionCommentLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamDiscussionComment) ApiClient.Deserialize(response.Content, typeof(TeamDiscussionComment), response.Headers);
        }

        /// <summary>
        /// Update a discussion Edits the title and body text of a discussion post. Only the parameters you provide are updated. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;PATCH /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="teamsUpdateDiscussionInOrgRequest"></param>
        /// <returns>TeamDiscussion</returns>
        public TeamDiscussion TeamsUpdateDiscussionInOrg (string org, string teamSlug, int? discussionNumber, TeamsUpdateDiscussionInOrgRequest teamsUpdateDiscussionInOrgRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsUpdateDiscussionInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsUpdateDiscussionInOrg");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling TeamsUpdateDiscussionInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}/discussions/{discussion_number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(teamsUpdateDiscussionInOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsUpdateDiscussionInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsUpdateDiscussionInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamDiscussion) ApiClient.Deserialize(response.Content, typeof(TeamDiscussion), response.Headers);
        }

        /// <summary>
        /// Update a discussion (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Update a discussion](https://docs.github.com/rest/reference/teams#update-a-discussion) endpoint.  Edits the title and body text of a discussion post. Only the parameters you provide are updated. OAuth access tokens require the &#x60;write:discussion&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="discussionNumber">The number that identifies the discussion.</param>
        /// <param name="teamsUpdateDiscussionInOrgRequest"></param>
        /// <returns>TeamDiscussion</returns>
        [Obsolete]
        public TeamDiscussion TeamsUpdateDiscussionLegacy (int? teamId, int? discussionNumber, TeamsUpdateDiscussionInOrgRequest teamsUpdateDiscussionInOrgRequest)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsUpdateDiscussionLegacy");
            
            // verify the required parameter 'discussionNumber' is set
            if (discussionNumber == null) throw new ApiException(400, "Missing required parameter 'discussionNumber' when calling TeamsUpdateDiscussionLegacy");
            

            var path = "/teams/{team_id}/discussions/{discussion_number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));
path = path.Replace("{" + "discussion_number" + "}", ApiClient.ParameterToString(discussionNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(teamsUpdateDiscussionInOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsUpdateDiscussionLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsUpdateDiscussionLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (TeamDiscussion) ApiClient.Deserialize(response.Content, typeof(TeamDiscussion), response.Headers);
        }

        /// <summary>
        /// Update a team To edit a team, the authenticated user must either be an organization owner or a team maintainer.  **Note:** You can also specify a team by &#x60;org_id&#x60; and &#x60;team_id&#x60; using the route &#x60;PATCH /organizations/{org_id}/team/{team_id}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <param name="teamsUpdateInOrgRequest"></param>
        /// <returns>FullTeam</returns>
        public FullTeam TeamsUpdateInOrg (string org, string teamSlug, TeamsUpdateInOrgRequest teamsUpdateInOrgRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling TeamsUpdateInOrg");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling TeamsUpdateInOrg");
            

            var path = "/orgs/{org}/teams/{team_slug}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "team_slug" + "}", ApiClient.ParameterToString(teamSlug));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(teamsUpdateInOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsUpdateInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsUpdateInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (FullTeam) ApiClient.Deserialize(response.Content, typeof(FullTeam), response.Headers);
        }

        /// <summary>
        /// Update a team (Legacy) **Deprecation Notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Update a team](https://docs.github.com/rest/reference/teams#update-a-team) endpoint.  To edit a team, the authenticated user must either be an organization owner or a team maintainer.  **Note:** With nested teams, the &#x60;privacy&#x60; for parent teams cannot be &#x60;secret&#x60;.
        /// </summary>
        /// <param name="teamId">The unique identifier of the team.</param>
        /// <param name="teamsUpdateLegacyRequest"></param>
        /// <returns>FullTeam</returns>
        [Obsolete]
        public FullTeam TeamsUpdateLegacy (int? teamId, TeamsUpdateLegacyRequest teamsUpdateLegacyRequest)
        {
            
            // verify the required parameter 'teamId' is set
            if (teamId == null) throw new ApiException(400, "Missing required parameter 'teamId' when calling TeamsUpdateLegacy");
            
            // verify the required parameter 'teamsUpdateLegacyRequest' is set
            if (teamsUpdateLegacyRequest == null) throw new ApiException(400, "Missing required parameter 'teamsUpdateLegacyRequest' when calling TeamsUpdateLegacy");
            

            var path = "/teams/{team_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "team_id" + "}", ApiClient.ParameterToString(teamId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(teamsUpdateLegacyRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsUpdateLegacy: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TeamsUpdateLegacy: " + response.ErrorMessage, response.ErrorMessage);

            return (FullTeam) ApiClient.Deserialize(response.Content, typeof(FullTeam), response.Headers);
        }

    }
}
