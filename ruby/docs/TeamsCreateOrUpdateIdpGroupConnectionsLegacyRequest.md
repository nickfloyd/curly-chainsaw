# OpenapiClient::TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **groups** | [**Array&lt;TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequestGroupsInner&gt;**](TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequestGroupsInner.md) | The IdP groups you want to connect to a GitHub team. When updating, the new &#x60;groups&#x60; object will replace the original one. You must include any existing groups that you don&#39;t want to remove. |  |
| **synced_at** | **String** |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequest.new(
  groups: null,
  synced_at: &quot;I am not a timestamp&quot;
)
```

