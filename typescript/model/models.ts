import localVarRequest from 'request';

export * from './actionsCacheUsageByRepository';
export * from './actionsCreateOrUpdateEnvironmentSecretRequest';
export * from './actionsCreateOrUpdateOrgSecretRequest';
export * from './actionsCreateOrUpdateRepoSecretRequest';
export * from './actionsCreateSelfHostedRunnerGroupForOrgRequest';
export * from './actionsCreateWorkflowDispatchRequest';
export * from './actionsGetActionsCacheUsageByRepoForOrg200Response';
export * from './actionsGetActionsCacheUsageForEnterprise200Response';
export * from './actionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response';
export * from './actionsGetGithubActionsPermissionsOrganization200Response';
export * from './actionsGetGithubActionsPermissionsRepository200Response';
export * from './actionsGetWorkflowAccessToRepository200Response';
export * from './actionsGetWorkflowWorkflowIdParameter';
export * from './actionsListArtifactsForRepo200Response';
export * from './actionsListJobsForWorkflowRunAttempt200Response';
export * from './actionsListOrgSecrets200Response';
export * from './actionsListRepoAccessToSelfHostedRunnerGroupInOrg200Response';
export * from './actionsListRepoSecrets200Response';
export * from './actionsListRepoWorkflows200Response';
export * from './actionsListSelectedReposForOrgSecret200Response';
export * from './actionsListSelectedRepositoriesEnabledGithubActionsOrganization200Response';
export * from './actionsListSelfHostedRunnerGroupsForOrg200Response';
export * from './actionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner';
export * from './actionsListSelfHostedRunnersForOrg200Response';
export * from './actionsListWorkflowRunsForRepo200Response';
export * from './actionsOIDCSubjectCustomization';
export * from './actionsPublicKey';
export * from './actionsReRunJobForWorkflowRunRequest';
export * from './actionsReviewPendingDeploymentsForRunRequest';
export * from './actionsSecret';
export * from './actionsSecretForAnOrganization';
export * from './actionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest';
export * from './actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest';
export * from './actionsSetGithubActionsPermissionsOrganizationRequest';
export * from './actionsSetGithubActionsPermissionsRepositoryRequest';
export * from './actionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest';
export * from './actionsSetSelectedReposForOrgSecretRequest';
export * from './actionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest';
export * from './actionsUpdateSelfHostedRunnerGroupForOrgRequest';
export * from './activityListReposStarredByUser200Response';
export * from './activityListStargazersForRepo200Response';
export * from './activityMarkNotificationsAsRead202Response';
export * from './activityMarkNotificationsAsReadRequest';
export * from './activityMarkRepoNotificationsAsRead202Response';
export * from './activityMarkRepoNotificationsAsReadRequest';
export * from './activitySetRepoSubscriptionRequest';
export * from './activitySetThreadSubscriptionRequest';
export * from './actor';
export * from './addedToProjectIssueEvent';
export * from './addedToProjectIssueEventProjectCard';
export * from './analysisDeletion';
export * from './apiOverview';
export * from './apiOverviewSshKeyFingerprints';
export * from './appPermissions';
export * from './appsCheckTokenRequest';
export * from './appsCreateFromManifest201Response';
export * from './appsCreateFromManifest201ResponseAllOf';
export * from './appsCreateInstallationAccessTokenRequest';
export * from './appsDeleteAuthorizationRequest';
export * from './appsListInstallationReposForAuthenticatedUser200Response';
export * from './appsListReposAccessibleToInstallation200Response';
export * from './appsScopeTokenRequest';
export * from './appsUpdateWebhookConfigForAppRequest';
export * from './artifact';
export * from './artifactWorkflowRun';
export * from './assignedIssueEvent';
export * from './authenticationToken';
export * from './authorization';
export * from './authorizationApp';
export * from './autoMerge';
export * from './autolinkReference';
export * from './baseGist';
export * from './baseGistFilesValue';
export * from './basicError';
export * from './billingGetGithubActionsBillingGhe200Response';
export * from './billingGetGithubActionsBillingGhe200ResponseMinutesUsedBreakdown';
export * from './billingGetGithubAdvancedSecurityBillingGhe200Response';
export * from './billingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInner';
export * from './billingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInnerAdvancedSecurityCommittersBreakdownInner';
export * from './billingGetGithubPackagesBillingGhe200Response';
export * from './billingGetSharedStorageBillingGhe200Response';
export * from './blob';
export * from './branchProtection';
export * from './branchProtectionRequiredLinearHistory';
export * from './branchProtectionRequiredSignatures';
export * from './branchRestrictionPolicy';
export * from './branchRestrictionPolicyAppsInner';
export * from './branchRestrictionPolicyAppsInnerOwner';
export * from './branchRestrictionPolicyAppsInnerPermissions';
export * from './branchRestrictionPolicyTeamsInner';
export * from './branchShort';
export * from './branchShortCommit';
export * from './branchWithProtection';
export * from './branchWithProtectionLinks';
export * from './cODEOWNERSErrors';
export * from './cODEOWNERSErrorsErrorsInner';
export * from './checkAnnotation';
export * from './checkRun';
export * from './checkRunCheckSuite';
export * from './checkRunOutput';
export * from './checkSuite';
export * from './checkSuitePreference';
export * from './checkSuitePreferencePreferences';
export * from './checkSuitePreferencePreferencesAutoTriggerChecksInner';
export * from './checksCreateRequest';
export * from './checksCreateRequestActionsInner';
export * from './checksCreateRequestOneOf';
export * from './checksCreateRequestOneOf1';
export * from './checksCreateRequestOutput';
export * from './checksCreateRequestOutputAnnotationsInner';
export * from './checksCreateRequestOutputImagesInner';
export * from './checksCreateSuiteRequest';
export * from './checksListForSuite200Response';
export * from './checksListSuitesForRef200Response';
export * from './checksSetSuitesPreferencesRequest';
export * from './checksSetSuitesPreferencesRequestAutoTriggerChecksInner';
export * from './checksUpdateRequest';
export * from './checksUpdateRequestAnyOf';
export * from './checksUpdateRequestOutput';
export * from './cloneTraffic';
export * from './codeOfConduct';
export * from './codeOfConductSimple';
export * from './codeOfConductSimple1';
export * from './codeScanningGetAlert200Response';
export * from './codeScanningGetSarif200Response';
export * from './codeScanningListAlertsForEnterprise200ResponseInner';
export * from './codeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance';
export * from './codeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstanceLocation';
export * from './codeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstanceMessage';
export * from './codeScanningListAlertsForEnterprise200ResponseInnerRule';
export * from './codeScanningListAlertsForEnterprise200ResponseInnerTool';
export * from './codeScanningListAlertsForEnterprise503Response';
export * from './codeScanningListAlertsForRepo200ResponseInner';
export * from './codeScanningListAlertsForRepo200ResponseInnerRule';
export * from './codeScanningListRecentAnalyses200ResponseInner';
export * from './codeScanningUpdateAlertRequest';
export * from './codeScanningUploadSarif202Response';
export * from './codeScanningUploadSarifRequest';
export * from './codeSearchResultItem';
export * from './codespace';
export * from './codespaceGitStatus';
export * from './codespaceMachine';
export * from './codespaceMachine1';
export * from './codespaceRuntimeConstraints';
export * from './codespacesCreateForAuthenticatedUserRequest';
export * from './codespacesCreateForAuthenticatedUserRequestOneOf';
export * from './codespacesCreateForAuthenticatedUserRequestOneOf1';
export * from './codespacesCreateForAuthenticatedUserRequestOneOf1PullRequest';
export * from './codespacesCreateOrUpdateRepoSecretRequest';
export * from './codespacesCreateOrUpdateSecretForAuthenticatedUserRequest';
export * from './codespacesCreateWithPrForAuthenticatedUserRequest';
export * from './codespacesCreateWithRepoForAuthenticatedUserRequest';
export * from './codespacesListDevcontainersInRepositoryForAuthenticatedUser200Response';
export * from './codespacesListDevcontainersInRepositoryForAuthenticatedUser200ResponseDevcontainersInner';
export * from './codespacesListInOrganization200Response';
export * from './codespacesListRepoSecrets200Response';
export * from './codespacesListSecretsForAuthenticatedUser200Response';
export * from './codespacesPreFlightWithRepoForAuthenticatedUser200Response';
export * from './codespacesPreFlightWithRepoForAuthenticatedUser200ResponseDefaults';
export * from './codespacesPublicKey';
export * from './codespacesRepoMachinesForAuthenticatedUser200Response';
export * from './codespacesSecret';
export * from './codespacesSecret1';
export * from './codespacesSetRepositoriesForSecretForAuthenticatedUserRequest';
export * from './codespacesUpdateForAuthenticatedUserRequest';
export * from './codespacesUserPublicKey';
export * from './collaborator';
export * from './collaborator1';
export * from './collaboratorPermissions';
export * from './combinedCommitStatus';
export * from './commit';
export * from './commitActivity';
export * from './commitComment';
export * from './commitCommit';
export * from './commitCommitTree';
export * from './commitComparison';
export * from './commitParentsInner';
export * from './commitSearchResultItem';
export * from './commitSearchResultItemCommit';
export * from './commitSearchResultItemCommitAuthor';
export * from './commitStats';
export * from './communityHealthFile';
export * from './communityProfile';
export * from './communityProfileFiles';
export * from './containerMetadata';
export * from './contentFile';
export * from './contentTraffic';
export * from './contentTree';
export * from './contentTreeEntriesInner';
export * from './contentTreeEntriesInnerLinks';
export * from './contributor';
export * from './contributorActivity';
export * from './contributorActivityWeeksInner';
export * from './convertedNoteToIssueIssueEvent';
export * from './credentialAuthorization';
export * from './demilestonedIssueEvent';
export * from './dependabotCreateOrUpdateOrgSecretRequest';
export * from './dependabotCreateOrUpdateRepoSecretRequest';
export * from './dependabotListOrgSecrets200Response';
export * from './dependabotListRepoSecrets200Response';
export * from './dependabotPublicKey';
export * from './dependabotSecret';
export * from './dependabotSecretForAnOrganization';
export * from './dependabotSetSelectedReposForOrgSecretRequest';
export * from './dependencyGraphCreateRepositorySnapshot201Response';
export * from './dependencyGraphDiffInner';
export * from './dependencyGraphDiffInnerVulnerabilitiesInner';
export * from './deployKey';
export * from './deployment';
export * from './deployment1';
export * from './deploymentPayload';
export * from './deploymentStatus';
export * from './diffEntry';
export * from './dockerMetadata';
export * from './email';
export * from './enterprise';
export * from './enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest';
export * from './enterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest';
export * from './enterpriseAdminGetAllowedActionsEnterprise200Response';
export * from './enterpriseAdminGetAuditLog200ResponseInner';
export * from './enterpriseAdminGetAuditLog200ResponseInnerActorLocation';
export * from './enterpriseAdminGetGithubActionsPermissionsEnterprise200Response';
export * from './enterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response';
export * from './enterpriseAdminListProvisionedGroupsEnterprise200Response';
export * from './enterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner';
export * from './enterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMembersInner';
export * from './enterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMeta';
export * from './enterpriseAdminListProvisionedIdentitiesEnterprise200Response';
export * from './enterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInner';
export * from './enterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerEmailsInner';
export * from './enterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerGroupsInner';
export * from './enterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerName';
export * from './enterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response';
export * from './enterpriseAdminListSelfHostedRunnerGroupsForEnterprise200Response';
export * from './enterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner';
export * from './enterpriseAdminListSelfHostedRunnersForEnterprise200Response';
export * from './enterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response';
export * from './enterpriseAdminProvisionAndInviteEnterpriseGroupRequest';
export * from './enterpriseAdminProvisionAndInviteEnterpriseGroupRequestMembersInner';
export * from './enterpriseAdminProvisionAndInviteEnterpriseUser201Response';
export * from './enterpriseAdminProvisionAndInviteEnterpriseUser201ResponseEmailsInner';
export * from './enterpriseAdminProvisionAndInviteEnterpriseUserRequest';
export * from './enterpriseAdminProvisionAndInviteEnterpriseUserRequestEmailsInner';
export * from './enterpriseAdminProvisionAndInviteEnterpriseUserRequestName';
export * from './enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest';
export * from './enterpriseAdminSetGithubActionsPermissionsEnterpriseRequest';
export * from './enterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest';
export * from './enterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest';
export * from './enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest';
export * from './enterpriseAdminUpdateAttributeForEnterpriseGroupRequest';
export * from './enterpriseAdminUpdateAttributeForEnterpriseGroupRequestOperationsInner';
export * from './enterpriseAdminUpdateAttributeForEnterpriseUserRequest';
export * from './enterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest';
export * from './environment';
export * from './environmentApproval';
export * from './environmentApprovalEnvironmentsInner';
export * from './environmentDeploymentBranchPolicy';
export * from './environmentProtectionRulesInner';
export * from './environmentProtectionRulesInnerAnyOf';
export * from './environmentProtectionRulesInnerAnyOf1';
export * from './environmentProtectionRulesInnerAnyOf2';
export * from './event';
export * from './eventPayload';
export * from './eventPayloadPagesInner';
export * from './eventRepo';
export * from './externalGroup';
export * from './externalGroupMembersInner';
export * from './externalGroupTeamsInner';
export * from './externalGroups';
export * from './externalGroupsGroupsInner';
export * from './feed';
export * from './feedLinks';
export * from './fetchesInformationAboutAnExportOfACodespace';
export * from './fileCommit';
export * from './fileCommitCommit';
export * from './fileCommitCommitAuthor';
export * from './fileCommitCommitParentsInner';
export * from './fileCommitCommitTree';
export * from './fileCommitCommitVerification';
export * from './fileCommitContent';
export * from './fileCommitContentLinks';
export * from './fullRepository';
export * from './fullRepositoryPermissions';
export * from './fullRepositorySecurityAndAnalysis';
export * from './fullRepositorySecurityAndAnalysisAdvancedSecurity';
export * from './fullTeam';
export * from './gPGKey';
export * from './gPGKeyEmailsInner';
export * from './gPGKeySubkeysInner';
export * from './generatedReleaseNotesContent';
export * from './gist';
export * from './gistComment';
export * from './gistCommit';
export * from './gistHistory';
export * from './gistHistoryChangeStatus';
export * from './gistSimple';
export * from './gistSimpleFilesValue';
export * from './gistSimpleForksInner';
export * from './gistsCreateCommentRequest';
export * from './gistsCreateRequest';
export * from './gistsCreateRequestFilesValue';
export * from './gistsCreateRequestPublic';
export * from './gistsCreateRequestPublicOneOf';
export * from './gistsGet403Response';
export * from './gistsGet403ResponseBlock';
export * from './gistsUpdateRequest';
export * from './gistsUpdateRequestFilesValue';
export * from './gitCommit';
export * from './gitCommitAuthor';
export * from './gitCommitParentsInner';
export * from './gitCommitTree';
export * from './gitCommitVerification';
export * from './gitCreateBlobRequest';
export * from './gitCreateCommitRequest';
export * from './gitCreateCommitRequestAuthor';
export * from './gitCreateCommitRequestCommitter';
export * from './gitCreateRefRequest';
export * from './gitCreateTagRequest';
export * from './gitCreateTagRequestTagger';
export * from './gitCreateTreeRequest';
export * from './gitCreateTreeRequestTreeInner';
export * from './gitHubApp';
export * from './gitHubApp1';
export * from './gitHubAppPermissions';
export * from './gitHubPages';
export * from './gitHubPages1';
export * from './gitReference';
export * from './gitReferenceObject';
export * from './gitTag';
export * from './gitTagObject';
export * from './gitTagTagger';
export * from './gitTree';
export * from './gitTreeTreeInner';
export * from './gitUpdateRefRequest';
export * from './gitUser';
export * from './gitignoreTemplate';
export * from './groupMapping';
export * from './groupMappingGroupsInner';
export * from './hookResponse';
export * from './hovercard';
export * from './hovercardContextsInner';
export * from './import';
export * from './importProjectChoicesInner';
export * from './installation';
export * from './installationAccount';
export * from './installationToken';
export * from './interactionLimits';
export * from './interactionRestrictions';
export * from './interactionsGetRestrictionsForOrg200Response';
export * from './issue';
export * from './issue1';
export * from './issueComment';
export * from './issueEvent';
export * from './issueEventDismissedReview';
export * from './issueEventForIssue';
export * from './issueEventLabel';
export * from './issueEventMilestone';
export * from './issueEventProjectCard';
export * from './issueEventRename';
export * from './issueLabelsInner';
export * from './issueLabelsInnerOneOf';
export * from './issuePullRequest';
export * from './issueSearchResultItem';
export * from './issueSearchResultItemLabelsInner';
export * from './issuesAddAssigneesRequest';
export * from './issuesAddLabelsRequest';
export * from './issuesAddLabelsRequestOneOf';
export * from './issuesCreateLabelRequest';
export * from './issuesCreateMilestoneRequest';
export * from './issuesCreateRequest';
export * from './issuesCreateRequestLabelsInner';
export * from './issuesCreateRequestLabelsInnerOneOf';
export * from './issuesCreateRequestMilestone';
export * from './issuesCreateRequestTitle';
export * from './issuesLockRequest';
export * from './issuesRemoveAssigneesRequest';
export * from './issuesSetLabelsRequest';
export * from './issuesSetLabelsRequestOneOf';
export * from './issuesSetLabelsRequestOneOf1';
export * from './issuesSetLabelsRequestOneOf1LabelsInner';
export * from './issuesUpdateCommentRequest';
export * from './issuesUpdateLabelRequest';
export * from './issuesUpdateMilestoneRequest';
export * from './issuesUpdateRequest';
export * from './issuesUpdateRequestMilestone';
export * from './issuesUpdateRequestTitle';
export * from './job';
export * from './jobStepsInner';
export * from './key';
export * from './keySimple';
export * from './label';
export * from './labelSearchResultItem';
export * from './labeledIssueEvent';
export * from './labeledIssueEventLabel';
export * from './legacyReviewComment';
export * from './legacyReviewCommentLinks';
export * from './license';
export * from './licenseContent';
export * from './licenseSimple';
export * from './licenseSimple1';
export * from './link';
export * from './linkWithType';
export * from './lockedIssueEvent';
export * from './markdownRenderRequest';
export * from './marketplaceAccount';
export * from './marketplaceListingPlan';
export * from './marketplacePurchase';
export * from './marketplacePurchaseMarketplacePendingChange';
export * from './marketplacePurchaseMarketplacePurchase';
export * from './mergedUpstream';
export * from './metaRoot200Response';
export * from './metadata';
export * from './migration';
export * from './migrationsMapCommitAuthorRequest';
export * from './migrationsSetLfsPreferenceRequest';
export * from './migrationsStartForAuthenticatedUserRequest';
export * from './migrationsStartForOrgRequest';
export * from './migrationsStartImportRequest';
export * from './migrationsUpdateImportRequest';
export * from './milestone';
export * from './milestone1';
export * from './milestonedIssueEvent';
export * from './milestonedIssueEventMilestone';
export * from './minimalRepository';
export * from './minimalRepository1';
export * from './minimalRepositoryLicense';
export * from './movedColumnInProjectIssueEvent';
export * from './orgHook';
export * from './orgHookConfig';
export * from './orgMembership';
export * from './orgMembershipPermissions';
export * from './organizationCustomRepositoryRole';
export * from './organizationFull';
export * from './organizationFullPlan';
export * from './organizationInvitation';
export * from './organizationSimple';
export * from './orgsConvertMemberToOutsideCollaboratorRequest';
export * from './orgsCreateInvitationRequest';
export * from './orgsCreateWebhookRequest';
export * from './orgsCreateWebhookRequestConfig';
export * from './orgsListAppInstallations200Response';
export * from './orgsListCustomRoles200Response';
export * from './orgsRemoveOutsideCollaborator422Response';
export * from './orgsSetMembershipForUserRequest';
export * from './orgsUpdate422Response';
export * from './orgsUpdateMembershipForAuthenticatedUserRequest';
export * from './orgsUpdateRequest';
export * from './orgsUpdateWebhookRequest';
export * from './orgsUpdateWebhookRequestConfig';
export * from './package';
export * from './packageVersion';
export * from './packageVersionMetadata';
export * from './pageBuild';
export * from './pageBuildError';
export * from './pageBuildStatus';
export * from './pagesHealthCheckStatus';
export * from './pagesHealthCheckStatusAltDomain';
export * from './pagesHealthCheckStatusDomain';
export * from './pagesHttpsCertificate';
export * from './pagesSourceHash';
export * from './participationStats';
export * from './pendingDeployment';
export * from './pendingDeploymentEnvironment';
export * from './pendingDeploymentReviewersInner';
export * from './pendingDeploymentReviewersInnerReviewer';
export * from './porterAuthor';
export * from './porterLargeFile';
export * from './privateUser';
export * from './project';
export * from './projectCard';
export * from './projectCollaboratorPermission';
export * from './projectColumn';
export * from './projectsAddCollaboratorRequest';
export * from './projectsCreateCardRequest';
export * from './projectsCreateCardRequestOneOf';
export * from './projectsCreateCardRequestOneOf1';
export * from './projectsCreateForAuthenticatedUserRequest';
export * from './projectsCreateForOrgRequest';
export * from './projectsDeleteCard403Response';
export * from './projectsMoveCard403Response';
export * from './projectsMoveCard403ResponseErrorsInner';
export * from './projectsMoveCard503Response';
export * from './projectsMoveCard503ResponseErrorsInner';
export * from './projectsMoveCardRequest';
export * from './projectsMoveColumnRequest';
export * from './projectsUpdateCardRequest';
export * from './projectsUpdateColumnRequest';
export * from './projectsUpdateRequest';
export * from './protectedBranch';
export * from './protectedBranchAdminEnforced';
export * from './protectedBranchEnforceAdmins';
export * from './protectedBranchPullRequestReview';
export * from './protectedBranchPullRequestReviewBypassPullRequestAllowances';
export * from './protectedBranchPullRequestReviewDismissalRestrictions';
export * from './protectedBranchRequiredConversationResolution';
export * from './protectedBranchRequiredLinearHistory';
export * from './protectedBranchRequiredPullRequestReviews';
export * from './protectedBranchRequiredPullRequestReviewsBypassPullRequestAllowances';
export * from './protectedBranchRequiredPullRequestReviewsDismissalRestrictions';
export * from './protectedBranchRequiredStatusCheck';
export * from './protectedBranchRequiredStatusCheckChecksInner';
export * from './publicUser';
export * from './publicUserPlan';
export * from './pullRequest';
export * from './pullRequestBase';
export * from './pullRequestBaseRepo';
export * from './pullRequestHead';
export * from './pullRequestHeadRepo';
export * from './pullRequestHeadRepoLicense';
export * from './pullRequestHeadRepoOwner';
export * from './pullRequestLabelsInner';
export * from './pullRequestMergeResult';
export * from './pullRequestMinimal';
export * from './pullRequestMinimalHead';
export * from './pullRequestMinimalHeadRepo';
export * from './pullRequestReview';
export * from './pullRequestReviewComment';
export * from './pullRequestReviewCommentLinks';
export * from './pullRequestReviewCommentLinksHtml';
export * from './pullRequestReviewCommentLinksPullRequest';
export * from './pullRequestReviewCommentLinksSelf';
export * from './pullRequestReviewRequest';
export * from './pullRequestSimple';
export * from './pullRequestSimpleHead';
export * from './pullRequestSimpleLabelsInner';
export * from './pullRequestSimpleLinks';
export * from './pullsCreateReplyForReviewCommentRequest';
export * from './pullsCreateRequest';
export * from './pullsCreateReviewCommentRequest';
export * from './pullsCreateReviewRequest';
export * from './pullsCreateReviewRequestCommentsInner';
export * from './pullsDismissReviewRequest';
export * from './pullsMergeRequest';
export * from './pullsRemoveRequestedReviewersRequest';
export * from './pullsRequestReviewersRequest';
export * from './pullsSubmitReviewRequest';
export * from './pullsUpdateBranchRequest';
export * from './pullsUpdateRequest';
export * from './pullsUpdateReviewCommentRequest';
export * from './pullsUpdateReviewRequest';
export * from './rateLimit';
export * from './rateLimitOverview';
export * from './rateLimitOverviewResources';
export * from './reaction';
export * from './reactionRollup';
export * from './reactionsCreateForCommitCommentRequest';
export * from './reactionsCreateForIssueCommentRequest';
export * from './reactionsCreateForIssueRequest';
export * from './reactionsCreateForPullRequestReviewCommentRequest';
export * from './reactionsCreateForReleaseRequest';
export * from './reactionsCreateForTeamDiscussionCommentInOrgRequest';
export * from './reactionsCreateForTeamDiscussionInOrgRequest';
export * from './referencedWorkflow';
export * from './referrerTraffic';
export * from './release';
export * from './releaseAsset';
export * from './removedFromProjectIssueEvent';
export * from './renamedIssueEvent';
export * from './renamedIssueEventRename';
export * from './repoSearchResultItem';
export * from './reposAddCollaboratorRequest';
export * from './reposCreateAutolinkRequest';
export * from './reposCreateCommitCommentRequest';
export * from './reposCreateCommitStatusRequest';
export * from './reposCreateDeployKeyRequest';
export * from './reposCreateDeploymentRequest';
export * from './reposCreateDeploymentRequestPayload';
export * from './reposCreateDeploymentStatusRequest';
export * from './reposCreateDispatchEventRequest';
export * from './reposCreateForAuthenticatedUserRequest';
export * from './reposCreateForkRequest';
export * from './reposCreateInOrgRequest';
export * from './reposCreateOrUpdateEnvironmentRequest';
export * from './reposCreateOrUpdateEnvironmentRequestReviewersInner';
export * from './reposCreateOrUpdateFileContentsRequest';
export * from './reposCreateOrUpdateFileContentsRequestAuthor';
export * from './reposCreateOrUpdateFileContentsRequestCommitter';
export * from './reposCreatePagesDeploymentRequest';
export * from './reposCreatePagesSiteRequest';
export * from './reposCreatePagesSiteRequestSource';
export * from './reposCreateReleaseRequest';
export * from './reposCreateTagProtectionRequest';
export * from './reposCreateUsingTemplateRequest';
export * from './reposCreateWebhookRequest';
export * from './reposCreateWebhookRequestConfig';
export * from './reposDeleteFileRequest';
export * from './reposDeleteFileRequestAuthor';
export * from './reposDeleteFileRequestCommitter';
export * from './reposGenerateReleaseNotesRequest';
export * from './reposGetAllEnvironments200Response';
export * from './reposGetContent200Response';
export * from './reposMergeRequest';
export * from './reposMergeUpstreamRequest';
export * from './reposRenameBranchRequest';
export * from './reposReplaceAllTopicsRequest';
export * from './reposSetAppAccessRestrictionsRequest';
export * from './reposSetAppAccessRestrictionsRequestOneOf';
export * from './reposSetStatusCheckContextsRequest';
export * from './reposSetStatusCheckContextsRequestOneOf';
export * from './reposSetTeamAccessRestrictionsRequest';
export * from './reposSetTeamAccessRestrictionsRequestOneOf';
export * from './reposSetUserAccessRestrictionsRequest';
export * from './reposSetUserAccessRestrictionsRequestOneOf';
export * from './reposTransferRequest';
export * from './reposUpdateBranchProtectionRequest';
export * from './reposUpdateBranchProtectionRequestRequiredPullRequestReviews';
export * from './reposUpdateBranchProtectionRequestRequiredPullRequestReviewsBypassPullRequestAllowances';
export * from './reposUpdateBranchProtectionRequestRequiredPullRequestReviewsDismissalRestrictions';
export * from './reposUpdateBranchProtectionRequestRequiredStatusChecks';
export * from './reposUpdateBranchProtectionRequestRequiredStatusChecksChecksInner';
export * from './reposUpdateBranchProtectionRequestRestrictions';
export * from './reposUpdateCommitCommentRequest';
export * from './reposUpdateInformationAboutPagesSiteRequest';
export * from './reposUpdateInformationAboutPagesSiteRequestSource';
export * from './reposUpdateInformationAboutPagesSiteRequestSourceAnyOf';
export * from './reposUpdateInformationAboutPagesSiteRequestSourceAnyOf1';
export * from './reposUpdateInvitationRequest';
export * from './reposUpdatePullRequestReviewProtectionRequest';
export * from './reposUpdateReleaseAssetRequest';
export * from './reposUpdateReleaseRequest';
export * from './reposUpdateRequest';
export * from './reposUpdateRequestSecurityAndAnalysis';
export * from './reposUpdateRequestSecurityAndAnalysisAdvancedSecurity';
export * from './reposUpdateRequestSecurityAndAnalysisSecretScanning';
export * from './reposUpdateRequestSecurityAndAnalysisSecretScanningPushProtection';
export * from './reposUpdateStatusCheckProtectionRequest';
export * from './reposUpdateWebhookConfigForRepoRequest';
export * from './reposUpdateWebhookRequest';
export * from './reposUpdateWebhookRequestConfig';
export * from './repository';
export * from './repository1';
export * from './repositoryActionsCaches';
export * from './repositoryActionsCachesActionsCachesInner';
export * from './repositoryCollaboratorPermission';
export * from './repositoryInvitation';
export * from './repositoryInvitation1';
export * from './repositoryPermissions';
export * from './repositoryTemplateRepository';
export * from './repositoryTemplateRepositoryOwner';
export * from './repositoryTemplateRepositoryPermissions';
export * from './reviewDismissedIssueEvent';
export * from './reviewDismissedIssueEventDismissedReview';
export * from './reviewRequestRemovedIssueEvent';
export * from './reviewRequestedIssueEvent';
export * from './runnerApplication';
export * from './sCIMUserList';
export * from './sCIMUsers';
export * from './sCIMUsersEmailsInner';
export * from './sCIMUsersGroupsInner';
export * from './sCIMUsersMeta';
export * from './sCIMUsersName';
export * from './sCIMUsersOperationsInner';
export * from './sCIMUsersOperationsInnerValue';
export * from './scimError';
export * from './scimProvisionAndInviteUserRequest';
export * from './scimProvisionAndInviteUserRequestEmailsInner';
export * from './scimProvisionAndInviteUserRequestName';
export * from './scimSetInformationForProvisionedUserRequest';
export * from './scimSetInformationForProvisionedUserRequestEmailsInner';
export * from './scimUpdateAttributeForUserRequest';
export * from './scimUpdateAttributeForUserRequestOperationsInner';
export * from './scimUpdateAttributeForUserRequestOperationsInnerValue';
export * from './scimUpdateAttributeForUserRequestOperationsInnerValueOneOf';
export * from './scimUpdateAttributeForUserRequestOperationsInnerValueOneOf1Inner';
export * from './scopedInstallation';
export * from './searchCode200Response';
export * from './searchCommits200Response';
export * from './searchIssuesAndPullRequests200Response';
export * from './searchLabels200Response';
export * from './searchRepos200Response';
export * from './searchResultTextMatchesInner';
export * from './searchResultTextMatchesInnerMatchesInner';
export * from './searchTopics200Response';
export * from './searchUsers200Response';
export * from './secretScanningListAlertsForEnterprise200ResponseInner';
export * from './secretScanningListAlertsForRepo200ResponseInner';
export * from './secretScanningListLocationsForAlert200ResponseInner';
export * from './secretScanningListLocationsForAlert200ResponseInnerDetails';
export * from './secretScanningListLocationsForAlert200ResponseInnerDetailsOneOf';
export * from './secretScanningUpdateAlertRequest';
export * from './selfHostedRunnerLabel';
export * from './selfHostedRunners';
export * from './serverStatisticsProxyEndpointInner';
export * from './serverStatisticsProxyEndpointInnerDormantUsers';
export * from './serverStatisticsProxyEndpointInnerGheStats';
export * from './serverStatisticsProxyEndpointInnerGheStatsComments';
export * from './serverStatisticsProxyEndpointInnerGheStatsGists';
export * from './serverStatisticsProxyEndpointInnerGheStatsHooks';
export * from './serverStatisticsProxyEndpointInnerGheStatsIssues';
export * from './serverStatisticsProxyEndpointInnerGheStatsMilestones';
export * from './serverStatisticsProxyEndpointInnerGheStatsOrgs';
export * from './serverStatisticsProxyEndpointInnerGheStatsPages';
export * from './serverStatisticsProxyEndpointInnerGheStatsPulls';
export * from './serverStatisticsProxyEndpointInnerGheStatsRepos';
export * from './serverStatisticsProxyEndpointInnerGheStatsUsers';
export * from './serverStatisticsProxyEndpointInnerGithubConnect';
export * from './shortBlob';
export * from './shortBranch';
export * from './shortBranchCommit';
export * from './simpleCommit';
export * from './simpleCommit1';
export * from './simpleCommitAuthor';
export * from './simpleCommitStatus';
export * from './simpleRepository';
export * from './simpleUser';
export * from './simpleUser1';
export * from './simpleWebhookDelivery';
export * from './snapshot';
export * from './snapshotDetector';
export * from './snapshotJob';
export * from './snapshotManifestsValue';
export * from './snapshotManifestsValueFile';
export * from './snapshotManifestsValueResolvedValue';
export * from './stargazer';
export * from './starredRepository';
export * from './stateChangeIssueEvent';
export * from './status';
export * from './statusCheckPolicy';
export * from './statusCheckPolicyChecksInner';
export * from './symlinkContent';
export * from './symlinkContent1';
export * from './tag';
export * from './tagProtection';
export * from './team';
export * from './teamDiscussion';
export * from './teamDiscussionComment';
export * from './teamMembership';
export * from './teamPermissions';
export * from './teamProject';
export * from './teamProjectPermissions';
export * from './teamRepository';
export * from './teamSimple';
export * from './teamSimple1';
export * from './teamsAddOrUpdateMembershipForUserInOrgRequest';
export * from './teamsAddOrUpdateProjectPermissionsInOrgRequest';
export * from './teamsAddOrUpdateProjectPermissionsLegacyRequest';
export * from './teamsAddOrUpdateRepoPermissionsInOrgRequest';
export * from './teamsAddOrUpdateRepoPermissionsLegacyRequest';
export * from './teamsCreateDiscussionCommentInOrgRequest';
export * from './teamsCreateDiscussionInOrgRequest';
export * from './teamsCreateOrUpdateIdpGroupConnectionsInOrgRequest';
export * from './teamsCreateOrUpdateIdpGroupConnectionsInOrgRequestGroupsInner';
export * from './teamsCreateOrUpdateIdpGroupConnectionsLegacyRequest';
export * from './teamsCreateOrUpdateIdpGroupConnectionsLegacyRequestGroupsInner';
export * from './teamsCreateRequest';
export * from './teamsLinkExternalIdpGroupToTeamForOrgRequest';
export * from './teamsUpdateDiscussionInOrgRequest';
export * from './teamsUpdateInOrgRequest';
export * from './teamsUpdateLegacyRequest';
export * from './theJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization';
export * from './thread';
export * from './threadSubject';
export * from './threadSubscription';
export * from './timelineAssignedIssueEvent';
export * from './timelineCommentEvent';
export * from './timelineCommitCommentedEvent';
export * from './timelineCommittedEvent';
export * from './timelineCrossReferencedEvent';
export * from './timelineCrossReferencedEventSource';
export * from './timelineEvent';
export * from './timelineLineCommentedEvent';
export * from './timelineReviewedEvent';
export * from './timelineReviewedEventLinks';
export * from './timelineReviewedEventLinksHtml';
export * from './timelineUnassignedIssueEvent';
export * from './topic';
export * from './topicSearchResultItem';
export * from './topicSearchResultItemRelatedInner';
export * from './topicSearchResultItemRelatedInnerTopicRelation';
export * from './traffic';
export * from './unassignedIssueEvent';
export * from './unlabeledIssueEvent';
export * from './userMarketplacePurchase';
export * from './userSearchResultItem';
export * from './usersAddEmailForAuthenticatedUserRequest';
export * from './usersAddEmailForAuthenticatedUserRequestOneOf';
export * from './usersCreateGpgKeyForAuthenticatedUserRequest';
export * from './usersCreatePublicSshKeyForAuthenticatedUserRequest';
export * from './usersDeleteEmailForAuthenticatedUserRequest';
export * from './usersDeleteEmailForAuthenticatedUserRequestOneOf';
export * from './usersGetAuthenticated200Response';
export * from './usersSetPrimaryEmailVisibilityForAuthenticatedUserRequest';
export * from './usersUpdateAuthenticatedRequest';
export * from './validationError';
export * from './validationErrorErrorsInner';
export * from './validationErrorErrorsInnerValue';
export * from './validationErrorSimple';
export * from './verification';
export * from './viewTraffic';
export * from './webhook';
export * from './webhookConfig';
export * from './webhookConfiguration';
export * from './webhookConfigurationInsecureSsl';
export * from './webhookDelivery';
export * from './webhookDeliveryRequest';
export * from './webhookDeliveryResponse';
export * from './workflow';
export * from './workflowRun';
export * from './workflowRunUsage';
export * from './workflowRunUsageBillable';
export * from './workflowRunUsageBillableUBUNTU';
export * from './workflowRunUsageBillableUBUNTUJobRunsInner';
export * from './workflowUsage';
export * from './workflowUsageBillable';
export * from './workflowUsageBillableUBUNTU';

