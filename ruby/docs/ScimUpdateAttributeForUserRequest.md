# OpenapiClient::ScimUpdateAttributeForUserRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **schemas** | **Array&lt;String&gt;** |  | [optional] |
| **operations** | [**Array&lt;ScimUpdateAttributeForUserRequestOperationsInner&gt;**](ScimUpdateAttributeForUserRequestOperationsInner.md) | Set of operations to be performed |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ScimUpdateAttributeForUserRequest.new(
  schemas: null,
  operations: [{&quot;op&quot;:&quot;replace&quot;,&quot;value&quot;:{&quot;active&quot;:false}}]
)
```

