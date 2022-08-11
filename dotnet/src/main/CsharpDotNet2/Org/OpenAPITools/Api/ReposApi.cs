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
    public interface IReposApi
    {
        /// <summary>
        /// Accept a repository invitation 
        /// </summary>
        /// <param name="invitationId">The unique identifier of the invitation.</param>
        /// <returns></returns>
        void ReposAcceptInvitationForAuthenticatedUser (int? invitationId);
        /// <summary>
        /// Add app access restrictions Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Grants the specified apps push access for this branch. Only installed GitHub Apps with &#x60;write&#x60; access to the &#x60;contents&#x60; permission can be added as authorized actors on a protected branch.  | Type    | Description                                                                                                                                                | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | &#x60;array&#x60; | The GitHub Apps that have push access to this branch. Use the app&#39;s &#x60;slug&#x60;. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetAppAccessRestrictionsRequest"></param>
        /// <returns>List&lt;GitHubApp&gt;</returns>
        List<GitHubApp> ReposAddAppAccessRestrictions (string owner, string repo, string branch, ReposSetAppAccessRestrictionsRequest reposSetAppAccessRestrictionsRequest);
        /// <summary>
        /// Add a repository collaborator This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.  Adding an outside collaborator may be restricted by enterprise administrators. For more information, see \&quot;[Enforcing repository management policies in your enterprise](https://docs.github.com/enterprise-cloud@latest/admin/policies/enforcing-policies-for-your-enterprise/enforcing-repository-management-policies-in-your-enterprise#enforcing-a-policy-for-inviting-outside-collaborators-to-repositories).\&quot;  For more information on permission levels, see \&quot;[Repository permission levels for an organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/repository-permission-levels-for-an-organization#permission-levels-for-repositories-owned-by-an-organization)\&quot;. There are restrictions on which permissions can be granted to organization members when an organization base role is in place. In this case, the permission being given must be equal to or higher than the org base permission. Otherwise, the request will fail with:  &#x60;&#x60;&#x60; Cannot assign {member} permission of {role name} &#x60;&#x60;&#x60;  Note that, if you choose not to pass any parameters, you&#39;ll need to set &#x60;Content-Length&#x60; to zero when calling out to this endpoint. For more information, see \&quot;[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\&quot;  The invitee will receive a notification that they have been invited to the repository, which they must accept or decline. They may do this via the notifications page, the email they receive, or by using the [repository invitations API endpoints](https://docs.github.com/rest/reference/repos#invitations).  **Updating an existing collaborator&#39;s permission level**  The endpoint can also be used to change the permissions of an existing collaborator without first removing and re-adding the collaborator. To change the permissions, use the same endpoint and pass a different &#x60;permission&#x60; parameter. The response will be a &#x60;204&#x60;, with no other indication that the permission level changed.  **Rate limits**  You are limited to sending 50 invitations to a repository per 24 hour period. Note there is no limit if you are inviting organization members to an organization repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="reposAddCollaboratorRequest"></param>
        /// <returns>RepositoryInvitation</returns>
        RepositoryInvitation ReposAddCollaborator (string owner, string repo, string username, ReposAddCollaboratorRequest reposAddCollaboratorRequest);
        /// <summary>
        /// Add status check contexts Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetStatusCheckContextsRequest"></param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> ReposAddStatusCheckContexts (string owner, string repo, string branch, ReposSetStatusCheckContextsRequest reposSetStatusCheckContextsRequest);
        /// <summary>
        /// Add team access restrictions Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Grants the specified teams push access for this branch. You can also give push access to child teams.  | Type    | Description                                                                                                                                | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | &#x60;array&#x60; | The teams that can have push access. Use the team&#39;s &#x60;slug&#x60;. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetTeamAccessRestrictionsRequest"></param>
        /// <returns>List&lt;Team&gt;</returns>
        List<Team> ReposAddTeamAccessRestrictions (string owner, string repo, string branch, ReposSetTeamAccessRestrictionsRequest reposSetTeamAccessRestrictionsRequest);
        /// <summary>
        /// Add user access restrictions Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Grants the specified people push access for this branch.  | Type    | Description                                                                                                                   | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | &#x60;array&#x60; | Usernames for people who can have push access. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetUserAccessRestrictionsRequest"></param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        List<SimpleUser1> ReposAddUserAccessRestrictions (string owner, string repo, string branch, ReposSetUserAccessRestrictionsRequest reposSetUserAccessRestrictionsRequest);
        /// <summary>
        /// Check if a user is a repository collaborator For organization-owned repositories, the list of collaborators includes outside collaborators, organization members that are direct collaborators, organization members with access through team memberships, organization members with access through default organization permissions, and organization owners.  Team members will include the members of child teams.  You must authenticate using an access token with the &#x60;read:org&#x60; and &#x60;repo&#x60; scopes with push access to use this endpoint. GitHub Apps must have the &#x60;members&#x60; organization permission and &#x60;metadata&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        void ReposCheckCollaborator (string owner, string repo, string username);
        /// <summary>
        /// Check if vulnerability alerts are enabled for a repository Shows whether dependency alerts are enabled or disabled for a repository. The authenticated user must have admin read access to the repository. For more information, see \&quot;[About security alerts for vulnerable dependencies](https://docs.github.com/en/articles/about-security-alerts-for-vulnerable-dependencies)\&quot;.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        void ReposCheckVulnerabilityAlerts (string owner, string repo);
        /// <summary>
        /// List CODEOWNERS errors List any syntax errors that are detected in the CODEOWNERS file.  For more information about the correct CODEOWNERS syntax, see \&quot;[About code owners](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/customizing-your-repository/about-code-owners).\&quot;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="_ref">A branch, tag or commit name used to determine which version of the CODEOWNERS file to use. Default: the repository&#39;s default branch (e.g. &#x60;main&#x60;)</param>
        /// <returns>CODEOWNERSErrors</returns>
        CODEOWNERSErrors ReposCodeownersErrors (string owner, string repo, string _ref);
        /// <summary>
        /// Compare two commits The &#x60;basehead&#x60; param is comprised of two parts: &#x60;base&#x60; and &#x60;head&#x60;. Both must be branch names in &#x60;repo&#x60;. To compare branches across other repositories in the same network as &#x60;repo&#x60;, use the format &#x60;&lt;USERNAME&gt;:branch&#x60;.  The response from the API is equivalent to running the &#x60;git log base..head&#x60; command; however, commits are returned in chronological order. Pass the appropriate [media type](https://docs.github.com/rest/overview/media-types/#commits-commit-comparison-and-pull-requests) to fetch diff and patch formats.  The response also includes details on the files that were changed between the two commits. This includes the status of the change (for example, if a file was added, removed, modified, or renamed), and details of the change itself. For example, files with a &#x60;renamed&#x60; status have a &#x60;previous_filename&#x60; field showing the previous filename of the file, and files with a &#x60;modified&#x60; status have a &#x60;patch&#x60; field showing the changes made to the file.  **Working with large comparisons**  To process a response with a large number of commits, you can use (&#x60;per_page&#x60; or &#x60;page&#x60;) to paginate the results. When using paging, the list of changed files is only returned with page 1, but includes all changed files for the entire comparison. For more information on working with pagination, see \&quot;[Traversing with pagination](/rest/guides/traversing-with-pagination).\&quot;  When calling this API without any paging parameters (&#x60;per_page&#x60; or &#x60;page&#x60;), the returned list is limited to 250 commits and the last commit in the list is the most recent of the entire comparison. When a paging parameter is specified, the first commit in the returned list of each page is the earliest.  **Signature verification object**  The response will include a &#x60;verification&#x60; object that describes the result of verifying the commit&#39;s signature. The following fields are included in the &#x60;verification&#x60; object:  | Name | Type | Description | | - -- - | - -- - | - -- -- -- -- -- | | &#x60;verified&#x60; | &#x60;boolean&#x60; | Indicates whether GitHub considers the signature in this commit to be verified. | | &#x60;reason&#x60; | &#x60;string&#x60; | The reason for verified value. Possible values and their meanings are enumerated in table below. | | &#x60;signature&#x60; | &#x60;string&#x60; | The signature that was extracted from the commit. | | &#x60;payload&#x60; | &#x60;string&#x60; | The value that was signed. |  These are the possible values for &#x60;reason&#x60; in the &#x60;verification&#x60; object:  | Value | Description | | - -- -- | - -- -- -- -- -- | | &#x60;expired_key&#x60; | The key that made the signature is expired. | | &#x60;not_signing_key&#x60; | The \&quot;signing\&quot; flag is not among the usage flags in the GPG key that made the signature. | | &#x60;gpgverify_error&#x60; | There was an error communicating with the signature verification service. | | &#x60;gpgverify_unavailable&#x60; | The signature verification service is currently unavailable. | | &#x60;unsigned&#x60; | The object does not include a signature. | | &#x60;unknown_signature_type&#x60; | A non-PGP signature was found in the commit. | | &#x60;no_user&#x60; | No user was associated with the &#x60;committer&#x60; email address in the commit. | | &#x60;unverified_email&#x60; | The &#x60;committer&#x60; email address in the commit was associated with a user, but the email address is not verified on her/his account. | | &#x60;bad_email&#x60; | The &#x60;committer&#x60; email address in the commit is not included in the identities of the PGP key that made the signature. | | &#x60;unknown_key&#x60; | The key that made the signature has not been registered with any user&#39;s account. | | &#x60;malformed_signature&#x60; | There was an error parsing the signature. | | &#x60;invalid&#x60; | The signature could not be cryptographically verified using the key whose key-id was found in the signature. | | &#x60;valid&#x60; | None of the above errors applied, so the signature is considered to be verified. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="basehead">The base branch and head branch to compare. This parameter expects the format &#x60;{base}...{head}&#x60;.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <returns>CommitComparison</returns>
        CommitComparison ReposCompareCommits (string owner, string repo, string basehead, int? page, int? perPage);
        /// <summary>
        /// Create an autolink reference for a repository Users with admin access to the repository can create an autolink.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposCreateAutolinkRequest"></param>
        /// <returns>AutolinkReference</returns>
        AutolinkReference ReposCreateAutolink (string owner, string repo, ReposCreateAutolinkRequest reposCreateAutolinkRequest);
        /// <summary>
        /// Create a commit comment Create a comment for a commit using its &#x60;:commit_sha&#x60;.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commitSha">The SHA of the commit.</param>
        /// <param name="reposCreateCommitCommentRequest"></param>
        /// <returns>CommitComment</returns>
        CommitComment ReposCreateCommitComment (string owner, string repo, string commitSha, ReposCreateCommitCommentRequest reposCreateCommitCommentRequest);
        /// <summary>
        /// Create commit signature protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  When authenticated with admin or owner permissions to the repository, you can use this endpoint to require signed commits on a branch. You must enable branch protection to require signed commits.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>ProtectedBranchAdminEnforced</returns>
        ProtectedBranchAdminEnforced ReposCreateCommitSignatureProtection (string owner, string repo, string branch);
        /// <summary>
        /// Create a commit status Users with push access in a repository can create commit statuses for a given SHA.  Note: there is a limit of 1000 statuses per &#x60;sha&#x60; and &#x60;context&#x60; within a repository. Attempts to create more than 1000 statuses will result in a validation error.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="sha"></param>
        /// <param name="reposCreateCommitStatusRequest"></param>
        /// <returns>Status</returns>
        Status ReposCreateCommitStatus (string owner, string repo, string sha, ReposCreateCommitStatusRequest reposCreateCommitStatusRequest);
        /// <summary>
        /// Create a deploy key You can create a read-only deploy key.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposCreateDeployKeyRequest"></param>
        /// <returns>DeployKey</returns>
        DeployKey ReposCreateDeployKey (string owner, string repo, ReposCreateDeployKeyRequest reposCreateDeployKeyRequest);
        /// <summary>
        /// Create a deployment Deployments offer a few configurable parameters with certain defaults.  The &#x60;ref&#x60; parameter can be any named branch, tag, or SHA. At GitHub we often deploy branches and verify them before we merge a pull request.  The &#x60;environment&#x60; parameter allows deployments to be issued to different runtime environments. Teams often have multiple environments for verifying their applications, such as &#x60;production&#x60;, &#x60;staging&#x60;, and &#x60;qa&#x60;. This parameter makes it easier to track which environments have requested deployments. The default environment is &#x60;production&#x60;.  The &#x60;auto_merge&#x60; parameter is used to ensure that the requested ref is not behind the repository&#39;s default branch. If the ref _is_ behind the default branch for the repository, we will attempt to merge it for you. If the merge succeeds, the API will return a successful merge commit. If merge conflicts prevent the merge from succeeding, the API will return a failure response.  By default, [commit statuses](https://docs.github.com/rest/commits/statuses) for every submitted context must be in a &#x60;success&#x60; state. The &#x60;required_contexts&#x60; parameter allows you to specify a subset of contexts that must be &#x60;success&#x60;, or to specify contexts that have not yet been submitted. You are not required to use commit statuses to deploy. If you do not require any contexts or create any commit statuses, the deployment will always succeed.  The &#x60;payload&#x60; parameter is available for any extra information that a deployment system might need. It is a JSON text field that will be passed on when a deployment event is dispatched.  The &#x60;task&#x60; parameter is used by the deployment system to allow different execution paths. In the web world this might be &#x60;deploy:migrations&#x60; to run schema changes on the system. In the compiled world this could be a flag to compile an application with debugging enabled.  Users with &#x60;repo&#x60; or &#x60;repo_deployment&#x60; scopes can create a deployment for a given ref.  #### Merged branch response You will see this response when GitHub automatically merges the base branch into the topic branch instead of creating a deployment. This auto-merge happens when: *   Auto-merge option is enabled in the repository *   Topic branch does not include the latest changes on the base branch, which is &#x60;master&#x60; in the response example *   There are no merge conflicts  If there are no new commits in the base branch, a new request to create a deployment should give a successful response.  #### Merge conflict response This error happens when the &#x60;auto_merge&#x60; option is enabled and when the default branch (in this case &#x60;master&#x60;), can&#39;t be merged into the branch that&#39;s being deployed (in this case &#x60;topic-branch&#x60;), due to merge conflicts.  #### Failed commit status checks This error happens when the &#x60;required_contexts&#x60; parameter indicates that one or more contexts need to have a &#x60;success&#x60; status for the commit to be deployed, but one or more of the required contexts do not have a state of &#x60;success&#x60;.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposCreateDeploymentRequest"></param>
        /// <returns>Deployment</returns>
        Deployment ReposCreateDeployment (string owner, string repo, ReposCreateDeploymentRequest reposCreateDeploymentRequest);
        /// <summary>
        /// Create a deployment status Users with &#x60;push&#x60; access can create deployment statuses for a given deployment.  GitHub Apps require &#x60;read &amp; write&#x60; access to \&quot;Deployments\&quot; and &#x60;read-only&#x60; access to \&quot;Repo contents\&quot; (for private repos). OAuth Apps require the &#x60;repo_deployment&#x60; scope.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="deploymentId">deployment_id parameter</param>
        /// <param name="reposCreateDeploymentStatusRequest"></param>
        /// <returns>DeploymentStatus</returns>
        DeploymentStatus ReposCreateDeploymentStatus (string owner, string repo, int? deploymentId, ReposCreateDeploymentStatusRequest reposCreateDeploymentStatusRequest);
        /// <summary>
        /// Create a repository dispatch event You can use this endpoint to trigger a webhook event called &#x60;repository_dispatch&#x60; when you want activity that happens outside of GitHub to trigger a GitHub Actions workflow or GitHub App webhook. You must configure your GitHub Actions workflow or GitHub App to run when the &#x60;repository_dispatch&#x60; event occurs. For an example &#x60;repository_dispatch&#x60; webhook payload, see \&quot;[RepositoryDispatchEvent](https://docs.github.com/webhooks/event-payloads/#repository_dispatch).\&quot;  The &#x60;client_payload&#x60; parameter is available for any extra information that your workflow might need. This parameter is a JSON payload that will be passed on when the webhook event is dispatched. For example, the &#x60;client_payload&#x60; can include a message that a user would like to send using a GitHub Actions workflow. Or the &#x60;client_payload&#x60; can be used as a test to debug your workflow.  This endpoint requires write access to the repository by providing either:    - Personal access tokens with &#x60;repo&#x60; scope. For more information, see \&quot;[Creating a personal access token for the command line](https://docs.github.com/articles/creating-a-personal-access-token-for-the-command-line)\&quot; in the GitHub Help documentation.   - GitHub Apps with both &#x60;metadata:read&#x60; and &#x60;contents:read&amp;write&#x60; permissions.  This input example shows how you can use the &#x60;client_payload&#x60; as a test to debug your workflow.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposCreateDispatchEventRequest"></param>
        /// <returns></returns>
        void ReposCreateDispatchEvent (string owner, string repo, ReposCreateDispatchEventRequest reposCreateDispatchEventRequest);
        /// <summary>
        /// Create a repository for the authenticated user Creates a new repository for the authenticated user.  **OAuth scope requirements**  When using [OAuth](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/), authorizations must include:  *   &#x60;public_repo&#x60; scope or &#x60;repo&#x60; scope to create a public repository. Note: For GitHub AE, use &#x60;repo&#x60; scope to create an internal repository. *   &#x60;repo&#x60; scope to create a private repository.
        /// </summary>
        /// <param name="reposCreateForAuthenticatedUserRequest"></param>
        /// <returns>Repository</returns>
        Repository ReposCreateForAuthenticatedUser (ReposCreateForAuthenticatedUserRequest reposCreateForAuthenticatedUserRequest);
        /// <summary>
        /// Create a fork Create a fork for the authenticated user.  **Note**: Forking a Repository happens asynchronously. You may have to wait a short period of time before you can access the git objects. If this takes longer than 5 minutes, be sure to contact [GitHub Support](https://support.github.com/contact?tags&#x3D;dotcom-rest-api).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposCreateForkRequest"></param>
        /// <returns>FullRepository</returns>
        FullRepository ReposCreateFork (string owner, string repo, ReposCreateForkRequest reposCreateForkRequest);
        /// <summary>
        /// Create an organization repository Creates a new repository in the specified organization. The authenticated user must be a member of the organization.  **OAuth scope requirements**  When using [OAuth](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/), authorizations must include:  *   &#x60;public_repo&#x60; scope or &#x60;repo&#x60; scope to create a public repository. Note: For GitHub AE, use &#x60;repo&#x60; scope to create an internal repository. *   &#x60;repo&#x60; scope to create a private repository
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="reposCreateInOrgRequest"></param>
        /// <returns>Repository</returns>
        Repository ReposCreateInOrg (string org, ReposCreateInOrgRequest reposCreateInOrgRequest);
        /// <summary>
        /// Create or update an environment Create or update an environment with protection rules, such as required reviewers. For more information about environment protection rules, see \&quot;[Environments](/actions/reference/environments#environment-protection-rules).\&quot;  **Note:** Although you can use this operation to specify that only branches that match specified name patterns can deploy to this environment, you must use the UI to set the name patterns. For more information, see \&quot;[Environments](/actions/reference/environments#deployment-branches).\&quot;  **Note:** To create or update secrets for an environment, see \&quot;[Secrets](/rest/reference/actions#secrets).\&quot;  You must authenticate using an access token with the repo scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="environmentName">The name of the environment</param>
        /// <param name="reposCreateOrUpdateEnvironmentRequest"></param>
        /// <returns>Environment</returns>
        Org.OpenAPITools.Model.Environment ReposCreateOrUpdateEnvironment (string owner, string repo, string environmentName, ReposCreateOrUpdateEnvironmentRequest reposCreateOrUpdateEnvironmentRequest);
        /// <summary>
        /// Create or update file contents Creates a new file or replaces an existing file in a repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="path">path parameter</param>
        /// <param name="reposCreateOrUpdateFileContentsRequest"></param>
        /// <returns>FileCommit</returns>
        FileCommit ReposCreateOrUpdateFileContents (string owner, string repo, string path, ReposCreateOrUpdateFileContentsRequest reposCreateOrUpdateFileContentsRequest);
        /// <summary>
        /// Create a GitHub Pages deployment Create a GitHub Pages deployment for a repository.  Users must have write permissions. GitHub Apps must have the &#x60;pages:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposCreatePagesDeploymentRequest"></param>
        /// <returns>GitHubPages1</returns>
        GitHubPages1 ReposCreatePagesDeployment (string owner, string repo, ReposCreatePagesDeploymentRequest reposCreatePagesDeploymentRequest);
        /// <summary>
        /// Create a GitHub Pages site Configures a GitHub Pages site. For more information, see \&quot;[About GitHub Pages](/github/working-with-github-pages/about-github-pages).\&quot;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposCreatePagesSiteRequest"></param>
        /// <returns>GitHubPages</returns>
        GitHubPages ReposCreatePagesSite (string owner, string repo, ReposCreatePagesSiteRequest reposCreatePagesSiteRequest);
        /// <summary>
        /// Create a release Users with push access to the repository can create a release.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposCreateReleaseRequest"></param>
        /// <returns>Release</returns>
        Release ReposCreateRelease (string owner, string repo, ReposCreateReleaseRequest reposCreateReleaseRequest);
        /// <summary>
        /// Create a tag protection state for a repository This creates a tag protection state for a repository. This endpoint is only available to repository administrators.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposCreateTagProtectionRequest"></param>
        /// <returns>TagProtection</returns>
        TagProtection ReposCreateTagProtection (string owner, string repo, ReposCreateTagProtectionRequest reposCreateTagProtectionRequest);
        /// <summary>
        /// Create a repository using a template Creates a new repository using a repository template. Use the &#x60;template_owner&#x60; and &#x60;template_repo&#x60; route parameters to specify the repository to use as the template. The authenticated user must own or be a member of an organization that owns the repository. To check if a repository is available to use as a template, get the repository&#39;s information using the [Get a repository](https://docs.github.com/rest/reference/repos#get-a-repository) endpoint and check that the &#x60;is_template&#x60; key is &#x60;true&#x60;.  **OAuth scope requirements**  When using [OAuth](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/), authorizations must include:  *   &#x60;public_repo&#x60; scope or &#x60;repo&#x60; scope to create a public repository. Note: For GitHub AE, use &#x60;repo&#x60; scope to create an internal repository. *   &#x60;repo&#x60; scope to create a private repository
        /// </summary>
        /// <param name="templateOwner"></param>
        /// <param name="templateRepo"></param>
        /// <param name="reposCreateUsingTemplateRequest"></param>
        /// <returns>Repository</returns>
        Repository ReposCreateUsingTemplate (string templateOwner, string templateRepo, ReposCreateUsingTemplateRequest reposCreateUsingTemplateRequest);
        /// <summary>
        /// Create a repository webhook Repositories can have multiple webhooks installed. Each webhook should have a unique &#x60;config&#x60;. Multiple webhooks can share the same &#x60;config&#x60; as long as those webhooks do not have any &#x60;events&#x60; that overlap.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposCreateWebhookRequest"></param>
        /// <returns>Webhook</returns>
        Webhook ReposCreateWebhook (string owner, string repo, ReposCreateWebhookRequest reposCreateWebhookRequest);
        /// <summary>
        /// Decline a repository invitation 
        /// </summary>
        /// <param name="invitationId">The unique identifier of the invitation.</param>
        /// <returns></returns>
        void ReposDeclineInvitationForAuthenticatedUser (int? invitationId);
        /// <summary>
        /// Delete a repository Deleting a repository requires admin access. If OAuth is used, the &#x60;delete_repo&#x60; scope is required.  If an organization owner has configured the organization to prevent members from deleting organization-owned repositories, you will get a &#x60;403 Forbidden&#x60; response.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        void ReposDelete (string owner, string repo);
        /// <summary>
        /// Delete access restrictions Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Disables the ability to restrict who can push to this branch.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns></returns>
        void ReposDeleteAccessRestrictions (string owner, string repo, string branch);
        /// <summary>
        /// Delete admin branch protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Removing admin enforcement requires admin or owner permissions to the repository and branch protection to be enabled.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns></returns>
        void ReposDeleteAdminBranchProtection (string owner, string repo, string branch);
        /// <summary>
        /// Delete an environment You must authenticate using an access token with the repo scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="environmentName">The name of the environment</param>
        /// <returns></returns>
        void ReposDeleteAnEnvironment (string owner, string repo, string environmentName);
        /// <summary>
        /// Delete an autolink reference from a repository This deletes a single autolink reference by ID that was configured for the given repository.  Information about autolinks are only available to repository administrators.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="autolinkId">The unique identifier of the autolink.</param>
        /// <returns></returns>
        void ReposDeleteAutolink (string owner, string repo, int? autolinkId);
        /// <summary>
        /// Delete branch protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns></returns>
        void ReposDeleteBranchProtection (string owner, string repo, string branch);
        /// <summary>
        /// Delete a commit comment 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <returns></returns>
        void ReposDeleteCommitComment (string owner, string repo, int? commentId);
        /// <summary>
        /// Delete commit signature protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  When authenticated with admin or owner permissions to the repository, you can use this endpoint to disable required signed commits on a branch. You must enable branch protection to require signed commits.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns></returns>
        void ReposDeleteCommitSignatureProtection (string owner, string repo, string branch);
        /// <summary>
        /// Delete a deploy key Deploy keys are immutable. If you need to update a key, remove the key and create a new one instead.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="keyId">The unique identifier of the key.</param>
        /// <returns></returns>
        void ReposDeleteDeployKey (string owner, string repo, int? keyId);
        /// <summary>
        /// Delete a deployment If the repository only has one deployment, you can delete the deployment regardless of its status. If the repository has more than one deployment, you can only delete inactive deployments. This ensures that repositories with multiple deployments will always have an active deployment. Anyone with &#x60;repo&#x60; or &#x60;repo_deployment&#x60; scopes can delete a deployment.  To set a deployment as inactive, you must:  *   Create a new deployment that is active so that the system has a record of the current state, then delete the previously active deployment. *   Mark the active deployment as inactive by adding any non-successful deployment status.  For more information, see \&quot;[Create a deployment](https://docs.github.com/rest/reference/repos/#create-a-deployment)\&quot; and \&quot;[Create a deployment status](https://docs.github.com/rest/reference/repos#create-a-deployment-status).\&quot;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="deploymentId">deployment_id parameter</param>
        /// <returns></returns>
        void ReposDeleteDeployment (string owner, string repo, int? deploymentId);
        /// <summary>
        /// Delete a file Deletes a file in a repository.  You can provide an additional &#x60;committer&#x60; parameter, which is an object containing information about the committer. Or, you can provide an &#x60;author&#x60; parameter, which is an object containing information about the author.  The &#x60;author&#x60; section is optional and is filled in with the &#x60;committer&#x60; information if omitted. If the &#x60;committer&#x60; information is omitted, the authenticated user&#39;s information is used.  You must provide values for both &#x60;name&#x60; and &#x60;email&#x60;, whether you choose to use &#x60;author&#x60; or &#x60;committer&#x60;. Otherwise, you&#39;ll receive a &#x60;422&#x60; status code.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="path">path parameter</param>
        /// <param name="reposDeleteFileRequest"></param>
        /// <returns>FileCommit</returns>
        FileCommit ReposDeleteFile (string owner, string repo, string path, ReposDeleteFileRequest reposDeleteFileRequest);
        /// <summary>
        /// Delete a repository invitation 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="invitationId">The unique identifier of the invitation.</param>
        /// <returns></returns>
        void ReposDeleteInvitation (string owner, string repo, int? invitationId);
        /// <summary>
        /// Delete a GitHub Pages site 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        void ReposDeletePagesSite (string owner, string repo);
        /// <summary>
        /// Delete pull request review protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns></returns>
        void ReposDeletePullRequestReviewProtection (string owner, string repo, string branch);
        /// <summary>
        /// Delete a release Users with push access to the repository can delete a release.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="releaseId">The unique identifier of the release.</param>
        /// <returns></returns>
        void ReposDeleteRelease (string owner, string repo, int? releaseId);
        /// <summary>
        /// Delete a release asset 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="assetId">The unique identifier of the asset.</param>
        /// <returns></returns>
        void ReposDeleteReleaseAsset (string owner, string repo, int? assetId);
        /// <summary>
        /// Delete a tag protection state for a repository This deletes a tag protection state for a repository. This endpoint is only available to repository administrators.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="tagProtectionId">The unique identifier of the tag protection.</param>
        /// <returns></returns>
        void ReposDeleteTagProtection (string owner, string repo, int? tagProtectionId);
        /// <summary>
        /// Delete a repository webhook 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <returns></returns>
        void ReposDeleteWebhook (string owner, string repo, int? hookId);
        /// <summary>
        /// Disable automated security fixes Disables automated security fixes for a repository. The authenticated user must have admin access to the repository. For more information, see \&quot;[Configuring automated security fixes](https://docs.github.com/en/articles/configuring-automated-security-fixes)\&quot;.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        void ReposDisableAutomatedSecurityFixes (string owner, string repo);
        /// <summary>
        /// Disable Git LFS for a repository 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        void ReposDisableLfsForRepo (string owner, string repo);
        /// <summary>
        /// Disable vulnerability alerts Disables dependency alerts and the dependency graph for a repository. The authenticated user must have admin access to the repository. For more information, see \&quot;[About security alerts for vulnerable dependencies](https://docs.github.com/en/articles/about-security-alerts-for-vulnerable-dependencies)\&quot;.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        void ReposDisableVulnerabilityAlerts (string owner, string repo);
        /// <summary>
        /// Download a repository archive (tar) Gets a redirect URL to download a tar archive for a repository. If you omit &#x60;:ref&#x60;, the repository’s default branch (usually &#x60;master&#x60;) will be used. Please make sure your HTTP framework is configured to follow redirects or you will need to use the &#x60;Location&#x60; header to make a second &#x60;GET&#x60; request. **Note**: For private repositories, these links are temporary and expire after five minutes.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="_ref"></param>
        /// <returns></returns>
        void ReposDownloadTarballArchive (string owner, string repo, string _ref);
        /// <summary>
        /// Download a repository archive (zip) Gets a redirect URL to download a zip archive for a repository. If you omit &#x60;:ref&#x60;, the repository’s default branch (usually &#x60;master&#x60;) will be used. Please make sure your HTTP framework is configured to follow redirects or you will need to use the &#x60;Location&#x60; header to make a second &#x60;GET&#x60; request.  **Note**: For private repositories, these links are temporary and expire after five minutes. If the repository is empty, you will receive a 404 when you follow the redirect.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="_ref"></param>
        /// <returns></returns>
        void ReposDownloadZipballArchive (string owner, string repo, string _ref);
        /// <summary>
        /// Enable automated security fixes Enables automated security fixes for a repository. The authenticated user must have admin access to the repository. For more information, see \&quot;[Configuring automated security fixes](https://docs.github.com/en/articles/configuring-automated-security-fixes)\&quot;.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        void ReposEnableAutomatedSecurityFixes (string owner, string repo);
        /// <summary>
        /// Enable Git LFS for a repository 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>Object</returns>
        Object ReposEnableLfsForRepo (string owner, string repo);
        /// <summary>
        /// Enable vulnerability alerts Enables dependency alerts and the dependency graph for a repository. The authenticated user must have admin access to the repository. For more information, see \&quot;[About security alerts for vulnerable dependencies](https://docs.github.com/en/articles/about-security-alerts-for-vulnerable-dependencies)\&quot;.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        void ReposEnableVulnerabilityAlerts (string owner, string repo);
        /// <summary>
        /// Generate release notes content for a release Generate a name and body describing a [release](https://docs.github.com/rest/reference/repos#releases). The body content will be markdown formatted and contain information like the changes since last release and users who contributed. The generated release notes are not saved anywhere. They are intended to be generated and used when creating a new release.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposGenerateReleaseNotesRequest"></param>
        /// <returns>GeneratedReleaseNotesContent</returns>
        GeneratedReleaseNotesContent ReposGenerateReleaseNotes (string owner, string repo, ReposGenerateReleaseNotesRequest reposGenerateReleaseNotesRequest);
        /// <summary>
        /// Get a repository The &#x60;parent&#x60; and &#x60;source&#x60; objects are present when the repository is a fork. &#x60;parent&#x60; is the repository this repository was forked from, &#x60;source&#x60; is the ultimate source for the network.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>FullRepository</returns>
        FullRepository ReposGet (string owner, string repo);
        /// <summary>
        /// Get access restrictions Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Lists who has access to this protected branch.  **Note**: Users, apps, and teams &#x60;restrictions&#x60; are only available for organization-owned repositories.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>BranchRestrictionPolicy</returns>
        BranchRestrictionPolicy ReposGetAccessRestrictions (string owner, string repo, string branch);
        /// <summary>
        /// Get admin branch protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>ProtectedBranchAdminEnforced</returns>
        ProtectedBranchAdminEnforced ReposGetAdminBranchProtection (string owner, string repo, string branch);
        /// <summary>
        /// Get all environments Get all environments for a repository.  Anyone with read access to the repository can use this endpoint. If the repository is private, you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ReposGetAllEnvironments200Response</returns>
        ReposGetAllEnvironments200Response ReposGetAllEnvironments (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// Get all status check contexts Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> ReposGetAllStatusCheckContexts (string owner, string repo, string branch);
        /// <summary>
        /// Get all repository topics 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <returns>Topic</returns>
        Topic ReposGetAllTopics (string owner, string repo, int? page, int? perPage);
        /// <summary>
        /// Get apps with access to the protected branch Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Lists the GitHub Apps that have push access to this branch. Only installed GitHub Apps with &#x60;write&#x60; access to the &#x60;contents&#x60; permission can be added as authorized actors on a protected branch.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>List&lt;GitHubApp&gt;</returns>
        List<GitHubApp> ReposGetAppsWithAccessToProtectedBranch (string owner, string repo, string branch);
        /// <summary>
        /// Get an autolink reference of a repository This returns a single autolink reference by ID that was configured for the given repository.  Information about autolinks are only available to repository administrators.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="autolinkId">The unique identifier of the autolink.</param>
        /// <returns>AutolinkReference</returns>
        AutolinkReference ReposGetAutolink (string owner, string repo, int? autolinkId);
        /// <summary>
        /// Get a branch 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>BranchWithProtection</returns>
        BranchWithProtection ReposGetBranch (string owner, string repo, string branch);
        /// <summary>
        /// Get branch protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>BranchProtection</returns>
        BranchProtection ReposGetBranchProtection (string owner, string repo, string branch);
        /// <summary>
        /// Get repository clones Get the total number of clones and breakdown per day or week for the last 14 days. Timestamps are aligned to UTC midnight of the beginning of the day or week. Week begins on Monday.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="per">The time frame to display results for.</param>
        /// <returns>CloneTraffic</returns>
        CloneTraffic ReposGetClones (string owner, string repo, string per);
        /// <summary>
        /// Get the weekly commit activity Returns a weekly aggregate of the number of additions and deletions pushed to a repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>List&lt;List&lt;int?&gt;&gt;</returns>
        List<List<int?>> ReposGetCodeFrequencyStats (string owner, string repo);
        /// <summary>
        /// Get repository permissions for a user Checks the repository permission of a collaborator. The possible repository permissions are &#x60;admin&#x60;, &#x60;write&#x60;, &#x60;read&#x60;, and &#x60;none&#x60;.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>RepositoryCollaboratorPermission</returns>
        RepositoryCollaboratorPermission ReposGetCollaboratorPermissionLevel (string owner, string repo, string username);
        /// <summary>
        /// Get the combined status for a specific reference Users with pull access in a repository can access a combined view of commit statuses for a given ref. The ref can be a SHA, a branch name, or a tag name.   Additionally, a combined &#x60;state&#x60; is returned. The &#x60;state&#x60; is one of:  *   **failure** if any of the contexts report as &#x60;error&#x60; or &#x60;failure&#x60; *   **pending** if there are no statuses or a context is &#x60;pending&#x60; *   **success** if the latest status for all contexts is &#x60;success&#x60;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="_ref">ref parameter</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>CombinedCommitStatus</returns>
        CombinedCommitStatus ReposGetCombinedStatusForRef (string owner, string repo, string _ref, int? perPage, int? page);
        /// <summary>
        /// Get a commit Returns the contents of a single commit reference. You must have &#x60;read&#x60; access for the repository to use this endpoint.  **Note:** If there are more than 300 files in the commit diff, the response will include pagination link headers for the remaining files, up to a limit of 3000 files. Each page contains the static commit information, and the only changes are to the file listing.  You can pass the appropriate [media type](https://docs.github.com/rest/overview/media-types/#commits-commit-comparison-and-pull-requests) to  fetch &#x60;diff&#x60; and &#x60;patch&#x60; formats. Diffs with binary data will have no &#x60;patch&#x60; property.  To return only the SHA-1 hash of the commit reference, you can provide the &#x60;sha&#x60; custom [media type](https://docs.github.com/rest/overview/media-types/#commits-commit-comparison-and-pull-requests) in the &#x60;Accept&#x60; header. You can use this endpoint to check if a remote reference&#39;s SHA-1 hash is the same as your local reference&#39;s SHA-1 hash by providing the local SHA-1 reference as the ETag.  **Signature verification object**  The response will include a &#x60;verification&#x60; object that describes the result of verifying the commit&#39;s signature. The following fields are included in the &#x60;verification&#x60; object:  | Name | Type | Description | | - -- - | - -- - | - -- -- -- -- -- | | &#x60;verified&#x60; | &#x60;boolean&#x60; | Indicates whether GitHub considers the signature in this commit to be verified. | | &#x60;reason&#x60; | &#x60;string&#x60; | The reason for verified value. Possible values and their meanings are enumerated in table below. | | &#x60;signature&#x60; | &#x60;string&#x60; | The signature that was extracted from the commit. | | &#x60;payload&#x60; | &#x60;string&#x60; | The value that was signed. |  These are the possible values for &#x60;reason&#x60; in the &#x60;verification&#x60; object:  | Value | Description | | - -- -- | - -- -- -- -- -- | | &#x60;expired_key&#x60; | The key that made the signature is expired. | | &#x60;not_signing_key&#x60; | The \&quot;signing\&quot; flag is not among the usage flags in the GPG key that made the signature. | | &#x60;gpgverify_error&#x60; | There was an error communicating with the signature verification service. | | &#x60;gpgverify_unavailable&#x60; | The signature verification service is currently unavailable. | | &#x60;unsigned&#x60; | The object does not include a signature. | | &#x60;unknown_signature_type&#x60; | A non-PGP signature was found in the commit. | | &#x60;no_user&#x60; | No user was associated with the &#x60;committer&#x60; email address in the commit. | | &#x60;unverified_email&#x60; | The &#x60;committer&#x60; email address in the commit was associated with a user, but the email address is not verified on her/his account. | | &#x60;bad_email&#x60; | The &#x60;committer&#x60; email address in the commit is not included in the identities of the PGP key that made the signature. | | &#x60;unknown_key&#x60; | The key that made the signature has not been registered with any user&#39;s account. | | &#x60;malformed_signature&#x60; | There was an error parsing the signature. | | &#x60;invalid&#x60; | The signature could not be cryptographically verified using the key whose key-id was found in the signature. | | &#x60;valid&#x60; | None of the above errors applied, so the signature is considered to be verified. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="_ref">ref parameter</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <returns>Commit</returns>
        Commit ReposGetCommit (string owner, string repo, string _ref, int? page, int? perPage);
        /// <summary>
        /// Get the last year of commit activity Returns the last year of commit activity grouped by week. The &#x60;days&#x60; array is a group of commits per day, starting on &#x60;Sunday&#x60;.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>List&lt;CommitActivity&gt;</returns>
        List<CommitActivity> ReposGetCommitActivityStats (string owner, string repo);
        /// <summary>
        /// Get a commit comment 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <returns>CommitComment</returns>
        CommitComment ReposGetCommitComment (string owner, string repo, int? commentId);
        /// <summary>
        /// Get commit signature protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  When authenticated with admin or owner permissions to the repository, you can use this endpoint to check whether a branch requires signed commits. An enabled status of &#x60;true&#x60; indicates you must sign commits on this branch. For more information, see [Signing commits with GPG](https://docs.github.com/articles/signing-commits-with-gpg) in GitHub Help.  **Note**: You must enable branch protection to require signed commits.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>ProtectedBranchAdminEnforced</returns>
        ProtectedBranchAdminEnforced ReposGetCommitSignatureProtection (string owner, string repo, string branch);
        /// <summary>
        /// Get community profile metrics This endpoint will return all community profile metrics, including an overall health score, repository description, the presence of documentation, detected code of conduct, detected license, and the presence of ISSUE\\_TEMPLATE, PULL\\_REQUEST\\_TEMPLATE, README, and CONTRIBUTING files.  The &#x60;health_percentage&#x60; score is defined as a percentage of how many of these four documents are present: README, CONTRIBUTING, LICENSE, and CODE_OF_CONDUCT. For example, if all four documents are present, then the &#x60;health_percentage&#x60; is &#x60;100&#x60;. If only one is present, then the &#x60;health_percentage&#x60; is &#x60;25&#x60;.  &#x60;content_reports_enabled&#x60; is only returned for organization-owned repositories.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>CommunityProfile</returns>
        CommunityProfile ReposGetCommunityProfileMetrics (string owner, string repo);
        /// <summary>
        /// Get repository content Gets the contents of a file or directory in a repository. Specify the file path or directory in &#x60;:path&#x60;. If you omit &#x60;:path&#x60;, you will receive the contents of the repository&#39;s root directory. See the description below regarding what the API response includes for directories.   Files and symlinks support [a custom media type](https://docs.github.com/rest/reference/repos#custom-media-types) for retrieving the raw content or rendered HTML (when supported). All content types support [a custom media type](https://docs.github.com/rest/reference/repos#custom-media-types) to ensure the content is returned in a consistent object format.  **Note**: *   To get a repository&#39;s contents recursively, you can [recursively get the tree](https://docs.github.com/rest/reference/git#trees). *   This API has an upper limit of 1,000 files for a directory. If you need to retrieve more files, use the [Git Trees API](https://docs.github.com/rest/reference/git#get-a-tree).  #### Size limits If the requested file&#39;s size is: * 1 MB or smaller: All features of this endpoint are supported. * Between 1-100 MB: Only the &#x60;raw&#x60; or &#x60;object&#x60; [custom media types](https://docs.github.com/rest/repos/contents#custom-media-types-for-repository-contents) are supported. Both will work as normal, except that when using the &#x60;object&#x60; media type, the &#x60;content&#x60; field will be an empty string and the &#x60;encoding&#x60; field will be &#x60;\&quot;none\&quot;&#x60;. To get the contents of these larger files, use the &#x60;raw&#x60; media type.  * Greater than 100 MB: This endpoint is not supported.  #### If the content is a directory The response will be an array of objects, one object for each item in the directory. When listing the contents of a directory, submodules have their \&quot;type\&quot; specified as \&quot;file\&quot;. Logically, the value _should_ be \&quot;submodule\&quot;. This behavior exists in API v3 [for backwards compatibility purposes](https://git.io/v1YCW). In the next major version of the API, the type will be returned as \&quot;submodule\&quot;.  #### If the content is a symlink  If the requested &#x60;:path&#x60; points to a symlink, and the symlink&#39;s target is a normal file in the repository, then the API responds with the content of the file (in the format shown in the example. Otherwise, the API responds with an object  describing the symlink itself.  #### If the content is a submodule The &#x60;submodule_git_url&#x60; identifies the location of the submodule repository, and the &#x60;sha&#x60; identifies a specific commit within the submodule repository. Git uses the given URL when cloning the submodule repository, and checks out the submodule at that specific commit.  If the submodule repository is not hosted on github.com, the Git URLs (&#x60;git_url&#x60; and &#x60;_links[\&quot;git\&quot;]&#x60;) and the github.com URLs (&#x60;html_url&#x60; and &#x60;_links[\&quot;html\&quot;]&#x60;) will have null values.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="path">path parameter</param>
        /// <param name="_ref">The name of the commit/branch/tag. Default: the repository’s default branch (usually &#x60;master&#x60;)</param>
        /// <returns>ContentTree</returns>
        ContentTree ReposGetContent (string owner, string repo, string path, string _ref);
        /// <summary>
        /// Get all contributor commit activity  Returns the &#x60;total&#x60; number of commits authored by the contributor. In addition, the response includes a Weekly Hash (&#x60;weeks&#x60; array) with the following information:  *   &#x60;w&#x60; - Start of the week, given as a [Unix timestamp](http://en.wikipedia.org/wiki/Unix_time). *   &#x60;a&#x60; - Number of additions *   &#x60;d&#x60; - Number of deletions *   &#x60;c&#x60; - Number of commits
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>List&lt;ContributorActivity&gt;</returns>
        List<ContributorActivity> ReposGetContributorsStats (string owner, string repo);
        /// <summary>
        /// Get a deploy key 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="keyId">The unique identifier of the key.</param>
        /// <returns>DeployKey</returns>
        DeployKey ReposGetDeployKey (string owner, string repo, int? keyId);
        /// <summary>
        /// Get a deployment 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="deploymentId">deployment_id parameter</param>
        /// <returns>Deployment</returns>
        Deployment ReposGetDeployment (string owner, string repo, int? deploymentId);
        /// <summary>
        /// Get a deployment status Users with pull access can view a deployment status for a deployment:
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="deploymentId">deployment_id parameter</param>
        /// <param name="statusId"></param>
        /// <returns>DeploymentStatus</returns>
        DeploymentStatus ReposGetDeploymentStatus (string owner, string repo, int? deploymentId, int? statusId);
        /// <summary>
        /// Get an environment Anyone with read access to the repository can use this endpoint. If the repository is private, you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="environmentName">The name of the environment</param>
        /// <returns>Environment</returns>
        Org.OpenAPITools.Model.Environment ReposGetEnvironment (string owner, string repo, string environmentName);
        /// <summary>
        /// Get latest Pages build 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>PageBuild</returns>
        PageBuild ReposGetLatestPagesBuild (string owner, string repo);
        /// <summary>
        /// Get the latest release View the latest published full release for the repository.  The latest release is the most recent non-prerelease, non-draft release, sorted by the &#x60;created_at&#x60; attribute. The &#x60;created_at&#x60; attribute is the date of the commit used for the release, and not the date when the release was drafted or published.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>Release</returns>
        Release ReposGetLatestRelease (string owner, string repo);
        /// <summary>
        /// Get a GitHub Pages site 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>GitHubPages</returns>
        GitHubPages ReposGetPages (string owner, string repo);
        /// <summary>
        /// Get GitHub Pages build 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="buildId"></param>
        /// <returns>PageBuild</returns>
        PageBuild ReposGetPagesBuild (string owner, string repo, int? buildId);
        /// <summary>
        /// Get a DNS health check for GitHub Pages Gets a health check of the DNS settings for the &#x60;CNAME&#x60; record configured for a repository&#39;s GitHub Pages.  The first request to this endpoint returns a &#x60;202 Accepted&#x60; status and starts an asynchronous background task to get the results for the domain. After the background task completes, subsequent requests to this endpoint return a &#x60;200 OK&#x60; status with the health check results in the response.  Users must have admin or owner permissions. GitHub Apps must have the &#x60;pages:write&#x60; and &#x60;administration:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>PagesHealthCheckStatus</returns>
        PagesHealthCheckStatus ReposGetPagesHealthCheck (string owner, string repo);
        /// <summary>
        /// Get the weekly commit count Returns the total commit counts for the &#x60;owner&#x60; and total commit counts in &#x60;all&#x60;. &#x60;all&#x60; is everyone combined, including the &#x60;owner&#x60; in the last 52 weeks. If you&#39;d like to get the commit counts for non-owners, you can subtract &#x60;owner&#x60; from &#x60;all&#x60;.  The array order is oldest week (index 0) to most recent week.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>ParticipationStats</returns>
        ParticipationStats ReposGetParticipationStats (string owner, string repo);
        /// <summary>
        /// Get pull request review protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>ProtectedBranchPullRequestReview</returns>
        ProtectedBranchPullRequestReview ReposGetPullRequestReviewProtection (string owner, string repo, string branch);
        /// <summary>
        /// Get the hourly commit count for each day Each array contains the day number, hour number, and number of commits:  *   &#x60;0-6&#x60;: Sunday - Saturday *   &#x60;0-23&#x60;: Hour of day *   Number of commits  For example, &#x60;[2, 14, 25]&#x60; indicates that there were 25 total commits, during the 2:00pm hour on Tuesdays. All times are based on the time zone of individual commits.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>List&lt;List&lt;int?&gt;&gt;</returns>
        List<List<int?>> ReposGetPunchCardStats (string owner, string repo);
        /// <summary>
        /// Get a repository README Gets the preferred README for a repository.  READMEs support [custom media types](https://docs.github.com/rest/reference/repos#custom-media-types) for retrieving the raw content or rendered HTML.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="_ref">The name of the commit/branch/tag. Default: the repository’s default branch (usually &#x60;master&#x60;)</param>
        /// <returns>ContentFile</returns>
        ContentFile ReposGetReadme (string owner, string repo, string _ref);
        /// <summary>
        /// Get a repository README for a directory Gets the README from a repository directory.  READMEs support [custom media types](https://docs.github.com/rest/reference/repos#custom-media-types) for retrieving the raw content or rendered HTML.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="dir">The alternate path to look for a README file</param>
        /// <param name="_ref">The name of the commit/branch/tag. Default: the repository’s default branch (usually &#x60;master&#x60;)</param>
        /// <returns>ContentFile</returns>
        ContentFile ReposGetReadmeInDirectory (string owner, string repo, string dir, string _ref);
        /// <summary>
        /// Get a release **Note:** This returns an &#x60;upload_url&#x60; key corresponding to the endpoint for uploading release assets. This key is a [hypermedia resource](https://docs.github.com/rest/overview/resources-in-the-rest-api#hypermedia).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="releaseId">The unique identifier of the release.</param>
        /// <returns>Release</returns>
        Release ReposGetRelease (string owner, string repo, int? releaseId);
        /// <summary>
        /// Get a release asset To download the asset&#39;s binary content, set the &#x60;Accept&#x60; header of the request to [&#x60;application/octet-stream&#x60;](https://docs.github.com/rest/overview/media-types). The API will either redirect the client to the location, or stream it directly if possible. API clients should handle both a &#x60;200&#x60; or &#x60;302&#x60; response.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="assetId">The unique identifier of the asset.</param>
        /// <returns>ReleaseAsset</returns>
        ReleaseAsset ReposGetReleaseAsset (string owner, string repo, int? assetId);
        /// <summary>
        /// Get a release by tag name Get a published release with the specified tag.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="tag">tag parameter</param>
        /// <returns>Release</returns>
        Release ReposGetReleaseByTag (string owner, string repo, string tag);
        /// <summary>
        /// Get status checks protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>StatusCheckPolicy</returns>
        StatusCheckPolicy ReposGetStatusChecksProtection (string owner, string repo, string branch);
        /// <summary>
        /// Get teams with access to the protected branch Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Lists the teams who have push access to this branch. The list includes child teams.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>List&lt;Team&gt;</returns>
        List<Team> ReposGetTeamsWithAccessToProtectedBranch (string owner, string repo, string branch);
        /// <summary>
        /// Get top referral paths Get the top 10 popular contents over the last 14 days.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>List&lt;ContentTraffic&gt;</returns>
        List<ContentTraffic> ReposGetTopPaths (string owner, string repo);
        /// <summary>
        /// Get top referral sources Get the top 10 referrers over the last 14 days.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>List&lt;ReferrerTraffic&gt;</returns>
        List<ReferrerTraffic> ReposGetTopReferrers (string owner, string repo);
        /// <summary>
        /// Get users with access to the protected branch Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Lists the people who have push access to this branch.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        List<SimpleUser1> ReposGetUsersWithAccessToProtectedBranch (string owner, string repo, string branch);
        /// <summary>
        /// Get page views Get the total number of views and breakdown per day or week for the last 14 days. Timestamps are aligned to UTC midnight of the beginning of the day or week. Week begins on Monday.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="per">The time frame to display results for.</param>
        /// <returns>ViewTraffic</returns>
        ViewTraffic ReposGetViews (string owner, string repo, string per);
        /// <summary>
        /// Get a repository webhook Returns a webhook configured in a repository. To get only the webhook &#x60;config&#x60; properties, see \&quot;[Get a webhook configuration for a repository](/rest/reference/repos#get-a-webhook-configuration-for-a-repository).\&quot;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <returns>Webhook</returns>
        Webhook ReposGetWebhook (string owner, string repo, int? hookId);
        /// <summary>
        /// Get a webhook configuration for a repository Returns the webhook configuration for a repository. To get more information about the webhook, including the &#x60;active&#x60; state and &#x60;events&#x60;, use \&quot;[Get a repository webhook](/rest/reference/orgs#get-a-repository-webhook).\&quot;  Access tokens must have the &#x60;read:repo_hook&#x60; or &#x60;repo&#x60; scope, and GitHub Apps must have the &#x60;repository_hooks:read&#x60; permission.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <returns>WebhookConfiguration</returns>
        WebhookConfiguration ReposGetWebhookConfigForRepo (string owner, string repo, int? hookId);
        /// <summary>
        /// Get a delivery for a repository webhook Returns a delivery for a webhook configured in a repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <param name="deliveryId"></param>
        /// <returns>WebhookDelivery</returns>
        WebhookDelivery ReposGetWebhookDelivery (string owner, string repo, int? hookId, int? deliveryId);
        /// <summary>
        /// List all autolinks of a repository This returns a list of autolinks configured for the given repository.  Information about autolinks are only available to repository administrators.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;AutolinkReference&gt;</returns>
        List<AutolinkReference> ReposListAutolinks (string owner, string repo, int? page);
        /// <summary>
        /// List branches 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="_protected">Setting to &#x60;true&#x60; returns only protected branches. When set to &#x60;false&#x60;, only unprotected branches are returned. Omitting this parameter returns all branches.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;ShortBranch&gt;</returns>
        List<ShortBranch> ReposListBranches (string owner, string repo, bool? _protected, int? perPage, int? page);
        /// <summary>
        /// List branches for HEAD commit Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Returns all branches where the given commit SHA is the HEAD, or latest commit for the branch.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commitSha">The SHA of the commit.</param>
        /// <returns>List&lt;BranchShort&gt;</returns>
        List<BranchShort> ReposListBranchesForHeadCommit (string owner, string repo, string commitSha);
        /// <summary>
        /// List repository collaborators For organization-owned repositories, the list of collaborators includes outside collaborators, organization members that are direct collaborators, organization members with access through team memberships, organization members with access through default organization permissions, and organization owners. Organization members with write, maintain, or admin privileges on the organization-owned repository can use this endpoint.  Team members will include the members of child teams.  You must authenticate using an access token with the &#x60;read:org&#x60; and &#x60;repo&#x60; scopes with push access to use this endpoint. GitHub Apps must have the &#x60;members&#x60; organization permission and &#x60;metadata&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="affiliation">Filter collaborators returned by their affiliation. &#x60;outside&#x60; means all outside collaborators of an organization-owned repository. &#x60;direct&#x60; means all collaborators with permissions to an organization-owned repository, regardless of organization membership status. &#x60;all&#x60; means all collaborators the authenticated user can see.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Collaborator&gt;</returns>
        List<Collaborator> ReposListCollaborators (string owner, string repo, string affiliation, int? perPage, int? page);
        /// <summary>
        /// List commit comments Use the &#x60;:commit_sha&#x60; to specify the commit that will have its comments listed.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commitSha">The SHA of the commit.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;CommitComment&gt;</returns>
        List<CommitComment> ReposListCommentsForCommit (string owner, string repo, string commitSha, int? perPage, int? page);
        /// <summary>
        /// List commit comments for a repository Commit Comments use [these custom media types](https://docs.github.com/rest/reference/repos#custom-media-types). You can read more about the use of media types in the API [here](https://docs.github.com/rest/overview/media-types/).  Comments are ordered by ascending ID.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;CommitComment&gt;</returns>
        List<CommitComment> ReposListCommitCommentsForRepo (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// List commit statuses for a reference Users with pull access in a repository can view commit statuses for a given ref. The ref can be a SHA, a branch name, or a tag name. Statuses are returned in reverse chronological order. The first status in the list will be the latest one.  This resource is also available via a legacy route: &#x60;GET /repos/:owner/:repo/statuses/:ref&#x60;.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="_ref">ref parameter</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Status&gt;</returns>
        List<Status> ReposListCommitStatusesForRef (string owner, string repo, string _ref, int? perPage, int? page);
        /// <summary>
        /// List commits **Signature verification object**  The response will include a &#x60;verification&#x60; object that describes the result of verifying the commit&#39;s signature. The following fields are included in the &#x60;verification&#x60; object:  | Name | Type | Description | | - -- - | - -- - | - -- -- -- -- -- | | &#x60;verified&#x60; | &#x60;boolean&#x60; | Indicates whether GitHub considers the signature in this commit to be verified. | | &#x60;reason&#x60; | &#x60;string&#x60; | The reason for verified value. Possible values and their meanings are enumerated in table below. | | &#x60;signature&#x60; | &#x60;string&#x60; | The signature that was extracted from the commit. | | &#x60;payload&#x60; | &#x60;string&#x60; | The value that was signed. |  These are the possible values for &#x60;reason&#x60; in the &#x60;verification&#x60; object:  | Value | Description | | - -- -- | - -- -- -- -- -- | | &#x60;expired_key&#x60; | The key that made the signature is expired. | | &#x60;not_signing_key&#x60; | The \&quot;signing\&quot; flag is not among the usage flags in the GPG key that made the signature. | | &#x60;gpgverify_error&#x60; | There was an error communicating with the signature verification service. | | &#x60;gpgverify_unavailable&#x60; | The signature verification service is currently unavailable. | | &#x60;unsigned&#x60; | The object does not include a signature. | | &#x60;unknown_signature_type&#x60; | A non-PGP signature was found in the commit. | | &#x60;no_user&#x60; | No user was associated with the &#x60;committer&#x60; email address in the commit. | | &#x60;unverified_email&#x60; | The &#x60;committer&#x60; email address in the commit was associated with a user, but the email address is not verified on her/his account. | | &#x60;bad_email&#x60; | The &#x60;committer&#x60; email address in the commit is not included in the identities of the PGP key that made the signature. | | &#x60;unknown_key&#x60; | The key that made the signature has not been registered with any user&#39;s account. | | &#x60;malformed_signature&#x60; | There was an error parsing the signature. | | &#x60;invalid&#x60; | The signature could not be cryptographically verified using the key whose key-id was found in the signature. | | &#x60;valid&#x60; | None of the above errors applied, so the signature is considered to be verified. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="sha">SHA or branch to start listing commits from. Default: the repository’s default branch (usually &#x60;master&#x60;).</param>
        /// <param name="path">Only commits containing this file path will be returned.</param>
        /// <param name="author">GitHub login or email address by which to filter by commit author.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="until">Only commits before this date will be returned. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Commit&gt;</returns>
        List<Commit> ReposListCommits (string owner, string repo, string sha, string path, string author, DateTime? since, DateTime? until, int? perPage, int? page);
        /// <summary>
        /// List repository contributors Lists contributors to the specified repository and sorts them by the number of commits per contributor in descending order. This endpoint may return information that is a few hours old because the GitHub REST API v3 caches contributor data to improve performance.  GitHub identifies contributors by author email address. This endpoint groups contribution counts by GitHub user, which includes all associated email addresses. To improve performance, only the first 500 author email addresses in the repository link to GitHub users. The rest will appear as anonymous contributors without associated GitHub user information.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="anon">Set to &#x60;1&#x60; or &#x60;true&#x60; to include anonymous contributors in results.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Contributor&gt;</returns>
        List<Contributor> ReposListContributors (string owner, string repo, string anon, int? perPage, int? page);
        /// <summary>
        /// List deploy keys 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;DeployKey&gt;</returns>
        List<DeployKey> ReposListDeployKeys (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// List deployment statuses Users with pull access can view deployment statuses for a deployment:
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="deploymentId">deployment_id parameter</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;DeploymentStatus&gt;</returns>
        List<DeploymentStatus> ReposListDeploymentStatuses (string owner, string repo, int? deploymentId, int? perPage, int? page);
        /// <summary>
        /// List deployments Simple filtering of deployments is available via query parameters:
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="sha">The SHA recorded at creation time.</param>
        /// <param name="_ref">The name of the ref. This can be a branch, tag, or SHA.</param>
        /// <param name="task">The name of the task for the deployment (e.g., &#x60;deploy&#x60; or &#x60;deploy:migrations&#x60;).</param>
        /// <param name="environment">The name of the environment that was deployed to (e.g., &#x60;staging&#x60; or &#x60;production&#x60;).</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Deployment&gt;</returns>
        List<Deployment> ReposListDeployments (string owner, string repo, string sha, string _ref, string task, string environment, int? perPage, int? page);
        /// <summary>
        /// List repositories for the authenticated user Lists repositories that the authenticated user has explicit permission (&#x60;:read&#x60;, &#x60;:write&#x60;, or &#x60;:admin&#x60;) to access.  The authenticated user has explicit permission to access repositories they own, repositories where they are a collaborator, and repositories that they can access through an organization membership.
        /// </summary>
        /// <param name="visibility">Limit results to repositories with the specified visibility.</param>
        /// <param name="affiliation">Comma-separated list of values. Can include:   \\* &#x60;owner&#x60;: Repositories that are owned by the authenticated user.   \\* &#x60;collaborator&#x60;: Repositories that the user has been added to as a collaborator.   \\* &#x60;organization_member&#x60;: Repositories that the user has access to through being a member of an organization. This includes every repository on every team that the user is on.</param>
        /// <param name="type">Limit results to repositories of the specified type. Will cause a &#x60;422&#x60; error if used in the same request as **visibility** or **affiliation**.</param>
        /// <param name="sort">The property to sort the results by.</param>
        /// <param name="direction">The order to sort by. Default: &#x60;asc&#x60; when using &#x60;full_name&#x60;, otherwise &#x60;desc&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="before">Only show notifications updated before the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <returns>List&lt;Repository&gt;</returns>
        List<Repository> ReposListForAuthenticatedUser (string visibility, string affiliation, string type, string sort, string direction, int? perPage, int? page, DateTime? since, DateTime? before);
        /// <summary>
        /// List organization repositories Lists repositories for the specified organization.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="type">Specifies the types of repositories you want returned. If your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+, &#x60;type&#x60; can also be &#x60;internal&#x60;. However, the &#x60;internal&#x60; value is not yet supported when a GitHub App calls this API with an installation access token.</param>
        /// <param name="sort">The property to sort the results by.</param>
        /// <param name="direction">The order to sort by. Default: &#x60;asc&#x60; when using &#x60;full_name&#x60;, otherwise &#x60;desc&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MinimalRepository&gt;</returns>
        List<MinimalRepository> ReposListForOrg (string org, string type, string sort, string direction, int? perPage, int? page);
        /// <summary>
        /// List repositories for a user Lists public repositories for the specified user. Note: For GitHub AE, this endpoint will list internal repositories for the specified user.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="type">Limit results to repositories of the specified type.</param>
        /// <param name="sort">The property to sort the results by.</param>
        /// <param name="direction">The order to sort by. Default: &#x60;asc&#x60; when using &#x60;full_name&#x60;, otherwise &#x60;desc&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MinimalRepository&gt;</returns>
        List<MinimalRepository> ReposListForUser (string username, string type, string sort, string direction, int? perPage, int? page);
        /// <summary>
        /// List forks 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="sort">The sort order. Can be either &#x60;newest&#x60;, &#x60;oldest&#x60;, or &#x60;stargazers&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MinimalRepository&gt;</returns>
        List<MinimalRepository> ReposListForks (string owner, string repo, string sort, int? perPage, int? page);
        /// <summary>
        /// List repository invitations When authenticating as a user with admin rights to a repository, this endpoint will list all currently open repository invitations.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;RepositoryInvitation&gt;</returns>
        List<RepositoryInvitation> ReposListInvitations (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// List repository invitations for the authenticated user When authenticating as a user, this endpoint will list all currently open repository invitations for that user.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;RepositoryInvitation&gt;</returns>
        List<RepositoryInvitation> ReposListInvitationsForAuthenticatedUser (int? perPage, int? page);
        /// <summary>
        /// List repository languages Lists languages for the specified repository. The value shown for each language is the number of bytes of code written in that language.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>Dictionary&lt;string, int?&gt;</returns>
        Dictionary<string, int?> ReposListLanguages (string owner, string repo);
        /// <summary>
        /// List GitHub Pages builds 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;PageBuild&gt;</returns>
        List<PageBuild> ReposListPagesBuilds (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// List public repositories Lists all public repositories in the order that they were created.  Note: - For GitHub Enterprise Server, this endpoint will only list repositories available to all users on the enterprise. - Pagination is powered exclusively by the &#x60;since&#x60; parameter. Use the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header) to get the URL for the next page of repositories.
        /// </summary>
        /// <param name="since">A repository ID. Only return repositories with an ID greater than this ID.</param>
        /// <returns>List&lt;MinimalRepository&gt;</returns>
        List<MinimalRepository> ReposListPublic (int? since);
        /// <summary>
        /// List pull requests associated with a commit Lists the merged pull request that introduced the commit to the repository. If the commit is not present in the default branch, additionally returns open pull requests associated with the commit. The results may include open and closed pull requests.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commitSha">The SHA of the commit.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;PullRequestSimple&gt;</returns>
        List<PullRequestSimple> ReposListPullRequestsAssociatedWithCommit (string owner, string repo, string commitSha, int? perPage, int? page);
        /// <summary>
        /// List release assets 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="releaseId">The unique identifier of the release.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;ReleaseAsset&gt;</returns>
        List<ReleaseAsset> ReposListReleaseAssets (string owner, string repo, int? releaseId, int? perPage, int? page);
        /// <summary>
        /// List releases This returns a list of releases, which does not include regular Git tags that have not been associated with a release. To get a list of Git tags, use the [Repository Tags API](https://docs.github.com/rest/reference/repos#list-repository-tags).  Information about published releases are available to everyone. Only users with push access will receive listings for draft releases.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Release&gt;</returns>
        List<Release> ReposListReleases (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// List tag protection states for a repository This returns the tag protection states of a repository.  This information is only available to repository administrators.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>List&lt;TagProtection&gt;</returns>
        List<TagProtection> ReposListTagProtection (string owner, string repo);
        /// <summary>
        /// List repository tags 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Tag&gt;</returns>
        List<Tag> ReposListTags (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// List repository teams 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Team&gt;</returns>
        List<Team> ReposListTeams (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// List deliveries for a repository webhook Returns a list of webhook deliveries for a webhook configured in a repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="cursor">Used for pagination: the starting delivery from which the page of deliveries is fetched. Refer to the &#x60;link&#x60; header for the next and previous page cursors.</param>
        /// <returns>List&lt;SimpleWebhookDelivery&gt;</returns>
        List<SimpleWebhookDelivery> ReposListWebhookDeliveries (string owner, string repo, int? hookId, int? perPage, string cursor);
        /// <summary>
        /// List repository webhooks 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Webhook&gt;</returns>
        List<Webhook> ReposListWebhooks (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// Merge a branch 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposMergeRequest"></param>
        /// <returns>Commit</returns>
        Commit ReposMerge (string owner, string repo, ReposMergeRequest reposMergeRequest);
        /// <summary>
        /// Sync a fork branch with the upstream repository Sync a branch of a forked repository to keep it up-to-date with the upstream repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposMergeUpstreamRequest"></param>
        /// <returns>MergedUpstream</returns>
        MergedUpstream ReposMergeUpstream (string owner, string repo, ReposMergeUpstreamRequest reposMergeUpstreamRequest);
        /// <summary>
        /// Ping a repository webhook This will trigger a [ping event](https://docs.github.com/webhooks/#ping-event) to be sent to the hook.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <returns></returns>
        void ReposPingWebhook (string owner, string repo, int? hookId);
        /// <summary>
        /// Redeliver a delivery for a repository webhook Redeliver a webhook delivery for a webhook configured in a repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <param name="deliveryId"></param>
        /// <returns>Object</returns>
        Object ReposRedeliverWebhookDelivery (string owner, string repo, int? hookId, int? deliveryId);
        /// <summary>
        /// Remove app access restrictions Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Removes the ability of an app to push to this branch. Only installed GitHub Apps with &#x60;write&#x60; access to the &#x60;contents&#x60; permission can be added as authorized actors on a protected branch.  | Type    | Description                                                                                                                                                | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | &#x60;array&#x60; | The GitHub Apps that have push access to this branch. Use the app&#39;s &#x60;slug&#x60;. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetAppAccessRestrictionsRequest"></param>
        /// <returns>List&lt;GitHubApp&gt;</returns>
        List<GitHubApp> ReposRemoveAppAccessRestrictions (string owner, string repo, string branch, ReposSetAppAccessRestrictionsRequest reposSetAppAccessRestrictionsRequest);
        /// <summary>
        /// Remove a repository collaborator 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        void ReposRemoveCollaborator (string owner, string repo, string username);
        /// <summary>
        /// Remove status check contexts Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetStatusCheckContextsRequest"></param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> ReposRemoveStatusCheckContexts (string owner, string repo, string branch, ReposSetStatusCheckContextsRequest reposSetStatusCheckContextsRequest);
        /// <summary>
        /// Remove status check protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns></returns>
        void ReposRemoveStatusCheckProtection (string owner, string repo, string branch);
        /// <summary>
        /// Remove team access restrictions Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Removes the ability of a team to push to this branch. You can also remove push access for child teams.  | Type    | Description                                                                                                                                         | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | &#x60;array&#x60; | Teams that should no longer have push access. Use the team&#39;s &#x60;slug&#x60;. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetTeamAccessRestrictionsRequest"></param>
        /// <returns>List&lt;Team&gt;</returns>
        List<Team> ReposRemoveTeamAccessRestrictions (string owner, string repo, string branch, ReposSetTeamAccessRestrictionsRequest reposSetTeamAccessRestrictionsRequest);
        /// <summary>
        /// Remove user access restrictions Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Removes the ability of a user to push to this branch.  | Type    | Description                                                                                                                                   | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | &#x60;array&#x60; | Usernames of the people who should no longer have push access. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetUserAccessRestrictionsRequest"></param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        List<SimpleUser1> ReposRemoveUserAccessRestrictions (string owner, string repo, string branch, ReposSetUserAccessRestrictionsRequest reposSetUserAccessRestrictionsRequest);
        /// <summary>
        /// Rename a branch Renames a branch in a repository.  **Note:** Although the API responds immediately, the branch rename process might take some extra time to complete in the background. You won&#39;t be able to push to the old branch name while the rename process is in progress. For more information, see \&quot;[Renaming a branch](https://docs.github.com/github/administering-a-repository/renaming-a-branch)\&quot;.  The permissions required to use this endpoint depends on whether you are renaming the default branch.  To rename a non-default branch:  * Users must have push access. * GitHub Apps must have the &#x60;contents:write&#x60; repository permission.  To rename the default branch:  * Users must have admin or owner permissions. * GitHub Apps must have the &#x60;administration:write&#x60; repository permission.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposRenameBranchRequest"></param>
        /// <returns>BranchWithProtection</returns>
        BranchWithProtection ReposRenameBranch (string owner, string repo, string branch, ReposRenameBranchRequest reposRenameBranchRequest);
        /// <summary>
        /// Replace all repository topics 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposReplaceAllTopicsRequest"></param>
        /// <returns>Topic</returns>
        Topic ReposReplaceAllTopics (string owner, string repo, ReposReplaceAllTopicsRequest reposReplaceAllTopicsRequest);
        /// <summary>
        /// Request a GitHub Pages build You can request that your site be built from the latest revision on the default branch. This has the same effect as pushing a commit to your default branch, but does not require an additional commit. Manually triggering page builds can be helpful when diagnosing build warnings and failures.  Build requests are limited to one concurrent build per repository and one concurrent build per requester. If you request a build while another is still in progress, the second request will be queued until the first completes.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>PageBuildStatus</returns>
        PageBuildStatus ReposRequestPagesBuild (string owner, string repo);
        /// <summary>
        /// Set admin branch protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Adding admin enforcement requires admin or owner permissions to the repository and branch protection to be enabled.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>ProtectedBranchAdminEnforced</returns>
        ProtectedBranchAdminEnforced ReposSetAdminBranchProtection (string owner, string repo, string branch);
        /// <summary>
        /// Set app access restrictions Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Replaces the list of apps that have push access to this branch. This removes all apps that previously had push access and grants push access to the new list of apps. Only installed GitHub Apps with &#x60;write&#x60; access to the &#x60;contents&#x60; permission can be added as authorized actors on a protected branch.  | Type    | Description                                                                                                                                                | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | &#x60;array&#x60; | The GitHub Apps that have push access to this branch. Use the app&#39;s &#x60;slug&#x60;. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetAppAccessRestrictionsRequest"></param>
        /// <returns>List&lt;GitHubApp&gt;</returns>
        List<GitHubApp> ReposSetAppAccessRestrictions (string owner, string repo, string branch, ReposSetAppAccessRestrictionsRequest reposSetAppAccessRestrictionsRequest);
        /// <summary>
        /// Set status check contexts Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetStatusCheckContextsRequest"></param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> ReposSetStatusCheckContexts (string owner, string repo, string branch, ReposSetStatusCheckContextsRequest reposSetStatusCheckContextsRequest);
        /// <summary>
        /// Set team access restrictions Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Replaces the list of teams that have push access to this branch. This removes all teams that previously had push access and grants push access to the new list of teams. Team restrictions include child teams.  | Type    | Description                                                                                                                                | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | &#x60;array&#x60; | The teams that can have push access. Use the team&#39;s &#x60;slug&#x60;. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetTeamAccessRestrictionsRequest"></param>
        /// <returns>List&lt;Team&gt;</returns>
        List<Team> ReposSetTeamAccessRestrictions (string owner, string repo, string branch, ReposSetTeamAccessRestrictionsRequest reposSetTeamAccessRestrictionsRequest);
        /// <summary>
        /// Set user access restrictions Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Replaces the list of people that have push access to this branch. This removes all people that previously had push access and grants push access to the new list of people.  | Type    | Description                                                                                                                   | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | &#x60;array&#x60; | Usernames for people who can have push access. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetUserAccessRestrictionsRequest"></param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        List<SimpleUser1> ReposSetUserAccessRestrictions (string owner, string repo, string branch, ReposSetUserAccessRestrictionsRequest reposSetUserAccessRestrictionsRequest);
        /// <summary>
        /// Test the push repository webhook This will trigger the hook with the latest push to the current repository if the hook is subscribed to &#x60;push&#x60; events. If the hook is not subscribed to &#x60;push&#x60; events, the server will respond with 204 but no test POST will be generated.  **Note**: Previously &#x60;/repos/:owner/:repo/hooks/:hook_id/test&#x60;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <returns></returns>
        void ReposTestPushWebhook (string owner, string repo, int? hookId);
        /// <summary>
        /// Transfer a repository A transfer request will need to be accepted by the new owner when transferring a personal repository to another user. The response will contain the original &#x60;owner&#x60;, and the transfer will continue asynchronously. For more details on the requirements to transfer personal and organization-owned repositories, see [about repository transfers](https://docs.github.com/articles/about-repository-transfers/).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposTransferRequest"></param>
        /// <returns>MinimalRepository</returns>
        MinimalRepository ReposTransfer (string owner, string repo, ReposTransferRequest reposTransferRequest);
        /// <summary>
        /// Update a repository **Note**: To edit a repository&#39;s topics, use the [Replace all repository topics](https://docs.github.com/rest/reference/repos#replace-all-repository-topics) endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposUpdateRequest"></param>
        /// <returns>FullRepository</returns>
        FullRepository ReposUpdate (string owner, string repo, ReposUpdateRequest reposUpdateRequest);
        /// <summary>
        /// Update branch protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Protecting a branch requires admin or owner permissions to the repository.  **Note**: Passing new arrays of &#x60;users&#x60; and &#x60;teams&#x60; replaces their previous values.  **Note**: The list of users, apps, and teams in total is limited to 100 items.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposUpdateBranchProtectionRequest"></param>
        /// <returns>ProtectedBranch</returns>
        ProtectedBranch ReposUpdateBranchProtection (string owner, string repo, string branch, ReposUpdateBranchProtectionRequest reposUpdateBranchProtectionRequest);
        /// <summary>
        /// Update a commit comment 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="reposUpdateCommitCommentRequest"></param>
        /// <returns>CommitComment</returns>
        CommitComment ReposUpdateCommitComment (string owner, string repo, int? commentId, ReposUpdateCommitCommentRequest reposUpdateCommitCommentRequest);
        /// <summary>
        /// Update information about a GitHub Pages site Updates information for a GitHub Pages site. For more information, see \&quot;[About GitHub Pages](/github/working-with-github-pages/about-github-pages).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposUpdateInformationAboutPagesSiteRequest"></param>
        /// <returns></returns>
        void ReposUpdateInformationAboutPagesSite (string owner, string repo, ReposUpdateInformationAboutPagesSiteRequest reposUpdateInformationAboutPagesSiteRequest);
        /// <summary>
        /// Update a repository invitation 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="invitationId">The unique identifier of the invitation.</param>
        /// <param name="reposUpdateInvitationRequest"></param>
        /// <returns>RepositoryInvitation</returns>
        RepositoryInvitation ReposUpdateInvitation (string owner, string repo, int? invitationId, ReposUpdateInvitationRequest reposUpdateInvitationRequest);
        /// <summary>
        /// Update pull request review protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Updating pull request review enforcement requires admin or owner permissions to the repository and branch protection to be enabled.  **Note**: Passing new arrays of &#x60;users&#x60; and &#x60;teams&#x60; replaces their previous values.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposUpdatePullRequestReviewProtectionRequest"></param>
        /// <returns>ProtectedBranchPullRequestReview</returns>
        ProtectedBranchPullRequestReview ReposUpdatePullRequestReviewProtection (string owner, string repo, string branch, ReposUpdatePullRequestReviewProtectionRequest reposUpdatePullRequestReviewProtectionRequest);
        /// <summary>
        /// Update a release Users with push access to the repository can edit a release.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="releaseId">The unique identifier of the release.</param>
        /// <param name="reposUpdateReleaseRequest"></param>
        /// <returns>Release</returns>
        Release ReposUpdateRelease (string owner, string repo, int? releaseId, ReposUpdateReleaseRequest reposUpdateReleaseRequest);
        /// <summary>
        /// Update a release asset Users with push access to the repository can edit a release asset.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="assetId">The unique identifier of the asset.</param>
        /// <param name="reposUpdateReleaseAssetRequest"></param>
        /// <returns>ReleaseAsset</returns>
        ReleaseAsset ReposUpdateReleaseAsset (string owner, string repo, int? assetId, ReposUpdateReleaseAssetRequest reposUpdateReleaseAssetRequest);
        /// <summary>
        /// Update status check protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Updating required status checks requires admin or owner permissions to the repository and branch protection to be enabled.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposUpdateStatusCheckProtectionRequest"></param>
        /// <returns>StatusCheckPolicy</returns>
        StatusCheckPolicy ReposUpdateStatusCheckProtection (string owner, string repo, string branch, ReposUpdateStatusCheckProtectionRequest reposUpdateStatusCheckProtectionRequest);
        /// <summary>
        /// Update a repository webhook Updates a webhook configured in a repository. If you previously had a &#x60;secret&#x60; set, you must provide the same &#x60;secret&#x60; or set a new &#x60;secret&#x60; or the secret will be removed. If you are only updating individual webhook &#x60;config&#x60; properties, use \&quot;[Update a webhook configuration for a repository](/rest/reference/repos#update-a-webhook-configuration-for-a-repository).\&quot;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <param name="reposUpdateWebhookRequest"></param>
        /// <returns>Webhook</returns>
        Webhook ReposUpdateWebhook (string owner, string repo, int? hookId, ReposUpdateWebhookRequest reposUpdateWebhookRequest);
        /// <summary>
        /// Update a webhook configuration for a repository Updates the webhook configuration for a repository. To update more information about the webhook, including the &#x60;active&#x60; state and &#x60;events&#x60;, use \&quot;[Update a repository webhook](/rest/reference/orgs#update-a-repository-webhook).\&quot;  Access tokens must have the &#x60;write:repo_hook&#x60; or &#x60;repo&#x60; scope, and GitHub Apps must have the &#x60;repository_hooks:write&#x60; permission.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <param name="reposUpdateWebhookConfigForRepoRequest"></param>
        /// <returns>WebhookConfiguration</returns>
        WebhookConfiguration ReposUpdateWebhookConfigForRepo (string owner, string repo, int? hookId, ReposUpdateWebhookConfigForRepoRequest reposUpdateWebhookConfigForRepoRequest);
        /// <summary>
        /// Upload a release asset This endpoint makes use of [a Hypermedia relation](https://docs.github.com/rest/overview/resources-in-the-rest-api#hypermedia) to determine which URL to access. The endpoint you call to upload release assets is specific to your release. Use the &#x60;upload_url&#x60; returned in the response of the [Create a release endpoint](https://docs.github.com/rest/reference/repos#create-a-release) to upload a release asset.  You need to use an HTTP client which supports [SNI](http://en.wikipedia.org/wiki/Server_Name_Indication) to make calls to this endpoint.  Most libraries will set the required &#x60;Content-Length&#x60; header automatically. Use the required &#x60;Content-Type&#x60; header to provide the media type of the asset. For a list of media types, see [Media Types](https://www.iana.org/assignments/media-types/media-types.xhtml). For example:   &#x60;application/zip&#x60;  GitHub expects the asset data in its raw binary form, rather than JSON. You will send the raw binary content of the asset as the request body. Everything else about the endpoint is the same as the rest of the API. For example, you&#39;ll still need to pass your authentication to be able to upload an asset.  When an upstream failure occurs, you will receive a &#x60;502 Bad Gateway&#x60; status. This may leave an empty asset with a state of &#x60;starter&#x60;. It can be safely deleted.  **Notes:** *   GitHub renames asset filenames that have special characters, non-alphanumeric characters, and leading or trailing periods. The \&quot;[List assets for a release](https://docs.github.com/rest/reference/repos#list-assets-for-a-release)\&quot; endpoint lists the renamed filenames. For more information and help, contact [GitHub Support](https://support.github.com/contact?tags&#x3D;dotcom-rest-api). *   If you upload an asset with the same filename as another uploaded asset, you&#39;ll receive an error and must delete the old file before you can re-upload the new asset.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="releaseId">The unique identifier of the release.</param>
        /// <param name="name"></param>
        /// <param name="label"></param>
        /// <param name="body"></param>
        /// <returns>ReleaseAsset</returns>
        ReleaseAsset ReposUploadReleaseAsset (string owner, string repo, int? releaseId, string name, string label, string body);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReposApi : IReposApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReposApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReposApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReposApi(String basePath)
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
        /// Accept a repository invitation 
        /// </summary>
        /// <param name="invitationId">The unique identifier of the invitation.</param>
        /// <returns></returns>
        public void ReposAcceptInvitationForAuthenticatedUser (int? invitationId)
        {
            
            // verify the required parameter 'invitationId' is set
            if (invitationId == null) throw new ApiException(400, "Missing required parameter 'invitationId' when calling ReposAcceptInvitationForAuthenticatedUser");
            

            var path = "/user/repository_invitations/{invitation_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "invitation_id" + "}", ApiClient.ParameterToString(invitationId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposAcceptInvitationForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposAcceptInvitationForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Add app access restrictions Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Grants the specified apps push access for this branch. Only installed GitHub Apps with &#x60;write&#x60; access to the &#x60;contents&#x60; permission can be added as authorized actors on a protected branch.  | Type    | Description                                                                                                                                                | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | &#x60;array&#x60; | The GitHub Apps that have push access to this branch. Use the app&#39;s &#x60;slug&#x60;. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetAppAccessRestrictionsRequest"></param>
        /// <returns>List&lt;GitHubApp&gt;</returns>
        public List<GitHubApp> ReposAddAppAccessRestrictions (string owner, string repo, string branch, ReposSetAppAccessRestrictionsRequest reposSetAppAccessRestrictionsRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposAddAppAccessRestrictions");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposAddAppAccessRestrictions");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposAddAppAccessRestrictions");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/restrictions/apps";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposSetAppAccessRestrictionsRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposAddAppAccessRestrictions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposAddAppAccessRestrictions: " + response.ErrorMessage, response.ErrorMessage);

            return (List<GitHubApp>) ApiClient.Deserialize(response.Content, typeof(List<GitHubApp>), response.Headers);
        }

        /// <summary>
        /// Add a repository collaborator This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.  Adding an outside collaborator may be restricted by enterprise administrators. For more information, see \&quot;[Enforcing repository management policies in your enterprise](https://docs.github.com/enterprise-cloud@latest/admin/policies/enforcing-policies-for-your-enterprise/enforcing-repository-management-policies-in-your-enterprise#enforcing-a-policy-for-inviting-outside-collaborators-to-repositories).\&quot;  For more information on permission levels, see \&quot;[Repository permission levels for an organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/repository-permission-levels-for-an-organization#permission-levels-for-repositories-owned-by-an-organization)\&quot;. There are restrictions on which permissions can be granted to organization members when an organization base role is in place. In this case, the permission being given must be equal to or higher than the org base permission. Otherwise, the request will fail with:  &#x60;&#x60;&#x60; Cannot assign {member} permission of {role name} &#x60;&#x60;&#x60;  Note that, if you choose not to pass any parameters, you&#39;ll need to set &#x60;Content-Length&#x60; to zero when calling out to this endpoint. For more information, see \&quot;[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\&quot;  The invitee will receive a notification that they have been invited to the repository, which they must accept or decline. They may do this via the notifications page, the email they receive, or by using the [repository invitations API endpoints](https://docs.github.com/rest/reference/repos#invitations).  **Updating an existing collaborator&#39;s permission level**  The endpoint can also be used to change the permissions of an existing collaborator without first removing and re-adding the collaborator. To change the permissions, use the same endpoint and pass a different &#x60;permission&#x60; parameter. The response will be a &#x60;204&#x60;, with no other indication that the permission level changed.  **Rate limits**  You are limited to sending 50 invitations to a repository per 24 hour period. Note there is no limit if you are inviting organization members to an organization repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="reposAddCollaboratorRequest"></param>
        /// <returns>RepositoryInvitation</returns>
        public RepositoryInvitation ReposAddCollaborator (string owner, string repo, string username, ReposAddCollaboratorRequest reposAddCollaboratorRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposAddCollaborator");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposAddCollaborator");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling ReposAddCollaborator");
            

            var path = "/repos/{owner}/{repo}/collaborators/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposAddCollaboratorRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposAddCollaborator: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposAddCollaborator: " + response.ErrorMessage, response.ErrorMessage);

            return (RepositoryInvitation) ApiClient.Deserialize(response.Content, typeof(RepositoryInvitation), response.Headers);
        }

        /// <summary>
        /// Add status check contexts Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetStatusCheckContextsRequest"></param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> ReposAddStatusCheckContexts (string owner, string repo, string branch, ReposSetStatusCheckContextsRequest reposSetStatusCheckContextsRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposAddStatusCheckContexts");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposAddStatusCheckContexts");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposAddStatusCheckContexts");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/required_status_checks/contexts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposSetStatusCheckContextsRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposAddStatusCheckContexts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposAddStatusCheckContexts: " + response.ErrorMessage, response.ErrorMessage);

            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }

        /// <summary>
        /// Add team access restrictions Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Grants the specified teams push access for this branch. You can also give push access to child teams.  | Type    | Description                                                                                                                                | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | &#x60;array&#x60; | The teams that can have push access. Use the team&#39;s &#x60;slug&#x60;. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetTeamAccessRestrictionsRequest"></param>
        /// <returns>List&lt;Team&gt;</returns>
        public List<Team> ReposAddTeamAccessRestrictions (string owner, string repo, string branch, ReposSetTeamAccessRestrictionsRequest reposSetTeamAccessRestrictionsRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposAddTeamAccessRestrictions");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposAddTeamAccessRestrictions");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposAddTeamAccessRestrictions");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/restrictions/teams";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposSetTeamAccessRestrictionsRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposAddTeamAccessRestrictions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposAddTeamAccessRestrictions: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Team>) ApiClient.Deserialize(response.Content, typeof(List<Team>), response.Headers);
        }

        /// <summary>
        /// Add user access restrictions Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Grants the specified people push access for this branch.  | Type    | Description                                                                                                                   | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | &#x60;array&#x60; | Usernames for people who can have push access. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetUserAccessRestrictionsRequest"></param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        public List<SimpleUser1> ReposAddUserAccessRestrictions (string owner, string repo, string branch, ReposSetUserAccessRestrictionsRequest reposSetUserAccessRestrictionsRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposAddUserAccessRestrictions");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposAddUserAccessRestrictions");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposAddUserAccessRestrictions");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/restrictions/users";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposSetUserAccessRestrictionsRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposAddUserAccessRestrictions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposAddUserAccessRestrictions: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SimpleUser1>) ApiClient.Deserialize(response.Content, typeof(List<SimpleUser1>), response.Headers);
        }

        /// <summary>
        /// Check if a user is a repository collaborator For organization-owned repositories, the list of collaborators includes outside collaborators, organization members that are direct collaborators, organization members with access through team memberships, organization members with access through default organization permissions, and organization owners.  Team members will include the members of child teams.  You must authenticate using an access token with the &#x60;read:org&#x60; and &#x60;repo&#x60; scopes with push access to use this endpoint. GitHub Apps must have the &#x60;members&#x60; organization permission and &#x60;metadata&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        public void ReposCheckCollaborator (string owner, string repo, string username)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposCheckCollaborator");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposCheckCollaborator");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling ReposCheckCollaborator");
            

            var path = "/repos/{owner}/{repo}/collaborators/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCheckCollaborator: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCheckCollaborator: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Check if vulnerability alerts are enabled for a repository Shows whether dependency alerts are enabled or disabled for a repository. The authenticated user must have admin read access to the repository. For more information, see \&quot;[About security alerts for vulnerable dependencies](https://docs.github.com/en/articles/about-security-alerts-for-vulnerable-dependencies)\&quot;.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        public void ReposCheckVulnerabilityAlerts (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposCheckVulnerabilityAlerts");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposCheckVulnerabilityAlerts");
            

            var path = "/repos/{owner}/{repo}/vulnerability-alerts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCheckVulnerabilityAlerts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCheckVulnerabilityAlerts: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// List CODEOWNERS errors List any syntax errors that are detected in the CODEOWNERS file.  For more information about the correct CODEOWNERS syntax, see \&quot;[About code owners](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/customizing-your-repository/about-code-owners).\&quot;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="_ref">A branch, tag or commit name used to determine which version of the CODEOWNERS file to use. Default: the repository&#39;s default branch (e.g. &#x60;main&#x60;)</param>
        /// <returns>CODEOWNERSErrors</returns>
        public CODEOWNERSErrors ReposCodeownersErrors (string owner, string repo, string _ref)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposCodeownersErrors");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposCodeownersErrors");
            

            var path = "/repos/{owner}/{repo}/codeowners/errors";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (_ref != null) queryParams.Add("ref", ApiClient.ParameterToString(_ref)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCodeownersErrors: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCodeownersErrors: " + response.ErrorMessage, response.ErrorMessage);

            return (CODEOWNERSErrors) ApiClient.Deserialize(response.Content, typeof(CODEOWNERSErrors), response.Headers);
        }

        /// <summary>
        /// Compare two commits The &#x60;basehead&#x60; param is comprised of two parts: &#x60;base&#x60; and &#x60;head&#x60;. Both must be branch names in &#x60;repo&#x60;. To compare branches across other repositories in the same network as &#x60;repo&#x60;, use the format &#x60;&lt;USERNAME&gt;:branch&#x60;.  The response from the API is equivalent to running the &#x60;git log base..head&#x60; command; however, commits are returned in chronological order. Pass the appropriate [media type](https://docs.github.com/rest/overview/media-types/#commits-commit-comparison-and-pull-requests) to fetch diff and patch formats.  The response also includes details on the files that were changed between the two commits. This includes the status of the change (for example, if a file was added, removed, modified, or renamed), and details of the change itself. For example, files with a &#x60;renamed&#x60; status have a &#x60;previous_filename&#x60; field showing the previous filename of the file, and files with a &#x60;modified&#x60; status have a &#x60;patch&#x60; field showing the changes made to the file.  **Working with large comparisons**  To process a response with a large number of commits, you can use (&#x60;per_page&#x60; or &#x60;page&#x60;) to paginate the results. When using paging, the list of changed files is only returned with page 1, but includes all changed files for the entire comparison. For more information on working with pagination, see \&quot;[Traversing with pagination](/rest/guides/traversing-with-pagination).\&quot;  When calling this API without any paging parameters (&#x60;per_page&#x60; or &#x60;page&#x60;), the returned list is limited to 250 commits and the last commit in the list is the most recent of the entire comparison. When a paging parameter is specified, the first commit in the returned list of each page is the earliest.  **Signature verification object**  The response will include a &#x60;verification&#x60; object that describes the result of verifying the commit&#39;s signature. The following fields are included in the &#x60;verification&#x60; object:  | Name | Type | Description | | - -- - | - -- - | - -- -- -- -- -- | | &#x60;verified&#x60; | &#x60;boolean&#x60; | Indicates whether GitHub considers the signature in this commit to be verified. | | &#x60;reason&#x60; | &#x60;string&#x60; | The reason for verified value. Possible values and their meanings are enumerated in table below. | | &#x60;signature&#x60; | &#x60;string&#x60; | The signature that was extracted from the commit. | | &#x60;payload&#x60; | &#x60;string&#x60; | The value that was signed. |  These are the possible values for &#x60;reason&#x60; in the &#x60;verification&#x60; object:  | Value | Description | | - -- -- | - -- -- -- -- -- | | &#x60;expired_key&#x60; | The key that made the signature is expired. | | &#x60;not_signing_key&#x60; | The \&quot;signing\&quot; flag is not among the usage flags in the GPG key that made the signature. | | &#x60;gpgverify_error&#x60; | There was an error communicating with the signature verification service. | | &#x60;gpgverify_unavailable&#x60; | The signature verification service is currently unavailable. | | &#x60;unsigned&#x60; | The object does not include a signature. | | &#x60;unknown_signature_type&#x60; | A non-PGP signature was found in the commit. | | &#x60;no_user&#x60; | No user was associated with the &#x60;committer&#x60; email address in the commit. | | &#x60;unverified_email&#x60; | The &#x60;committer&#x60; email address in the commit was associated with a user, but the email address is not verified on her/his account. | | &#x60;bad_email&#x60; | The &#x60;committer&#x60; email address in the commit is not included in the identities of the PGP key that made the signature. | | &#x60;unknown_key&#x60; | The key that made the signature has not been registered with any user&#39;s account. | | &#x60;malformed_signature&#x60; | There was an error parsing the signature. | | &#x60;invalid&#x60; | The signature could not be cryptographically verified using the key whose key-id was found in the signature. | | &#x60;valid&#x60; | None of the above errors applied, so the signature is considered to be verified. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="basehead">The base branch and head branch to compare. This parameter expects the format &#x60;{base}...{head}&#x60;.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <returns>CommitComparison</returns>
        public CommitComparison ReposCompareCommits (string owner, string repo, string basehead, int? page, int? perPage)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposCompareCommits");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposCompareCommits");
            
            // verify the required parameter 'basehead' is set
            if (basehead == null) throw new ApiException(400, "Missing required parameter 'basehead' when calling ReposCompareCommits");
            

            var path = "/repos/{owner}/{repo}/compare/{basehead}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "basehead" + "}", ApiClient.ParameterToString(basehead));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCompareCommits: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCompareCommits: " + response.ErrorMessage, response.ErrorMessage);

            return (CommitComparison) ApiClient.Deserialize(response.Content, typeof(CommitComparison), response.Headers);
        }

        /// <summary>
        /// Create an autolink reference for a repository Users with admin access to the repository can create an autolink.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposCreateAutolinkRequest"></param>
        /// <returns>AutolinkReference</returns>
        public AutolinkReference ReposCreateAutolink (string owner, string repo, ReposCreateAutolinkRequest reposCreateAutolinkRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposCreateAutolink");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposCreateAutolink");
            
            // verify the required parameter 'reposCreateAutolinkRequest' is set
            if (reposCreateAutolinkRequest == null) throw new ApiException(400, "Missing required parameter 'reposCreateAutolinkRequest' when calling ReposCreateAutolink");
            

            var path = "/repos/{owner}/{repo}/autolinks";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposCreateAutolinkRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateAutolink: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateAutolink: " + response.ErrorMessage, response.ErrorMessage);

            return (AutolinkReference) ApiClient.Deserialize(response.Content, typeof(AutolinkReference), response.Headers);
        }

        /// <summary>
        /// Create a commit comment Create a comment for a commit using its &#x60;:commit_sha&#x60;.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commitSha">The SHA of the commit.</param>
        /// <param name="reposCreateCommitCommentRequest"></param>
        /// <returns>CommitComment</returns>
        public CommitComment ReposCreateCommitComment (string owner, string repo, string commitSha, ReposCreateCommitCommentRequest reposCreateCommitCommentRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposCreateCommitComment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposCreateCommitComment");
            
            // verify the required parameter 'commitSha' is set
            if (commitSha == null) throw new ApiException(400, "Missing required parameter 'commitSha' when calling ReposCreateCommitComment");
            
            // verify the required parameter 'reposCreateCommitCommentRequest' is set
            if (reposCreateCommitCommentRequest == null) throw new ApiException(400, "Missing required parameter 'reposCreateCommitCommentRequest' when calling ReposCreateCommitComment");
            

            var path = "/repos/{owner}/{repo}/commits/{commit_sha}/comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "commit_sha" + "}", ApiClient.ParameterToString(commitSha));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposCreateCommitCommentRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateCommitComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateCommitComment: " + response.ErrorMessage, response.ErrorMessage);

            return (CommitComment) ApiClient.Deserialize(response.Content, typeof(CommitComment), response.Headers);
        }

        /// <summary>
        /// Create commit signature protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  When authenticated with admin or owner permissions to the repository, you can use this endpoint to require signed commits on a branch. You must enable branch protection to require signed commits.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>ProtectedBranchAdminEnforced</returns>
        public ProtectedBranchAdminEnforced ReposCreateCommitSignatureProtection (string owner, string repo, string branch)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposCreateCommitSignatureProtection");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposCreateCommitSignatureProtection");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposCreateCommitSignatureProtection");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/required_signatures";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateCommitSignatureProtection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateCommitSignatureProtection: " + response.ErrorMessage, response.ErrorMessage);

            return (ProtectedBranchAdminEnforced) ApiClient.Deserialize(response.Content, typeof(ProtectedBranchAdminEnforced), response.Headers);
        }

        /// <summary>
        /// Create a commit status Users with push access in a repository can create commit statuses for a given SHA.  Note: there is a limit of 1000 statuses per &#x60;sha&#x60; and &#x60;context&#x60; within a repository. Attempts to create more than 1000 statuses will result in a validation error.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="sha"></param>
        /// <param name="reposCreateCommitStatusRequest"></param>
        /// <returns>Status</returns>
        public Status ReposCreateCommitStatus (string owner, string repo, string sha, ReposCreateCommitStatusRequest reposCreateCommitStatusRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposCreateCommitStatus");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposCreateCommitStatus");
            
            // verify the required parameter 'sha' is set
            if (sha == null) throw new ApiException(400, "Missing required parameter 'sha' when calling ReposCreateCommitStatus");
            
            // verify the required parameter 'reposCreateCommitStatusRequest' is set
            if (reposCreateCommitStatusRequest == null) throw new ApiException(400, "Missing required parameter 'reposCreateCommitStatusRequest' when calling ReposCreateCommitStatus");
            

            var path = "/repos/{owner}/{repo}/statuses/{sha}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "sha" + "}", ApiClient.ParameterToString(sha));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposCreateCommitStatusRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateCommitStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateCommitStatus: " + response.ErrorMessage, response.ErrorMessage);

            return (Status) ApiClient.Deserialize(response.Content, typeof(Status), response.Headers);
        }

        /// <summary>
        /// Create a deploy key You can create a read-only deploy key.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposCreateDeployKeyRequest"></param>
        /// <returns>DeployKey</returns>
        public DeployKey ReposCreateDeployKey (string owner, string repo, ReposCreateDeployKeyRequest reposCreateDeployKeyRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposCreateDeployKey");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposCreateDeployKey");
            
            // verify the required parameter 'reposCreateDeployKeyRequest' is set
            if (reposCreateDeployKeyRequest == null) throw new ApiException(400, "Missing required parameter 'reposCreateDeployKeyRequest' when calling ReposCreateDeployKey");
            

            var path = "/repos/{owner}/{repo}/keys";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposCreateDeployKeyRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateDeployKey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateDeployKey: " + response.ErrorMessage, response.ErrorMessage);

            return (DeployKey) ApiClient.Deserialize(response.Content, typeof(DeployKey), response.Headers);
        }

        /// <summary>
        /// Create a deployment Deployments offer a few configurable parameters with certain defaults.  The &#x60;ref&#x60; parameter can be any named branch, tag, or SHA. At GitHub we often deploy branches and verify them before we merge a pull request.  The &#x60;environment&#x60; parameter allows deployments to be issued to different runtime environments. Teams often have multiple environments for verifying their applications, such as &#x60;production&#x60;, &#x60;staging&#x60;, and &#x60;qa&#x60;. This parameter makes it easier to track which environments have requested deployments. The default environment is &#x60;production&#x60;.  The &#x60;auto_merge&#x60; parameter is used to ensure that the requested ref is not behind the repository&#39;s default branch. If the ref _is_ behind the default branch for the repository, we will attempt to merge it for you. If the merge succeeds, the API will return a successful merge commit. If merge conflicts prevent the merge from succeeding, the API will return a failure response.  By default, [commit statuses](https://docs.github.com/rest/commits/statuses) for every submitted context must be in a &#x60;success&#x60; state. The &#x60;required_contexts&#x60; parameter allows you to specify a subset of contexts that must be &#x60;success&#x60;, or to specify contexts that have not yet been submitted. You are not required to use commit statuses to deploy. If you do not require any contexts or create any commit statuses, the deployment will always succeed.  The &#x60;payload&#x60; parameter is available for any extra information that a deployment system might need. It is a JSON text field that will be passed on when a deployment event is dispatched.  The &#x60;task&#x60; parameter is used by the deployment system to allow different execution paths. In the web world this might be &#x60;deploy:migrations&#x60; to run schema changes on the system. In the compiled world this could be a flag to compile an application with debugging enabled.  Users with &#x60;repo&#x60; or &#x60;repo_deployment&#x60; scopes can create a deployment for a given ref.  #### Merged branch response You will see this response when GitHub automatically merges the base branch into the topic branch instead of creating a deployment. This auto-merge happens when: *   Auto-merge option is enabled in the repository *   Topic branch does not include the latest changes on the base branch, which is &#x60;master&#x60; in the response example *   There are no merge conflicts  If there are no new commits in the base branch, a new request to create a deployment should give a successful response.  #### Merge conflict response This error happens when the &#x60;auto_merge&#x60; option is enabled and when the default branch (in this case &#x60;master&#x60;), can&#39;t be merged into the branch that&#39;s being deployed (in this case &#x60;topic-branch&#x60;), due to merge conflicts.  #### Failed commit status checks This error happens when the &#x60;required_contexts&#x60; parameter indicates that one or more contexts need to have a &#x60;success&#x60; status for the commit to be deployed, but one or more of the required contexts do not have a state of &#x60;success&#x60;.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposCreateDeploymentRequest"></param>
        /// <returns>Deployment</returns>
        public Deployment ReposCreateDeployment (string owner, string repo, ReposCreateDeploymentRequest reposCreateDeploymentRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposCreateDeployment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposCreateDeployment");
            
            // verify the required parameter 'reposCreateDeploymentRequest' is set
            if (reposCreateDeploymentRequest == null) throw new ApiException(400, "Missing required parameter 'reposCreateDeploymentRequest' when calling ReposCreateDeployment");
            

            var path = "/repos/{owner}/{repo}/deployments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposCreateDeploymentRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateDeployment: " + response.ErrorMessage, response.ErrorMessage);

            return (Deployment) ApiClient.Deserialize(response.Content, typeof(Deployment), response.Headers);
        }

        /// <summary>
        /// Create a deployment status Users with &#x60;push&#x60; access can create deployment statuses for a given deployment.  GitHub Apps require &#x60;read &amp; write&#x60; access to \&quot;Deployments\&quot; and &#x60;read-only&#x60; access to \&quot;Repo contents\&quot; (for private repos). OAuth Apps require the &#x60;repo_deployment&#x60; scope.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="deploymentId">deployment_id parameter</param>
        /// <param name="reposCreateDeploymentStatusRequest"></param>
        /// <returns>DeploymentStatus</returns>
        public DeploymentStatus ReposCreateDeploymentStatus (string owner, string repo, int? deploymentId, ReposCreateDeploymentStatusRequest reposCreateDeploymentStatusRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposCreateDeploymentStatus");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposCreateDeploymentStatus");
            
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null) throw new ApiException(400, "Missing required parameter 'deploymentId' when calling ReposCreateDeploymentStatus");
            
            // verify the required parameter 'reposCreateDeploymentStatusRequest' is set
            if (reposCreateDeploymentStatusRequest == null) throw new ApiException(400, "Missing required parameter 'reposCreateDeploymentStatusRequest' when calling ReposCreateDeploymentStatus");
            

            var path = "/repos/{owner}/{repo}/deployments/{deployment_id}/statuses";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "deployment_id" + "}", ApiClient.ParameterToString(deploymentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposCreateDeploymentStatusRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateDeploymentStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateDeploymentStatus: " + response.ErrorMessage, response.ErrorMessage);

            return (DeploymentStatus) ApiClient.Deserialize(response.Content, typeof(DeploymentStatus), response.Headers);
        }

        /// <summary>
        /// Create a repository dispatch event You can use this endpoint to trigger a webhook event called &#x60;repository_dispatch&#x60; when you want activity that happens outside of GitHub to trigger a GitHub Actions workflow or GitHub App webhook. You must configure your GitHub Actions workflow or GitHub App to run when the &#x60;repository_dispatch&#x60; event occurs. For an example &#x60;repository_dispatch&#x60; webhook payload, see \&quot;[RepositoryDispatchEvent](https://docs.github.com/webhooks/event-payloads/#repository_dispatch).\&quot;  The &#x60;client_payload&#x60; parameter is available for any extra information that your workflow might need. This parameter is a JSON payload that will be passed on when the webhook event is dispatched. For example, the &#x60;client_payload&#x60; can include a message that a user would like to send using a GitHub Actions workflow. Or the &#x60;client_payload&#x60; can be used as a test to debug your workflow.  This endpoint requires write access to the repository by providing either:    - Personal access tokens with &#x60;repo&#x60; scope. For more information, see \&quot;[Creating a personal access token for the command line](https://docs.github.com/articles/creating-a-personal-access-token-for-the-command-line)\&quot; in the GitHub Help documentation.   - GitHub Apps with both &#x60;metadata:read&#x60; and &#x60;contents:read&amp;write&#x60; permissions.  This input example shows how you can use the &#x60;client_payload&#x60; as a test to debug your workflow.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposCreateDispatchEventRequest"></param>
        /// <returns></returns>
        public void ReposCreateDispatchEvent (string owner, string repo, ReposCreateDispatchEventRequest reposCreateDispatchEventRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposCreateDispatchEvent");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposCreateDispatchEvent");
            
            // verify the required parameter 'reposCreateDispatchEventRequest' is set
            if (reposCreateDispatchEventRequest == null) throw new ApiException(400, "Missing required parameter 'reposCreateDispatchEventRequest' when calling ReposCreateDispatchEvent");
            

            var path = "/repos/{owner}/{repo}/dispatches";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposCreateDispatchEventRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateDispatchEvent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateDispatchEvent: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Create a repository for the authenticated user Creates a new repository for the authenticated user.  **OAuth scope requirements**  When using [OAuth](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/), authorizations must include:  *   &#x60;public_repo&#x60; scope or &#x60;repo&#x60; scope to create a public repository. Note: For GitHub AE, use &#x60;repo&#x60; scope to create an internal repository. *   &#x60;repo&#x60; scope to create a private repository.
        /// </summary>
        /// <param name="reposCreateForAuthenticatedUserRequest"></param>
        /// <returns>Repository</returns>
        public Repository ReposCreateForAuthenticatedUser (ReposCreateForAuthenticatedUserRequest reposCreateForAuthenticatedUserRequest)
        {
            
            // verify the required parameter 'reposCreateForAuthenticatedUserRequest' is set
            if (reposCreateForAuthenticatedUserRequest == null) throw new ApiException(400, "Missing required parameter 'reposCreateForAuthenticatedUserRequest' when calling ReposCreateForAuthenticatedUser");
            

            var path = "/user/repos";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposCreateForAuthenticatedUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (Repository) ApiClient.Deserialize(response.Content, typeof(Repository), response.Headers);
        }

        /// <summary>
        /// Create a fork Create a fork for the authenticated user.  **Note**: Forking a Repository happens asynchronously. You may have to wait a short period of time before you can access the git objects. If this takes longer than 5 minutes, be sure to contact [GitHub Support](https://support.github.com/contact?tags&#x3D;dotcom-rest-api).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposCreateForkRequest"></param>
        /// <returns>FullRepository</returns>
        public FullRepository ReposCreateFork (string owner, string repo, ReposCreateForkRequest reposCreateForkRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposCreateFork");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposCreateFork");
            

            var path = "/repos/{owner}/{repo}/forks";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposCreateForkRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateFork: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateFork: " + response.ErrorMessage, response.ErrorMessage);

            return (FullRepository) ApiClient.Deserialize(response.Content, typeof(FullRepository), response.Headers);
        }

        /// <summary>
        /// Create an organization repository Creates a new repository in the specified organization. The authenticated user must be a member of the organization.  **OAuth scope requirements**  When using [OAuth](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/), authorizations must include:  *   &#x60;public_repo&#x60; scope or &#x60;repo&#x60; scope to create a public repository. Note: For GitHub AE, use &#x60;repo&#x60; scope to create an internal repository. *   &#x60;repo&#x60; scope to create a private repository
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="reposCreateInOrgRequest"></param>
        /// <returns>Repository</returns>
        public Repository ReposCreateInOrg (string org, ReposCreateInOrgRequest reposCreateInOrgRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ReposCreateInOrg");
            
            // verify the required parameter 'reposCreateInOrgRequest' is set
            if (reposCreateInOrgRequest == null) throw new ApiException(400, "Missing required parameter 'reposCreateInOrgRequest' when calling ReposCreateInOrg");
            

            var path = "/orgs/{org}/repos";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposCreateInOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (Repository) ApiClient.Deserialize(response.Content, typeof(Repository), response.Headers);
        }

        /// <summary>
        /// Create or update an environment Create or update an environment with protection rules, such as required reviewers. For more information about environment protection rules, see \&quot;[Environments](/actions/reference/environments#environment-protection-rules).\&quot;  **Note:** Although you can use this operation to specify that only branches that match specified name patterns can deploy to this environment, you must use the UI to set the name patterns. For more information, see \&quot;[Environments](/actions/reference/environments#deployment-branches).\&quot;  **Note:** To create or update secrets for an environment, see \&quot;[Secrets](/rest/reference/actions#secrets).\&quot;  You must authenticate using an access token with the repo scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="environmentName">The name of the environment</param>
        /// <param name="reposCreateOrUpdateEnvironmentRequest"></param>
        /// <returns>Environment</returns>
        public Org.OpenAPITools.Model.Environment ReposCreateOrUpdateEnvironment (string owner, string repo, string environmentName, ReposCreateOrUpdateEnvironmentRequest reposCreateOrUpdateEnvironmentRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposCreateOrUpdateEnvironment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposCreateOrUpdateEnvironment");
            
            // verify the required parameter 'environmentName' is set
            if (environmentName == null) throw new ApiException(400, "Missing required parameter 'environmentName' when calling ReposCreateOrUpdateEnvironment");
            

            var path = "/repos/{owner}/{repo}/environments/{environment_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
            path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
            path = path.Replace("{" + "environment_name" + "}", ApiClient.ParameterToString(environmentName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposCreateOrUpdateEnvironmentRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateOrUpdateEnvironment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateOrUpdateEnvironment: " + response.ErrorMessage, response.ErrorMessage);

            return (Org.OpenAPITools.Model.Environment) ApiClient.Deserialize(response.Content, typeof(Org.OpenAPITools.Model.Environment), response.Headers);
        }

        /// <summary>
        /// Create or update file contents Creates a new file or replaces an existing file in a repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="path">path parameter</param>
        /// <param name="reposCreateOrUpdateFileContentsRequest"></param>
        /// <returns>FileCommit</returns>
        public FileCommit ReposCreateOrUpdateFileContents (string owner, string repo, string path, ReposCreateOrUpdateFileContentsRequest reposCreateOrUpdateFileContentsRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposCreateOrUpdateFileContents");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposCreateOrUpdateFileContents");
            
            // verify the required parameter 'path' is set
            if (path == null) throw new ApiException(400, "Missing required parameter 'path' when calling ReposCreateOrUpdateFileContents");
            
            // verify the required parameter 'reposCreateOrUpdateFileContentsRequest' is set
            if (reposCreateOrUpdateFileContentsRequest == null) throw new ApiException(400, "Missing required parameter 'reposCreateOrUpdateFileContentsRequest' when calling ReposCreateOrUpdateFileContents");
            

            path = "/repos/{owner}/{repo}/contents/{path}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
            path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
            path = path.Replace("{" + "path" + "}", ApiClient.ParameterToString(path));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposCreateOrUpdateFileContentsRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateOrUpdateFileContents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateOrUpdateFileContents: " + response.ErrorMessage, response.ErrorMessage);

            return (FileCommit) ApiClient.Deserialize(response.Content, typeof(FileCommit), response.Headers);
        }

        /// <summary>
        /// Create a GitHub Pages deployment Create a GitHub Pages deployment for a repository.  Users must have write permissions. GitHub Apps must have the &#x60;pages:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposCreatePagesDeploymentRequest"></param>
        /// <returns>GitHubPages1</returns>
        public GitHubPages1 ReposCreatePagesDeployment (string owner, string repo, ReposCreatePagesDeploymentRequest reposCreatePagesDeploymentRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposCreatePagesDeployment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposCreatePagesDeployment");
            
            // verify the required parameter 'reposCreatePagesDeploymentRequest' is set
            if (reposCreatePagesDeploymentRequest == null) throw new ApiException(400, "Missing required parameter 'reposCreatePagesDeploymentRequest' when calling ReposCreatePagesDeployment");
            

            var path = "/repos/{owner}/{repo}/pages/deployment";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposCreatePagesDeploymentRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreatePagesDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreatePagesDeployment: " + response.ErrorMessage, response.ErrorMessage);

            return (GitHubPages1) ApiClient.Deserialize(response.Content, typeof(GitHubPages1), response.Headers);
        }

        /// <summary>
        /// Create a GitHub Pages site Configures a GitHub Pages site. For more information, see \&quot;[About GitHub Pages](/github/working-with-github-pages/about-github-pages).\&quot;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposCreatePagesSiteRequest"></param>
        /// <returns>GitHubPages</returns>
        public GitHubPages ReposCreatePagesSite (string owner, string repo, ReposCreatePagesSiteRequest reposCreatePagesSiteRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposCreatePagesSite");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposCreatePagesSite");
            
            // verify the required parameter 'reposCreatePagesSiteRequest' is set
            if (reposCreatePagesSiteRequest == null) throw new ApiException(400, "Missing required parameter 'reposCreatePagesSiteRequest' when calling ReposCreatePagesSite");
            

            var path = "/repos/{owner}/{repo}/pages";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposCreatePagesSiteRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreatePagesSite: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreatePagesSite: " + response.ErrorMessage, response.ErrorMessage);

            return (GitHubPages) ApiClient.Deserialize(response.Content, typeof(GitHubPages), response.Headers);
        }

        /// <summary>
        /// Create a release Users with push access to the repository can create a release.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \&quot;[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\&quot; and \&quot;[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\&quot; for details.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposCreateReleaseRequest"></param>
        /// <returns>Release</returns>
        public Release ReposCreateRelease (string owner, string repo, ReposCreateReleaseRequest reposCreateReleaseRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposCreateRelease");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposCreateRelease");
            
            // verify the required parameter 'reposCreateReleaseRequest' is set
            if (reposCreateReleaseRequest == null) throw new ApiException(400, "Missing required parameter 'reposCreateReleaseRequest' when calling ReposCreateRelease");
            

            var path = "/repos/{owner}/{repo}/releases";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposCreateReleaseRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateRelease: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateRelease: " + response.ErrorMessage, response.ErrorMessage);

            return (Release) ApiClient.Deserialize(response.Content, typeof(Release), response.Headers);
        }

        /// <summary>
        /// Create a tag protection state for a repository This creates a tag protection state for a repository. This endpoint is only available to repository administrators.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposCreateTagProtectionRequest"></param>
        /// <returns>TagProtection</returns>
        public TagProtection ReposCreateTagProtection (string owner, string repo, ReposCreateTagProtectionRequest reposCreateTagProtectionRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposCreateTagProtection");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposCreateTagProtection");
            
            // verify the required parameter 'reposCreateTagProtectionRequest' is set
            if (reposCreateTagProtectionRequest == null) throw new ApiException(400, "Missing required parameter 'reposCreateTagProtectionRequest' when calling ReposCreateTagProtection");
            

            var path = "/repos/{owner}/{repo}/tags/protection";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposCreateTagProtectionRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateTagProtection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateTagProtection: " + response.ErrorMessage, response.ErrorMessage);

            return (TagProtection) ApiClient.Deserialize(response.Content, typeof(TagProtection), response.Headers);
        }

        /// <summary>
        /// Create a repository using a template Creates a new repository using a repository template. Use the &#x60;template_owner&#x60; and &#x60;template_repo&#x60; route parameters to specify the repository to use as the template. The authenticated user must own or be a member of an organization that owns the repository. To check if a repository is available to use as a template, get the repository&#39;s information using the [Get a repository](https://docs.github.com/rest/reference/repos#get-a-repository) endpoint and check that the &#x60;is_template&#x60; key is &#x60;true&#x60;.  **OAuth scope requirements**  When using [OAuth](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/), authorizations must include:  *   &#x60;public_repo&#x60; scope or &#x60;repo&#x60; scope to create a public repository. Note: For GitHub AE, use &#x60;repo&#x60; scope to create an internal repository. *   &#x60;repo&#x60; scope to create a private repository
        /// </summary>
        /// <param name="templateOwner"></param>
        /// <param name="templateRepo"></param>
        /// <param name="reposCreateUsingTemplateRequest"></param>
        /// <returns>Repository</returns>
        public Repository ReposCreateUsingTemplate (string templateOwner, string templateRepo, ReposCreateUsingTemplateRequest reposCreateUsingTemplateRequest)
        {
            
            // verify the required parameter 'templateOwner' is set
            if (templateOwner == null) throw new ApiException(400, "Missing required parameter 'templateOwner' when calling ReposCreateUsingTemplate");
            
            // verify the required parameter 'templateRepo' is set
            if (templateRepo == null) throw new ApiException(400, "Missing required parameter 'templateRepo' when calling ReposCreateUsingTemplate");
            
            // verify the required parameter 'reposCreateUsingTemplateRequest' is set
            if (reposCreateUsingTemplateRequest == null) throw new ApiException(400, "Missing required parameter 'reposCreateUsingTemplateRequest' when calling ReposCreateUsingTemplate");
            

            var path = "/repos/{template_owner}/{template_repo}/generate";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "template_owner" + "}", ApiClient.ParameterToString(templateOwner));
