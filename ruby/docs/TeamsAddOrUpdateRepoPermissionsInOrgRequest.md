# OpenapiClient::TeamsAddOrUpdateRepoPermissionsInOrgRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **permission** | **String** | The permission to grant the team on this repository. In addition to the enumerated values, you can also specify a custom repository role name, if the owning organization has defined any. If no permission is specified, the team&#39;s &#x60;permission&#x60; attribute will be used to determine what permission to grant the team on this repository. | [optional][default to &#39;push&#39;] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::TeamsAddOrUpdateRepoPermissionsInOrgRequest.new(
  permission: null
)
```

