# OpenapiClient::Commit

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **url** | **String** |  |  |
| **sha** | **String** |  |  |
| **node_id** | **String** |  |  |
| **html_url** | **String** |  |  |
| **comments_url** | **String** |  |  |
| **commit** | [**CommitCommit**](CommitCommit.md) |  |  |
| **author** | [**SimpleUser**](SimpleUser.md) |  |  |
| **committer** | [**SimpleUser**](SimpleUser.md) |  |  |
| **parents** | [**Array&lt;CommitParentsInner&gt;**](CommitParentsInner.md) |  |  |
| **stats** | [**CommitStats**](CommitStats.md) |  | [optional] |
| **files** | [**Array&lt;DiffEntry&gt;**](DiffEntry.md) |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::Commit.new(
  url: https://api.github.com/repos/octocat/Hello-World/commits/6dcb09b5b57875f334f61aebed695e2e4193db5e,
  sha: 6dcb09b5b57875f334f61aebed695e2e4193db5e,
  node_id: MDY6Q29tbWl0NmRjYjA5YjViNTc4NzVmMzM0ZjYxYWViZWQ2OTVlMmU0MTkzZGI1ZQ&#x3D;&#x3D;,
  html_url: https://github.com/octocat/Hello-World/commit/6dcb09b5b57875f334f61aebed695e2e4193db5e,
  comments_url: https://api.github.com/repos/octocat/Hello-World/commits/6dcb09b5b57875f334f61aebed695e2e4193db5e/comments,
  commit: null,
  author: null,
  committer: null,
  parents: null,
  stats: null,
  files: null
)
```

