# Org.OpenAPITools.Model.ReposCreateForAuthenticatedUserRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the repository. | 
**Description** | **string** | A short description of the repository. | [optional] 
**Homepage** | **string** | A URL with more information about the repository. | [optional] 
**Private** | **bool?** | Whether the repository is private. | [optional] [default to false]
**HasIssues** | **bool?** | Whether issues are enabled. | [optional] [default to true]
**HasProjects** | **bool?** | Whether projects are enabled. | [optional] [default to true]
**HasWiki** | **bool?** | Whether the wiki is enabled. | [optional] [default to true]
**TeamId** | **int?** | The id of the team that will be granted access to this repository. This is only valid when creating a repository in an organization. | [optional] 
**AutoInit** | **bool?** | Whether the repository is initialized with a minimal README. | [optional] [default to false]
**GitignoreTemplate** | **string** | The desired language or platform to apply to the .gitignore. | [optional] 
**LicenseTemplate** | **string** | The license keyword of the open source license for this repository. | [optional] 
**AllowSquashMerge** | **bool?** | Whether to allow squash merges for pull requests. | [optional] [default to true]
**AllowMergeCommit** | **bool?** | Whether to allow merge commits for pull requests. | [optional] [default to true]
**AllowRebaseMerge** | **bool?** | Whether to allow rebase merges for pull requests. | [optional] [default to true]
**AllowAutoMerge** | **bool?** | Whether to allow Auto-merge to be used on pull requests. | [optional] [default to false]
**DeleteBranchOnMerge** | **bool?** | Whether to delete head branches when pull requests are merged | [optional] [default to false]
**HasDownloads** | **bool?** | Whether downloads are enabled. | [optional] [default to true]
**IsTemplate** | **bool?** | Whether this repository acts as a template that can be used to generate new repositories. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