import * as fs from 'fs';

export interface RequestDetailedFile {
    value: Buffer;
    options?: {
        filename?: string;
        contentType?: string;
    }
}

export type RequestFile = string | Buffer | fs.ReadStream | RequestDetailedFile;


import { ActionsCacheUsageByRepository } from './actionsCacheUsageByRepository';
import { ActionsCreateOrUpdateEnvironmentSecretRequest } from './actionsCreateOrUpdateEnvironmentSecretRequest';
import { ActionsCreateOrUpdateOrgSecretRequest } from './actionsCreateOrUpdateOrgSecretRequest';
import { ActionsCreateOrUpdateRepoSecretRequest } from './actionsCreateOrUpdateRepoSecretRequest';
import { ActionsCreateSelfHostedRunnerGroupForOrgRequest } from './actionsCreateSelfHostedRunnerGroupForOrgRequest';
import { ActionsCreateWorkflowDispatchRequest } from './actionsCreateWorkflowDispatchRequest';
import { ActionsGetActionsCacheUsageByRepoForOrg200Response } from './actionsGetActionsCacheUsageByRepoForOrg200Response';
import { ActionsGetActionsCacheUsageForEnterprise200Response } from './actionsGetActionsCacheUsageForEnterprise200Response';
import { ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response } from './actionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response';
import { ActionsGetGithubActionsPermissionsOrganization200Response } from './actionsGetGithubActionsPermissionsOrganization200Response';
import { ActionsGetGithubActionsPermissionsRepository200Response } from './actionsGetGithubActionsPermissionsRepository200Response';
import { ActionsGetWorkflowAccessToRepository200Response } from './actionsGetWorkflowAccessToRepository200Response';
import { ActionsGetWorkflowWorkflowIdParameter } from './actionsGetWorkflowWorkflowIdParameter';
import { ActionsListArtifactsForRepo200Response } from './actionsListArtifactsForRepo200Response';
import { ActionsListJobsForWorkflowRunAttempt200Response } from './actionsListJobsForWorkflowRunAttempt200Response';
import { ActionsListOrgSecrets200Response } from './actionsListOrgSecrets200Response';
import { ActionsListRepoAccessToSelfHostedRunnerGroupInOrg200Response } from './actionsListRepoAccessToSelfHostedRunnerGroupInOrg200Response';
import { ActionsListRepoSecrets200Response } from './actionsListRepoSecrets200Response';
import { ActionsListRepoWorkflows200Response } from './actionsListRepoWorkflows200Response';
import { ActionsListSelectedReposForOrgSecret200Response } from './actionsListSelectedReposForOrgSecret200Response';
import { ActionsListSelectedRepositoriesEnabledGithubActionsOrganization200Response } from './actionsListSelectedRepositoriesEnabledGithubActionsOrganization200Response';
import { ActionsListSelfHostedRunnerGroupsForOrg200Response } from './actionsListSelfHostedRunnerGroupsForOrg200Response';
import { ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner } from './actionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner';
import { ActionsListSelfHostedRunnersForOrg200Response } from './actionsListSelfHostedRunnersForOrg200Response';
import { ActionsListWorkflowRunsForRepo200Response } from './actionsListWorkflowRunsForRepo200Response';
import { ActionsOIDCSubjectCustomization } from './actionsOIDCSubjectCustomization';
import { ActionsPublicKey } from './actionsPublicKey';
import { ActionsReRunJobForWorkflowRunRequest } from './actionsReRunJobForWorkflowRunRequest';
import { ActionsReviewPendingDeploymentsForRunRequest } from './actionsReviewPendingDeploymentsForRunRequest';
import { ActionsSecret } from './actionsSecret';
import { ActionsSecretForAnOrganization } from './actionsSecretForAnOrganization';
import { ActionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest } from './actionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest';
import { ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest } from './actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest';
import { ActionsSetGithubActionsPermissionsOrganizationRequest } from './actionsSetGithubActionsPermissionsOrganizationRequest';
import { ActionsSetGithubActionsPermissionsRepositoryRequest } from './actionsSetGithubActionsPermissionsRepositoryRequest';
import { ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest } from './actionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest';
import { ActionsSetSelectedReposForOrgSecretRequest } from './actionsSetSelectedReposForOrgSecretRequest';
import { ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest } from './actionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest';
import { ActionsUpdateSelfHostedRunnerGroupForOrgRequest } from './actionsUpdateSelfHostedRunnerGroupForOrgRequest';
import { ActivityListReposStarredByUser200Response } from './activityListReposStarredByUser200Response';
import { ActivityListStargazersForRepo200Response } from './activityListStargazersForRepo200Response';
import { ActivityMarkNotificationsAsRead202Response } from './activityMarkNotificationsAsRead202Response';
import { ActivityMarkNotificationsAsReadRequest } from './activityMarkNotificationsAsReadRequest';
import { ActivityMarkRepoNotificationsAsRead202Response } from './activityMarkRepoNotificationsAsRead202Response';
import { ActivityMarkRepoNotificationsAsReadRequest } from './activityMarkRepoNotificationsAsReadRequest';
import { ActivitySetRepoSubscriptionRequest } from './activitySetRepoSubscriptionRequest';
import { ActivitySetThreadSubscriptionRequest } from './activitySetThreadSubscriptionRequest';
import { Actor } from './actor';
import { AddedToProjectIssueEvent } from './addedToProjectIssueEvent';
import { AddedToProjectIssueEventProjectCard } from './addedToProjectIssueEventProjectCard';
import { AnalysisDeletion } from './analysisDeletion';
import { ApiOverview } from './apiOverview';
import { ApiOverviewSshKeyFingerprints } from './apiOverviewSshKeyFingerprints';
import { AppPermissions } from './appPermissions';
import { AppsCheckTokenRequest } from './appsCheckTokenRequest';
import { AppsCreateFromManifest201Response } from './appsCreateFromManifest201Response';
import { AppsCreateFromManifest201ResponseAllOf } from './appsCreateFromManifest201ResponseAllOf';
import { AppsCreateInstallationAccessTokenRequest } from './appsCreateInstallationAccessTokenRequest';
import { AppsDeleteAuthorizationRequest } from './appsDeleteAuthorizationRequest';
import { AppsListInstallationReposForAuthenticatedUser200Response } from './appsListInstallationReposForAuthenticatedUser200Response';
import { AppsListReposAccessibleToInstallation200Response } from './appsListReposAccessibleToInstallation200Response';
import { AppsScopeTokenRequest } from './appsScopeTokenRequest';
import { AppsUpdateWebhookConfigForAppRequest } from './appsUpdateWebhookConfigForAppRequest';
import { Artifact } from './artifact';
import { ArtifactWorkflowRun } from './artifactWorkflowRun';
import { AssignedIssueEvent } from './assignedIssueEvent';
import { AuthenticationToken } from './authenticationToken';
import { Authorization } from './authorization';
import { AuthorizationApp } from './authorizationApp';
import { AutoMerge } from './autoMerge';
import { AutolinkReference } from './autolinkReference';
import { BaseGist } from './baseGist';
import { BaseGistFilesValue } from './baseGistFilesValue';
import { BasicError } from './basicError';
import { BillingGetGithubActionsBillingGhe200Response } from './billingGetGithubActionsBillingGhe200Response';
import { BillingGetGithubActionsBillingGhe200ResponseMinutesUsedBreakdown } from './billingGetGithubActionsBillingGhe200ResponseMinutesUsedBreakdown';
import { BillingGetGithubAdvancedSecurityBillingGhe200Response } from './billingGetGithubAdvancedSecurityBillingGhe200Response';
import { BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInner } from './billingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInner';
import { BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInnerAdvancedSecurityCommittersBreakdownInner } from './billingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInnerAdvancedSecurityCommittersBreakdownInner';
import { BillingGetGithubPackagesBillingGhe200Response } from './billingGetGithubPackagesBillingGhe200Response';
import { BillingGetSharedStorageBillingGhe200Response } from './billingGetSharedStorageBillingGhe200Response';
import { Blob } from './blob';
import { BranchProtection } from './branchProtection';
import { BranchProtectionRequiredLinearHistory } from './branchProtectionRequiredLinearHistory';
import { BranchProtectionRequiredSignatures } from './branchProtectionRequiredSignatures';
import { BranchRestrictionPolicy } from './branchRestrictionPolicy';
import { BranchRestrictionPolicyAppsInner } from './branchRestrictionPolicyAppsInner';
import { BranchRestrictionPolicyAppsInnerOwner } from './branchRestrictionPolicyAppsInnerOwner';
import { BranchRestrictionPolicyAppsInnerPermissions } from './branchRestrictionPolicyAppsInnerPermissions';
import { BranchRestrictionPolicyTeamsInner } from './branchRestrictionPolicyTeamsInner';
import { BranchShort } from './branchShort';
import { BranchShortCommit } from './branchShortCommit';
import { BranchWithProtection } from './branchWithProtection';
import { BranchWithProtectionLinks } from './branchWithProtectionLinks';
import { CODEOWNERSErrors } from './cODEOWNERSErrors';
import { CODEOWNERSErrorsErrorsInner } from './cODEOWNERSErrorsErrorsInner';
import { CheckAnnotation } from './checkAnnotation';
import { CheckRun } from './checkRun';
import { CheckRunCheckSuite } from './checkRunCheckSuite';
import { CheckRunOutput } from './checkRunOutput';
import { CheckSuite } from './checkSuite';
import { CheckSuitePreference } from './checkSuitePreference';
import { CheckSuitePreferencePreferences } from './checkSuitePreferencePreferences';
import { CheckSuitePreferencePreferencesAutoTriggerChecksInner } from './checkSuitePreferencePreferencesAutoTriggerChecksInner';
import { ChecksCreateRequest } from './checksCreateRequest';
import { ChecksCreateRequestActionsInner } from './checksCreateRequestActionsInner';
import { ChecksCreateRequestOneOf } from './checksCreateRequestOneOf';
import { ChecksCreateRequestOneOf1 } from './checksCreateRequestOneOf1';
import { ChecksCreateRequestOutput } from './checksCreateRequestOutput';
import { ChecksCreateRequestOutputAnnotationsInner } from './checksCreateRequestOutputAnnotationsInner';
import { ChecksCreateRequestOutputImagesInner } from './checksCreateRequestOutputImagesInner';
import { ChecksCreateSuiteRequest } from './checksCreateSuiteRequest';
import { ChecksListForSuite200Response } from './checksListForSuite200Response';
import { ChecksListSuitesForRef200Response } from './checksListSuitesForRef200Response';
import { ChecksSetSuitesPreferencesRequest } from './checksSetSuitesPreferencesRequest';
import { ChecksSetSuitesPreferencesRequestAutoTriggerChecksInner } from './checksSetSuitesPreferencesRequestAutoTriggerChecksInner';
import { ChecksUpdateRequest } from './checksUpdateRequest';
import { ChecksUpdateRequestAnyOf } from './checksUpdateRequestAnyOf';
import { ChecksUpdateRequestOutput } from './checksUpdateRequestOutput';
import { CloneTraffic } from './cloneTraffic';
import { CodeOfConduct } from './codeOfConduct';
import { CodeOfConductSimple } from './codeOfConductSimple';
import { CodeOfConductSimple1 } from './codeOfConductSimple1';
import { CodeScanningGetAlert200Response } from './codeScanningGetAlert200Response';
import { CodeScanningGetSarif200Response } from './codeScanningGetSarif200Response';
import { CodeScanningListAlertsForEnterprise200ResponseInner } from './codeScanningListAlertsForEnterprise200ResponseInner';
import { CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance } from './codeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance';
import { CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstanceLocation } from './codeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstanceLocation';
import { CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstanceMessage } from './codeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstanceMessage';
import { CodeScanningListAlertsForEnterprise200ResponseInnerRule } from './codeScanningListAlertsForEnterprise200ResponseInnerRule';
import { CodeScanningListAlertsForEnterprise200ResponseInnerTool } from './codeScanningListAlertsForEnterprise200ResponseInnerTool';
import { CodeScanningListAlertsForEnterprise503Response } from './codeScanningListAlertsForEnterprise503Response';
import { CodeScanningListAlertsForRepo200ResponseInner } from './codeScanningListAlertsForRepo200ResponseInner';
import { CodeScanningListAlertsForRepo200ResponseInnerRule } from './codeScanningListAlertsForRepo200ResponseInnerRule';
import { CodeScanningListRecentAnalyses200ResponseInner } from './codeScanningListRecentAnalyses200ResponseInner';
import { CodeScanningUpdateAlertRequest } from './codeScanningUpdateAlertRequest';
import { CodeScanningUploadSarif202Response } from './codeScanningUploadSarif202Response';
import { CodeScanningUploadSarifRequest } from './codeScanningUploadSarifRequest';
import { CodeSearchResultItem } from './codeSearchResultItem';
import { Codespace } from './codespace';
import { CodespaceGitStatus } from './codespaceGitStatus';
import { CodespaceMachine } from './codespaceMachine';
import { CodespaceMachine1 } from './codespaceMachine1';
import { CodespaceRuntimeConstraints } from './codespaceRuntimeConstraints';
import { CodespacesCreateForAuthenticatedUserRequest } from './codespacesCreateForAuthenticatedUserRequest';
import { CodespacesCreateForAuthenticatedUserRequestOneOf } from './codespacesCreateForAuthenticatedUserRequestOneOf';
import { CodespacesCreateForAuthenticatedUserRequestOneOf1 } from './codespacesCreateForAuthenticatedUserRequestOneOf1';
import { CodespacesCreateForAuthenticatedUserRequestOneOf1PullRequest } from './codespacesCreateForAuthenticatedUserRequestOneOf1PullRequest';
import { CodespacesCreateOrUpdateRepoSecretRequest } from './codespacesCreateOrUpdateRepoSecretRequest';
import { CodespacesCreateOrUpdateSecretForAuthenticatedUserRequest } from './codespacesCreateOrUpdateSecretForAuthenticatedUserRequest';
import { CodespacesCreateWithPrForAuthenticatedUserRequest } from './codespacesCreateWithPrForAuthenticatedUserRequest';
import { CodespacesCreateWithRepoForAuthenticatedUserRequest } from './codespacesCreateWithRepoForAuthenticatedUserRequest';
import { CodespacesListDevcontainersInRepositoryForAuthenticatedUser200Response } from './codespacesListDevcontainersInRepositoryForAuthenticatedUser200Response';
import { CodespacesListDevcontainersInRepositoryForAuthenticatedUser200ResponseDevcontainersInner } from './codespacesListDevcontainersInRepositoryForAuthenticatedUser200ResponseDevcontainersInner';
import { CodespacesListInOrganization200Response } from './codespacesListInOrganization200Response';
import { CodespacesListRepoSecrets200Response } from './codespacesListRepoSecrets200Response';
import { CodespacesListSecretsForAuthenticatedUser200Response } from './codespacesListSecretsForAuthenticatedUser200Response';
import { CodespacesPreFlightWithRepoForAuthenticatedUser200Response } from './codespacesPreFlightWithRepoForAuthenticatedUser200Response';
import { CodespacesPreFlightWithRepoForAuthenticatedUser200ResponseDefaults } from './codespacesPreFlightWithRepoForAuthenticatedUser200ResponseDefaults';
import { CodespacesPublicKey } from './codespacesPublicKey';
import { CodespacesRepoMachinesForAuthenticatedUser200Response } from './codespacesRepoMachinesForAuthenticatedUser200Response';
import { CodespacesSecret } from './codespacesSecret';
import { CodespacesSecret1 } from './codespacesSecret1';
import { CodespacesSetRepositoriesForSecretForAuthenticatedUserRequest } from './codespacesSetRepositoriesForSecretForAuthenticatedUserRequest';
import { CodespacesUpdateForAuthenticatedUserRequest } from './codespacesUpdateForAuthenticatedUserRequest';
import { CodespacesUserPublicKey } from './codespacesUserPublicKey';
import { Collaborator } from './collaborator';
import { Collaborator1 } from './collaborator1';
import { CollaboratorPermissions } from './collaboratorPermissions';
import { CombinedCommitStatus } from './combinedCommitStatus';
import { Commit } from './commit';
import { CommitActivity } from './commitActivity';
import { CommitComment } from './commitComment';
import { CommitCommit } from './commitCommit';
import { CommitCommitTree } from './commitCommitTree';
import { CommitComparison } from './commitComparison';
import { CommitParentsInner } from './commitParentsInner';
import { CommitSearchResultItem } from './commitSearchResultItem';
import { CommitSearchResultItemCommit } from './commitSearchResultItemCommit';
import { CommitSearchResultItemCommitAuthor } from './commitSearchResultItemCommitAuthor';
import { CommitStats } from './commitStats';
import { CommunityHealthFile } from './communityHealthFile';
import { CommunityProfile } from './communityProfile';
import { CommunityProfileFiles } from './communityProfileFiles';
import { ContainerMetadata } from './containerMetadata';
import { ContentFile } from './contentFile';
import { ContentTraffic } from './contentTraffic';
import { ContentTree } from './contentTree';
import { ContentTreeEntriesInner } from './contentTreeEntriesInner';
import { ContentTreeEntriesInnerLinks } from './contentTreeEntriesInnerLinks';
import { Contributor } from './contributor';
import { ContributorActivity } from './contributorActivity';
import { ContributorActivityWeeksInner } from './contributorActivityWeeksInner';
import { ConvertedNoteToIssueIssueEvent } from './convertedNoteToIssueIssueEvent';
import { CredentialAuthorization } from './credentialAuthorization';
import { DemilestonedIssueEvent } from './demilestonedIssueEvent';
import { DependabotCreateOrUpdateOrgSecretRequest } from './dependabotCreateOrUpdateOrgSecretRequest';
import { DependabotCreateOrUpdateRepoSecretRequest } from './dependabotCreateOrUpdateRepoSecretRequest';
import { DependabotListOrgSecrets200Response } from './dependabotListOrgSecrets200Response';
import { DependabotListRepoSecrets200Response } from './dependabotListRepoSecrets200Response';
import { DependabotPublicKey } from './dependabotPublicKey';
import { DependabotSecret } from './dependabotSecret';
import { DependabotSecretForAnOrganization } from './dependabotSecretForAnOrganization';
import { DependabotSetSelectedReposForOrgSecretRequest } from './dependabotSetSelectedReposForOrgSecretRequest';
import { DependencyGraphCreateRepositorySnapshot201Response } from './dependencyGraphCreateRepositorySnapshot201Response';
import { DependencyGraphDiffInner } from './dependencyGraphDiffInner';
import { DependencyGraphDiffInnerVulnerabilitiesInner } from './dependencyGraphDiffInnerVulnerabilitiesInner';
import { DeployKey } from './deployKey';
import { Deployment } from './deployment';
import { Deployment1 } from './deployment1';
import { DeploymentPayload } from './deploymentPayload';
import { DeploymentStatus } from './deploymentStatus';
import { DiffEntry } from './diffEntry';
import { DockerMetadata } from './dockerMetadata';
import { Email } from './email';
import { Enterprise } from './enterprise';
import { EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest } from './enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest';
import { EnterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest } from './enterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest';
import { EnterpriseAdminGetAllowedActionsEnterprise200Response } from './enterpriseAdminGetAllowedActionsEnterprise200Response';
import { EnterpriseAdminGetAuditLog200ResponseInner } from './enterpriseAdminGetAuditLog200ResponseInner';
import { EnterpriseAdminGetAuditLog200ResponseInnerActorLocation } from './enterpriseAdminGetAuditLog200ResponseInnerActorLocation';
import { EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response } from './enterpriseAdminGetGithubActionsPermissionsEnterprise200Response';
import { EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response } from './enterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response';
import { EnterpriseAdminListProvisionedGroupsEnterprise200Response } from './enterpriseAdminListProvisionedGroupsEnterprise200Response';
import { EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner } from './enterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner';
import { EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMembersInner } from './enterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMembersInner';
import { EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMeta } from './enterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMeta';
import { EnterpriseAdminListProvisionedIdentitiesEnterprise200Response } from './enterpriseAdminListProvisionedIdentitiesEnterprise200Response';
import { EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInner } from './enterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInner';
import { EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerEmailsInner } from './enterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerEmailsInner';
import { EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerGroupsInner } from './enterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerGroupsInner';
import { EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerName } from './enterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerName';
import { EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response } from './enterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response';
import { EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200Response } from './enterpriseAdminListSelfHostedRunnerGroupsForEnterprise200Response';
import { EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner } from './enterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner';
import { EnterpriseAdminListSelfHostedRunnersForEnterprise200Response } from './enterpriseAdminListSelfHostedRunnersForEnterprise200Response';
import { EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response } from './enterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response';
import { EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest } from './enterpriseAdminProvisionAndInviteEnterpriseGroupRequest';
import { EnterpriseAdminProvisionAndInviteEnterpriseGroupRequestMembersInner } from './enterpriseAdminProvisionAndInviteEnterpriseGroupRequestMembersInner';
import { EnterpriseAdminProvisionAndInviteEnterpriseUser201Response } from './enterpriseAdminProvisionAndInviteEnterpriseUser201Response';
import { EnterpriseAdminProvisionAndInviteEnterpriseUser201ResponseEmailsInner } from './enterpriseAdminProvisionAndInviteEnterpriseUser201ResponseEmailsInner';
import { EnterpriseAdminProvisionAndInviteEnterpriseUserRequest } from './enterpriseAdminProvisionAndInviteEnterpriseUserRequest';
import { EnterpriseAdminProvisionAndInviteEnterpriseUserRequestEmailsInner } from './enterpriseAdminProvisionAndInviteEnterpriseUserRequestEmailsInner';
import { EnterpriseAdminProvisionAndInviteEnterpriseUserRequestName } from './enterpriseAdminProvisionAndInviteEnterpriseUserRequestName';
import { EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest } from './enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest';
import { EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest } from './enterpriseAdminSetGithubActionsPermissionsEnterpriseRequest';
import { EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest } from './enterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest';
import { EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest } from './enterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest';
import { EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest } from './enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest';
import { EnterpriseAdminUpdateAttributeForEnterpriseGroupRequest } from './enterpriseAdminUpdateAttributeForEnterpriseGroupRequest';
import { EnterpriseAdminUpdateAttributeForEnterpriseGroupRequestOperationsInner } from './enterpriseAdminUpdateAttributeForEnterpriseGroupRequestOperationsInner';
import { EnterpriseAdminUpdateAttributeForEnterpriseUserRequest } from './enterpriseAdminUpdateAttributeForEnterpriseUserRequest';
import { EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest } from './enterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest';
import { Environment } from './environment';
import { EnvironmentApproval } from './environmentApproval';
import { EnvironmentApprovalEnvironmentsInner } from './environmentApprovalEnvironmentsInner';
import { EnvironmentDeploymentBranchPolicy } from './environmentDeploymentBranchPolicy';
import { EnvironmentProtectionRulesInner } from './environmentProtectionRulesInner';
import { EnvironmentProtectionRulesInnerAnyOf } from './environmentProtectionRulesInnerAnyOf';
import { EnvironmentProtectionRulesInnerAnyOf1 } from './environmentProtectionRulesInnerAnyOf1';
import { EnvironmentProtectionRulesInnerAnyOf2 } from './environmentProtectionRulesInnerAnyOf2';
import { Event } from './event';
import { EventPayload } from './eventPayload';
import { EventPayloadPagesInner } from './eventPayloadPagesInner';
import { EventRepo } from './eventRepo';
import { ExternalGroup } from './externalGroup';
import { ExternalGroupMembersInner } from './externalGroupMembersInner';
import { ExternalGroupTeamsInner } from './externalGroupTeamsInner';
import { ExternalGroups } from './externalGroups';
import { ExternalGroupsGroupsInner } from './externalGroupsGroupsInner';
import { Feed } from './feed';
import { FeedLinks } from './feedLinks';
import { FetchesInformationAboutAnExportOfACodespace } from './fetchesInformationAboutAnExportOfACodespace';
import { FileCommit } from './fileCommit';
import { FileCommitCommit } from './fileCommitCommit';
import { FileCommitCommitAuthor } from './fileCommitCommitAuthor';
import { FileCommitCommitParentsInner } from './fileCommitCommitParentsInner';
import { FileCommitCommitTree } from './fileCommitCommitTree';
import { FileCommitCommitVerification } from './fileCommitCommitVerification';
import { FileCommitContent } from './fileCommitContent';
import { FileCommitContentLinks } from './fileCommitContentLinks';
import { FullRepository } from './fullRepository';
import { FullRepositoryPermissions } from './fullRepositoryPermissions';
import { FullRepositorySecurityAndAnalysis } from './fullRepositorySecurityAndAnalysis';
import { FullRepositorySecurityAndAnalysisAdvancedSecurity } from './fullRepositorySecurityAndAnalysisAdvancedSecurity';
import { FullTeam } from './fullTeam';
import { GPGKey } from './gPGKey';
import { GPGKeyEmailsInner } from './gPGKeyEmailsInner';
import { GPGKeySubkeysInner } from './gPGKeySubkeysInner';
import { GeneratedReleaseNotesContent } from './generatedReleaseNotesContent';
import { Gist } from './gist';
import { GistComment } from './gistComment';
import { GistCommit } from './gistCommit';
import { GistHistory } from './gistHistory';
import { GistHistoryChangeStatus } from './gistHistoryChangeStatus';
import { GistSimple } from './gistSimple';
import { GistSimpleFilesValue } from './gistSimpleFilesValue';
import { GistSimpleForksInner } from './gistSimpleForksInner';
import { GistsCreateCommentRequest } from './gistsCreateCommentRequest';
import { GistsCreateRequest } from './gistsCreateRequest';
import { GistsCreateRequestFilesValue } from './gistsCreateRequestFilesValue';
import { GistsCreateRequestPublic } from './gistsCreateRequestPublic';
import { GistsCreateRequestPublicOneOf } from './gistsCreateRequestPublicOneOf';
import { GistsGet403Response } from './gistsGet403Response';
import { GistsGet403ResponseBlock } from './gistsGet403ResponseBlock';
import { GistsUpdateRequest } from './gistsUpdateRequest';
import { GistsUpdateRequestFilesValue } from './gistsUpdateRequestFilesValue';
import { GitCommit } from './gitCommit';
import { GitCommitAuthor } from './gitCommitAuthor';
import { GitCommitParentsInner } from './gitCommitParentsInner';
import { GitCommitTree } from './gitCommitTree';
import { GitCommitVerification } from './gitCommitVerification';
import { GitCreateBlobRequest } from './gitCreateBlobRequest';
import { GitCreateCommitRequest } from './gitCreateCommitRequest';
import { GitCreateCommitRequestAuthor } from './gitCreateCommitRequestAuthor';
import { GitCreateCommitRequestCommitter } from './gitCreateCommitRequestCommitter';
import { GitCreateRefRequest } from './gitCreateRefRequest';
import { GitCreateTagRequest } from './gitCreateTagRequest';
import { GitCreateTagRequestTagger } from './gitCreateTagRequestTagger';
import { GitCreateTreeRequest } from './gitCreateTreeRequest';
import { GitCreateTreeRequestTreeInner } from './gitCreateTreeRequestTreeInner';
import { GitHubApp } from './gitHubApp';
import { GitHubApp1 } from './gitHubApp1';
import { GitHubAppPermissions } from './gitHubAppPermissions';
import { GitHubPages } from './gitHubPages';
import { GitHubPages1 } from './gitHubPages1';
import { GitReference } from './gitReference';
import { GitReferenceObject } from './gitReferenceObject';
import { GitTag } from './gitTag';
import { GitTagObject } from './gitTagObject';
import { GitTagTagger } from './gitTagTagger';
import { GitTree } from './gitTree';
import { GitTreeTreeInner } from './gitTreeTreeInner';
import { GitUpdateRefRequest } from './gitUpdateRefRequest';
import { GitUser } from './gitUser';
import { GitignoreTemplate } from './gitignoreTemplate';
import { GroupMapping } from './groupMapping';
import { GroupMappingGroupsInner } from './groupMappingGroupsInner';
import { HookResponse } from './hookResponse';
import { Hovercard } from './hovercard';
import { HovercardContextsInner } from './hovercardContextsInner';
import { Import } from './import';
import { ImportProjectChoicesInner } from './importProjectChoicesInner';
import { Installation } from './installation';
import { InstallationAccount } from './installationAccount';
import { InstallationToken } from './installationToken';
import { InteractionLimits } from './interactionLimits';
import { InteractionRestrictions } from './interactionRestrictions';
import { InteractionsGetRestrictionsForOrg200Response } from './interactionsGetRestrictionsForOrg200Response';
import { Issue } from './issue';
import { Issue1 } from './issue1';
import { IssueComment } from './issueComment';
import { IssueEvent } from './issueEvent';
import { IssueEventDismissedReview } from './issueEventDismissedReview';
import { IssueEventForIssue } from './issueEventForIssue';
import { IssueEventLabel } from './issueEventLabel';
import { IssueEventMilestone } from './issueEventMilestone';
import { IssueEventProjectCard } from './issueEventProjectCard';
import { IssueEventRename } from './issueEventRename';
import { IssueLabelsInner } from './issueLabelsInner';
import { IssueLabelsInnerOneOf } from './issueLabelsInnerOneOf';
import { IssuePullRequest } from './issuePullRequest';
import { IssueSearchResultItem } from './issueSearchResultItem';
import { IssueSearchResultItemLabelsInner } from './issueSearchResultItemLabelsInner';
import { IssuesAddAssigneesRequest } from './issuesAddAssigneesRequest';
import { IssuesAddLabelsRequest } from './issuesAddLabelsRequest';
import { IssuesAddLabelsRequestOneOf } from './issuesAddLabelsRequestOneOf';
import { IssuesCreateLabelRequest } from './issuesCreateLabelRequest';
import { IssuesCreateMilestoneRequest } from './issuesCreateMilestoneRequest';
import { IssuesCreateRequest } from './issuesCreateRequest';
import { IssuesCreateRequestLabelsInner } from './issuesCreateRequestLabelsInner';
import { IssuesCreateRequestLabelsInnerOneOf } from './issuesCreateRequestLabelsInnerOneOf';
import { IssuesCreateRequestMilestone } from './issuesCreateRequestMilestone';
import { IssuesCreateRequestTitle } from './issuesCreateRequestTitle';
import { IssuesLockRequest } from './issuesLockRequest';
import { IssuesRemoveAssigneesRequest } from './issuesRemoveAssigneesRequest';
import { IssuesSetLabelsRequest } from './issuesSetLabelsRequest';
import { IssuesSetLabelsRequestOneOf } from './issuesSetLabelsRequestOneOf';
import { IssuesSetLabelsRequestOneOf1 } from './issuesSetLabelsRequestOneOf1';
import { IssuesSetLabelsRequestOneOf1LabelsInner } from './issuesSetLabelsRequestOneOf1LabelsInner';
import { IssuesUpdateCommentRequest } from './issuesUpdateCommentRequest';
import { IssuesUpdateLabelRequest } from './issuesUpdateLabelRequest';
import { IssuesUpdateMilestoneRequest } from './issuesUpdateMilestoneRequest';
import { IssuesUpdateRequest } from './issuesUpdateRequest';
import { IssuesUpdateRequestMilestone } from './issuesUpdateRequestMilestone';
import { IssuesUpdateRequestTitle } from './issuesUpdateRequestTitle';
import { Job } from './job';
import { JobStepsInner } from './jobStepsInner';
import { Key } from './key';
import { KeySimple } from './keySimple';
import { Label } from './label';
import { LabelSearchResultItem } from './labelSearchResultItem';
import { LabeledIssueEvent } from './labeledIssueEvent';
import { LabeledIssueEventLabel } from './labeledIssueEventLabel';
import { LegacyReviewComment } from './legacyReviewComment';
import { LegacyReviewCommentLinks } from './legacyReviewCommentLinks';
import { License } from './license';
import { LicenseContent } from './licenseContent';
import { LicenseSimple } from './licenseSimple';
import { LicenseSimple1 } from './licenseSimple1';
import { Link } from './link';
import { LinkWithType } from './linkWithType';
import { LockedIssueEvent } from './lockedIssueEvent';
import { MarkdownRenderRequest } from './markdownRenderRequest';
import { MarketplaceAccount } from './marketplaceAccount';
import { MarketplaceListingPlan } from './marketplaceListingPlan';
import { MarketplacePurchase } from './marketplacePurchase';
import { MarketplacePurchaseMarketplacePendingChange } from './marketplacePurchaseMarketplacePendingChange';
import { MarketplacePurchaseMarketplacePurchase } from './marketplacePurchaseMarketplacePurchase';
import { MergedUpstream } from './mergedUpstream';
import { MetaRoot200Response } from './metaRoot200Response';
import { Metadata } from './metadata';
import { Migration } from './migration';
import { MigrationsMapCommitAuthorRequest } from './migrationsMapCommitAuthorRequest';
import { MigrationsSetLfsPreferenceRequest } from './migrationsSetLfsPreferenceRequest';
import { MigrationsStartForAuthenticatedUserRequest } from './migrationsStartForAuthenticatedUserRequest';
import { MigrationsStartForOrgRequest } from './migrationsStartForOrgRequest';
import { MigrationsStartImportRequest } from './migrationsStartImportRequest';
import { MigrationsUpdateImportRequest } from './migrationsUpdateImportRequest';
import { Milestone } from './milestone';
import { Milestone1 } from './milestone1';
import { MilestonedIssueEvent } from './milestonedIssueEvent';
import { MilestonedIssueEventMilestone } from './milestonedIssueEventMilestone';
import { MinimalRepository } from './minimalRepository';
import { MinimalRepository1 } from './minimalRepository1';
import { MinimalRepositoryLicense } from './minimalRepositoryLicense';
import { MovedColumnInProjectIssueEvent } from './movedColumnInProjectIssueEvent';
import { OrgHook } from './orgHook';
import { OrgHookConfig } from './orgHookConfig';
import { OrgMembership } from './orgMembership';
import { OrgMembershipPermissions } from './orgMembershipPermissions';
import { OrganizationCustomRepositoryRole } from './organizationCustomRepositoryRole';
import { OrganizationFull } from './organizationFull';
import { OrganizationFullPlan } from './organizationFullPlan';
import { OrganizationInvitation } from './organizationInvitation';
import { OrganizationSimple } from './organizationSimple';
import { OrgsConvertMemberToOutsideCollaboratorRequest } from './orgsConvertMemberToOutsideCollaboratorRequest';
import { OrgsCreateInvitationRequest } from './orgsCreateInvitationRequest';
import { OrgsCreateWebhookRequest } from './orgsCreateWebhookRequest';
import { OrgsCreateWebhookRequestConfig } from './orgsCreateWebhookRequestConfig';
import { OrgsListAppInstallations200Response } from './orgsListAppInstallations200Response';
import { OrgsListCustomRoles200Response } from './orgsListCustomRoles200Response';
import { OrgsRemoveOutsideCollaborator422Response } from './orgsRemoveOutsideCollaborator422Response';
import { OrgsSetMembershipForUserRequest } from './orgsSetMembershipForUserRequest';
import { OrgsUpdate422Response } from './orgsUpdate422Response';
import { OrgsUpdateMembershipForAuthenticatedUserRequest } from './orgsUpdateMembershipForAuthenticatedUserRequest';
import { OrgsUpdateRequest } from './orgsUpdateRequest';
import { OrgsUpdateWebhookRequest } from './orgsUpdateWebhookRequest';
import { OrgsUpdateWebhookRequestConfig } from './orgsUpdateWebhookRequestConfig';
import { Package } from './package';
import { PackageVersion } from './packageVersion';
import { PackageVersionMetadata } from './packageVersionMetadata';
import { PageBuild } from './pageBuild';
import { PageBuildError } from './pageBuildError';
import { PageBuildStatus } from './pageBuildStatus';
import { PagesHealthCheckStatus } from './pagesHealthCheckStatus';
import { PagesHealthCheckStatusAltDomain } from './pagesHealthCheckStatusAltDomain';
import { PagesHealthCheckStatusDomain } from './pagesHealthCheckStatusDomain';
import { PagesHttpsCertificate } from './pagesHttpsCertificate';
import { PagesSourceHash } from './pagesSourceHash';
import { ParticipationStats } from './participationStats';
import { PendingDeployment } from './pendingDeployment';
import { PendingDeploymentEnvironment } from './pendingDeploymentEnvironment';
import { PendingDeploymentReviewersInner } from './pendingDeploymentReviewersInner';
import { PendingDeploymentReviewersInnerReviewer } from './pendingDeploymentReviewersInnerReviewer';
import { PorterAuthor } from './porterAuthor';
import { PorterLargeFile } from './porterLargeFile';
import { PrivateUser } from './privateUser';
import { Project } from './project';
import { ProjectCard } from './projectCard';
import { ProjectCollaboratorPermission } from './projectCollaboratorPermission';
import { ProjectColumn } from './projectColumn';
import { ProjectsAddCollaboratorRequest } from './projectsAddCollaboratorRequest';
import { ProjectsCreateCardRequest } from './projectsCreateCardRequest';
import { ProjectsCreateCardRequestOneOf } from './projectsCreateCardRequestOneOf';
import { ProjectsCreateCardRequestOneOf1 } from './projectsCreateCardRequestOneOf1';
import { ProjectsCreateForAuthenticatedUserRequest } from './projectsCreateForAuthenticatedUserRequest';
import { ProjectsCreateForOrgRequest } from './projectsCreateForOrgRequest';
import { ProjectsDeleteCard403Response } from './projectsDeleteCard403Response';
import { ProjectsMoveCard403Response } from './projectsMoveCard403Response';
import { ProjectsMoveCard403ResponseErrorsInner } from './projectsMoveCard403ResponseErrorsInner';
import { ProjectsMoveCard503Response } from './projectsMoveCard503Response';
import { ProjectsMoveCard503ResponseErrorsInner } from './projectsMoveCard503ResponseErrorsInner';
import { ProjectsMoveCardRequest } from './projectsMoveCardRequest';
import { ProjectsMoveColumnRequest } from './projectsMoveColumnRequest';
import { ProjectsUpdateCardRequest } from './projectsUpdateCardRequest';
import { ProjectsUpdateColumnRequest } from './projectsUpdateColumnRequest';
import { ProjectsUpdateRequest } from './projectsUpdateRequest';
import { ProtectedBranch } from './protectedBranch';
import { ProtectedBranchAdminEnforced } from './protectedBranchAdminEnforced';
import { ProtectedBranchEnforceAdmins } from './protectedBranchEnforceAdmins';
import { ProtectedBranchPullRequestReview } from './protectedBranchPullRequestReview';
import { ProtectedBranchPullRequestReviewBypassPullRequestAllowances } from './protectedBranchPullRequestReviewBypassPullRequestAllowances';
import { ProtectedBranchPullRequestReviewDismissalRestrictions } from './protectedBranchPullRequestReviewDismissalRestrictions';
import { ProtectedBranchRequiredConversationResolution } from './protectedBranchRequiredConversationResolution';
import { ProtectedBranchRequiredLinearHistory } from './protectedBranchRequiredLinearHistory';
import { ProtectedBranchRequiredPullRequestReviews } from './protectedBranchRequiredPullRequestReviews';
import { ProtectedBranchRequiredPullRequestReviewsBypassPullRequestAllowances } from './protectedBranchRequiredPullRequestReviewsBypassPullRequestAllowances';
import { ProtectedBranchRequiredPullRequestReviewsDismissalRestrictions } from './protectedBranchRequiredPullRequestReviewsDismissalRestrictions';
import { ProtectedBranchRequiredStatusCheck } from './protectedBranchRequiredStatusCheck';
import { ProtectedBranchRequiredStatusCheckChecksInner } from './protectedBranchRequiredStatusCheckChecksInner';
import { PublicUser } from './publicUser';
import { PublicUserPlan } from './publicUserPlan';
import { PullRequest } from './pullRequest';
import { PullRequestBase } from './pullRequestBase';
import { PullRequestBaseRepo } from './pullRequestBaseRepo';
import { PullRequestHead } from './pullRequestHead';
import { PullRequestHeadRepo } from './pullRequestHeadRepo';
import { PullRequestHeadRepoLicense } from './pullRequestHeadRepoLicense';
import { PullRequestHeadRepoOwner } from './pullRequestHeadRepoOwner';
import { PullRequestLabelsInner } from './pullRequestLabelsInner';
import { PullRequestMergeResult } from './pullRequestMergeResult';
import { PullRequestMinimal } from './pullRequestMinimal';
import { PullRequestMinimalHead } from './pullRequestMinimalHead';
import { PullRequestMinimalHeadRepo } from './pullRequestMinimalHeadRepo';
import { PullRequestReview } from './pullRequestReview';
import { PullRequestReviewComment } from './pullRequestReviewComment';
import { PullRequestReviewCommentLinks } from './pullRequestReviewCommentLinks';
import { PullRequestReviewCommentLinksHtml } from './pullRequestReviewCommentLinksHtml';
import { PullRequestReviewCommentLinksPullRequest } from './pullRequestReviewCommentLinksPullRequest';
import { PullRequestReviewCommentLinksSelf } from './pullRequestReviewCommentLinksSelf';
import { PullRequestReviewRequest } from './pullRequestReviewRequest';
import { PullRequestSimple } from './pullRequestSimple';
import { PullRequestSimpleHead } from './pullRequestSimpleHead';
import { PullRequestSimpleLabelsInner } from './pullRequestSimpleLabelsInner';
import { PullRequestSimpleLinks } from './pullRequestSimpleLinks';
import { PullsCreateReplyForReviewCommentRequest } from './pullsCreateReplyForReviewCommentRequest';
import { PullsCreateRequest } from './pullsCreateRequest';
import { PullsCreateReviewCommentRequest } from './pullsCreateReviewCommentRequest';
import { PullsCreateReviewRequest } from './pullsCreateReviewRequest';
import { PullsCreateReviewRequestCommentsInner } from './pullsCreateReviewRequestCommentsInner';
import { PullsDismissReviewRequest } from './pullsDismissReviewRequest';
import { PullsMergeRequest } from './pullsMergeRequest';
import { PullsRemoveRequestedReviewersRequest } from './pullsRemoveRequestedReviewersRequest';
import { PullsRequestReviewersRequest } from './pullsRequestReviewersRequest';
import { PullsSubmitReviewRequest } from './pullsSubmitReviewRequest';
import { PullsUpdateBranchRequest } from './pullsUpdateBranchRequest';
import { PullsUpdateRequest } from './pullsUpdateRequest';
import { PullsUpdateReviewCommentRequest } from './pullsUpdateReviewCommentRequest';
import { PullsUpdateReviewRequest } from './pullsUpdateReviewRequest';
import { RateLimit } from './rateLimit';
import { RateLimitOverview } from './rateLimitOverview';
import { RateLimitOverviewResources } from './rateLimitOverviewResources';
import { Reaction } from './reaction';
import { ReactionRollup } from './reactionRollup';
import { ReactionsCreateForCommitCommentRequest } from './reactionsCreateForCommitCommentRequest';
import { ReactionsCreateForIssueCommentRequest } from './reactionsCreateForIssueCommentRequest';
import { ReactionsCreateForIssueRequest } from './reactionsCreateForIssueRequest';
import { ReactionsCreateForPullRequestReviewCommentRequest } from './reactionsCreateForPullRequestReviewCommentRequest';
import { ReactionsCreateForReleaseRequest } from './reactionsCreateForReleaseRequest';
import { ReactionsCreateForTeamDiscussionCommentInOrgRequest } from './reactionsCreateForTeamDiscussionCommentInOrgRequest';
import { ReactionsCreateForTeamDiscussionInOrgRequest } from './reactionsCreateForTeamDiscussionInOrgRequest';
import { ReferencedWorkflow } from './referencedWorkflow';
import { ReferrerTraffic } from './referrerTraffic';
import { Release } from './release';
import { ReleaseAsset } from './releaseAsset';
import { RemovedFromProjectIssueEvent } from './removedFromProjectIssueEvent';
import { RenamedIssueEvent } from './renamedIssueEvent';
import { RenamedIssueEventRename } from './renamedIssueEventRename';
import { RepoSearchResultItem } from './repoSearchResultItem';
import { ReposAddCollaboratorRequest } from './reposAddCollaboratorRequest';
import { ReposCreateAutolinkRequest } from './reposCreateAutolinkRequest';
import { ReposCreateCommitCommentRequest } from './reposCreateCommitCommentRequest';
import { ReposCreateCommitStatusRequest } from './reposCreateCommitStatusRequest';
import { ReposCreateDeployKeyRequest } from './reposCreateDeployKeyRequest';
import { ReposCreateDeploymentRequest } from './reposCreateDeploymentRequest';
import { ReposCreateDeploymentRequestPayload } from './reposCreateDeploymentRequestPayload';
import { ReposCreateDeploymentStatusRequest } from './reposCreateDeploymentStatusRequest';
import { ReposCreateDispatchEventRequest } from './reposCreateDispatchEventRequest';
import { ReposCreateForAuthenticatedUserRequest } from './reposCreateForAuthenticatedUserRequest';
import { ReposCreateForkRequest } from './reposCreateForkRequest';
import { ReposCreateInOrgRequest } from './reposCreateInOrgRequest';
import { ReposCreateOrUpdateEnvironmentRequest } from './reposCreateOrUpdateEnvironmentRequest';
import { ReposCreateOrUpdateEnvironmentRequestReviewersInner } from './reposCreateOrUpdateEnvironmentRequestReviewersInner';
import { ReposCreateOrUpdateFileContentsRequest } from './reposCreateOrUpdateFileContentsRequest';
import { ReposCreateOrUpdateFileContentsRequestAuthor } from './reposCreateOrUpdateFileContentsRequestAuthor';
import { ReposCreateOrUpdateFileContentsRequestCommitter } from './reposCreateOrUpdateFileContentsRequestCommitter';
import { ReposCreatePagesDeploymentRequest } from './reposCreatePagesDeploymentRequest';
import { ReposCreatePagesSiteRequest } from './reposCreatePagesSiteRequest';
import { ReposCreatePagesSiteRequestSource } from './reposCreatePagesSiteRequestSource';
import { ReposCreateReleaseRequest } from './reposCreateReleaseRequest';
import { ReposCreateTagProtectionRequest } from './reposCreateTagProtectionRequest';
import { ReposCreateUsingTemplateRequest } from './reposCreateUsingTemplateRequest';
import { ReposCreateWebhookRequest } from './reposCreateWebhookRequest';
import { ReposCreateWebhookRequestConfig } from './reposCreateWebhookRequestConfig';
import { ReposDeleteFileRequest } from './reposDeleteFileRequest';
import { ReposDeleteFileRequestAuthor } from './reposDeleteFileRequestAuthor';
import { ReposDeleteFileRequestCommitter } from './reposDeleteFileRequestCommitter';
import { ReposGenerateReleaseNotesRequest } from './reposGenerateReleaseNotesRequest';
import { ReposGetAllEnvironments200Response } from './reposGetAllEnvironments200Response';
import { ReposGetContent200Response } from './reposGetContent200Response';
import { ReposMergeRequest } from './reposMergeRequest';
import { ReposMergeUpstreamRequest } from './reposMergeUpstreamRequest';
import { ReposRenameBranchRequest } from './reposRenameBranchRequest';
import { ReposReplaceAllTopicsRequest } from './reposReplaceAllTopicsRequest';
import { ReposSetAppAccessRestrictionsRequest } from './reposSetAppAccessRestrictionsRequest';
import { ReposSetAppAccessRestrictionsRequestOneOf } from './reposSetAppAccessRestrictionsRequestOneOf';
import { ReposSetStatusCheckContextsRequest } from './reposSetStatusCheckContextsRequest';
import { ReposSetStatusCheckContextsRequestOneOf } from './reposSetStatusCheckContextsRequestOneOf';
import { ReposSetTeamAccessRestrictionsRequest } from './reposSetTeamAccessRestrictionsRequest';
import { ReposSetTeamAccessRestrictionsRequestOneOf } from './reposSetTeamAccessRestrictionsRequestOneOf';
import { ReposSetUserAccessRestrictionsRequest } from './reposSetUserAccessRestrictionsRequest';
import { ReposSetUserAccessRestrictionsRequestOneOf } from './reposSetUserAccessRestrictionsRequestOneOf';
import { ReposTransferRequest } from './reposTransferRequest';
import { ReposUpdateBranchProtectionRequest } from './reposUpdateBranchProtectionRequest';
import { ReposUpdateBranchProtectionRequestRequiredPullRequestReviews } from './reposUpdateBranchProtectionRequestRequiredPullRequestReviews';
import { ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsBypassPullRequestAllowances } from './reposUpdateBranchProtectionRequestRequiredPullRequestReviewsBypassPullRequestAllowances';
import { ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsDismissalRestrictions } from './reposUpdateBranchProtectionRequestRequiredPullRequestReviewsDismissalRestrictions';
import { ReposUpdateBranchProtectionRequestRequiredStatusChecks } from './reposUpdateBranchProtectionRequestRequiredStatusChecks';
import { ReposUpdateBranchProtectionRequestRequiredStatusChecksChecksInner } from './reposUpdateBranchProtectionRequestRequiredStatusChecksChecksInner';
import { ReposUpdateBranchProtectionRequestRestrictions } from './reposUpdateBranchProtectionRequestRestrictions';
import { ReposUpdateCommitCommentRequest } from './reposUpdateCommitCommentRequest';
import { ReposUpdateInformationAboutPagesSiteRequest } from './reposUpdateInformationAboutPagesSiteRequest';
import { ReposUpdateInformationAboutPagesSiteRequestSource } from './reposUpdateInformationAboutPagesSiteRequestSource';
import { ReposUpdateInformationAboutPagesSiteRequestSourceAnyOf } from './reposUpdateInformationAboutPagesSiteRequestSourceAnyOf';
import { ReposUpdateInformationAboutPagesSiteRequestSourceAnyOf1 } from './reposUpdateInformationAboutPagesSiteRequestSourceAnyOf1';
import { ReposUpdateInvitationRequest } from './reposUpdateInvitationRequest';
import { ReposUpdatePullRequestReviewProtectionRequest } from './reposUpdatePullRequestReviewProtectionRequest';
import { ReposUpdateReleaseAssetRequest } from './reposUpdateReleaseAssetRequest';
import { ReposUpdateReleaseRequest } from './reposUpdateReleaseRequest';
import { ReposUpdateRequest } from './reposUpdateRequest';
import { ReposUpdateRequestSecurityAndAnalysis } from './reposUpdateRequestSecurityAndAnalysis';
import { ReposUpdateRequestSecurityAndAnalysisAdvancedSecurity } from './reposUpdateRequestSecurityAndAnalysisAdvancedSecurity';
import { ReposUpdateRequestSecurityAndAnalysisSecretScanning } from './reposUpdateRequestSecurityAndAnalysisSecretScanning';
import { ReposUpdateRequestSecurityAndAnalysisSecretScanningPushProtection } from './reposUpdateRequestSecurityAndAnalysisSecretScanningPushProtection';
import { ReposUpdateStatusCheckProtectionRequest } from './reposUpdateStatusCheckProtectionRequest';
import { ReposUpdateWebhookConfigForRepoRequest } from './reposUpdateWebhookConfigForRepoRequest';
import { ReposUpdateWebhookRequest } from './reposUpdateWebhookRequest';
import { ReposUpdateWebhookRequestConfig } from './reposUpdateWebhookRequestConfig';
import { Repository } from './repository';
import { Repository1 } from './repository1';
import { RepositoryActionsCaches } from './repositoryActionsCaches';
import { RepositoryActionsCachesActionsCachesInner } from './repositoryActionsCachesActionsCachesInner';
import { RepositoryCollaboratorPermission } from './repositoryCollaboratorPermission';
import { RepositoryInvitation } from './repositoryInvitation';
import { RepositoryInvitation1 } from './repositoryInvitation1';
import { RepositoryPermissions } from './repositoryPermissions';
import { RepositoryTemplateRepository } from './repositoryTemplateRepository';
import { RepositoryTemplateRepositoryOwner } from './repositoryTemplateRepositoryOwner';
import { RepositoryTemplateRepositoryPermissions } from './repositoryTemplateRepositoryPermissions';
import { ReviewDismissedIssueEvent } from './reviewDismissedIssueEvent';
import { ReviewDismissedIssueEventDismissedReview } from './reviewDismissedIssueEventDismissedReview';
import { ReviewRequestRemovedIssueEvent } from './reviewRequestRemovedIssueEvent';
import { ReviewRequestedIssueEvent } from './reviewRequestedIssueEvent';
import { RunnerApplication } from './runnerApplication';
import { SCIMUserList } from './sCIMUserList';
import { SCIMUsers } from './sCIMUsers';
import { SCIMUsersEmailsInner } from './sCIMUsersEmailsInner';
import { SCIMUsersGroupsInner } from './sCIMUsersGroupsInner';
import { SCIMUsersMeta } from './sCIMUsersMeta';
import { SCIMUsersName } from './sCIMUsersName';
import { SCIMUsersOperationsInner } from './sCIMUsersOperationsInner';
import { SCIMUsersOperationsInnerValue } from './sCIMUsersOperationsInnerValue';
import { ScimError } from './scimError';
import { ScimProvisionAndInviteUserRequest } from './scimProvisionAndInviteUserRequest';
import { ScimProvisionAndInviteUserRequestEmailsInner } from './scimProvisionAndInviteUserRequestEmailsInner';
import { ScimProvisionAndInviteUserRequestName } from './scimProvisionAndInviteUserRequestName';
import { ScimSetInformationForProvisionedUserRequest } from './scimSetInformationForProvisionedUserRequest';
import { ScimSetInformationForProvisionedUserRequestEmailsInner } from './scimSetInformationForProvisionedUserRequestEmailsInner';
import { ScimUpdateAttributeForUserRequest } from './scimUpdateAttributeForUserRequest';
import { ScimUpdateAttributeForUserRequestOperationsInner } from './scimUpdateAttributeForUserRequestOperationsInner';
import { ScimUpdateAttributeForUserRequestOperationsInnerValue } from './scimUpdateAttributeForUserRequestOperationsInnerValue';
import { ScimUpdateAttributeForUserRequestOperationsInnerValueOneOf } from './scimUpdateAttributeForUserRequestOperationsInnerValueOneOf';
import { ScimUpdateAttributeForUserRequestOperationsInnerValueOneOf1Inner } from './scimUpdateAttributeForUserRequestOperationsInnerValueOneOf1Inner';
import { ScopedInstallation } from './scopedInstallation';
import { SearchCode200Response } from './searchCode200Response';
import { SearchCommits200Response } from './searchCommits200Response';
import { SearchIssuesAndPullRequests200Response } from './searchIssuesAndPullRequests200Response';
import { SearchLabels200Response } from './searchLabels200Response';
import { SearchRepos200Response } from './searchRepos200Response';
import { SearchResultTextMatchesInner } from './searchResultTextMatchesInner';
import { SearchResultTextMatchesInnerMatchesInner } from './searchResultTextMatchesInnerMatchesInner';
import { SearchTopics200Response } from './searchTopics200Response';
import { SearchUsers200Response } from './searchUsers200Response';
import { SecretScanningListAlertsForEnterprise200ResponseInner } from './secretScanningListAlertsForEnterprise200ResponseInner';
import { SecretScanningListAlertsForRepo200ResponseInner } from './secretScanningListAlertsForRepo200ResponseInner';
import { SecretScanningListLocationsForAlert200ResponseInner } from './secretScanningListLocationsForAlert200ResponseInner';
import { SecretScanningListLocationsForAlert200ResponseInnerDetails } from './secretScanningListLocationsForAlert200ResponseInnerDetails';
import { SecretScanningListLocationsForAlert200ResponseInnerDetailsOneOf } from './secretScanningListLocationsForAlert200ResponseInnerDetailsOneOf';
import { SecretScanningUpdateAlertRequest } from './secretScanningUpdateAlertRequest';
import { SelfHostedRunnerLabel } from './selfHostedRunnerLabel';
import { SelfHostedRunners } from './selfHostedRunners';
import { ServerStatisticsProxyEndpointInner } from './serverStatisticsProxyEndpointInner';
import { ServerStatisticsProxyEndpointInnerDormantUsers } from './serverStatisticsProxyEndpointInnerDormantUsers';
import { ServerStatisticsProxyEndpointInnerGheStats } from './serverStatisticsProxyEndpointInnerGheStats';
import { ServerStatisticsProxyEndpointInnerGheStatsComments } from './serverStatisticsProxyEndpointInnerGheStatsComments';
import { ServerStatisticsProxyEndpointInnerGheStatsGists } from './serverStatisticsProxyEndpointInnerGheStatsGists';
import { ServerStatisticsProxyEndpointInnerGheStatsHooks } from './serverStatisticsProxyEndpointInnerGheStatsHooks';
import { ServerStatisticsProxyEndpointInnerGheStatsIssues } from './serverStatisticsProxyEndpointInnerGheStatsIssues';
import { ServerStatisticsProxyEndpointInnerGheStatsMilestones } from './serverStatisticsProxyEndpointInnerGheStatsMilestones';
import { ServerStatisticsProxyEndpointInnerGheStatsOrgs } from './serverStatisticsProxyEndpointInnerGheStatsOrgs';
import { ServerStatisticsProxyEndpointInnerGheStatsPages } from './serverStatisticsProxyEndpointInnerGheStatsPages';
import { ServerStatisticsProxyEndpointInnerGheStatsPulls } from './serverStatisticsProxyEndpointInnerGheStatsPulls';
import { ServerStatisticsProxyEndpointInnerGheStatsRepos } from './serverStatisticsProxyEndpointInnerGheStatsRepos';
import { ServerStatisticsProxyEndpointInnerGheStatsUsers } from './serverStatisticsProxyEndpointInnerGheStatsUsers';
import { ServerStatisticsProxyEndpointInnerGithubConnect } from './serverStatisticsProxyEndpointInnerGithubConnect';
import { ShortBlob } from './shortBlob';
import { ShortBranch } from './shortBranch';
import { ShortBranchCommit } from './shortBranchCommit';
import { SimpleCommit } from './simpleCommit';
import { SimpleCommit1 } from './simpleCommit1';
import { SimpleCommitAuthor } from './simpleCommitAuthor';
import { SimpleCommitStatus } from './simpleCommitStatus';
import { SimpleRepository } from './simpleRepository';
import { SimpleUser } from './simpleUser';
import { SimpleUser1 } from './simpleUser1';
import { SimpleWebhookDelivery } from './simpleWebhookDelivery';
import { Snapshot } from './snapshot';
import { SnapshotDetector } from './snapshotDetector';
import { SnapshotJob } from './snapshotJob';
import { SnapshotManifestsValue } from './snapshotManifestsValue';
import { SnapshotManifestsValueFile } from './snapshotManifestsValueFile';
import { SnapshotManifestsValueResolvedValue } from './snapshotManifestsValueResolvedValue';
import { Stargazer } from './stargazer';
import { StarredRepository } from './starredRepository';
import { StateChangeIssueEvent } from './stateChangeIssueEvent';
import { Status } from './status';
import { StatusCheckPolicy } from './statusCheckPolicy';
import { StatusCheckPolicyChecksInner } from './statusCheckPolicyChecksInner';
import { SymlinkContent } from './symlinkContent';
import { SymlinkContent1 } from './symlinkContent1';
import { Tag } from './tag';
import { TagProtection } from './tagProtection';
import { Team } from './team';
import { TeamDiscussion } from './teamDiscussion';
import { TeamDiscussionComment } from './teamDiscussionComment';
import { TeamMembership } from './teamMembership';
import { TeamPermissions } from './teamPermissions';
import { TeamProject } from './teamProject';
import { TeamProjectPermissions } from './teamProjectPermissions';
import { TeamRepository } from './teamRepository';
import { TeamSimple } from './teamSimple';
import { TeamSimple1 } from './teamSimple1';
import { TeamsAddOrUpdateMembershipForUserInOrgRequest } from './teamsAddOrUpdateMembershipForUserInOrgRequest';
import { TeamsAddOrUpdateProjectPermissionsInOrgRequest } from './teamsAddOrUpdateProjectPermissionsInOrgRequest';
import { TeamsAddOrUpdateProjectPermissionsLegacyRequest } from './teamsAddOrUpdateProjectPermissionsLegacyRequest';
import { TeamsAddOrUpdateRepoPermissionsInOrgRequest } from './teamsAddOrUpdateRepoPermissionsInOrgRequest';
import { TeamsAddOrUpdateRepoPermissionsLegacyRequest } from './teamsAddOrUpdateRepoPermissionsLegacyRequest';
import { TeamsCreateDiscussionCommentInOrgRequest } from './teamsCreateDiscussionCommentInOrgRequest';
import { TeamsCreateDiscussionInOrgRequest } from './teamsCreateDiscussionInOrgRequest';
import { TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequest } from './teamsCreateOrUpdateIdpGroupConnectionsInOrgRequest';
import { TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequestGroupsInner } from './teamsCreateOrUpdateIdpGroupConnectionsInOrgRequestGroupsInner';
import { TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequest } from './teamsCreateOrUpdateIdpGroupConnectionsLegacyRequest';
import { TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequestGroupsInner } from './teamsCreateOrUpdateIdpGroupConnectionsLegacyRequestGroupsInner';
import { TeamsCreateRequest } from './teamsCreateRequest';
import { TeamsLinkExternalIdpGroupToTeamForOrgRequest } from './teamsLinkExternalIdpGroupToTeamForOrgRequest';
import { TeamsUpdateDiscussionInOrgRequest } from './teamsUpdateDiscussionInOrgRequest';
import { TeamsUpdateInOrgRequest } from './teamsUpdateInOrgRequest';
import { TeamsUpdateLegacyRequest } from './teamsUpdateLegacyRequest';
import { TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization } from './theJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization';
import { Thread } from './thread';
import { ThreadSubject } from './threadSubject';
import { ThreadSubscription } from './threadSubscription';
import { TimelineAssignedIssueEvent } from './timelineAssignedIssueEvent';
import { TimelineCommentEvent } from './timelineCommentEvent';
import { TimelineCommitCommentedEvent } from './timelineCommitCommentedEvent';
import { TimelineCommittedEvent } from './timelineCommittedEvent';
import { TimelineCrossReferencedEvent } from './timelineCrossReferencedEvent';
import { TimelineCrossReferencedEventSource } from './timelineCrossReferencedEventSource';
import { TimelineEvent } from './timelineEvent';
import { TimelineLineCommentedEvent } from './timelineLineCommentedEvent';
import { TimelineReviewedEvent } from './timelineReviewedEvent';
import { TimelineReviewedEventLinks } from './timelineReviewedEventLinks';
import { TimelineReviewedEventLinksHtml } from './timelineReviewedEventLinksHtml';
import { TimelineUnassignedIssueEvent } from './timelineUnassignedIssueEvent';
import { Topic } from './topic';
import { TopicSearchResultItem } from './topicSearchResultItem';
import { TopicSearchResultItemRelatedInner } from './topicSearchResultItemRelatedInner';
import { TopicSearchResultItemRelatedInnerTopicRelation } from './topicSearchResultItemRelatedInnerTopicRelation';
import { Traffic } from './traffic';
import { UnassignedIssueEvent } from './unassignedIssueEvent';
import { UnlabeledIssueEvent } from './unlabeledIssueEvent';
import { UserMarketplacePurchase } from './userMarketplacePurchase';
import { UserSearchResultItem } from './userSearchResultItem';
import { UsersAddEmailForAuthenticatedUserRequest } from './usersAddEmailForAuthenticatedUserRequest';
import { UsersAddEmailForAuthenticatedUserRequestOneOf } from './usersAddEmailForAuthenticatedUserRequestOneOf';
import { UsersCreateGpgKeyForAuthenticatedUserRequest } from './usersCreateGpgKeyForAuthenticatedUserRequest';
import { UsersCreatePublicSshKeyForAuthenticatedUserRequest } from './usersCreatePublicSshKeyForAuthenticatedUserRequest';
import { UsersDeleteEmailForAuthenticatedUserRequest } from './usersDeleteEmailForAuthenticatedUserRequest';
import { UsersDeleteEmailForAuthenticatedUserRequestOneOf } from './usersDeleteEmailForAuthenticatedUserRequestOneOf';
import { UsersGetAuthenticated200Response } from './usersGetAuthenticated200Response';
import { UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest } from './usersSetPrimaryEmailVisibilityForAuthenticatedUserRequest';
import { UsersUpdateAuthenticatedRequest } from './usersUpdateAuthenticatedRequest';
import { ValidationError } from './validationError';
import { ValidationErrorErrorsInner } from './validationErrorErrorsInner';
import { ValidationErrorErrorsInnerValue } from './validationErrorErrorsInnerValue';
import { ValidationErrorSimple } from './validationErrorSimple';
import { Verification } from './verification';
import { ViewTraffic } from './viewTraffic';
import { Webhook } from './webhook';
import { WebhookConfig } from './webhookConfig';
import { WebhookConfiguration } from './webhookConfiguration';
import { WebhookConfigurationInsecureSsl } from './webhookConfigurationInsecureSsl';
import { WebhookDelivery } from './webhookDelivery';
import { WebhookDeliveryRequest } from './webhookDeliveryRequest';
import { WebhookDeliveryResponse } from './webhookDeliveryResponse';
import { Workflow } from './workflow';
import { WorkflowRun } from './workflowRun';
import { WorkflowRunUsage } from './workflowRunUsage';
import { WorkflowRunUsageBillable } from './workflowRunUsageBillable';
import { WorkflowRunUsageBillableUBUNTU } from './workflowRunUsageBillableUBUNTU';
import { WorkflowRunUsageBillableUBUNTUJobRunsInner } from './workflowRunUsageBillableUBUNTUJobRunsInner';
import { WorkflowUsage } from './workflowUsage';
import { WorkflowUsageBillable } from './workflowUsageBillable';
import { WorkflowUsageBillableUBUNTU } from './workflowUsageBillableUBUNTU';

