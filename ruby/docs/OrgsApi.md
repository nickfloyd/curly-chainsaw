# OpenapiClient::OrgsApi

All URIs are relative to *https://api.github.com*

| Method | HTTP request | Description |
| ------ | ------------ | ----------- |
| [**orgs_add_security_manager_team**](OrgsApi.md#orgs_add_security_manager_team) | **PUT** /orgs/{org}/security-managers/teams/{team_slug} | Add a security manager team |
| [**orgs_block_user**](OrgsApi.md#orgs_block_user) | **PUT** /orgs/{org}/blocks/{username} | Block a user from an organization |
| [**orgs_cancel_invitation**](OrgsApi.md#orgs_cancel_invitation) | **DELETE** /orgs/{org}/invitations/{invitation_id} | Cancel an organization invitation |
| [**orgs_check_blocked_user**](OrgsApi.md#orgs_check_blocked_user) | **GET** /orgs/{org}/blocks/{username} | Check if a user is blocked by an organization |
| [**orgs_check_membership_for_user**](OrgsApi.md#orgs_check_membership_for_user) | **GET** /orgs/{org}/members/{username} | Check organization membership for a user |
| [**orgs_check_public_membership_for_user**](OrgsApi.md#orgs_check_public_membership_for_user) | **GET** /orgs/{org}/public_members/{username} | Check public organization membership for a user |
| [**orgs_convert_member_to_outside_collaborator**](OrgsApi.md#orgs_convert_member_to_outside_collaborator) | **PUT** /orgs/{org}/outside_collaborators/{username} | Convert an organization member to outside collaborator |
| [**orgs_create_invitation**](OrgsApi.md#orgs_create_invitation) | **POST** /orgs/{org}/invitations | Create an organization invitation |
| [**orgs_create_webhook**](OrgsApi.md#orgs_create_webhook) | **POST** /orgs/{org}/hooks | Create an organization webhook |
| [**orgs_delete_webhook**](OrgsApi.md#orgs_delete_webhook) | **DELETE** /orgs/{org}/hooks/{hook_id} | Delete an organization webhook |
| [**orgs_get**](OrgsApi.md#orgs_get) | **GET** /orgs/{org} | Get an organization |
| [**orgs_get_audit_log**](OrgsApi.md#orgs_get_audit_log) | **GET** /orgs/{org}/audit-log | Get the audit log for an organization |
| [**orgs_get_membership_for_authenticated_user**](OrgsApi.md#orgs_get_membership_for_authenticated_user) | **GET** /user/memberships/orgs/{org} | Get an organization membership for the authenticated user |
| [**orgs_get_membership_for_user**](OrgsApi.md#orgs_get_membership_for_user) | **GET** /orgs/{org}/memberships/{username} | Get organization membership for a user |
| [**orgs_get_webhook**](OrgsApi.md#orgs_get_webhook) | **GET** /orgs/{org}/hooks/{hook_id} | Get an organization webhook |
| [**orgs_get_webhook_config_for_org**](OrgsApi.md#orgs_get_webhook_config_for_org) | **GET** /orgs/{org}/hooks/{hook_id}/config | Get a webhook configuration for an organization |
| [**orgs_get_webhook_delivery**](OrgsApi.md#orgs_get_webhook_delivery) | **GET** /orgs/{org}/hooks/{hook_id}/deliveries/{delivery_id} | Get a webhook delivery for an organization webhook |
| [**orgs_list**](OrgsApi.md#orgs_list) | **GET** /organizations | List organizations |
| [**orgs_list_app_installations**](OrgsApi.md#orgs_list_app_installations) | **GET** /orgs/{org}/installations | List app installations for an organization |
| [**orgs_list_blocked_users**](OrgsApi.md#orgs_list_blocked_users) | **GET** /orgs/{org}/blocks | List users blocked by an organization |
| [**orgs_list_custom_roles**](OrgsApi.md#orgs_list_custom_roles) | **GET** /organizations/{organization_id}/custom_roles | List custom repository roles in an organization |
| [**orgs_list_failed_invitations**](OrgsApi.md#orgs_list_failed_invitations) | **GET** /orgs/{org}/failed_invitations | List failed organization invitations |
| [**orgs_list_for_authenticated_user**](OrgsApi.md#orgs_list_for_authenticated_user) | **GET** /user/orgs | List organizations for the authenticated user |
| [**orgs_list_for_user**](OrgsApi.md#orgs_list_for_user) | **GET** /users/{username}/orgs | List organizations for a user |
| [**orgs_list_invitation_teams**](OrgsApi.md#orgs_list_invitation_teams) | **GET** /orgs/{org}/invitations/{invitation_id}/teams | List organization invitation teams |
| [**orgs_list_members**](OrgsApi.md#orgs_list_members) | **GET** /orgs/{org}/members | List organization members |
| [**orgs_list_memberships_for_authenticated_user**](OrgsApi.md#orgs_list_memberships_for_authenticated_user) | **GET** /user/memberships/orgs | List organization memberships for the authenticated user |
| [**orgs_list_outside_collaborators**](OrgsApi.md#orgs_list_outside_collaborators) | **GET** /orgs/{org}/outside_collaborators | List outside collaborators for an organization |
| [**orgs_list_pending_invitations**](OrgsApi.md#orgs_list_pending_invitations) | **GET** /orgs/{org}/invitations | List pending organization invitations |
| [**orgs_list_public_members**](OrgsApi.md#orgs_list_public_members) | **GET** /orgs/{org}/public_members | List public organization members |
| [**orgs_list_saml_sso_authorizations**](OrgsApi.md#orgs_list_saml_sso_authorizations) | **GET** /orgs/{org}/credential-authorizations | List SAML SSO authorizations for an organization |
| [**orgs_list_security_manager_teams**](OrgsApi.md#orgs_list_security_manager_teams) | **GET** /orgs/{org}/security-managers | List security manager teams |
| [**orgs_list_webhook_deliveries**](OrgsApi.md#orgs_list_webhook_deliveries) | **GET** /orgs/{org}/hooks/{hook_id}/deliveries | List deliveries for an organization webhook |
| [**orgs_list_webhooks**](OrgsApi.md#orgs_list_webhooks) | **GET** /orgs/{org}/hooks | List organization webhooks |
| [**orgs_ping_webhook**](OrgsApi.md#orgs_ping_webhook) | **POST** /orgs/{org}/hooks/{hook_id}/pings | Ping an organization webhook |
| [**orgs_redeliver_webhook_delivery**](OrgsApi.md#orgs_redeliver_webhook_delivery) | **POST** /orgs/{org}/hooks/{hook_id}/deliveries/{delivery_id}/attempts | Redeliver a delivery for an organization webhook |
| [**orgs_remove_member**](OrgsApi.md#orgs_remove_member) | **DELETE** /orgs/{org}/members/{username} | Remove an organization member |
| [**orgs_remove_membership_for_user**](OrgsApi.md#orgs_remove_membership_for_user) | **DELETE** /orgs/{org}/memberships/{username} | Remove organization membership for a user |
| [**orgs_remove_outside_collaborator**](OrgsApi.md#orgs_remove_outside_collaborator) | **DELETE** /orgs/{org}/outside_collaborators/{username} | Remove outside collaborator from an organization |
| [**orgs_remove_public_membership_for_authenticated_user**](OrgsApi.md#orgs_remove_public_membership_for_authenticated_user) | **DELETE** /orgs/{org}/public_members/{username} | Remove public organization membership for the authenticated user |
| [**orgs_remove_saml_sso_authorization**](OrgsApi.md#orgs_remove_saml_sso_authorization) | **DELETE** /orgs/{org}/credential-authorizations/{credential_id} | Remove a SAML SSO authorization for an organization |
| [**orgs_remove_security_manager_team**](OrgsApi.md#orgs_remove_security_manager_team) | **DELETE** /orgs/{org}/security-managers/teams/{team_slug} | Remove a security manager team |
| [**orgs_set_membership_for_user**](OrgsApi.md#orgs_set_membership_for_user) | **PUT** /orgs/{org}/memberships/{username} | Set organization membership for a user |
| [**orgs_set_public_membership_for_authenticated_user**](OrgsApi.md#orgs_set_public_membership_for_authenticated_user) | **PUT** /orgs/{org}/public_members/{username} | Set public organization membership for the authenticated user |
| [**orgs_unblock_user**](OrgsApi.md#orgs_unblock_user) | **DELETE** /orgs/{org}/blocks/{username} | Unblock a user from an organization |
| [**orgs_update**](OrgsApi.md#orgs_update) | **PATCH** /orgs/{org} | Update an organization |
| [**orgs_update_membership_for_authenticated_user**](OrgsApi.md#orgs_update_membership_for_authenticated_user) | **PATCH** /user/memberships/orgs/{org} | Update an organization membership for the authenticated user |
| [**orgs_update_webhook**](OrgsApi.md#orgs_update_webhook) | **PATCH** /orgs/{org}/hooks/{hook_id} | Update an organization webhook |
| [**orgs_update_webhook_config_for_org**](OrgsApi.md#orgs_update_webhook_config_for_org) | **PATCH** /orgs/{org}/hooks/{hook_id}/config | Update a webhook configuration for an organization |


## orgs_add_security_manager_team

> orgs_add_security_manager_team(org, team_slug)

Add a security manager team

Adds a team as a security manager for an organization. For more information, see \"[Managing security for an organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization) for an organization.\"  To use this endpoint, you must be an administrator for the organization, and you must use an access token with the `write:org` scope.  GitHub Apps must have the `administration` organization read-write permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
team_slug = 'team_slug_example' # String | The slug of the team name.

begin
  # Add a security manager team
  api_instance.orgs_add_security_manager_team(org, team_slug)
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_add_security_manager_team: #{e}"
end
```

#### Using the orgs_add_security_manager_team_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> orgs_add_security_manager_team_with_http_info(org, team_slug)

```ruby
begin
  # Add a security manager team
  data, status_code, headers = api_instance.orgs_add_security_manager_team_with_http_info(org, team_slug)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_add_security_manager_team_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **team_slug** | **String** | The slug of the team name. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## orgs_block_user

> orgs_block_user(org, username)

Block a user from an organization



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
username = 'username_example' # String | The handle for the GitHub user account.

begin
  # Block a user from an organization
  api_instance.orgs_block_user(org, username)
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_block_user: #{e}"
end
```

#### Using the orgs_block_user_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> orgs_block_user_with_http_info(org, username)

```ruby
begin
  # Block a user from an organization
  data, status_code, headers = api_instance.orgs_block_user_with_http_info(org, username)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_block_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **username** | **String** | The handle for the GitHub user account. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_cancel_invitation

> orgs_cancel_invitation(org, invitation_id)

Cancel an organization invitation

Cancel an organization invitation. In order to cancel an organization invitation, the authenticated user must be an organization owner.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications).

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
invitation_id = 56 # Integer | The unique identifier of the invitation.

begin
  # Cancel an organization invitation
  api_instance.orgs_cancel_invitation(org, invitation_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_cancel_invitation: #{e}"
end
```

#### Using the orgs_cancel_invitation_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> orgs_cancel_invitation_with_http_info(org, invitation_id)

```ruby
begin
  # Cancel an organization invitation
  data, status_code, headers = api_instance.orgs_cancel_invitation_with_http_info(org, invitation_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_cancel_invitation_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **invitation_id** | **Integer** | The unique identifier of the invitation. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_check_blocked_user

> orgs_check_blocked_user(org, username)

Check if a user is blocked by an organization



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
username = 'username_example' # String | The handle for the GitHub user account.

begin
  # Check if a user is blocked by an organization
  api_instance.orgs_check_blocked_user(org, username)
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_check_blocked_user: #{e}"
end
```

#### Using the orgs_check_blocked_user_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> orgs_check_blocked_user_with_http_info(org, username)

```ruby
begin
  # Check if a user is blocked by an organization
  data, status_code, headers = api_instance.orgs_check_blocked_user_with_http_info(org, username)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_check_blocked_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **username** | **String** | The handle for the GitHub user account. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_check_membership_for_user

> orgs_check_membership_for_user(org, username)

Check organization membership for a user

Check if a user is, publicly or privately, a member of the organization.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
username = 'username_example' # String | The handle for the GitHub user account.

begin
  # Check organization membership for a user
  api_instance.orgs_check_membership_for_user(org, username)
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_check_membership_for_user: #{e}"
end
```

#### Using the orgs_check_membership_for_user_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> orgs_check_membership_for_user_with_http_info(org, username)

```ruby
begin
  # Check organization membership for a user
  data, status_code, headers = api_instance.orgs_check_membership_for_user_with_http_info(org, username)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_check_membership_for_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **username** | **String** | The handle for the GitHub user account. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## orgs_check_public_membership_for_user

> orgs_check_public_membership_for_user(org, username)

Check public organization membership for a user



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
username = 'username_example' # String | The handle for the GitHub user account.

begin
  # Check public organization membership for a user
  api_instance.orgs_check_public_membership_for_user(org, username)
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_check_public_membership_for_user: #{e}"
end
```

#### Using the orgs_check_public_membership_for_user_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> orgs_check_public_membership_for_user_with_http_info(org, username)

```ruby
begin
  # Check public organization membership for a user
  data, status_code, headers = api_instance.orgs_check_public_membership_for_user_with_http_info(org, username)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_check_public_membership_for_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **username** | **String** | The handle for the GitHub user account. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## orgs_convert_member_to_outside_collaborator

> Object orgs_convert_member_to_outside_collaborator(org, username, opts)

Convert an organization member to outside collaborator

When an organization member is converted to an outside collaborator, they'll only have access to the repositories that their current team membership allows. The user will no longer be a member of the organization. For more information, see \"[Converting an organization member to an outside collaborator](https://docs.github.com/articles/converting-an-organization-member-to-an-outside-collaborator/)\". Converting an organization member to an outside collaborator may be restricted by enterprise administrators. For more information, see \"[Enforcing repository management policies in your enterprise](https://docs.github.com/enterprise-cloud@latest/admin/policies/enforcing-policies-for-your-enterprise/enforcing-repository-management-policies-in-your-enterprise#enforcing-a-policy-for-inviting-outside-collaborators-to-repositories).\"

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
username = 'username_example' # String | The handle for the GitHub user account.
opts = {
  orgs_convert_member_to_outside_collaborator_request: OpenapiClient::OrgsConvertMemberToOutsideCollaboratorRequest.new # OrgsConvertMemberToOutsideCollaboratorRequest | 
}

begin
  # Convert an organization member to outside collaborator
  result = api_instance.orgs_convert_member_to_outside_collaborator(org, username, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_convert_member_to_outside_collaborator: #{e}"
end
```

#### Using the orgs_convert_member_to_outside_collaborator_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Object, Integer, Hash)> orgs_convert_member_to_outside_collaborator_with_http_info(org, username, opts)

```ruby
begin
  # Convert an organization member to outside collaborator
  data, status_code, headers = api_instance.orgs_convert_member_to_outside_collaborator_with_http_info(org, username, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Object
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_convert_member_to_outside_collaborator_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **username** | **String** | The handle for the GitHub user account. |  |
| **orgs_convert_member_to_outside_collaborator_request** | [**OrgsConvertMemberToOutsideCollaboratorRequest**](OrgsConvertMemberToOutsideCollaboratorRequest.md) |  | [optional] |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## orgs_create_invitation

> <OrganizationInvitation> orgs_create_invitation(org, opts)

Create an organization invitation

Invite people to an organization by using their GitHub user ID or their email address. In order to create invitations in an organization, the authenticated user must be an organization owner.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \"[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\" and \"[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\" for details.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  orgs_create_invitation_request: OpenapiClient::OrgsCreateInvitationRequest.new # OrgsCreateInvitationRequest | 
}

begin
  # Create an organization invitation
  result = api_instance.orgs_create_invitation(org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_create_invitation: #{e}"
end
```

#### Using the orgs_create_invitation_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<OrganizationInvitation>, Integer, Hash)> orgs_create_invitation_with_http_info(org, opts)

```ruby
begin
  # Create an organization invitation
  data, status_code, headers = api_instance.orgs_create_invitation_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <OrganizationInvitation>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_create_invitation_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **orgs_create_invitation_request** | [**OrgsCreateInvitationRequest**](OrgsCreateInvitationRequest.md) |  | [optional] |

### Return type

[**OrganizationInvitation**](OrganizationInvitation.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## orgs_create_webhook

> <OrgHook> orgs_create_webhook(org, orgs_create_webhook_request)

Create an organization webhook

Here's how you can create a hook that posts payloads in JSON format:

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
orgs_create_webhook_request = OpenapiClient::OrgsCreateWebhookRequest.new({name: 'name_example', config: OpenapiClient::OrgsCreateWebhookRequestConfig.new({url: 'https://example.com/webhook'})}) # OrgsCreateWebhookRequest | 

begin
  # Create an organization webhook
  result = api_instance.orgs_create_webhook(org, orgs_create_webhook_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_create_webhook: #{e}"
end
```

#### Using the orgs_create_webhook_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<OrgHook>, Integer, Hash)> orgs_create_webhook_with_http_info(org, orgs_create_webhook_request)

```ruby
begin
  # Create an organization webhook
  data, status_code, headers = api_instance.orgs_create_webhook_with_http_info(org, orgs_create_webhook_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <OrgHook>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_create_webhook_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **orgs_create_webhook_request** | [**OrgsCreateWebhookRequest**](OrgsCreateWebhookRequest.md) |  |  |

### Return type

[**OrgHook**](OrgHook.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## orgs_delete_webhook

> orgs_delete_webhook(org, hook_id)

Delete an organization webhook



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
hook_id = 56 # Integer | The unique identifier of the hook.

begin
  # Delete an organization webhook
  api_instance.orgs_delete_webhook(org, hook_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_delete_webhook: #{e}"
end
```

#### Using the orgs_delete_webhook_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> orgs_delete_webhook_with_http_info(org, hook_id)

```ruby
begin
  # Delete an organization webhook
  data, status_code, headers = api_instance.orgs_delete_webhook_with_http_info(org, hook_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_delete_webhook_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **hook_id** | **Integer** | The unique identifier of the hook. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_get

> <OrganizationFull> orgs_get(org)

Get an organization

To see many of the organization response values, you need to be an authenticated organization owner with the `admin:org` scope. When the value of `two_factor_requirement_enabled` is `true`, the organization requires all members, billing managers, and outside collaborators to enable [two-factor authentication](https://docs.github.com/articles/securing-your-account-with-two-factor-authentication-2fa/).  GitHub Apps with the `Organization plan` permission can use this endpoint to retrieve information about an organization's GitHub plan. See \"[Authenticating with GitHub Apps](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/)\" for details. For an example response, see 'Response with GitHub plan information' below.\"

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.

begin
  # Get an organization
  result = api_instance.orgs_get(org)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_get: #{e}"
end
```

#### Using the orgs_get_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<OrganizationFull>, Integer, Hash)> orgs_get_with_http_info(org)

```ruby
begin
  # Get an organization
  data, status_code, headers = api_instance.orgs_get_with_http_info(org)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <OrganizationFull>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_get_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |

### Return type

[**OrganizationFull**](OrganizationFull.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_get_audit_log

> <Array<EnterpriseAdminGetAuditLog200ResponseInner>> orgs_get_audit_log(org, opts)

Get the audit log for an organization

Gets the audit log for an organization. For more information, see \"[Reviewing the audit log for your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/reviewing-the-audit-log-for-your-organization).\"  This endpoint is available for organizations on GitHub Enterprise Cloud. To use this endpoint, you must be an organization owner, and you must use an access token with the `admin:org` scope. GitHub Apps must have the `organization_administration` read permission to use this endpoint.  By default, the response includes up to 30 events from the past three months. Use the `phrase` parameter to filter results and retrieve older events. For example, use the `phrase` parameter with the `created` qualifier to filter events based on when the events occurred. For more information, see \"[Reviewing the audit log for your organization](https://docs.github.com/organizations/keeping-your-organization-secure/managing-security-settings-for-your-organization/reviewing-the-audit-log-for-your-organization#searching-the-audit-log).\"  Use pagination to retrieve fewer or more than 30 events. For more information, see \"[Resources in the REST API](https://docs.github.com/rest/overview/resources-in-the-rest-api#pagination).\"

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  phrase: 'phrase_example', # String | A search phrase. For more information, see [Searching the audit log](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/reviewing-the-audit-log-for-your-organization#searching-the-audit-log).
  include: 'web', # String | The event types to include:  - `web` - returns web (non-Git) events. - `git` - returns Git events. - `all` - returns both web and Git events.  The default is `web`.
  after: 'after_example', # String | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.
  before: 'before_example', # String | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor.
  order: 'desc', # String | The order of audit log events. To list newest events first, specify `desc`. To list oldest events first, specify `asc`.  The default is `desc`.
  per_page: 56 # Integer | The number of results per page (max 100).
}

begin
  # Get the audit log for an organization
  result = api_instance.orgs_get_audit_log(org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_get_audit_log: #{e}"
end
```

#### Using the orgs_get_audit_log_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<EnterpriseAdminGetAuditLog200ResponseInner>>, Integer, Hash)> orgs_get_audit_log_with_http_info(org, opts)

```ruby
begin
  # Get the audit log for an organization
  data, status_code, headers = api_instance.orgs_get_audit_log_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<EnterpriseAdminGetAuditLog200ResponseInner>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_get_audit_log_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **phrase** | **String** | A search phrase. For more information, see [Searching the audit log](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/reviewing-the-audit-log-for-your-organization#searching-the-audit-log). | [optional] |
| **include** | **String** | The event types to include:  - &#x60;web&#x60; - returns web (non-Git) events. - &#x60;git&#x60; - returns Git events. - &#x60;all&#x60; - returns both web and Git events.  The default is &#x60;web&#x60;. | [optional] |
| **after** | **String** | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor. | [optional] |
| **before** | **String** | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. | [optional] |
| **order** | **String** | The order of audit log events. To list newest events first, specify &#x60;desc&#x60;. To list oldest events first, specify &#x60;asc&#x60;.  The default is &#x60;desc&#x60;. | [optional] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |

### Return type

[**Array&lt;EnterpriseAdminGetAuditLog200ResponseInner&gt;**](EnterpriseAdminGetAuditLog200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_get_membership_for_authenticated_user

> <OrgMembership> orgs_get_membership_for_authenticated_user(org)

Get an organization membership for the authenticated user



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.

begin
  # Get an organization membership for the authenticated user
  result = api_instance.orgs_get_membership_for_authenticated_user(org)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_get_membership_for_authenticated_user: #{e}"
end
```

#### Using the orgs_get_membership_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<OrgMembership>, Integer, Hash)> orgs_get_membership_for_authenticated_user_with_http_info(org)

```ruby
begin
  # Get an organization membership for the authenticated user
  data, status_code, headers = api_instance.orgs_get_membership_for_authenticated_user_with_http_info(org)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <OrgMembership>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_get_membership_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |

### Return type

[**OrgMembership**](OrgMembership.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_get_membership_for_user

> <OrgMembership> orgs_get_membership_for_user(org, username)

Get organization membership for a user

In order to get a user's membership with an organization, the authenticated user must be an organization member. The `state` parameter in the response can be used to identify the user's membership status.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
username = 'username_example' # String | The handle for the GitHub user account.

begin
  # Get organization membership for a user
  result = api_instance.orgs_get_membership_for_user(org, username)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_get_membership_for_user: #{e}"
end
```

#### Using the orgs_get_membership_for_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<OrgMembership>, Integer, Hash)> orgs_get_membership_for_user_with_http_info(org, username)

```ruby
begin
  # Get organization membership for a user
  data, status_code, headers = api_instance.orgs_get_membership_for_user_with_http_info(org, username)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <OrgMembership>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_get_membership_for_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **username** | **String** | The handle for the GitHub user account. |  |

### Return type

[**OrgMembership**](OrgMembership.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_get_webhook

> <OrgHook> orgs_get_webhook(org, hook_id)

Get an organization webhook

Returns a webhook configured in an organization. To get only the webhook `config` properties, see \"[Get a webhook configuration for an organization](/rest/reference/orgs#get-a-webhook-configuration-for-an-organization).\"

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
hook_id = 56 # Integer | The unique identifier of the hook.

begin
  # Get an organization webhook
  result = api_instance.orgs_get_webhook(org, hook_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_get_webhook: #{e}"
end
```

#### Using the orgs_get_webhook_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<OrgHook>, Integer, Hash)> orgs_get_webhook_with_http_info(org, hook_id)

```ruby
begin
  # Get an organization webhook
  data, status_code, headers = api_instance.orgs_get_webhook_with_http_info(org, hook_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <OrgHook>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_get_webhook_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **hook_id** | **Integer** | The unique identifier of the hook. |  |

### Return type

[**OrgHook**](OrgHook.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_get_webhook_config_for_org

> <WebhookConfiguration> orgs_get_webhook_config_for_org(org, hook_id)

Get a webhook configuration for an organization

Returns the webhook configuration for an organization. To get more information about the webhook, including the `active` state and `events`, use \"[Get an organization webhook ](/rest/reference/orgs#get-an-organization-webhook).\"  Access tokens must have the `admin:org_hook` scope, and GitHub Apps must have the `organization_hooks:read` permission.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
hook_id = 56 # Integer | The unique identifier of the hook.

begin
  # Get a webhook configuration for an organization
  result = api_instance.orgs_get_webhook_config_for_org(org, hook_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_get_webhook_config_for_org: #{e}"
end
```

#### Using the orgs_get_webhook_config_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<WebhookConfiguration>, Integer, Hash)> orgs_get_webhook_config_for_org_with_http_info(org, hook_id)

```ruby
begin
  # Get a webhook configuration for an organization
  data, status_code, headers = api_instance.orgs_get_webhook_config_for_org_with_http_info(org, hook_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <WebhookConfiguration>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_get_webhook_config_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **hook_id** | **Integer** | The unique identifier of the hook. |  |

### Return type

[**WebhookConfiguration**](WebhookConfiguration.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_get_webhook_delivery

> <WebhookDelivery> orgs_get_webhook_delivery(org, hook_id, delivery_id)

Get a webhook delivery for an organization webhook

Returns a delivery for a webhook configured in an organization.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
hook_id = 56 # Integer | The unique identifier of the hook.
delivery_id = 56 # Integer | 

begin
  # Get a webhook delivery for an organization webhook
  result = api_instance.orgs_get_webhook_delivery(org, hook_id, delivery_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_get_webhook_delivery: #{e}"
end
```

#### Using the orgs_get_webhook_delivery_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<WebhookDelivery>, Integer, Hash)> orgs_get_webhook_delivery_with_http_info(org, hook_id, delivery_id)

```ruby
begin
  # Get a webhook delivery for an organization webhook
  data, status_code, headers = api_instance.orgs_get_webhook_delivery_with_http_info(org, hook_id, delivery_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <WebhookDelivery>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_get_webhook_delivery_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **hook_id** | **Integer** | The unique identifier of the hook. |  |
| **delivery_id** | **Integer** |  |  |

### Return type

[**WebhookDelivery**](WebhookDelivery.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/scim+json


## orgs_list

> <Array<OrganizationSimple>> orgs_list(opts)

List organizations

Lists all organizations, in the order that they were created on GitHub.  **Note:** Pagination is powered exclusively by the `since` parameter. Use the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header) to get the URL for the next page of organizations.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
opts = {
  since: 56, # Integer | An organization ID. Only return organizations with an ID greater than this ID.
  per_page: 56 # Integer | The number of results per page (max 100).
}

begin
  # List organizations
  result = api_instance.orgs_list(opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list: #{e}"
end
```

#### Using the orgs_list_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<OrganizationSimple>>, Integer, Hash)> orgs_list_with_http_info(opts)

```ruby
begin
  # List organizations
  data, status_code, headers = api_instance.orgs_list_with_http_info(opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<OrganizationSimple>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **since** | **Integer** | An organization ID. Only return organizations with an ID greater than this ID. | [optional] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |

### Return type

[**Array&lt;OrganizationSimple&gt;**](OrganizationSimple.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_list_app_installations

> <OrgsListAppInstallations200Response> orgs_list_app_installations(org, opts)

List app installations for an organization

Lists all GitHub Apps in an organization. The installation count includes all GitHub Apps installed on repositories in the organization. You must be an organization owner with `admin:read` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List app installations for an organization
  result = api_instance.orgs_list_app_installations(org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_app_installations: #{e}"
end
```

#### Using the orgs_list_app_installations_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<OrgsListAppInstallations200Response>, Integer, Hash)> orgs_list_app_installations_with_http_info(org, opts)

```ruby
begin
  # List app installations for an organization
  data, status_code, headers = api_instance.orgs_list_app_installations_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <OrgsListAppInstallations200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_app_installations_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**OrgsListAppInstallations200Response**](OrgsListAppInstallations200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_list_blocked_users

> <Array<SimpleUser1>> orgs_list_blocked_users(org)

List users blocked by an organization

List the users blocked by an organization.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.

begin
  # List users blocked by an organization
  result = api_instance.orgs_list_blocked_users(org)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_blocked_users: #{e}"
end
```

#### Using the orgs_list_blocked_users_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<SimpleUser1>>, Integer, Hash)> orgs_list_blocked_users_with_http_info(org)

```ruby
begin
  # List users blocked by an organization
  data, status_code, headers = api_instance.orgs_list_blocked_users_with_http_info(org)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<SimpleUser1>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_blocked_users_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |

### Return type

[**Array&lt;SimpleUser1&gt;**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_list_custom_roles

> <OrgsListCustomRoles200Response> orgs_list_custom_roles(organization_id)

List custom repository roles in an organization

List the custom repository roles available in this organization. In order to see custom repository roles in an organization, the authenticated user must be an organization owner.  For more information on custom repository roles, see \"[Managing custom repository roles for an organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-custom-repository-roles-for-an-organization)\".

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
organization_id = 'organization_id_example' # String | 

begin
  # List custom repository roles in an organization
  result = api_instance.orgs_list_custom_roles(organization_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_custom_roles: #{e}"
end
```

#### Using the orgs_list_custom_roles_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<OrgsListCustomRoles200Response>, Integer, Hash)> orgs_list_custom_roles_with_http_info(organization_id)

```ruby
begin
  # List custom repository roles in an organization
  data, status_code, headers = api_instance.orgs_list_custom_roles_with_http_info(organization_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <OrgsListCustomRoles200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_custom_roles_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **organization_id** | **String** |  |  |

### Return type

[**OrgsListCustomRoles200Response**](OrgsListCustomRoles200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_list_failed_invitations

> <Array<OrganizationInvitation>> orgs_list_failed_invitations(org, opts)

List failed organization invitations

The return hash contains `failed_at` and `failed_reason` fields which represent the time at which the invitation failed and the reason for the failure.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List failed organization invitations
  result = api_instance.orgs_list_failed_invitations(org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_failed_invitations: #{e}"
end
```

#### Using the orgs_list_failed_invitations_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<OrganizationInvitation>>, Integer, Hash)> orgs_list_failed_invitations_with_http_info(org, opts)

```ruby
begin
  # List failed organization invitations
  data, status_code, headers = api_instance.orgs_list_failed_invitations_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<OrganizationInvitation>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_failed_invitations_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;OrganizationInvitation&gt;**](OrganizationInvitation.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_list_for_authenticated_user

> <Array<OrganizationSimple>> orgs_list_for_authenticated_user(opts)

List organizations for the authenticated user

List organizations for the authenticated user.  **OAuth scope requirements**  This only lists organizations that your authorization allows you to operate on in some way (e.g., you can list teams with `read:org` scope, you can publicize your organization membership with `user` scope, etc.). Therefore, this API requires at least `user` or `read:org` scope. OAuth requests with insufficient scope receive a `403 Forbidden` response.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List organizations for the authenticated user
  result = api_instance.orgs_list_for_authenticated_user(opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_for_authenticated_user: #{e}"
end
```

#### Using the orgs_list_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<OrganizationSimple>>, Integer, Hash)> orgs_list_for_authenticated_user_with_http_info(opts)

```ruby
begin
  # List organizations for the authenticated user
  data, status_code, headers = api_instance.orgs_list_for_authenticated_user_with_http_info(opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<OrganizationSimple>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;OrganizationSimple&gt;**](OrganizationSimple.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_list_for_user

> <Array<OrganizationSimple>> orgs_list_for_user(username, opts)

List organizations for a user

List [public organization memberships](https://docs.github.com/articles/publicizing-or-concealing-organization-membership) for the specified user.  This method only lists _public_ memberships, regardless of authentication. If you need to fetch all of the organization memberships (public and private) for the authenticated user, use the [List organizations for the authenticated user](https://docs.github.com/rest/reference/orgs#list-organizations-for-the-authenticated-user) API instead.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
username = 'username_example' # String | The handle for the GitHub user account.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List organizations for a user
  result = api_instance.orgs_list_for_user(username, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_for_user: #{e}"
end
```

#### Using the orgs_list_for_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<OrganizationSimple>>, Integer, Hash)> orgs_list_for_user_with_http_info(username, opts)

```ruby
begin
  # List organizations for a user
  data, status_code, headers = api_instance.orgs_list_for_user_with_http_info(username, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<OrganizationSimple>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_for_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **username** | **String** | The handle for the GitHub user account. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;OrganizationSimple&gt;**](OrganizationSimple.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_list_invitation_teams

> <Array<Team>> orgs_list_invitation_teams(org, invitation_id, opts)

List organization invitation teams

List all teams associated with an invitation. In order to see invitations in an organization, the authenticated user must be an organization owner.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
invitation_id = 56 # Integer | The unique identifier of the invitation.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List organization invitation teams
  result = api_instance.orgs_list_invitation_teams(org, invitation_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_invitation_teams: #{e}"
end
```

#### Using the orgs_list_invitation_teams_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<Team>>, Integer, Hash)> orgs_list_invitation_teams_with_http_info(org, invitation_id, opts)

```ruby
begin
  # List organization invitation teams
  data, status_code, headers = api_instance.orgs_list_invitation_teams_with_http_info(org, invitation_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<Team>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_invitation_teams_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **invitation_id** | **Integer** | The unique identifier of the invitation. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;Team&gt;**](Team.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_list_members

> <Array<SimpleUser1>> orgs_list_members(org, opts)

List organization members

List all users who are members of an organization. If the authenticated user is also a member of this organization then both concealed and public members will be returned.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  filter: '2fa_disabled', # String | Filter members returned in the list. `2fa_disabled` means that only members without [two-factor authentication](https://github.com/blog/1614-two-factor-authentication) enabled will be returned. This options is only available for organization owners.
  role: 'all', # String | Filter members returned by their role.
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List organization members
  result = api_instance.orgs_list_members(org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_members: #{e}"
end
```

#### Using the orgs_list_members_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<SimpleUser1>>, Integer, Hash)> orgs_list_members_with_http_info(org, opts)

```ruby
begin
  # List organization members
  data, status_code, headers = api_instance.orgs_list_members_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<SimpleUser1>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_members_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **filter** | **String** | Filter members returned in the list. &#x60;2fa_disabled&#x60; means that only members without [two-factor authentication](https://github.com/blog/1614-two-factor-authentication) enabled will be returned. This options is only available for organization owners. | [optional][default to &#39;all&#39;] |
| **role** | **String** | Filter members returned by their role. | [optional][default to &#39;all&#39;] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;SimpleUser1&gt;**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_list_memberships_for_authenticated_user

> <Array<OrgMembership>> orgs_list_memberships_for_authenticated_user(opts)

List organization memberships for the authenticated user



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
opts = {
  state: 'active', # String | Indicates the state of the memberships to return. Can be either `active` or `pending`. If not specified, the API returns both active and pending memberships.
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List organization memberships for the authenticated user
  result = api_instance.orgs_list_memberships_for_authenticated_user(opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_memberships_for_authenticated_user: #{e}"
end
```

#### Using the orgs_list_memberships_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<OrgMembership>>, Integer, Hash)> orgs_list_memberships_for_authenticated_user_with_http_info(opts)

```ruby
begin
  # List organization memberships for the authenticated user
  data, status_code, headers = api_instance.orgs_list_memberships_for_authenticated_user_with_http_info(opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<OrgMembership>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_memberships_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **state** | **String** | Indicates the state of the memberships to return. Can be either &#x60;active&#x60; or &#x60;pending&#x60;. If not specified, the API returns both active and pending memberships. | [optional] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;OrgMembership&gt;**](OrgMembership.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_list_outside_collaborators

> <Array<SimpleUser1>> orgs_list_outside_collaborators(org, opts)

List outside collaborators for an organization

List all users who are outside collaborators of an organization.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  filter: '2fa_disabled', # String | Filter the list of outside collaborators. `2fa_disabled` means that only outside collaborators without [two-factor authentication](https://github.com/blog/1614-two-factor-authentication) enabled will be returned.
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List outside collaborators for an organization
  result = api_instance.orgs_list_outside_collaborators(org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_outside_collaborators: #{e}"
end
```

#### Using the orgs_list_outside_collaborators_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<SimpleUser1>>, Integer, Hash)> orgs_list_outside_collaborators_with_http_info(org, opts)

```ruby
begin
  # List outside collaborators for an organization
  data, status_code, headers = api_instance.orgs_list_outside_collaborators_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<SimpleUser1>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_outside_collaborators_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **filter** | **String** | Filter the list of outside collaborators. &#x60;2fa_disabled&#x60; means that only outside collaborators without [two-factor authentication](https://github.com/blog/1614-two-factor-authentication) enabled will be returned. | [optional][default to &#39;all&#39;] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;SimpleUser1&gt;**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_list_pending_invitations

> <Array<OrganizationInvitation>> orgs_list_pending_invitations(org, opts)

List pending organization invitations

The return hash contains a `role` field which refers to the Organization Invitation role and will be one of the following values: `direct_member`, `admin`, `billing_manager`, `hiring_manager`, or `reinstate`. If the invitee is not a GitHub member, the `login` field in the return hash will be `null`.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List pending organization invitations
  result = api_instance.orgs_list_pending_invitations(org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_pending_invitations: #{e}"
end
```

#### Using the orgs_list_pending_invitations_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<OrganizationInvitation>>, Integer, Hash)> orgs_list_pending_invitations_with_http_info(org, opts)

```ruby
begin
  # List pending organization invitations
  data, status_code, headers = api_instance.orgs_list_pending_invitations_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<OrganizationInvitation>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_pending_invitations_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;OrganizationInvitation&gt;**](OrganizationInvitation.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_list_public_members

> <Array<SimpleUser1>> orgs_list_public_members(org, opts)

List public organization members

Members of an organization can choose to have their membership publicized or not.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List public organization members
  result = api_instance.orgs_list_public_members(org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_public_members: #{e}"
end
```

#### Using the orgs_list_public_members_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<SimpleUser1>>, Integer, Hash)> orgs_list_public_members_with_http_info(org, opts)

```ruby
begin
  # List public organization members
  data, status_code, headers = api_instance.orgs_list_public_members_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<SimpleUser1>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_public_members_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;SimpleUser1&gt;**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_list_saml_sso_authorizations

> <Array<CredentialAuthorization>> orgs_list_saml_sso_authorizations(org, opts)

List SAML SSO authorizations for an organization

Listing and deleting credential authorizations is available to organizations with GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).  An authenticated organization owner with the `read:org` scope can list all credential authorizations for an organization that uses SAML single sign-on (SSO). The credentials are either personal access tokens or SSH keys that organization members have authorized for the organization. For more information, see [About authentication with SAML single sign-on](https://docs.github.com/en/articles/about-authentication-with-saml-single-sign-on).

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56, # Integer | Page token
  login: 'login_example' # String | Limits the list of credentials authorizations for an organization to a specific login
}

begin
  # List SAML SSO authorizations for an organization
  result = api_instance.orgs_list_saml_sso_authorizations(org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_saml_sso_authorizations: #{e}"
end
```

#### Using the orgs_list_saml_sso_authorizations_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<CredentialAuthorization>>, Integer, Hash)> orgs_list_saml_sso_authorizations_with_http_info(org, opts)

```ruby
begin
  # List SAML SSO authorizations for an organization
  data, status_code, headers = api_instance.orgs_list_saml_sso_authorizations_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<CredentialAuthorization>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_saml_sso_authorizations_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page token | [optional] |
| **login** | **String** | Limits the list of credentials authorizations for an organization to a specific login | [optional] |

### Return type

[**Array&lt;CredentialAuthorization&gt;**](CredentialAuthorization.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_list_security_manager_teams

> <Array<TeamSimple1>> orgs_list_security_manager_teams(org)

List security manager teams

Lists teams that are security managers for an organization. For more information, see \"[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).\"  To use this endpoint, you must be an administrator or security manager for the organization, and you must use an access token with the `read:org` scope.  GitHub Apps must have the `administration` organization read permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.

begin
  # List security manager teams
  result = api_instance.orgs_list_security_manager_teams(org)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_security_manager_teams: #{e}"
end
```

#### Using the orgs_list_security_manager_teams_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<TeamSimple1>>, Integer, Hash)> orgs_list_security_manager_teams_with_http_info(org)

```ruby
begin
  # List security manager teams
  data, status_code, headers = api_instance.orgs_list_security_manager_teams_with_http_info(org)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<TeamSimple1>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_security_manager_teams_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |

### Return type

[**Array&lt;TeamSimple1&gt;**](TeamSimple1.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_list_webhook_deliveries

> <Array<SimpleWebhookDelivery>> orgs_list_webhook_deliveries(org, hook_id, opts)

List deliveries for an organization webhook

Returns a list of webhook deliveries for a webhook configured in an organization.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
hook_id = 56 # Integer | The unique identifier of the hook.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  cursor: 'cursor_example' # String | Used for pagination: the starting delivery from which the page of deliveries is fetched. Refer to the `link` header for the next and previous page cursors.
}

begin
  # List deliveries for an organization webhook
  result = api_instance.orgs_list_webhook_deliveries(org, hook_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_webhook_deliveries: #{e}"
end
```

#### Using the orgs_list_webhook_deliveries_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<SimpleWebhookDelivery>>, Integer, Hash)> orgs_list_webhook_deliveries_with_http_info(org, hook_id, opts)

```ruby
begin
  # List deliveries for an organization webhook
  data, status_code, headers = api_instance.orgs_list_webhook_deliveries_with_http_info(org, hook_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<SimpleWebhookDelivery>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_webhook_deliveries_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **hook_id** | **Integer** | The unique identifier of the hook. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **cursor** | **String** | Used for pagination: the starting delivery from which the page of deliveries is fetched. Refer to the &#x60;link&#x60; header for the next and previous page cursors. | [optional] |

### Return type

[**Array&lt;SimpleWebhookDelivery&gt;**](SimpleWebhookDelivery.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/scim+json


## orgs_list_webhooks

> <Array<OrgHook>> orgs_list_webhooks(org, opts)

List organization webhooks



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List organization webhooks
  result = api_instance.orgs_list_webhooks(org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_webhooks: #{e}"
end
```

#### Using the orgs_list_webhooks_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<OrgHook>>, Integer, Hash)> orgs_list_webhooks_with_http_info(org, opts)

```ruby
begin
  # List organization webhooks
  data, status_code, headers = api_instance.orgs_list_webhooks_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<OrgHook>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_list_webhooks_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;OrgHook&gt;**](OrgHook.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_ping_webhook

> orgs_ping_webhook(org, hook_id)

Ping an organization webhook

This will trigger a [ping event](https://docs.github.com/webhooks/#ping-event) to be sent to the hook.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
hook_id = 56 # Integer | The unique identifier of the hook.

begin
  # Ping an organization webhook
  api_instance.orgs_ping_webhook(org, hook_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_ping_webhook: #{e}"
end
```

#### Using the orgs_ping_webhook_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> orgs_ping_webhook_with_http_info(org, hook_id)

```ruby
begin
  # Ping an organization webhook
  data, status_code, headers = api_instance.orgs_ping_webhook_with_http_info(org, hook_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_ping_webhook_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **hook_id** | **Integer** | The unique identifier of the hook. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_redeliver_webhook_delivery

> Object orgs_redeliver_webhook_delivery(org, hook_id, delivery_id)

Redeliver a delivery for an organization webhook

Redeliver a delivery for a webhook configured in an organization.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
hook_id = 56 # Integer | The unique identifier of the hook.
delivery_id = 56 # Integer | 

begin
  # Redeliver a delivery for an organization webhook
  result = api_instance.orgs_redeliver_webhook_delivery(org, hook_id, delivery_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_redeliver_webhook_delivery: #{e}"
end
```

#### Using the orgs_redeliver_webhook_delivery_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Object, Integer, Hash)> orgs_redeliver_webhook_delivery_with_http_info(org, hook_id, delivery_id)

```ruby
begin
  # Redeliver a delivery for an organization webhook
  data, status_code, headers = api_instance.orgs_redeliver_webhook_delivery_with_http_info(org, hook_id, delivery_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Object
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_redeliver_webhook_delivery_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **hook_id** | **Integer** | The unique identifier of the hook. |  |
| **delivery_id** | **Integer** |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/scim+json


## orgs_remove_member

> orgs_remove_member(org, username)

Remove an organization member

Removing a user from this list will remove them from all teams and they will no longer have any access to the organization's repositories.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
username = 'username_example' # String | The handle for the GitHub user account.

begin
  # Remove an organization member
  api_instance.orgs_remove_member(org, username)
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_remove_member: #{e}"
end
```

#### Using the orgs_remove_member_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> orgs_remove_member_with_http_info(org, username)

```ruby
begin
  # Remove an organization member
  data, status_code, headers = api_instance.orgs_remove_member_with_http_info(org, username)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_remove_member_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **username** | **String** | The handle for the GitHub user account. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_remove_membership_for_user

> orgs_remove_membership_for_user(org, username)

Remove organization membership for a user

In order to remove a user's membership with an organization, the authenticated user must be an organization owner.  If the specified user is an active member of the organization, this will remove them from the organization. If the specified user has been invited to the organization, this will cancel their invitation. The specified user will receive an email notification in both cases.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
username = 'username_example' # String | The handle for the GitHub user account.

begin
  # Remove organization membership for a user
  api_instance.orgs_remove_membership_for_user(org, username)
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_remove_membership_for_user: #{e}"
end
```

#### Using the orgs_remove_membership_for_user_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> orgs_remove_membership_for_user_with_http_info(org, username)

```ruby
begin
  # Remove organization membership for a user
  data, status_code, headers = api_instance.orgs_remove_membership_for_user_with_http_info(org, username)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_remove_membership_for_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **username** | **String** | The handle for the GitHub user account. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_remove_outside_collaborator

> orgs_remove_outside_collaborator(org, username)

Remove outside collaborator from an organization

Removing a user from this list will remove them from all the organization's repositories.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
username = 'username_example' # String | The handle for the GitHub user account.

begin
  # Remove outside collaborator from an organization
  api_instance.orgs_remove_outside_collaborator(org, username)
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_remove_outside_collaborator: #{e}"
end
```

#### Using the orgs_remove_outside_collaborator_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> orgs_remove_outside_collaborator_with_http_info(org, username)

```ruby
begin
  # Remove outside collaborator from an organization
  data, status_code, headers = api_instance.orgs_remove_outside_collaborator_with_http_info(org, username)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_remove_outside_collaborator_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **username** | **String** | The handle for the GitHub user account. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_remove_public_membership_for_authenticated_user

> orgs_remove_public_membership_for_authenticated_user(org, username)

Remove public organization membership for the authenticated user



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
username = 'username_example' # String | The handle for the GitHub user account.

begin
  # Remove public organization membership for the authenticated user
  api_instance.orgs_remove_public_membership_for_authenticated_user(org, username)
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_remove_public_membership_for_authenticated_user: #{e}"
end
```

#### Using the orgs_remove_public_membership_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> orgs_remove_public_membership_for_authenticated_user_with_http_info(org, username)

```ruby
begin
  # Remove public organization membership for the authenticated user
  data, status_code, headers = api_instance.orgs_remove_public_membership_for_authenticated_user_with_http_info(org, username)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_remove_public_membership_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **username** | **String** | The handle for the GitHub user account. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## orgs_remove_saml_sso_authorization

> orgs_remove_saml_sso_authorization(org, credential_id)

Remove a SAML SSO authorization for an organization

Listing and deleting credential authorizations is available to organizations with GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).  An authenticated organization owner with the `admin:org` scope can remove a credential authorization for an organization that uses SAML SSO. Once you remove someone's credential authorization, they will need to create a new personal access token or SSH key and authorize it for the organization they want to access.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
credential_id = 56 # Integer | 

begin
  # Remove a SAML SSO authorization for an organization
  api_instance.orgs_remove_saml_sso_authorization(org, credential_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_remove_saml_sso_authorization: #{e}"
end
```

#### Using the orgs_remove_saml_sso_authorization_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> orgs_remove_saml_sso_authorization_with_http_info(org, credential_id)

```ruby
begin
  # Remove a SAML SSO authorization for an organization
  data, status_code, headers = api_instance.orgs_remove_saml_sso_authorization_with_http_info(org, credential_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_remove_saml_sso_authorization_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **credential_id** | **Integer** |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_remove_security_manager_team

> orgs_remove_security_manager_team(org, team_slug)

Remove a security manager team

Removes the security manager role from a team for an organization. For more information, see \"[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization) team from an organization.\"  To use this endpoint, you must be an administrator for the organization, and you must use an access token with the `admin:org` scope.  GitHub Apps must have the `administration` organization read-write permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
team_slug = 'team_slug_example' # String | The slug of the team name.

begin
  # Remove a security manager team
  api_instance.orgs_remove_security_manager_team(org, team_slug)
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_remove_security_manager_team: #{e}"
end
```

#### Using the orgs_remove_security_manager_team_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> orgs_remove_security_manager_team_with_http_info(org, team_slug)

```ruby
begin
  # Remove a security manager team
  data, status_code, headers = api_instance.orgs_remove_security_manager_team_with_http_info(org, team_slug)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_remove_security_manager_team_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **team_slug** | **String** | The slug of the team name. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## orgs_set_membership_for_user

> <OrgMembership> orgs_set_membership_for_user(org, username, opts)

Set organization membership for a user

Only authenticated organization owners can add a member to the organization or update the member's role.  *   If the authenticated user is _adding_ a member to the organization, the invited user will receive an email inviting them to the organization. The user's [membership status](https://docs.github.com/rest/reference/orgs#get-organization-membership-for-a-user) will be `pending` until they accept the invitation.      *   Authenticated users can _update_ a user's membership by passing the `role` parameter. If the authenticated user changes a member's role to `admin`, the affected user will receive an email notifying them that they've been made an organization owner. If the authenticated user changes an owner's role to `member`, no email will be sent.  **Rate limits**  To prevent abuse, the authenticated user is limited to 50 organization invitations per 24 hour period. If the organization is more than one month old or on a paid plan, the limit is 500 invitations per 24 hour period.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
username = 'username_example' # String | The handle for the GitHub user account.
opts = {
  orgs_set_membership_for_user_request: OpenapiClient::OrgsSetMembershipForUserRequest.new # OrgsSetMembershipForUserRequest | 
}

begin
  # Set organization membership for a user
  result = api_instance.orgs_set_membership_for_user(org, username, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_set_membership_for_user: #{e}"
end
```

#### Using the orgs_set_membership_for_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<OrgMembership>, Integer, Hash)> orgs_set_membership_for_user_with_http_info(org, username, opts)

```ruby
begin
  # Set organization membership for a user
  data, status_code, headers = api_instance.orgs_set_membership_for_user_with_http_info(org, username, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <OrgMembership>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_set_membership_for_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **username** | **String** | The handle for the GitHub user account. |  |
| **orgs_set_membership_for_user_request** | [**OrgsSetMembershipForUserRequest**](OrgsSetMembershipForUserRequest.md) |  | [optional] |

### Return type

[**OrgMembership**](OrgMembership.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## orgs_set_public_membership_for_authenticated_user

> orgs_set_public_membership_for_authenticated_user(org, username)

Set public organization membership for the authenticated user

The user can publicize their own membership. (A user cannot publicize the membership for another user.)  Note that you'll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see \"[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\"

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
username = 'username_example' # String | The handle for the GitHub user account.

begin
  # Set public organization membership for the authenticated user
  api_instance.orgs_set_public_membership_for_authenticated_user(org, username)
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_set_public_membership_for_authenticated_user: #{e}"
end
```

#### Using the orgs_set_public_membership_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> orgs_set_public_membership_for_authenticated_user_with_http_info(org, username)

```ruby
begin
  # Set public organization membership for the authenticated user
  data, status_code, headers = api_instance.orgs_set_public_membership_for_authenticated_user_with_http_info(org, username)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_set_public_membership_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **username** | **String** | The handle for the GitHub user account. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## orgs_unblock_user

> orgs_unblock_user(org, username)

Unblock a user from an organization



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
username = 'username_example' # String | The handle for the GitHub user account.

begin
  # Unblock a user from an organization
  api_instance.orgs_unblock_user(org, username)
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_unblock_user: #{e}"
end
```

#### Using the orgs_unblock_user_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> orgs_unblock_user_with_http_info(org, username)

```ruby
begin
  # Unblock a user from an organization
  data, status_code, headers = api_instance.orgs_unblock_user_with_http_info(org, username)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_unblock_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **username** | **String** | The handle for the GitHub user account. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## orgs_update

> <OrganizationFull> orgs_update(org, opts)

Update an organization

**Parameter Deprecation Notice:** GitHub will replace and discontinue `members_allowed_repository_creation_type` in favor of more granular permissions. The new input parameters are `members_can_create_public_repositories`, `members_can_create_private_repositories` for all organizations and `members_can_create_internal_repositories` for organizations associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+. For more information, see the [blog post](https://developer.github.com/changes/2019-12-03-internal-visibility-changes).  Enables an authenticated organization owner with the `admin:org` scope to update the organization's profile and member privileges.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  orgs_update_request: OpenapiClient::OrgsUpdateRequest.new # OrgsUpdateRequest | 
}

begin
  # Update an organization
  result = api_instance.orgs_update(org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_update: #{e}"
end
```

#### Using the orgs_update_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<OrganizationFull>, Integer, Hash)> orgs_update_with_http_info(org, opts)

```ruby
begin
  # Update an organization
  data, status_code, headers = api_instance.orgs_update_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <OrganizationFull>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_update_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **orgs_update_request** | [**OrgsUpdateRequest**](OrgsUpdateRequest.md) |  | [optional] |

### Return type

[**OrganizationFull**](OrganizationFull.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## orgs_update_membership_for_authenticated_user

> <OrgMembership> orgs_update_membership_for_authenticated_user(org, orgs_update_membership_for_authenticated_user_request)

Update an organization membership for the authenticated user



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
orgs_update_membership_for_authenticated_user_request = OpenapiClient::OrgsUpdateMembershipForAuthenticatedUserRequest.new({state: 'active'}) # OrgsUpdateMembershipForAuthenticatedUserRequest | 

begin
  # Update an organization membership for the authenticated user
  result = api_instance.orgs_update_membership_for_authenticated_user(org, orgs_update_membership_for_authenticated_user_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_update_membership_for_authenticated_user: #{e}"
end
```

#### Using the orgs_update_membership_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<OrgMembership>, Integer, Hash)> orgs_update_membership_for_authenticated_user_with_http_info(org, orgs_update_membership_for_authenticated_user_request)

```ruby
begin
  # Update an organization membership for the authenticated user
  data, status_code, headers = api_instance.orgs_update_membership_for_authenticated_user_with_http_info(org, orgs_update_membership_for_authenticated_user_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <OrgMembership>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_update_membership_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **orgs_update_membership_for_authenticated_user_request** | [**OrgsUpdateMembershipForAuthenticatedUserRequest**](OrgsUpdateMembershipForAuthenticatedUserRequest.md) |  |  |

### Return type

[**OrgMembership**](OrgMembership.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## orgs_update_webhook

> <OrgHook> orgs_update_webhook(org, hook_id, opts)

Update an organization webhook

Updates a webhook configured in an organization. When you update a webhook, the `secret` will be overwritten. If you previously had a `secret` set, you must provide the same `secret` or set a new `secret` or the secret will be removed. If you are only updating individual webhook `config` properties, use \"[Update a webhook configuration for an organization](/rest/reference/orgs#update-a-webhook-configuration-for-an-organization).\"

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
hook_id = 56 # Integer | The unique identifier of the hook.
opts = {
  orgs_update_webhook_request: OpenapiClient::OrgsUpdateWebhookRequest.new # OrgsUpdateWebhookRequest | 
}

begin
  # Update an organization webhook
  result = api_instance.orgs_update_webhook(org, hook_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_update_webhook: #{e}"
end
```

#### Using the orgs_update_webhook_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<OrgHook>, Integer, Hash)> orgs_update_webhook_with_http_info(org, hook_id, opts)

```ruby
begin
  # Update an organization webhook
  data, status_code, headers = api_instance.orgs_update_webhook_with_http_info(org, hook_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <OrgHook>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_update_webhook_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **hook_id** | **Integer** | The unique identifier of the hook. |  |
| **orgs_update_webhook_request** | [**OrgsUpdateWebhookRequest**](OrgsUpdateWebhookRequest.md) |  | [optional] |

### Return type

[**OrgHook**](OrgHook.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## orgs_update_webhook_config_for_org

> <WebhookConfiguration> orgs_update_webhook_config_for_org(org, hook_id, opts)

Update a webhook configuration for an organization

Updates the webhook configuration for an organization. To update more information about the webhook, including the `active` state and `events`, use \"[Update an organization webhook ](/rest/reference/orgs#update-an-organization-webhook).\"  Access tokens must have the `admin:org_hook` scope, and GitHub Apps must have the `organization_hooks:write` permission.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OrgsApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
hook_id = 56 # Integer | The unique identifier of the hook.
opts = {
  apps_update_webhook_config_for_app_request: OpenapiClient::AppsUpdateWebhookConfigForAppRequest.new # AppsUpdateWebhookConfigForAppRequest | 
}

begin
  # Update a webhook configuration for an organization
  result = api_instance.orgs_update_webhook_config_for_org(org, hook_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_update_webhook_config_for_org: #{e}"
end
```

#### Using the orgs_update_webhook_config_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<WebhookConfiguration>, Integer, Hash)> orgs_update_webhook_config_for_org_with_http_info(org, hook_id, opts)

```ruby
begin
  # Update a webhook configuration for an organization
  data, status_code, headers = api_instance.orgs_update_webhook_config_for_org_with_http_info(org, hook_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <WebhookConfiguration>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OrgsApi->orgs_update_webhook_config_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **hook_id** | **Integer** | The unique identifier of the hook. |  |
| **apps_update_webhook_config_for_app_request** | [**AppsUpdateWebhookConfigForAppRequest**](AppsUpdateWebhookConfigForAppRequest.md) |  | [optional] |

### Return type

[**WebhookConfiguration**](WebhookConfiguration.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

