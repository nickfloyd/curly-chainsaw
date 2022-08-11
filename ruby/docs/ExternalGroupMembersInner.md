# OpenapiClient::ExternalGroupMembersInner

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **member_id** | **Integer** | The internal user ID of the identity |  |
| **member_login** | **String** | The handle/login for the user |  |
| **member_name** | **String** | The user display name/profile name |  |
| **member_email** | **String** | An email attached to a user |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ExternalGroupMembersInner.new(
  member_id: 1,
  member_login: mona-lisa_eocsaxrs,
  member_name: Mona Lisa,
  member_email: mona_lisa@github.com
)
```

