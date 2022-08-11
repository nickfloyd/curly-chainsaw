# OpenapiClient::ScimApi

All URIs are relative to *https://api.github.com*

| Method | HTTP request | Description |
| ------ | ------------ | ----------- |
| [**scim_delete_user_from_org**](ScimApi.md#scim_delete_user_from_org) | **DELETE** /scim/v2/organizations/{org}/Users/{scim_user_id} | Delete a SCIM user from an organization |
| [**scim_get_provisioning_information_for_user**](ScimApi.md#scim_get_provisioning_information_for_user) | **GET** /scim/v2/organizations/{org}/Users/{scim_user_id} | Get SCIM provisioning information for a user |
| [**scim_list_provisioned_identities**](ScimApi.md#scim_list_provisioned_identities) | **GET** /scim/v2/organizations/{org}/Users | List SCIM provisioned identities |
| [**scim_provision_and_invite_user**](ScimApi.md#scim_provision_and_invite_user) | **POST** /scim/v2/organizations/{org}/Users | Provision and invite a SCIM user |
| [**scim_set_information_for_provisioned_user**](ScimApi.md#scim_set_information_for_provisioned_user) | **PUT** /scim/v2/organizations/{org}/Users/{scim_user_id} | Update a provisioned organization membership |
| [**scim_update_attribute_for_user**](ScimApi.md#scim_update_attribute_for_user) | **PATCH** /scim/v2/organizations/{org}/Users/{scim_user_id} | Update an attribute for a SCIM user |


## scim_delete_user_from_org

> scim_delete_user_from_org(org, scim_user_id)

Delete a SCIM user from an organization



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ScimApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
scim_user_id = 'scim_user_id_example' # String | The unique identifier of the SCIM user.

begin
  # Delete a SCIM user from an organization
  api_instance.scim_delete_user_from_org(org, scim_user_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling ScimApi->scim_delete_user_from_org: #{e}"
end
```

#### Using the scim_delete_user_from_org_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> scim_delete_user_from_org_with_http_info(org, scim_user_id)

```ruby
begin
  # Delete a SCIM user from an organization
  data, status_code, headers = api_instance.scim_delete_user_from_org_with_http_info(org, scim_user_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling ScimApi->scim_delete_user_from_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **scim_user_id** | **String** | The unique identifier of the SCIM user. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/scim+json


## scim_get_provisioning_information_for_user

> <SCIMUsers> scim_get_provisioning_information_for_user(org, scim_user_id)

Get SCIM provisioning information for a user



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ScimApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
scim_user_id = 'scim_user_id_example' # String | The unique identifier of the SCIM user.

begin
  # Get SCIM provisioning information for a user
  result = api_instance.scim_get_provisioning_information_for_user(org, scim_user_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ScimApi->scim_get_provisioning_information_for_user: #{e}"
end
```

#### Using the scim_get_provisioning_information_for_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<SCIMUsers>, Integer, Hash)> scim_get_provisioning_information_for_user_with_http_info(org, scim_user_id)

```ruby
begin
  # Get SCIM provisioning information for a user
  data, status_code, headers = api_instance.scim_get_provisioning_information_for_user_with_http_info(org, scim_user_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <SCIMUsers>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ScimApi->scim_get_provisioning_information_for_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **scim_user_id** | **String** | The unique identifier of the SCIM user. |  |

### Return type

[**SCIMUsers**](SCIMUsers.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/scim+json, application/json


## scim_list_provisioned_identities

> <SCIMUserList> scim_list_provisioned_identities(org, opts)

List SCIM provisioned identities

Retrieves a paginated list of all provisioned organization members, including pending invitations. If you provide the `filter` parameter, the resources for all matching provisions members are returned.  When a user with a SAML-provisioned external identity leaves (or is removed from) an organization, the account's metadata is immediately removed. However, the returned list of user accounts might not always match the organization or enterprise member list you see on GitHub. This can happen in certain cases where an external identity associated with an organization will not match an organization member:   - When a user with a SCIM-provisioned external identity is removed from an organization, the account's metadata is preserved to allow the user to re-join the organization in the future.   - When inviting a user to join an organization, you can expect to see their external identity in the results before they accept the invitation, or if the invitation is cancelled (or never accepted).   - When a user is invited over SCIM, an external identity is created that matches with the invitee's email address. However, this identity is only linked to a user account when the user accepts the invitation by going through SAML SSO.  The returned list of external identities can include an entry for a `null` user. These are unlinked SAML identities that are created when a user goes through the following Single Sign-On (SSO) process but does not sign in to their GitHub account after completing SSO:  1. The user is granted access by the IdP and is not a member of the GitHub organization.  1. The user attempts to access the GitHub organization and initiates the SAML SSO process, and is not currently signed in to their GitHub account.  1. After successfully authenticating with the SAML SSO IdP, the `null` external identity entry is created and the user is prompted to sign in to their GitHub account:    - If the user signs in, their GitHub account is linked to this entry.    - If the user does not sign in (or does not create a new account when prompted), they are not added to the GitHub organization, and the external identity `null` entry remains in place.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ScimApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  start_index: 56, # Integer | Used for pagination: the index of the first result to return.
  count: 56, # Integer | Used for pagination: the number of results to return.
  filter: 'filter_example' # String | Filters results using the equals query parameter operator (`eq`). You can filter results that are equal to `id`, `userName`, `emails`, and `external_id`. For example, to search for an identity with the `userName` Octocat, you would use this query:  `?filter=userName%20eq%20\\\"Octocat\\\"`.  To filter results for the identity with the email `octocat@github.com`, you would use this query:  `?filter=emails%20eq%20\\\"octocat@github.com\\\"`.
}

begin
  # List SCIM provisioned identities
  result = api_instance.scim_list_provisioned_identities(org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ScimApi->scim_list_provisioned_identities: #{e}"
end
```

#### Using the scim_list_provisioned_identities_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<SCIMUserList>, Integer, Hash)> scim_list_provisioned_identities_with_http_info(org, opts)

```ruby
begin
  # List SCIM provisioned identities
  data, status_code, headers = api_instance.scim_list_provisioned_identities_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <SCIMUserList>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ScimApi->scim_list_provisioned_identities_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **start_index** | **Integer** | Used for pagination: the index of the first result to return. | [optional] |
| **count** | **Integer** | Used for pagination: the number of results to return. | [optional] |
| **filter** | **String** | Filters results using the equals query parameter operator (&#x60;eq&#x60;). You can filter results that are equal to &#x60;id&#x60;, &#x60;userName&#x60;, &#x60;emails&#x60;, and &#x60;external_id&#x60;. For example, to search for an identity with the &#x60;userName&#x60; Octocat, you would use this query:  &#x60;?filter&#x3D;userName%20eq%20\\\&quot;Octocat\\\&quot;&#x60;.  To filter results for the identity with the email &#x60;octocat@github.com&#x60;, you would use this query:  &#x60;?filter&#x3D;emails%20eq%20\\\&quot;octocat@github.com\\\&quot;&#x60;. | [optional] |

### Return type

[**SCIMUserList**](SCIMUserList.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/scim+json, application/json


## scim_provision_and_invite_user

> <SCIMUsers> scim_provision_and_invite_user(org, scim_provision_and_invite_user_request)

Provision and invite a SCIM user

Provision organization membership for a user, and send an activation email to the email address.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ScimApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
scim_provision_and_invite_user_request = OpenapiClient::ScimProvisionAndInviteUserRequest.new({user_name: 'someone@example.com', name: OpenapiClient::ScimProvisionAndInviteUserRequestName.new({given_name: 'given_name_example', family_name: 'family_name_example'}), emails: [{"value": "someone@example.com", "primary": true}, {"value": "another@example.com", "primary": false}]}) # ScimProvisionAndInviteUserRequest | 

begin
  # Provision and invite a SCIM user
  result = api_instance.scim_provision_and_invite_user(org, scim_provision_and_invite_user_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ScimApi->scim_provision_and_invite_user: #{e}"
end
```

#### Using the scim_provision_and_invite_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<SCIMUsers>, Integer, Hash)> scim_provision_and_invite_user_with_http_info(org, scim_provision_and_invite_user_request)

```ruby
begin
  # Provision and invite a SCIM user
  data, status_code, headers = api_instance.scim_provision_and_invite_user_with_http_info(org, scim_provision_and_invite_user_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <SCIMUsers>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ScimApi->scim_provision_and_invite_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **scim_provision_and_invite_user_request** | [**ScimProvisionAndInviteUserRequest**](ScimProvisionAndInviteUserRequest.md) |  |  |

### Return type

[**SCIMUsers**](SCIMUsers.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/scim+json, application/json


## scim_set_information_for_provisioned_user

> <SCIMUsers> scim_set_information_for_provisioned_user(org, scim_user_id, scim_set_information_for_provisioned_user_request)

Update a provisioned organization membership

Replaces an existing provisioned user's information. You must provide all the information required for the user as if you were provisioning them for the first time. Any existing user information that you don't provide will be removed. If you want to only update a specific attribute, use the [Update an attribute for a SCIM user](https://docs.github.com/rest/reference/scim#update-an-attribute-for-a-scim-user) endpoint instead.  You must at least provide the required values for the user: `userName`, `name`, and `emails`.  **Warning:** Setting `active: false` removes the user from the organization, deletes the external identity, and deletes the associated `{scim_user_id}`.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ScimApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
scim_user_id = 'scim_user_id_example' # String | The unique identifier of the SCIM user.
scim_set_information_for_provisioned_user_request = OpenapiClient::ScimSetInformationForProvisionedUserRequest.new({user_name: 'someone@example.com', name: OpenapiClient::ScimProvisionAndInviteUserRequestName.new({given_name: 'given_name_example', family_name: 'family_name_example'}), emails: [{"value": "someone@example.com", "primary": true}, {"value": "another@example.com", "primary": false}]}) # ScimSetInformationForProvisionedUserRequest | 

begin
  # Update a provisioned organization membership
  result = api_instance.scim_set_information_for_provisioned_user(org, scim_user_id, scim_set_information_for_provisioned_user_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ScimApi->scim_set_information_for_provisioned_user: #{e}"
end
```

#### Using the scim_set_information_for_provisioned_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<SCIMUsers>, Integer, Hash)> scim_set_information_for_provisioned_user_with_http_info(org, scim_user_id, scim_set_information_for_provisioned_user_request)

```ruby
begin
  # Update a provisioned organization membership
  data, status_code, headers = api_instance.scim_set_information_for_provisioned_user_with_http_info(org, scim_user_id, scim_set_information_for_provisioned_user_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <SCIMUsers>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ScimApi->scim_set_information_for_provisioned_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **scim_user_id** | **String** | The unique identifier of the SCIM user. |  |
| **scim_set_information_for_provisioned_user_request** | [**ScimSetInformationForProvisionedUserRequest**](ScimSetInformationForProvisionedUserRequest.md) |  |  |

### Return type

[**SCIMUsers**](SCIMUsers.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/scim+json, application/json


## scim_update_attribute_for_user

> <SCIMUsers> scim_update_attribute_for_user(org, scim_user_id, scim_update_attribute_for_user_request)

Update an attribute for a SCIM user

Allows you to change a provisioned user's individual attributes. To change a user's values, you must provide a specific `Operations` JSON format that contains at least one of the `add`, `remove`, or `replace` operations. For examples and more information on the SCIM operations format, see the [SCIM specification](https://tools.ietf.org/html/rfc7644#section-3.5.2).  **Note:** Complicated SCIM `path` selectors that include filters are not supported. For example, a `path` selector defined as `\"path\": \"emails[type eq \\\"work\\\"]\"` will not work.  **Warning:** If you set `active:false` using the `replace` operation (as shown in the JSON example below), it removes the user from the organization, deletes the external identity, and deletes the associated `:scim_user_id`.  ``` {   \"Operations\":[{     \"op\":\"replace\",     \"value\":{       \"active\":false     }   }] } ```

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ScimApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
scim_user_id = 'scim_user_id_example' # String | The unique identifier of the SCIM user.
scim_update_attribute_for_user_request = OpenapiClient::ScimUpdateAttributeForUserRequest.new({operations: [{"op": "replace", "value": {"active": false}}]}) # ScimUpdateAttributeForUserRequest | 

begin
  # Update an attribute for a SCIM user
  result = api_instance.scim_update_attribute_for_user(org, scim_user_id, scim_update_attribute_for_user_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ScimApi->scim_update_attribute_for_user: #{e}"
end
```

#### Using the scim_update_attribute_for_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<SCIMUsers>, Integer, Hash)> scim_update_attribute_for_user_with_http_info(org, scim_user_id, scim_update_attribute_for_user_request)

```ruby
begin
  # Update an attribute for a SCIM user
  data, status_code, headers = api_instance.scim_update_attribute_for_user_with_http_info(org, scim_user_id, scim_update_attribute_for_user_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <SCIMUsers>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ScimApi->scim_update_attribute_for_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **scim_user_id** | **String** | The unique identifier of the SCIM user. |  |
| **scim_update_attribute_for_user_request** | [**ScimUpdateAttributeForUserRequest**](ScimUpdateAttributeForUserRequest.md) |  |  |

### Return type

[**SCIMUsers**](SCIMUsers.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/scim+json, application/json

