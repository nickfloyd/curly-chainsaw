# OpenapiClient::ReposUpdateBranchProtectionRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **required_status_checks** | [**ReposUpdateBranchProtectionRequestRequiredStatusChecks**](ReposUpdateBranchProtectionRequestRequiredStatusChecks.md) |  |  |
| **enforce_admins** | **Boolean** | Enforce all configured restrictions for administrators. Set to &#x60;true&#x60; to enforce required status checks for repository administrators. Set to &#x60;null&#x60; to disable. |  |
| **required_pull_request_reviews** | [**ReposUpdateBranchProtectionRequestRequiredPullRequestReviews**](ReposUpdateBranchProtectionRequestRequiredPullRequestReviews.md) |  |  |
| **restrictions** | [**ReposUpdateBranchProtectionRequestRestrictions**](ReposUpdateBranchProtectionRequestRestrictions.md) |  |  |
| **required_linear_history** | **Boolean** | Enforces a linear commit Git history, which prevents anyone from pushing merge commits to a branch. Set to &#x60;true&#x60; to enforce a linear commit history. Set to &#x60;false&#x60; to disable a linear commit Git history. Your repository must allow squash merging or rebase merging before you can enable a linear commit history. Default: &#x60;false&#x60;. For more information, see \&quot;[Requiring a linear commit history](https://docs.github.com/github/administering-a-repository/requiring-a-linear-commit-history)\&quot; in the GitHub Help documentation. | [optional] |
| **allow_force_pushes** | **Boolean** | Permits force pushes to the protected branch by anyone with write access to the repository. Set to &#x60;true&#x60; to allow force pushes. Set to &#x60;false&#x60; or &#x60;null&#x60; to block force pushes. Default: &#x60;false&#x60;. For more information, see \&quot;[Enabling force pushes to a protected branch](https://docs.github.com/en/github/administering-a-repository/enabling-force-pushes-to-a-protected-branch)\&quot; in the GitHub Help documentation.\&quot; | [optional] |
| **allow_deletions** | **Boolean** | Allows deletion of the protected branch by anyone with write access to the repository. Set to &#x60;false&#x60; to prevent deletion of the protected branch. Default: &#x60;false&#x60;. For more information, see \&quot;[Enabling force pushes to a protected branch](https://docs.github.com/en/github/administering-a-repository/enabling-force-pushes-to-a-protected-branch)\&quot; in the GitHub Help documentation. | [optional] |
| **block_creations** | **Boolean** | If set to &#x60;true&#x60;, the &#x60;restrictions&#x60; branch protection settings which limits who can push will also block pushes which create new branches, unless the push is initiated by a user, team, or app which has the ability to push. Set to &#x60;true&#x60; to restrict new branch creation. Default: &#x60;false&#x60;. | [optional] |
| **required_conversation_resolution** | **Boolean** | Requires all conversations on code to be resolved before a pull request can be merged into a branch that matches this rule. Set to &#x60;false&#x60; to disable. Default: &#x60;false&#x60;. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ReposUpdateBranchProtectionRequest.new(
  required_status_checks: null,
  enforce_admins: null,
  required_pull_request_reviews: null,
  restrictions: null,
  required_linear_history: null,
  allow_force_pushes: null,
  allow_deletions: null,
  block_creations: null,
  required_conversation_resolution: null
)
```

