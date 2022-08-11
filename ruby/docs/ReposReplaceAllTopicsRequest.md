# OpenapiClient::ReposReplaceAllTopicsRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **names** | **Array&lt;String&gt;** | An array of topics to add to the repository. Pass one or more topics to _replace_ the set of existing topics. Send an empty array (&#x60;[]&#x60;) to clear all topics from the repository. **Note:** Topic &#x60;names&#x60; cannot contain uppercase letters. |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ReposReplaceAllTopicsRequest.new(
  names: null
)
```