/* tslint:disable:no-unused-variable */
let primitives = [
                    "string",
                    "boolean",
                    "double",
                    "integer",
                    "long",
                    "float",
                    "number",
                    "any"
                 ];

let enumsMap: {[index: string]: any} = {
        "ActionsCreateOrUpdateOrgSecretRequest.VisibilityEnum": ActionsCreateOrUpdateOrgSecretRequest.VisibilityEnum,
        "ActionsCreateSelfHostedRunnerGroupForOrgRequest.VisibilityEnum": ActionsCreateSelfHostedRunnerGroupForOrgRequest.VisibilityEnum,
        "ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response.DefaultWorkflowPermissionsEnum": ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response.DefaultWorkflowPermissionsEnum,
        "ActionsGetGithubActionsPermissionsOrganization200Response.EnabledRepositoriesEnum": ActionsGetGithubActionsPermissionsOrganization200Response.EnabledRepositoriesEnum,
        "ActionsGetGithubActionsPermissionsOrganization200Response.AllowedActionsEnum": ActionsGetGithubActionsPermissionsOrganization200Response.AllowedActionsEnum,
        "ActionsGetGithubActionsPermissionsRepository200Response.AllowedActionsEnum": ActionsGetGithubActionsPermissionsRepository200Response.AllowedActionsEnum,
        "ActionsGetWorkflowAccessToRepository200Response.AccessLevelEnum": ActionsGetWorkflowAccessToRepository200Response.AccessLevelEnum,
        "ActionsReviewPendingDeploymentsForRunRequest.StateEnum": ActionsReviewPendingDeploymentsForRunRequest.StateEnum,
        "ActionsSecretForAnOrganization.VisibilityEnum": ActionsSecretForAnOrganization.VisibilityEnum,
        "ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest.DefaultWorkflowPermissionsEnum": ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest.DefaultWorkflowPermissionsEnum,
        "ActionsSetGithubActionsPermissionsOrganizationRequest.EnabledRepositoriesEnum": ActionsSetGithubActionsPermissionsOrganizationRequest.EnabledRepositoriesEnum,
        "ActionsSetGithubActionsPermissionsOrganizationRequest.AllowedActionsEnum": ActionsSetGithubActionsPermissionsOrganizationRequest.AllowedActionsEnum,
        "ActionsSetGithubActionsPermissionsRepositoryRequest.AllowedActionsEnum": ActionsSetGithubActionsPermissionsRepositoryRequest.AllowedActionsEnum,
        "ActionsUpdateSelfHostedRunnerGroupForOrgRequest.VisibilityEnum": ActionsUpdateSelfHostedRunnerGroupForOrgRequest.VisibilityEnum,
        "AppPermissions.ActionsEnum": AppPermissions.ActionsEnum,
        "AppPermissions.AdministrationEnum": AppPermissions.AdministrationEnum,
        "AppPermissions.ChecksEnum": AppPermissions.ChecksEnum,
        "AppPermissions.ContentsEnum": AppPermissions.ContentsEnum,
        "AppPermissions.DeploymentsEnum": AppPermissions.DeploymentsEnum,
        "AppPermissions.EnvironmentsEnum": AppPermissions.EnvironmentsEnum,
        "AppPermissions.IssuesEnum": AppPermissions.IssuesEnum,
        "AppPermissions.MetadataEnum": AppPermissions.MetadataEnum,
        "AppPermissions.PackagesEnum": AppPermissions.PackagesEnum,
        "AppPermissions.PagesEnum": AppPermissions.PagesEnum,
        "AppPermissions.PullRequestsEnum": AppPermissions.PullRequestsEnum,
        "AppPermissions.RepositoryHooksEnum": AppPermissions.RepositoryHooksEnum,
        "AppPermissions.RepositoryProjectsEnum": AppPermissions.RepositoryProjectsEnum,
        "AppPermissions.SecretScanningAlertsEnum": AppPermissions.SecretScanningAlertsEnum,
        "AppPermissions.SecretsEnum": AppPermissions.SecretsEnum,
        "AppPermissions.SecurityEventsEnum": AppPermissions.SecurityEventsEnum,
        "AppPermissions.SingleFileEnum": AppPermissions.SingleFileEnum,
        "AppPermissions.StatusesEnum": AppPermissions.StatusesEnum,
        "AppPermissions.VulnerabilityAlertsEnum": AppPermissions.VulnerabilityAlertsEnum,
        "AppPermissions.WorkflowsEnum": AppPermissions.WorkflowsEnum,
        "AppPermissions.MembersEnum": AppPermissions.MembersEnum,
        "AppPermissions.OrganizationAdministrationEnum": AppPermissions.OrganizationAdministrationEnum,
        "AppPermissions.OrganizationHooksEnum": AppPermissions.OrganizationHooksEnum,
        "AppPermissions.OrganizationPlanEnum": AppPermissions.OrganizationPlanEnum,
        "AppPermissions.OrganizationProjectsEnum": AppPermissions.OrganizationProjectsEnum,
        "AppPermissions.OrganizationPackagesEnum": AppPermissions.OrganizationPackagesEnum,
        "AppPermissions.OrganizationSecretsEnum": AppPermissions.OrganizationSecretsEnum,
        "AppPermissions.OrganizationSelfHostedRunnersEnum": AppPermissions.OrganizationSelfHostedRunnersEnum,
        "AppPermissions.OrganizationUserBlockingEnum": AppPermissions.OrganizationUserBlockingEnum,
        "AppPermissions.TeamDiscussionsEnum": AppPermissions.TeamDiscussionsEnum,
        "AuthenticationToken.RepositorySelectionEnum": AuthenticationToken.RepositorySelectionEnum,
        "AutoMerge.MergeMethodEnum": AutoMerge.MergeMethodEnum,
        "CheckRun.StatusEnum": CheckRun.StatusEnum,
        "CheckRun.ConclusionEnum": CheckRun.ConclusionEnum,
        "CheckSuite.StatusEnum": CheckSuite.StatusEnum,
        "CheckSuite.ConclusionEnum": CheckSuite.ConclusionEnum,
        "ChecksCreateRequest.StatusEnum": ChecksCreateRequest.StatusEnum,
        "ChecksCreateRequest.ConclusionEnum": ChecksCreateRequest.ConclusionEnum,
        "ChecksCreateRequestOneOf.StatusEnum": ChecksCreateRequestOneOf.StatusEnum,
        "ChecksCreateRequestOneOf1.StatusEnum": ChecksCreateRequestOneOf1.StatusEnum,
        "ChecksCreateRequestOutputAnnotationsInner.AnnotationLevelEnum": ChecksCreateRequestOutputAnnotationsInner.AnnotationLevelEnum,
        "ChecksUpdateRequest.StatusEnum": ChecksUpdateRequest.StatusEnum,
        "ChecksUpdateRequest.ConclusionEnum": ChecksUpdateRequest.ConclusionEnum,
        "ChecksUpdateRequestAnyOf.StatusEnum": ChecksUpdateRequestAnyOf.StatusEnum,
        "CodeScanningGetAlert200Response.StateEnum": CodeScanningGetAlert200Response.StateEnum,
        "CodeScanningGetAlert200Response.DismissedReasonEnum": CodeScanningGetAlert200Response.DismissedReasonEnum,
        "CodeScanningGetSarif200Response.ProcessingStatusEnum": CodeScanningGetSarif200Response.ProcessingStatusEnum,
        "CodeScanningListAlertsForEnterprise200ResponseInner.StateEnum": CodeScanningListAlertsForEnterprise200ResponseInner.StateEnum,
        "CodeScanningListAlertsForEnterprise200ResponseInner.DismissedReasonEnum": CodeScanningListAlertsForEnterprise200ResponseInner.DismissedReasonEnum,
        "CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance.StateEnum": CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance.StateEnum,
        "CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance.ClassificationsEnum": CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance.ClassificationsEnum,
        "CodeScanningListAlertsForEnterprise200ResponseInnerRule.SeverityEnum": CodeScanningListAlertsForEnterprise200ResponseInnerRule.SeverityEnum,
        "CodeScanningListAlertsForEnterprise200ResponseInnerRule.SecuritySeverityLevelEnum": CodeScanningListAlertsForEnterprise200ResponseInnerRule.SecuritySeverityLevelEnum,
        "CodeScanningListAlertsForRepo200ResponseInner.StateEnum": CodeScanningListAlertsForRepo200ResponseInner.StateEnum,
        "CodeScanningListAlertsForRepo200ResponseInner.DismissedReasonEnum": CodeScanningListAlertsForRepo200ResponseInner.DismissedReasonEnum,
        "CodeScanningListAlertsForRepo200ResponseInnerRule.SeverityEnum": CodeScanningListAlertsForRepo200ResponseInnerRule.SeverityEnum,
        "CodeScanningUpdateAlertRequest.StateEnum": CodeScanningUpdateAlertRequest.StateEnum,
        "CodeScanningUpdateAlertRequest.DismissedReasonEnum": CodeScanningUpdateAlertRequest.DismissedReasonEnum,
        "Codespace.StateEnum": Codespace.StateEnum,
        "Codespace.LocationEnum": Codespace.LocationEnum,
        "CodespaceMachine.PrebuildAvailabilityEnum": CodespaceMachine.PrebuildAvailabilityEnum,
        "CodespaceMachine1.PrebuildAvailabilityEnum": CodespaceMachine1.PrebuildAvailabilityEnum,
        "CodespacesSecret1.VisibilityEnum": CodespacesSecret1.VisibilityEnum,
        "CommitComment.AuthorAssociationEnum": CommitComment.AuthorAssociationEnum,
        "CommitComparison.StatusEnum": CommitComparison.StatusEnum,
        "DependabotCreateOrUpdateOrgSecretRequest.VisibilityEnum": DependabotCreateOrUpdateOrgSecretRequest.VisibilityEnum,
        "DependabotSecretForAnOrganization.VisibilityEnum": DependabotSecretForAnOrganization.VisibilityEnum,
        "DependencyGraphDiffInner.ChangeTypeEnum": DependencyGraphDiffInner.ChangeTypeEnum,
        "DeploymentStatus.StateEnum": DeploymentStatus.StateEnum,
        "DiffEntry.StatusEnum": DiffEntry.StatusEnum,
        "EnterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest.VisibilityEnum": EnterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest.VisibilityEnum,
        "EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response.EnabledOrganizationsEnum": EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response.EnabledOrganizationsEnum,
        "EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response.AllowedActionsEnum": EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response.AllowedActionsEnum,
        "EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest.EnabledOrganizationsEnum": EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest.EnabledOrganizationsEnum,
        "EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest.AllowedActionsEnum": EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest.AllowedActionsEnum,
        "EnterpriseAdminUpdateAttributeForEnterpriseGroupRequestOperationsInner.OpEnum": EnterpriseAdminUpdateAttributeForEnterpriseGroupRequestOperationsInner.OpEnum,
        "EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest.VisibilityEnum": EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest.VisibilityEnum,
        "EnvironmentApproval.StateEnum": EnvironmentApproval.StateEnum,
        "FullRepositorySecurityAndAnalysisAdvancedSecurity.StatusEnum": FullRepositorySecurityAndAnalysisAdvancedSecurity.StatusEnum,
        "FullTeam.PrivacyEnum": FullTeam.PrivacyEnum,
        "GistComment.AuthorAssociationEnum": GistComment.AuthorAssociationEnum,
        "GistsCreateRequestPublicOneOf": GistsCreateRequestPublicOneOf,
        "GitCreateTagRequest.TypeEnum": GitCreateTagRequest.TypeEnum,
        "GitCreateTreeRequestTreeInner.ModeEnum": GitCreateTreeRequestTreeInner.ModeEnum,
        "GitCreateTreeRequestTreeInner.TypeEnum": GitCreateTreeRequestTreeInner.TypeEnum,
        "GitHubPages.StatusEnum": GitHubPages.StatusEnum,
        "GitHubPages.ProtectedDomainStateEnum": GitHubPages.ProtectedDomainStateEnum,
        "GitHubPages.BuildTypeEnum": GitHubPages.BuildTypeEnum,
        "Import.StatusEnum": Import.StatusEnum,
        "Installation.RepositorySelectionEnum": Installation.RepositorySelectionEnum,
        "InstallationToken.RepositorySelectionEnum": InstallationToken.RepositorySelectionEnum,
        "InteractionLimits.LimitEnum": InteractionLimits.LimitEnum,
        "InteractionRestrictions.LimitEnum": InteractionRestrictions.LimitEnum,
        "InteractionRestrictions.ExpiryEnum": InteractionRestrictions.ExpiryEnum,
        "InteractionsGetRestrictionsForOrg200Response.LimitEnum": InteractionsGetRestrictionsForOrg200Response.LimitEnum,
        "Issue.AuthorAssociationEnum": Issue.AuthorAssociationEnum,
        "Issue1.AuthorAssociationEnum": Issue1.AuthorAssociationEnum,
        "IssueComment.AuthorAssociationEnum": IssueComment.AuthorAssociationEnum,
        "IssueEvent.AuthorAssociationEnum": IssueEvent.AuthorAssociationEnum,
        "IssueSearchResultItem.AuthorAssociationEnum": IssueSearchResultItem.AuthorAssociationEnum,
        "IssuesCreateMilestoneRequest.StateEnum": IssuesCreateMilestoneRequest.StateEnum,
        "IssuesLockRequest.LockReasonEnum": IssuesLockRequest.LockReasonEnum,
        "IssuesUpdateMilestoneRequest.StateEnum": IssuesUpdateMilestoneRequest.StateEnum,
        "IssuesUpdateRequest.StateEnum": IssuesUpdateRequest.StateEnum,
        "Job.StatusEnum": Job.StatusEnum,
        "JobStepsInner.StatusEnum": JobStepsInner.StatusEnum,
        "LegacyReviewComment.AuthorAssociationEnum": LegacyReviewComment.AuthorAssociationEnum,
        "LegacyReviewComment.SideEnum": LegacyReviewComment.SideEnum,
        "LegacyReviewComment.StartSideEnum": LegacyReviewComment.StartSideEnum,
        "MarkdownRenderRequest.ModeEnum": MarkdownRenderRequest.ModeEnum,
        "MergedUpstream.MergeTypeEnum": MergedUpstream.MergeTypeEnum,
        "MigrationsSetLfsPreferenceRequest.UseLfsEnum": MigrationsSetLfsPreferenceRequest.UseLfsEnum,
        "MigrationsStartForAuthenticatedUserRequest.ExcludeEnum": MigrationsStartForAuthenticatedUserRequest.ExcludeEnum,
        "MigrationsStartForOrgRequest.ExcludeEnum": MigrationsStartForOrgRequest.ExcludeEnum,
        "MigrationsStartImportRequest.VcsEnum": MigrationsStartImportRequest.VcsEnum,
        "MigrationsUpdateImportRequest.VcsEnum": MigrationsUpdateImportRequest.VcsEnum,
        "Milestone.StateEnum": Milestone.StateEnum,
        "Milestone1.StateEnum": Milestone1.StateEnum,
        "OrgMembership.StateEnum": OrgMembership.StateEnum,
        "OrgMembership.RoleEnum": OrgMembership.RoleEnum,
        "OrgsCreateInvitationRequest.RoleEnum": OrgsCreateInvitationRequest.RoleEnum,
        "OrgsSetMembershipForUserRequest.RoleEnum": OrgsSetMembershipForUserRequest.RoleEnum,
        "OrgsUpdateMembershipForAuthenticatedUserRequest.StateEnum": OrgsUpdateMembershipForAuthenticatedUserRequest.StateEnum,
        "OrgsUpdateRequest.DefaultRepositoryPermissionEnum": OrgsUpdateRequest.DefaultRepositoryPermissionEnum,
        "OrgsUpdateRequest.MembersAllowedRepositoryCreationTypeEnum": OrgsUpdateRequest.MembersAllowedRepositoryCreationTypeEnum,
        "Package.PackageTypeEnum": Package.PackageTypeEnum,
        "Package.VisibilityEnum": Package.VisibilityEnum,
        "PackageVersionMetadata.PackageTypeEnum": PackageVersionMetadata.PackageTypeEnum,
        "PagesHttpsCertificate.StateEnum": PagesHttpsCertificate.StateEnum,
        "PendingDeploymentReviewersInner.TypeEnum": PendingDeploymentReviewersInner.TypeEnum,
        "Project.OrganizationPermissionEnum": Project.OrganizationPermissionEnum,
        "ProjectsAddCollaboratorRequest.PermissionEnum": ProjectsAddCollaboratorRequest.PermissionEnum,
        "ProjectsUpdateRequest.OrganizationPermissionEnum": ProjectsUpdateRequest.OrganizationPermissionEnum,
        "PullRequest.StateEnum": PullRequest.StateEnum,
        "PullRequest.AuthorAssociationEnum": PullRequest.AuthorAssociationEnum,
        "PullRequestReview.AuthorAssociationEnum": PullRequestReview.AuthorAssociationEnum,
        "PullRequestReviewComment.AuthorAssociationEnum": PullRequestReviewComment.AuthorAssociationEnum,
        "PullRequestReviewComment.StartSideEnum": PullRequestReviewComment.StartSideEnum,
        "PullRequestReviewComment.SideEnum": PullRequestReviewComment.SideEnum,
        "PullRequestSimple.AuthorAssociationEnum": PullRequestSimple.AuthorAssociationEnum,
        "PullsCreateReviewCommentRequest.SideEnum": PullsCreateReviewCommentRequest.SideEnum,
        "PullsCreateReviewCommentRequest.StartSideEnum": PullsCreateReviewCommentRequest.StartSideEnum,
        "PullsCreateReviewRequest.EventEnum": PullsCreateReviewRequest.EventEnum,
        "PullsDismissReviewRequest.EventEnum": PullsDismissReviewRequest.EventEnum,
        "PullsMergeRequest.MergeMethodEnum": PullsMergeRequest.MergeMethodEnum,
        "PullsSubmitReviewRequest.EventEnum": PullsSubmitReviewRequest.EventEnum,
        "PullsUpdateRequest.StateEnum": PullsUpdateRequest.StateEnum,
        "Reaction.ContentEnum": Reaction.ContentEnum,
        "ReactionsCreateForCommitCommentRequest.ContentEnum": ReactionsCreateForCommitCommentRequest.ContentEnum,
        "ReactionsCreateForIssueCommentRequest.ContentEnum": ReactionsCreateForIssueCommentRequest.ContentEnum,
        "ReactionsCreateForIssueRequest.ContentEnum": ReactionsCreateForIssueRequest.ContentEnum,
        "ReactionsCreateForPullRequestReviewCommentRequest.ContentEnum": ReactionsCreateForPullRequestReviewCommentRequest.ContentEnum,
        "ReactionsCreateForReleaseRequest.ContentEnum": ReactionsCreateForReleaseRequest.ContentEnum,
        "ReactionsCreateForTeamDiscussionCommentInOrgRequest.ContentEnum": ReactionsCreateForTeamDiscussionCommentInOrgRequest.ContentEnum,
        "ReactionsCreateForTeamDiscussionInOrgRequest.ContentEnum": ReactionsCreateForTeamDiscussionInOrgRequest.ContentEnum,
        "ReleaseAsset.StateEnum": ReleaseAsset.StateEnum,
        "ReposAddCollaboratorRequest.PermissionEnum": ReposAddCollaboratorRequest.PermissionEnum,
        "ReposCreateCommitStatusRequest.StateEnum": ReposCreateCommitStatusRequest.StateEnum,
        "ReposCreateDeploymentStatusRequest.StateEnum": ReposCreateDeploymentStatusRequest.StateEnum,
        "ReposCreateDeploymentStatusRequest.EnvironmentEnum": ReposCreateDeploymentStatusRequest.EnvironmentEnum,
        "ReposCreateInOrgRequest.VisibilityEnum": ReposCreateInOrgRequest.VisibilityEnum,
        "ReposCreateOrUpdateEnvironmentRequestReviewersInner.TypeEnum": ReposCreateOrUpdateEnvironmentRequestReviewersInner.TypeEnum,
        "ReposCreatePagesSiteRequestSource.PathEnum": ReposCreatePagesSiteRequestSource.PathEnum,
        "ReposUpdateInformationAboutPagesSiteRequestSource.PathEnum": ReposUpdateInformationAboutPagesSiteRequestSource.PathEnum,
        "ReposUpdateInformationAboutPagesSiteRequestSourceAnyOf.PathEnum": ReposUpdateInformationAboutPagesSiteRequestSourceAnyOf.PathEnum,
        "ReposUpdateInformationAboutPagesSiteRequestSourceAnyOf1": ReposUpdateInformationAboutPagesSiteRequestSourceAnyOf1,
        "ReposUpdateInvitationRequest.PermissionsEnum": ReposUpdateInvitationRequest.PermissionsEnum,
        "ReposUpdateRequest.VisibilityEnum": ReposUpdateRequest.VisibilityEnum,
        "RepositoryInvitation.PermissionsEnum": RepositoryInvitation.PermissionsEnum,
        "SCIMUsersOperationsInner.OpEnum": SCIMUsersOperationsInner.OpEnum,
        "ScimUpdateAttributeForUserRequestOperationsInner.OpEnum": ScimUpdateAttributeForUserRequestOperationsInner.OpEnum,
        "ScopedInstallation.RepositorySelectionEnum": ScopedInstallation.RepositorySelectionEnum,
        "SecretScanningListAlertsForEnterprise200ResponseInner.StateEnum": SecretScanningListAlertsForEnterprise200ResponseInner.StateEnum,
        "SecretScanningListAlertsForEnterprise200ResponseInner.ResolutionEnum": SecretScanningListAlertsForEnterprise200ResponseInner.ResolutionEnum,
        "SecretScanningListAlertsForRepo200ResponseInner.StateEnum": SecretScanningListAlertsForRepo200ResponseInner.StateEnum,
        "SecretScanningListAlertsForRepo200ResponseInner.ResolutionEnum": SecretScanningListAlertsForRepo200ResponseInner.ResolutionEnum,
        "SecretScanningListLocationsForAlert200ResponseInner.TypeEnum": SecretScanningListLocationsForAlert200ResponseInner.TypeEnum,
        "SecretScanningUpdateAlertRequest.StateEnum": SecretScanningUpdateAlertRequest.StateEnum,
        "SecretScanningUpdateAlertRequest.ResolutionEnum": SecretScanningUpdateAlertRequest.ResolutionEnum,
        "SelfHostedRunnerLabel.TypeEnum": SelfHostedRunnerLabel.TypeEnum,
        "SnapshotManifestsValueResolvedValue.RelationshipEnum": SnapshotManifestsValueResolvedValue.RelationshipEnum,
        "SnapshotManifestsValueResolvedValue.ScopeEnum": SnapshotManifestsValueResolvedValue.ScopeEnum,
        "TeamMembership.RoleEnum": TeamMembership.RoleEnum,
        "TeamMembership.StateEnum": TeamMembership.StateEnum,
        "TeamsAddOrUpdateMembershipForUserInOrgRequest.RoleEnum": TeamsAddOrUpdateMembershipForUserInOrgRequest.RoleEnum,
        "TeamsAddOrUpdateProjectPermissionsInOrgRequest.PermissionEnum": TeamsAddOrUpdateProjectPermissionsInOrgRequest.PermissionEnum,
        "TeamsAddOrUpdateProjectPermissionsLegacyRequest.PermissionEnum": TeamsAddOrUpdateProjectPermissionsLegacyRequest.PermissionEnum,
        "TeamsAddOrUpdateRepoPermissionsInOrgRequest.PermissionEnum": TeamsAddOrUpdateRepoPermissionsInOrgRequest.PermissionEnum,
        "TeamsAddOrUpdateRepoPermissionsLegacyRequest.PermissionEnum": TeamsAddOrUpdateRepoPermissionsLegacyRequest.PermissionEnum,
        "TeamsCreateRequest.PrivacyEnum": TeamsCreateRequest.PrivacyEnum,
        "TeamsCreateRequest.PermissionEnum": TeamsCreateRequest.PermissionEnum,
        "TeamsUpdateInOrgRequest.PrivacyEnum": TeamsUpdateInOrgRequest.PrivacyEnum,
        "TeamsUpdateInOrgRequest.PermissionEnum": TeamsUpdateInOrgRequest.PermissionEnum,
        "TeamsUpdateLegacyRequest.PrivacyEnum": TeamsUpdateLegacyRequest.PrivacyEnum,
        "TeamsUpdateLegacyRequest.PermissionEnum": TeamsUpdateLegacyRequest.PermissionEnum,
        "TimelineCommentEvent.AuthorAssociationEnum": TimelineCommentEvent.AuthorAssociationEnum,
        "TimelineEvent.AuthorAssociationEnum": TimelineEvent.AuthorAssociationEnum,
        "TimelineReviewedEvent.AuthorAssociationEnum": TimelineReviewedEvent.AuthorAssociationEnum,
        "UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest.VisibilityEnum": UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest.VisibilityEnum,
        "Workflow.StateEnum": Workflow.StateEnum,
}

