# OpenapiClient::TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **groups** | [**Array&lt;TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequestGroupsInner&gt;**](TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequestGroupsInner.md) | The IdP groups you want to connect to a GitHub team. When updating, the new &#x60;groups&#x60; object will replace the original one. You must include any existing groups that you don&#39;t want to remove. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequest.new(
  groups: null
)
```

