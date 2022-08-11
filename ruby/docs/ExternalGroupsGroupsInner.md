# OpenapiClient::ExternalGroupsGroupsInner

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **group_id** | **Integer** | The internal ID of the group |  |
| **group_name** | **String** | The display name of the group |  |
| **updated_at** | **String** | The time of the last update for this group |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ExternalGroupsGroupsInner.new(
  group_id: 1,
  group_name: group-azuread-test,
  updated_at: 2019-06-03 22:27:15:000 -700
)
```