let typeMap: {[index: string]: any} = {
    "ActionsCacheUsageByRepository": ActionsCacheUsageByRepository,
    "ActionsCreateOrUpdateEnvironmentSecretRequest": ActionsCreateOrUpdateEnvironmentSecretRequest,
    "ActionsCreateOrUpdateOrgSecretRequest": ActionsCreateOrUpdateOrgSecretRequest,
    "ActionsCreateOrUpdateRepoSecretRequest": ActionsCreateOrUpdateRepoSecretRequest,
    "ActionsCreateSelfHostedRunnerGroupForOrgRequest": ActionsCreateSelfHostedRunnerGroupForOrgRequest,
    "ActionsCreateWorkflowDispatchRequest": ActionsCreateWorkflowDispatchRequest,
    "ActionsGetActionsCacheUsageByRepoForOrg200Response": ActionsGetActionsCacheUsageByRepoForOrg200Response,
    "ActionsGetActionsCacheUsageForEnterprise200Response": ActionsGetActionsCacheUsageForEnterprise200Response,
    "ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response": ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response,
    "ActionsGetGithubActionsPermissionsOrganization200Response": ActionsGetGithubActionsPermissionsOrganization200Response,
    "ActionsGetGithubActionsPermissionsRepository200Response": ActionsGetGithubActionsPermissionsRepository200Response,
    "ActionsGetWorkflowAccessToRepository200Response": ActionsGetWorkflowAccessToRepository200Response,
    "ActionsGetWorkflowWorkflowIdParameter": ActionsGetWorkflowWorkflowIdParameter,
    "ActionsListArtifactsForRepo200Response": ActionsListArtifactsForRepo200Response,
    "ActionsListJobsForWorkflowRunAttempt200Response": ActionsListJobsForWorkflowRunAttempt200Response,
    "ActionsListOrgSecrets200Response": ActionsListOrgSecrets200Response,
    "ActionsListRepoAccessToSelfHostedRunnerGroupInOrg200Response": ActionsListRepoAccessToSelfHostedRunnerGroupInOrg200Response,
    "ActionsListRepoSecrets200Response": ActionsListRepoSecrets200Response,
    "ActionsListRepoWorkflows200Response": ActionsListRepoWorkflows200Response,
    "ActionsListSelectedReposForOrgSecret200Response": ActionsListSelectedReposForOrgSecret200Response,
    "ActionsListSelectedRepositoriesEnabledGithubActionsOrganization200Response": ActionsListSelectedRepositoriesEnabledGithubActionsOrganization200Response,
    "ActionsListSelfHostedRunnerGroupsForOrg200Response": ActionsListSelfHostedRunnerGroupsForOrg200Response,
    "ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner": ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner,
    "ActionsListSelfHostedRunnersForOrg200Response": ActionsListSelfHostedRunnersForOrg200Response,
    "ActionsListWorkflowRunsForRepo200Response": ActionsListWorkflowRunsForRepo200Response,
    "ActionsOIDCSubjectCustomization": ActionsOIDCSubjectCustomization,
    "ActionsPublicKey": ActionsPublicKey,
    "ActionsReRunJobForWorkflowRunRequest": ActionsReRunJobForWorkflowRunRequest,
    "ActionsReviewPendingDeploymentsForRunRequest": ActionsReviewPendingDeploymentsForRunRequest,
    "ActionsSecret": ActionsSecret,
    "ActionsSecretForAnOrganization": ActionsSecretForAnOrganization,
    "ActionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest": ActionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest,
    "ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest": ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest,
    "ActionsSetGithubActionsPermissionsOrganizationRequest": ActionsSetGithubActionsPermissionsOrganizationRequest,
    "ActionsSetGithubActionsPermissionsRepositoryRequest": ActionsSetGithubActionsPermissionsRepositoryRequest,
    "ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest": ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest,
    "ActionsSetSelectedReposForOrgSecretRequest": ActionsSetSelectedReposForOrgSecretRequest,
    "ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest": ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest,
    "ActionsUpdateSelfHostedRunnerGroupForOrgRequest": ActionsUpdateSelfHostedRunnerGroupForOrgRequest,
    "ActivityListReposStarredByUser200Response": ActivityListReposStarredByUser200Response,
    "ActivityListStargazersForRepo200Response": ActivityListStargazersForRepo200Response,
    "ActivityMarkNotificationsAsRead202Response": ActivityMarkNotificationsAsRead202Response,
    "ActivityMarkNotificationsAsReadRequest": ActivityMarkNotificationsAsReadRequest,
    "ActivityMarkRepoNotificationsAsRead202Response": ActivityMarkRepoNotificationsAsRead202Response,
    "ActivityMarkRepoNotificationsAsReadRequest": ActivityMarkRepoNotificationsAsReadRequest,
    "ActivitySetRepoSubscriptionRequest": ActivitySetRepoSubscriptionRequest,
    "ActivitySetThreadSubscriptionRequest": ActivitySetThreadSubscriptionRequest,
    "Actor": Actor,
    "AddedToProjectIssueEvent": AddedToProjectIssueEvent,
    "AddedToProjectIssueEventProjectCard": AddedToProjectIssueEventProjectCard,
    "AnalysisDeletion": AnalysisDeletion,
    "ApiOverview": ApiOverview,
    "ApiOverviewSshKeyFingerprints": ApiOverviewSshKeyFingerprints,
    "AppPermissions": AppPermissions,
    "AppsCheckTokenRequest": AppsCheckTokenRequest,
    "AppsCreateFromManifest201Response": AppsCreateFromManifest201Response,
    "AppsCreateFromManifest201ResponseAllOf": AppsCreateFromManifest201ResponseAllOf,
    "AppsCreateInstallationAccessTokenRequest": AppsCreateInstallationAccessTokenRequest,
    "AppsDeleteAuthorizationRequest": AppsDeleteAuthorizationRequest,
    "AppsListInstallationReposForAuthenticatedUser200Response": AppsListInstallationReposForAuthenticatedUser200Response,
    "AppsListReposAccessibleToInstallation200Response": AppsListReposAccessibleToInstallation200Response,
    "AppsScopeTokenRequest": AppsScopeTokenRequest,
    "AppsUpdateWebhookConfigForAppRequest": AppsUpdateWebhookConfigForAppRequest,
    "Artifact": Artifact,
    "ArtifactWorkflowRun": ArtifactWorkflowRun,
    "AssignedIssueEvent": AssignedIssueEvent,
    "AuthenticationToken": AuthenticationToken,
    "Authorization": Authorization,
    "AuthorizationApp": AuthorizationApp,
    "AutoMerge": AutoMerge,
    "AutolinkReference": AutolinkReference,
    "BaseGist": BaseGist,
    "BaseGistFilesValue": BaseGistFilesValue,
    "BasicError": BasicError,
    "BillingGetGithubActionsBillingGhe200Response": BillingGetGithubActionsBillingGhe200Response,
    "BillingGetGithubActionsBillingGhe200ResponseMinutesUsedBreakdown": BillingGetGithubActionsBillingGhe200ResponseMinutesUsedBreakdown,
    "BillingGetGithubAdvancedSecurityBillingGhe200Response": BillingGetGithubAdvancedSecurityBillingGhe200Response,
    "BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInner": BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInner,
    "BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInnerAdvancedSecurityCommittersBreakdownInner": BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInnerAdvancedSecurityCommittersBreakdownInner,
    "BillingGetGithubPackagesBillingGhe200Response": BillingGetGithubPackagesBillingGhe200Response,
    "BillingGetSharedStorageBillingGhe200Response": BillingGetSharedStorageBillingGhe200Response,
    "Blob": Blob,
    "BranchProtection": BranchProtection,
    "BranchProtectionRequiredLinearHistory": BranchProtectionRequiredLinearHistory,
    "BranchProtectionRequiredSignatures": BranchProtectionRequiredSignatures,
    "BranchRestrictionPolicy": BranchRestrictionPolicy,
    "BranchRestrictionPolicyAppsInner": BranchRestrictionPolicyAppsInner,
    "BranchRestrictionPolicyAppsInnerOwner": BranchRestrictionPolicyAppsInnerOwner,
    "BranchRestrictionPolicyAppsInnerPermissions": BranchRestrictionPolicyAppsInnerPermissions,
    "BranchRestrictionPolicyTeamsInner": BranchRestrictionPolicyTeamsInner,
    "BranchShort": BranchShort,
    "BranchShortCommit": BranchShortCommit,
    "BranchWithProtection": BranchWithProtection,
    "BranchWithProtectionLinks": BranchWithProtectionLinks,
    "CODEOWNERSErrors": CODEOWNERSErrors,
    "CODEOWNERSErrorsErrorsInner": CODEOWNERSErrorsErrorsInner,
    "CheckAnnotation": CheckAnnotation,
    "CheckRun": CheckRun,
    "CheckRunCheckSuite": CheckRunCheckSuite,
    "CheckRunOutput": CheckRunOutput,
    "CheckSuite": CheckSuite,
    "CheckSuitePreference": CheckSuitePreference,
    "CheckSuitePreferencePreferences": CheckSuitePreferencePreferences,
    "CheckSuitePreferencePreferencesAutoTriggerChecksInner": CheckSuitePreferencePreferencesAutoTriggerChecksInner,
    "ChecksCreateRequest": ChecksCreateRequest,
    "ChecksCreateRequestActionsInner": ChecksCreateRequestActionsInner,
    "ChecksCreateRequestOneOf": ChecksCreateRequestOneOf,
    "ChecksCreateRequestOneOf1": ChecksCreateRequestOneOf1,
    "ChecksCreateRequestOutput": ChecksCreateRequestOutput,
    "ChecksCreateRequestOutputAnnotationsInner": ChecksCreateRequestOutputAnnotationsInner,
    "ChecksCreateRequestOutputImagesInner": ChecksCreateRequestOutputImagesInner,
    "ChecksCreateSuiteRequest": ChecksCreateSuiteRequest,
    "ChecksListForSuite200Response": ChecksListForSuite200Response,
    "ChecksListSuitesForRef200Response": ChecksListSuitesForRef200Response,
    "ChecksSetSuitesPreferencesRequest": ChecksSetSuitesPreferencesRequest,
    "ChecksSetSuitesPreferencesRequestAutoTriggerChecksInner": ChecksSetSuitesPreferencesRequestAutoTriggerChecksInner,
    "ChecksUpdateRequest": ChecksUpdateRequest,
    "ChecksUpdateRequestAnyOf": ChecksUpdateRequestAnyOf,
    "ChecksUpdateRequestOutput": ChecksUpdateRequestOutput,
    "CloneTraffic": CloneTraffic,
    "CodeOfConduct": CodeOfConduct,
    "CodeOfConductSimple": CodeOfConductSimple,
    "CodeOfConductSimple1": CodeOfConductSimple1,
    "CodeScanningGetAlert200Response": CodeScanningGetAlert200Response,
    "CodeScanningGetSarif200Response": CodeScanningGetSarif200Response,
    "CodeScanningListAlertsForEnterprise200ResponseInner": CodeScanningListAlertsForEnterprise200ResponseInner,
    "CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance": CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance,
    "CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstanceLocation": CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstanceLocation,
    "CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstanceMessage": CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstanceMessage,
    "CodeScanningListAlertsForEnterprise200ResponseInnerRule": CodeScanningListAlertsForEnterprise200ResponseInnerRule,
    "CodeScanningListAlertsForEnterprise200ResponseInnerTool": CodeScanningListAlertsForEnterprise200ResponseInnerTool,
    "CodeScanningListAlertsForEnterprise503Response": CodeScanningListAlertsForEnterprise503Response,
    "CodeScanningListAlertsForRepo200ResponseInner": CodeScanningListAlertsForRepo200ResponseInner,
    "CodeScanningListAlertsForRepo200ResponseInnerRule": CodeScanningListAlertsForRepo200ResponseInnerRule,
    "CodeScanningListRecentAnalyses200ResponseInner": CodeScanningListRecentAnalyses200ResponseInner,
    "CodeScanningUpdateAlertRequest": CodeScanningUpdateAlertRequest,
    "CodeScanningUploadSarif202Response": CodeScanningUploadSarif202Response,
    "CodeScanningUploadSarifRequest": CodeScanningUploadSarifRequest,
    "CodeSearchResultItem": CodeSearchResultItem,
    "Codespace": Codespace,
    "CodespaceGitStatus": CodespaceGitStatus,
    "CodespaceMachine": CodespaceMachine,
    "CodespaceMachine1": CodespaceMachine1,
    "CodespaceRuntimeConstraints": CodespaceRuntimeConstraints,
    "CodespacesCreateForAuthenticatedUserRequest": CodespacesCreateForAuthenticatedUserRequest,
    "CodespacesCreateForAuthenticatedUserRequestOneOf": CodespacesCreateForAuthenticatedUserRequestOneOf,
    "CodespacesCreateForAuthenticatedUserRequestOneOf1": CodespacesCreateForAuthenticatedUserRequestOneOf1,
    "CodespacesCreateForAuthenticatedUserRequestOneOf1PullRequest": CodespacesCreateForAuthenticatedUserRequestOneOf1PullRequest,
    "CodespacesCreateOrUpdateRepoSecretRequest": CodespacesCreateOrUpdateRepoSecretRequest,
    "CodespacesCreateOrUpdateSecretForAuthenticatedUserRequest": CodespacesCreateOrUpdateSecretForAuthenticatedUserRequest,
    "CodespacesCreateWithPrForAuthenticatedUserRequest": CodespacesCreateWithPrForAuthenticatedUserRequest,
    "CodespacesCreateWithRepoForAuthenticatedUserRequest": CodespacesCreateWithRepoForAuthenticatedUserRequest,
    "CodespacesListDevcontainersInRepositoryForAuthenticatedUser200Response": CodespacesListDevcontainersInRepositoryForAuthenticatedUser200Response,
    "CodespacesListDevcontainersInRepositoryForAuthenticatedUser200ResponseDevcontainersInner": CodespacesListDevcontainersInRepositoryForAuthenticatedUser200ResponseDevcontainersInner,
    "CodespacesListInOrganization200Response": CodespacesListInOrganization200Response,
    "CodespacesListRepoSecrets200Response": CodespacesListRepoSecrets200Response,
    "CodespacesListSecretsForAuthenticatedUser200Response": CodespacesListSecretsForAuthenticatedUser200Response,
    "CodespacesPreFlightWithRepoForAuthenticatedUser200Response": CodespacesPreFlightWithRepoForAuthenticatedUser200Response,
    "CodespacesPreFlightWithRepoForAuthenticatedUser200ResponseDefaults": CodespacesPreFlightWithRepoForAuthenticatedUser200ResponseDefaults,
    "CodespacesPublicKey": CodespacesPublicKey,
    "CodespacesRepoMachinesForAuthenticatedUser200Response": CodespacesRepoMachinesForAuthenticatedUser200Response,
    "CodespacesSecret": CodespacesSecret,
    "CodespacesSecret1": CodespacesSecret1,
    "CodespacesSetRepositoriesForSecretForAuthenticatedUserRequest": CodespacesSetRepositoriesForSecretForAuthenticatedUserRequest,
    "CodespacesUpdateForAuthenticatedUserRequest": CodespacesUpdateForAuthenticatedUserRequest,
    "CodespacesUserPublicKey": CodespacesUserPublicKey,
    "Collaborator": Collaborator,
    "Collaborator1": Collaborator1,
    "CollaboratorPermissions": CollaboratorPermissions,
    "CombinedCommitStatus": CombinedCommitStatus,
    "Commit": Commit,
    "CommitActivity": CommitActivity,
    "CommitComment": CommitComment,
    "CommitCommit": CommitCommit,
    "CommitCommitTree": CommitCommitTree,
    "CommitComparison": CommitComparison,
    "CommitParentsInner": CommitParentsInner,
    "CommitSearchResultItem": CommitSearchResultItem,
    "CommitSearchResultItemCommit": CommitSearchResultItemCommit,
    "CommitSearchResultItemCommitAuthor": CommitSearchResultItemCommitAuthor,
    "CommitStats": CommitStats,
    "CommunityHealthFile": CommunityHealthFile,
    "CommunityProfile": CommunityProfile,
    "CommunityProfileFiles": CommunityProfileFiles,
    "ContainerMetadata": ContainerMetadata,
    "ContentFile": ContentFile,
    "ContentTraffic": ContentTraffic,
    "ContentTree": ContentTree,
    "ContentTreeEntriesInner": ContentTreeEntriesInner,
    "ContentTreeEntriesInnerLinks": ContentTreeEntriesInnerLinks,
    "Contributor": Contributor,
    "ContributorActivity": ContributorActivity,
    "ContributorActivityWeeksInner": ContributorActivityWeeksInner,
    "ConvertedNoteToIssueIssueEvent": ConvertedNoteToIssueIssueEvent,
    "CredentialAuthorization": CredentialAuthorization,
    "DemilestonedIssueEvent": DemilestonedIssueEvent,
    "DependabotCreateOrUpdateOrgSecretRequest": DependabotCreateOrUpdateOrgSecretRequest,
    "DependabotCreateOrUpdateRepoSecretRequest": DependabotCreateOrUpdateRepoSecretRequest,
    "DependabotListOrgSecrets200Response": DependabotListOrgSecrets200Response,
    "DependabotListRepoSecrets200Response": DependabotListRepoSecrets200Response,
    "DependabotPublicKey": DependabotPublicKey,
    "DependabotSecret": DependabotSecret,
    "DependabotSecretForAnOrganization": DependabotSecretForAnOrganization,
    "DependabotSetSelectedReposForOrgSecretRequest": DependabotSetSelectedReposForOrgSecretRequest,
    "DependencyGraphCreateRepositorySnapshot201Response": DependencyGraphCreateRepositorySnapshot201Response,
    "DependencyGraphDiffInner": DependencyGraphDiffInner,
    "DependencyGraphDiffInnerVulnerabilitiesInner": DependencyGraphDiffInnerVulnerabilitiesInner,
    "DeployKey": DeployKey,
    "Deployment": Deployment,
    "Deployment1": Deployment1,
    "DeploymentPayload": DeploymentPayload,
    "DeploymentStatus": DeploymentStatus,
    "DiffEntry": DiffEntry,
    "DockerMetadata": DockerMetadata,
    "Email": Email,
    "Enterprise": Enterprise,
    "EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest": EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest,
    "EnterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest": EnterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest,
    "EnterpriseAdminGetAllowedActionsEnterprise200Response": EnterpriseAdminGetAllowedActionsEnterprise200Response,
    "EnterpriseAdminGetAuditLog200ResponseInner": EnterpriseAdminGetAuditLog200ResponseInner,
    "EnterpriseAdminGetAuditLog200ResponseInnerActorLocation": EnterpriseAdminGetAuditLog200ResponseInnerActorLocation,
    "EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response": EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response,
    "EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response": EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response,
    "EnterpriseAdminListProvisionedGroupsEnterprise200Response": EnterpriseAdminListProvisionedGroupsEnterprise200Response,
    "EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner": EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner,
    "EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMembersInner": EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMembersInner,
    "EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMeta": EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMeta,
    "EnterpriseAdminListProvisionedIdentitiesEnterprise200Response": EnterpriseAdminListProvisionedIdentitiesEnterprise200Response,
    "EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInner": EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInner,
    "EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerEmailsInner": EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerEmailsInner,
    "EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerGroupsInner": EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerGroupsInner,
    "EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerName": EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerName,
    "EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response": EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response,
    "EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200Response": EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200Response,
    "EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner": EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner,
    "EnterpriseAdminListSelfHostedRunnersForEnterprise200Response": EnterpriseAdminListSelfHostedRunnersForEnterprise200Response,
    "EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response": EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response,
    "EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest": EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest,
    "EnterpriseAdminProvisionAndInviteEnterpriseGroupRequestMembersInner": EnterpriseAdminProvisionAndInviteEnterpriseGroupRequestMembersInner,
    "EnterpriseAdminProvisionAndInviteEnterpriseUser201Response": EnterpriseAdminProvisionAndInviteEnterpriseUser201Response,
    "EnterpriseAdminProvisionAndInviteEnterpriseUser201ResponseEmailsInner": EnterpriseAdminProvisionAndInviteEnterpriseUser201ResponseEmailsInner,
    "EnterpriseAdminProvisionAndInviteEnterpriseUserRequest": EnterpriseAdminProvisionAndInviteEnterpriseUserRequest,
    "EnterpriseAdminProvisionAndInviteEnterpriseUserRequestEmailsInner": EnterpriseAdminProvisionAndInviteEnterpriseUserRequestEmailsInner,
    "EnterpriseAdminProvisionAndInviteEnterpriseUserRequestName": EnterpriseAdminProvisionAndInviteEnterpriseUserRequestName,
    "EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest": EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest,
    "EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest": EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest,
    "EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest": EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest,
    "EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest": EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest,
    "EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest": EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest,
    "EnterpriseAdminUpdateAttributeForEnterpriseGroupRequest": EnterpriseAdminUpdateAttributeForEnterpriseGroupRequest,
    "EnterpriseAdminUpdateAttributeForEnterpriseGroupRequestOperationsInner": EnterpriseAdminUpdateAttributeForEnterpriseGroupRequestOperationsInner,
    "EnterpriseAdminUpdateAttributeForEnterpriseUserRequest": EnterpriseAdminUpdateAttributeForEnterpriseUserRequest,
    "EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest": EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest,
    "Environment": Environment,
    "EnvironmentApproval": EnvironmentApproval,
    "EnvironmentApprovalEnvironmentsInner": EnvironmentApprovalEnvironmentsInner,
    "EnvironmentDeploymentBranchPolicy": EnvironmentDeploymentBranchPolicy,
    "EnvironmentProtectionRulesInner": EnvironmentProtectionRulesInner,
    "EnvironmentProtectionRulesInnerAnyOf": EnvironmentProtectionRulesInnerAnyOf,
    "EnvironmentProtectionRulesInnerAnyOf1": EnvironmentProtectionRulesInnerAnyOf1,
    "EnvironmentProtectionRulesInnerAnyOf2": EnvironmentProtectionRulesInnerAnyOf2,
    "Event": Event,
    "EventPayload": EventPayload,
    "EventPayloadPagesInner": EventPayloadPagesInner,
    "EventRepo": EventRepo,
    "ExternalGroup": ExternalGroup,
    "ExternalGroupMembersInner": ExternalGroupMembersInner,
    "ExternalGroupTeamsInner": ExternalGroupTeamsInner,
    "ExternalGroups": ExternalGroups,
    "ExternalGroupsGroupsInner": ExternalGroupsGroupsInner,
    "Feed": Feed,
    "FeedLinks": FeedLinks,
    "FetchesInformationAboutAnExportOfACodespace": FetchesInformationAboutAnExportOfACodespace,
    "FileCommit": FileCommit,
    "FileCommitCommit": FileCommitCommit,
    "FileCommitCommitAuthor": FileCommitCommitAuthor,
    "FileCommitCommitParentsInner": FileCommitCommitParentsInner,
    "FileCommitCommitTree": FileCommitCommitTree,
    "FileCommitCommitVerification": FileCommitCommitVerification,
    "FileCommitContent": FileCommitContent,
    "FileCommitContentLinks": FileCommitContentLinks,
    "FullRepository": FullRepository,
    "FullRepositoryPermissions": FullRepositoryPermissions,
    "FullRepositorySecurityAndAnalysis": FullRepositorySecurityAndAnalysis,
    "FullRepositorySecurityAndAnalysisAdvancedSecurity": FullRepositorySecurityAndAnalysisAdvancedSecurity,
    "FullTeam": FullTeam,
    "GPGKey": GPGKey,
    "GPGKeyEmailsInner": GPGKeyEmailsInner,
    "GPGKeySubkeysInner": GPGKeySubkeysInner,
    "GeneratedReleaseNotesContent": GeneratedReleaseNotesContent,
    "Gist": Gist,
    "GistComment": GistComment,
    "GistCommit": GistCommit,
    "GistHistory": GistHistory,
    "GistHistoryChangeStatus": GistHistoryChangeStatus,
    "GistSimple": GistSimple,
    "GistSimpleFilesValue": GistSimpleFilesValue,
    "GistSimpleForksInner": GistSimpleForksInner,
    "GistsCreateCommentRequest": GistsCreateCommentRequest,
    "GistsCreateRequest": GistsCreateRequest,
    "GistsCreateRequestFilesValue": GistsCreateRequestFilesValue,
    "GistsCreateRequestPublic": GistsCreateRequestPublic,
    "GistsGet403Response": GistsGet403Response,
    "GistsGet403ResponseBlock": GistsGet403ResponseBlock,
    "GistsUpdateRequest": GistsUpdateRequest,
    "GistsUpdateRequestFilesValue": GistsUpdateRequestFilesValue,
    "GitCommit": GitCommit,
    "GitCommitAuthor": GitCommitAuthor,
    "GitCommitParentsInner": GitCommitParentsInner,
    "GitCommitTree": GitCommitTree,
    "GitCommitVerification": GitCommitVerification,
    "GitCreateBlobRequest": GitCreateBlobRequest,
    "GitCreateCommitRequest": GitCreateCommitRequest,
    "GitCreateCommitRequestAuthor": GitCreateCommitRequestAuthor,
    "GitCreateCommitRequestCommitter": GitCreateCommitRequestCommitter,
    "GitCreateRefRequest": GitCreateRefRequest,
    "GitCreateTagRequest": GitCreateTagRequest,
    "GitCreateTagRequestTagger": GitCreateTagRequestTagger,
    "GitCreateTreeRequest": GitCreateTreeRequest,
    "GitCreateTreeRequestTreeInner": GitCreateTreeRequestTreeInner,
    "GitHubApp": GitHubApp,
    "GitHubApp1": GitHubApp1,
    "GitHubAppPermissions": GitHubAppPermissions,
    "GitHubPages": GitHubPages,
    "GitHubPages1": GitHubPages1,
    "GitReference": GitReference,
    "GitReferenceObject": GitReferenceObject,
    "GitTag": GitTag,
    "GitTagObject": GitTagObject,
    "GitTagTagger": GitTagTagger,
    "GitTree": GitTree,
    "GitTreeTreeInner": GitTreeTreeInner,
    "GitUpdateRefRequest": GitUpdateRefRequest,
    "GitUser": GitUser,
    "GitignoreTemplate": GitignoreTemplate,
    "GroupMapping": GroupMapping,
    "GroupMappingGroupsInner": GroupMappingGroupsInner,
    "HookResponse": HookResponse,
    "Hovercard": Hovercard,
    "HovercardContextsInner": HovercardContextsInner,
    "Import": Import,
    "ImportProjectChoicesInner": ImportProjectChoicesInner,
    "Installation": Installation,
    "InstallationAccount": InstallationAccount,
    "InstallationToken": InstallationToken,
    "InteractionLimits": InteractionLimits,
    "InteractionRestrictions": InteractionRestrictions,
    "InteractionsGetRestrictionsForOrg200Response": InteractionsGetRestrictionsForOrg200Response,
    "Issue": Issue,
    "Issue1": Issue1,
    "IssueComment": IssueComment,
    "IssueEvent": IssueEvent,
    "IssueEventDismissedReview": IssueEventDismissedReview,
    "IssueEventForIssue": IssueEventForIssue,
    "IssueEventLabel": IssueEventLabel,
    "IssueEventMilestone": IssueEventMilestone,
    "IssueEventProjectCard": IssueEventProjectCard,
    "IssueEventRename": IssueEventRename,
    "IssueLabelsInner": IssueLabelsInner,
    "IssueLabelsInnerOneOf": IssueLabelsInnerOneOf,
    "IssuePullRequest": IssuePullRequest,
    "IssueSearchResultItem": IssueSearchResultItem,
    "IssueSearchResultItemLabelsInner": IssueSearchResultItemLabelsInner,
    "IssuesAddAssigneesRequest": IssuesAddAssigneesRequest,
    "IssuesAddLabelsRequest": IssuesAddLabelsRequest,
    "IssuesAddLabelsRequestOneOf": IssuesAddLabelsRequestOneOf,
    "IssuesCreateLabelRequest": IssuesCreateLabelRequest,
    "IssuesCreateMilestoneRequest": IssuesCreateMilestoneRequest,
    "IssuesCreateRequest": IssuesCreateRequest,
    "IssuesCreateRequestLabelsInner": IssuesCreateRequestLabelsInner,
    "IssuesCreateRequestLabelsInnerOneOf": IssuesCreateRequestLabelsInnerOneOf,
    "IssuesCreateRequestMilestone": IssuesCreateRequestMilestone,
    "IssuesCreateRequestTitle": IssuesCreateRequestTitle,
    "IssuesLockRequest": IssuesLockRequest,
    "IssuesRemoveAssigneesRequest": IssuesRemoveAssigneesRequest,
    "IssuesSetLabelsRequest": IssuesSetLabelsRequest,
    "IssuesSetLabelsRequestOneOf": IssuesSetLabelsRequestOneOf,
    "IssuesSetLabelsRequestOneOf1": IssuesSetLabelsRequestOneOf1,
    "IssuesSetLabelsRequestOneOf1LabelsInner": IssuesSetLabelsRequestOneOf1LabelsInner,
    "IssuesUpdateCommentRequest": IssuesUpdateCommentRequest,
    "IssuesUpdateLabelRequest": IssuesUpdateLabelRequest,
    "IssuesUpdateMilestoneRequest": IssuesUpdateMilestoneRequest,
    "IssuesUpdateRequest": IssuesUpdateRequest,
    "IssuesUpdateRequestMilestone": IssuesUpdateRequestMilestone,
    "IssuesUpdateRequestTitle": IssuesUpdateRequestTitle,
    "Job": Job,
    "JobStepsInner": JobStepsInner,
    "Key": Key,
    "KeySimple": KeySimple,
    "Label": Label,
    "LabelSearchResultItem": LabelSearchResultItem,
    "LabeledIssueEvent": LabeledIssueEvent,
    "LabeledIssueEventLabel": LabeledIssueEventLabel,
    "LegacyReviewComment": LegacyReviewComment,
    "LegacyReviewCommentLinks": LegacyReviewCommentLinks,
    "License": License,
    "LicenseContent": LicenseContent,
    "LicenseSimple": LicenseSimple,
    "LicenseSimple1": LicenseSimple1,
    "Link": Link,
    "LinkWithType": LinkWithType,
    "LockedIssueEvent": LockedIssueEvent,
    "MarkdownRenderRequest": MarkdownRenderRequest,
    "MarketplaceAccount": MarketplaceAccount,
    "MarketplaceListingPlan": MarketplaceListingPlan,
    "MarketplacePurchase": MarketplacePurchase,
    "MarketplacePurchaseMarketplacePendingChange": MarketplacePurchaseMarketplacePendingChange,
    "MarketplacePurchaseMarketplacePurchase": MarketplacePurchaseMarketplacePurchase,
    "MergedUpstream": MergedUpstream,
    "MetaRoot200Response": MetaRoot200Response,
    "Metadata": Metadata,
    "Migration": Migration,
    "MigrationsMapCommitAuthorRequest": MigrationsMapCommitAuthorRequest,
    "MigrationsSetLfsPreferenceRequest": MigrationsSetLfsPreferenceRequest,
    "MigrationsStartForAuthenticatedUserRequest": MigrationsStartForAuthenticatedUserRequest,
    "MigrationsStartForOrgRequest": MigrationsStartForOrgRequest,
    "MigrationsStartImportRequest": MigrationsStartImportRequest,
    "MigrationsUpdateImportRequest": MigrationsUpdateImportRequest,
    "Milestone": Milestone,
    "Milestone1": Milestone1,
    "MilestonedIssueEvent": MilestonedIssueEvent,
    "MilestonedIssueEventMilestone": MilestonedIssueEventMilestone,
    "MinimalRepository": MinimalRepository,
    "MinimalRepository1": MinimalRepository1,
    "MinimalRepositoryLicense": MinimalRepositoryLicense,
    "MovedColumnInProjectIssueEvent": MovedColumnInProjectIssueEvent,
    "OrgHook": OrgHook,
    "OrgHookConfig": OrgHookConfig,
    "OrgMembership": OrgMembership,
    "OrgMembershipPermissions": OrgMembershipPermissions,
    "OrganizationCustomRepositoryRole": OrganizationCustomRepositoryRole,
    "OrganizationFull": OrganizationFull,
    "OrganizationFullPlan": OrganizationFullPlan,
    "OrganizationInvitation": OrganizationInvitation,
    "OrganizationSimple": OrganizationSimple,
    "OrgsConvertMemberToOutsideCollaboratorRequest": OrgsConvertMemberToOutsideCollaboratorRequest,
    "OrgsCreateInvitationRequest": OrgsCreateInvitationRequest,
    "OrgsCreateWebhookRequest": OrgsCreateWebhookRequest,
    "OrgsCreateWebhookRequestConfig": OrgsCreateWebhookRequestConfig,
    "OrgsListAppInstallations200Response": OrgsListAppInstallations200Response,
    "OrgsListCustomRoles200Response": OrgsListCustomRoles200Response,
    "OrgsRemoveOutsideCollaborator422Response": OrgsRemoveOutsideCollaborator422Response,
    "OrgsSetMembershipForUserRequest": OrgsSetMembershipForUserRequest,
    "OrgsUpdate422Response": OrgsUpdate422Response,
    "OrgsUpdateMembershipForAuthenticatedUserRequest": OrgsUpdateMembershipForAuthenticatedUserRequest,
    "OrgsUpdateRequest": OrgsUpdateRequest,
    "OrgsUpdateWebhookRequest": OrgsUpdateWebhookRequest,
    "OrgsUpdateWebhookRequestConfig": OrgsUpdateWebhookRequestConfig,
    "Package": Package,
    "PackageVersion": PackageVersion,
    "PackageVersionMetadata": PackageVersionMetadata,
    "PageBuild": PageBuild,
    "PageBuildError": PageBuildError,
    "PageBuildStatus": PageBuildStatus,
    "PagesHealthCheckStatus": PagesHealthCheckStatus,
    "PagesHealthCheckStatusAltDomain": PagesHealthCheckStatusAltDomain,
    "PagesHealthCheckStatusDomain": PagesHealthCheckStatusDomain,
    "PagesHttpsCertificate": PagesHttpsCertificate,
    "PagesSourceHash": PagesSourceHash,
    "ParticipationStats": ParticipationStats,
    "PendingDeployment": PendingDeployment,
    "PendingDeploymentEnvironment": PendingDeploymentEnvironment,
    "PendingDeploymentReviewersInner": PendingDeploymentReviewersInner,
    "PendingDeploymentReviewersInnerReviewer": PendingDeploymentReviewersInnerReviewer,
    "PorterAuthor": PorterAuthor,
    "PorterLargeFile": PorterLargeFile,
    "PrivateUser": PrivateUser,
    "Project": Project,
    "ProjectCard": ProjectCard,
    "ProjectCollaboratorPermission": ProjectCollaboratorPermission,
    "ProjectColumn": ProjectColumn,
    "ProjectsAddCollaboratorRequest": ProjectsAddCollaboratorRequest,
    "ProjectsCreateCardRequest": ProjectsCreateCardRequest,
    "ProjectsCreateCardRequestOneOf": ProjectsCreateCardRequestOneOf,
    "ProjectsCreateCardRequestOneOf1": ProjectsCreateCardRequestOneOf1,
    "ProjectsCreateForAuthenticatedUserRequest": ProjectsCreateForAuthenticatedUserRequest,
    "ProjectsCreateForOrgRequest": ProjectsCreateForOrgRequest,
    "ProjectsDeleteCard403Response": ProjectsDeleteCard403Response,
    "ProjectsMoveCard403Response": ProjectsMoveCard403Response,
    "ProjectsMoveCard403ResponseErrorsInner": ProjectsMoveCard403ResponseErrorsInner,
    "ProjectsMoveCard503Response": ProjectsMoveCard503Response,
    "ProjectsMoveCard503ResponseErrorsInner": ProjectsMoveCard503ResponseErrorsInner,
    "ProjectsMoveCardRequest": ProjectsMoveCardRequest,
    "ProjectsMoveColumnRequest": ProjectsMoveColumnRequest,
    "ProjectsUpdateCardRequest": ProjectsUpdateCardRequest,
    "ProjectsUpdateColumnRequest": ProjectsUpdateColumnRequest,
    "ProjectsUpdateRequest": ProjectsUpdateRequest,
    "ProtectedBranch": ProtectedBranch,
    "ProtectedBranchAdminEnforced": ProtectedBranchAdminEnforced,
    "ProtectedBranchEnforceAdmins": ProtectedBranchEnforceAdmins,
    "ProtectedBranchPullRequestReview": ProtectedBranchPullRequestReview,
    "ProtectedBranchPullRequestReviewBypassPullRequestAllowances": ProtectedBranchPullRequestReviewBypassPullRequestAllowances,
    "ProtectedBranchPullRequestReviewDismissalRestrictions": ProtectedBranchPullRequestReviewDismissalRestrictions,
    "ProtectedBranchRequiredConversationResolution": ProtectedBranchRequiredConversationResolution,
    "ProtectedBranchRequiredLinearHistory": ProtectedBranchRequiredLinearHistory,
    "ProtectedBranchRequiredPullRequestReviews": ProtectedBranchRequiredPullRequestReviews,
    "ProtectedBranchRequiredPullRequestReviewsBypassPullRequestAllowances": ProtectedBranchRequiredPullRequestReviewsBypassPullRequestAllowances,
    "ProtectedBranchRequiredPullRequestReviewsDismissalRestrictions": ProtectedBranchRequiredPullRequestReviewsDismissalRestrictions,
    "ProtectedBranchRequiredStatusCheck": ProtectedBranchRequiredStatusCheck,
    "ProtectedBranchRequiredStatusCheckChecksInner": ProtectedBranchRequiredStatusCheckChecksInner,
    "PublicUser": PublicUser,
    "PublicUserPlan": PublicUserPlan,
    "PullRequest": PullRequest,
    "PullRequestBase": PullRequestBase,
    "PullRequestBaseRepo": PullRequestBaseRepo,
    "PullRequestHead": PullRequestHead,
    "PullRequestHeadRepo": PullRequestHeadRepo,
    "PullRequestHeadRepoLicense": PullRequestHeadRepoLicense,
    "PullRequestHeadRepoOwner": PullRequestHeadRepoOwner,
    "PullRequestLabelsInner": PullRequestLabelsInner,
    "PullRequestMergeResult": PullRequestMergeResult,
    "PullRequestMinimal": PullRequestMinimal,
    "PullRequestMinimalHead": PullRequestMinimalHead,
    "PullRequestMinimalHeadRepo": PullRequestMinimalHeadRepo,
    "PullRequestReview": PullRequestReview,
    "PullRequestReviewComment": PullRequestReviewComment,
    "PullRequestReviewCommentLinks": PullRequestReviewCommentLinks,
    "PullRequestReviewCommentLinksHtml": PullRequestReviewCommentLinksHtml,
    "PullRequestReviewCommentLinksPullRequest": PullRequestReviewCommentLinksPullRequest,
    "PullRequestReviewCommentLinksSelf": PullRequestReviewCommentLinksSelf,
    "PullRequestReviewRequest": PullRequestReviewRequest,
    "PullRequestSimple": PullRequestSimple,
    "PullRequestSimpleHead": PullRequestSimpleHead,
    "PullRequestSimpleLabelsInner": PullRequestSimpleLabelsInner,
    "PullRequestSimpleLinks": PullRequestSimpleLinks,
    "PullsCreateReplyForReviewCommentRequest": PullsCreateReplyForReviewCommentRequest,
    "PullsCreateRequest": PullsCreateRequest,
    "PullsCreateReviewCommentRequest": PullsCreateReviewCommentRequest,
    "PullsCreateReviewRequest": PullsCreateReviewRequest,
    "PullsCreateReviewRequestCommentsInner": PullsCreateReviewRequestCommentsInner,
    "PullsDismissReviewRequest": PullsDismissReviewRequest,
    "PullsMergeRequest": PullsMergeRequest,
    "PullsRemoveRequestedReviewersRequest": PullsRemoveRequestedReviewersRequest,
    "PullsRequestReviewersRequest": PullsRequestReviewersRequest,
    "PullsSubmitReviewRequest": PullsSubmitReviewRequest,
    "PullsUpdateBranchRequest": PullsUpdateBranchRequest,
    "PullsUpdateRequest": PullsUpdateRequest,
    "PullsUpdateReviewCommentRequest": PullsUpdateReviewCommentRequest,
    "PullsUpdateReviewRequest": PullsUpdateReviewRequest,
    "RateLimit": RateLimit,
    "RateLimitOverview": RateLimitOverview,
    "RateLimitOverviewResources": RateLimitOverviewResources,
    "Reaction": Reaction,
    "ReactionRollup": ReactionRollup,
    "ReactionsCreateForCommitCommentRequest": ReactionsCreateForCommitCommentRequest,
    "ReactionsCreateForIssueCommentRequest": ReactionsCreateForIssueCommentRequest,
    "ReactionsCreateForIssueRequest": ReactionsCreateForIssueRequest,
    "ReactionsCreateForPullRequestReviewCommentRequest": ReactionsCreateForPullRequestReviewCommentRequest,
    "ReactionsCreateForReleaseRequest": ReactionsCreateForReleaseRequest,
    "ReactionsCreateForTeamDiscussionCommentInOrgRequest": ReactionsCreateForTeamDiscussionCommentInOrgRequest,
    "ReactionsCreateForTeamDiscussionInOrgRequest": ReactionsCreateForTeamDiscussionInOrgRequest,
    "ReferencedWorkflow": ReferencedWorkflow,
    "ReferrerTraffic": ReferrerTraffic,
    "Release": Release,
    "ReleaseAsset": ReleaseAsset,
    "RemovedFromProjectIssueEvent": RemovedFromProjectIssueEvent,
    "RenamedIssueEvent": RenamedIssueEvent,
    "RenamedIssueEventRename": RenamedIssueEventRename,
    "RepoSearchResultItem": RepoSearchResultItem,
    "ReposAddCollaboratorRequest": ReposAddCollaboratorRequest,
    "ReposCreateAutolinkRequest": ReposCreateAutolinkRequest,
    "ReposCreateCommitCommentRequest": ReposCreateCommitCommentRequest,
    "ReposCreateCommitStatusRequest": ReposCreateCommitStatusRequest,
    "ReposCreateDeployKeyRequest": ReposCreateDeployKeyRequest,
    "ReposCreateDeploymentRequest": ReposCreateDeploymentRequest,
    "ReposCreateDeploymentRequestPayload": ReposCreateDeploymentRequestPayload,
    "ReposCreateDeploymentStatusRequest": ReposCreateDeploymentStatusRequest,
    "ReposCreateDispatchEventRequest": ReposCreateDispatchEventRequest,
    "ReposCreateForAuthenticatedUserRequest": ReposCreateForAuthenticatedUserRequest,
    "ReposCreateForkRequest": ReposCreateForkRequest,
    "ReposCreateInOrgRequest": ReposCreateInOrgRequest,
    "ReposCreateOrUpdateEnvironmentRequest": ReposCreateOrUpdateEnvironmentRequest,
    "ReposCreateOrUpdateEnvironmentRequestReviewersInner": ReposCreateOrUpdateEnvironmentRequestReviewersInner,
    "ReposCreateOrUpdateFileContentsRequest": ReposCreateOrUpdateFileContentsRequest,
    "ReposCreateOrUpdateFileContentsRequestAuthor": ReposCreateOrUpdateFileContentsRequestAuthor,
    "ReposCreateOrUpdateFileContentsRequestCommitter": ReposCreateOrUpdateFileContentsRequestCommitter,
    "ReposCreatePagesDeploymentRequest": ReposCreatePagesDeploymentRequest,
    "ReposCreatePagesSiteRequest": ReposCreatePagesSiteRequest,
    "ReposCreatePagesSiteRequestSource": ReposCreatePagesSiteRequestSource,
    "ReposCreateReleaseRequest": ReposCreateReleaseRequest,
    "ReposCreateTagProtectionRequest": ReposCreateTagProtectionRequest,
    "ReposCreateUsingTemplateRequest": ReposCreateUsingTemplateRequest,
    "ReposCreateWebhookRequest": ReposCreateWebhookRequest,
    "ReposCreateWebhookRequestConfig": ReposCreateWebhookRequestConfig,
    "ReposDeleteFileRequest": ReposDeleteFileRequest,
    "ReposDeleteFileRequestAuthor": ReposDeleteFileRequestAuthor,
    "ReposDeleteFileRequestCommitter": ReposDeleteFileRequestCommitter,
    "ReposGenerateReleaseNotesRequest": ReposGenerateReleaseNotesRequest,
    "ReposGetAllEnvironments200Response": ReposGetAllEnvironments200Response,
    "ReposGetContent200Response": ReposGetContent200Response,
    "ReposMergeRequest": ReposMergeRequest,
    "ReposMergeUpstreamRequest": ReposMergeUpstreamRequest,
    "ReposRenameBranchRequest": ReposRenameBranchRequest,
    "ReposReplaceAllTopicsRequest": ReposReplaceAllTopicsRequest,
    "ReposSetAppAccessRestrictionsRequest": ReposSetAppAccessRestrictionsRequest,
    "ReposSetAppAccessRestrictionsRequestOneOf": ReposSetAppAccessRestrictionsRequestOneOf,
    "ReposSetStatusCheckContextsRequest": ReposSetStatusCheckContextsRequest,
    "ReposSetStatusCheckContextsRequestOneOf": ReposSetStatusCheckContextsRequestOneOf,
    "ReposSetTeamAccessRestrictionsRequest": ReposSetTeamAccessRestrictionsRequest,
    "ReposSetTeamAccessRestrictionsRequestOneOf": ReposSetTeamAccessRestrictionsRequestOneOf,
    "ReposSetUserAccessRestrictionsRequest": ReposSetUserAccessRestrictionsRequest,
    "ReposSetUserAccessRestrictionsRequestOneOf": ReposSetUserAccessRestrictionsRequestOneOf,
    "ReposTransferRequest": ReposTransferRequest,
    "ReposUpdateBranchProtectionRequest": ReposUpdateBranchProtectionRequest,
    "ReposUpdateBranchProtectionRequestRequiredPullRequestReviews": ReposUpdateBranchProtectionRequestRequiredPullRequestReviews,
    "ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsBypassPullRequestAllowances": ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsBypassPullRequestAllowances,
    "ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsDismissalRestrictions": ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsDismissalRestrictions,
    "ReposUpdateBranchProtectionRequestRequiredStatusChecks": ReposUpdateBranchProtectionRequestRequiredStatusChecks,
    "ReposUpdateBranchProtectionRequestRequiredStatusChecksChecksInner": ReposUpdateBranchProtectionRequestRequiredStatusChecksChecksInner,
    "ReposUpdateBranchProtectionRequestRestrictions": ReposUpdateBranchProtectionRequestRestrictions,
    "ReposUpdateCommitCommentRequest": ReposUpdateCommitCommentRequest,
    "ReposUpdateInformationAboutPagesSiteRequest": ReposUpdateInformationAboutPagesSiteRequest,
    "ReposUpdateInformationAboutPagesSiteRequestSource": ReposUpdateInformationAboutPagesSiteRequestSource,
    "ReposUpdateInformationAboutPagesSiteRequestSourceAnyOf": ReposUpdateInformationAboutPagesSiteRequestSourceAnyOf,
    "ReposUpdateInvitationRequest": ReposUpdateInvitationRequest,
    "ReposUpdatePullRequestReviewProtectionRequest": ReposUpdatePullRequestReviewProtectionRequest,
    "ReposUpdateReleaseAssetRequest": ReposUpdateReleaseAssetRequest,
    "ReposUpdateReleaseRequest": ReposUpdateReleaseRequest,
    "ReposUpdateRequest": ReposUpdateRequest,
    "ReposUpdateRequestSecurityAndAnalysis": ReposUpdateRequestSecurityAndAnalysis,
    "ReposUpdateRequestSecurityAndAnalysisAdvancedSecurity": ReposUpdateRequestSecurityAndAnalysisAdvancedSecurity,
    "ReposUpdateRequestSecurityAndAnalysisSecretScanning": ReposUpdateRequestSecurityAndAnalysisSecretScanning,
    "ReposUpdateRequestSecurityAndAnalysisSecretScanningPushProtection": ReposUpdateRequestSecurityAndAnalysisSecretScanningPushProtection,
    "ReposUpdateStatusCheckProtectionRequest": ReposUpdateStatusCheckProtectionRequest,
    "ReposUpdateWebhookConfigForRepoRequest": ReposUpdateWebhookConfigForRepoRequest,
    "ReposUpdateWebhookRequest": ReposUpdateWebhookRequest,
    "ReposUpdateWebhookRequestConfig": ReposUpdateWebhookRequestConfig,
    "Repository": Repository,
    "Repository1": Repository1,
    "RepositoryActionsCaches": RepositoryActionsCaches,
    "RepositoryActionsCachesActionsCachesInner": RepositoryActionsCachesActionsCachesInner,
    "RepositoryCollaboratorPermission": RepositoryCollaboratorPermission,
    "RepositoryInvitation": RepositoryInvitation,
    "RepositoryInvitation1": RepositoryInvitation1,
    "RepositoryPermissions": RepositoryPermissions,
    "RepositoryTemplateRepository": RepositoryTemplateRepository,
    "RepositoryTemplateRepositoryOwner": RepositoryTemplateRepositoryOwner,
    "RepositoryTemplateRepositoryPermissions": RepositoryTemplateRepositoryPermissions,
    "ReviewDismissedIssueEvent": ReviewDismissedIssueEvent,
    "ReviewDismissedIssueEventDismissedReview": ReviewDismissedIssueEventDismissedReview,
    "ReviewRequestRemovedIssueEvent": ReviewRequestRemovedIssueEvent,
    "ReviewRequestedIssueEvent": ReviewRequestedIssueEvent,
    "RunnerApplication": RunnerApplication,
    "SCIMUserList": SCIMUserList,
    "SCIMUsers": SCIMUsers,
    "SCIMUsersEmailsInner": SCIMUsersEmailsInner,
    "SCIMUsersGroupsInner": SCIMUsersGroupsInner,
    "SCIMUsersMeta": SCIMUsersMeta,
    "SCIMUsersName": SCIMUsersName,
    "SCIMUsersOperationsInner": SCIMUsersOperationsInner,
    "SCIMUsersOperationsInnerValue": SCIMUsersOperationsInnerValue,
    "ScimError": ScimError,
    "ScimProvisionAndInviteUserRequest": ScimProvisionAndInviteUserRequest,
    "ScimProvisionAndInviteUserRequestEmailsInner": ScimProvisionAndInviteUserRequestEmailsInner,
    "ScimProvisionAndInviteUserRequestName": ScimProvisionAndInviteUserRequestName,
    "ScimSetInformationForProvisionedUserRequest": ScimSetInformationForProvisionedUserRequest,
    "ScimSetInformationForProvisionedUserRequestEmailsInner": ScimSetInformationForProvisionedUserRequestEmailsInner,
    "ScimUpdateAttributeForUserRequest": ScimUpdateAttributeForUserRequest,
    "ScimUpdateAttributeForUserRequestOperationsInner": ScimUpdateAttributeForUserRequestOperationsInner,
    "ScimUpdateAttributeForUserRequestOperationsInnerValue": ScimUpdateAttributeForUserRequestOperationsInnerValue,
    "ScimUpdateAttributeForUserRequestOperationsInnerValueOneOf": ScimUpdateAttributeForUserRequestOperationsInnerValueOneOf,
    "ScimUpdateAttributeForUserRequestOperationsInnerValueOneOf1Inner": ScimUpdateAttributeForUserRequestOperationsInnerValueOneOf1Inner,
    "ScopedInstallation": ScopedInstallation,
    "SearchCode200Response": SearchCode200Response,
    "SearchCommits200Response": SearchCommits200Response,
    "SearchIssuesAndPullRequests200Response": SearchIssuesAndPullRequests200Response,
    "SearchLabels200Response": SearchLabels200Response,
    "SearchRepos200Response": SearchRepos200Response,
    "SearchResultTextMatchesInner": SearchResultTextMatchesInner,
    "SearchResultTextMatchesInnerMatchesInner": SearchResultTextMatchesInnerMatchesInner,
    "SearchTopics200Response": SearchTopics200Response,
    "SearchUsers200Response": SearchUsers200Response,
    "SecretScanningListAlertsForEnterprise200ResponseInner": SecretScanningListAlertsForEnterprise200ResponseInner,
    "SecretScanningListAlertsForRepo200ResponseInner": SecretScanningListAlertsForRepo200ResponseInner,
    "SecretScanningListLocationsForAlert200ResponseInner": SecretScanningListLocationsForAlert200ResponseInner,
    "SecretScanningListLocationsForAlert200ResponseInnerDetails": SecretScanningListLocationsForAlert200ResponseInnerDetails,
    "SecretScanningListLocationsForAlert200ResponseInnerDetailsOneOf": SecretScanningListLocationsForAlert200ResponseInnerDetailsOneOf,
    "SecretScanningUpdateAlertRequest": SecretScanningUpdateAlertRequest,
    "SelfHostedRunnerLabel": SelfHostedRunnerLabel,
    "SelfHostedRunners": SelfHostedRunners,
    "ServerStatisticsProxyEndpointInner": ServerStatisticsProxyEndpointInner,
    "ServerStatisticsProxyEndpointInnerDormantUsers": ServerStatisticsProxyEndpointInnerDormantUsers,
    "ServerStatisticsProxyEndpointInnerGheStats": ServerStatisticsProxyEndpointInnerGheStats,
    "ServerStatisticsProxyEndpointInnerGheStatsComments": ServerStatisticsProxyEndpointInnerGheStatsComments,
    "ServerStatisticsProxyEndpointInnerGheStatsGists": ServerStatisticsProxyEndpointInnerGheStatsGists,
    "ServerStatisticsProxyEndpointInnerGheStatsHooks": ServerStatisticsProxyEndpointInnerGheStatsHooks,
    "ServerStatisticsProxyEndpointInnerGheStatsIssues": ServerStatisticsProxyEndpointInnerGheStatsIssues,
    "ServerStatisticsProxyEndpointInnerGheStatsMilestones": ServerStatisticsProxyEndpointInnerGheStatsMilestones,
    "ServerStatisticsProxyEndpointInnerGheStatsOrgs": ServerStatisticsProxyEndpointInnerGheStatsOrgs,
    "ServerStatisticsProxyEndpointInnerGheStatsPages": ServerStatisticsProxyEndpointInnerGheStatsPages,
    "ServerStatisticsProxyEndpointInnerGheStatsPulls": ServerStatisticsProxyEndpointInnerGheStatsPulls,
    "ServerStatisticsProxyEndpointInnerGheStatsRepos": ServerStatisticsProxyEndpointInnerGheStatsRepos,
    "ServerStatisticsProxyEndpointInnerGheStatsUsers": ServerStatisticsProxyEndpointInnerGheStatsUsers,
    "ServerStatisticsProxyEndpointInnerGithubConnect": ServerStatisticsProxyEndpointInnerGithubConnect,
    "ShortBlob": ShortBlob,
    "ShortBranch": ShortBranch,
    "ShortBranchCommit": ShortBranchCommit,
    "SimpleCommit": SimpleCommit,
    "SimpleCommit1": SimpleCommit1,
    "SimpleCommitAuthor": SimpleCommitAuthor,
    "SimpleCommitStatus": SimpleCommitStatus,
    "SimpleRepository": SimpleRepository,
    "SimpleUser": SimpleUser,
    "SimpleUser1": SimpleUser1,
    "SimpleWebhookDelivery": SimpleWebhookDelivery,
    "Snapshot": Snapshot,
    "SnapshotDetector": SnapshotDetector,
    "SnapshotJob": SnapshotJob,
    "SnapshotManifestsValue": SnapshotManifestsValue,
    "SnapshotManifestsValueFile": SnapshotManifestsValueFile,
    "SnapshotManifestsValueResolvedValue": SnapshotManifestsValueResolvedValue,
    "Stargazer": Stargazer,
    "StarredRepository": StarredRepository,
    "StateChangeIssueEvent": StateChangeIssueEvent,
    "Status": Status,
    "StatusCheckPolicy": StatusCheckPolicy,
    "StatusCheckPolicyChecksInner": StatusCheckPolicyChecksInner,
    "SymlinkContent": SymlinkContent,
    "SymlinkContent1": SymlinkContent1,
    "Tag": Tag,
    "TagProtection": TagProtection,
    "Team": Team,
    "TeamDiscussion": TeamDiscussion,
    "TeamDiscussionComment": TeamDiscussionComment,
    "TeamMembership": TeamMembership,
    "TeamPermissions": TeamPermissions,
    "TeamProject": TeamProject,
    "TeamProjectPermissions": TeamProjectPermissions,
    "TeamRepository": TeamRepository,
    "TeamSimple": TeamSimple,
    "TeamSimple1": TeamSimple1,
    "TeamsAddOrUpdateMembershipForUserInOrgRequest": TeamsAddOrUpdateMembershipForUserInOrgRequest,
    "TeamsAddOrUpdateProjectPermissionsInOrgRequest": TeamsAddOrUpdateProjectPermissionsInOrgRequest,
    "TeamsAddOrUpdateProjectPermissionsLegacyRequest": TeamsAddOrUpdateProjectPermissionsLegacyRequest,
    "TeamsAddOrUpdateRepoPermissionsInOrgRequest": TeamsAddOrUpdateRepoPermissionsInOrgRequest,
    "TeamsAddOrUpdateRepoPermissionsLegacyRequest": TeamsAddOrUpdateRepoPermissionsLegacyRequest,
    "TeamsCreateDiscussionCommentInOrgRequest": TeamsCreateDiscussionCommentInOrgRequest,
    "TeamsCreateDiscussionInOrgRequest": TeamsCreateDiscussionInOrgRequest,
    "TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequest": TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequest,
    "TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequestGroupsInner": TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequestGroupsInner,
    "TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequest": TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequest,
    "TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequestGroupsInner": TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequestGroupsInner,
    "TeamsCreateRequest": TeamsCreateRequest,
    "TeamsLinkExternalIdpGroupToTeamForOrgRequest": TeamsLinkExternalIdpGroupToTeamForOrgRequest,
    "TeamsUpdateDiscussionInOrgRequest": TeamsUpdateDiscussionInOrgRequest,
    "TeamsUpdateInOrgRequest": TeamsUpdateInOrgRequest,
    "TeamsUpdateLegacyRequest": TeamsUpdateLegacyRequest,
    "TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization": TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization,
    "Thread": Thread,
    "ThreadSubject": ThreadSubject,
    "ThreadSubscription": ThreadSubscription,
    "TimelineAssignedIssueEvent": TimelineAssignedIssueEvent,
    "TimelineCommentEvent": TimelineCommentEvent,
    "TimelineCommitCommentedEvent": TimelineCommitCommentedEvent,
    "TimelineCommittedEvent": TimelineCommittedEvent,
    "TimelineCrossReferencedEvent": TimelineCrossReferencedEvent,
    "TimelineCrossReferencedEventSource": TimelineCrossReferencedEventSource,
    "TimelineEvent": TimelineEvent,
    "TimelineLineCommentedEvent": TimelineLineCommentedEvent,
    "TimelineReviewedEvent": TimelineReviewedEvent,
    "TimelineReviewedEventLinks": TimelineReviewedEventLinks,
    "TimelineReviewedEventLinksHtml": TimelineReviewedEventLinksHtml,
    "TimelineUnassignedIssueEvent": TimelineUnassignedIssueEvent,
    "Topic": Topic,
    "TopicSearchResultItem": TopicSearchResultItem,
    "TopicSearchResultItemRelatedInner": TopicSearchResultItemRelatedInner,
    "TopicSearchResultItemRelatedInnerTopicRelation": TopicSearchResultItemRelatedInnerTopicRelation,
    "Traffic": Traffic,
    "UnassignedIssueEvent": UnassignedIssueEvent,
    "UnlabeledIssueEvent": UnlabeledIssueEvent,
    "UserMarketplacePurchase": UserMarketplacePurchase,
    "UserSearchResultItem": UserSearchResultItem,
    "UsersAddEmailForAuthenticatedUserRequest": UsersAddEmailForAuthenticatedUserRequest,
    "UsersAddEmailForAuthenticatedUserRequestOneOf": UsersAddEmailForAuthenticatedUserRequestOneOf,
    "UsersCreateGpgKeyForAuthenticatedUserRequest": UsersCreateGpgKeyForAuthenticatedUserRequest,
    "UsersCreatePublicSshKeyForAuthenticatedUserRequest": UsersCreatePublicSshKeyForAuthenticatedUserRequest,
    "UsersDeleteEmailForAuthenticatedUserRequest": UsersDeleteEmailForAuthenticatedUserRequest,
    "UsersDeleteEmailForAuthenticatedUserRequestOneOf": UsersDeleteEmailForAuthenticatedUserRequestOneOf,
    "UsersGetAuthenticated200Response": UsersGetAuthenticated200Response,
    "UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest": UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest,
    "UsersUpdateAuthenticatedRequest": UsersUpdateAuthenticatedRequest,
    "ValidationError": ValidationError,
    "ValidationErrorErrorsInner": ValidationErrorErrorsInner,
    "ValidationErrorErrorsInnerValue": ValidationErrorErrorsInnerValue,
    "ValidationErrorSimple": ValidationErrorSimple,
    "Verification": Verification,
    "ViewTraffic": ViewTraffic,
    "Webhook": Webhook,
    "WebhookConfig": WebhookConfig,
    "WebhookConfiguration": WebhookConfiguration,
    "WebhookConfigurationInsecureSsl": WebhookConfigurationInsecureSsl,
    "WebhookDelivery": WebhookDelivery,
    "WebhookDeliveryRequest": WebhookDeliveryRequest,
    "WebhookDeliveryResponse": WebhookDeliveryResponse,
    "Workflow": Workflow,
    "WorkflowRun": WorkflowRun,
    "WorkflowRunUsage": WorkflowRunUsage,
    "WorkflowRunUsageBillable": WorkflowRunUsageBillable,
    "WorkflowRunUsageBillableUBUNTU": WorkflowRunUsageBillableUBUNTU,
    "WorkflowRunUsageBillableUBUNTUJobRunsInner": WorkflowRunUsageBillableUBUNTUJobRunsInner,
    "WorkflowUsage": WorkflowUsage,
    "WorkflowUsageBillable": WorkflowUsageBillable,
    "WorkflowUsageBillableUBUNTU": WorkflowUsageBillableUBUNTU,
}

