# Org.OpenAPITools.Model.Repository1

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Unique identifier of the repository | 
**NodeId** | **string** |  | 
**Name** | **string** | The name of the repository. | 
**FullName** | **string** |  | 
**License** | [**LicenseSimple**](LicenseSimple.md) |  | 
**Organization** | [**SimpleUser**](SimpleUser.md) |  | [optional] 
**Forks** | **int?** |  | 
**Permissions** | [**RepositoryPermissions**](RepositoryPermissions.md) |  | [optional] 
**Owner** | [**SimpleUser1**](SimpleUser1.md) |  | 
**Private** | **bool?** | Whether the repository is private or public. | [default to false]
**HtmlUrl** | **string** |  | 
**Description** | **string** |  | 
**Fork** | **bool?** |  | 
**Url** | **string** |  | 
**ArchiveUrl** | **string** |  | 
**AssigneesUrl** | **string** |  | 
**BlobsUrl** | **string** |  | 
**BranchesUrl** | **string** |  | 
**CollaboratorsUrl** | **string** |  | 
**CommentsUrl** | **string** |  | 
**CommitsUrl** | **string** |  | 
**CompareUrl** | **string** |  | 
**ContentsUrl** | **string** |  | 
**ContributorsUrl** | **string** |  | 
**DeploymentsUrl** | **string** |  | 
**DownloadsUrl** | **string** |  | 
**EventsUrl** | **string** |  | 
**ForksUrl** | **string** |  | 
**GitCommitsUrl** | **string** |  | 
**GitRefsUrl** | **string** |  | 
**GitTagsUrl** | **string** |  | 
**GitUrl** | **string** |  | 
**IssueCommentUrl** | **string** |  | 
**IssueEventsUrl** | **string** |  | 
**IssuesUrl** | **string** |  | 
**KeysUrl** | **string** |  | 
**LabelsUrl** | **string** |  | 
**LanguagesUrl** | **string** |  | 
**MergesUrl** | **string** |  | 
**MilestonesUrl** | **string** |  | 
**NotificationsUrl** | **string** |  | 
**PullsUrl** | **string** |  | 
**ReleasesUrl** | **string** |  | 
**SshUrl** | **string** |  | 
**StargazersUrl** | **string** |  | 
**StatusesUrl** | **string** |  | 
**SubscribersUrl** | **string** |  | 
**SubscriptionUrl** | **string** |  | 
**TagsUrl** | **string** |  | 
**TeamsUrl** | **string** |  | 
**TreesUrl** | **string** |  | 
**CloneUrl** | **string** |  | 
**MirrorUrl** | **string** |  | 
**HooksUrl** | **string** |  | 
**SvnUrl** | **string** |  | 
**Homepage** | **string** |  | 
**Language** | **string** |  | 
**ForksCount** | **int?** |  | 
**StargazersCount** | **int?** |  | 
**WatchersCount** | **int?** |  | 
**Size** | **int?** |  | 
**DefaultBranch** | **string** | The default branch of the repository. | 
**OpenIssuesCount** | **int?** |  | 
**IsTemplate** | **bool?** | Whether this repository acts as a template that can be used to generate new repositories. | [optional] [default to false]
**Topics** | **List<string>** |  | [optional] 
**HasIssues** | **bool?** | Whether issues are enabled. | [default to true]
**HasProjects** | **bool?** | Whether projects are enabled. | [default to true]
**HasWiki** | **bool?** | Whether the wiki is enabled. | [default to true]
**HasPages** | **bool?** |  | 
**HasDownloads** | **bool?** | Whether downloads are enabled. | [default to true]
**Archived** | **bool?** | Whether the repository is archived. | [default to false]
**Disabled** | **bool?** | Returns whether or not this repository disabled. | 
**Visibility** | **string** | The repository visibility: public, private, or internal. | [optional] [default to "public"]
**PushedAt** | **DateTime?** |  | 
**CreatedAt** | **DateTime?** |  | 
**UpdatedAt** | **DateTime?** |  | 
**AllowRebaseMerge** | **bool?** | Whether to allow rebase merges for pull requests. | [optional] [default to true]
**TemplateRepository** | [**RepositoryTemplateRepository**](RepositoryTemplateRepository.md) |  | [optional] 
**TempCloneToken** | **string** |  | [optional] 
**AllowSquashMerge** | **bool?** | Whether to allow squash merges for pull requests. | [optional] [default to true]
**AllowAutoMerge** | **bool?** | Whether to allow Auto-merge to be used on pull requests. | [optional] [default to false]
**DeleteBranchOnMerge** | **bool?** | Whether to delete head branches when pull requests are merged | [optional] [default to false]
**AllowUpdateBranch** | **bool?** | Whether or not a pull request head branch that is behind its base branch can always be updated even if it is not required to be up to date before merging. | [optional] [default to false]
**UseSquashPrTitleAsDefault** | **bool?** | Whether a squash merge commit can use the pull request title as default. | [optional] [default to false]
**AllowMergeCommit** | **bool?** | Whether to allow merge commits for pull requests. | [optional] [default to true]
**AllowForking** | **bool?** | Whether to allow forking this repo | [optional] 
**SubscribersCount** | **int?** |  | [optional] 
**NetworkCount** | **int?** |  | [optional] 
**OpenIssues** | **int?** |  | 
**Watchers** | **int?** |  | 
**MasterBranch** | **string** |  | [optional] 
**StarredAt** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

