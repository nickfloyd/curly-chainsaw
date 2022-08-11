# OpenapiClient::Label

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **id** | **Integer** |  |  |
| **node_id** | **String** |  |  |
| **url** | **String** | URL for the label |  |
| **name** | **String** | The name of the label. |  |
| **description** | **String** |  |  |
| **color** | **String** | 6-character hex code, without the leading #, identifying the color |  |
| **default** | **Boolean** |  |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::Label.new(
  id: 208045946,
  node_id: MDU6TGFiZWwyMDgwNDU5NDY&#x3D;,
  url: https://api.github.com/repositories/42/labels/bug,
  name: bug,
  description: Something isn&#39;t working,
  color: FFFFFF,
  default: true
)
```