path = path.Replace("{" + "template_repo" + "}", ApiClient.ParameterToString(templateRepo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposCreateUsingTemplateRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateUsingTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateUsingTemplate: " + response.ErrorMessage, response.ErrorMessage);

            return (Repository) ApiClient.Deserialize(response.Content, typeof(Repository), response.Headers);
        }

        /// <summary>
        /// Create a repository webhook Repositories can have multiple webhooks installed. Each webhook should have a unique &#x60;config&#x60;. Multiple webhooks can share the same &#x60;config&#x60; as long as those webhooks do not have any &#x60;events&#x60; that overlap.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposCreateWebhookRequest"></param>
        /// <returns>Webhook</returns>
        public Webhook ReposCreateWebhook (string owner, string repo, ReposCreateWebhookRequest reposCreateWebhookRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposCreateWebhook");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposCreateWebhook");
            

            var path = "/repos/{owner}/{repo}/hooks";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposCreateWebhookRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposCreateWebhook: " + response.ErrorMessage, response.ErrorMessage);

            return (Webhook) ApiClient.Deserialize(response.Content, typeof(Webhook), response.Headers);
        }

        /// <summary>
        /// Decline a repository invitation 
        /// </summary>
        /// <param name="invitationId">The unique identifier of the invitation.</param>
        /// <returns></returns>
        public void ReposDeclineInvitationForAuthenticatedUser (int? invitationId)
        {
            
            // verify the required parameter 'invitationId' is set
            if (invitationId == null) throw new ApiException(400, "Missing required parameter 'invitationId' when calling ReposDeclineInvitationForAuthenticatedUser");
            

            var path = "/user/repository_invitations/{invitation_id}";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeclineInvitationForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeclineInvitationForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a repository Deleting a repository requires admin access. If OAuth is used, the &#x60;delete_repo&#x60; scope is required.  If an organization owner has configured the organization to prevent members from deleting organization-owned repositories, you will get a &#x60;403 Forbidden&#x60; response.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        public void ReposDelete (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDelete");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDelete");
            

            var path = "/repos/{owner}/{repo}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDelete: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete access restrictions Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Disables the ability to restrict who can push to this branch.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns></returns>
        public void ReposDeleteAccessRestrictions (string owner, string repo, string branch)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDeleteAccessRestrictions");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDeleteAccessRestrictions");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposDeleteAccessRestrictions");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/restrictions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteAccessRestrictions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteAccessRestrictions: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete admin branch protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Removing admin enforcement requires admin or owner permissions to the repository and branch protection to be enabled.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns></returns>
        public void ReposDeleteAdminBranchProtection (string owner, string repo, string branch)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDeleteAdminBranchProtection");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDeleteAdminBranchProtection");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposDeleteAdminBranchProtection");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/enforce_admins";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteAdminBranchProtection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteAdminBranchProtection: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete an environment You must authenticate using an access token with the repo scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="environmentName">The name of the environment</param>
        /// <returns></returns>
        public void ReposDeleteAnEnvironment (string owner, string repo, string environmentName)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDeleteAnEnvironment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDeleteAnEnvironment");
            
            // verify the required parameter 'environmentName' is set
            if (environmentName == null) throw new ApiException(400, "Missing required parameter 'environmentName' when calling ReposDeleteAnEnvironment");
            

            var path = "/repos/{owner}/{repo}/environments/{environment_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "environment_name" + "}", ApiClient.ParameterToString(environmentName));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteAnEnvironment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteAnEnvironment: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete an autolink reference from a repository This deletes a single autolink reference by ID that was configured for the given repository.  Information about autolinks are only available to repository administrators.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="autolinkId">The unique identifier of the autolink.</param>
        /// <returns></returns>
        public void ReposDeleteAutolink (string owner, string repo, int? autolinkId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDeleteAutolink");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDeleteAutolink");
            
            // verify the required parameter 'autolinkId' is set
            if (autolinkId == null) throw new ApiException(400, "Missing required parameter 'autolinkId' when calling ReposDeleteAutolink");
            

            var path = "/repos/{owner}/{repo}/autolinks/{autolink_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "autolink_id" + "}", ApiClient.ParameterToString(autolinkId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteAutolink: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteAutolink: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete branch protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns></returns>
        public void ReposDeleteBranchProtection (string owner, string repo, string branch)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDeleteBranchProtection");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDeleteBranchProtection");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposDeleteBranchProtection");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteBranchProtection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteBranchProtection: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a commit comment 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <returns></returns>
        public void ReposDeleteCommitComment (string owner, string repo, int? commentId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDeleteCommitComment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDeleteCommitComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling ReposDeleteCommitComment");
            

            var path = "/repos/{owner}/{repo}/comments/{comment_id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteCommitComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteCommitComment: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete commit signature protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  When authenticated with admin or owner permissions to the repository, you can use this endpoint to disable required signed commits on a branch. You must enable branch protection to require signed commits.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns></returns>
        public void ReposDeleteCommitSignatureProtection (string owner, string repo, string branch)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDeleteCommitSignatureProtection");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDeleteCommitSignatureProtection");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposDeleteCommitSignatureProtection");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/required_signatures";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteCommitSignatureProtection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteCommitSignatureProtection: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a deploy key Deploy keys are immutable. If you need to update a key, remove the key and create a new one instead.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="keyId">The unique identifier of the key.</param>
        /// <returns></returns>
        public void ReposDeleteDeployKey (string owner, string repo, int? keyId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDeleteDeployKey");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDeleteDeployKey");
            
            // verify the required parameter 'keyId' is set
            if (keyId == null) throw new ApiException(400, "Missing required parameter 'keyId' when calling ReposDeleteDeployKey");
            

            var path = "/repos/{owner}/{repo}/keys/{key_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "key_id" + "}", ApiClient.ParameterToString(keyId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteDeployKey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteDeployKey: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a deployment If the repository only has one deployment, you can delete the deployment regardless of its status. If the repository has more than one deployment, you can only delete inactive deployments. This ensures that repositories with multiple deployments will always have an active deployment. Anyone with &#x60;repo&#x60; or &#x60;repo_deployment&#x60; scopes can delete a deployment.  To set a deployment as inactive, you must:  *   Create a new deployment that is active so that the system has a record of the current state, then delete the previously active deployment. *   Mark the active deployment as inactive by adding any non-successful deployment status.  For more information, see \&quot;[Create a deployment](https://docs.github.com/rest/reference/repos/#create-a-deployment)\&quot; and \&quot;[Create a deployment status](https://docs.github.com/rest/reference/repos#create-a-deployment-status).\&quot;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="deploymentId">deployment_id parameter</param>
        /// <returns></returns>
        public void ReposDeleteDeployment (string owner, string repo, int? deploymentId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDeleteDeployment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDeleteDeployment");
            
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null) throw new ApiException(400, "Missing required parameter 'deploymentId' when calling ReposDeleteDeployment");
            

            var path = "/repos/{owner}/{repo}/deployments/{deployment_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "deployment_id" + "}", ApiClient.ParameterToString(deploymentId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteDeployment: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a file Deletes a file in a repository.  You can provide an additional &#x60;committer&#x60; parameter, which is an object containing information about the committer. Or, you can provide an &#x60;author&#x60; parameter, which is an object containing information about the author.  The &#x60;author&#x60; section is optional and is filled in with the &#x60;committer&#x60; information if omitted. If the &#x60;committer&#x60; information is omitted, the authenticated user&#39;s information is used.  You must provide values for both &#x60;name&#x60; and &#x60;email&#x60;, whether you choose to use &#x60;author&#x60; or &#x60;committer&#x60;. Otherwise, you&#39;ll receive a &#x60;422&#x60; status code.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="path">path parameter</param>
        /// <param name="reposDeleteFileRequest"></param>
        /// <returns>FileCommit</returns>
        public FileCommit ReposDeleteFile (string owner, string repo, string path, ReposDeleteFileRequest reposDeleteFileRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDeleteFile");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDeleteFile");
            
            // verify the required parameter 'path' is set
            if (path == null) throw new ApiException(400, "Missing required parameter 'path' when calling ReposDeleteFile");
            
            // verify the required parameter 'reposDeleteFileRequest' is set
            if (reposDeleteFileRequest == null) throw new ApiException(400, "Missing required parameter 'reposDeleteFileRequest' when calling ReposDeleteFile");
            

            path = "/repos/{owner}/{repo}/contents/{path}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
            path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
            path = path.Replace("{" + "path" + "}", ApiClient.ParameterToString(path));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposDeleteFileRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteFile: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteFile: " + response.ErrorMessage, response.ErrorMessage);

            return (FileCommit) ApiClient.Deserialize(response.Content, typeof(FileCommit), response.Headers);
        }

        /// <summary>
        /// Delete a repository invitation 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="invitationId">The unique identifier of the invitation.</param>
        /// <returns></returns>
        public void ReposDeleteInvitation (string owner, string repo, int? invitationId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDeleteInvitation");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDeleteInvitation");
            
            // verify the required parameter 'invitationId' is set
            if (invitationId == null) throw new ApiException(400, "Missing required parameter 'invitationId' when calling ReposDeleteInvitation");
            

            var path = "/repos/{owner}/{repo}/invitations/{invitation_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteInvitation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteInvitation: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a GitHub Pages site 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        public void ReposDeletePagesSite (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDeletePagesSite");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDeletePagesSite");
            

            var path = "/repos/{owner}/{repo}/pages";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeletePagesSite: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeletePagesSite: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete pull request review protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns></returns>
        public void ReposDeletePullRequestReviewProtection (string owner, string repo, string branch)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDeletePullRequestReviewProtection");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDeletePullRequestReviewProtection");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposDeletePullRequestReviewProtection");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/required_pull_request_reviews";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeletePullRequestReviewProtection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeletePullRequestReviewProtection: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a release Users with push access to the repository can delete a release.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="releaseId">The unique identifier of the release.</param>
        /// <returns></returns>
        public void ReposDeleteRelease (string owner, string repo, int? releaseId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDeleteRelease");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDeleteRelease");
            
            // verify the required parameter 'releaseId' is set
            if (releaseId == null) throw new ApiException(400, "Missing required parameter 'releaseId' when calling ReposDeleteRelease");
            

            var path = "/repos/{owner}/{repo}/releases/{release_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "release_id" + "}", ApiClient.ParameterToString(releaseId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteRelease: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteRelease: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a release asset 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="assetId">The unique identifier of the asset.</param>
        /// <returns></returns>
        public void ReposDeleteReleaseAsset (string owner, string repo, int? assetId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDeleteReleaseAsset");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDeleteReleaseAsset");
            
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling ReposDeleteReleaseAsset");
            

            var path = "/repos/{owner}/{repo}/releases/assets/{asset_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "asset_id" + "}", ApiClient.ParameterToString(assetId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteReleaseAsset: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteReleaseAsset: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a tag protection state for a repository This deletes a tag protection state for a repository. This endpoint is only available to repository administrators.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="tagProtectionId">The unique identifier of the tag protection.</param>
        /// <returns></returns>
        public void ReposDeleteTagProtection (string owner, string repo, int? tagProtectionId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDeleteTagProtection");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDeleteTagProtection");
            
            // verify the required parameter 'tagProtectionId' is set
            if (tagProtectionId == null) throw new ApiException(400, "Missing required parameter 'tagProtectionId' when calling ReposDeleteTagProtection");
            

            var path = "/repos/{owner}/{repo}/tags/protection/{tag_protection_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "tag_protection_id" + "}", ApiClient.ParameterToString(tagProtectionId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteTagProtection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteTagProtection: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a repository webhook 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <returns></returns>
        public void ReposDeleteWebhook (string owner, string repo, int? hookId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDeleteWebhook");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDeleteWebhook");
            
            // verify the required parameter 'hookId' is set
            if (hookId == null) throw new ApiException(400, "Missing required parameter 'hookId' when calling ReposDeleteWebhook");
            

            var path = "/repos/{owner}/{repo}/hooks/{hook_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDeleteWebhook: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Disable automated security fixes Disables automated security fixes for a repository. The authenticated user must have admin access to the repository. For more information, see \&quot;[Configuring automated security fixes](https://docs.github.com/en/articles/configuring-automated-security-fixes)\&quot;.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        public void ReposDisableAutomatedSecurityFixes (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDisableAutomatedSecurityFixes");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDisableAutomatedSecurityFixes");
            

            var path = "/repos/{owner}/{repo}/automated-security-fixes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDisableAutomatedSecurityFixes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDisableAutomatedSecurityFixes: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Disable Git LFS for a repository 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        public void ReposDisableLfsForRepo (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDisableLfsForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDisableLfsForRepo");
            

            var path = "/repos/{owner}/{repo}/lfs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDisableLfsForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDisableLfsForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Disable vulnerability alerts Disables dependency alerts and the dependency graph for a repository. The authenticated user must have admin access to the repository. For more information, see \&quot;[About security alerts for vulnerable dependencies](https://docs.github.com/en/articles/about-security-alerts-for-vulnerable-dependencies)\&quot;.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        public void ReposDisableVulnerabilityAlerts (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDisableVulnerabilityAlerts");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDisableVulnerabilityAlerts");
            

            var path = "/repos/{owner}/{repo}/vulnerability-alerts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDisableVulnerabilityAlerts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDisableVulnerabilityAlerts: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Download a repository archive (tar) Gets a redirect URL to download a tar archive for a repository. If you omit &#x60;:ref&#x60;, the repository’s default branch (usually &#x60;master&#x60;) will be used. Please make sure your HTTP framework is configured to follow redirects or you will need to use the &#x60;Location&#x60; header to make a second &#x60;GET&#x60; request. **Note**: For private repositories, these links are temporary and expire after five minutes.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="_ref"></param>
        /// <returns></returns>
        public void ReposDownloadTarballArchive (string owner, string repo, string _ref)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDownloadTarballArchive");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDownloadTarballArchive");
            
            // verify the required parameter '_ref' is set
            if (_ref == null) throw new ApiException(400, "Missing required parameter '_ref' when calling ReposDownloadTarballArchive");
            

            var path = "/repos/{owner}/{repo}/tarball/{ref}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "ref" + "}", ApiClient.ParameterToString(_ref));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDownloadTarballArchive: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDownloadTarballArchive: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Download a repository archive (zip) Gets a redirect URL to download a zip archive for a repository. If you omit &#x60;:ref&#x60;, the repository’s default branch (usually &#x60;master&#x60;) will be used. Please make sure your HTTP framework is configured to follow redirects or you will need to use the &#x60;Location&#x60; header to make a second &#x60;GET&#x60; request.  **Note**: For private repositories, these links are temporary and expire after five minutes. If the repository is empty, you will receive a 404 when you follow the redirect.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="_ref"></param>
        /// <returns></returns>
        public void ReposDownloadZipballArchive (string owner, string repo, string _ref)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposDownloadZipballArchive");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposDownloadZipballArchive");
            
            // verify the required parameter '_ref' is set
            if (_ref == null) throw new ApiException(400, "Missing required parameter '_ref' when calling ReposDownloadZipballArchive");
            

            var path = "/repos/{owner}/{repo}/zipball/{ref}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "ref" + "}", ApiClient.ParameterToString(_ref));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDownloadZipballArchive: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposDownloadZipballArchive: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Enable automated security fixes Enables automated security fixes for a repository. The authenticated user must have admin access to the repository. For more information, see \&quot;[Configuring automated security fixes](https://docs.github.com/en/articles/configuring-automated-security-fixes)\&quot;.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        public void ReposEnableAutomatedSecurityFixes (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposEnableAutomatedSecurityFixes");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposEnableAutomatedSecurityFixes");
            

            var path = "/repos/{owner}/{repo}/automated-security-fixes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposEnableAutomatedSecurityFixes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposEnableAutomatedSecurityFixes: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Enable Git LFS for a repository 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>Object</returns>
        public Object ReposEnableLfsForRepo (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposEnableLfsForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposEnableLfsForRepo");
            

            var path = "/repos/{owner}/{repo}/lfs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposEnableLfsForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposEnableLfsForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Enable vulnerability alerts Enables dependency alerts and the dependency graph for a repository. The authenticated user must have admin access to the repository. For more information, see \&quot;[About security alerts for vulnerable dependencies](https://docs.github.com/en/articles/about-security-alerts-for-vulnerable-dependencies)\&quot;.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        public void ReposEnableVulnerabilityAlerts (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposEnableVulnerabilityAlerts");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposEnableVulnerabilityAlerts");
            

            var path = "/repos/{owner}/{repo}/vulnerability-alerts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposEnableVulnerabilityAlerts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposEnableVulnerabilityAlerts: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Generate release notes content for a release Generate a name and body describing a [release](https://docs.github.com/rest/reference/repos#releases). The body content will be markdown formatted and contain information like the changes since last release and users who contributed. The generated release notes are not saved anywhere. They are intended to be generated and used when creating a new release.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposGenerateReleaseNotesRequest"></param>
        /// <returns>GeneratedReleaseNotesContent</returns>
        public GeneratedReleaseNotesContent ReposGenerateReleaseNotes (string owner, string repo, ReposGenerateReleaseNotesRequest reposGenerateReleaseNotesRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGenerateReleaseNotes");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGenerateReleaseNotes");
            
            // verify the required parameter 'reposGenerateReleaseNotesRequest' is set
            if (reposGenerateReleaseNotesRequest == null) throw new ApiException(400, "Missing required parameter 'reposGenerateReleaseNotesRequest' when calling ReposGenerateReleaseNotes");
            

            var path = "/repos/{owner}/{repo}/releases/generate-notes";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposGenerateReleaseNotesRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGenerateReleaseNotes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGenerateReleaseNotes: " + response.ErrorMessage, response.ErrorMessage);

            return (GeneratedReleaseNotesContent) ApiClient.Deserialize(response.Content, typeof(GeneratedReleaseNotesContent), response.Headers);
        }

        /// <summary>
        /// Get a repository The &#x60;parent&#x60; and &#x60;source&#x60; objects are present when the repository is a fork. &#x60;parent&#x60; is the repository this repository was forked from, &#x60;source&#x60; is the ultimate source for the network.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>FullRepository</returns>
        public FullRepository ReposGet (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGet");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGet");
            

            var path = "/repos/{owner}/{repo}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGet: " + response.ErrorMessage, response.ErrorMessage);

            return (FullRepository) ApiClient.Deserialize(response.Content, typeof(FullRepository), response.Headers);
        }

        /// <summary>
        /// Get access restrictions Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Lists who has access to this protected branch.  **Note**: Users, apps, and teams &#x60;restrictions&#x60; are only available for organization-owned repositories.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>BranchRestrictionPolicy</returns>
        public BranchRestrictionPolicy ReposGetAccessRestrictions (string owner, string repo, string branch)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetAccessRestrictions");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetAccessRestrictions");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposGetAccessRestrictions");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/restrictions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetAccessRestrictions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetAccessRestrictions: " + response.ErrorMessage, response.ErrorMessage);

            return (BranchRestrictionPolicy) ApiClient.Deserialize(response.Content, typeof(BranchRestrictionPolicy), response.Headers);
        }

        /// <summary>
        /// Get admin branch protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>ProtectedBranchAdminEnforced</returns>
        public ProtectedBranchAdminEnforced ReposGetAdminBranchProtection (string owner, string repo, string branch)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetAdminBranchProtection");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetAdminBranchProtection");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposGetAdminBranchProtection");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/enforce_admins";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetAdminBranchProtection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetAdminBranchProtection: " + response.ErrorMessage, response.ErrorMessage);

            return (ProtectedBranchAdminEnforced) ApiClient.Deserialize(response.Content, typeof(ProtectedBranchAdminEnforced), response.Headers);
        }

        /// <summary>
        /// Get all environments Get all environments for a repository.  Anyone with read access to the repository can use this endpoint. If the repository is private, you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ReposGetAllEnvironments200Response</returns>
        public ReposGetAllEnvironments200Response ReposGetAllEnvironments (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetAllEnvironments");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetAllEnvironments");
            

            var path = "/repos/{owner}/{repo}/environments";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetAllEnvironments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetAllEnvironments: " + response.ErrorMessage, response.ErrorMessage);

            return (ReposGetAllEnvironments200Response) ApiClient.Deserialize(response.Content, typeof(ReposGetAllEnvironments200Response), response.Headers);
        }

        /// <summary>
        /// Get all status check contexts Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> ReposGetAllStatusCheckContexts (string owner, string repo, string branch)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetAllStatusCheckContexts");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetAllStatusCheckContexts");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposGetAllStatusCheckContexts");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/required_status_checks/contexts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetAllStatusCheckContexts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetAllStatusCheckContexts: " + response.ErrorMessage, response.ErrorMessage);

            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }

        /// <summary>
        /// Get all repository topics 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <returns>Topic</returns>
        public Topic ReposGetAllTopics (string owner, string repo, int? page, int? perPage)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetAllTopics");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetAllTopics");
            

            var path = "/repos/{owner}/{repo}/topics";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetAllTopics: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetAllTopics: " + response.ErrorMessage, response.ErrorMessage);

            return (Topic) ApiClient.Deserialize(response.Content, typeof(Topic), response.Headers);
        }

        /// <summary>
        /// Get apps with access to the protected branch Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Lists the GitHub Apps that have push access to this branch. Only installed GitHub Apps with &#x60;write&#x60; access to the &#x60;contents&#x60; permission can be added as authorized actors on a protected branch.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>List&lt;GitHubApp&gt;</returns>
        public List<GitHubApp> ReposGetAppsWithAccessToProtectedBranch (string owner, string repo, string branch)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetAppsWithAccessToProtectedBranch");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetAppsWithAccessToProtectedBranch");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposGetAppsWithAccessToProtectedBranch");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/restrictions/apps";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetAppsWithAccessToProtectedBranch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetAppsWithAccessToProtectedBranch: " + response.ErrorMessage, response.ErrorMessage);

            return (List<GitHubApp>) ApiClient.Deserialize(response.Content, typeof(List<GitHubApp>), response.Headers);
        }

        /// <summary>
        /// Get an autolink reference of a repository This returns a single autolink reference by ID that was configured for the given repository.  Information about autolinks are only available to repository administrators.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="autolinkId">The unique identifier of the autolink.</param>
        /// <returns>AutolinkReference</returns>
        public AutolinkReference ReposGetAutolink (string owner, string repo, int? autolinkId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetAutolink");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetAutolink");
            
            // verify the required parameter 'autolinkId' is set
            if (autolinkId == null) throw new ApiException(400, "Missing required parameter 'autolinkId' when calling ReposGetAutolink");
            

            var path = "/repos/{owner}/{repo}/autolinks/{autolink_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "autolink_id" + "}", ApiClient.ParameterToString(autolinkId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetAutolink: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetAutolink: " + response.ErrorMessage, response.ErrorMessage);

            return (AutolinkReference) ApiClient.Deserialize(response.Content, typeof(AutolinkReference), response.Headers);
        }

        /// <summary>
        /// Get a branch 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>BranchWithProtection</returns>
        public BranchWithProtection ReposGetBranch (string owner, string repo, string branch)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetBranch");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetBranch");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposGetBranch");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetBranch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetBranch: " + response.ErrorMessage, response.ErrorMessage);

            return (BranchWithProtection) ApiClient.Deserialize(response.Content, typeof(BranchWithProtection), response.Headers);
        }

        /// <summary>
        /// Get branch protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>BranchProtection</returns>
        public BranchProtection ReposGetBranchProtection (string owner, string repo, string branch)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetBranchProtection");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetBranchProtection");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposGetBranchProtection");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetBranchProtection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetBranchProtection: " + response.ErrorMessage, response.ErrorMessage);

            return (BranchProtection) ApiClient.Deserialize(response.Content, typeof(BranchProtection), response.Headers);
        }

        /// <summary>
        /// Get repository clones Get the total number of clones and breakdown per day or week for the last 14 days. Timestamps are aligned to UTC midnight of the beginning of the day or week. Week begins on Monday.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="per">The time frame to display results for.</param>
        /// <returns>CloneTraffic</returns>
        public CloneTraffic ReposGetClones (string owner, string repo, string per)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetClones");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetClones");
            

            var path = "/repos/{owner}/{repo}/traffic/clones";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (per != null) queryParams.Add("per", ApiClient.ParameterToString(per)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetClones: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetClones: " + response.ErrorMessage, response.ErrorMessage);

            return (CloneTraffic) ApiClient.Deserialize(response.Content, typeof(CloneTraffic), response.Headers);
        }

        /// <summary>
        /// Get the weekly commit activity Returns a weekly aggregate of the number of additions and deletions pushed to a repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>List&lt;List&lt;int?&gt;&gt;</returns>
        public List<List<int?>> ReposGetCodeFrequencyStats (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetCodeFrequencyStats");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetCodeFrequencyStats");
            

            var path = "/repos/{owner}/{repo}/stats/code_frequency";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetCodeFrequencyStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetCodeFrequencyStats: " + response.ErrorMessage, response.ErrorMessage);

            return (List<List<int?>>) ApiClient.Deserialize(response.Content, typeof(List<List<int?>>), response.Headers);
        }

        /// <summary>
        /// Get repository permissions for a user Checks the repository permission of a collaborator. The possible repository permissions are &#x60;admin&#x60;, &#x60;write&#x60;, &#x60;read&#x60;, and &#x60;none&#x60;.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>RepositoryCollaboratorPermission</returns>
        public RepositoryCollaboratorPermission ReposGetCollaboratorPermissionLevel (string owner, string repo, string username)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetCollaboratorPermissionLevel");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetCollaboratorPermissionLevel");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling ReposGetCollaboratorPermissionLevel");
            

            var path = "/repos/{owner}/{repo}/collaborators/{username}/permission";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetCollaboratorPermissionLevel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetCollaboratorPermissionLevel: " + response.ErrorMessage, response.ErrorMessage);

            return (RepositoryCollaboratorPermission) ApiClient.Deserialize(response.Content, typeof(RepositoryCollaboratorPermission), response.Headers);
        }

        /// <summary>
        /// Get the combined status for a specific reference Users with pull access in a repository can access a combined view of commit statuses for a given ref. The ref can be a SHA, a branch name, or a tag name.   Additionally, a combined &#x60;state&#x60; is returned. The &#x60;state&#x60; is one of:  *   **failure** if any of the contexts report as &#x60;error&#x60; or &#x60;failure&#x60; *   **pending** if there are no statuses or a context is &#x60;pending&#x60; *   **success** if the latest status for all contexts is &#x60;success&#x60;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="_ref">ref parameter</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>CombinedCommitStatus</returns>
        public CombinedCommitStatus ReposGetCombinedStatusForRef (string owner, string repo, string _ref, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetCombinedStatusForRef");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetCombinedStatusForRef");
            
            // verify the required parameter '_ref' is set
            if (_ref == null) throw new ApiException(400, "Missing required parameter '_ref' when calling ReposGetCombinedStatusForRef");
            

            var path = "/repos/{owner}/{repo}/commits/{ref}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "ref" + "}", ApiClient.ParameterToString(_ref));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetCombinedStatusForRef: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetCombinedStatusForRef: " + response.ErrorMessage, response.ErrorMessage);

            return (CombinedCommitStatus) ApiClient.Deserialize(response.Content, typeof(CombinedCommitStatus), response.Headers);
        }

        /// <summary>
        /// Get a commit Returns the contents of a single commit reference. You must have &#x60;read&#x60; access for the repository to use this endpoint.  **Note:** If there are more than 300 files in the commit diff, the response will include pagination link headers for the remaining files, up to a limit of 3000 files. Each page contains the static commit information, and the only changes are to the file listing.  You can pass the appropriate [media type](https://docs.github.com/rest/overview/media-types/#commits-commit-comparison-and-pull-requests) to  fetch &#x60;diff&#x60; and &#x60;patch&#x60; formats. Diffs with binary data will have no &#x60;patch&#x60; property.  To return only the SHA-1 hash of the commit reference, you can provide the &#x60;sha&#x60; custom [media type](https://docs.github.com/rest/overview/media-types/#commits-commit-comparison-and-pull-requests) in the &#x60;Accept&#x60; header. You can use this endpoint to check if a remote reference&#39;s SHA-1 hash is the same as your local reference&#39;s SHA-1 hash by providing the local SHA-1 reference as the ETag.  **Signature verification object**  The response will include a &#x60;verification&#x60; object that describes the result of verifying the commit&#39;s signature. The following fields are included in the &#x60;verification&#x60; object:  | Name | Type | Description | | - -- - | - -- - | - -- -- -- -- -- | | &#x60;verified&#x60; | &#x60;boolean&#x60; | Indicates whether GitHub considers the signature in this commit to be verified. | | &#x60;reason&#x60; | &#x60;string&#x60; | The reason for verified value. Possible values and their meanings are enumerated in table below. | | &#x60;signature&#x60; | &#x60;string&#x60; | The signature that was extracted from the commit. | | &#x60;payload&#x60; | &#x60;string&#x60; | The value that was signed. |  These are the possible values for &#x60;reason&#x60; in the &#x60;verification&#x60; object:  | Value | Description | | - -- -- | - -- -- -- -- -- | | &#x60;expired_key&#x60; | The key that made the signature is expired. | | &#x60;not_signing_key&#x60; | The \&quot;signing\&quot; flag is not among the usage flags in the GPG key that made the signature. | | &#x60;gpgverify_error&#x60; | There was an error communicating with the signature verification service. | | &#x60;gpgverify_unavailable&#x60; | The signature verification service is currently unavailable. | | &#x60;unsigned&#x60; | The object does not include a signature. | | &#x60;unknown_signature_type&#x60; | A non-PGP signature was found in the commit. | | &#x60;no_user&#x60; | No user was associated with the &#x60;committer&#x60; email address in the commit. | | &#x60;unverified_email&#x60; | The &#x60;committer&#x60; email address in the commit was associated with a user, but the email address is not verified on her/his account. | | &#x60;bad_email&#x60; | The &#x60;committer&#x60; email address in the commit is not included in the identities of the PGP key that made the signature. | | &#x60;unknown_key&#x60; | The key that made the signature has not been registered with any user&#39;s account. | | &#x60;malformed_signature&#x60; | There was an error parsing the signature. | | &#x60;invalid&#x60; | The signature could not be cryptographically verified using the key whose key-id was found in the signature. | | &#x60;valid&#x60; | None of the above errors applied, so the signature is considered to be verified. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="_ref">ref parameter</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <returns>Commit</returns>
        public Commit ReposGetCommit (string owner, string repo, string _ref, int? page, int? perPage)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetCommit");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetCommit");
            
            // verify the required parameter '_ref' is set
            if (_ref == null) throw new ApiException(400, "Missing required parameter '_ref' when calling ReposGetCommit");
            

            var path = "/repos/{owner}/{repo}/commits/{ref}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "ref" + "}", ApiClient.ParameterToString(_ref));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetCommit: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetCommit: " + response.ErrorMessage, response.ErrorMessage);

            return (Commit) ApiClient.Deserialize(response.Content, typeof(Commit), response.Headers);
        }

        /// <summary>
        /// Get the last year of commit activity Returns the last year of commit activity grouped by week. The &#x60;days&#x60; array is a group of commits per day, starting on &#x60;Sunday&#x60;.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>List&lt;CommitActivity&gt;</returns>
        public List<CommitActivity> ReposGetCommitActivityStats (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetCommitActivityStats");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetCommitActivityStats");
            

            var path = "/repos/{owner}/{repo}/stats/commit_activity";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetCommitActivityStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetCommitActivityStats: " + response.ErrorMessage, response.ErrorMessage);

            return (List<CommitActivity>) ApiClient.Deserialize(response.Content, typeof(List<CommitActivity>), response.Headers);
        }

        /// <summary>
        /// Get a commit comment 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <returns>CommitComment</returns>
        public CommitComment ReposGetCommitComment (string owner, string repo, int? commentId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetCommitComment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetCommitComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling ReposGetCommitComment");
            

            var path = "/repos/{owner}/{repo}/comments/{comment_id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetCommitComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetCommitComment: " + response.ErrorMessage, response.ErrorMessage);

            return (CommitComment) ApiClient.Deserialize(response.Content, typeof(CommitComment), response.Headers);
        }

        /// <summary>
        /// Get commit signature protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  When authenticated with admin or owner permissions to the repository, you can use this endpoint to check whether a branch requires signed commits. An enabled status of &#x60;true&#x60; indicates you must sign commits on this branch. For more information, see [Signing commits with GPG](https://docs.github.com/articles/signing-commits-with-gpg) in GitHub Help.  **Note**: You must enable branch protection to require signed commits.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>ProtectedBranchAdminEnforced</returns>
        public ProtectedBranchAdminEnforced ReposGetCommitSignatureProtection (string owner, string repo, string branch)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetCommitSignatureProtection");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetCommitSignatureProtection");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposGetCommitSignatureProtection");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/required_signatures";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetCommitSignatureProtection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetCommitSignatureProtection: " + response.ErrorMessage, response.ErrorMessage);

            return (ProtectedBranchAdminEnforced) ApiClient.Deserialize(response.Content, typeof(ProtectedBranchAdminEnforced), response.Headers);
        }

        /// <summary>
        /// Get community profile metrics This endpoint will return all community profile metrics, including an overall health score, repository description, the presence of documentation, detected code of conduct, detected license, and the presence of ISSUE\\_TEMPLATE, PULL\\_REQUEST\\_TEMPLATE, README, and CONTRIBUTING files.  The &#x60;health_percentage&#x60; score is defined as a percentage of how many of these four documents are present: README, CONTRIBUTING, LICENSE, and CODE_OF_CONDUCT. For example, if all four documents are present, then the &#x60;health_percentage&#x60; is &#x60;100&#x60;. If only one is present, then the &#x60;health_percentage&#x60; is &#x60;25&#x60;.  &#x60;content_reports_enabled&#x60; is only returned for organization-owned repositories.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>CommunityProfile</returns>
        public CommunityProfile ReposGetCommunityProfileMetrics (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetCommunityProfileMetrics");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetCommunityProfileMetrics");
            

            var path = "/repos/{owner}/{repo}/community/profile";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetCommunityProfileMetrics: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetCommunityProfileMetrics: " + response.ErrorMessage, response.ErrorMessage);

            return (CommunityProfile) ApiClient.Deserialize(response.Content, typeof(CommunityProfile), response.Headers);
        }

        /// <summary>
        /// Get repository content Gets the contents of a file or directory in a repository. Specify the file path or directory in &#x60;:path&#x60;. If you omit &#x60;:path&#x60;, you will receive the contents of the repository&#39;s root directory. See the description below regarding what the API response includes for directories.   Files and symlinks support [a custom media type](https://docs.github.com/rest/reference/repos#custom-media-types) for retrieving the raw content or rendered HTML (when supported). All content types support [a custom media type](https://docs.github.com/rest/reference/repos#custom-media-types) to ensure the content is returned in a consistent object format.  **Note**: *   To get a repository&#39;s contents recursively, you can [recursively get the tree](https://docs.github.com/rest/reference/git#trees). *   This API has an upper limit of 1,000 files for a directory. If you need to retrieve more files, use the [Git Trees API](https://docs.github.com/rest/reference/git#get-a-tree).  #### Size limits If the requested file&#39;s size is: * 1 MB or smaller: All features of this endpoint are supported. * Between 1-100 MB: Only the &#x60;raw&#x60; or &#x60;object&#x60; [custom media types](https://docs.github.com/rest/repos/contents#custom-media-types-for-repository-contents) are supported. Both will work as normal, except that when using the &#x60;object&#x60; media type, the &#x60;content&#x60; field will be an empty string and the &#x60;encoding&#x60; field will be &#x60;\&quot;none\&quot;&#x60;. To get the contents of these larger files, use the &#x60;raw&#x60; media type.  * Greater than 100 MB: This endpoint is not supported.  #### If the content is a directory The response will be an array of objects, one object for each item in the directory. When listing the contents of a directory, submodules have their \&quot;type\&quot; specified as \&quot;file\&quot;. Logically, the value _should_ be \&quot;submodule\&quot;. This behavior exists in API v3 [for backwards compatibility purposes](https://git.io/v1YCW). In the next major version of the API, the type will be returned as \&quot;submodule\&quot;.  #### If the content is a symlink  If the requested &#x60;:path&#x60; points to a symlink, and the symlink&#39;s target is a normal file in the repository, then the API responds with the content of the file (in the format shown in the example. Otherwise, the API responds with an object  describing the symlink itself.  #### If the content is a submodule The &#x60;submodule_git_url&#x60; identifies the location of the submodule repository, and the &#x60;sha&#x60; identifies a specific commit within the submodule repository. Git uses the given URL when cloning the submodule repository, and checks out the submodule at that specific commit.  If the submodule repository is not hosted on github.com, the Git URLs (&#x60;git_url&#x60; and &#x60;_links[\&quot;git\&quot;]&#x60;) and the github.com URLs (&#x60;html_url&#x60; and &#x60;_links[\&quot;html\&quot;]&#x60;) will have null values.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="path">path parameter</param>
        /// <param name="_ref">The name of the commit/branch/tag. Default: the repository’s default branch (usually &#x60;master&#x60;)</param>
        /// <returns>ContentTree</returns>
        public ContentTree ReposGetContent (string owner, string repo, string path, string _ref)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetContent");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetContent");
            
            // verify the required parameter 'path' is set
            if (path == null) throw new ApiException(400, "Missing required parameter 'path' when calling ReposGetContent");
            

            path = "/repos/{owner}/{repo}/contents/{path}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
            path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
            path = path.Replace("{" + "path" + "}", ApiClient.ParameterToString(path));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (_ref != null) queryParams.Add("ref", ApiClient.ParameterToString(_ref)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetContent: " + response.ErrorMessage, response.ErrorMessage);

            return (ContentTree) ApiClient.Deserialize(response.Content, typeof(ContentTree), response.Headers);
        }

        /// <summary>
        /// Get all contributor commit activity  Returns the &#x60;total&#x60; number of commits authored by the contributor. In addition, the response includes a Weekly Hash (&#x60;weeks&#x60; array) with the following information:  *   &#x60;w&#x60; - Start of the week, given as a [Unix timestamp](http://en.wikipedia.org/wiki/Unix_time). *   &#x60;a&#x60; - Number of additions *   &#x60;d&#x60; - Number of deletions *   &#x60;c&#x60; - Number of commits
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>List&lt;ContributorActivity&gt;</returns>
        public List<ContributorActivity> ReposGetContributorsStats (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetContributorsStats");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetContributorsStats");
            

            var path = "/repos/{owner}/{repo}/stats/contributors";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetContributorsStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetContributorsStats: " + response.ErrorMessage, response.ErrorMessage);

            return (List<ContributorActivity>) ApiClient.Deserialize(response.Content, typeof(List<ContributorActivity>), response.Headers);
        }

        /// <summary>
        /// Get a deploy key 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="keyId">The unique identifier of the key.</param>
        /// <returns>DeployKey</returns>
        public DeployKey ReposGetDeployKey (string owner, string repo, int? keyId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetDeployKey");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetDeployKey");
            
            // verify the required parameter 'keyId' is set
            if (keyId == null) throw new ApiException(400, "Missing required parameter 'keyId' when calling ReposGetDeployKey");
            

            var path = "/repos/{owner}/{repo}/keys/{key_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "key_id" + "}", ApiClient.ParameterToString(keyId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetDeployKey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetDeployKey: " + response.ErrorMessage, response.ErrorMessage);

            return (DeployKey) ApiClient.Deserialize(response.Content, typeof(DeployKey), response.Headers);
        }

        /// <summary>
        /// Get a deployment 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="deploymentId">deployment_id parameter</param>
        /// <returns>Deployment</returns>
        public Deployment ReposGetDeployment (string owner, string repo, int? deploymentId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetDeployment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetDeployment");
            
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null) throw new ApiException(400, "Missing required parameter 'deploymentId' when calling ReposGetDeployment");
            

            var path = "/repos/{owner}/{repo}/deployments/{deployment_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "deployment_id" + "}", ApiClient.ParameterToString(deploymentId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetDeployment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetDeployment: " + response.ErrorMessage, response.ErrorMessage);

            return (Deployment) ApiClient.Deserialize(response.Content, typeof(Deployment), response.Headers);
        }

        /// <summary>
        /// Get a deployment status Users with pull access can view a deployment status for a deployment:
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="deploymentId">deployment_id parameter</param>
        /// <param name="statusId"></param>
        /// <returns>DeploymentStatus</returns>
        public DeploymentStatus ReposGetDeploymentStatus (string owner, string repo, int? deploymentId, int? statusId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetDeploymentStatus");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetDeploymentStatus");
            
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null) throw new ApiException(400, "Missing required parameter 'deploymentId' when calling ReposGetDeploymentStatus");
            
            // verify the required parameter 'statusId' is set
            if (statusId == null) throw new ApiException(400, "Missing required parameter 'statusId' when calling ReposGetDeploymentStatus");
            

            var path = "/repos/{owner}/{repo}/deployments/{deployment_id}/statuses/{status_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "deployment_id" + "}", ApiClient.ParameterToString(deploymentId));
