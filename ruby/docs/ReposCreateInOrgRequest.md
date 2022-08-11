# OpenapiClient::ReposCreateInOrgRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **name** | **String** | The name of the repository. |  |
| **description** | **String** | A short description of the repository. | [optional] |
| **homepage** | **String** | A URL with more information about the repository. | [optional] |
| **private** | **Boolean** | Whether the repository is private. | [optional][default to false] |
| **visibility** | **String** | Can be &#x60;public&#x60; or &#x60;private&#x60;. If your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+, &#x60;visibility&#x60; can also be &#x60;internal&#x60;. Note: For GitHub Enterprise Server and GitHub AE, this endpoint will only list repositories available to all users on the enterprise. For more information, see \&quot;[Creating an internal repository](https://docs.github.com/en/github/creating-cloning-and-archiving-repositories/about-repository-visibility#about-internal-repositories)\&quot; in the GitHub Help documentation. | [optional] |
| **has_issues** | **Boolean** | Either &#x60;true&#x60; to enable issues for this repository or &#x60;false&#x60; to disable them. | [optional][default to true] |
| **has_projects** | **Boolean** | Either &#x60;true&#x60; to enable projects for this repository or &#x60;false&#x60; to disable them. **Note:** If you&#39;re creating a repository in an organization that has disabled repository projects, the default is &#x60;false&#x60;, and if you pass &#x60;true&#x60;, the API returns an error. | [optional][default to true] |
| **has_wiki** | **Boolean** | Either &#x60;true&#x60; to enable the wiki for this repository or &#x60;false&#x60; to disable it. | [optional][default to true] |
| **is_template** | **Boolean** | Either &#x60;true&#x60; to make this repo available as a template repository or &#x60;false&#x60; to prevent it. | [optional][default to false] |
| **team_id** | **Integer** | The id of the team that will be granted access to this repository. This is only valid when creating a repository in an organization. | [optional] |
| **auto_init** | **Boolean** | Pass &#x60;true&#x60; to create an initial commit with empty README. | [optional][default to false] |
| **gitignore_template** | **String** | Desired language or platform [.gitignore template](https://github.com/github/gitignore) to apply. Use the name of the template without the extension. For example, \&quot;Haskell\&quot;. | [optional] |
| **license_template** | **String** | Choose an [open source license template](https://choosealicense.com/) that best suits your needs, and then use the [license keyword](https://docs.github.com/articles/licensing-a-repository/#searching-github-by-license-type) as the &#x60;license_template&#x60; string. For example, \&quot;mit\&quot; or \&quot;mpl-2.0\&quot;. | [optional] |
| **allow_squash_merge** | **Boolean** | Either &#x60;true&#x60; to allow squash-merging pull requests, or &#x60;false&#x60; to prevent squash-merging. | [optional][default to true] |
| **allow_merge_commit** | **Boolean** | Either &#x60;true&#x60; to allow merging pull requests with a merge commit, or &#x60;false&#x60; to prevent merging pull requests with merge commits. | [optional][default to true] |
| **allow_rebase_merge** | **Boolean** | Either &#x60;true&#x60; to allow rebase-merging pull requests, or &#x60;false&#x60; to prevent rebase-merging. | [optional][default to true] |
| **allow_auto_merge** | **Boolean** | Either &#x60;true&#x60; to allow auto-merge on pull requests, or &#x60;false&#x60; to disallow auto-merge. | [optional][default to false] |
| **delete_branch_on_merge** | **Boolean** | Either &#x60;true&#x60; to allow automatically deleting head branches when pull requests are merged, or &#x60;false&#x60; to prevent automatic deletion. | [optional][default to false] |
| **use_squash_pr_title_as_default** | **Boolean** | Either &#x60;true&#x60; to allow squash-merge commits to use pull request title, or &#x60;false&#x60; to use commit message. | [optional][default to false] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ReposCreateInOrgRequest.new(
  name: null,
  description: null,
  homepage: null,
  private: null,
  visibility: null,
  has_issues: null,
  has_projects: null,
  has_wiki: null,
  is_template: null,
  team_id: null,
  auto_init: null,
  gitignore_template: null,
  license_template: null,
  allow_squash_merge: null,
  allow_merge_commit: null,
  allow_rebase_merge: null,
  allow_auto_merge: null,
  delete_branch_on_merge: null,
  use_squash_pr_title_as_default: null
)
```

