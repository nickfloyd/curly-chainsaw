# OpenapiClient::OrgsListCustomRoles200Response

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **total_count** | **Integer** | The number of custom roles in this organization | [optional] |
| **custom_roles** | [**Array&lt;OrganizationCustomRepositoryRole&gt;**](OrganizationCustomRepositoryRole.md) |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::OrgsListCustomRoles200Response.new(
  total_count: 3,
  custom_roles: null
)
```

