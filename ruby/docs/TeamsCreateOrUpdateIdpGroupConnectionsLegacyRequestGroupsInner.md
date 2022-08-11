# OpenapiClient::TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequestGroupsInner

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **group_id** | **String** | ID of the IdP group. |  |
| **group_name** | **String** | Name of the IdP group. |  |
| **group_description** | **String** | Description of the IdP group. |  |
| **id** | **String** |  | [optional] |
| **name** | **String** |  | [optional] |
| **description** | **String** |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequestGroupsInner.new(
  group_id: null,
  group_name: null,
  group_description: null,
  id: &quot;caceab43fc9ffa20081c&quot;,
  name: &quot;external-team-6c13e7288ef7&quot;,
  description: &quot;moar cheese pleese&quot;
)
```

