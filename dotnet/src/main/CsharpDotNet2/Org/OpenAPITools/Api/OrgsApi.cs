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
    public interface IOrgsApi
    {
        /// <summary>
        /// Add a security manager team Adds a team as a security manager for an organization. For more information, see \&quot;[Managing security for an organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization) for an organization.\&quot;  To use this endpoint, you must be an administrator for the organization, and you must use an access token with the &#x60;write:org&#x60; scope.  GitHub Apps must have the &#x60;administration&#x60; organization read-write permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <returns></returns>
        void OrgsAddSecurityManagerTeam (string org, string teamSlug);
        /// <summary>
        /// Block a user from an organization 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        void OrgsBlockUser (string org, string username);
        /// <summary>
        /// Cancel an organization invitation Cancel an organization invitation. In order to cancel an organization invitation, the authenticated user must be an organization owner.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications).
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="invitationId">The unique identifier of the invitation.</param>
        /// <returns></returns>
        void OrgsCancelInvitation (string org, int? invitationId);
        /// <summary>
        /// Check if a user is blocked by an organization 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        void OrgsCheckBlockedUser (string org, string username);
        /// <summary>
        /// Check organization membership for a user Check if a user is, publicly or privately, a member of the organization.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        void OrgsCheckMembershipForUser (string org, string username);
        /// <summary>
        /// Check public organization membership for a user 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        void OrgsCheckPublicMembershipForUser (string org, string username);
        /// <summary>
        /// Convert an organization member to outside collaborator When an organization member is converted to an outside collaborator, they&#39;ll only have access to the repositories that their current team membership allows. The user will no longer be a member of the organization. For more information, see \&quot;[Converting an organization member to an outside collaborator](https://docs.github.com/articles/converting-an-organization-member-to-an-outside-collaborator/)\&quot;. Converting an organization member to an outside collaborator may be restricted by enterprise administrators. For more information, see \&quot;[Enforcing repository management policies in your enterprise](https://docs.github.com/enterprise-cloud@latest/admin/policies/enforcing-policies-for-your-enterprise/enforcing-repository-management-policies-in-your-enterprise#enforcing-a-policy-for-inviting-outside-collaborators-to-repositories).\&quot;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="orgsConvertMemberToOutsideCollaboratorRequest"></param>
        /// <returns>Object</returns>
        Object OrgsConvertMemberToOutsideCollaborator (string org, string username, OrgsConvertMemberToOutsideCollaboratorRequest orgsConvertMemberToOutsideCollaboratorRequest);
        /// <summary>
        /// Create an organization invitation Invite people to an organization by using their GitHub user ID or their email address. In order to create invitations in an organization, the authenticated user must be an organization owner.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="orgsCreateInvitationRequest"></param>
        /// <returns>OrganizationInvitation</returns>
        OrganizationInvitation OrgsCreateInvitation (string org, OrgsCreateInvitationRequest orgsCreateInvitationRequest);
        /// <summary>
        /// Create an organization webhook Here&#39;s how you can create a hook that posts payloads in JSON format:
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="orgsCreateWebhookRequest"></param>
        /// <returns>OrgHook</returns>
        OrgHook OrgsCreateWebhook (string org, OrgsCreateWebhookRequest orgsCreateWebhookRequest);
        /// <summary>
        /// Delete an organization webhook 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <returns></returns>
        void OrgsDeleteWebhook (string org, int? hookId);
        /// <summary>
        /// Get an organization To see many of the organization response values, you need to be an authenticated organization owner with the &#x60;admin:org&#x60; scope. When the value of &#x60;two_factor_requirement_enabled&#x60; is &#x60;true&#x60;, the organization requires all members, billing managers, and outside collaborators to enable [two-factor authentication](https://docs.github.com/articles/securing-your-account-with-two-factor-authentication-2fa/).  GitHub Apps with the &#x60;Organization plan&#x60; permission can use this endpoint to retrieve information about an organization&#39;s GitHub plan. See \&quot;[Authenticating with GitHub Apps](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/)\&quot; for details. For an example response, see &#39;Response with GitHub plan information&#39; below.\&quot;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>OrganizationFull</returns>
        OrganizationFull OrgsGet (string org);
        /// <summary>
        /// Get the audit log for an organization Gets the audit log for an organization. For more information, see \&quot;[Reviewing the audit log for your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/reviewing-the-audit-log-for-your-organization).\&quot;  This endpoint is available for organizations on GitHub Enterprise Cloud. To use this endpoint, you must be an organization owner, and you must use an access token with the &#x60;admin:org&#x60; scope. GitHub Apps must have the &#x60;organization_administration&#x60; read permission to use this endpoint.  By default, the response includes up to 30 events from the past three months. Use the &#x60;phrase&#x60; parameter to filter results and retrieve older events. For example, use the &#x60;phrase&#x60; parameter with the &#x60;created&#x60; qualifier to filter events based on when the events occurred. For more information, see \&quot;[Reviewing the audit log for your organization](https://docs.github.com/organizations/keeping-your-organization-secure/managing-security-settings-for-your-organization/reviewing-the-audit-log-for-your-organization#searching-the-audit-log).\&quot;  Use pagination to retrieve fewer or more than 30 events. For more information, see \&quot;[Resources in the REST API](https://docs.github.com/rest/overview/resources-in-the-rest-api#pagination).\&quot;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="phrase">A search phrase. For more information, see [Searching the audit log](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/reviewing-the-audit-log-for-your-organization#searching-the-audit-log).</param>
        /// <param name="include">The event types to include:  - &#x60;web&#x60; - returns web (non-Git) events. - &#x60;git&#x60; - returns Git events. - &#x60;all&#x60; - returns both web and Git events.  The default is &#x60;web&#x60;.</param>
        /// <param name="after">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.</param>
        /// <param name="before">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor.</param>
        /// <param name="order">The order of audit log events. To list newest events first, specify &#x60;desc&#x60;. To list oldest events first, specify &#x60;asc&#x60;.  The default is &#x60;desc&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <returns>List&lt;EnterpriseAdminGetAuditLog200ResponseInner&gt;</returns>
        List<EnterpriseAdminGetAuditLog200ResponseInner> OrgsGetAuditLog (string org, string phrase, string include, string after, string before, string order, int? perPage);
        /// <summary>
        /// Get an organization membership for the authenticated user 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>OrgMembership</returns>
        OrgMembership OrgsGetMembershipForAuthenticatedUser (string org);
        /// <summary>
        /// Get organization membership for a user In order to get a user&#39;s membership with an organization, the authenticated user must be an organization member. The &#x60;state&#x60; parameter in the response can be used to identify the user&#39;s membership status.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>OrgMembership</returns>
        OrgMembership OrgsGetMembershipForUser (string org, string username);
        /// <summary>
        /// Get an organization webhook Returns a webhook configured in an organization. To get only the webhook &#x60;config&#x60; properties, see \&quot;[Get a webhook configuration for an organization](/rest/reference/orgs#get-a-webhook-configuration-for-an-organization).\&quot;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <returns>OrgHook</returns>
        OrgHook OrgsGetWebhook (string org, int? hookId);
        /// <summary>
        /// Get a webhook configuration for an organization Returns the webhook configuration for an organization. To get more information about the webhook, including the &#x60;active&#x60; state and &#x60;events&#x60;, use \&quot;[Get an organization webhook ](/rest/reference/orgs#get-an-organization-webhook).\&quot;  Access tokens must have the &#x60;admin:org_hook&#x60; scope, and GitHub Apps must have the &#x60;organization_hooks:read&#x60; permission.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <returns>WebhookConfiguration</returns>
        WebhookConfiguration OrgsGetWebhookConfigForOrg (string org, int? hookId);
        /// <summary>
        /// Get a webhook delivery for an organization webhook Returns a delivery for a webhook configured in an organization.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <param name="deliveryId"></param>
        /// <returns>WebhookDelivery</returns>
        WebhookDelivery OrgsGetWebhookDelivery (string org, int? hookId, int? deliveryId);
        /// <summary>
        /// List organizations Lists all organizations, in the order that they were created on GitHub.  **Note:** Pagination is powered exclusively by the &#x60;since&#x60; parameter. Use the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header) to get the URL for the next page of organizations.
        /// </summary>
        /// <param name="since">An organization ID. Only return organizations with an ID greater than this ID.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <returns>List&lt;OrganizationSimple&gt;</returns>
        List<OrganizationSimple> OrgsList (int? since, int? perPage);
        /// <summary>
        /// List app installations for an organization Lists all GitHub Apps in an organization. The installation count includes all GitHub Apps installed on repositories in the organization. You must be an organization owner with &#x60;admin:read&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>OrgsListAppInstallations200Response</returns>
        OrgsListAppInstallations200Response OrgsListAppInstallations (string org, int? perPage, int? page);
        /// <summary>
        /// List users blocked by an organization List the users blocked by an organization.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        List<SimpleUser1> OrgsListBlockedUsers (string org);
        /// <summary>
        /// List custom repository roles in an organization List the custom repository roles available in this organization. In order to see custom repository roles in an organization, the authenticated user must be an organization owner.  For more information on custom repository roles, see \&quot;[Managing custom repository roles for an organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-custom-repository-roles-for-an-organization)\&quot;.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <returns>OrgsListCustomRoles200Response</returns>
        OrgsListCustomRoles200Response OrgsListCustomRoles (string organizationId);
        /// <summary>
        /// List failed organization invitations The return hash contains &#x60;failed_at&#x60; and &#x60;failed_reason&#x60; fields which represent the time at which the invitation failed and the reason for the failure.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;OrganizationInvitation&gt;</returns>
        List<OrganizationInvitation> OrgsListFailedInvitations (string org, int? perPage, int? page);
        /// <summary>
        /// List organizations for the authenticated user List organizations for the authenticated user.  **OAuth scope requirements**  This only lists organizations that your authorization allows you to operate on in some way (e.g., you can list teams with &#x60;read:org&#x60; scope, you can publicize your organization membership with &#x60;user&#x60; scope, etc.). Therefore, this API requires at least &#x60;user&#x60; or &#x60;read:org&#x60; scope. OAuth requests with insufficient scope receive a &#x60;403 Forbidden&#x60; response.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;OrganizationSimple&gt;</returns>
        List<OrganizationSimple> OrgsListForAuthenticatedUser (int? perPage, int? page);
        /// <summary>
        /// List organizations for a user List [public organization memberships](https://docs.github.com/articles/publicizing-or-concealing-organization-membership) for the specified user.  This method only lists _public_ memberships, regardless of authentication. If you need to fetch all of the organization memberships (public and private) for the authenticated user, use the [List organizations for the authenticated user](https://docs.github.com/rest/reference/orgs#list-organizations-for-the-authenticated-user) API instead.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;OrganizationSimple&gt;</returns>
        List<OrganizationSimple> OrgsListForUser (string username, int? perPage, int? page);
        /// <summary>
        /// List organization invitation teams List all teams associated with an invitation. In order to see invitations in an organization, the authenticated user must be an organization owner.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="invitationId">The unique identifier of the invitation.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Team&gt;</returns>
        List<Team> OrgsListInvitationTeams (string org, int? invitationId, int? perPage, int? page);
        /// <summary>
        /// List organization members List all users who are members of an organization. If the authenticated user is also a member of this organization then both concealed and public members will be returned.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="filter">Filter members returned in the list. &#x60;2fa_disabled&#x60; means that only members without [two-factor authentication](https://github.com/blog/1614-two-factor-authentication) enabled will be returned. This options is only available for organization owners.</param>
        /// <param name="role">Filter members returned by their role.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        List<SimpleUser1> OrgsListMembers (string org, string filter, string role, int? perPage, int? page);
        /// <summary>
        /// List organization memberships for the authenticated user 
        /// </summary>
        /// <param name="state">Indicates the state of the memberships to return. Can be either &#x60;active&#x60; or &#x60;pending&#x60;. If not specified, the API returns both active and pending memberships.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;OrgMembership&gt;</returns>
        List<OrgMembership> OrgsListMembershipsForAuthenticatedUser (string state, int? perPage, int? page);
        /// <summary>
        /// List outside collaborators for an organization List all users who are outside collaborators of an organization.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="filter">Filter the list of outside collaborators. &#x60;2fa_disabled&#x60; means that only outside collaborators without [two-factor authentication](https://github.com/blog/1614-two-factor-authentication) enabled will be returned.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        List<SimpleUser1> OrgsListOutsideCollaborators (string org, string filter, int? perPage, int? page);
        /// <summary>
        /// List pending organization invitations The return hash contains a &#x60;role&#x60; field which refers to the Organization Invitation role and will be one of the following values: &#x60;direct_member&#x60;, &#x60;admin&#x60;, &#x60;billing_manager&#x60;, &#x60;hiring_manager&#x60;, or &#x60;reinstate&#x60;. If the invitee is not a GitHub member, the &#x60;login&#x60; field in the return hash will be &#x60;null&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;OrganizationInvitation&gt;</returns>
        List<OrganizationInvitation> OrgsListPendingInvitations (string org, int? perPage, int? page);
        /// <summary>
        /// List public organization members Members of an organization can choose to have their membership publicized or not.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        List<SimpleUser1> OrgsListPublicMembers (string org, int? perPage, int? page);
        /// <summary>
        /// List SAML SSO authorizations for an organization Listing and deleting credential authorizations is available to organizations with GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).  An authenticated organization owner with the &#x60;read:org&#x60; scope can list all credential authorizations for an organization that uses SAML single sign-on (SSO). The credentials are either personal access tokens or SSH keys that organization members have authorized for the organization. For more information, see [About authentication with SAML single sign-on](https://docs.github.com/en/articles/about-authentication-with-saml-single-sign-on).
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page token</param>
        /// <param name="login">Limits the list of credentials authorizations for an organization to a specific login</param>
        /// <returns>List&lt;CredentialAuthorization&gt;</returns>
        List<CredentialAuthorization> OrgsListSamlSsoAuthorizations (string org, int? perPage, int? page, string login);
        /// <summary>
        /// List security manager teams Lists teams that are security managers for an organization. For more information, see \&quot;[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).\&quot;  To use this endpoint, you must be an administrator or security manager for the organization, and you must use an access token with the &#x60;read:org&#x60; scope.  GitHub Apps must have the &#x60;administration&#x60; organization read permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>List&lt;TeamSimple1&gt;</returns>
        List<TeamSimple1> OrgsListSecurityManagerTeams (string org);
        /// <summary>
        /// List deliveries for an organization webhook Returns a list of webhook deliveries for a webhook configured in an organization.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="cursor">Used for pagination: the starting delivery from which the page of deliveries is fetched. Refer to the &#x60;link&#x60; header for the next and previous page cursors.</param>
        /// <returns>List&lt;SimpleWebhookDelivery&gt;</returns>
        List<SimpleWebhookDelivery> OrgsListWebhookDeliveries (string org, int? hookId, int? perPage, string cursor);
        /// <summary>
        /// List organization webhooks 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;OrgHook&gt;</returns>
        List<OrgHook> OrgsListWebhooks (string org, int? perPage, int? page);
        /// <summary>
        /// Ping an organization webhook This will trigger a [ping event](https://docs.github.com/webhooks/#ping-event) to be sent to the hook.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <returns></returns>
        void OrgsPingWebhook (string org, int? hookId);
        /// <summary>
        /// Redeliver a delivery for an organization webhook Redeliver a delivery for a webhook configured in an organization.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <param name="deliveryId"></param>
        /// <returns>Object</returns>
        Object OrgsRedeliverWebhookDelivery (string org, int? hookId, int? deliveryId);
        /// <summary>
        /// Remove an organization member Removing a user from this list will remove them from all teams and they will no longer have any access to the organization&#39;s repositories.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        void OrgsRemoveMember (string org, string username);
        /// <summary>
        /// Remove organization membership for a user In order to remove a user&#39;s membership with an organization, the authenticated user must be an organization owner.  If the specified user is an active member of the organization, this will remove them from the organization. If the specified user has been invited to the organization, this will cancel their invitation. The specified user will receive an email notification in both cases.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        void OrgsRemoveMembershipForUser (string org, string username);
        /// <summary>
        /// Remove outside collaborator from an organization Removing a user from this list will remove them from all the organization&#39;s repositories.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        void OrgsRemoveOutsideCollaborator (string org, string username);
        /// <summary>
        /// Remove public organization membership for the authenticated user 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        void OrgsRemovePublicMembershipForAuthenticatedUser (string org, string username);
        /// <summary>
        /// Remove a SAML SSO authorization for an organization Listing and deleting credential authorizations is available to organizations with GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).  An authenticated organization owner with the &#x60;admin:org&#x60; scope can remove a credential authorization for an organization that uses SAML SSO. Once you remove someone&#39;s credential authorization, they will need to create a new personal access token or SSH key and authorize it for the organization they want to access.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="credentialId"></param>
        /// <returns></returns>
        void OrgsRemoveSamlSsoAuthorization (string org, int? credentialId);
        /// <summary>
        /// Remove a security manager team Removes the security manager role from a team for an organization. For more information, see \&quot;[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization) team from an organization.\&quot;  To use this endpoint, you must be an administrator for the organization, and you must use an access token with the &#x60;admin:org&#x60; scope.  GitHub Apps must have the &#x60;administration&#x60; organization read-write permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <returns></returns>
        void OrgsRemoveSecurityManagerTeam (string org, string teamSlug);
        /// <summary>
        /// Set organization membership for a user Only authenticated organization owners can add a member to the organization or update the member&#39;s role.  *   If the authenticated user is _adding_ a member to the organization, the invited user will receive an email inviting them to the organization. The user&#39;s [membership status](https://docs.github.com/rest/reference/orgs#get-organization-membership-for-a-user) will be &#x60;pending&#x60; until they accept the invitation.      *   Authenticated users can _update_ a user&#39;s membership by passing the &#x60;role&#x60; parameter. If the authenticated user changes a member&#39;s role to &#x60;admin&#x60;, the affected user will receive an email notifying them that they&#39;ve been made an organization owner. If the authenticated user changes an owner&#39;s role to &#x60;member&#x60;, no email will be sent.  **Rate limits**  To prevent abuse, the authenticated user is limited to 50 organization invitations per 24 hour period. If the organization is more than one month old or on a paid plan, the limit is 500 invitations per 24 hour period.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="orgsSetMembershipForUserRequest"></param>
        /// <returns>OrgMembership</returns>
        OrgMembership OrgsSetMembershipForUser (string org, string username, OrgsSetMembershipForUserRequest orgsSetMembershipForUserRequest);
        /// <summary>
        /// Set public organization membership for the authenticated user The user can publicize their own membership. (A user cannot publicize the membership for another user.)  Note that you&#39;ll need to set &#x60;Content-Length&#x60; to zero when calling out to this endpoint. For more information, see \&quot;[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\&quot;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        void OrgsSetPublicMembershipForAuthenticatedUser (string org, string username);
        /// <summary>
        /// Unblock a user from an organization 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        void OrgsUnblockUser (string org, string username);
        /// <summary>
        /// Update an organization **Parameter Deprecation Notice:** GitHub will replace and discontinue &#x60;members_allowed_repository_creation_type&#x60; in favor of more granular permissions. The new input parameters are &#x60;members_can_create_public_repositories&#x60;, &#x60;members_can_create_private_repositories&#x60; for all organizations and &#x60;members_can_create_internal_repositories&#x60; for organizations associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+. For more information, see the [blog post](https://developer.github.com/changes/2019-12-03-internal-visibility-changes).  Enables an authenticated organization owner with the &#x60;admin:org&#x60; scope to update the organization&#39;s profile and member privileges.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="orgsUpdateRequest"></param>
        /// <returns>OrganizationFull</returns>
        OrganizationFull OrgsUpdate (string org, OrgsUpdateRequest orgsUpdateRequest);
        /// <summary>
        /// Update an organization membership for the authenticated user 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="orgsUpdateMembershipForAuthenticatedUserRequest"></param>
        /// <returns>OrgMembership</returns>
        OrgMembership OrgsUpdateMembershipForAuthenticatedUser (string org, OrgsUpdateMembershipForAuthenticatedUserRequest orgsUpdateMembershipForAuthenticatedUserRequest);
        /// <summary>
        /// Update an organization webhook Updates a webhook configured in an organization. When you update a webhook, the &#x60;secret&#x60; will be overwritten. If you previously had a &#x60;secret&#x60; set, you must provide the same &#x60;secret&#x60; or set a new &#x60;secret&#x60; or the secret will be removed. If you are only updating individual webhook &#x60;config&#x60; properties, use \&quot;[Update a webhook configuration for an organization](/rest/reference/orgs#update-a-webhook-configuration-for-an-organization).\&quot;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <param name="orgsUpdateWebhookRequest"></param>
        /// <returns>OrgHook</returns>
        OrgHook OrgsUpdateWebhook (string org, int? hookId, OrgsUpdateWebhookRequest orgsUpdateWebhookRequest);
        /// <summary>
        /// Update a webhook configuration for an organization Updates the webhook configuration for an organization. To update more information about the webhook, including the &#x60;active&#x60; state and &#x60;events&#x60;, use \&quot;[Update an organization webhook ](/rest/reference/orgs#update-an-organization-webhook).\&quot;  Access tokens must have the &#x60;admin:org_hook&#x60; scope, and GitHub Apps must have the &#x60;organization_hooks:write&#x60; permission.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <param name="appsUpdateWebhookConfigForAppRequest"></param>
        /// <returns>WebhookConfiguration</returns>
        WebhookConfiguration OrgsUpdateWebhookConfigForOrg (string org, int? hookId, AppsUpdateWebhookConfigForAppRequest appsUpdateWebhookConfigForAppRequest);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrgsApi : IOrgsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OrgsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrgsApi(String basePath)
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
        /// Add a security manager team Adds a team as a security manager for an organization. For more information, see \&quot;[Managing security for an organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization) for an organization.\&quot;  To use this endpoint, you must be an administrator for the organization, and you must use an access token with the &#x60;write:org&#x60; scope.  GitHub Apps must have the &#x60;administration&#x60; organization read-write permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <returns></returns>
        public void OrgsAddSecurityManagerTeam (string org, string teamSlug)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsAddSecurityManagerTeam");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling OrgsAddSecurityManagerTeam");
            

            var path = "/orgs/{org}/security-managers/teams/{team_slug}";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsAddSecurityManagerTeam: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsAddSecurityManagerTeam: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Block a user from an organization 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        public void OrgsBlockUser (string org, string username)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsBlockUser");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling OrgsBlockUser");
            

            var path = "/orgs/{org}/blocks/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsBlockUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsBlockUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Cancel an organization invitation Cancel an organization invitation. In order to cancel an organization invitation, the authenticated user must be an organization owner.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications).
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="invitationId">The unique identifier of the invitation.</param>
        /// <returns></returns>
        public void OrgsCancelInvitation (string org, int? invitationId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsCancelInvitation");
            
            // verify the required parameter 'invitationId' is set
            if (invitationId == null) throw new ApiException(400, "Missing required parameter 'invitationId' when calling OrgsCancelInvitation");
            

            var path = "/orgs/{org}/invitations/{invitation_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "invitation_id" + "}", ApiClient.ParameterToString(invitationId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsCancelInvitation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsCancelInvitation: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Check if a user is blocked by an organization 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        public void OrgsCheckBlockedUser (string org, string username)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsCheckBlockedUser");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling OrgsCheckBlockedUser");
            

            var path = "/orgs/{org}/blocks/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsCheckBlockedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsCheckBlockedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Check organization membership for a user Check if a user is, publicly or privately, a member of the organization.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        public void OrgsCheckMembershipForUser (string org, string username)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsCheckMembershipForUser");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling OrgsCheckMembershipForUser");
            

            var path = "/orgs/{org}/members/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsCheckMembershipForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsCheckMembershipForUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Check public organization membership for a user 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        public void OrgsCheckPublicMembershipForUser (string org, string username)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsCheckPublicMembershipForUser");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling OrgsCheckPublicMembershipForUser");
            

            var path = "/orgs/{org}/public_members/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsCheckPublicMembershipForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsCheckPublicMembershipForUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Convert an organization member to outside collaborator When an organization member is converted to an outside collaborator, they&#39;ll only have access to the repositories that their current team membership allows. The user will no longer be a member of the organization. For more information, see \&quot;[Converting an organization member to an outside collaborator](https://docs.github.com/articles/converting-an-organization-member-to-an-outside-collaborator/)\&quot;. Converting an organization member to an outside collaborator may be restricted by enterprise administrators. For more information, see \&quot;[Enforcing repository management policies in your enterprise](https://docs.github.com/enterprise-cloud@latest/admin/policies/enforcing-policies-for-your-enterprise/enforcing-repository-management-policies-in-your-enterprise#enforcing-a-policy-for-inviting-outside-collaborators-to-repositories).\&quot;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="orgsConvertMemberToOutsideCollaboratorRequest"></param>
        /// <returns>Object</returns>
        public Object OrgsConvertMemberToOutsideCollaborator (string org, string username, OrgsConvertMemberToOutsideCollaboratorRequest orgsConvertMemberToOutsideCollaboratorRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsConvertMemberToOutsideCollaborator");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling OrgsConvertMemberToOutsideCollaborator");
            

            var path = "/orgs/{org}/outside_collaborators/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(orgsConvertMemberToOutsideCollaboratorRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsConvertMemberToOutsideCollaborator: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsConvertMemberToOutsideCollaborator: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Create an organization invitation Invite people to an organization by using their GitHub user ID or their email address. In order to create invitations in an organization, the authenticated user must be an organization owner.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="orgsCreateInvitationRequest"></param>
        /// <returns>OrganizationInvitation</returns>
        public OrganizationInvitation OrgsCreateInvitation (string org, OrgsCreateInvitationRequest orgsCreateInvitationRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsCreateInvitation");
            

            var path = "/orgs/{org}/invitations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(orgsCreateInvitationRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsCreateInvitation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsCreateInvitation: " + response.ErrorMessage, response.ErrorMessage);

            return (OrganizationInvitation) ApiClient.Deserialize(response.Content, typeof(OrganizationInvitation), response.Headers);
        }

        /// <summary>
        /// Create an organization webhook Here&#39;s how you can create a hook that posts payloads in JSON format:
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="orgsCreateWebhookRequest"></param>
        /// <returns>OrgHook</returns>
        public OrgHook OrgsCreateWebhook (string org, OrgsCreateWebhookRequest orgsCreateWebhookRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsCreateWebhook");
            
            // verify the required parameter 'orgsCreateWebhookRequest' is set
            if (orgsCreateWebhookRequest == null) throw new ApiException(400, "Missing required parameter 'orgsCreateWebhookRequest' when calling OrgsCreateWebhook");
            

            var path = "/orgs/{org}/hooks";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(orgsCreateWebhookRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsCreateWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsCreateWebhook: " + response.ErrorMessage, response.ErrorMessage);

            return (OrgHook) ApiClient.Deserialize(response.Content, typeof(OrgHook), response.Headers);
        }

        /// <summary>
        /// Delete an organization webhook 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <returns></returns>
        public void OrgsDeleteWebhook (string org, int? hookId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsDeleteWebhook");
            
            // verify the required parameter 'hookId' is set
            if (hookId == null) throw new ApiException(400, "Missing required parameter 'hookId' when calling OrgsDeleteWebhook");
            

            var path = "/orgs/{org}/hooks/{hook_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "hook_id" + "}", ApiClient.ParameterToString(hookId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsDeleteWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsDeleteWebhook: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get an organization To see many of the organization response values, you need to be an authenticated organization owner with the &#x60;admin:org&#x60; scope. When the value of &#x60;two_factor_requirement_enabled&#x60; is &#x60;true&#x60;, the organization requires all members, billing managers, and outside collaborators to enable [two-factor authentication](https://docs.github.com/articles/securing-your-account-with-two-factor-authentication-2fa/).  GitHub Apps with the &#x60;Organization plan&#x60; permission can use this endpoint to retrieve information about an organization&#39;s GitHub plan. See \&quot;[Authenticating with GitHub Apps](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/)\&quot; for details. For an example response, see &#39;Response with GitHub plan information&#39; below.\&quot;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>OrganizationFull</returns>
        public OrganizationFull OrgsGet (string org)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsGet");
            

            var path = "/orgs/{org}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsGet: " + response.ErrorMessage, response.ErrorMessage);

            return (OrganizationFull) ApiClient.Deserialize(response.Content, typeof(OrganizationFull), response.Headers);
        }

        /// <summary>
        /// Get the audit log for an organization Gets the audit log for an organization. For more information, see \&quot;[Reviewing the audit log for your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/reviewing-the-audit-log-for-your-organization).\&quot;  This endpoint is available for organizations on GitHub Enterprise Cloud. To use this endpoint, you must be an organization owner, and you must use an access token with the &#x60;admin:org&#x60; scope. GitHub Apps must have the &#x60;organization_administration&#x60; read permission to use this endpoint.  By default, the response includes up to 30 events from the past three months. Use the &#x60;phrase&#x60; parameter to filter results and retrieve older events. For example, use the &#x60;phrase&#x60; parameter with the &#x60;created&#x60; qualifier to filter events based on when the events occurred. For more information, see \&quot;[Reviewing the audit log for your organization](https://docs.github.com/organizations/keeping-your-organization-secure/managing-security-settings-for-your-organization/reviewing-the-audit-log-for-your-organization#searching-the-audit-log).\&quot;  Use pagination to retrieve fewer or more than 30 events. For more information, see \&quot;[Resources in the REST API](https://docs.github.com/rest/overview/resources-in-the-rest-api#pagination).\&quot;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="phrase">A search phrase. For more information, see [Searching the audit log](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/reviewing-the-audit-log-for-your-organization#searching-the-audit-log).</param>
        /// <param name="include">The event types to include:  - &#x60;web&#x60; - returns web (non-Git) events. - &#x60;git&#x60; - returns Git events. - &#x60;all&#x60; - returns both web and Git events.  The default is &#x60;web&#x60;.</param>
        /// <param name="after">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.</param>
        /// <param name="before">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor.</param>
        /// <param name="order">The order of audit log events. To list newest events first, specify &#x60;desc&#x60;. To list oldest events first, specify &#x60;asc&#x60;.  The default is &#x60;desc&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <returns>List&lt;EnterpriseAdminGetAuditLog200ResponseInner&gt;</returns>
        public List<EnterpriseAdminGetAuditLog200ResponseInner> OrgsGetAuditLog (string org, string phrase, string include, string after, string before, string order, int? perPage)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsGetAuditLog");
            

            var path = "/orgs/{org}/audit-log";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (phrase != null) queryParams.Add("phrase", ApiClient.ParameterToString(phrase)); // query parameter
 if (include != null) queryParams.Add("include", ApiClient.ParameterToString(include)); // query parameter
 if (after != null) queryParams.Add("after", ApiClient.ParameterToString(after)); // query parameter
 if (before != null) queryParams.Add("before", ApiClient.ParameterToString(before)); // query parameter
 if (order != null) queryParams.Add("order", ApiClient.ParameterToString(order)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsGetAuditLog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsGetAuditLog: " + response.ErrorMessage, response.ErrorMessage);

            return (List<EnterpriseAdminGetAuditLog200ResponseInner>) ApiClient.Deserialize(response.Content, typeof(List<EnterpriseAdminGetAuditLog200ResponseInner>), response.Headers);
        }

        /// <summary>
        /// Get an organization membership for the authenticated user 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>OrgMembership</returns>
        public OrgMembership OrgsGetMembershipForAuthenticatedUser (string org)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsGetMembershipForAuthenticatedUser");
            

            var path = "/user/memberships/orgs/{org}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsGetMembershipForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsGetMembershipForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (OrgMembership) ApiClient.Deserialize(response.Content, typeof(OrgMembership), response.Headers);
        }

        /// <summary>
        /// Get organization membership for a user In order to get a user&#39;s membership with an organization, the authenticated user must be an organization member. The &#x60;state&#x60; parameter in the response can be used to identify the user&#39;s membership status.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>OrgMembership</returns>
        public OrgMembership OrgsGetMembershipForUser (string org, string username)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsGetMembershipForUser");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling OrgsGetMembershipForUser");
            

            var path = "/orgs/{org}/memberships/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsGetMembershipForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsGetMembershipForUser: " + response.ErrorMessage, response.ErrorMessage);

            return (OrgMembership) ApiClient.Deserialize(response.Content, typeof(OrgMembership), response.Headers);
        }

        /// <summary>
        /// Get an organization webhook Returns a webhook configured in an organization. To get only the webhook &#x60;config&#x60; properties, see \&quot;[Get a webhook configuration for an organization](/rest/reference/orgs#get-a-webhook-configuration-for-an-organization).\&quot;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <returns>OrgHook</returns>
        public OrgHook OrgsGetWebhook (string org, int? hookId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsGetWebhook");
            
            // verify the required parameter 'hookId' is set
            if (hookId == null) throw new ApiException(400, "Missing required parameter 'hookId' when calling OrgsGetWebhook");
            

            var path = "/orgs/{org}/hooks/{hook_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "hook_id" + "}", ApiClient.ParameterToString(hookId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsGetWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsGetWebhook: " + response.ErrorMessage, response.ErrorMessage);

            return (OrgHook) ApiClient.Deserialize(response.Content, typeof(OrgHook), response.Headers);
        }

        /// <summary>
        /// Get a webhook configuration for an organization Returns the webhook configuration for an organization. To get more information about the webhook, including the &#x60;active&#x60; state and &#x60;events&#x60;, use \&quot;[Get an organization webhook ](/rest/reference/orgs#get-an-organization-webhook).\&quot;  Access tokens must have the &#x60;admin:org_hook&#x60; scope, and GitHub Apps must have the &#x60;organization_hooks:read&#x60; permission.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <returns>WebhookConfiguration</returns>
        public WebhookConfiguration OrgsGetWebhookConfigForOrg (string org, int? hookId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsGetWebhookConfigForOrg");
            
            // verify the required parameter 'hookId' is set
            if (hookId == null) throw new ApiException(400, "Missing required parameter 'hookId' when calling OrgsGetWebhookConfigForOrg");
            

            var path = "/orgs/{org}/hooks/{hook_id}/config";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "hook_id" + "}", ApiClient.ParameterToString(hookId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsGetWebhookConfigForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsGetWebhookConfigForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (WebhookConfiguration) ApiClient.Deserialize(response.Content, typeof(WebhookConfiguration), response.Headers);
        }

        /// <summary>
        /// Get a webhook delivery for an organization webhook Returns a delivery for a webhook configured in an organization.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <param name="deliveryId"></param>
        /// <returns>WebhookDelivery</returns>
        public WebhookDelivery OrgsGetWebhookDelivery (string org, int? hookId, int? deliveryId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsGetWebhookDelivery");
            
            // verify the required parameter 'hookId' is set
            if (hookId == null) throw new ApiException(400, "Missing required parameter 'hookId' when calling OrgsGetWebhookDelivery");
            
            // verify the required parameter 'deliveryId' is set
            if (deliveryId == null) throw new ApiException(400, "Missing required parameter 'deliveryId' when calling OrgsGetWebhookDelivery");
            

            var path = "/orgs/{org}/hooks/{hook_id}/deliveries/{delivery_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "hook_id" + "}", ApiClient.ParameterToString(hookId));
path = path.Replace("{" + "delivery_id" + "}", ApiClient.ParameterToString(deliveryId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsGetWebhookDelivery: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsGetWebhookDelivery: " + response.ErrorMessage, response.ErrorMessage);

            return (WebhookDelivery) ApiClient.Deserialize(response.Content, typeof(WebhookDelivery), response.Headers);
        }

        /// <summary>
        /// List organizations Lists all organizations, in the order that they were created on GitHub.  **Note:** Pagination is powered exclusively by the &#x60;since&#x60; parameter. Use the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header) to get the URL for the next page of organizations.
        /// </summary>
        /// <param name="since">An organization ID. Only return organizations with an ID greater than this ID.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <returns>List&lt;OrganizationSimple&gt;</returns>
        public List<OrganizationSimple> OrgsList (int? since, int? perPage)
        {
            

            var path = "/organizations";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsList: " + response.ErrorMessage, response.ErrorMessage);

            return (List<OrganizationSimple>) ApiClient.Deserialize(response.Content, typeof(List<OrganizationSimple>), response.Headers);
        }

        /// <summary>
        /// List app installations for an organization Lists all GitHub Apps in an organization. The installation count includes all GitHub Apps installed on repositories in the organization. You must be an organization owner with &#x60;admin:read&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>OrgsListAppInstallations200Response</returns>
        public OrgsListAppInstallations200Response OrgsListAppInstallations (string org, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsListAppInstallations");
            

            var path = "/orgs/{org}/installations";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListAppInstallations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListAppInstallations: " + response.ErrorMessage, response.ErrorMessage);

            return (OrgsListAppInstallations200Response) ApiClient.Deserialize(response.Content, typeof(OrgsListAppInstallations200Response), response.Headers);
        }

        /// <summary>
        /// List users blocked by an organization List the users blocked by an organization.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        public List<SimpleUser1> OrgsListBlockedUsers (string org)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsListBlockedUsers");
            

            var path = "/orgs/{org}/blocks";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListBlockedUsers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListBlockedUsers: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SimpleUser1>) ApiClient.Deserialize(response.Content, typeof(List<SimpleUser1>), response.Headers);
        }

        /// <summary>
        /// List custom repository roles in an organization List the custom repository roles available in this organization. In order to see custom repository roles in an organization, the authenticated user must be an organization owner.  For more information on custom repository roles, see \&quot;[Managing custom repository roles for an organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-custom-repository-roles-for-an-organization)\&quot;.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <returns>OrgsListCustomRoles200Response</returns>
        public OrgsListCustomRoles200Response OrgsListCustomRoles (string organizationId)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling OrgsListCustomRoles");
            

            var path = "/organizations/{organization_id}/custom_roles";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organization_id" + "}", ApiClient.ParameterToString(organizationId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListCustomRoles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListCustomRoles: " + response.ErrorMessage, response.ErrorMessage);

            return (OrgsListCustomRoles200Response) ApiClient.Deserialize(response.Content, typeof(OrgsListCustomRoles200Response), response.Headers);
        }

        /// <summary>
        /// List failed organization invitations The return hash contains &#x60;failed_at&#x60; and &#x60;failed_reason&#x60; fields which represent the time at which the invitation failed and the reason for the failure.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;OrganizationInvitation&gt;</returns>
        public List<OrganizationInvitation> OrgsListFailedInvitations (string org, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsListFailedInvitations");
            

            var path = "/orgs/{org}/failed_invitations";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListFailedInvitations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListFailedInvitations: " + response.ErrorMessage, response.ErrorMessage);

            return (List<OrganizationInvitation>) ApiClient.Deserialize(response.Content, typeof(List<OrganizationInvitation>), response.Headers);
        }

        /// <summary>
        /// List organizations for the authenticated user List organizations for the authenticated user.  **OAuth scope requirements**  This only lists organizations that your authorization allows you to operate on in some way (e.g., you can list teams with &#x60;read:org&#x60; scope, you can publicize your organization membership with &#x60;user&#x60; scope, etc.). Therefore, this API requires at least &#x60;user&#x60; or &#x60;read:org&#x60; scope. OAuth requests with insufficient scope receive a &#x60;403 Forbidden&#x60; response.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;OrganizationSimple&gt;</returns>
        public List<OrganizationSimple> OrgsListForAuthenticatedUser (int? perPage, int? page)
        {
            

            var path = "/user/orgs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<OrganizationSimple>) ApiClient.Deserialize(response.Content, typeof(List<OrganizationSimple>), response.Headers);
        }

        /// <summary>
        /// List organizations for a user List [public organization memberships](https://docs.github.com/articles/publicizing-or-concealing-organization-membership) for the specified user.  This method only lists _public_ memberships, regardless of authentication. If you need to fetch all of the organization memberships (public and private) for the authenticated user, use the [List organizations for the authenticated user](https://docs.github.com/rest/reference/orgs#list-organizations-for-the-authenticated-user) API instead.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;OrganizationSimple&gt;</returns>
        public List<OrganizationSimple> OrgsListForUser (string username, int? perPage, int? page)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling OrgsListForUser");
            

            var path = "/users/{username}/orgs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListForUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<OrganizationSimple>) ApiClient.Deserialize(response.Content, typeof(List<OrganizationSimple>), response.Headers);
        }

        /// <summary>
        /// List organization invitation teams List all teams associated with an invitation. In order to see invitations in an organization, the authenticated user must be an organization owner.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="invitationId">The unique identifier of the invitation.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Team&gt;</returns>
        public List<Team> OrgsListInvitationTeams (string org, int? invitationId, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsListInvitationTeams");
            
            // verify the required parameter 'invitationId' is set
            if (invitationId == null) throw new ApiException(400, "Missing required parameter 'invitationId' when calling OrgsListInvitationTeams");
            

            var path = "/orgs/{org}/invitations/{invitation_id}/teams";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "invitation_id" + "}", ApiClient.ParameterToString(invitationId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListInvitationTeams: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListInvitationTeams: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Team>) ApiClient.Deserialize(response.Content, typeof(List<Team>), response.Headers);
        }

        /// <summary>
        /// List organization members List all users who are members of an organization. If the authenticated user is also a member of this organization then both concealed and public members will be returned.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="filter">Filter members returned in the list. &#x60;2fa_disabled&#x60; means that only members without [two-factor authentication](https://github.com/blog/1614-two-factor-authentication) enabled will be returned. This options is only available for organization owners.</param>
        /// <param name="role">Filter members returned by their role.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        public List<SimpleUser1> OrgsListMembers (string org, string filter, string role, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsListMembers");
            

            var path = "/orgs/{org}/members";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (role != null) queryParams.Add("role", ApiClient.ParameterToString(role)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListMembers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListMembers: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SimpleUser1>) ApiClient.Deserialize(response.Content, typeof(List<SimpleUser1>), response.Headers);
        }

        /// <summary>
        /// List organization memberships for the authenticated user 
        /// </summary>
        /// <param name="state">Indicates the state of the memberships to return. Can be either &#x60;active&#x60; or &#x60;pending&#x60;. If not specified, the API returns both active and pending memberships.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;OrgMembership&gt;</returns>
        public List<OrgMembership> OrgsListMembershipsForAuthenticatedUser (string state, int? perPage, int? page)
        {
            

            var path = "/user/memberships/orgs";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListMembershipsForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListMembershipsForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<OrgMembership>) ApiClient.Deserialize(response.Content, typeof(List<OrgMembership>), response.Headers);
        }

        /// <summary>
        /// List outside collaborators for an organization List all users who are outside collaborators of an organization.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="filter">Filter the list of outside collaborators. &#x60;2fa_disabled&#x60; means that only outside collaborators without [two-factor authentication](https://github.com/blog/1614-two-factor-authentication) enabled will be returned.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        public List<SimpleUser1> OrgsListOutsideCollaborators (string org, string filter, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsListOutsideCollaborators");
            

            var path = "/orgs/{org}/outside_collaborators";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListOutsideCollaborators: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListOutsideCollaborators: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SimpleUser1>) ApiClient.Deserialize(response.Content, typeof(List<SimpleUser1>), response.Headers);
        }

        /// <summary>
        /// List pending organization invitations The return hash contains a &#x60;role&#x60; field which refers to the Organization Invitation role and will be one of the following values: &#x60;direct_member&#x60;, &#x60;admin&#x60;, &#x60;billing_manager&#x60;, &#x60;hiring_manager&#x60;, or &#x60;reinstate&#x60;. If the invitee is not a GitHub member, the &#x60;login&#x60; field in the return hash will be &#x60;null&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;OrganizationInvitation&gt;</returns>
        public List<OrganizationInvitation> OrgsListPendingInvitations (string org, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsListPendingInvitations");
            

            var path = "/orgs/{org}/invitations";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListPendingInvitations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListPendingInvitations: " + response.ErrorMessage, response.ErrorMessage);

            return (List<OrganizationInvitation>) ApiClient.Deserialize(response.Content, typeof(List<OrganizationInvitation>), response.Headers);
        }

        /// <summary>
        /// List public organization members Members of an organization can choose to have their membership publicized or not.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        public List<SimpleUser1> OrgsListPublicMembers (string org, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsListPublicMembers");
            

            var path = "/orgs/{org}/public_members";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListPublicMembers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListPublicMembers: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SimpleUser1>) ApiClient.Deserialize(response.Content, typeof(List<SimpleUser1>), response.Headers);
        }

        /// <summary>
        /// List SAML SSO authorizations for an organization Listing and deleting credential authorizations is available to organizations with GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).  An authenticated organization owner with the &#x60;read:org&#x60; scope can list all credential authorizations for an organization that uses SAML single sign-on (SSO). The credentials are either personal access tokens or SSH keys that organization members have authorized for the organization. For more information, see [About authentication with SAML single sign-on](https://docs.github.com/en/articles/about-authentication-with-saml-single-sign-on).
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page token</param>
        /// <param name="login">Limits the list of credentials authorizations for an organization to a specific login</param>
        /// <returns>List&lt;CredentialAuthorization&gt;</returns>
        public List<CredentialAuthorization> OrgsListSamlSsoAuthorizations (string org, int? perPage, int? page, string login)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsListSamlSsoAuthorizations");
            

            var path = "/orgs/{org}/credential-authorizations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (login != null) queryParams.Add("login", ApiClient.ParameterToString(login)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListSamlSsoAuthorizations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListSamlSsoAuthorizations: " + response.ErrorMessage, response.ErrorMessage);

            return (List<CredentialAuthorization>) ApiClient.Deserialize(response.Content, typeof(List<CredentialAuthorization>), response.Headers);
        }

        /// <summary>
        /// List security manager teams Lists teams that are security managers for an organization. For more information, see \&quot;[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).\&quot;  To use this endpoint, you must be an administrator or security manager for the organization, and you must use an access token with the &#x60;read:org&#x60; scope.  GitHub Apps must have the &#x60;administration&#x60; organization read permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>List&lt;TeamSimple1&gt;</returns>
        public List<TeamSimple1> OrgsListSecurityManagerTeams (string org)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsListSecurityManagerTeams");
            

            var path = "/orgs/{org}/security-managers";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListSecurityManagerTeams: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListSecurityManagerTeams: " + response.ErrorMessage, response.ErrorMessage);

            return (List<TeamSimple1>) ApiClient.Deserialize(response.Content, typeof(List<TeamSimple1>), response.Headers);
        }

        /// <summary>
        /// List deliveries for an organization webhook Returns a list of webhook deliveries for a webhook configured in an organization.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="cursor">Used for pagination: the starting delivery from which the page of deliveries is fetched. Refer to the &#x60;link&#x60; header for the next and previous page cursors.</param>
        /// <returns>List&lt;SimpleWebhookDelivery&gt;</returns>
        public List<SimpleWebhookDelivery> OrgsListWebhookDeliveries (string org, int? hookId, int? perPage, string cursor)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsListWebhookDeliveries");
            
            // verify the required parameter 'hookId' is set
            if (hookId == null) throw new ApiException(400, "Missing required parameter 'hookId' when calling OrgsListWebhookDeliveries");
            

            var path = "/orgs/{org}/hooks/{hook_id}/deliveries";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "hook_id" + "}", ApiClient.ParameterToString(hookId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (cursor != null) queryParams.Add("cursor", ApiClient.ParameterToString(cursor)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListWebhookDeliveries: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListWebhookDeliveries: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SimpleWebhookDelivery>) ApiClient.Deserialize(response.Content, typeof(List<SimpleWebhookDelivery>), response.Headers);
        }

        /// <summary>
        /// List organization webhooks 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;OrgHook&gt;</returns>
        public List<OrgHook> OrgsListWebhooks (string org, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsListWebhooks");
            

            var path = "/orgs/{org}/hooks";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListWebhooks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsListWebhooks: " + response.ErrorMessage, response.ErrorMessage);

            return (List<OrgHook>) ApiClient.Deserialize(response.Content, typeof(List<OrgHook>), response.Headers);
        }

        /// <summary>
        /// Ping an organization webhook This will trigger a [ping event](https://docs.github.com/webhooks/#ping-event) to be sent to the hook.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <returns></returns>
        public void OrgsPingWebhook (string org, int? hookId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsPingWebhook");
            
            // verify the required parameter 'hookId' is set
            if (hookId == null) throw new ApiException(400, "Missing required parameter 'hookId' when calling OrgsPingWebhook");
            

            var path = "/orgs/{org}/hooks/{hook_id}/pings";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "hook_id" + "}", ApiClient.ParameterToString(hookId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsPingWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsPingWebhook: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Redeliver a delivery for an organization webhook Redeliver a delivery for a webhook configured in an organization.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <param name="deliveryId"></param>
        /// <returns>Object</returns>
        public Object OrgsRedeliverWebhookDelivery (string org, int? hookId, int? deliveryId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsRedeliverWebhookDelivery");
            
            // verify the required parameter 'hookId' is set
            if (hookId == null) throw new ApiException(400, "Missing required parameter 'hookId' when calling OrgsRedeliverWebhookDelivery");
            
            // verify the required parameter 'deliveryId' is set
            if (deliveryId == null) throw new ApiException(400, "Missing required parameter 'deliveryId' when calling OrgsRedeliverWebhookDelivery");
            

            var path = "/orgs/{org}/hooks/{hook_id}/deliveries/{delivery_id}/attempts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "hook_id" + "}", ApiClient.ParameterToString(hookId));
path = path.Replace("{" + "delivery_id" + "}", ApiClient.ParameterToString(deliveryId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsRedeliverWebhookDelivery: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsRedeliverWebhookDelivery: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Remove an organization member Removing a user from this list will remove them from all teams and they will no longer have any access to the organization&#39;s repositories.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        public void OrgsRemoveMember (string org, string username)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsRemoveMember");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling OrgsRemoveMember");
            

            var path = "/orgs/{org}/members/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsRemoveMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsRemoveMember: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Remove organization membership for a user In order to remove a user&#39;s membership with an organization, the authenticated user must be an organization owner.  If the specified user is an active member of the organization, this will remove them from the organization. If the specified user has been invited to the organization, this will cancel their invitation. The specified user will receive an email notification in both cases.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        public void OrgsRemoveMembershipForUser (string org, string username)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsRemoveMembershipForUser");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling OrgsRemoveMembershipForUser");
            

            var path = "/orgs/{org}/memberships/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsRemoveMembershipForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsRemoveMembershipForUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Remove outside collaborator from an organization Removing a user from this list will remove them from all the organization&#39;s repositories.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        public void OrgsRemoveOutsideCollaborator (string org, string username)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsRemoveOutsideCollaborator");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling OrgsRemoveOutsideCollaborator");
            

            var path = "/orgs/{org}/outside_collaborators/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsRemoveOutsideCollaborator: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsRemoveOutsideCollaborator: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Remove public organization membership for the authenticated user 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        public void OrgsRemovePublicMembershipForAuthenticatedUser (string org, string username)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsRemovePublicMembershipForAuthenticatedUser");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling OrgsRemovePublicMembershipForAuthenticatedUser");
            

            var path = "/orgs/{org}/public_members/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsRemovePublicMembershipForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsRemovePublicMembershipForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Remove a SAML SSO authorization for an organization Listing and deleting credential authorizations is available to organizations with GitHub Enterprise Cloud. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).  An authenticated organization owner with the &#x60;admin:org&#x60; scope can remove a credential authorization for an organization that uses SAML SSO. Once you remove someone&#39;s credential authorization, they will need to create a new personal access token or SSH key and authorize it for the organization they want to access.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="credentialId"></param>
        /// <returns></returns>
        public void OrgsRemoveSamlSsoAuthorization (string org, int? credentialId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsRemoveSamlSsoAuthorization");
            
            // verify the required parameter 'credentialId' is set
            if (credentialId == null) throw new ApiException(400, "Missing required parameter 'credentialId' when calling OrgsRemoveSamlSsoAuthorization");
            

            var path = "/orgs/{org}/credential-authorizations/{credential_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "credential_id" + "}", ApiClient.ParameterToString(credentialId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsRemoveSamlSsoAuthorization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsRemoveSamlSsoAuthorization: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Remove a security manager team Removes the security manager role from a team for an organization. For more information, see \&quot;[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization) team from an organization.\&quot;  To use this endpoint, you must be an administrator for the organization, and you must use an access token with the &#x60;admin:org&#x60; scope.  GitHub Apps must have the &#x60;administration&#x60; organization read-write permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="teamSlug">The slug of the team name.</param>
        /// <returns></returns>
        public void OrgsRemoveSecurityManagerTeam (string org, string teamSlug)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsRemoveSecurityManagerTeam");
            
            // verify the required parameter 'teamSlug' is set
            if (teamSlug == null) throw new ApiException(400, "Missing required parameter 'teamSlug' when calling OrgsRemoveSecurityManagerTeam");
            

            var path = "/orgs/{org}/security-managers/teams/{team_slug}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsRemoveSecurityManagerTeam: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsRemoveSecurityManagerTeam: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Set organization membership for a user Only authenticated organization owners can add a member to the organization or update the member&#39;s role.  *   If the authenticated user is _adding_ a member to the organization, the invited user will receive an email inviting them to the organization. The user&#39;s [membership status](https://docs.github.com/rest/reference/orgs#get-organization-membership-for-a-user) will be &#x60;pending&#x60; until they accept the invitation.      *   Authenticated users can _update_ a user&#39;s membership by passing the &#x60;role&#x60; parameter. If the authenticated user changes a member&#39;s role to &#x60;admin&#x60;, the affected user will receive an email notifying them that they&#39;ve been made an organization owner. If the authenticated user changes an owner&#39;s role to &#x60;member&#x60;, no email will be sent.  **Rate limits**  To prevent abuse, the authenticated user is limited to 50 organization invitations per 24 hour period. If the organization is more than one month old or on a paid plan, the limit is 500 invitations per 24 hour period.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="orgsSetMembershipForUserRequest"></param>
        /// <returns>OrgMembership</returns>
        public OrgMembership OrgsSetMembershipForUser (string org, string username, OrgsSetMembershipForUserRequest orgsSetMembershipForUserRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsSetMembershipForUser");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling OrgsSetMembershipForUser");
            

            var path = "/orgs/{org}/memberships/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(orgsSetMembershipForUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsSetMembershipForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsSetMembershipForUser: " + response.ErrorMessage, response.ErrorMessage);

            return (OrgMembership) ApiClient.Deserialize(response.Content, typeof(OrgMembership), response.Headers);
        }

        /// <summary>
        /// Set public organization membership for the authenticated user The user can publicize their own membership. (A user cannot publicize the membership for another user.)  Note that you&#39;ll need to set &#x60;Content-Length&#x60; to zero when calling out to this endpoint. For more information, see \&quot;[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\&quot;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        public void OrgsSetPublicMembershipForAuthenticatedUser (string org, string username)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsSetPublicMembershipForAuthenticatedUser");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling OrgsSetPublicMembershipForAuthenticatedUser");
            

            var path = "/orgs/{org}/public_members/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsSetPublicMembershipForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsSetPublicMembershipForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Unblock a user from an organization 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        public void OrgsUnblockUser (string org, string username)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsUnblockUser");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling OrgsUnblockUser");
            

            var path = "/orgs/{org}/blocks/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
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
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsUnblockUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsUnblockUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Update an organization **Parameter Deprecation Notice:** GitHub will replace and discontinue &#x60;members_allowed_repository_creation_type&#x60; in favor of more granular permissions. The new input parameters are &#x60;members_can_create_public_repositories&#x60;, &#x60;members_can_create_private_repositories&#x60; for all organizations and &#x60;members_can_create_internal_repositories&#x60; for organizations associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+. For more information, see the [blog post](https://developer.github.com/changes/2019-12-03-internal-visibility-changes).  Enables an authenticated organization owner with the &#x60;admin:org&#x60; scope to update the organization&#39;s profile and member privileges.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="orgsUpdateRequest"></param>
        /// <returns>OrganizationFull</returns>
        public OrganizationFull OrgsUpdate (string org, OrgsUpdateRequest orgsUpdateRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsUpdate");
            

            var path = "/orgs/{org}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(orgsUpdateRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsUpdate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsUpdate: " + response.ErrorMessage, response.ErrorMessage);

            return (OrganizationFull) ApiClient.Deserialize(response.Content, typeof(OrganizationFull), response.Headers);
        }

        /// <summary>
        /// Update an organization membership for the authenticated user 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="orgsUpdateMembershipForAuthenticatedUserRequest"></param>
        /// <returns>OrgMembership</returns>
        public OrgMembership OrgsUpdateMembershipForAuthenticatedUser (string org, OrgsUpdateMembershipForAuthenticatedUserRequest orgsUpdateMembershipForAuthenticatedUserRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsUpdateMembershipForAuthenticatedUser");
            
            // verify the required parameter 'orgsUpdateMembershipForAuthenticatedUserRequest' is set
            if (orgsUpdateMembershipForAuthenticatedUserRequest == null) throw new ApiException(400, "Missing required parameter 'orgsUpdateMembershipForAuthenticatedUserRequest' when calling OrgsUpdateMembershipForAuthenticatedUser");
            

            var path = "/user/memberships/orgs/{org}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(orgsUpdateMembershipForAuthenticatedUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsUpdateMembershipForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsUpdateMembershipForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (OrgMembership) ApiClient.Deserialize(response.Content, typeof(OrgMembership), response.Headers);
        }

        /// <summary>
        /// Update an organization webhook Updates a webhook configured in an organization. When you update a webhook, the &#x60;secret&#x60; will be overwritten. If you previously had a &#x60;secret&#x60; set, you must provide the same &#x60;secret&#x60; or set a new &#x60;secret&#x60; or the secret will be removed. If you are only updating individual webhook &#x60;config&#x60; properties, use \&quot;[Update a webhook configuration for an organization](/rest/reference/orgs#update-a-webhook-configuration-for-an-organization).\&quot;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <param name="orgsUpdateWebhookRequest"></param>
        /// <returns>OrgHook</returns>
        public OrgHook OrgsUpdateWebhook (string org, int? hookId, OrgsUpdateWebhookRequest orgsUpdateWebhookRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsUpdateWebhook");
            
            // verify the required parameter 'hookId' is set
            if (hookId == null) throw new ApiException(400, "Missing required parameter 'hookId' when calling OrgsUpdateWebhook");
            

            var path = "/orgs/{org}/hooks/{hook_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "hook_id" + "}", ApiClient.ParameterToString(hookId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(orgsUpdateWebhookRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsUpdateWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsUpdateWebhook: " + response.ErrorMessage, response.ErrorMessage);

            return (OrgHook) ApiClient.Deserialize(response.Content, typeof(OrgHook), response.Headers);
        }

        /// <summary>
        /// Update a webhook configuration for an organization Updates the webhook configuration for an organization. To update more information about the webhook, including the &#x60;active&#x60; state and &#x60;events&#x60;, use \&quot;[Update an organization webhook ](/rest/reference/orgs#update-an-organization-webhook).\&quot;  Access tokens must have the &#x60;admin:org_hook&#x60; scope, and GitHub Apps must have the &#x60;organization_hooks:write&#x60; permission.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <param name="appsUpdateWebhookConfigForAppRequest"></param>
        /// <returns>WebhookConfiguration</returns>
        public WebhookConfiguration OrgsUpdateWebhookConfigForOrg (string org, int? hookId, AppsUpdateWebhookConfigForAppRequest appsUpdateWebhookConfigForAppRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OrgsUpdateWebhookConfigForOrg");
            
            // verify the required parameter 'hookId' is set
            if (hookId == null) throw new ApiException(400, "Missing required parameter 'hookId' when calling OrgsUpdateWebhookConfigForOrg");
            

            var path = "/orgs/{org}/hooks/{hook_id}/config";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "hook_id" + "}", ApiClient.ParameterToString(hookId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(appsUpdateWebhookConfigForAppRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsUpdateWebhookConfigForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OrgsUpdateWebhookConfigForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (WebhookConfiguration) ApiClient.Deserialize(response.Content, typeof(WebhookConfiguration), response.Headers);
        }

    }
}
