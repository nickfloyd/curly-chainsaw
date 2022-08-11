# Org.OpenAPITools.Api.ReposApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReposAcceptInvitationForAuthenticatedUser**](ReposApi.md#reposacceptinvitationforauthenticateduser) | **PATCH** /user/repository_invitations/{invitation_id} | Accept a repository invitation
[**ReposAddAppAccessRestrictions**](ReposApi.md#reposaddappaccessrestrictions) | **POST** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/apps | Add app access restrictions
[**ReposAddCollaborator**](ReposApi.md#reposaddcollaborator) | **PUT** /repos/{owner}/{repo}/collaborators/{username} | Add a repository collaborator
[**ReposAddStatusCheckContexts**](ReposApi.md#reposaddstatuscheckcontexts) | **POST** /repos/{owner}/{repo}/branches/{branch}/protection/required_status_checks/contexts | Add status check contexts
[**ReposAddTeamAccessRestrictions**](ReposApi.md#reposaddteamaccessrestrictions) | **POST** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/teams | Add team access restrictions
[**ReposAddUserAccessRestrictions**](ReposApi.md#reposadduseraccessrestrictions) | **POST** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/users | Add user access restrictions
[**ReposCheckCollaborator**](ReposApi.md#reposcheckcollaborator) | **GET** /repos/{owner}/{repo}/collaborators/{username} | Check if a user is a repository collaborator
[**ReposCheckVulnerabilityAlerts**](ReposApi.md#reposcheckvulnerabilityalerts) | **GET** /repos/{owner}/{repo}/vulnerability-alerts | Check if vulnerability alerts are enabled for a repository
[**ReposCodeownersErrors**](ReposApi.md#reposcodeownerserrors) | **GET** /repos/{owner}/{repo}/codeowners/errors | List CODEOWNERS errors
[**ReposCompareCommits**](ReposApi.md#reposcomparecommits) | **GET** /repos/{owner}/{repo}/compare/{basehead} | Compare two commits
[**ReposCreateAutolink**](ReposApi.md#reposcreateautolink) | **POST** /repos/{owner}/{repo}/autolinks | Create an autolink reference for a repository
[**ReposCreateCommitComment**](ReposApi.md#reposcreatecommitcomment) | **POST** /repos/{owner}/{repo}/commits/{commit_sha}/comments | Create a commit comment
[**ReposCreateCommitSignatureProtection**](ReposApi.md#reposcreatecommitsignatureprotection) | **POST** /repos/{owner}/{repo}/branches/{branch}/protection/required_signatures | Create commit signature protection
[**ReposCreateCommitStatus**](ReposApi.md#reposcreatecommitstatus) | **POST** /repos/{owner}/{repo}/statuses/{sha} | Create a commit status
[**ReposCreateDeployKey**](ReposApi.md#reposcreatedeploykey) | **POST** /repos/{owner}/{repo}/keys | Create a deploy key
[**ReposCreateDeployment**](ReposApi.md#reposcreatedeployment) | **POST** /repos/{owner}/{repo}/deployments | Create a deployment
[**ReposCreateDeploymentStatus**](ReposApi.md#reposcreatedeploymentstatus) | **POST** /repos/{owner}/{repo}/deployments/{deployment_id}/statuses | Create a deployment status
[**ReposCreateDispatchEvent**](ReposApi.md#reposcreatedispatchevent) | **POST** /repos/{owner}/{repo}/dispatches | Create a repository dispatch event
[**ReposCreateForAuthenticatedUser**](ReposApi.md#reposcreateforauthenticateduser) | **POST** /user/repos | Create a repository for the authenticated user
[**ReposCreateFork**](ReposApi.md#reposcreatefork) | **POST** /repos/{owner}/{repo}/forks | Create a fork
[**ReposCreateInOrg**](ReposApi.md#reposcreateinorg) | **POST** /orgs/{org}/repos | Create an organization repository
[**ReposCreateOrUpdateEnvironment**](ReposApi.md#reposcreateorupdateenvironment) | **PUT** /repos/{owner}/{repo}/environments/{environment_name} | Create or update an environment
[**ReposCreateOrUpdateFileContents**](ReposApi.md#reposcreateorupdatefilecontents) | **PUT** /repos/{owner}/{repo}/contents/{path} | Create or update file contents
[**ReposCreatePagesDeployment**](ReposApi.md#reposcreatepagesdeployment) | **POST** /repos/{owner}/{repo}/pages/deployment | Create a GitHub Pages deployment
[**ReposCreatePagesSite**](ReposApi.md#reposcreatepagessite) | **POST** /repos/{owner}/{repo}/pages | Create a GitHub Pages site
[**ReposCreateRelease**](ReposApi.md#reposcreaterelease) | **POST** /repos/{owner}/{repo}/releases | Create a release
[**ReposCreateTagProtection**](ReposApi.md#reposcreatetagprotection) | **POST** /repos/{owner}/{repo}/tags/protection | Create a tag protection state for a repository
[**ReposCreateUsingTemplate**](ReposApi.md#reposcreateusingtemplate) | **POST** /repos/{template_owner}/{template_repo}/generate | Create a repository using a template
[**ReposCreateWebhook**](ReposApi.md#reposcreatewebhook) | **POST** /repos/{owner}/{repo}/hooks | Create a repository webhook
[**ReposDeclineInvitationForAuthenticatedUser**](ReposApi.md#reposdeclineinvitationforauthenticateduser) | **DELETE** /user/repository_invitations/{invitation_id} | Decline a repository invitation
[**ReposDelete**](ReposApi.md#reposdelete) | **DELETE** /repos/{owner}/{repo} | Delete a repository
[**ReposDeleteAccessRestrictions**](ReposApi.md#reposdeleteaccessrestrictions) | **DELETE** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions | Delete access restrictions
[**ReposDeleteAdminBranchProtection**](ReposApi.md#reposdeleteadminbranchprotection) | **DELETE** /repos/{owner}/{repo}/branches/{branch}/protection/enforce_admins | Delete admin branch protection
[**ReposDeleteAnEnvironment**](ReposApi.md#reposdeleteanenvironment) | **DELETE** /repos/{owner}/{repo}/environments/{environment_name} | Delete an environment
[**ReposDeleteAutolink**](ReposApi.md#reposdeleteautolink) | **DELETE** /repos/{owner}/{repo}/autolinks/{autolink_id} | Delete an autolink reference from a repository
[**ReposDeleteBranchProtection**](ReposApi.md#reposdeletebranchprotection) | **DELETE** /repos/{owner}/{repo}/branches/{branch}/protection | Delete branch protection
[**ReposDeleteCommitComment**](ReposApi.md#reposdeletecommitcomment) | **DELETE** /repos/{owner}/{repo}/comments/{comment_id} | Delete a commit comment
[**ReposDeleteCommitSignatureProtection**](ReposApi.md#reposdeletecommitsignatureprotection) | **DELETE** /repos/{owner}/{repo}/branches/{branch}/protection/required_signatures | Delete commit signature protection
[**ReposDeleteDeployKey**](ReposApi.md#reposdeletedeploykey) | **DELETE** /repos/{owner}/{repo}/keys/{key_id} | Delete a deploy key
[**ReposDeleteDeployment**](ReposApi.md#reposdeletedeployment) | **DELETE** /repos/{owner}/{repo}/deployments/{deployment_id} | Delete a deployment
[**ReposDeleteFile**](ReposApi.md#reposdeletefile) | **DELETE** /repos/{owner}/{repo}/contents/{path} | Delete a file
[**ReposDeleteInvitation**](ReposApi.md#reposdeleteinvitation) | **DELETE** /repos/{owner}/{repo}/invitations/{invitation_id} | Delete a repository invitation
[**ReposDeletePagesSite**](ReposApi.md#reposdeletepagessite) | **DELETE** /repos/{owner}/{repo}/pages | Delete a GitHub Pages site
[**ReposDeletePullRequestReviewProtection**](ReposApi.md#reposdeletepullrequestreviewprotection) | **DELETE** /repos/{owner}/{repo}/branches/{branch}/protection/required_pull_request_reviews | Delete pull request review protection
[**ReposDeleteRelease**](ReposApi.md#reposdeleterelease) | **DELETE** /repos/{owner}/{repo}/releases/{release_id} | Delete a release
[**ReposDeleteReleaseAsset**](ReposApi.md#reposdeletereleaseasset) | **DELETE** /repos/{owner}/{repo}/releases/assets/{asset_id} | Delete a release asset
[**ReposDeleteTagProtection**](ReposApi.md#reposdeletetagprotection) | **DELETE** /repos/{owner}/{repo}/tags/protection/{tag_protection_id} | Delete a tag protection state for a repository
[**ReposDeleteWebhook**](ReposApi.md#reposdeletewebhook) | **DELETE** /repos/{owner}/{repo}/hooks/{hook_id} | Delete a repository webhook
[**ReposDisableAutomatedSecurityFixes**](ReposApi.md#reposdisableautomatedsecurityfixes) | **DELETE** /repos/{owner}/{repo}/automated-security-fixes | Disable automated security fixes
[**ReposDisableLfsForRepo**](ReposApi.md#reposdisablelfsforrepo) | **DELETE** /repos/{owner}/{repo}/lfs | Disable Git LFS for a repository
[**ReposDisableVulnerabilityAlerts**](ReposApi.md#reposdisablevulnerabilityalerts) | **DELETE** /repos/{owner}/{repo}/vulnerability-alerts | Disable vulnerability alerts
[**ReposDownloadTarballArchive**](ReposApi.md#reposdownloadtarballarchive) | **GET** /repos/{owner}/{repo}/tarball/{ref} | Download a repository archive (tar)
[**ReposDownloadZipballArchive**](ReposApi.md#reposdownloadzipballarchive) | **GET** /repos/{owner}/{repo}/zipball/{ref} | Download a repository archive (zip)
[**ReposEnableAutomatedSecurityFixes**](ReposApi.md#reposenableautomatedsecurityfixes) | **PUT** /repos/{owner}/{repo}/automated-security-fixes | Enable automated security fixes
[**ReposEnableLfsForRepo**](ReposApi.md#reposenablelfsforrepo) | **PUT** /repos/{owner}/{repo}/lfs | Enable Git LFS for a repository
[**ReposEnableVulnerabilityAlerts**](ReposApi.md#reposenablevulnerabilityalerts) | **PUT** /repos/{owner}/{repo}/vulnerability-alerts | Enable vulnerability alerts
[**ReposGenerateReleaseNotes**](ReposApi.md#reposgeneratereleasenotes) | **POST** /repos/{owner}/{repo}/releases/generate-notes | Generate release notes content for a release
[**ReposGet**](ReposApi.md#reposget) | **GET** /repos/{owner}/{repo} | Get a repository
[**ReposGetAccessRestrictions**](ReposApi.md#reposgetaccessrestrictions) | **GET** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions | Get access restrictions
[**ReposGetAdminBranchProtection**](ReposApi.md#reposgetadminbranchprotection) | **GET** /repos/{owner}/{repo}/branches/{branch}/protection/enforce_admins | Get admin branch protection
[**ReposGetAllEnvironments**](ReposApi.md#reposgetallenvironments) | **GET** /repos/{owner}/{repo}/environments | Get all environments
[**ReposGetAllStatusCheckContexts**](ReposApi.md#reposgetallstatuscheckcontexts) | **GET** /repos/{owner}/{repo}/branches/{branch}/protection/required_status_checks/contexts | Get all status check contexts
[**ReposGetAllTopics**](ReposApi.md#reposgetalltopics) | **GET** /repos/{owner}/{repo}/topics | Get all repository topics
[**ReposGetAppsWithAccessToProtectedBranch**](ReposApi.md#reposgetappswithaccesstoprotectedbranch) | **GET** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/apps | Get apps with access to the protected branch
[**ReposGetAutolink**](ReposApi.md#reposgetautolink) | **GET** /repos/{owner}/{repo}/autolinks/{autolink_id} | Get an autolink reference of a repository
[**ReposGetBranch**](ReposApi.md#reposgetbranch) | **GET** /repos/{owner}/{repo}/branches/{branch} | Get a branch
[**ReposGetBranchProtection**](ReposApi.md#reposgetbranchprotection) | **GET** /repos/{owner}/{repo}/branches/{branch}/protection | Get branch protection
[**ReposGetClones**](ReposApi.md#reposgetclones) | **GET** /repos/{owner}/{repo}/traffic/clones | Get repository clones
[**ReposGetCodeFrequencyStats**](ReposApi.md#reposgetcodefrequencystats) | **GET** /repos/{owner}/{repo}/stats/code_frequency | Get the weekly commit activity
[**ReposGetCollaboratorPermissionLevel**](ReposApi.md#reposgetcollaboratorpermissionlevel) | **GET** /repos/{owner}/{repo}/collaborators/{username}/permission | Get repository permissions for a user
[**ReposGetCombinedStatusForRef**](ReposApi.md#reposgetcombinedstatusforref) | **GET** /repos/{owner}/{repo}/commits/{ref}/status | Get the combined status for a specific reference
[**ReposGetCommit**](ReposApi.md#reposgetcommit) | **GET** /repos/{owner}/{repo}/commits/{ref} | Get a commit
[**ReposGetCommitActivityStats**](ReposApi.md#reposgetcommitactivitystats) | **GET** /repos/{owner}/{repo}/stats/commit_activity | Get the last year of commit activity
[**ReposGetCommitComment**](ReposApi.md#reposgetcommitcomment) | **GET** /repos/{owner}/{repo}/comments/{comment_id} | Get a commit comment
[**ReposGetCommitSignatureProtection**](ReposApi.md#reposgetcommitsignatureprotection) | **GET** /repos/{owner}/{repo}/branches/{branch}/protection/required_signatures | Get commit signature protection
[**ReposGetCommunityProfileMetrics**](ReposApi.md#reposgetcommunityprofilemetrics) | **GET** /repos/{owner}/{repo}/community/profile | Get community profile metrics
[**ReposGetContent**](ReposApi.md#reposgetcontent) | **GET** /repos/{owner}/{repo}/contents/{path} | Get repository content
[**ReposGetContributorsStats**](ReposApi.md#reposgetcontributorsstats) | **GET** /repos/{owner}/{repo}/stats/contributors | Get all contributor commit activity
[**ReposGetDeployKey**](ReposApi.md#reposgetdeploykey) | **GET** /repos/{owner}/{repo}/keys/{key_id} | Get a deploy key
[**ReposGetDeployment**](ReposApi.md#reposgetdeployment) | **GET** /repos/{owner}/{repo}/deployments/{deployment_id} | Get a deployment
[**ReposGetDeploymentStatus**](ReposApi.md#reposgetdeploymentstatus) | **GET** /repos/{owner}/{repo}/deployments/{deployment_id}/statuses/{status_id} | Get a deployment status
[**ReposGetEnvironment**](ReposApi.md#reposgetenvironment) | **GET** /repos/{owner}/{repo}/environments/{environment_name} | Get an environment
[**ReposGetLatestPagesBuild**](ReposApi.md#reposgetlatestpagesbuild) | **GET** /repos/{owner}/{repo}/pages/builds/latest | Get latest Pages build
[**ReposGetLatestRelease**](ReposApi.md#reposgetlatestrelease) | **GET** /repos/{owner}/{repo}/releases/latest | Get the latest release
[**ReposGetPages**](ReposApi.md#reposgetpages) | **GET** /repos/{owner}/{repo}/pages | Get a GitHub Pages site
[**ReposGetPagesBuild**](ReposApi.md#reposgetpagesbuild) | **GET** /repos/{owner}/{repo}/pages/builds/{build_id} | Get GitHub Pages build
[**ReposGetPagesHealthCheck**](ReposApi.md#reposgetpageshealthcheck) | **GET** /repos/{owner}/{repo}/pages/health | Get a DNS health check for GitHub Pages
[**ReposGetParticipationStats**](ReposApi.md#reposgetparticipationstats) | **GET** /repos/{owner}/{repo}/stats/participation | Get the weekly commit count
[**ReposGetPullRequestReviewProtection**](ReposApi.md#reposgetpullrequestreviewprotection) | **GET** /repos/{owner}/{repo}/branches/{branch}/protection/required_pull_request_reviews | Get pull request review protection
[**ReposGetPunchCardStats**](ReposApi.md#reposgetpunchcardstats) | **GET** /repos/{owner}/{repo}/stats/punch_card | Get the hourly commit count for each day
[**ReposGetReadme**](ReposApi.md#reposgetreadme) | **GET** /repos/{owner}/{repo}/readme | Get a repository README
[**ReposGetReadmeInDirectory**](ReposApi.md#reposgetreadmeindirectory) | **GET** /repos/{owner}/{repo}/readme/{dir} | Get a repository README for a directory
[**ReposGetRelease**](ReposApi.md#reposgetrelease) | **GET** /repos/{owner}/{repo}/releases/{release_id} | Get a release
[**ReposGetReleaseAsset**](ReposApi.md#reposgetreleaseasset) | **GET** /repos/{owner}/{repo}/releases/assets/{asset_id} | Get a release asset
[**ReposGetReleaseByTag**](ReposApi.md#reposgetreleasebytag) | **GET** /repos/{owner}/{repo}/releases/tags/{tag} | Get a release by tag name
[**ReposGetStatusChecksProtection**](ReposApi.md#reposgetstatuschecksprotection) | **GET** /repos/{owner}/{repo}/branches/{branch}/protection/required_status_checks | Get status checks protection
[**ReposGetTeamsWithAccessToProtectedBranch**](ReposApi.md#reposgetteamswithaccesstoprotectedbranch) | **GET** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/teams | Get teams with access to the protected branch
[**ReposGetTopPaths**](ReposApi.md#reposgettoppaths) | **GET** /repos/{owner}/{repo}/traffic/popular/paths | Get top referral paths
[**ReposGetTopReferrers**](ReposApi.md#reposgettopreferrers) | **GET** /repos/{owner}/{repo}/traffic/popular/referrers | Get top referral sources
[**ReposGetUsersWithAccessToProtectedBranch**](ReposApi.md#reposgetuserswithaccesstoprotectedbranch) | **GET** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/users | Get users with access to the protected branch
[**ReposGetViews**](ReposApi.md#reposgetviews) | **GET** /repos/{owner}/{repo}/traffic/views | Get page views
[**ReposGetWebhook**](ReposApi.md#reposgetwebhook) | **GET** /repos/{owner}/{repo}/hooks/{hook_id} | Get a repository webhook
[**ReposGetWebhookConfigForRepo**](ReposApi.md#reposgetwebhookconfigforrepo) | **GET** /repos/{owner}/{repo}/hooks/{hook_id}/config | Get a webhook configuration for a repository
[**ReposGetWebhookDelivery**](ReposApi.md#reposgetwebhookdelivery) | **GET** /repos/{owner}/{repo}/hooks/{hook_id}/deliveries/{delivery_id} | Get a delivery for a repository webhook
[**ReposListAutolinks**](ReposApi.md#reposlistautolinks) | **GET** /repos/{owner}/{repo}/autolinks | List all autolinks of a repository
[**ReposListBranches**](ReposApi.md#reposlistbranches) | **GET** /repos/{owner}/{repo}/branches | List branches
[**ReposListBranchesForHeadCommit**](ReposApi.md#reposlistbranchesforheadcommit) | **GET** /repos/{owner}/{repo}/commits/{commit_sha}/branches-where-head | List branches for HEAD commit
[**ReposListCollaborators**](ReposApi.md#reposlistcollaborators) | **GET** /repos/{owner}/{repo}/collaborators | List repository collaborators
[**ReposListCommentsForCommit**](ReposApi.md#reposlistcommentsforcommit) | **GET** /repos/{owner}/{repo}/commits/{commit_sha}/comments | List commit comments
[**ReposListCommitCommentsForRepo**](ReposApi.md#reposlistcommitcommentsforrepo) | **GET** /repos/{owner}/{repo}/comments | List commit comments for a repository
[**ReposListCommitStatusesForRef**](ReposApi.md#reposlistcommitstatusesforref) | **GET** /repos/{owner}/{repo}/commits/{ref}/statuses | List commit statuses for a reference
[**ReposListCommits**](ReposApi.md#reposlistcommits) | **GET** /repos/{owner}/{repo}/commits | List commits
[**ReposListContributors**](ReposApi.md#reposlistcontributors) | **GET** /repos/{owner}/{repo}/contributors | List repository contributors
[**ReposListDeployKeys**](ReposApi.md#reposlistdeploykeys) | **GET** /repos/{owner}/{repo}/keys | List deploy keys
[**ReposListDeploymentStatuses**](ReposApi.md#reposlistdeploymentstatuses) | **GET** /repos/{owner}/{repo}/deployments/{deployment_id}/statuses | List deployment statuses
[**ReposListDeployments**](ReposApi.md#reposlistdeployments) | **GET** /repos/{owner}/{repo}/deployments | List deployments
[**ReposListForAuthenticatedUser**](ReposApi.md#reposlistforauthenticateduser) | **GET** /user/repos | List repositories for the authenticated user
[**ReposListForOrg**](ReposApi.md#reposlistfororg) | **GET** /orgs/{org}/repos | List organization repositories
[**ReposListForUser**](ReposApi.md#reposlistforuser) | **GET** /users/{username}/repos | List repositories for a user
[**ReposListForks**](ReposApi.md#reposlistforks) | **GET** /repos/{owner}/{repo}/forks | List forks
[**ReposListInvitations**](ReposApi.md#reposlistinvitations) | **GET** /repos/{owner}/{repo}/invitations | List repository invitations
[**ReposListInvitationsForAuthenticatedUser**](ReposApi.md#reposlistinvitationsforauthenticateduser) | **GET** /user/repository_invitations | List repository invitations for the authenticated user
[**ReposListLanguages**](ReposApi.md#reposlistlanguages) | **GET** /repos/{owner}/{repo}/languages | List repository languages
[**ReposListPagesBuilds**](ReposApi.md#reposlistpagesbuilds) | **GET** /repos/{owner}/{repo}/pages/builds | List GitHub Pages builds
[**ReposListPublic**](ReposApi.md#reposlistpublic) | **GET** /repositories | List public repositories
[**ReposListPullRequestsAssociatedWithCommit**](ReposApi.md#reposlistpullrequestsassociatedwithcommit) | **GET** /repos/{owner}/{repo}/commits/{commit_sha}/pulls | List pull requests associated with a commit
[**ReposListReleaseAssets**](ReposApi.md#reposlistreleaseassets) | **GET** /repos/{owner}/{repo}/releases/{release_id}/assets | List release assets
[**ReposListReleases**](ReposApi.md#reposlistreleases) | **GET** /repos/{owner}/{repo}/releases | List releases
[**ReposListTagProtection**](ReposApi.md#reposlisttagprotection) | **GET** /repos/{owner}/{repo}/tags/protection | List tag protection states for a repository
[**ReposListTags**](ReposApi.md#reposlisttags) | **GET** /repos/{owner}/{repo}/tags | List repository tags
[**ReposListTeams**](ReposApi.md#reposlistteams) | **GET** /repos/{owner}/{repo}/teams | List repository teams
[**ReposListWebhookDeliveries**](ReposApi.md#reposlistwebhookdeliveries) | **GET** /repos/{owner}/{repo}/hooks/{hook_id}/deliveries | List deliveries for a repository webhook
[**ReposListWebhooks**](ReposApi.md#reposlistwebhooks) | **GET** /repos/{owner}/{repo}/hooks | List repository webhooks
[**ReposMerge**](ReposApi.md#reposmerge) | **POST** /repos/{owner}/{repo}/merges | Merge a branch
[**ReposMergeUpstream**](ReposApi.md#reposmergeupstream) | **POST** /repos/{owner}/{repo}/merge-upstream | Sync a fork branch with the upstream repository
[**ReposPingWebhook**](ReposApi.md#repospingwebhook) | **POST** /repos/{owner}/{repo}/hooks/{hook_id}/pings | Ping a repository webhook
[**ReposRedeliverWebhookDelivery**](ReposApi.md#reposredeliverwebhookdelivery) | **POST** /repos/{owner}/{repo}/hooks/{hook_id}/deliveries/{delivery_id}/attempts | Redeliver a delivery for a repository webhook
[**ReposRemoveAppAccessRestrictions**](ReposApi.md#reposremoveappaccessrestrictions) | **DELETE** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/apps | Remove app access restrictions
[**ReposRemoveCollaborator**](ReposApi.md#reposremovecollaborator) | **DELETE** /repos/{owner}/{repo}/collaborators/{username} | Remove a repository collaborator
[**ReposRemoveStatusCheckContexts**](ReposApi.md#reposremovestatuscheckcontexts) | **DELETE** /repos/{owner}/{repo}/branches/{branch}/protection/required_status_checks/contexts | Remove status check contexts
[**ReposRemoveStatusCheckProtection**](ReposApi.md#reposremovestatuscheckprotection) | **DELETE** /repos/{owner}/{repo}/branches/{branch}/protection/required_status_checks | Remove status check protection
[**ReposRemoveTeamAccessRestrictions**](ReposApi.md#reposremoveteamaccessrestrictions) | **DELETE** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/teams | Remove team access restrictions
[**ReposRemoveUserAccessRestrictions**](ReposApi.md#reposremoveuseraccessrestrictions) | **DELETE** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/users | Remove user access restrictions
[**ReposRenameBranch**](ReposApi.md#reposrenamebranch) | **POST** /repos/{owner}/{repo}/branches/{branch}/rename | Rename a branch
[**ReposReplaceAllTopics**](ReposApi.md#reposreplacealltopics) | **PUT** /repos/{owner}/{repo}/topics | Replace all repository topics
[**ReposRequestPagesBuild**](ReposApi.md#reposrequestpagesbuild) | **POST** /repos/{owner}/{repo}/pages/builds | Request a GitHub Pages build
[**ReposSetAdminBranchProtection**](ReposApi.md#repossetadminbranchprotection) | **POST** /repos/{owner}/{repo}/branches/{branch}/protection/enforce_admins | Set admin branch protection
[**ReposSetAppAccessRestrictions**](ReposApi.md#repossetappaccessrestrictions) | **PUT** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/apps | Set app access restrictions
[**ReposSetStatusCheckContexts**](ReposApi.md#repossetstatuscheckcontexts) | **PUT** /repos/{owner}/{repo}/branches/{branch}/protection/required_status_checks/contexts | Set status check contexts
[**ReposSetTeamAccessRestrictions**](ReposApi.md#repossetteamaccessrestrictions) | **PUT** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/teams | Set team access restrictions
[**ReposSetUserAccessRestrictions**](ReposApi.md#repossetuseraccessrestrictions) | **PUT** /repos/{owner}/{repo}/branches/{branch}/protection/restrictions/users | Set user access restrictions
[**ReposTestPushWebhook**](ReposApi.md#repostestpushwebhook) | **POST** /repos/{owner}/{repo}/hooks/{hook_id}/tests | Test the push repository webhook
[**ReposTransfer**](ReposApi.md#repostransfer) | **POST** /repos/{owner}/{repo}/transfer | Transfer a repository
[**ReposUpdate**](ReposApi.md#reposupdate) | **PATCH** /repos/{owner}/{repo} | Update a repository
[**ReposUpdateBranchProtection**](ReposApi.md#reposupdatebranchprotection) | **PUT** /repos/{owner}/{repo}/branches/{branch}/protection | Update branch protection
[**ReposUpdateCommitComment**](ReposApi.md#reposupdatecommitcomment) | **PATCH** /repos/{owner}/{repo}/comments/{comment_id} | Update a commit comment
[**ReposUpdateInformationAboutPagesSite**](ReposApi.md#reposupdateinformationaboutpagessite) | **PUT** /repos/{owner}/{repo}/pages | Update information about a GitHub Pages site
[**ReposUpdateInvitation**](ReposApi.md#reposupdateinvitation) | **PATCH** /repos/{owner}/{repo}/invitations/{invitation_id} | Update a repository invitation
[**ReposUpdatePullRequestReviewProtection**](ReposApi.md#reposupdatepullrequestreviewprotection) | **PATCH** /repos/{owner}/{repo}/branches/{branch}/protection/required_pull_request_reviews | Update pull request review protection
[**ReposUpdateRelease**](ReposApi.md#reposupdaterelease) | **PATCH** /repos/{owner}/{repo}/releases/{release_id} | Update a release
[**ReposUpdateReleaseAsset**](ReposApi.md#reposupdatereleaseasset) | **PATCH** /repos/{owner}/{repo}/releases/assets/{asset_id} | Update a release asset
[**ReposUpdateStatusCheckProtection**](ReposApi.md#reposupdatestatuscheckprotection) | **PATCH** /repos/{owner}/{repo}/branches/{branch}/protection/required_status_checks | Update status check protection
[**ReposUpdateWebhook**](ReposApi.md#reposupdatewebhook) | **PATCH** /repos/{owner}/{repo}/hooks/{hook_id} | Update a repository webhook
[**ReposUpdateWebhookConfigForRepo**](ReposApi.md#reposupdatewebhookconfigforrepo) | **PATCH** /repos/{owner}/{repo}/hooks/{hook_id}/config | Update a webhook configuration for a repository
[**ReposUploadReleaseAsset**](ReposApi.md#reposuploadreleaseasset) | **POST** /repos/{owner}/{repo}/releases/{release_id}/assets | Upload a release asset


<a name="reposacceptinvitationforauthenticateduser"></a>
# **ReposAcceptInvitationForAuthenticatedUser**
> void ReposAcceptInvitationForAuthenticatedUser (int? invitationId)

Accept a repository invitation



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposAcceptInvitationForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var invitationId = 56;  // int? | The unique identifier of the invitation.

            try
            {
                // Accept a repository invitation
                apiInstance.ReposAcceptInvitationForAuthenticatedUser(invitationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposAcceptInvitationForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invitationId** | **int?**| The unique identifier of the invitation. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposaddappaccessrestrictions"></a>
# **ReposAddAppAccessRestrictions**
> List<GitHubApp> ReposAddAppAccessRestrictions (string owner, string repo, string branch, ReposSetAppAccessRestrictionsRequest reposSetAppAccessRestrictionsRequest)

Add app access restrictions

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Grants the specified apps push access for this branch. Only installed GitHub Apps with `write` access to the `contents` permission can be added as authorized actors on a protected branch.  | Type    | Description                                                                                                                                                | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | `array` | The GitHub Apps that have push access to this branch. Use the app's `slug`. **Note**: The list of users, apps, and teams in total is limited to 100 items. |

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposAddAppAccessRestrictionsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.
            var reposSetAppAccessRestrictionsRequest = new ReposSetAppAccessRestrictionsRequest(); // ReposSetAppAccessRestrictionsRequest |  (optional) 

            try
            {
                // Add app access restrictions
                List&lt;GitHubApp&gt; result = apiInstance.ReposAddAppAccessRestrictions(owner, repo, branch, reposSetAppAccessRestrictionsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposAddAppAccessRestrictions: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 
 **reposSetAppAccessRestrictionsRequest** | [**ReposSetAppAccessRestrictionsRequest**](ReposSetAppAccessRestrictionsRequest.md)|  | [optional] 

### Return type

[**List<GitHubApp>**](GitHubApp.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposaddcollaborator"></a>
# **ReposAddCollaborator**
> RepositoryInvitation ReposAddCollaborator (string owner, string repo, string username, ReposAddCollaboratorRequest reposAddCollaboratorRequest)

Add a repository collaborator

This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \"[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\" and \"[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\" for details.  Adding an outside collaborator may be restricted by enterprise administrators. For more information, see \"[Enforcing repository management policies in your enterprise](https://docs.github.com/enterprise-cloud@latest/admin/policies/enforcing-policies-for-your-enterprise/enforcing-repository-management-policies-in-your-enterprise#enforcing-a-policy-for-inviting-outside-collaborators-to-repositories).\"  For more information on permission levels, see \"[Repository permission levels for an organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/repository-permission-levels-for-an-organization#permission-levels-for-repositories-owned-by-an-organization)\". There are restrictions on which permissions can be granted to organization members when an organization base role is in place. In this case, the permission being given must be equal to or higher than the org base permission. Otherwise, the request will fail with:  ``` Cannot assign {member} permission of {role name} ```  Note that, if you choose not to pass any parameters, you'll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see \"[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\"  The invitee will receive a notification that they have been invited to the repository, which they must accept or decline. They may do this via the notifications page, the email they receive, or by using the [repository invitations API endpoints](https://docs.github.com/rest/reference/repos#invitations).  **Updating an existing collaborator's permission level**  The endpoint can also be used to change the permissions of an existing collaborator without first removing and re-adding the collaborator. To change the permissions, use the same endpoint and pass a different `permission` parameter. The response will be a `204`, with no other indication that the permission level changed.  **Rate limits**  You are limited to sending 50 invitations to a repository per 24 hour period. Note there is no limit if you are inviting organization members to an organization repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposAddCollaboratorExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var username = "username_example";  // string | The handle for the GitHub user account.
            var reposAddCollaboratorRequest = new ReposAddCollaboratorRequest(); // ReposAddCollaboratorRequest |  (optional) 

            try
            {
                // Add a repository collaborator
                RepositoryInvitation result = apiInstance.ReposAddCollaborator(owner, repo, username, reposAddCollaboratorRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposAddCollaborator: " + e.Message );
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
 **username** | **string**| The handle for the GitHub user account. | 
 **reposAddCollaboratorRequest** | [**ReposAddCollaboratorRequest**](ReposAddCollaboratorRequest.md)|  | [optional] 

### Return type

[**RepositoryInvitation**](RepositoryInvitation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposaddstatuscheckcontexts"></a>
# **ReposAddStatusCheckContexts**
> List<string> ReposAddStatusCheckContexts (string owner, string repo, string branch, ReposSetStatusCheckContextsRequest reposSetStatusCheckContextsRequest)

Add status check contexts

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposAddStatusCheckContextsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.
            var reposSetStatusCheckContextsRequest = new ReposSetStatusCheckContextsRequest(); // ReposSetStatusCheckContextsRequest |  (optional) 

            try
            {
                // Add status check contexts
                List&lt;string&gt; result = apiInstance.ReposAddStatusCheckContexts(owner, repo, branch, reposSetStatusCheckContextsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposAddStatusCheckContexts: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 
 **reposSetStatusCheckContextsRequest** | [**ReposSetStatusCheckContextsRequest**](ReposSetStatusCheckContextsRequest.md)|  | [optional] 

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposaddteamaccessrestrictions"></a>
# **ReposAddTeamAccessRestrictions**
> List<Team> ReposAddTeamAccessRestrictions (string owner, string repo, string branch, ReposSetTeamAccessRestrictionsRequest reposSetTeamAccessRestrictionsRequest)

Add team access restrictions

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Grants the specified teams push access for this branch. You can also give push access to child teams.  | Type    | Description                                                                                                                                | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | `array` | The teams that can have push access. Use the team's `slug`. **Note**: The list of users, apps, and teams in total is limited to 100 items. |

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposAddTeamAccessRestrictionsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.
            var reposSetTeamAccessRestrictionsRequest = new ReposSetTeamAccessRestrictionsRequest(); // ReposSetTeamAccessRestrictionsRequest |  (optional) 

            try
            {
                // Add team access restrictions
                List&lt;Team&gt; result = apiInstance.ReposAddTeamAccessRestrictions(owner, repo, branch, reposSetTeamAccessRestrictionsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposAddTeamAccessRestrictions: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 
 **reposSetTeamAccessRestrictionsRequest** | [**ReposSetTeamAccessRestrictionsRequest**](ReposSetTeamAccessRestrictionsRequest.md)|  | [optional] 

### Return type

[**List<Team>**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposadduseraccessrestrictions"></a>
# **ReposAddUserAccessRestrictions**
> List<SimpleUser1> ReposAddUserAccessRestrictions (string owner, string repo, string branch, ReposSetUserAccessRestrictionsRequest reposSetUserAccessRestrictionsRequest)

Add user access restrictions

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Grants the specified people push access for this branch.  | Type    | Description                                                                                                                   | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | `array` | Usernames for people who can have push access. **Note**: The list of users, apps, and teams in total is limited to 100 items. |

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposAddUserAccessRestrictionsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.
            var reposSetUserAccessRestrictionsRequest = new ReposSetUserAccessRestrictionsRequest(); // ReposSetUserAccessRestrictionsRequest |  (optional) 

            try
            {
                // Add user access restrictions
                List&lt;SimpleUser1&gt; result = apiInstance.ReposAddUserAccessRestrictions(owner, repo, branch, reposSetUserAccessRestrictionsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposAddUserAccessRestrictions: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 
 **reposSetUserAccessRestrictionsRequest** | [**ReposSetUserAccessRestrictionsRequest**](ReposSetUserAccessRestrictionsRequest.md)|  | [optional] 

### Return type

[**List<SimpleUser1>**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcheckcollaborator"></a>
# **ReposCheckCollaborator**
> void ReposCheckCollaborator (string owner, string repo, string username)

Check if a user is a repository collaborator

For organization-owned repositories, the list of collaborators includes outside collaborators, organization members that are direct collaborators, organization members with access through team memberships, organization members with access through default organization permissions, and organization owners.  Team members will include the members of child teams.  You must authenticate using an access token with the `read:org` and `repo` scopes with push access to use this endpoint. GitHub Apps must have the `members` organization permission and `metadata` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCheckCollaboratorExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Check if a user is a repository collaborator
                apiInstance.ReposCheckCollaborator(owner, repo, username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCheckCollaborator: " + e.Message );
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
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcheckvulnerabilityalerts"></a>
# **ReposCheckVulnerabilityAlerts**
> void ReposCheckVulnerabilityAlerts (string owner, string repo)

Check if vulnerability alerts are enabled for a repository

Shows whether dependency alerts are enabled or disabled for a repository. The authenticated user must have admin read access to the repository. For more information, see \"[About security alerts for vulnerable dependencies](https://docs.github.com/en/articles/about-security-alerts-for-vulnerable-dependencies)\".

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCheckVulnerabilityAlertsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Check if vulnerability alerts are enabled for a repository
                apiInstance.ReposCheckVulnerabilityAlerts(owner, repo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCheckVulnerabilityAlerts: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcodeownerserrors"></a>
# **ReposCodeownersErrors**
> CODEOWNERSErrors ReposCodeownersErrors (string owner, string repo, string _ref)

List CODEOWNERS errors

List any syntax errors that are detected in the CODEOWNERS file.  For more information about the correct CODEOWNERS syntax, see \"[About code owners](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/customizing-your-repository/about-code-owners).\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCodeownersErrorsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var _ref = "_ref_example";  // string | A branch, tag or commit name used to determine which version of the CODEOWNERS file to use. Default: the repository's default branch (e.g. `main`) (optional) 

            try
            {
                // List CODEOWNERS errors
                CODEOWNERSErrors result = apiInstance.ReposCodeownersErrors(owner, repo, _ref);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCodeownersErrors: " + e.Message );
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
 **_ref** | **string**| A branch, tag or commit name used to determine which version of the CODEOWNERS file to use. Default: the repository&#39;s default branch (e.g. &#x60;main&#x60;) | [optional] 

### Return type

[**CODEOWNERSErrors**](CODEOWNERSErrors.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcomparecommits"></a>
# **ReposCompareCommits**
> CommitComparison ReposCompareCommits (string owner, string repo, string basehead, int? page, int? perPage)

Compare two commits

The `basehead` param is comprised of two parts: `base` and `head`. Both must be branch names in `repo`. To compare branches across other repositories in the same network as `repo`, use the format `<USERNAME>:branch`.  The response from the API is equivalent to running the `git log base..head` command; however, commits are returned in chronological order. Pass the appropriate [media type](https://docs.github.com/rest/overview/media-types/#commits-commit-comparison-and-pull-requests) to fetch diff and patch formats.  The response also includes details on the files that were changed between the two commits. This includes the status of the change (for example, if a file was added, removed, modified, or renamed), and details of the change itself. For example, files with a `renamed` status have a `previous_filename` field showing the previous filename of the file, and files with a `modified` status have a `patch` field showing the changes made to the file.  **Working with large comparisons**  To process a response with a large number of commits, you can use (`per_page` or `page`) to paginate the results. When using paging, the list of changed files is only returned with page 1, but includes all changed files for the entire comparison. For more information on working with pagination, see \"[Traversing with pagination](/rest/guides/traversing-with-pagination).\"  When calling this API without any paging parameters (`per_page` or `page`), the returned list is limited to 250 commits and the last commit in the list is the most recent of the entire comparison. When a paging parameter is specified, the first commit in the returned list of each page is the earliest.  **Signature verification object**  The response will include a `verification` object that describes the result of verifying the commit's signature. The following fields are included in the `verification` object:  | Name | Type | Description | | - -- - | - -- - | - -- -- -- -- -- | | `verified` | `boolean` | Indicates whether GitHub considers the signature in this commit to be verified. | | `reason` | `string` | The reason for verified value. Possible values and their meanings are enumerated in table below. | | `signature` | `string` | The signature that was extracted from the commit. | | `payload` | `string` | The value that was signed. |  These are the possible values for `reason` in the `verification` object:  | Value | Description | | - -- -- | - -- -- -- -- -- | | `expired_key` | The key that made the signature is expired. | | `not_signing_key` | The \"signing\" flag is not among the usage flags in the GPG key that made the signature. | | `gpgverify_error` | There was an error communicating with the signature verification service. | | `gpgverify_unavailable` | The signature verification service is currently unavailable. | | `unsigned` | The object does not include a signature. | | `unknown_signature_type` | A non-PGP signature was found in the commit. | | `no_user` | No user was associated with the `committer` email address in the commit. | | `unverified_email` | The `committer` email address in the commit was associated with a user, but the email address is not verified on her/his account. | | `bad_email` | The `committer` email address in the commit is not included in the identities of the PGP key that made the signature. | | `unknown_key` | The key that made the signature has not been registered with any user's account. | | `malformed_signature` | There was an error parsing the signature. | | `invalid` | The signature could not be cryptographically verified using the key whose key-id was found in the signature. | | `valid` | None of the above errors applied, so the signature is considered to be verified. |

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCompareCommitsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var basehead = "basehead_example";  // string | The base branch and head branch to compare. This parameter expects the format `{base}...{head}`.
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)

            try
            {
                // Compare two commits
                CommitComparison result = apiInstance.ReposCompareCommits(owner, repo, basehead, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCompareCommits: " + e.Message );
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
 **basehead** | **string**| The base branch and head branch to compare. This parameter expects the format &#x60;{base}...{head}&#x60;. | 
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]

### Return type

[**CommitComparison**](CommitComparison.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcreateautolink"></a>
# **ReposCreateAutolink**
> AutolinkReference ReposCreateAutolink (string owner, string repo, ReposCreateAutolinkRequest reposCreateAutolinkRequest)

Create an autolink reference for a repository

Users with admin access to the repository can create an autolink.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCreateAutolinkExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var reposCreateAutolinkRequest = new ReposCreateAutolinkRequest(); // ReposCreateAutolinkRequest | 

            try
            {
                // Create an autolink reference for a repository
                AutolinkReference result = apiInstance.ReposCreateAutolink(owner, repo, reposCreateAutolinkRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCreateAutolink: " + e.Message );
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
 **reposCreateAutolinkRequest** | [**ReposCreateAutolinkRequest**](ReposCreateAutolinkRequest.md)|  | 

### Return type

[**AutolinkReference**](AutolinkReference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcreatecommitcomment"></a>
# **ReposCreateCommitComment**
> CommitComment ReposCreateCommitComment (string owner, string repo, string commitSha, ReposCreateCommitCommentRequest reposCreateCommitCommentRequest)

Create a commit comment

Create a comment for a commit using its `:commit_sha`.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \"[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\" and \"[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\" for details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCreateCommitCommentExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commitSha = "commitSha_example";  // string | The SHA of the commit.
            var reposCreateCommitCommentRequest = new ReposCreateCommitCommentRequest(); // ReposCreateCommitCommentRequest | 

            try
            {
                // Create a commit comment
                CommitComment result = apiInstance.ReposCreateCommitComment(owner, repo, commitSha, reposCreateCommitCommentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCreateCommitComment: " + e.Message );
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
 **commitSha** | **string**| The SHA of the commit. | 
 **reposCreateCommitCommentRequest** | [**ReposCreateCommitCommentRequest**](ReposCreateCommitCommentRequest.md)|  | 

### Return type

[**CommitComment**](CommitComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcreatecommitsignatureprotection"></a>
# **ReposCreateCommitSignatureProtection**
> ProtectedBranchAdminEnforced ReposCreateCommitSignatureProtection (string owner, string repo, string branch)

Create commit signature protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  When authenticated with admin or owner permissions to the repository, you can use this endpoint to require signed commits on a branch. You must enable branch protection to require signed commits.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCreateCommitSignatureProtectionExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.

            try
            {
                // Create commit signature protection
                ProtectedBranchAdminEnforced result = apiInstance.ReposCreateCommitSignatureProtection(owner, repo, branch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCreateCommitSignatureProtection: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 

### Return type

[**ProtectedBranchAdminEnforced**](ProtectedBranchAdminEnforced.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcreatecommitstatus"></a>
# **ReposCreateCommitStatus**
> Status ReposCreateCommitStatus (string owner, string repo, string sha, ReposCreateCommitStatusRequest reposCreateCommitStatusRequest)

Create a commit status

Users with push access in a repository can create commit statuses for a given SHA.  Note: there is a limit of 1000 statuses per `sha` and `context` within a repository. Attempts to create more than 1000 statuses will result in a validation error.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCreateCommitStatusExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var sha = "sha_example";  // string | 
            var reposCreateCommitStatusRequest = new ReposCreateCommitStatusRequest(); // ReposCreateCommitStatusRequest | 

            try
            {
                // Create a commit status
                Status result = apiInstance.ReposCreateCommitStatus(owner, repo, sha, reposCreateCommitStatusRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCreateCommitStatus: " + e.Message );
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
 **sha** | **string**|  | 
 **reposCreateCommitStatusRequest** | [**ReposCreateCommitStatusRequest**](ReposCreateCommitStatusRequest.md)|  | 

### Return type

[**Status**](Status.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcreatedeploykey"></a>
# **ReposCreateDeployKey**
> DeployKey ReposCreateDeployKey (string owner, string repo, ReposCreateDeployKeyRequest reposCreateDeployKeyRequest)

Create a deploy key

You can create a read-only deploy key.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCreateDeployKeyExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var reposCreateDeployKeyRequest = new ReposCreateDeployKeyRequest(); // ReposCreateDeployKeyRequest | 

            try
            {
                // Create a deploy key
                DeployKey result = apiInstance.ReposCreateDeployKey(owner, repo, reposCreateDeployKeyRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCreateDeployKey: " + e.Message );
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
 **reposCreateDeployKeyRequest** | [**ReposCreateDeployKeyRequest**](ReposCreateDeployKeyRequest.md)|  | 

### Return type

[**DeployKey**](DeployKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcreatedeployment"></a>
# **ReposCreateDeployment**
> Deployment ReposCreateDeployment (string owner, string repo, ReposCreateDeploymentRequest reposCreateDeploymentRequest)

Create a deployment

Deployments offer a few configurable parameters with certain defaults.  The `ref` parameter can be any named branch, tag, or SHA. At GitHub we often deploy branches and verify them before we merge a pull request.  The `environment` parameter allows deployments to be issued to different runtime environments. Teams often have multiple environments for verifying their applications, such as `production`, `staging`, and `qa`. This parameter makes it easier to track which environments have requested deployments. The default environment is `production`.  The `auto_merge` parameter is used to ensure that the requested ref is not behind the repository's default branch. If the ref _is_ behind the default branch for the repository, we will attempt to merge it for you. If the merge succeeds, the API will return a successful merge commit. If merge conflicts prevent the merge from succeeding, the API will return a failure response.  By default, [commit statuses](https://docs.github.com/rest/commits/statuses) for every submitted context must be in a `success` state. The `required_contexts` parameter allows you to specify a subset of contexts that must be `success`, or to specify contexts that have not yet been submitted. You are not required to use commit statuses to deploy. If you do not require any contexts or create any commit statuses, the deployment will always succeed.  The `payload` parameter is available for any extra information that a deployment system might need. It is a JSON text field that will be passed on when a deployment event is dispatched.  The `task` parameter is used by the deployment system to allow different execution paths. In the web world this might be `deploy:migrations` to run schema changes on the system. In the compiled world this could be a flag to compile an application with debugging enabled.  Users with `repo` or `repo_deployment` scopes can create a deployment for a given ref.  #### Merged branch response You will see this response when GitHub automatically merges the base branch into the topic branch instead of creating a deployment. This auto-merge happens when: *   Auto-merge option is enabled in the repository *   Topic branch does not include the latest changes on the base branch, which is `master` in the response example *   There are no merge conflicts  If there are no new commits in the base branch, a new request to create a deployment should give a successful response.  #### Merge conflict response This error happens when the `auto_merge` option is enabled and when the default branch (in this case `master`), can't be merged into the branch that's being deployed (in this case `topic-branch`), due to merge conflicts.  #### Failed commit status checks This error happens when the `required_contexts` parameter indicates that one or more contexts need to have a `success` status for the commit to be deployed, but one or more of the required contexts do not have a state of `success`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCreateDeploymentExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var reposCreateDeploymentRequest = new ReposCreateDeploymentRequest(); // ReposCreateDeploymentRequest | 

            try
            {
                // Create a deployment
                Deployment result = apiInstance.ReposCreateDeployment(owner, repo, reposCreateDeploymentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCreateDeployment: " + e.Message );
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
 **reposCreateDeploymentRequest** | [**ReposCreateDeploymentRequest**](ReposCreateDeploymentRequest.md)|  | 

### Return type

[**Deployment**](Deployment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcreatedeploymentstatus"></a>
# **ReposCreateDeploymentStatus**
> DeploymentStatus ReposCreateDeploymentStatus (string owner, string repo, int? deploymentId, ReposCreateDeploymentStatusRequest reposCreateDeploymentStatusRequest)

Create a deployment status

Users with `push` access can create deployment statuses for a given deployment.  GitHub Apps require `read & write` access to \"Deployments\" and `read-only` access to \"Repo contents\" (for private repos). OAuth Apps require the `repo_deployment` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCreateDeploymentStatusExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var deploymentId = 56;  // int? | deployment_id parameter
            var reposCreateDeploymentStatusRequest = new ReposCreateDeploymentStatusRequest(); // ReposCreateDeploymentStatusRequest | 

            try
            {
                // Create a deployment status
                DeploymentStatus result = apiInstance.ReposCreateDeploymentStatus(owner, repo, deploymentId, reposCreateDeploymentStatusRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCreateDeploymentStatus: " + e.Message );
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
 **deploymentId** | **int?**| deployment_id parameter | 
 **reposCreateDeploymentStatusRequest** | [**ReposCreateDeploymentStatusRequest**](ReposCreateDeploymentStatusRequest.md)|  | 

### Return type

[**DeploymentStatus**](DeploymentStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcreatedispatchevent"></a>
# **ReposCreateDispatchEvent**
> void ReposCreateDispatchEvent (string owner, string repo, ReposCreateDispatchEventRequest reposCreateDispatchEventRequest)

Create a repository dispatch event

You can use this endpoint to trigger a webhook event called `repository_dispatch` when you want activity that happens outside of GitHub to trigger a GitHub Actions workflow or GitHub App webhook. You must configure your GitHub Actions workflow or GitHub App to run when the `repository_dispatch` event occurs. For an example `repository_dispatch` webhook payload, see \"[RepositoryDispatchEvent](https://docs.github.com/webhooks/event-payloads/#repository_dispatch).\"  The `client_payload` parameter is available for any extra information that your workflow might need. This parameter is a JSON payload that will be passed on when the webhook event is dispatched. For example, the `client_payload` can include a message that a user would like to send using a GitHub Actions workflow. Or the `client_payload` can be used as a test to debug your workflow.  This endpoint requires write access to the repository by providing either:    - Personal access tokens with `repo` scope. For more information, see \"[Creating a personal access token for the command line](https://docs.github.com/articles/creating-a-personal-access-token-for-the-command-line)\" in the GitHub Help documentation.   - GitHub Apps with both `metadata:read` and `contents:read&write` permissions.  This input example shows how you can use the `client_payload` as a test to debug your workflow.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCreateDispatchEventExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var reposCreateDispatchEventRequest = new ReposCreateDispatchEventRequest(); // ReposCreateDispatchEventRequest | 

            try
            {
                // Create a repository dispatch event
                apiInstance.ReposCreateDispatchEvent(owner, repo, reposCreateDispatchEventRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCreateDispatchEvent: " + e.Message );
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
 **reposCreateDispatchEventRequest** | [**ReposCreateDispatchEventRequest**](ReposCreateDispatchEventRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcreateforauthenticateduser"></a>
# **ReposCreateForAuthenticatedUser**
> Repository ReposCreateForAuthenticatedUser (ReposCreateForAuthenticatedUserRequest reposCreateForAuthenticatedUserRequest)

Create a repository for the authenticated user

Creates a new repository for the authenticated user.  **OAuth scope requirements**  When using [OAuth](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/), authorizations must include:  *   `public_repo` scope or `repo` scope to create a public repository. Note: For GitHub AE, use `repo` scope to create an internal repository. *   `repo` scope to create a private repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCreateForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var reposCreateForAuthenticatedUserRequest = new ReposCreateForAuthenticatedUserRequest(); // ReposCreateForAuthenticatedUserRequest | 

            try
            {
                // Create a repository for the authenticated user
                Repository result = apiInstance.ReposCreateForAuthenticatedUser(reposCreateForAuthenticatedUserRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCreateForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reposCreateForAuthenticatedUserRequest** | [**ReposCreateForAuthenticatedUserRequest**](ReposCreateForAuthenticatedUserRequest.md)|  | 

### Return type

[**Repository**](Repository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/scim+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcreatefork"></a>
# **ReposCreateFork**
> FullRepository ReposCreateFork (string owner, string repo, ReposCreateForkRequest reposCreateForkRequest)

Create a fork

Create a fork for the authenticated user.  **Note**: Forking a Repository happens asynchronously. You may have to wait a short period of time before you can access the git objects. If this takes longer than 5 minutes, be sure to contact [GitHub Support](https://support.github.com/contact?tags=dotcom-rest-api).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCreateForkExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var reposCreateForkRequest = new ReposCreateForkRequest(); // ReposCreateForkRequest |  (optional) 

            try
            {
                // Create a fork
                FullRepository result = apiInstance.ReposCreateFork(owner, repo, reposCreateForkRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCreateFork: " + e.Message );
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
 **reposCreateForkRequest** | [**ReposCreateForkRequest**](ReposCreateForkRequest.md)|  | [optional] 

### Return type

[**FullRepository**](FullRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/scim+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcreateinorg"></a>
# **ReposCreateInOrg**
> Repository ReposCreateInOrg (string org, ReposCreateInOrgRequest reposCreateInOrgRequest)

Create an organization repository

Creates a new repository in the specified organization. The authenticated user must be a member of the organization.  **OAuth scope requirements**  When using [OAuth](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/), authorizations must include:  *   `public_repo` scope or `repo` scope to create a public repository. Note: For GitHub AE, use `repo` scope to create an internal repository. *   `repo` scope to create a private repository

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCreateInOrgExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var reposCreateInOrgRequest = new ReposCreateInOrgRequest(); // ReposCreateInOrgRequest | 

            try
            {
                // Create an organization repository
                Repository result = apiInstance.ReposCreateInOrg(org, reposCreateInOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCreateInOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **reposCreateInOrgRequest** | [**ReposCreateInOrgRequest**](ReposCreateInOrgRequest.md)|  | 

### Return type

[**Repository**](Repository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcreateorupdateenvironment"></a>
# **ReposCreateOrUpdateEnvironment**
> Environment ReposCreateOrUpdateEnvironment (string owner, string repo, string environmentName, ReposCreateOrUpdateEnvironmentRequest reposCreateOrUpdateEnvironmentRequest)

Create or update an environment

Create or update an environment with protection rules, such as required reviewers. For more information about environment protection rules, see \"[Environments](/actions/reference/environments#environment-protection-rules).\"  **Note:** Although you can use this operation to specify that only branches that match specified name patterns can deploy to this environment, you must use the UI to set the name patterns. For more information, see \"[Environments](/actions/reference/environments#deployment-branches).\"  **Note:** To create or update secrets for an environment, see \"[Secrets](/rest/reference/actions#secrets).\"  You must authenticate using an access token with the repo scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCreateOrUpdateEnvironmentExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var environmentName = "environmentName_example";  // string | The name of the environment
            var reposCreateOrUpdateEnvironmentRequest = new ReposCreateOrUpdateEnvironmentRequest(); // ReposCreateOrUpdateEnvironmentRequest |  (optional) 

            try
            {
                // Create or update an environment
                Environment result = apiInstance.ReposCreateOrUpdateEnvironment(owner, repo, environmentName, reposCreateOrUpdateEnvironmentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCreateOrUpdateEnvironment: " + e.Message );
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
 **environmentName** | **string**| The name of the environment | 
 **reposCreateOrUpdateEnvironmentRequest** | [**ReposCreateOrUpdateEnvironmentRequest**](ReposCreateOrUpdateEnvironmentRequest.md)|  | [optional] 

### Return type

[**Environment**](Environment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcreateorupdatefilecontents"></a>
# **ReposCreateOrUpdateFileContents**
> FileCommit ReposCreateOrUpdateFileContents (string owner, string repo, string path, ReposCreateOrUpdateFileContentsRequest reposCreateOrUpdateFileContentsRequest)

Create or update file contents

Creates a new file or replaces an existing file in a repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCreateOrUpdateFileContentsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var path = "path_example";  // string | path parameter
            var reposCreateOrUpdateFileContentsRequest = new ReposCreateOrUpdateFileContentsRequest(); // ReposCreateOrUpdateFileContentsRequest | 

            try
            {
                // Create or update file contents
                FileCommit result = apiInstance.ReposCreateOrUpdateFileContents(owner, repo, path, reposCreateOrUpdateFileContentsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCreateOrUpdateFileContents: " + e.Message );
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
 **path** | **string**| path parameter | 
 **reposCreateOrUpdateFileContentsRequest** | [**ReposCreateOrUpdateFileContentsRequest**](ReposCreateOrUpdateFileContentsRequest.md)|  | 

### Return type

[**FileCommit**](FileCommit.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcreatepagesdeployment"></a>
# **ReposCreatePagesDeployment**
> GitHubPages1 ReposCreatePagesDeployment (string owner, string repo, ReposCreatePagesDeploymentRequest reposCreatePagesDeploymentRequest)

Create a GitHub Pages deployment

Create a GitHub Pages deployment for a repository.  Users must have write permissions. GitHub Apps must have the `pages:write` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCreatePagesDeploymentExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var reposCreatePagesDeploymentRequest = new ReposCreatePagesDeploymentRequest(); // ReposCreatePagesDeploymentRequest | 

            try
            {
                // Create a GitHub Pages deployment
                GitHubPages1 result = apiInstance.ReposCreatePagesDeployment(owner, repo, reposCreatePagesDeploymentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCreatePagesDeployment: " + e.Message );
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
 **reposCreatePagesDeploymentRequest** | [**ReposCreatePagesDeploymentRequest**](ReposCreatePagesDeploymentRequest.md)|  | 

### Return type

[**GitHubPages1**](GitHubPages1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/scim+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcreatepagessite"></a>
# **ReposCreatePagesSite**
> GitHubPages ReposCreatePagesSite (string owner, string repo, ReposCreatePagesSiteRequest reposCreatePagesSiteRequest)

Create a GitHub Pages site

Configures a GitHub Pages site. For more information, see \"[About GitHub Pages](/github/working-with-github-pages/about-github-pages).\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCreatePagesSiteExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var reposCreatePagesSiteRequest = new ReposCreatePagesSiteRequest(); // ReposCreatePagesSiteRequest | 

            try
            {
                // Create a GitHub Pages site
                GitHubPages result = apiInstance.ReposCreatePagesSite(owner, repo, reposCreatePagesSiteRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCreatePagesSite: " + e.Message );
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
 **reposCreatePagesSiteRequest** | [**ReposCreatePagesSiteRequest**](ReposCreatePagesSiteRequest.md)|  | 

### Return type

[**GitHubPages**](GitHubPages.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcreaterelease"></a>
# **ReposCreateRelease**
> Release ReposCreateRelease (string owner, string repo, ReposCreateReleaseRequest reposCreateReleaseRequest)

Create a release

Users with push access to the repository can create a release.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \"[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\" and \"[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\" for details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCreateReleaseExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var reposCreateReleaseRequest = new ReposCreateReleaseRequest(); // ReposCreateReleaseRequest | 

            try
            {
                // Create a release
                Release result = apiInstance.ReposCreateRelease(owner, repo, reposCreateReleaseRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCreateRelease: " + e.Message );
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
 **reposCreateReleaseRequest** | [**ReposCreateReleaseRequest**](ReposCreateReleaseRequest.md)|  | 

### Return type

[**Release**](Release.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcreatetagprotection"></a>
# **ReposCreateTagProtection**
> TagProtection ReposCreateTagProtection (string owner, string repo, ReposCreateTagProtectionRequest reposCreateTagProtectionRequest)

Create a tag protection state for a repository

This creates a tag protection state for a repository. This endpoint is only available to repository administrators.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCreateTagProtectionExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var reposCreateTagProtectionRequest = new ReposCreateTagProtectionRequest(); // ReposCreateTagProtectionRequest | 

            try
            {
                // Create a tag protection state for a repository
                TagProtection result = apiInstance.ReposCreateTagProtection(owner, repo, reposCreateTagProtectionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCreateTagProtection: " + e.Message );
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
 **reposCreateTagProtectionRequest** | [**ReposCreateTagProtectionRequest**](ReposCreateTagProtectionRequest.md)|  | 

### Return type

[**TagProtection**](TagProtection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcreateusingtemplate"></a>
# **ReposCreateUsingTemplate**
> Repository ReposCreateUsingTemplate (string templateOwner, string templateRepo, ReposCreateUsingTemplateRequest reposCreateUsingTemplateRequest)

Create a repository using a template

Creates a new repository using a repository template. Use the `template_owner` and `template_repo` route parameters to specify the repository to use as the template. The authenticated user must own or be a member of an organization that owns the repository. To check if a repository is available to use as a template, get the repository's information using the [Get a repository](https://docs.github.com/rest/reference/repos#get-a-repository) endpoint and check that the `is_template` key is `true`.  **OAuth scope requirements**  When using [OAuth](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/), authorizations must include:  *   `public_repo` scope or `repo` scope to create a public repository. Note: For GitHub AE, use `repo` scope to create an internal repository. *   `repo` scope to create a private repository

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCreateUsingTemplateExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var templateOwner = "templateOwner_example";  // string | 
            var templateRepo = "templateRepo_example";  // string | 
            var reposCreateUsingTemplateRequest = new ReposCreateUsingTemplateRequest(); // ReposCreateUsingTemplateRequest | 

            try
            {
                // Create a repository using a template
                Repository result = apiInstance.ReposCreateUsingTemplate(templateOwner, templateRepo, reposCreateUsingTemplateRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCreateUsingTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateOwner** | **string**|  | 
 **templateRepo** | **string**|  | 
 **reposCreateUsingTemplateRequest** | [**ReposCreateUsingTemplateRequest**](ReposCreateUsingTemplateRequest.md)|  | 

### Return type

[**Repository**](Repository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposcreatewebhook"></a>
# **ReposCreateWebhook**
> Webhook ReposCreateWebhook (string owner, string repo, ReposCreateWebhookRequest reposCreateWebhookRequest)

Create a repository webhook

Repositories can have multiple webhooks installed. Each webhook should have a unique `config`. Multiple webhooks can share the same `config` as long as those webhooks do not have any `events` that overlap.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposCreateWebhookExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var reposCreateWebhookRequest = new ReposCreateWebhookRequest(); // ReposCreateWebhookRequest |  (optional) 

            try
            {
                // Create a repository webhook
                Webhook result = apiInstance.ReposCreateWebhook(owner, repo, reposCreateWebhookRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposCreateWebhook: " + e.Message );
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
 **reposCreateWebhookRequest** | [**ReposCreateWebhookRequest**](ReposCreateWebhookRequest.md)|  | [optional] 

### Return type

[**Webhook**](Webhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdeclineinvitationforauthenticateduser"></a>
# **ReposDeclineInvitationForAuthenticatedUser**
> void ReposDeclineInvitationForAuthenticatedUser (int? invitationId)

Decline a repository invitation



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDeclineInvitationForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var invitationId = 56;  // int? | The unique identifier of the invitation.

            try
            {
                // Decline a repository invitation
                apiInstance.ReposDeclineInvitationForAuthenticatedUser(invitationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDeclineInvitationForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invitationId** | **int?**| The unique identifier of the invitation. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdelete"></a>
# **ReposDelete**
> void ReposDelete (string owner, string repo)

Delete a repository

Deleting a repository requires admin access. If OAuth is used, the `delete_repo` scope is required.  If an organization owner has configured the organization to prevent members from deleting organization-owned repositories, you will get a `403 Forbidden` response.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDeleteExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Delete a repository
                apiInstance.ReposDelete(owner, repo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDelete: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdeleteaccessrestrictions"></a>
# **ReposDeleteAccessRestrictions**
> void ReposDeleteAccessRestrictions (string owner, string repo, string branch)

Delete access restrictions

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Disables the ability to restrict who can push to this branch.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDeleteAccessRestrictionsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.

            try
            {
                // Delete access restrictions
                apiInstance.ReposDeleteAccessRestrictions(owner, repo, branch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDeleteAccessRestrictions: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdeleteadminbranchprotection"></a>
# **ReposDeleteAdminBranchProtection**
> void ReposDeleteAdminBranchProtection (string owner, string repo, string branch)

Delete admin branch protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Removing admin enforcement requires admin or owner permissions to the repository and branch protection to be enabled.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDeleteAdminBranchProtectionExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.

            try
            {
                // Delete admin branch protection
                apiInstance.ReposDeleteAdminBranchProtection(owner, repo, branch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDeleteAdminBranchProtection: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdeleteanenvironment"></a>
# **ReposDeleteAnEnvironment**
> void ReposDeleteAnEnvironment (string owner, string repo, string environmentName)

Delete an environment

You must authenticate using an access token with the repo scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDeleteAnEnvironmentExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var environmentName = "environmentName_example";  // string | The name of the environment

            try
            {
                // Delete an environment
                apiInstance.ReposDeleteAnEnvironment(owner, repo, environmentName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDeleteAnEnvironment: " + e.Message );
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
 **environmentName** | **string**| The name of the environment | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdeleteautolink"></a>
# **ReposDeleteAutolink**
> void ReposDeleteAutolink (string owner, string repo, int? autolinkId)

Delete an autolink reference from a repository

This deletes a single autolink reference by ID that was configured for the given repository.  Information about autolinks are only available to repository administrators.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDeleteAutolinkExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var autolinkId = 56;  // int? | The unique identifier of the autolink.

            try
            {
                // Delete an autolink reference from a repository
                apiInstance.ReposDeleteAutolink(owner, repo, autolinkId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDeleteAutolink: " + e.Message );
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
 **autolinkId** | **int?**| The unique identifier of the autolink. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdeletebranchprotection"></a>
# **ReposDeleteBranchProtection**
> void ReposDeleteBranchProtection (string owner, string repo, string branch)

Delete branch protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDeleteBranchProtectionExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.

            try
            {
                // Delete branch protection
                apiInstance.ReposDeleteBranchProtection(owner, repo, branch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDeleteBranchProtection: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdeletecommitcomment"></a>
# **ReposDeleteCommitComment**
> void ReposDeleteCommitComment (string owner, string repo, int? commentId)

Delete a commit comment



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDeleteCommitCommentExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commentId = 56;  // int? | The unique identifier of the comment.

            try
            {
                // Delete a commit comment
                apiInstance.ReposDeleteCommitComment(owner, repo, commentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDeleteCommitComment: " + e.Message );
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
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdeletecommitsignatureprotection"></a>
# **ReposDeleteCommitSignatureProtection**
> void ReposDeleteCommitSignatureProtection (string owner, string repo, string branch)

Delete commit signature protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  When authenticated with admin or owner permissions to the repository, you can use this endpoint to disable required signed commits on a branch. You must enable branch protection to require signed commits.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDeleteCommitSignatureProtectionExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.

            try
            {
                // Delete commit signature protection
                apiInstance.ReposDeleteCommitSignatureProtection(owner, repo, branch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDeleteCommitSignatureProtection: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdeletedeploykey"></a>
# **ReposDeleteDeployKey**
> void ReposDeleteDeployKey (string owner, string repo, int? keyId)

Delete a deploy key

Deploy keys are immutable. If you need to update a key, remove the key and create a new one instead.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDeleteDeployKeyExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var keyId = 56;  // int? | The unique identifier of the key.

            try
            {
                // Delete a deploy key
                apiInstance.ReposDeleteDeployKey(owner, repo, keyId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDeleteDeployKey: " + e.Message );
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
 **keyId** | **int?**| The unique identifier of the key. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdeletedeployment"></a>
# **ReposDeleteDeployment**
> void ReposDeleteDeployment (string owner, string repo, int? deploymentId)

Delete a deployment

If the repository only has one deployment, you can delete the deployment regardless of its status. If the repository has more than one deployment, you can only delete inactive deployments. This ensures that repositories with multiple deployments will always have an active deployment. Anyone with `repo` or `repo_deployment` scopes can delete a deployment.  To set a deployment as inactive, you must:  *   Create a new deployment that is active so that the system has a record of the current state, then delete the previously active deployment. *   Mark the active deployment as inactive by adding any non-successful deployment status.  For more information, see \"[Create a deployment](https://docs.github.com/rest/reference/repos/#create-a-deployment)\" and \"[Create a deployment status](https://docs.github.com/rest/reference/repos#create-a-deployment-status).\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDeleteDeploymentExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var deploymentId = 56;  // int? | deployment_id parameter

            try
            {
                // Delete a deployment
                apiInstance.ReposDeleteDeployment(owner, repo, deploymentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDeleteDeployment: " + e.Message );
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
 **deploymentId** | **int?**| deployment_id parameter | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdeletefile"></a>
# **ReposDeleteFile**
> FileCommit ReposDeleteFile (string owner, string repo, string path, ReposDeleteFileRequest reposDeleteFileRequest)

Delete a file

Deletes a file in a repository.  You can provide an additional `committer` parameter, which is an object containing information about the committer. Or, you can provide an `author` parameter, which is an object containing information about the author.  The `author` section is optional and is filled in with the `committer` information if omitted. If the `committer` information is omitted, the authenticated user's information is used.  You must provide values for both `name` and `email`, whether you choose to use `author` or `committer`. Otherwise, you'll receive a `422` status code.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDeleteFileExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var path = "path_example";  // string | path parameter
            var reposDeleteFileRequest = new ReposDeleteFileRequest(); // ReposDeleteFileRequest | 

            try
            {
                // Delete a file
                FileCommit result = apiInstance.ReposDeleteFile(owner, repo, path, reposDeleteFileRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDeleteFile: " + e.Message );
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
 **path** | **string**| path parameter | 
 **reposDeleteFileRequest** | [**ReposDeleteFileRequest**](ReposDeleteFileRequest.md)|  | 

### Return type

[**FileCommit**](FileCommit.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdeleteinvitation"></a>
# **ReposDeleteInvitation**
> void ReposDeleteInvitation (string owner, string repo, int? invitationId)

Delete a repository invitation



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDeleteInvitationExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var invitationId = 56;  // int? | The unique identifier of the invitation.

            try
            {
                // Delete a repository invitation
                apiInstance.ReposDeleteInvitation(owner, repo, invitationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDeleteInvitation: " + e.Message );
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
 **invitationId** | **int?**| The unique identifier of the invitation. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdeletepagessite"></a>
# **ReposDeletePagesSite**
> void ReposDeletePagesSite (string owner, string repo)

Delete a GitHub Pages site



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDeletePagesSiteExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Delete a GitHub Pages site
                apiInstance.ReposDeletePagesSite(owner, repo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDeletePagesSite: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdeletepullrequestreviewprotection"></a>
# **ReposDeletePullRequestReviewProtection**
> void ReposDeletePullRequestReviewProtection (string owner, string repo, string branch)

Delete pull request review protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDeletePullRequestReviewProtectionExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.

            try
            {
                // Delete pull request review protection
                apiInstance.ReposDeletePullRequestReviewProtection(owner, repo, branch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDeletePullRequestReviewProtection: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdeleterelease"></a>
# **ReposDeleteRelease**
> void ReposDeleteRelease (string owner, string repo, int? releaseId)

Delete a release

Users with push access to the repository can delete a release.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDeleteReleaseExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var releaseId = 56;  // int? | The unique identifier of the release.

            try
            {
                // Delete a release
                apiInstance.ReposDeleteRelease(owner, repo, releaseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDeleteRelease: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdeletereleaseasset"></a>
# **ReposDeleteReleaseAsset**
> void ReposDeleteReleaseAsset (string owner, string repo, int? assetId)

Delete a release asset



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDeleteReleaseAssetExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var assetId = 56;  // int? | The unique identifier of the asset.

            try
            {
                // Delete a release asset
                apiInstance.ReposDeleteReleaseAsset(owner, repo, assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDeleteReleaseAsset: " + e.Message );
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
 **assetId** | **int?**| The unique identifier of the asset. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdeletetagprotection"></a>
# **ReposDeleteTagProtection**
> void ReposDeleteTagProtection (string owner, string repo, int? tagProtectionId)

Delete a tag protection state for a repository

This deletes a tag protection state for a repository. This endpoint is only available to repository administrators.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDeleteTagProtectionExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var tagProtectionId = 56;  // int? | The unique identifier of the tag protection.

            try
            {
                // Delete a tag protection state for a repository
                apiInstance.ReposDeleteTagProtection(owner, repo, tagProtectionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDeleteTagProtection: " + e.Message );
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
 **tagProtectionId** | **int?**| The unique identifier of the tag protection. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdeletewebhook"></a>
# **ReposDeleteWebhook**
> void ReposDeleteWebhook (string owner, string repo, int? hookId)

Delete a repository webhook



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDeleteWebhookExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var hookId = 56;  // int? | The unique identifier of the hook.

            try
            {
                // Delete a repository webhook
                apiInstance.ReposDeleteWebhook(owner, repo, hookId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDeleteWebhook: " + e.Message );
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
 **hookId** | **int?**| The unique identifier of the hook. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdisableautomatedsecurityfixes"></a>
# **ReposDisableAutomatedSecurityFixes**
> void ReposDisableAutomatedSecurityFixes (string owner, string repo)

Disable automated security fixes

Disables automated security fixes for a repository. The authenticated user must have admin access to the repository. For more information, see \"[Configuring automated security fixes](https://docs.github.com/en/articles/configuring-automated-security-fixes)\".

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDisableAutomatedSecurityFixesExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Disable automated security fixes
                apiInstance.ReposDisableAutomatedSecurityFixes(owner, repo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDisableAutomatedSecurityFixes: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdisablelfsforrepo"></a>
# **ReposDisableLfsForRepo**
> void ReposDisableLfsForRepo (string owner, string repo)

Disable Git LFS for a repository



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDisableLfsForRepoExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Disable Git LFS for a repository
                apiInstance.ReposDisableLfsForRepo(owner, repo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDisableLfsForRepo: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdisablevulnerabilityalerts"></a>
# **ReposDisableVulnerabilityAlerts**
> void ReposDisableVulnerabilityAlerts (string owner, string repo)

Disable vulnerability alerts

Disables dependency alerts and the dependency graph for a repository. The authenticated user must have admin access to the repository. For more information, see \"[About security alerts for vulnerable dependencies](https://docs.github.com/en/articles/about-security-alerts-for-vulnerable-dependencies)\".

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDisableVulnerabilityAlertsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Disable vulnerability alerts
                apiInstance.ReposDisableVulnerabilityAlerts(owner, repo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDisableVulnerabilityAlerts: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdownloadtarballarchive"></a>
# **ReposDownloadTarballArchive**
> void ReposDownloadTarballArchive (string owner, string repo, string _ref)

Download a repository archive (tar)

Gets a redirect URL to download a tar archive for a repository. If you omit `:ref`, the repository’s default branch (usually `master`) will be used. Please make sure your HTTP framework is configured to follow redirects or you will need to use the `Location` header to make a second `GET` request. **Note**: For private repositories, these links are temporary and expire after five minutes.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDownloadTarballArchiveExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var _ref = "_ref_example";  // string | 

            try
            {
                // Download a repository archive (tar)
                apiInstance.ReposDownloadTarballArchive(owner, repo, _ref);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDownloadTarballArchive: " + e.Message );
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
 **_ref** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposdownloadzipballarchive"></a>
# **ReposDownloadZipballArchive**
> void ReposDownloadZipballArchive (string owner, string repo, string _ref)

Download a repository archive (zip)

Gets a redirect URL to download a zip archive for a repository. If you omit `:ref`, the repository’s default branch (usually `master`) will be used. Please make sure your HTTP framework is configured to follow redirects or you will need to use the `Location` header to make a second `GET` request.  **Note**: For private repositories, these links are temporary and expire after five minutes. If the repository is empty, you will receive a 404 when you follow the redirect.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposDownloadZipballArchiveExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var _ref = "_ref_example";  // string | 

            try
            {
                // Download a repository archive (zip)
                apiInstance.ReposDownloadZipballArchive(owner, repo, _ref);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposDownloadZipballArchive: " + e.Message );
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
 **_ref** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposenableautomatedsecurityfixes"></a>
# **ReposEnableAutomatedSecurityFixes**
> void ReposEnableAutomatedSecurityFixes (string owner, string repo)

Enable automated security fixes

Enables automated security fixes for a repository. The authenticated user must have admin access to the repository. For more information, see \"[Configuring automated security fixes](https://docs.github.com/en/articles/configuring-automated-security-fixes)\".

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposEnableAutomatedSecurityFixesExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Enable automated security fixes
                apiInstance.ReposEnableAutomatedSecurityFixes(owner, repo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposEnableAutomatedSecurityFixes: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposenablelfsforrepo"></a>
# **ReposEnableLfsForRepo**
> Object ReposEnableLfsForRepo (string owner, string repo)

Enable Git LFS for a repository



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposEnableLfsForRepoExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Enable Git LFS for a repository
                Object result = apiInstance.ReposEnableLfsForRepo(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposEnableLfsForRepo: " + e.Message );
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

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposenablevulnerabilityalerts"></a>
# **ReposEnableVulnerabilityAlerts**
> void ReposEnableVulnerabilityAlerts (string owner, string repo)

Enable vulnerability alerts

Enables dependency alerts and the dependency graph for a repository. The authenticated user must have admin access to the repository. For more information, see \"[About security alerts for vulnerable dependencies](https://docs.github.com/en/articles/about-security-alerts-for-vulnerable-dependencies)\".

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposEnableVulnerabilityAlertsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Enable vulnerability alerts
                apiInstance.ReposEnableVulnerabilityAlerts(owner, repo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposEnableVulnerabilityAlerts: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgeneratereleasenotes"></a>
# **ReposGenerateReleaseNotes**
> GeneratedReleaseNotesContent ReposGenerateReleaseNotes (string owner, string repo, ReposGenerateReleaseNotesRequest reposGenerateReleaseNotesRequest)

Generate release notes content for a release

Generate a name and body describing a [release](https://docs.github.com/rest/reference/repos#releases). The body content will be markdown formatted and contain information like the changes since last release and users who contributed. The generated release notes are not saved anywhere. They are intended to be generated and used when creating a new release.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGenerateReleaseNotesExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var reposGenerateReleaseNotesRequest = new ReposGenerateReleaseNotesRequest(); // ReposGenerateReleaseNotesRequest | 

            try
            {
                // Generate release notes content for a release
                GeneratedReleaseNotesContent result = apiInstance.ReposGenerateReleaseNotes(owner, repo, reposGenerateReleaseNotesRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGenerateReleaseNotes: " + e.Message );
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
 **reposGenerateReleaseNotesRequest** | [**ReposGenerateReleaseNotesRequest**](ReposGenerateReleaseNotesRequest.md)|  | 

### Return type

[**GeneratedReleaseNotesContent**](GeneratedReleaseNotesContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposget"></a>
# **ReposGet**
> FullRepository ReposGet (string owner, string repo)

Get a repository

The `parent` and `source` objects are present when the repository is a fork. `parent` is the repository this repository was forked from, `source` is the ultimate source for the network.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get a repository
                FullRepository result = apiInstance.ReposGet(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGet: " + e.Message );
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

[**FullRepository**](FullRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetaccessrestrictions"></a>
# **ReposGetAccessRestrictions**
> BranchRestrictionPolicy ReposGetAccessRestrictions (string owner, string repo, string branch)

Get access restrictions

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Lists who has access to this protected branch.  **Note**: Users, apps, and teams `restrictions` are only available for organization-owned repositories.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetAccessRestrictionsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.

            try
            {
                // Get access restrictions
                BranchRestrictionPolicy result = apiInstance.ReposGetAccessRestrictions(owner, repo, branch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetAccessRestrictions: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 

### Return type

[**BranchRestrictionPolicy**](BranchRestrictionPolicy.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetadminbranchprotection"></a>
# **ReposGetAdminBranchProtection**
> ProtectedBranchAdminEnforced ReposGetAdminBranchProtection (string owner, string repo, string branch)

Get admin branch protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetAdminBranchProtectionExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.

            try
            {
                // Get admin branch protection
                ProtectedBranchAdminEnforced result = apiInstance.ReposGetAdminBranchProtection(owner, repo, branch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetAdminBranchProtection: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 

### Return type

[**ProtectedBranchAdminEnforced**](ProtectedBranchAdminEnforced.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetallenvironments"></a>
# **ReposGetAllEnvironments**
> ReposGetAllEnvironments200Response ReposGetAllEnvironments (string owner, string repo, int? perPage, int? page)

Get all environments

Get all environments for a repository.  Anyone with read access to the repository can use this endpoint. If the repository is private, you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetAllEnvironmentsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // Get all environments
                ReposGetAllEnvironments200Response result = apiInstance.ReposGetAllEnvironments(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetAllEnvironments: " + e.Message );
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

[**ReposGetAllEnvironments200Response**](ReposGetAllEnvironments200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetallstatuscheckcontexts"></a>
# **ReposGetAllStatusCheckContexts**
> List<string> ReposGetAllStatusCheckContexts (string owner, string repo, string branch)

Get all status check contexts

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetAllStatusCheckContextsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.

            try
            {
                // Get all status check contexts
                List&lt;string&gt; result = apiInstance.ReposGetAllStatusCheckContexts(owner, repo, branch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetAllStatusCheckContexts: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetalltopics"></a>
# **ReposGetAllTopics**
> Topic ReposGetAllTopics (string owner, string repo, int? page, int? perPage)

Get all repository topics



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetAllTopicsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)

            try
            {
                // Get all repository topics
                Topic result = apiInstance.ReposGetAllTopics(owner, repo, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetAllTopics: " + e.Message );
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
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]

### Return type

[**Topic**](Topic.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetappswithaccesstoprotectedbranch"></a>
# **ReposGetAppsWithAccessToProtectedBranch**
> List<GitHubApp> ReposGetAppsWithAccessToProtectedBranch (string owner, string repo, string branch)

Get apps with access to the protected branch

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Lists the GitHub Apps that have push access to this branch. Only installed GitHub Apps with `write` access to the `contents` permission can be added as authorized actors on a protected branch.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetAppsWithAccessToProtectedBranchExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.

            try
            {
                // Get apps with access to the protected branch
                List&lt;GitHubApp&gt; result = apiInstance.ReposGetAppsWithAccessToProtectedBranch(owner, repo, branch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetAppsWithAccessToProtectedBranch: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 

### Return type

[**List<GitHubApp>**](GitHubApp.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetautolink"></a>
# **ReposGetAutolink**
> AutolinkReference ReposGetAutolink (string owner, string repo, int? autolinkId)

Get an autolink reference of a repository

This returns a single autolink reference by ID that was configured for the given repository.  Information about autolinks are only available to repository administrators.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetAutolinkExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var autolinkId = 56;  // int? | The unique identifier of the autolink.

            try
            {
                // Get an autolink reference of a repository
                AutolinkReference result = apiInstance.ReposGetAutolink(owner, repo, autolinkId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetAutolink: " + e.Message );
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
 **autolinkId** | **int?**| The unique identifier of the autolink. | 

### Return type

[**AutolinkReference**](AutolinkReference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetbranch"></a>
# **ReposGetBranch**
> BranchWithProtection ReposGetBranch (string owner, string repo, string branch)

Get a branch



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetBranchExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.

            try
            {
                // Get a branch
                BranchWithProtection result = apiInstance.ReposGetBranch(owner, repo, branch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetBranch: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 

### Return type

[**BranchWithProtection**](BranchWithProtection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetbranchprotection"></a>
# **ReposGetBranchProtection**
> BranchProtection ReposGetBranchProtection (string owner, string repo, string branch)

Get branch protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetBranchProtectionExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.

            try
            {
                // Get branch protection
                BranchProtection result = apiInstance.ReposGetBranchProtection(owner, repo, branch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetBranchProtection: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 

### Return type

[**BranchProtection**](BranchProtection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetclones"></a>
# **ReposGetClones**
> CloneTraffic ReposGetClones (string owner, string repo, string per)

Get repository clones

Get the total number of clones and breakdown per day or week for the last 14 days. Timestamps are aligned to UTC midnight of the beginning of the day or week. Week begins on Monday.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetClonesExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var per = "";  // string | The time frame to display results for. (optional)  (default to day)

            try
            {
                // Get repository clones
                CloneTraffic result = apiInstance.ReposGetClones(owner, repo, per);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetClones: " + e.Message );
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
 **per** | **string**| The time frame to display results for. | [optional] [default to day]

### Return type

[**CloneTraffic**](CloneTraffic.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetcodefrequencystats"></a>
# **ReposGetCodeFrequencyStats**
> List<List<int?>> ReposGetCodeFrequencyStats (string owner, string repo)

Get the weekly commit activity

Returns a weekly aggregate of the number of additions and deletions pushed to a repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetCodeFrequencyStatsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get the weekly commit activity
                List&lt;List&lt;int?&gt;&gt; result = apiInstance.ReposGetCodeFrequencyStats(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetCodeFrequencyStats: " + e.Message );
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

**List<List<int?>>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetcollaboratorpermissionlevel"></a>
# **ReposGetCollaboratorPermissionLevel**
> RepositoryCollaboratorPermission ReposGetCollaboratorPermissionLevel (string owner, string repo, string username)

Get repository permissions for a user

Checks the repository permission of a collaborator. The possible repository permissions are `admin`, `write`, `read`, and `none`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetCollaboratorPermissionLevelExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Get repository permissions for a user
                RepositoryCollaboratorPermission result = apiInstance.ReposGetCollaboratorPermissionLevel(owner, repo, username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetCollaboratorPermissionLevel: " + e.Message );
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
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

[**RepositoryCollaboratorPermission**](RepositoryCollaboratorPermission.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetcombinedstatusforref"></a>
# **ReposGetCombinedStatusForRef**
> CombinedCommitStatus ReposGetCombinedStatusForRef (string owner, string repo, string _ref, int? perPage, int? page)

Get the combined status for a specific reference

Users with pull access in a repository can access a combined view of commit statuses for a given ref. The ref can be a SHA, a branch name, or a tag name.   Additionally, a combined `state` is returned. The `state` is one of:  *   **failure** if any of the contexts report as `error` or `failure` *   **pending** if there are no statuses or a context is `pending` *   **success** if the latest status for all contexts is `success`

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetCombinedStatusForRefExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var _ref = "_ref_example";  // string | ref parameter
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // Get the combined status for a specific reference
                CombinedCommitStatus result = apiInstance.ReposGetCombinedStatusForRef(owner, repo, _ref, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetCombinedStatusForRef: " + e.Message );
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
 **_ref** | **string**| ref parameter | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**CombinedCommitStatus**](CombinedCommitStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetcommit"></a>
# **ReposGetCommit**
> Commit ReposGetCommit (string owner, string repo, string _ref, int? page, int? perPage)

Get a commit

Returns the contents of a single commit reference. You must have `read` access for the repository to use this endpoint.  **Note:** If there are more than 300 files in the commit diff, the response will include pagination link headers for the remaining files, up to a limit of 3000 files. Each page contains the static commit information, and the only changes are to the file listing.  You can pass the appropriate [media type](https://docs.github.com/rest/overview/media-types/#commits-commit-comparison-and-pull-requests) to  fetch `diff` and `patch` formats. Diffs with binary data will have no `patch` property.  To return only the SHA-1 hash of the commit reference, you can provide the `sha` custom [media type](https://docs.github.com/rest/overview/media-types/#commits-commit-comparison-and-pull-requests) in the `Accept` header. You can use this endpoint to check if a remote reference's SHA-1 hash is the same as your local reference's SHA-1 hash by providing the local SHA-1 reference as the ETag.  **Signature verification object**  The response will include a `verification` object that describes the result of verifying the commit's signature. The following fields are included in the `verification` object:  | Name | Type | Description | | - -- - | - -- - | - -- -- -- -- -- | | `verified` | `boolean` | Indicates whether GitHub considers the signature in this commit to be verified. | | `reason` | `string` | The reason for verified value. Possible values and their meanings are enumerated in table below. | | `signature` | `string` | The signature that was extracted from the commit. | | `payload` | `string` | The value that was signed. |  These are the possible values for `reason` in the `verification` object:  | Value | Description | | - -- -- | - -- -- -- -- -- | | `expired_key` | The key that made the signature is expired. | | `not_signing_key` | The \"signing\" flag is not among the usage flags in the GPG key that made the signature. | | `gpgverify_error` | There was an error communicating with the signature verification service. | | `gpgverify_unavailable` | The signature verification service is currently unavailable. | | `unsigned` | The object does not include a signature. | | `unknown_signature_type` | A non-PGP signature was found in the commit. | | `no_user` | No user was associated with the `committer` email address in the commit. | | `unverified_email` | The `committer` email address in the commit was associated with a user, but the email address is not verified on her/his account. | | `bad_email` | The `committer` email address in the commit is not included in the identities of the PGP key that made the signature. | | `unknown_key` | The key that made the signature has not been registered with any user's account. | | `malformed_signature` | There was an error parsing the signature. | | `invalid` | The signature could not be cryptographically verified using the key whose key-id was found in the signature. | | `valid` | None of the above errors applied, so the signature is considered to be verified. |

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetCommitExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var _ref = "_ref_example";  // string | ref parameter
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)

            try
            {
                // Get a commit
                Commit result = apiInstance.ReposGetCommit(owner, repo, _ref, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetCommit: " + e.Message );
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
 **_ref** | **string**| ref parameter | 
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]

### Return type

[**Commit**](Commit.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetcommitactivitystats"></a>
# **ReposGetCommitActivityStats**
> List<CommitActivity> ReposGetCommitActivityStats (string owner, string repo)

Get the last year of commit activity

Returns the last year of commit activity grouped by week. The `days` array is a group of commits per day, starting on `Sunday`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetCommitActivityStatsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get the last year of commit activity
                List&lt;CommitActivity&gt; result = apiInstance.ReposGetCommitActivityStats(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetCommitActivityStats: " + e.Message );
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

[**List<CommitActivity>**](CommitActivity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetcommitcomment"></a>
# **ReposGetCommitComment**
> CommitComment ReposGetCommitComment (string owner, string repo, int? commentId)

Get a commit comment



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetCommitCommentExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commentId = 56;  // int? | The unique identifier of the comment.

            try
            {
                // Get a commit comment
                CommitComment result = apiInstance.ReposGetCommitComment(owner, repo, commentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetCommitComment: " + e.Message );
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

[**CommitComment**](CommitComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetcommitsignatureprotection"></a>
# **ReposGetCommitSignatureProtection**
> ProtectedBranchAdminEnforced ReposGetCommitSignatureProtection (string owner, string repo, string branch)

Get commit signature protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  When authenticated with admin or owner permissions to the repository, you can use this endpoint to check whether a branch requires signed commits. An enabled status of `true` indicates you must sign commits on this branch. For more information, see [Signing commits with GPG](https://docs.github.com/articles/signing-commits-with-gpg) in GitHub Help.  **Note**: You must enable branch protection to require signed commits.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetCommitSignatureProtectionExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.

            try
            {
                // Get commit signature protection
                ProtectedBranchAdminEnforced result = apiInstance.ReposGetCommitSignatureProtection(owner, repo, branch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetCommitSignatureProtection: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 

### Return type

[**ProtectedBranchAdminEnforced**](ProtectedBranchAdminEnforced.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetcommunityprofilemetrics"></a>
# **ReposGetCommunityProfileMetrics**
> CommunityProfile ReposGetCommunityProfileMetrics (string owner, string repo)

Get community profile metrics

This endpoint will return all community profile metrics, including an overall health score, repository description, the presence of documentation, detected code of conduct, detected license, and the presence of ISSUE\\_TEMPLATE, PULL\\_REQUEST\\_TEMPLATE, README, and CONTRIBUTING files.  The `health_percentage` score is defined as a percentage of how many of these four documents are present: README, CONTRIBUTING, LICENSE, and CODE_OF_CONDUCT. For example, if all four documents are present, then the `health_percentage` is `100`. If only one is present, then the `health_percentage` is `25`.  `content_reports_enabled` is only returned for organization-owned repositories.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetCommunityProfileMetricsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get community profile metrics
                CommunityProfile result = apiInstance.ReposGetCommunityProfileMetrics(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetCommunityProfileMetrics: " + e.Message );
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

[**CommunityProfile**](CommunityProfile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetcontent"></a>
# **ReposGetContent**
> ContentTree ReposGetContent (string owner, string repo, string path, string _ref)

Get repository content

Gets the contents of a file or directory in a repository. Specify the file path or directory in `:path`. If you omit `:path`, you will receive the contents of the repository's root directory. See the description below regarding what the API response includes for directories.   Files and symlinks support [a custom media type](https://docs.github.com/rest/reference/repos#custom-media-types) for retrieving the raw content or rendered HTML (when supported). All content types support [a custom media type](https://docs.github.com/rest/reference/repos#custom-media-types) to ensure the content is returned in a consistent object format.  **Note**: *   To get a repository's contents recursively, you can [recursively get the tree](https://docs.github.com/rest/reference/git#trees). *   This API has an upper limit of 1,000 files for a directory. If you need to retrieve more files, use the [Git Trees API](https://docs.github.com/rest/reference/git#get-a-tree).  #### Size limits If the requested file's size is: * 1 MB or smaller: All features of this endpoint are supported. * Between 1-100 MB: Only the `raw` or `object` [custom media types](https://docs.github.com/rest/repos/contents#custom-media-types-for-repository-contents) are supported. Both will work as normal, except that when using the `object` media type, the `content` field will be an empty string and the `encoding` field will be `\"none\"`. To get the contents of these larger files, use the `raw` media type.  * Greater than 100 MB: This endpoint is not supported.  #### If the content is a directory The response will be an array of objects, one object for each item in the directory. When listing the contents of a directory, submodules have their \"type\" specified as \"file\". Logically, the value _should_ be \"submodule\". This behavior exists in API v3 [for backwards compatibility purposes](https://git.io/v1YCW). In the next major version of the API, the type will be returned as \"submodule\".  #### If the content is a symlink  If the requested `:path` points to a symlink, and the symlink's target is a normal file in the repository, then the API responds with the content of the file (in the format shown in the example. Otherwise, the API responds with an object  describing the symlink itself.  #### If the content is a submodule The `submodule_git_url` identifies the location of the submodule repository, and the `sha` identifies a specific commit within the submodule repository. Git uses the given URL when cloning the submodule repository, and checks out the submodule at that specific commit.  If the submodule repository is not hosted on github.com, the Git URLs (`git_url` and `_links[\"git\"]`) and the github.com URLs (`html_url` and `_links[\"html\"]`) will have null values.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetContentExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var path = "path_example";  // string | path parameter
            var _ref = "_ref_example";  // string | The name of the commit/branch/tag. Default: the repository’s default branch (usually `master`) (optional) 

            try
            {
                // Get repository content
                ContentTree result = apiInstance.ReposGetContent(owner, repo, path, _ref);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetContent: " + e.Message );
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
 **path** | **string**| path parameter | 
 **_ref** | **string**| The name of the commit/branch/tag. Default: the repository’s default branch (usually &#x60;master&#x60;) | [optional] 

### Return type

[**ContentTree**](ContentTree.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.github.object, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetcontributorsstats"></a>
# **ReposGetContributorsStats**
> List<ContributorActivity> ReposGetContributorsStats (string owner, string repo)

Get all contributor commit activity

 Returns the `total` number of commits authored by the contributor. In addition, the response includes a Weekly Hash (`weeks` array) with the following information:  *   `w` - Start of the week, given as a [Unix timestamp](http://en.wikipedia.org/wiki/Unix_time). *   `a` - Number of additions *   `d` - Number of deletions *   `c` - Number of commits

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetContributorsStatsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get all contributor commit activity
                List&lt;ContributorActivity&gt; result = apiInstance.ReposGetContributorsStats(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetContributorsStats: " + e.Message );
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

[**List<ContributorActivity>**](ContributorActivity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetdeploykey"></a>
# **ReposGetDeployKey**
> DeployKey ReposGetDeployKey (string owner, string repo, int? keyId)

Get a deploy key



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetDeployKeyExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var keyId = 56;  // int? | The unique identifier of the key.

            try
            {
                // Get a deploy key
                DeployKey result = apiInstance.ReposGetDeployKey(owner, repo, keyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetDeployKey: " + e.Message );
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
 **keyId** | **int?**| The unique identifier of the key. | 

### Return type

[**DeployKey**](DeployKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetdeployment"></a>
# **ReposGetDeployment**
> Deployment ReposGetDeployment (string owner, string repo, int? deploymentId)

Get a deployment



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetDeploymentExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var deploymentId = 56;  // int? | deployment_id parameter

            try
            {
                // Get a deployment
                Deployment result = apiInstance.ReposGetDeployment(owner, repo, deploymentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetDeployment: " + e.Message );
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
 **deploymentId** | **int?**| deployment_id parameter | 

### Return type

[**Deployment**](Deployment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetdeploymentstatus"></a>
# **ReposGetDeploymentStatus**
> DeploymentStatus ReposGetDeploymentStatus (string owner, string repo, int? deploymentId, int? statusId)

Get a deployment status

Users with pull access can view a deployment status for a deployment:

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetDeploymentStatusExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var deploymentId = 56;  // int? | deployment_id parameter
            var statusId = 56;  // int? | 

            try
            {
                // Get a deployment status
                DeploymentStatus result = apiInstance.ReposGetDeploymentStatus(owner, repo, deploymentId, statusId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetDeploymentStatus: " + e.Message );
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
 **deploymentId** | **int?**| deployment_id parameter | 
 **statusId** | **int?**|  | 

### Return type

[**DeploymentStatus**](DeploymentStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetenvironment"></a>
# **ReposGetEnvironment**
> Environment ReposGetEnvironment (string owner, string repo, string environmentName)

Get an environment

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
    public class ReposGetEnvironmentExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var environmentName = "environmentName_example";  // string | The name of the environment

            try
            {
                // Get an environment
                Environment result = apiInstance.ReposGetEnvironment(owner, repo, environmentName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetEnvironment: " + e.Message );
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
 **environmentName** | **string**| The name of the environment | 

### Return type

[**Environment**](Environment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetlatestpagesbuild"></a>
# **ReposGetLatestPagesBuild**
> PageBuild ReposGetLatestPagesBuild (string owner, string repo)

Get latest Pages build



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetLatestPagesBuildExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get latest Pages build
                PageBuild result = apiInstance.ReposGetLatestPagesBuild(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetLatestPagesBuild: " + e.Message );
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

[**PageBuild**](PageBuild.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetlatestrelease"></a>
# **ReposGetLatestRelease**
> Release ReposGetLatestRelease (string owner, string repo)

Get the latest release

View the latest published full release for the repository.  The latest release is the most recent non-prerelease, non-draft release, sorted by the `created_at` attribute. The `created_at` attribute is the date of the commit used for the release, and not the date when the release was drafted or published.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetLatestReleaseExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get the latest release
                Release result = apiInstance.ReposGetLatestRelease(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetLatestRelease: " + e.Message );
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

[**Release**](Release.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetpages"></a>
# **ReposGetPages**
> GitHubPages ReposGetPages (string owner, string repo)

Get a GitHub Pages site



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetPagesExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get a GitHub Pages site
                GitHubPages result = apiInstance.ReposGetPages(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetPages: " + e.Message );
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

[**GitHubPages**](GitHubPages.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetpagesbuild"></a>
# **ReposGetPagesBuild**
> PageBuild ReposGetPagesBuild (string owner, string repo, int? buildId)

Get GitHub Pages build



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetPagesBuildExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var buildId = 56;  // int? | 

            try
            {
                // Get GitHub Pages build
                PageBuild result = apiInstance.ReposGetPagesBuild(owner, repo, buildId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetPagesBuild: " + e.Message );
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
 **buildId** | **int?**|  | 

### Return type

[**PageBuild**](PageBuild.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetpageshealthcheck"></a>
# **ReposGetPagesHealthCheck**
> PagesHealthCheckStatus ReposGetPagesHealthCheck (string owner, string repo)

Get a DNS health check for GitHub Pages

Gets a health check of the DNS settings for the `CNAME` record configured for a repository's GitHub Pages.  The first request to this endpoint returns a `202 Accepted` status and starts an asynchronous background task to get the results for the domain. After the background task completes, subsequent requests to this endpoint return a `200 OK` status with the health check results in the response.  Users must have admin or owner permissions. GitHub Apps must have the `pages:write` and `administration:write` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetPagesHealthCheckExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get a DNS health check for GitHub Pages
                PagesHealthCheckStatus result = apiInstance.ReposGetPagesHealthCheck(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetPagesHealthCheck: " + e.Message );
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

[**PagesHealthCheckStatus**](PagesHealthCheckStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetparticipationstats"></a>
# **ReposGetParticipationStats**
> ParticipationStats ReposGetParticipationStats (string owner, string repo)

Get the weekly commit count

Returns the total commit counts for the `owner` and total commit counts in `all`. `all` is everyone combined, including the `owner` in the last 52 weeks. If you'd like to get the commit counts for non-owners, you can subtract `owner` from `all`.  The array order is oldest week (index 0) to most recent week.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetParticipationStatsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get the weekly commit count
                ParticipationStats result = apiInstance.ReposGetParticipationStats(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetParticipationStats: " + e.Message );
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

[**ParticipationStats**](ParticipationStats.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetpullrequestreviewprotection"></a>
# **ReposGetPullRequestReviewProtection**
> ProtectedBranchPullRequestReview ReposGetPullRequestReviewProtection (string owner, string repo, string branch)

Get pull request review protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetPullRequestReviewProtectionExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.

            try
            {
                // Get pull request review protection
                ProtectedBranchPullRequestReview result = apiInstance.ReposGetPullRequestReviewProtection(owner, repo, branch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetPullRequestReviewProtection: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 

### Return type

[**ProtectedBranchPullRequestReview**](ProtectedBranchPullRequestReview.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetpunchcardstats"></a>
# **ReposGetPunchCardStats**
> List<List<int?>> ReposGetPunchCardStats (string owner, string repo)

Get the hourly commit count for each day

Each array contains the day number, hour number, and number of commits:  *   `0-6`: Sunday - Saturday *   `0-23`: Hour of day *   Number of commits  For example, `[2, 14, 25]` indicates that there were 25 total commits, during the 2:00pm hour on Tuesdays. All times are based on the time zone of individual commits.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetPunchCardStatsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get the hourly commit count for each day
                List&lt;List&lt;int?&gt;&gt; result = apiInstance.ReposGetPunchCardStats(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetPunchCardStats: " + e.Message );
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

**List<List<int?>>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetreadme"></a>
# **ReposGetReadme**
> ContentFile ReposGetReadme (string owner, string repo, string _ref)

Get a repository README

Gets the preferred README for a repository.  READMEs support [custom media types](https://docs.github.com/rest/reference/repos#custom-media-types) for retrieving the raw content or rendered HTML.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetReadmeExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var _ref = "_ref_example";  // string | The name of the commit/branch/tag. Default: the repository’s default branch (usually `master`) (optional) 

            try
            {
                // Get a repository README
                ContentFile result = apiInstance.ReposGetReadme(owner, repo, _ref);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetReadme: " + e.Message );
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
 **_ref** | **string**| The name of the commit/branch/tag. Default: the repository’s default branch (usually &#x60;master&#x60;) | [optional] 

### Return type

[**ContentFile**](ContentFile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetreadmeindirectory"></a>
# **ReposGetReadmeInDirectory**
> ContentFile ReposGetReadmeInDirectory (string owner, string repo, string dir, string _ref)

Get a repository README for a directory

Gets the README from a repository directory.  READMEs support [custom media types](https://docs.github.com/rest/reference/repos#custom-media-types) for retrieving the raw content or rendered HTML.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetReadmeInDirectoryExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var dir = "dir_example";  // string | The alternate path to look for a README file
            var _ref = "_ref_example";  // string | The name of the commit/branch/tag. Default: the repository’s default branch (usually `master`) (optional) 

            try
            {
                // Get a repository README for a directory
                ContentFile result = apiInstance.ReposGetReadmeInDirectory(owner, repo, dir, _ref);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetReadmeInDirectory: " + e.Message );
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
 **dir** | **string**| The alternate path to look for a README file | 
 **_ref** | **string**| The name of the commit/branch/tag. Default: the repository’s default branch (usually &#x60;master&#x60;) | [optional] 

### Return type

[**ContentFile**](ContentFile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetrelease"></a>
# **ReposGetRelease**
> Release ReposGetRelease (string owner, string repo, int? releaseId)

Get a release

**Note:** This returns an `upload_url` key corresponding to the endpoint for uploading release assets. This key is a [hypermedia resource](https://docs.github.com/rest/overview/resources-in-the-rest-api#hypermedia).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetReleaseExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var releaseId = 56;  // int? | The unique identifier of the release.

            try
            {
                // Get a release
                Release result = apiInstance.ReposGetRelease(owner, repo, releaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetRelease: " + e.Message );
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

### Return type

[**Release**](Release.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetreleaseasset"></a>
# **ReposGetReleaseAsset**
> ReleaseAsset ReposGetReleaseAsset (string owner, string repo, int? assetId)

Get a release asset

To download the asset's binary content, set the `Accept` header of the request to [`application/octet-stream`](https://docs.github.com/rest/overview/media-types). The API will either redirect the client to the location, or stream it directly if possible. API clients should handle both a `200` or `302` response.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetReleaseAssetExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var assetId = 56;  // int? | The unique identifier of the asset.

            try
            {
                // Get a release asset
                ReleaseAsset result = apiInstance.ReposGetReleaseAsset(owner, repo, assetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetReleaseAsset: " + e.Message );
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
 **assetId** | **int?**| The unique identifier of the asset. | 

### Return type

[**ReleaseAsset**](ReleaseAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetreleasebytag"></a>
# **ReposGetReleaseByTag**
> Release ReposGetReleaseByTag (string owner, string repo, string tag)

Get a release by tag name

Get a published release with the specified tag.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetReleaseByTagExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var tag = "tag_example";  // string | tag parameter

            try
            {
                // Get a release by tag name
                Release result = apiInstance.ReposGetReleaseByTag(owner, repo, tag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetReleaseByTag: " + e.Message );
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
 **tag** | **string**| tag parameter | 

### Return type

[**Release**](Release.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetstatuschecksprotection"></a>
# **ReposGetStatusChecksProtection**
> StatusCheckPolicy ReposGetStatusChecksProtection (string owner, string repo, string branch)

Get status checks protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetStatusChecksProtectionExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.

            try
            {
                // Get status checks protection
                StatusCheckPolicy result = apiInstance.ReposGetStatusChecksProtection(owner, repo, branch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetStatusChecksProtection: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 

### Return type

[**StatusCheckPolicy**](StatusCheckPolicy.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetteamswithaccesstoprotectedbranch"></a>
# **ReposGetTeamsWithAccessToProtectedBranch**
> List<Team> ReposGetTeamsWithAccessToProtectedBranch (string owner, string repo, string branch)

Get teams with access to the protected branch

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Lists the teams who have push access to this branch. The list includes child teams.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetTeamsWithAccessToProtectedBranchExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.

            try
            {
                // Get teams with access to the protected branch
                List&lt;Team&gt; result = apiInstance.ReposGetTeamsWithAccessToProtectedBranch(owner, repo, branch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetTeamsWithAccessToProtectedBranch: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 

### Return type

[**List<Team>**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgettoppaths"></a>
# **ReposGetTopPaths**
> List<ContentTraffic> ReposGetTopPaths (string owner, string repo)

Get top referral paths

Get the top 10 popular contents over the last 14 days.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetTopPathsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get top referral paths
                List&lt;ContentTraffic&gt; result = apiInstance.ReposGetTopPaths(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetTopPaths: " + e.Message );
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

[**List<ContentTraffic>**](ContentTraffic.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgettopreferrers"></a>
# **ReposGetTopReferrers**
> List<ReferrerTraffic> ReposGetTopReferrers (string owner, string repo)

Get top referral sources

Get the top 10 referrers over the last 14 days.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetTopReferrersExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get top referral sources
                List&lt;ReferrerTraffic&gt; result = apiInstance.ReposGetTopReferrers(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetTopReferrers: " + e.Message );
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

[**List<ReferrerTraffic>**](ReferrerTraffic.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetuserswithaccesstoprotectedbranch"></a>
# **ReposGetUsersWithAccessToProtectedBranch**
> List<SimpleUser1> ReposGetUsersWithAccessToProtectedBranch (string owner, string repo, string branch)

Get users with access to the protected branch

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Lists the people who have push access to this branch.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetUsersWithAccessToProtectedBranchExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.

            try
            {
                // Get users with access to the protected branch
                List&lt;SimpleUser1&gt; result = apiInstance.ReposGetUsersWithAccessToProtectedBranch(owner, repo, branch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetUsersWithAccessToProtectedBranch: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 

### Return type

[**List<SimpleUser1>**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetviews"></a>
# **ReposGetViews**
> ViewTraffic ReposGetViews (string owner, string repo, string per)

Get page views

Get the total number of views and breakdown per day or week for the last 14 days. Timestamps are aligned to UTC midnight of the beginning of the day or week. Week begins on Monday.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetViewsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var per = "";  // string | The time frame to display results for. (optional)  (default to day)

            try
            {
                // Get page views
                ViewTraffic result = apiInstance.ReposGetViews(owner, repo, per);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetViews: " + e.Message );
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
 **per** | **string**| The time frame to display results for. | [optional] [default to day]

### Return type

[**ViewTraffic**](ViewTraffic.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetwebhook"></a>
# **ReposGetWebhook**
> Webhook ReposGetWebhook (string owner, string repo, int? hookId)

Get a repository webhook

Returns a webhook configured in a repository. To get only the webhook `config` properties, see \"[Get a webhook configuration for a repository](/rest/reference/repos#get-a-webhook-configuration-for-a-repository).\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetWebhookExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var hookId = 56;  // int? | The unique identifier of the hook.

            try
            {
                // Get a repository webhook
                Webhook result = apiInstance.ReposGetWebhook(owner, repo, hookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetWebhook: " + e.Message );
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
 **hookId** | **int?**| The unique identifier of the hook. | 

### Return type

[**Webhook**](Webhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetwebhookconfigforrepo"></a>
# **ReposGetWebhookConfigForRepo**
> WebhookConfiguration ReposGetWebhookConfigForRepo (string owner, string repo, int? hookId)

Get a webhook configuration for a repository

Returns the webhook configuration for a repository. To get more information about the webhook, including the `active` state and `events`, use \"[Get a repository webhook](/rest/reference/orgs#get-a-repository-webhook).\"  Access tokens must have the `read:repo_hook` or `repo` scope, and GitHub Apps must have the `repository_hooks:read` permission.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetWebhookConfigForRepoExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var hookId = 56;  // int? | The unique identifier of the hook.

            try
            {
                // Get a webhook configuration for a repository
                WebhookConfiguration result = apiInstance.ReposGetWebhookConfigForRepo(owner, repo, hookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetWebhookConfigForRepo: " + e.Message );
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
 **hookId** | **int?**| The unique identifier of the hook. | 

### Return type

[**WebhookConfiguration**](WebhookConfiguration.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposgetwebhookdelivery"></a>
# **ReposGetWebhookDelivery**
> WebhookDelivery ReposGetWebhookDelivery (string owner, string repo, int? hookId, int? deliveryId)

Get a delivery for a repository webhook

Returns a delivery for a webhook configured in a repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposGetWebhookDeliveryExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var hookId = 56;  // int? | The unique identifier of the hook.
            var deliveryId = 56;  // int? | 

            try
            {
                // Get a delivery for a repository webhook
                WebhookDelivery result = apiInstance.ReposGetWebhookDelivery(owner, repo, hookId, deliveryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposGetWebhookDelivery: " + e.Message );
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
 **hookId** | **int?**| The unique identifier of the hook. | 
 **deliveryId** | **int?**|  | 

### Return type

[**WebhookDelivery**](WebhookDelivery.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/scim+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistautolinks"></a>
# **ReposListAutolinks**
> List<AutolinkReference> ReposListAutolinks (string owner, string repo, int? page)

List all autolinks of a repository

This returns a list of autolinks configured for the given repository.  Information about autolinks are only available to repository administrators.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListAutolinksExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List all autolinks of a repository
                List&lt;AutolinkReference&gt; result = apiInstance.ReposListAutolinks(owner, repo, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListAutolinks: " + e.Message );
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
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<AutolinkReference>**](AutolinkReference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistbranches"></a>
# **ReposListBranches**
> List<ShortBranch> ReposListBranches (string owner, string repo, bool? _protected, int? perPage, int? page)

List branches



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListBranchesExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var _protected = true;  // bool? | Setting to `true` returns only protected branches. When set to `false`, only unprotected branches are returned. Omitting this parameter returns all branches. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List branches
                List&lt;ShortBranch&gt; result = apiInstance.ReposListBranches(owner, repo, _protected, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListBranches: " + e.Message );
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
 **_protected** | **bool?**| Setting to &#x60;true&#x60; returns only protected branches. When set to &#x60;false&#x60;, only unprotected branches are returned. Omitting this parameter returns all branches. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<ShortBranch>**](ShortBranch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistbranchesforheadcommit"></a>
# **ReposListBranchesForHeadCommit**
> List<BranchShort> ReposListBranchesForHeadCommit (string owner, string repo, string commitSha)

List branches for HEAD commit

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Returns all branches where the given commit SHA is the HEAD, or latest commit for the branch.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListBranchesForHeadCommitExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commitSha = "commitSha_example";  // string | The SHA of the commit.

            try
            {
                // List branches for HEAD commit
                List&lt;BranchShort&gt; result = apiInstance.ReposListBranchesForHeadCommit(owner, repo, commitSha);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListBranchesForHeadCommit: " + e.Message );
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
 **commitSha** | **string**| The SHA of the commit. | 

### Return type

[**List<BranchShort>**](BranchShort.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistcollaborators"></a>
# **ReposListCollaborators**
> List<Collaborator> ReposListCollaborators (string owner, string repo, string affiliation, int? perPage, int? page)

List repository collaborators

For organization-owned repositories, the list of collaborators includes outside collaborators, organization members that are direct collaborators, organization members with access through team memberships, organization members with access through default organization permissions, and organization owners. Organization members with write, maintain, or admin privileges on the organization-owned repository can use this endpoint.  Team members will include the members of child teams.  You must authenticate using an access token with the `read:org` and `repo` scopes with push access to use this endpoint. GitHub Apps must have the `members` organization permission and `metadata` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListCollaboratorsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var affiliation = "outside";  // string | Filter collaborators returned by their affiliation. `outside` means all outside collaborators of an organization-owned repository. `direct` means all collaborators with permissions to an organization-owned repository, regardless of organization membership status. `all` means all collaborators the authenticated user can see. (optional)  (default to all)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repository collaborators
                List&lt;Collaborator&gt; result = apiInstance.ReposListCollaborators(owner, repo, affiliation, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListCollaborators: " + e.Message );
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
 **affiliation** | **string**| Filter collaborators returned by their affiliation. &#x60;outside&#x60; means all outside collaborators of an organization-owned repository. &#x60;direct&#x60; means all collaborators with permissions to an organization-owned repository, regardless of organization membership status. &#x60;all&#x60; means all collaborators the authenticated user can see. | [optional] [default to all]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Collaborator>**](Collaborator.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistcommentsforcommit"></a>
# **ReposListCommentsForCommit**
> List<CommitComment> ReposListCommentsForCommit (string owner, string repo, string commitSha, int? perPage, int? page)

List commit comments

Use the `:commit_sha` to specify the commit that will have its comments listed.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListCommentsForCommitExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commitSha = "commitSha_example";  // string | The SHA of the commit.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List commit comments
                List&lt;CommitComment&gt; result = apiInstance.ReposListCommentsForCommit(owner, repo, commitSha, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListCommentsForCommit: " + e.Message );
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
 **commitSha** | **string**| The SHA of the commit. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<CommitComment>**](CommitComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistcommitcommentsforrepo"></a>
# **ReposListCommitCommentsForRepo**
> List<CommitComment> ReposListCommitCommentsForRepo (string owner, string repo, int? perPage, int? page)

List commit comments for a repository

Commit Comments use [these custom media types](https://docs.github.com/rest/reference/repos#custom-media-types). You can read more about the use of media types in the API [here](https://docs.github.com/rest/overview/media-types/).  Comments are ordered by ascending ID.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListCommitCommentsForRepoExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List commit comments for a repository
                List&lt;CommitComment&gt; result = apiInstance.ReposListCommitCommentsForRepo(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListCommitCommentsForRepo: " + e.Message );
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

[**List<CommitComment>**](CommitComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistcommitstatusesforref"></a>
# **ReposListCommitStatusesForRef**
> List<Status> ReposListCommitStatusesForRef (string owner, string repo, string _ref, int? perPage, int? page)

List commit statuses for a reference

Users with pull access in a repository can view commit statuses for a given ref. The ref can be a SHA, a branch name, or a tag name. Statuses are returned in reverse chronological order. The first status in the list will be the latest one.  This resource is also available via a legacy route: `GET /repos/:owner/:repo/statuses/:ref`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListCommitStatusesForRefExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var _ref = "_ref_example";  // string | ref parameter
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List commit statuses for a reference
                List&lt;Status&gt; result = apiInstance.ReposListCommitStatusesForRef(owner, repo, _ref, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListCommitStatusesForRef: " + e.Message );
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
 **_ref** | **string**| ref parameter | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Status>**](Status.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistcommits"></a>
# **ReposListCommits**
> List<Commit> ReposListCommits (string owner, string repo, string sha, string path, string author, DateTime? since, DateTime? until, int? perPage, int? page)

List commits

**Signature verification object**  The response will include a `verification` object that describes the result of verifying the commit's signature. The following fields are included in the `verification` object:  | Name | Type | Description | | - -- - | - -- - | - -- -- -- -- -- | | `verified` | `boolean` | Indicates whether GitHub considers the signature in this commit to be verified. | | `reason` | `string` | The reason for verified value. Possible values and their meanings are enumerated in table below. | | `signature` | `string` | The signature that was extracted from the commit. | | `payload` | `string` | The value that was signed. |  These are the possible values for `reason` in the `verification` object:  | Value | Description | | - -- -- | - -- -- -- -- -- | | `expired_key` | The key that made the signature is expired. | | `not_signing_key` | The \"signing\" flag is not among the usage flags in the GPG key that made the signature. | | `gpgverify_error` | There was an error communicating with the signature verification service. | | `gpgverify_unavailable` | The signature verification service is currently unavailable. | | `unsigned` | The object does not include a signature. | | `unknown_signature_type` | A non-PGP signature was found in the commit. | | `no_user` | No user was associated with the `committer` email address in the commit. | | `unverified_email` | The `committer` email address in the commit was associated with a user, but the email address is not verified on her/his account. | | `bad_email` | The `committer` email address in the commit is not included in the identities of the PGP key that made the signature. | | `unknown_key` | The key that made the signature has not been registered with any user's account. | | `malformed_signature` | There was an error parsing the signature. | | `invalid` | The signature could not be cryptographically verified using the key whose key-id was found in the signature. | | `valid` | None of the above errors applied, so the signature is considered to be verified. |

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListCommitsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var sha = "sha_example";  // string | SHA or branch to start listing commits from. Default: the repository’s default branch (usually `master`). (optional) 
            var path = "path_example";  // string | Only commits containing this file path will be returned. (optional) 
            var author = "author_example";  // string | GitHub login or email address by which to filter by commit author. (optional) 
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. (optional) 
            var until = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only commits before this date will be returned. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List commits
                List&lt;Commit&gt; result = apiInstance.ReposListCommits(owner, repo, sha, path, author, since, until, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListCommits: " + e.Message );
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
 **sha** | **string**| SHA or branch to start listing commits from. Default: the repository’s default branch (usually &#x60;master&#x60;). | [optional] 
 **path** | **string**| Only commits containing this file path will be returned. | [optional] 
 **author** | **string**| GitHub login or email address by which to filter by commit author. | [optional] 
 **since** | **DateTime?**| Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
 **until** | **DateTime?**| Only commits before this date will be returned. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Commit>**](Commit.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/scim+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistcontributors"></a>
# **ReposListContributors**
> List<Contributor> ReposListContributors (string owner, string repo, string anon, int? perPage, int? page)

List repository contributors

Lists contributors to the specified repository and sorts them by the number of commits per contributor in descending order. This endpoint may return information that is a few hours old because the GitHub REST API v3 caches contributor data to improve performance.  GitHub identifies contributors by author email address. This endpoint groups contribution counts by GitHub user, which includes all associated email addresses. To improve performance, only the first 500 author email addresses in the repository link to GitHub users. The rest will appear as anonymous contributors without associated GitHub user information.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListContributorsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var anon = "anon_example";  // string | Set to `1` or `true` to include anonymous contributors in results. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repository contributors
                List&lt;Contributor&gt; result = apiInstance.ReposListContributors(owner, repo, anon, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListContributors: " + e.Message );
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
 **anon** | **string**| Set to &#x60;1&#x60; or &#x60;true&#x60; to include anonymous contributors in results. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Contributor>**](Contributor.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistdeploykeys"></a>
# **ReposListDeployKeys**
> List<DeployKey> ReposListDeployKeys (string owner, string repo, int? perPage, int? page)

List deploy keys



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListDeployKeysExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List deploy keys
                List&lt;DeployKey&gt; result = apiInstance.ReposListDeployKeys(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListDeployKeys: " + e.Message );
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

[**List<DeployKey>**](DeployKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistdeploymentstatuses"></a>
# **ReposListDeploymentStatuses**
> List<DeploymentStatus> ReposListDeploymentStatuses (string owner, string repo, int? deploymentId, int? perPage, int? page)

List deployment statuses

Users with pull access can view deployment statuses for a deployment:

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListDeploymentStatusesExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var deploymentId = 56;  // int? | deployment_id parameter
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List deployment statuses
                List&lt;DeploymentStatus&gt; result = apiInstance.ReposListDeploymentStatuses(owner, repo, deploymentId, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListDeploymentStatuses: " + e.Message );
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
 **deploymentId** | **int?**| deployment_id parameter | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<DeploymentStatus>**](DeploymentStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistdeployments"></a>
# **ReposListDeployments**
> List<Deployment> ReposListDeployments (string owner, string repo, string sha, string _ref, string task, string environment, int? perPage, int? page)

List deployments

Simple filtering of deployments is available via query parameters:

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListDeploymentsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var sha = "\"none\"";  // string | The SHA recorded at creation time. (optional)  (default to "none")
            var _ref = "\"none\"";  // string | The name of the ref. This can be a branch, tag, or SHA. (optional)  (default to "none")
            var task = "\"none\"";  // string | The name of the task for the deployment (e.g., `deploy` or `deploy:migrations`). (optional)  (default to "none")
            var environment = "\"none\"";  // string | The name of the environment that was deployed to (e.g., `staging` or `production`). (optional)  (default to "none")
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List deployments
                List&lt;Deployment&gt; result = apiInstance.ReposListDeployments(owner, repo, sha, _ref, task, environment, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListDeployments: " + e.Message );
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
 **sha** | **string**| The SHA recorded at creation time. | [optional] [default to &quot;none&quot;]
 **_ref** | **string**| The name of the ref. This can be a branch, tag, or SHA. | [optional] [default to &quot;none&quot;]
 **task** | **string**| The name of the task for the deployment (e.g., &#x60;deploy&#x60; or &#x60;deploy:migrations&#x60;). | [optional] [default to &quot;none&quot;]
 **environment** | **string**| The name of the environment that was deployed to (e.g., &#x60;staging&#x60; or &#x60;production&#x60;). | [optional] [default to &quot;none&quot;]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Deployment>**](Deployment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistforauthenticateduser"></a>
# **ReposListForAuthenticatedUser**
> List<Repository> ReposListForAuthenticatedUser (string visibility, string affiliation, string type, string sort, string direction, int? perPage, int? page, DateTime? since, DateTime? before)

List repositories for the authenticated user

Lists repositories that the authenticated user has explicit permission (`:read`, `:write`, or `:admin`) to access.  The authenticated user has explicit permission to access repositories they own, repositories where they are a collaborator, and repositories that they can access through an organization membership.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var visibility = "all";  // string | Limit results to repositories with the specified visibility. (optional)  (default to all)
            var affiliation = "\"owner,collaborator,organization_member\"";  // string | Comma-separated list of values. Can include:   \\* `owner`: Repositories that are owned by the authenticated user.   \\* `collaborator`: Repositories that the user has been added to as a collaborator.   \\* `organization_member`: Repositories that the user has access to through being a member of an organization. This includes every repository on every team that the user is on. (optional)  (default to "owner,collaborator,organization_member")
            var type = "all";  // string | Limit results to repositories of the specified type. Will cause a `422` error if used in the same request as **visibility** or **affiliation**. (optional)  (default to all)
            var sort = "created";  // string | The property to sort the results by. (optional)  (default to full_name)
            var direction = "asc";  // string | The order to sort by. Default: `asc` when using `full_name`, otherwise `desc`. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show notifications updated before the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. (optional) 

            try
            {
                // List repositories for the authenticated user
                List&lt;Repository&gt; result = apiInstance.ReposListForAuthenticatedUser(visibility, affiliation, type, sort, direction, perPage, page, since, before);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **visibility** | **string**| Limit results to repositories with the specified visibility. | [optional] [default to all]
 **affiliation** | **string**| Comma-separated list of values. Can include:   \\* &#x60;owner&#x60;: Repositories that are owned by the authenticated user.   \\* &#x60;collaborator&#x60;: Repositories that the user has been added to as a collaborator.   \\* &#x60;organization_member&#x60;: Repositories that the user has access to through being a member of an organization. This includes every repository on every team that the user is on. | [optional] [default to &quot;owner,collaborator,organization_member&quot;]
 **type** | **string**| Limit results to repositories of the specified type. Will cause a &#x60;422&#x60; error if used in the same request as **visibility** or **affiliation**. | [optional] [default to all]
 **sort** | **string**| The property to sort the results by. | [optional] [default to full_name]
 **direction** | **string**| The order to sort by. Default: &#x60;asc&#x60; when using &#x60;full_name&#x60;, otherwise &#x60;desc&#x60;. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **since** | **DateTime?**| Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
 **before** | **DateTime?**| Only show notifications updated before the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 

### Return type

[**List<Repository>**](Repository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistfororg"></a>
# **ReposListForOrg**
> List<MinimalRepository> ReposListForOrg (string org, string type, string sort, string direction, int? perPage, int? page)

List organization repositories

Lists repositories for the specified organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListForOrgExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var type = "all";  // string | Specifies the types of repositories you want returned. If your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+, `type` can also be `internal`. However, the `internal` value is not yet supported when a GitHub App calls this API with an installation access token. (optional) 
            var sort = "created";  // string | The property to sort the results by. (optional)  (default to created)
            var direction = "asc";  // string | The order to sort by. Default: `asc` when using `full_name`, otherwise `desc`. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List organization repositories
                List&lt;MinimalRepository&gt; result = apiInstance.ReposListForOrg(org, type, sort, direction, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **type** | **string**| Specifies the types of repositories you want returned. If your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+, &#x60;type&#x60; can also be &#x60;internal&#x60;. However, the &#x60;internal&#x60; value is not yet supported when a GitHub App calls this API with an installation access token. | [optional] 
 **sort** | **string**| The property to sort the results by. | [optional] [default to created]
 **direction** | **string**| The order to sort by. Default: &#x60;asc&#x60; when using &#x60;full_name&#x60;, otherwise &#x60;desc&#x60;. | [optional] 
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

<a name="reposlistforuser"></a>
# **ReposListForUser**
> List<MinimalRepository> ReposListForUser (string username, string type, string sort, string direction, int? perPage, int? page)

List repositories for a user

Lists public repositories for the specified user. Note: For GitHub AE, this endpoint will list internal repositories for the specified user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListForUserExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var username = "username_example";  // string | The handle for the GitHub user account.
            var type = "all";  // string | Limit results to repositories of the specified type. (optional)  (default to owner)
            var sort = "created";  // string | The property to sort the results by. (optional)  (default to full_name)
            var direction = "asc";  // string | The order to sort by. Default: `asc` when using `full_name`, otherwise `desc`. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repositories for a user
                List&lt;MinimalRepository&gt; result = apiInstance.ReposListForUser(username, type, sort, direction, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 
 **type** | **string**| Limit results to repositories of the specified type. | [optional] [default to owner]
 **sort** | **string**| The property to sort the results by. | [optional] [default to full_name]
 **direction** | **string**| The order to sort by. Default: &#x60;asc&#x60; when using &#x60;full_name&#x60;, otherwise &#x60;desc&#x60;. | [optional] 
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

<a name="reposlistforks"></a>
# **ReposListForks**
> List<MinimalRepository> ReposListForks (string owner, string repo, string sort, int? perPage, int? page)

List forks



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListForksExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var sort = "newest";  // string | The sort order. Can be either `newest`, `oldest`, or `stargazers`. (optional)  (default to newest)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List forks
                List&lt;MinimalRepository&gt; result = apiInstance.ReposListForks(owner, repo, sort, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListForks: " + e.Message );
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
 **sort** | **string**| The sort order. Can be either &#x60;newest&#x60;, &#x60;oldest&#x60;, or &#x60;stargazers&#x60;. | [optional] [default to newest]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<MinimalRepository>**](MinimalRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/scim+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistinvitations"></a>
# **ReposListInvitations**
> List<RepositoryInvitation> ReposListInvitations (string owner, string repo, int? perPage, int? page)

List repository invitations

When authenticating as a user with admin rights to a repository, this endpoint will list all currently open repository invitations.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListInvitationsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repository invitations
                List&lt;RepositoryInvitation&gt; result = apiInstance.ReposListInvitations(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListInvitations: " + e.Message );
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

[**List<RepositoryInvitation>**](RepositoryInvitation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistinvitationsforauthenticateduser"></a>
# **ReposListInvitationsForAuthenticatedUser**
> List<RepositoryInvitation> ReposListInvitationsForAuthenticatedUser (int? perPage, int? page)

List repository invitations for the authenticated user

When authenticating as a user, this endpoint will list all currently open repository invitations for that user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListInvitationsForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repository invitations for the authenticated user
                List&lt;RepositoryInvitation&gt; result = apiInstance.ReposListInvitationsForAuthenticatedUser(perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListInvitationsForAuthenticatedUser: " + e.Message );
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

[**List<RepositoryInvitation>**](RepositoryInvitation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistlanguages"></a>
# **ReposListLanguages**
> Dictionary<string, int?> ReposListLanguages (string owner, string repo)

List repository languages

Lists languages for the specified repository. The value shown for each language is the number of bytes of code written in that language.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListLanguagesExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // List repository languages
                Dictionary&lt;string, int?&gt; result = apiInstance.ReposListLanguages(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListLanguages: " + e.Message );
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

**Dictionary<string, int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistpagesbuilds"></a>
# **ReposListPagesBuilds**
> List<PageBuild> ReposListPagesBuilds (string owner, string repo, int? perPage, int? page)

List GitHub Pages builds



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListPagesBuildsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List GitHub Pages builds
                List&lt;PageBuild&gt; result = apiInstance.ReposListPagesBuilds(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListPagesBuilds: " + e.Message );
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

[**List<PageBuild>**](PageBuild.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistpublic"></a>
# **ReposListPublic**
> List<MinimalRepository> ReposListPublic (int? since)

List public repositories

Lists all public repositories in the order that they were created.  Note: - For GitHub Enterprise Server, this endpoint will only list repositories available to all users on the enterprise. - Pagination is powered exclusively by the `since` parameter. Use the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header) to get the URL for the next page of repositories.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListPublicExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var since = 56;  // int? | A repository ID. Only return repositories with an ID greater than this ID. (optional) 

            try
            {
                // List public repositories
                List&lt;MinimalRepository&gt; result = apiInstance.ReposListPublic(since);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListPublic: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **since** | **int?**| A repository ID. Only return repositories with an ID greater than this ID. | [optional] 

### Return type

[**List<MinimalRepository>**](MinimalRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistpullrequestsassociatedwithcommit"></a>
# **ReposListPullRequestsAssociatedWithCommit**
> List<PullRequestSimple> ReposListPullRequestsAssociatedWithCommit (string owner, string repo, string commitSha, int? perPage, int? page)

List pull requests associated with a commit

Lists the merged pull request that introduced the commit to the repository. If the commit is not present in the default branch, additionally returns open pull requests associated with the commit. The results may include open and closed pull requests.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListPullRequestsAssociatedWithCommitExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commitSha = "commitSha_example";  // string | The SHA of the commit.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List pull requests associated with a commit
                List&lt;PullRequestSimple&gt; result = apiInstance.ReposListPullRequestsAssociatedWithCommit(owner, repo, commitSha, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListPullRequestsAssociatedWithCommit: " + e.Message );
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
 **commitSha** | **string**| The SHA of the commit. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<PullRequestSimple>**](PullRequestSimple.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistreleaseassets"></a>
# **ReposListReleaseAssets**
> List<ReleaseAsset> ReposListReleaseAssets (string owner, string repo, int? releaseId, int? perPage, int? page)

List release assets



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListReleaseAssetsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var releaseId = 56;  // int? | The unique identifier of the release.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List release assets
                List&lt;ReleaseAsset&gt; result = apiInstance.ReposListReleaseAssets(owner, repo, releaseId, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListReleaseAssets: " + e.Message );
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
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<ReleaseAsset>**](ReleaseAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistreleases"></a>
# **ReposListReleases**
> List<Release> ReposListReleases (string owner, string repo, int? perPage, int? page)

List releases

This returns a list of releases, which does not include regular Git tags that have not been associated with a release. To get a list of Git tags, use the [Repository Tags API](https://docs.github.com/rest/reference/repos#list-repository-tags).  Information about published releases are available to everyone. Only users with push access will receive listings for draft releases.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListReleasesExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List releases
                List&lt;Release&gt; result = apiInstance.ReposListReleases(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListReleases: " + e.Message );
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

[**List<Release>**](Release.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlisttagprotection"></a>
# **ReposListTagProtection**
> List<TagProtection> ReposListTagProtection (string owner, string repo)

List tag protection states for a repository

This returns the tag protection states of a repository.  This information is only available to repository administrators.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListTagProtectionExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // List tag protection states for a repository
                List&lt;TagProtection&gt; result = apiInstance.ReposListTagProtection(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListTagProtection: " + e.Message );
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

[**List<TagProtection>**](TagProtection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlisttags"></a>
# **ReposListTags**
> List<Tag> ReposListTags (string owner, string repo, int? perPage, int? page)

List repository tags



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListTagsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repository tags
                List&lt;Tag&gt; result = apiInstance.ReposListTags(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListTags: " + e.Message );
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

[**List<Tag>**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistteams"></a>
# **ReposListTeams**
> List<Team> ReposListTeams (string owner, string repo, int? perPage, int? page)

List repository teams



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListTeamsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repository teams
                List&lt;Team&gt; result = apiInstance.ReposListTeams(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListTeams: " + e.Message );
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

[**List<Team>**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistwebhookdeliveries"></a>
# **ReposListWebhookDeliveries**
> List<SimpleWebhookDelivery> ReposListWebhookDeliveries (string owner, string repo, int? hookId, int? perPage, string cursor)

List deliveries for a repository webhook

Returns a list of webhook deliveries for a webhook configured in a repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListWebhookDeliveriesExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var hookId = 56;  // int? | The unique identifier of the hook.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var cursor = "cursor_example";  // string | Used for pagination: the starting delivery from which the page of deliveries is fetched. Refer to the `link` header for the next and previous page cursors. (optional) 

            try
            {
                // List deliveries for a repository webhook
                List&lt;SimpleWebhookDelivery&gt; result = apiInstance.ReposListWebhookDeliveries(owner, repo, hookId, perPage, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListWebhookDeliveries: " + e.Message );
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
 **hookId** | **int?**| The unique identifier of the hook. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **cursor** | **string**| Used for pagination: the starting delivery from which the page of deliveries is fetched. Refer to the &#x60;link&#x60; header for the next and previous page cursors. | [optional] 

### Return type

[**List<SimpleWebhookDelivery>**](SimpleWebhookDelivery.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/scim+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposlistwebhooks"></a>
# **ReposListWebhooks**
> List<Webhook> ReposListWebhooks (string owner, string repo, int? perPage, int? page)

List repository webhooks



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposListWebhooksExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repository webhooks
                List&lt;Webhook&gt; result = apiInstance.ReposListWebhooks(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposListWebhooks: " + e.Message );
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

[**List<Webhook>**](Webhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposmerge"></a>
# **ReposMerge**
> Commit ReposMerge (string owner, string repo, ReposMergeRequest reposMergeRequest)

Merge a branch



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposMergeExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var reposMergeRequest = new ReposMergeRequest(); // ReposMergeRequest | 

            try
            {
                // Merge a branch
                Commit result = apiInstance.ReposMerge(owner, repo, reposMergeRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposMerge: " + e.Message );
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
 **reposMergeRequest** | [**ReposMergeRequest**](ReposMergeRequest.md)|  | 

### Return type

[**Commit**](Commit.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposmergeupstream"></a>
# **ReposMergeUpstream**
> MergedUpstream ReposMergeUpstream (string owner, string repo, ReposMergeUpstreamRequest reposMergeUpstreamRequest)

Sync a fork branch with the upstream repository

Sync a branch of a forked repository to keep it up-to-date with the upstream repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposMergeUpstreamExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var reposMergeUpstreamRequest = new ReposMergeUpstreamRequest(); // ReposMergeUpstreamRequest | 

            try
            {
                // Sync a fork branch with the upstream repository
                MergedUpstream result = apiInstance.ReposMergeUpstream(owner, repo, reposMergeUpstreamRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposMergeUpstream: " + e.Message );
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
 **reposMergeUpstreamRequest** | [**ReposMergeUpstreamRequest**](ReposMergeUpstreamRequest.md)|  | 

### Return type

[**MergedUpstream**](MergedUpstream.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repospingwebhook"></a>
# **ReposPingWebhook**
> void ReposPingWebhook (string owner, string repo, int? hookId)

Ping a repository webhook

This will trigger a [ping event](https://docs.github.com/webhooks/#ping-event) to be sent to the hook.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposPingWebhookExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var hookId = 56;  // int? | The unique identifier of the hook.

            try
            {
                // Ping a repository webhook
                apiInstance.ReposPingWebhook(owner, repo, hookId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposPingWebhook: " + e.Message );
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
 **hookId** | **int?**| The unique identifier of the hook. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposredeliverwebhookdelivery"></a>
# **ReposRedeliverWebhookDelivery**
> Object ReposRedeliverWebhookDelivery (string owner, string repo, int? hookId, int? deliveryId)

Redeliver a delivery for a repository webhook

Redeliver a webhook delivery for a webhook configured in a repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposRedeliverWebhookDeliveryExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var hookId = 56;  // int? | The unique identifier of the hook.
            var deliveryId = 56;  // int? | 

            try
            {
                // Redeliver a delivery for a repository webhook
                Object result = apiInstance.ReposRedeliverWebhookDelivery(owner, repo, hookId, deliveryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposRedeliverWebhookDelivery: " + e.Message );
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
 **hookId** | **int?**| The unique identifier of the hook. | 
 **deliveryId** | **int?**|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/scim+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposremoveappaccessrestrictions"></a>
# **ReposRemoveAppAccessRestrictions**
> List<GitHubApp> ReposRemoveAppAccessRestrictions (string owner, string repo, string branch, ReposSetAppAccessRestrictionsRequest reposSetAppAccessRestrictionsRequest)

Remove app access restrictions

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Removes the ability of an app to push to this branch. Only installed GitHub Apps with `write` access to the `contents` permission can be added as authorized actors on a protected branch.  | Type    | Description                                                                                                                                                | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | `array` | The GitHub Apps that have push access to this branch. Use the app's `slug`. **Note**: The list of users, apps, and teams in total is limited to 100 items. |

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposRemoveAppAccessRestrictionsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.
            var reposSetAppAccessRestrictionsRequest = new ReposSetAppAccessRestrictionsRequest(); // ReposSetAppAccessRestrictionsRequest |  (optional) 

            try
            {
                // Remove app access restrictions
                List&lt;GitHubApp&gt; result = apiInstance.ReposRemoveAppAccessRestrictions(owner, repo, branch, reposSetAppAccessRestrictionsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposRemoveAppAccessRestrictions: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 
 **reposSetAppAccessRestrictionsRequest** | [**ReposSetAppAccessRestrictionsRequest**](ReposSetAppAccessRestrictionsRequest.md)|  | [optional] 

### Return type

[**List<GitHubApp>**](GitHubApp.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposremovecollaborator"></a>
# **ReposRemoveCollaborator**
> void ReposRemoveCollaborator (string owner, string repo, string username)

Remove a repository collaborator



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposRemoveCollaboratorExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Remove a repository collaborator
                apiInstance.ReposRemoveCollaborator(owner, repo, username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposRemoveCollaborator: " + e.Message );
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
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposremovestatuscheckcontexts"></a>
# **ReposRemoveStatusCheckContexts**
> List<string> ReposRemoveStatusCheckContexts (string owner, string repo, string branch, ReposSetStatusCheckContextsRequest reposSetStatusCheckContextsRequest)

Remove status check contexts

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposRemoveStatusCheckContextsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.
            var reposSetStatusCheckContextsRequest = new ReposSetStatusCheckContextsRequest(); // ReposSetStatusCheckContextsRequest |  (optional) 

            try
            {
                // Remove status check contexts
                List&lt;string&gt; result = apiInstance.ReposRemoveStatusCheckContexts(owner, repo, branch, reposSetStatusCheckContextsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposRemoveStatusCheckContexts: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 
 **reposSetStatusCheckContextsRequest** | [**ReposSetStatusCheckContextsRequest**](ReposSetStatusCheckContextsRequest.md)|  | [optional] 

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposremovestatuscheckprotection"></a>
# **ReposRemoveStatusCheckProtection**
> void ReposRemoveStatusCheckProtection (string owner, string repo, string branch)

Remove status check protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposRemoveStatusCheckProtectionExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.

            try
            {
                // Remove status check protection
                apiInstance.ReposRemoveStatusCheckProtection(owner, repo, branch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposRemoveStatusCheckProtection: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposremoveteamaccessrestrictions"></a>
# **ReposRemoveTeamAccessRestrictions**
> List<Team> ReposRemoveTeamAccessRestrictions (string owner, string repo, string branch, ReposSetTeamAccessRestrictionsRequest reposSetTeamAccessRestrictionsRequest)

Remove team access restrictions

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Removes the ability of a team to push to this branch. You can also remove push access for child teams.  | Type    | Description                                                                                                                                         | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | `array` | Teams that should no longer have push access. Use the team's `slug`. **Note**: The list of users, apps, and teams in total is limited to 100 items. |

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposRemoveTeamAccessRestrictionsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.
            var reposSetTeamAccessRestrictionsRequest = new ReposSetTeamAccessRestrictionsRequest(); // ReposSetTeamAccessRestrictionsRequest |  (optional) 

            try
            {
                // Remove team access restrictions
                List&lt;Team&gt; result = apiInstance.ReposRemoveTeamAccessRestrictions(owner, repo, branch, reposSetTeamAccessRestrictionsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposRemoveTeamAccessRestrictions: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 
 **reposSetTeamAccessRestrictionsRequest** | [**ReposSetTeamAccessRestrictionsRequest**](ReposSetTeamAccessRestrictionsRequest.md)|  | [optional] 

### Return type

[**List<Team>**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposremoveuseraccessrestrictions"></a>
# **ReposRemoveUserAccessRestrictions**
> List<SimpleUser1> ReposRemoveUserAccessRestrictions (string owner, string repo, string branch, ReposSetUserAccessRestrictionsRequest reposSetUserAccessRestrictionsRequest)

Remove user access restrictions

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Removes the ability of a user to push to this branch.  | Type    | Description                                                                                                                                   | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | `array` | Usernames of the people who should no longer have push access. **Note**: The list of users, apps, and teams in total is limited to 100 items. |

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposRemoveUserAccessRestrictionsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.
            var reposSetUserAccessRestrictionsRequest = new ReposSetUserAccessRestrictionsRequest(); // ReposSetUserAccessRestrictionsRequest |  (optional) 

            try
            {
                // Remove user access restrictions
                List&lt;SimpleUser1&gt; result = apiInstance.ReposRemoveUserAccessRestrictions(owner, repo, branch, reposSetUserAccessRestrictionsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposRemoveUserAccessRestrictions: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 
 **reposSetUserAccessRestrictionsRequest** | [**ReposSetUserAccessRestrictionsRequest**](ReposSetUserAccessRestrictionsRequest.md)|  | [optional] 

### Return type

[**List<SimpleUser1>**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposrenamebranch"></a>
# **ReposRenameBranch**
> BranchWithProtection ReposRenameBranch (string owner, string repo, string branch, ReposRenameBranchRequest reposRenameBranchRequest)

Rename a branch

Renames a branch in a repository.  **Note:** Although the API responds immediately, the branch rename process might take some extra time to complete in the background. You won't be able to push to the old branch name while the rename process is in progress. For more information, see \"[Renaming a branch](https://docs.github.com/github/administering-a-repository/renaming-a-branch)\".  The permissions required to use this endpoint depends on whether you are renaming the default branch.  To rename a non-default branch:  * Users must have push access. * GitHub Apps must have the `contents:write` repository permission.  To rename the default branch:  * Users must have admin or owner permissions. * GitHub Apps must have the `administration:write` repository permission.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposRenameBranchExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.
            var reposRenameBranchRequest = new ReposRenameBranchRequest(); // ReposRenameBranchRequest | 

            try
            {
                // Rename a branch
                BranchWithProtection result = apiInstance.ReposRenameBranch(owner, repo, branch, reposRenameBranchRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposRenameBranch: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 
 **reposRenameBranchRequest** | [**ReposRenameBranchRequest**](ReposRenameBranchRequest.md)|  | 

### Return type

[**BranchWithProtection**](BranchWithProtection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposreplacealltopics"></a>
# **ReposReplaceAllTopics**
> Topic ReposReplaceAllTopics (string owner, string repo, ReposReplaceAllTopicsRequest reposReplaceAllTopicsRequest)

Replace all repository topics



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposReplaceAllTopicsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var reposReplaceAllTopicsRequest = new ReposReplaceAllTopicsRequest(); // ReposReplaceAllTopicsRequest | 

            try
            {
                // Replace all repository topics
                Topic result = apiInstance.ReposReplaceAllTopics(owner, repo, reposReplaceAllTopicsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposReplaceAllTopics: " + e.Message );
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
 **reposReplaceAllTopicsRequest** | [**ReposReplaceAllTopicsRequest**](ReposReplaceAllTopicsRequest.md)|  | 

### Return type

[**Topic**](Topic.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposrequestpagesbuild"></a>
# **ReposRequestPagesBuild**
> PageBuildStatus ReposRequestPagesBuild (string owner, string repo)

Request a GitHub Pages build

You can request that your site be built from the latest revision on the default branch. This has the same effect as pushing a commit to your default branch, but does not require an additional commit. Manually triggering page builds can be helpful when diagnosing build warnings and failures.  Build requests are limited to one concurrent build per repository and one concurrent build per requester. If you request a build while another is still in progress, the second request will be queued until the first completes.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposRequestPagesBuildExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Request a GitHub Pages build
                PageBuildStatus result = apiInstance.ReposRequestPagesBuild(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposRequestPagesBuild: " + e.Message );
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

[**PageBuildStatus**](PageBuildStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repossetadminbranchprotection"></a>
# **ReposSetAdminBranchProtection**
> ProtectedBranchAdminEnforced ReposSetAdminBranchProtection (string owner, string repo, string branch)

Set admin branch protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Adding admin enforcement requires admin or owner permissions to the repository and branch protection to be enabled.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposSetAdminBranchProtectionExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.

            try
            {
                // Set admin branch protection
                ProtectedBranchAdminEnforced result = apiInstance.ReposSetAdminBranchProtection(owner, repo, branch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposSetAdminBranchProtection: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 

### Return type

[**ProtectedBranchAdminEnforced**](ProtectedBranchAdminEnforced.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repossetappaccessrestrictions"></a>
# **ReposSetAppAccessRestrictions**
> List<GitHubApp> ReposSetAppAccessRestrictions (string owner, string repo, string branch, ReposSetAppAccessRestrictionsRequest reposSetAppAccessRestrictionsRequest)

Set app access restrictions

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Replaces the list of apps that have push access to this branch. This removes all apps that previously had push access and grants push access to the new list of apps. Only installed GitHub Apps with `write` access to the `contents` permission can be added as authorized actors on a protected branch.  | Type    | Description                                                                                                                                                | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | `array` | The GitHub Apps that have push access to this branch. Use the app's `slug`. **Note**: The list of users, apps, and teams in total is limited to 100 items. |

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposSetAppAccessRestrictionsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.
            var reposSetAppAccessRestrictionsRequest = new ReposSetAppAccessRestrictionsRequest(); // ReposSetAppAccessRestrictionsRequest |  (optional) 

            try
            {
                // Set app access restrictions
                List&lt;GitHubApp&gt; result = apiInstance.ReposSetAppAccessRestrictions(owner, repo, branch, reposSetAppAccessRestrictionsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposSetAppAccessRestrictions: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 
 **reposSetAppAccessRestrictionsRequest** | [**ReposSetAppAccessRestrictionsRequest**](ReposSetAppAccessRestrictionsRequest.md)|  | [optional] 

### Return type

[**List<GitHubApp>**](GitHubApp.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repossetstatuscheckcontexts"></a>
# **ReposSetStatusCheckContexts**
> List<string> ReposSetStatusCheckContexts (string owner, string repo, string branch, ReposSetStatusCheckContextsRequest reposSetStatusCheckContextsRequest)

Set status check contexts

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposSetStatusCheckContextsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.
            var reposSetStatusCheckContextsRequest = new ReposSetStatusCheckContextsRequest(); // ReposSetStatusCheckContextsRequest |  (optional) 

            try
            {
                // Set status check contexts
                List&lt;string&gt; result = apiInstance.ReposSetStatusCheckContexts(owner, repo, branch, reposSetStatusCheckContextsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposSetStatusCheckContexts: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 
 **reposSetStatusCheckContextsRequest** | [**ReposSetStatusCheckContextsRequest**](ReposSetStatusCheckContextsRequest.md)|  | [optional] 

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repossetteamaccessrestrictions"></a>
# **ReposSetTeamAccessRestrictions**
> List<Team> ReposSetTeamAccessRestrictions (string owner, string repo, string branch, ReposSetTeamAccessRestrictionsRequest reposSetTeamAccessRestrictionsRequest)

Set team access restrictions

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Replaces the list of teams that have push access to this branch. This removes all teams that previously had push access and grants push access to the new list of teams. Team restrictions include child teams.  | Type    | Description                                                                                                                                | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | `array` | The teams that can have push access. Use the team's `slug`. **Note**: The list of users, apps, and teams in total is limited to 100 items. |

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposSetTeamAccessRestrictionsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.
            var reposSetTeamAccessRestrictionsRequest = new ReposSetTeamAccessRestrictionsRequest(); // ReposSetTeamAccessRestrictionsRequest |  (optional) 

            try
            {
                // Set team access restrictions
                List&lt;Team&gt; result = apiInstance.ReposSetTeamAccessRestrictions(owner, repo, branch, reposSetTeamAccessRestrictionsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposSetTeamAccessRestrictions: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 
 **reposSetTeamAccessRestrictionsRequest** | [**ReposSetTeamAccessRestrictionsRequest**](ReposSetTeamAccessRestrictionsRequest.md)|  | [optional] 

### Return type

[**List<Team>**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repossetuseraccessrestrictions"></a>
# **ReposSetUserAccessRestrictions**
> List<SimpleUser1> ReposSetUserAccessRestrictions (string owner, string repo, string branch, ReposSetUserAccessRestrictionsRequest reposSetUserAccessRestrictionsRequest)

Set user access restrictions

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Replaces the list of people that have push access to this branch. This removes all people that previously had push access and grants push access to the new list of people.  | Type    | Description                                                                                                                   | | - -- -- -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | `array` | Usernames for people who can have push access. **Note**: The list of users, apps, and teams in total is limited to 100 items. |

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposSetUserAccessRestrictionsExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.
            var reposSetUserAccessRestrictionsRequest = new ReposSetUserAccessRestrictionsRequest(); // ReposSetUserAccessRestrictionsRequest |  (optional) 

            try
            {
                // Set user access restrictions
                List&lt;SimpleUser1&gt; result = apiInstance.ReposSetUserAccessRestrictions(owner, repo, branch, reposSetUserAccessRestrictionsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposSetUserAccessRestrictions: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 
 **reposSetUserAccessRestrictionsRequest** | [**ReposSetUserAccessRestrictionsRequest**](ReposSetUserAccessRestrictionsRequest.md)|  | [optional] 

### Return type

[**List<SimpleUser1>**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repostestpushwebhook"></a>
# **ReposTestPushWebhook**
> void ReposTestPushWebhook (string owner, string repo, int? hookId)

Test the push repository webhook

This will trigger the hook with the latest push to the current repository if the hook is subscribed to `push` events. If the hook is not subscribed to `push` events, the server will respond with 204 but no test POST will be generated.  **Note**: Previously `/repos/:owner/:repo/hooks/:hook_id/test`

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposTestPushWebhookExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var hookId = 56;  // int? | The unique identifier of the hook.

            try
            {
                // Test the push repository webhook
                apiInstance.ReposTestPushWebhook(owner, repo, hookId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposTestPushWebhook: " + e.Message );
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
 **hookId** | **int?**| The unique identifier of the hook. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repostransfer"></a>
# **ReposTransfer**
> MinimalRepository ReposTransfer (string owner, string repo, ReposTransferRequest reposTransferRequest)

Transfer a repository

A transfer request will need to be accepted by the new owner when transferring a personal repository to another user. The response will contain the original `owner`, and the transfer will continue asynchronously. For more details on the requirements to transfer personal and organization-owned repositories, see [about repository transfers](https://docs.github.com/articles/about-repository-transfers/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposTransferExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var reposTransferRequest = new ReposTransferRequest(); // ReposTransferRequest | 

            try
            {
                // Transfer a repository
                MinimalRepository result = apiInstance.ReposTransfer(owner, repo, reposTransferRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposTransfer: " + e.Message );
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
 **reposTransferRequest** | [**ReposTransferRequest**](ReposTransferRequest.md)|  | 

### Return type

[**MinimalRepository**](MinimalRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposupdate"></a>
# **ReposUpdate**
> FullRepository ReposUpdate (string owner, string repo, ReposUpdateRequest reposUpdateRequest)

Update a repository

**Note**: To edit a repository's topics, use the [Replace all repository topics](https://docs.github.com/rest/reference/repos#replace-all-repository-topics) endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposUpdateExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var reposUpdateRequest = new ReposUpdateRequest(); // ReposUpdateRequest |  (optional) 

            try
            {
                // Update a repository
                FullRepository result = apiInstance.ReposUpdate(owner, repo, reposUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposUpdate: " + e.Message );
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
 **reposUpdateRequest** | [**ReposUpdateRequest**](ReposUpdateRequest.md)|  | [optional] 

### Return type

[**FullRepository**](FullRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposupdatebranchprotection"></a>
# **ReposUpdateBranchProtection**
> ProtectedBranch ReposUpdateBranchProtection (string owner, string repo, string branch, ReposUpdateBranchProtectionRequest reposUpdateBranchProtectionRequest)

Update branch protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Protecting a branch requires admin or owner permissions to the repository.  **Note**: Passing new arrays of `users` and `teams` replaces their previous values.  **Note**: The list of users, apps, and teams in total is limited to 100 items.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposUpdateBranchProtectionExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.
            var reposUpdateBranchProtectionRequest = new ReposUpdateBranchProtectionRequest(); // ReposUpdateBranchProtectionRequest | 

            try
            {
                // Update branch protection
                ProtectedBranch result = apiInstance.ReposUpdateBranchProtection(owner, repo, branch, reposUpdateBranchProtectionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposUpdateBranchProtection: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 
 **reposUpdateBranchProtectionRequest** | [**ReposUpdateBranchProtectionRequest**](ReposUpdateBranchProtectionRequest.md)|  | 

### Return type

[**ProtectedBranch**](ProtectedBranch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposupdatecommitcomment"></a>
# **ReposUpdateCommitComment**
> CommitComment ReposUpdateCommitComment (string owner, string repo, int? commentId, ReposUpdateCommitCommentRequest reposUpdateCommitCommentRequest)

Update a commit comment



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposUpdateCommitCommentExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commentId = 56;  // int? | The unique identifier of the comment.
            var reposUpdateCommitCommentRequest = new ReposUpdateCommitCommentRequest(); // ReposUpdateCommitCommentRequest | 

            try
            {
                // Update a commit comment
                CommitComment result = apiInstance.ReposUpdateCommitComment(owner, repo, commentId, reposUpdateCommitCommentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposUpdateCommitComment: " + e.Message );
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
 **reposUpdateCommitCommentRequest** | [**ReposUpdateCommitCommentRequest**](ReposUpdateCommitCommentRequest.md)|  | 

### Return type

[**CommitComment**](CommitComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposupdateinformationaboutpagessite"></a>
# **ReposUpdateInformationAboutPagesSite**
> void ReposUpdateInformationAboutPagesSite (string owner, string repo, ReposUpdateInformationAboutPagesSiteRequest reposUpdateInformationAboutPagesSiteRequest)

Update information about a GitHub Pages site

Updates information for a GitHub Pages site. For more information, see \"[About GitHub Pages](/github/working-with-github-pages/about-github-pages).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposUpdateInformationAboutPagesSiteExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var reposUpdateInformationAboutPagesSiteRequest = new ReposUpdateInformationAboutPagesSiteRequest(); // ReposUpdateInformationAboutPagesSiteRequest | 

            try
            {
                // Update information about a GitHub Pages site
                apiInstance.ReposUpdateInformationAboutPagesSite(owner, repo, reposUpdateInformationAboutPagesSiteRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposUpdateInformationAboutPagesSite: " + e.Message );
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
 **reposUpdateInformationAboutPagesSiteRequest** | [**ReposUpdateInformationAboutPagesSiteRequest**](ReposUpdateInformationAboutPagesSiteRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/scim+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposupdateinvitation"></a>
# **ReposUpdateInvitation**
> RepositoryInvitation ReposUpdateInvitation (string owner, string repo, int? invitationId, ReposUpdateInvitationRequest reposUpdateInvitationRequest)

Update a repository invitation



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposUpdateInvitationExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var invitationId = 56;  // int? | The unique identifier of the invitation.
            var reposUpdateInvitationRequest = new ReposUpdateInvitationRequest(); // ReposUpdateInvitationRequest |  (optional) 

            try
            {
                // Update a repository invitation
                RepositoryInvitation result = apiInstance.ReposUpdateInvitation(owner, repo, invitationId, reposUpdateInvitationRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposUpdateInvitation: " + e.Message );
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
 **invitationId** | **int?**| The unique identifier of the invitation. | 
 **reposUpdateInvitationRequest** | [**ReposUpdateInvitationRequest**](ReposUpdateInvitationRequest.md)|  | [optional] 

### Return type

[**RepositoryInvitation**](RepositoryInvitation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposupdatepullrequestreviewprotection"></a>
# **ReposUpdatePullRequestReviewProtection**
> ProtectedBranchPullRequestReview ReposUpdatePullRequestReviewProtection (string owner, string repo, string branch, ReposUpdatePullRequestReviewProtectionRequest reposUpdatePullRequestReviewProtectionRequest)

Update pull request review protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Updating pull request review enforcement requires admin or owner permissions to the repository and branch protection to be enabled.  **Note**: Passing new arrays of `users` and `teams` replaces their previous values.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposUpdatePullRequestReviewProtectionExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.
            var reposUpdatePullRequestReviewProtectionRequest = new ReposUpdatePullRequestReviewProtectionRequest(); // ReposUpdatePullRequestReviewProtectionRequest |  (optional) 

            try
            {
                // Update pull request review protection
                ProtectedBranchPullRequestReview result = apiInstance.ReposUpdatePullRequestReviewProtection(owner, repo, branch, reposUpdatePullRequestReviewProtectionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposUpdatePullRequestReviewProtection: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 
 **reposUpdatePullRequestReviewProtectionRequest** | [**ReposUpdatePullRequestReviewProtectionRequest**](ReposUpdatePullRequestReviewProtectionRequest.md)|  | [optional] 

### Return type

[**ProtectedBranchPullRequestReview**](ProtectedBranchPullRequestReview.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposupdaterelease"></a>
# **ReposUpdateRelease**
> Release ReposUpdateRelease (string owner, string repo, int? releaseId, ReposUpdateReleaseRequest reposUpdateReleaseRequest)

Update a release

Users with push access to the repository can edit a release.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposUpdateReleaseExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var releaseId = 56;  // int? | The unique identifier of the release.
            var reposUpdateReleaseRequest = new ReposUpdateReleaseRequest(); // ReposUpdateReleaseRequest |  (optional) 

            try
            {
                // Update a release
                Release result = apiInstance.ReposUpdateRelease(owner, repo, releaseId, reposUpdateReleaseRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposUpdateRelease: " + e.Message );
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
 **reposUpdateReleaseRequest** | [**ReposUpdateReleaseRequest**](ReposUpdateReleaseRequest.md)|  | [optional] 

### Return type

[**Release**](Release.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposupdatereleaseasset"></a>
# **ReposUpdateReleaseAsset**
> ReleaseAsset ReposUpdateReleaseAsset (string owner, string repo, int? assetId, ReposUpdateReleaseAssetRequest reposUpdateReleaseAssetRequest)

Update a release asset

Users with push access to the repository can edit a release asset.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposUpdateReleaseAssetExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var assetId = 56;  // int? | The unique identifier of the asset.
            var reposUpdateReleaseAssetRequest = new ReposUpdateReleaseAssetRequest(); // ReposUpdateReleaseAssetRequest |  (optional) 

            try
            {
                // Update a release asset
                ReleaseAsset result = apiInstance.ReposUpdateReleaseAsset(owner, repo, assetId, reposUpdateReleaseAssetRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposUpdateReleaseAsset: " + e.Message );
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
 **assetId** | **int?**| The unique identifier of the asset. | 
 **reposUpdateReleaseAssetRequest** | [**ReposUpdateReleaseAssetRequest**](ReposUpdateReleaseAssetRequest.md)|  | [optional] 

### Return type

[**ReleaseAsset**](ReleaseAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposupdatestatuscheckprotection"></a>
# **ReposUpdateStatusCheckProtection**
> StatusCheckPolicy ReposUpdateStatusCheckProtection (string owner, string repo, string branch, ReposUpdateStatusCheckProtectionRequest reposUpdateStatusCheckProtectionRequest)

Update status check protection

Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.  Updating required status checks requires admin or owner permissions to the repository and branch protection to be enabled.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposUpdateStatusCheckProtectionExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var branch = "branch_example";  // string | The name of the branch.
            var reposUpdateStatusCheckProtectionRequest = new ReposUpdateStatusCheckProtectionRequest(); // ReposUpdateStatusCheckProtectionRequest |  (optional) 

            try
            {
                // Update status check protection
                StatusCheckPolicy result = apiInstance.ReposUpdateStatusCheckProtection(owner, repo, branch, reposUpdateStatusCheckProtectionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposUpdateStatusCheckProtection: " + e.Message );
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
 **branch** | **string**| The name of the branch. | 
 **reposUpdateStatusCheckProtectionRequest** | [**ReposUpdateStatusCheckProtectionRequest**](ReposUpdateStatusCheckProtectionRequest.md)|  | [optional] 

### Return type

[**StatusCheckPolicy**](StatusCheckPolicy.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposupdatewebhook"></a>
# **ReposUpdateWebhook**
> Webhook ReposUpdateWebhook (string owner, string repo, int? hookId, ReposUpdateWebhookRequest reposUpdateWebhookRequest)

Update a repository webhook

Updates a webhook configured in a repository. If you previously had a `secret` set, you must provide the same `secret` or set a new `secret` or the secret will be removed. If you are only updating individual webhook `config` properties, use \"[Update a webhook configuration for a repository](/rest/reference/repos#update-a-webhook-configuration-for-a-repository).\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposUpdateWebhookExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var hookId = 56;  // int? | The unique identifier of the hook.
            var reposUpdateWebhookRequest = new ReposUpdateWebhookRequest(); // ReposUpdateWebhookRequest | 

            try
            {
                // Update a repository webhook
                Webhook result = apiInstance.ReposUpdateWebhook(owner, repo, hookId, reposUpdateWebhookRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposUpdateWebhook: " + e.Message );
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
 **hookId** | **int?**| The unique identifier of the hook. | 
 **reposUpdateWebhookRequest** | [**ReposUpdateWebhookRequest**](ReposUpdateWebhookRequest.md)|  | 

### Return type

[**Webhook**](Webhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposupdatewebhookconfigforrepo"></a>
# **ReposUpdateWebhookConfigForRepo**
> WebhookConfiguration ReposUpdateWebhookConfigForRepo (string owner, string repo, int? hookId, ReposUpdateWebhookConfigForRepoRequest reposUpdateWebhookConfigForRepoRequest)

Update a webhook configuration for a repository

Updates the webhook configuration for a repository. To update more information about the webhook, including the `active` state and `events`, use \"[Update a repository webhook](/rest/reference/orgs#update-a-repository-webhook).\"  Access tokens must have the `write:repo_hook` or `repo` scope, and GitHub Apps must have the `repository_hooks:write` permission.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposUpdateWebhookConfigForRepoExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var hookId = 56;  // int? | The unique identifier of the hook.
            var reposUpdateWebhookConfigForRepoRequest = new ReposUpdateWebhookConfigForRepoRequest(); // ReposUpdateWebhookConfigForRepoRequest |  (optional) 

            try
            {
                // Update a webhook configuration for a repository
                WebhookConfiguration result = apiInstance.ReposUpdateWebhookConfigForRepo(owner, repo, hookId, reposUpdateWebhookConfigForRepoRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposUpdateWebhookConfigForRepo: " + e.Message );
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
 **hookId** | **int?**| The unique identifier of the hook. | 
 **reposUpdateWebhookConfigForRepoRequest** | [**ReposUpdateWebhookConfigForRepoRequest**](ReposUpdateWebhookConfigForRepoRequest.md)|  | [optional] 

### Return type

[**WebhookConfiguration**](WebhookConfiguration.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reposuploadreleaseasset"></a>
# **ReposUploadReleaseAsset**
> ReleaseAsset ReposUploadReleaseAsset (string owner, string repo, int? releaseId, string name, string label, string body)

Upload a release asset

This endpoint makes use of [a Hypermedia relation](https://docs.github.com/rest/overview/resources-in-the-rest-api#hypermedia) to determine which URL to access. The endpoint you call to upload release assets is specific to your release. Use the `upload_url` returned in the response of the [Create a release endpoint](https://docs.github.com/rest/reference/repos#create-a-release) to upload a release asset.  You need to use an HTTP client which supports [SNI](http://en.wikipedia.org/wiki/Server_Name_Indication) to make calls to this endpoint.  Most libraries will set the required `Content-Length` header automatically. Use the required `Content-Type` header to provide the media type of the asset. For a list of media types, see [Media Types](https://www.iana.org/assignments/media-types/media-types.xhtml). For example:   `application/zip`  GitHub expects the asset data in its raw binary form, rather than JSON. You will send the raw binary content of the asset as the request body. Everything else about the endpoint is the same as the rest of the API. For example, you'll still need to pass your authentication to be able to upload an asset.  When an upstream failure occurs, you will receive a `502 Bad Gateway` status. This may leave an empty asset with a state of `starter`. It can be safely deleted.  **Notes:** *   GitHub renames asset filenames that have special characters, non-alphanumeric characters, and leading or trailing periods. The \"[List assets for a release](https://docs.github.com/rest/reference/repos#list-assets-for-a-release)\" endpoint lists the renamed filenames. For more information and help, contact [GitHub Support](https://support.github.com/contact?tags=dotcom-rest-api). *   If you upload an asset with the same filename as another uploaded asset, you'll receive an error and must delete the old file before you can re-upload the new asset.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReposUploadReleaseAssetExample
    {
        public void main()
        {
            var apiInstance = new ReposApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var releaseId = 56;  // int? | The unique identifier of the release.
            var name = "name_example";  // string | 
            var label = "label_example";  // string |  (optional) 
            var body = "body_example";  // string |  (optional) 

            try
            {
                // Upload a release asset
                ReleaseAsset result = apiInstance.ReposUploadReleaseAsset(owner, repo, releaseId, name, label, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReposApi.ReposUploadReleaseAsset: " + e.Message );
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
 **name** | **string**|  | 
 **label** | **string**|  | [optional] 
 **body** | **string**|  | [optional] 

### Return type

[**ReleaseAsset**](ReleaseAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

