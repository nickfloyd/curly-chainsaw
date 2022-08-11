# OpenapiClient::EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **schemas** | **Array&lt;String&gt;** | The SCIM schema URIs. |  |
| **display_name** | **String** | The name of the SCIM group. This must match the GitHub organization that the group maps to. |  |
| **members** | [**Array&lt;EnterpriseAdminProvisionAndInviteEnterpriseGroupRequestMembersInner&gt;**](EnterpriseAdminProvisionAndInviteEnterpriseGroupRequestMembersInner.md) |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest.new(
  schemas: null,
  display_name: null,
  members: null
)
```

