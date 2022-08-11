# OpenapiClient::ReposCreateAutolinkRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **key_prefix** | **String** | The prefix appended by alphanumeric characters will generate a link any time it is found in an issue, pull request, or commit. |  |
| **url_template** | **String** | The URL must contain &#x60;&lt;num&gt;&#x60; for the reference number. &#x60;&lt;num&gt;&#x60; matches alphanumeric characters &#x60;A-Z&#x60; (case insensitive), &#x60;0-9&#x60;, and &#x60;-&#x60;. |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ReposCreateAutolinkRequest.new(
  key_prefix: null,
  url_template: null
)
```

