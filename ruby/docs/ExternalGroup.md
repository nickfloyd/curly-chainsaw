# OpenapiClient::ExternalGroup

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **group_id** | **Integer** | The internal ID of the group |  |
| **group_name** | **String** | The display name for the group |  |
| **updated_at** | **String** | The date when the group was last updated_at | [optional] |
| **teams** | [**Array&lt;ExternalGroupTeamsInner&gt;**](ExternalGroupTeamsInner.md) | An array of teams linked to this group |  |
| **members** | [**Array&lt;ExternalGroupMembersInner&gt;**](ExternalGroupMembersInner.md) | An array of external members linked to this group |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ExternalGroup.new(
  group_id: 1,
  group_name: group-azuread-test,
  updated_at: 2021-01-03 22:27:15:000 -700,
  teams: [{&quot;team_id&quot;:1,&quot;team_name&quot;:&quot;team-test&quot;},{&quot;team_id&quot;:2,&quot;team_name&quot;:&quot;team-test2&quot;}],
  members: [{&quot;member_id&quot;:1,&quot;member_login&quot;:&quot;mona-lisa_eocsaxrs&quot;,&quot;member_name&quot;:&quot;Mona Lisa&quot;,&quot;member_email&quot;:&quot;mona_lisa@github.com&quot;},{&quot;member_id&quot;:2,&quot;member_login&quot;:&quot;octo-lisa_eocsaxrs&quot;,&quot;member_name&quot;:&quot;Octo Lisa&quot;,&quot;member_email&quot;:&quot;octo_lisa@github.com&quot;}]
)
```