path = path.Replace("{" + "status_id" + "}", ApiClient.ParameterToString(statusId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetDeploymentStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetDeploymentStatus: " + response.ErrorMessage, response.ErrorMessage);

            return (DeploymentStatus) ApiClient.Deserialize(response.Content, typeof(DeploymentStatus), response.Headers);
        }

        /// <summary>
        /// Get an environment Anyone with read access to the repository can use this endpoint. If the repository is private, you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="environmentName">The name of the environment</param>
        /// <returns>Environment</returns>
        public Org.OpenAPITools.Model.Environment ReposGetEnvironment (string owner, string repo, string environmentName)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetEnvironment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetEnvironment");
            
            // verify the required parameter 'environmentName' is set
            if (environmentName == null) throw new ApiException(400, "Missing required parameter 'environmentName' when calling ReposGetEnvironment");
            

            var path = "/repos/{owner}/{repo}/environments/{environment_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "environment_name" + "}", ApiClient.ParameterToString(environmentName));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetEnvironment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetEnvironment: " + response.ErrorMessage, response.ErrorMessage);

            return (Org.OpenAPITools.Model.Environment) ApiClient.Deserialize(response.Content, typeof(Org.OpenAPITools.Model.Environment), response.Headers);
        }

        /// <summary>
        /// Get latest Pages build 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>PageBuild</returns>
        public PageBuild ReposGetLatestPagesBuild (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetLatestPagesBuild");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetLatestPagesBuild");
            

            var path = "/repos/{owner}/{repo}/pages/builds/latest";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetLatestPagesBuild: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetLatestPagesBuild: " + response.ErrorMessage, response.ErrorMessage);

            return (PageBuild) ApiClient.Deserialize(response.Content, typeof(PageBuild), response.Headers);
        }

        /// <summary>
        /// Get the latest release View the latest published full release for the repository.  The latest release is the most recent non-prerelease, non-draft release, sorted by the &#x60;created_at&#x60; attribute. The &#x60;created_at&#x60; attribute is the date of the commit used for the release, and not the date when the release was drafted or published.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>Release</returns>
        public Release ReposGetLatestRelease (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetLatestRelease");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetLatestRelease");
            

            var path = "/repos/{owner}/{repo}/releases/latest";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetLatestRelease: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetLatestRelease: " + response.ErrorMessage, response.ErrorMessage);

            return (Release) ApiClient.Deserialize(response.Content, typeof(Release), response.Headers);
        }

        /// <summary>
        /// Get a GitHub Pages site 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>GitHubPages</returns>
        public GitHubPages ReposGetPages (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetPages");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetPages");
            

            var path = "/repos/{owner}/{repo}/pages";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetPages: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetPages: " + response.ErrorMessage, response.ErrorMessage);

            return (GitHubPages) ApiClient.Deserialize(response.Content, typeof(GitHubPages), response.Headers);
        }

        /// <summary>
        /// Get GitHub Pages build 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="buildId"></param>
        /// <returns>PageBuild</returns>
        public PageBuild ReposGetPagesBuild (string owner, string repo, int? buildId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetPagesBuild");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetPagesBuild");
            
            // verify the required parameter 'buildId' is set
            if (buildId == null) throw new ApiException(400, "Missing required parameter 'buildId' when calling ReposGetPagesBuild");
            

            var path = "/repos/{owner}/{repo}/pages/builds/{build_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "build_id" + "}", ApiClient.ParameterToString(buildId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetPagesBuild: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetPagesBuild: " + response.ErrorMessage, response.ErrorMessage);

            return (PageBuild) ApiClient.Deserialize(response.Content, typeof(PageBuild), response.Headers);
        }

        /// <summary>
        /// Get a DNS health check for GitHub Pages Gets a health check of the DNS settings for the &#x60;CNAME&#x60; record configured for a repository&#39;s GitHub Pages.  The first request to this endpoint returns a &#x60;202 Accepted&#x60; status and starts an asynchronous background task to get the results for the domain. After the background task completes, subsequent requests to this endpoint return a &#x60;200 OK&#x60; status with the health check results in the response.  Users must have admin or owner permissions. GitHub Apps must have the &#x60;pages:write&#x60; and &#x60;administration:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>PagesHealthCheckStatus</returns>
        public PagesHealthCheckStatus ReposGetPagesHealthCheck (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetPagesHealthCheck");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetPagesHealthCheck");
            

            var path = "/repos/{owner}/{repo}/pages/health";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetPagesHealthCheck: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetPagesHealthCheck: " + response.ErrorMessage, response.ErrorMessage);

            return (PagesHealthCheckStatus) ApiClient.Deserialize(response.Content, typeof(PagesHealthCheckStatus), response.Headers);
        }

        /// <summary>
        /// Get the weekly commit count Returns the total commit counts for the &#x60;owner&#x60; and total commit counts in &#x60;all&#x60;. &#x60;all&#x60; is everyone combined, including the &#x60;owner&#x60; in the last 52 weeks. If you&#39;d like to get the commit counts for non-owners, you can subtract &#x60;owner&#x60; from &#x60;all&#x60;.  The array order is oldest week (index 0) to most recent week.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>ParticipationStats</returns>
        public ParticipationStats ReposGetParticipationStats (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetParticipationStats");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetParticipationStats");
            

            var path = "/repos/{owner}/{repo}/stats/participation";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetParticipationStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetParticipationStats: " + response.ErrorMessage, response.ErrorMessage);

            return (ParticipationStats) ApiClient.Deserialize(response.Content, typeof(ParticipationStats), response.Headers);
        }

        /// <summary>
        /// Get pull request review protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>ProtectedBranchPullRequestReview</returns>
        public ProtectedBranchPullRequestReview ReposGetPullRequestReviewProtection (string owner, string repo, string branch)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetPullRequestReviewProtection");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetPullRequestReviewProtection");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposGetPullRequestReviewProtection");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/required_pull_request_reviews";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetPullRequestReviewProtection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetPullRequestReviewProtection: " + response.ErrorMessage, response.ErrorMessage);

            return (ProtectedBranchPullRequestReview) ApiClient.Deserialize(response.Content, typeof(ProtectedBranchPullRequestReview), response.Headers);
        }

        /// <summary>
        /// Get the hourly commit count for each day Each array contains the day number, hour number, and number of commits:  *   &#x60;0-6&#x60;: Sunday - Saturday *   &#x60;0-23&#x60;: Hour of day *   Number of commits  For example, &#x60;[2, 14, 25]&#x60; indicates that there were 25 total commits, during the 2:00pm hour on Tuesdays. All times are based on the time zone of individual commits.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>List&lt;List&lt;int?&gt;&gt;</returns>
        public List<List<int?>> ReposGetPunchCardStats (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetPunchCardStats");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetPunchCardStats");
            

            var path = "/repos/{owner}/{repo}/stats/punch_card";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetPunchCardStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetPunchCardStats: " + response.ErrorMessage, response.ErrorMessage);

            return (List<List<int?>>) ApiClient.Deserialize(response.Content, typeof(List<List<int?>>), response.Headers);
        }

        /// <summary>
        /// Get a repository README Gets the preferred README for a repository.  READMEs support [custom media types](https://docs.github.com/rest/reference/repos#custom-media-types) for retrieving the raw content or rendered HTML.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="_ref">The name of the commit/branch/tag. Default: the repository’s default branch (usually &#x60;master&#x60;)</param>
        /// <returns>ContentFile</returns>
        public ContentFile ReposGetReadme (string owner, string repo, string _ref)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetReadme");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetReadme");
            

            var path = "/repos/{owner}/{repo}/readme";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (_ref != null) queryParams.Add("ref", ApiClient.ParameterToString(_ref)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetReadme: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetReadme: " + response.ErrorMessage, response.ErrorMessage);

            return (ContentFile) ApiClient.Deserialize(response.Content, typeof(ContentFile), response.Headers);
        }

        /// <summary>
        /// Get a repository README for a directory Gets the README from a repository directory.  READMEs support [custom media types](https://docs.github.com/rest/reference/repos#custom-media-types) for retrieving the raw content or rendered HTML.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="dir">The alternate path to look for a README file</param>
        /// <param name="_ref">The name of the commit/branch/tag. Default: the repository’s default branch (usually &#x60;master&#x60;)</param>
        /// <returns>ContentFile</returns>
        public ContentFile ReposGetReadmeInDirectory (string owner, string repo, string dir, string _ref)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetReadmeInDirectory");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetReadmeInDirectory");
            
            // verify the required parameter 'dir' is set
            if (dir == null) throw new ApiException(400, "Missing required parameter 'dir' when calling ReposGetReadmeInDirectory");
            

            var path = "/repos/{owner}/{repo}/readme/{dir}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "dir" + "}", ApiClient.ParameterToString(dir));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (_ref != null) queryParams.Add("ref", ApiClient.ParameterToString(_ref)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetReadmeInDirectory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetReadmeInDirectory: " + response.ErrorMessage, response.ErrorMessage);

            return (ContentFile) ApiClient.Deserialize(response.Content, typeof(ContentFile), response.Headers);
        }

        /// <summary>
        /// Get a release **Note:** This returns an &#x60;upload_url&#x60; key corresponding to the endpoint for uploading release assets. This key is a [hypermedia resource](https://docs.github.com/rest/overview/resources-in-the-rest-api#hypermedia).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="releaseId">The unique identifier of the release.</param>
        /// <returns>Release</returns>
        public Release ReposGetRelease (string owner, string repo, int? releaseId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetRelease");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetRelease");
            
            // verify the required parameter 'releaseId' is set
            if (releaseId == null) throw new ApiException(400, "Missing required parameter 'releaseId' when calling ReposGetRelease");
            

            var path = "/repos/{owner}/{repo}/releases/{release_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "release_id" + "}", ApiClient.ParameterToString(releaseId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetRelease: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetRelease: " + response.ErrorMessage, response.ErrorMessage);

            return (Release) ApiClient.Deserialize(response.Content, typeof(Release), response.Headers);
        }

        /// <summary>
        /// Get a release asset To download the asset&#39;s binary content, set the &#x60;Accept&#x60; header of the request to [&#x60;application/octet-stream&#x60;](https://docs.github.com/rest/overview/media-types). The API will either redirect the client to the location, or stream it directly if possible. API clients should handle both a &#x60;200&#x60; or &#x60;302&#x60; response.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="assetId">The unique identifier of the asset.</param>
        /// <returns>ReleaseAsset</returns>
        public ReleaseAsset ReposGetReleaseAsset (string owner, string repo, int? assetId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetReleaseAsset");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetReleaseAsset");
            
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling ReposGetReleaseAsset");
            

            var path = "/repos/{owner}/{repo}/releases/assets/{asset_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "asset_id" + "}", ApiClient.ParameterToString(assetId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetReleaseAsset: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetReleaseAsset: " + response.ErrorMessage, response.ErrorMessage);

            return (ReleaseAsset) ApiClient.Deserialize(response.Content, typeof(ReleaseAsset), response.Headers);
        }

        /// <summary>
        /// Get a release by tag name Get a published release with the specified tag.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="tag">tag parameter</param>
        /// <returns>Release</returns>
        public Release ReposGetReleaseByTag (string owner, string repo, string tag)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetReleaseByTag");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetReleaseByTag");
            
            // verify the required parameter 'tag' is set
            if (tag == null) throw new ApiException(400, "Missing required parameter 'tag' when calling ReposGetReleaseByTag");
            

            var path = "/repos/{owner}/{repo}/releases/tags/{tag}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "tag" + "}", ApiClient.ParameterToString(tag));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetReleaseByTag: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetReleaseByTag: " + response.ErrorMessage, response.ErrorMessage);

            return (Release) ApiClient.Deserialize(response.Content, typeof(Release), response.Headers);
        }

        /// <summary>
        /// Get status checks protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>StatusCheckPolicy</returns>
        public StatusCheckPolicy ReposGetStatusChecksProtection (string owner, string repo, string branch)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetStatusChecksProtection");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetStatusChecksProtection");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposGetStatusChecksProtection");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/required_status_checks";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetStatusChecksProtection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetStatusChecksProtection: " + response.ErrorMessage, response.ErrorMessage);

            return (StatusCheckPolicy) ApiClient.Deserialize(response.Content, typeof(StatusCheckPolicy), response.Headers);
        }

        /// <summary>
        /// Get teams with access to the protected branch Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Lists the teams who have push access to this branch. The list includes child teams.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>List&lt;Team&gt;</returns>
        public List<Team> ReposGetTeamsWithAccessToProtectedBranch (string owner, string repo, string branch)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetTeamsWithAccessToProtectedBranch");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetTeamsWithAccessToProtectedBranch");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposGetTeamsWithAccessToProtectedBranch");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/restrictions/teams";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetTeamsWithAccessToProtectedBranch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetTeamsWithAccessToProtectedBranch: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Team>) ApiClient.Deserialize(response.Content, typeof(List<Team>), response.Headers);
        }

        /// <summary>
        /// Get top referral paths Get the top 10 popular contents over the last 14 days.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>List&lt;ContentTraffic&gt;</returns>
        public List<ContentTraffic> ReposGetTopPaths (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetTopPaths");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetTopPaths");
            

            var path = "/repos/{owner}/{repo}/traffic/popular/paths";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetTopPaths: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetTopPaths: " + response.ErrorMessage, response.ErrorMessage);

            return (List<ContentTraffic>) ApiClient.Deserialize(response.Content, typeof(List<ContentTraffic>), response.Headers);
        }

        /// <summary>
        /// Get top referral sources Get the top 10 referrers over the last 14 days.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>List&lt;ReferrerTraffic&gt;</returns>
        public List<ReferrerTraffic> ReposGetTopReferrers (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetTopReferrers");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetTopReferrers");
            

            var path = "/repos/{owner}/{repo}/traffic/popular/referrers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetTopReferrers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetTopReferrers: " + response.ErrorMessage, response.ErrorMessage);

            return (List<ReferrerTraffic>) ApiClient.Deserialize(response.Content, typeof(List<ReferrerTraffic>), response.Headers);
        }

        /// <summary>
        /// Get users with access to the protected branch Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Lists the people who have push access to this branch.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        public List<SimpleUser1> ReposGetUsersWithAccessToProtectedBranch (string owner, string repo, string branch)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetUsersWithAccessToProtectedBranch");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetUsersWithAccessToProtectedBranch");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposGetUsersWithAccessToProtectedBranch");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/restrictions/users";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetUsersWithAccessToProtectedBranch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetUsersWithAccessToProtectedBranch: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SimpleUser1>) ApiClient.Deserialize(response.Content, typeof(List<SimpleUser1>), response.Headers);
        }

        /// <summary>
        /// Get page views Get the total number of views and breakdown per day or week for the last 14 days. Timestamps are aligned to UTC midnight of the beginning of the day or week. Week begins on Monday.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="per">The time frame to display results for.</param>
        /// <returns>ViewTraffic</returns>
        public ViewTraffic ReposGetViews (string owner, string repo, string per)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetViews");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetViews");
            

            var path = "/repos/{owner}/{repo}/traffic/views";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (per != null) queryParams.Add("per", ApiClient.ParameterToString(per)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetViews: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetViews: " + response.ErrorMessage, response.ErrorMessage);

            return (ViewTraffic) ApiClient.Deserialize(response.Content, typeof(ViewTraffic), response.Headers);
        }

        /// <summary>
        /// Get a repository webhook Returns a webhook configured in a repository. To get only the webhook &#x60;config&#x60; properties, see \&quot;[Get a webhook configuration for a repository](/rest/reference/repos#get-a-webhook-configuration-for-a-repository).\&quot;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <returns>Webhook</returns>
        public Webhook ReposGetWebhook (string owner, string repo, int? hookId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetWebhook");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetWebhook");
            
            // verify the required parameter 'hookId' is set
            if (hookId == null) throw new ApiException(400, "Missing required parameter 'hookId' when calling ReposGetWebhook");
            

            var path = "/repos/{owner}/{repo}/hooks/{hook_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetWebhook: " + response.ErrorMessage, response.ErrorMessage);

            return (Webhook) ApiClient.Deserialize(response.Content, typeof(Webhook), response.Headers);
        }

        /// <summary>
        /// Get a webhook configuration for a repository Returns the webhook configuration for a repository. To get more information about the webhook, including the &#x60;active&#x60; state and &#x60;events&#x60;, use \&quot;[Get a repository webhook](/rest/reference/orgs#get-a-repository-webhook).\&quot;  Access tokens must have the &#x60;read:repo_hook&#x60; or &#x60;repo&#x60; scope, and GitHub Apps must have the &#x60;repository_hooks:read&#x60; permission.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <returns>WebhookConfiguration</returns>
        public WebhookConfiguration ReposGetWebhookConfigForRepo (string owner, string repo, int? hookId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetWebhookConfigForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetWebhookConfigForRepo");
            
            // verify the required parameter 'hookId' is set
            if (hookId == null) throw new ApiException(400, "Missing required parameter 'hookId' when calling ReposGetWebhookConfigForRepo");
            

            var path = "/repos/{owner}/{repo}/hooks/{hook_id}/config";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetWebhookConfigForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetWebhookConfigForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (WebhookConfiguration) ApiClient.Deserialize(response.Content, typeof(WebhookConfiguration), response.Headers);
        }

        /// <summary>
        /// Get a delivery for a repository webhook Returns a delivery for a webhook configured in a repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <param name="deliveryId"></param>
        /// <returns>WebhookDelivery</returns>
        public WebhookDelivery ReposGetWebhookDelivery (string owner, string repo, int? hookId, int? deliveryId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposGetWebhookDelivery");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposGetWebhookDelivery");
            
            // verify the required parameter 'hookId' is set
            if (hookId == null) throw new ApiException(400, "Missing required parameter 'hookId' when calling ReposGetWebhookDelivery");
            
            // verify the required parameter 'deliveryId' is set
            if (deliveryId == null) throw new ApiException(400, "Missing required parameter 'deliveryId' when calling ReposGetWebhookDelivery");
            

            var path = "/repos/{owner}/{repo}/hooks/{hook_id}/deliveries/{delivery_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetWebhookDelivery: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposGetWebhookDelivery: " + response.ErrorMessage, response.ErrorMessage);

            return (WebhookDelivery) ApiClient.Deserialize(response.Content, typeof(WebhookDelivery), response.Headers);
        }

        /// <summary>
        /// List all autolinks of a repository This returns a list of autolinks configured for the given repository.  Information about autolinks are only available to repository administrators.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;AutolinkReference&gt;</returns>
        public List<AutolinkReference> ReposListAutolinks (string owner, string repo, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListAutolinks");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListAutolinks");
            

            var path = "/repos/{owner}/{repo}/autolinks";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListAutolinks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListAutolinks: " + response.ErrorMessage, response.ErrorMessage);

            return (List<AutolinkReference>) ApiClient.Deserialize(response.Content, typeof(List<AutolinkReference>), response.Headers);
        }

        /// <summary>
        /// List branches 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="_protected">Setting to &#x60;true&#x60; returns only protected branches. When set to &#x60;false&#x60;, only unprotected branches are returned. Omitting this parameter returns all branches.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;ShortBranch&gt;</returns>
        public List<ShortBranch> ReposListBranches (string owner, string repo, bool? _protected, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListBranches");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListBranches");
            

            var path = "/repos/{owner}/{repo}/branches";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (_protected != null) queryParams.Add("protected", ApiClient.ParameterToString(_protected)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListBranches: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListBranches: " + response.ErrorMessage, response.ErrorMessage);

            return (List<ShortBranch>) ApiClient.Deserialize(response.Content, typeof(List<ShortBranch>), response.Headers);
        }

        /// <summary>
        /// List branches for HEAD commit Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Returns all branches where the given commit SHA is the HEAD, or latest commit for the branch.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commitSha">The SHA of the commit.</param>
        /// <returns>List&lt;BranchShort&gt;</returns>
        public List<BranchShort> ReposListBranchesForHeadCommit (string owner, string repo, string commitSha)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListBranchesForHeadCommit");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListBranchesForHeadCommit");
            
            // verify the required parameter 'commitSha' is set
            if (commitSha == null) throw new ApiException(400, "Missing required parameter 'commitSha' when calling ReposListBranchesForHeadCommit");
            

            var path = "/repos/{owner}/{repo}/commits/{commit_sha}/branches-where-head";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "commit_sha" + "}", ApiClient.ParameterToString(commitSha));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListBranchesForHeadCommit: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListBranchesForHeadCommit: " + response.ErrorMessage, response.ErrorMessage);

            return (List<BranchShort>) ApiClient.Deserialize(response.Content, typeof(List<BranchShort>), response.Headers);
        }

        /// <summary>
        /// List repository collaborators For organization-owned repositories, the list of collaborators includes outside collaborators, organization members that are direct collaborators, organization members with access through team memberships, organization members with access through default organization permissions, and organization owners. Organization members with write, maintain, or admin privileges on the organization-owned repository can use this endpoint.  Team members will include the members of child teams.  You must authenticate using an access token with the &#x60;read:org&#x60; and &#x60;repo&#x60; scopes with push access to use this endpoint. GitHub Apps must have the &#x60;members&#x60; organization permission and &#x60;metadata&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="affiliation">Filter collaborators returned by their affiliation. &#x60;outside&#x60; means all outside collaborators of an organization-owned repository. &#x60;direct&#x60; means all collaborators with permissions to an organization-owned repository, regardless of organization membership status. &#x60;all&#x60; means all collaborators the authenticated user can see.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Collaborator&gt;</returns>
        public List<Collaborator> ReposListCollaborators (string owner, string repo, string affiliation, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListCollaborators");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListCollaborators");
            

            var path = "/repos/{owner}/{repo}/collaborators";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (affiliation != null) queryParams.Add("affiliation", ApiClient.ParameterToString(affiliation)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListCollaborators: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListCollaborators: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Collaborator>) ApiClient.Deserialize(response.Content, typeof(List<Collaborator>), response.Headers);
        }

        /// <summary>
        /// List commit comments Use the &#x60;:commit_sha&#x60; to specify the commit that will have its comments listed.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commitSha">The SHA of the commit.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;CommitComment&gt;</returns>
        public List<CommitComment> ReposListCommentsForCommit (string owner, string repo, string commitSha, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListCommentsForCommit");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListCommentsForCommit");
            
            // verify the required parameter 'commitSha' is set
            if (commitSha == null) throw new ApiException(400, "Missing required parameter 'commitSha' when calling ReposListCommentsForCommit");
            

            var path = "/repos/{owner}/{repo}/commits/{commit_sha}/comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "commit_sha" + "}", ApiClient.ParameterToString(commitSha));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListCommentsForCommit: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListCommentsForCommit: " + response.ErrorMessage, response.ErrorMessage);

            return (List<CommitComment>) ApiClient.Deserialize(response.Content, typeof(List<CommitComment>), response.Headers);
        }

        /// <summary>
        /// List commit comments for a repository Commit Comments use [these custom media types](https://docs.github.com/rest/reference/repos#custom-media-types). You can read more about the use of media types in the API [here](https://docs.github.com/rest/overview/media-types/).  Comments are ordered by ascending ID.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;CommitComment&gt;</returns>
        public List<CommitComment> ReposListCommitCommentsForRepo (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListCommitCommentsForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListCommitCommentsForRepo");
            

            var path = "/repos/{owner}/{repo}/comments";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListCommitCommentsForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListCommitCommentsForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (List<CommitComment>) ApiClient.Deserialize(response.Content, typeof(List<CommitComment>), response.Headers);
        }

        /// <summary>
        /// List commit statuses for a reference Users with pull access in a repository can view commit statuses for a given ref. The ref can be a SHA, a branch name, or a tag name. Statuses are returned in reverse chronological order. The first status in the list will be the latest one.  This resource is also available via a legacy route: &#x60;GET /repos/:owner/:repo/statuses/:ref&#x60;.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="_ref">ref parameter</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Status&gt;</returns>
        public List<Status> ReposListCommitStatusesForRef (string owner, string repo, string _ref, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListCommitStatusesForRef");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListCommitStatusesForRef");
            
            // verify the required parameter '_ref' is set
            if (_ref == null) throw new ApiException(400, "Missing required parameter '_ref' when calling ReposListCommitStatusesForRef");
            

            var path = "/repos/{owner}/{repo}/commits/{ref}/statuses";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "ref" + "}", ApiClient.ParameterToString(_ref));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListCommitStatusesForRef: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListCommitStatusesForRef: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Status>) ApiClient.Deserialize(response.Content, typeof(List<Status>), response.Headers);
        }

        /// <summary>
        /// List commits **Signature verification object**  The response will include a &#x60;verification&#x60; object that describes the result of verifying the commit&#39;s signature. The following fields are included in the &#x60;verification&#x60; object:  | Name | Type | Description | | - -- - | - -- - | - -- -- -- -- -- | | &#x60;verified&#x60; | &#x60;boolean&#x60; | Indicates whether GitHub considers the signature in this commit to be verified. | | &#x60;reason&#x60; | &#x60;string&#x60; | The reason for verified value. Possible values and their meanings are enumerated in table below. | | &#x60;signature&#x60; | &#x60;string&#x60; | The signature that was extracted from the commit. | | &#x60;payload&#x60; | &#x60;string&#x60; | The value that was signed. |  These are the possible values for &#x60;reason&#x60; in the &#x60;verification&#x60; object:  | Value | Description | | - -- -- | - -- -- -- -- -- | | &#x60;expired_key&#x60; | The key that made the signature is expired. | | &#x60;not_signing_key&#x60; | The \&quot;signing\&quot; flag is not among the usage flags in the GPG key that made the signature. | | &#x60;gpgverify_error&#x60; | There was an error communicating with the signature verification service. | | &#x60;gpgverify_unavailable&#x60; | The signature verification service is currently unavailable. | | &#x60;unsigned&#x60; | The object does not include a signature. | | &#x60;unknown_signature_type&#x60; | A non-PGP signature was found in the commit. | | &#x60;no_user&#x60; | No user was associated with the &#x60;committer&#x60; email address in the commit. | | &#x60;unverified_email&#x60; | The &#x60;committer&#x60; email address in the commit was associated with a user, but the email address is not verified on her/his account. | | &#x60;bad_email&#x60; | The &#x60;committer&#x60; email address in the commit is not included in the identities of the PGP key that made the signature. | | &#x60;unknown_key&#x60; | The key that made the signature has not been registered with any user&#39;s account. | | &#x60;malformed_signature&#x60; | There was an error parsing the signature. | | &#x60;invalid&#x60; | The signature could not be cryptographically verified using the key whose key-id was found in the signature. | | &#x60;valid&#x60; | None of the above errors applied, so the signature is considered to be verified. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="sha">SHA or branch to start listing commits from. Default: the repository’s default branch (usually &#x60;master&#x60;).</param>
        /// <param name="path">Only commits containing this file path will be returned.</param>
        /// <param name="author">GitHub login or email address by which to filter by commit author.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="until">Only commits before this date will be returned. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Commit&gt;</returns>
        public List<Commit> ReposListCommits (string owner, string repo, string sha, string path, string author, DateTime? since, DateTime? until, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListCommits");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListCommits");
            

            path = "/repos/{owner}/{repo}/commits";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
            path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (sha != null) queryParams.Add("sha", ApiClient.ParameterToString(sha)); // query parameter
            if (path != null) queryParams.Add("path", ApiClient.ParameterToString(path)); // query parameter
            if (author != null) queryParams.Add("author", ApiClient.ParameterToString(author)); // query parameter
            if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
            if (until != null) queryParams.Add("until", ApiClient.ParameterToString(until)); // query parameter
            if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
            if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListCommits: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListCommits: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Commit>) ApiClient.Deserialize(response.Content, typeof(List<Commit>), response.Headers);
        }

        /// <summary>
        /// List repository contributors Lists contributors to the specified repository and sorts them by the number of commits per contributor in descending order. This endpoint may return information that is a few hours old because the GitHub REST API v3 caches contributor data to improve performance.  GitHub identifies contributors by author email address. This endpoint groups contribution counts by GitHub user, which includes all associated email addresses. To improve performance, only the first 500 author email addresses in the repository link to GitHub users. The rest will appear as anonymous contributors without associated GitHub user information.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="anon">Set to &#x60;1&#x60; or &#x60;true&#x60; to include anonymous contributors in results.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Contributor&gt;</returns>
        public List<Contributor> ReposListContributors (string owner, string repo, string anon, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListContributors");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListContributors");
            

            var path = "/repos/{owner}/{repo}/contributors";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (anon != null) queryParams.Add("anon", ApiClient.ParameterToString(anon)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListContributors: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListContributors: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Contributor>) ApiClient.Deserialize(response.Content, typeof(List<Contributor>), response.Headers);
        }

        /// <summary>
        /// List deploy keys 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;DeployKey&gt;</returns>
        public List<DeployKey> ReposListDeployKeys (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListDeployKeys");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListDeployKeys");
            

            var path = "/repos/{owner}/{repo}/keys";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListDeployKeys: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListDeployKeys: " + response.ErrorMessage, response.ErrorMessage);

            return (List<DeployKey>) ApiClient.Deserialize(response.Content, typeof(List<DeployKey>), response.Headers);
        }

        /// <summary>
        /// List deployment statuses Users with pull access can view deployment statuses for a deployment:
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="deploymentId">deployment_id parameter</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;DeploymentStatus&gt;</returns>
        public List<DeploymentStatus> ReposListDeploymentStatuses (string owner, string repo, int? deploymentId, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListDeploymentStatuses");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListDeploymentStatuses");
            
            // verify the required parameter 'deploymentId' is set
            if (deploymentId == null) throw new ApiException(400, "Missing required parameter 'deploymentId' when calling ReposListDeploymentStatuses");
            

            var path = "/repos/{owner}/{repo}/deployments/{deployment_id}/statuses";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "deployment_id" + "}", ApiClient.ParameterToString(deploymentId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListDeploymentStatuses: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListDeploymentStatuses: " + response.ErrorMessage, response.ErrorMessage);

            return (List<DeploymentStatus>) ApiClient.Deserialize(response.Content, typeof(List<DeploymentStatus>), response.Headers);
        }

        /// <summary>
        /// List deployments Simple filtering of deployments is available via query parameters:
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="sha">The SHA recorded at creation time.</param>
        /// <param name="_ref">The name of the ref. This can be a branch, tag, or SHA.</param>
        /// <param name="task">The name of the task for the deployment (e.g., &#x60;deploy&#x60; or &#x60;deploy:migrations&#x60;).</param>
        /// <param name="environment">The name of the environment that was deployed to (e.g., &#x60;staging&#x60; or &#x60;production&#x60;).</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Deployment&gt;</returns>
        public List<Deployment> ReposListDeployments (string owner, string repo, string sha, string _ref, string task, string environment, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListDeployments");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListDeployments");
            

            var path = "/repos/{owner}/{repo}/deployments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (sha != null) queryParams.Add("sha", ApiClient.ParameterToString(sha)); // query parameter
 if (_ref != null) queryParams.Add("ref", ApiClient.ParameterToString(_ref)); // query parameter
 if (task != null) queryParams.Add("task", ApiClient.ParameterToString(task)); // query parameter
 if (environment != null) queryParams.Add("environment", ApiClient.ParameterToString(environment)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListDeployments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListDeployments: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Deployment>) ApiClient.Deserialize(response.Content, typeof(List<Deployment>), response.Headers);
        }

        /// <summary>
        /// List repositories for the authenticated user Lists repositories that the authenticated user has explicit permission (&#x60;:read&#x60;, &#x60;:write&#x60;, or &#x60;:admin&#x60;) to access.  The authenticated user has explicit permission to access repositories they own, repositories where they are a collaborator, and repositories that they can access through an organization membership.
        /// </summary>
        /// <param name="visibility">Limit results to repositories with the specified visibility.</param>
        /// <param name="affiliation">Comma-separated list of values. Can include:   \\* &#x60;owner&#x60;: Repositories that are owned by the authenticated user.   \\* &#x60;collaborator&#x60;: Repositories that the user has been added to as a collaborator.   \\* &#x60;organization_member&#x60;: Repositories that the user has access to through being a member of an organization. This includes every repository on every team that the user is on.</param>
        /// <param name="type">Limit results to repositories of the specified type. Will cause a &#x60;422&#x60; error if used in the same request as **visibility** or **affiliation**.</param>
        /// <param name="sort">The property to sort the results by.</param>
        /// <param name="direction">The order to sort by. Default: &#x60;asc&#x60; when using &#x60;full_name&#x60;, otherwise &#x60;desc&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="before">Only show notifications updated before the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <returns>List&lt;Repository&gt;</returns>
        public List<Repository> ReposListForAuthenticatedUser (string visibility, string affiliation, string type, string sort, string direction, int? perPage, int? page, DateTime? since, DateTime? before)
        {
            

            var path = "/user/repos";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (visibility != null) queryParams.Add("visibility", ApiClient.ParameterToString(visibility)); // query parameter
 if (affiliation != null) queryParams.Add("affiliation", ApiClient.ParameterToString(affiliation)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
 if (before != null) queryParams.Add("before", ApiClient.ParameterToString(before)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Repository>) ApiClient.Deserialize(response.Content, typeof(List<Repository>), response.Headers);
        }

        /// <summary>
        /// List organization repositories Lists repositories for the specified organization.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="type">Specifies the types of repositories you want returned. If your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+, &#x60;type&#x60; can also be &#x60;internal&#x60;. However, the &#x60;internal&#x60; value is not yet supported when a GitHub App calls this API with an installation access token.</param>
        /// <param name="sort">The property to sort the results by.</param>
        /// <param name="direction">The order to sort by. Default: &#x60;asc&#x60; when using &#x60;full_name&#x60;, otherwise &#x60;desc&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MinimalRepository&gt;</returns>
        public List<MinimalRepository> ReposListForOrg (string org, string type, string sort, string direction, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ReposListForOrg");
            

            var path = "/orgs/{org}/repos";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (List<MinimalRepository>) ApiClient.Deserialize(response.Content, typeof(List<MinimalRepository>), response.Headers);
        }

        /// <summary>
        /// List repositories for a user Lists public repositories for the specified user. Note: For GitHub AE, this endpoint will list internal repositories for the specified user.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="type">Limit results to repositories of the specified type.</param>
        /// <param name="sort">The property to sort the results by.</param>
        /// <param name="direction">The order to sort by. Default: &#x60;asc&#x60; when using &#x60;full_name&#x60;, otherwise &#x60;desc&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MinimalRepository&gt;</returns>
        public List<MinimalRepository> ReposListForUser (string username, string type, string sort, string direction, int? perPage, int? page)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling ReposListForUser");
            

            var path = "/users/{username}/repos";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListForUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<MinimalRepository>) ApiClient.Deserialize(response.Content, typeof(List<MinimalRepository>), response.Headers);
        }

        /// <summary>
        /// List forks 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="sort">The sort order. Can be either &#x60;newest&#x60;, &#x60;oldest&#x60;, or &#x60;stargazers&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MinimalRepository&gt;</returns>
        public List<MinimalRepository> ReposListForks (string owner, string repo, string sort, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListForks");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListForks");
            

            var path = "/repos/{owner}/{repo}/forks";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListForks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListForks: " + response.ErrorMessage, response.ErrorMessage);

            return (List<MinimalRepository>) ApiClient.Deserialize(response.Content, typeof(List<MinimalRepository>), response.Headers);
        }

        /// <summary>
        /// List repository invitations When authenticating as a user with admin rights to a repository, this endpoint will list all currently open repository invitations.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;RepositoryInvitation&gt;</returns>
        public List<RepositoryInvitation> ReposListInvitations (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListInvitations");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListInvitations");
            

            var path = "/repos/{owner}/{repo}/invitations";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListInvitations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListInvitations: " + response.ErrorMessage, response.ErrorMessage);

            return (List<RepositoryInvitation>) ApiClient.Deserialize(response.Content, typeof(List<RepositoryInvitation>), response.Headers);
        }

        /// <summary>
        /// List repository invitations for the authenticated user When authenticating as a user, this endpoint will list all currently open repository invitations for that user.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;RepositoryInvitation&gt;</returns>
        public List<RepositoryInvitation> ReposListInvitationsForAuthenticatedUser (int? perPage, int? page)
        {
            

            var path = "/user/repository_invitations";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListInvitationsForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListInvitationsForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<RepositoryInvitation>) ApiClient.Deserialize(response.Content, typeof(List<RepositoryInvitation>), response.Headers);
        }

        /// <summary>
        /// List repository languages Lists languages for the specified repository. The value shown for each language is the number of bytes of code written in that language.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>Dictionary&lt;string, int?&gt;</returns>
        public Dictionary<string, int?> ReposListLanguages (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListLanguages");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListLanguages");
            

            var path = "/repos/{owner}/{repo}/languages";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListLanguages: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListLanguages: " + response.ErrorMessage, response.ErrorMessage);

            return (Dictionary<string, int?>) ApiClient.Deserialize(response.Content, typeof(Dictionary<string, int?>), response.Headers);
        }

        /// <summary>
        /// List GitHub Pages builds 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;PageBuild&gt;</returns>
        public List<PageBuild> ReposListPagesBuilds (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListPagesBuilds");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListPagesBuilds");
            

            var path = "/repos/{owner}/{repo}/pages/builds";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListPagesBuilds: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListPagesBuilds: " + response.ErrorMessage, response.ErrorMessage);

            return (List<PageBuild>) ApiClient.Deserialize(response.Content, typeof(List<PageBuild>), response.Headers);
        }

        /// <summary>
        /// List public repositories Lists all public repositories in the order that they were created.  Note: - For GitHub Enterprise Server, this endpoint will only list repositories available to all users on the enterprise. - Pagination is powered exclusively by the &#x60;since&#x60; parameter. Use the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header) to get the URL for the next page of repositories.
        /// </summary>
        /// <param name="since">A repository ID. Only return repositories with an ID greater than this ID.</param>
        /// <returns>List&lt;MinimalRepository&gt;</returns>
        public List<MinimalRepository> ReposListPublic (int? since)
        {
            

            var path = "/repositories";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListPublic: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListPublic: " + response.ErrorMessage, response.ErrorMessage);

            return (List<MinimalRepository>) ApiClient.Deserialize(response.Content, typeof(List<MinimalRepository>), response.Headers);
        }

        /// <summary>
        /// List pull requests associated with a commit Lists the merged pull request that introduced the commit to the repository. If the commit is not present in the default branch, additionally returns open pull requests associated with the commit. The results may include open and closed pull requests.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commitSha">The SHA of the commit.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;PullRequestSimple&gt;</returns>
        public List<PullRequestSimple> ReposListPullRequestsAssociatedWithCommit (string owner, string repo, string commitSha, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListPullRequestsAssociatedWithCommit");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListPullRequestsAssociatedWithCommit");
            
            // verify the required parameter 'commitSha' is set
            if (commitSha == null) throw new ApiException(400, "Missing required parameter 'commitSha' when calling ReposListPullRequestsAssociatedWithCommit");
            

            var path = "/repos/{owner}/{repo}/commits/{commit_sha}/pulls";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "commit_sha" + "}", ApiClient.ParameterToString(commitSha));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListPullRequestsAssociatedWithCommit: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListPullRequestsAssociatedWithCommit: " + response.ErrorMessage, response.ErrorMessage);

            return (List<PullRequestSimple>) ApiClient.Deserialize(response.Content, typeof(List<PullRequestSimple>), response.Headers);
        }

        /// <summary>
        /// List release assets 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="releaseId">The unique identifier of the release.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;ReleaseAsset&gt;</returns>
        public List<ReleaseAsset> ReposListReleaseAssets (string owner, string repo, int? releaseId, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListReleaseAssets");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListReleaseAssets");
            
            // verify the required parameter 'releaseId' is set
            if (releaseId == null) throw new ApiException(400, "Missing required parameter 'releaseId' when calling ReposListReleaseAssets");
            

            var path = "/repos/{owner}/{repo}/releases/{release_id}/assets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "release_id" + "}", ApiClient.ParameterToString(releaseId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListReleaseAssets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListReleaseAssets: " + response.ErrorMessage, response.ErrorMessage);

            return (List<ReleaseAsset>) ApiClient.Deserialize(response.Content, typeof(List<ReleaseAsset>), response.Headers);
        }

        /// <summary>
        /// List releases This returns a list of releases, which does not include regular Git tags that have not been associated with a release. To get a list of Git tags, use the [Repository Tags API](https://docs.github.com/rest/reference/repos#list-repository-tags).  Information about published releases are available to everyone. Only users with push access will receive listings for draft releases.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Release&gt;</returns>
        public List<Release> ReposListReleases (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListReleases");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListReleases");
            

            var path = "/repos/{owner}/{repo}/releases";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListReleases: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListReleases: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Release>) ApiClient.Deserialize(response.Content, typeof(List<Release>), response.Headers);
        }

        /// <summary>
        /// List tag protection states for a repository This returns the tag protection states of a repository.  This information is only available to repository administrators.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>List&lt;TagProtection&gt;</returns>
        public List<TagProtection> ReposListTagProtection (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListTagProtection");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListTagProtection");
            

            var path = "/repos/{owner}/{repo}/tags/protection";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListTagProtection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListTagProtection: " + response.ErrorMessage, response.ErrorMessage);

            return (List<TagProtection>) ApiClient.Deserialize(response.Content, typeof(List<TagProtection>), response.Headers);
        }

        /// <summary>
        /// List repository tags 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Tag&gt;</returns>
        public List<Tag> ReposListTags (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListTags");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListTags");
            

            var path = "/repos/{owner}/{repo}/tags";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListTags: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListTags: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Tag>) ApiClient.Deserialize(response.Content, typeof(List<Tag>), response.Headers);
        }

        /// <summary>
        /// List repository teams 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Team&gt;</returns>
        public List<Team> ReposListTeams (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListTeams");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListTeams");
            

            var path = "/repos/{owner}/{repo}/teams";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListTeams: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListTeams: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Team>) ApiClient.Deserialize(response.Content, typeof(List<Team>), response.Headers);
        }

        /// <summary>
        /// List deliveries for a repository webhook Returns a list of webhook deliveries for a webhook configured in a repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="cursor">Used for pagination: the starting delivery from which the page of deliveries is fetched. Refer to the &#x60;link&#x60; header for the next and previous page cursors.</param>
        /// <returns>List&lt;SimpleWebhookDelivery&gt;</returns>
        public List<SimpleWebhookDelivery> ReposListWebhookDeliveries (string owner, string repo, int? hookId, int? perPage, string cursor)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListWebhookDeliveries");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListWebhookDeliveries");
            
            // verify the required parameter 'hookId' is set
            if (hookId == null) throw new ApiException(400, "Missing required parameter 'hookId' when calling ReposListWebhookDeliveries");
            

            var path = "/repos/{owner}/{repo}/hooks/{hook_id}/deliveries";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListWebhookDeliveries: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListWebhookDeliveries: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SimpleWebhookDelivery>) ApiClient.Deserialize(response.Content, typeof(List<SimpleWebhookDelivery>), response.Headers);
        }

        /// <summary>
        /// List repository webhooks 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Webhook&gt;</returns>
        public List<Webhook> ReposListWebhooks (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposListWebhooks");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposListWebhooks");
            

            var path = "/repos/{owner}/{repo}/hooks";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListWebhooks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposListWebhooks: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Webhook>) ApiClient.Deserialize(response.Content, typeof(List<Webhook>), response.Headers);
        }

        /// <summary>
        /// Merge a branch 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposMergeRequest"></param>
        /// <returns>Commit</returns>
        public Commit ReposMerge (string owner, string repo, ReposMergeRequest reposMergeRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposMerge");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposMerge");
            
            // verify the required parameter 'reposMergeRequest' is set
            if (reposMergeRequest == null) throw new ApiException(400, "Missing required parameter 'reposMergeRequest' when calling ReposMerge");
            

            var path = "/repos/{owner}/{repo}/merges";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposMergeRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposMerge: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposMerge: " + response.ErrorMessage, response.ErrorMessage);

            return (Commit) ApiClient.Deserialize(response.Content, typeof(Commit), response.Headers);
        }

        /// <summary>
        /// Sync a fork branch with the upstream repository Sync a branch of a forked repository to keep it up-to-date with the upstream repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposMergeUpstreamRequest"></param>
        /// <returns>MergedUpstream</returns>
        public MergedUpstream ReposMergeUpstream (string owner, string repo, ReposMergeUpstreamRequest reposMergeUpstreamRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposMergeUpstream");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposMergeUpstream");
            
            // verify the required parameter 'reposMergeUpstreamRequest' is set
            if (reposMergeUpstreamRequest == null) throw new ApiException(400, "Missing required parameter 'reposMergeUpstreamRequest' when calling ReposMergeUpstream");
            

            var path = "/repos/{owner}/{repo}/merge-upstream";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposMergeUpstreamRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposMergeUpstream: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposMergeUpstream: " + response.ErrorMessage, response.ErrorMessage);

            return (MergedUpstream) ApiClient.Deserialize(response.Content, typeof(MergedUpstream), response.Headers);
        }

        /// <summary>
        /// Ping a repository webhook This will trigger a [ping event](https://docs.github.com/webhooks/#ping-event) to be sent to the hook.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <returns></returns>
        public void ReposPingWebhook (string owner, string repo, int? hookId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposPingWebhook");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposPingWebhook");
            
            // verify the required parameter 'hookId' is set
            if (hookId == null) throw new ApiException(400, "Missing required parameter 'hookId' when calling ReposPingWebhook");
            

            var path = "/repos/{owner}/{repo}/hooks/{hook_id}/pings";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposPingWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposPingWebhook: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Redeliver a delivery for a repository webhook Redeliver a webhook delivery for a webhook configured in a repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <param name="deliveryId"></param>
        /// <returns>Object</returns>
        public Object ReposRedeliverWebhookDelivery (string owner, string repo, int? hookId, int? deliveryId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposRedeliverWebhookDelivery");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposRedeliverWebhookDelivery");
            
            // verify the required parameter 'hookId' is set
            if (hookId == null) throw new ApiException(400, "Missing required parameter 'hookId' when calling ReposRedeliverWebhookDelivery");
            
            // verify the required parameter 'deliveryId' is set
            if (deliveryId == null) throw new ApiException(400, "Missing required parameter 'deliveryId' when calling ReposRedeliverWebhookDelivery");
            

            var path = "/repos/{owner}/{repo}/hooks/{hook_id}/deliveries/{delivery_id}/attempts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposRedeliverWebhookDelivery: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposRedeliverWebhookDelivery: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Remove app access restrictions Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Removes the ability of an app to push to this branch. Only installed GitHub Apps with &#x60;write&#x60; access to the &#x60;contents&#x60; permission can be added as authorized actors on a protected branch.  | Type    | Description                                                                                                                                                | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | &#x60;array&#x60; | The GitHub Apps that have push access to this branch. Use the app&#39;s &#x60;slug&#x60;. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetAppAccessRestrictionsRequest"></param>
        /// <returns>List&lt;GitHubApp&gt;</returns>
        public List<GitHubApp> ReposRemoveAppAccessRestrictions (string owner, string repo, string branch, ReposSetAppAccessRestrictionsRequest reposSetAppAccessRestrictionsRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposRemoveAppAccessRestrictions");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposRemoveAppAccessRestrictions");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposRemoveAppAccessRestrictions");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/restrictions/apps";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposSetAppAccessRestrictionsRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposRemoveAppAccessRestrictions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposRemoveAppAccessRestrictions: " + response.ErrorMessage, response.ErrorMessage);

            return (List<GitHubApp>) ApiClient.Deserialize(response.Content, typeof(List<GitHubApp>), response.Headers);
        }

        /// <summary>
        /// Remove a repository collaborator 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        public void ReposRemoveCollaborator (string owner, string repo, string username)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposRemoveCollaborator");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposRemoveCollaborator");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling ReposRemoveCollaborator");
            

            var path = "/repos/{owner}/{repo}/collaborators/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposRemoveCollaborator: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposRemoveCollaborator: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Remove status check contexts Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetStatusCheckContextsRequest"></param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> ReposRemoveStatusCheckContexts (string owner, string repo, string branch, ReposSetStatusCheckContextsRequest reposSetStatusCheckContextsRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposRemoveStatusCheckContexts");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposRemoveStatusCheckContexts");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposRemoveStatusCheckContexts");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/required_status_checks/contexts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposSetStatusCheckContextsRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposRemoveStatusCheckContexts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposRemoveStatusCheckContexts: " + response.ErrorMessage, response.ErrorMessage);

            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }

        /// <summary>
        /// Remove status check protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns></returns>
        public void ReposRemoveStatusCheckProtection (string owner, string repo, string branch)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposRemoveStatusCheckProtection");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposRemoveStatusCheckProtection");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposRemoveStatusCheckProtection");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/required_status_checks";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposRemoveStatusCheckProtection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposRemoveStatusCheckProtection: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Remove team access restrictions Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Removes the ability of a team to push to this branch. You can also remove push access for child teams.  | Type    | Description                                                                                                                                         | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | &#x60;array&#x60; | Teams that should no longer have push access. Use the team&#39;s &#x60;slug&#x60;. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetTeamAccessRestrictionsRequest"></param>
        /// <returns>List&lt;Team&gt;</returns>
        public List<Team> ReposRemoveTeamAccessRestrictions (string owner, string repo, string branch, ReposSetTeamAccessRestrictionsRequest reposSetTeamAccessRestrictionsRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposRemoveTeamAccessRestrictions");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposRemoveTeamAccessRestrictions");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposRemoveTeamAccessRestrictions");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/restrictions/teams";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposSetTeamAccessRestrictionsRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposRemoveTeamAccessRestrictions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposRemoveTeamAccessRestrictions: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Team>) ApiClient.Deserialize(response.Content, typeof(List<Team>), response.Headers);
        }

        /// <summary>
        /// Remove user access restrictions Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Removes the ability of a user to push to this branch.  | Type    | Description                                                                                                                                   | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | &#x60;array&#x60; | Usernames of the people who should no longer have push access. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetUserAccessRestrictionsRequest"></param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        public List<SimpleUser1> ReposRemoveUserAccessRestrictions (string owner, string repo, string branch, ReposSetUserAccessRestrictionsRequest reposSetUserAccessRestrictionsRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposRemoveUserAccessRestrictions");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposRemoveUserAccessRestrictions");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposRemoveUserAccessRestrictions");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/restrictions/users";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposSetUserAccessRestrictionsRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposRemoveUserAccessRestrictions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposRemoveUserAccessRestrictions: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SimpleUser1>) ApiClient.Deserialize(response.Content, typeof(List<SimpleUser1>), response.Headers);
        }

        /// <summary>
        /// Rename a branch Renames a branch in a repository.  **Note:** Although the API responds immediately, the branch rename process might take some extra time to complete in the background. You won&#39;t be able to push to the old branch name while the rename process is in progress. For more information, see \&quot;[Renaming a branch](https://docs.github.com/github/administering-a-repository/renaming-a-branch)\&quot;.  The permissions required to use this endpoint depends on whether you are renaming the default branch.  To rename a non-default branch:  * Users must have push access. * GitHub Apps must have the &#x60;contents:write&#x60; repository permission.  To rename the default branch:  * Users must have admin or owner permissions. * GitHub Apps must have the &#x60;administration:write&#x60; repository permission.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposRenameBranchRequest"></param>
        /// <returns>BranchWithProtection</returns>
        public BranchWithProtection ReposRenameBranch (string owner, string repo, string branch, ReposRenameBranchRequest reposRenameBranchRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposRenameBranch");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposRenameBranch");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposRenameBranch");
            
            // verify the required parameter 'reposRenameBranchRequest' is set
            if (reposRenameBranchRequest == null) throw new ApiException(400, "Missing required parameter 'reposRenameBranchRequest' when calling ReposRenameBranch");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/rename";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposRenameBranchRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposRenameBranch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposRenameBranch: " + response.ErrorMessage, response.ErrorMessage);

            return (BranchWithProtection) ApiClient.Deserialize(response.Content, typeof(BranchWithProtection), response.Headers);
        }

        /// <summary>
        /// Replace all repository topics 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposReplaceAllTopicsRequest"></param>
        /// <returns>Topic</returns>
        public Topic ReposReplaceAllTopics (string owner, string repo, ReposReplaceAllTopicsRequest reposReplaceAllTopicsRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposReplaceAllTopics");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposReplaceAllTopics");
            
            // verify the required parameter 'reposReplaceAllTopicsRequest' is set
            if (reposReplaceAllTopicsRequest == null) throw new ApiException(400, "Missing required parameter 'reposReplaceAllTopicsRequest' when calling ReposReplaceAllTopics");
            

            var path = "/repos/{owner}/{repo}/topics";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposReplaceAllTopicsRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposReplaceAllTopics: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposReplaceAllTopics: " + response.ErrorMessage, response.ErrorMessage);

            return (Topic) ApiClient.Deserialize(response.Content, typeof(Topic), response.Headers);
        }

        /// <summary>
        /// Request a GitHub Pages build You can request that your site be built from the latest revision on the default branch. This has the same effect as pushing a commit to your default branch, but does not require an additional commit. Manually triggering page builds can be helpful when diagnosing build warnings and failures.  Build requests are limited to one concurrent build per repository and one concurrent build per requester. If you request a build while another is still in progress, the second request will be queued until the first completes.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>PageBuildStatus</returns>
        public PageBuildStatus ReposRequestPagesBuild (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposRequestPagesBuild");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposRequestPagesBuild");
            

            var path = "/repos/{owner}/{repo}/pages/builds";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposRequestPagesBuild: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposRequestPagesBuild: " + response.ErrorMessage, response.ErrorMessage);

            return (PageBuildStatus) ApiClient.Deserialize(response.Content, typeof(PageBuildStatus), response.Headers);
        }

        /// <summary>
        /// Set admin branch protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Adding admin enforcement requires admin or owner permissions to the repository and branch protection to be enabled.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <returns>ProtectedBranchAdminEnforced</returns>
        public ProtectedBranchAdminEnforced ReposSetAdminBranchProtection (string owner, string repo, string branch)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposSetAdminBranchProtection");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposSetAdminBranchProtection");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposSetAdminBranchProtection");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/enforce_admins";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposSetAdminBranchProtection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposSetAdminBranchProtection: " + response.ErrorMessage, response.ErrorMessage);

            return (ProtectedBranchAdminEnforced) ApiClient.Deserialize(response.Content, typeof(ProtectedBranchAdminEnforced), response.Headers);
        }

        /// <summary>
        /// Set app access restrictions Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Replaces the list of apps that have push access to this branch. This removes all apps that previously had push access and grants push access to the new list of apps. Only installed GitHub Apps with &#x60;write&#x60; access to the &#x60;contents&#x60; permission can be added as authorized actors on a protected branch.  | Type    | Description                                                                                                                                                | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | &#x60;array&#x60; | The GitHub Apps that have push access to this branch. Use the app&#39;s &#x60;slug&#x60;. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetAppAccessRestrictionsRequest"></param>
        /// <returns>List&lt;GitHubApp&gt;</returns>
        public List<GitHubApp> ReposSetAppAccessRestrictions (string owner, string repo, string branch, ReposSetAppAccessRestrictionsRequest reposSetAppAccessRestrictionsRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposSetAppAccessRestrictions");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposSetAppAccessRestrictions");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposSetAppAccessRestrictions");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/restrictions/apps";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposSetAppAccessRestrictionsRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposSetAppAccessRestrictions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposSetAppAccessRestrictions: " + response.ErrorMessage, response.ErrorMessage);

            return (List<GitHubApp>) ApiClient.Deserialize(response.Content, typeof(List<GitHubApp>), response.Headers);
        }

        /// <summary>
        /// Set status check contexts Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetStatusCheckContextsRequest"></param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> ReposSetStatusCheckContexts (string owner, string repo, string branch, ReposSetStatusCheckContextsRequest reposSetStatusCheckContextsRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposSetStatusCheckContexts");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposSetStatusCheckContexts");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposSetStatusCheckContexts");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/required_status_checks/contexts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposSetStatusCheckContextsRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposSetStatusCheckContexts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposSetStatusCheckContexts: " + response.ErrorMessage, response.ErrorMessage);

            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }

        /// <summary>
        /// Set team access restrictions Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Replaces the list of teams that have push access to this branch. This removes all teams that previously had push access and grants push access to the new list of teams. Team restrictions include child teams.  | Type    | Description                                                                                                                                | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | &#x60;array&#x60; | The teams that can have push access. Use the team&#39;s &#x60;slug&#x60;. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetTeamAccessRestrictionsRequest"></param>
        /// <returns>List&lt;Team&gt;</returns>
        public List<Team> ReposSetTeamAccessRestrictions (string owner, string repo, string branch, ReposSetTeamAccessRestrictionsRequest reposSetTeamAccessRestrictionsRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposSetTeamAccessRestrictions");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposSetTeamAccessRestrictions");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposSetTeamAccessRestrictions");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/restrictions/teams";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposSetTeamAccessRestrictionsRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposSetTeamAccessRestrictions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposSetTeamAccessRestrictions: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Team>) ApiClient.Deserialize(response.Content, typeof(List<Team>), response.Headers);
        }

        /// <summary>
        /// Set user access restrictions Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Replaces the list of people that have push access to this branch. This removes all people that previously had push access and grants push access to the new list of people.  | Type    | Description                                                                                                                   | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | &#x60;array&#x60; | Usernames for people who can have push access. **Note**: The list of users, apps, and teams in total is limited to 100 items. |
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposSetUserAccessRestrictionsRequest"></param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        public List<SimpleUser1> ReposSetUserAccessRestrictions (string owner, string repo, string branch, ReposSetUserAccessRestrictionsRequest reposSetUserAccessRestrictionsRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposSetUserAccessRestrictions");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposSetUserAccessRestrictions");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposSetUserAccessRestrictions");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/restrictions/users";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposSetUserAccessRestrictionsRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposSetUserAccessRestrictions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposSetUserAccessRestrictions: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SimpleUser1>) ApiClient.Deserialize(response.Content, typeof(List<SimpleUser1>), response.Headers);
        }

        /// <summary>
        /// Test the push repository webhook This will trigger the hook with the latest push to the current repository if the hook is subscribed to &#x60;push&#x60; events. If the hook is not subscribed to &#x60;push&#x60; events, the server will respond with 204 but no test POST will be generated.  **Note**: Previously &#x60;/repos/:owner/:repo/hooks/:hook_id/test&#x60;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <returns></returns>
        public void ReposTestPushWebhook (string owner, string repo, int? hookId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposTestPushWebhook");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposTestPushWebhook");
            
            // verify the required parameter 'hookId' is set
            if (hookId == null) throw new ApiException(400, "Missing required parameter 'hookId' when calling ReposTestPushWebhook");
            

            var path = "/repos/{owner}/{repo}/hooks/{hook_id}/tests";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReposTestPushWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposTestPushWebhook: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Transfer a repository A transfer request will need to be accepted by the new owner when transferring a personal repository to another user. The response will contain the original &#x60;owner&#x60;, and the transfer will continue asynchronously. For more details on the requirements to transfer personal and organization-owned repositories, see [about repository transfers](https://docs.github.com/articles/about-repository-transfers/).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposTransferRequest"></param>
        /// <returns>MinimalRepository</returns>
        public MinimalRepository ReposTransfer (string owner, string repo, ReposTransferRequest reposTransferRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposTransfer");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposTransfer");
            
            // verify the required parameter 'reposTransferRequest' is set
            if (reposTransferRequest == null) throw new ApiException(400, "Missing required parameter 'reposTransferRequest' when calling ReposTransfer");
            

            var path = "/repos/{owner}/{repo}/transfer";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposTransferRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposTransfer: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposTransfer: " + response.ErrorMessage, response.ErrorMessage);

            return (MinimalRepository) ApiClient.Deserialize(response.Content, typeof(MinimalRepository), response.Headers);
        }

        /// <summary>
        /// Update a repository **Note**: To edit a repository&#39;s topics, use the [Replace all repository topics](https://docs.github.com/rest/reference/repos#replace-all-repository-topics) endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposUpdateRequest"></param>
        /// <returns>FullRepository</returns>
        public FullRepository ReposUpdate (string owner, string repo, ReposUpdateRequest reposUpdateRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposUpdate");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposUpdate");
            

            var path = "/repos/{owner}/{repo}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposUpdateRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUpdate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUpdate: " + response.ErrorMessage, response.ErrorMessage);

            return (FullRepository) ApiClient.Deserialize(response.Content, typeof(FullRepository), response.Headers);
        }

        /// <summary>
        /// Update branch protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Protecting a branch requires admin or owner permissions to the repository.  **Note**: Passing new arrays of &#x60;users&#x60; and &#x60;teams&#x60; replaces their previous values.  **Note**: The list of users, apps, and teams in total is limited to 100 items.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposUpdateBranchProtectionRequest"></param>
        /// <returns>ProtectedBranch</returns>
        public ProtectedBranch ReposUpdateBranchProtection (string owner, string repo, string branch, ReposUpdateBranchProtectionRequest reposUpdateBranchProtectionRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposUpdateBranchProtection");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposUpdateBranchProtection");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposUpdateBranchProtection");
            
            // verify the required parameter 'reposUpdateBranchProtectionRequest' is set
            if (reposUpdateBranchProtectionRequest == null) throw new ApiException(400, "Missing required parameter 'reposUpdateBranchProtectionRequest' when calling ReposUpdateBranchProtection");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposUpdateBranchProtectionRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUpdateBranchProtection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUpdateBranchProtection: " + response.ErrorMessage, response.ErrorMessage);

            return (ProtectedBranch) ApiClient.Deserialize(response.Content, typeof(ProtectedBranch), response.Headers);
        }

        /// <summary>
        /// Update a commit comment 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="reposUpdateCommitCommentRequest"></param>
        /// <returns>CommitComment</returns>
        public CommitComment ReposUpdateCommitComment (string owner, string repo, int? commentId, ReposUpdateCommitCommentRequest reposUpdateCommitCommentRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposUpdateCommitComment");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposUpdateCommitComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling ReposUpdateCommitComment");
            
            // verify the required parameter 'reposUpdateCommitCommentRequest' is set
            if (reposUpdateCommitCommentRequest == null) throw new ApiException(400, "Missing required parameter 'reposUpdateCommitCommentRequest' when calling ReposUpdateCommitComment");
            

            var path = "/repos/{owner}/{repo}/comments/{comment_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "comment_id" + "}", ApiClient.ParameterToString(commentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposUpdateCommitCommentRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUpdateCommitComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUpdateCommitComment: " + response.ErrorMessage, response.ErrorMessage);

            return (CommitComment) ApiClient.Deserialize(response.Content, typeof(CommitComment), response.Headers);
        }

        /// <summary>
        /// Update information about a GitHub Pages site Updates information for a GitHub Pages site. For more information, see \&quot;[About GitHub Pages](/github/working-with-github-pages/about-github-pages).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="reposUpdateInformationAboutPagesSiteRequest"></param>
        /// <returns></returns>
        public void ReposUpdateInformationAboutPagesSite (string owner, string repo, ReposUpdateInformationAboutPagesSiteRequest reposUpdateInformationAboutPagesSiteRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposUpdateInformationAboutPagesSite");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposUpdateInformationAboutPagesSite");
            
            // verify the required parameter 'reposUpdateInformationAboutPagesSiteRequest' is set
            if (reposUpdateInformationAboutPagesSiteRequest == null) throw new ApiException(400, "Missing required parameter 'reposUpdateInformationAboutPagesSiteRequest' when calling ReposUpdateInformationAboutPagesSite");
            

            var path = "/repos/{owner}/{repo}/pages";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposUpdateInformationAboutPagesSiteRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUpdateInformationAboutPagesSite: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUpdateInformationAboutPagesSite: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Update a repository invitation 
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="invitationId">The unique identifier of the invitation.</param>
        /// <param name="reposUpdateInvitationRequest"></param>
        /// <returns>RepositoryInvitation</returns>
        public RepositoryInvitation ReposUpdateInvitation (string owner, string repo, int? invitationId, ReposUpdateInvitationRequest reposUpdateInvitationRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposUpdateInvitation");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposUpdateInvitation");
            
            // verify the required parameter 'invitationId' is set
            if (invitationId == null) throw new ApiException(400, "Missing required parameter 'invitationId' when calling ReposUpdateInvitation");
            

            var path = "/repos/{owner}/{repo}/invitations/{invitation_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "invitation_id" + "}", ApiClient.ParameterToString(invitationId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposUpdateInvitationRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUpdateInvitation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUpdateInvitation: " + response.ErrorMessage, response.ErrorMessage);

            return (RepositoryInvitation) ApiClient.Deserialize(response.Content, typeof(RepositoryInvitation), response.Headers);
        }

        /// <summary>
        /// Update pull request review protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Updating pull request review enforcement requires admin or owner permissions to the repository and branch protection to be enabled.  **Note**: Passing new arrays of &#x60;users&#x60; and &#x60;teams&#x60; replaces their previous values.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposUpdatePullRequestReviewProtectionRequest"></param>
        /// <returns>ProtectedBranchPullRequestReview</returns>
        public ProtectedBranchPullRequestReview ReposUpdatePullRequestReviewProtection (string owner, string repo, string branch, ReposUpdatePullRequestReviewProtectionRequest reposUpdatePullRequestReviewProtectionRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposUpdatePullRequestReviewProtection");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposUpdatePullRequestReviewProtection");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposUpdatePullRequestReviewProtection");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/required_pull_request_reviews";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposUpdatePullRequestReviewProtectionRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUpdatePullRequestReviewProtection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUpdatePullRequestReviewProtection: " + response.ErrorMessage, response.ErrorMessage);

            return (ProtectedBranchPullRequestReview) ApiClient.Deserialize(response.Content, typeof(ProtectedBranchPullRequestReview), response.Headers);
        }

        /// <summary>
        /// Update a release Users with push access to the repository can edit a release.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="releaseId">The unique identifier of the release.</param>
        /// <param name="reposUpdateReleaseRequest"></param>
        /// <returns>Release</returns>
        public Release ReposUpdateRelease (string owner, string repo, int? releaseId, ReposUpdateReleaseRequest reposUpdateReleaseRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposUpdateRelease");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposUpdateRelease");
            
            // verify the required parameter 'releaseId' is set
            if (releaseId == null) throw new ApiException(400, "Missing required parameter 'releaseId' when calling ReposUpdateRelease");
            

            var path = "/repos/{owner}/{repo}/releases/{release_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "release_id" + "}", ApiClient.ParameterToString(releaseId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposUpdateReleaseRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUpdateRelease: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUpdateRelease: " + response.ErrorMessage, response.ErrorMessage);

            return (Release) ApiClient.Deserialize(response.Content, typeof(Release), response.Headers);
        }

        /// <summary>
        /// Update a release asset Users with push access to the repository can edit a release asset.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="assetId">The unique identifier of the asset.</param>
        /// <param name="reposUpdateReleaseAssetRequest"></param>
        /// <returns>ReleaseAsset</returns>
        public ReleaseAsset ReposUpdateReleaseAsset (string owner, string repo, int? assetId, ReposUpdateReleaseAssetRequest reposUpdateReleaseAssetRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposUpdateReleaseAsset");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposUpdateReleaseAsset");
            
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling ReposUpdateReleaseAsset");
            

            var path = "/repos/{owner}/{repo}/releases/assets/{asset_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "asset_id" + "}", ApiClient.ParameterToString(assetId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposUpdateReleaseAssetRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUpdateReleaseAsset: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUpdateReleaseAsset: " + response.ErrorMessage, response.ErrorMessage);

            return (ReleaseAsset) ApiClient.Deserialize(response.Content, typeof(ReleaseAsset), response.Headers);
        }

        /// <summary>
        /// Update status check protection Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Updating required status checks requires admin or owner permissions to the repository and branch protection to be enabled.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="branch">The name of the branch.</param>
        /// <param name="reposUpdateStatusCheckProtectionRequest"></param>
        /// <returns>StatusCheckPolicy</returns>
        public StatusCheckPolicy ReposUpdateStatusCheckProtection (string owner, string repo, string branch, ReposUpdateStatusCheckProtectionRequest reposUpdateStatusCheckProtectionRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposUpdateStatusCheckProtection");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposUpdateStatusCheckProtection");
            
            // verify the required parameter 'branch' is set
            if (branch == null) throw new ApiException(400, "Missing required parameter 'branch' when calling ReposUpdateStatusCheckProtection");
            

            var path = "/repos/{owner}/{repo}/branches/{branch}/protection/required_status_checks";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "branch" + "}", ApiClient.ParameterToString(branch));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposUpdateStatusCheckProtectionRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUpdateStatusCheckProtection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUpdateStatusCheckProtection: " + response.ErrorMessage, response.ErrorMessage);

            return (StatusCheckPolicy) ApiClient.Deserialize(response.Content, typeof(StatusCheckPolicy), response.Headers);
        }

        /// <summary>
        /// Update a repository webhook Updates a webhook configured in a repository. If you previously had a &#x60;secret&#x60; set, you must provide the same &#x60;secret&#x60; or set a new &#x60;secret&#x60; or the secret will be removed. If you are only updating individual webhook &#x60;config&#x60; properties, use \&quot;[Update a webhook configuration for a repository](/rest/reference/repos#update-a-webhook-configuration-for-a-repository).\&quot;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <param name="reposUpdateWebhookRequest"></param>
        /// <returns>Webhook</returns>
        public Webhook ReposUpdateWebhook (string owner, string repo, int? hookId, ReposUpdateWebhookRequest reposUpdateWebhookRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposUpdateWebhook");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposUpdateWebhook");
            
            // verify the required parameter 'hookId' is set
            if (hookId == null) throw new ApiException(400, "Missing required parameter 'hookId' when calling ReposUpdateWebhook");
            
            // verify the required parameter 'reposUpdateWebhookRequest' is set
            if (reposUpdateWebhookRequest == null) throw new ApiException(400, "Missing required parameter 'reposUpdateWebhookRequest' when calling ReposUpdateWebhook");
            

            var path = "/repos/{owner}/{repo}/hooks/{hook_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "hook_id" + "}", ApiClient.ParameterToString(hookId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposUpdateWebhookRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUpdateWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUpdateWebhook: " + response.ErrorMessage, response.ErrorMessage);

            return (Webhook) ApiClient.Deserialize(response.Content, typeof(Webhook), response.Headers);
        }

        /// <summary>
        /// Update a webhook configuration for a repository Updates the webhook configuration for a repository. To update more information about the webhook, including the &#x60;active&#x60; state and &#x60;events&#x60;, use \&quot;[Update a repository webhook](/rest/reference/orgs#update-a-repository-webhook).\&quot;  Access tokens must have the &#x60;write:repo_hook&#x60; or &#x60;repo&#x60; scope, and GitHub Apps must have the &#x60;repository_hooks:write&#x60; permission.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="hookId">The unique identifier of the hook.</param>
        /// <param name="reposUpdateWebhookConfigForRepoRequest"></param>
        /// <returns>WebhookConfiguration</returns>
        public WebhookConfiguration ReposUpdateWebhookConfigForRepo (string owner, string repo, int? hookId, ReposUpdateWebhookConfigForRepoRequest reposUpdateWebhookConfigForRepoRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposUpdateWebhookConfigForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposUpdateWebhookConfigForRepo");
            
            // verify the required parameter 'hookId' is set
            if (hookId == null) throw new ApiException(400, "Missing required parameter 'hookId' when calling ReposUpdateWebhookConfigForRepo");
            

            var path = "/repos/{owner}/{repo}/hooks/{hook_id}/config";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "hook_id" + "}", ApiClient.ParameterToString(hookId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(reposUpdateWebhookConfigForRepoRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUpdateWebhookConfigForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUpdateWebhookConfigForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (WebhookConfiguration) ApiClient.Deserialize(response.Content, typeof(WebhookConfiguration), response.Headers);
        }

        /// <summary>
        /// Upload a release asset This endpoint makes use of [a Hypermedia relation](https://docs.github.com/rest/overview/resources-in-the-rest-api#hypermedia) to determine which URL to access. The endpoint you call to upload release assets is specific to your release. Use the &#x60;upload_url&#x60; returned in the response of the [Create a release endpoint](https://docs.github.com/rest/reference/repos#create-a-release) to upload a release asset.  You need to use an HTTP client which supports [SNI](http://en.wikipedia.org/wiki/Server_Name_Indication) to make calls to this endpoint.  Most libraries will set the required &#x60;Content-Length&#x60; header automatically. Use the required &#x60;Content-Type&#x60; header to provide the media type of the asset. For a list of media types, see [Media Types](https://www.iana.org/assignments/media-types/media-types.xhtml). For example:   &#x60;application/zip&#x60;  GitHub expects the asset data in its raw binary form, rather than JSON. You will send the raw binary content of the asset as the request body. Everything else about the endpoint is the same as the rest of the API. For example, you&#39;ll still need to pass your authentication to be able to upload an asset.  When an upstream failure occurs, you will receive a &#x60;502 Bad Gateway&#x60; status. This may leave an empty asset with a state of &#x60;starter&#x60;. It can be safely deleted.  **Notes:** *   GitHub renames asset filenames that have special characters, non-alphanumeric characters, and leading or trailing periods. The \&quot;[List assets for a release](https://docs.github.com/rest/reference/repos#list-assets-for-a-release)\&quot; endpoint lists the renamed filenames. For more information and help, contact [GitHub Support](https://support.github.com/contact?tags&#x3D;dotcom-rest-api). *   If you upload an asset with the same filename as another uploaded asset, you&#39;ll receive an error and must delete the old file before you can re-upload the new asset.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="releaseId">The unique identifier of the release.</param>
        /// <param name="name"></param>
        /// <param name="label"></param>
        /// <param name="body"></param>
        /// <returns>ReleaseAsset</returns>
        public ReleaseAsset ReposUploadReleaseAsset (string owner, string repo, int? releaseId, string name, string label, string body)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ReposUploadReleaseAsset");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ReposUploadReleaseAsset");
            
            // verify the required parameter 'releaseId' is set
            if (releaseId == null) throw new ApiException(400, "Missing required parameter 'releaseId' when calling ReposUploadReleaseAsset");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ReposUploadReleaseAsset");
            

            var path = "/repos/{owner}/{repo}/releases/{release_id}/assets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "release_id" + "}", ApiClient.ParameterToString(releaseId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUploadReleaseAsset: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReposUploadReleaseAsset: " + response.ErrorMessage, response.ErrorMessage);

            return (ReleaseAsset) ApiClient.Deserialize(response.Content, typeof(ReleaseAsset), response.Headers);
        }

    }
}
