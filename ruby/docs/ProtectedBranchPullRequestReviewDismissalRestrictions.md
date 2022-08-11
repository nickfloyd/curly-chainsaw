# OpenapiClient::ProtectedBranchPullRequestReviewDismissalRestrictions

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **users** | [**Array&lt;SimpleUser1&gt;**](SimpleUser1.md) | The list of users with review dismissal access. | [optional] |
| **teams** | [**Array&lt;Team&gt;**](Team.md) | The list of teams with review dismissal access. | [optional] |
| **apps** | [**Array&lt;GitHubApp&gt;**](GitHubApp.md) | The list of apps with review dismissal access. | [optional] |
| **url** | **String** |  | [optional] |
| **users_url** | **String** |  | [optional] |
| **teams_url** | **String** |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ProtectedBranchPullRequestReviewDismissalRestrictions.new(
  users: null,
  teams: null,
  apps: null,
  url: &quot;https://api.github.com/repos/the-org/an-org-repo/branches/master/protection/dismissal_restrictions&quot;,
  users_url: &quot;https://api.github.com/repos/the-org/an-org-repo/branches/master/protection/dismissal_restrictions/users&quot;,
  teams_url: &quot;https://api.github.com/repos/the-org/an-org-repo/branches/master/protection/dismissal_restrictions/teams&quot;
)
```

