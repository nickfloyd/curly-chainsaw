# OpenapiClient::ReposApi

All URIs are relative to *https://api.github.com*

| Method | HTTP request | Description |
| ------ | ------------ | ----------- |
| [**repos_accept_invitation_for_authenticated_user**](ReposApi.md#repos_accept_invitation_for_authenticated_user) | **PATCH** /user/repository_invitations/{invitation_id} | Accept a repository invitation |
| [**repos_add_app_access_restrictions**](ReposApi.md#repos_add_app_access_restrictions) | **POST** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/apps | Add app access restrictions |
| [**repos_add_collaborator**](ReposApi.md#repos_add_collaborator) | **PUT** /repos/{owner}/{repo}/collaborators/{username} | Add a repository collaborator |
| [**repos_add_status_check_contexts**](ReposApi.md#repos_add_status_check_contexts) | **POST** /repos/{owner}/{repo}/branches/{branch}/protection/required_status_checks/contexts | Add status check contexts |
| [**repos_add_team_access_restrictions**](ReposApi.md#repos_add_team_access_restrictions) | **POST** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/teams | Add team access restrictions |
| [**repos_add_user_access_restrictions**](ReposApi.md#repos_add_user_access_restrictions) | **POST** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/users | Add user access restrictions |
| [**repos_check_collaborator**](ReposApi.md#repos_check_collaborator) | **GET** /repos/{owner}/{repo}/collaborators/{username} | Check if a user is a repository collaborator |
| [**repos_check_vulnerability_alerts**](ReposApi.md#repos_check_vulnerability_alerts) | **GET** /repos/{owner}/{repo}/vulnerability-alerts | Check if vulnerability alerts are enabled for a repository |
| [**repos_codeowners_errors**](ReposApi.md#repos_codeowners_errors) | **GET** /repos/{owner}/{repo}/codeowners/errors | List CODEOWNERS errors |
| [**repos_compare_commits**](ReposApi.md#repos_compare_commits) | **GET** /repos/{owner}/{repo}/compare/{basehead} | Compare two commits |
| [**repos_create_autolink**](ReposApi.md#repos_create_autolink) | **POST** /repos/{owner}/{repo}/autolinks | Create an autolink reference for a repository |
| [**repos_create_commit_comment**](ReposApi.md#repos_create_commit_comment) | **POST** /repos/{owner}/{repo}/commits/{commit_sha}/comments | Create a commit comment |
| [**repos_create_commit_signature_protection**](ReposApi.md#repos_create_commit_signature_protection) | **POST** /repos/{owner}/{repo}/branches/{branch}/protection/required_signatures | Create commit signature protection |
| [**repos_create_commit_status**](ReposApi.md#repos_create_commit_status) | **POST** /repos/{owner}/{repo}/statuses/{sha} | Create a commit status |
| [**repos_create_deploy_key**](ReposApi.md#repos_create_deploy_key) | **POST** /repos/{owner}/{repo}/keys | Create a deploy key |
| [**repos_create_deployment**](ReposApi.md#repos_create_deployment) | **POST** /repos/{owner}/{repo}/deployments | Create a deployment |
| [**repos_create_deployment_status**](ReposApi.md#repos_create_deployment_status) | **POST** /repos/{owner}/{repo}/deployments/{deployment_id}/statuses | Create a deployment status |
| [**repos_create_dispatch_event**](ReposApi.md#repos_create_dispatch_event) | **POST** /repos/{owner}/{repo}/dispatches | Create a repository dispatch event |
| [**repos_create_for_authenticated_user**](ReposApi.md#repos_create_for_authenticated_user) | **POST** /user/repos | Create a repository for the authenticated user |
| [**repos_create_fork**](ReposApi.md#repos_create_fork) | **POST** /repos/{owner}/{repo}/forks | Create a fork |
| [**repos_create_in_org**](ReposApi.md#repos_create_in_org) | **POST** /orgs/{org}/repos | Create an organization repository |
| [**repos_create_or_update_environment**](ReposApi.md#repos_create_or_update_environment) | **PUT** /repos/{owner}/{repo}/environments/{environment_name} | Create or update an environment |
| [**repos_create_or_update_file_contents**](ReposApi.md#repos_create_or_update_file_contents) | **PUT** /repos/{owner}/{repo}/contents/{path} | Create or update file contents |
| [**repos_create_pages_deployment**](ReposApi.md#repos_create_pages_deployment) | **POST** /repos/{owner}/{repo}/pages/deployment | Create a GitHub Pages deployment |
| [**repos_create_pages_site**](ReposApi.md#repos_create_pages_site) | **POST** /repos/{owner}/{repo}/pages | Create a GitHub Pages site |
| [**repos_create_release**](ReposApi.md#repos_create_release) | **POST** /repos/{owner}/{repo}/releases | Create a release |
| [**repos_create_tag_protection**](ReposApi.md#repos_create_tag_protection) | **POST** /repos/{owner}/{repo}/tags/protection | Create a tag protection state for a repository |
| [**repos_create_using_template**](ReposApi.md#repos_create_using_template) | **POST** /repos/{template_owner}/{template_repo}/generate | Create a repository using a template |
| [**repos_create_webhook**](ReposApi.md#repos_create_webhook) | **POST** /repos/{owner}/{repo}/hooks | Create a repository webhook |
| [**repos_decline_invitation_for_authenticated_user**](ReposApi.md#repos_decline_invitation_for_authenticated_user) | **DELETE** /user/repository_invitations/{invitation_id} | Decline a repository invitation |
| [**repos_delete**](ReposApi.md#repos_delete) | **DELETE** /repos/{owner}/{repo} | Delete a repository |
| [**repos_delete_access_restrictions**](ReposApi.md#repos_delete_access_restrictions) | **DELETE** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions | Delete access restrictions |
| [**repos_delete_admin_branch_protection**](ReposApi.md#repos_delete_admin_branch_protection) | **DELETE** /repos/{owner}/{repo}/branches/{branch}/protection/enforce_admins | Delete admin branch protection |
| [**repos_delete_an_environment**](ReposApi.md#repos_delete_an_environment) | **DELETE** /repos/{owner}/{repo}/environments/{environment_name} | Delete an environment |
| [**repos_delete_autolink**](ReposApi.md#repos_delete_autolink) | **DELETE** /repos/{owner}/{repo}/autolinks/{autolink_id} | Delete an autolink reference from a repository |
| [**repos_delete_branch_protection**](ReposApi.md#repos_delete_branch_protection) | **DELETE** /repos/{owner}/{repo}/branches/{branch}/protection | Delete branch protection |
| [**repos_delete_commit_comment**](ReposApi.md#repos_delete_commit_comment) | **DELETE** /repos/{owner}/{repo}/comments/{comment_id} | Delete a commit comment |
| [**repos_delete_commit_signature_protection**](ReposApi.md#repos_delete_commit_signature_protection) | **DELETE** /repos/{owner}/{repo}/branches/{branch}/protection/required_signatures | Delete commit signature protection |
| [**repos_delete_deploy_key**](ReposApi.md#repos_delete_deploy_key) | **DELETE** /repos/{owner}/{repo}/keys/{key_id} | Delete a deploy key |
| [**repos_delete_deployment**](ReposApi.md#repos_delete_deployment) | **DELETE** /repos/{owner}/{repo}/deployments/{deployment_id} | Delete a deployment |
| [**repos_delete_file**](ReposApi.md#repos_delete_file) | **DELETE** /repos/{owner}/{repo}/contents/{path} | Delete a file |
| [**repos_delete_invitation**](ReposApi.md#repos_delete_invitation) | **DELETE** /repos/{owner}/{repo}/invitations/{invitation_id} | Delete a repository invitation |
| [**repos_delete_pages_site**](ReposApi.md#repos_delete_pages_site) | **DELETE** /repos/{owner}/{repo}/pages | Delete a GitHub Pages site |
| [**repos_delete_pull_request_review_protection**](ReposApi.md#repos_delete_pull_request_review_protection) | **DELETE** /repos/{owner}/{repo}/branches/{branch}/protection/required_pull_request_reviews | Delete pull request review protection |
| [**repos_delete_release**](ReposApi.md#repos_delete_release) | **DELETE** /repos/{owner}/{repo}/releases/{release_id} | Delete a release |
| [**repos_delete_release_asset**](ReposApi.md#repos_delete_release_asset) | **DELETE** /repos/{owner}/{repo}/releases/assets/{asset_id} | Delete a release asset |
| [**repos_delete_tag_protection**](ReposApi.md#repos_delete_tag_protection) | **DELETE** /repos/{owner}/{repo}/tags/protection/{tag_protection_id} | Delete a tag protection state for a repository |
| [**repos_delete_webhook**](ReposApi.md#repos_delete_webhook) | **DELETE** /repos/{owner}/{repo}/hooks/{hook_id} | Delete a repository webhook |
| [**repos_disable_automated_security_fixes**](ReposApi.md#repos_disable_automated_security_fixes) | **DELETE** /repos/{owner}/{repo}/automated-security-fixes | Disable automated security fixes |
| [**repos_disable_lfs_for_repo**](ReposApi.md#repos_disable_lfs_for_repo) | **DELETE** /repos/{owner}/{repo}/lfs | Disable Git LFS for a repository |
| [**repos_disable_vulnerability_alerts**](ReposApi.md#repos_disable_vulnerability_alerts) | **DELETE** /repos/{owner}/{repo}/vulnerability-alerts | Disable vulnerability alerts |
| [**repos_download_tarball_archive**](ReposApi.md#repos_download_tarball_archive) | **GET** /repos/{owner}/{repo}/tarball/{ref} | Download a repository archive (tar) |
| [**repos_download_zipball_archive**](ReposApi.md#repos_download_zipball_archive) | **GET** /repos/{owner}/{repo}/zipball/{ref} | Download a repository archive (zip) |
| [**repos_enable_automated_security_fixes**](ReposApi.md#repos_enable_automated_security_fixes) | **PUT** /repos/{owner}/{repo}/automated-security-fixes | Enable automated security fixes |
| [**repos_enable_lfs_for_repo**](ReposApi.md#repos_enable_lfs_for_repo) | **PUT** /repos/{owner}/{repo}/lfs | Enable Git LFS for a repository |
| [**repos_enable_vulnerability_alerts**](ReposApi.md#repos_enable_vulnerability_alerts) | **PUT** /repos/{owner}/{repo}/vulnerability-alerts | Enable vulnerability alerts |
| [**repos_generate_release_notes**](ReposApi.md#repos_generate_release_notes) | **POST** /repos/{owner}/{repo}/releases/generate-notes | Generate release notes content for a release |
| [**repos_get**](ReposApi.md#repos_get) | **GET** /repos/{owner}/{repo} | Get a repository |
| [**repos_get_access_restrictions**](ReposApi.md#repos_get_access_restrictions) | **GET** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions | Get access restrictions |
| [**repos_get_admin_branch_protection**](ReposApi.md#repos_get_admin_branch_protection) | **GET** /repos/{owner}/{repo}/branches/{branch}/protection/enforce_admins | Get admin branch protection |
| [**repos_get_all_environments**](ReposApi.md#repos_get_all_environments) | **GET** /repos/{owner}/{repo}/environments | Get all environments |
| [**repos_get_all_status_check_contexts**](ReposApi.md#repos_get_all_status_check_contexts) | **GET** /repos/{owner}/{repo}/branches/{branch}/protection/required_status_checks/contexts | Get all status check contexts |
| [**repos_get_all_topics**](ReposApi.md#repos_get_all_topics) | **GET** /repos/{owner}/{repo}/topics | Get all repository topics |
| [**repos_get_apps_with_access_to_protected_branch**](ReposApi.md#repos_get_apps_with_access_to_protected_branch) | **GET** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/apps | Get apps with access to the protected branch |
| [**repos_get_autolink**](ReposApi.md#repos_get_autolink) | **GET** /repos/{owner}/{repo}/autolinks/{autolink_id} | Get an autolink reference of a repository |
| [**repos_get_branch**](ReposApi.md#repos_get_branch) | **GET** /repos/{owner}/{repo}/branches/{branch} | Get a branch |
| [**repos_get_branch_protection**](ReposApi.md#repos_get_branch_protection) | **GET** /repos/{owner}/{repo}/branches/{branch}/protection | Get branch protection |
| [**repos_get_clones**](ReposApi.md#repos_get_clones) | **GET** /repos/{owner}/{repo}/traffic/clones | Get repository clones |
| [**repos_get_code_frequency_stats**](ReposApi.md#repos_get_code_frequency_stats) | **GET** /repos/{owner}/{repo}/stats/code_frequency | Get the weekly commit activity |
| [**repos_get_collaborator_permission_level**](ReposApi.md#repos_get_collaborator_permission_level) | **GET** /repos/{owner}/{repo}/collaborators/{username}/permission | Get repository permissions for a user |
| [**repos_get_combined_status_for_ref**](ReposApi.md#repos_get_combined_status_for_ref) | **GET** /repos/{owner}/{repo}/commits/{ref}/status | Get the combined status for a specific reference |
| [**repos_get_commit**](ReposApi.md#repos_get_commit) | **GET** /repos/{owner}/{repo}/commits/{ref} | Get a commit |
| [**repos_get_commit_activity_stats**](ReposApi.md#repos_get_commit_activity_stats) | **GET** /repos/{owner}/{repo}/stats/commit_activity | Get the last year of commit activity |
| [**repos_get_commit_comment**](ReposApi.md#repos_get_commit_comment) | **GET** /repos/{owner}/{repo}/comments/{comment_id} | Get a commit comment |
| [**repos_get_commit_signature_protection**](ReposApi.md#repos_get_commit_signature_protection) | **GET** /repos/{owner}/{repo}/branches/{branch}/protection/required_signatures | Get commit signature protection |
| [**repos_get_community_profile_metrics**](ReposApi.md#repos_get_community_profile_metrics) | **GET** /repos/{owner}/{repo}/community/profile | Get community profile metrics |
| [**repos_get_content**](ReposApi.md#repos_get_content) | **GET** /repos/{owner}/{repo}/contents/{path} | Get repository content |
| [**repos_get_contributors_stats**](ReposApi.md#repos_get_contributors_stats) | **GET** /repos/{owner}/{repo}/stats/contributors | Get all contributor commit activity |
| [**repos_get_deploy_key**](ReposApi.md#repos_get_deploy_key) | **GET** /repos/{owner}/{repo}/keys/{key_id} | Get a deploy key |
| [**repos_get_deployment**](ReposApi.md#repos_get_deployment) | **GET** /repos/{owner}/{repo}/deployments/{deployment_id} | Get a deployment |
| [**repos_get_deployment_status**](ReposApi.md#repos_get_deployment_status) | **GET** /repos/{owner}/{repo}/deployments/{deployment_id}/statuses/{status_id} | Get a deployment status |
| [**repos_get_environment**](ReposApi.md#repos_get_environment) | **GET** /repos/{owner}/{repo}/environments/{environment_name} | Get an environment |
| [**repos_get_latest_pages_build**](ReposApi.md#repos_get_latest_pages_build) | **GET** /repos/{owner}/{repo}/pages/builds/latest | Get latest Pages build |
| [**repos_get_latest_release**](ReposApi.md#repos_get_latest_release) | **GET** /repos/{owner}/{repo}/releases/latest | Get the latest release |
| [**repos_get_pages**](ReposApi.md#repos_get_pages) | **GET** /repos/{owner}/{repo}/pages | Get a GitHub Pages site |
| [**repos_get_pages_build**](ReposApi.md#repos_get_pages_build) | **GET** /repos/{owner}/{repo}/pages/builds/{build_id} | Get GitHub Pages build |
| [**repos_get_pages_health_check**](ReposApi.md#repos_get_pages_health_check) | **GET** /repos/{owner}/{repo}/pages/health | Get a DNS health check for GitHub Pages |
| [**repos_get_participation_stats**](ReposApi.md#repos_get_participation_stats) | **GET** /repos/{owner}/{repo}/stats/participation | Get the weekly commit count |
| [**repos_get_pull_request_review_protection**](ReposApi.md#repos_get_pull_request_review_protection) | **GET** /repos/{owner}/{repo}/branches/{branch}/protection/required_pull_request_reviews | Get pull request review protection |
| [**repos_get_punch_card_stats**](ReposApi.md#repos_get_punch_card_stats) | **GET** /repos/{owner}/{repo}/stats/punch_card | Get the hourly commit count for each day |
| [**repos_get_readme**](ReposApi.md#repos_get_readme) | **GET** /repos/{owner}/{repo}/readme | Get a repository README |
| [**repos_get_readme_in_directory**](ReposApi.md#repos_get_readme_in_directory) | **GET** /repos/{owner}/{repo}/readme/{dir} | Get a repository README for a directory |
| [**repos_get_release**](ReposApi.md#repos_get_release) | **GET** /repos/{owner}/{repo}/releases/{release_id} | Get a release |
| [**repos_get_release_asset**](ReposApi.md#repos_get_release_asset) | **GET** /repos/{owner}/{repo}/releases/assets/{asset_id} | Get a release asset |
| [**repos_get_release_by_tag**](ReposApi.md#repos_get_release_by_tag) | **GET** /repos/{owner}/{repo}/releases/tags/{tag} | Get a release by tag name |
| [**repos_get_status_checks_protection**](ReposApi.md#repos_get_status_checks_protection) | **GET** /repos/{owner}/{repo}/branches/{branch}/protection/required_status_checks | Get status checks protection |
| [**repos_get_teams_with_access_to_protected_branch**](ReposApi.md#repos_get_teams_with_access_to_protected_branch) | **GET** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/teams | Get teams with access to the protected branch |
| [**repos_get_top_paths**](ReposApi.md#repos_get_top_paths) | **GET** /repos/{owner}/{repo}/traffic/popular/paths | Get top referral paths |
| [**repos_get_top_referrers**](ReposApi.md#repos_get_top_referrers) | **GET** /repos/{owner}/{repo}/traffic/popular/referrers | Get top referral sources |
| [**repos_get_users_with_access_to_protected_branch**](ReposApi.md#repos_get_users_with_access_to_protected_branch) | **GET** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/users | Get users with access to the protected branch |
| [**repos_get_views**](ReposApi.md#repos_get_views) | **GET** /repos/{owner}/{repo}/traffic/views | Get page views |
| [**repos_get_webhook**](ReposApi.md#repos_get_webhook) | **GET** /repos/{owner}/{repo}/hooks/{hook_id} | Get a repository webhook |
| [**repos_get_webhook_config_for_repo**](ReposApi.md#repos_get_webhook_config_for_repo) | **GET** /repos/{owner}/{repo}/hooks/{hook_id}/config | Get a webhook configuration for a repository |
| [**repos_get_webhook_delivery**](ReposApi.md#repos_get_webhook_delivery) | **GET** /repos/{owner}/{repo}/hooks/{hook_id}/deliveries/{delivery_id} | Get a delivery for a repository webhook |
| [**repos_list_autolinks**](ReposApi.md#repos_list_autolinks) | **GET** /repos/{owner}/{repo}/autolinks | List all autolinks of a repository |
| [**repos_list_branches**](ReposApi.md#repos_list_branches) | **GET** /repos/{owner}/{repo}/branches | List branches |
| [**repos_list_branches_for_head_commit**](ReposApi.md#repos_list_branches_for_head_commit) | **GET** /repos/{owner}/{repo}/commits/{commit_sha}/branches-where-head | List branches for HEAD commit |
| [**repos_list_collaborators**](ReposApi.md#repos_list_collaborators) | **GET** /repos/{owner}/{repo}/collaborators | List repository collaborators |
| [**repos_list_comments_for_commit**](ReposApi.md#repos_list_comments_for_commit) | **GET** /repos/{owner}/{repo}/commits/{commit_sha}/comments | List commit comments |
| [**repos_list_commit_comments_for_repo**](ReposApi.md#repos_list_commit_comments_for_repo) | **GET** /repos/{owner}/{repo}/comments | List commit comments for a repository |
| [**repos_list_commit_statuses_for_ref**](ReposApi.md#repos_list_commit_statuses_for_ref) | **GET** /repos/{owner}/{repo}/commits/{ref}/statuses | List commit statuses for a reference |
| [**repos_list_commits**](ReposApi.md#repos_list_commits) | **GET** /repos/{owner}/{repo}/commits | List commits |
| [**repos_list_contributors**](ReposApi.md#repos_list_contributors) | **GET** /repos/{owner}/{repo}/contributors | List repository contributors |
| [**repos_list_deploy_keys**](ReposApi.md#repos_list_deploy_keys) | **GET** /repos/{owner}/{repo}/keys | List deploy keys |
| [**repos_list_deployment_statuses**](ReposApi.md#repos_list_deployment_statuses) | **GET** /repos/{owner}/{repo}/deployments/{deployment_id}/statuses | List deployment statuses |
| [**repos_list_deployments**](ReposApi.md#repos_list_deployments) | **GET** /repos/{owner}/{repo}/deployments | List deployments |
| [**repos_list_for_authenticated_user**](ReposApi.md#repos_list_for_authenticated_user) | **GET** /user/repos | List repositories for the authenticated user |
| [**repos_list_for_org**](ReposApi.md#repos_list_for_org) | **GET** /orgs/{org}/repos | List organization repositories |
| [**repos_list_for_user**](ReposApi.md#repos_list_for_user) | **GET** /users/{username}/repos | List repositories for a user |
| [**repos_list_forks**](ReposApi.md#repos_list_forks) | **GET** /repos/{owner}/{repo}/forks | List forks |
| [**repos_list_invitations**](ReposApi.md#repos_list_invitations) | **GET** /repos/{owner}/{repo}/invitations | List repository invitations |
| [**repos_list_invitations_for_authenticated_user**](ReposApi.md#repos_list_invitations_for_authenticated_user) | **GET** /user/repository_invitations | List repository invitations for the authenticated user |
| [**repos_list_languages**](ReposApi.md#repos_list_languages) | **GET** /repos/{owner}/{repo}/languages | List repository languages |
| [**repos_list_pages_builds**](ReposApi.md#repos_list_pages_builds) | **GET** /repos/{owner}/{repo}/pages/builds | List GitHub Pages builds |
| [**repos_list_public**](ReposApi.md#repos_list_public) | **GET** /repositories | List public repositories |
| [**repos_list_pull_requests_associated_with_commit**](ReposApi.md#repos_list_pull_requests_associated_with_commit) | **GET** /repos/{owner}/{repo}/commits/{commit_sha}/pulls | List pull requests associated with a commit |
| [**repos_list_release_assets**](ReposApi.md#repos_list_release_assets) | **GET** /repos/{owner}/{repo}/releases/{release_id}/assets | List release assets |
| [**repos_list_releases**](ReposApi.md#repos_list_releases) | **GET** /repos/{owner}/{repo}/releases | List releases |
| [**repos_list_tag_protection**](ReposApi.md#repos_list_tag_protection) | **GET** /repos/{owner}/{repo}/tags/protection | List tag protection states for a repository |
| [**repos_list_tags**](ReposApi.md#repos_list_tags) | **GET** /repos/{owner}/{repo}/tags | List repository tags |
| [**repos_list_teams**](ReposApi.md#repos_list_teams) | **GET** /repos/{owner}/{repo}/teams | List repository teams |
| [**repos_list_webhook_deliveries**](ReposApi.md#repos_list_webhook_deliveries) | **GET** /repos/{owner}/{repo}/hooks/{hook_id}/deliveries | List deliveries for a repository webhook |
| [**repos_list_webhooks**](ReposApi.md#repos_list_webhooks) | **GET** /repos/{owner}/{repo}/hooks | List repository webhooks |
| [**repos_merge**](ReposApi.md#repos_merge) | **POST** /repos/{owner}/{repo}/merges | Merge a branch |
| [**repos_merge_upstream**](ReposApi.md#repos_merge_upstream) | **POST** /repos/{owner}/{repo}/merge-upstream | Sync a fork branch with the upstream repository |
| [**repos_ping_webhook**](ReposApi.md#repos_ping_webhook) | **POST** /repos/{owner}/{repo}/hooks/{hook_id}/pings | Ping a repository webhook |
| [**repos_redeliver_webhook_delivery**](ReposApi.md#repos_redeliver_webhook_delivery) | **POST** /repos/{owner}/{repo}/hooks/{hook_id}/deliveries/{delivery_id}/attempts | Redeliver a delivery for a repository webhook |
| [**repos_remove_app_access_restrictions**](ReposApi.md#repos_remove_app_access_restrictions) | **DELETE** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/apps | Remove app access restrictions |
| [**repos_remove_collaborator**](ReposApi.md#repos_remove_collaborator) | **DELETE** /repos/{owner}/{repo}/collaborators/{username} | Remove a repository collaborator |
| [**repos_remove_status_check_contexts**](ReposApi.md#repos_remove_status_check_contexts) | **DELETE** /repos/{owner}/{repo}/branches/{branch}/protection/required_status_checks/contexts | Remove status check contexts |
| [**repos_remove_status_check_protection**](ReposApi.md#repos_remove_status_check_protection) | **DELETE** /repos/{owner}/{repo}/branches/{branch}/protection/required_status_checks | Remove status check protection |
| [**repos_remove_team_access_restrictions**](ReposApi.md#repos_remove_team_access_restrictions) | **DELETE** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/teams | Remove team access restrictions |
| [**repos_remove_user_access_restrictions**](ReposApi.md#repos_remove_user_access_restrictions) | **DELETE** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/users | Remove user access restrictions |
| [**repos_rename_branch**](ReposApi.md#repos_rename_branch) | **POST** /repos/{owner}/{repo}/branches/{branch}/rename | Rename a branch |
| [**repos_replace_all_topics**](ReposApi.md#repos_replace_all_topics) | **PUT** /repos/{owner}/{repo}/topics | Replace all repository topics |
| [**repos_request_pages_build**](ReposApi.md#repos_request_pages_build) | **POST** /repos/{owner}/{repo}/pages/builds | Request a GitHub Pages build |
| [**repos_set_admin_branch_protection**](ReposApi.md#repos_set_admin_branch_protection) | **POST** /repos/{owner}/{repo}/branches/{branch}/protection/enforce_admins | Set admin branch protection |
| [**repos_set_app_access_restrictions**](ReposApi.md#repos_set_app_access_restrictions) | **PUT** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/apps | Set app access restrictions |
| [**repos_set_status_check_contexts**](ReposApi.md#repos_set_status_check_contexts) | **PUT** /repos/{owner}/{repo}/branches/{branch}/protection/required_status_checks/contexts | Set status check contexts |
| [**repos_set_team_access_restrictions**](ReposApi.md#repos_set_team_access_restrictions) | **PUT** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/teams | Set team access restrictions |
| [**repos_set_user_access_restrictions**](ReposApi.md#repos_set_user_access_restrictions) | **PUT** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/users | Set user access restrictions |
| [**repos_test_push_webhook**](ReposApi.md#repos_test_push_webhook) | **POST** /repos/{owner}/{repo}/hooks/{hook_id}/tests | Test the push repository webhook |
| [**repos_transfer**](ReposApi.md#repos_transfer) | **POST** /repos/{owner}/{repo}/transfer | Transfer a repository |
| [**repos_update**](ReposApi.md#repos_update) | **PATCH** /repos/{owner}/{repo} | Update a repository |
| [**repos_update_branch_protection**](ReposApi.md#repos_update_branch_protection) | **PUT** /repos/{owner}/{repo}/branches/{branch}/protection | Update branch protection |
| [**repos_update_commit_comment**](ReposApi.md#repos_update_commit_comment) | **PATCH** /repos/{owner}/{repo}/comments/{comment_id} | Update a commit comment |
| [**repos_update_information_about_pages_site**](ReposApi.md#repos_update_information_about_pages_site) | **PUT** /repos/{owner}/{repo}/pages | Update information about a GitHub Pages site |
| [**repos_update_invitation**](ReposApi.md#repos_update_invitation) | **PATCH** /repos/{owner}/{repo}/invitations/{invitation_id} | Update a repository invitation |
| [**repos_update_pull_request_review_protection**](ReposApi.md#repos_update_pull_request_review_protection) | **PATCH** /repos/{owner}/{repo}/branches/{branch}/protection/required_pull_request_reviews | Update pull request review protection |
| [**repos_update_release**](ReposApi.md#repos_update_release) | **PATCH** /repos/{owner}/{repo}/releases/{release_id} | Update a release |
| [**repos_update_release_asset**](ReposApi.md#repos_update_release_asset) | **PATCH** /repos/{owner}/{repo}/releases/assets/{asset_id} | Update a release asset |
| [**repos_update_status_check_protection**](ReposApi.md#repos_update_status_check_protection) | **PATCH** /repos/{owner}/{repo}/branches/{branch}/protection/required_status_checks | Update status check protection |
| [**repos_update_webhook**](ReposApi.md#repos_update_webhook) | **PATCH** /repos/{owner}/{repo}/hooks/{hook_id} | Update a repository webhook |
| [**repos_update_webhook_config_for_repo**](ReposApi.md#repos_update_webhook_config_for_repo) | **PATCH** /repos/{owner}/{repo}/hooks/{hook_id}/config | Update a webhook configuration for a repository |
| [**repos_upload_release_asset**](ReposApi.md#repos_upload_release_asset) | **POST** /repos/{owner}/{repo}/releases/{release_id}/assets | Upload a release asset |


## repos_accept_invitation_for_authenticated_user

> repos_accept_invitation_for_authenticated_user(invitation_id)

Accept a repository invitation



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
invitation_id = 56 # Integer | The unique identifier of the invitation.

begin
  # Accept a repository invitation
  api_instance.repos_accept_invitation_for_authenticated_user(invitation_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_accept_invitation_for_authenticated_user: #{e}"
end
```

#### Using the repos_accept_invitation_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_accept_invitation_for_authenticated_user_with_http_info(invitation_id)

```ruby
begin
  # Accept a repository invitation
  data, status_code, headers = api_instance.repos_accept_invitation_for_authenticated_user_with_http_info(invitation_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_accept_invitation_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **invitation_id** | **Integer** | The unique identifier of the invitation. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_add_app_access_restrictions

> <Array<GitHubApp>> repos_add_app_access_restrictions(owner, repo, branch, opts)

Add app access restrictions

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Grants the specified apps push access for this branch. Only installed GitHub Apps with `write` access to the `contents` permission can be added as authorized actors on a protected branch.  | Type    | Description                                                                                                                                                | | ------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- | | `array` | The GitHub Apps that have push access to this branch. Use the app's `slug`. **Note**: The list of users, apps, and teams in total is limited to 100 items. |

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.
opts = {
  repos_set_app_access_restrictions_request: nil # ReposSetAppAccessRestrictionsRequest | 
}

begin
  # Add app access restrictions
  result = api_instance.repos_add_app_access_restrictions(owner, repo, branch, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_add_app_access_restrictions: #{e}"
end
```

#### Using the repos_add_app_access_restrictions_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<GitHubApp>>, Integer, Hash)> repos_add_app_access_restrictions_with_http_info(owner, repo, branch, opts)

```ruby
begin
  # Add app access restrictions
  data, status_code, headers = api_instance.repos_add_app_access_restrictions_with_http_info(owner, repo, branch, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<GitHubApp>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_add_app_access_restrictions_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |
| **repos_set_app_access_restrictions_request** | [**ReposSetAppAccessRestrictionsRequest**](ReposSetAppAccessRestrictionsRequest.md) |  | [optional] |

### Return type

[**Array&lt;GitHubApp&gt;**](GitHubApp.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_add_collaborator

> <RepositoryInvitation> repos_add_collaborator(owner, repo, username, opts)

Add a repository collaborator

This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \"[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\" and \"[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\" for details.  Adding an outside collaborator may be restricted by enterprise administrators. For more information, see \"[Enforcing repository management policies in your enterprise](https://docs.github.com/enterprise-cloud@latest/admin/policies/enforcing-policies-for-your-enterprise/enforcing-repository-management-policies-in-your-enterprise#enforcing-a-policy-for-inviting-outside-collaborators-to-repositories).\"  For more information on permission levels, see \"[Repository permission levels for an organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/repository-permission-levels-for-an-organization#permission-levels-for-repositories-owned-by-an-organization)\". There are restrictions on which permissions can be granted to organization members when an organization base role is in place. In this case, the permission being given must be equal to or higher than the org base permission. Otherwise, the request will fail with:  ``` Cannot assign {member} permission of {role name} ```  Note that, if you choose not to pass any parameters, you'll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see \"[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\"  The invitee will receive a notification that they have been invited to the repository, which they must accept or decline. They may do this via the notifications page, the email they receive, or by using the [repository invitations API endpoints](https://docs.github.com/rest/reference/repos#invitations).  **Updating an existing collaborator's permission level**  The endpoint can also be used to change the permissions of an existing collaborator without first removing and re-adding the collaborator. To change the permissions, use the same endpoint and pass a different `permission` parameter. The response will be a `204`, with no other indication that the permission level changed.  **Rate limits**  You are limited to sending 50 invitations to a repository per 24 hour period. Note there is no limit if you are inviting organization members to an organization repository.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
username = 'username_example' # String | The handle for the GitHub user account.
opts = {
  repos_add_collaborator_request: OpenapiClient::ReposAddCollaboratorRequest.new # ReposAddCollaboratorRequest | 
}

begin
  # Add a repository collaborator
  result = api_instance.repos_add_collaborator(owner, repo, username, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_add_collaborator: #{e}"
end
```

#### Using the repos_add_collaborator_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<RepositoryInvitation>, Integer, Hash)> repos_add_collaborator_with_http_info(owner, repo, username, opts)

```ruby
begin
  # Add a repository collaborator
  data, status_code, headers = api_instance.repos_add_collaborator_with_http_info(owner, repo, username, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <RepositoryInvitation>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_add_collaborator_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **username** | **String** | The handle for the GitHub user account. |  |
| **repos_add_collaborator_request** | [**ReposAddCollaboratorRequest**](ReposAddCollaboratorRequest.md) |  | [optional] |

### Return type

[**RepositoryInvitation**](RepositoryInvitation.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_add_status_check_contexts

> Array&lt;String&gt; repos_add_status_check_contexts(owner, repo, branch, opts)

Add status check contexts

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.
opts = {
  repos_set_status_check_contexts_request: nil # ReposSetStatusCheckContextsRequest | 
}

begin
  # Add status check contexts
  result = api_instance.repos_add_status_check_contexts(owner, repo, branch, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_add_status_check_contexts: #{e}"
end
```

#### Using the repos_add_status_check_contexts_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Array&lt;String&gt;, Integer, Hash)> repos_add_status_check_contexts_with_http_info(owner, repo, branch, opts)

```ruby
begin
  # Add status check contexts
  data, status_code, headers = api_instance.repos_add_status_check_contexts_with_http_info(owner, repo, branch, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Array&lt;String&gt;
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_add_status_check_contexts_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |
| **repos_set_status_check_contexts_request** | [**ReposSetStatusCheckContextsRequest**](ReposSetStatusCheckContextsRequest.md) |  | [optional] |

### Return type

**Array&lt;String&gt;**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_add_team_access_restrictions

> <Array<Team>> repos_add_team_access_restrictions(owner, repo, branch, opts)

Add team access restrictions

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Grants the specified teams push access for this branch. You can also give push access to child teams.  | Type    | Description                                                                                                                                | | ------- | ------------------------------------------------------------------------------------------------------------------------------------------ | | `array` | The teams that can have push access. Use the team's `slug`. **Note**: The list of users, apps, and teams in total is limited to 100 items. |

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.
opts = {
  repos_set_team_access_restrictions_request: nil # ReposSetTeamAccessRestrictionsRequest | 
}

begin
  # Add team access restrictions
  result = api_instance.repos_add_team_access_restrictions(owner, repo, branch, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_add_team_access_restrictions: #{e}"
end
```

#### Using the repos_add_team_access_restrictions_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<Team>>, Integer, Hash)> repos_add_team_access_restrictions_with_http_info(owner, repo, branch, opts)

```ruby
begin
  # Add team access restrictions
  data, status_code, headers = api_instance.repos_add_team_access_restrictions_with_http_info(owner, repo, branch, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<Team>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_add_team_access_restrictions_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |
| **repos_set_team_access_restrictions_request** | [**ReposSetTeamAccessRestrictionsRequest**](ReposSetTeamAccessRestrictionsRequest.md) |  | [optional] |

### Return type

[**Array&lt;Team&gt;**](Team.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_add_user_access_restrictions

> <Array<SimpleUser1>> repos_add_user_access_restrictions(owner, repo, branch, opts)

Add user access restrictions

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Grants the specified people push access for this branch.  | Type    | Description                                                                                                                   | | ------- | ----------------------------------------------------------------------------------------------------------------------------- | | `array` | Usernames for people who can have push access. **Note**: The list of users, apps, and teams in total is limited to 100 items. |

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.
opts = {
  repos_set_user_access_restrictions_request: nil # ReposSetUserAccessRestrictionsRequest | 
}

begin
  # Add user access restrictions
  result = api_instance.repos_add_user_access_restrictions(owner, repo, branch, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_add_user_access_restrictions: #{e}"
end
```

#### Using the repos_add_user_access_restrictions_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<SimpleUser1>>, Integer, Hash)> repos_add_user_access_restrictions_with_http_info(owner, repo, branch, opts)

```ruby
begin
  # Add user access restrictions
  data, status_code, headers = api_instance.repos_add_user_access_restrictions_with_http_info(owner, repo, branch, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<SimpleUser1>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_add_user_access_restrictions_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |
| **repos_set_user_access_restrictions_request** | [**ReposSetUserAccessRestrictionsRequest**](ReposSetUserAccessRestrictionsRequest.md) |  | [optional] |

### Return type

[**Array&lt;SimpleUser1&gt;**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_check_collaborator

> repos_check_collaborator(owner, repo, username)

Check if a user is a repository collaborator

For organization-owned repositories, the list of collaborators includes outside collaborators, organization members that are direct collaborators, organization members with access through team memberships, organization members with access through default organization permissions, and organization owners.  Team members will include the members of child teams.  You must authenticate using an access token with the `read:org` and `repo` scopes with push access to use this endpoint. GitHub Apps must have the `members` organization permission and `metadata` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
username = 'username_example' # String | The handle for the GitHub user account.

begin
  # Check if a user is a repository collaborator
  api_instance.repos_check_collaborator(owner, repo, username)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_check_collaborator: #{e}"
end
```

#### Using the repos_check_collaborator_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_check_collaborator_with_http_info(owner, repo, username)

```ruby
begin
  # Check if a user is a repository collaborator
  data, status_code, headers = api_instance.repos_check_collaborator_with_http_info(owner, repo, username)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_check_collaborator_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **username** | **String** | The handle for the GitHub user account. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## repos_check_vulnerability_alerts

> repos_check_vulnerability_alerts(owner, repo)

Check if vulnerability alerts are enabled for a repository

Shows whether dependency alerts are enabled or disabled for a repository. The authenticated user must have admin read access to the repository. For more information, see \"[About security alerts for vulnerable dependencies](https://docs.github.com/en/articles/about-security-alerts-for-vulnerable-dependencies)\".

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Check if vulnerability alerts are enabled for a repository
  api_instance.repos_check_vulnerability_alerts(owner, repo)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_check_vulnerability_alerts: #{e}"
end
```

#### Using the repos_check_vulnerability_alerts_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_check_vulnerability_alerts_with_http_info(owner, repo)

```ruby
begin
  # Check if vulnerability alerts are enabled for a repository
  data, status_code, headers = api_instance.repos_check_vulnerability_alerts_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_check_vulnerability_alerts_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## repos_codeowners_errors

> <CODEOWNERSErrors> repos_codeowners_errors(owner, repo, opts)

List CODEOWNERS errors

List any syntax errors that are detected in the CODEOWNERS file.  For more information about the correct CODEOWNERS syntax, see \"[About code owners](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/customizing-your-repository/about-code-owners).\"

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  ref: 'ref_example' # String | A branch, tag or commit name used to determine which version of the CODEOWNERS file to use. Default: the repository's default branch (e.g. `main`)
}

begin
  # List CODEOWNERS errors
  result = api_instance.repos_codeowners_errors(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_codeowners_errors: #{e}"
end
```

#### Using the repos_codeowners_errors_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CODEOWNERSErrors>, Integer, Hash)> repos_codeowners_errors_with_http_info(owner, repo, opts)

```ruby
begin
  # List CODEOWNERS errors
  data, status_code, headers = api_instance.repos_codeowners_errors_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CODEOWNERSErrors>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_codeowners_errors_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **ref** | **String** | A branch, tag or commit name used to determine which version of the CODEOWNERS file to use. Default: the repository&#39;s default branch (e.g. &#x60;main&#x60;) | [optional] |

### Return type

[**CODEOWNERSErrors**](CODEOWNERSErrors.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_compare_commits

> <CommitComparison> repos_compare_commits(owner, repo, basehead, opts)

Compare two commits

The `basehead` param is comprised of two parts: `base` and `head`. Both must be branch names in `repo`. To compare branches across other repositories in the same network as `repo`, use the format `<USERNAME>:branch`.  The response from the API is equivalent to running the `git log base..head` command; however, commits are returned in chronological order. Pass the appropriate [media type](https://docs.github.com/rest/overview/media-types/#commits-commit-comparison-and-pull-requests) to fetch diff and patch formats.  The response also includes details on the files that were changed between the two commits. This includes the status of the change (for example, if a file was added, removed, modified, or renamed), and details of the change itself. For example, files with a `renamed` status have a `previous_filename` field showing the previous filename of the file, and files with a `modified` status have a `patch` field showing the changes made to the file.  **Working with large comparisons**  To process a response with a large number of commits, you can use (`per_page` or `page`) to paginate the results. When using paging, the list of changed files is only returned with page 1, but includes all changed files for the entire comparison. For more information on working with pagination, see \"[Traversing with pagination](/rest/guides/traversing-with-pagination).\"  When calling this API without any paging parameters (`per_page` or `page`), the returned list is limited to 250 commits and the last commit in the list is the most recent of the entire comparison. When a paging parameter is specified, the first commit in the returned list of each page is the earliest.  **Signature verification object**  The response will include a `verification` object that describes the result of verifying the commit's signature. The following fields are included in the `verification` object:  | Name | Type | Description | | ---- | ---- | ----------- | | `verified` | `boolean` | Indicates whether GitHub considers the signature in this commit to be verified. | | `reason` | `string` | The reason for verified value. Possible values and their meanings are enumerated in table below. | | `signature` | `string` | The signature that was extracted from the commit. | | `payload` | `string` | The value that was signed. |  These are the possible values for `reason` in the `verification` object:  | Value | Description | | ----- | ----------- | | `expired_key` | The key that made the signature is expired. | | `not_signing_key` | The \"signing\" flag is not among the usage flags in the GPG key that made the signature. | | `gpgverify_error` | There was an error communicating with the signature verification service. | | `gpgverify_unavailable` | The signature verification service is currently unavailable. | | `unsigned` | The object does not include a signature. | | `unknown_signature_type` | A non-PGP signature was found in the commit. | | `no_user` | No user was associated with the `committer` email address in the commit. | | `unverified_email` | The `committer` email address in the commit was associated with a user, but the email address is not verified on her/his account. | | `bad_email` | The `committer` email address in the commit is not included in the identities of the PGP key that made the signature. | | `unknown_key` | The key that made the signature has not been registered with any user's account. | | `malformed_signature` | There was an error parsing the signature. | | `invalid` | The signature could not be cryptographically verified using the key whose key-id was found in the signature. | | `valid` | None of the above errors applied, so the signature is considered to be verified. |

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
basehead = 'basehead_example' # String | The base branch and head branch to compare. This parameter expects the format `{base}...{head}`.
opts = {
  page: 56, # Integer | Page number of the results to fetch.
  per_page: 56 # Integer | The number of results per page (max 100).
}

begin
  # Compare two commits
  result = api_instance.repos_compare_commits(owner, repo, basehead, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_compare_commits: #{e}"
end
```

#### Using the repos_compare_commits_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CommitComparison>, Integer, Hash)> repos_compare_commits_with_http_info(owner, repo, basehead, opts)

```ruby
begin
  # Compare two commits
  data, status_code, headers = api_instance.repos_compare_commits_with_http_info(owner, repo, basehead, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CommitComparison>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_compare_commits_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **basehead** | **String** | The base branch and head branch to compare. This parameter expects the format &#x60;{base}...{head}&#x60;. |  |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |

### Return type

[**CommitComparison**](CommitComparison.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_create_autolink

> <AutolinkReference> repos_create_autolink(owner, repo, repos_create_autolink_request)

Create an autolink reference for a repository

Users with admin access to the repository can create an autolink.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
repos_create_autolink_request = OpenapiClient::ReposCreateAutolinkRequest.new({key_prefix: 'key_prefix_example', url_template: 'url_template_example'}) # ReposCreateAutolinkRequest | 

begin
  # Create an autolink reference for a repository
  result = api_instance.repos_create_autolink(owner, repo, repos_create_autolink_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_autolink: #{e}"
end
```

#### Using the repos_create_autolink_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<AutolinkReference>, Integer, Hash)> repos_create_autolink_with_http_info(owner, repo, repos_create_autolink_request)

```ruby
begin
  # Create an autolink reference for a repository
  data, status_code, headers = api_instance.repos_create_autolink_with_http_info(owner, repo, repos_create_autolink_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <AutolinkReference>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_autolink_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **repos_create_autolink_request** | [**ReposCreateAutolinkRequest**](ReposCreateAutolinkRequest.md) |  |  |

### Return type

[**AutolinkReference**](AutolinkReference.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_create_commit_comment

> <CommitComment> repos_create_commit_comment(owner, repo, commit_sha, repos_create_commit_comment_request)

Create a commit comment

Create a comment for a commit using its `:commit_sha`.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \"[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\" and \"[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\" for details.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
commit_sha = 'commit_sha_example' # String | The SHA of the commit.
repos_create_commit_comment_request = OpenapiClient::ReposCreateCommitCommentRequest.new({body: 'body_example'}) # ReposCreateCommitCommentRequest | 

begin
  # Create a commit comment
  result = api_instance.repos_create_commit_comment(owner, repo, commit_sha, repos_create_commit_comment_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_commit_comment: #{e}"
end
```

#### Using the repos_create_commit_comment_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CommitComment>, Integer, Hash)> repos_create_commit_comment_with_http_info(owner, repo, commit_sha, repos_create_commit_comment_request)

```ruby
begin
  # Create a commit comment
  data, status_code, headers = api_instance.repos_create_commit_comment_with_http_info(owner, repo, commit_sha, repos_create_commit_comment_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CommitComment>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_commit_comment_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **commit_sha** | **String** | The SHA of the commit. |  |
| **repos_create_commit_comment_request** | [**ReposCreateCommitCommentRequest**](ReposCreateCommitCommentRequest.md) |  |  |

### Return type

[**CommitComment**](CommitComment.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_create_commit_signature_protection

> <ProtectedBranchAdminEnforced> repos_create_commit_signature_protection(owner, repo, branch)

Create commit signature protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  When authenticated with admin or owner permissions to the repository, you can use this endpoint to require signed commits on a branch. You must enable branch protection to require signed commits.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.

begin
  # Create commit signature protection
  result = api_instance.repos_create_commit_signature_protection(owner, repo, branch)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_commit_signature_protection: #{e}"
end
```

#### Using the repos_create_commit_signature_protection_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ProtectedBranchAdminEnforced>, Integer, Hash)> repos_create_commit_signature_protection_with_http_info(owner, repo, branch)

```ruby
begin
  # Create commit signature protection
  data, status_code, headers = api_instance.repos_create_commit_signature_protection_with_http_info(owner, repo, branch)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ProtectedBranchAdminEnforced>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_commit_signature_protection_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |

### Return type

[**ProtectedBranchAdminEnforced**](ProtectedBranchAdminEnforced.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_create_commit_status

> <Status> repos_create_commit_status(owner, repo, sha, repos_create_commit_status_request)

Create a commit status

Users with push access in a repository can create commit statuses for a given SHA.  Note: there is a limit of 1000 statuses per `sha` and `context` within a repository. Attempts to create more than 1000 statuses will result in a validation error.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
sha = 'sha_example' # String | 
repos_create_commit_status_request = OpenapiClient::ReposCreateCommitStatusRequest.new({state: 'error'}) # ReposCreateCommitStatusRequest | 

begin
  # Create a commit status
  result = api_instance.repos_create_commit_status(owner, repo, sha, repos_create_commit_status_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_commit_status: #{e}"
end
```

#### Using the repos_create_commit_status_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Status>, Integer, Hash)> repos_create_commit_status_with_http_info(owner, repo, sha, repos_create_commit_status_request)

```ruby
begin
  # Create a commit status
  data, status_code, headers = api_instance.repos_create_commit_status_with_http_info(owner, repo, sha, repos_create_commit_status_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Status>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_commit_status_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **sha** | **String** |  |  |
| **repos_create_commit_status_request** | [**ReposCreateCommitStatusRequest**](ReposCreateCommitStatusRequest.md) |  |  |

### Return type

[**Status**](Status.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_create_deploy_key

> <DeployKey> repos_create_deploy_key(owner, repo, repos_create_deploy_key_request)

Create a deploy key

You can create a read-only deploy key.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
repos_create_deploy_key_request = OpenapiClient::ReposCreateDeployKeyRequest.new({key: 'key_example'}) # ReposCreateDeployKeyRequest | 

begin
  # Create a deploy key
  result = api_instance.repos_create_deploy_key(owner, repo, repos_create_deploy_key_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_deploy_key: #{e}"
end
```

#### Using the repos_create_deploy_key_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<DeployKey>, Integer, Hash)> repos_create_deploy_key_with_http_info(owner, repo, repos_create_deploy_key_request)

```ruby
begin
  # Create a deploy key
  data, status_code, headers = api_instance.repos_create_deploy_key_with_http_info(owner, repo, repos_create_deploy_key_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <DeployKey>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_deploy_key_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **repos_create_deploy_key_request** | [**ReposCreateDeployKeyRequest**](ReposCreateDeployKeyRequest.md) |  |  |

### Return type

[**DeployKey**](DeployKey.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_create_deployment

> <Deployment> repos_create_deployment(owner, repo, repos_create_deployment_request)

Create a deployment

Deployments offer a few configurable parameters with certain defaults.  The `ref` parameter can be any named branch, tag, or SHA. At GitHub we often deploy branches and verify them before we merge a pull request.  The `environment` parameter allows deployments to be issued to different runtime environments. Teams often have multiple environments for verifying their applications, such as `production`, `staging`, and `qa`. This parameter makes it easier to track which environments have requested deployments. The default environment is `production`.  The `auto_merge` parameter is used to ensure that the requested ref is not behind the repository's default branch. If the ref _is_ behind the default branch for the repository, we will attempt to merge it for you. If the merge succeeds, the API will return a successful merge commit. If merge conflicts prevent the merge from succeeding, the API will return a failure response.  By default, [commit statuses](https://docs.github.com/rest/commits/statuses) for every submitted context must be in a `success` state. The `required_contexts` parameter allows you to specify a subset of contexts that must be `success`, or to specify contexts that have not yet been submitted. You are not required to use commit statuses to deploy. If you do not require any contexts or create any commit statuses, the deployment will always succeed.  The `payload` parameter is available for any extra information that a deployment system might need. It is a JSON text field that will be passed on when a deployment event is dispatched.  The `task` parameter is used by the deployment system to allow different execution paths. In the web world this might be `deploy:migrations` to run schema changes on the system. In the compiled world this could be a flag to compile an application with debugging enabled.  Users with `repo` or `repo_deployment` scopes can create a deployment for a given ref.  #### Merged branch response You will see this response when GitHub automatically merges the base branch into the topic branch instead of creating a deployment. This auto-merge happens when: *   Auto-merge option is enabled in the repository *   Topic branch does not include the latest changes on the base branch, which is `master` in the response example *   There are no merge conflicts  If there are no new commits in the base branch, a new request to create a deployment should give a successful response.  #### Merge conflict response This error happens when the `auto_merge` option is enabled and when the default branch (in this case `master`), can't be merged into the branch that's being deployed (in this case `topic-branch`), due to merge conflicts.  #### Failed commit status checks This error happens when the `required_contexts` parameter indicates that one or more contexts need to have a `success` status for the commit to be deployed, but one or more of the required contexts do not have a state of `success`.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
repos_create_deployment_request = OpenapiClient::ReposCreateDeploymentRequest.new({ref: 'ref_example'}) # ReposCreateDeploymentRequest | 

begin
  # Create a deployment
  result = api_instance.repos_create_deployment(owner, repo, repos_create_deployment_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_deployment: #{e}"
end
```

#### Using the repos_create_deployment_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Deployment>, Integer, Hash)> repos_create_deployment_with_http_info(owner, repo, repos_create_deployment_request)

```ruby
begin
  # Create a deployment
  data, status_code, headers = api_instance.repos_create_deployment_with_http_info(owner, repo, repos_create_deployment_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Deployment>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_deployment_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **repos_create_deployment_request** | [**ReposCreateDeploymentRequest**](ReposCreateDeploymentRequest.md) |  |  |

### Return type

[**Deployment**](Deployment.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_create_deployment_status

> <DeploymentStatus> repos_create_deployment_status(owner, repo, deployment_id, repos_create_deployment_status_request)

Create a deployment status

Users with `push` access can create deployment statuses for a given deployment.  GitHub Apps require `read & write` access to \"Deployments\" and `read-only` access to \"Repo contents\" (for private repos). OAuth Apps require the `repo_deployment` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
deployment_id = 56 # Integer | deployment_id parameter
repos_create_deployment_status_request = OpenapiClient::ReposCreateDeploymentStatusRequest.new({state: 'error'}) # ReposCreateDeploymentStatusRequest | 

begin
  # Create a deployment status
  result = api_instance.repos_create_deployment_status(owner, repo, deployment_id, repos_create_deployment_status_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_deployment_status: #{e}"
end
```

#### Using the repos_create_deployment_status_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<DeploymentStatus>, Integer, Hash)> repos_create_deployment_status_with_http_info(owner, repo, deployment_id, repos_create_deployment_status_request)

```ruby
begin
  # Create a deployment status
  data, status_code, headers = api_instance.repos_create_deployment_status_with_http_info(owner, repo, deployment_id, repos_create_deployment_status_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <DeploymentStatus>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_deployment_status_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **deployment_id** | **Integer** | deployment_id parameter |  |
| **repos_create_deployment_status_request** | [**ReposCreateDeploymentStatusRequest**](ReposCreateDeploymentStatusRequest.md) |  |  |

### Return type

[**DeploymentStatus**](DeploymentStatus.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_create_dispatch_event

> repos_create_dispatch_event(owner, repo, repos_create_dispatch_event_request)

Create a repository dispatch event

You can use this endpoint to trigger a webhook event called `repository_dispatch` when you want activity that happens outside of GitHub to trigger a GitHub Actions workflow or GitHub App webhook. You must configure your GitHub Actions workflow or GitHub App to run when the `repository_dispatch` event occurs. For an example `repository_dispatch` webhook payload, see \"[RepositoryDispatchEvent](https://docs.github.com/webhooks/event-payloads/#repository_dispatch).\"  The `client_payload` parameter is available for any extra information that your workflow might need. This parameter is a JSON payload that will be passed on when the webhook event is dispatched. For example, the `client_payload` can include a message that a user would like to send using a GitHub Actions workflow. Or the `client_payload` can be used as a test to debug your workflow.  This endpoint requires write access to the repository by providing either:    - Personal access tokens with `repo` scope. For more information, see \"[Creating a personal access token for the command line](https://docs.github.com/articles/creating-a-personal-access-token-for-the-command-line)\" in the GitHub Help documentation.   - GitHub Apps with both `metadata:read` and `contents:read&write` permissions.  This input example shows how you can use the `client_payload` as a test to debug your workflow.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
repos_create_dispatch_event_request = OpenapiClient::ReposCreateDispatchEventRequest.new({event_type: 'event_type_example'}) # ReposCreateDispatchEventRequest | 

begin
  # Create a repository dispatch event
  api_instance.repos_create_dispatch_event(owner, repo, repos_create_dispatch_event_request)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_dispatch_event: #{e}"
end
```

#### Using the repos_create_dispatch_event_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_create_dispatch_event_with_http_info(owner, repo, repos_create_dispatch_event_request)

```ruby
begin
  # Create a repository dispatch event
  data, status_code, headers = api_instance.repos_create_dispatch_event_with_http_info(owner, repo, repos_create_dispatch_event_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_dispatch_event_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **repos_create_dispatch_event_request** | [**ReposCreateDispatchEventRequest**](ReposCreateDispatchEventRequest.md) |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_create_for_authenticated_user

> <Repository> repos_create_for_authenticated_user(repos_create_for_authenticated_user_request)

Create a repository for the authenticated user

Creates a new repository for the authenticated user.  **OAuth scope requirements**  When using [OAuth](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/), authorizations must include:  *   `public_repo` scope or `repo` scope to create a public repository. Note: For GitHub AE, use `repo` scope to create an internal repository. *   `repo` scope to create a private repository.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
repos_create_for_authenticated_user_request = OpenapiClient::ReposCreateForAuthenticatedUserRequest.new({name: 'Team Environment'}) # ReposCreateForAuthenticatedUserRequest | 

begin
  # Create a repository for the authenticated user
  result = api_instance.repos_create_for_authenticated_user(repos_create_for_authenticated_user_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_for_authenticated_user: #{e}"
end
```

#### Using the repos_create_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Repository>, Integer, Hash)> repos_create_for_authenticated_user_with_http_info(repos_create_for_authenticated_user_request)

```ruby
begin
  # Create a repository for the authenticated user
  data, status_code, headers = api_instance.repos_create_for_authenticated_user_with_http_info(repos_create_for_authenticated_user_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Repository>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **repos_create_for_authenticated_user_request** | [**ReposCreateForAuthenticatedUserRequest**](ReposCreateForAuthenticatedUserRequest.md) |  |  |

### Return type

[**Repository**](Repository.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/scim+json


## repos_create_fork

> <FullRepository> repos_create_fork(owner, repo, opts)

Create a fork

Create a fork for the authenticated user.  **Note**: Forking a Repository happens asynchronously. You may have to wait a short period of time before you can access the git objects. If this takes longer than 5 minutes, be sure to contact [GitHub Support](https://support.github.com/contact?tags=dotcom-rest-api).

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  repos_create_fork_request: OpenapiClient::ReposCreateForkRequest.new # ReposCreateForkRequest | 
}

begin
  # Create a fork
  result = api_instance.repos_create_fork(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_fork: #{e}"
end
```

#### Using the repos_create_fork_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<FullRepository>, Integer, Hash)> repos_create_fork_with_http_info(owner, repo, opts)

```ruby
begin
  # Create a fork
  data, status_code, headers = api_instance.repos_create_fork_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <FullRepository>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_fork_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **repos_create_fork_request** | [**ReposCreateForkRequest**](ReposCreateForkRequest.md) |  | [optional] |

### Return type

[**FullRepository**](FullRepository.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/scim+json


## repos_create_in_org

> <Repository> repos_create_in_org(org, repos_create_in_org_request)

Create an organization repository

Creates a new repository in the specified organization. The authenticated user must be a member of the organization.  **OAuth scope requirements**  When using [OAuth](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/), authorizations must include:  *   `public_repo` scope or `repo` scope to create a public repository. Note: For GitHub AE, use `repo` scope to create an internal repository. *   `repo` scope to create a private repository

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
repos_create_in_org_request = OpenapiClient::ReposCreateInOrgRequest.new({name: 'name_example'}) # ReposCreateInOrgRequest | 

begin
  # Create an organization repository
  result = api_instance.repos_create_in_org(org, repos_create_in_org_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_in_org: #{e}"
end
```

#### Using the repos_create_in_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Repository>, Integer, Hash)> repos_create_in_org_with_http_info(org, repos_create_in_org_request)

```ruby
begin
  # Create an organization repository
  data, status_code, headers = api_instance.repos_create_in_org_with_http_info(org, repos_create_in_org_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Repository>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_in_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **repos_create_in_org_request** | [**ReposCreateInOrgRequest**](ReposCreateInOrgRequest.md) |  |  |

### Return type

[**Repository**](Repository.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_create_or_update_environment

> <Environment> repos_create_or_update_environment(owner, repo, environment_name, opts)

Create or update an environment

Create or update an environment with protection rules, such as required reviewers. For more information about environment protection rules, see \"[Environments](/actions/reference/environments#environment-protection-rules).\"  **Note:** Although you can use this operation to specify that only branches that match specified name patterns can deploy to this environment, you must use the UI to set the name patterns. For more information, see \"[Environments](/actions/reference/environments#deployment-branches).\"  **Note:** To create or update secrets for an environment, see \"[Secrets](/rest/reference/actions#secrets).\"  You must authenticate using an access token with the repo scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
environment_name = 'environment_name_example' # String | The name of the environment
opts = {
  repos_create_or_update_environment_request: OpenapiClient::ReposCreateOrUpdateEnvironmentRequest.new # ReposCreateOrUpdateEnvironmentRequest | 
}

begin
  # Create or update an environment
  result = api_instance.repos_create_or_update_environment(owner, repo, environment_name, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_or_update_environment: #{e}"
end
```

#### Using the repos_create_or_update_environment_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Environment>, Integer, Hash)> repos_create_or_update_environment_with_http_info(owner, repo, environment_name, opts)

```ruby
begin
  # Create or update an environment
  data, status_code, headers = api_instance.repos_create_or_update_environment_with_http_info(owner, repo, environment_name, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Environment>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_or_update_environment_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **environment_name** | **String** | The name of the environment |  |
| **repos_create_or_update_environment_request** | [**ReposCreateOrUpdateEnvironmentRequest**](ReposCreateOrUpdateEnvironmentRequest.md) |  | [optional] |

### Return type

[**Environment**](Environment.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_create_or_update_file_contents

> <FileCommit> repos_create_or_update_file_contents(owner, repo, path, repos_create_or_update_file_contents_request)

Create or update file contents

Creates a new file or replaces an existing file in a repository.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
path = 'path_example' # String | path parameter
repos_create_or_update_file_contents_request = OpenapiClient::ReposCreateOrUpdateFileContentsRequest.new({message: 'message_example', content: 'content_example'}) # ReposCreateOrUpdateFileContentsRequest | 

begin
  # Create or update file contents
  result = api_instance.repos_create_or_update_file_contents(owner, repo, path, repos_create_or_update_file_contents_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_or_update_file_contents: #{e}"
end
```

#### Using the repos_create_or_update_file_contents_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<FileCommit>, Integer, Hash)> repos_create_or_update_file_contents_with_http_info(owner, repo, path, repos_create_or_update_file_contents_request)

```ruby
begin
  # Create or update file contents
  data, status_code, headers = api_instance.repos_create_or_update_file_contents_with_http_info(owner, repo, path, repos_create_or_update_file_contents_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <FileCommit>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_or_update_file_contents_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **path** | **String** | path parameter |  |
| **repos_create_or_update_file_contents_request** | [**ReposCreateOrUpdateFileContentsRequest**](ReposCreateOrUpdateFileContentsRequest.md) |  |  |

### Return type

[**FileCommit**](FileCommit.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_create_pages_deployment

> <GitHubPages1> repos_create_pages_deployment(owner, repo, repos_create_pages_deployment_request)

Create a GitHub Pages deployment

Create a GitHub Pages deployment for a repository.  Users must have write permissions. GitHub Apps must have the `pages:write` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
repos_create_pages_deployment_request = OpenapiClient::ReposCreatePagesDeploymentRequest.new({artifact_url: 'artifact_url_example', pages_build_version: 'pages_build_version_example', oidc_token: 'oidc_token_example'}) # ReposCreatePagesDeploymentRequest | 

begin
  # Create a GitHub Pages deployment
  result = api_instance.repos_create_pages_deployment(owner, repo, repos_create_pages_deployment_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_pages_deployment: #{e}"
end
```

#### Using the repos_create_pages_deployment_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<GitHubPages1>, Integer, Hash)> repos_create_pages_deployment_with_http_info(owner, repo, repos_create_pages_deployment_request)

```ruby
begin
  # Create a GitHub Pages deployment
  data, status_code, headers = api_instance.repos_create_pages_deployment_with_http_info(owner, repo, repos_create_pages_deployment_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <GitHubPages1>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_pages_deployment_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **repos_create_pages_deployment_request** | [**ReposCreatePagesDeploymentRequest**](ReposCreatePagesDeploymentRequest.md) |  |  |

### Return type

[**GitHubPages1**](GitHubPages1.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/scim+json


## repos_create_pages_site

> <GitHubPages> repos_create_pages_site(owner, repo, repos_create_pages_site_request)

Create a GitHub Pages site

Configures a GitHub Pages site. For more information, see \"[About GitHub Pages](/github/working-with-github-pages/about-github-pages).\"

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
repos_create_pages_site_request = OpenapiClient::ReposCreatePagesSiteRequest.new # ReposCreatePagesSiteRequest | 

begin
  # Create a GitHub Pages site
  result = api_instance.repos_create_pages_site(owner, repo, repos_create_pages_site_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_pages_site: #{e}"
end
```

#### Using the repos_create_pages_site_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<GitHubPages>, Integer, Hash)> repos_create_pages_site_with_http_info(owner, repo, repos_create_pages_site_request)

```ruby
begin
  # Create a GitHub Pages site
  data, status_code, headers = api_instance.repos_create_pages_site_with_http_info(owner, repo, repos_create_pages_site_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <GitHubPages>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_pages_site_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **repos_create_pages_site_request** | [**ReposCreatePagesSiteRequest**](ReposCreatePagesSiteRequest.md) |  |  |

### Return type

[**GitHubPages**](GitHubPages.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_create_release

> <Release> repos_create_release(owner, repo, repos_create_release_request)

Create a release

Users with push access to the repository can create a release.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \"[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\" and \"[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\" for details.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
repos_create_release_request = OpenapiClient::ReposCreateReleaseRequest.new({tag_name: 'tag_name_example'}) # ReposCreateReleaseRequest | 

begin
  # Create a release
  result = api_instance.repos_create_release(owner, repo, repos_create_release_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_release: #{e}"
end
```

#### Using the repos_create_release_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Release>, Integer, Hash)> repos_create_release_with_http_info(owner, repo, repos_create_release_request)

```ruby
begin
  # Create a release
  data, status_code, headers = api_instance.repos_create_release_with_http_info(owner, repo, repos_create_release_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Release>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_release_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **repos_create_release_request** | [**ReposCreateReleaseRequest**](ReposCreateReleaseRequest.md) |  |  |

### Return type

[**Release**](Release.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_create_tag_protection

> <TagProtection> repos_create_tag_protection(owner, repo, repos_create_tag_protection_request)

Create a tag protection state for a repository

This creates a tag protection state for a repository. This endpoint is only available to repository administrators.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
repos_create_tag_protection_request = OpenapiClient::ReposCreateTagProtectionRequest.new({pattern: 'pattern_example'}) # ReposCreateTagProtectionRequest | 

begin
  # Create a tag protection state for a repository
  result = api_instance.repos_create_tag_protection(owner, repo, repos_create_tag_protection_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_tag_protection: #{e}"
end
```

#### Using the repos_create_tag_protection_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<TagProtection>, Integer, Hash)> repos_create_tag_protection_with_http_info(owner, repo, repos_create_tag_protection_request)

```ruby
begin
  # Create a tag protection state for a repository
  data, status_code, headers = api_instance.repos_create_tag_protection_with_http_info(owner, repo, repos_create_tag_protection_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <TagProtection>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_tag_protection_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **repos_create_tag_protection_request** | [**ReposCreateTagProtectionRequest**](ReposCreateTagProtectionRequest.md) |  |  |

### Return type

[**TagProtection**](TagProtection.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_create_using_template

> <Repository> repos_create_using_template(template_owner, template_repo, repos_create_using_template_request)

Create a repository using a template

Creates a new repository using a repository template. Use the `template_owner` and `template_repo` route parameters to specify the repository to use as the template. The authenticated user must own or be a member of an organization that owns the repository. To check if a repository is available to use as a template, get the repository's information using the [Get a repository](https://docs.github.com/rest/reference/repos#get-a-repository) endpoint and check that the `is_template` key is `true`.  **OAuth scope requirements**  When using [OAuth](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/), authorizations must include:  *   `public_repo` scope or `repo` scope to create a public repository. Note: For GitHub AE, use `repo` scope to create an internal repository. *   `repo` scope to create a private repository

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
template_owner = 'template_owner_example' # String | 
template_repo = 'template_repo_example' # String | 
repos_create_using_template_request = OpenapiClient::ReposCreateUsingTemplateRequest.new({name: 'name_example'}) # ReposCreateUsingTemplateRequest | 

begin
  # Create a repository using a template
  result = api_instance.repos_create_using_template(template_owner, template_repo, repos_create_using_template_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_using_template: #{e}"
end
```

#### Using the repos_create_using_template_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Repository>, Integer, Hash)> repos_create_using_template_with_http_info(template_owner, template_repo, repos_create_using_template_request)

```ruby
begin
  # Create a repository using a template
  data, status_code, headers = api_instance.repos_create_using_template_with_http_info(template_owner, template_repo, repos_create_using_template_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Repository>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_using_template_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **template_owner** | **String** |  |  |
| **template_repo** | **String** |  |  |
| **repos_create_using_template_request** | [**ReposCreateUsingTemplateRequest**](ReposCreateUsingTemplateRequest.md) |  |  |

### Return type

[**Repository**](Repository.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_create_webhook

> <Webhook> repos_create_webhook(owner, repo, opts)

Create a repository webhook

Repositories can have multiple webhooks installed. Each webhook should have a unique `config`. Multiple webhooks can share the same `config` as long as those webhooks do not have any `events` that overlap.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  repos_create_webhook_request: OpenapiClient::ReposCreateWebhookRequest.new # ReposCreateWebhookRequest | 
}

begin
  # Create a repository webhook
  result = api_instance.repos_create_webhook(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_webhook: #{e}"
end
```

#### Using the repos_create_webhook_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Webhook>, Integer, Hash)> repos_create_webhook_with_http_info(owner, repo, opts)

```ruby
begin
  # Create a repository webhook
  data, status_code, headers = api_instance.repos_create_webhook_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Webhook>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_create_webhook_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **repos_create_webhook_request** | [**ReposCreateWebhookRequest**](ReposCreateWebhookRequest.md) |  | [optional] |

### Return type

[**Webhook**](Webhook.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_decline_invitation_for_authenticated_user

> repos_decline_invitation_for_authenticated_user(invitation_id)

Decline a repository invitation



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
invitation_id = 56 # Integer | The unique identifier of the invitation.

begin
  # Decline a repository invitation
  api_instance.repos_decline_invitation_for_authenticated_user(invitation_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_decline_invitation_for_authenticated_user: #{e}"
end
```

#### Using the repos_decline_invitation_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_decline_invitation_for_authenticated_user_with_http_info(invitation_id)

```ruby
begin
  # Decline a repository invitation
  data, status_code, headers = api_instance.repos_decline_invitation_for_authenticated_user_with_http_info(invitation_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_decline_invitation_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **invitation_id** | **Integer** | The unique identifier of the invitation. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_delete

> repos_delete(owner, repo)

Delete a repository

Deleting a repository requires admin access. If OAuth is used, the `delete_repo` scope is required.  If an organization owner has configured the organization to prevent members from deleting organization-owned repositories, you will get a `403 Forbidden` response.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Delete a repository
  api_instance.repos_delete(owner, repo)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete: #{e}"
end
```

#### Using the repos_delete_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_delete_with_http_info(owner, repo)

```ruby
begin
  # Delete a repository
  data, status_code, headers = api_instance.repos_delete_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_delete_access_restrictions

> repos_delete_access_restrictions(owner, repo, branch)

Delete access restrictions

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Disables the ability to restrict who can push to this branch.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.

begin
  # Delete access restrictions
  api_instance.repos_delete_access_restrictions(owner, repo, branch)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_access_restrictions: #{e}"
end
```

#### Using the repos_delete_access_restrictions_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_delete_access_restrictions_with_http_info(owner, repo, branch)

```ruby
begin
  # Delete access restrictions
  data, status_code, headers = api_instance.repos_delete_access_restrictions_with_http_info(owner, repo, branch)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_access_restrictions_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## repos_delete_admin_branch_protection

> repos_delete_admin_branch_protection(owner, repo, branch)

Delete admin branch protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Removing admin enforcement requires admin or owner permissions to the repository and branch protection to be enabled.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.

begin
  # Delete admin branch protection
  api_instance.repos_delete_admin_branch_protection(owner, repo, branch)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_admin_branch_protection: #{e}"
end
```

#### Using the repos_delete_admin_branch_protection_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_delete_admin_branch_protection_with_http_info(owner, repo, branch)

```ruby
begin
  # Delete admin branch protection
  data, status_code, headers = api_instance.repos_delete_admin_branch_protection_with_http_info(owner, repo, branch)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_admin_branch_protection_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_delete_an_environment

> repos_delete_an_environment(owner, repo, environment_name)

Delete an environment

You must authenticate using an access token with the repo scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
environment_name = 'environment_name_example' # String | The name of the environment

begin
  # Delete an environment
  api_instance.repos_delete_an_environment(owner, repo, environment_name)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_an_environment: #{e}"
end
```

#### Using the repos_delete_an_environment_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_delete_an_environment_with_http_info(owner, repo, environment_name)

```ruby
begin
  # Delete an environment
  data, status_code, headers = api_instance.repos_delete_an_environment_with_http_info(owner, repo, environment_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_an_environment_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **environment_name** | **String** | The name of the environment |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## repos_delete_autolink

> repos_delete_autolink(owner, repo, autolink_id)

Delete an autolink reference from a repository

This deletes a single autolink reference by ID that was configured for the given repository.  Information about autolinks are only available to repository administrators.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
autolink_id = 56 # Integer | The unique identifier of the autolink.

begin
  # Delete an autolink reference from a repository
  api_instance.repos_delete_autolink(owner, repo, autolink_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_autolink: #{e}"
end
```

#### Using the repos_delete_autolink_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_delete_autolink_with_http_info(owner, repo, autolink_id)

```ruby
begin
  # Delete an autolink reference from a repository
  data, status_code, headers = api_instance.repos_delete_autolink_with_http_info(owner, repo, autolink_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_autolink_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **autolink_id** | **Integer** | The unique identifier of the autolink. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_delete_branch_protection

> repos_delete_branch_protection(owner, repo, branch)

Delete branch protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.

begin
  # Delete branch protection
  api_instance.repos_delete_branch_protection(owner, repo, branch)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_branch_protection: #{e}"
end
```

#### Using the repos_delete_branch_protection_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_delete_branch_protection_with_http_info(owner, repo, branch)

```ruby
begin
  # Delete branch protection
  data, status_code, headers = api_instance.repos_delete_branch_protection_with_http_info(owner, repo, branch)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_branch_protection_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_delete_commit_comment

> repos_delete_commit_comment(owner, repo, comment_id)

Delete a commit comment



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
comment_id = 56 # Integer | The unique identifier of the comment.

begin
  # Delete a commit comment
  api_instance.repos_delete_commit_comment(owner, repo, comment_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_commit_comment: #{e}"
end
```

#### Using the repos_delete_commit_comment_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_delete_commit_comment_with_http_info(owner, repo, comment_id)

```ruby
begin
  # Delete a commit comment
  data, status_code, headers = api_instance.repos_delete_commit_comment_with_http_info(owner, repo, comment_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_commit_comment_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **comment_id** | **Integer** | The unique identifier of the comment. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_delete_commit_signature_protection

> repos_delete_commit_signature_protection(owner, repo, branch)

Delete commit signature protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  When authenticated with admin or owner permissions to the repository, you can use this endpoint to disable required signed commits on a branch. You must enable branch protection to require signed commits.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.

begin
  # Delete commit signature protection
  api_instance.repos_delete_commit_signature_protection(owner, repo, branch)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_commit_signature_protection: #{e}"
end
```

#### Using the repos_delete_commit_signature_protection_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_delete_commit_signature_protection_with_http_info(owner, repo, branch)

```ruby
begin
  # Delete commit signature protection
  data, status_code, headers = api_instance.repos_delete_commit_signature_protection_with_http_info(owner, repo, branch)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_commit_signature_protection_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_delete_deploy_key

> repos_delete_deploy_key(owner, repo, key_id)

Delete a deploy key

Deploy keys are immutable. If you need to update a key, remove the key and create a new one instead.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
key_id = 56 # Integer | The unique identifier of the key.

begin
  # Delete a deploy key
  api_instance.repos_delete_deploy_key(owner, repo, key_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_deploy_key: #{e}"
end
```

#### Using the repos_delete_deploy_key_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_delete_deploy_key_with_http_info(owner, repo, key_id)

```ruby
begin
  # Delete a deploy key
  data, status_code, headers = api_instance.repos_delete_deploy_key_with_http_info(owner, repo, key_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_deploy_key_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **key_id** | **Integer** | The unique identifier of the key. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## repos_delete_deployment

> repos_delete_deployment(owner, repo, deployment_id)

Delete a deployment

If the repository only has one deployment, you can delete the deployment regardless of its status. If the repository has more than one deployment, you can only delete inactive deployments. This ensures that repositories with multiple deployments will always have an active deployment. Anyone with `repo` or `repo_deployment` scopes can delete a deployment.  To set a deployment as inactive, you must:  *   Create a new deployment that is active so that the system has a record of the current state, then delete the previously active deployment. *   Mark the active deployment as inactive by adding any non-successful deployment status.  For more information, see \"[Create a deployment](https://docs.github.com/rest/reference/repos/#create-a-deployment)\" and \"[Create a deployment status](https://docs.github.com/rest/reference/repos#create-a-deployment-status).\"

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
deployment_id = 56 # Integer | deployment_id parameter

begin
  # Delete a deployment
  api_instance.repos_delete_deployment(owner, repo, deployment_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_deployment: #{e}"
end
```

#### Using the repos_delete_deployment_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_delete_deployment_with_http_info(owner, repo, deployment_id)

```ruby
begin
  # Delete a deployment
  data, status_code, headers = api_instance.repos_delete_deployment_with_http_info(owner, repo, deployment_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_deployment_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **deployment_id** | **Integer** | deployment_id parameter |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_delete_file

> <FileCommit> repos_delete_file(owner, repo, path, repos_delete_file_request)

Delete a file

Deletes a file in a repository.  You can provide an additional `committer` parameter, which is an object containing information about the committer. Or, you can provide an `author` parameter, which is an object containing information about the author.  The `author` section is optional and is filled in with the `committer` information if omitted. If the `committer` information is omitted, the authenticated user's information is used.  You must provide values for both `name` and `email`, whether you choose to use `author` or `committer`. Otherwise, you'll receive a `422` status code.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
path = 'path_example' # String | path parameter
repos_delete_file_request = OpenapiClient::ReposDeleteFileRequest.new({message: 'message_example', sha: 'sha_example'}) # ReposDeleteFileRequest | 

begin
  # Delete a file
  result = api_instance.repos_delete_file(owner, repo, path, repos_delete_file_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_file: #{e}"
end
```

#### Using the repos_delete_file_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<FileCommit>, Integer, Hash)> repos_delete_file_with_http_info(owner, repo, path, repos_delete_file_request)

```ruby
begin
  # Delete a file
  data, status_code, headers = api_instance.repos_delete_file_with_http_info(owner, repo, path, repos_delete_file_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <FileCommit>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_file_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **path** | **String** | path parameter |  |
| **repos_delete_file_request** | [**ReposDeleteFileRequest**](ReposDeleteFileRequest.md) |  |  |

### Return type

[**FileCommit**](FileCommit.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_delete_invitation

> repos_delete_invitation(owner, repo, invitation_id)

Delete a repository invitation



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
invitation_id = 56 # Integer | The unique identifier of the invitation.

begin
  # Delete a repository invitation
  api_instance.repos_delete_invitation(owner, repo, invitation_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_invitation: #{e}"
end
```

#### Using the repos_delete_invitation_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_delete_invitation_with_http_info(owner, repo, invitation_id)

```ruby
begin
  # Delete a repository invitation
  data, status_code, headers = api_instance.repos_delete_invitation_with_http_info(owner, repo, invitation_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_invitation_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **invitation_id** | **Integer** | The unique identifier of the invitation. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## repos_delete_pages_site

> repos_delete_pages_site(owner, repo)

Delete a GitHub Pages site



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Delete a GitHub Pages site
  api_instance.repos_delete_pages_site(owner, repo)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_pages_site: #{e}"
end
```

#### Using the repos_delete_pages_site_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_delete_pages_site_with_http_info(owner, repo)

```ruby
begin
  # Delete a GitHub Pages site
  data, status_code, headers = api_instance.repos_delete_pages_site_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_pages_site_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_delete_pull_request_review_protection

> repos_delete_pull_request_review_protection(owner, repo, branch)

Delete pull request review protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.

begin
  # Delete pull request review protection
  api_instance.repos_delete_pull_request_review_protection(owner, repo, branch)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_pull_request_review_protection: #{e}"
end
```

#### Using the repos_delete_pull_request_review_protection_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_delete_pull_request_review_protection_with_http_info(owner, repo, branch)

```ruby
begin
  # Delete pull request review protection
  data, status_code, headers = api_instance.repos_delete_pull_request_review_protection_with_http_info(owner, repo, branch)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_pull_request_review_protection_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_delete_release

> repos_delete_release(owner, repo, release_id)

Delete a release

Users with push access to the repository can delete a release.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
release_id = 56 # Integer | The unique identifier of the release.

begin
  # Delete a release
  api_instance.repos_delete_release(owner, repo, release_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_release: #{e}"
end
```

#### Using the repos_delete_release_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_delete_release_with_http_info(owner, repo, release_id)

```ruby
begin
  # Delete a release
  data, status_code, headers = api_instance.repos_delete_release_with_http_info(owner, repo, release_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_release_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **release_id** | **Integer** | The unique identifier of the release. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## repos_delete_release_asset

> repos_delete_release_asset(owner, repo, asset_id)

Delete a release asset



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
asset_id = 56 # Integer | The unique identifier of the asset.

begin
  # Delete a release asset
  api_instance.repos_delete_release_asset(owner, repo, asset_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_release_asset: #{e}"
end
```

#### Using the repos_delete_release_asset_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_delete_release_asset_with_http_info(owner, repo, asset_id)

```ruby
begin
  # Delete a release asset
  data, status_code, headers = api_instance.repos_delete_release_asset_with_http_info(owner, repo, asset_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_release_asset_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **asset_id** | **Integer** | The unique identifier of the asset. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## repos_delete_tag_protection

> repos_delete_tag_protection(owner, repo, tag_protection_id)

Delete a tag protection state for a repository

This deletes a tag protection state for a repository. This endpoint is only available to repository administrators.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
tag_protection_id = 56 # Integer | The unique identifier of the tag protection.

begin
  # Delete a tag protection state for a repository
  api_instance.repos_delete_tag_protection(owner, repo, tag_protection_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_tag_protection: #{e}"
end
```

#### Using the repos_delete_tag_protection_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_delete_tag_protection_with_http_info(owner, repo, tag_protection_id)

```ruby
begin
  # Delete a tag protection state for a repository
  data, status_code, headers = api_instance.repos_delete_tag_protection_with_http_info(owner, repo, tag_protection_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_tag_protection_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **tag_protection_id** | **Integer** | The unique identifier of the tag protection. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_delete_webhook

> repos_delete_webhook(owner, repo, hook_id)

Delete a repository webhook



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
hook_id = 56 # Integer | The unique identifier of the hook.

begin
  # Delete a repository webhook
  api_instance.repos_delete_webhook(owner, repo, hook_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_webhook: #{e}"
end
```

#### Using the repos_delete_webhook_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_delete_webhook_with_http_info(owner, repo, hook_id)

```ruby
begin
  # Delete a repository webhook
  data, status_code, headers = api_instance.repos_delete_webhook_with_http_info(owner, repo, hook_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_delete_webhook_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **hook_id** | **Integer** | The unique identifier of the hook. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_disable_automated_security_fixes

> repos_disable_automated_security_fixes(owner, repo)

Disable automated security fixes

Disables automated security fixes for a repository. The authenticated user must have admin access to the repository. For more information, see \"[Configuring automated security fixes](https://docs.github.com/en/articles/configuring-automated-security-fixes)\".

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Disable automated security fixes
  api_instance.repos_disable_automated_security_fixes(owner, repo)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_disable_automated_security_fixes: #{e}"
end
```

#### Using the repos_disable_automated_security_fixes_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_disable_automated_security_fixes_with_http_info(owner, repo)

```ruby
begin
  # Disable automated security fixes
  data, status_code, headers = api_instance.repos_disable_automated_security_fixes_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_disable_automated_security_fixes_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## repos_disable_lfs_for_repo

> repos_disable_lfs_for_repo(owner, repo)

Disable Git LFS for a repository



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Disable Git LFS for a repository
  api_instance.repos_disable_lfs_for_repo(owner, repo)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_disable_lfs_for_repo: #{e}"
end
```

#### Using the repos_disable_lfs_for_repo_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_disable_lfs_for_repo_with_http_info(owner, repo)

```ruby
begin
  # Disable Git LFS for a repository
  data, status_code, headers = api_instance.repos_disable_lfs_for_repo_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_disable_lfs_for_repo_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## repos_disable_vulnerability_alerts

> repos_disable_vulnerability_alerts(owner, repo)

Disable vulnerability alerts

Disables dependency alerts and the dependency graph for a repository. The authenticated user must have admin access to the repository. For more information, see \"[About security alerts for vulnerable dependencies](https://docs.github.com/en/articles/about-security-alerts-for-vulnerable-dependencies)\".

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Disable vulnerability alerts
  api_instance.repos_disable_vulnerability_alerts(owner, repo)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_disable_vulnerability_alerts: #{e}"
end
```

#### Using the repos_disable_vulnerability_alerts_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_disable_vulnerability_alerts_with_http_info(owner, repo)

```ruby
begin
  # Disable vulnerability alerts
  data, status_code, headers = api_instance.repos_disable_vulnerability_alerts_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_disable_vulnerability_alerts_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## repos_download_tarball_archive

> repos_download_tarball_archive(owner, repo, ref)

Download a repository archive (tar)

Gets a redirect URL to download a tar archive for a repository. If you omit `:ref`, the repository’s default branch (usually `master`) will be used. Please make sure your HTTP framework is configured to follow redirects or you will need to use the `Location` header to make a second `GET` request. **Note**: For private repositories, these links are temporary and expire after five minutes.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
ref = 'ref_example' # String | 

begin
  # Download a repository archive (tar)
  api_instance.repos_download_tarball_archive(owner, repo, ref)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_download_tarball_archive: #{e}"
end
```

#### Using the repos_download_tarball_archive_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_download_tarball_archive_with_http_info(owner, repo, ref)

```ruby
begin
  # Download a repository archive (tar)
  data, status_code, headers = api_instance.repos_download_tarball_archive_with_http_info(owner, repo, ref)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_download_tarball_archive_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **ref** | **String** |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## repos_download_zipball_archive

> repos_download_zipball_archive(owner, repo, ref)

Download a repository archive (zip)

Gets a redirect URL to download a zip archive for a repository. If you omit `:ref`, the repository’s default branch (usually `master`) will be used. Please make sure your HTTP framework is configured to follow redirects or you will need to use the `Location` header to make a second `GET` request.  **Note**: For private repositories, these links are temporary and expire after five minutes. If the repository is empty, you will receive a 404 when you follow the redirect.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
ref = 'ref_example' # String | 

begin
  # Download a repository archive (zip)
  api_instance.repos_download_zipball_archive(owner, repo, ref)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_download_zipball_archive: #{e}"
end
```

#### Using the repos_download_zipball_archive_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_download_zipball_archive_with_http_info(owner, repo, ref)

```ruby
begin
  # Download a repository archive (zip)
  data, status_code, headers = api_instance.repos_download_zipball_archive_with_http_info(owner, repo, ref)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_download_zipball_archive_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **ref** | **String** |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## repos_enable_automated_security_fixes

> repos_enable_automated_security_fixes(owner, repo)

Enable automated security fixes

Enables automated security fixes for a repository. The authenticated user must have admin access to the repository. For more information, see \"[Configuring automated security fixes](https://docs.github.com/en/articles/configuring-automated-security-fixes)\".

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Enable automated security fixes
  api_instance.repos_enable_automated_security_fixes(owner, repo)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_enable_automated_security_fixes: #{e}"
end
```

#### Using the repos_enable_automated_security_fixes_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_enable_automated_security_fixes_with_http_info(owner, repo)

```ruby
begin
  # Enable automated security fixes
  data, status_code, headers = api_instance.repos_enable_automated_security_fixes_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_enable_automated_security_fixes_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## repos_enable_lfs_for_repo

> Object repos_enable_lfs_for_repo(owner, repo)

Enable Git LFS for a repository



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Enable Git LFS for a repository
  result = api_instance.repos_enable_lfs_for_repo(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_enable_lfs_for_repo: #{e}"
end
```

#### Using the repos_enable_lfs_for_repo_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Object, Integer, Hash)> repos_enable_lfs_for_repo_with_http_info(owner, repo)

```ruby
begin
  # Enable Git LFS for a repository
  data, status_code, headers = api_instance.repos_enable_lfs_for_repo_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Object
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_enable_lfs_for_repo_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_enable_vulnerability_alerts

> repos_enable_vulnerability_alerts(owner, repo)

Enable vulnerability alerts

Enables dependency alerts and the dependency graph for a repository. The authenticated user must have admin access to the repository. For more information, see \"[About security alerts for vulnerable dependencies](https://docs.github.com/en/articles/about-security-alerts-for-vulnerable-dependencies)\".

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Enable vulnerability alerts
  api_instance.repos_enable_vulnerability_alerts(owner, repo)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_enable_vulnerability_alerts: #{e}"
end
```

#### Using the repos_enable_vulnerability_alerts_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_enable_vulnerability_alerts_with_http_info(owner, repo)

```ruby
begin
  # Enable vulnerability alerts
  data, status_code, headers = api_instance.repos_enable_vulnerability_alerts_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_enable_vulnerability_alerts_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## repos_generate_release_notes

> <GeneratedReleaseNotesContent> repos_generate_release_notes(owner, repo, repos_generate_release_notes_request)

Generate release notes content for a release

Generate a name and body describing a [release](https://docs.github.com/rest/reference/repos#releases). The body content will be markdown formatted and contain information like the changes since last release and users who contributed. The generated release notes are not saved anywhere. They are intended to be generated and used when creating a new release.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
repos_generate_release_notes_request = OpenapiClient::ReposGenerateReleaseNotesRequest.new({tag_name: 'tag_name_example'}) # ReposGenerateReleaseNotesRequest | 

begin
  # Generate release notes content for a release
  result = api_instance.repos_generate_release_notes(owner, repo, repos_generate_release_notes_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_generate_release_notes: #{e}"
end
```

#### Using the repos_generate_release_notes_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<GeneratedReleaseNotesContent>, Integer, Hash)> repos_generate_release_notes_with_http_info(owner, repo, repos_generate_release_notes_request)

```ruby
begin
  # Generate release notes content for a release
  data, status_code, headers = api_instance.repos_generate_release_notes_with_http_info(owner, repo, repos_generate_release_notes_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <GeneratedReleaseNotesContent>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_generate_release_notes_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **repos_generate_release_notes_request** | [**ReposGenerateReleaseNotesRequest**](ReposGenerateReleaseNotesRequest.md) |  |  |

### Return type

[**GeneratedReleaseNotesContent**](GeneratedReleaseNotesContent.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_get

> <FullRepository> repos_get(owner, repo)

Get a repository

The `parent` and `source` objects are present when the repository is a fork. `parent` is the repository this repository was forked from, `source` is the ultimate source for the network.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get a repository
  result = api_instance.repos_get(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get: #{e}"
end
```

#### Using the repos_get_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<FullRepository>, Integer, Hash)> repos_get_with_http_info(owner, repo)

```ruby
begin
  # Get a repository
  data, status_code, headers = api_instance.repos_get_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <FullRepository>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**FullRepository**](FullRepository.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_access_restrictions

> <BranchRestrictionPolicy> repos_get_access_restrictions(owner, repo, branch)

Get access restrictions

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Lists who has access to this protected branch.  **Note**: Users, apps, and teams `restrictions` are only available for organization-owned repositories.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.

begin
  # Get access restrictions
  result = api_instance.repos_get_access_restrictions(owner, repo, branch)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_access_restrictions: #{e}"
end
```

#### Using the repos_get_access_restrictions_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<BranchRestrictionPolicy>, Integer, Hash)> repos_get_access_restrictions_with_http_info(owner, repo, branch)

```ruby
begin
  # Get access restrictions
  data, status_code, headers = api_instance.repos_get_access_restrictions_with_http_info(owner, repo, branch)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <BranchRestrictionPolicy>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_access_restrictions_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |

### Return type

[**BranchRestrictionPolicy**](BranchRestrictionPolicy.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_admin_branch_protection

> <ProtectedBranchAdminEnforced> repos_get_admin_branch_protection(owner, repo, branch)

Get admin branch protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.

begin
  # Get admin branch protection
  result = api_instance.repos_get_admin_branch_protection(owner, repo, branch)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_admin_branch_protection: #{e}"
end
```

#### Using the repos_get_admin_branch_protection_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ProtectedBranchAdminEnforced>, Integer, Hash)> repos_get_admin_branch_protection_with_http_info(owner, repo, branch)

```ruby
begin
  # Get admin branch protection
  data, status_code, headers = api_instance.repos_get_admin_branch_protection_with_http_info(owner, repo, branch)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ProtectedBranchAdminEnforced>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_admin_branch_protection_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |

### Return type

[**ProtectedBranchAdminEnforced**](ProtectedBranchAdminEnforced.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_all_environments

> <ReposGetAllEnvironments200Response> repos_get_all_environments(owner, repo, opts)

Get all environments

Get all environments for a repository.  Anyone with read access to the repository can use this endpoint. If the repository is private, you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # Get all environments
  result = api_instance.repos_get_all_environments(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_all_environments: #{e}"
end
```

#### Using the repos_get_all_environments_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ReposGetAllEnvironments200Response>, Integer, Hash)> repos_get_all_environments_with_http_info(owner, repo, opts)

```ruby
begin
  # Get all environments
  data, status_code, headers = api_instance.repos_get_all_environments_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ReposGetAllEnvironments200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_all_environments_with_http_info: #{e}"
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

[**ReposGetAllEnvironments200Response**](ReposGetAllEnvironments200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_all_status_check_contexts

> Array&lt;String&gt; repos_get_all_status_check_contexts(owner, repo, branch)

Get all status check contexts

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.

begin
  # Get all status check contexts
  result = api_instance.repos_get_all_status_check_contexts(owner, repo, branch)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_all_status_check_contexts: #{e}"
end
```

#### Using the repos_get_all_status_check_contexts_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Array&lt;String&gt;, Integer, Hash)> repos_get_all_status_check_contexts_with_http_info(owner, repo, branch)

```ruby
begin
  # Get all status check contexts
  data, status_code, headers = api_instance.repos_get_all_status_check_contexts_with_http_info(owner, repo, branch)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Array&lt;String&gt;
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_all_status_check_contexts_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |

### Return type

**Array&lt;String&gt;**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_all_topics

> <Topic> repos_get_all_topics(owner, repo, opts)

Get all repository topics



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  page: 56, # Integer | Page number of the results to fetch.
  per_page: 56 # Integer | The number of results per page (max 100).
}

begin
  # Get all repository topics
  result = api_instance.repos_get_all_topics(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_all_topics: #{e}"
end
```

#### Using the repos_get_all_topics_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Topic>, Integer, Hash)> repos_get_all_topics_with_http_info(owner, repo, opts)

```ruby
begin
  # Get all repository topics
  data, status_code, headers = api_instance.repos_get_all_topics_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Topic>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_all_topics_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |

### Return type

[**Topic**](Topic.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_apps_with_access_to_protected_branch

> <Array<GitHubApp>> repos_get_apps_with_access_to_protected_branch(owner, repo, branch)

Get apps with access to the protected branch

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Lists the GitHub Apps that have push access to this branch. Only installed GitHub Apps with `write` access to the `contents` permission can be added as authorized actors on a protected branch.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.

begin
  # Get apps with access to the protected branch
  result = api_instance.repos_get_apps_with_access_to_protected_branch(owner, repo, branch)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_apps_with_access_to_protected_branch: #{e}"
end
```

#### Using the repos_get_apps_with_access_to_protected_branch_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<GitHubApp>>, Integer, Hash)> repos_get_apps_with_access_to_protected_branch_with_http_info(owner, repo, branch)

```ruby
begin
  # Get apps with access to the protected branch
  data, status_code, headers = api_instance.repos_get_apps_with_access_to_protected_branch_with_http_info(owner, repo, branch)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<GitHubApp>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_apps_with_access_to_protected_branch_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |

### Return type

[**Array&lt;GitHubApp&gt;**](GitHubApp.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_autolink

> <AutolinkReference> repos_get_autolink(owner, repo, autolink_id)

Get an autolink reference of a repository

This returns a single autolink reference by ID that was configured for the given repository.  Information about autolinks are only available to repository administrators.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
autolink_id = 56 # Integer | The unique identifier of the autolink.

begin
  # Get an autolink reference of a repository
  result = api_instance.repos_get_autolink(owner, repo, autolink_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_autolink: #{e}"
end
```

#### Using the repos_get_autolink_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<AutolinkReference>, Integer, Hash)> repos_get_autolink_with_http_info(owner, repo, autolink_id)

```ruby
begin
  # Get an autolink reference of a repository
  data, status_code, headers = api_instance.repos_get_autolink_with_http_info(owner, repo, autolink_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <AutolinkReference>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_autolink_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **autolink_id** | **Integer** | The unique identifier of the autolink. |  |

### Return type

[**AutolinkReference**](AutolinkReference.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_branch

> <BranchWithProtection> repos_get_branch(owner, repo, branch)

Get a branch



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.

begin
  # Get a branch
  result = api_instance.repos_get_branch(owner, repo, branch)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_branch: #{e}"
end
```

#### Using the repos_get_branch_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<BranchWithProtection>, Integer, Hash)> repos_get_branch_with_http_info(owner, repo, branch)

```ruby
begin
  # Get a branch
  data, status_code, headers = api_instance.repos_get_branch_with_http_info(owner, repo, branch)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <BranchWithProtection>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_branch_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |

### Return type

[**BranchWithProtection**](BranchWithProtection.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_branch_protection

> <BranchProtection> repos_get_branch_protection(owner, repo, branch)

Get branch protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.

begin
  # Get branch protection
  result = api_instance.repos_get_branch_protection(owner, repo, branch)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_branch_protection: #{e}"
end
```

#### Using the repos_get_branch_protection_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<BranchProtection>, Integer, Hash)> repos_get_branch_protection_with_http_info(owner, repo, branch)

```ruby
begin
  # Get branch protection
  data, status_code, headers = api_instance.repos_get_branch_protection_with_http_info(owner, repo, branch)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <BranchProtection>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_branch_protection_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |

### Return type

[**BranchProtection**](BranchProtection.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_clones

> <CloneTraffic> repos_get_clones(owner, repo, opts)

Get repository clones

Get the total number of clones and breakdown per day or week for the last 14 days. Timestamps are aligned to UTC midnight of the beginning of the day or week. Week begins on Monday.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  per: 'per_example' # String | The time frame to display results for.
}

begin
  # Get repository clones
  result = api_instance.repos_get_clones(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_clones: #{e}"
end
```

#### Using the repos_get_clones_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CloneTraffic>, Integer, Hash)> repos_get_clones_with_http_info(owner, repo, opts)

```ruby
begin
  # Get repository clones
  data, status_code, headers = api_instance.repos_get_clones_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CloneTraffic>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_clones_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **per** | **String** | The time frame to display results for. | [optional][default to &#39;day&#39;] |

### Return type

[**CloneTraffic**](CloneTraffic.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_code_frequency_stats

> Array&lt;Array&lt;Integer&gt;&gt; repos_get_code_frequency_stats(owner, repo)

Get the weekly commit activity

Returns a weekly aggregate of the number of additions and deletions pushed to a repository.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get the weekly commit activity
  result = api_instance.repos_get_code_frequency_stats(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_code_frequency_stats: #{e}"
end
```

#### Using the repos_get_code_frequency_stats_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Array&lt;Array&lt;Integer&gt;&gt;, Integer, Hash)> repos_get_code_frequency_stats_with_http_info(owner, repo)

```ruby
begin
  # Get the weekly commit activity
  data, status_code, headers = api_instance.repos_get_code_frequency_stats_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Array&lt;Array&lt;Integer&gt;&gt;
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_code_frequency_stats_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

**Array&lt;Array&lt;Integer&gt;&gt;**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_collaborator_permission_level

> <RepositoryCollaboratorPermission> repos_get_collaborator_permission_level(owner, repo, username)

Get repository permissions for a user

Checks the repository permission of a collaborator. The possible repository permissions are `admin`, `write`, `read`, and `none`.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
username = 'username_example' # String | The handle for the GitHub user account.

begin
  # Get repository permissions for a user
  result = api_instance.repos_get_collaborator_permission_level(owner, repo, username)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_collaborator_permission_level: #{e}"
end
```

#### Using the repos_get_collaborator_permission_level_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<RepositoryCollaboratorPermission>, Integer, Hash)> repos_get_collaborator_permission_level_with_http_info(owner, repo, username)

```ruby
begin
  # Get repository permissions for a user
  data, status_code, headers = api_instance.repos_get_collaborator_permission_level_with_http_info(owner, repo, username)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <RepositoryCollaboratorPermission>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_collaborator_permission_level_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **username** | **String** | The handle for the GitHub user account. |  |

### Return type

[**RepositoryCollaboratorPermission**](RepositoryCollaboratorPermission.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_combined_status_for_ref

> <CombinedCommitStatus> repos_get_combined_status_for_ref(owner, repo, ref, opts)

Get the combined status for a specific reference

Users with pull access in a repository can access a combined view of commit statuses for a given ref. The ref can be a SHA, a branch name, or a tag name.   Additionally, a combined `state` is returned. The `state` is one of:  *   **failure** if any of the contexts report as `error` or `failure` *   **pending** if there are no statuses or a context is `pending` *   **success** if the latest status for all contexts is `success`

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
ref = 'ref_example' # String | ref parameter
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # Get the combined status for a specific reference
  result = api_instance.repos_get_combined_status_for_ref(owner, repo, ref, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_combined_status_for_ref: #{e}"
end
```

#### Using the repos_get_combined_status_for_ref_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CombinedCommitStatus>, Integer, Hash)> repos_get_combined_status_for_ref_with_http_info(owner, repo, ref, opts)

```ruby
begin
  # Get the combined status for a specific reference
  data, status_code, headers = api_instance.repos_get_combined_status_for_ref_with_http_info(owner, repo, ref, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CombinedCommitStatus>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_combined_status_for_ref_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **ref** | **String** | ref parameter |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**CombinedCommitStatus**](CombinedCommitStatus.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_commit

> <Commit> repos_get_commit(owner, repo, ref, opts)

Get a commit

Returns the contents of a single commit reference. You must have `read` access for the repository to use this endpoint.  **Note:** If there are more than 300 files in the commit diff, the response will include pagination link headers for the remaining files, up to a limit of 3000 files. Each page contains the static commit information, and the only changes are to the file listing.  You can pass the appropriate [media type](https://docs.github.com/rest/overview/media-types/#commits-commit-comparison-and-pull-requests) to  fetch `diff` and `patch` formats. Diffs with binary data will have no `patch` property.  To return only the SHA-1 hash of the commit reference, you can provide the `sha` custom [media type](https://docs.github.com/rest/overview/media-types/#commits-commit-comparison-and-pull-requests) in the `Accept` header. You can use this endpoint to check if a remote reference's SHA-1 hash is the same as your local reference's SHA-1 hash by providing the local SHA-1 reference as the ETag.  **Signature verification object**  The response will include a `verification` object that describes the result of verifying the commit's signature. The following fields are included in the `verification` object:  | Name | Type | Description | | ---- | ---- | ----------- | | `verified` | `boolean` | Indicates whether GitHub considers the signature in this commit to be verified. | | `reason` | `string` | The reason for verified value. Possible values and their meanings are enumerated in table below. | | `signature` | `string` | The signature that was extracted from the commit. | | `payload` | `string` | The value that was signed. |  These are the possible values for `reason` in the `verification` object:  | Value | Description | | ----- | ----------- | | `expired_key` | The key that made the signature is expired. | | `not_signing_key` | The \"signing\" flag is not among the usage flags in the GPG key that made the signature. | | `gpgverify_error` | There was an error communicating with the signature verification service. | | `gpgverify_unavailable` | The signature verification service is currently unavailable. | | `unsigned` | The object does not include a signature. | | `unknown_signature_type` | A non-PGP signature was found in the commit. | | `no_user` | No user was associated with the `committer` email address in the commit. | | `unverified_email` | The `committer` email address in the commit was associated with a user, but the email address is not verified on her/his account. | | `bad_email` | The `committer` email address in the commit is not included in the identities of the PGP key that made the signature. | | `unknown_key` | The key that made the signature has not been registered with any user's account. | | `malformed_signature` | There was an error parsing the signature. | | `invalid` | The signature could not be cryptographically verified using the key whose key-id was found in the signature. | | `valid` | None of the above errors applied, so the signature is considered to be verified. |

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
ref = 'ref_example' # String | ref parameter
opts = {
  page: 56, # Integer | Page number of the results to fetch.
  per_page: 56 # Integer | The number of results per page (max 100).
}

begin
  # Get a commit
  result = api_instance.repos_get_commit(owner, repo, ref, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_commit: #{e}"
end
```

#### Using the repos_get_commit_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Commit>, Integer, Hash)> repos_get_commit_with_http_info(owner, repo, ref, opts)

```ruby
begin
  # Get a commit
  data, status_code, headers = api_instance.repos_get_commit_with_http_info(owner, repo, ref, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Commit>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_commit_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **ref** | **String** | ref parameter |  |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |

### Return type

[**Commit**](Commit.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_commit_activity_stats

> <Array<CommitActivity>> repos_get_commit_activity_stats(owner, repo)

Get the last year of commit activity

Returns the last year of commit activity grouped by week. The `days` array is a group of commits per day, starting on `Sunday`.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get the last year of commit activity
  result = api_instance.repos_get_commit_activity_stats(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_commit_activity_stats: #{e}"
end
```

#### Using the repos_get_commit_activity_stats_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<CommitActivity>>, Integer, Hash)> repos_get_commit_activity_stats_with_http_info(owner, repo)

```ruby
begin
  # Get the last year of commit activity
  data, status_code, headers = api_instance.repos_get_commit_activity_stats_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<CommitActivity>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_commit_activity_stats_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**Array&lt;CommitActivity&gt;**](CommitActivity.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_commit_comment

> <CommitComment> repos_get_commit_comment(owner, repo, comment_id)

Get a commit comment



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
comment_id = 56 # Integer | The unique identifier of the comment.

begin
  # Get a commit comment
  result = api_instance.repos_get_commit_comment(owner, repo, comment_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_commit_comment: #{e}"
end
```

#### Using the repos_get_commit_comment_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CommitComment>, Integer, Hash)> repos_get_commit_comment_with_http_info(owner, repo, comment_id)

```ruby
begin
  # Get a commit comment
  data, status_code, headers = api_instance.repos_get_commit_comment_with_http_info(owner, repo, comment_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CommitComment>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_commit_comment_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **comment_id** | **Integer** | The unique identifier of the comment. |  |

### Return type

[**CommitComment**](CommitComment.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_commit_signature_protection

> <ProtectedBranchAdminEnforced> repos_get_commit_signature_protection(owner, repo, branch)

Get commit signature protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  When authenticated with admin or owner permissions to the repository, you can use this endpoint to check whether a branch requires signed commits. An enabled status of `true` indicates you must sign commits on this branch. For more information, see [Signing commits with GPG](https://docs.github.com/articles/signing-commits-with-gpg) in GitHub Help.  **Note**: You must enable branch protection to require signed commits.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.

begin
  # Get commit signature protection
  result = api_instance.repos_get_commit_signature_protection(owner, repo, branch)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_commit_signature_protection: #{e}"
end
```

#### Using the repos_get_commit_signature_protection_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ProtectedBranchAdminEnforced>, Integer, Hash)> repos_get_commit_signature_protection_with_http_info(owner, repo, branch)

```ruby
begin
  # Get commit signature protection
  data, status_code, headers = api_instance.repos_get_commit_signature_protection_with_http_info(owner, repo, branch)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ProtectedBranchAdminEnforced>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_commit_signature_protection_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |

### Return type

[**ProtectedBranchAdminEnforced**](ProtectedBranchAdminEnforced.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_community_profile_metrics

> <CommunityProfile> repos_get_community_profile_metrics(owner, repo)

Get community profile metrics

This endpoint will return all community profile metrics, including an overall health score, repository description, the presence of documentation, detected code of conduct, detected license, and the presence of ISSUE\\_TEMPLATE, PULL\\_REQUEST\\_TEMPLATE, README, and CONTRIBUTING files.  The `health_percentage` score is defined as a percentage of how many of these four documents are present: README, CONTRIBUTING, LICENSE, and CODE_OF_CONDUCT. For example, if all four documents are present, then the `health_percentage` is `100`. If only one is present, then the `health_percentage` is `25`.  `content_reports_enabled` is only returned for organization-owned repositories.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get community profile metrics
  result = api_instance.repos_get_community_profile_metrics(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_community_profile_metrics: #{e}"
end
```

#### Using the repos_get_community_profile_metrics_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CommunityProfile>, Integer, Hash)> repos_get_community_profile_metrics_with_http_info(owner, repo)

```ruby
begin
  # Get community profile metrics
  data, status_code, headers = api_instance.repos_get_community_profile_metrics_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CommunityProfile>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_community_profile_metrics_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**CommunityProfile**](CommunityProfile.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_content

> <ContentTree> repos_get_content(owner, repo, path, opts)

Get repository content

Gets the contents of a file or directory in a repository. Specify the file path or directory in `:path`. If you omit `:path`, you will receive the contents of the repository's root directory. See the description below regarding what the API response includes for directories.   Files and symlinks support [a custom media type](https://docs.github.com/rest/reference/repos#custom-media-types) for retrieving the raw content or rendered HTML (when supported). All content types support [a custom media type](https://docs.github.com/rest/reference/repos#custom-media-types) to ensure the content is returned in a consistent object format.  **Note**: *   To get a repository's contents recursively, you can [recursively get the tree](https://docs.github.com/rest/reference/git#trees). *   This API has an upper limit of 1,000 files for a directory. If you need to retrieve more files, use the [Git Trees API](https://docs.github.com/rest/reference/git#get-a-tree).  #### Size limits If the requested file's size is: * 1 MB or smaller: All features of this endpoint are supported. * Between 1-100 MB: Only the `raw` or `object` [custom media types](https://docs.github.com/rest/repos/contents#custom-media-types-for-repository-contents) are supported. Both will work as normal, except that when using the `object` media type, the `content` field will be an empty string and the `encoding` field will be `\"none\"`. To get the contents of these larger files, use the `raw` media type.  * Greater than 100 MB: This endpoint is not supported.  #### If the content is a directory The response will be an array of objects, one object for each item in the directory. When listing the contents of a directory, submodules have their \"type\" specified as \"file\". Logically, the value _should_ be \"submodule\". This behavior exists in API v3 [for backwards compatibility purposes](https://git.io/v1YCW). In the next major version of the API, the type will be returned as \"submodule\".  #### If the content is a symlink  If the requested `:path` points to a symlink, and the symlink's target is a normal file in the repository, then the API responds with the content of the file (in the format shown in the example. Otherwise, the API responds with an object  describing the symlink itself.  #### If the content is a submodule The `submodule_git_url` identifies the location of the submodule repository, and the `sha` identifies a specific commit within the submodule repository. Git uses the given URL when cloning the submodule repository, and checks out the submodule at that specific commit.  If the submodule repository is not hosted on github.com, the Git URLs (`git_url` and `_links[\"git\"]`) and the github.com URLs (`html_url` and `_links[\"html\"]`) will have null values.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
path = 'path_example' # String | path parameter
opts = {
  ref: 'ref_example' # String | The name of the commit/branch/tag. Default: the repository’s default branch (usually `master`)
}

begin
  # Get repository content
  result = api_instance.repos_get_content(owner, repo, path, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_content: #{e}"
end
```

#### Using the repos_get_content_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ContentTree>, Integer, Hash)> repos_get_content_with_http_info(owner, repo, path, opts)

```ruby
begin
  # Get repository content
  data, status_code, headers = api_instance.repos_get_content_with_http_info(owner, repo, path, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ContentTree>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_content_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **path** | **String** | path parameter |  |
| **ref** | **String** | The name of the commit/branch/tag. Default: the repository’s default branch (usually &#x60;master&#x60;) | [optional] |

### Return type

[**ContentTree**](ContentTree.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/vnd.github.object, application/json


## repos_get_contributors_stats

> <Array<ContributorActivity>> repos_get_contributors_stats(owner, repo)

Get all contributor commit activity

 Returns the `total` number of commits authored by the contributor. In addition, the response includes a Weekly Hash (`weeks` array) with the following information:  *   `w` - Start of the week, given as a [Unix timestamp](http://en.wikipedia.org/wiki/Unix_time). *   `a` - Number of additions *   `d` - Number of deletions *   `c` - Number of commits

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get all contributor commit activity
  result = api_instance.repos_get_contributors_stats(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_contributors_stats: #{e}"
end
```

#### Using the repos_get_contributors_stats_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<ContributorActivity>>, Integer, Hash)> repos_get_contributors_stats_with_http_info(owner, repo)

```ruby
begin
  # Get all contributor commit activity
  data, status_code, headers = api_instance.repos_get_contributors_stats_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<ContributorActivity>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_contributors_stats_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**Array&lt;ContributorActivity&gt;**](ContributorActivity.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_deploy_key

> <DeployKey> repos_get_deploy_key(owner, repo, key_id)

Get a deploy key



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
key_id = 56 # Integer | The unique identifier of the key.

begin
  # Get a deploy key
  result = api_instance.repos_get_deploy_key(owner, repo, key_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_deploy_key: #{e}"
end
```

#### Using the repos_get_deploy_key_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<DeployKey>, Integer, Hash)> repos_get_deploy_key_with_http_info(owner, repo, key_id)

```ruby
begin
  # Get a deploy key
  data, status_code, headers = api_instance.repos_get_deploy_key_with_http_info(owner, repo, key_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <DeployKey>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_deploy_key_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **key_id** | **Integer** | The unique identifier of the key. |  |

### Return type

[**DeployKey**](DeployKey.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_deployment

> <Deployment> repos_get_deployment(owner, repo, deployment_id)

Get a deployment



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
deployment_id = 56 # Integer | deployment_id parameter

begin
  # Get a deployment
  result = api_instance.repos_get_deployment(owner, repo, deployment_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_deployment: #{e}"
end
```

#### Using the repos_get_deployment_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Deployment>, Integer, Hash)> repos_get_deployment_with_http_info(owner, repo, deployment_id)

```ruby
begin
  # Get a deployment
  data, status_code, headers = api_instance.repos_get_deployment_with_http_info(owner, repo, deployment_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Deployment>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_deployment_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **deployment_id** | **Integer** | deployment_id parameter |  |

### Return type

[**Deployment**](Deployment.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_deployment_status

> <DeploymentStatus> repos_get_deployment_status(owner, repo, deployment_id, status_id)

Get a deployment status

Users with pull access can view a deployment status for a deployment:

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
deployment_id = 56 # Integer | deployment_id parameter
status_id = 56 # Integer | 

begin
  # Get a deployment status
  result = api_instance.repos_get_deployment_status(owner, repo, deployment_id, status_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_deployment_status: #{e}"
end
```

#### Using the repos_get_deployment_status_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<DeploymentStatus>, Integer, Hash)> repos_get_deployment_status_with_http_info(owner, repo, deployment_id, status_id)

```ruby
begin
  # Get a deployment status
  data, status_code, headers = api_instance.repos_get_deployment_status_with_http_info(owner, repo, deployment_id, status_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <DeploymentStatus>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_deployment_status_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **deployment_id** | **Integer** | deployment_id parameter |  |
| **status_id** | **Integer** |  |  |

### Return type

[**DeploymentStatus**](DeploymentStatus.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_environment

> <Environment> repos_get_environment(owner, repo, environment_name)

Get an environment

Anyone with read access to the repository can use this endpoint. If the repository is private, you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
environment_name = 'environment_name_example' # String | The name of the environment

begin
  # Get an environment
  result = api_instance.repos_get_environment(owner, repo, environment_name)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_environment: #{e}"
end
```

#### Using the repos_get_environment_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Environment>, Integer, Hash)> repos_get_environment_with_http_info(owner, repo, environment_name)

```ruby
begin
  # Get an environment
  data, status_code, headers = api_instance.repos_get_environment_with_http_info(owner, repo, environment_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Environment>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_environment_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **environment_name** | **String** | The name of the environment |  |

### Return type

[**Environment**](Environment.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_latest_pages_build

> <PageBuild> repos_get_latest_pages_build(owner, repo)

Get latest Pages build



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get latest Pages build
  result = api_instance.repos_get_latest_pages_build(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_latest_pages_build: #{e}"
end
```

#### Using the repos_get_latest_pages_build_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<PageBuild>, Integer, Hash)> repos_get_latest_pages_build_with_http_info(owner, repo)

```ruby
begin
  # Get latest Pages build
  data, status_code, headers = api_instance.repos_get_latest_pages_build_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <PageBuild>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_latest_pages_build_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**PageBuild**](PageBuild.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_latest_release

> <Release> repos_get_latest_release(owner, repo)

Get the latest release

View the latest published full release for the repository.  The latest release is the most recent non-prerelease, non-draft release, sorted by the `created_at` attribute. The `created_at` attribute is the date of the commit used for the release, and not the date when the release was drafted or published.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get the latest release
  result = api_instance.repos_get_latest_release(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_latest_release: #{e}"
end
```

#### Using the repos_get_latest_release_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Release>, Integer, Hash)> repos_get_latest_release_with_http_info(owner, repo)

```ruby
begin
  # Get the latest release
  data, status_code, headers = api_instance.repos_get_latest_release_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Release>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_latest_release_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**Release**](Release.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_pages

> <GitHubPages> repos_get_pages(owner, repo)

Get a GitHub Pages site



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get a GitHub Pages site
  result = api_instance.repos_get_pages(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_pages: #{e}"
end
```

#### Using the repos_get_pages_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<GitHubPages>, Integer, Hash)> repos_get_pages_with_http_info(owner, repo)

```ruby
begin
  # Get a GitHub Pages site
  data, status_code, headers = api_instance.repos_get_pages_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <GitHubPages>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_pages_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**GitHubPages**](GitHubPages.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_pages_build

> <PageBuild> repos_get_pages_build(owner, repo, build_id)

Get GitHub Pages build



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
build_id = 56 # Integer | 

begin
  # Get GitHub Pages build
  result = api_instance.repos_get_pages_build(owner, repo, build_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_pages_build: #{e}"
end
```

#### Using the repos_get_pages_build_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<PageBuild>, Integer, Hash)> repos_get_pages_build_with_http_info(owner, repo, build_id)

```ruby
begin
  # Get GitHub Pages build
  data, status_code, headers = api_instance.repos_get_pages_build_with_http_info(owner, repo, build_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <PageBuild>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_pages_build_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **build_id** | **Integer** |  |  |

### Return type

[**PageBuild**](PageBuild.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_pages_health_check

> <PagesHealthCheckStatus> repos_get_pages_health_check(owner, repo)

Get a DNS health check for GitHub Pages

Gets a health check of the DNS settings for the `CNAME` record configured for a repository's GitHub Pages.  The first request to this endpoint returns a `202 Accepted` status and starts an asynchronous background task to get the results for the domain. After the background task completes, subsequent requests to this endpoint return a `200 OK` status with the health check results in the response.  Users must have admin or owner permissions. GitHub Apps must have the `pages:write` and `administration:write` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get a DNS health check for GitHub Pages
  result = api_instance.repos_get_pages_health_check(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_pages_health_check: #{e}"
end
```

#### Using the repos_get_pages_health_check_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<PagesHealthCheckStatus>, Integer, Hash)> repos_get_pages_health_check_with_http_info(owner, repo)

```ruby
begin
  # Get a DNS health check for GitHub Pages
  data, status_code, headers = api_instance.repos_get_pages_health_check_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <PagesHealthCheckStatus>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_pages_health_check_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**PagesHealthCheckStatus**](PagesHealthCheckStatus.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_participation_stats

> <ParticipationStats> repos_get_participation_stats(owner, repo)

Get the weekly commit count

Returns the total commit counts for the `owner` and total commit counts in `all`. `all` is everyone combined, including the `owner` in the last 52 weeks. If you'd like to get the commit counts for non-owners, you can subtract `owner` from `all`.  The array order is oldest week (index 0) to most recent week.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get the weekly commit count
  result = api_instance.repos_get_participation_stats(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_participation_stats: #{e}"
end
```

#### Using the repos_get_participation_stats_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ParticipationStats>, Integer, Hash)> repos_get_participation_stats_with_http_info(owner, repo)

```ruby
begin
  # Get the weekly commit count
  data, status_code, headers = api_instance.repos_get_participation_stats_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ParticipationStats>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_participation_stats_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**ParticipationStats**](ParticipationStats.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_pull_request_review_protection

> <ProtectedBranchPullRequestReview> repos_get_pull_request_review_protection(owner, repo, branch)

Get pull request review protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.

begin
  # Get pull request review protection
  result = api_instance.repos_get_pull_request_review_protection(owner, repo, branch)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_pull_request_review_protection: #{e}"
end
```

#### Using the repos_get_pull_request_review_protection_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ProtectedBranchPullRequestReview>, Integer, Hash)> repos_get_pull_request_review_protection_with_http_info(owner, repo, branch)

```ruby
begin
  # Get pull request review protection
  data, status_code, headers = api_instance.repos_get_pull_request_review_protection_with_http_info(owner, repo, branch)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ProtectedBranchPullRequestReview>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_pull_request_review_protection_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |

### Return type

[**ProtectedBranchPullRequestReview**](ProtectedBranchPullRequestReview.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_punch_card_stats

> Array&lt;Array&lt;Integer&gt;&gt; repos_get_punch_card_stats(owner, repo)

Get the hourly commit count for each day

Each array contains the day number, hour number, and number of commits:  *   `0-6`: Sunday - Saturday *   `0-23`: Hour of day *   Number of commits  For example, `[2, 14, 25]` indicates that there were 25 total commits, during the 2:00pm hour on Tuesdays. All times are based on the time zone of individual commits.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get the hourly commit count for each day
  result = api_instance.repos_get_punch_card_stats(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_punch_card_stats: #{e}"
end
```

#### Using the repos_get_punch_card_stats_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Array&lt;Array&lt;Integer&gt;&gt;, Integer, Hash)> repos_get_punch_card_stats_with_http_info(owner, repo)

```ruby
begin
  # Get the hourly commit count for each day
  data, status_code, headers = api_instance.repos_get_punch_card_stats_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Array&lt;Array&lt;Integer&gt;&gt;
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_punch_card_stats_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

**Array&lt;Array&lt;Integer&gt;&gt;**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_readme

> <ContentFile> repos_get_readme(owner, repo, opts)

Get a repository README

Gets the preferred README for a repository.  READMEs support [custom media types](https://docs.github.com/rest/reference/repos#custom-media-types) for retrieving the raw content or rendered HTML.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  ref: 'ref_example' # String | The name of the commit/branch/tag. Default: the repository’s default branch (usually `master`)
}

begin
  # Get a repository README
  result = api_instance.repos_get_readme(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_readme: #{e}"
end
```

#### Using the repos_get_readme_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ContentFile>, Integer, Hash)> repos_get_readme_with_http_info(owner, repo, opts)

```ruby
begin
  # Get a repository README
  data, status_code, headers = api_instance.repos_get_readme_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ContentFile>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_readme_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **ref** | **String** | The name of the commit/branch/tag. Default: the repository’s default branch (usually &#x60;master&#x60;) | [optional] |

### Return type

[**ContentFile**](ContentFile.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_readme_in_directory

> <ContentFile> repos_get_readme_in_directory(owner, repo, dir, opts)

Get a repository README for a directory

Gets the README from a repository directory.  READMEs support [custom media types](https://docs.github.com/rest/reference/repos#custom-media-types) for retrieving the raw content or rendered HTML.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
dir = 'dir_example' # String | The alternate path to look for a README file
opts = {
  ref: 'ref_example' # String | The name of the commit/branch/tag. Default: the repository’s default branch (usually `master`)
}

begin
  # Get a repository README for a directory
  result = api_instance.repos_get_readme_in_directory(owner, repo, dir, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_readme_in_directory: #{e}"
end
```

#### Using the repos_get_readme_in_directory_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ContentFile>, Integer, Hash)> repos_get_readme_in_directory_with_http_info(owner, repo, dir, opts)

```ruby
begin
  # Get a repository README for a directory
  data, status_code, headers = api_instance.repos_get_readme_in_directory_with_http_info(owner, repo, dir, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ContentFile>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_readme_in_directory_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **dir** | **String** | The alternate path to look for a README file |  |
| **ref** | **String** | The name of the commit/branch/tag. Default: the repository’s default branch (usually &#x60;master&#x60;) | [optional] |

### Return type

[**ContentFile**](ContentFile.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_release

> <Release> repos_get_release(owner, repo, release_id)

Get a release

**Note:** This returns an `upload_url` key corresponding to the endpoint for uploading release assets. This key is a [hypermedia resource](https://docs.github.com/rest/overview/resources-in-the-rest-api#hypermedia).

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
release_id = 56 # Integer | The unique identifier of the release.

begin
  # Get a release
  result = api_instance.repos_get_release(owner, repo, release_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_release: #{e}"
end
```

#### Using the repos_get_release_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Release>, Integer, Hash)> repos_get_release_with_http_info(owner, repo, release_id)

```ruby
begin
  # Get a release
  data, status_code, headers = api_instance.repos_get_release_with_http_info(owner, repo, release_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Release>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_release_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **release_id** | **Integer** | The unique identifier of the release. |  |

### Return type

[**Release**](Release.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_release_asset

> <ReleaseAsset> repos_get_release_asset(owner, repo, asset_id)

Get a release asset

To download the asset's binary content, set the `Accept` header of the request to [`application/octet-stream`](https://docs.github.com/rest/overview/media-types). The API will either redirect the client to the location, or stream it directly if possible. API clients should handle both a `200` or `302` response.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
asset_id = 56 # Integer | The unique identifier of the asset.

begin
  # Get a release asset
  result = api_instance.repos_get_release_asset(owner, repo, asset_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_release_asset: #{e}"
end
```

#### Using the repos_get_release_asset_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ReleaseAsset>, Integer, Hash)> repos_get_release_asset_with_http_info(owner, repo, asset_id)

```ruby
begin
  # Get a release asset
  data, status_code, headers = api_instance.repos_get_release_asset_with_http_info(owner, repo, asset_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ReleaseAsset>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_release_asset_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **asset_id** | **Integer** | The unique identifier of the asset. |  |

### Return type

[**ReleaseAsset**](ReleaseAsset.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_release_by_tag

> <Release> repos_get_release_by_tag(owner, repo, tag)

Get a release by tag name

Get a published release with the specified tag.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
tag = 'tag_example' # String | tag parameter

begin
  # Get a release by tag name
  result = api_instance.repos_get_release_by_tag(owner, repo, tag)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_release_by_tag: #{e}"
end
```

#### Using the repos_get_release_by_tag_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Release>, Integer, Hash)> repos_get_release_by_tag_with_http_info(owner, repo, tag)

```ruby
begin
  # Get a release by tag name
  data, status_code, headers = api_instance.repos_get_release_by_tag_with_http_info(owner, repo, tag)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Release>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_release_by_tag_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **tag** | **String** | tag parameter |  |

### Return type

[**Release**](Release.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_status_checks_protection

> <StatusCheckPolicy> repos_get_status_checks_protection(owner, repo, branch)

Get status checks protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.

begin
  # Get status checks protection
  result = api_instance.repos_get_status_checks_protection(owner, repo, branch)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_status_checks_protection: #{e}"
end
```

#### Using the repos_get_status_checks_protection_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<StatusCheckPolicy>, Integer, Hash)> repos_get_status_checks_protection_with_http_info(owner, repo, branch)

```ruby
begin
  # Get status checks protection
  data, status_code, headers = api_instance.repos_get_status_checks_protection_with_http_info(owner, repo, branch)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <StatusCheckPolicy>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_status_checks_protection_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |

### Return type

[**StatusCheckPolicy**](StatusCheckPolicy.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_teams_with_access_to_protected_branch

> <Array<Team>> repos_get_teams_with_access_to_protected_branch(owner, repo, branch)

Get teams with access to the protected branch

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Lists the teams who have push access to this branch. The list includes child teams.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.

begin
  # Get teams with access to the protected branch
  result = api_instance.repos_get_teams_with_access_to_protected_branch(owner, repo, branch)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_teams_with_access_to_protected_branch: #{e}"
end
```

#### Using the repos_get_teams_with_access_to_protected_branch_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<Team>>, Integer, Hash)> repos_get_teams_with_access_to_protected_branch_with_http_info(owner, repo, branch)

```ruby
begin
  # Get teams with access to the protected branch
  data, status_code, headers = api_instance.repos_get_teams_with_access_to_protected_branch_with_http_info(owner, repo, branch)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<Team>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_teams_with_access_to_protected_branch_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |

### Return type

[**Array&lt;Team&gt;**](Team.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_top_paths

> <Array<ContentTraffic>> repos_get_top_paths(owner, repo)

Get top referral paths

Get the top 10 popular contents over the last 14 days.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get top referral paths
  result = api_instance.repos_get_top_paths(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_top_paths: #{e}"
end
```

#### Using the repos_get_top_paths_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<ContentTraffic>>, Integer, Hash)> repos_get_top_paths_with_http_info(owner, repo)

```ruby
begin
  # Get top referral paths
  data, status_code, headers = api_instance.repos_get_top_paths_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<ContentTraffic>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_top_paths_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**Array&lt;ContentTraffic&gt;**](ContentTraffic.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_top_referrers

> <Array<ReferrerTraffic>> repos_get_top_referrers(owner, repo)

Get top referral sources

Get the top 10 referrers over the last 14 days.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get top referral sources
  result = api_instance.repos_get_top_referrers(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_top_referrers: #{e}"
end
```

#### Using the repos_get_top_referrers_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<ReferrerTraffic>>, Integer, Hash)> repos_get_top_referrers_with_http_info(owner, repo)

```ruby
begin
  # Get top referral sources
  data, status_code, headers = api_instance.repos_get_top_referrers_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<ReferrerTraffic>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_top_referrers_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**Array&lt;ReferrerTraffic&gt;**](ReferrerTraffic.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_users_with_access_to_protected_branch

> <Array<SimpleUser1>> repos_get_users_with_access_to_protected_branch(owner, repo, branch)

Get users with access to the protected branch

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Lists the people who have push access to this branch.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.

begin
  # Get users with access to the protected branch
  result = api_instance.repos_get_users_with_access_to_protected_branch(owner, repo, branch)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_users_with_access_to_protected_branch: #{e}"
end
```

#### Using the repos_get_users_with_access_to_protected_branch_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<SimpleUser1>>, Integer, Hash)> repos_get_users_with_access_to_protected_branch_with_http_info(owner, repo, branch)

```ruby
begin
  # Get users with access to the protected branch
  data, status_code, headers = api_instance.repos_get_users_with_access_to_protected_branch_with_http_info(owner, repo, branch)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<SimpleUser1>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_users_with_access_to_protected_branch_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |

### Return type

[**Array&lt;SimpleUser1&gt;**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_views

> <ViewTraffic> repos_get_views(owner, repo, opts)

Get page views

Get the total number of views and breakdown per day or week for the last 14 days. Timestamps are aligned to UTC midnight of the beginning of the day or week. Week begins on Monday.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  per: 'per_example' # String | The time frame to display results for.
}

begin
  # Get page views
  result = api_instance.repos_get_views(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_views: #{e}"
end
```

#### Using the repos_get_views_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ViewTraffic>, Integer, Hash)> repos_get_views_with_http_info(owner, repo, opts)

```ruby
begin
  # Get page views
  data, status_code, headers = api_instance.repos_get_views_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ViewTraffic>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_views_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **per** | **String** | The time frame to display results for. | [optional][default to &#39;day&#39;] |

### Return type

[**ViewTraffic**](ViewTraffic.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_webhook

> <Webhook> repos_get_webhook(owner, repo, hook_id)

Get a repository webhook

Returns a webhook configured in a repository. To get only the webhook `config` properties, see \"[Get a webhook configuration for a repository](/rest/reference/repos#get-a-webhook-configuration-for-a-repository).\"

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
hook_id = 56 # Integer | The unique identifier of the hook.

begin
  # Get a repository webhook
  result = api_instance.repos_get_webhook(owner, repo, hook_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_webhook: #{e}"
end
```

#### Using the repos_get_webhook_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Webhook>, Integer, Hash)> repos_get_webhook_with_http_info(owner, repo, hook_id)

```ruby
begin
  # Get a repository webhook
  data, status_code, headers = api_instance.repos_get_webhook_with_http_info(owner, repo, hook_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Webhook>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_webhook_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **hook_id** | **Integer** | The unique identifier of the hook. |  |

### Return type

[**Webhook**](Webhook.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_webhook_config_for_repo

> <WebhookConfiguration> repos_get_webhook_config_for_repo(owner, repo, hook_id)

Get a webhook configuration for a repository

Returns the webhook configuration for a repository. To get more information about the webhook, including the `active` state and `events`, use \"[Get a repository webhook](/rest/reference/orgs#get-a-repository-webhook).\"  Access tokens must have the `read:repo_hook` or `repo` scope, and GitHub Apps must have the `repository_hooks:read` permission.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
hook_id = 56 # Integer | The unique identifier of the hook.

begin
  # Get a webhook configuration for a repository
  result = api_instance.repos_get_webhook_config_for_repo(owner, repo, hook_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_webhook_config_for_repo: #{e}"
end
```

#### Using the repos_get_webhook_config_for_repo_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<WebhookConfiguration>, Integer, Hash)> repos_get_webhook_config_for_repo_with_http_info(owner, repo, hook_id)

```ruby
begin
  # Get a webhook configuration for a repository
  data, status_code, headers = api_instance.repos_get_webhook_config_for_repo_with_http_info(owner, repo, hook_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <WebhookConfiguration>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_webhook_config_for_repo_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **hook_id** | **Integer** | The unique identifier of the hook. |  |

### Return type

[**WebhookConfiguration**](WebhookConfiguration.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_get_webhook_delivery

> <WebhookDelivery> repos_get_webhook_delivery(owner, repo, hook_id, delivery_id)

Get a delivery for a repository webhook

Returns a delivery for a webhook configured in a repository.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
hook_id = 56 # Integer | The unique identifier of the hook.
delivery_id = 56 # Integer | 

begin
  # Get a delivery for a repository webhook
  result = api_instance.repos_get_webhook_delivery(owner, repo, hook_id, delivery_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_webhook_delivery: #{e}"
end
```

#### Using the repos_get_webhook_delivery_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<WebhookDelivery>, Integer, Hash)> repos_get_webhook_delivery_with_http_info(owner, repo, hook_id, delivery_id)

```ruby
begin
  # Get a delivery for a repository webhook
  data, status_code, headers = api_instance.repos_get_webhook_delivery_with_http_info(owner, repo, hook_id, delivery_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <WebhookDelivery>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_get_webhook_delivery_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **hook_id** | **Integer** | The unique identifier of the hook. |  |
| **delivery_id** | **Integer** |  |  |

### Return type

[**WebhookDelivery**](WebhookDelivery.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/scim+json


## repos_list_autolinks

> <Array<AutolinkReference>> repos_list_autolinks(owner, repo, opts)

List all autolinks of a repository

This returns a list of autolinks configured for the given repository.  Information about autolinks are only available to repository administrators.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List all autolinks of a repository
  result = api_instance.repos_list_autolinks(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_autolinks: #{e}"
end
```

#### Using the repos_list_autolinks_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<AutolinkReference>>, Integer, Hash)> repos_list_autolinks_with_http_info(owner, repo, opts)

```ruby
begin
  # List all autolinks of a repository
  data, status_code, headers = api_instance.repos_list_autolinks_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<AutolinkReference>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_autolinks_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;AutolinkReference&gt;**](AutolinkReference.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_branches

> <Array<ShortBranch>> repos_list_branches(owner, repo, opts)

List branches



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  protected: true, # Boolean | Setting to `true` returns only protected branches. When set to `false`, only unprotected branches are returned. Omitting this parameter returns all branches.
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List branches
  result = api_instance.repos_list_branches(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_branches: #{e}"
end
```

#### Using the repos_list_branches_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<ShortBranch>>, Integer, Hash)> repos_list_branches_with_http_info(owner, repo, opts)

```ruby
begin
  # List branches
  data, status_code, headers = api_instance.repos_list_branches_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<ShortBranch>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_branches_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **protected** | **Boolean** | Setting to &#x60;true&#x60; returns only protected branches. When set to &#x60;false&#x60;, only unprotected branches are returned. Omitting this parameter returns all branches. | [optional] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;ShortBranch&gt;**](ShortBranch.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_branches_for_head_commit

> <Array<BranchShort>> repos_list_branches_for_head_commit(owner, repo, commit_sha)

List branches for HEAD commit

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Returns all branches where the given commit SHA is the HEAD, or latest commit for the branch.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
commit_sha = 'commit_sha_example' # String | The SHA of the commit.

begin
  # List branches for HEAD commit
  result = api_instance.repos_list_branches_for_head_commit(owner, repo, commit_sha)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_branches_for_head_commit: #{e}"
end
```

#### Using the repos_list_branches_for_head_commit_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<BranchShort>>, Integer, Hash)> repos_list_branches_for_head_commit_with_http_info(owner, repo, commit_sha)

```ruby
begin
  # List branches for HEAD commit
  data, status_code, headers = api_instance.repos_list_branches_for_head_commit_with_http_info(owner, repo, commit_sha)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<BranchShort>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_branches_for_head_commit_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **commit_sha** | **String** | The SHA of the commit. |  |

### Return type

[**Array&lt;BranchShort&gt;**](BranchShort.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_collaborators

> <Array<Collaborator>> repos_list_collaborators(owner, repo, opts)

List repository collaborators

For organization-owned repositories, the list of collaborators includes outside collaborators, organization members that are direct collaborators, organization members with access through team memberships, organization members with access through default organization permissions, and organization owners. Organization members with write, maintain, or admin privileges on the organization-owned repository can use this endpoint.  Team members will include the members of child teams.  You must authenticate using an access token with the `read:org` and `repo` scopes with push access to use this endpoint. GitHub Apps must have the `members` organization permission and `metadata` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  affiliation: 'outside', # String | Filter collaborators returned by their affiliation. `outside` means all outside collaborators of an organization-owned repository. `direct` means all collaborators with permissions to an organization-owned repository, regardless of organization membership status. `all` means all collaborators the authenticated user can see.
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List repository collaborators
  result = api_instance.repos_list_collaborators(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_collaborators: #{e}"
end
```

#### Using the repos_list_collaborators_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<Collaborator>>, Integer, Hash)> repos_list_collaborators_with_http_info(owner, repo, opts)

```ruby
begin
  # List repository collaborators
  data, status_code, headers = api_instance.repos_list_collaborators_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<Collaborator>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_collaborators_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **affiliation** | **String** | Filter collaborators returned by their affiliation. &#x60;outside&#x60; means all outside collaborators of an organization-owned repository. &#x60;direct&#x60; means all collaborators with permissions to an organization-owned repository, regardless of organization membership status. &#x60;all&#x60; means all collaborators the authenticated user can see. | [optional][default to &#39;all&#39;] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;Collaborator&gt;**](Collaborator.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_comments_for_commit

> <Array<CommitComment>> repos_list_comments_for_commit(owner, repo, commit_sha, opts)

List commit comments

Use the `:commit_sha` to specify the commit that will have its comments listed.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
commit_sha = 'commit_sha_example' # String | The SHA of the commit.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List commit comments
  result = api_instance.repos_list_comments_for_commit(owner, repo, commit_sha, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_comments_for_commit: #{e}"
end
```

#### Using the repos_list_comments_for_commit_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<CommitComment>>, Integer, Hash)> repos_list_comments_for_commit_with_http_info(owner, repo, commit_sha, opts)

```ruby
begin
  # List commit comments
  data, status_code, headers = api_instance.repos_list_comments_for_commit_with_http_info(owner, repo, commit_sha, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<CommitComment>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_comments_for_commit_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **commit_sha** | **String** | The SHA of the commit. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;CommitComment&gt;**](CommitComment.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_commit_comments_for_repo

> <Array<CommitComment>> repos_list_commit_comments_for_repo(owner, repo, opts)

List commit comments for a repository

Commit Comments use [these custom media types](https://docs.github.com/rest/reference/repos#custom-media-types). You can read more about the use of media types in the API [here](https://docs.github.com/rest/overview/media-types/).  Comments are ordered by ascending ID.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List commit comments for a repository
  result = api_instance.repos_list_commit_comments_for_repo(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_commit_comments_for_repo: #{e}"
end
```

#### Using the repos_list_commit_comments_for_repo_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<CommitComment>>, Integer, Hash)> repos_list_commit_comments_for_repo_with_http_info(owner, repo, opts)

```ruby
begin
  # List commit comments for a repository
  data, status_code, headers = api_instance.repos_list_commit_comments_for_repo_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<CommitComment>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_commit_comments_for_repo_with_http_info: #{e}"
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

[**Array&lt;CommitComment&gt;**](CommitComment.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_commit_statuses_for_ref

> <Array<Status>> repos_list_commit_statuses_for_ref(owner, repo, ref, opts)

List commit statuses for a reference

Users with pull access in a repository can view commit statuses for a given ref. The ref can be a SHA, a branch name, or a tag name. Statuses are returned in reverse chronological order. The first status in the list will be the latest one.  This resource is also available via a legacy route: `GET /repos/:owner/:repo/statuses/:ref`.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
ref = 'ref_example' # String | ref parameter
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List commit statuses for a reference
  result = api_instance.repos_list_commit_statuses_for_ref(owner, repo, ref, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_commit_statuses_for_ref: #{e}"
end
```

#### Using the repos_list_commit_statuses_for_ref_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<Status>>, Integer, Hash)> repos_list_commit_statuses_for_ref_with_http_info(owner, repo, ref, opts)

```ruby
begin
  # List commit statuses for a reference
  data, status_code, headers = api_instance.repos_list_commit_statuses_for_ref_with_http_info(owner, repo, ref, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<Status>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_commit_statuses_for_ref_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **ref** | **String** | ref parameter |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;Status&gt;**](Status.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_commits

> <Array<Commit>> repos_list_commits(owner, repo, opts)

List commits

**Signature verification object**  The response will include a `verification` object that describes the result of verifying the commit's signature. The following fields are included in the `verification` object:  | Name | Type | Description | | ---- | ---- | ----------- | | `verified` | `boolean` | Indicates whether GitHub considers the signature in this commit to be verified. | | `reason` | `string` | The reason for verified value. Possible values and their meanings are enumerated in table below. | | `signature` | `string` | The signature that was extracted from the commit. | | `payload` | `string` | The value that was signed. |  These are the possible values for `reason` in the `verification` object:  | Value | Description | | ----- | ----------- | | `expired_key` | The key that made the signature is expired. | | `not_signing_key` | The \"signing\" flag is not among the usage flags in the GPG key that made the signature. | | `gpgverify_error` | There was an error communicating with the signature verification service. | | `gpgverify_unavailable` | The signature verification service is currently unavailable. | | `unsigned` | The object does not include a signature. | | `unknown_signature_type` | A non-PGP signature was found in the commit. | | `no_user` | No user was associated with the `committer` email address in the commit. | | `unverified_email` | The `committer` email address in the commit was associated with a user, but the email address is not verified on her/his account. | | `bad_email` | The `committer` email address in the commit is not included in the identities of the PGP key that made the signature. | | `unknown_key` | The key that made the signature has not been registered with any user's account. | | `malformed_signature` | There was an error parsing the signature. | | `invalid` | The signature could not be cryptographically verified using the key whose key-id was found in the signature. | | `valid` | None of the above errors applied, so the signature is considered to be verified. |

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  sha: 'sha_example', # String | SHA or branch to start listing commits from. Default: the repository’s default branch (usually `master`).
  path: 'path_example', # String | Only commits containing this file path will be returned.
  author: 'author_example', # String | GitHub login or email address by which to filter by commit author.
  since: Time.parse('2013-10-20T19:20:30+01:00'), # Time | Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
  _until: Time.parse('2013-10-20T19:20:30+01:00'), # Time | Only commits before this date will be returned. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List commits
  result = api_instance.repos_list_commits(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_commits: #{e}"
end
```

#### Using the repos_list_commits_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<Commit>>, Integer, Hash)> repos_list_commits_with_http_info(owner, repo, opts)

```ruby
begin
  # List commits
  data, status_code, headers = api_instance.repos_list_commits_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<Commit>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_commits_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **sha** | **String** | SHA or branch to start listing commits from. Default: the repository’s default branch (usually &#x60;master&#x60;). | [optional] |
| **path** | **String** | Only commits containing this file path will be returned. | [optional] |
| **author** | **String** | GitHub login or email address by which to filter by commit author. | [optional] |
| **since** | **Time** | Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] |
| **_until** | **Time** | Only commits before this date will be returned. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;Commit&gt;**](Commit.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/scim+json


## repos_list_contributors

> <Array<Contributor>> repos_list_contributors(owner, repo, opts)

List repository contributors

Lists contributors to the specified repository and sorts them by the number of commits per contributor in descending order. This endpoint may return information that is a few hours old because the GitHub REST API v3 caches contributor data to improve performance.  GitHub identifies contributors by author email address. This endpoint groups contribution counts by GitHub user, which includes all associated email addresses. To improve performance, only the first 500 author email addresses in the repository link to GitHub users. The rest will appear as anonymous contributors without associated GitHub user information.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  anon: 'anon_example', # String | Set to `1` or `true` to include anonymous contributors in results.
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List repository contributors
  result = api_instance.repos_list_contributors(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_contributors: #{e}"
end
```

#### Using the repos_list_contributors_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<Contributor>>, Integer, Hash)> repos_list_contributors_with_http_info(owner, repo, opts)

```ruby
begin
  # List repository contributors
  data, status_code, headers = api_instance.repos_list_contributors_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<Contributor>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_contributors_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **anon** | **String** | Set to &#x60;1&#x60; or &#x60;true&#x60; to include anonymous contributors in results. | [optional] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;Contributor&gt;**](Contributor.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_deploy_keys

> <Array<DeployKey>> repos_list_deploy_keys(owner, repo, opts)

List deploy keys



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List deploy keys
  result = api_instance.repos_list_deploy_keys(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_deploy_keys: #{e}"
end
```

#### Using the repos_list_deploy_keys_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<DeployKey>>, Integer, Hash)> repos_list_deploy_keys_with_http_info(owner, repo, opts)

```ruby
begin
  # List deploy keys
  data, status_code, headers = api_instance.repos_list_deploy_keys_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<DeployKey>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_deploy_keys_with_http_info: #{e}"
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

[**Array&lt;DeployKey&gt;**](DeployKey.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_deployment_statuses

> <Array<DeploymentStatus>> repos_list_deployment_statuses(owner, repo, deployment_id, opts)

List deployment statuses

Users with pull access can view deployment statuses for a deployment:

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
deployment_id = 56 # Integer | deployment_id parameter
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List deployment statuses
  result = api_instance.repos_list_deployment_statuses(owner, repo, deployment_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_deployment_statuses: #{e}"
end
```

#### Using the repos_list_deployment_statuses_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<DeploymentStatus>>, Integer, Hash)> repos_list_deployment_statuses_with_http_info(owner, repo, deployment_id, opts)

```ruby
begin
  # List deployment statuses
  data, status_code, headers = api_instance.repos_list_deployment_statuses_with_http_info(owner, repo, deployment_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<DeploymentStatus>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_deployment_statuses_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **deployment_id** | **Integer** | deployment_id parameter |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;DeploymentStatus&gt;**](DeploymentStatus.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_deployments

> <Array<Deployment>> repos_list_deployments(owner, repo, opts)

List deployments

Simple filtering of deployments is available via query parameters:

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  sha: 'sha_example', # String | The SHA recorded at creation time.
  ref: 'ref_example', # String | The name of the ref. This can be a branch, tag, or SHA.
  task: 'task_example', # String | The name of the task for the deployment (e.g., `deploy` or `deploy:migrations`).
  environment: 'environment_example', # String | The name of the environment that was deployed to (e.g., `staging` or `production`).
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List deployments
  result = api_instance.repos_list_deployments(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_deployments: #{e}"
end
```

#### Using the repos_list_deployments_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<Deployment>>, Integer, Hash)> repos_list_deployments_with_http_info(owner, repo, opts)

```ruby
begin
  # List deployments
  data, status_code, headers = api_instance.repos_list_deployments_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<Deployment>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_deployments_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **sha** | **String** | The SHA recorded at creation time. | [optional][default to &#39;none&#39;] |
| **ref** | **String** | The name of the ref. This can be a branch, tag, or SHA. | [optional][default to &#39;none&#39;] |
| **task** | **String** | The name of the task for the deployment (e.g., &#x60;deploy&#x60; or &#x60;deploy:migrations&#x60;). | [optional][default to &#39;none&#39;] |
| **environment** | **String** | The name of the environment that was deployed to (e.g., &#x60;staging&#x60; or &#x60;production&#x60;). | [optional][default to &#39;none&#39;] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;Deployment&gt;**](Deployment.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_for_authenticated_user

> <Array<Repository>> repos_list_for_authenticated_user(opts)

List repositories for the authenticated user

Lists repositories that the authenticated user has explicit permission (`:read`, `:write`, or `:admin`) to access.  The authenticated user has explicit permission to access repositories they own, repositories where they are a collaborator, and repositories that they can access through an organization membership.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
opts = {
  visibility: 'all', # String | Limit results to repositories with the specified visibility.
  affiliation: 'affiliation_example', # String | Comma-separated list of values. Can include:   \\* `owner`: Repositories that are owned by the authenticated user.   \\* `collaborator`: Repositories that the user has been added to as a collaborator.   \\* `organization_member`: Repositories that the user has access to through being a member of an organization. This includes every repository on every team that the user is on.
  type: 'all', # String | Limit results to repositories of the specified type. Will cause a `422` error if used in the same request as **visibility** or **affiliation**.
  sort: 'created', # String | The property to sort the results by.
  direction: 'asc', # String | The order to sort by. Default: `asc` when using `full_name`, otherwise `desc`.
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56, # Integer | Page number of the results to fetch.
  since: Time.parse('2013-10-20T19:20:30+01:00'), # Time | Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
  before: Time.parse('2013-10-20T19:20:30+01:00') # Time | Only show notifications updated before the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
}

begin
  # List repositories for the authenticated user
  result = api_instance.repos_list_for_authenticated_user(opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_for_authenticated_user: #{e}"
end
```

#### Using the repos_list_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<Repository>>, Integer, Hash)> repos_list_for_authenticated_user_with_http_info(opts)

```ruby
begin
  # List repositories for the authenticated user
  data, status_code, headers = api_instance.repos_list_for_authenticated_user_with_http_info(opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<Repository>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **visibility** | **String** | Limit results to repositories with the specified visibility. | [optional][default to &#39;all&#39;] |
| **affiliation** | **String** | Comma-separated list of values. Can include:   \\* &#x60;owner&#x60;: Repositories that are owned by the authenticated user.   \\* &#x60;collaborator&#x60;: Repositories that the user has been added to as a collaborator.   \\* &#x60;organization_member&#x60;: Repositories that the user has access to through being a member of an organization. This includes every repository on every team that the user is on. | [optional][default to &#39;owner,collaborator,organization_member&#39;] |
| **type** | **String** | Limit results to repositories of the specified type. Will cause a &#x60;422&#x60; error if used in the same request as **visibility** or **affiliation**. | [optional][default to &#39;all&#39;] |
| **sort** | **String** | The property to sort the results by. | [optional][default to &#39;full_name&#39;] |
| **direction** | **String** | The order to sort by. Default: &#x60;asc&#x60; when using &#x60;full_name&#x60;, otherwise &#x60;desc&#x60;. | [optional] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |
| **since** | **Time** | Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] |
| **before** | **Time** | Only show notifications updated before the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] |

### Return type

[**Array&lt;Repository&gt;**](Repository.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_for_org

> <Array<MinimalRepository>> repos_list_for_org(org, opts)

List organization repositories

Lists repositories for the specified organization.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  type: 'all', # String | Specifies the types of repositories you want returned. If your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+, `type` can also be `internal`. However, the `internal` value is not yet supported when a GitHub App calls this API with an installation access token.
  sort: 'created', # String | The property to sort the results by.
  direction: 'asc', # String | The order to sort by. Default: `asc` when using `full_name`, otherwise `desc`.
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List organization repositories
  result = api_instance.repos_list_for_org(org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_for_org: #{e}"
end
```

#### Using the repos_list_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<MinimalRepository>>, Integer, Hash)> repos_list_for_org_with_http_info(org, opts)

```ruby
begin
  # List organization repositories
  data, status_code, headers = api_instance.repos_list_for_org_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<MinimalRepository>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **type** | **String** | Specifies the types of repositories you want returned. If your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+, &#x60;type&#x60; can also be &#x60;internal&#x60;. However, the &#x60;internal&#x60; value is not yet supported when a GitHub App calls this API with an installation access token. | [optional] |
| **sort** | **String** | The property to sort the results by. | [optional][default to &#39;created&#39;] |
| **direction** | **String** | The order to sort by. Default: &#x60;asc&#x60; when using &#x60;full_name&#x60;, otherwise &#x60;desc&#x60;. | [optional] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;MinimalRepository&gt;**](MinimalRepository.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_for_user

> <Array<MinimalRepository>> repos_list_for_user(username, opts)

List repositories for a user

Lists public repositories for the specified user. Note: For GitHub AE, this endpoint will list internal repositories for the specified user.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
username = 'username_example' # String | The handle for the GitHub user account.
opts = {
  type: 'all', # String | Limit results to repositories of the specified type.
  sort: 'created', # String | The property to sort the results by.
  direction: 'asc', # String | The order to sort by. Default: `asc` when using `full_name`, otherwise `desc`.
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List repositories for a user
  result = api_instance.repos_list_for_user(username, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_for_user: #{e}"
end
```

#### Using the repos_list_for_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<MinimalRepository>>, Integer, Hash)> repos_list_for_user_with_http_info(username, opts)

```ruby
begin
  # List repositories for a user
  data, status_code, headers = api_instance.repos_list_for_user_with_http_info(username, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<MinimalRepository>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_for_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **username** | **String** | The handle for the GitHub user account. |  |
| **type** | **String** | Limit results to repositories of the specified type. | [optional][default to &#39;owner&#39;] |
| **sort** | **String** | The property to sort the results by. | [optional][default to &#39;full_name&#39;] |
| **direction** | **String** | The order to sort by. Default: &#x60;asc&#x60; when using &#x60;full_name&#x60;, otherwise &#x60;desc&#x60;. | [optional] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;MinimalRepository&gt;**](MinimalRepository.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_forks

> <Array<MinimalRepository>> repos_list_forks(owner, repo, opts)

List forks



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  sort: 'newest', # String | The sort order. Can be either `newest`, `oldest`, or `stargazers`.
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List forks
  result = api_instance.repos_list_forks(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_forks: #{e}"
end
```

#### Using the repos_list_forks_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<MinimalRepository>>, Integer, Hash)> repos_list_forks_with_http_info(owner, repo, opts)

```ruby
begin
  # List forks
  data, status_code, headers = api_instance.repos_list_forks_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<MinimalRepository>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_forks_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **sort** | **String** | The sort order. Can be either &#x60;newest&#x60;, &#x60;oldest&#x60;, or &#x60;stargazers&#x60;. | [optional][default to &#39;newest&#39;] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;MinimalRepository&gt;**](MinimalRepository.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/scim+json


## repos_list_invitations

> <Array<RepositoryInvitation>> repos_list_invitations(owner, repo, opts)

List repository invitations

When authenticating as a user with admin rights to a repository, this endpoint will list all currently open repository invitations.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List repository invitations
  result = api_instance.repos_list_invitations(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_invitations: #{e}"
end
```

#### Using the repos_list_invitations_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<RepositoryInvitation>>, Integer, Hash)> repos_list_invitations_with_http_info(owner, repo, opts)

```ruby
begin
  # List repository invitations
  data, status_code, headers = api_instance.repos_list_invitations_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<RepositoryInvitation>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_invitations_with_http_info: #{e}"
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

[**Array&lt;RepositoryInvitation&gt;**](RepositoryInvitation.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_invitations_for_authenticated_user

> <Array<RepositoryInvitation>> repos_list_invitations_for_authenticated_user(opts)

List repository invitations for the authenticated user

When authenticating as a user, this endpoint will list all currently open repository invitations for that user.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List repository invitations for the authenticated user
  result = api_instance.repos_list_invitations_for_authenticated_user(opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_invitations_for_authenticated_user: #{e}"
end
```

#### Using the repos_list_invitations_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<RepositoryInvitation>>, Integer, Hash)> repos_list_invitations_for_authenticated_user_with_http_info(opts)

```ruby
begin
  # List repository invitations for the authenticated user
  data, status_code, headers = api_instance.repos_list_invitations_for_authenticated_user_with_http_info(opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<RepositoryInvitation>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_invitations_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;RepositoryInvitation&gt;**](RepositoryInvitation.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_languages

> Hash&lt;String, Integer&gt; repos_list_languages(owner, repo)

List repository languages

Lists languages for the specified repository. The value shown for each language is the number of bytes of code written in that language.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # List repository languages
  result = api_instance.repos_list_languages(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_languages: #{e}"
end
```

#### Using the repos_list_languages_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Hash&lt;String, Integer&gt;, Integer, Hash)> repos_list_languages_with_http_info(owner, repo)

```ruby
begin
  # List repository languages
  data, status_code, headers = api_instance.repos_list_languages_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Hash&lt;String, Integer&gt;
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_languages_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

**Hash&lt;String, Integer&gt;**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_pages_builds

> <Array<PageBuild>> repos_list_pages_builds(owner, repo, opts)

List GitHub Pages builds



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List GitHub Pages builds
  result = api_instance.repos_list_pages_builds(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_pages_builds: #{e}"
end
```

#### Using the repos_list_pages_builds_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<PageBuild>>, Integer, Hash)> repos_list_pages_builds_with_http_info(owner, repo, opts)

```ruby
begin
  # List GitHub Pages builds
  data, status_code, headers = api_instance.repos_list_pages_builds_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<PageBuild>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_pages_builds_with_http_info: #{e}"
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

[**Array&lt;PageBuild&gt;**](PageBuild.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_public

> <Array<MinimalRepository>> repos_list_public(opts)

List public repositories

Lists all public repositories in the order that they were created.  Note: - For GitHub Enterprise Server, this endpoint will only list repositories available to all users on the enterprise. - Pagination is powered exclusively by the `since` parameter. Use the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header) to get the URL for the next page of repositories.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
opts = {
  since: 56 # Integer | A repository ID. Only return repositories with an ID greater than this ID.
}

begin
  # List public repositories
  result = api_instance.repos_list_public(opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_public: #{e}"
end
```

#### Using the repos_list_public_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<MinimalRepository>>, Integer, Hash)> repos_list_public_with_http_info(opts)

```ruby
begin
  # List public repositories
  data, status_code, headers = api_instance.repos_list_public_with_http_info(opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<MinimalRepository>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_public_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **since** | **Integer** | A repository ID. Only return repositories with an ID greater than this ID. | [optional] |

### Return type

[**Array&lt;MinimalRepository&gt;**](MinimalRepository.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_pull_requests_associated_with_commit

> <Array<PullRequestSimple>> repos_list_pull_requests_associated_with_commit(owner, repo, commit_sha, opts)

List pull requests associated with a commit

Lists the merged pull request that introduced the commit to the repository. If the commit is not present in the default branch, additionally returns open pull requests associated with the commit. The results may include open and closed pull requests.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
commit_sha = 'commit_sha_example' # String | The SHA of the commit.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List pull requests associated with a commit
  result = api_instance.repos_list_pull_requests_associated_with_commit(owner, repo, commit_sha, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_pull_requests_associated_with_commit: #{e}"
end
```

#### Using the repos_list_pull_requests_associated_with_commit_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<PullRequestSimple>>, Integer, Hash)> repos_list_pull_requests_associated_with_commit_with_http_info(owner, repo, commit_sha, opts)

```ruby
begin
  # List pull requests associated with a commit
  data, status_code, headers = api_instance.repos_list_pull_requests_associated_with_commit_with_http_info(owner, repo, commit_sha, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<PullRequestSimple>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_pull_requests_associated_with_commit_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **commit_sha** | **String** | The SHA of the commit. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;PullRequestSimple&gt;**](PullRequestSimple.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_release_assets

> <Array<ReleaseAsset>> repos_list_release_assets(owner, repo, release_id, opts)

List release assets



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
release_id = 56 # Integer | The unique identifier of the release.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List release assets
  result = api_instance.repos_list_release_assets(owner, repo, release_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_release_assets: #{e}"
end
```

#### Using the repos_list_release_assets_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<ReleaseAsset>>, Integer, Hash)> repos_list_release_assets_with_http_info(owner, repo, release_id, opts)

```ruby
begin
  # List release assets
  data, status_code, headers = api_instance.repos_list_release_assets_with_http_info(owner, repo, release_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<ReleaseAsset>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_release_assets_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **release_id** | **Integer** | The unique identifier of the release. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;ReleaseAsset&gt;**](ReleaseAsset.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_releases

> <Array<Release>> repos_list_releases(owner, repo, opts)

List releases

This returns a list of releases, which does not include regular Git tags that have not been associated with a release. To get a list of Git tags, use the [Repository Tags API](https://docs.github.com/rest/reference/repos#list-repository-tags).  Information about published releases are available to everyone. Only users with push access will receive listings for draft releases.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List releases
  result = api_instance.repos_list_releases(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_releases: #{e}"
end
```

#### Using the repos_list_releases_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<Release>>, Integer, Hash)> repos_list_releases_with_http_info(owner, repo, opts)

```ruby
begin
  # List releases
  data, status_code, headers = api_instance.repos_list_releases_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<Release>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_releases_with_http_info: #{e}"
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

[**Array&lt;Release&gt;**](Release.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_tag_protection

> <Array<TagProtection>> repos_list_tag_protection(owner, repo)

List tag protection states for a repository

This returns the tag protection states of a repository.  This information is only available to repository administrators.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # List tag protection states for a repository
  result = api_instance.repos_list_tag_protection(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_tag_protection: #{e}"
end
```

#### Using the repos_list_tag_protection_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<TagProtection>>, Integer, Hash)> repos_list_tag_protection_with_http_info(owner, repo)

```ruby
begin
  # List tag protection states for a repository
  data, status_code, headers = api_instance.repos_list_tag_protection_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<TagProtection>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_tag_protection_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**Array&lt;TagProtection&gt;**](TagProtection.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_tags

> <Array<Tag>> repos_list_tags(owner, repo, opts)

List repository tags



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List repository tags
  result = api_instance.repos_list_tags(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_tags: #{e}"
end
```

#### Using the repos_list_tags_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<Tag>>, Integer, Hash)> repos_list_tags_with_http_info(owner, repo, opts)

```ruby
begin
  # List repository tags
  data, status_code, headers = api_instance.repos_list_tags_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<Tag>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_tags_with_http_info: #{e}"
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

[**Array&lt;Tag&gt;**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_teams

> <Array<Team>> repos_list_teams(owner, repo, opts)

List repository teams



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List repository teams
  result = api_instance.repos_list_teams(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_teams: #{e}"
end
```

#### Using the repos_list_teams_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<Team>>, Integer, Hash)> repos_list_teams_with_http_info(owner, repo, opts)

```ruby
begin
  # List repository teams
  data, status_code, headers = api_instance.repos_list_teams_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<Team>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_teams_with_http_info: #{e}"
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

[**Array&lt;Team&gt;**](Team.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_list_webhook_deliveries

> <Array<SimpleWebhookDelivery>> repos_list_webhook_deliveries(owner, repo, hook_id, opts)

List deliveries for a repository webhook

Returns a list of webhook deliveries for a webhook configured in a repository.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
hook_id = 56 # Integer | The unique identifier of the hook.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  cursor: 'cursor_example' # String | Used for pagination: the starting delivery from which the page of deliveries is fetched. Refer to the `link` header for the next and previous page cursors.
}

begin
  # List deliveries for a repository webhook
  result = api_instance.repos_list_webhook_deliveries(owner, repo, hook_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_webhook_deliveries: #{e}"
end
```

#### Using the repos_list_webhook_deliveries_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<SimpleWebhookDelivery>>, Integer, Hash)> repos_list_webhook_deliveries_with_http_info(owner, repo, hook_id, opts)

```ruby
begin
  # List deliveries for a repository webhook
  data, status_code, headers = api_instance.repos_list_webhook_deliveries_with_http_info(owner, repo, hook_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<SimpleWebhookDelivery>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_webhook_deliveries_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **hook_id** | **Integer** | The unique identifier of the hook. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **cursor** | **String** | Used for pagination: the starting delivery from which the page of deliveries is fetched. Refer to the &#x60;link&#x60; header for the next and previous page cursors. | [optional] |

### Return type

[**Array&lt;SimpleWebhookDelivery&gt;**](SimpleWebhookDelivery.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/scim+json


## repos_list_webhooks

> <Array<Webhook>> repos_list_webhooks(owner, repo, opts)

List repository webhooks



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List repository webhooks
  result = api_instance.repos_list_webhooks(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_webhooks: #{e}"
end
```

#### Using the repos_list_webhooks_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<Webhook>>, Integer, Hash)> repos_list_webhooks_with_http_info(owner, repo, opts)

```ruby
begin
  # List repository webhooks
  data, status_code, headers = api_instance.repos_list_webhooks_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<Webhook>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_list_webhooks_with_http_info: #{e}"
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

[**Array&lt;Webhook&gt;**](Webhook.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_merge

> <Commit> repos_merge(owner, repo, repos_merge_request)

Merge a branch



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
repos_merge_request = OpenapiClient::ReposMergeRequest.new({base: 'base_example', head: 'head_example'}) # ReposMergeRequest | 

begin
  # Merge a branch
  result = api_instance.repos_merge(owner, repo, repos_merge_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_merge: #{e}"
end
```

#### Using the repos_merge_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Commit>, Integer, Hash)> repos_merge_with_http_info(owner, repo, repos_merge_request)

```ruby
begin
  # Merge a branch
  data, status_code, headers = api_instance.repos_merge_with_http_info(owner, repo, repos_merge_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Commit>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_merge_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **repos_merge_request** | [**ReposMergeRequest**](ReposMergeRequest.md) |  |  |

### Return type

[**Commit**](Commit.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_merge_upstream

> <MergedUpstream> repos_merge_upstream(owner, repo, repos_merge_upstream_request)

Sync a fork branch with the upstream repository

Sync a branch of a forked repository to keep it up-to-date with the upstream repository.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
repos_merge_upstream_request = OpenapiClient::ReposMergeUpstreamRequest.new({branch: 'branch_example'}) # ReposMergeUpstreamRequest | 

begin
  # Sync a fork branch with the upstream repository
  result = api_instance.repos_merge_upstream(owner, repo, repos_merge_upstream_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_merge_upstream: #{e}"
end
```

#### Using the repos_merge_upstream_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<MergedUpstream>, Integer, Hash)> repos_merge_upstream_with_http_info(owner, repo, repos_merge_upstream_request)

```ruby
begin
  # Sync a fork branch with the upstream repository
  data, status_code, headers = api_instance.repos_merge_upstream_with_http_info(owner, repo, repos_merge_upstream_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <MergedUpstream>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_merge_upstream_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **repos_merge_upstream_request** | [**ReposMergeUpstreamRequest**](ReposMergeUpstreamRequest.md) |  |  |

### Return type

[**MergedUpstream**](MergedUpstream.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_ping_webhook

> repos_ping_webhook(owner, repo, hook_id)

Ping a repository webhook

This will trigger a [ping event](https://docs.github.com/webhooks/#ping-event) to be sent to the hook.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
hook_id = 56 # Integer | The unique identifier of the hook.

begin
  # Ping a repository webhook
  api_instance.repos_ping_webhook(owner, repo, hook_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_ping_webhook: #{e}"
end
```

#### Using the repos_ping_webhook_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_ping_webhook_with_http_info(owner, repo, hook_id)

```ruby
begin
  # Ping a repository webhook
  data, status_code, headers = api_instance.repos_ping_webhook_with_http_info(owner, repo, hook_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_ping_webhook_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **hook_id** | **Integer** | The unique identifier of the hook. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_redeliver_webhook_delivery

> Object repos_redeliver_webhook_delivery(owner, repo, hook_id, delivery_id)

Redeliver a delivery for a repository webhook

Redeliver a webhook delivery for a webhook configured in a repository.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
hook_id = 56 # Integer | The unique identifier of the hook.
delivery_id = 56 # Integer | 

begin
  # Redeliver a delivery for a repository webhook
  result = api_instance.repos_redeliver_webhook_delivery(owner, repo, hook_id, delivery_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_redeliver_webhook_delivery: #{e}"
end
```

#### Using the repos_redeliver_webhook_delivery_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Object, Integer, Hash)> repos_redeliver_webhook_delivery_with_http_info(owner, repo, hook_id, delivery_id)

```ruby
begin
  # Redeliver a delivery for a repository webhook
  data, status_code, headers = api_instance.repos_redeliver_webhook_delivery_with_http_info(owner, repo, hook_id, delivery_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Object
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_redeliver_webhook_delivery_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **hook_id** | **Integer** | The unique identifier of the hook. |  |
| **delivery_id** | **Integer** |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/scim+json


## repos_remove_app_access_restrictions

> <Array<GitHubApp>> repos_remove_app_access_restrictions(owner, repo, branch, opts)

Remove app access restrictions

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Removes the ability of an app to push to this branch. Only installed GitHub Apps with `write` access to the `contents` permission can be added as authorized actors on a protected branch.  | Type    | Description                                                                                                                                                | | ------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- | | `array` | The GitHub Apps that have push access to this branch. Use the app's `slug`. **Note**: The list of users, apps, and teams in total is limited to 100 items. |

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.
opts = {
  repos_set_app_access_restrictions_request: nil # ReposSetAppAccessRestrictionsRequest | 
}

begin
  # Remove app access restrictions
  result = api_instance.repos_remove_app_access_restrictions(owner, repo, branch, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_remove_app_access_restrictions: #{e}"
end
```

#### Using the repos_remove_app_access_restrictions_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<GitHubApp>>, Integer, Hash)> repos_remove_app_access_restrictions_with_http_info(owner, repo, branch, opts)

```ruby
begin
  # Remove app access restrictions
  data, status_code, headers = api_instance.repos_remove_app_access_restrictions_with_http_info(owner, repo, branch, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<GitHubApp>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_remove_app_access_restrictions_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |
| **repos_set_app_access_restrictions_request** | [**ReposSetAppAccessRestrictionsRequest**](ReposSetAppAccessRestrictionsRequest.md) |  | [optional] |

### Return type

[**Array&lt;GitHubApp&gt;**](GitHubApp.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_remove_collaborator

> repos_remove_collaborator(owner, repo, username)

Remove a repository collaborator



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
username = 'username_example' # String | The handle for the GitHub user account.

begin
  # Remove a repository collaborator
  api_instance.repos_remove_collaborator(owner, repo, username)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_remove_collaborator: #{e}"
end
```

#### Using the repos_remove_collaborator_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_remove_collaborator_with_http_info(owner, repo, username)

```ruby
begin
  # Remove a repository collaborator
  data, status_code, headers = api_instance.repos_remove_collaborator_with_http_info(owner, repo, username)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_remove_collaborator_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **username** | **String** | The handle for the GitHub user account. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## repos_remove_status_check_contexts

> Array&lt;String&gt; repos_remove_status_check_contexts(owner, repo, branch, opts)

Remove status check contexts

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.
opts = {
  repos_set_status_check_contexts_request: nil # ReposSetStatusCheckContextsRequest | 
}

begin
  # Remove status check contexts
  result = api_instance.repos_remove_status_check_contexts(owner, repo, branch, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_remove_status_check_contexts: #{e}"
end
```

#### Using the repos_remove_status_check_contexts_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Array&lt;String&gt;, Integer, Hash)> repos_remove_status_check_contexts_with_http_info(owner, repo, branch, opts)

```ruby
begin
  # Remove status check contexts
  data, status_code, headers = api_instance.repos_remove_status_check_contexts_with_http_info(owner, repo, branch, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Array&lt;String&gt;
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_remove_status_check_contexts_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |
| **repos_set_status_check_contexts_request** | [**ReposSetStatusCheckContextsRequest**](ReposSetStatusCheckContextsRequest.md) |  | [optional] |

### Return type

**Array&lt;String&gt;**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_remove_status_check_protection

> repos_remove_status_check_protection(owner, repo, branch)

Remove status check protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.

begin
  # Remove status check protection
  api_instance.repos_remove_status_check_protection(owner, repo, branch)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_remove_status_check_protection: #{e}"
end
```

#### Using the repos_remove_status_check_protection_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_remove_status_check_protection_with_http_info(owner, repo, branch)

```ruby
begin
  # Remove status check protection
  data, status_code, headers = api_instance.repos_remove_status_check_protection_with_http_info(owner, repo, branch)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_remove_status_check_protection_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## repos_remove_team_access_restrictions

> <Array<Team>> repos_remove_team_access_restrictions(owner, repo, branch, opts)

Remove team access restrictions

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Removes the ability of a team to push to this branch. You can also remove push access for child teams.  | Type    | Description                                                                                                                                         | | ------- | --------------------------------------------------------------------------------------------------------------------------------------------------- | | `array` | Teams that should no longer have push access. Use the team's `slug`. **Note**: The list of users, apps, and teams in total is limited to 100 items. |

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.
opts = {
  repos_set_team_access_restrictions_request: nil # ReposSetTeamAccessRestrictionsRequest | 
}

begin
  # Remove team access restrictions
  result = api_instance.repos_remove_team_access_restrictions(owner, repo, branch, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_remove_team_access_restrictions: #{e}"
end
```

#### Using the repos_remove_team_access_restrictions_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<Team>>, Integer, Hash)> repos_remove_team_access_restrictions_with_http_info(owner, repo, branch, opts)

```ruby
begin
  # Remove team access restrictions
  data, status_code, headers = api_instance.repos_remove_team_access_restrictions_with_http_info(owner, repo, branch, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<Team>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_remove_team_access_restrictions_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |
| **repos_set_team_access_restrictions_request** | [**ReposSetTeamAccessRestrictionsRequest**](ReposSetTeamAccessRestrictionsRequest.md) |  | [optional] |

### Return type

[**Array&lt;Team&gt;**](Team.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_remove_user_access_restrictions

> <Array<SimpleUser1>> repos_remove_user_access_restrictions(owner, repo, branch, opts)

Remove user access restrictions

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Removes the ability of a user to push to this branch.  | Type    | Description                                                                                                                                   | | ------- | --------------------------------------------------------------------------------------------------------------------------------------------- | | `array` | Usernames of the people who should no longer have push access. **Note**: The list of users, apps, and teams in total is limited to 100 items. |

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.
opts = {
  repos_set_user_access_restrictions_request: nil # ReposSetUserAccessRestrictionsRequest | 
}

begin
  # Remove user access restrictions
  result = api_instance.repos_remove_user_access_restrictions(owner, repo, branch, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_remove_user_access_restrictions: #{e}"
end
```

#### Using the repos_remove_user_access_restrictions_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<SimpleUser1>>, Integer, Hash)> repos_remove_user_access_restrictions_with_http_info(owner, repo, branch, opts)

```ruby
begin
  # Remove user access restrictions
  data, status_code, headers = api_instance.repos_remove_user_access_restrictions_with_http_info(owner, repo, branch, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<SimpleUser1>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_remove_user_access_restrictions_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |
| **repos_set_user_access_restrictions_request** | [**ReposSetUserAccessRestrictionsRequest**](ReposSetUserAccessRestrictionsRequest.md) |  | [optional] |

### Return type

[**Array&lt;SimpleUser1&gt;**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_rename_branch

> <BranchWithProtection> repos_rename_branch(owner, repo, branch, repos_rename_branch_request)

Rename a branch

Renames a branch in a repository.  **Note:** Although the API responds immediately, the branch rename process might take some extra time to complete in the background. You won't be able to push to the old branch name while the rename process is in progress. For more information, see \"[Renaming a branch](https://docs.github.com/github/administering-a-repository/renaming-a-branch)\".  The permissions required to use this endpoint depends on whether you are renaming the default branch.  To rename a non-default branch:  * Users must have push access. * GitHub Apps must have the `contents:write` repository permission.  To rename the default branch:  * Users must have admin or owner permissions. * GitHub Apps must have the `administration:write` repository permission.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.
repos_rename_branch_request = OpenapiClient::ReposRenameBranchRequest.new({new_name: 'new_name_example'}) # ReposRenameBranchRequest | 

begin
  # Rename a branch
  result = api_instance.repos_rename_branch(owner, repo, branch, repos_rename_branch_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_rename_branch: #{e}"
end
```

#### Using the repos_rename_branch_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<BranchWithProtection>, Integer, Hash)> repos_rename_branch_with_http_info(owner, repo, branch, repos_rename_branch_request)

```ruby
begin
  # Rename a branch
  data, status_code, headers = api_instance.repos_rename_branch_with_http_info(owner, repo, branch, repos_rename_branch_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <BranchWithProtection>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_rename_branch_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |
| **repos_rename_branch_request** | [**ReposRenameBranchRequest**](ReposRenameBranchRequest.md) |  |  |

### Return type

[**BranchWithProtection**](BranchWithProtection.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_replace_all_topics

> <Topic> repos_replace_all_topics(owner, repo, repos_replace_all_topics_request)

Replace all repository topics



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
repos_replace_all_topics_request = OpenapiClient::ReposReplaceAllTopicsRequest.new({names: ['names_example']}) # ReposReplaceAllTopicsRequest | 

begin
  # Replace all repository topics
  result = api_instance.repos_replace_all_topics(owner, repo, repos_replace_all_topics_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_replace_all_topics: #{e}"
end
```

#### Using the repos_replace_all_topics_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Topic>, Integer, Hash)> repos_replace_all_topics_with_http_info(owner, repo, repos_replace_all_topics_request)

```ruby
begin
  # Replace all repository topics
  data, status_code, headers = api_instance.repos_replace_all_topics_with_http_info(owner, repo, repos_replace_all_topics_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Topic>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_replace_all_topics_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **repos_replace_all_topics_request** | [**ReposReplaceAllTopicsRequest**](ReposReplaceAllTopicsRequest.md) |  |  |

### Return type

[**Topic**](Topic.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_request_pages_build

> <PageBuildStatus> repos_request_pages_build(owner, repo)

Request a GitHub Pages build

You can request that your site be built from the latest revision on the default branch. This has the same effect as pushing a commit to your default branch, but does not require an additional commit. Manually triggering page builds can be helpful when diagnosing build warnings and failures.  Build requests are limited to one concurrent build per repository and one concurrent build per requester. If you request a build while another is still in progress, the second request will be queued until the first completes.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Request a GitHub Pages build
  result = api_instance.repos_request_pages_build(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_request_pages_build: #{e}"
end
```

#### Using the repos_request_pages_build_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<PageBuildStatus>, Integer, Hash)> repos_request_pages_build_with_http_info(owner, repo)

```ruby
begin
  # Request a GitHub Pages build
  data, status_code, headers = api_instance.repos_request_pages_build_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <PageBuildStatus>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_request_pages_build_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**PageBuildStatus**](PageBuildStatus.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_set_admin_branch_protection

> <ProtectedBranchAdminEnforced> repos_set_admin_branch_protection(owner, repo, branch)

Set admin branch protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Adding admin enforcement requires admin or owner permissions to the repository and branch protection to be enabled.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.

begin
  # Set admin branch protection
  result = api_instance.repos_set_admin_branch_protection(owner, repo, branch)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_set_admin_branch_protection: #{e}"
end
```

#### Using the repos_set_admin_branch_protection_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ProtectedBranchAdminEnforced>, Integer, Hash)> repos_set_admin_branch_protection_with_http_info(owner, repo, branch)

```ruby
begin
  # Set admin branch protection
  data, status_code, headers = api_instance.repos_set_admin_branch_protection_with_http_info(owner, repo, branch)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ProtectedBranchAdminEnforced>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_set_admin_branch_protection_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |

### Return type

[**ProtectedBranchAdminEnforced**](ProtectedBranchAdminEnforced.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_set_app_access_restrictions

> <Array<GitHubApp>> repos_set_app_access_restrictions(owner, repo, branch, opts)

Set app access restrictions

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Replaces the list of apps that have push access to this branch. This removes all apps that previously had push access and grants push access to the new list of apps. Only installed GitHub Apps with `write` access to the `contents` permission can be added as authorized actors on a protected branch.  | Type    | Description                                                                                                                                                | | ------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- | | `array` | The GitHub Apps that have push access to this branch. Use the app's `slug`. **Note**: The list of users, apps, and teams in total is limited to 100 items. |

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.
opts = {
  repos_set_app_access_restrictions_request: nil # ReposSetAppAccessRestrictionsRequest | 
}

begin
  # Set app access restrictions
  result = api_instance.repos_set_app_access_restrictions(owner, repo, branch, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_set_app_access_restrictions: #{e}"
end
```

#### Using the repos_set_app_access_restrictions_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<GitHubApp>>, Integer, Hash)> repos_set_app_access_restrictions_with_http_info(owner, repo, branch, opts)

```ruby
begin
  # Set app access restrictions
  data, status_code, headers = api_instance.repos_set_app_access_restrictions_with_http_info(owner, repo, branch, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<GitHubApp>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_set_app_access_restrictions_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |
| **repos_set_app_access_restrictions_request** | [**ReposSetAppAccessRestrictionsRequest**](ReposSetAppAccessRestrictionsRequest.md) |  | [optional] |

### Return type

[**Array&lt;GitHubApp&gt;**](GitHubApp.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_set_status_check_contexts

> Array&lt;String&gt; repos_set_status_check_contexts(owner, repo, branch, opts)

Set status check contexts

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.
opts = {
  repos_set_status_check_contexts_request: nil # ReposSetStatusCheckContextsRequest | 
}

begin
  # Set status check contexts
  result = api_instance.repos_set_status_check_contexts(owner, repo, branch, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_set_status_check_contexts: #{e}"
end
```

#### Using the repos_set_status_check_contexts_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Array&lt;String&gt;, Integer, Hash)> repos_set_status_check_contexts_with_http_info(owner, repo, branch, opts)

```ruby
begin
  # Set status check contexts
  data, status_code, headers = api_instance.repos_set_status_check_contexts_with_http_info(owner, repo, branch, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Array&lt;String&gt;
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_set_status_check_contexts_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |
| **repos_set_status_check_contexts_request** | [**ReposSetStatusCheckContextsRequest**](ReposSetStatusCheckContextsRequest.md) |  | [optional] |

### Return type

**Array&lt;String&gt;**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_set_team_access_restrictions

> <Array<Team>> repos_set_team_access_restrictions(owner, repo, branch, opts)

Set team access restrictions

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Replaces the list of teams that have push access to this branch. This removes all teams that previously had push access and grants push access to the new list of teams. Team restrictions include child teams.  | Type    | Description                                                                                                                                | | ------- | ------------------------------------------------------------------------------------------------------------------------------------------ | | `array` | The teams that can have push access. Use the team's `slug`. **Note**: The list of users, apps, and teams in total is limited to 100 items. |

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.
opts = {
  repos_set_team_access_restrictions_request: nil # ReposSetTeamAccessRestrictionsRequest | 
}

begin
  # Set team access restrictions
  result = api_instance.repos_set_team_access_restrictions(owner, repo, branch, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_set_team_access_restrictions: #{e}"
end
```

#### Using the repos_set_team_access_restrictions_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<Team>>, Integer, Hash)> repos_set_team_access_restrictions_with_http_info(owner, repo, branch, opts)

```ruby
begin
  # Set team access restrictions
  data, status_code, headers = api_instance.repos_set_team_access_restrictions_with_http_info(owner, repo, branch, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<Team>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_set_team_access_restrictions_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |
| **repos_set_team_access_restrictions_request** | [**ReposSetTeamAccessRestrictionsRequest**](ReposSetTeamAccessRestrictionsRequest.md) |  | [optional] |

### Return type

[**Array&lt;Team&gt;**](Team.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_set_user_access_restrictions

> <Array<SimpleUser1>> repos_set_user_access_restrictions(owner, repo, branch, opts)

Set user access restrictions

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Replaces the list of people that have push access to this branch. This removes all people that previously had push access and grants push access to the new list of people.  | Type    | Description                                                                                                                   | | ------- | ----------------------------------------------------------------------------------------------------------------------------- | | `array` | Usernames for people who can have push access. **Note**: The list of users, apps, and teams in total is limited to 100 items. |

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.
opts = {
  repos_set_user_access_restrictions_request: nil # ReposSetUserAccessRestrictionsRequest | 
}

begin
  # Set user access restrictions
  result = api_instance.repos_set_user_access_restrictions(owner, repo, branch, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_set_user_access_restrictions: #{e}"
end
```

#### Using the repos_set_user_access_restrictions_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<SimpleUser1>>, Integer, Hash)> repos_set_user_access_restrictions_with_http_info(owner, repo, branch, opts)

```ruby
begin
  # Set user access restrictions
  data, status_code, headers = api_instance.repos_set_user_access_restrictions_with_http_info(owner, repo, branch, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<SimpleUser1>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_set_user_access_restrictions_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |
| **repos_set_user_access_restrictions_request** | [**ReposSetUserAccessRestrictionsRequest**](ReposSetUserAccessRestrictionsRequest.md) |  | [optional] |

### Return type

[**Array&lt;SimpleUser1&gt;**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_test_push_webhook

> repos_test_push_webhook(owner, repo, hook_id)

Test the push repository webhook

This will trigger the hook with the latest push to the current repository if the hook is subscribed to `push` events. If the hook is not subscribed to `push` events, the server will respond with 204 but no test POST will be generated.  **Note**: Previously `/repos/:owner/:repo/hooks/:hook_id/test`

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
hook_id = 56 # Integer | The unique identifier of the hook.

begin
  # Test the push repository webhook
  api_instance.repos_test_push_webhook(owner, repo, hook_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_test_push_webhook: #{e}"
end
```

#### Using the repos_test_push_webhook_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_test_push_webhook_with_http_info(owner, repo, hook_id)

```ruby
begin
  # Test the push repository webhook
  data, status_code, headers = api_instance.repos_test_push_webhook_with_http_info(owner, repo, hook_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_test_push_webhook_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **hook_id** | **Integer** | The unique identifier of the hook. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## repos_transfer

> <MinimalRepository> repos_transfer(owner, repo, repos_transfer_request)

Transfer a repository

A transfer request will need to be accepted by the new owner when transferring a personal repository to another user. The response will contain the original `owner`, and the transfer will continue asynchronously. For more details on the requirements to transfer personal and organization-owned repositories, see [about repository transfers](https://docs.github.com/articles/about-repository-transfers/).

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
repos_transfer_request = OpenapiClient::ReposTransferRequest.new({new_owner: 'new_owner_example'}) # ReposTransferRequest | 

begin
  # Transfer a repository
  result = api_instance.repos_transfer(owner, repo, repos_transfer_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_transfer: #{e}"
end
```

#### Using the repos_transfer_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<MinimalRepository>, Integer, Hash)> repos_transfer_with_http_info(owner, repo, repos_transfer_request)

```ruby
begin
  # Transfer a repository
  data, status_code, headers = api_instance.repos_transfer_with_http_info(owner, repo, repos_transfer_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <MinimalRepository>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_transfer_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **repos_transfer_request** | [**ReposTransferRequest**](ReposTransferRequest.md) |  |  |

### Return type

[**MinimalRepository**](MinimalRepository.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_update

> <FullRepository> repos_update(owner, repo, opts)

Update a repository

**Note**: To edit a repository's topics, use the [Replace all repository topics](https://docs.github.com/rest/reference/repos#replace-all-repository-topics) endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  repos_update_request: OpenapiClient::ReposUpdateRequest.new # ReposUpdateRequest | 
}

begin
  # Update a repository
  result = api_instance.repos_update(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_update: #{e}"
end
```

#### Using the repos_update_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<FullRepository>, Integer, Hash)> repos_update_with_http_info(owner, repo, opts)

```ruby
begin
  # Update a repository
  data, status_code, headers = api_instance.repos_update_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <FullRepository>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_update_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **repos_update_request** | [**ReposUpdateRequest**](ReposUpdateRequest.md) |  | [optional] |

### Return type

[**FullRepository**](FullRepository.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_update_branch_protection

> <ProtectedBranch> repos_update_branch_protection(owner, repo, branch, repos_update_branch_protection_request)

Update branch protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Protecting a branch requires admin or owner permissions to the repository.  **Note**: Passing new arrays of `users` and `teams` replaces their previous values.  **Note**: The list of users, apps, and teams in total is limited to 100 items.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.
repos_update_branch_protection_request = OpenapiClient::ReposUpdateBranchProtectionRequest.new({required_status_checks: OpenapiClient::ReposUpdateBranchProtectionRequestRequiredStatusChecks.new({strict: false, contexts: ['contexts_example']}), enforce_admins: false, required_pull_request_reviews: OpenapiClient::ReposUpdateBranchProtectionRequestRequiredPullRequestReviews.new, restrictions: OpenapiClient::ReposUpdateBranchProtectionRequestRestrictions.new({users: ['users_example'], teams: ['teams_example']})}) # ReposUpdateBranchProtectionRequest | 

begin
  # Update branch protection
  result = api_instance.repos_update_branch_protection(owner, repo, branch, repos_update_branch_protection_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_update_branch_protection: #{e}"
end
```

#### Using the repos_update_branch_protection_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ProtectedBranch>, Integer, Hash)> repos_update_branch_protection_with_http_info(owner, repo, branch, repos_update_branch_protection_request)

```ruby
begin
  # Update branch protection
  data, status_code, headers = api_instance.repos_update_branch_protection_with_http_info(owner, repo, branch, repos_update_branch_protection_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ProtectedBranch>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_update_branch_protection_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |
| **repos_update_branch_protection_request** | [**ReposUpdateBranchProtectionRequest**](ReposUpdateBranchProtectionRequest.md) |  |  |

### Return type

[**ProtectedBranch**](ProtectedBranch.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_update_commit_comment

> <CommitComment> repos_update_commit_comment(owner, repo, comment_id, repos_update_commit_comment_request)

Update a commit comment



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
comment_id = 56 # Integer | The unique identifier of the comment.
repos_update_commit_comment_request = OpenapiClient::ReposUpdateCommitCommentRequest.new({body: 'body_example'}) # ReposUpdateCommitCommentRequest | 

begin
  # Update a commit comment
  result = api_instance.repos_update_commit_comment(owner, repo, comment_id, repos_update_commit_comment_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_update_commit_comment: #{e}"
end
```

#### Using the repos_update_commit_comment_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CommitComment>, Integer, Hash)> repos_update_commit_comment_with_http_info(owner, repo, comment_id, repos_update_commit_comment_request)

```ruby
begin
  # Update a commit comment
  data, status_code, headers = api_instance.repos_update_commit_comment_with_http_info(owner, repo, comment_id, repos_update_commit_comment_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CommitComment>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_update_commit_comment_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **comment_id** | **Integer** | The unique identifier of the comment. |  |
| **repos_update_commit_comment_request** | [**ReposUpdateCommitCommentRequest**](ReposUpdateCommitCommentRequest.md) |  |  |

### Return type

[**CommitComment**](CommitComment.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_update_information_about_pages_site

> repos_update_information_about_pages_site(owner, repo, repos_update_information_about_pages_site_request)

Update information about a GitHub Pages site

Updates information for a GitHub Pages site. For more information, see \"[About GitHub Pages](/github/working-with-github-pages/about-github-pages).

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
repos_update_information_about_pages_site_request = OpenapiClient::ReposUpdateInformationAboutPagesSiteRequest.new # ReposUpdateInformationAboutPagesSiteRequest | 

begin
  # Update information about a GitHub Pages site
  api_instance.repos_update_information_about_pages_site(owner, repo, repos_update_information_about_pages_site_request)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_update_information_about_pages_site: #{e}"
end
```

#### Using the repos_update_information_about_pages_site_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> repos_update_information_about_pages_site_with_http_info(owner, repo, repos_update_information_about_pages_site_request)

```ruby
begin
  # Update information about a GitHub Pages site
  data, status_code, headers = api_instance.repos_update_information_about_pages_site_with_http_info(owner, repo, repos_update_information_about_pages_site_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_update_information_about_pages_site_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **repos_update_information_about_pages_site_request** | [**ReposUpdateInformationAboutPagesSiteRequest**](ReposUpdateInformationAboutPagesSiteRequest.md) |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, application/scim+json


## repos_update_invitation

> <RepositoryInvitation> repos_update_invitation(owner, repo, invitation_id, opts)

Update a repository invitation



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
invitation_id = 56 # Integer | The unique identifier of the invitation.
opts = {
  repos_update_invitation_request: OpenapiClient::ReposUpdateInvitationRequest.new # ReposUpdateInvitationRequest | 
}

begin
  # Update a repository invitation
  result = api_instance.repos_update_invitation(owner, repo, invitation_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_update_invitation: #{e}"
end
```

#### Using the repos_update_invitation_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<RepositoryInvitation>, Integer, Hash)> repos_update_invitation_with_http_info(owner, repo, invitation_id, opts)

```ruby
begin
  # Update a repository invitation
  data, status_code, headers = api_instance.repos_update_invitation_with_http_info(owner, repo, invitation_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <RepositoryInvitation>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_update_invitation_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **invitation_id** | **Integer** | The unique identifier of the invitation. |  |
| **repos_update_invitation_request** | [**ReposUpdateInvitationRequest**](ReposUpdateInvitationRequest.md) |  | [optional] |

### Return type

[**RepositoryInvitation**](RepositoryInvitation.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_update_pull_request_review_protection

> <ProtectedBranchPullRequestReview> repos_update_pull_request_review_protection(owner, repo, branch, opts)

Update pull request review protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Updating pull request review enforcement requires admin or owner permissions to the repository and branch protection to be enabled.  **Note**: Passing new arrays of `users` and `teams` replaces their previous values.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.
opts = {
  repos_update_pull_request_review_protection_request: OpenapiClient::ReposUpdatePullRequestReviewProtectionRequest.new # ReposUpdatePullRequestReviewProtectionRequest | 
}

begin
  # Update pull request review protection
  result = api_instance.repos_update_pull_request_review_protection(owner, repo, branch, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_update_pull_request_review_protection: #{e}"
end
```

#### Using the repos_update_pull_request_review_protection_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ProtectedBranchPullRequestReview>, Integer, Hash)> repos_update_pull_request_review_protection_with_http_info(owner, repo, branch, opts)

```ruby
begin
  # Update pull request review protection
  data, status_code, headers = api_instance.repos_update_pull_request_review_protection_with_http_info(owner, repo, branch, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ProtectedBranchPullRequestReview>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_update_pull_request_review_protection_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |
| **repos_update_pull_request_review_protection_request** | [**ReposUpdatePullRequestReviewProtectionRequest**](ReposUpdatePullRequestReviewProtectionRequest.md) |  | [optional] |

### Return type

[**ProtectedBranchPullRequestReview**](ProtectedBranchPullRequestReview.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_update_release

> <Release> repos_update_release(owner, repo, release_id, opts)

Update a release

Users with push access to the repository can edit a release.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
release_id = 56 # Integer | The unique identifier of the release.
opts = {
  repos_update_release_request: OpenapiClient::ReposUpdateReleaseRequest.new # ReposUpdateReleaseRequest | 
}

begin
  # Update a release
  result = api_instance.repos_update_release(owner, repo, release_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_update_release: #{e}"
end
```

#### Using the repos_update_release_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Release>, Integer, Hash)> repos_update_release_with_http_info(owner, repo, release_id, opts)

```ruby
begin
  # Update a release
  data, status_code, headers = api_instance.repos_update_release_with_http_info(owner, repo, release_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Release>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_update_release_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **release_id** | **Integer** | The unique identifier of the release. |  |
| **repos_update_release_request** | [**ReposUpdateReleaseRequest**](ReposUpdateReleaseRequest.md) |  | [optional] |

### Return type

[**Release**](Release.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_update_release_asset

> <ReleaseAsset> repos_update_release_asset(owner, repo, asset_id, opts)

Update a release asset

Users with push access to the repository can edit a release asset.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
asset_id = 56 # Integer | The unique identifier of the asset.
opts = {
  repos_update_release_asset_request: OpenapiClient::ReposUpdateReleaseAssetRequest.new # ReposUpdateReleaseAssetRequest | 
}

begin
  # Update a release asset
  result = api_instance.repos_update_release_asset(owner, repo, asset_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_update_release_asset: #{e}"
end
```

#### Using the repos_update_release_asset_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ReleaseAsset>, Integer, Hash)> repos_update_release_asset_with_http_info(owner, repo, asset_id, opts)

```ruby
begin
  # Update a release asset
  data, status_code, headers = api_instance.repos_update_release_asset_with_http_info(owner, repo, asset_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ReleaseAsset>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_update_release_asset_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **asset_id** | **Integer** | The unique identifier of the asset. |  |
| **repos_update_release_asset_request** | [**ReposUpdateReleaseAssetRequest**](ReposUpdateReleaseAssetRequest.md) |  | [optional] |

### Return type

[**ReleaseAsset**](ReleaseAsset.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_update_status_check_protection

> <StatusCheckPolicy> repos_update_status_check_protection(owner, repo, branch, opts)

Update status check protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Updating required status checks requires admin or owner permissions to the repository and branch protection to be enabled.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
branch = 'branch_example' # String | The name of the branch.
opts = {
  repos_update_status_check_protection_request: OpenapiClient::ReposUpdateStatusCheckProtectionRequest.new # ReposUpdateStatusCheckProtectionRequest | 
}

begin
  # Update status check protection
  result = api_instance.repos_update_status_check_protection(owner, repo, branch, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_update_status_check_protection: #{e}"
end
```

#### Using the repos_update_status_check_protection_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<StatusCheckPolicy>, Integer, Hash)> repos_update_status_check_protection_with_http_info(owner, repo, branch, opts)

```ruby
begin
  # Update status check protection
  data, status_code, headers = api_instance.repos_update_status_check_protection_with_http_info(owner, repo, branch, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <StatusCheckPolicy>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_update_status_check_protection_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **branch** | **String** | The name of the branch. |  |
| **repos_update_status_check_protection_request** | [**ReposUpdateStatusCheckProtectionRequest**](ReposUpdateStatusCheckProtectionRequest.md) |  | [optional] |

### Return type

[**StatusCheckPolicy**](StatusCheckPolicy.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_update_webhook

> <Webhook> repos_update_webhook(owner, repo, hook_id, repos_update_webhook_request)

Update a repository webhook

Updates a webhook configured in a repository. If you previously had a `secret` set, you must provide the same `secret` or set a new `secret` or the secret will be removed. If you are only updating individual webhook `config` properties, use \"[Update a webhook configuration for a repository](/rest/reference/repos#update-a-webhook-configuration-for-a-repository).\"

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
hook_id = 56 # Integer | The unique identifier of the hook.
repos_update_webhook_request = OpenapiClient::ReposUpdateWebhookRequest.new # ReposUpdateWebhookRequest | 

begin
  # Update a repository webhook
  result = api_instance.repos_update_webhook(owner, repo, hook_id, repos_update_webhook_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_update_webhook: #{e}"
end
```

#### Using the repos_update_webhook_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Webhook>, Integer, Hash)> repos_update_webhook_with_http_info(owner, repo, hook_id, repos_update_webhook_request)

```ruby
begin
  # Update a repository webhook
  data, status_code, headers = api_instance.repos_update_webhook_with_http_info(owner, repo, hook_id, repos_update_webhook_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Webhook>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_update_webhook_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **hook_id** | **Integer** | The unique identifier of the hook. |  |
| **repos_update_webhook_request** | [**ReposUpdateWebhookRequest**](ReposUpdateWebhookRequest.md) |  |  |

### Return type

[**Webhook**](Webhook.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_update_webhook_config_for_repo

> <WebhookConfiguration> repos_update_webhook_config_for_repo(owner, repo, hook_id, opts)

Update a webhook configuration for a repository

Updates the webhook configuration for a repository. To update more information about the webhook, including the `active` state and `events`, use \"[Update a repository webhook](/rest/reference/orgs#update-a-repository-webhook).\"  Access tokens must have the `write:repo_hook` or `repo` scope, and GitHub Apps must have the `repository_hooks:write` permission.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
hook_id = 56 # Integer | The unique identifier of the hook.
opts = {
  repos_update_webhook_config_for_repo_request: OpenapiClient::ReposUpdateWebhookConfigForRepoRequest.new # ReposUpdateWebhookConfigForRepoRequest | 
}

begin
  # Update a webhook configuration for a repository
  result = api_instance.repos_update_webhook_config_for_repo(owner, repo, hook_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_update_webhook_config_for_repo: #{e}"
end
```

#### Using the repos_update_webhook_config_for_repo_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<WebhookConfiguration>, Integer, Hash)> repos_update_webhook_config_for_repo_with_http_info(owner, repo, hook_id, opts)

```ruby
begin
  # Update a webhook configuration for a repository
  data, status_code, headers = api_instance.repos_update_webhook_config_for_repo_with_http_info(owner, repo, hook_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <WebhookConfiguration>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_update_webhook_config_for_repo_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **hook_id** | **Integer** | The unique identifier of the hook. |  |
| **repos_update_webhook_config_for_repo_request** | [**ReposUpdateWebhookConfigForRepoRequest**](ReposUpdateWebhookConfigForRepoRequest.md) |  | [optional] |

### Return type

[**WebhookConfiguration**](WebhookConfiguration.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## repos_upload_release_asset

> <ReleaseAsset> repos_upload_release_asset(owner, repo, release_id, name, opts)

Upload a release asset

This endpoint makes use of [a Hypermedia relation](https://docs.github.com/rest/overview/resources-in-the-rest-api#hypermedia) to determine which URL to access. The endpoint you call to upload release assets is specific to your release. Use the `upload_url` returned in the response of the [Create a release endpoint](https://docs.github.com/rest/reference/repos#create-a-release) to upload a release asset.  You need to use an HTTP client which supports [SNI](http://en.wikipedia.org/wiki/Server_Name_Indication) to make calls to this endpoint.  Most libraries will set the required `Content-Length` header automatically. Use the required `Content-Type` header to provide the media type of the asset. For a list of media types, see [Media Types](https://www.iana.org/assignments/media-types/media-types.xhtml). For example:   `application/zip`  GitHub expects the asset data in its raw binary form, rather than JSON. You will send the raw binary content of the asset as the request body. Everything else about the endpoint is the same as the rest of the API. For example, you'll still need to pass your authentication to be able to upload an asset.  When an upstream failure occurs, you will receive a `502 Bad Gateway` status. This may leave an empty asset with a state of `starter`. It can be safely deleted.  **Notes:** *   GitHub renames asset filenames that have special characters, non-alphanumeric characters, and leading or trailing periods. The \"[List assets for a release](https://docs.github.com/rest/reference/repos#list-assets-for-a-release)\" endpoint lists the renamed filenames. For more information and help, contact [GitHub Support](https://support.github.com/contact?tags=dotcom-rest-api). *   If you upload an asset with the same filename as another uploaded asset, you'll receive an error and must delete the old file before you can re-upload the new asset.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ReposApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
release_id = 56 # Integer | The unique identifier of the release.
name = 'name_example' # String | 
opts = {
  label: 'label_example', # String | 
  body: 'body_example' # String | 
}

begin
  # Upload a release asset
  result = api_instance.repos_upload_release_asset(owner, repo, release_id, name, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_upload_release_asset: #{e}"
end
```

#### Using the repos_upload_release_asset_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ReleaseAsset>, Integer, Hash)> repos_upload_release_asset_with_http_info(owner, repo, release_id, name, opts)

```ruby
begin
  # Upload a release asset
  data, status_code, headers = api_instance.repos_upload_release_asset_with_http_info(owner, repo, release_id, name, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ReleaseAsset>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ReposApi->repos_upload_release_asset_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **release_id** | **Integer** | The unique identifier of the release. |  |
| **name** | **String** |  |  |
| **label** | **String** |  | [optional] |
| **body** | **String** |  | [optional] |

### Return type

[**ReleaseAsset**](ReleaseAsset.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

