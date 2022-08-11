# OpenapiClient::GroupMapping

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **groups** | [**Array&lt;GroupMappingGroupsInner&gt;**](GroupMappingGroupsInner.md) | Array of groups to be mapped to this team | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::GroupMapping.new(
  groups: [{&quot;group_id&quot;:&quot;111a1a11-aaa1-1aaa-11a1-a1a1a1a1a1aa&quot;,&quot;group_name&quot;:&quot;saml-azuread-test&quot;,&quot;group_description&quot;:&quot;A group of Developers working on AzureAD SAML SSO&quot;},{&quot;group_id&quot;:&quot;2bb2bb2b-bb22-22bb-2bb2-bb2bbb2bb2b2&quot;,&quot;group_name&quot;:&quot;saml-azuread-test2&quot;,&quot;group_description&quot;:&quot;Another group of Developers working on AzureAD SAML SSO&quot;}]
)
```