export class ObjectSerializer {
    public static findCorrectType(data: any, expectedType: string) {
        if (data == undefined) {
            return expectedType;
        } else if (primitives.indexOf(expectedType.toLowerCase()) !== -1) {
            return expectedType;
        } else if (expectedType === "Date") {
            return expectedType;
        } else {
            if (enumsMap[expectedType]) {
                return expectedType;
            }

            if (!typeMap[expectedType]) {
                return expectedType; // w/e we don't know the type
            }

            // Check the discriminator
            let discriminatorProperty = typeMap[expectedType].discriminator;
            if (discriminatorProperty == null) {
                return expectedType; // the type does not have a discriminator. use it.
            } else {
                if (data[discriminatorProperty]) {
                    var discriminatorType = data[discriminatorProperty];
                    if(typeMap[discriminatorType]){
                        return discriminatorType; // use the type given in the discriminator
                    } else {
                        return expectedType; // discriminator did not map to a type
                    }
                } else {
                    return expectedType; // discriminator was not present (or an empty string)
                }
            }
        }
    }

    public static serialize(data: any, type: string) {
        if (data == undefined) {
            return data;
        } else if (primitives.indexOf(type.toLowerCase()) !== -1) {
            return data;
        } else if (type.lastIndexOf("Array<", 0) === 0) { // string.startsWith pre es6
            let subType: string = type.replace("Array<", ""); // Array<Type> => Type>
            subType = subType.substring(0, subType.length - 1); // Type> => Type
            let transformedData: any[] = [];
            for (let index = 0; index < data.length; index++) {
                let datum = data[index];
                transformedData.push(ObjectSerializer.serialize(datum, subType));
            }
            return transformedData;
        } else if (type === "Date") {
            return data.toISOString();
        } else {
            if (enumsMap[type]) {
                return data;
            }
            if (!typeMap[type]) { // in case we dont know the type
                return data;
            }

            // Get the actual type of this object
            type = this.findCorrectType(data, type);

            // get the map for the correct type.
            let attributeTypes = typeMap[type].getAttributeTypeMap();
            let instance: {[index: string]: any} = {};
            for (let index = 0; index < attributeTypes.length; index++) {
                let attributeType = attributeTypes[index];
                instance[attributeType.baseName] = ObjectSerializer.serialize(data[attributeType.name], attributeType.type);
            }
            return instance;
        }
    }

