# OpenapiClient::EnterpriseAdminProvisionAndInviteEnterpriseUser201Response

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **schemas** | **Array&lt;String&gt;** |  |  |
| **id** | **String** |  |  |
| **external_id** | **String** |  | [optional] |
| **user_name** | **String** |  | [optional] |
| **name** | [**EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerName**](EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerName.md) |  | [optional] |
| **emails** | [**Array&lt;EnterpriseAdminProvisionAndInviteEnterpriseUser201ResponseEmailsInner&gt;**](EnterpriseAdminProvisionAndInviteEnterpriseUser201ResponseEmailsInner.md) |  | [optional] |
| **groups** | [**Array&lt;EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerGroupsInner&gt;**](EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerGroupsInner.md) |  | [optional] |
| **active** | **Boolean** |  | [optional] |
| **meta** | [**EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMeta**](EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMeta.md) |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::EnterpriseAdminProvisionAndInviteEnterpriseUser201Response.new(
  schemas: null,
  id: null,
  external_id: null,
  user_name: null,
  name: null,
  emails: null,
  groups: null,
  active: null,
  meta: null
)
```

