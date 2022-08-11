# OpenapiClient::GistsUpdateRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **description** | **String** | Description of the gist | [optional] |
| **files** | [**Hash&lt;String, GistsUpdateRequestFilesValue&gt;**](GistsUpdateRequestFilesValue.md) | Names of files to be updated | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::GistsUpdateRequest.new(
  description: Example Ruby script,
  files: {&quot;hello.rb&quot;:{&quot;content&quot;:&quot;blah&quot;,&quot;filename&quot;:&quot;goodbye.rb&quot;}}
)
```

