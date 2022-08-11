# OpenapiClient::AutolinkReference

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **id** | **Integer** |  |  |
| **key_prefix** | **String** | The prefix of a key that is linkified. |  |
| **url_template** | **String** | A template for the target URL that is generated if a key was found. |  |
| **is_alphanumeric** | **Boolean** | Whether this autolink reference matches alphanumeric characters. If false, this autolink reference is a legacy autolink that only matches numeric characters. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::AutolinkReference.new(
  id: 3,
  key_prefix: TICKET-,
  url_template: https://example.com/TICKET?query&#x3D;&lt;num&gt;,
  is_alphanumeric: null
)
```

