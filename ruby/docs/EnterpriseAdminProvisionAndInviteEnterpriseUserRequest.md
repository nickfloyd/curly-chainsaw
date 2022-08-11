# OpenapiClient::EnterpriseAdminProvisionAndInviteEnterpriseUserRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **schemas** | **Array&lt;String&gt;** | The SCIM schema URIs. |  |
| **user_name** | **String** | The username for the user. |  |
| **name** | [**EnterpriseAdminProvisionAndInviteEnterpriseUserRequestName**](EnterpriseAdminProvisionAndInviteEnterpriseUserRequestName.md) |  |  |
| **emails** | [**Array&lt;EnterpriseAdminProvisionAndInviteEnterpriseUserRequestEmailsInner&gt;**](EnterpriseAdminProvisionAndInviteEnterpriseUserRequestEmailsInner.md) | List of user emails. |  |
| **groups** | [**Array&lt;EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerGroupsInner&gt;**](EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerGroupsInner.md) | List of SCIM group IDs the user is a member of. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::EnterpriseAdminProvisionAndInviteEnterpriseUserRequest.new(
  schemas: null,
  user_name: null,
  name: null,
  emails: null,
  groups: null
)
```