    public static deserialize(data: any, type: string) {
        // polymorphism may change the actual type.
        type = ObjectSerializer.findCorrectType(data, type);
        if (data == undefined) {
            return data;
        } else if (primitives.indexOf(type.toLowerCase()) !== -1) {
            return data;
        } else if (type.lastIndexOf("Array<", 0) === 0) { // string.startsWith pre es6
            let subType: string = type.replace("Array<", ""); // Array<Type> => Type>
            subType = subType.substring(0, subType.length - 1); // Type> => Type
            let transformedData: any[] = [];
            for (let index = 0; index < data.length; index++) {
                let datum = data[index];
                transformedData.push(ObjectSerializer.deserialize(datum, subType));
            }
            return transformedData;
        } else if (type === "Date") {
            return new Date(data);
        } else {
            if (enumsMap[type]) {// is Enum
                return data;
            }

            if (!typeMap[type]) { // dont know the type
                return data;
            }
            let instance = new typeMap[type]();
            let attributeTypes = typeMap[type].getAttributeTypeMap();
            for (let index = 0; index < attributeTypes.length; index++) {
                let attributeType = attributeTypes[index];
                instance[attributeType.name] = ObjectSerializer.deserialize(data[attributeType.baseName], attributeType.type);
            }
            return instance;
        }
    }
}

