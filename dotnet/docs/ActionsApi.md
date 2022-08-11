# Org.OpenAPITools.Api.ActionsApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActionsAddCustomLabelsToSelfHostedRunnerForOrg**](ActionsApi.md#actionsaddcustomlabelstoselfhostedrunnerfororg) | **POST** /orgs/{org}/actions/runners/{runner_id}/labels | Add custom labels to a self-hosted runner for an organization
[**ActionsAddCustomLabelsToSelfHostedRunnerForRepo**](ActionsApi.md#actionsaddcustomlabelstoselfhostedrunnerforrepo) | **POST** /repos/{owner}/{repo}/actions/runners/{runner_id}/labels | Add custom labels to a self-hosted runner for a repository
[**ActionsAddRepoAccessToSelfHostedRunnerGroupInOrg**](ActionsApi.md#actionsaddrepoaccesstoselfhostedrunnergroupinorg) | **PUT** /orgs/{org}/actions/runner-groups/{runner_group_id}/repositories/{repository_id} | Add repository access to a self-hosted runner group in an organization
[**ActionsAddSelectedRepoToOrgSecret**](ActionsApi.md#actionsaddselectedrepotoorgsecret) | **PUT** /orgs/{org}/actions/secrets/{secret_name}/repositories/{repository_id} | Add selected repository to an organization secret
[**ActionsAddSelfHostedRunnerToGroupForOrg**](ActionsApi.md#actionsaddselfhostedrunnertogroupfororg) | **PUT** /orgs/{org}/actions/runner-groups/{runner_group_id}/runners/{runner_id} | Add a self-hosted runner to a group for an organization
[**ActionsApproveWorkflowRun**](ActionsApi.md#actionsapproveworkflowrun) | **POST** /repos/{owner}/{repo}/actions/runs/{run_id}/approve | Approve a workflow run for a fork pull request
[**ActionsCancelWorkflowRun**](ActionsApi.md#actionscancelworkflowrun) | **POST** /repos/{owner}/{repo}/actions/runs/{run_id}/cancel | Cancel a workflow run
[**ActionsCreateOrUpdateEnvironmentSecret**](ActionsApi.md#actionscreateorupdateenvironmentsecret) | **PUT** /repositories/{repository_id}/environments/{environment_name}/secrets/{secret_name} | Create or update an environment secret
[**ActionsCreateOrUpdateOrgSecret**](ActionsApi.md#actionscreateorupdateorgsecret) | **PUT** /orgs/{org}/actions/secrets/{secret_name} | Create or update an organization secret
[**ActionsCreateOrUpdateRepoSecret**](ActionsApi.md#actionscreateorupdatereposecret) | **PUT** /repos/{owner}/{repo}/actions/secrets/{secret_name} | Create or update a repository secret
[**ActionsCreateRegistrationTokenForOrg**](ActionsApi.md#actionscreateregistrationtokenfororg) | **POST** /orgs/{org}/actions/runners/registration-token | Create a registration token for an organization
[**ActionsCreateRegistrationTokenForRepo**](ActionsApi.md#actionscreateregistrationtokenforrepo) | **POST** /repos/{owner}/{repo}/actions/runners/registration-token | Create a registration token for a repository
[**ActionsCreateRemoveTokenForOrg**](ActionsApi.md#actionscreateremovetokenfororg) | **POST** /orgs/{org}/actions/runners/remove-token | Create a remove token for an organization
[**ActionsCreateRemoveTokenForRepo**](ActionsApi.md#actionscreateremovetokenforrepo) | **POST** /repos/{owner}/{repo}/actions/runners/remove-token | Create a remove token for a repository
[**ActionsCreateSelfHostedRunnerGroupForOrg**](ActionsApi.md#actionscreateselfhostedrunnergroupfororg) | **POST** /orgs/{org}/actions/runner-groups | Create a self-hosted runner group for an organization
[**ActionsCreateWorkflowDispatch**](ActionsApi.md#actionscreateworkflowdispatch) | **POST** /repos/{owner}/{repo}/actions/workflows/{workflow_id}/dispatches | Create a workflow dispatch event
[**ActionsDeleteActionsCacheById**](ActionsApi.md#actionsdeleteactionscachebyid) | **DELETE** /repos/{owner}/{repo}/actions/caches/{cache_id} | Delete a GitHub Actions cache for a repository (using a cache ID)
[**ActionsDeleteActionsCacheByKey**](ActionsApi.md#actionsdeleteactionscachebykey) | **DELETE** /repos/{owner}/{repo}/actions/caches | Delete GitHub Actions caches for a repository (using a cache key)
[**ActionsDeleteArtifact**](ActionsApi.md#actionsdeleteartifact) | **DELETE** /repos/{owner}/{repo}/actions/artifacts/{artifact_id} | Delete an artifact
[**ActionsDeleteEnvironmentSecret**](ActionsApi.md#actionsdeleteenvironmentsecret) | **DELETE** /repositories/{repository_id}/environments/{environment_name}/secrets/{secret_name} | Delete an environment secret
[**ActionsDeleteOrgSecret**](ActionsApi.md#actionsdeleteorgsecret) | **DELETE** /orgs/{org}/actions/secrets/{secret_name} | Delete an organization secret
[**ActionsDeleteRepoSecret**](ActionsApi.md#actionsdeletereposecret) | **DELETE** /repos/{owner}/{repo}/actions/secrets/{secret_name} | Delete a repository secret
[**ActionsDeleteSelfHostedRunnerFromOrg**](ActionsApi.md#actionsdeleteselfhostedrunnerfromorg) | **DELETE** /orgs/{org}/actions/runners/{runner_id} | Delete a self-hosted runner from an organization
[**ActionsDeleteSelfHostedRunnerFromRepo**](ActionsApi.md#actionsdeleteselfhostedrunnerfromrepo) | **DELETE** /repos/{owner}/{repo}/actions/runners/{runner_id} | Delete a self-hosted runner from a repository
[**ActionsDeleteSelfHostedRunnerGroupFromOrg**](ActionsApi.md#actionsdeleteselfhostedrunnergroupfromorg) | **DELETE** /orgs/{org}/actions/runner-groups/{runner_group_id} | Delete a self-hosted runner group from an organization
[**ActionsDeleteWorkflowRun**](ActionsApi.md#actionsdeleteworkflowrun) | **DELETE** /repos/{owner}/{repo}/actions/runs/{run_id} | Delete a workflow run
[**ActionsDeleteWorkflowRunLogs**](ActionsApi.md#actionsdeleteworkflowrunlogs) | **DELETE** /repos/{owner}/{repo}/actions/runs/{run_id}/logs | Delete workflow run logs
[**ActionsDisableSelectedRepositoryGithubActionsOrganization**](ActionsApi.md#actionsdisableselectedrepositorygithubactionsorganization) | **DELETE** /orgs/{org}/actions/permissions/repositories/{repository_id} | Disable a selected repository for GitHub Actions in an organization
[**ActionsDisableWorkflow**](ActionsApi.md#actionsdisableworkflow) | **PUT** /repos/{owner}/{repo}/actions/workflows/{workflow_id}/disable | Disable a workflow
[**ActionsDownloadArtifact**](ActionsApi.md#actionsdownloadartifact) | **GET** /repos/{owner}/{repo}/actions/artifacts/{artifact_id}/{archive_format} | Download an artifact
[**ActionsDownloadJobLogsForWorkflowRun**](ActionsApi.md#actionsdownloadjoblogsforworkflowrun) | **GET** /repos/{owner}/{repo}/actions/jobs/{job_id}/logs | Download job logs for a workflow run
[**ActionsDownloadWorkflowRunAttemptLogs**](ActionsApi.md#actionsdownloadworkflowrunattemptlogs) | **GET** /repos/{owner}/{repo}/actions/runs/{run_id}/attempts/{attempt_number}/logs | Download workflow run attempt logs
[**ActionsDownloadWorkflowRunLogs**](ActionsApi.md#actionsdownloadworkflowrunlogs) | **GET** /repos/{owner}/{repo}/actions/runs/{run_id}/logs | Download workflow run logs
[**ActionsEnableSelectedRepositoryGithubActionsOrganization**](ActionsApi.md#actionsenableselectedrepositorygithubactionsorganization) | **PUT** /orgs/{org}/actions/permissions/repositories/{repository_id} | Enable a selected repository for GitHub Actions in an organization
[**ActionsEnableWorkflow**](ActionsApi.md#actionsenableworkflow) | **PUT** /repos/{owner}/{repo}/actions/workflows/{workflow_id}/enable | Enable a workflow
[**ActionsGetActionsCacheList**](ActionsApi.md#actionsgetactionscachelist) | **GET** /repos/{owner}/{repo}/actions/caches | List GitHub Actions caches for a repository
[**ActionsGetActionsCacheUsage**](ActionsApi.md#actionsgetactionscacheusage) | **GET** /repos/{owner}/{repo}/actions/cache/usage | Get GitHub Actions cache usage for a repository
[**ActionsGetActionsCacheUsageByRepoForOrg**](ActionsApi.md#actionsgetactionscacheusagebyrepofororg) | **GET** /orgs/{org}/actions/cache/usage-by-repository | List repositories with GitHub Actions cache usage for an organization
[**ActionsGetActionsCacheUsageForEnterprise**](ActionsApi.md#actionsgetactionscacheusageforenterprise) | **GET** /enterprises/{enterprise}/actions/cache/usage | Get GitHub Actions cache usage for an enterprise
[**ActionsGetActionsCacheUsageForOrg**](ActionsApi.md#actionsgetactionscacheusagefororg) | **GET** /orgs/{org}/actions/cache/usage | Get GitHub Actions cache usage for an organization
[**ActionsGetAllowedActionsOrganization**](ActionsApi.md#actionsgetallowedactionsorganization) | **GET** /orgs/{org}/actions/permissions/selected-actions | Get allowed actions and reusable workflows for an organization
[**ActionsGetAllowedActionsRepository**](ActionsApi.md#actionsgetallowedactionsrepository) | **GET** /repos/{owner}/{repo}/actions/permissions/selected-actions | Get allowed actions and reusable workflows for a repository
[**ActionsGetArtifact**](ActionsApi.md#actionsgetartifact) | **GET** /repos/{owner}/{repo}/actions/artifacts/{artifact_id} | Get an artifact
[**ActionsGetCustomOidcSubClaimForRepo**](ActionsApi.md#actionsgetcustomoidcsubclaimforrepo) | **GET** /repos/{owner}/{repo}/actions/oidc/customization/sub | Get the opt-out flag of an OIDC subject claim customization for a repository
[**ActionsGetEnvironmentPublicKey**](ActionsApi.md#actionsgetenvironmentpublickey) | **GET** /repositories/{repository_id}/environments/{environment_name}/secrets/public-key | Get an environment public key
[**ActionsGetEnvironmentSecret**](ActionsApi.md#actionsgetenvironmentsecret) | **GET** /repositories/{repository_id}/environments/{environment_name}/secrets/{secret_name} | Get an environment secret
[**ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise**](ActionsApi.md#actionsgetgithubactionsdefaultworkflowpermissionsenterprise) | **GET** /enterprises/{enterprise}/actions/permissions/workflow | Get default workflow permissions for an enterprise
[**ActionsGetGithubActionsDefaultWorkflowPermissionsOrganization**](ActionsApi.md#actionsgetgithubactionsdefaultworkflowpermissionsorganization) | **GET** /orgs/{org}/actions/permissions/workflow | Get default workflow permissions for an organization
[**ActionsGetGithubActionsDefaultWorkflowPermissionsRepository**](ActionsApi.md#actionsgetgithubactionsdefaultworkflowpermissionsrepository) | **GET** /repos/{owner}/{repo}/actions/permissions/workflow | Get default workflow permissions for a repository
[**ActionsGetGithubActionsPermissionsOrganization**](ActionsApi.md#actionsgetgithubactionspermissionsorganization) | **GET** /orgs/{org}/actions/permissions | Get GitHub Actions permissions for an organization
[**ActionsGetGithubActionsPermissionsRepository**](ActionsApi.md#actionsgetgithubactionspermissionsrepository) | **GET** /repos/{owner}/{repo}/actions/permissions | Get GitHub Actions permissions for a repository
[**ActionsGetJobForWorkflowRun**](ActionsApi.md#actionsgetjobforworkflowrun) | **GET** /repos/{owner}/{repo}/actions/jobs/{job_id} | Get a job for a workflow run
[**ActionsGetOrgPublicKey**](ActionsApi.md#actionsgetorgpublickey) | **GET** /orgs/{org}/actions/secrets/public-key | Get an organization public key
[**ActionsGetOrgSecret**](ActionsApi.md#actionsgetorgsecret) | **GET** /orgs/{org}/actions/secrets/{secret_name} | Get an organization secret
[**ActionsGetPendingDeploymentsForRun**](ActionsApi.md#actionsgetpendingdeploymentsforrun) | **GET** /repos/{owner}/{repo}/actions/runs/{run_id}/pending_deployments | Get pending deployments for a workflow run
[**ActionsGetRepoPublicKey**](ActionsApi.md#actionsgetrepopublickey) | **GET** /repos/{owner}/{repo}/actions/secrets/public-key | Get a repository public key
[**ActionsGetRepoSecret**](ActionsApi.md#actionsgetreposecret) | **GET** /repos/{owner}/{repo}/actions/secrets/{secret_name} | Get a repository secret
[**ActionsGetReviewsForRun**](ActionsApi.md#actionsgetreviewsforrun) | **GET** /repos/{owner}/{repo}/actions/runs/{run_id}/approvals | Get the review history for a workflow run
[**ActionsGetSelfHostedRunnerForOrg**](ActionsApi.md#actionsgetselfhostedrunnerfororg) | **GET** /orgs/{org}/actions/runners/{runner_id} | Get a self-hosted runner for an organization
[**ActionsGetSelfHostedRunnerForRepo**](ActionsApi.md#actionsgetselfhostedrunnerforrepo) | **GET** /repos/{owner}/{repo}/actions/runners/{runner_id} | Get a self-hosted runner for a repository
[**ActionsGetSelfHostedRunnerGroupForOrg**](ActionsApi.md#actionsgetselfhostedrunnergroupfororg) | **GET** /orgs/{org}/actions/runner-groups/{runner_group_id} | Get a self-hosted runner group for an organization
[**ActionsGetWorkflow**](ActionsApi.md#actionsgetworkflow) | **GET** /repos/{owner}/{repo}/actions/workflows/{workflow_id} | Get a workflow
[**ActionsGetWorkflowAccessToRepository**](ActionsApi.md#actionsgetworkflowaccesstorepository) | **GET** /repos/{owner}/{repo}/actions/permissions/access | Get the level of access for workflows outside of the repository
[**ActionsGetWorkflowRun**](ActionsApi.md#actionsgetworkflowrun) | **GET** /repos/{owner}/{repo}/actions/runs/{run_id} | Get a workflow run
[**ActionsGetWorkflowRunAttempt**](ActionsApi.md#actionsgetworkflowrunattempt) | **GET** /repos/{owner}/{repo}/actions/runs/{run_id}/attempts/{attempt_number} | Get a workflow run attempt
[**ActionsGetWorkflowRunUsage**](ActionsApi.md#actionsgetworkflowrunusage) | **GET** /repos/{owner}/{repo}/actions/runs/{run_id}/timing | Get workflow run usage
[**ActionsGetWorkflowUsage**](ActionsApi.md#actionsgetworkflowusage) | **GET** /repos/{owner}/{repo}/actions/workflows/{workflow_id}/timing | Get workflow usage
[**ActionsListArtifactsForRepo**](ActionsApi.md#actionslistartifactsforrepo) | **GET** /repos/{owner}/{repo}/actions/artifacts | List artifacts for a repository
[**ActionsListEnvironmentSecrets**](ActionsApi.md#actionslistenvironmentsecrets) | **GET** /repositories/{repository_id}/environments/{environment_name}/secrets | List environment secrets
[**ActionsListJobsForWorkflowRun**](ActionsApi.md#actionslistjobsforworkflowrun) | **GET** /repos/{owner}/{repo}/actions/runs/{run_id}/jobs | List jobs for a workflow run
[**ActionsListJobsForWorkflowRunAttempt**](ActionsApi.md#actionslistjobsforworkflowrunattempt) | **GET** /repos/{owner}/{repo}/actions/runs/{run_id}/attempts/{attempt_number}/jobs | List jobs for a workflow run attempt
[**ActionsListLabelsForSelfHostedRunnerForOrg**](ActionsApi.md#actionslistlabelsforselfhostedrunnerfororg) | **GET** /orgs/{org}/actions/runners/{runner_id}/labels | List labels for a self-hosted runner for an organization
[**ActionsListLabelsForSelfHostedRunnerForRepo**](ActionsApi.md#actionslistlabelsforselfhostedrunnerforrepo) | **GET** /repos/{owner}/{repo}/actions/runners/{runner_id}/labels | List labels for a self-hosted runner for a repository
[**ActionsListOrgSecrets**](ActionsApi.md#actionslistorgsecrets) | **GET** /orgs/{org}/actions/secrets | List organization secrets
[**ActionsListRepoAccessToSelfHostedRunnerGroupInOrg**](ActionsApi.md#actionslistrepoaccesstoselfhostedrunnergroupinorg) | **GET** /orgs/{org}/actions/runner-groups/{runner_group_id}/repositories | List repository access to a self-hosted runner group in an organization
[**ActionsListRepoSecrets**](ActionsApi.md#actionslistreposecrets) | **GET** /repos/{owner}/{repo}/actions/secrets | List repository secrets
[**ActionsListRepoWorkflows**](ActionsApi.md#actionslistrepoworkflows) | **GET** /repos/{owner}/{repo}/actions/workflows | List repository workflows
[**ActionsListRunnerApplicationsForOrg**](ActionsApi.md#actionslistrunnerapplicationsfororg) | **GET** /orgs/{org}/actions/runners/downloads | List runner applications for an organization
[**ActionsListRunnerApplicationsForRepo**](ActionsApi.md#actionslistrunnerapplicationsforrepo) | **GET** /repos/{owner}/{repo}/actions/runners/downloads | List runner applications for a repository
[**ActionsListSelectedReposForOrgSecret**](ActionsApi.md#actionslistselectedreposfororgsecret) | **GET** /orgs/{org}/actions/secrets/{secret_name}/repositories | List selected repositories for an organization secret
[**ActionsListSelectedRepositoriesEnabledGithubActionsOrganization**](ActionsApi.md#actionslistselectedrepositoriesenabledgithubactionsorganization) | **GET** /orgs/{org}/actions/permissions/repositories | List selected repositories enabled for GitHub Actions in an organization
[**ActionsListSelfHostedRunnerGroupsForOrg**](ActionsApi.md#actionslistselfhostedrunnergroupsfororg) | **GET** /orgs/{org}/actions/runner-groups | List self-hosted runner groups for an organization
[**ActionsListSelfHostedRunnersForOrg**](ActionsApi.md#actionslistselfhostedrunnersfororg) | **GET** /orgs/{org}/actions/runners | List self-hosted runners for an organization
[**ActionsListSelfHostedRunnersForRepo**](ActionsApi.md#actionslistselfhostedrunnersforrepo) | **GET** /repos/{owner}/{repo}/actions/runners | List self-hosted runners for a repository
[**ActionsListSelfHostedRunnersInGroupForOrg**](ActionsApi.md#actionslistselfhostedrunnersingroupfororg) | **GET** /orgs/{org}/actions/runner-groups/{runner_group_id}/runners | List self-hosted runners in a group for an organization
[**ActionsListWorkflowRunArtifacts**](ActionsApi.md#actionslistworkflowrunartifacts) | **GET** /repos/{owner}/{repo}/actions/runs/{run_id}/artifacts | List workflow run artifacts
[**ActionsListWorkflowRuns**](ActionsApi.md#actionslistworkflowruns) | **GET** /repos/{owner}/{repo}/actions/workflows/{workflow_id}/runs | List workflow runs
[**ActionsListWorkflowRunsForRepo**](ActionsApi.md#actionslistworkflowrunsforrepo) | **GET** /repos/{owner}/{repo}/actions/runs | List workflow runs for a repository
[**ActionsReRunJobForWorkflowRun**](ActionsApi.md#actionsrerunjobforworkflowrun) | **POST** /repos/{owner}/{repo}/actions/jobs/{job_id}/rerun | Re-run a job from a workflow run
[**ActionsReRunWorkflow**](ActionsApi.md#actionsrerunworkflow) | **POST** /repos/{owner}/{repo}/actions/runs/{run_id}/rerun | Re-run a workflow
[**ActionsReRunWorkflowFailedJobs**](ActionsApi.md#actionsrerunworkflowfailedjobs) | **POST** /repos/{owner}/{repo}/actions/runs/{run_id}/rerun-failed-jobs | Re-run failed jobs from a workflow run
[**ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForOrg**](ActionsApi.md#actionsremoveallcustomlabelsfromselfhostedrunnerfororg) | **DELETE** /orgs/{org}/actions/runners/{runner_id}/labels | Remove all custom labels from a self-hosted runner for an organization
[**ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepo**](ActionsApi.md#actionsremoveallcustomlabelsfromselfhostedrunnerforrepo) | **DELETE** /repos/{owner}/{repo}/actions/runners/{runner_id}/labels | Remove all custom labels from a self-hosted runner for a repository
[**ActionsRemoveCustomLabelFromSelfHostedRunnerForOrg**](ActionsApi.md#actionsremovecustomlabelfromselfhostedrunnerfororg) | **DELETE** /orgs/{org}/actions/runners/{runner_id}/labels/{name} | Remove a custom label from a self-hosted runner for an organization
[**ActionsRemoveCustomLabelFromSelfHostedRunnerForRepo**](ActionsApi.md#actionsremovecustomlabelfromselfhostedrunnerforrepo) | **DELETE** /repos/{owner}/{repo}/actions/runners/{runner_id}/labels/{name} | Remove a custom label from a self-hosted runner for a repository
[**ActionsRemoveRepoAccessToSelfHostedRunnerGroupInOrg**](ActionsApi.md#actionsremoverepoaccesstoselfhostedrunnergroupinorg) | **DELETE** /orgs/{org}/actions/runner-groups/{runner_group_id}/repositories/{repository_id} | Remove repository access to a self-hosted runner group in an organization
[**ActionsRemoveSelectedRepoFromOrgSecret**](ActionsApi.md#actionsremoveselectedrepofromorgsecret) | **DELETE** /orgs/{org}/actions/secrets/{secret_name}/repositories/{repository_id} | Remove selected repository from an organization secret
[**ActionsRemoveSelfHostedRunnerFromGroupForOrg**](ActionsApi.md#actionsremoveselfhostedrunnerfromgroupfororg) | **DELETE** /orgs/{org}/actions/runner-groups/{runner_group_id}/runners/{runner_id} | Remove a self-hosted runner from a group for an organization
[**ActionsReviewPendingDeploymentsForRun**](ActionsApi.md#actionsreviewpendingdeploymentsforrun) | **POST** /repos/{owner}/{repo}/actions/runs/{run_id}/pending_deployments | Review pending deployments for a workflow run
[**ActionsSetActionsOidcCustomIssuerPolicyForEnterprise**](ActionsApi.md#actionssetactionsoidccustomissuerpolicyforenterprise) | **PUT** /enterprises/{enterprise}/actions/oidc/customization/issuer | Set the GitHub Actions OIDC custom issuer policy for an enterprise
[**ActionsSetAllowedActionsOrganization**](ActionsApi.md#actionssetallowedactionsorganization) | **PUT** /orgs/{org}/actions/permissions/selected-actions | Set allowed actions and reusable workflows for an organization
[**ActionsSetAllowedActionsRepository**](ActionsApi.md#actionssetallowedactionsrepository) | **PUT** /repos/{owner}/{repo}/actions/permissions/selected-actions | Set allowed actions and reusable workflows for a repository
[**ActionsSetCustomLabelsForSelfHostedRunnerForOrg**](ActionsApi.md#actionssetcustomlabelsforselfhostedrunnerfororg) | **PUT** /orgs/{org}/actions/runners/{runner_id}/labels | Set custom labels for a self-hosted runner for an organization
[**ActionsSetCustomLabelsForSelfHostedRunnerForRepo**](ActionsApi.md#actionssetcustomlabelsforselfhostedrunnerforrepo) | **PUT** /repos/{owner}/{repo}/actions/runners/{runner_id}/labels | Set custom labels for a self-hosted runner for a repository
[**ActionsSetCustomOidcSubClaimForRepo**](ActionsApi.md#actionssetcustomoidcsubclaimforrepo) | **PUT** /repos/{owner}/{repo}/actions/oidc/customization/sub | Set the opt-in flag of an OIDC subject claim customization for a repository
[**ActionsSetGithubActionsDefaultWorkflowPermissionsEnterprise**](ActionsApi.md#actionssetgithubactionsdefaultworkflowpermissionsenterprise) | **PUT** /enterprises/{enterprise}/actions/permissions/workflow | Set default workflow permissions for an enterprise
[**ActionsSetGithubActionsDefaultWorkflowPermissionsOrganization**](ActionsApi.md#actionssetgithubactionsdefaultworkflowpermissionsorganization) | **PUT** /orgs/{org}/actions/permissions/workflow | Set default workflow permissions for an organization
[**ActionsSetGithubActionsDefaultWorkflowPermissionsRepository**](ActionsApi.md#actionssetgithubactionsdefaultworkflowpermissionsrepository) | **PUT** /repos/{owner}/{repo}/actions/permissions/workflow | Set default workflow permissions for a repository
[**ActionsSetGithubActionsPermissionsOrganization**](ActionsApi.md#actionssetgithubactionspermissionsorganization) | **PUT** /orgs/{org}/actions/permissions | Set GitHub Actions permissions for an organization
[**ActionsSetGithubActionsPermissionsRepository**](ActionsApi.md#actionssetgithubactionspermissionsrepository) | **PUT** /repos/{owner}/{repo}/actions/permissions | Set GitHub Actions permissions for a repository
[**ActionsSetRepoAccessToSelfHostedRunnerGroupInOrg**](ActionsApi.md#actionssetrepoaccesstoselfhostedrunnergroupinorg) | **PUT** /orgs/{org}/actions/runner-groups/{runner_group_id}/repositories | Set repository access for a self-hosted runner group in an organization
[**ActionsSetSelectedReposForOrgSecret**](ActionsApi.md#actionssetselectedreposfororgsecret) | **PUT** /orgs/{org}/actions/secrets/{secret_name}/repositories | Set selected repositories for an organization secret
[**ActionsSetSelectedRepositoriesEnabledGithubActionsOrganization**](ActionsApi.md#actionssetselectedrepositoriesenabledgithubactionsorganization) | **PUT** /orgs/{org}/actions/permissions/repositories | Set selected repositories enabled for GitHub Actions in an organization
[**ActionsSetSelfHostedRunnersInGroupForOrg**](ActionsApi.md#actionssetselfhostedrunnersingroupfororg) | **PUT** /orgs/{org}/actions/runner-groups/{runner_group_id}/runners | Set self-hosted runners in a group for an organization
[**ActionsSetWorkflowAccessToRepository**](ActionsApi.md#actionssetworkflowaccesstorepository) | **PUT** /repos/{owner}/{repo}/actions/permissions/access | Set the level of access for workflows outside of the repository
[**ActionsUpdateSelfHostedRunnerGroupForOrg**](ActionsApi.md#actionsupdateselfhostedrunnergroupfororg) | **PATCH** /orgs/{org}/actions/runner-groups/{runner_group_id} | Update a self-hosted runner group for an organization


<a name="actionsaddcustomlabelstoselfhostedrunnerfororg"></a>
# **ActionsAddCustomLabelsToSelfHostedRunnerForOrg**
> EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsAddCustomLabelsToSelfHostedRunnerForOrg (string org, int? runnerId, EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest)

Add custom labels to a self-hosted runner for an organization

Add custom labels to a self-hosted runner configured in an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsAddCustomLabelsToSelfHostedRunnerForOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.
            var enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest = new EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest(); // EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest | 

            try
            {
                // Add custom labels to a self-hosted runner for an organization
                EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response result = apiInstance.ActionsAddCustomLabelsToSelfHostedRunnerForOrg(org, runnerId, enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsAddCustomLabelsToSelfHostedRunnerForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 
 **enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest** | [**EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest**](EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest.md)|  | 

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsaddcustomlabelstoselfhostedrunnerforrepo"></a>
# **ActionsAddCustomLabelsToSelfHostedRunnerForRepo**
> EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsAddCustomLabelsToSelfHostedRunnerForRepo (string owner, string repo, int? runnerId, EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest)

Add custom labels to a self-hosted runner for a repository

Add custom labels to a self-hosted runner configured in a repository.  You must authenticate using an access token with the `repo` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsAddCustomLabelsToSelfHostedRunnerForRepoExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.
            var enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest = new EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest(); // EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest | 

            try
            {
                // Add custom labels to a self-hosted runner for a repository
                EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response result = apiInstance.ActionsAddCustomLabelsToSelfHostedRunnerForRepo(owner, repo, runnerId, enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsAddCustomLabelsToSelfHostedRunnerForRepo: " + e.Message );
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
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 
 **enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest** | [**EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest**](EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest.md)|  | 

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsaddrepoaccesstoselfhostedrunnergroupinorg"></a>
# **ActionsAddRepoAccessToSelfHostedRunnerGroupInOrg**
> void ActionsAddRepoAccessToSelfHostedRunnerGroupInOrg (string org, int? runnerGroupId, int? repositoryId)

Add repository access to a self-hosted runner group in an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"   Adds a repository to the list of selected repositories that can access a self-hosted runner group. The runner group must have `visibility` set to `selected`. For more information, see \"[Create a self-hosted runner group for an organization](#create-a-self-hosted-runner-group-for-an-organization).\"  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsAddRepoAccessToSelfHostedRunnerGroupInOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var runnerGroupId = 56;  // int? | Unique identifier of the self-hosted runner group.
            var repositoryId = 56;  // int? | The unique identifier of the repository.

            try
            {
                // Add repository access to a self-hosted runner group in an organization
                apiInstance.ActionsAddRepoAccessToSelfHostedRunnerGroupInOrg(org, runnerGroupId, repositoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsAddRepoAccessToSelfHostedRunnerGroupInOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **runnerGroupId** | **int?**| Unique identifier of the self-hosted runner group. | 
 **repositoryId** | **int?**| The unique identifier of the repository. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsaddselectedrepotoorgsecret"></a>
# **ActionsAddSelectedRepoToOrgSecret**
> void ActionsAddSelectedRepoToOrgSecret (string org, string secretName, int? repositoryId)

Add selected repository to an organization secret

Adds a repository to an organization secret when the `visibility` for repository access is set to `selected`. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/actions#create-or-update-an-organization-secret). You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `secrets` organization permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsAddSelectedRepoToOrgSecretExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.
            var repositoryId = 56;  // int? | 

            try
            {
                // Add selected repository to an organization secret
                apiInstance.ActionsAddSelectedRepoToOrgSecret(org, secretName, repositoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsAddSelectedRepoToOrgSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **secretName** | **string**| The name of the secret. | 
 **repositoryId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsaddselfhostedrunnertogroupfororg"></a>
# **ActionsAddSelfHostedRunnerToGroupForOrg**
> void ActionsAddSelfHostedRunnerToGroupForOrg (string org, int? runnerGroupId, int? runnerId)

Add a self-hosted runner to a group for an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"   Adds a self-hosted runner to a runner group configured in an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsAddSelfHostedRunnerToGroupForOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var runnerGroupId = 56;  // int? | Unique identifier of the self-hosted runner group.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.

            try
            {
                // Add a self-hosted runner to a group for an organization
                apiInstance.ActionsAddSelfHostedRunnerToGroupForOrg(org, runnerGroupId, runnerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsAddSelfHostedRunnerToGroupForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **runnerGroupId** | **int?**| Unique identifier of the self-hosted runner group. | 
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsapproveworkflowrun"></a>
# **ActionsApproveWorkflowRun**
> Object ActionsApproveWorkflowRun (string owner, string repo, int? runId)

Approve a workflow run for a fork pull request

Approves a workflow run for a pull request from a public fork of a first time contributor. For more information, see [\"Approving workflow runs from public forks](https://docs.github.com/actions/managing-workflow-runs/approving-workflow-runs-from-public-forks).\"  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsApproveWorkflowRunExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runId = 56;  // int? | The unique identifier of the workflow run.

            try
            {
                // Approve a workflow run for a fork pull request
                Object result = apiInstance.ActionsApproveWorkflowRun(owner, repo, runId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsApproveWorkflowRun: " + e.Message );
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
 **runId** | **int?**| The unique identifier of the workflow run. | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionscancelworkflowrun"></a>
# **ActionsCancelWorkflowRun**
> Object ActionsCancelWorkflowRun (string owner, string repo, int? runId)

Cancel a workflow run

Cancels a workflow run using its `id`. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsCancelWorkflowRunExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runId = 56;  // int? | The unique identifier of the workflow run.

            try
            {
                // Cancel a workflow run
                Object result = apiInstance.ActionsCancelWorkflowRun(owner, repo, runId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsCancelWorkflowRun: " + e.Message );
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
 **runId** | **int?**| The unique identifier of the workflow run. | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionscreateorupdateenvironmentsecret"></a>
# **ActionsCreateOrUpdateEnvironmentSecret**
> Object ActionsCreateOrUpdateEnvironmentSecret (int? repositoryId, string environmentName, string secretName, ActionsCreateOrUpdateEnvironmentSecretRequest actionsCreateOrUpdateEnvironmentSecretRequest)

Create or update an environment secret

Creates or updates an environment secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `secrets` repository permission to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  ``` const sodium = require('tweetsodium');  const key = \"base64-encoded-public-key\"; const value = \"plain-text-secret\";  // Convert the message and key to Uint8Array's (Buffer implements that interface) const messageBytes = Buffer.from(value); const keyBytes = Buffer.from(key, 'base64');  // Encrypt using LibSodium. const encryptedBytes = sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted = Buffer.from(encryptedBytes).toString('base64');  console.log(encrypted); ```   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  ``` from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -> str:   \"\"\"Encrypt a Unicode string using the public key.\"\"\"   public_key = public.PublicKey(public_key.encode(\"utf-8\"), encoding.Base64Encoder())   sealed_box = public.SealedBox(public_key)   encrypted = sealed_box.encrypt(secret_value.encode(\"utf-8\"))   return b64encode(encrypted).decode(\"utf-8\") ```  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  ``` var secretValue = System.Text.Encoding.UTF8.GetBytes(\"mySecret\"); var publicKey = Convert.FromBase64String(\"2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU=\");  var sealedPublicKeyBox = Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); ```  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  ```ruby require \"rbnacl\" require \"base64\"  key = Base64.decode64(\"+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0=\") public_key = RbNaCl::PublicKey.new(key)  box = RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret = box.encrypt(\"my_secret\")  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) ```

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsCreateOrUpdateEnvironmentSecretExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var repositoryId = 56;  // int? | The unique identifier of the repository.
            var environmentName = "environmentName_example";  // string | The name of the environment
            var secretName = "secretName_example";  // string | The name of the secret.
            var actionsCreateOrUpdateEnvironmentSecretRequest = new ActionsCreateOrUpdateEnvironmentSecretRequest(); // ActionsCreateOrUpdateEnvironmentSecretRequest | 

            try
            {
                // Create or update an environment secret
                Object result = apiInstance.ActionsCreateOrUpdateEnvironmentSecret(repositoryId, environmentName, secretName, actionsCreateOrUpdateEnvironmentSecretRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsCreateOrUpdateEnvironmentSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryId** | **int?**| The unique identifier of the repository. | 
 **environmentName** | **string**| The name of the environment | 
 **secretName** | **string**| The name of the secret. | 
 **actionsCreateOrUpdateEnvironmentSecretRequest** | [**ActionsCreateOrUpdateEnvironmentSecretRequest**](ActionsCreateOrUpdateEnvironmentSecretRequest.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionscreateorupdateorgsecret"></a>
# **ActionsCreateOrUpdateOrgSecret**
> Object ActionsCreateOrUpdateOrgSecret (string org, string secretName, ActionsCreateOrUpdateOrgSecretRequest actionsCreateOrUpdateOrgSecretRequest)

Create or update an organization secret

Creates or updates an organization secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `secrets` organization permission to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  ``` const sodium = require('tweetsodium');  const key = \"base64-encoded-public-key\"; const value = \"plain-text-secret\";  // Convert the message and key to Uint8Array's (Buffer implements that interface) const messageBytes = Buffer.from(value); const keyBytes = Buffer.from(key, 'base64');  // Encrypt using LibSodium. const encryptedBytes = sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted = Buffer.from(encryptedBytes).toString('base64');  console.log(encrypted); ```   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  ``` from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -> str:   \"\"\"Encrypt a Unicode string using the public key.\"\"\"   public_key = public.PublicKey(public_key.encode(\"utf-8\"), encoding.Base64Encoder())   sealed_box = public.SealedBox(public_key)   encrypted = sealed_box.encrypt(secret_value.encode(\"utf-8\"))   return b64encode(encrypted).decode(\"utf-8\") ```  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  ``` var secretValue = System.Text.Encoding.UTF8.GetBytes(\"mySecret\"); var publicKey = Convert.FromBase64String(\"2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU=\");  var sealedPublicKeyBox = Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); ```  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  ```ruby require \"rbnacl\" require \"base64\"  key = Base64.decode64(\"+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0=\") public_key = RbNaCl::PublicKey.new(key)  box = RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret = box.encrypt(\"my_secret\")  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) ```

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsCreateOrUpdateOrgSecretExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.
            var actionsCreateOrUpdateOrgSecretRequest = new ActionsCreateOrUpdateOrgSecretRequest(); // ActionsCreateOrUpdateOrgSecretRequest | 

            try
            {
                // Create or update an organization secret
                Object result = apiInstance.ActionsCreateOrUpdateOrgSecret(org, secretName, actionsCreateOrUpdateOrgSecretRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsCreateOrUpdateOrgSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **secretName** | **string**| The name of the secret. | 
 **actionsCreateOrUpdateOrgSecretRequest** | [**ActionsCreateOrUpdateOrgSecretRequest**](ActionsCreateOrUpdateOrgSecretRequest.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionscreateorupdatereposecret"></a>
# **ActionsCreateOrUpdateRepoSecret**
> Object ActionsCreateOrUpdateRepoSecret (string owner, string repo, string secretName, ActionsCreateOrUpdateRepoSecretRequest actionsCreateOrUpdateRepoSecretRequest)

Create or update a repository secret

Creates or updates a repository secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `secrets` repository permission to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  ``` const sodium = require('tweetsodium');  const key = \"base64-encoded-public-key\"; const value = \"plain-text-secret\";  // Convert the message and key to Uint8Array's (Buffer implements that interface) const messageBytes = Buffer.from(value); const keyBytes = Buffer.from(key, 'base64');  // Encrypt using LibSodium. const encryptedBytes = sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted = Buffer.from(encryptedBytes).toString('base64');  console.log(encrypted); ```   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  ``` from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -> str:   \"\"\"Encrypt a Unicode string using the public key.\"\"\"   public_key = public.PublicKey(public_key.encode(\"utf-8\"), encoding.Base64Encoder())   sealed_box = public.SealedBox(public_key)   encrypted = sealed_box.encrypt(secret_value.encode(\"utf-8\"))   return b64encode(encrypted).decode(\"utf-8\") ```  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  ``` var secretValue = System.Text.Encoding.UTF8.GetBytes(\"mySecret\"); var publicKey = Convert.FromBase64String(\"2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU=\");  var sealedPublicKeyBox = Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); ```  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  ```ruby require \"rbnacl\" require \"base64\"  key = Base64.decode64(\"+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0=\") public_key = RbNaCl::PublicKey.new(key)  box = RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret = box.encrypt(\"my_secret\")  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) ```

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsCreateOrUpdateRepoSecretExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.
            var actionsCreateOrUpdateRepoSecretRequest = new ActionsCreateOrUpdateRepoSecretRequest(); // ActionsCreateOrUpdateRepoSecretRequest | 

            try
            {
                // Create or update a repository secret
                Object result = apiInstance.ActionsCreateOrUpdateRepoSecret(owner, repo, secretName, actionsCreateOrUpdateRepoSecretRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsCreateOrUpdateRepoSecret: " + e.Message );
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
 **secretName** | **string**| The name of the secret. | 
 **actionsCreateOrUpdateRepoSecretRequest** | [**ActionsCreateOrUpdateRepoSecretRequest**](ActionsCreateOrUpdateRepoSecretRequest.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionscreateregistrationtokenfororg"></a>
# **ActionsCreateRegistrationTokenForOrg**
> AuthenticationToken ActionsCreateRegistrationTokenForOrg (string org)

Create a registration token for an organization

Returns a token that you can pass to the `config` script. The token expires after one hour.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.  #### Example using registration token  Configure your self-hosted runner, replacing `TOKEN` with the registration token provided by this endpoint.  ``` ./config.sh - -url https://github.com/octo-org - -token TOKEN ```

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsCreateRegistrationTokenForOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.

            try
            {
                // Create a registration token for an organization
                AuthenticationToken result = apiInstance.ActionsCreateRegistrationTokenForOrg(org);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsCreateRegistrationTokenForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 

### Return type

[**AuthenticationToken**](AuthenticationToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionscreateregistrationtokenforrepo"></a>
# **ActionsCreateRegistrationTokenForRepo**
> AuthenticationToken ActionsCreateRegistrationTokenForRepo (string owner, string repo)

Create a registration token for a repository

Returns a token that you can pass to the `config` script. The token expires after one hour. You must authenticate using an access token with the `repo` scope to use this endpoint.  #### Example using registration token   Configure your self-hosted runner, replacing `TOKEN` with the registration token provided by this endpoint.  ``` ./config.sh - -url https://github.com/octo-org/octo-repo-artifacts - -token TOKEN ```

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsCreateRegistrationTokenForRepoExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Create a registration token for a repository
                AuthenticationToken result = apiInstance.ActionsCreateRegistrationTokenForRepo(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsCreateRegistrationTokenForRepo: " + e.Message );
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

[**AuthenticationToken**](AuthenticationToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionscreateremovetokenfororg"></a>
# **ActionsCreateRemoveTokenForOrg**
> AuthenticationToken ActionsCreateRemoveTokenForOrg (string org)

Create a remove token for an organization

Returns a token that you can pass to the `config` script to remove a self-hosted runner from an organization. The token expires after one hour.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.  #### Example using remove token  To remove your self-hosted runner from an organization, replace `TOKEN` with the remove token provided by this endpoint.  ``` ./config.sh remove - -token TOKEN ```

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsCreateRemoveTokenForOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.

            try
            {
                // Create a remove token for an organization
                AuthenticationToken result = apiInstance.ActionsCreateRemoveTokenForOrg(org);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsCreateRemoveTokenForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 

### Return type

[**AuthenticationToken**](AuthenticationToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionscreateremovetokenforrepo"></a>
# **ActionsCreateRemoveTokenForRepo**
> AuthenticationToken ActionsCreateRemoveTokenForRepo (string owner, string repo)

Create a remove token for a repository

Returns a token that you can pass to remove a self-hosted runner from a repository. The token expires after one hour. You must authenticate using an access token with the `repo` scope to use this endpoint.  #### Example using remove token   To remove your self-hosted runner from a repository, replace TOKEN with the remove token provided by this endpoint.  ``` ./config.sh remove - -token TOKEN ```

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsCreateRemoveTokenForRepoExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Create a remove token for a repository
                AuthenticationToken result = apiInstance.ActionsCreateRemoveTokenForRepo(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsCreateRemoveTokenForRepo: " + e.Message );
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

[**AuthenticationToken**](AuthenticationToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionscreateselfhostedrunnergroupfororg"></a>
# **ActionsCreateSelfHostedRunnerGroupForOrg**
> ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner ActionsCreateSelfHostedRunnerGroupForOrg (string org, ActionsCreateSelfHostedRunnerGroupForOrgRequest actionsCreateSelfHostedRunnerGroupForOrgRequest)

Create a self-hosted runner group for an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud and GitHub Enterprise Server. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"  Creates a new self-hosted runner group for an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsCreateSelfHostedRunnerGroupForOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var actionsCreateSelfHostedRunnerGroupForOrgRequest = new ActionsCreateSelfHostedRunnerGroupForOrgRequest(); // ActionsCreateSelfHostedRunnerGroupForOrgRequest | 

            try
            {
                // Create a self-hosted runner group for an organization
                ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner result = apiInstance.ActionsCreateSelfHostedRunnerGroupForOrg(org, actionsCreateSelfHostedRunnerGroupForOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsCreateSelfHostedRunnerGroupForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **actionsCreateSelfHostedRunnerGroupForOrgRequest** | [**ActionsCreateSelfHostedRunnerGroupForOrgRequest**](ActionsCreateSelfHostedRunnerGroupForOrgRequest.md)|  | 

### Return type

[**ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner**](ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionscreateworkflowdispatch"></a>
# **ActionsCreateWorkflowDispatch**
> void ActionsCreateWorkflowDispatch (string owner, string repo, ActionsGetWorkflowWorkflowIdParameter workflowId, ActionsCreateWorkflowDispatchRequest actionsCreateWorkflowDispatchRequest)

Create a workflow dispatch event

You can use this endpoint to manually trigger a GitHub Actions workflow run. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`.  You must configure your GitHub Actions workflow to run when the [`workflow_dispatch` webhook](/developers/webhooks-and-events/webhook-events-and-payloads#workflow_dispatch) event occurs. The `inputs` are configured in the workflow file. For more information about how to configure the `workflow_dispatch` event in the workflow file, see \"[Events that trigger workflows](/actions/reference/events-that-trigger-workflows#workflow_dispatch).\"  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint. For more information, see \"[Creating a personal access token for the command line](https://docs.github.com/articles/creating-a-personal-access-token-for-the-command-line).\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsCreateWorkflowDispatchExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var workflowId = new ActionsGetWorkflowWorkflowIdParameter(); // ActionsGetWorkflowWorkflowIdParameter | The ID of the workflow. You can also pass the workflow file name as a string.
            var actionsCreateWorkflowDispatchRequest = new ActionsCreateWorkflowDispatchRequest(); // ActionsCreateWorkflowDispatchRequest | 

            try
            {
                // Create a workflow dispatch event
                apiInstance.ActionsCreateWorkflowDispatch(owner, repo, workflowId, actionsCreateWorkflowDispatchRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsCreateWorkflowDispatch: " + e.Message );
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
 **workflowId** | [**ActionsGetWorkflowWorkflowIdParameter**](.md)| The ID of the workflow. You can also pass the workflow file name as a string. | 
 **actionsCreateWorkflowDispatchRequest** | [**ActionsCreateWorkflowDispatchRequest**](ActionsCreateWorkflowDispatchRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsdeleteactionscachebyid"></a>
# **ActionsDeleteActionsCacheById**
> void ActionsDeleteActionsCacheById (string owner, string repo, int? cacheId)

Delete a GitHub Actions cache for a repository (using a cache ID)

Deletes a GitHub Actions cache for a repository, using a cache ID.  You must authenticate using an access token with the `repo` scope to use this endpoint.  GitHub Apps must have the `actions:write` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsDeleteActionsCacheByIdExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var cacheId = 56;  // int? | The unique identifier of the GitHub Actions cache.

            try
            {
                // Delete a GitHub Actions cache for a repository (using a cache ID)
                apiInstance.ActionsDeleteActionsCacheById(owner, repo, cacheId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsDeleteActionsCacheById: " + e.Message );
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
 **cacheId** | **int?**| The unique identifier of the GitHub Actions cache. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsdeleteactionscachebykey"></a>
# **ActionsDeleteActionsCacheByKey**
> RepositoryActionsCaches ActionsDeleteActionsCacheByKey (string owner, string repo, string key, string _ref)

Delete GitHub Actions caches for a repository (using a cache key)

Deletes one or more GitHub Actions caches for a repository, using a complete cache key. By default, all caches that match the provided key are deleted, but you can optionally provide a Git ref to restrict deletions to caches that match both the provided key and the Git ref.  You must authenticate using an access token with the `repo` scope to use this endpoint.  GitHub Apps must have the `actions:write` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsDeleteActionsCacheByKeyExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var key = "key_example";  // string | A key for identifying the cache.
            var _ref = "_ref_example";  // string | The Git reference for the results you want to list. The `ref` for a branch can be formatted either as `refs/heads/<branch name>` or simply `<branch name>`. To reference a pull request use `refs/pull/<number>/merge`. (optional) 

            try
            {
                // Delete GitHub Actions caches for a repository (using a cache key)
                RepositoryActionsCaches result = apiInstance.ActionsDeleteActionsCacheByKey(owner, repo, key, _ref);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsDeleteActionsCacheByKey: " + e.Message );
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
 **key** | **string**| A key for identifying the cache. | 
 **_ref** | **string**| The Git reference for the results you want to list. The &#x60;ref&#x60; for a branch can be formatted either as &#x60;refs/heads/&lt;branch name&gt;&#x60; or simply &#x60;&lt;branch name&gt;&#x60;. To reference a pull request use &#x60;refs/pull/&lt;number&gt;/merge&#x60;. | [optional] 

### Return type

[**RepositoryActionsCaches**](RepositoryActionsCaches.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsdeleteartifact"></a>
# **ActionsDeleteArtifact**
> void ActionsDeleteArtifact (string owner, string repo, int? artifactId)

Delete an artifact

Deletes an artifact for a workflow run. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsDeleteArtifactExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var artifactId = 56;  // int? | The unique identifier of the artifact.

            try
            {
                // Delete an artifact
                apiInstance.ActionsDeleteArtifact(owner, repo, artifactId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsDeleteArtifact: " + e.Message );
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
 **artifactId** | **int?**| The unique identifier of the artifact. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsdeleteenvironmentsecret"></a>
# **ActionsDeleteEnvironmentSecret**
> void ActionsDeleteEnvironmentSecret (int? repositoryId, string environmentName, string secretName)

Delete an environment secret

Deletes a secret in an environment using the secret name. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `secrets` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsDeleteEnvironmentSecretExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var repositoryId = 56;  // int? | The unique identifier of the repository.
            var environmentName = "environmentName_example";  // string | The name of the environment
            var secretName = "secretName_example";  // string | The name of the secret.

            try
            {
                // Delete an environment secret
                apiInstance.ActionsDeleteEnvironmentSecret(repositoryId, environmentName, secretName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsDeleteEnvironmentSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryId** | **int?**| The unique identifier of the repository. | 
 **environmentName** | **string**| The name of the environment | 
 **secretName** | **string**| The name of the secret. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsdeleteorgsecret"></a>
# **ActionsDeleteOrgSecret**
> void ActionsDeleteOrgSecret (string org, string secretName)

Delete an organization secret

Deletes a secret in an organization using the secret name. You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `secrets` organization permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsDeleteOrgSecretExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.

            try
            {
                // Delete an organization secret
                apiInstance.ActionsDeleteOrgSecret(org, secretName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsDeleteOrgSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **secretName** | **string**| The name of the secret. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsdeletereposecret"></a>
# **ActionsDeleteRepoSecret**
> void ActionsDeleteRepoSecret (string owner, string repo, string secretName)

Delete a repository secret

Deletes a secret in a repository using the secret name. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `secrets` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsDeleteRepoSecretExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.

            try
            {
                // Delete a repository secret
                apiInstance.ActionsDeleteRepoSecret(owner, repo, secretName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsDeleteRepoSecret: " + e.Message );
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
 **secretName** | **string**| The name of the secret. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsdeleteselfhostedrunnerfromorg"></a>
# **ActionsDeleteSelfHostedRunnerFromOrg**
> void ActionsDeleteSelfHostedRunnerFromOrg (string org, int? runnerId)

Delete a self-hosted runner from an organization

Forces the removal of a self-hosted runner from an organization. You can use this endpoint to completely remove the runner when the machine you were using no longer exists.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsDeleteSelfHostedRunnerFromOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.

            try
            {
                // Delete a self-hosted runner from an organization
                apiInstance.ActionsDeleteSelfHostedRunnerFromOrg(org, runnerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsDeleteSelfHostedRunnerFromOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsdeleteselfhostedrunnerfromrepo"></a>
# **ActionsDeleteSelfHostedRunnerFromRepo**
> void ActionsDeleteSelfHostedRunnerFromRepo (string owner, string repo, int? runnerId)

Delete a self-hosted runner from a repository

Forces the removal of a self-hosted runner from a repository. You can use this endpoint to completely remove the runner when the machine you were using no longer exists.  You must authenticate using an access token with the `repo` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsDeleteSelfHostedRunnerFromRepoExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.

            try
            {
                // Delete a self-hosted runner from a repository
                apiInstance.ActionsDeleteSelfHostedRunnerFromRepo(owner, repo, runnerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsDeleteSelfHostedRunnerFromRepo: " + e.Message );
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
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsdeleteselfhostedrunnergroupfromorg"></a>
# **ActionsDeleteSelfHostedRunnerGroupFromOrg**
> void ActionsDeleteSelfHostedRunnerGroupFromOrg (string org, int? runnerGroupId)

Delete a self-hosted runner group from an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"  Deletes a self-hosted runner group for an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsDeleteSelfHostedRunnerGroupFromOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var runnerGroupId = 56;  // int? | Unique identifier of the self-hosted runner group.

            try
            {
                // Delete a self-hosted runner group from an organization
                apiInstance.ActionsDeleteSelfHostedRunnerGroupFromOrg(org, runnerGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsDeleteSelfHostedRunnerGroupFromOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **runnerGroupId** | **int?**| Unique identifier of the self-hosted runner group. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsdeleteworkflowrun"></a>
# **ActionsDeleteWorkflowRun**
> void ActionsDeleteWorkflowRun (string owner, string repo, int? runId)

Delete a workflow run

Delete a specific workflow run. Anyone with write access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:write` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsDeleteWorkflowRunExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runId = 56;  // int? | The unique identifier of the workflow run.

            try
            {
                // Delete a workflow run
                apiInstance.ActionsDeleteWorkflowRun(owner, repo, runId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsDeleteWorkflowRun: " + e.Message );
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
 **runId** | **int?**| The unique identifier of the workflow run. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsdeleteworkflowrunlogs"></a>
# **ActionsDeleteWorkflowRunLogs**
> void ActionsDeleteWorkflowRunLogs (string owner, string repo, int? runId)

Delete workflow run logs

Deletes all logs for a workflow run. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsDeleteWorkflowRunLogsExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runId = 56;  // int? | The unique identifier of the workflow run.

            try
            {
                // Delete workflow run logs
                apiInstance.ActionsDeleteWorkflowRunLogs(owner, repo, runId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsDeleteWorkflowRunLogs: " + e.Message );
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
 **runId** | **int?**| The unique identifier of the workflow run. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsdisableselectedrepositorygithubactionsorganization"></a>
# **ActionsDisableSelectedRepositoryGithubActionsOrganization**
> void ActionsDisableSelectedRepositoryGithubActionsOrganization (string org, int? repositoryId)

Disable a selected repository for GitHub Actions in an organization

Removes a repository from the list of selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for `enabled_repositories` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\"  You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `administration` organization permission to use this API.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsDisableSelectedRepositoryGithubActionsOrganizationExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var repositoryId = 56;  // int? | The unique identifier of the repository.

            try
            {
                // Disable a selected repository for GitHub Actions in an organization
                apiInstance.ActionsDisableSelectedRepositoryGithubActionsOrganization(org, repositoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsDisableSelectedRepositoryGithubActionsOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **repositoryId** | **int?**| The unique identifier of the repository. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsdisableworkflow"></a>
# **ActionsDisableWorkflow**
> void ActionsDisableWorkflow (string owner, string repo, ActionsGetWorkflowWorkflowIdParameter workflowId)

Disable a workflow

Disables a workflow and sets the `state` of the workflow to `disabled_manually`. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`.  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsDisableWorkflowExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var workflowId = new ActionsGetWorkflowWorkflowIdParameter(); // ActionsGetWorkflowWorkflowIdParameter | The ID of the workflow. You can also pass the workflow file name as a string.

            try
            {
                // Disable a workflow
                apiInstance.ActionsDisableWorkflow(owner, repo, workflowId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsDisableWorkflow: " + e.Message );
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
 **workflowId** | [**ActionsGetWorkflowWorkflowIdParameter**](.md)| The ID of the workflow. You can also pass the workflow file name as a string. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsdownloadartifact"></a>
# **ActionsDownloadArtifact**
> void ActionsDownloadArtifact (string owner, string repo, int? artifactId, string archiveFormat)

Download an artifact

Gets a redirect URL to download an archive for a repository. This URL expires after 1 minute. Look for `Location:` in the response header to find the URL for the download. The `:archive_format` must be `zip`. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsDownloadArtifactExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var artifactId = 56;  // int? | The unique identifier of the artifact.
            var archiveFormat = "archiveFormat_example";  // string | 

            try
            {
                // Download an artifact
                apiInstance.ActionsDownloadArtifact(owner, repo, artifactId, archiveFormat);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsDownloadArtifact: " + e.Message );
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
 **artifactId** | **int?**| The unique identifier of the artifact. | 
 **archiveFormat** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsdownloadjoblogsforworkflowrun"></a>
# **ActionsDownloadJobLogsForWorkflowRun**
> void ActionsDownloadJobLogsForWorkflowRun (string owner, string repo, int? jobId)

Download job logs for a workflow run

Gets a redirect URL to download a plain text file of logs for a workflow job. This link expires after 1 minute. Look for `Location:` in the response header to find the URL for the download. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsDownloadJobLogsForWorkflowRunExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var jobId = 56;  // int? | The unique identifier of the job.

            try
            {
                // Download job logs for a workflow run
                apiInstance.ActionsDownloadJobLogsForWorkflowRun(owner, repo, jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsDownloadJobLogsForWorkflowRun: " + e.Message );
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
 **jobId** | **int?**| The unique identifier of the job. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsdownloadworkflowrunattemptlogs"></a>
# **ActionsDownloadWorkflowRunAttemptLogs**
> void ActionsDownloadWorkflowRunAttemptLogs (string owner, string repo, int? runId, int? attemptNumber)

Download workflow run attempt logs

Gets a redirect URL to download an archive of log files for a specific workflow run attempt. This link expires after 1 minute. Look for `Location:` in the response header to find the URL for the download. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsDownloadWorkflowRunAttemptLogsExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runId = 56;  // int? | The unique identifier of the workflow run.
            var attemptNumber = 56;  // int? | The attempt number of the workflow run.

            try
            {
                // Download workflow run attempt logs
                apiInstance.ActionsDownloadWorkflowRunAttemptLogs(owner, repo, runId, attemptNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsDownloadWorkflowRunAttemptLogs: " + e.Message );
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
 **runId** | **int?**| The unique identifier of the workflow run. | 
 **attemptNumber** | **int?**| The attempt number of the workflow run. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsdownloadworkflowrunlogs"></a>
# **ActionsDownloadWorkflowRunLogs**
> void ActionsDownloadWorkflowRunLogs (string owner, string repo, int? runId)

Download workflow run logs

Gets a redirect URL to download an archive of log files for a workflow run. This link expires after 1 minute. Look for `Location:` in the response header to find the URL for the download. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsDownloadWorkflowRunLogsExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runId = 56;  // int? | The unique identifier of the workflow run.

            try
            {
                // Download workflow run logs
                apiInstance.ActionsDownloadWorkflowRunLogs(owner, repo, runId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsDownloadWorkflowRunLogs: " + e.Message );
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
 **runId** | **int?**| The unique identifier of the workflow run. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsenableselectedrepositorygithubactionsorganization"></a>
# **ActionsEnableSelectedRepositoryGithubActionsOrganization**
> void ActionsEnableSelectedRepositoryGithubActionsOrganization (string org, int? repositoryId)

Enable a selected repository for GitHub Actions in an organization

Adds a repository to the list of selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for `enabled_repositories` must be must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\"  You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `administration` organization permission to use this API.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsEnableSelectedRepositoryGithubActionsOrganizationExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var repositoryId = 56;  // int? | The unique identifier of the repository.

            try
            {
                // Enable a selected repository for GitHub Actions in an organization
                apiInstance.ActionsEnableSelectedRepositoryGithubActionsOrganization(org, repositoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsEnableSelectedRepositoryGithubActionsOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **repositoryId** | **int?**| The unique identifier of the repository. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsenableworkflow"></a>
# **ActionsEnableWorkflow**
> void ActionsEnableWorkflow (string owner, string repo, ActionsGetWorkflowWorkflowIdParameter workflowId)

Enable a workflow

Enables a workflow and sets the `state` of the workflow to `active`. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`.  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsEnableWorkflowExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var workflowId = new ActionsGetWorkflowWorkflowIdParameter(); // ActionsGetWorkflowWorkflowIdParameter | The ID of the workflow. You can also pass the workflow file name as a string.

            try
            {
                // Enable a workflow
                apiInstance.ActionsEnableWorkflow(owner, repo, workflowId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsEnableWorkflow: " + e.Message );
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
 **workflowId** | [**ActionsGetWorkflowWorkflowIdParameter**](.md)| The ID of the workflow. You can also pass the workflow file name as a string. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetactionscachelist"></a>
# **ActionsGetActionsCacheList**
> RepositoryActionsCaches ActionsGetActionsCacheList (string owner, string repo, int? perPage, int? page, string _ref, string key, string sort, string direction)

List GitHub Actions caches for a repository

Lists the GitHub Actions caches for a repository. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetActionsCacheListExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var _ref = "_ref_example";  // string | The Git reference for the results you want to list. The `ref` for a branch can be formatted either as `refs/heads/<branch name>` or simply `<branch name>`. To reference a pull request use `refs/pull/<number>/merge`. (optional) 
            var key = "key_example";  // string | An explicit key or prefix for identifying the cache (optional) 
            var sort = "created_at";  // string | The property to sort the results by. `created_at` means when the cache was created. `last_accessed_at` means when the cache was last accessed. `size_in_bytes` is the size of the cache in bytes. (optional)  (default to last_accessed_at)
            var direction = "asc";  // string | The direction to sort the results by. (optional)  (default to desc)

            try
            {
                // List GitHub Actions caches for a repository
                RepositoryActionsCaches result = apiInstance.ActionsGetActionsCacheList(owner, repo, perPage, page, _ref, key, sort, direction);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetActionsCacheList: " + e.Message );
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
 **_ref** | **string**| The Git reference for the results you want to list. The &#x60;ref&#x60; for a branch can be formatted either as &#x60;refs/heads/&lt;branch name&gt;&#x60; or simply &#x60;&lt;branch name&gt;&#x60;. To reference a pull request use &#x60;refs/pull/&lt;number&gt;/merge&#x60;. | [optional] 
 **key** | **string**| An explicit key or prefix for identifying the cache | [optional] 
 **sort** | **string**| The property to sort the results by. &#x60;created_at&#x60; means when the cache was created. &#x60;last_accessed_at&#x60; means when the cache was last accessed. &#x60;size_in_bytes&#x60; is the size of the cache in bytes. | [optional] [default to last_accessed_at]
 **direction** | **string**| The direction to sort the results by. | [optional] [default to desc]

### Return type

[**RepositoryActionsCaches**](RepositoryActionsCaches.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetactionscacheusage"></a>
# **ActionsGetActionsCacheUsage**
> ActionsCacheUsageByRepository ActionsGetActionsCacheUsage (string owner, string repo)

Get GitHub Actions cache usage for a repository

Gets GitHub Actions cache usage for a repository. The data fetched using this API is refreshed approximately every 5 minutes, so values returned from this endpoint may take at least 5 minutes to get updated. Anyone with read access to the repository can use this endpoint. If the repository is private, you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetActionsCacheUsageExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get GitHub Actions cache usage for a repository
                ActionsCacheUsageByRepository result = apiInstance.ActionsGetActionsCacheUsage(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetActionsCacheUsage: " + e.Message );
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

[**ActionsCacheUsageByRepository**](ActionsCacheUsageByRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetactionscacheusagebyrepofororg"></a>
# **ActionsGetActionsCacheUsageByRepoForOrg**
> ActionsGetActionsCacheUsageByRepoForOrg200Response ActionsGetActionsCacheUsageByRepoForOrg (string org, int? perPage, int? page)

List repositories with GitHub Actions cache usage for an organization

Lists repositories and their GitHub Actions cache usage for an organization. The data fetched using this API is refreshed approximately every 5 minutes, so values returned from this endpoint may take at least 5 minutes to get updated. You must authenticate using an access token with the `read:org` scope to use this endpoint. GitHub Apps must have the `organization_admistration:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetActionsCacheUsageByRepoForOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repositories with GitHub Actions cache usage for an organization
                ActionsGetActionsCacheUsageByRepoForOrg200Response result = apiInstance.ActionsGetActionsCacheUsageByRepoForOrg(org, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetActionsCacheUsageByRepoForOrg: " + e.Message );
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

[**ActionsGetActionsCacheUsageByRepoForOrg200Response**](ActionsGetActionsCacheUsageByRepoForOrg200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetactionscacheusageforenterprise"></a>
# **ActionsGetActionsCacheUsageForEnterprise**
> ActionsGetActionsCacheUsageForEnterprise200Response ActionsGetActionsCacheUsageForEnterprise (string enterprise)

Get GitHub Actions cache usage for an enterprise

Gets the total GitHub Actions cache usage for an enterprise. The data fetched using this API is refreshed approximately every 5 minutes, so values returned from this endpoint may take at least 5 minutes to get updated. You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetActionsCacheUsageForEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.

            try
            {
                // Get GitHub Actions cache usage for an enterprise
                ActionsGetActionsCacheUsageForEnterprise200Response result = apiInstance.ActionsGetActionsCacheUsageForEnterprise(enterprise);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetActionsCacheUsageForEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 

### Return type

[**ActionsGetActionsCacheUsageForEnterprise200Response**](ActionsGetActionsCacheUsageForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetactionscacheusagefororg"></a>
# **ActionsGetActionsCacheUsageForOrg**
> ActionsGetActionsCacheUsageForEnterprise200Response ActionsGetActionsCacheUsageForOrg (string org)

Get GitHub Actions cache usage for an organization

Gets the total GitHub Actions cache usage for an organization. The data fetched using this API is refreshed approximately every 5 minutes, so values returned from this endpoint may take at least 5 minutes to get updated. You must authenticate using an access token with the `read:org` scope to use this endpoint. GitHub Apps must have the `organization_admistration:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetActionsCacheUsageForOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.

            try
            {
                // Get GitHub Actions cache usage for an organization
                ActionsGetActionsCacheUsageForEnterprise200Response result = apiInstance.ActionsGetActionsCacheUsageForOrg(org);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetActionsCacheUsageForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 

### Return type

[**ActionsGetActionsCacheUsageForEnterprise200Response**](ActionsGetActionsCacheUsageForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetallowedactionsorganization"></a>
# **ActionsGetAllowedActionsOrganization**
> EnterpriseAdminGetAllowedActionsEnterprise200Response ActionsGetAllowedActionsOrganization (string org)

Get allowed actions and reusable workflows for an organization

Gets the selected actions and reusable workflows that are allowed in an organization. To use this endpoint, the organization permission policy for `allowed_actions` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\"\"  You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `administration` organization permission to use this API.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetAllowedActionsOrganizationExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.

            try
            {
                // Get allowed actions and reusable workflows for an organization
                EnterpriseAdminGetAllowedActionsEnterprise200Response result = apiInstance.ActionsGetAllowedActionsOrganization(org);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetAllowedActionsOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 

### Return type

[**EnterpriseAdminGetAllowedActionsEnterprise200Response**](EnterpriseAdminGetAllowedActionsEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetallowedactionsrepository"></a>
# **ActionsGetAllowedActionsRepository**
> EnterpriseAdminGetAllowedActionsEnterprise200Response ActionsGetAllowedActionsRepository (string owner, string repo)

Get allowed actions and reusable workflows for a repository

Gets the settings for selected actions and reusable workflows that are allowed in a repository. To use this endpoint, the repository policy for `allowed_actions` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for a repository](#set-github-actions-permissions-for-a-repository).\"  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `administration` repository permission to use this API.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetAllowedActionsRepositoryExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get allowed actions and reusable workflows for a repository
                EnterpriseAdminGetAllowedActionsEnterprise200Response result = apiInstance.ActionsGetAllowedActionsRepository(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetAllowedActionsRepository: " + e.Message );
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

[**EnterpriseAdminGetAllowedActionsEnterprise200Response**](EnterpriseAdminGetAllowedActionsEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetartifact"></a>
# **ActionsGetArtifact**
> Artifact ActionsGetArtifact (string owner, string repo, int? artifactId)

Get an artifact

Gets a specific artifact for a workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetArtifactExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var artifactId = 56;  // int? | The unique identifier of the artifact.

            try
            {
                // Get an artifact
                Artifact result = apiInstance.ActionsGetArtifact(owner, repo, artifactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetArtifact: " + e.Message );
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
 **artifactId** | **int?**| The unique identifier of the artifact. | 

### Return type

[**Artifact**](Artifact.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetcustomoidcsubclaimforrepo"></a>
# **ActionsGetCustomOidcSubClaimForRepo**
> TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization ActionsGetCustomOidcSubClaimForRepo (string owner, string repo)

Get the opt-out flag of an OIDC subject claim customization for a repository

Gets the `opt-out` flag of a GitHub Actions OpenID Connect (OIDC) subject claim customization for a repository. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `organization_administration:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetCustomOidcSubClaimForRepoExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get the opt-out flag of an OIDC subject claim customization for a repository
                TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization result = apiInstance.ActionsGetCustomOidcSubClaimForRepo(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetCustomOidcSubClaimForRepo: " + e.Message );
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

[**TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization**](TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/scim+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetenvironmentpublickey"></a>
# **ActionsGetEnvironmentPublicKey**
> ActionsPublicKey ActionsGetEnvironmentPublicKey (int? repositoryId, string environmentName)

Get an environment public key

Get the public key for an environment, which you need to encrypt environment secrets. You need to encrypt a secret before you can create or update secrets. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `secrets` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetEnvironmentPublicKeyExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var repositoryId = 56;  // int? | The unique identifier of the repository.
            var environmentName = "environmentName_example";  // string | The name of the environment

            try
            {
                // Get an environment public key
                ActionsPublicKey result = apiInstance.ActionsGetEnvironmentPublicKey(repositoryId, environmentName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetEnvironmentPublicKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryId** | **int?**| The unique identifier of the repository. | 
 **environmentName** | **string**| The name of the environment | 

### Return type

[**ActionsPublicKey**](ActionsPublicKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetenvironmentsecret"></a>
# **ActionsGetEnvironmentSecret**
> ActionsSecret ActionsGetEnvironmentSecret (int? repositoryId, string environmentName, string secretName)

Get an environment secret

Gets a single environment secret without revealing its encrypted value. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `secrets` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetEnvironmentSecretExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var repositoryId = 56;  // int? | The unique identifier of the repository.
            var environmentName = "environmentName_example";  // string | The name of the environment
            var secretName = "secretName_example";  // string | The name of the secret.

            try
            {
                // Get an environment secret
                ActionsSecret result = apiInstance.ActionsGetEnvironmentSecret(repositoryId, environmentName, secretName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetEnvironmentSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryId** | **int?**| The unique identifier of the repository. | 
 **environmentName** | **string**| The name of the environment | 
 **secretName** | **string**| The name of the secret. | 

### Return type

[**ActionsSecret**](ActionsSecret.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetgithubactionsdefaultworkflowpermissionsenterprise"></a>
# **ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise**
> ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise (string enterprise)

Get default workflow permissions for an enterprise

Gets the default workflow permissions granted to the `GITHUB_TOKEN` when running workflows in an enterprise, as well as whether GitHub Actions can submit approving pull request reviews. For more information, see \"[Enforcing a policy for workflow permissions in your enterprise](https://docs.github.com/enterprise-cloud@latest/admin/policies/enforcing-policies-for-your-enterprise/enforcing-policies-for-github-actions-in-your-enterprise#enforcing-a-policy-for-workflow-permissions-in-your-enterprise).\"  You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint. GitHub Apps must have the `enterprise_administration:write` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetGithubActionsDefaultWorkflowPermissionsEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.

            try
            {
                // Get default workflow permissions for an enterprise
                ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response result = apiInstance.ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise(enterprise);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 

### Return type

[**ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response**](ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetgithubactionsdefaultworkflowpermissionsorganization"></a>
# **ActionsGetGithubActionsDefaultWorkflowPermissionsOrganization**
> ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response ActionsGetGithubActionsDefaultWorkflowPermissionsOrganization (string org)

Get default workflow permissions for an organization

Gets the default workflow permissions granted to the `GITHUB_TOKEN` when running workflows in an organization, as well as whether GitHub Actions can submit approving pull request reviews. For more information, see \"[Setting the permissions of the GITHUB_TOKEN for your organization](https://docs.github.com/organizations/managing-organization-settings/disabling-or-limiting-github-actions-for-your-organization#setting-the-permissions-of-the-github_token-for-your-organization).\"  You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `administration` organization permission to use this API.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetGithubActionsDefaultWorkflowPermissionsOrganizationExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.

            try
            {
                // Get default workflow permissions for an organization
                ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response result = apiInstance.ActionsGetGithubActionsDefaultWorkflowPermissionsOrganization(org);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetGithubActionsDefaultWorkflowPermissionsOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 

### Return type

[**ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response**](ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetgithubactionsdefaultworkflowpermissionsrepository"></a>
# **ActionsGetGithubActionsDefaultWorkflowPermissionsRepository**
> ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response ActionsGetGithubActionsDefaultWorkflowPermissionsRepository (string owner, string repo)

Get default workflow permissions for a repository

Gets the default workflow permissions granted to the `GITHUB_TOKEN` when running workflows in a repository, as well as if GitHub Actions can submit approving pull request reviews. For more information, see \"[Setting the permissions of the GITHUB_TOKEN for your repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#setting-the-permissions-of-the-github_token-for-your-repository).\"  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the repository `administration` permission to use this API.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetGithubActionsDefaultWorkflowPermissionsRepositoryExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get default workflow permissions for a repository
                ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response result = apiInstance.ActionsGetGithubActionsDefaultWorkflowPermissionsRepository(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetGithubActionsDefaultWorkflowPermissionsRepository: " + e.Message );
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

[**ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response**](ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetgithubactionspermissionsorganization"></a>
# **ActionsGetGithubActionsPermissionsOrganization**
> ActionsGetGithubActionsPermissionsOrganization200Response ActionsGetGithubActionsPermissionsOrganization (string org)

Get GitHub Actions permissions for an organization

Gets the GitHub Actions permissions policy for repositories and allowed actions and reusable workflows in an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `administration` organization permission to use this API.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetGithubActionsPermissionsOrganizationExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.

            try
            {
                // Get GitHub Actions permissions for an organization
                ActionsGetGithubActionsPermissionsOrganization200Response result = apiInstance.ActionsGetGithubActionsPermissionsOrganization(org);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetGithubActionsPermissionsOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 

### Return type

[**ActionsGetGithubActionsPermissionsOrganization200Response**](ActionsGetGithubActionsPermissionsOrganization200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetgithubactionspermissionsrepository"></a>
# **ActionsGetGithubActionsPermissionsRepository**
> ActionsGetGithubActionsPermissionsRepository200Response ActionsGetGithubActionsPermissionsRepository (string owner, string repo)

Get GitHub Actions permissions for a repository

Gets the GitHub Actions permissions policy for a repository, including whether GitHub Actions is enabled and the actions and reusable workflows allowed to run in the repository.  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `administration` repository permission to use this API.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetGithubActionsPermissionsRepositoryExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get GitHub Actions permissions for a repository
                ActionsGetGithubActionsPermissionsRepository200Response result = apiInstance.ActionsGetGithubActionsPermissionsRepository(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetGithubActionsPermissionsRepository: " + e.Message );
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

[**ActionsGetGithubActionsPermissionsRepository200Response**](ActionsGetGithubActionsPermissionsRepository200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetjobforworkflowrun"></a>
# **ActionsGetJobForWorkflowRun**
> Job ActionsGetJobForWorkflowRun (string owner, string repo, int? jobId)

Get a job for a workflow run

Gets a specific job in a workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetJobForWorkflowRunExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var jobId = 56;  // int? | The unique identifier of the job.

            try
            {
                // Get a job for a workflow run
                Job result = apiInstance.ActionsGetJobForWorkflowRun(owner, repo, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetJobForWorkflowRun: " + e.Message );
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
 **jobId** | **int?**| The unique identifier of the job. | 

### Return type

[**Job**](Job.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetorgpublickey"></a>
# **ActionsGetOrgPublicKey**
> ActionsPublicKey ActionsGetOrgPublicKey (string org)

Get an organization public key

Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets. You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `secrets` organization permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetOrgPublicKeyExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.

            try
            {
                // Get an organization public key
                ActionsPublicKey result = apiInstance.ActionsGetOrgPublicKey(org);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetOrgPublicKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 

### Return type

[**ActionsPublicKey**](ActionsPublicKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetorgsecret"></a>
# **ActionsGetOrgSecret**
> ActionsSecretForAnOrganization ActionsGetOrgSecret (string org, string secretName)

Get an organization secret

Gets a single organization secret without revealing its encrypted value. You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `secrets` organization permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetOrgSecretExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.

            try
            {
                // Get an organization secret
                ActionsSecretForAnOrganization result = apiInstance.ActionsGetOrgSecret(org, secretName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetOrgSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **secretName** | **string**| The name of the secret. | 

### Return type

[**ActionsSecretForAnOrganization**](ActionsSecretForAnOrganization.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetpendingdeploymentsforrun"></a>
# **ActionsGetPendingDeploymentsForRun**
> List<PendingDeployment> ActionsGetPendingDeploymentsForRun (string owner, string repo, int? runId)

Get pending deployments for a workflow run

Get all deployment environments for a workflow run that are waiting for protection rules to pass.  Anyone with read access to the repository can use this endpoint. If the repository is private, you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetPendingDeploymentsForRunExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runId = 56;  // int? | The unique identifier of the workflow run.

            try
            {
                // Get pending deployments for a workflow run
                List&lt;PendingDeployment&gt; result = apiInstance.ActionsGetPendingDeploymentsForRun(owner, repo, runId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetPendingDeploymentsForRun: " + e.Message );
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
 **runId** | **int?**| The unique identifier of the workflow run. | 

### Return type

[**List<PendingDeployment>**](PendingDeployment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetrepopublickey"></a>
# **ActionsGetRepoPublicKey**
> ActionsPublicKey ActionsGetRepoPublicKey (string owner, string repo)

Get a repository public key

Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `secrets` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetRepoPublicKeyExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get a repository public key
                ActionsPublicKey result = apiInstance.ActionsGetRepoPublicKey(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetRepoPublicKey: " + e.Message );
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

[**ActionsPublicKey**](ActionsPublicKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetreposecret"></a>
# **ActionsGetRepoSecret**
> ActionsSecret ActionsGetRepoSecret (string owner, string repo, string secretName)

Get a repository secret

Gets a single repository secret without revealing its encrypted value. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `secrets` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetRepoSecretExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.

            try
            {
                // Get a repository secret
                ActionsSecret result = apiInstance.ActionsGetRepoSecret(owner, repo, secretName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetRepoSecret: " + e.Message );
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
 **secretName** | **string**| The name of the secret. | 

### Return type

[**ActionsSecret**](ActionsSecret.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetreviewsforrun"></a>
# **ActionsGetReviewsForRun**
> List<EnvironmentApproval> ActionsGetReviewsForRun (string owner, string repo, int? runId)

Get the review history for a workflow run

Anyone with read access to the repository can use this endpoint. If the repository is private, you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetReviewsForRunExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runId = 56;  // int? | The unique identifier of the workflow run.

            try
            {
                // Get the review history for a workflow run
                List&lt;EnvironmentApproval&gt; result = apiInstance.ActionsGetReviewsForRun(owner, repo, runId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetReviewsForRun: " + e.Message );
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
 **runId** | **int?**| The unique identifier of the workflow run. | 

### Return type

[**List<EnvironmentApproval>**](EnvironmentApproval.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetselfhostedrunnerfororg"></a>
# **ActionsGetSelfHostedRunnerForOrg**
> SelfHostedRunners ActionsGetSelfHostedRunnerForOrg (string org, int? runnerId)

Get a self-hosted runner for an organization

Gets a specific self-hosted runner configured in an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetSelfHostedRunnerForOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.

            try
            {
                // Get a self-hosted runner for an organization
                SelfHostedRunners result = apiInstance.ActionsGetSelfHostedRunnerForOrg(org, runnerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetSelfHostedRunnerForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 

### Return type

[**SelfHostedRunners**](SelfHostedRunners.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetselfhostedrunnerforrepo"></a>
# **ActionsGetSelfHostedRunnerForRepo**
> SelfHostedRunners ActionsGetSelfHostedRunnerForRepo (string owner, string repo, int? runnerId)

Get a self-hosted runner for a repository

Gets a specific self-hosted runner configured in a repository.  You must authenticate using an access token with the `repo` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetSelfHostedRunnerForRepoExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.

            try
            {
                // Get a self-hosted runner for a repository
                SelfHostedRunners result = apiInstance.ActionsGetSelfHostedRunnerForRepo(owner, repo, runnerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetSelfHostedRunnerForRepo: " + e.Message );
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
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 

### Return type

[**SelfHostedRunners**](SelfHostedRunners.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetselfhostedrunnergroupfororg"></a>
# **ActionsGetSelfHostedRunnerGroupForOrg**
> ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner ActionsGetSelfHostedRunnerGroupForOrg (string org, int? runnerGroupId)

Get a self-hosted runner group for an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"  Gets a specific self-hosted runner group for an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetSelfHostedRunnerGroupForOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var runnerGroupId = 56;  // int? | Unique identifier of the self-hosted runner group.

            try
            {
                // Get a self-hosted runner group for an organization
                ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner result = apiInstance.ActionsGetSelfHostedRunnerGroupForOrg(org, runnerGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetSelfHostedRunnerGroupForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **runnerGroupId** | **int?**| Unique identifier of the self-hosted runner group. | 

### Return type

[**ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner**](ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetworkflow"></a>
# **ActionsGetWorkflow**
> Workflow ActionsGetWorkflow (string owner, string repo, ActionsGetWorkflowWorkflowIdParameter workflowId)

Get a workflow

Gets a specific workflow. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetWorkflowExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var workflowId = new ActionsGetWorkflowWorkflowIdParameter(); // ActionsGetWorkflowWorkflowIdParameter | The ID of the workflow. You can also pass the workflow file name as a string.

            try
            {
                // Get a workflow
                Workflow result = apiInstance.ActionsGetWorkflow(owner, repo, workflowId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetWorkflow: " + e.Message );
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
 **workflowId** | [**ActionsGetWorkflowWorkflowIdParameter**](.md)| The ID of the workflow. You can also pass the workflow file name as a string. | 

### Return type

[**Workflow**](Workflow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetworkflowaccesstorepository"></a>
# **ActionsGetWorkflowAccessToRepository**
> ActionsGetWorkflowAccessToRepository200Response ActionsGetWorkflowAccessToRepository (string owner, string repo)

Get the level of access for workflows outside of the repository

Gets the level of access that workflows outside of the repository have to actions and reusable workflows in the repository. This endpoint only applies to internal repositories. For more information, see \"[Managing GitHub Actions settings for a repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#allowing-access-to-components-in-an-internal-repository).\"  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the repository `administration` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetWorkflowAccessToRepositoryExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get the level of access for workflows outside of the repository
                ActionsGetWorkflowAccessToRepository200Response result = apiInstance.ActionsGetWorkflowAccessToRepository(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetWorkflowAccessToRepository: " + e.Message );
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

[**ActionsGetWorkflowAccessToRepository200Response**](ActionsGetWorkflowAccessToRepository200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetworkflowrun"></a>
# **ActionsGetWorkflowRun**
> WorkflowRun ActionsGetWorkflowRun (string owner, string repo, int? runId, bool? excludePullRequests)

Get a workflow run

Gets a specific workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetWorkflowRunExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runId = 56;  // int? | The unique identifier of the workflow run.
            var excludePullRequests = false;  // bool? | If `true` pull requests are omitted from the response (empty array). (optional)  (default to false)

            try
            {
                // Get a workflow run
                WorkflowRun result = apiInstance.ActionsGetWorkflowRun(owner, repo, runId, excludePullRequests);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetWorkflowRun: " + e.Message );
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
 **runId** | **int?**| The unique identifier of the workflow run. | 
 **excludePullRequests** | **bool?**| If &#x60;true&#x60; pull requests are omitted from the response (empty array). | [optional] [default to false]

### Return type

[**WorkflowRun**](WorkflowRun.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetworkflowrunattempt"></a>
# **ActionsGetWorkflowRunAttempt**
> WorkflowRun ActionsGetWorkflowRunAttempt (string owner, string repo, int? runId, int? attemptNumber, bool? excludePullRequests)

Get a workflow run attempt

Gets a specific workflow run attempt. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetWorkflowRunAttemptExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runId = 56;  // int? | The unique identifier of the workflow run.
            var attemptNumber = 56;  // int? | The attempt number of the workflow run.
            var excludePullRequests = false;  // bool? | If `true` pull requests are omitted from the response (empty array). (optional)  (default to false)

            try
            {
                // Get a workflow run attempt
                WorkflowRun result = apiInstance.ActionsGetWorkflowRunAttempt(owner, repo, runId, attemptNumber, excludePullRequests);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetWorkflowRunAttempt: " + e.Message );
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
 **runId** | **int?**| The unique identifier of the workflow run. | 
 **attemptNumber** | **int?**| The attempt number of the workflow run. | 
 **excludePullRequests** | **bool?**| If &#x60;true&#x60; pull requests are omitted from the response (empty array). | [optional] [default to false]

### Return type

[**WorkflowRun**](WorkflowRun.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetworkflowrunusage"></a>
# **ActionsGetWorkflowRunUsage**
> WorkflowRunUsage ActionsGetWorkflowRunUsage (string owner, string repo, int? runId)

Get workflow run usage

Gets the number of billable minutes and total run time for a specific workflow run. Billable minutes only apply to workflows in private repositories that use GitHub-hosted runners. Usage is listed for each GitHub-hosted runner operating system in milliseconds. Any job re-runs are also included in the usage. The usage does not include the multiplier for macOS and Windows runners and is not rounded up to the nearest whole minute. For more information, see \"[Managing billing for GitHub Actions](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-actions)\".  Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetWorkflowRunUsageExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runId = 56;  // int? | The unique identifier of the workflow run.

            try
            {
                // Get workflow run usage
                WorkflowRunUsage result = apiInstance.ActionsGetWorkflowRunUsage(owner, repo, runId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetWorkflowRunUsage: " + e.Message );
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
 **runId** | **int?**| The unique identifier of the workflow run. | 

### Return type

[**WorkflowRunUsage**](WorkflowRunUsage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsgetworkflowusage"></a>
# **ActionsGetWorkflowUsage**
> WorkflowUsage ActionsGetWorkflowUsage (string owner, string repo, ActionsGetWorkflowWorkflowIdParameter workflowId)

Get workflow usage

Gets the number of billable minutes used by a specific workflow during the current billing cycle. Billable minutes only apply to workflows in private repositories that use GitHub-hosted runners. Usage is listed for each GitHub-hosted runner operating system in milliseconds. Any job re-runs are also included in the usage. The usage does not include the multiplier for macOS and Windows runners and is not rounded up to the nearest whole minute. For more information, see \"[Managing billing for GitHub Actions](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-actions)\".  You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsGetWorkflowUsageExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var workflowId = new ActionsGetWorkflowWorkflowIdParameter(); // ActionsGetWorkflowWorkflowIdParameter | The ID of the workflow. You can also pass the workflow file name as a string.

            try
            {
                // Get workflow usage
                WorkflowUsage result = apiInstance.ActionsGetWorkflowUsage(owner, repo, workflowId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsGetWorkflowUsage: " + e.Message );
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
 **workflowId** | [**ActionsGetWorkflowWorkflowIdParameter**](.md)| The ID of the workflow. You can also pass the workflow file name as a string. | 

### Return type

[**WorkflowUsage**](WorkflowUsage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionslistartifactsforrepo"></a>
# **ActionsListArtifactsForRepo**
> ActionsListArtifactsForRepo200Response ActionsListArtifactsForRepo (string owner, string repo, int? perPage, int? page)

List artifacts for a repository

Lists all artifacts for a repository. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsListArtifactsForRepoExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List artifacts for a repository
                ActionsListArtifactsForRepo200Response result = apiInstance.ActionsListArtifactsForRepo(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsListArtifactsForRepo: " + e.Message );
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

[**ActionsListArtifactsForRepo200Response**](ActionsListArtifactsForRepo200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionslistenvironmentsecrets"></a>
# **ActionsListEnvironmentSecrets**
> ActionsListRepoSecrets200Response ActionsListEnvironmentSecrets (int? repositoryId, string environmentName, int? perPage, int? page)

List environment secrets

Lists all secrets available in an environment without revealing their encrypted values. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `secrets` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsListEnvironmentSecretsExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var repositoryId = 56;  // int? | The unique identifier of the repository.
            var environmentName = "environmentName_example";  // string | The name of the environment
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List environment secrets
                ActionsListRepoSecrets200Response result = apiInstance.ActionsListEnvironmentSecrets(repositoryId, environmentName, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsListEnvironmentSecrets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryId** | **int?**| The unique identifier of the repository. | 
 **environmentName** | **string**| The name of the environment | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**ActionsListRepoSecrets200Response**](ActionsListRepoSecrets200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionslistjobsforworkflowrun"></a>
# **ActionsListJobsForWorkflowRun**
> ActionsListJobsForWorkflowRunAttempt200Response ActionsListJobsForWorkflowRun (string owner, string repo, int? runId, string filter, int? perPage, int? page)

List jobs for a workflow run

Lists jobs for a workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/overview/resources-in-the-rest-api#parameters).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsListJobsForWorkflowRunExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runId = 56;  // int? | The unique identifier of the workflow run.
            var filter = "latest";  // string | Filters jobs by their `completed_at` timestamp. `latest` returns jobs from the most recent execution of the workflow run. `all` returns all jobs for a workflow run, including from old executions of the workflow run. (optional)  (default to latest)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List jobs for a workflow run
                ActionsListJobsForWorkflowRunAttempt200Response result = apiInstance.ActionsListJobsForWorkflowRun(owner, repo, runId, filter, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsListJobsForWorkflowRun: " + e.Message );
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
 **runId** | **int?**| The unique identifier of the workflow run. | 
 **filter** | **string**| Filters jobs by their &#x60;completed_at&#x60; timestamp. &#x60;latest&#x60; returns jobs from the most recent execution of the workflow run. &#x60;all&#x60; returns all jobs for a workflow run, including from old executions of the workflow run. | [optional] [default to latest]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**ActionsListJobsForWorkflowRunAttempt200Response**](ActionsListJobsForWorkflowRunAttempt200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionslistjobsforworkflowrunattempt"></a>
# **ActionsListJobsForWorkflowRunAttempt**
> ActionsListJobsForWorkflowRunAttempt200Response ActionsListJobsForWorkflowRunAttempt (string owner, string repo, int? runId, int? attemptNumber, int? perPage, int? page)

List jobs for a workflow run attempt

Lists jobs for a specific workflow run attempt. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/overview/resources-in-the-rest-api#parameters).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsListJobsForWorkflowRunAttemptExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runId = 56;  // int? | The unique identifier of the workflow run.
            var attemptNumber = 56;  // int? | The attempt number of the workflow run.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List jobs for a workflow run attempt
                ActionsListJobsForWorkflowRunAttempt200Response result = apiInstance.ActionsListJobsForWorkflowRunAttempt(owner, repo, runId, attemptNumber, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsListJobsForWorkflowRunAttempt: " + e.Message );
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
 **runId** | **int?**| The unique identifier of the workflow run. | 
 **attemptNumber** | **int?**| The attempt number of the workflow run. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**ActionsListJobsForWorkflowRunAttempt200Response**](ActionsListJobsForWorkflowRunAttempt200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionslistlabelsforselfhostedrunnerfororg"></a>
# **ActionsListLabelsForSelfHostedRunnerForOrg**
> EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsListLabelsForSelfHostedRunnerForOrg (string org, int? runnerId)

List labels for a self-hosted runner for an organization

Lists all labels for a self-hosted runner configured in an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsListLabelsForSelfHostedRunnerForOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.

            try
            {
                // List labels for a self-hosted runner for an organization
                EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response result = apiInstance.ActionsListLabelsForSelfHostedRunnerForOrg(org, runnerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsListLabelsForSelfHostedRunnerForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionslistlabelsforselfhostedrunnerforrepo"></a>
# **ActionsListLabelsForSelfHostedRunnerForRepo**
> EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsListLabelsForSelfHostedRunnerForRepo (string owner, string repo, int? runnerId)

List labels for a self-hosted runner for a repository

Lists all labels for a self-hosted runner configured in a repository.  You must authenticate using an access token with the `repo` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsListLabelsForSelfHostedRunnerForRepoExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.

            try
            {
                // List labels for a self-hosted runner for a repository
                EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response result = apiInstance.ActionsListLabelsForSelfHostedRunnerForRepo(owner, repo, runnerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsListLabelsForSelfHostedRunnerForRepo: " + e.Message );
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
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionslistorgsecrets"></a>
# **ActionsListOrgSecrets**
> ActionsListOrgSecrets200Response ActionsListOrgSecrets (string org, int? perPage, int? page)

List organization secrets

Lists all secrets available in an organization without revealing their encrypted values. You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `secrets` organization permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsListOrgSecretsExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List organization secrets
                ActionsListOrgSecrets200Response result = apiInstance.ActionsListOrgSecrets(org, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsListOrgSecrets: " + e.Message );
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

[**ActionsListOrgSecrets200Response**](ActionsListOrgSecrets200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionslistrepoaccesstoselfhostedrunnergroupinorg"></a>
# **ActionsListRepoAccessToSelfHostedRunnerGroupInOrg**
> ActionsListRepoAccessToSelfHostedRunnerGroupInOrg200Response ActionsListRepoAccessToSelfHostedRunnerGroupInOrg (string org, int? runnerGroupId, int? page, int? perPage)

List repository access to a self-hosted runner group in an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud and GitHub Enterprise Server. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"  Lists the repositories with access to a self-hosted runner group configured in an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsListRepoAccessToSelfHostedRunnerGroupInOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var runnerGroupId = 56;  // int? | Unique identifier of the self-hosted runner group.
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)

            try
            {
                // List repository access to a self-hosted runner group in an organization
                ActionsListRepoAccessToSelfHostedRunnerGroupInOrg200Response result = apiInstance.ActionsListRepoAccessToSelfHostedRunnerGroupInOrg(org, runnerGroupId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsListRepoAccessToSelfHostedRunnerGroupInOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **runnerGroupId** | **int?**| Unique identifier of the self-hosted runner group. | 
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]

### Return type

[**ActionsListRepoAccessToSelfHostedRunnerGroupInOrg200Response**](ActionsListRepoAccessToSelfHostedRunnerGroupInOrg200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionslistreposecrets"></a>
# **ActionsListRepoSecrets**
> ActionsListRepoSecrets200Response ActionsListRepoSecrets (string owner, string repo, int? perPage, int? page)

List repository secrets

Lists all secrets available in a repository without revealing their encrypted values. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `secrets` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsListRepoSecretsExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repository secrets
                ActionsListRepoSecrets200Response result = apiInstance.ActionsListRepoSecrets(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsListRepoSecrets: " + e.Message );
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

[**ActionsListRepoSecrets200Response**](ActionsListRepoSecrets200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionslistrepoworkflows"></a>
# **ActionsListRepoWorkflows**
> ActionsListRepoWorkflows200Response ActionsListRepoWorkflows (string owner, string repo, int? perPage, int? page)

List repository workflows

Lists the workflows in a repository. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsListRepoWorkflowsExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repository workflows
                ActionsListRepoWorkflows200Response result = apiInstance.ActionsListRepoWorkflows(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsListRepoWorkflows: " + e.Message );
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

[**ActionsListRepoWorkflows200Response**](ActionsListRepoWorkflows200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionslistrunnerapplicationsfororg"></a>
# **ActionsListRunnerApplicationsForOrg**
> List<RunnerApplication> ActionsListRunnerApplicationsForOrg (string org)

List runner applications for an organization

Lists binaries for the runner application that you can download and run.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsListRunnerApplicationsForOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.

            try
            {
                // List runner applications for an organization
                List&lt;RunnerApplication&gt; result = apiInstance.ActionsListRunnerApplicationsForOrg(org);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsListRunnerApplicationsForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 

### Return type

[**List<RunnerApplication>**](RunnerApplication.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionslistrunnerapplicationsforrepo"></a>
# **ActionsListRunnerApplicationsForRepo**
> List<RunnerApplication> ActionsListRunnerApplicationsForRepo (string owner, string repo)

List runner applications for a repository

Lists binaries for the runner application that you can download and run.  You must authenticate using an access token with the `repo` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsListRunnerApplicationsForRepoExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // List runner applications for a repository
                List&lt;RunnerApplication&gt; result = apiInstance.ActionsListRunnerApplicationsForRepo(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsListRunnerApplicationsForRepo: " + e.Message );
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

[**List<RunnerApplication>**](RunnerApplication.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionslistselectedreposfororgsecret"></a>
# **ActionsListSelectedReposForOrgSecret**
> ActionsListSelectedReposForOrgSecret200Response ActionsListSelectedReposForOrgSecret (string org, string secretName, int? page, int? perPage)

List selected repositories for an organization secret

Lists all repositories that have been selected when the `visibility` for repository access to a secret is set to `selected`. You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `secrets` organization permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsListSelectedReposForOrgSecretExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)

            try
            {
                // List selected repositories for an organization secret
                ActionsListSelectedReposForOrgSecret200Response result = apiInstance.ActionsListSelectedReposForOrgSecret(org, secretName, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsListSelectedReposForOrgSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **secretName** | **string**| The name of the secret. | 
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]

### Return type

[**ActionsListSelectedReposForOrgSecret200Response**](ActionsListSelectedReposForOrgSecret200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionslistselectedrepositoriesenabledgithubactionsorganization"></a>
# **ActionsListSelectedRepositoriesEnabledGithubActionsOrganization**
> ActionsListSelectedRepositoriesEnabledGithubActionsOrganization200Response ActionsListSelectedRepositoriesEnabledGithubActionsOrganization (string org, int? perPage, int? page)

List selected repositories enabled for GitHub Actions in an organization

Lists the selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for `enabled_repositories` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\"  You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `administration` organization permission to use this API.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsListSelectedRepositoriesEnabledGithubActionsOrganizationExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List selected repositories enabled for GitHub Actions in an organization
                ActionsListSelectedRepositoriesEnabledGithubActionsOrganization200Response result = apiInstance.ActionsListSelectedRepositoriesEnabledGithubActionsOrganization(org, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsListSelectedRepositoriesEnabledGithubActionsOrganization: " + e.Message );
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

[**ActionsListSelectedRepositoriesEnabledGithubActionsOrganization200Response**](ActionsListSelectedRepositoriesEnabledGithubActionsOrganization200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionslistselfhostedrunnergroupsfororg"></a>
# **ActionsListSelfHostedRunnerGroupsForOrg**
> ActionsListSelfHostedRunnerGroupsForOrg200Response ActionsListSelfHostedRunnerGroupsForOrg (string org, int? perPage, int? page, string visibleToRepository)

List self-hosted runner groups for an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"  Lists all self-hosted runner groups configured in an organization and inherited from an enterprise.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsListSelfHostedRunnerGroupsForOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var visibleToRepository = "visibleToRepository_example";  // string | Only return runner groups that are allowed to be used by this repository. (optional) 

            try
            {
                // List self-hosted runner groups for an organization
                ActionsListSelfHostedRunnerGroupsForOrg200Response result = apiInstance.ActionsListSelfHostedRunnerGroupsForOrg(org, perPage, page, visibleToRepository);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsListSelfHostedRunnerGroupsForOrg: " + e.Message );
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
 **visibleToRepository** | **string**| Only return runner groups that are allowed to be used by this repository. | [optional] 

### Return type

[**ActionsListSelfHostedRunnerGroupsForOrg200Response**](ActionsListSelfHostedRunnerGroupsForOrg200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionslistselfhostedrunnersfororg"></a>
# **ActionsListSelfHostedRunnersForOrg**
> ActionsListSelfHostedRunnersForOrg200Response ActionsListSelfHostedRunnersForOrg (string org, int? perPage, int? page)

List self-hosted runners for an organization

Lists all self-hosted runners configured in an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsListSelfHostedRunnersForOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List self-hosted runners for an organization
                ActionsListSelfHostedRunnersForOrg200Response result = apiInstance.ActionsListSelfHostedRunnersForOrg(org, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsListSelfHostedRunnersForOrg: " + e.Message );
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

[**ActionsListSelfHostedRunnersForOrg200Response**](ActionsListSelfHostedRunnersForOrg200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionslistselfhostedrunnersforrepo"></a>
# **ActionsListSelfHostedRunnersForRepo**
> ActionsListSelfHostedRunnersForOrg200Response ActionsListSelfHostedRunnersForRepo (string owner, string repo, int? perPage, int? page)

List self-hosted runners for a repository

Lists all self-hosted runners configured in a repository. You must authenticate using an access token with the `repo` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsListSelfHostedRunnersForRepoExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List self-hosted runners for a repository
                ActionsListSelfHostedRunnersForOrg200Response result = apiInstance.ActionsListSelfHostedRunnersForRepo(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsListSelfHostedRunnersForRepo: " + e.Message );
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

[**ActionsListSelfHostedRunnersForOrg200Response**](ActionsListSelfHostedRunnersForOrg200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionslistselfhostedrunnersingroupfororg"></a>
# **ActionsListSelfHostedRunnersInGroupForOrg**
> EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response ActionsListSelfHostedRunnersInGroupForOrg (string org, int? runnerGroupId, int? perPage, int? page)

List self-hosted runners in a group for an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"  Lists self-hosted runners that are in a specific organization group.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsListSelfHostedRunnersInGroupForOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var runnerGroupId = 56;  // int? | Unique identifier of the self-hosted runner group.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List self-hosted runners in a group for an organization
                EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response result = apiInstance.ActionsListSelfHostedRunnersInGroupForOrg(org, runnerGroupId, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsListSelfHostedRunnersInGroupForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **runnerGroupId** | **int?**| Unique identifier of the self-hosted runner group. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response**](EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionslistworkflowrunartifacts"></a>
# **ActionsListWorkflowRunArtifacts**
> ActionsListArtifactsForRepo200Response ActionsListWorkflowRunArtifacts (string owner, string repo, int? runId, int? perPage, int? page)

List workflow run artifacts

Lists artifacts for a workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsListWorkflowRunArtifactsExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runId = 56;  // int? | The unique identifier of the workflow run.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List workflow run artifacts
                ActionsListArtifactsForRepo200Response result = apiInstance.ActionsListWorkflowRunArtifacts(owner, repo, runId, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsListWorkflowRunArtifacts: " + e.Message );
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
 **runId** | **int?**| The unique identifier of the workflow run. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**ActionsListArtifactsForRepo200Response**](ActionsListArtifactsForRepo200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionslistworkflowruns"></a>
# **ActionsListWorkflowRuns**
> ActionsListWorkflowRunsForRepo200Response ActionsListWorkflowRuns (string owner, string repo, ActionsGetWorkflowWorkflowIdParameter workflowId, string actor, string branch, string _event, string status, int? perPage, int? page, DateTime? created, bool? excludePullRequests, int? checkSuiteId)

List workflow runs

List all workflow runs for a workflow. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/overview/resources-in-the-rest-api#parameters).  Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsListWorkflowRunsExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var workflowId = new ActionsGetWorkflowWorkflowIdParameter(); // ActionsGetWorkflowWorkflowIdParameter | The ID of the workflow. You can also pass the workflow file name as a string.
            var actor = "actor_example";  // string | Returns someone's workflow runs. Use the login for the user who created the `push` associated with the check suite or workflow run. (optional) 
            var branch = "branch_example";  // string | Returns workflow runs associated with a branch. Use the name of the branch of the `push`. (optional) 
            var _event = "_event_example";  // string | Returns workflow run triggered by the event you specify. For example, `push`, `pull_request` or `issue`. For more information, see \"[Events that trigger workflows](https://docs.github.com/en/actions/automating-your-workflow-with-github-actions/events-that-trigger-workflows).\" (optional) 
            var status = "completed";  // string | Returns workflow runs with the check run `status` or `conclusion` that you specify. For example, a conclusion can be `success` or a status can be `in_progress`. Only GitHub can set a status of `waiting` or `requested`. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var created = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Returns workflow runs created within the given date-time range. For more information on the syntax, see \"[Understanding the search syntax](https://docs.github.com/search-github/getting-started-with-searching-on-github/understanding-the-search-syntax#query-for-dates).\" (optional) 
            var excludePullRequests = false;  // bool? | If `true` pull requests are omitted from the response (empty array). (optional)  (default to false)
            var checkSuiteId = 56;  // int? | Returns workflow runs with the `check_suite_id` that you specify. (optional) 

            try
            {
                // List workflow runs
                ActionsListWorkflowRunsForRepo200Response result = apiInstance.ActionsListWorkflowRuns(owner, repo, workflowId, actor, branch, _event, status, perPage, page, created, excludePullRequests, checkSuiteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsListWorkflowRuns: " + e.Message );
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
 **workflowId** | [**ActionsGetWorkflowWorkflowIdParameter**](.md)| The ID of the workflow. You can also pass the workflow file name as a string. | 
 **actor** | **string**| Returns someone&#39;s workflow runs. Use the login for the user who created the &#x60;push&#x60; associated with the check suite or workflow run. | [optional] 
 **branch** | **string**| Returns workflow runs associated with a branch. Use the name of the branch of the &#x60;push&#x60;. | [optional] 
 **_event** | **string**| Returns workflow run triggered by the event you specify. For example, &#x60;push&#x60;, &#x60;pull_request&#x60; or &#x60;issue&#x60;. For more information, see \&quot;[Events that trigger workflows](https://docs.github.com/en/actions/automating-your-workflow-with-github-actions/events-that-trigger-workflows).\&quot; | [optional] 
 **status** | **string**| Returns workflow runs with the check run &#x60;status&#x60; or &#x60;conclusion&#x60; that you specify. For example, a conclusion can be &#x60;success&#x60; or a status can be &#x60;in_progress&#x60;. Only GitHub can set a status of &#x60;waiting&#x60; or &#x60;requested&#x60;. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **created** | **DateTime?**| Returns workflow runs created within the given date-time range. For more information on the syntax, see \&quot;[Understanding the search syntax](https://docs.github.com/search-github/getting-started-with-searching-on-github/understanding-the-search-syntax#query-for-dates).\&quot; | [optional] 
 **excludePullRequests** | **bool?**| If &#x60;true&#x60; pull requests are omitted from the response (empty array). | [optional] [default to false]
 **checkSuiteId** | **int?**| Returns workflow runs with the &#x60;check_suite_id&#x60; that you specify. | [optional] 

### Return type

[**ActionsListWorkflowRunsForRepo200Response**](ActionsListWorkflowRunsForRepo200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionslistworkflowrunsforrepo"></a>
# **ActionsListWorkflowRunsForRepo**
> ActionsListWorkflowRunsForRepo200Response ActionsListWorkflowRunsForRepo (string owner, string repo, string actor, string branch, string _event, string status, int? perPage, int? page, DateTime? created, bool? excludePullRequests, int? checkSuiteId)

List workflow runs for a repository

Lists all workflow runs for a repository. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/overview/resources-in-the-rest-api#parameters).  Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsListWorkflowRunsForRepoExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var actor = "actor_example";  // string | Returns someone's workflow runs. Use the login for the user who created the `push` associated with the check suite or workflow run. (optional) 
            var branch = "branch_example";  // string | Returns workflow runs associated with a branch. Use the name of the branch of the `push`. (optional) 
            var _event = "_event_example";  // string | Returns workflow run triggered by the event you specify. For example, `push`, `pull_request` or `issue`. For more information, see \"[Events that trigger workflows](https://docs.github.com/en/actions/automating-your-workflow-with-github-actions/events-that-trigger-workflows).\" (optional) 
            var status = "completed";  // string | Returns workflow runs with the check run `status` or `conclusion` that you specify. For example, a conclusion can be `success` or a status can be `in_progress`. Only GitHub can set a status of `waiting` or `requested`. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var created = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Returns workflow runs created within the given date-time range. For more information on the syntax, see \"[Understanding the search syntax](https://docs.github.com/search-github/getting-started-with-searching-on-github/understanding-the-search-syntax#query-for-dates).\" (optional) 
            var excludePullRequests = false;  // bool? | If `true` pull requests are omitted from the response (empty array). (optional)  (default to false)
            var checkSuiteId = 56;  // int? | Returns workflow runs with the `check_suite_id` that you specify. (optional) 

            try
            {
                // List workflow runs for a repository
                ActionsListWorkflowRunsForRepo200Response result = apiInstance.ActionsListWorkflowRunsForRepo(owner, repo, actor, branch, _event, status, perPage, page, created, excludePullRequests, checkSuiteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsListWorkflowRunsForRepo: " + e.Message );
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
 **actor** | **string**| Returns someone&#39;s workflow runs. Use the login for the user who created the &#x60;push&#x60; associated with the check suite or workflow run. | [optional] 
 **branch** | **string**| Returns workflow runs associated with a branch. Use the name of the branch of the &#x60;push&#x60;. | [optional] 
 **_event** | **string**| Returns workflow run triggered by the event you specify. For example, &#x60;push&#x60;, &#x60;pull_request&#x60; or &#x60;issue&#x60;. For more information, see \&quot;[Events that trigger workflows](https://docs.github.com/en/actions/automating-your-workflow-with-github-actions/events-that-trigger-workflows).\&quot; | [optional] 
 **status** | **string**| Returns workflow runs with the check run &#x60;status&#x60; or &#x60;conclusion&#x60; that you specify. For example, a conclusion can be &#x60;success&#x60; or a status can be &#x60;in_progress&#x60;. Only GitHub can set a status of &#x60;waiting&#x60; or &#x60;requested&#x60;. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **created** | **DateTime?**| Returns workflow runs created within the given date-time range. For more information on the syntax, see \&quot;[Understanding the search syntax](https://docs.github.com/search-github/getting-started-with-searching-on-github/understanding-the-search-syntax#query-for-dates).\&quot; | [optional] 
 **excludePullRequests** | **bool?**| If &#x60;true&#x60; pull requests are omitted from the response (empty array). | [optional] [default to false]
 **checkSuiteId** | **int?**| Returns workflow runs with the &#x60;check_suite_id&#x60; that you specify. | [optional] 

### Return type

[**ActionsListWorkflowRunsForRepo200Response**](ActionsListWorkflowRunsForRepo200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsrerunjobforworkflowrun"></a>
# **ActionsReRunJobForWorkflowRun**
> Object ActionsReRunJobForWorkflowRun (string owner, string repo, int? jobId, ActionsReRunJobForWorkflowRunRequest actionsReRunJobForWorkflowRunRequest)

Re-run a job from a workflow run

Re-run a job and its dependent jobs in a workflow run. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsReRunJobForWorkflowRunExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var jobId = 56;  // int? | The unique identifier of the job.
            var actionsReRunJobForWorkflowRunRequest = new ActionsReRunJobForWorkflowRunRequest(); // ActionsReRunJobForWorkflowRunRequest |  (optional) 

            try
            {
                // Re-run a job from a workflow run
                Object result = apiInstance.ActionsReRunJobForWorkflowRun(owner, repo, jobId, actionsReRunJobForWorkflowRunRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsReRunJobForWorkflowRun: " + e.Message );
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
 **jobId** | **int?**| The unique identifier of the job. | 
 **actionsReRunJobForWorkflowRunRequest** | [**ActionsReRunJobForWorkflowRunRequest**](ActionsReRunJobForWorkflowRunRequest.md)|  | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsrerunworkflow"></a>
# **ActionsReRunWorkflow**
> Object ActionsReRunWorkflow (string owner, string repo, int? runId, ActionsReRunJobForWorkflowRunRequest actionsReRunJobForWorkflowRunRequest)

Re-run a workflow

Re-runs your workflow run using its `id`. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsReRunWorkflowExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runId = 56;  // int? | The unique identifier of the workflow run.
            var actionsReRunJobForWorkflowRunRequest = new ActionsReRunJobForWorkflowRunRequest(); // ActionsReRunJobForWorkflowRunRequest |  (optional) 

            try
            {
                // Re-run a workflow
                Object result = apiInstance.ActionsReRunWorkflow(owner, repo, runId, actionsReRunJobForWorkflowRunRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsReRunWorkflow: " + e.Message );
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
 **runId** | **int?**| The unique identifier of the workflow run. | 
 **actionsReRunJobForWorkflowRunRequest** | [**ActionsReRunJobForWorkflowRunRequest**](ActionsReRunJobForWorkflowRunRequest.md)|  | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsrerunworkflowfailedjobs"></a>
# **ActionsReRunWorkflowFailedJobs**
> Object ActionsReRunWorkflowFailedJobs (string owner, string repo, int? runId, ActionsReRunJobForWorkflowRunRequest actionsReRunJobForWorkflowRunRequest)

Re-run failed jobs from a workflow run

Re-run all of the failed jobs and their dependent jobs in a workflow run using the `id` of the workflow run. You must authenticate using an access token with the `repo` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsReRunWorkflowFailedJobsExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runId = 56;  // int? | The unique identifier of the workflow run.
            var actionsReRunJobForWorkflowRunRequest = new ActionsReRunJobForWorkflowRunRequest(); // ActionsReRunJobForWorkflowRunRequest |  (optional) 

            try
            {
                // Re-run failed jobs from a workflow run
                Object result = apiInstance.ActionsReRunWorkflowFailedJobs(owner, repo, runId, actionsReRunJobForWorkflowRunRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsReRunWorkflowFailedJobs: " + e.Message );
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
 **runId** | **int?**| The unique identifier of the workflow run. | 
 **actionsReRunJobForWorkflowRunRequest** | [**ActionsReRunJobForWorkflowRunRequest**](ActionsReRunJobForWorkflowRunRequest.md)|  | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsremoveallcustomlabelsfromselfhostedrunnerfororg"></a>
# **ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForOrg**
> EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForOrg (string org, int? runnerId)

Remove all custom labels from a self-hosted runner for an organization

Remove all custom labels from a self-hosted runner configured in an organization. Returns the remaining read-only labels from the runner.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.

            try
            {
                // Remove all custom labels from a self-hosted runner for an organization
                EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response result = apiInstance.ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForOrg(org, runnerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsremoveallcustomlabelsfromselfhostedrunnerforrepo"></a>
# **ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepo**
> EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepo (string owner, string repo, int? runnerId)

Remove all custom labels from a self-hosted runner for a repository

Remove all custom labels from a self-hosted runner configured in a repository. Returns the remaining read-only labels from the runner.  You must authenticate using an access token with the `repo` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepoExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.

            try
            {
                // Remove all custom labels from a self-hosted runner for a repository
                EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response result = apiInstance.ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepo(owner, repo, runnerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepo: " + e.Message );
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
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsremovecustomlabelfromselfhostedrunnerfororg"></a>
# **ActionsRemoveCustomLabelFromSelfHostedRunnerForOrg**
> EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsRemoveCustomLabelFromSelfHostedRunnerForOrg (string org, int? runnerId, string name)

Remove a custom label from a self-hosted runner for an organization

Remove a custom label from a self-hosted runner configured in an organization. Returns the remaining labels from the runner.  This endpoint returns a `404 Not Found` status if the custom label is not present on the runner.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsRemoveCustomLabelFromSelfHostedRunnerForOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.
            var name = "name_example";  // string | The name of a self-hosted runner's custom label.

            try
            {
                // Remove a custom label from a self-hosted runner for an organization
                EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response result = apiInstance.ActionsRemoveCustomLabelFromSelfHostedRunnerForOrg(org, runnerId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsRemoveCustomLabelFromSelfHostedRunnerForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 
 **name** | **string**| The name of a self-hosted runner&#39;s custom label. | 

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsremovecustomlabelfromselfhostedrunnerforrepo"></a>
# **ActionsRemoveCustomLabelFromSelfHostedRunnerForRepo**
> EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsRemoveCustomLabelFromSelfHostedRunnerForRepo (string owner, string repo, int? runnerId, string name)

Remove a custom label from a self-hosted runner for a repository

Remove a custom label from a self-hosted runner configured in a repository. Returns the remaining labels from the runner.  This endpoint returns a `404 Not Found` status if the custom label is not present on the runner.  You must authenticate using an access token with the `repo` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsRemoveCustomLabelFromSelfHostedRunnerForRepoExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.
            var name = "name_example";  // string | The name of a self-hosted runner's custom label.

            try
            {
                // Remove a custom label from a self-hosted runner for a repository
                EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response result = apiInstance.ActionsRemoveCustomLabelFromSelfHostedRunnerForRepo(owner, repo, runnerId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsRemoveCustomLabelFromSelfHostedRunnerForRepo: " + e.Message );
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
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 
 **name** | **string**| The name of a self-hosted runner&#39;s custom label. | 

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsremoverepoaccesstoselfhostedrunnergroupinorg"></a>
# **ActionsRemoveRepoAccessToSelfHostedRunnerGroupInOrg**
> void ActionsRemoveRepoAccessToSelfHostedRunnerGroupInOrg (string org, int? runnerGroupId, int? repositoryId)

Remove repository access to a self-hosted runner group in an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"   Removes a repository from the list of selected repositories that can access a self-hosted runner group. The runner group must have `visibility` set to `selected`. For more information, see \"[Create a self-hosted runner group for an organization](#create-a-self-hosted-runner-group-for-an-organization).\"  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsRemoveRepoAccessToSelfHostedRunnerGroupInOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var runnerGroupId = 56;  // int? | Unique identifier of the self-hosted runner group.
            var repositoryId = 56;  // int? | The unique identifier of the repository.

            try
            {
                // Remove repository access to a self-hosted runner group in an organization
                apiInstance.ActionsRemoveRepoAccessToSelfHostedRunnerGroupInOrg(org, runnerGroupId, repositoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsRemoveRepoAccessToSelfHostedRunnerGroupInOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **runnerGroupId** | **int?**| Unique identifier of the self-hosted runner group. | 
 **repositoryId** | **int?**| The unique identifier of the repository. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsremoveselectedrepofromorgsecret"></a>
# **ActionsRemoveSelectedRepoFromOrgSecret**
> void ActionsRemoveSelectedRepoFromOrgSecret (string org, string secretName, int? repositoryId)

Remove selected repository from an organization secret

Removes a repository from an organization secret when the `visibility` for repository access is set to `selected`. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/actions#create-or-update-an-organization-secret). You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `secrets` organization permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsRemoveSelectedRepoFromOrgSecretExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.
            var repositoryId = 56;  // int? | 

            try
            {
                // Remove selected repository from an organization secret
                apiInstance.ActionsRemoveSelectedRepoFromOrgSecret(org, secretName, repositoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsRemoveSelectedRepoFromOrgSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **secretName** | **string**| The name of the secret. | 
 **repositoryId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsremoveselfhostedrunnerfromgroupfororg"></a>
# **ActionsRemoveSelfHostedRunnerFromGroupForOrg**
> void ActionsRemoveSelfHostedRunnerFromGroupForOrg (string org, int? runnerGroupId, int? runnerId)

Remove a self-hosted runner from a group for an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"   Removes a self-hosted runner from a group configured in an organization. The runner is then returned to the default group.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsRemoveSelfHostedRunnerFromGroupForOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var runnerGroupId = 56;  // int? | Unique identifier of the self-hosted runner group.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.

            try
            {
                // Remove a self-hosted runner from a group for an organization
                apiInstance.ActionsRemoveSelfHostedRunnerFromGroupForOrg(org, runnerGroupId, runnerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsRemoveSelfHostedRunnerFromGroupForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **runnerGroupId** | **int?**| Unique identifier of the self-hosted runner group. | 
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsreviewpendingdeploymentsforrun"></a>
# **ActionsReviewPendingDeploymentsForRun**
> List<Deployment> ActionsReviewPendingDeploymentsForRun (string owner, string repo, int? runId, ActionsReviewPendingDeploymentsForRunRequest actionsReviewPendingDeploymentsForRunRequest)

Review pending deployments for a workflow run

Approve or reject pending deployments that are waiting on approval by a required reviewer.  Required reviewers with read access to the repository contents and deployments can use this endpoint. Required reviewers must authenticate using an access token with the `repo` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsReviewPendingDeploymentsForRunExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runId = 56;  // int? | The unique identifier of the workflow run.
            var actionsReviewPendingDeploymentsForRunRequest = new ActionsReviewPendingDeploymentsForRunRequest(); // ActionsReviewPendingDeploymentsForRunRequest | 

            try
            {
                // Review pending deployments for a workflow run
                List&lt;Deployment&gt; result = apiInstance.ActionsReviewPendingDeploymentsForRun(owner, repo, runId, actionsReviewPendingDeploymentsForRunRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsReviewPendingDeploymentsForRun: " + e.Message );
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
 **runId** | **int?**| The unique identifier of the workflow run. | 
 **actionsReviewPendingDeploymentsForRunRequest** | [**ActionsReviewPendingDeploymentsForRunRequest**](ActionsReviewPendingDeploymentsForRunRequest.md)|  | 

### Return type

[**List<Deployment>**](Deployment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionssetactionsoidccustomissuerpolicyforenterprise"></a>
# **ActionsSetActionsOidcCustomIssuerPolicyForEnterprise**
> void ActionsSetActionsOidcCustomIssuerPolicyForEnterprise (string enterprise, ActionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest actionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest)

Set the GitHub Actions OIDC custom issuer policy for an enterprise

Sets the GitHub Actions OpenID Connect (OIDC) custom issuer policy for an enterprise. You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint. GitHub Apps must have the `enterprise_administration:write` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsSetActionsOidcCustomIssuerPolicyForEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var actionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest = new ActionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest(); // ActionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest | 

            try
            {
                // Set the GitHub Actions OIDC custom issuer policy for an enterprise
                apiInstance.ActionsSetActionsOidcCustomIssuerPolicyForEnterprise(enterprise, actionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsSetActionsOidcCustomIssuerPolicyForEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **actionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest** | [**ActionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest**](ActionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionssetallowedactionsorganization"></a>
# **ActionsSetAllowedActionsOrganization**
> void ActionsSetAllowedActionsOrganization (string org, EnterpriseAdminGetAllowedActionsEnterprise200Response enterpriseAdminGetAllowedActionsEnterprise200Response)

Set allowed actions and reusable workflows for an organization

Sets the actions and reusable workflows that are allowed in an organization. To use this endpoint, the organization permission policy for `allowed_actions` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\"  If the organization belongs to an enterprise that has `selected` actions and reusable workflows set at the enterprise level, then you cannot override any of the enterprise's allowed actions and reusable workflows settings.  To use the `patterns_allowed` setting for private repositories, the organization must belong to an enterprise. If the organization does not belong to an enterprise, then the `patterns_allowed` setting only applies to public repositories in the organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `administration` organization permission to use this API.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsSetAllowedActionsOrganizationExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var enterpriseAdminGetAllowedActionsEnterprise200Response = new EnterpriseAdminGetAllowedActionsEnterprise200Response(); // EnterpriseAdminGetAllowedActionsEnterprise200Response |  (optional) 

            try
            {
                // Set allowed actions and reusable workflows for an organization
                apiInstance.ActionsSetAllowedActionsOrganization(org, enterpriseAdminGetAllowedActionsEnterprise200Response);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsSetAllowedActionsOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **enterpriseAdminGetAllowedActionsEnterprise200Response** | [**EnterpriseAdminGetAllowedActionsEnterprise200Response**](EnterpriseAdminGetAllowedActionsEnterprise200Response.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionssetallowedactionsrepository"></a>
# **ActionsSetAllowedActionsRepository**
> void ActionsSetAllowedActionsRepository (string owner, string repo, EnterpriseAdminGetAllowedActionsEnterprise200Response enterpriseAdminGetAllowedActionsEnterprise200Response)

Set allowed actions and reusable workflows for a repository

Sets the actions and reusable workflows that are allowed in a repository. To use this endpoint, the repository permission policy for `allowed_actions` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for a repository](#set-github-actions-permissions-for-a-repository).\"  If the repository belongs to an organization or enterprise that has `selected` actions and reusable workflows set at the organization or enterprise levels, then you cannot override any of the allowed actions and reusable workflows settings.  To use the `patterns_allowed` setting for private repositories, the repository must belong to an enterprise. If the repository does not belong to an enterprise, then the `patterns_allowed` setting only applies to public repositories.  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `administration` repository permission to use this API.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsSetAllowedActionsRepositoryExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var enterpriseAdminGetAllowedActionsEnterprise200Response = new EnterpriseAdminGetAllowedActionsEnterprise200Response(); // EnterpriseAdminGetAllowedActionsEnterprise200Response |  (optional) 

            try
            {
                // Set allowed actions and reusable workflows for a repository
                apiInstance.ActionsSetAllowedActionsRepository(owner, repo, enterpriseAdminGetAllowedActionsEnterprise200Response);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsSetAllowedActionsRepository: " + e.Message );
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
 **enterpriseAdminGetAllowedActionsEnterprise200Response** | [**EnterpriseAdminGetAllowedActionsEnterprise200Response**](EnterpriseAdminGetAllowedActionsEnterprise200Response.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionssetcustomlabelsforselfhostedrunnerfororg"></a>
# **ActionsSetCustomLabelsForSelfHostedRunnerForOrg**
> EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsSetCustomLabelsForSelfHostedRunnerForOrg (string org, int? runnerId, EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest)

Set custom labels for a self-hosted runner for an organization

Remove all previous custom labels and set the new custom labels for a specific self-hosted runner configured in an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsSetCustomLabelsForSelfHostedRunnerForOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.
            var enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest = new EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest(); // EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest | 

            try
            {
                // Set custom labels for a self-hosted runner for an organization
                EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response result = apiInstance.ActionsSetCustomLabelsForSelfHostedRunnerForOrg(org, runnerId, enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsSetCustomLabelsForSelfHostedRunnerForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 
 **enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest** | [**EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest**](EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest.md)|  | 

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionssetcustomlabelsforselfhostedrunnerforrepo"></a>
# **ActionsSetCustomLabelsForSelfHostedRunnerForRepo**
> EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsSetCustomLabelsForSelfHostedRunnerForRepo (string owner, string repo, int? runnerId, EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest)

Set custom labels for a self-hosted runner for a repository

Remove all previous custom labels and set the new custom labels for a specific self-hosted runner configured in a repository.  You must authenticate using an access token with the `repo` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsSetCustomLabelsForSelfHostedRunnerForRepoExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.
            var enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest = new EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest(); // EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest | 

            try
            {
                // Set custom labels for a self-hosted runner for a repository
                EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response result = apiInstance.ActionsSetCustomLabelsForSelfHostedRunnerForRepo(owner, repo, runnerId, enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsSetCustomLabelsForSelfHostedRunnerForRepo: " + e.Message );
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
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 
 **enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest** | [**EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest**](EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest.md)|  | 

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionssetcustomoidcsubclaimforrepo"></a>
# **ActionsSetCustomOidcSubClaimForRepo**
> Object ActionsSetCustomOidcSubClaimForRepo (string owner, string repo, TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization theJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization)

Set the opt-in flag of an OIDC subject claim customization for a repository

Sets the `opt-in` or `opt-out` flag of a GitHub Actions OpenID Connect (OIDC) subject claim customization for a repository. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsSetCustomOidcSubClaimForRepoExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var theJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization = new TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization(); // TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization | 

            try
            {
                // Set the opt-in flag of an OIDC subject claim customization for a repository
                Object result = apiInstance.ActionsSetCustomOidcSubClaimForRepo(owner, repo, theJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsSetCustomOidcSubClaimForRepo: " + e.Message );
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
 **theJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization** | [**TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization**](TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/scim+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionssetgithubactionsdefaultworkflowpermissionsenterprise"></a>
# **ActionsSetGithubActionsDefaultWorkflowPermissionsEnterprise**
> void ActionsSetGithubActionsDefaultWorkflowPermissionsEnterprise (string enterprise, ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest)

Set default workflow permissions for an enterprise

Sets the default workflow permissions granted to the `GITHUB_TOKEN` when running workflows in an enterprise, and sets whether GitHub Actions can submit approving pull request reviews. For more information, see \"[Enforcing a policy for workflow permissions in your enterprise](https://docs.github.com/enterprise-cloud@latest/admin/policies/enforcing-policies-for-your-enterprise/enforcing-policies-for-github-actions-in-your-enterprise#enforcing-a-policy-for-workflow-permissions-in-your-enterprise).\"  You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint. GitHub Apps must have the `enterprise_administration:write` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest = new ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest(); // ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest | 

            try
            {
                // Set default workflow permissions for an enterprise
                apiInstance.ActionsSetGithubActionsDefaultWorkflowPermissionsEnterprise(enterprise, actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsSetGithubActionsDefaultWorkflowPermissionsEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest** | [**ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest**](ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionssetgithubactionsdefaultworkflowpermissionsorganization"></a>
# **ActionsSetGithubActionsDefaultWorkflowPermissionsOrganization**
> void ActionsSetGithubActionsDefaultWorkflowPermissionsOrganization (string org, ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest)

Set default workflow permissions for an organization

Sets the default workflow permissions granted to the `GITHUB_TOKEN` when running workflows in an organization, and sets if GitHub Actions can submit approving pull request reviews. For more information, see \"[Setting the permissions of the GITHUB_TOKEN for your organization](https://docs.github.com/organizations/managing-organization-settings/disabling-or-limiting-github-actions-for-your-organization#setting-the-permissions-of-the-github_token-for-your-organization).\"  You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `administration` organization permission to use this API.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsSetGithubActionsDefaultWorkflowPermissionsOrganizationExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest = new ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest(); // ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest |  (optional) 

            try
            {
                // Set default workflow permissions for an organization
                apiInstance.ActionsSetGithubActionsDefaultWorkflowPermissionsOrganization(org, actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsSetGithubActionsDefaultWorkflowPermissionsOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest** | [**ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest**](ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionssetgithubactionsdefaultworkflowpermissionsrepository"></a>
# **ActionsSetGithubActionsDefaultWorkflowPermissionsRepository**
> void ActionsSetGithubActionsDefaultWorkflowPermissionsRepository (string owner, string repo, ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest)

Set default workflow permissions for a repository

Sets the default workflow permissions granted to the `GITHUB_TOKEN` when running workflows in a repository, and sets if GitHub Actions can submit approving pull request reviews. For more information, see \"[Setting the permissions of the GITHUB_TOKEN for your repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#setting-the-permissions-of-the-github_token-for-your-repository).\"  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the repository `administration` permission to use this API.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsSetGithubActionsDefaultWorkflowPermissionsRepositoryExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest = new ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest(); // ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest | 

            try
            {
                // Set default workflow permissions for a repository
                apiInstance.ActionsSetGithubActionsDefaultWorkflowPermissionsRepository(owner, repo, actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsSetGithubActionsDefaultWorkflowPermissionsRepository: " + e.Message );
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
 **actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest** | [**ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest**](ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionssetgithubactionspermissionsorganization"></a>
# **ActionsSetGithubActionsPermissionsOrganization**
> void ActionsSetGithubActionsPermissionsOrganization (string org, ActionsSetGithubActionsPermissionsOrganizationRequest actionsSetGithubActionsPermissionsOrganizationRequest)

Set GitHub Actions permissions for an organization

Sets the GitHub Actions permissions policy for repositories and allowed actions and reusable workflows in an organization.  If the organization belongs to an enterprise that has set restrictive permissions at the enterprise level, such as `allowed_actions` to `selected` actions and reusable workflows, then you cannot override them for the organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `administration` organization permission to use this API.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsSetGithubActionsPermissionsOrganizationExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var actionsSetGithubActionsPermissionsOrganizationRequest = new ActionsSetGithubActionsPermissionsOrganizationRequest(); // ActionsSetGithubActionsPermissionsOrganizationRequest | 

            try
            {
                // Set GitHub Actions permissions for an organization
                apiInstance.ActionsSetGithubActionsPermissionsOrganization(org, actionsSetGithubActionsPermissionsOrganizationRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsSetGithubActionsPermissionsOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **actionsSetGithubActionsPermissionsOrganizationRequest** | [**ActionsSetGithubActionsPermissionsOrganizationRequest**](ActionsSetGithubActionsPermissionsOrganizationRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionssetgithubactionspermissionsrepository"></a>
# **ActionsSetGithubActionsPermissionsRepository**
> void ActionsSetGithubActionsPermissionsRepository (string owner, string repo, ActionsSetGithubActionsPermissionsRepositoryRequest actionsSetGithubActionsPermissionsRepositoryRequest)

Set GitHub Actions permissions for a repository

Sets the GitHub Actions permissions policy for enabling GitHub Actions and allowed actions and reusable workflows in the repository.  If the repository belongs to an organization or enterprise that has set restrictive permissions at the organization or enterprise levels, such as `allowed_actions` to `selected` actions and reusable workflows, then you cannot override them for the repository.  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `administration` repository permission to use this API.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsSetGithubActionsPermissionsRepositoryExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var actionsSetGithubActionsPermissionsRepositoryRequest = new ActionsSetGithubActionsPermissionsRepositoryRequest(); // ActionsSetGithubActionsPermissionsRepositoryRequest | 

            try
            {
                // Set GitHub Actions permissions for a repository
                apiInstance.ActionsSetGithubActionsPermissionsRepository(owner, repo, actionsSetGithubActionsPermissionsRepositoryRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsSetGithubActionsPermissionsRepository: " + e.Message );
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
 **actionsSetGithubActionsPermissionsRepositoryRequest** | [**ActionsSetGithubActionsPermissionsRepositoryRequest**](ActionsSetGithubActionsPermissionsRepositoryRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionssetrepoaccesstoselfhostedrunnergroupinorg"></a>
# **ActionsSetRepoAccessToSelfHostedRunnerGroupInOrg**
> void ActionsSetRepoAccessToSelfHostedRunnerGroupInOrg (string org, int? runnerGroupId, ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest actionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest)

Set repository access for a self-hosted runner group in an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"  Replaces the list of repositories that have access to a self-hosted runner group configured in an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var runnerGroupId = 56;  // int? | Unique identifier of the self-hosted runner group.
            var actionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest = new ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest(); // ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest | 

            try
            {
                // Set repository access for a self-hosted runner group in an organization
                apiInstance.ActionsSetRepoAccessToSelfHostedRunnerGroupInOrg(org, runnerGroupId, actionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsSetRepoAccessToSelfHostedRunnerGroupInOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **runnerGroupId** | **int?**| Unique identifier of the self-hosted runner group. | 
 **actionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest** | [**ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest**](ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionssetselectedreposfororgsecret"></a>
# **ActionsSetSelectedReposForOrgSecret**
> void ActionsSetSelectedReposForOrgSecret (string org, string secretName, ActionsSetSelectedReposForOrgSecretRequest actionsSetSelectedReposForOrgSecretRequest)

Set selected repositories for an organization secret

Replaces all repositories for an organization secret when the `visibility` for repository access is set to `selected`. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/actions#create-or-update-an-organization-secret). You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `secrets` organization permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsSetSelectedReposForOrgSecretExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.
            var actionsSetSelectedReposForOrgSecretRequest = new ActionsSetSelectedReposForOrgSecretRequest(); // ActionsSetSelectedReposForOrgSecretRequest | 

            try
            {
                // Set selected repositories for an organization secret
                apiInstance.ActionsSetSelectedReposForOrgSecret(org, secretName, actionsSetSelectedReposForOrgSecretRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsSetSelectedReposForOrgSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **secretName** | **string**| The name of the secret. | 
 **actionsSetSelectedReposForOrgSecretRequest** | [**ActionsSetSelectedReposForOrgSecretRequest**](ActionsSetSelectedReposForOrgSecretRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionssetselectedrepositoriesenabledgithubactionsorganization"></a>
# **ActionsSetSelectedRepositoriesEnabledGithubActionsOrganization**
> void ActionsSetSelectedRepositoriesEnabledGithubActionsOrganization (string org, ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest actionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest)

Set selected repositories enabled for GitHub Actions in an organization

Replaces the list of selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for `enabled_repositories` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\"  You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `administration` organization permission to use this API.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var actionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest = new ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest(); // ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest | 

            try
            {
                // Set selected repositories enabled for GitHub Actions in an organization
                apiInstance.ActionsSetSelectedRepositoriesEnabledGithubActionsOrganization(org, actionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsSetSelectedRepositoriesEnabledGithubActionsOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **actionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest** | [**ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest**](ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionssetselfhostedrunnersingroupfororg"></a>
# **ActionsSetSelfHostedRunnersInGroupForOrg**
> void ActionsSetSelfHostedRunnersInGroupForOrg (string org, int? runnerGroupId, EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest)

Set self-hosted runners in a group for an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"  Replaces the list of self-hosted runners that are part of an organization runner group.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsSetSelfHostedRunnersInGroupForOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var runnerGroupId = 56;  // int? | Unique identifier of the self-hosted runner group.
            var enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest = new EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest(); // EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest | 

            try
            {
                // Set self-hosted runners in a group for an organization
                apiInstance.ActionsSetSelfHostedRunnersInGroupForOrg(org, runnerGroupId, enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsSetSelfHostedRunnersInGroupForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **runnerGroupId** | **int?**| Unique identifier of the self-hosted runner group. | 
 **enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest** | [**EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest**](EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionssetworkflowaccesstorepository"></a>
# **ActionsSetWorkflowAccessToRepository**
> void ActionsSetWorkflowAccessToRepository (string owner, string repo, ActionsGetWorkflowAccessToRepository200Response actionsGetWorkflowAccessToRepository200Response)

Set the level of access for workflows outside of the repository

Sets the level of access that workflows outside of the repository have to actions and reusable workflows in the repository. This endpoint only applies to internal repositories. For more information, see \"[Managing GitHub Actions settings for a repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#allowing-access-to-components-in-an-internal-repository).\"  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the repository `administration` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsSetWorkflowAccessToRepositoryExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var actionsGetWorkflowAccessToRepository200Response = new ActionsGetWorkflowAccessToRepository200Response(); // ActionsGetWorkflowAccessToRepository200Response | 

            try
            {
                // Set the level of access for workflows outside of the repository
                apiInstance.ActionsSetWorkflowAccessToRepository(owner, repo, actionsGetWorkflowAccessToRepository200Response);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsSetWorkflowAccessToRepository: " + e.Message );
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
 **actionsGetWorkflowAccessToRepository200Response** | [**ActionsGetWorkflowAccessToRepository200Response**](ActionsGetWorkflowAccessToRepository200Response.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsupdateselfhostedrunnergroupfororg"></a>
# **ActionsUpdateSelfHostedRunnerGroupForOrg**
> ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner ActionsUpdateSelfHostedRunnerGroupForOrg (string org, int? runnerGroupId, ActionsUpdateSelfHostedRunnerGroupForOrgRequest actionsUpdateSelfHostedRunnerGroupForOrgRequest)

Update a self-hosted runner group for an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"  Updates the `name` and `visibility` of a self-hosted runner group in an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionsUpdateSelfHostedRunnerGroupForOrgExample
    {
        public void main()
        {
            var apiInstance = new ActionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var runnerGroupId = 56;  // int? | Unique identifier of the self-hosted runner group.
            var actionsUpdateSelfHostedRunnerGroupForOrgRequest = new ActionsUpdateSelfHostedRunnerGroupForOrgRequest(); // ActionsUpdateSelfHostedRunnerGroupForOrgRequest | 

            try
            {
                // Update a self-hosted runner group for an organization
                ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner result = apiInstance.ActionsUpdateSelfHostedRunnerGroupForOrg(org, runnerGroupId, actionsUpdateSelfHostedRunnerGroupForOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionsApi.ActionsUpdateSelfHostedRunnerGroupForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **runnerGroupId** | **int?**| Unique identifier of the self-hosted runner group. | 
 **actionsUpdateSelfHostedRunnerGroupForOrgRequest** | [**ActionsUpdateSelfHostedRunnerGroupForOrgRequest**](ActionsUpdateSelfHostedRunnerGroupForOrgRequest.md)|  | 

### Return type

[**ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner**](ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

