# OpenapiClient::SimpleCommit

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **id** | **String** |  |  |
| **tree_id** | **String** |  |  |
| **message** | **String** |  |  |
| **timestamp** | **Time** |  |  |
| **author** | [**SimpleCommitAuthor**](SimpleCommitAuthor.md) |  |  |
| **committer** | [**SimpleCommitAuthor**](SimpleCommitAuthor.md) |  |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::SimpleCommit.new(
  id: null,
  tree_id: null,
  message: null,
  timestamp: null,
  author: null,
  committer: null
)
```

