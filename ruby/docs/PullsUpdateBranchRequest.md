# OpenapiClient::PullsUpdateBranchRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **expected_head_sha** | **String** | The expected SHA of the pull request&#39;s HEAD ref. This is the most recent commit on the pull request&#39;s branch. If the expected SHA does not match the pull request&#39;s HEAD, you will receive a &#x60;422 Unprocessable Entity&#x60; status. You can use the \&quot;[List commits](https://docs.github.com/rest/reference/repos#list-commits)\&quot; endpoint to find the most recent commit SHA. Default: SHA of the pull request&#39;s current HEAD ref. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::PullsUpdateBranchRequest.new(
  expected_head_sha: null
)
```

