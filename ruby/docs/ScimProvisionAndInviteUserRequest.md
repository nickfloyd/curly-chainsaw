# OpenapiClient::ScimProvisionAndInviteUserRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **user_name** | **String** | Configured by the admin. Could be an email, login, or username |  |
| **display_name** | **String** | The name of the user, suitable for display to end-users | [optional] |
| **name** | [**ScimProvisionAndInviteUserRequestName**](ScimProvisionAndInviteUserRequestName.md) |  |  |
| **emails** | [**Array&lt;ScimProvisionAndInviteUserRequestEmailsInner&gt;**](ScimProvisionAndInviteUserRequestEmailsInner.md) | user emails |  |
| **schemas** | **Array&lt;String&gt;** |  | [optional] |
| **external_id** | **String** |  | [optional] |
| **groups** | **Array&lt;String&gt;** |  | [optional] |
| **active** | **Boolean** |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ScimProvisionAndInviteUserRequest.new(
  user_name: someone@example.com,
  display_name: Jon Doe,
  name: null,
  emails: [{&quot;value&quot;:&quot;someone@example.com&quot;,&quot;primary&quot;:true},{&quot;value&quot;:&quot;another@example.com&quot;,&quot;primary&quot;:false}],
  schemas: null,
  external_id: null,
  groups: null,
  active: null
)
```

