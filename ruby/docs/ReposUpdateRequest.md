# OpenapiClient::ReposUpdateRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **name** | **String** | The name of the repository. | [optional] |
| **description** | **String** | A short description of the repository. | [optional] |
| **homepage** | **String** | A URL with more information about the repository. | [optional] |
| **private** | **Boolean** | Either &#x60;true&#x60; to make the repository private or &#x60;false&#x60; to make it public. Default: &#x60;false&#x60;.   **Note**: You will get a &#x60;422&#x60; error if the organization restricts [changing repository visibility](https://docs.github.com/articles/repository-permission-levels-for-an-organization#changing-the-visibility-of-repositories) to organization owners and a non-owner tries to change the value of private. | [optional][default to false] |
| **visibility** | **String** | Can be &#x60;public&#x60; or &#x60;private&#x60;. If your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+, &#x60;visibility&#x60; can also be &#x60;internal&#x60;.\&quot; | [optional] |
| **security_and_analysis** | [**ReposUpdateRequestSecurityAndAnalysis**](ReposUpdateRequestSecurityAndAnalysis.md) |  | [optional] |
| **has_issues** | **Boolean** | Either &#x60;true&#x60; to enable issues for this repository or &#x60;false&#x60; to disable them. | [optional][default to true] |
| **has_projects** | **Boolean** | Either &#x60;true&#x60; to enable projects for this repository or &#x60;false&#x60; to disable them. **Note:** If you&#39;re creating a repository in an organization that has disabled repository projects, the default is &#x60;false&#x60;, and if you pass &#x60;true&#x60;, the API returns an error. | [optional][default to true] |
| **has_wiki** | **Boolean** | Either &#x60;true&#x60; to enable the wiki for this repository or &#x60;false&#x60; to disable it. | [optional][default to true] |
| **is_template** | **Boolean** | Either &#x60;true&#x60; to make this repo available as a template repository or &#x60;false&#x60; to prevent it. | [optional][default to false] |
| **default_branch** | **String** | Updates the default branch for this repository. | [optional] |
| **allow_squash_merge** | **Boolean** | Either &#x60;true&#x60; to allow squash-merging pull requests, or &#x60;false&#x60; to prevent squash-merging. | [optional][default to true] |
| **allow_merge_commit** | **Boolean** | Either &#x60;true&#x60; to allow merging pull requests with a merge commit, or &#x60;false&#x60; to prevent merging pull requests with merge commits. | [optional][default to true] |
| **allow_rebase_merge** | **Boolean** | Either &#x60;true&#x60; to allow rebase-merging pull requests, or &#x60;false&#x60; to prevent rebase-merging. | [optional][default to true] |
| **allow_auto_merge** | **Boolean** | Either &#x60;true&#x60; to allow auto-merge on pull requests, or &#x60;false&#x60; to disallow auto-merge. | [optional][default to false] |
| **delete_branch_on_merge** | **Boolean** | Either &#x60;true&#x60; to allow automatically deleting head branches when pull requests are merged, or &#x60;false&#x60; to prevent automatic deletion. | [optional][default to false] |
| **allow_update_branch** | **Boolean** | Either &#x60;true&#x60; to always allow a pull request head branch that is behind its base branch to be updated even if it is not required to be up to date before merging, or false otherwise. | [optional][default to false] |
| **use_squash_pr_title_as_default** | **Boolean** | Either &#x60;true&#x60; to allow squash-merge commits to use pull request title, or &#x60;false&#x60; to use commit message. | [optional][default to false] |
| **archived** | **Boolean** | &#x60;true&#x60; to archive this repository. **Note**: You cannot unarchive repositories through the API. | [optional][default to false] |
| **allow_forking** | **Boolean** | Either &#x60;true&#x60; to allow private forks, or &#x60;false&#x60; to prevent private forks. | [optional][default to false] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ReposUpdateRequest.new(
  name: null,
  description: null,
  homepage: null,
  private: null,
  visibility: null,
  security_and_analysis: null,
  has_issues: null,
  has_projects: null,
  has_wiki: null,
  is_template: null,
  default_branch: null,
  allow_squash_merge: null,
  allow_merge_commit: null,
  allow_rebase_merge: null,
  allow_auto_merge: null,
  delete_branch_on_merge: null,
  allow_update_branch: null,
  use_squash_pr_title_as_default: null,
  archived: null,
  allow_forking: null
)
```