export interface Authentication {
    /**
    * Apply authentication settings to header and query params.
    */
    applyToRequest(requestOptions: localVarRequest.Options): Promise<void> | void;
}

export class HttpBasicAuth implements Authentication {
    public username: string = '';
    public password: string = '';

    applyToRequest(requestOptions: localVarRequest.Options): void {
        requestOptions.auth = {
            username: this.username, password: this.password
        }
    }
}

export class HttpBearerAuth implements Authentication {
    public accessToken: string | (() => string) = '';

    applyToRequest(requestOptions: localVarRequest.Options): void {
        if (requestOptions && requestOptions.headers) {
            const accessToken = typeof this.accessToken === 'function'
                            ? this.accessToken()
                            : this.accessToken;
            requestOptions.headers["Authorization"] = "Bearer " + accessToken;
        }
    }
}

export class ApiKeyAuth implements Authentication {
    public apiKey: string = '';

    constructor(private location: string, private paramName: string) {
    }

    applyToRequest(requestOptions: localVarRequest.Options): void {
        if (this.location == "query") {
            (<any>requestOptions.qs)[this.paramName] = this.apiKey;
        } else if (this.location == "header" && requestOptions && requestOptions.headers) {
            requestOptions.headers[this.paramName] = this.apiKey;
        } else if (this.location == 'cookie' && requestOptions && requestOptions.headers) {
            if (requestOptions.headers['Cookie']) {
                requestOptions.headers['Cookie'] += '; ' + this.paramName + '=' + encodeURIComponent(this.apiKey);
            }
            else {
                requestOptions.headers['Cookie'] = this.paramName + '=' + encodeURIComponent(this.apiKey);
            }
        }
    }
}

export class OAuth implements Authentication {
    public accessToken: string = '';

    applyToRequest(requestOptions: localVarRequest.Options): void {
        if (requestOptions && requestOptions.headers) {
            requestOptions.headers["Authorization"] = "Bearer " + this.accessToken;
        }
    }
}

export class VoidAuth implements Authentication {
    public username: string = '';
    public password: string = '';

    applyToRequest(_: localVarRequest.Options): void {
        // Do nothing
    }
}

export type Interceptor = (requestOptions: localVarRequest.Options) => (Promise<void> | void);
