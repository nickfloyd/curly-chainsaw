# OpenapiClient::ActionsApi

All URIs are relative to *https://api.github.com*

| Method | HTTP request | Description |
| ------ | ------------ | ----------- |
| [**actions_add_custom_labels_to_self_hosted_runner_for_org**](ActionsApi.md#actions_add_custom_labels_to_self_hosted_runner_for_org) | **POST** /orgs/{org}/actions/runners/{runner_id}/labels | Add custom labels to a self-hosted runner for an organization |
| [**actions_add_custom_labels_to_self_hosted_runner_for_repo**](ActionsApi.md#actions_add_custom_labels_to_self_hosted_runner_for_repo) | **POST** /repos/{owner}/{repo}/actions/runners/{runner_id}/labels | Add custom labels to a self-hosted runner for a repository |
| [**actions_add_repo_access_to_self_hosted_runner_group_in_org**](ActionsApi.md#actions_add_repo_access_to_self_hosted_runner_group_in_org) | **PUT** /orgs/{org}/actions/runner-groups/{runner_group_id}/repositories/{repository_id} | Add repository access to a self-hosted runner group in an organization |
| [**actions_add_selected_repo_to_org_secret**](ActionsApi.md#actions_add_selected_repo_to_org_secret) | **PUT** /orgs/{org}/actions/secrets/{secret_name}/repositories/{repository_id} | Add selected repository to an organization secret |
| [**actions_add_self_hosted_runner_to_group_for_org**](ActionsApi.md#actions_add_self_hosted_runner_to_group_for_org) | **PUT** /orgs/{org}/actions/runner-groups/{runner_group_id}/runners/{runner_id} | Add a self-hosted runner to a group for an organization |
| [**actions_approve_workflow_run**](ActionsApi.md#actions_approve_workflow_run) | **POST** /repos/{owner}/{repo}/actions/runs/{run_id}/approve | Approve a workflow run for a fork pull request |
| [**actions_cancel_workflow_run**](ActionsApi.md#actions_cancel_workflow_run) | **POST** /repos/{owner}/{repo}/actions/runs/{run_id}/cancel | Cancel a workflow run |
| [**actions_create_or_update_environment_secret**](ActionsApi.md#actions_create_or_update_environment_secret) | **PUT** /repositories/{repository_id}/environments/{environment_name}/secrets/{secret_name} | Create or update an environment secret |
| [**actions_create_or_update_org_secret**](ActionsApi.md#actions_create_or_update_org_secret) | **PUT** /orgs/{org}/actions/secrets/{secret_name} | Create or update an organization secret |
| [**actions_create_or_update_repo_secret**](ActionsApi.md#actions_create_or_update_repo_secret) | **PUT** /repos/{owner}/{repo}/actions/secrets/{secret_name} | Create or update a repository secret |
| [**actions_create_registration_token_for_org**](ActionsApi.md#actions_create_registration_token_for_org) | **POST** /orgs/{org}/actions/runners/registration-token | Create a registration token for an organization |
| [**actions_create_registration_token_for_repo**](ActionsApi.md#actions_create_registration_token_for_repo) | **POST** /repos/{owner}/{repo}/actions/runners/registration-token | Create a registration token for a repository |
| [**actions_create_remove_token_for_org**](ActionsApi.md#actions_create_remove_token_for_org) | **POST** /orgs/{org}/actions/runners/remove-token | Create a remove token for an organization |
| [**actions_create_remove_token_for_repo**](ActionsApi.md#actions_create_remove_token_for_repo) | **POST** /repos/{owner}/{repo}/actions/runners/remove-token | Create a remove token for a repository |
| [**actions_create_self_hosted_runner_group_for_org**](ActionsApi.md#actions_create_self_hosted_runner_group_for_org) | **POST** /orgs/{org}/actions/runner-groups | Create a self-hosted runner group for an organization |
| [**actions_create_workflow_dispatch**](ActionsApi.md#actions_create_workflow_dispatch) | **POST** /repos/{owner}/{repo}/actions/workflows/{workflow_id}/dispatches | Create a workflow dispatch event |
| [**actions_delete_actions_cache_by_id**](ActionsApi.md#actions_delete_actions_cache_by_id) | **DELETE** /repos/{owner}/{repo}/actions/caches/{cache_id} | Delete a GitHub Actions cache for a repository (using a cache ID) |
| [**actions_delete_actions_cache_by_key**](ActionsApi.md#actions_delete_actions_cache_by_key) | **DELETE** /repos/{owner}/{repo}/actions/caches | Delete GitHub Actions caches for a repository (using a cache key) |
| [**actions_delete_artifact**](ActionsApi.md#actions_delete_artifact) | **DELETE** /repos/{owner}/{repo}/actions/artifacts/{artifact_id} | Delete an artifact |
| [**actions_delete_environment_secret**](ActionsApi.md#actions_delete_environment_secret) | **DELETE** /repositories/{repository_id}/environments/{environment_name}/secrets/{secret_name} | Delete an environment secret |
| [**actions_delete_org_secret**](ActionsApi.md#actions_delete_org_secret) | **DELETE** /orgs/{org}/actions/secrets/{secret_name} | Delete an organization secret |
| [**actions_delete_repo_secret**](ActionsApi.md#actions_delete_repo_secret) | **DELETE** /repos/{owner}/{repo}/actions/secrets/{secret_name} | Delete a repository secret |
| [**actions_delete_self_hosted_runner_from_org**](ActionsApi.md#actions_delete_self_hosted_runner_from_org) | **DELETE** /orgs/{org}/actions/runners/{runner_id} | Delete a self-hosted runner from an organization |
| [**actions_delete_self_hosted_runner_from_repo**](ActionsApi.md#actions_delete_self_hosted_runner_from_repo) | **DELETE** /repos/{owner}/{repo}/actions/runners/{runner_id} | Delete a self-hosted runner from a repository |
| [**actions_delete_self_hosted_runner_group_from_org**](ActionsApi.md#actions_delete_self_hosted_runner_group_from_org) | **DELETE** /orgs/{org}/actions/runner-groups/{runner_group_id} | Delete a self-hosted runner group from an organization |
| [**actions_delete_workflow_run**](ActionsApi.md#actions_delete_workflow_run) | **DELETE** /repos/{owner}/{repo}/actions/runs/{run_id} | Delete a workflow run |
| [**actions_delete_workflow_run_logs**](ActionsApi.md#actions_delete_workflow_run_logs) | **DELETE** /repos/{owner}/{repo}/actions/runs/{run_id}/logs | Delete workflow run logs |
| [**actions_disable_selected_repository_github_actions_organization**](ActionsApi.md#actions_disable_selected_repository_github_actions_organization) | **DELETE** /orgs/{org}/actions/permissions/repositories/{repository_id} | Disable a selected repository for GitHub Actions in an organization |
| [**actions_disable_workflow**](ActionsApi.md#actions_disable_workflow) | **PUT** /repos/{owner}/{repo}/actions/workflows/{workflow_id}/disable | Disable a workflow |
| [**actions_download_artifact**](ActionsApi.md#actions_download_artifact) | **GET** /repos/{owner}/{repo}/actions/artifacts/{artifact_id}/{archive_format} | Download an artifact |
| [**actions_download_job_logs_for_workflow_run**](ActionsApi.md#actions_download_job_logs_for_workflow_run) | **GET** /repos/{owner}/{repo}/actions/jobs/{job_id}/logs | Download job logs for a workflow run |
| [**actions_download_workflow_run_attempt_logs**](ActionsApi.md#actions_download_workflow_run_attempt_logs) | **GET** /repos/{owner}/{repo}/actions/runs/{run_id}/attempts/{attempt_number}/logs | Download workflow run attempt logs |
| [**actions_download_workflow_run_logs**](ActionsApi.md#actions_download_workflow_run_logs) | **GET** /repos/{owner}/{repo}/actions/runs/{run_id}/logs | Download workflow run logs |
| [**actions_enable_selected_repository_github_actions_organization**](ActionsApi.md#actions_enable_selected_repository_github_actions_organization) | **PUT** /orgs/{org}/actions/permissions/repositories/{repository_id} | Enable a selected repository for GitHub Actions in an organization |
| [**actions_enable_workflow**](ActionsApi.md#actions_enable_workflow) | **PUT** /repos/{owner}/{repo}/actions/workflows/{workflow_id}/enable | Enable a workflow |
| [**actions_get_actions_cache_list**](ActionsApi.md#actions_get_actions_cache_list) | **GET** /repos/{owner}/{repo}/actions/caches | List GitHub Actions caches for a repository |
| [**actions_get_actions_cache_usage**](ActionsApi.md#actions_get_actions_cache_usage) | **GET** /repos/{owner}/{repo}/actions/cache/usage | Get GitHub Actions cache usage for a repository |
| [**actions_get_actions_cache_usage_by_repo_for_org**](ActionsApi.md#actions_get_actions_cache_usage_by_repo_for_org) | **GET** /orgs/{org}/actions/cache/usage-by-repository | List repositories with GitHub Actions cache usage for an organization |
| [**actions_get_actions_cache_usage_for_enterprise**](ActionsApi.md#actions_get_actions_cache_usage_for_enterprise) | **GET** /enterprises/{enterprise}/actions/cache/usage | Get GitHub Actions cache usage for an enterprise |
| [**actions_get_actions_cache_usage_for_org**](ActionsApi.md#actions_get_actions_cache_usage_for_org) | **GET** /orgs/{org}/actions/cache/usage | Get GitHub Actions cache usage for an organization |
| [**actions_get_allowed_actions_organization**](ActionsApi.md#actions_get_allowed_actions_organization) | **GET** /orgs/{org}/actions/permissions/selected-actions | Get allowed actions and reusable workflows for an organization |
| [**actions_get_allowed_actions_repository**](ActionsApi.md#actions_get_allowed_actions_repository) | **GET** /repos/{owner}/{repo}/actions/permissions/selected-actions | Get allowed actions and reusable workflows for a repository |
| [**actions_get_artifact**](ActionsApi.md#actions_get_artifact) | **GET** /repos/{owner}/{repo}/actions/artifacts/{artifact_id} | Get an artifact |
| [**actions_get_custom_oidc_sub_claim_for_repo**](ActionsApi.md#actions_get_custom_oidc_sub_claim_for_repo) | **GET** /repos/{owner}/{repo}/actions/oidc/customization/sub | Get the opt-out flag of an OIDC subject claim customization for a repository |
| [**actions_get_environment_public_key**](ActionsApi.md#actions_get_environment_public_key) | **GET** /repositories/{repository_id}/environments/{environment_name}/secrets/public-key | Get an environment public key |
| [**actions_get_environment_secret**](ActionsApi.md#actions_get_environment_secret) | **GET** /repositories/{repository_id}/environments/{environment_name}/secrets/{secret_name} | Get an environment secret |
| [**actions_get_github_actions_default_workflow_permissions_enterprise**](ActionsApi.md#actions_get_github_actions_default_workflow_permissions_enterprise) | **GET** /enterprises/{enterprise}/actions/permissions/workflow | Get default workflow permissions for an enterprise |
| [**actions_get_github_actions_default_workflow_permissions_organization**](ActionsApi.md#actions_get_github_actions_default_workflow_permissions_organization) | **GET** /orgs/{org}/actions/permissions/workflow | Get default workflow permissions for an organization |
| [**actions_get_github_actions_default_workflow_permissions_repository**](ActionsApi.md#actions_get_github_actions_default_workflow_permissions_repository) | **GET** /repos/{owner}/{repo}/actions/permissions/workflow | Get default workflow permissions for a repository |
| [**actions_get_github_actions_permissions_organization**](ActionsApi.md#actions_get_github_actions_permissions_organization) | **GET** /orgs/{org}/actions/permissions | Get GitHub Actions permissions for an organization |
| [**actions_get_github_actions_permissions_repository**](ActionsApi.md#actions_get_github_actions_permissions_repository) | **GET** /repos/{owner}/{repo}/actions/permissions | Get GitHub Actions permissions for a repository |
| [**actions_get_job_for_workflow_run**](ActionsApi.md#actions_get_job_for_workflow_run) | **GET** /repos/{owner}/{repo}/actions/jobs/{job_id} | Get a job for a workflow run |
| [**actions_get_org_public_key**](ActionsApi.md#actions_get_org_public_key) | **GET** /orgs/{org}/actions/secrets/public-key | Get an organization public key |
| [**actions_get_org_secret**](ActionsApi.md#actions_get_org_secret) | **GET** /orgs/{org}/actions/secrets/{secret_name} | Get an organization secret |
| [**actions_get_pending_deployments_for_run**](ActionsApi.md#actions_get_pending_deployments_for_run) | **GET** /repos/{owner}/{repo}/actions/runs/{run_id}/pending_deployments | Get pending deployments for a workflow run |
| [**actions_get_repo_public_key**](ActionsApi.md#actions_get_repo_public_key) | **GET** /repos/{owner}/{repo}/actions/secrets/public-key | Get a repository public key |
| [**actions_get_repo_secret**](ActionsApi.md#actions_get_repo_secret) | **GET** /repos/{owner}/{repo}/actions/secrets/{secret_name} | Get a repository secret |
| [**actions_get_reviews_for_run**](ActionsApi.md#actions_get_reviews_for_run) | **GET** /repos/{owner}/{repo}/actions/runs/{run_id}/approvals | Get the review history for a workflow run |
| [**actions_get_self_hosted_runner_for_org**](ActionsApi.md#actions_get_self_hosted_runner_for_org) | **GET** /orgs/{org}/actions/runners/{runner_id} | Get a self-hosted runner for an organization |
| [**actions_get_self_hosted_runner_for_repo**](ActionsApi.md#actions_get_self_hosted_runner_for_repo) | **GET** /repos/{owner}/{repo}/actions/runners/{runner_id} | Get a self-hosted runner for a repository |
| [**actions_get_self_hosted_runner_group_for_org**](ActionsApi.md#actions_get_self_hosted_runner_group_for_org) | **GET** /orgs/{org}/actions/runner-groups/{runner_group_id} | Get a self-hosted runner group for an organization |
| [**actions_get_workflow**](ActionsApi.md#actions_get_workflow) | **GET** /repos/{owner}/{repo}/actions/workflows/{workflow_id} | Get a workflow |
| [**actions_get_workflow_access_to_repository**](ActionsApi.md#actions_get_workflow_access_to_repository) | **GET** /repos/{owner}/{repo}/actions/permissions/access | Get the level of access for workflows outside of the repository |
| [**actions_get_workflow_run**](ActionsApi.md#actions_get_workflow_run) | **GET** /repos/{owner}/{repo}/actions/runs/{run_id} | Get a workflow run |
| [**actions_get_workflow_run_attempt**](ActionsApi.md#actions_get_workflow_run_attempt) | **GET** /repos/{owner}/{repo}/actions/runs/{run_id}/attempts/{attempt_number} | Get a workflow run attempt |
| [**actions_get_workflow_run_usage**](ActionsApi.md#actions_get_workflow_run_usage) | **GET** /repos/{owner}/{repo}/actions/runs/{run_id}/timing | Get workflow run usage |
| [**actions_get_workflow_usage**](ActionsApi.md#actions_get_workflow_usage) | **GET** /repos/{owner}/{repo}/actions/workflows/{workflow_id}/timing | Get workflow usage |
| [**actions_list_artifacts_for_repo**](ActionsApi.md#actions_list_artifacts_for_repo) | **GET** /repos/{owner}/{repo}/actions/artifacts | List artifacts for a repository |
| [**actions_list_environment_secrets**](ActionsApi.md#actions_list_environment_secrets) | **GET** /repositories/{repository_id}/environments/{environment_name}/secrets | List environment secrets |
| [**actions_list_jobs_for_workflow_run**](ActionsApi.md#actions_list_jobs_for_workflow_run) | **GET** /repos/{owner}/{repo}/actions/runs/{run_id}/jobs | List jobs for a workflow run |
| [**actions_list_jobs_for_workflow_run_attempt**](ActionsApi.md#actions_list_jobs_for_workflow_run_attempt) | **GET** /repos/{owner}/{repo}/actions/runs/{run_id}/attempts/{attempt_number}/jobs | List jobs for a workflow run attempt |
| [**actions_list_labels_for_self_hosted_runner_for_org**](ActionsApi.md#actions_list_labels_for_self_hosted_runner_for_org) | **GET** /orgs/{org}/actions/runners/{runner_id}/labels | List labels for a self-hosted runner for an organization |
| [**actions_list_labels_for_self_hosted_runner_for_repo**](ActionsApi.md#actions_list_labels_for_self_hosted_runner_for_repo) | **GET** /repos/{owner}/{repo}/actions/runners/{runner_id}/labels | List labels for a self-hosted runner for a repository |
| [**actions_list_org_secrets**](ActionsApi.md#actions_list_org_secrets) | **GET** /orgs/{org}/actions/secrets | List organization secrets |
| [**actions_list_repo_access_to_self_hosted_runner_group_in_org**](ActionsApi.md#actions_list_repo_access_to_self_hosted_runner_group_in_org) | **GET** /orgs/{org}/actions/runner-groups/{runner_group_id}/repositories | List repository access to a self-hosted runner group in an organization |
| [**actions_list_repo_secrets**](ActionsApi.md#actions_list_repo_secrets) | **GET** /repos/{owner}/{repo}/actions/secrets | List repository secrets |
| [**actions_list_repo_workflows**](ActionsApi.md#actions_list_repo_workflows) | **GET** /repos/{owner}/{repo}/actions/workflows | List repository workflows |
| [**actions_list_runner_applications_for_org**](ActionsApi.md#actions_list_runner_applications_for_org) | **GET** /orgs/{org}/actions/runners/downloads | List runner applications for an organization |
| [**actions_list_runner_applications_for_repo**](ActionsApi.md#actions_list_runner_applications_for_repo) | **GET** /repos/{owner}/{repo}/actions/runners/downloads | List runner applications for a repository |
| [**actions_list_selected_repos_for_org_secret**](ActionsApi.md#actions_list_selected_repos_for_org_secret) | **GET** /orgs/{org}/actions/secrets/{secret_name}/repositories | List selected repositories for an organization secret |
| [**actions_list_selected_repositories_enabled_github_actions_organization**](ActionsApi.md#actions_list_selected_repositories_enabled_github_actions_organization) | **GET** /orgs/{org}/actions/permissions/repositories | List selected repositories enabled for GitHub Actions in an organization |
| [**actions_list_self_hosted_runner_groups_for_org**](ActionsApi.md#actions_list_self_hosted_runner_groups_for_org) | **GET** /orgs/{org}/actions/runner-groups | List self-hosted runner groups for an organization |
| [**actions_list_self_hosted_runners_for_org**](ActionsApi.md#actions_list_self_hosted_runners_for_org) | **GET** /orgs/{org}/actions/runners | List self-hosted runners for an organization |
| [**actions_list_self_hosted_runners_for_repo**](ActionsApi.md#actions_list_self_hosted_runners_for_repo) | **GET** /repos/{owner}/{repo}/actions/runners | List self-hosted runners for a repository |
| [**actions_list_self_hosted_runners_in_group_for_org**](ActionsApi.md#actions_list_self_hosted_runners_in_group_for_org) | **GET** /orgs/{org}/actions/runner-groups/{runner_group_id}/runners | List self-hosted runners in a group for an organization |
| [**actions_list_workflow_run_artifacts**](ActionsApi.md#actions_list_workflow_run_artifacts) | **GET** /repos/{owner}/{repo}/actions/runs/{run_id}/artifacts | List workflow run artifacts |
| [**actions_list_workflow_runs**](ActionsApi.md#actions_list_workflow_runs) | **GET** /repos/{owner}/{repo}/actions/workflows/{workflow_id}/runs | List workflow runs |
| [**actions_list_workflow_runs_for_repo**](ActionsApi.md#actions_list_workflow_runs_for_repo) | **GET** /repos/{owner}/{repo}/actions/runs | List workflow runs for a repository |
| [**actions_re_run_job_for_workflow_run**](ActionsApi.md#actions_re_run_job_for_workflow_run) | **POST** /repos/{owner}/{repo}/actions/jobs/{job_id}/rerun | Re-run a job from a workflow run |
| [**actions_re_run_workflow**](ActionsApi.md#actions_re_run_workflow) | **POST** /repos/{owner}/{repo}/actions/runs/{run_id}/rerun | Re-run a workflow |
| [**actions_re_run_workflow_failed_jobs**](ActionsApi.md#actions_re_run_workflow_failed_jobs) | **POST** /repos/{owner}/{repo}/actions/runs/{run_id}/rerun-failed-jobs | Re-run failed jobs from a workflow run |
| [**actions_remove_all_custom_labels_from_self_hosted_runner_for_org**](ActionsApi.md#actions_remove_all_custom_labels_from_self_hosted_runner_for_org) | **DELETE** /orgs/{org}/actions/runners/{runner_id}/labels | Remove all custom labels from a self-hosted runner for an organization |
| [**actions_remove_all_custom_labels_from_self_hosted_runner_for_repo**](ActionsApi.md#actions_remove_all_custom_labels_from_self_hosted_runner_for_repo) | **DELETE** /repos/{owner}/{repo}/actions/runners/{runner_id}/labels | Remove all custom labels from a self-hosted runner for a repository |
| [**actions_remove_custom_label_from_self_hosted_runner_for_org**](ActionsApi.md#actions_remove_custom_label_from_self_hosted_runner_for_org) | **DELETE** /orgs/{org}/actions/runners/{runner_id}/labels/{name} | Remove a custom label from a self-hosted runner for an organization |
| [**actions_remove_custom_label_from_self_hosted_runner_for_repo**](ActionsApi.md#actions_remove_custom_label_from_self_hosted_runner_for_repo) | **DELETE** /repos/{owner}/{repo}/actions/runners/{runner_id}/labels/{name} | Remove a custom label from a self-hosted runner for a repository |
| [**actions_remove_repo_access_to_self_hosted_runner_group_in_org**](ActionsApi.md#actions_remove_repo_access_to_self_hosted_runner_group_in_org) | **DELETE** /orgs/{org}/actions/runner-groups/{runner_group_id}/repositories/{repository_id} | Remove repository access to a self-hosted runner group in an organization |
| [**actions_remove_selected_repo_from_org_secret**](ActionsApi.md#actions_remove_selected_repo_from_org_secret) | **DELETE** /orgs/{org}/actions/secrets/{secret_name}/repositories/{repository_id} | Remove selected repository from an organization secret |
| [**actions_remove_self_hosted_runner_from_group_for_org**](ActionsApi.md#actions_remove_self_hosted_runner_from_group_for_org) | **DELETE** /orgs/{org}/actions/runner-groups/{runner_group_id}/runners/{runner_id} | Remove a self-hosted runner from a group for an organization |
| [**actions_review_pending_deployments_for_run**](ActionsApi.md#actions_review_pending_deployments_for_run) | **POST** /repos/{owner}/{repo}/actions/runs/{run_id}/pending_deployments | Review pending deployments for a workflow run |
| [**actions_set_actions_oidc_custom_issuer_policy_for_enterprise**](ActionsApi.md#actions_set_actions_oidc_custom_issuer_policy_for_enterprise) | **PUT** /enterprises/{enterprise}/actions/oidc/customization/issuer | Set the GitHub Actions OIDC custom issuer policy for an enterprise |
| [**actions_set_allowed_actions_organization**](ActionsApi.md#actions_set_allowed_actions_organization) | **PUT** /orgs/{org}/actions/permissions/selected-actions | Set allowed actions and reusable workflows for an organization |
| [**actions_set_allowed_actions_repository**](ActionsApi.md#actions_set_allowed_actions_repository) | **PUT** /repos/{owner}/{repo}/actions/permissions/selected-actions | Set allowed actions and reusable workflows for a repository |
| [**actions_set_custom_labels_for_self_hosted_runner_for_org**](ActionsApi.md#actions_set_custom_labels_for_self_hosted_runner_for_org) | **PUT** /orgs/{org}/actions/runners/{runner_id}/labels | Set custom labels for a self-hosted runner for an organization |
| [**actions_set_custom_labels_for_self_hosted_runner_for_repo**](ActionsApi.md#actions_set_custom_labels_for_self_hosted_runner_for_repo) | **PUT** /repos/{owner}/{repo}/actions/runners/{runner_id}/labels | Set custom labels for a self-hosted runner for a repository |
| [**actions_set_custom_oidc_sub_claim_for_repo**](ActionsApi.md#actions_set_custom_oidc_sub_claim_for_repo) | **PUT** /repos/{owner}/{repo}/actions/oidc/customization/sub | Set the opt-in flag of an OIDC subject claim customization for a repository |
| [**actions_set_github_actions_default_workflow_permissions_enterprise**](ActionsApi.md#actions_set_github_actions_default_workflow_permissions_enterprise) | **PUT** /enterprises/{enterprise}/actions/permissions/workflow | Set default workflow permissions for an enterprise |
| [**actions_set_github_actions_default_workflow_permissions_organization**](ActionsApi.md#actions_set_github_actions_default_workflow_permissions_organization) | **PUT** /orgs/{org}/actions/permissions/workflow | Set default workflow permissions for an organization |
| [**actions_set_github_actions_default_workflow_permissions_repository**](ActionsApi.md#actions_set_github_actions_default_workflow_permissions_repository) | **PUT** /repos/{owner}/{repo}/actions/permissions/workflow | Set default workflow permissions for a repository |
| [**actions_set_github_actions_permissions_organization**](ActionsApi.md#actions_set_github_actions_permissions_organization) | **PUT** /orgs/{org}/actions/permissions | Set GitHub Actions permissions for an organization |
| [**actions_set_github_actions_permissions_repository**](ActionsApi.md#actions_set_github_actions_permissions_repository) | **PUT** /repos/{owner}/{repo}/actions/permissions | Set GitHub Actions permissions for a repository |
| [**actions_set_repo_access_to_self_hosted_runner_group_in_org**](ActionsApi.md#actions_set_repo_access_to_self_hosted_runner_group_in_org) | **PUT** /orgs/{org}/actions/runner-groups/{runner_group_id}/repositories | Set repository access for a self-hosted runner group in an organization |
| [**actions_set_selected_repos_for_org_secret**](ActionsApi.md#actions_set_selected_repos_for_org_secret) | **PUT** /orgs/{org}/actions/secrets/{secret_name}/repositories | Set selected repositories for an organization secret |
| [**actions_set_selected_repositories_enabled_github_actions_organization**](ActionsApi.md#actions_set_selected_repositories_enabled_github_actions_organization) | **PUT** /orgs/{org}/actions/permissions/repositories | Set selected repositories enabled for GitHub Actions in an organization |
| [**actions_set_self_hosted_runners_in_group_for_org**](ActionsApi.md#actions_set_self_hosted_runners_in_group_for_org) | **PUT** /orgs/{org}/actions/runner-groups/{runner_group_id}/runners | Set self-hosted runners in a group for an organization |
| [**actions_set_workflow_access_to_repository**](ActionsApi.md#actions_set_workflow_access_to_repository) | **PUT** /repos/{owner}/{repo}/actions/permissions/access | Set the level of access for workflows outside of the repository |
| [**actions_update_self_hosted_runner_group_for_org**](ActionsApi.md#actions_update_self_hosted_runner_group_for_org) | **PATCH** /orgs/{org}/actions/runner-groups/{runner_group_id} | Update a self-hosted runner group for an organization |


## actions_add_custom_labels_to_self_hosted_runner_for_org

> <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response> actions_add_custom_labels_to_self_hosted_runner_for_org(org, runner_id, enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise_request)

Add custom labels to a self-hosted runner for an organization

Add custom labels to a self-hosted runner configured in an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.
enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise_request = OpenapiClient::EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest.new({labels: ['labels_example']}) # EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest | 

begin
  # Add custom labels to a self-hosted runner for an organization
  result = api_instance.actions_add_custom_labels_to_self_hosted_runner_for_org(org, runner_id, enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_add_custom_labels_to_self_hosted_runner_for_org: #{e}"
end
```

#### Using the actions_add_custom_labels_to_self_hosted_runner_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>, Integer, Hash)> actions_add_custom_labels_to_self_hosted_runner_for_org_with_http_info(org, runner_id, enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise_request)

```ruby
begin
  # Add custom labels to a self-hosted runner for an organization
  data, status_code, headers = api_instance.actions_add_custom_labels_to_self_hosted_runner_for_org_with_http_info(org, runner_id, enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_add_custom_labels_to_self_hosted_runner_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |
| **enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise_request** | [**EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest**](EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest.md) |  |  |

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## actions_add_custom_labels_to_self_hosted_runner_for_repo

> <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response> actions_add_custom_labels_to_self_hosted_runner_for_repo(owner, repo, runner_id, enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise_request)

Add custom labels to a self-hosted runner for a repository

Add custom labels to a self-hosted runner configured in a repository.  You must authenticate using an access token with the `repo` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.
enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise_request = OpenapiClient::EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest.new({labels: ['labels_example']}) # EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest | 

begin
  # Add custom labels to a self-hosted runner for a repository
  result = api_instance.actions_add_custom_labels_to_self_hosted_runner_for_repo(owner, repo, runner_id, enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_add_custom_labels_to_self_hosted_runner_for_repo: #{e}"
end
```

#### Using the actions_add_custom_labels_to_self_hosted_runner_for_repo_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>, Integer, Hash)> actions_add_custom_labels_to_self_hosted_runner_for_repo_with_http_info(owner, repo, runner_id, enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise_request)

```ruby
begin
  # Add custom labels to a self-hosted runner for a repository
  data, status_code, headers = api_instance.actions_add_custom_labels_to_self_hosted_runner_for_repo_with_http_info(owner, repo, runner_id, enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_add_custom_labels_to_self_hosted_runner_for_repo_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |
| **enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise_request** | [**EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest**](EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest.md) |  |  |

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## actions_add_repo_access_to_self_hosted_runner_group_in_org

> actions_add_repo_access_to_self_hosted_runner_group_in_org(org, runner_group_id, repository_id)

Add repository access to a self-hosted runner group in an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"   Adds a repository to the list of selected repositories that can access a self-hosted runner group. The runner group must have `visibility` set to `selected`. For more information, see \"[Create a self-hosted runner group for an organization](#create-a-self-hosted-runner-group-for-an-organization).\"  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
runner_group_id = 56 # Integer | Unique identifier of the self-hosted runner group.
repository_id = 56 # Integer | The unique identifier of the repository.

begin
  # Add repository access to a self-hosted runner group in an organization
  api_instance.actions_add_repo_access_to_self_hosted_runner_group_in_org(org, runner_group_id, repository_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_add_repo_access_to_self_hosted_runner_group_in_org: #{e}"
end
```

#### Using the actions_add_repo_access_to_self_hosted_runner_group_in_org_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_add_repo_access_to_self_hosted_runner_group_in_org_with_http_info(org, runner_group_id, repository_id)

```ruby
begin
  # Add repository access to a self-hosted runner group in an organization
  data, status_code, headers = api_instance.actions_add_repo_access_to_self_hosted_runner_group_in_org_with_http_info(org, runner_group_id, repository_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_add_repo_access_to_self_hosted_runner_group_in_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **runner_group_id** | **Integer** | Unique identifier of the self-hosted runner group. |  |
| **repository_id** | **Integer** | The unique identifier of the repository. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actions_add_selected_repo_to_org_secret

> actions_add_selected_repo_to_org_secret(org, secret_name, repository_id)

Add selected repository to an organization secret

Adds a repository to an organization secret when the `visibility` for repository access is set to `selected`. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/actions#create-or-update-an-organization-secret). You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `secrets` organization permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.
repository_id = 56 # Integer | 

begin
  # Add selected repository to an organization secret
  api_instance.actions_add_selected_repo_to_org_secret(org, secret_name, repository_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_add_selected_repo_to_org_secret: #{e}"
end
```

#### Using the actions_add_selected_repo_to_org_secret_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_add_selected_repo_to_org_secret_with_http_info(org, secret_name, repository_id)

```ruby
begin
  # Add selected repository to an organization secret
  data, status_code, headers = api_instance.actions_add_selected_repo_to_org_secret_with_http_info(org, secret_name, repository_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_add_selected_repo_to_org_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **secret_name** | **String** | The name of the secret. |  |
| **repository_id** | **Integer** |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actions_add_self_hosted_runner_to_group_for_org

> actions_add_self_hosted_runner_to_group_for_org(org, runner_group_id, runner_id)

Add a self-hosted runner to a group for an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"   Adds a self-hosted runner to a runner group configured in an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
runner_group_id = 56 # Integer | Unique identifier of the self-hosted runner group.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.

begin
  # Add a self-hosted runner to a group for an organization
  api_instance.actions_add_self_hosted_runner_to_group_for_org(org, runner_group_id, runner_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_add_self_hosted_runner_to_group_for_org: #{e}"
end
```

#### Using the actions_add_self_hosted_runner_to_group_for_org_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_add_self_hosted_runner_to_group_for_org_with_http_info(org, runner_group_id, runner_id)

```ruby
begin
  # Add a self-hosted runner to a group for an organization
  data, status_code, headers = api_instance.actions_add_self_hosted_runner_to_group_for_org_with_http_info(org, runner_group_id, runner_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_add_self_hosted_runner_to_group_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **runner_group_id** | **Integer** | Unique identifier of the self-hosted runner group. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actions_approve_workflow_run

> Object actions_approve_workflow_run(owner, repo, run_id)

Approve a workflow run for a fork pull request

Approves a workflow run for a pull request from a public fork of a first time contributor. For more information, see [\"Approving workflow runs from public forks](https://docs.github.com/actions/managing-workflow-runs/approving-workflow-runs-from-public-forks).\"  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
run_id = 56 # Integer | The unique identifier of the workflow run.

begin
  # Approve a workflow run for a fork pull request
  result = api_instance.actions_approve_workflow_run(owner, repo, run_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_approve_workflow_run: #{e}"
end
```

#### Using the actions_approve_workflow_run_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Object, Integer, Hash)> actions_approve_workflow_run_with_http_info(owner, repo, run_id)

```ruby
begin
  # Approve a workflow run for a fork pull request
  data, status_code, headers = api_instance.actions_approve_workflow_run_with_http_info(owner, repo, run_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Object
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_approve_workflow_run_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **run_id** | **Integer** | The unique identifier of the workflow run. |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_cancel_workflow_run

> Object actions_cancel_workflow_run(owner, repo, run_id)

Cancel a workflow run

Cancels a workflow run using its `id`. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
run_id = 56 # Integer | The unique identifier of the workflow run.

begin
  # Cancel a workflow run
  result = api_instance.actions_cancel_workflow_run(owner, repo, run_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_cancel_workflow_run: #{e}"
end
```

#### Using the actions_cancel_workflow_run_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Object, Integer, Hash)> actions_cancel_workflow_run_with_http_info(owner, repo, run_id)

```ruby
begin
  # Cancel a workflow run
  data, status_code, headers = api_instance.actions_cancel_workflow_run_with_http_info(owner, repo, run_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Object
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_cancel_workflow_run_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **run_id** | **Integer** | The unique identifier of the workflow run. |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_create_or_update_environment_secret

> Object actions_create_or_update_environment_secret(repository_id, environment_name, secret_name, actions_create_or_update_environment_secret_request)

Create or update an environment secret

Creates or updates an environment secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `secrets` repository permission to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  ``` const sodium = require('tweetsodium');  const key = \"base64-encoded-public-key\"; const value = \"plain-text-secret\";  // Convert the message and key to Uint8Array's (Buffer implements that interface) const messageBytes = Buffer.from(value); const keyBytes = Buffer.from(key, 'base64');  // Encrypt using LibSodium. const encryptedBytes = sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted = Buffer.from(encryptedBytes).toString('base64');  console.log(encrypted); ```   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  ``` from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -> str:   \"\"\"Encrypt a Unicode string using the public key.\"\"\"   public_key = public.PublicKey(public_key.encode(\"utf-8\"), encoding.Base64Encoder())   sealed_box = public.SealedBox(public_key)   encrypted = sealed_box.encrypt(secret_value.encode(\"utf-8\"))   return b64encode(encrypted).decode(\"utf-8\") ```  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  ``` var secretValue = System.Text.Encoding.UTF8.GetBytes(\"mySecret\"); var publicKey = Convert.FromBase64String(\"2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU=\");  var sealedPublicKeyBox = Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); ```  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  ```ruby require \"rbnacl\" require \"base64\"  key = Base64.decode64(\"+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0=\") public_key = RbNaCl::PublicKey.new(key)  box = RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret = box.encrypt(\"my_secret\")  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) ```

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
repository_id = 56 # Integer | The unique identifier of the repository.
environment_name = 'environment_name_example' # String | The name of the environment
secret_name = 'secret_name_example' # String | The name of the secret.
actions_create_or_update_environment_secret_request = OpenapiClient::ActionsCreateOrUpdateEnvironmentSecretRequest.new({encrypted_value: 'encrypted_value_example', key_id: 'key_id_example'}) # ActionsCreateOrUpdateEnvironmentSecretRequest | 

begin
  # Create or update an environment secret
  result = api_instance.actions_create_or_update_environment_secret(repository_id, environment_name, secret_name, actions_create_or_update_environment_secret_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_create_or_update_environment_secret: #{e}"
end
```

#### Using the actions_create_or_update_environment_secret_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Object, Integer, Hash)> actions_create_or_update_environment_secret_with_http_info(repository_id, environment_name, secret_name, actions_create_or_update_environment_secret_request)

```ruby
begin
  # Create or update an environment secret
  data, status_code, headers = api_instance.actions_create_or_update_environment_secret_with_http_info(repository_id, environment_name, secret_name, actions_create_or_update_environment_secret_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Object
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_create_or_update_environment_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **repository_id** | **Integer** | The unique identifier of the repository. |  |
| **environment_name** | **String** | The name of the environment |  |
| **secret_name** | **String** | The name of the secret. |  |
| **actions_create_or_update_environment_secret_request** | [**ActionsCreateOrUpdateEnvironmentSecretRequest**](ActionsCreateOrUpdateEnvironmentSecretRequest.md) |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## actions_create_or_update_org_secret

> Object actions_create_or_update_org_secret(org, secret_name, actions_create_or_update_org_secret_request)

Create or update an organization secret

Creates or updates an organization secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `secrets` organization permission to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  ``` const sodium = require('tweetsodium');  const key = \"base64-encoded-public-key\"; const value = \"plain-text-secret\";  // Convert the message and key to Uint8Array's (Buffer implements that interface) const messageBytes = Buffer.from(value); const keyBytes = Buffer.from(key, 'base64');  // Encrypt using LibSodium. const encryptedBytes = sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted = Buffer.from(encryptedBytes).toString('base64');  console.log(encrypted); ```   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  ``` from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -> str:   \"\"\"Encrypt a Unicode string using the public key.\"\"\"   public_key = public.PublicKey(public_key.encode(\"utf-8\"), encoding.Base64Encoder())   sealed_box = public.SealedBox(public_key)   encrypted = sealed_box.encrypt(secret_value.encode(\"utf-8\"))   return b64encode(encrypted).decode(\"utf-8\") ```  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  ``` var secretValue = System.Text.Encoding.UTF8.GetBytes(\"mySecret\"); var publicKey = Convert.FromBase64String(\"2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU=\");  var sealedPublicKeyBox = Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); ```  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  ```ruby require \"rbnacl\" require \"base64\"  key = Base64.decode64(\"+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0=\") public_key = RbNaCl::PublicKey.new(key)  box = RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret = box.encrypt(\"my_secret\")  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) ```

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.
actions_create_or_update_org_secret_request = OpenapiClient::ActionsCreateOrUpdateOrgSecretRequest.new({visibility: 'all'}) # ActionsCreateOrUpdateOrgSecretRequest | 

begin
  # Create or update an organization secret
  result = api_instance.actions_create_or_update_org_secret(org, secret_name, actions_create_or_update_org_secret_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_create_or_update_org_secret: #{e}"
end
```

#### Using the actions_create_or_update_org_secret_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Object, Integer, Hash)> actions_create_or_update_org_secret_with_http_info(org, secret_name, actions_create_or_update_org_secret_request)

```ruby
begin
  # Create or update an organization secret
  data, status_code, headers = api_instance.actions_create_or_update_org_secret_with_http_info(org, secret_name, actions_create_or_update_org_secret_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Object
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_create_or_update_org_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **secret_name** | **String** | The name of the secret. |  |
| **actions_create_or_update_org_secret_request** | [**ActionsCreateOrUpdateOrgSecretRequest**](ActionsCreateOrUpdateOrgSecretRequest.md) |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## actions_create_or_update_repo_secret

> Object actions_create_or_update_repo_secret(owner, repo, secret_name, actions_create_or_update_repo_secret_request)

Create or update a repository secret

Creates or updates a repository secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `secrets` repository permission to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  ``` const sodium = require('tweetsodium');  const key = \"base64-encoded-public-key\"; const value = \"plain-text-secret\";  // Convert the message and key to Uint8Array's (Buffer implements that interface) const messageBytes = Buffer.from(value); const keyBytes = Buffer.from(key, 'base64');  // Encrypt using LibSodium. const encryptedBytes = sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted = Buffer.from(encryptedBytes).toString('base64');  console.log(encrypted); ```   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  ``` from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -> str:   \"\"\"Encrypt a Unicode string using the public key.\"\"\"   public_key = public.PublicKey(public_key.encode(\"utf-8\"), encoding.Base64Encoder())   sealed_box = public.SealedBox(public_key)   encrypted = sealed_box.encrypt(secret_value.encode(\"utf-8\"))   return b64encode(encrypted).decode(\"utf-8\") ```  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  ``` var secretValue = System.Text.Encoding.UTF8.GetBytes(\"mySecret\"); var publicKey = Convert.FromBase64String(\"2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU=\");  var sealedPublicKeyBox = Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); ```  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  ```ruby require \"rbnacl\" require \"base64\"  key = Base64.decode64(\"+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0=\") public_key = RbNaCl::PublicKey.new(key)  box = RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret = box.encrypt(\"my_secret\")  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) ```

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.
actions_create_or_update_repo_secret_request = OpenapiClient::ActionsCreateOrUpdateRepoSecretRequest.new # ActionsCreateOrUpdateRepoSecretRequest | 

begin
  # Create or update a repository secret
  result = api_instance.actions_create_or_update_repo_secret(owner, repo, secret_name, actions_create_or_update_repo_secret_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_create_or_update_repo_secret: #{e}"
end
```

#### Using the actions_create_or_update_repo_secret_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Object, Integer, Hash)> actions_create_or_update_repo_secret_with_http_info(owner, repo, secret_name, actions_create_or_update_repo_secret_request)

```ruby
begin
  # Create or update a repository secret
  data, status_code, headers = api_instance.actions_create_or_update_repo_secret_with_http_info(owner, repo, secret_name, actions_create_or_update_repo_secret_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Object
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_create_or_update_repo_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **secret_name** | **String** | The name of the secret. |  |
| **actions_create_or_update_repo_secret_request** | [**ActionsCreateOrUpdateRepoSecretRequest**](ActionsCreateOrUpdateRepoSecretRequest.md) |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## actions_create_registration_token_for_org

> <AuthenticationToken> actions_create_registration_token_for_org(org)

Create a registration token for an organization

Returns a token that you can pass to the `config` script. The token expires after one hour.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.  #### Example using registration token  Configure your self-hosted runner, replacing `TOKEN` with the registration token provided by this endpoint.  ``` ./config.sh --url https://github.com/octo-org --token TOKEN ```

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.

begin
  # Create a registration token for an organization
  result = api_instance.actions_create_registration_token_for_org(org)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_create_registration_token_for_org: #{e}"
end
```

#### Using the actions_create_registration_token_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<AuthenticationToken>, Integer, Hash)> actions_create_registration_token_for_org_with_http_info(org)

```ruby
begin
  # Create a registration token for an organization
  data, status_code, headers = api_instance.actions_create_registration_token_for_org_with_http_info(org)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <AuthenticationToken>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_create_registration_token_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |

### Return type

[**AuthenticationToken**](AuthenticationToken.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_create_registration_token_for_repo

> <AuthenticationToken> actions_create_registration_token_for_repo(owner, repo)

Create a registration token for a repository

Returns a token that you can pass to the `config` script. The token expires after one hour. You must authenticate using an access token with the `repo` scope to use this endpoint.  #### Example using registration token   Configure your self-hosted runner, replacing `TOKEN` with the registration token provided by this endpoint.  ``` ./config.sh --url https://github.com/octo-org/octo-repo-artifacts --token TOKEN ```

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Create a registration token for a repository
  result = api_instance.actions_create_registration_token_for_repo(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_create_registration_token_for_repo: #{e}"
end
```

#### Using the actions_create_registration_token_for_repo_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<AuthenticationToken>, Integer, Hash)> actions_create_registration_token_for_repo_with_http_info(owner, repo)

```ruby
begin
  # Create a registration token for a repository
  data, status_code, headers = api_instance.actions_create_registration_token_for_repo_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <AuthenticationToken>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_create_registration_token_for_repo_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**AuthenticationToken**](AuthenticationToken.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_create_remove_token_for_org

> <AuthenticationToken> actions_create_remove_token_for_org(org)

Create a remove token for an organization

Returns a token that you can pass to the `config` script to remove a self-hosted runner from an organization. The token expires after one hour.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.  #### Example using remove token  To remove your self-hosted runner from an organization, replace `TOKEN` with the remove token provided by this endpoint.  ``` ./config.sh remove --token TOKEN ```

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.

begin
  # Create a remove token for an organization
  result = api_instance.actions_create_remove_token_for_org(org)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_create_remove_token_for_org: #{e}"
end
```

#### Using the actions_create_remove_token_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<AuthenticationToken>, Integer, Hash)> actions_create_remove_token_for_org_with_http_info(org)

```ruby
begin
  # Create a remove token for an organization
  data, status_code, headers = api_instance.actions_create_remove_token_for_org_with_http_info(org)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <AuthenticationToken>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_create_remove_token_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |

### Return type

[**AuthenticationToken**](AuthenticationToken.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_create_remove_token_for_repo

> <AuthenticationToken> actions_create_remove_token_for_repo(owner, repo)

Create a remove token for a repository

Returns a token that you can pass to remove a self-hosted runner from a repository. The token expires after one hour. You must authenticate using an access token with the `repo` scope to use this endpoint.  #### Example using remove token   To remove your self-hosted runner from a repository, replace TOKEN with the remove token provided by this endpoint.  ``` ./config.sh remove --token TOKEN ```

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Create a remove token for a repository
  result = api_instance.actions_create_remove_token_for_repo(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_create_remove_token_for_repo: #{e}"
end
```

#### Using the actions_create_remove_token_for_repo_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<AuthenticationToken>, Integer, Hash)> actions_create_remove_token_for_repo_with_http_info(owner, repo)

```ruby
begin
  # Create a remove token for a repository
  data, status_code, headers = api_instance.actions_create_remove_token_for_repo_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <AuthenticationToken>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_create_remove_token_for_repo_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**AuthenticationToken**](AuthenticationToken.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_create_self_hosted_runner_group_for_org

> <ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner> actions_create_self_hosted_runner_group_for_org(org, actions_create_self_hosted_runner_group_for_org_request)

Create a self-hosted runner group for an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud and GitHub Enterprise Server. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"  Creates a new self-hosted runner group for an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
actions_create_self_hosted_runner_group_for_org_request = OpenapiClient::ActionsCreateSelfHostedRunnerGroupForOrgRequest.new({name: 'name_example'}) # ActionsCreateSelfHostedRunnerGroupForOrgRequest | 

begin
  # Create a self-hosted runner group for an organization
  result = api_instance.actions_create_self_hosted_runner_group_for_org(org, actions_create_self_hosted_runner_group_for_org_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_create_self_hosted_runner_group_for_org: #{e}"
end
```

#### Using the actions_create_self_hosted_runner_group_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner>, Integer, Hash)> actions_create_self_hosted_runner_group_for_org_with_http_info(org, actions_create_self_hosted_runner_group_for_org_request)

```ruby
begin
  # Create a self-hosted runner group for an organization
  data, status_code, headers = api_instance.actions_create_self_hosted_runner_group_for_org_with_http_info(org, actions_create_self_hosted_runner_group_for_org_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_create_self_hosted_runner_group_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **actions_create_self_hosted_runner_group_for_org_request** | [**ActionsCreateSelfHostedRunnerGroupForOrgRequest**](ActionsCreateSelfHostedRunnerGroupForOrgRequest.md) |  |  |

### Return type

[**ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner**](ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## actions_create_workflow_dispatch

> actions_create_workflow_dispatch(owner, repo, workflow_id, actions_create_workflow_dispatch_request)

Create a workflow dispatch event

You can use this endpoint to manually trigger a GitHub Actions workflow run. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`.  You must configure your GitHub Actions workflow to run when the [`workflow_dispatch` webhook](/developers/webhooks-and-events/webhook-events-and-payloads#workflow_dispatch) event occurs. The `inputs` are configured in the workflow file. For more information about how to configure the `workflow_dispatch` event in the workflow file, see \"[Events that trigger workflows](/actions/reference/events-that-trigger-workflows#workflow_dispatch).\"  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint. For more information, see \"[Creating a personal access token for the command line](https://docs.github.com/articles/creating-a-personal-access-token-for-the-command-line).\"

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
workflow_id = nil # ActionsGetWorkflowWorkflowIdParameter | The ID of the workflow. You can also pass the workflow file name as a string.
actions_create_workflow_dispatch_request = OpenapiClient::ActionsCreateWorkflowDispatchRequest.new({ref: 'ref_example'}) # ActionsCreateWorkflowDispatchRequest | 

begin
  # Create a workflow dispatch event
  api_instance.actions_create_workflow_dispatch(owner, repo, workflow_id, actions_create_workflow_dispatch_request)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_create_workflow_dispatch: #{e}"
end
```

#### Using the actions_create_workflow_dispatch_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_create_workflow_dispatch_with_http_info(owner, repo, workflow_id, actions_create_workflow_dispatch_request)

```ruby
begin
  # Create a workflow dispatch event
  data, status_code, headers = api_instance.actions_create_workflow_dispatch_with_http_info(owner, repo, workflow_id, actions_create_workflow_dispatch_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_create_workflow_dispatch_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **workflow_id** | [**ActionsGetWorkflowWorkflowIdParameter**](.md) | The ID of the workflow. You can also pass the workflow file name as a string. |  |
| **actions_create_workflow_dispatch_request** | [**ActionsCreateWorkflowDispatchRequest**](ActionsCreateWorkflowDispatchRequest.md) |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actions_delete_actions_cache_by_id

> actions_delete_actions_cache_by_id(owner, repo, cache_id)

Delete a GitHub Actions cache for a repository (using a cache ID)

Deletes a GitHub Actions cache for a repository, using a cache ID.  You must authenticate using an access token with the `repo` scope to use this endpoint.  GitHub Apps must have the `actions:write` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
cache_id = 56 # Integer | The unique identifier of the GitHub Actions cache.

begin
  # Delete a GitHub Actions cache for a repository (using a cache ID)
  api_instance.actions_delete_actions_cache_by_id(owner, repo, cache_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_delete_actions_cache_by_id: #{e}"
end
```

#### Using the actions_delete_actions_cache_by_id_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_delete_actions_cache_by_id_with_http_info(owner, repo, cache_id)

```ruby
begin
  # Delete a GitHub Actions cache for a repository (using a cache ID)
  data, status_code, headers = api_instance.actions_delete_actions_cache_by_id_with_http_info(owner, repo, cache_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_delete_actions_cache_by_id_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **cache_id** | **Integer** | The unique identifier of the GitHub Actions cache. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actions_delete_actions_cache_by_key

> <RepositoryActionsCaches> actions_delete_actions_cache_by_key(owner, repo, key, opts)

Delete GitHub Actions caches for a repository (using a cache key)

Deletes one or more GitHub Actions caches for a repository, using a complete cache key. By default, all caches that match the provided key are deleted, but you can optionally provide a Git ref to restrict deletions to caches that match both the provided key and the Git ref.  You must authenticate using an access token with the `repo` scope to use this endpoint.  GitHub Apps must have the `actions:write` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
key = 'key_example' # String | A key for identifying the cache.
opts = {
  ref: 'ref_example' # String | The Git reference for the results you want to list. The `ref` for a branch can be formatted either as `refs/heads/<branch name>` or simply `<branch name>`. To reference a pull request use `refs/pull/<number>/merge`.
}

begin
  # Delete GitHub Actions caches for a repository (using a cache key)
  result = api_instance.actions_delete_actions_cache_by_key(owner, repo, key, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_delete_actions_cache_by_key: #{e}"
end
```

#### Using the actions_delete_actions_cache_by_key_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<RepositoryActionsCaches>, Integer, Hash)> actions_delete_actions_cache_by_key_with_http_info(owner, repo, key, opts)

```ruby
begin
  # Delete GitHub Actions caches for a repository (using a cache key)
  data, status_code, headers = api_instance.actions_delete_actions_cache_by_key_with_http_info(owner, repo, key, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <RepositoryActionsCaches>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_delete_actions_cache_by_key_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **key** | **String** | A key for identifying the cache. |  |
| **ref** | **String** | The Git reference for the results you want to list. The &#x60;ref&#x60; for a branch can be formatted either as &#x60;refs/heads/&lt;branch name&gt;&#x60; or simply &#x60;&lt;branch name&gt;&#x60;. To reference a pull request use &#x60;refs/pull/&lt;number&gt;/merge&#x60;. | [optional] |

### Return type

[**RepositoryActionsCaches**](RepositoryActionsCaches.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_delete_artifact

> actions_delete_artifact(owner, repo, artifact_id)

Delete an artifact

Deletes an artifact for a workflow run. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
artifact_id = 56 # Integer | The unique identifier of the artifact.

begin
  # Delete an artifact
  api_instance.actions_delete_artifact(owner, repo, artifact_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_delete_artifact: #{e}"
end
```

#### Using the actions_delete_artifact_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_delete_artifact_with_http_info(owner, repo, artifact_id)

```ruby
begin
  # Delete an artifact
  data, status_code, headers = api_instance.actions_delete_artifact_with_http_info(owner, repo, artifact_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_delete_artifact_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **artifact_id** | **Integer** | The unique identifier of the artifact. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actions_delete_environment_secret

> actions_delete_environment_secret(repository_id, environment_name, secret_name)

Delete an environment secret

Deletes a secret in an environment using the secret name. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `secrets` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
repository_id = 56 # Integer | The unique identifier of the repository.
environment_name = 'environment_name_example' # String | The name of the environment
secret_name = 'secret_name_example' # String | The name of the secret.

begin
  # Delete an environment secret
  api_instance.actions_delete_environment_secret(repository_id, environment_name, secret_name)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_delete_environment_secret: #{e}"
end
```

#### Using the actions_delete_environment_secret_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_delete_environment_secret_with_http_info(repository_id, environment_name, secret_name)

```ruby
begin
  # Delete an environment secret
  data, status_code, headers = api_instance.actions_delete_environment_secret_with_http_info(repository_id, environment_name, secret_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_delete_environment_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **repository_id** | **Integer** | The unique identifier of the repository. |  |
| **environment_name** | **String** | The name of the environment |  |
| **secret_name** | **String** | The name of the secret. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actions_delete_org_secret

> actions_delete_org_secret(org, secret_name)

Delete an organization secret

Deletes a secret in an organization using the secret name. You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `secrets` organization permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.

begin
  # Delete an organization secret
  api_instance.actions_delete_org_secret(org, secret_name)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_delete_org_secret: #{e}"
end
```

#### Using the actions_delete_org_secret_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_delete_org_secret_with_http_info(org, secret_name)

```ruby
begin
  # Delete an organization secret
  data, status_code, headers = api_instance.actions_delete_org_secret_with_http_info(org, secret_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_delete_org_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **secret_name** | **String** | The name of the secret. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actions_delete_repo_secret

> actions_delete_repo_secret(owner, repo, secret_name)

Delete a repository secret

Deletes a secret in a repository using the secret name. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `secrets` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.

begin
  # Delete a repository secret
  api_instance.actions_delete_repo_secret(owner, repo, secret_name)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_delete_repo_secret: #{e}"
end
```

#### Using the actions_delete_repo_secret_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_delete_repo_secret_with_http_info(owner, repo, secret_name)

```ruby
begin
  # Delete a repository secret
  data, status_code, headers = api_instance.actions_delete_repo_secret_with_http_info(owner, repo, secret_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_delete_repo_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **secret_name** | **String** | The name of the secret. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actions_delete_self_hosted_runner_from_org

> actions_delete_self_hosted_runner_from_org(org, runner_id)

Delete a self-hosted runner from an organization

Forces the removal of a self-hosted runner from an organization. You can use this endpoint to completely remove the runner when the machine you were using no longer exists.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.

begin
  # Delete a self-hosted runner from an organization
  api_instance.actions_delete_self_hosted_runner_from_org(org, runner_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_delete_self_hosted_runner_from_org: #{e}"
end
```

#### Using the actions_delete_self_hosted_runner_from_org_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_delete_self_hosted_runner_from_org_with_http_info(org, runner_id)

```ruby
begin
  # Delete a self-hosted runner from an organization
  data, status_code, headers = api_instance.actions_delete_self_hosted_runner_from_org_with_http_info(org, runner_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_delete_self_hosted_runner_from_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actions_delete_self_hosted_runner_from_repo

> actions_delete_self_hosted_runner_from_repo(owner, repo, runner_id)

Delete a self-hosted runner from a repository

Forces the removal of a self-hosted runner from a repository. You can use this endpoint to completely remove the runner when the machine you were using no longer exists.  You must authenticate using an access token with the `repo` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.

begin
  # Delete a self-hosted runner from a repository
  api_instance.actions_delete_self_hosted_runner_from_repo(owner, repo, runner_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_delete_self_hosted_runner_from_repo: #{e}"
end
```

#### Using the actions_delete_self_hosted_runner_from_repo_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_delete_self_hosted_runner_from_repo_with_http_info(owner, repo, runner_id)

```ruby
begin
  # Delete a self-hosted runner from a repository
  data, status_code, headers = api_instance.actions_delete_self_hosted_runner_from_repo_with_http_info(owner, repo, runner_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_delete_self_hosted_runner_from_repo_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actions_delete_self_hosted_runner_group_from_org

> actions_delete_self_hosted_runner_group_from_org(org, runner_group_id)

Delete a self-hosted runner group from an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"  Deletes a self-hosted runner group for an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
runner_group_id = 56 # Integer | Unique identifier of the self-hosted runner group.

begin
  # Delete a self-hosted runner group from an organization
  api_instance.actions_delete_self_hosted_runner_group_from_org(org, runner_group_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_delete_self_hosted_runner_group_from_org: #{e}"
end
```

#### Using the actions_delete_self_hosted_runner_group_from_org_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_delete_self_hosted_runner_group_from_org_with_http_info(org, runner_group_id)

```ruby
begin
  # Delete a self-hosted runner group from an organization
  data, status_code, headers = api_instance.actions_delete_self_hosted_runner_group_from_org_with_http_info(org, runner_group_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_delete_self_hosted_runner_group_from_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **runner_group_id** | **Integer** | Unique identifier of the self-hosted runner group. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actions_delete_workflow_run

> actions_delete_workflow_run(owner, repo, run_id)

Delete a workflow run

Delete a specific workflow run. Anyone with write access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:write` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
run_id = 56 # Integer | The unique identifier of the workflow run.

begin
  # Delete a workflow run
  api_instance.actions_delete_workflow_run(owner, repo, run_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_delete_workflow_run: #{e}"
end
```

#### Using the actions_delete_workflow_run_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_delete_workflow_run_with_http_info(owner, repo, run_id)

```ruby
begin
  # Delete a workflow run
  data, status_code, headers = api_instance.actions_delete_workflow_run_with_http_info(owner, repo, run_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_delete_workflow_run_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **run_id** | **Integer** | The unique identifier of the workflow run. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actions_delete_workflow_run_logs

> actions_delete_workflow_run_logs(owner, repo, run_id)

Delete workflow run logs

Deletes all logs for a workflow run. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
run_id = 56 # Integer | The unique identifier of the workflow run.

begin
  # Delete workflow run logs
  api_instance.actions_delete_workflow_run_logs(owner, repo, run_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_delete_workflow_run_logs: #{e}"
end
```

#### Using the actions_delete_workflow_run_logs_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_delete_workflow_run_logs_with_http_info(owner, repo, run_id)

```ruby
begin
  # Delete workflow run logs
  data, status_code, headers = api_instance.actions_delete_workflow_run_logs_with_http_info(owner, repo, run_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_delete_workflow_run_logs_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **run_id** | **Integer** | The unique identifier of the workflow run. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_disable_selected_repository_github_actions_organization

> actions_disable_selected_repository_github_actions_organization(org, repository_id)

Disable a selected repository for GitHub Actions in an organization

Removes a repository from the list of selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for `enabled_repositories` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\"  You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `administration` organization permission to use this API.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
repository_id = 56 # Integer | The unique identifier of the repository.

begin
  # Disable a selected repository for GitHub Actions in an organization
  api_instance.actions_disable_selected_repository_github_actions_organization(org, repository_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_disable_selected_repository_github_actions_organization: #{e}"
end
```

#### Using the actions_disable_selected_repository_github_actions_organization_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_disable_selected_repository_github_actions_organization_with_http_info(org, repository_id)

```ruby
begin
  # Disable a selected repository for GitHub Actions in an organization
  data, status_code, headers = api_instance.actions_disable_selected_repository_github_actions_organization_with_http_info(org, repository_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_disable_selected_repository_github_actions_organization_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **repository_id** | **Integer** | The unique identifier of the repository. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actions_disable_workflow

> actions_disable_workflow(owner, repo, workflow_id)

Disable a workflow

Disables a workflow and sets the `state` of the workflow to `disabled_manually`. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`.  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
workflow_id = nil # ActionsGetWorkflowWorkflowIdParameter | The ID of the workflow. You can also pass the workflow file name as a string.

begin
  # Disable a workflow
  api_instance.actions_disable_workflow(owner, repo, workflow_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_disable_workflow: #{e}"
end
```

#### Using the actions_disable_workflow_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_disable_workflow_with_http_info(owner, repo, workflow_id)

```ruby
begin
  # Disable a workflow
  data, status_code, headers = api_instance.actions_disable_workflow_with_http_info(owner, repo, workflow_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_disable_workflow_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **workflow_id** | [**ActionsGetWorkflowWorkflowIdParameter**](.md) | The ID of the workflow. You can also pass the workflow file name as a string. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actions_download_artifact

> actions_download_artifact(owner, repo, artifact_id, archive_format)

Download an artifact

Gets a redirect URL to download an archive for a repository. This URL expires after 1 minute. Look for `Location:` in the response header to find the URL for the download. The `:archive_format` must be `zip`. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
artifact_id = 56 # Integer | The unique identifier of the artifact.
archive_format = 'archive_format_example' # String | 

begin
  # Download an artifact
  api_instance.actions_download_artifact(owner, repo, artifact_id, archive_format)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_download_artifact: #{e}"
end
```

#### Using the actions_download_artifact_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_download_artifact_with_http_info(owner, repo, artifact_id, archive_format)

```ruby
begin
  # Download an artifact
  data, status_code, headers = api_instance.actions_download_artifact_with_http_info(owner, repo, artifact_id, archive_format)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_download_artifact_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **artifact_id** | **Integer** | The unique identifier of the artifact. |  |
| **archive_format** | **String** |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_download_job_logs_for_workflow_run

> actions_download_job_logs_for_workflow_run(owner, repo, job_id)

Download job logs for a workflow run

Gets a redirect URL to download a plain text file of logs for a workflow job. This link expires after 1 minute. Look for `Location:` in the response header to find the URL for the download. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
job_id = 56 # Integer | The unique identifier of the job.

begin
  # Download job logs for a workflow run
  api_instance.actions_download_job_logs_for_workflow_run(owner, repo, job_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_download_job_logs_for_workflow_run: #{e}"
end
```

#### Using the actions_download_job_logs_for_workflow_run_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_download_job_logs_for_workflow_run_with_http_info(owner, repo, job_id)

```ruby
begin
  # Download job logs for a workflow run
  data, status_code, headers = api_instance.actions_download_job_logs_for_workflow_run_with_http_info(owner, repo, job_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_download_job_logs_for_workflow_run_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **job_id** | **Integer** | The unique identifier of the job. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actions_download_workflow_run_attempt_logs

> actions_download_workflow_run_attempt_logs(owner, repo, run_id, attempt_number)

Download workflow run attempt logs

Gets a redirect URL to download an archive of log files for a specific workflow run attempt. This link expires after 1 minute. Look for `Location:` in the response header to find the URL for the download. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
run_id = 56 # Integer | The unique identifier of the workflow run.
attempt_number = 56 # Integer | The attempt number of the workflow run.

begin
  # Download workflow run attempt logs
  api_instance.actions_download_workflow_run_attempt_logs(owner, repo, run_id, attempt_number)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_download_workflow_run_attempt_logs: #{e}"
end
```

#### Using the actions_download_workflow_run_attempt_logs_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_download_workflow_run_attempt_logs_with_http_info(owner, repo, run_id, attempt_number)

```ruby
begin
  # Download workflow run attempt logs
  data, status_code, headers = api_instance.actions_download_workflow_run_attempt_logs_with_http_info(owner, repo, run_id, attempt_number)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_download_workflow_run_attempt_logs_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **run_id** | **Integer** | The unique identifier of the workflow run. |  |
| **attempt_number** | **Integer** | The attempt number of the workflow run. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actions_download_workflow_run_logs

> actions_download_workflow_run_logs(owner, repo, run_id)

Download workflow run logs

Gets a redirect URL to download an archive of log files for a workflow run. This link expires after 1 minute. Look for `Location:` in the response header to find the URL for the download. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
run_id = 56 # Integer | The unique identifier of the workflow run.

begin
  # Download workflow run logs
  api_instance.actions_download_workflow_run_logs(owner, repo, run_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_download_workflow_run_logs: #{e}"
end
```

#### Using the actions_download_workflow_run_logs_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_download_workflow_run_logs_with_http_info(owner, repo, run_id)

```ruby
begin
  # Download workflow run logs
  data, status_code, headers = api_instance.actions_download_workflow_run_logs_with_http_info(owner, repo, run_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_download_workflow_run_logs_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **run_id** | **Integer** | The unique identifier of the workflow run. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actions_enable_selected_repository_github_actions_organization

> actions_enable_selected_repository_github_actions_organization(org, repository_id)

Enable a selected repository for GitHub Actions in an organization

Adds a repository to the list of selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for `enabled_repositories` must be must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\"  You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `administration` organization permission to use this API.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
repository_id = 56 # Integer | The unique identifier of the repository.

begin
  # Enable a selected repository for GitHub Actions in an organization
  api_instance.actions_enable_selected_repository_github_actions_organization(org, repository_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_enable_selected_repository_github_actions_organization: #{e}"
end
```

#### Using the actions_enable_selected_repository_github_actions_organization_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_enable_selected_repository_github_actions_organization_with_http_info(org, repository_id)

```ruby
begin
  # Enable a selected repository for GitHub Actions in an organization
  data, status_code, headers = api_instance.actions_enable_selected_repository_github_actions_organization_with_http_info(org, repository_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_enable_selected_repository_github_actions_organization_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **repository_id** | **Integer** | The unique identifier of the repository. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actions_enable_workflow

> actions_enable_workflow(owner, repo, workflow_id)

Enable a workflow

Enables a workflow and sets the `state` of the workflow to `active`. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`.  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
workflow_id = nil # ActionsGetWorkflowWorkflowIdParameter | The ID of the workflow. You can also pass the workflow file name as a string.

begin
  # Enable a workflow
  api_instance.actions_enable_workflow(owner, repo, workflow_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_enable_workflow: #{e}"
end
```

#### Using the actions_enable_workflow_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_enable_workflow_with_http_info(owner, repo, workflow_id)

```ruby
begin
  # Enable a workflow
  data, status_code, headers = api_instance.actions_enable_workflow_with_http_info(owner, repo, workflow_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_enable_workflow_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **workflow_id** | [**ActionsGetWorkflowWorkflowIdParameter**](.md) | The ID of the workflow. You can also pass the workflow file name as a string. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actions_get_actions_cache_list

> <RepositoryActionsCaches> actions_get_actions_cache_list(owner, repo, opts)

List GitHub Actions caches for a repository

Lists the GitHub Actions caches for a repository. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56, # Integer | Page number of the results to fetch.
  ref: 'ref_example', # String | The Git reference for the results you want to list. The `ref` for a branch can be formatted either as `refs/heads/<branch name>` or simply `<branch name>`. To reference a pull request use `refs/pull/<number>/merge`.
  key: 'key_example', # String | An explicit key or prefix for identifying the cache
  sort: 'created_at', # String | The property to sort the results by. `created_at` means when the cache was created. `last_accessed_at` means when the cache was last accessed. `size_in_bytes` is the size of the cache in bytes.
  direction: 'asc' # String | The direction to sort the results by.
}

begin
  # List GitHub Actions caches for a repository
  result = api_instance.actions_get_actions_cache_list(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_actions_cache_list: #{e}"
end
```

#### Using the actions_get_actions_cache_list_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<RepositoryActionsCaches>, Integer, Hash)> actions_get_actions_cache_list_with_http_info(owner, repo, opts)

```ruby
begin
  # List GitHub Actions caches for a repository
  data, status_code, headers = api_instance.actions_get_actions_cache_list_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <RepositoryActionsCaches>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_actions_cache_list_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |
| **ref** | **String** | The Git reference for the results you want to list. The &#x60;ref&#x60; for a branch can be formatted either as &#x60;refs/heads/&lt;branch name&gt;&#x60; or simply &#x60;&lt;branch name&gt;&#x60;. To reference a pull request use &#x60;refs/pull/&lt;number&gt;/merge&#x60;. | [optional] |
| **key** | **String** | An explicit key or prefix for identifying the cache | [optional] |
| **sort** | **String** | The property to sort the results by. &#x60;created_at&#x60; means when the cache was created. &#x60;last_accessed_at&#x60; means when the cache was last accessed. &#x60;size_in_bytes&#x60; is the size of the cache in bytes. | [optional][default to &#39;last_accessed_at&#39;] |
| **direction** | **String** | The direction to sort the results by. | [optional][default to &#39;desc&#39;] |

### Return type

[**RepositoryActionsCaches**](RepositoryActionsCaches.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_actions_cache_usage

> <ActionsCacheUsageByRepository> actions_get_actions_cache_usage(owner, repo)

Get GitHub Actions cache usage for a repository

Gets GitHub Actions cache usage for a repository. The data fetched using this API is refreshed approximately every 5 minutes, so values returned from this endpoint may take at least 5 minutes to get updated. Anyone with read access to the repository can use this endpoint. If the repository is private, you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get GitHub Actions cache usage for a repository
  result = api_instance.actions_get_actions_cache_usage(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_actions_cache_usage: #{e}"
end
```

#### Using the actions_get_actions_cache_usage_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsCacheUsageByRepository>, Integer, Hash)> actions_get_actions_cache_usage_with_http_info(owner, repo)

```ruby
begin
  # Get GitHub Actions cache usage for a repository
  data, status_code, headers = api_instance.actions_get_actions_cache_usage_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsCacheUsageByRepository>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_actions_cache_usage_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**ActionsCacheUsageByRepository**](ActionsCacheUsageByRepository.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_actions_cache_usage_by_repo_for_org

> <ActionsGetActionsCacheUsageByRepoForOrg200Response> actions_get_actions_cache_usage_by_repo_for_org(org, opts)

List repositories with GitHub Actions cache usage for an organization

Lists repositories and their GitHub Actions cache usage for an organization. The data fetched using this API is refreshed approximately every 5 minutes, so values returned from this endpoint may take at least 5 minutes to get updated. You must authenticate using an access token with the `read:org` scope to use this endpoint. GitHub Apps must have the `organization_admistration:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List repositories with GitHub Actions cache usage for an organization
  result = api_instance.actions_get_actions_cache_usage_by_repo_for_org(org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_actions_cache_usage_by_repo_for_org: #{e}"
end
```

#### Using the actions_get_actions_cache_usage_by_repo_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsGetActionsCacheUsageByRepoForOrg200Response>, Integer, Hash)> actions_get_actions_cache_usage_by_repo_for_org_with_http_info(org, opts)

```ruby
begin
  # List repositories with GitHub Actions cache usage for an organization
  data, status_code, headers = api_instance.actions_get_actions_cache_usage_by_repo_for_org_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsGetActionsCacheUsageByRepoForOrg200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_actions_cache_usage_by_repo_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**ActionsGetActionsCacheUsageByRepoForOrg200Response**](ActionsGetActionsCacheUsageByRepoForOrg200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_actions_cache_usage_for_enterprise

> <ActionsGetActionsCacheUsageForEnterprise200Response> actions_get_actions_cache_usage_for_enterprise(enterprise)

Get GitHub Actions cache usage for an enterprise

Gets the total GitHub Actions cache usage for an enterprise. The data fetched using this API is refreshed approximately every 5 minutes, so values returned from this endpoint may take at least 5 minutes to get updated. You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.

begin
  # Get GitHub Actions cache usage for an enterprise
  result = api_instance.actions_get_actions_cache_usage_for_enterprise(enterprise)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_actions_cache_usage_for_enterprise: #{e}"
end
```

#### Using the actions_get_actions_cache_usage_for_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsGetActionsCacheUsageForEnterprise200Response>, Integer, Hash)> actions_get_actions_cache_usage_for_enterprise_with_http_info(enterprise)

```ruby
begin
  # Get GitHub Actions cache usage for an enterprise
  data, status_code, headers = api_instance.actions_get_actions_cache_usage_for_enterprise_with_http_info(enterprise)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsGetActionsCacheUsageForEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_actions_cache_usage_for_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |

### Return type

[**ActionsGetActionsCacheUsageForEnterprise200Response**](ActionsGetActionsCacheUsageForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_actions_cache_usage_for_org

> <ActionsGetActionsCacheUsageForEnterprise200Response> actions_get_actions_cache_usage_for_org(org)

Get GitHub Actions cache usage for an organization

Gets the total GitHub Actions cache usage for an organization. The data fetched using this API is refreshed approximately every 5 minutes, so values returned from this endpoint may take at least 5 minutes to get updated. You must authenticate using an access token with the `read:org` scope to use this endpoint. GitHub Apps must have the `organization_admistration:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.

begin
  # Get GitHub Actions cache usage for an organization
  result = api_instance.actions_get_actions_cache_usage_for_org(org)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_actions_cache_usage_for_org: #{e}"
end
```

#### Using the actions_get_actions_cache_usage_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsGetActionsCacheUsageForEnterprise200Response>, Integer, Hash)> actions_get_actions_cache_usage_for_org_with_http_info(org)

```ruby
begin
  # Get GitHub Actions cache usage for an organization
  data, status_code, headers = api_instance.actions_get_actions_cache_usage_for_org_with_http_info(org)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsGetActionsCacheUsageForEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_actions_cache_usage_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |

### Return type

[**ActionsGetActionsCacheUsageForEnterprise200Response**](ActionsGetActionsCacheUsageForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_allowed_actions_organization

> <EnterpriseAdminGetAllowedActionsEnterprise200Response> actions_get_allowed_actions_organization(org)

Get allowed actions and reusable workflows for an organization

Gets the selected actions and reusable workflows that are allowed in an organization. To use this endpoint, the organization permission policy for `allowed_actions` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\"\"  You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `administration` organization permission to use this API.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.

begin
  # Get allowed actions and reusable workflows for an organization
  result = api_instance.actions_get_allowed_actions_organization(org)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_allowed_actions_organization: #{e}"
end
```

#### Using the actions_get_allowed_actions_organization_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminGetAllowedActionsEnterprise200Response>, Integer, Hash)> actions_get_allowed_actions_organization_with_http_info(org)

```ruby
begin
  # Get allowed actions and reusable workflows for an organization
  data, status_code, headers = api_instance.actions_get_allowed_actions_organization_with_http_info(org)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminGetAllowedActionsEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_allowed_actions_organization_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |

### Return type

[**EnterpriseAdminGetAllowedActionsEnterprise200Response**](EnterpriseAdminGetAllowedActionsEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_allowed_actions_repository

> <EnterpriseAdminGetAllowedActionsEnterprise200Response> actions_get_allowed_actions_repository(owner, repo)

Get allowed actions and reusable workflows for a repository

Gets the settings for selected actions and reusable workflows that are allowed in a repository. To use this endpoint, the repository policy for `allowed_actions` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for a repository](#set-github-actions-permissions-for-a-repository).\"  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `administration` repository permission to use this API.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get allowed actions and reusable workflows for a repository
  result = api_instance.actions_get_allowed_actions_repository(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_allowed_actions_repository: #{e}"
end
```

#### Using the actions_get_allowed_actions_repository_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminGetAllowedActionsEnterprise200Response>, Integer, Hash)> actions_get_allowed_actions_repository_with_http_info(owner, repo)

```ruby
begin
  # Get allowed actions and reusable workflows for a repository
  data, status_code, headers = api_instance.actions_get_allowed_actions_repository_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminGetAllowedActionsEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_allowed_actions_repository_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**EnterpriseAdminGetAllowedActionsEnterprise200Response**](EnterpriseAdminGetAllowedActionsEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_artifact

> <Artifact> actions_get_artifact(owner, repo, artifact_id)

Get an artifact

Gets a specific artifact for a workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
artifact_id = 56 # Integer | The unique identifier of the artifact.

begin
  # Get an artifact
  result = api_instance.actions_get_artifact(owner, repo, artifact_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_artifact: #{e}"
end
```

#### Using the actions_get_artifact_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Artifact>, Integer, Hash)> actions_get_artifact_with_http_info(owner, repo, artifact_id)

```ruby
begin
  # Get an artifact
  data, status_code, headers = api_instance.actions_get_artifact_with_http_info(owner, repo, artifact_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Artifact>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_artifact_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **artifact_id** | **Integer** | The unique identifier of the artifact. |  |

### Return type

[**Artifact**](Artifact.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_custom_oidc_sub_claim_for_repo

> <TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization> actions_get_custom_oidc_sub_claim_for_repo(owner, repo)

Get the opt-out flag of an OIDC subject claim customization for a repository

Gets the `opt-out` flag of a GitHub Actions OpenID Connect (OIDC) subject claim customization for a repository. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `organization_administration:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get the opt-out flag of an OIDC subject claim customization for a repository
  result = api_instance.actions_get_custom_oidc_sub_claim_for_repo(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_custom_oidc_sub_claim_for_repo: #{e}"
end
```

#### Using the actions_get_custom_oidc_sub_claim_for_repo_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization>, Integer, Hash)> actions_get_custom_oidc_sub_claim_for_repo_with_http_info(owner, repo)

```ruby
begin
  # Get the opt-out flag of an OIDC subject claim customization for a repository
  data, status_code, headers = api_instance.actions_get_custom_oidc_sub_claim_for_repo_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_custom_oidc_sub_claim_for_repo_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization**](TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/scim+json


## actions_get_environment_public_key

> <ActionsPublicKey> actions_get_environment_public_key(repository_id, environment_name)

Get an environment public key

Get the public key for an environment, which you need to encrypt environment secrets. You need to encrypt a secret before you can create or update secrets. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `secrets` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
repository_id = 56 # Integer | The unique identifier of the repository.
environment_name = 'environment_name_example' # String | The name of the environment

begin
  # Get an environment public key
  result = api_instance.actions_get_environment_public_key(repository_id, environment_name)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_environment_public_key: #{e}"
end
```

#### Using the actions_get_environment_public_key_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsPublicKey>, Integer, Hash)> actions_get_environment_public_key_with_http_info(repository_id, environment_name)

```ruby
begin
  # Get an environment public key
  data, status_code, headers = api_instance.actions_get_environment_public_key_with_http_info(repository_id, environment_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsPublicKey>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_environment_public_key_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **repository_id** | **Integer** | The unique identifier of the repository. |  |
| **environment_name** | **String** | The name of the environment |  |

### Return type

[**ActionsPublicKey**](ActionsPublicKey.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_environment_secret

> <ActionsSecret> actions_get_environment_secret(repository_id, environment_name, secret_name)

Get an environment secret

Gets a single environment secret without revealing its encrypted value. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `secrets` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
repository_id = 56 # Integer | The unique identifier of the repository.
environment_name = 'environment_name_example' # String | The name of the environment
secret_name = 'secret_name_example' # String | The name of the secret.

begin
  # Get an environment secret
  result = api_instance.actions_get_environment_secret(repository_id, environment_name, secret_name)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_environment_secret: #{e}"
end
```

#### Using the actions_get_environment_secret_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsSecret>, Integer, Hash)> actions_get_environment_secret_with_http_info(repository_id, environment_name, secret_name)

```ruby
begin
  # Get an environment secret
  data, status_code, headers = api_instance.actions_get_environment_secret_with_http_info(repository_id, environment_name, secret_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsSecret>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_environment_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **repository_id** | **Integer** | The unique identifier of the repository. |  |
| **environment_name** | **String** | The name of the environment |  |
| **secret_name** | **String** | The name of the secret. |  |

### Return type

[**ActionsSecret**](ActionsSecret.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_github_actions_default_workflow_permissions_enterprise

> <ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response> actions_get_github_actions_default_workflow_permissions_enterprise(enterprise)

Get default workflow permissions for an enterprise

Gets the default workflow permissions granted to the `GITHUB_TOKEN` when running workflows in an enterprise, as well as whether GitHub Actions can submit approving pull request reviews. For more information, see \"[Enforcing a policy for workflow permissions in your enterprise](https://docs.github.com/enterprise-cloud@latest/admin/policies/enforcing-policies-for-your-enterprise/enforcing-policies-for-github-actions-in-your-enterprise#enforcing-a-policy-for-workflow-permissions-in-your-enterprise).\"  You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint. GitHub Apps must have the `enterprise_administration:write` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.

begin
  # Get default workflow permissions for an enterprise
  result = api_instance.actions_get_github_actions_default_workflow_permissions_enterprise(enterprise)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_github_actions_default_workflow_permissions_enterprise: #{e}"
end
```

#### Using the actions_get_github_actions_default_workflow_permissions_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response>, Integer, Hash)> actions_get_github_actions_default_workflow_permissions_enterprise_with_http_info(enterprise)

```ruby
begin
  # Get default workflow permissions for an enterprise
  data, status_code, headers = api_instance.actions_get_github_actions_default_workflow_permissions_enterprise_with_http_info(enterprise)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_github_actions_default_workflow_permissions_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |

### Return type

[**ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response**](ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_github_actions_default_workflow_permissions_organization

> <ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response> actions_get_github_actions_default_workflow_permissions_organization(org)

Get default workflow permissions for an organization

Gets the default workflow permissions granted to the `GITHUB_TOKEN` when running workflows in an organization, as well as whether GitHub Actions can submit approving pull request reviews. For more information, see \"[Setting the permissions of the GITHUB_TOKEN for your organization](https://docs.github.com/organizations/managing-organization-settings/disabling-or-limiting-github-actions-for-your-organization#setting-the-permissions-of-the-github_token-for-your-organization).\"  You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `administration` organization permission to use this API.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.

begin
  # Get default workflow permissions for an organization
  result = api_instance.actions_get_github_actions_default_workflow_permissions_organization(org)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_github_actions_default_workflow_permissions_organization: #{e}"
end
```

#### Using the actions_get_github_actions_default_workflow_permissions_organization_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response>, Integer, Hash)> actions_get_github_actions_default_workflow_permissions_organization_with_http_info(org)

```ruby
begin
  # Get default workflow permissions for an organization
  data, status_code, headers = api_instance.actions_get_github_actions_default_workflow_permissions_organization_with_http_info(org)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_github_actions_default_workflow_permissions_organization_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |

### Return type

[**ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response**](ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_github_actions_default_workflow_permissions_repository

> <ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response> actions_get_github_actions_default_workflow_permissions_repository(owner, repo)

Get default workflow permissions for a repository

Gets the default workflow permissions granted to the `GITHUB_TOKEN` when running workflows in a repository, as well as if GitHub Actions can submit approving pull request reviews. For more information, see \"[Setting the permissions of the GITHUB_TOKEN for your repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#setting-the-permissions-of-the-github_token-for-your-repository).\"  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the repository `administration` permission to use this API.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get default workflow permissions for a repository
  result = api_instance.actions_get_github_actions_default_workflow_permissions_repository(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_github_actions_default_workflow_permissions_repository: #{e}"
end
```

#### Using the actions_get_github_actions_default_workflow_permissions_repository_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response>, Integer, Hash)> actions_get_github_actions_default_workflow_permissions_repository_with_http_info(owner, repo)

```ruby
begin
  # Get default workflow permissions for a repository
  data, status_code, headers = api_instance.actions_get_github_actions_default_workflow_permissions_repository_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_github_actions_default_workflow_permissions_repository_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response**](ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_github_actions_permissions_organization

> <ActionsGetGithubActionsPermissionsOrganization200Response> actions_get_github_actions_permissions_organization(org)

Get GitHub Actions permissions for an organization

Gets the GitHub Actions permissions policy for repositories and allowed actions and reusable workflows in an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `administration` organization permission to use this API.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.

begin
  # Get GitHub Actions permissions for an organization
  result = api_instance.actions_get_github_actions_permissions_organization(org)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_github_actions_permissions_organization: #{e}"
end
```

#### Using the actions_get_github_actions_permissions_organization_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsGetGithubActionsPermissionsOrganization200Response>, Integer, Hash)> actions_get_github_actions_permissions_organization_with_http_info(org)

```ruby
begin
  # Get GitHub Actions permissions for an organization
  data, status_code, headers = api_instance.actions_get_github_actions_permissions_organization_with_http_info(org)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsGetGithubActionsPermissionsOrganization200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_github_actions_permissions_organization_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |

### Return type

[**ActionsGetGithubActionsPermissionsOrganization200Response**](ActionsGetGithubActionsPermissionsOrganization200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_github_actions_permissions_repository

> <ActionsGetGithubActionsPermissionsRepository200Response> actions_get_github_actions_permissions_repository(owner, repo)

Get GitHub Actions permissions for a repository

Gets the GitHub Actions permissions policy for a repository, including whether GitHub Actions is enabled and the actions and reusable workflows allowed to run in the repository.  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `administration` repository permission to use this API.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get GitHub Actions permissions for a repository
  result = api_instance.actions_get_github_actions_permissions_repository(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_github_actions_permissions_repository: #{e}"
end
```

#### Using the actions_get_github_actions_permissions_repository_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsGetGithubActionsPermissionsRepository200Response>, Integer, Hash)> actions_get_github_actions_permissions_repository_with_http_info(owner, repo)

```ruby
begin
  # Get GitHub Actions permissions for a repository
  data, status_code, headers = api_instance.actions_get_github_actions_permissions_repository_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsGetGithubActionsPermissionsRepository200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_github_actions_permissions_repository_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**ActionsGetGithubActionsPermissionsRepository200Response**](ActionsGetGithubActionsPermissionsRepository200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_job_for_workflow_run

> <Job> actions_get_job_for_workflow_run(owner, repo, job_id)

Get a job for a workflow run

Gets a specific job in a workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
job_id = 56 # Integer | The unique identifier of the job.

begin
  # Get a job for a workflow run
  result = api_instance.actions_get_job_for_workflow_run(owner, repo, job_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_job_for_workflow_run: #{e}"
end
```

#### Using the actions_get_job_for_workflow_run_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Job>, Integer, Hash)> actions_get_job_for_workflow_run_with_http_info(owner, repo, job_id)

```ruby
begin
  # Get a job for a workflow run
  data, status_code, headers = api_instance.actions_get_job_for_workflow_run_with_http_info(owner, repo, job_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Job>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_job_for_workflow_run_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **job_id** | **Integer** | The unique identifier of the job. |  |

### Return type

[**Job**](Job.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_org_public_key

> <ActionsPublicKey> actions_get_org_public_key(org)

Get an organization public key

Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets. You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `secrets` organization permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.

begin
  # Get an organization public key
  result = api_instance.actions_get_org_public_key(org)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_org_public_key: #{e}"
end
```

#### Using the actions_get_org_public_key_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsPublicKey>, Integer, Hash)> actions_get_org_public_key_with_http_info(org)

```ruby
begin
  # Get an organization public key
  data, status_code, headers = api_instance.actions_get_org_public_key_with_http_info(org)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsPublicKey>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_org_public_key_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |

### Return type

[**ActionsPublicKey**](ActionsPublicKey.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_org_secret

> <ActionsSecretForAnOrganization> actions_get_org_secret(org, secret_name)

Get an organization secret

Gets a single organization secret without revealing its encrypted value. You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `secrets` organization permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.

begin
  # Get an organization secret
  result = api_instance.actions_get_org_secret(org, secret_name)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_org_secret: #{e}"
end
```

#### Using the actions_get_org_secret_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsSecretForAnOrganization>, Integer, Hash)> actions_get_org_secret_with_http_info(org, secret_name)

```ruby
begin
  # Get an organization secret
  data, status_code, headers = api_instance.actions_get_org_secret_with_http_info(org, secret_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsSecretForAnOrganization>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_org_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **secret_name** | **String** | The name of the secret. |  |

### Return type

[**ActionsSecretForAnOrganization**](ActionsSecretForAnOrganization.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_pending_deployments_for_run

> <Array<PendingDeployment>> actions_get_pending_deployments_for_run(owner, repo, run_id)

Get pending deployments for a workflow run

Get all deployment environments for a workflow run that are waiting for protection rules to pass.  Anyone with read access to the repository can use this endpoint. If the repository is private, you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
run_id = 56 # Integer | The unique identifier of the workflow run.

begin
  # Get pending deployments for a workflow run
  result = api_instance.actions_get_pending_deployments_for_run(owner, repo, run_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_pending_deployments_for_run: #{e}"
end
```

#### Using the actions_get_pending_deployments_for_run_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<PendingDeployment>>, Integer, Hash)> actions_get_pending_deployments_for_run_with_http_info(owner, repo, run_id)

```ruby
begin
  # Get pending deployments for a workflow run
  data, status_code, headers = api_instance.actions_get_pending_deployments_for_run_with_http_info(owner, repo, run_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<PendingDeployment>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_pending_deployments_for_run_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **run_id** | **Integer** | The unique identifier of the workflow run. |  |

### Return type

[**Array&lt;PendingDeployment&gt;**](PendingDeployment.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_repo_public_key

> <ActionsPublicKey> actions_get_repo_public_key(owner, repo)

Get a repository public key

Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `secrets` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get a repository public key
  result = api_instance.actions_get_repo_public_key(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_repo_public_key: #{e}"
end
```

#### Using the actions_get_repo_public_key_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsPublicKey>, Integer, Hash)> actions_get_repo_public_key_with_http_info(owner, repo)

```ruby
begin
  # Get a repository public key
  data, status_code, headers = api_instance.actions_get_repo_public_key_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsPublicKey>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_repo_public_key_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**ActionsPublicKey**](ActionsPublicKey.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_repo_secret

> <ActionsSecret> actions_get_repo_secret(owner, repo, secret_name)

Get a repository secret

Gets a single repository secret without revealing its encrypted value. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `secrets` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.

begin
  # Get a repository secret
  result = api_instance.actions_get_repo_secret(owner, repo, secret_name)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_repo_secret: #{e}"
end
```

#### Using the actions_get_repo_secret_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsSecret>, Integer, Hash)> actions_get_repo_secret_with_http_info(owner, repo, secret_name)

```ruby
begin
  # Get a repository secret
  data, status_code, headers = api_instance.actions_get_repo_secret_with_http_info(owner, repo, secret_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsSecret>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_repo_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **secret_name** | **String** | The name of the secret. |  |

### Return type

[**ActionsSecret**](ActionsSecret.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_reviews_for_run

> <Array<EnvironmentApproval>> actions_get_reviews_for_run(owner, repo, run_id)

Get the review history for a workflow run

Anyone with read access to the repository can use this endpoint. If the repository is private, you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
run_id = 56 # Integer | The unique identifier of the workflow run.

begin
  # Get the review history for a workflow run
  result = api_instance.actions_get_reviews_for_run(owner, repo, run_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_reviews_for_run: #{e}"
end
```

#### Using the actions_get_reviews_for_run_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<EnvironmentApproval>>, Integer, Hash)> actions_get_reviews_for_run_with_http_info(owner, repo, run_id)

```ruby
begin
  # Get the review history for a workflow run
  data, status_code, headers = api_instance.actions_get_reviews_for_run_with_http_info(owner, repo, run_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<EnvironmentApproval>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_reviews_for_run_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **run_id** | **Integer** | The unique identifier of the workflow run. |  |

### Return type

[**Array&lt;EnvironmentApproval&gt;**](EnvironmentApproval.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_self_hosted_runner_for_org

> <SelfHostedRunners> actions_get_self_hosted_runner_for_org(org, runner_id)

Get a self-hosted runner for an organization

Gets a specific self-hosted runner configured in an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.

begin
  # Get a self-hosted runner for an organization
  result = api_instance.actions_get_self_hosted_runner_for_org(org, runner_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_self_hosted_runner_for_org: #{e}"
end
```

#### Using the actions_get_self_hosted_runner_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<SelfHostedRunners>, Integer, Hash)> actions_get_self_hosted_runner_for_org_with_http_info(org, runner_id)

```ruby
begin
  # Get a self-hosted runner for an organization
  data, status_code, headers = api_instance.actions_get_self_hosted_runner_for_org_with_http_info(org, runner_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <SelfHostedRunners>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_self_hosted_runner_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |

### Return type

[**SelfHostedRunners**](SelfHostedRunners.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_self_hosted_runner_for_repo

> <SelfHostedRunners> actions_get_self_hosted_runner_for_repo(owner, repo, runner_id)

Get a self-hosted runner for a repository

Gets a specific self-hosted runner configured in a repository.  You must authenticate using an access token with the `repo` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.

begin
  # Get a self-hosted runner for a repository
  result = api_instance.actions_get_self_hosted_runner_for_repo(owner, repo, runner_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_self_hosted_runner_for_repo: #{e}"
end
```

#### Using the actions_get_self_hosted_runner_for_repo_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<SelfHostedRunners>, Integer, Hash)> actions_get_self_hosted_runner_for_repo_with_http_info(owner, repo, runner_id)

```ruby
begin
  # Get a self-hosted runner for a repository
  data, status_code, headers = api_instance.actions_get_self_hosted_runner_for_repo_with_http_info(owner, repo, runner_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <SelfHostedRunners>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_self_hosted_runner_for_repo_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |

### Return type

[**SelfHostedRunners**](SelfHostedRunners.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_self_hosted_runner_group_for_org

> <ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner> actions_get_self_hosted_runner_group_for_org(org, runner_group_id)

Get a self-hosted runner group for an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"  Gets a specific self-hosted runner group for an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
runner_group_id = 56 # Integer | Unique identifier of the self-hosted runner group.

begin
  # Get a self-hosted runner group for an organization
  result = api_instance.actions_get_self_hosted_runner_group_for_org(org, runner_group_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_self_hosted_runner_group_for_org: #{e}"
end
```

#### Using the actions_get_self_hosted_runner_group_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner>, Integer, Hash)> actions_get_self_hosted_runner_group_for_org_with_http_info(org, runner_group_id)

```ruby
begin
  # Get a self-hosted runner group for an organization
  data, status_code, headers = api_instance.actions_get_self_hosted_runner_group_for_org_with_http_info(org, runner_group_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_self_hosted_runner_group_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **runner_group_id** | **Integer** | Unique identifier of the self-hosted runner group. |  |

### Return type

[**ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner**](ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_workflow

> <Workflow> actions_get_workflow(owner, repo, workflow_id)

Get a workflow

Gets a specific workflow. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
workflow_id = nil # ActionsGetWorkflowWorkflowIdParameter | The ID of the workflow. You can also pass the workflow file name as a string.

begin
  # Get a workflow
  result = api_instance.actions_get_workflow(owner, repo, workflow_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_workflow: #{e}"
end
```

#### Using the actions_get_workflow_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Workflow>, Integer, Hash)> actions_get_workflow_with_http_info(owner, repo, workflow_id)

```ruby
begin
  # Get a workflow
  data, status_code, headers = api_instance.actions_get_workflow_with_http_info(owner, repo, workflow_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Workflow>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_workflow_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **workflow_id** | [**ActionsGetWorkflowWorkflowIdParameter**](.md) | The ID of the workflow. You can also pass the workflow file name as a string. |  |

### Return type

[**Workflow**](Workflow.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_workflow_access_to_repository

> <ActionsGetWorkflowAccessToRepository200Response> actions_get_workflow_access_to_repository(owner, repo)

Get the level of access for workflows outside of the repository

Gets the level of access that workflows outside of the repository have to actions and reusable workflows in the repository. This endpoint only applies to internal and private repositories. For more information, see \"[Managing GitHub Actions settings for a repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#allowing-access-to-components-in-a-private-repository)\" for GitHub.com and \"[Managing GitHub Actions settings for a repository](https://docs.github.com/enterprise-cloud@latest/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#allowing-access-to-components-in-an-internal-repository)\" for GitHub Enterprise Cloud.  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the repository `administration` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get the level of access for workflows outside of the repository
  result = api_instance.actions_get_workflow_access_to_repository(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_workflow_access_to_repository: #{e}"
end
```

#### Using the actions_get_workflow_access_to_repository_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsGetWorkflowAccessToRepository200Response>, Integer, Hash)> actions_get_workflow_access_to_repository_with_http_info(owner, repo)

```ruby
begin
  # Get the level of access for workflows outside of the repository
  data, status_code, headers = api_instance.actions_get_workflow_access_to_repository_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsGetWorkflowAccessToRepository200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_workflow_access_to_repository_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**ActionsGetWorkflowAccessToRepository200Response**](ActionsGetWorkflowAccessToRepository200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_workflow_run

> <WorkflowRun> actions_get_workflow_run(owner, repo, run_id, opts)

Get a workflow run

Gets a specific workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
run_id = 56 # Integer | The unique identifier of the workflow run.
opts = {
  exclude_pull_requests: true # Boolean | If `true` pull requests are omitted from the response (empty array).
}

begin
  # Get a workflow run
  result = api_instance.actions_get_workflow_run(owner, repo, run_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_workflow_run: #{e}"
end
```

#### Using the actions_get_workflow_run_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<WorkflowRun>, Integer, Hash)> actions_get_workflow_run_with_http_info(owner, repo, run_id, opts)

```ruby
begin
  # Get a workflow run
  data, status_code, headers = api_instance.actions_get_workflow_run_with_http_info(owner, repo, run_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <WorkflowRun>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_workflow_run_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **run_id** | **Integer** | The unique identifier of the workflow run. |  |
| **exclude_pull_requests** | **Boolean** | If &#x60;true&#x60; pull requests are omitted from the response (empty array). | [optional][default to false] |

### Return type

[**WorkflowRun**](WorkflowRun.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_workflow_run_attempt

> <WorkflowRun> actions_get_workflow_run_attempt(owner, repo, run_id, attempt_number, opts)

Get a workflow run attempt

Gets a specific workflow run attempt. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
run_id = 56 # Integer | The unique identifier of the workflow run.
attempt_number = 56 # Integer | The attempt number of the workflow run.
opts = {
  exclude_pull_requests: true # Boolean | If `true` pull requests are omitted from the response (empty array).
}

begin
  # Get a workflow run attempt
  result = api_instance.actions_get_workflow_run_attempt(owner, repo, run_id, attempt_number, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_workflow_run_attempt: #{e}"
end
```

#### Using the actions_get_workflow_run_attempt_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<WorkflowRun>, Integer, Hash)> actions_get_workflow_run_attempt_with_http_info(owner, repo, run_id, attempt_number, opts)

```ruby
begin
  # Get a workflow run attempt
  data, status_code, headers = api_instance.actions_get_workflow_run_attempt_with_http_info(owner, repo, run_id, attempt_number, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <WorkflowRun>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_workflow_run_attempt_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **run_id** | **Integer** | The unique identifier of the workflow run. |  |
| **attempt_number** | **Integer** | The attempt number of the workflow run. |  |
| **exclude_pull_requests** | **Boolean** | If &#x60;true&#x60; pull requests are omitted from the response (empty array). | [optional][default to false] |

### Return type

[**WorkflowRun**](WorkflowRun.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_workflow_run_usage

> <WorkflowRunUsage> actions_get_workflow_run_usage(owner, repo, run_id)

Get workflow run usage

Gets the number of billable minutes and total run time for a specific workflow run. Billable minutes only apply to workflows in private repositories that use GitHub-hosted runners. Usage is listed for each GitHub-hosted runner operating system in milliseconds. Any job re-runs are also included in the usage. The usage does not include the multiplier for macOS and Windows runners and is not rounded up to the nearest whole minute. For more information, see \"[Managing billing for GitHub Actions](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-actions)\".  Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
run_id = 56 # Integer | The unique identifier of the workflow run.

begin
  # Get workflow run usage
  result = api_instance.actions_get_workflow_run_usage(owner, repo, run_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_workflow_run_usage: #{e}"
end
```

#### Using the actions_get_workflow_run_usage_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<WorkflowRunUsage>, Integer, Hash)> actions_get_workflow_run_usage_with_http_info(owner, repo, run_id)

```ruby
begin
  # Get workflow run usage
  data, status_code, headers = api_instance.actions_get_workflow_run_usage_with_http_info(owner, repo, run_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <WorkflowRunUsage>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_workflow_run_usage_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **run_id** | **Integer** | The unique identifier of the workflow run. |  |

### Return type

[**WorkflowRunUsage**](WorkflowRunUsage.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_get_workflow_usage

> <WorkflowUsage> actions_get_workflow_usage(owner, repo, workflow_id)

Get workflow usage

Gets the number of billable minutes used by a specific workflow during the current billing cycle. Billable minutes only apply to workflows in private repositories that use GitHub-hosted runners. Usage is listed for each GitHub-hosted runner operating system in milliseconds. Any job re-runs are also included in the usage. The usage does not include the multiplier for macOS and Windows runners and is not rounded up to the nearest whole minute. For more information, see \"[Managing billing for GitHub Actions](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-actions)\".  You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
workflow_id = nil # ActionsGetWorkflowWorkflowIdParameter | The ID of the workflow. You can also pass the workflow file name as a string.

begin
  # Get workflow usage
  result = api_instance.actions_get_workflow_usage(owner, repo, workflow_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_workflow_usage: #{e}"
end
```

#### Using the actions_get_workflow_usage_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<WorkflowUsage>, Integer, Hash)> actions_get_workflow_usage_with_http_info(owner, repo, workflow_id)

```ruby
begin
  # Get workflow usage
  data, status_code, headers = api_instance.actions_get_workflow_usage_with_http_info(owner, repo, workflow_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <WorkflowUsage>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_get_workflow_usage_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **workflow_id** | [**ActionsGetWorkflowWorkflowIdParameter**](.md) | The ID of the workflow. You can also pass the workflow file name as a string. |  |

### Return type

[**WorkflowUsage**](WorkflowUsage.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_list_artifacts_for_repo

> <ActionsListArtifactsForRepo200Response> actions_list_artifacts_for_repo(owner, repo, opts)

List artifacts for a repository

Lists all artifacts for a repository. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List artifacts for a repository
  result = api_instance.actions_list_artifacts_for_repo(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_artifacts_for_repo: #{e}"
end
```

#### Using the actions_list_artifacts_for_repo_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsListArtifactsForRepo200Response>, Integer, Hash)> actions_list_artifacts_for_repo_with_http_info(owner, repo, opts)

```ruby
begin
  # List artifacts for a repository
  data, status_code, headers = api_instance.actions_list_artifacts_for_repo_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsListArtifactsForRepo200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_artifacts_for_repo_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**ActionsListArtifactsForRepo200Response**](ActionsListArtifactsForRepo200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_list_environment_secrets

> <ActionsListRepoSecrets200Response> actions_list_environment_secrets(repository_id, environment_name, opts)

List environment secrets

Lists all secrets available in an environment without revealing their encrypted values. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `secrets` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
repository_id = 56 # Integer | The unique identifier of the repository.
environment_name = 'environment_name_example' # String | The name of the environment
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List environment secrets
  result = api_instance.actions_list_environment_secrets(repository_id, environment_name, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_environment_secrets: #{e}"
end
```

#### Using the actions_list_environment_secrets_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsListRepoSecrets200Response>, Integer, Hash)> actions_list_environment_secrets_with_http_info(repository_id, environment_name, opts)

```ruby
begin
  # List environment secrets
  data, status_code, headers = api_instance.actions_list_environment_secrets_with_http_info(repository_id, environment_name, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsListRepoSecrets200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_environment_secrets_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **repository_id** | **Integer** | The unique identifier of the repository. |  |
| **environment_name** | **String** | The name of the environment |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**ActionsListRepoSecrets200Response**](ActionsListRepoSecrets200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_list_jobs_for_workflow_run

> <ActionsListJobsForWorkflowRunAttempt200Response> actions_list_jobs_for_workflow_run(owner, repo, run_id, opts)

List jobs for a workflow run

Lists jobs for a workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/overview/resources-in-the-rest-api#parameters).

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
run_id = 56 # Integer | The unique identifier of the workflow run.
opts = {
  filter: 'latest', # String | Filters jobs by their `completed_at` timestamp. `latest` returns jobs from the most recent execution of the workflow run. `all` returns all jobs for a workflow run, including from old executions of the workflow run.
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List jobs for a workflow run
  result = api_instance.actions_list_jobs_for_workflow_run(owner, repo, run_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_jobs_for_workflow_run: #{e}"
end
```

#### Using the actions_list_jobs_for_workflow_run_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsListJobsForWorkflowRunAttempt200Response>, Integer, Hash)> actions_list_jobs_for_workflow_run_with_http_info(owner, repo, run_id, opts)

```ruby
begin
  # List jobs for a workflow run
  data, status_code, headers = api_instance.actions_list_jobs_for_workflow_run_with_http_info(owner, repo, run_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsListJobsForWorkflowRunAttempt200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_jobs_for_workflow_run_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **run_id** | **Integer** | The unique identifier of the workflow run. |  |
| **filter** | **String** | Filters jobs by their &#x60;completed_at&#x60; timestamp. &#x60;latest&#x60; returns jobs from the most recent execution of the workflow run. &#x60;all&#x60; returns all jobs for a workflow run, including from old executions of the workflow run. | [optional][default to &#39;latest&#39;] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**ActionsListJobsForWorkflowRunAttempt200Response**](ActionsListJobsForWorkflowRunAttempt200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_list_jobs_for_workflow_run_attempt

> <ActionsListJobsForWorkflowRunAttempt200Response> actions_list_jobs_for_workflow_run_attempt(owner, repo, run_id, attempt_number, opts)

List jobs for a workflow run attempt

Lists jobs for a specific workflow run attempt. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/overview/resources-in-the-rest-api#parameters).

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
run_id = 56 # Integer | The unique identifier of the workflow run.
attempt_number = 56 # Integer | The attempt number of the workflow run.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List jobs for a workflow run attempt
  result = api_instance.actions_list_jobs_for_workflow_run_attempt(owner, repo, run_id, attempt_number, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_jobs_for_workflow_run_attempt: #{e}"
end
```

#### Using the actions_list_jobs_for_workflow_run_attempt_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsListJobsForWorkflowRunAttempt200Response>, Integer, Hash)> actions_list_jobs_for_workflow_run_attempt_with_http_info(owner, repo, run_id, attempt_number, opts)

```ruby
begin
  # List jobs for a workflow run attempt
  data, status_code, headers = api_instance.actions_list_jobs_for_workflow_run_attempt_with_http_info(owner, repo, run_id, attempt_number, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsListJobsForWorkflowRunAttempt200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_jobs_for_workflow_run_attempt_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **run_id** | **Integer** | The unique identifier of the workflow run. |  |
| **attempt_number** | **Integer** | The attempt number of the workflow run. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**ActionsListJobsForWorkflowRunAttempt200Response**](ActionsListJobsForWorkflowRunAttempt200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_list_labels_for_self_hosted_runner_for_org

> <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response> actions_list_labels_for_self_hosted_runner_for_org(org, runner_id)

List labels for a self-hosted runner for an organization

Lists all labels for a self-hosted runner configured in an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.

begin
  # List labels for a self-hosted runner for an organization
  result = api_instance.actions_list_labels_for_self_hosted_runner_for_org(org, runner_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_labels_for_self_hosted_runner_for_org: #{e}"
end
```

#### Using the actions_list_labels_for_self_hosted_runner_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>, Integer, Hash)> actions_list_labels_for_self_hosted_runner_for_org_with_http_info(org, runner_id)

```ruby
begin
  # List labels for a self-hosted runner for an organization
  data, status_code, headers = api_instance.actions_list_labels_for_self_hosted_runner_for_org_with_http_info(org, runner_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_labels_for_self_hosted_runner_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_list_labels_for_self_hosted_runner_for_repo

> <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response> actions_list_labels_for_self_hosted_runner_for_repo(owner, repo, runner_id)

List labels for a self-hosted runner for a repository

Lists all labels for a self-hosted runner configured in a repository.  You must authenticate using an access token with the `repo` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.

begin
  # List labels for a self-hosted runner for a repository
  result = api_instance.actions_list_labels_for_self_hosted_runner_for_repo(owner, repo, runner_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_labels_for_self_hosted_runner_for_repo: #{e}"
end
```

#### Using the actions_list_labels_for_self_hosted_runner_for_repo_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>, Integer, Hash)> actions_list_labels_for_self_hosted_runner_for_repo_with_http_info(owner, repo, runner_id)

```ruby
begin
  # List labels for a self-hosted runner for a repository
  data, status_code, headers = api_instance.actions_list_labels_for_self_hosted_runner_for_repo_with_http_info(owner, repo, runner_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_labels_for_self_hosted_runner_for_repo_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_list_org_secrets

> <ActionsListOrgSecrets200Response> actions_list_org_secrets(org, opts)

List organization secrets

Lists all secrets available in an organization without revealing their encrypted values. You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `secrets` organization permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List organization secrets
  result = api_instance.actions_list_org_secrets(org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_org_secrets: #{e}"
end
```

#### Using the actions_list_org_secrets_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsListOrgSecrets200Response>, Integer, Hash)> actions_list_org_secrets_with_http_info(org, opts)

```ruby
begin
  # List organization secrets
  data, status_code, headers = api_instance.actions_list_org_secrets_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsListOrgSecrets200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_org_secrets_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**ActionsListOrgSecrets200Response**](ActionsListOrgSecrets200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_list_repo_access_to_self_hosted_runner_group_in_org

> <ActionsListRepoAccessToSelfHostedRunnerGroupInOrg200Response> actions_list_repo_access_to_self_hosted_runner_group_in_org(org, runner_group_id, opts)

List repository access to a self-hosted runner group in an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud and GitHub Enterprise Server. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"  Lists the repositories with access to a self-hosted runner group configured in an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
runner_group_id = 56 # Integer | Unique identifier of the self-hosted runner group.
opts = {
  page: 56, # Integer | Page number of the results to fetch.
  per_page: 56 # Integer | The number of results per page (max 100).
}

begin
  # List repository access to a self-hosted runner group in an organization
  result = api_instance.actions_list_repo_access_to_self_hosted_runner_group_in_org(org, runner_group_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_repo_access_to_self_hosted_runner_group_in_org: #{e}"
end
```

#### Using the actions_list_repo_access_to_self_hosted_runner_group_in_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsListRepoAccessToSelfHostedRunnerGroupInOrg200Response>, Integer, Hash)> actions_list_repo_access_to_self_hosted_runner_group_in_org_with_http_info(org, runner_group_id, opts)

```ruby
begin
  # List repository access to a self-hosted runner group in an organization
  data, status_code, headers = api_instance.actions_list_repo_access_to_self_hosted_runner_group_in_org_with_http_info(org, runner_group_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsListRepoAccessToSelfHostedRunnerGroupInOrg200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_repo_access_to_self_hosted_runner_group_in_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **runner_group_id** | **Integer** | Unique identifier of the self-hosted runner group. |  |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |

### Return type

[**ActionsListRepoAccessToSelfHostedRunnerGroupInOrg200Response**](ActionsListRepoAccessToSelfHostedRunnerGroupInOrg200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_list_repo_secrets

> <ActionsListRepoSecrets200Response> actions_list_repo_secrets(owner, repo, opts)

List repository secrets

Lists all secrets available in a repository without revealing their encrypted values. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `secrets` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List repository secrets
  result = api_instance.actions_list_repo_secrets(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_repo_secrets: #{e}"
end
```

#### Using the actions_list_repo_secrets_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsListRepoSecrets200Response>, Integer, Hash)> actions_list_repo_secrets_with_http_info(owner, repo, opts)

```ruby
begin
  # List repository secrets
  data, status_code, headers = api_instance.actions_list_repo_secrets_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsListRepoSecrets200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_repo_secrets_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**ActionsListRepoSecrets200Response**](ActionsListRepoSecrets200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_list_repo_workflows

> <ActionsListRepoWorkflows200Response> actions_list_repo_workflows(owner, repo, opts)

List repository workflows

Lists the workflows in a repository. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List repository workflows
  result = api_instance.actions_list_repo_workflows(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_repo_workflows: #{e}"
end
```

#### Using the actions_list_repo_workflows_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsListRepoWorkflows200Response>, Integer, Hash)> actions_list_repo_workflows_with_http_info(owner, repo, opts)

```ruby
begin
  # List repository workflows
  data, status_code, headers = api_instance.actions_list_repo_workflows_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsListRepoWorkflows200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_repo_workflows_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**ActionsListRepoWorkflows200Response**](ActionsListRepoWorkflows200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_list_runner_applications_for_org

> <Array<RunnerApplication>> actions_list_runner_applications_for_org(org)

List runner applications for an organization

Lists binaries for the runner application that you can download and run.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.

begin
  # List runner applications for an organization
  result = api_instance.actions_list_runner_applications_for_org(org)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_runner_applications_for_org: #{e}"
end
```

#### Using the actions_list_runner_applications_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<RunnerApplication>>, Integer, Hash)> actions_list_runner_applications_for_org_with_http_info(org)

```ruby
begin
  # List runner applications for an organization
  data, status_code, headers = api_instance.actions_list_runner_applications_for_org_with_http_info(org)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<RunnerApplication>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_runner_applications_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |

### Return type

[**Array&lt;RunnerApplication&gt;**](RunnerApplication.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_list_runner_applications_for_repo

> <Array<RunnerApplication>> actions_list_runner_applications_for_repo(owner, repo)

List runner applications for a repository

Lists binaries for the runner application that you can download and run.  You must authenticate using an access token with the `repo` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # List runner applications for a repository
  result = api_instance.actions_list_runner_applications_for_repo(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_runner_applications_for_repo: #{e}"
end
```

#### Using the actions_list_runner_applications_for_repo_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<RunnerApplication>>, Integer, Hash)> actions_list_runner_applications_for_repo_with_http_info(owner, repo)

```ruby
begin
  # List runner applications for a repository
  data, status_code, headers = api_instance.actions_list_runner_applications_for_repo_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<RunnerApplication>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_runner_applications_for_repo_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**Array&lt;RunnerApplication&gt;**](RunnerApplication.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_list_selected_repos_for_org_secret

> <ActionsListSelectedReposForOrgSecret200Response> actions_list_selected_repos_for_org_secret(org, secret_name, opts)

List selected repositories for an organization secret

Lists all repositories that have been selected when the `visibility` for repository access to a secret is set to `selected`. You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `secrets` organization permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.
opts = {
  page: 56, # Integer | Page number of the results to fetch.
  per_page: 56 # Integer | The number of results per page (max 100).
}

begin
  # List selected repositories for an organization secret
  result = api_instance.actions_list_selected_repos_for_org_secret(org, secret_name, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_selected_repos_for_org_secret: #{e}"
end
```

#### Using the actions_list_selected_repos_for_org_secret_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsListSelectedReposForOrgSecret200Response>, Integer, Hash)> actions_list_selected_repos_for_org_secret_with_http_info(org, secret_name, opts)

```ruby
begin
  # List selected repositories for an organization secret
  data, status_code, headers = api_instance.actions_list_selected_repos_for_org_secret_with_http_info(org, secret_name, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsListSelectedReposForOrgSecret200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_selected_repos_for_org_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **secret_name** | **String** | The name of the secret. |  |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |

### Return type

[**ActionsListSelectedReposForOrgSecret200Response**](ActionsListSelectedReposForOrgSecret200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_list_selected_repositories_enabled_github_actions_organization

> <ActionsListSelectedRepositoriesEnabledGithubActionsOrganization200Response> actions_list_selected_repositories_enabled_github_actions_organization(org, opts)

List selected repositories enabled for GitHub Actions in an organization

Lists the selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for `enabled_repositories` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\"  You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `administration` organization permission to use this API.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List selected repositories enabled for GitHub Actions in an organization
  result = api_instance.actions_list_selected_repositories_enabled_github_actions_organization(org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_selected_repositories_enabled_github_actions_organization: #{e}"
end
```

#### Using the actions_list_selected_repositories_enabled_github_actions_organization_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsListSelectedRepositoriesEnabledGithubActionsOrganization200Response>, Integer, Hash)> actions_list_selected_repositories_enabled_github_actions_organization_with_http_info(org, opts)

```ruby
begin
  # List selected repositories enabled for GitHub Actions in an organization
  data, status_code, headers = api_instance.actions_list_selected_repositories_enabled_github_actions_organization_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsListSelectedRepositoriesEnabledGithubActionsOrganization200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_selected_repositories_enabled_github_actions_organization_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**ActionsListSelectedRepositoriesEnabledGithubActionsOrganization200Response**](ActionsListSelectedRepositoriesEnabledGithubActionsOrganization200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_list_self_hosted_runner_groups_for_org

> <ActionsListSelfHostedRunnerGroupsForOrg200Response> actions_list_self_hosted_runner_groups_for_org(org, opts)

List self-hosted runner groups for an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"  Lists all self-hosted runner groups configured in an organization and inherited from an enterprise.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56, # Integer | Page number of the results to fetch.
  visible_to_repository: 'visible_to_repository_example' # String | Only return runner groups that are allowed to be used by this repository.
}

begin
  # List self-hosted runner groups for an organization
  result = api_instance.actions_list_self_hosted_runner_groups_for_org(org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_self_hosted_runner_groups_for_org: #{e}"
end
```

#### Using the actions_list_self_hosted_runner_groups_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsListSelfHostedRunnerGroupsForOrg200Response>, Integer, Hash)> actions_list_self_hosted_runner_groups_for_org_with_http_info(org, opts)

```ruby
begin
  # List self-hosted runner groups for an organization
  data, status_code, headers = api_instance.actions_list_self_hosted_runner_groups_for_org_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsListSelfHostedRunnerGroupsForOrg200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_self_hosted_runner_groups_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |
| **visible_to_repository** | **String** | Only return runner groups that are allowed to be used by this repository. | [optional] |

### Return type

[**ActionsListSelfHostedRunnerGroupsForOrg200Response**](ActionsListSelfHostedRunnerGroupsForOrg200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_list_self_hosted_runners_for_org

> <ActionsListSelfHostedRunnersForOrg200Response> actions_list_self_hosted_runners_for_org(org, opts)

List self-hosted runners for an organization

Lists all self-hosted runners configured in an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List self-hosted runners for an organization
  result = api_instance.actions_list_self_hosted_runners_for_org(org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_self_hosted_runners_for_org: #{e}"
end
```

#### Using the actions_list_self_hosted_runners_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsListSelfHostedRunnersForOrg200Response>, Integer, Hash)> actions_list_self_hosted_runners_for_org_with_http_info(org, opts)

```ruby
begin
  # List self-hosted runners for an organization
  data, status_code, headers = api_instance.actions_list_self_hosted_runners_for_org_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsListSelfHostedRunnersForOrg200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_self_hosted_runners_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**ActionsListSelfHostedRunnersForOrg200Response**](ActionsListSelfHostedRunnersForOrg200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_list_self_hosted_runners_for_repo

> <ActionsListSelfHostedRunnersForOrg200Response> actions_list_self_hosted_runners_for_repo(owner, repo, opts)

List self-hosted runners for a repository

Lists all self-hosted runners configured in a repository. You must authenticate using an access token with the `repo` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List self-hosted runners for a repository
  result = api_instance.actions_list_self_hosted_runners_for_repo(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_self_hosted_runners_for_repo: #{e}"
end
```

#### Using the actions_list_self_hosted_runners_for_repo_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsListSelfHostedRunnersForOrg200Response>, Integer, Hash)> actions_list_self_hosted_runners_for_repo_with_http_info(owner, repo, opts)

```ruby
begin
  # List self-hosted runners for a repository
  data, status_code, headers = api_instance.actions_list_self_hosted_runners_for_repo_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsListSelfHostedRunnersForOrg200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_self_hosted_runners_for_repo_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**ActionsListSelfHostedRunnersForOrg200Response**](ActionsListSelfHostedRunnersForOrg200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_list_self_hosted_runners_in_group_for_org

> <EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response> actions_list_self_hosted_runners_in_group_for_org(org, runner_group_id, opts)

List self-hosted runners in a group for an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"  Lists self-hosted runners that are in a specific organization group.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
runner_group_id = 56 # Integer | Unique identifier of the self-hosted runner group.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List self-hosted runners in a group for an organization
  result = api_instance.actions_list_self_hosted_runners_in_group_for_org(org, runner_group_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_self_hosted_runners_in_group_for_org: #{e}"
end
```

#### Using the actions_list_self_hosted_runners_in_group_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response>, Integer, Hash)> actions_list_self_hosted_runners_in_group_for_org_with_http_info(org, runner_group_id, opts)

```ruby
begin
  # List self-hosted runners in a group for an organization
  data, status_code, headers = api_instance.actions_list_self_hosted_runners_in_group_for_org_with_http_info(org, runner_group_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_self_hosted_runners_in_group_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **runner_group_id** | **Integer** | Unique identifier of the self-hosted runner group. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response**](EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_list_workflow_run_artifacts

> <ActionsListArtifactsForRepo200Response> actions_list_workflow_run_artifacts(owner, repo, run_id, opts)

List workflow run artifacts

Lists artifacts for a workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
run_id = 56 # Integer | The unique identifier of the workflow run.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List workflow run artifacts
  result = api_instance.actions_list_workflow_run_artifacts(owner, repo, run_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_workflow_run_artifacts: #{e}"
end
```

#### Using the actions_list_workflow_run_artifacts_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsListArtifactsForRepo200Response>, Integer, Hash)> actions_list_workflow_run_artifacts_with_http_info(owner, repo, run_id, opts)

```ruby
begin
  # List workflow run artifacts
  data, status_code, headers = api_instance.actions_list_workflow_run_artifacts_with_http_info(owner, repo, run_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsListArtifactsForRepo200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_workflow_run_artifacts_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **run_id** | **Integer** | The unique identifier of the workflow run. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**ActionsListArtifactsForRepo200Response**](ActionsListArtifactsForRepo200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_list_workflow_runs

> <ActionsListWorkflowRunsForRepo200Response> actions_list_workflow_runs(owner, repo, workflow_id, opts)

List workflow runs

List all workflow runs for a workflow. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/overview/resources-in-the-rest-api#parameters).  Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
workflow_id = nil # ActionsGetWorkflowWorkflowIdParameter | The ID of the workflow. You can also pass the workflow file name as a string.
opts = {
  actor: 'actor_example', # String | Returns someone's workflow runs. Use the login for the user who created the `push` associated with the check suite or workflow run.
  branch: 'branch_example', # String | Returns workflow runs associated with a branch. Use the name of the branch of the `push`.
  event: 'event_example', # String | Returns workflow run triggered by the event you specify. For example, `push`, `pull_request` or `issue`. For more information, see \"[Events that trigger workflows](https://docs.github.com/en/actions/automating-your-workflow-with-github-actions/events-that-trigger-workflows).\"
  status: 'completed', # String | Returns workflow runs with the check run `status` or `conclusion` that you specify. For example, a conclusion can be `success` or a status can be `in_progress`. Only GitHub can set a status of `waiting` or `requested`.
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56, # Integer | Page number of the results to fetch.
  created: Time.parse('2013-10-20T19:20:30+01:00'), # Time | Returns workflow runs created within the given date-time range. For more information on the syntax, see \"[Understanding the search syntax](https://docs.github.com/search-github/getting-started-with-searching-on-github/understanding-the-search-syntax#query-for-dates).\"
  exclude_pull_requests: true, # Boolean | If `true` pull requests are omitted from the response (empty array).
  check_suite_id: 56 # Integer | Returns workflow runs with the `check_suite_id` that you specify.
}

begin
  # List workflow runs
  result = api_instance.actions_list_workflow_runs(owner, repo, workflow_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_workflow_runs: #{e}"
end
```

#### Using the actions_list_workflow_runs_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsListWorkflowRunsForRepo200Response>, Integer, Hash)> actions_list_workflow_runs_with_http_info(owner, repo, workflow_id, opts)

```ruby
begin
  # List workflow runs
  data, status_code, headers = api_instance.actions_list_workflow_runs_with_http_info(owner, repo, workflow_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsListWorkflowRunsForRepo200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_workflow_runs_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **workflow_id** | [**ActionsGetWorkflowWorkflowIdParameter**](.md) | The ID of the workflow. You can also pass the workflow file name as a string. |  |
| **actor** | **String** | Returns someone&#39;s workflow runs. Use the login for the user who created the &#x60;push&#x60; associated with the check suite or workflow run. | [optional] |
| **branch** | **String** | Returns workflow runs associated with a branch. Use the name of the branch of the &#x60;push&#x60;. | [optional] |
| **event** | **String** | Returns workflow run triggered by the event you specify. For example, &#x60;push&#x60;, &#x60;pull_request&#x60; or &#x60;issue&#x60;. For more information, see \&quot;[Events that trigger workflows](https://docs.github.com/en/actions/automating-your-workflow-with-github-actions/events-that-trigger-workflows).\&quot; | [optional] |
| **status** | **String** | Returns workflow runs with the check run &#x60;status&#x60; or &#x60;conclusion&#x60; that you specify. For example, a conclusion can be &#x60;success&#x60; or a status can be &#x60;in_progress&#x60;. Only GitHub can set a status of &#x60;waiting&#x60; or &#x60;requested&#x60;. | [optional] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |
| **created** | **Time** | Returns workflow runs created within the given date-time range. For more information on the syntax, see \&quot;[Understanding the search syntax](https://docs.github.com/search-github/getting-started-with-searching-on-github/understanding-the-search-syntax#query-for-dates).\&quot; | [optional] |
| **exclude_pull_requests** | **Boolean** | If &#x60;true&#x60; pull requests are omitted from the response (empty array). | [optional][default to false] |
| **check_suite_id** | **Integer** | Returns workflow runs with the &#x60;check_suite_id&#x60; that you specify. | [optional] |

### Return type

[**ActionsListWorkflowRunsForRepo200Response**](ActionsListWorkflowRunsForRepo200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_list_workflow_runs_for_repo

> <ActionsListWorkflowRunsForRepo200Response> actions_list_workflow_runs_for_repo(owner, repo, opts)

List workflow runs for a repository

Lists all workflow runs for a repository. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/overview/resources-in-the-rest-api#parameters).  Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  actor: 'actor_example', # String | Returns someone's workflow runs. Use the login for the user who created the `push` associated with the check suite or workflow run.
  branch: 'branch_example', # String | Returns workflow runs associated with a branch. Use the name of the branch of the `push`.
  event: 'event_example', # String | Returns workflow run triggered by the event you specify. For example, `push`, `pull_request` or `issue`. For more information, see \"[Events that trigger workflows](https://docs.github.com/en/actions/automating-your-workflow-with-github-actions/events-that-trigger-workflows).\"
  status: 'completed', # String | Returns workflow runs with the check run `status` or `conclusion` that you specify. For example, a conclusion can be `success` or a status can be `in_progress`. Only GitHub can set a status of `waiting` or `requested`.
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56, # Integer | Page number of the results to fetch.
  created: Time.parse('2013-10-20T19:20:30+01:00'), # Time | Returns workflow runs created within the given date-time range. For more information on the syntax, see \"[Understanding the search syntax](https://docs.github.com/search-github/getting-started-with-searching-on-github/understanding-the-search-syntax#query-for-dates).\"
  exclude_pull_requests: true, # Boolean | If `true` pull requests are omitted from the response (empty array).
  check_suite_id: 56 # Integer | Returns workflow runs with the `check_suite_id` that you specify.
}

begin
  # List workflow runs for a repository
  result = api_instance.actions_list_workflow_runs_for_repo(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_workflow_runs_for_repo: #{e}"
end
```

#### Using the actions_list_workflow_runs_for_repo_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsListWorkflowRunsForRepo200Response>, Integer, Hash)> actions_list_workflow_runs_for_repo_with_http_info(owner, repo, opts)

```ruby
begin
  # List workflow runs for a repository
  data, status_code, headers = api_instance.actions_list_workflow_runs_for_repo_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsListWorkflowRunsForRepo200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_list_workflow_runs_for_repo_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **actor** | **String** | Returns someone&#39;s workflow runs. Use the login for the user who created the &#x60;push&#x60; associated with the check suite or workflow run. | [optional] |
| **branch** | **String** | Returns workflow runs associated with a branch. Use the name of the branch of the &#x60;push&#x60;. | [optional] |
| **event** | **String** | Returns workflow run triggered by the event you specify. For example, &#x60;push&#x60;, &#x60;pull_request&#x60; or &#x60;issue&#x60;. For more information, see \&quot;[Events that trigger workflows](https://docs.github.com/en/actions/automating-your-workflow-with-github-actions/events-that-trigger-workflows).\&quot; | [optional] |
| **status** | **String** | Returns workflow runs with the check run &#x60;status&#x60; or &#x60;conclusion&#x60; that you specify. For example, a conclusion can be &#x60;success&#x60; or a status can be &#x60;in_progress&#x60;. Only GitHub can set a status of &#x60;waiting&#x60; or &#x60;requested&#x60;. | [optional] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |
| **created** | **Time** | Returns workflow runs created within the given date-time range. For more information on the syntax, see \&quot;[Understanding the search syntax](https://docs.github.com/search-github/getting-started-with-searching-on-github/understanding-the-search-syntax#query-for-dates).\&quot; | [optional] |
| **exclude_pull_requests** | **Boolean** | If &#x60;true&#x60; pull requests are omitted from the response (empty array). | [optional][default to false] |
| **check_suite_id** | **Integer** | Returns workflow runs with the &#x60;check_suite_id&#x60; that you specify. | [optional] |

### Return type

[**ActionsListWorkflowRunsForRepo200Response**](ActionsListWorkflowRunsForRepo200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_re_run_job_for_workflow_run

> Object actions_re_run_job_for_workflow_run(owner, repo, job_id, opts)

Re-run a job from a workflow run

Re-run a job and its dependent jobs in a workflow run. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
job_id = 56 # Integer | The unique identifier of the job.
opts = {
  actions_re_run_job_for_workflow_run_request: OpenapiClient::ActionsReRunJobForWorkflowRunRequest.new # ActionsReRunJobForWorkflowRunRequest | 
}

begin
  # Re-run a job from a workflow run
  result = api_instance.actions_re_run_job_for_workflow_run(owner, repo, job_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_re_run_job_for_workflow_run: #{e}"
end
```

#### Using the actions_re_run_job_for_workflow_run_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Object, Integer, Hash)> actions_re_run_job_for_workflow_run_with_http_info(owner, repo, job_id, opts)

```ruby
begin
  # Re-run a job from a workflow run
  data, status_code, headers = api_instance.actions_re_run_job_for_workflow_run_with_http_info(owner, repo, job_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Object
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_re_run_job_for_workflow_run_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **job_id** | **Integer** | The unique identifier of the job. |  |
| **actions_re_run_job_for_workflow_run_request** | [**ActionsReRunJobForWorkflowRunRequest**](ActionsReRunJobForWorkflowRunRequest.md) |  | [optional] |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## actions_re_run_workflow

> Object actions_re_run_workflow(owner, repo, run_id, opts)

Re-run a workflow

Re-runs your workflow run using its `id`. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
run_id = 56 # Integer | The unique identifier of the workflow run.
opts = {
  actions_re_run_job_for_workflow_run_request: OpenapiClient::ActionsReRunJobForWorkflowRunRequest.new # ActionsReRunJobForWorkflowRunRequest | 
}

begin
  # Re-run a workflow
  result = api_instance.actions_re_run_workflow(owner, repo, run_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_re_run_workflow: #{e}"
end
```

#### Using the actions_re_run_workflow_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Object, Integer, Hash)> actions_re_run_workflow_with_http_info(owner, repo, run_id, opts)

```ruby
begin
  # Re-run a workflow
  data, status_code, headers = api_instance.actions_re_run_workflow_with_http_info(owner, repo, run_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Object
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_re_run_workflow_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **run_id** | **Integer** | The unique identifier of the workflow run. |  |
| **actions_re_run_job_for_workflow_run_request** | [**ActionsReRunJobForWorkflowRunRequest**](ActionsReRunJobForWorkflowRunRequest.md) |  | [optional] |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## actions_re_run_workflow_failed_jobs

> Object actions_re_run_workflow_failed_jobs(owner, repo, run_id, opts)

Re-run failed jobs from a workflow run

Re-run all of the failed jobs and their dependent jobs in a workflow run using the `id` of the workflow run. You must authenticate using an access token with the `repo` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
run_id = 56 # Integer | The unique identifier of the workflow run.
opts = {
  actions_re_run_job_for_workflow_run_request: OpenapiClient::ActionsReRunJobForWorkflowRunRequest.new # ActionsReRunJobForWorkflowRunRequest | 
}

begin
  # Re-run failed jobs from a workflow run
  result = api_instance.actions_re_run_workflow_failed_jobs(owner, repo, run_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_re_run_workflow_failed_jobs: #{e}"
end
```

#### Using the actions_re_run_workflow_failed_jobs_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Object, Integer, Hash)> actions_re_run_workflow_failed_jobs_with_http_info(owner, repo, run_id, opts)

```ruby
begin
  # Re-run failed jobs from a workflow run
  data, status_code, headers = api_instance.actions_re_run_workflow_failed_jobs_with_http_info(owner, repo, run_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Object
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_re_run_workflow_failed_jobs_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **run_id** | **Integer** | The unique identifier of the workflow run. |  |
| **actions_re_run_job_for_workflow_run_request** | [**ActionsReRunJobForWorkflowRunRequest**](ActionsReRunJobForWorkflowRunRequest.md) |  | [optional] |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## actions_remove_all_custom_labels_from_self_hosted_runner_for_org

> <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response> actions_remove_all_custom_labels_from_self_hosted_runner_for_org(org, runner_id)

Remove all custom labels from a self-hosted runner for an organization

Remove all custom labels from a self-hosted runner configured in an organization. Returns the remaining read-only labels from the runner.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.

begin
  # Remove all custom labels from a self-hosted runner for an organization
  result = api_instance.actions_remove_all_custom_labels_from_self_hosted_runner_for_org(org, runner_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_remove_all_custom_labels_from_self_hosted_runner_for_org: #{e}"
end
```

#### Using the actions_remove_all_custom_labels_from_self_hosted_runner_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>, Integer, Hash)> actions_remove_all_custom_labels_from_self_hosted_runner_for_org_with_http_info(org, runner_id)

```ruby
begin
  # Remove all custom labels from a self-hosted runner for an organization
  data, status_code, headers = api_instance.actions_remove_all_custom_labels_from_self_hosted_runner_for_org_with_http_info(org, runner_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_remove_all_custom_labels_from_self_hosted_runner_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_remove_all_custom_labels_from_self_hosted_runner_for_repo

> <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response> actions_remove_all_custom_labels_from_self_hosted_runner_for_repo(owner, repo, runner_id)

Remove all custom labels from a self-hosted runner for a repository

Remove all custom labels from a self-hosted runner configured in a repository. Returns the remaining read-only labels from the runner.  You must authenticate using an access token with the `repo` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.

begin
  # Remove all custom labels from a self-hosted runner for a repository
  result = api_instance.actions_remove_all_custom_labels_from_self_hosted_runner_for_repo(owner, repo, runner_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_remove_all_custom_labels_from_self_hosted_runner_for_repo: #{e}"
end
```

#### Using the actions_remove_all_custom_labels_from_self_hosted_runner_for_repo_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>, Integer, Hash)> actions_remove_all_custom_labels_from_self_hosted_runner_for_repo_with_http_info(owner, repo, runner_id)

```ruby
begin
  # Remove all custom labels from a self-hosted runner for a repository
  data, status_code, headers = api_instance.actions_remove_all_custom_labels_from_self_hosted_runner_for_repo_with_http_info(owner, repo, runner_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_remove_all_custom_labels_from_self_hosted_runner_for_repo_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_remove_custom_label_from_self_hosted_runner_for_org

> <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response> actions_remove_custom_label_from_self_hosted_runner_for_org(org, runner_id, name)

Remove a custom label from a self-hosted runner for an organization

Remove a custom label from a self-hosted runner configured in an organization. Returns the remaining labels from the runner.  This endpoint returns a `404 Not Found` status if the custom label is not present on the runner.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.
name = 'name_example' # String | The name of a self-hosted runner's custom label.

begin
  # Remove a custom label from a self-hosted runner for an organization
  result = api_instance.actions_remove_custom_label_from_self_hosted_runner_for_org(org, runner_id, name)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_remove_custom_label_from_self_hosted_runner_for_org: #{e}"
end
```

#### Using the actions_remove_custom_label_from_self_hosted_runner_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>, Integer, Hash)> actions_remove_custom_label_from_self_hosted_runner_for_org_with_http_info(org, runner_id, name)

```ruby
begin
  # Remove a custom label from a self-hosted runner for an organization
  data, status_code, headers = api_instance.actions_remove_custom_label_from_self_hosted_runner_for_org_with_http_info(org, runner_id, name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_remove_custom_label_from_self_hosted_runner_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |
| **name** | **String** | The name of a self-hosted runner&#39;s custom label. |  |

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_remove_custom_label_from_self_hosted_runner_for_repo

> <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response> actions_remove_custom_label_from_self_hosted_runner_for_repo(owner, repo, runner_id, name)

Remove a custom label from a self-hosted runner for a repository

Remove a custom label from a self-hosted runner configured in a repository. Returns the remaining labels from the runner.  This endpoint returns a `404 Not Found` status if the custom label is not present on the runner.  You must authenticate using an access token with the `repo` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.
name = 'name_example' # String | The name of a self-hosted runner's custom label.

begin
  # Remove a custom label from a self-hosted runner for a repository
  result = api_instance.actions_remove_custom_label_from_self_hosted_runner_for_repo(owner, repo, runner_id, name)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_remove_custom_label_from_self_hosted_runner_for_repo: #{e}"
end
```

#### Using the actions_remove_custom_label_from_self_hosted_runner_for_repo_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>, Integer, Hash)> actions_remove_custom_label_from_self_hosted_runner_for_repo_with_http_info(owner, repo, runner_id, name)

```ruby
begin
  # Remove a custom label from a self-hosted runner for a repository
  data, status_code, headers = api_instance.actions_remove_custom_label_from_self_hosted_runner_for_repo_with_http_info(owner, repo, runner_id, name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_remove_custom_label_from_self_hosted_runner_for_repo_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |
| **name** | **String** | The name of a self-hosted runner&#39;s custom label. |  |

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## actions_remove_repo_access_to_self_hosted_runner_group_in_org

> actions_remove_repo_access_to_self_hosted_runner_group_in_org(org, runner_group_id, repository_id)

Remove repository access to a self-hosted runner group in an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"   Removes a repository from the list of selected repositories that can access a self-hosted runner group. The runner group must have `visibility` set to `selected`. For more information, see \"[Create a self-hosted runner group for an organization](#create-a-self-hosted-runner-group-for-an-organization).\"  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
runner_group_id = 56 # Integer | Unique identifier of the self-hosted runner group.
repository_id = 56 # Integer | The unique identifier of the repository.

begin
  # Remove repository access to a self-hosted runner group in an organization
  api_instance.actions_remove_repo_access_to_self_hosted_runner_group_in_org(org, runner_group_id, repository_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_remove_repo_access_to_self_hosted_runner_group_in_org: #{e}"
end
```

#### Using the actions_remove_repo_access_to_self_hosted_runner_group_in_org_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_remove_repo_access_to_self_hosted_runner_group_in_org_with_http_info(org, runner_group_id, repository_id)

```ruby
begin
  # Remove repository access to a self-hosted runner group in an organization
  data, status_code, headers = api_instance.actions_remove_repo_access_to_self_hosted_runner_group_in_org_with_http_info(org, runner_group_id, repository_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_remove_repo_access_to_self_hosted_runner_group_in_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **runner_group_id** | **Integer** | Unique identifier of the self-hosted runner group. |  |
| **repository_id** | **Integer** | The unique identifier of the repository. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actions_remove_selected_repo_from_org_secret

> actions_remove_selected_repo_from_org_secret(org, secret_name, repository_id)

Remove selected repository from an organization secret

Removes a repository from an organization secret when the `visibility` for repository access is set to `selected`. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/actions#create-or-update-an-organization-secret). You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `secrets` organization permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.
repository_id = 56 # Integer | 

begin
  # Remove selected repository from an organization secret
  api_instance.actions_remove_selected_repo_from_org_secret(org, secret_name, repository_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_remove_selected_repo_from_org_secret: #{e}"
end
```

#### Using the actions_remove_selected_repo_from_org_secret_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_remove_selected_repo_from_org_secret_with_http_info(org, secret_name, repository_id)

```ruby
begin
  # Remove selected repository from an organization secret
  data, status_code, headers = api_instance.actions_remove_selected_repo_from_org_secret_with_http_info(org, secret_name, repository_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_remove_selected_repo_from_org_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **secret_name** | **String** | The name of the secret. |  |
| **repository_id** | **Integer** |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actions_remove_self_hosted_runner_from_group_for_org

> actions_remove_self_hosted_runner_from_group_for_org(org, runner_group_id, runner_id)

Remove a self-hosted runner from a group for an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"   Removes a self-hosted runner from a group configured in an organization. The runner is then returned to the default group.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
runner_group_id = 56 # Integer | Unique identifier of the self-hosted runner group.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.

begin
  # Remove a self-hosted runner from a group for an organization
  api_instance.actions_remove_self_hosted_runner_from_group_for_org(org, runner_group_id, runner_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_remove_self_hosted_runner_from_group_for_org: #{e}"
end
```

#### Using the actions_remove_self_hosted_runner_from_group_for_org_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_remove_self_hosted_runner_from_group_for_org_with_http_info(org, runner_group_id, runner_id)

```ruby
begin
  # Remove a self-hosted runner from a group for an organization
  data, status_code, headers = api_instance.actions_remove_self_hosted_runner_from_group_for_org_with_http_info(org, runner_group_id, runner_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_remove_self_hosted_runner_from_group_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **runner_group_id** | **Integer** | Unique identifier of the self-hosted runner group. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actions_review_pending_deployments_for_run

> <Array<Deployment>> actions_review_pending_deployments_for_run(owner, repo, run_id, actions_review_pending_deployments_for_run_request)

Review pending deployments for a workflow run

Approve or reject pending deployments that are waiting on approval by a required reviewer.  Required reviewers with read access to the repository contents and deployments can use this endpoint. Required reviewers must authenticate using an access token with the `repo` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
run_id = 56 # Integer | The unique identifier of the workflow run.
actions_review_pending_deployments_for_run_request = OpenapiClient::ActionsReviewPendingDeploymentsForRunRequest.new({environment_ids: [161171787, 161171795], state: 'approved', comment: 'Ship it!'}) # ActionsReviewPendingDeploymentsForRunRequest | 

begin
  # Review pending deployments for a workflow run
  result = api_instance.actions_review_pending_deployments_for_run(owner, repo, run_id, actions_review_pending_deployments_for_run_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_review_pending_deployments_for_run: #{e}"
end
```

#### Using the actions_review_pending_deployments_for_run_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<Deployment>>, Integer, Hash)> actions_review_pending_deployments_for_run_with_http_info(owner, repo, run_id, actions_review_pending_deployments_for_run_request)

```ruby
begin
  # Review pending deployments for a workflow run
  data, status_code, headers = api_instance.actions_review_pending_deployments_for_run_with_http_info(owner, repo, run_id, actions_review_pending_deployments_for_run_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<Deployment>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_review_pending_deployments_for_run_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **run_id** | **Integer** | The unique identifier of the workflow run. |  |
| **actions_review_pending_deployments_for_run_request** | [**ActionsReviewPendingDeploymentsForRunRequest**](ActionsReviewPendingDeploymentsForRunRequest.md) |  |  |

### Return type

[**Array&lt;Deployment&gt;**](Deployment.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## actions_set_actions_oidc_custom_issuer_policy_for_enterprise

> actions_set_actions_oidc_custom_issuer_policy_for_enterprise(enterprise, actions_set_actions_oidc_custom_issuer_policy_for_enterprise_request)

Set the GitHub Actions OIDC custom issuer policy for an enterprise

Sets the GitHub Actions OpenID Connect (OIDC) custom issuer policy for an enterprise. You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint. GitHub Apps must have the `enterprise_administration:write` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
actions_set_actions_oidc_custom_issuer_policy_for_enterprise_request = OpenapiClient::ActionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest.new # ActionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest | 

begin
  # Set the GitHub Actions OIDC custom issuer policy for an enterprise
  api_instance.actions_set_actions_oidc_custom_issuer_policy_for_enterprise(enterprise, actions_set_actions_oidc_custom_issuer_policy_for_enterprise_request)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_actions_oidc_custom_issuer_policy_for_enterprise: #{e}"
end
```

#### Using the actions_set_actions_oidc_custom_issuer_policy_for_enterprise_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_set_actions_oidc_custom_issuer_policy_for_enterprise_with_http_info(enterprise, actions_set_actions_oidc_custom_issuer_policy_for_enterprise_request)

```ruby
begin
  # Set the GitHub Actions OIDC custom issuer policy for an enterprise
  data, status_code, headers = api_instance.actions_set_actions_oidc_custom_issuer_policy_for_enterprise_with_http_info(enterprise, actions_set_actions_oidc_custom_issuer_policy_for_enterprise_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_actions_oidc_custom_issuer_policy_for_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **actions_set_actions_oidc_custom_issuer_policy_for_enterprise_request** | [**ActionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest**](ActionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest.md) |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actions_set_allowed_actions_organization

> actions_set_allowed_actions_organization(org, opts)

Set allowed actions and reusable workflows for an organization

Sets the actions and reusable workflows that are allowed in an organization. To use this endpoint, the organization permission policy for `allowed_actions` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\"  If the organization belongs to an enterprise that has `selected` actions and reusable workflows set at the enterprise level, then you cannot override any of the enterprise's allowed actions and reusable workflows settings.  To use the `patterns_allowed` setting for private repositories, the organization must belong to an enterprise. If the organization does not belong to an enterprise, then the `patterns_allowed` setting only applies to public repositories in the organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `administration` organization permission to use this API.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  enterprise_admin_get_allowed_actions_enterprise200_response: OpenapiClient::EnterpriseAdminGetAllowedActionsEnterprise200Response.new # EnterpriseAdminGetAllowedActionsEnterprise200Response | 
}

begin
  # Set allowed actions and reusable workflows for an organization
  api_instance.actions_set_allowed_actions_organization(org, opts)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_allowed_actions_organization: #{e}"
end
```

#### Using the actions_set_allowed_actions_organization_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_set_allowed_actions_organization_with_http_info(org, opts)

```ruby
begin
  # Set allowed actions and reusable workflows for an organization
  data, status_code, headers = api_instance.actions_set_allowed_actions_organization_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_allowed_actions_organization_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **enterprise_admin_get_allowed_actions_enterprise200_response** | [**EnterpriseAdminGetAllowedActionsEnterprise200Response**](EnterpriseAdminGetAllowedActionsEnterprise200Response.md) |  | [optional] |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actions_set_allowed_actions_repository

> actions_set_allowed_actions_repository(owner, repo, opts)

Set allowed actions and reusable workflows for a repository

Sets the actions and reusable workflows that are allowed in a repository. To use this endpoint, the repository permission policy for `allowed_actions` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for a repository](#set-github-actions-permissions-for-a-repository).\"  If the repository belongs to an organization or enterprise that has `selected` actions and reusable workflows set at the organization or enterprise levels, then you cannot override any of the allowed actions and reusable workflows settings.  To use the `patterns_allowed` setting for private repositories, the repository must belong to an enterprise. If the repository does not belong to an enterprise, then the `patterns_allowed` setting only applies to public repositories.  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `administration` repository permission to use this API.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  enterprise_admin_get_allowed_actions_enterprise200_response: OpenapiClient::EnterpriseAdminGetAllowedActionsEnterprise200Response.new # EnterpriseAdminGetAllowedActionsEnterprise200Response | 
}

begin
  # Set allowed actions and reusable workflows for a repository
  api_instance.actions_set_allowed_actions_repository(owner, repo, opts)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_allowed_actions_repository: #{e}"
end
```

#### Using the actions_set_allowed_actions_repository_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_set_allowed_actions_repository_with_http_info(owner, repo, opts)

```ruby
begin
  # Set allowed actions and reusable workflows for a repository
  data, status_code, headers = api_instance.actions_set_allowed_actions_repository_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_allowed_actions_repository_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **enterprise_admin_get_allowed_actions_enterprise200_response** | [**EnterpriseAdminGetAllowedActionsEnterprise200Response**](EnterpriseAdminGetAllowedActionsEnterprise200Response.md) |  | [optional] |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actions_set_custom_labels_for_self_hosted_runner_for_org

> <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response> actions_set_custom_labels_for_self_hosted_runner_for_org(org, runner_id, enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise_request)

Set custom labels for a self-hosted runner for an organization

Remove all previous custom labels and set the new custom labels for a specific self-hosted runner configured in an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.
enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise_request = OpenapiClient::EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest.new({labels: ['labels_example']}) # EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest | 

begin
  # Set custom labels for a self-hosted runner for an organization
  result = api_instance.actions_set_custom_labels_for_self_hosted_runner_for_org(org, runner_id, enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_custom_labels_for_self_hosted_runner_for_org: #{e}"
end
```

#### Using the actions_set_custom_labels_for_self_hosted_runner_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>, Integer, Hash)> actions_set_custom_labels_for_self_hosted_runner_for_org_with_http_info(org, runner_id, enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise_request)

```ruby
begin
  # Set custom labels for a self-hosted runner for an organization
  data, status_code, headers = api_instance.actions_set_custom_labels_for_self_hosted_runner_for_org_with_http_info(org, runner_id, enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_custom_labels_for_self_hosted_runner_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |
| **enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise_request** | [**EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest**](EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest.md) |  |  |

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## actions_set_custom_labels_for_self_hosted_runner_for_repo

> <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response> actions_set_custom_labels_for_self_hosted_runner_for_repo(owner, repo, runner_id, enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise_request)

Set custom labels for a self-hosted runner for a repository

Remove all previous custom labels and set the new custom labels for a specific self-hosted runner configured in a repository.  You must authenticate using an access token with the `repo` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.
enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise_request = OpenapiClient::EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest.new({labels: ['labels_example']}) # EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest | 

begin
  # Set custom labels for a self-hosted runner for a repository
  result = api_instance.actions_set_custom_labels_for_self_hosted_runner_for_repo(owner, repo, runner_id, enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_custom_labels_for_self_hosted_runner_for_repo: #{e}"
end
```

#### Using the actions_set_custom_labels_for_self_hosted_runner_for_repo_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>, Integer, Hash)> actions_set_custom_labels_for_self_hosted_runner_for_repo_with_http_info(owner, repo, runner_id, enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise_request)

```ruby
begin
  # Set custom labels for a self-hosted runner for a repository
  data, status_code, headers = api_instance.actions_set_custom_labels_for_self_hosted_runner_for_repo_with_http_info(owner, repo, runner_id, enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_custom_labels_for_self_hosted_runner_for_repo_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |
| **enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise_request** | [**EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest**](EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest.md) |  |  |

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## actions_set_custom_oidc_sub_claim_for_repo

> Object actions_set_custom_oidc_sub_claim_for_repo(owner, repo, the_json_payload_enables_disables_the_use_of_sub_claim_customization)

Set the opt-in flag of an OIDC subject claim customization for a repository

Sets the `opt-in` or `opt-out` flag of a GitHub Actions OpenID Connect (OIDC) subject claim customization for a repository. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `actions:write` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
the_json_payload_enables_disables_the_use_of_sub_claim_customization = OpenapiClient::TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization.new({use_default: false}) # TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization | 

begin
  # Set the opt-in flag of an OIDC subject claim customization for a repository
  result = api_instance.actions_set_custom_oidc_sub_claim_for_repo(owner, repo, the_json_payload_enables_disables_the_use_of_sub_claim_customization)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_custom_oidc_sub_claim_for_repo: #{e}"
end
```

#### Using the actions_set_custom_oidc_sub_claim_for_repo_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Object, Integer, Hash)> actions_set_custom_oidc_sub_claim_for_repo_with_http_info(owner, repo, the_json_payload_enables_disables_the_use_of_sub_claim_customization)

```ruby
begin
  # Set the opt-in flag of an OIDC subject claim customization for a repository
  data, status_code, headers = api_instance.actions_set_custom_oidc_sub_claim_for_repo_with_http_info(owner, repo, the_json_payload_enables_disables_the_use_of_sub_claim_customization)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Object
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_custom_oidc_sub_claim_for_repo_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **the_json_payload_enables_disables_the_use_of_sub_claim_customization** | [**TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization**](TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization.md) |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/scim+json


## actions_set_github_actions_default_workflow_permissions_enterprise

> actions_set_github_actions_default_workflow_permissions_enterprise(enterprise, actions_set_github_actions_default_workflow_permissions_enterprise_request)

Set default workflow permissions for an enterprise

Sets the default workflow permissions granted to the `GITHUB_TOKEN` when running workflows in an enterprise, and sets whether GitHub Actions can submit approving pull request reviews. For more information, see \"[Enforcing a policy for workflow permissions in your enterprise](https://docs.github.com/enterprise-cloud@latest/admin/policies/enforcing-policies-for-your-enterprise/enforcing-policies-for-github-actions-in-your-enterprise#enforcing-a-policy-for-workflow-permissions-in-your-enterprise).\"  You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint. GitHub Apps must have the `enterprise_administration:write` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
actions_set_github_actions_default_workflow_permissions_enterprise_request = OpenapiClient::ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest.new # ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest | 

begin
  # Set default workflow permissions for an enterprise
  api_instance.actions_set_github_actions_default_workflow_permissions_enterprise(enterprise, actions_set_github_actions_default_workflow_permissions_enterprise_request)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_github_actions_default_workflow_permissions_enterprise: #{e}"
end
```

#### Using the actions_set_github_actions_default_workflow_permissions_enterprise_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_set_github_actions_default_workflow_permissions_enterprise_with_http_info(enterprise, actions_set_github_actions_default_workflow_permissions_enterprise_request)

```ruby
begin
  # Set default workflow permissions for an enterprise
  data, status_code, headers = api_instance.actions_set_github_actions_default_workflow_permissions_enterprise_with_http_info(enterprise, actions_set_github_actions_default_workflow_permissions_enterprise_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_github_actions_default_workflow_permissions_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **actions_set_github_actions_default_workflow_permissions_enterprise_request** | [**ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest**](ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest.md) |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actions_set_github_actions_default_workflow_permissions_organization

> actions_set_github_actions_default_workflow_permissions_organization(org, opts)

Set default workflow permissions for an organization

Sets the default workflow permissions granted to the `GITHUB_TOKEN` when running workflows in an organization, and sets if GitHub Actions can submit approving pull request reviews. For more information, see \"[Setting the permissions of the GITHUB_TOKEN for your organization](https://docs.github.com/organizations/managing-organization-settings/disabling-or-limiting-github-actions-for-your-organization#setting-the-permissions-of-the-github_token-for-your-organization).\"  You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `administration` organization permission to use this API.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  actions_set_github_actions_default_workflow_permissions_enterprise_request: OpenapiClient::ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest.new # ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest | 
}

begin
  # Set default workflow permissions for an organization
  api_instance.actions_set_github_actions_default_workflow_permissions_organization(org, opts)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_github_actions_default_workflow_permissions_organization: #{e}"
end
```

#### Using the actions_set_github_actions_default_workflow_permissions_organization_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_set_github_actions_default_workflow_permissions_organization_with_http_info(org, opts)

```ruby
begin
  # Set default workflow permissions for an organization
  data, status_code, headers = api_instance.actions_set_github_actions_default_workflow_permissions_organization_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_github_actions_default_workflow_permissions_organization_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **actions_set_github_actions_default_workflow_permissions_enterprise_request** | [**ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest**](ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest.md) |  | [optional] |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actions_set_github_actions_default_workflow_permissions_repository

> actions_set_github_actions_default_workflow_permissions_repository(owner, repo, actions_set_github_actions_default_workflow_permissions_enterprise_request)

Set default workflow permissions for a repository

Sets the default workflow permissions granted to the `GITHUB_TOKEN` when running workflows in a repository, and sets if GitHub Actions can submit approving pull request reviews. For more information, see \"[Setting the permissions of the GITHUB_TOKEN for your repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#setting-the-permissions-of-the-github_token-for-your-repository).\"  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the repository `administration` permission to use this API.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
actions_set_github_actions_default_workflow_permissions_enterprise_request = OpenapiClient::ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest.new # ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest | 

begin
  # Set default workflow permissions for a repository
  api_instance.actions_set_github_actions_default_workflow_permissions_repository(owner, repo, actions_set_github_actions_default_workflow_permissions_enterprise_request)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_github_actions_default_workflow_permissions_repository: #{e}"
end
```

#### Using the actions_set_github_actions_default_workflow_permissions_repository_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_set_github_actions_default_workflow_permissions_repository_with_http_info(owner, repo, actions_set_github_actions_default_workflow_permissions_enterprise_request)

```ruby
begin
  # Set default workflow permissions for a repository
  data, status_code, headers = api_instance.actions_set_github_actions_default_workflow_permissions_repository_with_http_info(owner, repo, actions_set_github_actions_default_workflow_permissions_enterprise_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_github_actions_default_workflow_permissions_repository_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **actions_set_github_actions_default_workflow_permissions_enterprise_request** | [**ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest**](ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest.md) |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actions_set_github_actions_permissions_organization

> actions_set_github_actions_permissions_organization(org, actions_set_github_actions_permissions_organization_request)

Set GitHub Actions permissions for an organization

Sets the GitHub Actions permissions policy for repositories and allowed actions and reusable workflows in an organization.  If the organization belongs to an enterprise that has set restrictive permissions at the enterprise level, such as `allowed_actions` to `selected` actions and reusable workflows, then you cannot override them for the organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `administration` organization permission to use this API.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
actions_set_github_actions_permissions_organization_request = OpenapiClient::ActionsSetGithubActionsPermissionsOrganizationRequest.new({enabled_repositories: 'all'}) # ActionsSetGithubActionsPermissionsOrganizationRequest | 

begin
  # Set GitHub Actions permissions for an organization
  api_instance.actions_set_github_actions_permissions_organization(org, actions_set_github_actions_permissions_organization_request)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_github_actions_permissions_organization: #{e}"
end
```

#### Using the actions_set_github_actions_permissions_organization_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_set_github_actions_permissions_organization_with_http_info(org, actions_set_github_actions_permissions_organization_request)

```ruby
begin
  # Set GitHub Actions permissions for an organization
  data, status_code, headers = api_instance.actions_set_github_actions_permissions_organization_with_http_info(org, actions_set_github_actions_permissions_organization_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_github_actions_permissions_organization_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **actions_set_github_actions_permissions_organization_request** | [**ActionsSetGithubActionsPermissionsOrganizationRequest**](ActionsSetGithubActionsPermissionsOrganizationRequest.md) |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actions_set_github_actions_permissions_repository

> actions_set_github_actions_permissions_repository(owner, repo, actions_set_github_actions_permissions_repository_request)

Set GitHub Actions permissions for a repository

Sets the GitHub Actions permissions policy for enabling GitHub Actions and allowed actions and reusable workflows in the repository.  If the repository belongs to an organization or enterprise that has set restrictive permissions at the organization or enterprise levels, such as `allowed_actions` to `selected` actions and reusable workflows, then you cannot override them for the repository.  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `administration` repository permission to use this API.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
actions_set_github_actions_permissions_repository_request = OpenapiClient::ActionsSetGithubActionsPermissionsRepositoryRequest.new({enabled: false}) # ActionsSetGithubActionsPermissionsRepositoryRequest | 

begin
  # Set GitHub Actions permissions for a repository
  api_instance.actions_set_github_actions_permissions_repository(owner, repo, actions_set_github_actions_permissions_repository_request)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_github_actions_permissions_repository: #{e}"
end
```

#### Using the actions_set_github_actions_permissions_repository_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_set_github_actions_permissions_repository_with_http_info(owner, repo, actions_set_github_actions_permissions_repository_request)

```ruby
begin
  # Set GitHub Actions permissions for a repository
  data, status_code, headers = api_instance.actions_set_github_actions_permissions_repository_with_http_info(owner, repo, actions_set_github_actions_permissions_repository_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_github_actions_permissions_repository_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **actions_set_github_actions_permissions_repository_request** | [**ActionsSetGithubActionsPermissionsRepositoryRequest**](ActionsSetGithubActionsPermissionsRepositoryRequest.md) |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actions_set_repo_access_to_self_hosted_runner_group_in_org

> actions_set_repo_access_to_self_hosted_runner_group_in_org(org, runner_group_id, actions_set_repo_access_to_self_hosted_runner_group_in_org_request)

Set repository access for a self-hosted runner group in an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"  Replaces the list of repositories that have access to a self-hosted runner group configured in an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
runner_group_id = 56 # Integer | Unique identifier of the self-hosted runner group.
actions_set_repo_access_to_self_hosted_runner_group_in_org_request = OpenapiClient::ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest.new({selected_repository_ids: [37]}) # ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest | 

begin
  # Set repository access for a self-hosted runner group in an organization
  api_instance.actions_set_repo_access_to_self_hosted_runner_group_in_org(org, runner_group_id, actions_set_repo_access_to_self_hosted_runner_group_in_org_request)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_repo_access_to_self_hosted_runner_group_in_org: #{e}"
end
```

#### Using the actions_set_repo_access_to_self_hosted_runner_group_in_org_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_set_repo_access_to_self_hosted_runner_group_in_org_with_http_info(org, runner_group_id, actions_set_repo_access_to_self_hosted_runner_group_in_org_request)

```ruby
begin
  # Set repository access for a self-hosted runner group in an organization
  data, status_code, headers = api_instance.actions_set_repo_access_to_self_hosted_runner_group_in_org_with_http_info(org, runner_group_id, actions_set_repo_access_to_self_hosted_runner_group_in_org_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_repo_access_to_self_hosted_runner_group_in_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **runner_group_id** | **Integer** | Unique identifier of the self-hosted runner group. |  |
| **actions_set_repo_access_to_self_hosted_runner_group_in_org_request** | [**ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest**](ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest.md) |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actions_set_selected_repos_for_org_secret

> actions_set_selected_repos_for_org_secret(org, secret_name, actions_set_selected_repos_for_org_secret_request)

Set selected repositories for an organization secret

Replaces all repositories for an organization secret when the `visibility` for repository access is set to `selected`. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/actions#create-or-update-an-organization-secret). You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `secrets` organization permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.
actions_set_selected_repos_for_org_secret_request = OpenapiClient::ActionsSetSelectedReposForOrgSecretRequest.new({selected_repository_ids: [37]}) # ActionsSetSelectedReposForOrgSecretRequest | 

begin
  # Set selected repositories for an organization secret
  api_instance.actions_set_selected_repos_for_org_secret(org, secret_name, actions_set_selected_repos_for_org_secret_request)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_selected_repos_for_org_secret: #{e}"
end
```

#### Using the actions_set_selected_repos_for_org_secret_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_set_selected_repos_for_org_secret_with_http_info(org, secret_name, actions_set_selected_repos_for_org_secret_request)

```ruby
begin
  # Set selected repositories for an organization secret
  data, status_code, headers = api_instance.actions_set_selected_repos_for_org_secret_with_http_info(org, secret_name, actions_set_selected_repos_for_org_secret_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_selected_repos_for_org_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **secret_name** | **String** | The name of the secret. |  |
| **actions_set_selected_repos_for_org_secret_request** | [**ActionsSetSelectedReposForOrgSecretRequest**](ActionsSetSelectedReposForOrgSecretRequest.md) |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actions_set_selected_repositories_enabled_github_actions_organization

> actions_set_selected_repositories_enabled_github_actions_organization(org, actions_set_selected_repositories_enabled_github_actions_organization_request)

Set selected repositories enabled for GitHub Actions in an organization

Replaces the list of selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for `enabled_repositories` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\"  You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `administration` organization permission to use this API.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
actions_set_selected_repositories_enabled_github_actions_organization_request = OpenapiClient::ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest.new({selected_repository_ids: [37]}) # ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest | 

begin
  # Set selected repositories enabled for GitHub Actions in an organization
  api_instance.actions_set_selected_repositories_enabled_github_actions_organization(org, actions_set_selected_repositories_enabled_github_actions_organization_request)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_selected_repositories_enabled_github_actions_organization: #{e}"
end
```

#### Using the actions_set_selected_repositories_enabled_github_actions_organization_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_set_selected_repositories_enabled_github_actions_organization_with_http_info(org, actions_set_selected_repositories_enabled_github_actions_organization_request)

```ruby
begin
  # Set selected repositories enabled for GitHub Actions in an organization
  data, status_code, headers = api_instance.actions_set_selected_repositories_enabled_github_actions_organization_with_http_info(org, actions_set_selected_repositories_enabled_github_actions_organization_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_selected_repositories_enabled_github_actions_organization_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **actions_set_selected_repositories_enabled_github_actions_organization_request** | [**ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest**](ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest.md) |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actions_set_self_hosted_runners_in_group_for_org

> actions_set_self_hosted_runners_in_group_for_org(org, runner_group_id, enterprise_admin_set_self_hosted_runners_in_group_for_enterprise_request)

Set self-hosted runners in a group for an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"  Replaces the list of self-hosted runners that are part of an organization runner group.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
runner_group_id = 56 # Integer | Unique identifier of the self-hosted runner group.
enterprise_admin_set_self_hosted_runners_in_group_for_enterprise_request = OpenapiClient::EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest.new({runners: [37]}) # EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest | 

begin
  # Set self-hosted runners in a group for an organization
  api_instance.actions_set_self_hosted_runners_in_group_for_org(org, runner_group_id, enterprise_admin_set_self_hosted_runners_in_group_for_enterprise_request)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_self_hosted_runners_in_group_for_org: #{e}"
end
```

#### Using the actions_set_self_hosted_runners_in_group_for_org_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_set_self_hosted_runners_in_group_for_org_with_http_info(org, runner_group_id, enterprise_admin_set_self_hosted_runners_in_group_for_enterprise_request)

```ruby
begin
  # Set self-hosted runners in a group for an organization
  data, status_code, headers = api_instance.actions_set_self_hosted_runners_in_group_for_org_with_http_info(org, runner_group_id, enterprise_admin_set_self_hosted_runners_in_group_for_enterprise_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_self_hosted_runners_in_group_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **runner_group_id** | **Integer** | Unique identifier of the self-hosted runner group. |  |
| **enterprise_admin_set_self_hosted_runners_in_group_for_enterprise_request** | [**EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest**](EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest.md) |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actions_set_workflow_access_to_repository

> actions_set_workflow_access_to_repository(owner, repo, actions_get_workflow_access_to_repository200_response)

Set the level of access for workflows outside of the repository

Sets the level of access that workflows outside of the repository have to actions and reusable workflows in the repository. This endpoint only applies to internal and private repositories. For more information, see \"[Managing GitHub Actions settings for a repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#allowing-access-to-components-in-a-private-repository)\" for GitHub.com and \"[Managing GitHub Actions settings for a repository](https://docs.github.com/enterprise-cloud@latest/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#allowing-access-to-components-in-an-internal-repository)\" for GitHub Enterprise Cloud.  You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the repository `administration` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
actions_get_workflow_access_to_repository200_response = OpenapiClient::ActionsGetWorkflowAccessToRepository200Response.new({access_level: 'none'}) # ActionsGetWorkflowAccessToRepository200Response | 

begin
  # Set the level of access for workflows outside of the repository
  api_instance.actions_set_workflow_access_to_repository(owner, repo, actions_get_workflow_access_to_repository200_response)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_workflow_access_to_repository: #{e}"
end
```

#### Using the actions_set_workflow_access_to_repository_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> actions_set_workflow_access_to_repository_with_http_info(owner, repo, actions_get_workflow_access_to_repository200_response)

```ruby
begin
  # Set the level of access for workflows outside of the repository
  data, status_code, headers = api_instance.actions_set_workflow_access_to_repository_with_http_info(owner, repo, actions_get_workflow_access_to_repository200_response)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_set_workflow_access_to_repository_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **actions_get_workflow_access_to_repository200_response** | [**ActionsGetWorkflowAccessToRepository200Response**](ActionsGetWorkflowAccessToRepository200Response.md) |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actions_update_self_hosted_runner_group_for_org

> <ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner> actions_update_self_hosted_runner_group_for_org(org, runner_group_id, actions_update_self_hosted_runner_group_for_org_request)

Update a self-hosted runner group for an organization

The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \"[GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).\"  Updates the `name` and `visibility` of a self-hosted runner group in an organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ActionsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
runner_group_id = 56 # Integer | Unique identifier of the self-hosted runner group.
actions_update_self_hosted_runner_group_for_org_request = OpenapiClient::ActionsUpdateSelfHostedRunnerGroupForOrgRequest.new({name: 'name_example'}) # ActionsUpdateSelfHostedRunnerGroupForOrgRequest | 

begin
  # Update a self-hosted runner group for an organization
  result = api_instance.actions_update_self_hosted_runner_group_for_org(org, runner_group_id, actions_update_self_hosted_runner_group_for_org_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_update_self_hosted_runner_group_for_org: #{e}"
end
```

#### Using the actions_update_self_hosted_runner_group_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner>, Integer, Hash)> actions_update_self_hosted_runner_group_for_org_with_http_info(org, runner_group_id, actions_update_self_hosted_runner_group_for_org_request)

```ruby
begin
  # Update a self-hosted runner group for an organization
  data, status_code, headers = api_instance.actions_update_self_hosted_runner_group_for_org_with_http_info(org, runner_group_id, actions_update_self_hosted_runner_group_for_org_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ActionsApi->actions_update_self_hosted_runner_group_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **runner_group_id** | **Integer** | Unique identifier of the self-hosted runner group. |  |
| **actions_update_self_hosted_runner_group_for_org_request** | [**ActionsUpdateSelfHostedRunnerGroupForOrgRequest**](ActionsUpdateSelfHostedRunnerGroupForOrgRequest.md) |  |  |

### Return type

[**ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner**](ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

