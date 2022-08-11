# OpenapiClient::PullsMergeRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **commit_title** | **String** | Title for the automatic commit message. | [optional] |
| **commit_message** | **String** | Extra detail to append to automatic commit message. | [optional] |
| **sha** | **String** | SHA that pull request head must match to allow merge. | [optional] |
| **merge_method** | **String** | Merge method to use. Possible values are &#x60;merge&#x60;, &#x60;squash&#x60; or &#x60;rebase&#x60;. Default is &#x60;merge&#x60;. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::PullsMergeRequest.new(
  commit_title: null,
  commit_message: null,
  sha: null,
  merge_method: null
)
```

