# OpenapiClient::ReposAddCollaboratorRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **permission** | **String** | The permission to grant the collaborator. **Only valid on organization-owned repositories.** In addition to the enumerated values, you can also specify a custom repository role name, if the owning organization has defined any. | [optional][default to &#39;push&#39;] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ReposAddCollaboratorRequest.new(
  permission: null
)
```

