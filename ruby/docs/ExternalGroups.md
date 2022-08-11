# OpenapiClient::ExternalGroups

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **groups** | [**Array&lt;ExternalGroupsGroupsInner&gt;**](ExternalGroupsGroupsInner.md) | An array of external groups available to be mapped to a team | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ExternalGroups.new(
  groups: [{&quot;group_id&quot;:1,&quot;group_name&quot;:&quot;group-azuread-test&quot;,&quot;updated_at&quot;:&quot;2021-01-03 22:27:15:000 -700&quot;},{&quot;group_id&quot;:2,&quot;group_name&quot;:&quot;group-azuread-test2&quot;,&quot;updated_at&quot;:&quot;2021-06-03 22:27:15:000 -700&quot;}]
)
```

