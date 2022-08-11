# Org.OpenAPITools.Model.ReposUpdateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the repository. | [optional] 
**Description** | **string** | A short description of the repository. | [optional] 
**Homepage** | **string** | A URL with more information about the repository. | [optional] 
**Private** | **bool?** | Either &#x60;true&#x60; to make the repository private or &#x60;false&#x60; to make it public. Default: &#x60;false&#x60;.   **Note**: You will get a &#x60;422&#x60; error if the organization restricts [changing repository visibility](https://docs.github.com/articles/repository-permission-levels-for-an-organization#changing-the-visibility-of-repositories) to organization owners and a non-owner tries to change the value of private. | [optional] [default to false]
**Visibility** | **string** | Can be &#x60;public&#x60; or &#x60;private&#x60;. If your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+, &#x60;visibility&#x60; can also be &#x60;internal&#x60;.\&quot; | [optional] 
**SecurityAndAnalysis** | [**ReposUpdateRequestSecurityAndAnalysis**](ReposUpdateRequestSecurityAndAnalysis.md) |  | [optional] 
**HasIssues** | **bool?** | Either &#x60;true&#x60; to enable issues for this repository or &#x60;false&#x60; to disable them. | [optional] [default to true]
**HasProjects** | **bool?** | Either &#x60;true&#x60; to enable projects for this repository or &#x60;false&#x60; to disable them. **Note:** If you&#39;re creating a repository in an organization that has disabled repository projects, the default is &#x60;false&#x60;, and if you pass &#x60;true&#x60;, the API returns an error. | [optional] [default to true]
**HasWiki** | **bool?** | Either &#x60;true&#x60; to enable the wiki for this repository or &#x60;false&#x60; to disable it. | [optional] [default to true]
**IsTemplate** | **bool?** | Either &#x60;true&#x60; to make this repo available as a template repository or &#x60;false&#x60; to prevent it. | [optional] [default to false]
**DefaultBranch** | **string** | Updates the default branch for this repository. | [optional] 
**AllowSquashMerge** | **bool?** | Either &#x60;true&#x60; to allow squash-merging pull requests, or &#x60;false&#x60; to prevent squash-merging. | [optional] [default to true]
**AllowMergeCommit** | **bool?** | Either &#x60;true&#x60; to allow merging pull requests with a merge commit, or &#x60;false&#x60; to prevent merging pull requests with merge commits. | [optional] [default to true]
**AllowRebaseMerge** | **bool?** | Either &#x60;true&#x60; to allow rebase-merging pull requests, or &#x60;false&#x60; to prevent rebase-merging. | [optional] [default to true]
**AllowAutoMerge** | **bool?** | Either &#x60;true&#x60; to allow auto-merge on pull requests, or &#x60;false&#x60; to disallow auto-merge. | [optional] [default to false]
**DeleteBranchOnMerge** | **bool?** | Either &#x60;true&#x60; to allow automatically deleting head branches when pull requests are merged, or &#x60;false&#x60; to prevent automatic deletion. | [optional] [default to false]
**AllowUpdateBranch** | **bool?** | Either &#x60;true&#x60; to always allow a pull request head branch that is behind its base branch to be updated even if it is not required to be up to date before merging, or false otherwise. | [optional] [default to false]
**UseSquashPrTitleAsDefault** | **bool?** | Either &#x60;true&#x60; to allow squash-merge commits to use pull request title, or &#x60;false&#x60; to use commit message. | [optional] [default to false]
**Archived** | **bool?** | &#x60;true&#x60; to archive this repository. **Note**: You cannot unarchive repositories through the API. | [optional] [default to false]
**AllowForking** | **bool?** | Either &#x60;true&#x60; to allow private forks, or &#x60;false&#x60; to prevent private forks. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

