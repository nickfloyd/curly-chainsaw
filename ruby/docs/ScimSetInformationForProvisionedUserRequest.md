# OpenapiClient::ScimSetInformationForProvisionedUserRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **schemas** | **Array&lt;String&gt;** |  | [optional] |
| **display_name** | **String** | The name of the user, suitable for display to end-users | [optional] |
| **external_id** | **String** |  | [optional] |
| **groups** | **Array&lt;String&gt;** |  | [optional] |
| **active** | **Boolean** |  | [optional] |
| **user_name** | **String** | Configured by the admin. Could be an email, login, or username |  |
| **name** | [**ScimProvisionAndInviteUserRequestName**](ScimProvisionAndInviteUserRequestName.md) |  |  |
| **emails** | [**Array&lt;ScimSetInformationForProvisionedUserRequestEmailsInner&gt;**](ScimSetInformationForProvisionedUserRequestEmailsInner.md) | user emails |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ScimSetInformationForProvisionedUserRequest.new(
  schemas: null,
  display_name: Jon Doe,
  external_id: null,
  groups: null,
  active: null,
  user_name: someone@example.com,
  name: null,
  emails: [{&quot;value&quot;:&quot;someone@example.com&quot;,&quot;primary&quot;:true},{&quot;value&quot;:&quot;another@example.com&quot;,&quot;primary&quot;:false}]
)
```

