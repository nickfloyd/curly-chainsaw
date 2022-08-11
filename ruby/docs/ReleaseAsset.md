# OpenapiClient::ReleaseAsset

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **url** | **String** |  |  |
| **browser_download_url** | **String** |  |  |
| **id** | **Integer** |  |  |
| **node_id** | **String** |  |  |
| **name** | **String** | The file name of the asset. |  |
| **label** | **String** |  |  |
| **state** | **String** | State of the release asset. |  |
| **content_type** | **String** |  |  |
| **size** | **Integer** |  |  |
| **download_count** | **Integer** |  |  |
| **created_at** | **Time** |  |  |
| **updated_at** | **Time** |  |  |
| **uploader** | [**SimpleUser**](SimpleUser.md) |  |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ReleaseAsset.new(
  url: null,
  browser_download_url: null,
  id: null,
  node_id: null,
  name: Team Environment,
  label: null,
  state: null,
  content_type: null,
  size: null,
  download_count: null,
  created_at: null,
  updated_at: null,
  uploader: null
)
```

