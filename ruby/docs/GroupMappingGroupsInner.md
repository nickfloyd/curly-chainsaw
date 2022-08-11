# OpenapiClient::GroupMappingGroupsInner

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **group_id** | **String** | The ID of the group |  |
| **group_name** | **String** | The name of the group |  |
| **group_description** | **String** | a description of the group |  |
| **status** | **String** | synchronization status for this group mapping | [optional] |
| **synced_at** | **String** | the time of the last sync for this group-mapping | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::GroupMappingGroupsInner.new(
  group_id: 111a1a11-aaa1-1aaa-11a1-a1a1a1a1a1aa,
  group_name: saml-azuread-test,
  group_description: A group of Developers working on AzureAD SAML SSO,
  status: unsynced,
  synced_at: 2019-06-03 22:27:15:000 -700
)
```

