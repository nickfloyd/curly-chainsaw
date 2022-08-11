# Org.OpenAPITools.Model.ReposCreateInOrgRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the repository. | 
**Description** | **string** | A short description of the repository. | [optional] 
**Homepage** | **string** | A URL with more information about the repository. | [optional] 
**Private** | **bool?** | Whether the repository is private. | [optional] [default to false]
**Visibility** | **string** | Can be &#x60;public&#x60; or &#x60;private&#x60;. If your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+, &#x60;visibility&#x60; can also be &#x60;internal&#x60;. Note: For GitHub Enterprise Server and GitHub AE, this endpoint will only list repositories available to all users on the enterprise. For more information, see \&quot;[Creating an internal repository](https://docs.github.com/en/github/creating-cloning-and-archiving-repositories/about-repository-visibility#about-internal-repositories)\&quot; in the GitHub Help documentation. | [optional] 
**HasIssues** | **bool?** | Either &#x60;true&#x60; to enable issues for this repository or &#x60;false&#x60; to disable them. | [optional] [default to true]
**HasProjects** | **bool?** | Either &#x60;true&#x60; to enable projects for this repository or &#x60;false&#x60; to disable them. **Note:** If you&#39;re creating a repository in an organization that has disabled repository projects, the default is &#x60;false&#x60;, and if you pass &#x60;true&#x60;, the API returns an error. | [optional] [default to true]
**HasWiki** | **bool?** | Either &#x60;true&#x60; to enable the wiki for this repository or &#x60;false&#x60; to disable it. | [optional] [default to true]
**IsTemplate** | **bool?** | Either &#x60;true&#x60; to make this repo available as a template repository or &#x60;false&#x60; to prevent it. | [optional] [default to false]
**TeamId** | **int?** | The id of the team that will be granted access to this repository. This is only valid when creating a repository in an organization. | [optional] 
**AutoInit** | **bool?** | Pass &#x60;true&#x60; to create an initial commit with empty README. | [optional] [default to false]
**GitignoreTemplate** | **string** | Desired language or platform [.gitignore template](https://github.com/github/gitignore) to apply. Use the name of the template without the extension. For example, \&quot;Haskell\&quot;. | [optional] 
**LicenseTemplate** | **string** | Choose an [open source license template](https://choosealicense.com/) that best suits your needs, and then use the [license keyword](https://docs.github.com/articles/licensing-a-repository/#searching-github-by-license-type) as the &#x60;license_template&#x60; string. For example, \&quot;mit\&quot; or \&quot;mpl-2.0\&quot;. | [optional] 
**AllowSquashMerge** | **bool?** | Either &#x60;true&#x60; to allow squash-merging pull requests, or &#x60;false&#x60; to prevent squash-merging. | [optional] [default to true]
**AllowMergeCommit** | **bool?** | Either &#x60;true&#x60; to allow merging pull requests with a merge commit, or &#x60;false&#x60; to prevent merging pull requests with merge commits. | [optional] [default to true]
**AllowRebaseMerge** | **bool?** | Either &#x60;true&#x60; to allow rebase-merging pull requests, or &#x60;false&#x60; to prevent rebase-merging. | [optional] [default to true]
**AllowAutoMerge** | **bool?** | Either &#x60;true&#x60; to allow auto-merge on pull requests, or &#x60;false&#x60; to disallow auto-merge. | [optional] [default to false]
**DeleteBranchOnMerge** | **bool?** | Either &#x60;true&#x60; to allow automatically deleting head branches when pull requests are merged, or &#x60;false&#x60; to prevent automatic deletion. | [optional] [default to false]
**UseSquashPrTitleAsDefault** | **bool?** | Either &#x60;true&#x60; to allow squash-merge commits to use pull request title, or &#x60;false&#x60; to use commit message. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

