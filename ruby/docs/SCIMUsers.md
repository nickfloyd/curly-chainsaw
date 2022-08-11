# OpenapiClient::SCIMUsers

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **schemas** | **Array&lt;String&gt;** | SCIM schema used. |  |
| **id** | **String** | Unique identifier of an external identity |  |
| **external_id** | **String** | The ID of the User. |  |
| **user_name** | **String** | Configured by the admin. Could be an email, login, or username |  |
| **display_name** | **String** | The name of the user, suitable for display to end-users | [optional] |
| **name** | [**SCIMUsersName**](SCIMUsersName.md) |  |  |
| **emails** | [**Array&lt;SCIMUsersEmailsInner&gt;**](SCIMUsersEmailsInner.md) | user emails |  |
| **active** | **Boolean** | The active status of the User. |  |
| **meta** | [**SCIMUsersMeta**](SCIMUsersMeta.md) |  |  |
| **organization_id** | **Integer** | The ID of the organization. | [optional] |
| **operations** | [**Array&lt;SCIMUsersOperationsInner&gt;**](SCIMUsersOperationsInner.md) | Set of operations to be performed | [optional] |
| **groups** | [**Array&lt;SCIMUsersGroupsInner&gt;**](SCIMUsersGroupsInner.md) | associated groups | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::SCIMUsers.new(
  schemas: null,
  id: 1b78eada-9baa-11e6-9eb6-a431576d590e,
  external_id: a7b0f98395,
  user_name: someone@example.com,
  display_name: Jon Doe,
  name: null,
  emails: [{&quot;value&quot;:&quot;someone@example.com&quot;,&quot;primary&quot;:true},{&quot;value&quot;:&quot;another@example.com&quot;,&quot;primary&quot;:false}],
  active: true,
  meta: null,
  organization_id: null,
  operations: [{&quot;op&quot;:&quot;replace&quot;,&quot;value&quot;:{&quot;active&quot;:false}}],
  groups: null
)
```

