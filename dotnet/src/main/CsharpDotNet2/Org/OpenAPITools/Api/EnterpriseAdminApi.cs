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
    public interface IEnterpriseAdminApi
    {
        /// <summary>
        /// Add custom labels to a self-hosted runner for an enterprise Add custom labels to a self-hosted runner configured in an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <param name="enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest"></param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterprise (string enterprise, int? runnerId, EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest);
        /// <summary>
        /// Add organization access to a self-hosted runner group in an enterprise Adds an organization to the list of selected organizations that can access a self-hosted runner group. The runner group must have &#x60;visibility&#x60; set to &#x60;selected&#x60;. For more information, see \&quot;[Create a self-hosted runner group for an enterprise](#create-a-self-hosted-runner-group-for-an-enterprise).\&quot;  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="orgId">The unique identifier of the organization.</param>
        /// <returns></returns>
        void EnterpriseAdminAddOrgAccessToSelfHostedRunnerGroupInEnterprise (string enterprise, int? runnerGroupId, int? orgId);
        /// <summary>
        /// Add a self-hosted runner to a group for an enterprise Adds a self-hosted runner to a runner group configured in an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns></returns>
        void EnterpriseAdminAddSelfHostedRunnerToGroupForEnterprise (string enterprise, int? runnerGroupId, int? runnerId);
        /// <summary>
        /// Create a registration token for an enterprise Returns a token that you can pass to the &#x60;config&#x60; script. The token expires after one hour.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.  #### Example using registration token  Configure your self-hosted runner, replacing &#x60;TOKEN&#x60; with the registration token provided by this endpoint.  &#x60;&#x60;&#x60; ./config.sh - -url https://github.com/enterprises/octo-enterprise - -token TOKEN &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <returns>AuthenticationToken</returns>
        AuthenticationToken EnterpriseAdminCreateRegistrationTokenForEnterprise (string enterprise);
        /// <summary>
        /// Create a remove token for an enterprise Returns a token that you can pass to the &#x60;config&#x60; script to remove a self-hosted runner from an enterprise. The token expires after one hour.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.  #### Example using remove token  To remove your self-hosted runner from an enterprise, replace &#x60;TOKEN&#x60; with the remove token provided by this endpoint.  &#x60;&#x60;&#x60; ./config.sh remove - -token TOKEN &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <returns>AuthenticationToken</returns>
        AuthenticationToken EnterpriseAdminCreateRemoveTokenForEnterprise (string enterprise);
        /// <summary>
        /// Create a self-hosted runner group for an enterprise Creates a new self-hosted runner group for an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="enterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest"></param>
        /// <returns>EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner</returns>
        EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner EnterpriseAdminCreateSelfHostedRunnerGroupForEnterprise (string enterprise, EnterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest enterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest);
        /// <summary>
        /// Delete a SCIM group from an enterprise **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="scimGroupId">Identifier generated by the GitHub SCIM endpoint.</param>
        /// <returns></returns>
        void EnterpriseAdminDeleteScimGroupFromEnterprise (string enterprise, string scimGroupId);
        /// <summary>
        /// Delete a self-hosted runner from an enterprise Forces the removal of a self-hosted runner from an enterprise. You can use this endpoint to completely remove the runner when the machine you were using no longer exists.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns></returns>
        void EnterpriseAdminDeleteSelfHostedRunnerFromEnterprise (string enterprise, int? runnerId);
        /// <summary>
        /// Delete a self-hosted runner group from an enterprise Deletes a self-hosted runner group for an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <returns></returns>
        void EnterpriseAdminDeleteSelfHostedRunnerGroupFromEnterprise (string enterprise, int? runnerGroupId);
        /// <summary>
        /// Delete a SCIM user from an enterprise **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="scimUserId">The unique identifier of the SCIM user.</param>
        /// <returns></returns>
        void EnterpriseAdminDeleteUserFromEnterprise (string enterprise, string scimUserId);
        /// <summary>
        /// Disable a selected organization for GitHub Actions in an enterprise Removes an organization from the list of selected organizations that are enabled for GitHub Actions in an enterprise. To use this endpoint, the enterprise permission policy for &#x60;enabled_organizations&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\&quot;  You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="orgId">The unique identifier of the organization.</param>
        /// <returns></returns>
        void EnterpriseAdminDisableSelectedOrganizationGithubActionsEnterprise (string enterprise, int? orgId);
        /// <summary>
        /// Enable a selected organization for GitHub Actions in an enterprise Adds an organization to the list of selected organizations that are enabled for GitHub Actions in an enterprise. To use this endpoint, the enterprise permission policy for &#x60;enabled_organizations&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\&quot;  You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="orgId">The unique identifier of the organization.</param>
        /// <returns></returns>
        void EnterpriseAdminEnableSelectedOrganizationGithubActionsEnterprise (string enterprise, int? orgId);
        /// <summary>
        /// Get allowed actions and reusable workflows for an enterprise Gets the selected actions and reusable workflows that are allowed in an enterprise. To use this endpoint, the enterprise permission policy for &#x60;allowed_actions&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\&quot;  You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <returns>EnterpriseAdminGetAllowedActionsEnterprise200Response</returns>
        EnterpriseAdminGetAllowedActionsEnterprise200Response EnterpriseAdminGetAllowedActionsEnterprise (string enterprise);
        /// <summary>
        /// Get the audit log for an enterprise Gets the audit log for an enterprise. To use this endpoint, you must be an enterprise admin, and you must use an access token with the &#x60;admin:enterprise&#x60; scope.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="phrase">A search phrase. For more information, see [Searching the audit log](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/reviewing-the-audit-log-for-your-organization#searching-the-audit-log).</param>
        /// <param name="include">The event types to include:  - &#x60;web&#x60; - returns web (non-Git) events. - &#x60;git&#x60; - returns Git events. - &#x60;all&#x60; - returns both web and Git events.  The default is &#x60;web&#x60;.</param>
        /// <param name="after">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.</param>
        /// <param name="before">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor.</param>
        /// <param name="order">The order of audit log events. To list newest events first, specify &#x60;desc&#x60;. To list oldest events first, specify &#x60;asc&#x60;.  The default is &#x60;desc&#x60;.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <returns>List&lt;EnterpriseAdminGetAuditLog200ResponseInner&gt;</returns>
        List<EnterpriseAdminGetAuditLog200ResponseInner> EnterpriseAdminGetAuditLog (string enterprise, string phrase, string include, string after, string before, string order, int? page, int? perPage);
        /// <summary>
        /// Get GitHub Actions permissions for an enterprise Gets the GitHub Actions permissions policy for organizations and allowed actions and reusable workflows in an enterprise.  You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <returns>EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response</returns>
        EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response EnterpriseAdminGetGithubActionsPermissionsEnterprise (string enterprise);
        /// <summary>
        /// Get SCIM provisioning information for an enterprise group **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="scimGroupId">Identifier generated by the GitHub SCIM endpoint.</param>
        /// <param name="excludedAttributes">Attributes to exclude.</param>
        /// <returns>EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner</returns>
        EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner EnterpriseAdminGetProvisioningInformationForEnterpriseGroup (string enterprise, string scimGroupId, string excludedAttributes);
        /// <summary>
        /// Get SCIM provisioning information for an enterprise user **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="scimUserId">The unique identifier of the SCIM user.</param>
        /// <returns>EnterpriseAdminProvisionAndInviteEnterpriseUser201Response</returns>
        EnterpriseAdminProvisionAndInviteEnterpriseUser201Response EnterpriseAdminGetProvisioningInformationForEnterpriseUser (string enterprise, string scimUserId);
        /// <summary>
        /// Get a self-hosted runner for an enterprise Gets a specific self-hosted runner configured in an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns>SelfHostedRunners</returns>
        SelfHostedRunners EnterpriseAdminGetSelfHostedRunnerForEnterprise (string enterprise, int? runnerId);
        /// <summary>
        /// Get a self-hosted runner group for an enterprise Gets a specific self-hosted runner group for an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <returns>EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner</returns>
        EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner EnterpriseAdminGetSelfHostedRunnerGroupForEnterprise (string enterprise, int? runnerGroupId);
        /// <summary>
        /// Get GitHub Enterprise Server statistics Returns aggregate usage metrics for your GitHub Enterprise Server 3.5+ instance for a specified time period up to 365 days.  To use this endpoint, your GitHub Enterprise Server instance must be connected to GitHub Enterprise Cloud using GitHub Connect. You must enable Server Statistics, and for the API request provide your enterprise account name or organization name connected to the GitHub Enterprise Server. For more information, see \&quot;[Enabling Server Statistics for your enterprise](/admin/configuration/configuring-github-connect/enabling-server-statistics-for-your-enterprise)\&quot; in the GitHub Enterprise Server documentation.  You&#39;ll need to use a personal access token:   - If you connected your GitHub Enterprise Server to an enterprise account and enabled Server Statistics, you&#39;ll need a personal access token with the &#x60;read:enterprise&#x60; permission.   - If you connected your GitHub Enterprise Server to an organization account and enabled Server Statistics, you&#39;ll need a personal access token with the &#x60;read:org&#x60; permission.  For more information on creating a personal access token, see \&quot;[Creating a personal access token](/authentication/keeping-your-account-and-data-secure/creating-a-personal-access-token).\&quot;
        /// </summary>
        /// <param name="enterpriseOrOrg">The slug version of the enterprise name or the login of an organization.</param>
        /// <param name="dateStart">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.</param>
        /// <param name="dateEnd">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor.</param>
        /// <returns>List&lt;ServerStatisticsProxyEndpointInner&gt;</returns>
        List<ServerStatisticsProxyEndpointInner> EnterpriseAdminGetServerStatistics (string enterpriseOrOrg, string dateStart, string dateEnd);
        /// <summary>
        /// List labels for a self-hosted runner for an enterprise Lists all labels for a self-hosted runner configured in an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise (string enterprise, int? runnerId);
        /// <summary>
        /// List organization access to a self-hosted runner group in an enterprise Lists the organizations with access to a self-hosted runner group.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response</returns>
        EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response EnterpriseAdminListOrgAccessToSelfHostedRunnerGroupInEnterprise (string enterprise, int? runnerGroupId, int? perPage, int? page);
        /// <summary>
        /// List provisioned SCIM groups for an enterprise **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="startIndex">Used for pagination: the index of the first result to return.</param>
        /// <param name="count">Used for pagination: the number of results to return.</param>
        /// <param name="filter">filter results</param>
        /// <param name="excludedAttributes">attributes to exclude</param>
        /// <returns>EnterpriseAdminListProvisionedGroupsEnterprise200Response</returns>
        EnterpriseAdminListProvisionedGroupsEnterprise200Response EnterpriseAdminListProvisionedGroupsEnterprise (string enterprise, int? startIndex, int? count, string filter, string excludedAttributes);
        /// <summary>
        /// List SCIM provisioned identities for an enterprise **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Retrieves a paginated list of all provisioned enterprise members, including pending invitations.  When a user with a SAML-provisioned external identity leaves (or is removed from) an enterprise, the account&#39;s metadata is immediately removed. However, the returned list of user accounts might not always match the organization or enterprise member list you see on GitHub. This can happen in certain cases where an external identity associated with an organization will not match an organization member:   - When a user with a SCIM-provisioned external identity is removed from an enterprise, the account&#39;s metadata is preserved to allow the user to re-join the organization in the future.   - When inviting a user to join an organization, you can expect to see their external identity in the results before they accept the invitation, or if the invitation is cancelled (or never accepted).   - When a user is invited over SCIM, an external identity is created that matches with the invitee&#39;s email address. However, this identity is only linked to a user account when the user accepts the invitation by going through SAML SSO.  The returned list of external identities can include an entry for a &#x60;null&#x60; user. These are unlinked SAML identities that are created when a user goes through the following Single Sign-On (SSO) process but does not sign in to their GitHub account after completing SSO:  1. The user is granted access by the IdP and is not a member of the GitHub enterprise.  1. The user attempts to access the GitHub enterprise and initiates the SAML SSO process, and is not currently signed in to their GitHub account.  1. After successfully authenticating with the SAML SSO IdP, the &#x60;null&#x60; external identity entry is created and the user is prompted to sign in to their GitHub account:    - If the user signs in, their GitHub account is linked to this entry.    - If the user does not sign in (or does not create a new account when prompted), they are not added to the GitHub enterprise, and the external identity &#x60;null&#x60; entry remains in place.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="startIndex">Used for pagination: the index of the first result to return.</param>
        /// <param name="count">Used for pagination: the number of results to return.</param>
        /// <param name="filter">filter results</param>
        /// <returns>EnterpriseAdminListProvisionedIdentitiesEnterprise200Response</returns>
        EnterpriseAdminListProvisionedIdentitiesEnterprise200Response EnterpriseAdminListProvisionedIdentitiesEnterprise (string enterprise, int? startIndex, int? count, string filter);
        /// <summary>
        /// List runner applications for an enterprise Lists binaries for the runner application that you can download and run.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <returns>List&lt;RunnerApplication&gt;</returns>
        List<RunnerApplication> EnterpriseAdminListRunnerApplicationsForEnterprise (string enterprise);
        /// <summary>
        /// List selected organizations enabled for GitHub Actions in an enterprise Lists the organizations that are selected to have GitHub Actions enabled in an enterprise. To use this endpoint, the enterprise permission policy for &#x60;enabled_organizations&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\&quot;  You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response</returns>
        EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise (string enterprise, int? perPage, int? page);
        /// <summary>
        /// List self-hosted runner groups for an enterprise Lists all self-hosted runner groups for an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="visibleToOrganization">Only return runner groups that are allowed to be used by this organization.</param>
        /// <returns>EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200Response</returns>
        EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200Response EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise (string enterprise, int? perPage, int? page, string visibleToOrganization);
        /// <summary>
        /// List self-hosted runners for an enterprise Lists all self-hosted runners configured for an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>EnterpriseAdminListSelfHostedRunnersForEnterprise200Response</returns>
        EnterpriseAdminListSelfHostedRunnersForEnterprise200Response EnterpriseAdminListSelfHostedRunnersForEnterprise (string enterprise, int? perPage, int? page);
        /// <summary>
        /// List self-hosted runners in a group for an enterprise Lists the self-hosted runners that are in a specific enterprise group.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response</returns>
        EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise (string enterprise, int? runnerGroupId, int? perPage, int? page);
        /// <summary>
        /// Provision a SCIM enterprise group and invite users **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Provision an enterprise group, and invite users to the group. This sends invitation emails to the email address of the invited users to join the GitHub organization that the SCIM group corresponds to.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="enterpriseAdminProvisionAndInviteEnterpriseGroupRequest"></param>
        /// <returns>EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner</returns>
        EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner EnterpriseAdminProvisionAndInviteEnterpriseGroup (string enterprise, EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest enterpriseAdminProvisionAndInviteEnterpriseGroupRequest);
        /// <summary>
        /// Provision and invite a SCIM enterprise user **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Provision enterprise membership for a user, and send organization invitation emails to the email address.  You can optionally include the groups a user will be invited to join. If you do not provide a list of &#x60;groups&#x60;, the user is provisioned for the enterprise, but no organization invitation emails will be sent.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="enterpriseAdminProvisionAndInviteEnterpriseUserRequest"></param>
        /// <returns>EnterpriseAdminProvisionAndInviteEnterpriseUser201Response</returns>
        EnterpriseAdminProvisionAndInviteEnterpriseUser201Response EnterpriseAdminProvisionAndInviteEnterpriseUser (string enterprise, EnterpriseAdminProvisionAndInviteEnterpriseUserRequest enterpriseAdminProvisionAndInviteEnterpriseUserRequest);
        /// <summary>
        /// Remove all custom labels from a self-hosted runner for an enterprise Remove all custom labels from a self-hosted runner configured in an enterprise. Returns the remaining read-only labels from the runner.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response EnterpriseAdminRemoveAllCustomLabelsFromSelfHostedRunnerForEnterprise (string enterprise, int? runnerId);
        /// <summary>
        /// Remove a custom label from a self-hosted runner for an enterprise Remove a custom label from a self-hosted runner configured in an enterprise. Returns the remaining labels from the runner.  This endpoint returns a &#x60;404 Not Found&#x60; status if the custom label is not present on the runner.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <param name="name">The name of a self-hosted runner&#39;s custom label.</param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response EnterpriseAdminRemoveCustomLabelFromSelfHostedRunnerForEnterprise (string enterprise, int? runnerId, string name);
        /// <summary>
        /// Remove organization access to a self-hosted runner group in an enterprise Removes an organization from the list of selected organizations that can access a self-hosted runner group. The runner group must have &#x60;visibility&#x60; set to &#x60;selected&#x60;. For more information, see \&quot;[Create a self-hosted runner group for an enterprise](#create-a-self-hosted-runner-group-for-an-enterprise).\&quot;  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="orgId">The unique identifier of the organization.</param>
        /// <returns></returns>
        void EnterpriseAdminRemoveOrgAccessToSelfHostedRunnerGroupInEnterprise (string enterprise, int? runnerGroupId, int? orgId);
        /// <summary>
        /// Remove a self-hosted runner from a group for an enterprise Removes a self-hosted runner from a group configured in an enterprise. The runner is then returned to the default group.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns></returns>
        void EnterpriseAdminRemoveSelfHostedRunnerFromGroupForEnterprise (string enterprise, int? runnerGroupId, int? runnerId);
        /// <summary>
        /// Set allowed actions and reusable workflows for an enterprise Sets the actions and reusable workflows that are allowed in an enterprise. To use this endpoint, the enterprise permission policy for &#x60;allowed_actions&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\&quot;  You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="enterpriseAdminGetAllowedActionsEnterprise200Response"></param>
        /// <returns></returns>
        void EnterpriseAdminSetAllowedActionsEnterprise (string enterprise, EnterpriseAdminGetAllowedActionsEnterprise200Response enterpriseAdminGetAllowedActionsEnterprise200Response);
        /// <summary>
        /// Set custom labels for a self-hosted runner for an enterprise Remove all previous custom labels and set the new custom labels for a specific self-hosted runner configured in an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <param name="enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest"></param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterprise (string enterprise, int? runnerId, EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest);
        /// <summary>
        /// Set GitHub Actions permissions for an enterprise Sets the GitHub Actions permissions policy for organizations and allowed actions and reusable workflows in an enterprise.  You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="enterpriseAdminSetGithubActionsPermissionsEnterpriseRequest"></param>
        /// <returns></returns>
        void EnterpriseAdminSetGithubActionsPermissionsEnterprise (string enterprise, EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest enterpriseAdminSetGithubActionsPermissionsEnterpriseRequest);
        /// <summary>
        /// Set SCIM information for a provisioned enterprise group **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Replaces an existing provisioned group’s information. You must provide all the information required for the group as if you were provisioning it for the first time. Any existing group information that you don&#39;t provide will be removed, including group membership. If you want to only update a specific attribute, use the [Update an attribute for a SCIM enterprise group](#update-an-attribute-for-a-scim-enterprise-group) endpoint instead.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="scimGroupId">Identifier generated by the GitHub SCIM endpoint.</param>
        /// <param name="enterpriseAdminProvisionAndInviteEnterpriseGroupRequest"></param>
        /// <returns>EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner</returns>
        EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner EnterpriseAdminSetInformationForProvisionedEnterpriseGroup (string enterprise, string scimGroupId, EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest enterpriseAdminProvisionAndInviteEnterpriseGroupRequest);
        /// <summary>
        /// Set SCIM information for a provisioned enterprise user **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Replaces an existing provisioned user&#39;s information. You must provide all the information required for the user as if you were provisioning them for the first time. Any existing user information that you don&#39;t provide will be removed. If you want to only update a specific attribute, use the [Update an attribute for a SCIM user](#update-an-attribute-for-an-enterprise-scim-user) endpoint instead.  You must at least provide the required values for the user: &#x60;userName&#x60;, &#x60;name&#x60;, and &#x60;emails&#x60;.  **Warning:** Setting &#x60;active: false&#x60; removes the user from the enterprise, deletes the external identity, and deletes the associated &#x60;{scim_user_id}&#x60;.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="scimUserId">The unique identifier of the SCIM user.</param>
        /// <param name="enterpriseAdminProvisionAndInviteEnterpriseUserRequest"></param>
        /// <returns>EnterpriseAdminProvisionAndInviteEnterpriseUser201Response</returns>
        EnterpriseAdminProvisionAndInviteEnterpriseUser201Response EnterpriseAdminSetInformationForProvisionedEnterpriseUser (string enterprise, string scimUserId, EnterpriseAdminProvisionAndInviteEnterpriseUserRequest enterpriseAdminProvisionAndInviteEnterpriseUserRequest);
        /// <summary>
        /// Set organization access for a self-hosted runner group in an enterprise Replaces the list of organizations that have access to a self-hosted runner configured in an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="enterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest"></param>
        /// <returns></returns>
        void EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterprise (string enterprise, int? runnerGroupId, EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest enterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest);
        /// <summary>
        /// Set selected organizations enabled for GitHub Actions in an enterprise Replaces the list of selected organizations that are enabled for GitHub Actions in an enterprise. To use this endpoint, the enterprise permission policy for &#x60;enabled_organizations&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\&quot;  You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="enterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest"></param>
        /// <returns></returns>
        void EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterprise (string enterprise, EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest enterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest);
        /// <summary>
        /// Set self-hosted runners in a group for an enterprise Replaces the list of self-hosted runners that are part of an enterprise runner group.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest"></param>
        /// <returns></returns>
        void EnterpriseAdminSetSelfHostedRunnersInGroupForEnterprise (string enterprise, int? runnerGroupId, EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest);
        /// <summary>
        /// Update an attribute for a SCIM enterprise group **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Allows you to change a provisioned group’s individual attributes. To change a group’s values, you must provide a specific Operations JSON format that contains at least one of the add, remove, or replace operations. For examples and more information on the SCIM operations format, see the [SCIM specification](https://tools.ietf.org/html/rfc7644#section-3.5.2).
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="scimGroupId">Identifier generated by the GitHub SCIM endpoint.</param>
        /// <param name="enterpriseAdminUpdateAttributeForEnterpriseGroupRequest"></param>
        /// <returns>EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner</returns>
        EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner EnterpriseAdminUpdateAttributeForEnterpriseGroup (string enterprise, string scimGroupId, EnterpriseAdminUpdateAttributeForEnterpriseGroupRequest enterpriseAdminUpdateAttributeForEnterpriseGroupRequest);
        /// <summary>
        /// Update an attribute for a SCIM enterprise user **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Allows you to change a provisioned user&#39;s individual attributes. To change a user&#39;s values, you must provide a specific &#x60;Operations&#x60; JSON format that contains at least one of the &#x60;add&#x60;, &#x60;remove&#x60;, or &#x60;replace&#x60; operations. For examples and more information on the SCIM operations format, see the [SCIM specification](https://tools.ietf.org/html/rfc7644#section-3.5.2).  **Note:** Complicated SCIM &#x60;path&#x60; selectors that include filters are not supported. For example, a &#x60;path&#x60; selector defined as &#x60;\&quot;path\&quot;: \&quot;emails[type eq \\\&quot;work\\\&quot;]\&quot;&#x60; will not work.  **Warning:** If you set &#x60;active:false&#x60; using the &#x60;replace&#x60; operation (as shown in the JSON example below), it removes the user from the enterprise, deletes the external identity, and deletes the associated &#x60;:scim_user_id&#x60;.  &#x60;&#x60;&#x60; {   \&quot;Operations\&quot;:[{     \&quot;op\&quot;:\&quot;replace\&quot;,     \&quot;value\&quot;:{       \&quot;active\&quot;:false     }   }] } &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="scimUserId">The unique identifier of the SCIM user.</param>
        /// <param name="enterpriseAdminUpdateAttributeForEnterpriseUserRequest"></param>
        /// <returns>EnterpriseAdminProvisionAndInviteEnterpriseUser201Response</returns>
        EnterpriseAdminProvisionAndInviteEnterpriseUser201Response EnterpriseAdminUpdateAttributeForEnterpriseUser (string enterprise, string scimUserId, EnterpriseAdminUpdateAttributeForEnterpriseUserRequest enterpriseAdminUpdateAttributeForEnterpriseUserRequest);
        /// <summary>
        /// Update a self-hosted runner group for an enterprise Updates the &#x60;name&#x60; and &#x60;visibility&#x60; of a self-hosted runner group in an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="enterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest"></param>
        /// <returns>EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner</returns>
        EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterprise (string enterprise, int? runnerGroupId, EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest enterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EnterpriseAdminApi : IEnterpriseAdminApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseAdminApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public EnterpriseAdminApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseAdminApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EnterpriseAdminApi(String basePath)
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
        /// Add custom labels to a self-hosted runner for an enterprise Add custom labels to a self-hosted runner configured in an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <param name="enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest"></param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        public EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterprise (string enterprise, int? runnerId, EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterprise");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterprise");
            
            // verify the required parameter 'enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest' is set
            if (enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest == null) throw new ApiException(400, "Missing required parameter 'enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest' when calling EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runners/{runner_id}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// Add organization access to a self-hosted runner group in an enterprise Adds an organization to the list of selected organizations that can access a self-hosted runner group. The runner group must have &#x60;visibility&#x60; set to &#x60;selected&#x60;. For more information, see \&quot;[Create a self-hosted runner group for an enterprise](#create-a-self-hosted-runner-group-for-an-enterprise).\&quot;  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="orgId">The unique identifier of the organization.</param>
        /// <returns></returns>
        public void EnterpriseAdminAddOrgAccessToSelfHostedRunnerGroupInEnterprise (string enterprise, int? runnerGroupId, int? orgId)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminAddOrgAccessToSelfHostedRunnerGroupInEnterprise");
            
            // verify the required parameter 'runnerGroupId' is set
            if (runnerGroupId == null) throw new ApiException(400, "Missing required parameter 'runnerGroupId' when calling EnterpriseAdminAddOrgAccessToSelfHostedRunnerGroupInEnterprise");
            
            // verify the required parameter 'orgId' is set
            if (orgId == null) throw new ApiException(400, "Missing required parameter 'orgId' when calling EnterpriseAdminAddOrgAccessToSelfHostedRunnerGroupInEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/organizations/{org_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "runner_group_id" + "}", ApiClient.ParameterToString(runnerGroupId));
path = path.Replace("{" + "org_id" + "}", ApiClient.ParameterToString(orgId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminAddOrgAccessToSelfHostedRunnerGroupInEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminAddOrgAccessToSelfHostedRunnerGroupInEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Add a self-hosted runner to a group for an enterprise Adds a self-hosted runner to a runner group configured in an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns></returns>
        public void EnterpriseAdminAddSelfHostedRunnerToGroupForEnterprise (string enterprise, int? runnerGroupId, int? runnerId)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminAddSelfHostedRunnerToGroupForEnterprise");
            
            // verify the required parameter 'runnerGroupId' is set
            if (runnerGroupId == null) throw new ApiException(400, "Missing required parameter 'runnerGroupId' when calling EnterpriseAdminAddSelfHostedRunnerToGroupForEnterprise");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling EnterpriseAdminAddSelfHostedRunnerToGroupForEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/runners/{runner_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "runner_group_id" + "}", ApiClient.ParameterToString(runnerGroupId));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminAddSelfHostedRunnerToGroupForEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminAddSelfHostedRunnerToGroupForEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Create a registration token for an enterprise Returns a token that you can pass to the &#x60;config&#x60; script. The token expires after one hour.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.  #### Example using registration token  Configure your self-hosted runner, replacing &#x60;TOKEN&#x60; with the registration token provided by this endpoint.  &#x60;&#x60;&#x60; ./config.sh - -url https://github.com/enterprises/octo-enterprise - -token TOKEN &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <returns>AuthenticationToken</returns>
        public AuthenticationToken EnterpriseAdminCreateRegistrationTokenForEnterprise (string enterprise)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminCreateRegistrationTokenForEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runners/registration-token";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminCreateRegistrationTokenForEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminCreateRegistrationTokenForEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (AuthenticationToken) ApiClient.Deserialize(response.Content, typeof(AuthenticationToken), response.Headers);
        }

        /// <summary>
        /// Create a remove token for an enterprise Returns a token that you can pass to the &#x60;config&#x60; script to remove a self-hosted runner from an enterprise. The token expires after one hour.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.  #### Example using remove token  To remove your self-hosted runner from an enterprise, replace &#x60;TOKEN&#x60; with the remove token provided by this endpoint.  &#x60;&#x60;&#x60; ./config.sh remove - -token TOKEN &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <returns>AuthenticationToken</returns>
        public AuthenticationToken EnterpriseAdminCreateRemoveTokenForEnterprise (string enterprise)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminCreateRemoveTokenForEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runners/remove-token";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminCreateRemoveTokenForEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminCreateRemoveTokenForEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (AuthenticationToken) ApiClient.Deserialize(response.Content, typeof(AuthenticationToken), response.Headers);
        }

        /// <summary>
        /// Create a self-hosted runner group for an enterprise Creates a new self-hosted runner group for an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="enterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest"></param>
        /// <returns>EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner</returns>
        public EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner EnterpriseAdminCreateSelfHostedRunnerGroupForEnterprise (string enterprise, EnterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest enterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminCreateSelfHostedRunnerGroupForEnterprise");
            
            // verify the required parameter 'enterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest' is set
            if (enterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest == null) throw new ApiException(400, "Missing required parameter 'enterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest' when calling EnterpriseAdminCreateSelfHostedRunnerGroupForEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runner-groups";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(enterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminCreateSelfHostedRunnerGroupForEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminCreateSelfHostedRunnerGroupForEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner), response.Headers);
        }

        /// <summary>
        /// Delete a SCIM group from an enterprise **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="scimGroupId">Identifier generated by the GitHub SCIM endpoint.</param>
        /// <returns></returns>
        public void EnterpriseAdminDeleteScimGroupFromEnterprise (string enterprise, string scimGroupId)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminDeleteScimGroupFromEnterprise");
            
            // verify the required parameter 'scimGroupId' is set
            if (scimGroupId == null) throw new ApiException(400, "Missing required parameter 'scimGroupId' when calling EnterpriseAdminDeleteScimGroupFromEnterprise");
            

            var path = "/scim/v2/enterprises/{enterprise}/Groups/{scim_group_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "scim_group_id" + "}", ApiClient.ParameterToString(scimGroupId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminDeleteScimGroupFromEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminDeleteScimGroupFromEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a self-hosted runner from an enterprise Forces the removal of a self-hosted runner from an enterprise. You can use this endpoint to completely remove the runner when the machine you were using no longer exists.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns></returns>
        public void EnterpriseAdminDeleteSelfHostedRunnerFromEnterprise (string enterprise, int? runnerId)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminDeleteSelfHostedRunnerFromEnterprise");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling EnterpriseAdminDeleteSelfHostedRunnerFromEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runners/{runner_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminDeleteSelfHostedRunnerFromEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminDeleteSelfHostedRunnerFromEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a self-hosted runner group from an enterprise Deletes a self-hosted runner group for an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <returns></returns>
        public void EnterpriseAdminDeleteSelfHostedRunnerGroupFromEnterprise (string enterprise, int? runnerGroupId)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminDeleteSelfHostedRunnerGroupFromEnterprise");
            
            // verify the required parameter 'runnerGroupId' is set
            if (runnerGroupId == null) throw new ApiException(400, "Missing required parameter 'runnerGroupId' when calling EnterpriseAdminDeleteSelfHostedRunnerGroupFromEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runner-groups/{runner_group_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "runner_group_id" + "}", ApiClient.ParameterToString(runnerGroupId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminDeleteSelfHostedRunnerGroupFromEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminDeleteSelfHostedRunnerGroupFromEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a SCIM user from an enterprise **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="scimUserId">The unique identifier of the SCIM user.</param>
        /// <returns></returns>
        public void EnterpriseAdminDeleteUserFromEnterprise (string enterprise, string scimUserId)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminDeleteUserFromEnterprise");
            
            // verify the required parameter 'scimUserId' is set
            if (scimUserId == null) throw new ApiException(400, "Missing required parameter 'scimUserId' when calling EnterpriseAdminDeleteUserFromEnterprise");
            

            var path = "/scim/v2/enterprises/{enterprise}/Users/{scim_user_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "scim_user_id" + "}", ApiClient.ParameterToString(scimUserId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminDeleteUserFromEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminDeleteUserFromEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Disable a selected organization for GitHub Actions in an enterprise Removes an organization from the list of selected organizations that are enabled for GitHub Actions in an enterprise. To use this endpoint, the enterprise permission policy for &#x60;enabled_organizations&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\&quot;  You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="orgId">The unique identifier of the organization.</param>
        /// <returns></returns>
        public void EnterpriseAdminDisableSelectedOrganizationGithubActionsEnterprise (string enterprise, int? orgId)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminDisableSelectedOrganizationGithubActionsEnterprise");
            
            // verify the required parameter 'orgId' is set
            if (orgId == null) throw new ApiException(400, "Missing required parameter 'orgId' when calling EnterpriseAdminDisableSelectedOrganizationGithubActionsEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/permissions/organizations/{org_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "org_id" + "}", ApiClient.ParameterToString(orgId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminDisableSelectedOrganizationGithubActionsEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminDisableSelectedOrganizationGithubActionsEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Enable a selected organization for GitHub Actions in an enterprise Adds an organization to the list of selected organizations that are enabled for GitHub Actions in an enterprise. To use this endpoint, the enterprise permission policy for &#x60;enabled_organizations&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\&quot;  You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="orgId">The unique identifier of the organization.</param>
        /// <returns></returns>
        public void EnterpriseAdminEnableSelectedOrganizationGithubActionsEnterprise (string enterprise, int? orgId)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminEnableSelectedOrganizationGithubActionsEnterprise");
            
            // verify the required parameter 'orgId' is set
            if (orgId == null) throw new ApiException(400, "Missing required parameter 'orgId' when calling EnterpriseAdminEnableSelectedOrganizationGithubActionsEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/permissions/organizations/{org_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "org_id" + "}", ApiClient.ParameterToString(orgId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminEnableSelectedOrganizationGithubActionsEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminEnableSelectedOrganizationGithubActionsEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get allowed actions and reusable workflows for an enterprise Gets the selected actions and reusable workflows that are allowed in an enterprise. To use this endpoint, the enterprise permission policy for &#x60;allowed_actions&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\&quot;  You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <returns>EnterpriseAdminGetAllowedActionsEnterprise200Response</returns>
        public EnterpriseAdminGetAllowedActionsEnterprise200Response EnterpriseAdminGetAllowedActionsEnterprise (string enterprise)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminGetAllowedActionsEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/permissions/selected-actions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminGetAllowedActionsEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminGetAllowedActionsEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminGetAllowedActionsEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminGetAllowedActionsEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// Get the audit log for an enterprise Gets the audit log for an enterprise. To use this endpoint, you must be an enterprise admin, and you must use an access token with the &#x60;admin:enterprise&#x60; scope.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="phrase">A search phrase. For more information, see [Searching the audit log](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/reviewing-the-audit-log-for-your-organization#searching-the-audit-log).</param>
        /// <param name="include">The event types to include:  - &#x60;web&#x60; - returns web (non-Git) events. - &#x60;git&#x60; - returns Git events. - &#x60;all&#x60; - returns both web and Git events.  The default is &#x60;web&#x60;.</param>
        /// <param name="after">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.</param>
        /// <param name="before">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor.</param>
        /// <param name="order">The order of audit log events. To list newest events first, specify &#x60;desc&#x60;. To list oldest events first, specify &#x60;asc&#x60;.  The default is &#x60;desc&#x60;.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <returns>List&lt;EnterpriseAdminGetAuditLog200ResponseInner&gt;</returns>
        public List<EnterpriseAdminGetAuditLog200ResponseInner> EnterpriseAdminGetAuditLog (string enterprise, string phrase, string include, string after, string before, string order, int? page, int? perPage)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminGetAuditLog");
            

            var path = "/enterprises/{enterprise}/audit-log";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

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
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminGetAuditLog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminGetAuditLog: " + response.ErrorMessage, response.ErrorMessage);

            return (List<EnterpriseAdminGetAuditLog200ResponseInner>) ApiClient.Deserialize(response.Content, typeof(List<EnterpriseAdminGetAuditLog200ResponseInner>), response.Headers);
        }

        /// <summary>
        /// Get GitHub Actions permissions for an enterprise Gets the GitHub Actions permissions policy for organizations and allowed actions and reusable workflows in an enterprise.  You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <returns>EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response</returns>
        public EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response EnterpriseAdminGetGithubActionsPermissionsEnterprise (string enterprise)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminGetGithubActionsPermissionsEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/permissions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminGetGithubActionsPermissionsEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminGetGithubActionsPermissionsEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// Get SCIM provisioning information for an enterprise group **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="scimGroupId">Identifier generated by the GitHub SCIM endpoint.</param>
        /// <param name="excludedAttributes">Attributes to exclude.</param>
        /// <returns>EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner</returns>
        public EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner EnterpriseAdminGetProvisioningInformationForEnterpriseGroup (string enterprise, string scimGroupId, string excludedAttributes)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminGetProvisioningInformationForEnterpriseGroup");
            
            // verify the required parameter 'scimGroupId' is set
            if (scimGroupId == null) throw new ApiException(400, "Missing required parameter 'scimGroupId' when calling EnterpriseAdminGetProvisioningInformationForEnterpriseGroup");
            

            var path = "/scim/v2/enterprises/{enterprise}/Groups/{scim_group_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "scim_group_id" + "}", ApiClient.ParameterToString(scimGroupId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (excludedAttributes != null) queryParams.Add("excludedAttributes", ApiClient.ParameterToString(excludedAttributes)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminGetProvisioningInformationForEnterpriseGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminGetProvisioningInformationForEnterpriseGroup: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner), response.Headers);
        }

        /// <summary>
        /// Get SCIM provisioning information for an enterprise user **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="scimUserId">The unique identifier of the SCIM user.</param>
        /// <returns>EnterpriseAdminProvisionAndInviteEnterpriseUser201Response</returns>
        public EnterpriseAdminProvisionAndInviteEnterpriseUser201Response EnterpriseAdminGetProvisioningInformationForEnterpriseUser (string enterprise, string scimUserId)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminGetProvisioningInformationForEnterpriseUser");
            
            // verify the required parameter 'scimUserId' is set
            if (scimUserId == null) throw new ApiException(400, "Missing required parameter 'scimUserId' when calling EnterpriseAdminGetProvisioningInformationForEnterpriseUser");
            

            var path = "/scim/v2/enterprises/{enterprise}/Users/{scim_user_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "scim_user_id" + "}", ApiClient.ParameterToString(scimUserId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminGetProvisioningInformationForEnterpriseUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminGetProvisioningInformationForEnterpriseUser: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminProvisionAndInviteEnterpriseUser201Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminProvisionAndInviteEnterpriseUser201Response), response.Headers);
        }

        /// <summary>
        /// Get a self-hosted runner for an enterprise Gets a specific self-hosted runner configured in an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns>SelfHostedRunners</returns>
        public SelfHostedRunners EnterpriseAdminGetSelfHostedRunnerForEnterprise (string enterprise, int? runnerId)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminGetSelfHostedRunnerForEnterprise");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling EnterpriseAdminGetSelfHostedRunnerForEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runners/{runner_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminGetSelfHostedRunnerForEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminGetSelfHostedRunnerForEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (SelfHostedRunners) ApiClient.Deserialize(response.Content, typeof(SelfHostedRunners), response.Headers);
        }

        /// <summary>
        /// Get a self-hosted runner group for an enterprise Gets a specific self-hosted runner group for an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <returns>EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner</returns>
        public EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner EnterpriseAdminGetSelfHostedRunnerGroupForEnterprise (string enterprise, int? runnerGroupId)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminGetSelfHostedRunnerGroupForEnterprise");
            
            // verify the required parameter 'runnerGroupId' is set
            if (runnerGroupId == null) throw new ApiException(400, "Missing required parameter 'runnerGroupId' when calling EnterpriseAdminGetSelfHostedRunnerGroupForEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runner-groups/{runner_group_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "runner_group_id" + "}", ApiClient.ParameterToString(runnerGroupId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminGetSelfHostedRunnerGroupForEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminGetSelfHostedRunnerGroupForEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner), response.Headers);
        }

        /// <summary>
        /// Get GitHub Enterprise Server statistics Returns aggregate usage metrics for your GitHub Enterprise Server 3.5+ instance for a specified time period up to 365 days.  To use this endpoint, your GitHub Enterprise Server instance must be connected to GitHub Enterprise Cloud using GitHub Connect. You must enable Server Statistics, and for the API request provide your enterprise account name or organization name connected to the GitHub Enterprise Server. For more information, see \&quot;[Enabling Server Statistics for your enterprise](/admin/configuration/configuring-github-connect/enabling-server-statistics-for-your-enterprise)\&quot; in the GitHub Enterprise Server documentation.  You&#39;ll need to use a personal access token:   - If you connected your GitHub Enterprise Server to an enterprise account and enabled Server Statistics, you&#39;ll need a personal access token with the &#x60;read:enterprise&#x60; permission.   - If you connected your GitHub Enterprise Server to an organization account and enabled Server Statistics, you&#39;ll need a personal access token with the &#x60;read:org&#x60; permission.  For more information on creating a personal access token, see \&quot;[Creating a personal access token](/authentication/keeping-your-account-and-data-secure/creating-a-personal-access-token).\&quot;
        /// </summary>
        /// <param name="enterpriseOrOrg">The slug version of the enterprise name or the login of an organization.</param>
        /// <param name="dateStart">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.</param>
        /// <param name="dateEnd">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor.</param>
        /// <returns>List&lt;ServerStatisticsProxyEndpointInner&gt;</returns>
        public List<ServerStatisticsProxyEndpointInner> EnterpriseAdminGetServerStatistics (string enterpriseOrOrg, string dateStart, string dateEnd)
        {
            
            // verify the required parameter 'enterpriseOrOrg' is set
            if (enterpriseOrOrg == null) throw new ApiException(400, "Missing required parameter 'enterpriseOrOrg' when calling EnterpriseAdminGetServerStatistics");
            

            var path = "/enterprise-installation/{enterprise_or_org}/server-statistics";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise_or_org" + "}", ApiClient.ParameterToString(enterpriseOrOrg));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (dateStart != null) queryParams.Add("date_start", ApiClient.ParameterToString(dateStart)); // query parameter
 if (dateEnd != null) queryParams.Add("date_end", ApiClient.ParameterToString(dateEnd)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminGetServerStatistics: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminGetServerStatistics: " + response.ErrorMessage, response.ErrorMessage);

            return (List<ServerStatisticsProxyEndpointInner>) ApiClient.Deserialize(response.Content, typeof(List<ServerStatisticsProxyEndpointInner>), response.Headers);
        }

        /// <summary>
        /// List labels for a self-hosted runner for an enterprise Lists all labels for a self-hosted runner configured in an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        public EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise (string enterprise, int? runnerId)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runners/{runner_id}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// List organization access to a self-hosted runner group in an enterprise Lists the organizations with access to a self-hosted runner group.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response</returns>
        public EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response EnterpriseAdminListOrgAccessToSelfHostedRunnerGroupInEnterprise (string enterprise, int? runnerGroupId, int? perPage, int? page)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminListOrgAccessToSelfHostedRunnerGroupInEnterprise");
            
            // verify the required parameter 'runnerGroupId' is set
            if (runnerGroupId == null) throw new ApiException(400, "Missing required parameter 'runnerGroupId' when calling EnterpriseAdminListOrgAccessToSelfHostedRunnerGroupInEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/organizations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "runner_group_id" + "}", ApiClient.ParameterToString(runnerGroupId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminListOrgAccessToSelfHostedRunnerGroupInEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminListOrgAccessToSelfHostedRunnerGroupInEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// List provisioned SCIM groups for an enterprise **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="startIndex">Used for pagination: the index of the first result to return.</param>
        /// <param name="count">Used for pagination: the number of results to return.</param>
        /// <param name="filter">filter results</param>
        /// <param name="excludedAttributes">attributes to exclude</param>
        /// <returns>EnterpriseAdminListProvisionedGroupsEnterprise200Response</returns>
        public EnterpriseAdminListProvisionedGroupsEnterprise200Response EnterpriseAdminListProvisionedGroupsEnterprise (string enterprise, int? startIndex, int? count, string filter, string excludedAttributes)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminListProvisionedGroupsEnterprise");
            

            var path = "/scim/v2/enterprises/{enterprise}/Groups";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (startIndex != null) queryParams.Add("startIndex", ApiClient.ParameterToString(startIndex)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (excludedAttributes != null) queryParams.Add("excludedAttributes", ApiClient.ParameterToString(excludedAttributes)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminListProvisionedGroupsEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminListProvisionedGroupsEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListProvisionedGroupsEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListProvisionedGroupsEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// List SCIM provisioned identities for an enterprise **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Retrieves a paginated list of all provisioned enterprise members, including pending invitations.  When a user with a SAML-provisioned external identity leaves (or is removed from) an enterprise, the account&#39;s metadata is immediately removed. However, the returned list of user accounts might not always match the organization or enterprise member list you see on GitHub. This can happen in certain cases where an external identity associated with an organization will not match an organization member:   - When a user with a SCIM-provisioned external identity is removed from an enterprise, the account&#39;s metadata is preserved to allow the user to re-join the organization in the future.   - When inviting a user to join an organization, you can expect to see their external identity in the results before they accept the invitation, or if the invitation is cancelled (or never accepted).   - When a user is invited over SCIM, an external identity is created that matches with the invitee&#39;s email address. However, this identity is only linked to a user account when the user accepts the invitation by going through SAML SSO.  The returned list of external identities can include an entry for a &#x60;null&#x60; user. These are unlinked SAML identities that are created when a user goes through the following Single Sign-On (SSO) process but does not sign in to their GitHub account after completing SSO:  1. The user is granted access by the IdP and is not a member of the GitHub enterprise.  1. The user attempts to access the GitHub enterprise and initiates the SAML SSO process, and is not currently signed in to their GitHub account.  1. After successfully authenticating with the SAML SSO IdP, the &#x60;null&#x60; external identity entry is created and the user is prompted to sign in to their GitHub account:    - If the user signs in, their GitHub account is linked to this entry.    - If the user does not sign in (or does not create a new account when prompted), they are not added to the GitHub enterprise, and the external identity &#x60;null&#x60; entry remains in place.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="startIndex">Used for pagination: the index of the first result to return.</param>
        /// <param name="count">Used for pagination: the number of results to return.</param>
        /// <param name="filter">filter results</param>
        /// <returns>EnterpriseAdminListProvisionedIdentitiesEnterprise200Response</returns>
        public EnterpriseAdminListProvisionedIdentitiesEnterprise200Response EnterpriseAdminListProvisionedIdentitiesEnterprise (string enterprise, int? startIndex, int? count, string filter)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminListProvisionedIdentitiesEnterprise");
            

            var path = "/scim/v2/enterprises/{enterprise}/Users";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (startIndex != null) queryParams.Add("startIndex", ApiClient.ParameterToString(startIndex)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminListProvisionedIdentitiesEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminListProvisionedIdentitiesEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListProvisionedIdentitiesEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListProvisionedIdentitiesEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// List runner applications for an enterprise Lists binaries for the runner application that you can download and run.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <returns>List&lt;RunnerApplication&gt;</returns>
        public List<RunnerApplication> EnterpriseAdminListRunnerApplicationsForEnterprise (string enterprise)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminListRunnerApplicationsForEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runners/downloads";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminListRunnerApplicationsForEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminListRunnerApplicationsForEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (List<RunnerApplication>) ApiClient.Deserialize(response.Content, typeof(List<RunnerApplication>), response.Headers);
        }

        /// <summary>
        /// List selected organizations enabled for GitHub Actions in an enterprise Lists the organizations that are selected to have GitHub Actions enabled in an enterprise. To use this endpoint, the enterprise permission policy for &#x60;enabled_organizations&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\&quot;  You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response</returns>
        public EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise (string enterprise, int? perPage, int? page)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/permissions/organizations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// List self-hosted runner groups for an enterprise Lists all self-hosted runner groups for an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="visibleToOrganization">Only return runner groups that are allowed to be used by this organization.</param>
        /// <returns>EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200Response</returns>
        public EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200Response EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise (string enterprise, int? perPage, int? page, string visibleToOrganization)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runner-groups";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (visibleToOrganization != null) queryParams.Add("visible_to_organization", ApiClient.ParameterToString(visibleToOrganization)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// List self-hosted runners for an enterprise Lists all self-hosted runners configured for an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>EnterpriseAdminListSelfHostedRunnersForEnterprise200Response</returns>
        public EnterpriseAdminListSelfHostedRunnersForEnterprise200Response EnterpriseAdminListSelfHostedRunnersForEnterprise (string enterprise, int? perPage, int? page)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminListSelfHostedRunnersForEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runners";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminListSelfHostedRunnersForEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminListSelfHostedRunnersForEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListSelfHostedRunnersForEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListSelfHostedRunnersForEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// List self-hosted runners in a group for an enterprise Lists the self-hosted runners that are in a specific enterprise group.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response</returns>
        public EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise (string enterprise, int? runnerGroupId, int? perPage, int? page)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise");
            
            // verify the required parameter 'runnerGroupId' is set
            if (runnerGroupId == null) throw new ApiException(400, "Missing required parameter 'runnerGroupId' when calling EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/runners";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "runner_group_id" + "}", ApiClient.ParameterToString(runnerGroupId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// Provision a SCIM enterprise group and invite users **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Provision an enterprise group, and invite users to the group. This sends invitation emails to the email address of the invited users to join the GitHub organization that the SCIM group corresponds to.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="enterpriseAdminProvisionAndInviteEnterpriseGroupRequest"></param>
        /// <returns>EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner</returns>
        public EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner EnterpriseAdminProvisionAndInviteEnterpriseGroup (string enterprise, EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest enterpriseAdminProvisionAndInviteEnterpriseGroupRequest)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminProvisionAndInviteEnterpriseGroup");
            
            // verify the required parameter 'enterpriseAdminProvisionAndInviteEnterpriseGroupRequest' is set
            if (enterpriseAdminProvisionAndInviteEnterpriseGroupRequest == null) throw new ApiException(400, "Missing required parameter 'enterpriseAdminProvisionAndInviteEnterpriseGroupRequest' when calling EnterpriseAdminProvisionAndInviteEnterpriseGroup");
            

            var path = "/scim/v2/enterprises/{enterprise}/Groups";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(enterpriseAdminProvisionAndInviteEnterpriseGroupRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminProvisionAndInviteEnterpriseGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminProvisionAndInviteEnterpriseGroup: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner), response.Headers);
        }

        /// <summary>
        /// Provision and invite a SCIM enterprise user **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Provision enterprise membership for a user, and send organization invitation emails to the email address.  You can optionally include the groups a user will be invited to join. If you do not provide a list of &#x60;groups&#x60;, the user is provisioned for the enterprise, but no organization invitation emails will be sent.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="enterpriseAdminProvisionAndInviteEnterpriseUserRequest"></param>
        /// <returns>EnterpriseAdminProvisionAndInviteEnterpriseUser201Response</returns>
        public EnterpriseAdminProvisionAndInviteEnterpriseUser201Response EnterpriseAdminProvisionAndInviteEnterpriseUser (string enterprise, EnterpriseAdminProvisionAndInviteEnterpriseUserRequest enterpriseAdminProvisionAndInviteEnterpriseUserRequest)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminProvisionAndInviteEnterpriseUser");
            
            // verify the required parameter 'enterpriseAdminProvisionAndInviteEnterpriseUserRequest' is set
            if (enterpriseAdminProvisionAndInviteEnterpriseUserRequest == null) throw new ApiException(400, "Missing required parameter 'enterpriseAdminProvisionAndInviteEnterpriseUserRequest' when calling EnterpriseAdminProvisionAndInviteEnterpriseUser");
            

            var path = "/scim/v2/enterprises/{enterprise}/Users";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(enterpriseAdminProvisionAndInviteEnterpriseUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminProvisionAndInviteEnterpriseUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminProvisionAndInviteEnterpriseUser: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminProvisionAndInviteEnterpriseUser201Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminProvisionAndInviteEnterpriseUser201Response), response.Headers);
        }

        /// <summary>
        /// Remove all custom labels from a self-hosted runner for an enterprise Remove all custom labels from a self-hosted runner configured in an enterprise. Returns the remaining read-only labels from the runner.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        public EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response EnterpriseAdminRemoveAllCustomLabelsFromSelfHostedRunnerForEnterprise (string enterprise, int? runnerId)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminRemoveAllCustomLabelsFromSelfHostedRunnerForEnterprise");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling EnterpriseAdminRemoveAllCustomLabelsFromSelfHostedRunnerForEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runners/{runner_id}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminRemoveAllCustomLabelsFromSelfHostedRunnerForEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminRemoveAllCustomLabelsFromSelfHostedRunnerForEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// Remove a custom label from a self-hosted runner for an enterprise Remove a custom label from a self-hosted runner configured in an enterprise. Returns the remaining labels from the runner.  This endpoint returns a &#x60;404 Not Found&#x60; status if the custom label is not present on the runner.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <param name="name">The name of a self-hosted runner&#39;s custom label.</param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        public EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response EnterpriseAdminRemoveCustomLabelFromSelfHostedRunnerForEnterprise (string enterprise, int? runnerId, string name)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminRemoveCustomLabelFromSelfHostedRunnerForEnterprise");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling EnterpriseAdminRemoveCustomLabelFromSelfHostedRunnerForEnterprise");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling EnterpriseAdminRemoveCustomLabelFromSelfHostedRunnerForEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runners/{runner_id}/labels/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminRemoveCustomLabelFromSelfHostedRunnerForEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminRemoveCustomLabelFromSelfHostedRunnerForEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// Remove organization access to a self-hosted runner group in an enterprise Removes an organization from the list of selected organizations that can access a self-hosted runner group. The runner group must have &#x60;visibility&#x60; set to &#x60;selected&#x60;. For more information, see \&quot;[Create a self-hosted runner group for an enterprise](#create-a-self-hosted-runner-group-for-an-enterprise).\&quot;  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="orgId">The unique identifier of the organization.</param>
        /// <returns></returns>
        public void EnterpriseAdminRemoveOrgAccessToSelfHostedRunnerGroupInEnterprise (string enterprise, int? runnerGroupId, int? orgId)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminRemoveOrgAccessToSelfHostedRunnerGroupInEnterprise");
            
            // verify the required parameter 'runnerGroupId' is set
            if (runnerGroupId == null) throw new ApiException(400, "Missing required parameter 'runnerGroupId' when calling EnterpriseAdminRemoveOrgAccessToSelfHostedRunnerGroupInEnterprise");
            
            // verify the required parameter 'orgId' is set
            if (orgId == null) throw new ApiException(400, "Missing required parameter 'orgId' when calling EnterpriseAdminRemoveOrgAccessToSelfHostedRunnerGroupInEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/organizations/{org_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "runner_group_id" + "}", ApiClient.ParameterToString(runnerGroupId));
