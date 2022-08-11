# OpenapiClient::GistHistory

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **user** | [**SimpleUser**](SimpleUser.md) |  | [optional] |
| **version** | **String** |  | [optional] |
| **committed_at** | **Time** |  | [optional] |
| **change_status** | [**GistHistoryChangeStatus**](GistHistoryChangeStatus.md) |  | [optional] |
| **url** | **String** |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::GistHistory.new(
  user: null,
  version: null,
  committed_at: null,
  change_status: null,
  url: null
)
```

