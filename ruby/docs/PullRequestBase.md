# OpenapiClient::PullRequestBase

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **label** | **String** |  |  |
| **ref** | **String** |  |  |
| **repo** | [**PullRequestBaseRepo**](PullRequestBaseRepo.md) |  |  |
| **sha** | **String** |  |  |
| **user** | [**PullRequestHeadRepoOwner**](PullRequestHeadRepoOwner.md) |  |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::PullRequestBase.new(
  label: null,
  ref: null,
  repo: null,
  sha: null,
  user: null
)
```