path = path.Replace("{" + "org_id" + "}", ApiClient.ParameterToString(orgId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminRemoveOrgAccessToSelfHostedRunnerGroupInEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminRemoveOrgAccessToSelfHostedRunnerGroupInEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Remove a self-hosted runner from a group for an enterprise Removes a self-hosted runner from a group configured in an enterprise. The runner is then returned to the default group.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns></returns>
        public void EnterpriseAdminRemoveSelfHostedRunnerFromGroupForEnterprise (string enterprise, int? runnerGroupId, int? runnerId)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminRemoveSelfHostedRunnerFromGroupForEnterprise");
            
            // verify the required parameter 'runnerGroupId' is set
            if (runnerGroupId == null) throw new ApiException(400, "Missing required parameter 'runnerGroupId' when calling EnterpriseAdminRemoveSelfHostedRunnerFromGroupForEnterprise");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling EnterpriseAdminRemoveSelfHostedRunnerFromGroupForEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/runners/{runner_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "runner_group_id" + "}", ApiClient.ParameterToString(runnerGroupId));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminRemoveSelfHostedRunnerFromGroupForEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminRemoveSelfHostedRunnerFromGroupForEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Set allowed actions and reusable workflows for an enterprise Sets the actions and reusable workflows that are allowed in an enterprise. To use this endpoint, the enterprise permission policy for &#x60;allowed_actions&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\&quot;  You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="enterpriseAdminGetAllowedActionsEnterprise200Response"></param>
        /// <returns></returns>
        public void EnterpriseAdminSetAllowedActionsEnterprise (string enterprise, EnterpriseAdminGetAllowedActionsEnterprise200Response enterpriseAdminGetAllowedActionsEnterprise200Response)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminSetAllowedActionsEnterprise");
            
            // verify the required parameter 'enterpriseAdminGetAllowedActionsEnterprise200Response' is set
            if (enterpriseAdminGetAllowedActionsEnterprise200Response == null) throw new ApiException(400, "Missing required parameter 'enterpriseAdminGetAllowedActionsEnterprise200Response' when calling EnterpriseAdminSetAllowedActionsEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/permissions/selected-actions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(enterpriseAdminGetAllowedActionsEnterprise200Response); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminSetAllowedActionsEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminSetAllowedActionsEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Set custom labels for a self-hosted runner for an enterprise Remove all previous custom labels and set the new custom labels for a specific self-hosted runner configured in an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <param name="enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest"></param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        public EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterprise (string enterprise, int? runnerId, EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterprise");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterprise");
            
            // verify the required parameter 'enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest' is set
            if (enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest == null) throw new ApiException(400, "Missing required parameter 'enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest' when calling EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runners/{runner_id}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// Set GitHub Actions permissions for an enterprise Sets the GitHub Actions permissions policy for organizations and allowed actions and reusable workflows in an enterprise.  You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="enterpriseAdminSetGithubActionsPermissionsEnterpriseRequest"></param>
        /// <returns></returns>
        public void EnterpriseAdminSetGithubActionsPermissionsEnterprise (string enterprise, EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest enterpriseAdminSetGithubActionsPermissionsEnterpriseRequest)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminSetGithubActionsPermissionsEnterprise");
            
            // verify the required parameter 'enterpriseAdminSetGithubActionsPermissionsEnterpriseRequest' is set
            if (enterpriseAdminSetGithubActionsPermissionsEnterpriseRequest == null) throw new ApiException(400, "Missing required parameter 'enterpriseAdminSetGithubActionsPermissionsEnterpriseRequest' when calling EnterpriseAdminSetGithubActionsPermissionsEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/permissions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(enterpriseAdminSetGithubActionsPermissionsEnterpriseRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminSetGithubActionsPermissionsEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminSetGithubActionsPermissionsEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Set SCIM information for a provisioned enterprise group **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Replaces an existing provisioned group’s information. You must provide all the information required for the group as if you were provisioning it for the first time. Any existing group information that you don&#39;t provide will be removed, including group membership. If you want to only update a specific attribute, use the [Update an attribute for a SCIM enterprise group](#update-an-attribute-for-a-scim-enterprise-group) endpoint instead.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="scimGroupId">Identifier generated by the GitHub SCIM endpoint.</param>
        /// <param name="enterpriseAdminProvisionAndInviteEnterpriseGroupRequest"></param>
        /// <returns>EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner</returns>
        public EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner EnterpriseAdminSetInformationForProvisionedEnterpriseGroup (string enterprise, string scimGroupId, EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest enterpriseAdminProvisionAndInviteEnterpriseGroupRequest)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminSetInformationForProvisionedEnterpriseGroup");
            
            // verify the required parameter 'scimGroupId' is set
            if (scimGroupId == null) throw new ApiException(400, "Missing required parameter 'scimGroupId' when calling EnterpriseAdminSetInformationForProvisionedEnterpriseGroup");
            
            // verify the required parameter 'enterpriseAdminProvisionAndInviteEnterpriseGroupRequest' is set
            if (enterpriseAdminProvisionAndInviteEnterpriseGroupRequest == null) throw new ApiException(400, "Missing required parameter 'enterpriseAdminProvisionAndInviteEnterpriseGroupRequest' when calling EnterpriseAdminSetInformationForProvisionedEnterpriseGroup");
            

            var path = "/scim/v2/enterprises/{enterprise}/Groups/{scim_group_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "scim_group_id" + "}", ApiClient.ParameterToString(scimGroupId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(enterpriseAdminProvisionAndInviteEnterpriseGroupRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminSetInformationForProvisionedEnterpriseGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminSetInformationForProvisionedEnterpriseGroup: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner), response.Headers);
        }

        /// <summary>
        /// Set SCIM information for a provisioned enterprise user **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Replaces an existing provisioned user&#39;s information. You must provide all the information required for the user as if you were provisioning them for the first time. Any existing user information that you don&#39;t provide will be removed. If you want to only update a specific attribute, use the [Update an attribute for a SCIM user](#update-an-attribute-for-an-enterprise-scim-user) endpoint instead.  You must at least provide the required values for the user: &#x60;userName&#x60;, &#x60;name&#x60;, and &#x60;emails&#x60;.  **Warning:** Setting &#x60;active: false&#x60; removes the user from the enterprise, deletes the external identity, and deletes the associated &#x60;{scim_user_id}&#x60;.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="scimUserId">The unique identifier of the SCIM user.</param>
        /// <param name="enterpriseAdminProvisionAndInviteEnterpriseUserRequest"></param>
        /// <returns>EnterpriseAdminProvisionAndInviteEnterpriseUser201Response</returns>
        public EnterpriseAdminProvisionAndInviteEnterpriseUser201Response EnterpriseAdminSetInformationForProvisionedEnterpriseUser (string enterprise, string scimUserId, EnterpriseAdminProvisionAndInviteEnterpriseUserRequest enterpriseAdminProvisionAndInviteEnterpriseUserRequest)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminSetInformationForProvisionedEnterpriseUser");
            
            // verify the required parameter 'scimUserId' is set
            if (scimUserId == null) throw new ApiException(400, "Missing required parameter 'scimUserId' when calling EnterpriseAdminSetInformationForProvisionedEnterpriseUser");
            
            // verify the required parameter 'enterpriseAdminProvisionAndInviteEnterpriseUserRequest' is set
            if (enterpriseAdminProvisionAndInviteEnterpriseUserRequest == null) throw new ApiException(400, "Missing required parameter 'enterpriseAdminProvisionAndInviteEnterpriseUserRequest' when calling EnterpriseAdminSetInformationForProvisionedEnterpriseUser");
            

            var path = "/scim/v2/enterprises/{enterprise}/Users/{scim_user_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "scim_user_id" + "}", ApiClient.ParameterToString(scimUserId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(enterpriseAdminProvisionAndInviteEnterpriseUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminSetInformationForProvisionedEnterpriseUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminSetInformationForProvisionedEnterpriseUser: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminProvisionAndInviteEnterpriseUser201Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminProvisionAndInviteEnterpriseUser201Response), response.Headers);
        }

        /// <summary>
        /// Set organization access for a self-hosted runner group in an enterprise Replaces the list of organizations that have access to a self-hosted runner configured in an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="enterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest"></param>
        /// <returns></returns>
        public void EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterprise (string enterprise, int? runnerGroupId, EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest enterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterprise");
            
            // verify the required parameter 'runnerGroupId' is set
            if (runnerGroupId == null) throw new ApiException(400, "Missing required parameter 'runnerGroupId' when calling EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterprise");
            
            // verify the required parameter 'enterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest' is set
            if (enterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest == null) throw new ApiException(400, "Missing required parameter 'enterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest' when calling EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/organizations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "runner_group_id" + "}", ApiClient.ParameterToString(runnerGroupId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(enterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Set selected organizations enabled for GitHub Actions in an enterprise Replaces the list of selected organizations that are enabled for GitHub Actions in an enterprise. To use this endpoint, the enterprise permission policy for &#x60;enabled_organizations&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\&quot;  You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="enterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest"></param>
        /// <returns></returns>
        public void EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterprise (string enterprise, EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest enterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterprise");
            
            // verify the required parameter 'enterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest' is set
            if (enterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest == null) throw new ApiException(400, "Missing required parameter 'enterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest' when calling EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/permissions/organizations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(enterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Set self-hosted runners in a group for an enterprise Replaces the list of self-hosted runners that are part of an enterprise runner group.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest"></param>
        /// <returns></returns>
        public void EnterpriseAdminSetSelfHostedRunnersInGroupForEnterprise (string enterprise, int? runnerGroupId, EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminSetSelfHostedRunnersInGroupForEnterprise");
            
            // verify the required parameter 'runnerGroupId' is set
            if (runnerGroupId == null) throw new ApiException(400, "Missing required parameter 'runnerGroupId' when calling EnterpriseAdminSetSelfHostedRunnersInGroupForEnterprise");
            
            // verify the required parameter 'enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest' is set
            if (enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest == null) throw new ApiException(400, "Missing required parameter 'enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest' when calling EnterpriseAdminSetSelfHostedRunnersInGroupForEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/runners";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "runner_group_id" + "}", ApiClient.ParameterToString(runnerGroupId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminSetSelfHostedRunnersInGroupForEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminSetSelfHostedRunnersInGroupForEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Update an attribute for a SCIM enterprise group **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Allows you to change a provisioned group’s individual attributes. To change a group’s values, you must provide a specific Operations JSON format that contains at least one of the add, remove, or replace operations. For examples and more information on the SCIM operations format, see the [SCIM specification](https://tools.ietf.org/html/rfc7644#section-3.5.2).
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="scimGroupId">Identifier generated by the GitHub SCIM endpoint.</param>
        /// <param name="enterpriseAdminUpdateAttributeForEnterpriseGroupRequest"></param>
        /// <returns>EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner</returns>
        public EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner EnterpriseAdminUpdateAttributeForEnterpriseGroup (string enterprise, string scimGroupId, EnterpriseAdminUpdateAttributeForEnterpriseGroupRequest enterpriseAdminUpdateAttributeForEnterpriseGroupRequest)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminUpdateAttributeForEnterpriseGroup");
            
            // verify the required parameter 'scimGroupId' is set
            if (scimGroupId == null) throw new ApiException(400, "Missing required parameter 'scimGroupId' when calling EnterpriseAdminUpdateAttributeForEnterpriseGroup");
            
            // verify the required parameter 'enterpriseAdminUpdateAttributeForEnterpriseGroupRequest' is set
            if (enterpriseAdminUpdateAttributeForEnterpriseGroupRequest == null) throw new ApiException(400, "Missing required parameter 'enterpriseAdminUpdateAttributeForEnterpriseGroupRequest' when calling EnterpriseAdminUpdateAttributeForEnterpriseGroup");
            

            var path = "/scim/v2/enterprises/{enterprise}/Groups/{scim_group_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "scim_group_id" + "}", ApiClient.ParameterToString(scimGroupId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(enterpriseAdminUpdateAttributeForEnterpriseGroupRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminUpdateAttributeForEnterpriseGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminUpdateAttributeForEnterpriseGroup: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner), response.Headers);
        }

        /// <summary>
        /// Update an attribute for a SCIM enterprise user **Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Allows you to change a provisioned user&#39;s individual attributes. To change a user&#39;s values, you must provide a specific &#x60;Operations&#x60; JSON format that contains at least one of the &#x60;add&#x60;, &#x60;remove&#x60;, or &#x60;replace&#x60; operations. For examples and more information on the SCIM operations format, see the [SCIM specification](https://tools.ietf.org/html/rfc7644#section-3.5.2).  **Note:** Complicated SCIM &#x60;path&#x60; selectors that include filters are not supported. For example, a &#x60;path&#x60; selector defined as &#x60;\&quot;path\&quot;: \&quot;emails[type eq \\\&quot;work\\\&quot;]\&quot;&#x60; will not work.  **Warning:** If you set &#x60;active:false&#x60; using the &#x60;replace&#x60; operation (as shown in the JSON example below), it removes the user from the enterprise, deletes the external identity, and deletes the associated &#x60;:scim_user_id&#x60;.  &#x60;&#x60;&#x60; {   \&quot;Operations\&quot;:[{     \&quot;op\&quot;:\&quot;replace\&quot;,     \&quot;value\&quot;:{       \&quot;active\&quot;:false     }   }] } &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="scimUserId">The unique identifier of the SCIM user.</param>
        /// <param name="enterpriseAdminUpdateAttributeForEnterpriseUserRequest"></param>
        /// <returns>EnterpriseAdminProvisionAndInviteEnterpriseUser201Response</returns>
        public EnterpriseAdminProvisionAndInviteEnterpriseUser201Response EnterpriseAdminUpdateAttributeForEnterpriseUser (string enterprise, string scimUserId, EnterpriseAdminUpdateAttributeForEnterpriseUserRequest enterpriseAdminUpdateAttributeForEnterpriseUserRequest)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminUpdateAttributeForEnterpriseUser");
            
            // verify the required parameter 'scimUserId' is set
            if (scimUserId == null) throw new ApiException(400, "Missing required parameter 'scimUserId' when calling EnterpriseAdminUpdateAttributeForEnterpriseUser");
            
            // verify the required parameter 'enterpriseAdminUpdateAttributeForEnterpriseUserRequest' is set
            if (enterpriseAdminUpdateAttributeForEnterpriseUserRequest == null) throw new ApiException(400, "Missing required parameter 'enterpriseAdminUpdateAttributeForEnterpriseUserRequest' when calling EnterpriseAdminUpdateAttributeForEnterpriseUser");
            

            var path = "/scim/v2/enterprises/{enterprise}/Users/{scim_user_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "scim_user_id" + "}", ApiClient.ParameterToString(scimUserId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(enterpriseAdminUpdateAttributeForEnterpriseUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminUpdateAttributeForEnterpriseUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminUpdateAttributeForEnterpriseUser: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminProvisionAndInviteEnterpriseUser201Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminProvisionAndInviteEnterpriseUser201Response), response.Headers);
        }

        /// <summary>
        /// Update a self-hosted runner group for an enterprise Updates the &#x60;name&#x60; and &#x60;visibility&#x60; of a self-hosted runner group in an enterprise.  You must authenticate using an access token with the &#x60;manage_runners:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="enterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest"></param>
        /// <returns>EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner</returns>
        public EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterprise (string enterprise, int? runnerGroupId, EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest enterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterprise");
            
            // verify the required parameter 'runnerGroupId' is set
            if (runnerGroupId == null) throw new ApiException(400, "Missing required parameter 'runnerGroupId' when calling EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/runner-groups/{runner_group_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));
path = path.Replace("{" + "runner_group_id" + "}", ApiClient.ParameterToString(runnerGroupId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(enterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner), response.Headers);
        }

    }
}
