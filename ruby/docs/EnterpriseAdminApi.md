# OpenapiClient::EnterpriseAdminApi

All URIs are relative to *https://api.github.com*

| Method | HTTP request | Description |
| ------ | ------------ | ----------- |
| [**enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise**](EnterpriseAdminApi.md#enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise) | **POST** /enterprises/{enterprise}/actions/runners/{runner_id}/labels | Add custom labels to a self-hosted runner for an enterprise |
| [**enterprise_admin_add_org_access_to_self_hosted_runner_group_in_enterprise**](EnterpriseAdminApi.md#enterprise_admin_add_org_access_to_self_hosted_runner_group_in_enterprise) | **PUT** /enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/organizations/{org_id} | Add organization access to a self-hosted runner group in an enterprise |
| [**enterprise_admin_add_self_hosted_runner_to_group_for_enterprise**](EnterpriseAdminApi.md#enterprise_admin_add_self_hosted_runner_to_group_for_enterprise) | **PUT** /enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/runners/{runner_id} | Add a self-hosted runner to a group for an enterprise |
| [**enterprise_admin_create_registration_token_for_enterprise**](EnterpriseAdminApi.md#enterprise_admin_create_registration_token_for_enterprise) | **POST** /enterprises/{enterprise}/actions/runners/registration-token | Create a registration token for an enterprise |
| [**enterprise_admin_create_remove_token_for_enterprise**](EnterpriseAdminApi.md#enterprise_admin_create_remove_token_for_enterprise) | **POST** /enterprises/{enterprise}/actions/runners/remove-token | Create a remove token for an enterprise |
| [**enterprise_admin_create_self_hosted_runner_group_for_enterprise**](EnterpriseAdminApi.md#enterprise_admin_create_self_hosted_runner_group_for_enterprise) | **POST** /enterprises/{enterprise}/actions/runner-groups | Create a self-hosted runner group for an enterprise |
| [**enterprise_admin_delete_scim_group_from_enterprise**](EnterpriseAdminApi.md#enterprise_admin_delete_scim_group_from_enterprise) | **DELETE** /scim/v2/enterprises/{enterprise}/Groups/{scim_group_id} | Delete a SCIM group from an enterprise |
| [**enterprise_admin_delete_self_hosted_runner_from_enterprise**](EnterpriseAdminApi.md#enterprise_admin_delete_self_hosted_runner_from_enterprise) | **DELETE** /enterprises/{enterprise}/actions/runners/{runner_id} | Delete a self-hosted runner from an enterprise |
| [**enterprise_admin_delete_self_hosted_runner_group_from_enterprise**](EnterpriseAdminApi.md#enterprise_admin_delete_self_hosted_runner_group_from_enterprise) | **DELETE** /enterprises/{enterprise}/actions/runner-groups/{runner_group_id} | Delete a self-hosted runner group from an enterprise |
| [**enterprise_admin_delete_user_from_enterprise**](EnterpriseAdminApi.md#enterprise_admin_delete_user_from_enterprise) | **DELETE** /scim/v2/enterprises/{enterprise}/Users/{scim_user_id} | Delete a SCIM user from an enterprise |
| [**enterprise_admin_disable_selected_organization_github_actions_enterprise**](EnterpriseAdminApi.md#enterprise_admin_disable_selected_organization_github_actions_enterprise) | **DELETE** /enterprises/{enterprise}/actions/permissions/organizations/{org_id} | Disable a selected organization for GitHub Actions in an enterprise |
| [**enterprise_admin_enable_selected_organization_github_actions_enterprise**](EnterpriseAdminApi.md#enterprise_admin_enable_selected_organization_github_actions_enterprise) | **PUT** /enterprises/{enterprise}/actions/permissions/organizations/{org_id} | Enable a selected organization for GitHub Actions in an enterprise |
| [**enterprise_admin_get_allowed_actions_enterprise**](EnterpriseAdminApi.md#enterprise_admin_get_allowed_actions_enterprise) | **GET** /enterprises/{enterprise}/actions/permissions/selected-actions | Get allowed actions and reusable workflows for an enterprise |
| [**enterprise_admin_get_audit_log**](EnterpriseAdminApi.md#enterprise_admin_get_audit_log) | **GET** /enterprises/{enterprise}/audit-log | Get the audit log for an enterprise |
| [**enterprise_admin_get_github_actions_permissions_enterprise**](EnterpriseAdminApi.md#enterprise_admin_get_github_actions_permissions_enterprise) | **GET** /enterprises/{enterprise}/actions/permissions | Get GitHub Actions permissions for an enterprise |
| [**enterprise_admin_get_provisioning_information_for_enterprise_group**](EnterpriseAdminApi.md#enterprise_admin_get_provisioning_information_for_enterprise_group) | **GET** /scim/v2/enterprises/{enterprise}/Groups/{scim_group_id} | Get SCIM provisioning information for an enterprise group |
| [**enterprise_admin_get_provisioning_information_for_enterprise_user**](EnterpriseAdminApi.md#enterprise_admin_get_provisioning_information_for_enterprise_user) | **GET** /scim/v2/enterprises/{enterprise}/Users/{scim_user_id} | Get SCIM provisioning information for an enterprise user |
| [**enterprise_admin_get_self_hosted_runner_for_enterprise**](EnterpriseAdminApi.md#enterprise_admin_get_self_hosted_runner_for_enterprise) | **GET** /enterprises/{enterprise}/actions/runners/{runner_id} | Get a self-hosted runner for an enterprise |
| [**enterprise_admin_get_self_hosted_runner_group_for_enterprise**](EnterpriseAdminApi.md#enterprise_admin_get_self_hosted_runner_group_for_enterprise) | **GET** /enterprises/{enterprise}/actions/runner-groups/{runner_group_id} | Get a self-hosted runner group for an enterprise |
| [**enterprise_admin_get_server_statistics**](EnterpriseAdminApi.md#enterprise_admin_get_server_statistics) | **GET** /enterprise-installation/{enterprise_or_org}/server-statistics | Get GitHub Enterprise Server statistics |
| [**enterprise_admin_list_labels_for_self_hosted_runner_for_enterprise**](EnterpriseAdminApi.md#enterprise_admin_list_labels_for_self_hosted_runner_for_enterprise) | **GET** /enterprises/{enterprise}/actions/runners/{runner_id}/labels | List labels for a self-hosted runner for an enterprise |
| [**enterprise_admin_list_org_access_to_self_hosted_runner_group_in_enterprise**](EnterpriseAdminApi.md#enterprise_admin_list_org_access_to_self_hosted_runner_group_in_enterprise) | **GET** /enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/organizations | List organization access to a self-hosted runner group in an enterprise |
| [**enterprise_admin_list_provisioned_groups_enterprise**](EnterpriseAdminApi.md#enterprise_admin_list_provisioned_groups_enterprise) | **GET** /scim/v2/enterprises/{enterprise}/Groups | List provisioned SCIM groups for an enterprise |
| [**enterprise_admin_list_provisioned_identities_enterprise**](EnterpriseAdminApi.md#enterprise_admin_list_provisioned_identities_enterprise) | **GET** /scim/v2/enterprises/{enterprise}/Users | List SCIM provisioned identities for an enterprise |
| [**enterprise_admin_list_runner_applications_for_enterprise**](EnterpriseAdminApi.md#enterprise_admin_list_runner_applications_for_enterprise) | **GET** /enterprises/{enterprise}/actions/runners/downloads | List runner applications for an enterprise |
| [**enterprise_admin_list_selected_organizations_enabled_github_actions_enterprise**](EnterpriseAdminApi.md#enterprise_admin_list_selected_organizations_enabled_github_actions_enterprise) | **GET** /enterprises/{enterprise}/actions/permissions/organizations | List selected organizations enabled for GitHub Actions in an enterprise |
| [**enterprise_admin_list_self_hosted_runner_groups_for_enterprise**](EnterpriseAdminApi.md#enterprise_admin_list_self_hosted_runner_groups_for_enterprise) | **GET** /enterprises/{enterprise}/actions/runner-groups | List self-hosted runner groups for an enterprise |
| [**enterprise_admin_list_self_hosted_runners_for_enterprise**](EnterpriseAdminApi.md#enterprise_admin_list_self_hosted_runners_for_enterprise) | **GET** /enterprises/{enterprise}/actions/runners | List self-hosted runners for an enterprise |
| [**enterprise_admin_list_self_hosted_runners_in_group_for_enterprise**](EnterpriseAdminApi.md#enterprise_admin_list_self_hosted_runners_in_group_for_enterprise) | **GET** /enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/runners | List self-hosted runners in a group for an enterprise |
| [**enterprise_admin_provision_and_invite_enterprise_group**](EnterpriseAdminApi.md#enterprise_admin_provision_and_invite_enterprise_group) | **POST** /scim/v2/enterprises/{enterprise}/Groups | Provision a SCIM enterprise group and invite users |
| [**enterprise_admin_provision_and_invite_enterprise_user**](EnterpriseAdminApi.md#enterprise_admin_provision_and_invite_enterprise_user) | **POST** /scim/v2/enterprises/{enterprise}/Users | Provision and invite a SCIM enterprise user |
| [**enterprise_admin_remove_all_custom_labels_from_self_hosted_runner_for_enterprise**](EnterpriseAdminApi.md#enterprise_admin_remove_all_custom_labels_from_self_hosted_runner_for_enterprise) | **DELETE** /enterprises/{enterprise}/actions/runners/{runner_id}/labels | Remove all custom labels from a self-hosted runner for an enterprise |
| [**enterprise_admin_remove_custom_label_from_self_hosted_runner_for_enterprise**](EnterpriseAdminApi.md#enterprise_admin_remove_custom_label_from_self_hosted_runner_for_enterprise) | **DELETE** /enterprises/{enterprise}/actions/runners/{runner_id}/labels/{name} | Remove a custom label from a self-hosted runner for an enterprise |
| [**enterprise_admin_remove_org_access_to_self_hosted_runner_group_in_enterprise**](EnterpriseAdminApi.md#enterprise_admin_remove_org_access_to_self_hosted_runner_group_in_enterprise) | **DELETE** /enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/organizations/{org_id} | Remove organization access to a self-hosted runner group in an enterprise |
| [**enterprise_admin_remove_self_hosted_runner_from_group_for_enterprise**](EnterpriseAdminApi.md#enterprise_admin_remove_self_hosted_runner_from_group_for_enterprise) | **DELETE** /enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/runners/{runner_id} | Remove a self-hosted runner from a group for an enterprise |
| [**enterprise_admin_set_allowed_actions_enterprise**](EnterpriseAdminApi.md#enterprise_admin_set_allowed_actions_enterprise) | **PUT** /enterprises/{enterprise}/actions/permissions/selected-actions | Set allowed actions and reusable workflows for an enterprise |
| [**enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise**](EnterpriseAdminApi.md#enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise) | **PUT** /enterprises/{enterprise}/actions/runners/{runner_id}/labels | Set custom labels for a self-hosted runner for an enterprise |
| [**enterprise_admin_set_github_actions_permissions_enterprise**](EnterpriseAdminApi.md#enterprise_admin_set_github_actions_permissions_enterprise) | **PUT** /enterprises/{enterprise}/actions/permissions | Set GitHub Actions permissions for an enterprise |
| [**enterprise_admin_set_information_for_provisioned_enterprise_group**](EnterpriseAdminApi.md#enterprise_admin_set_information_for_provisioned_enterprise_group) | **PUT** /scim/v2/enterprises/{enterprise}/Groups/{scim_group_id} | Set SCIM information for a provisioned enterprise group |
| [**enterprise_admin_set_information_for_provisioned_enterprise_user**](EnterpriseAdminApi.md#enterprise_admin_set_information_for_provisioned_enterprise_user) | **PUT** /scim/v2/enterprises/{enterprise}/Users/{scim_user_id} | Set SCIM information for a provisioned enterprise user |
| [**enterprise_admin_set_org_access_to_self_hosted_runner_group_in_enterprise**](EnterpriseAdminApi.md#enterprise_admin_set_org_access_to_self_hosted_runner_group_in_enterprise) | **PUT** /enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/organizations | Set organization access for a self-hosted runner group in an enterprise |
| [**enterprise_admin_set_selected_organizations_enabled_github_actions_enterprise**](EnterpriseAdminApi.md#enterprise_admin_set_selected_organizations_enabled_github_actions_enterprise) | **PUT** /enterprises/{enterprise}/actions/permissions/organizations | Set selected organizations enabled for GitHub Actions in an enterprise |
| [**enterprise_admin_set_self_hosted_runners_in_group_for_enterprise**](EnterpriseAdminApi.md#enterprise_admin_set_self_hosted_runners_in_group_for_enterprise) | **PUT** /enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/runners | Set self-hosted runners in a group for an enterprise |
| [**enterprise_admin_update_attribute_for_enterprise_group**](EnterpriseAdminApi.md#enterprise_admin_update_attribute_for_enterprise_group) | **PATCH** /scim/v2/enterprises/{enterprise}/Groups/{scim_group_id} | Update an attribute for a SCIM enterprise group |
| [**enterprise_admin_update_attribute_for_enterprise_user**](EnterpriseAdminApi.md#enterprise_admin_update_attribute_for_enterprise_user) | **PATCH** /scim/v2/enterprises/{enterprise}/Users/{scim_user_id} | Update an attribute for a SCIM enterprise user |
| [**enterprise_admin_update_self_hosted_runner_group_for_enterprise**](EnterpriseAdminApi.md#enterprise_admin_update_self_hosted_runner_group_for_enterprise) | **PATCH** /enterprises/{enterprise}/actions/runner-groups/{runner_group_id} | Update a self-hosted runner group for an enterprise |


## enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise

> <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response> enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise(enterprise, runner_id, enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise_request)

Add custom labels to a self-hosted runner for an enterprise

Add custom labels to a self-hosted runner configured in an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.
enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise_request = OpenapiClient::EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest.new({labels: ['labels_example']}) # EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest | 

begin
  # Add custom labels to a self-hosted runner for an enterprise
  result = api_instance.enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise(enterprise, runner_id, enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise: #{e}"
end
```

#### Using the enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>, Integer, Hash)> enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise_with_http_info(enterprise, runner_id, enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise_request)

```ruby
begin
  # Add custom labels to a self-hosted runner for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise_with_http_info(enterprise, runner_id, enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |
| **enterprise_admin_add_custom_labels_to_self_hosted_runner_for_enterprise_request** | [**EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest**](EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest.md) |  |  |

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## enterprise_admin_add_org_access_to_self_hosted_runner_group_in_enterprise

> enterprise_admin_add_org_access_to_self_hosted_runner_group_in_enterprise(enterprise, runner_group_id, org_id)

Add organization access to a self-hosted runner group in an enterprise

Adds an organization to the list of selected organizations that can access a self-hosted runner group. The runner group must have `visibility` set to `selected`. For more information, see \"[Create a self-hosted runner group for an enterprise](#create-a-self-hosted-runner-group-for-an-enterprise).\"  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
runner_group_id = 56 # Integer | Unique identifier of the self-hosted runner group.
org_id = 56 # Integer | The unique identifier of the organization.

begin
  # Add organization access to a self-hosted runner group in an enterprise
  api_instance.enterprise_admin_add_org_access_to_self_hosted_runner_group_in_enterprise(enterprise, runner_group_id, org_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_add_org_access_to_self_hosted_runner_group_in_enterprise: #{e}"
end
```

#### Using the enterprise_admin_add_org_access_to_self_hosted_runner_group_in_enterprise_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> enterprise_admin_add_org_access_to_self_hosted_runner_group_in_enterprise_with_http_info(enterprise, runner_group_id, org_id)

```ruby
begin
  # Add organization access to a self-hosted runner group in an enterprise
  data, status_code, headers = api_instance.enterprise_admin_add_org_access_to_self_hosted_runner_group_in_enterprise_with_http_info(enterprise, runner_group_id, org_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_add_org_access_to_self_hosted_runner_group_in_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **runner_group_id** | **Integer** | Unique identifier of the self-hosted runner group. |  |
| **org_id** | **Integer** | The unique identifier of the organization. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## enterprise_admin_add_self_hosted_runner_to_group_for_enterprise

> enterprise_admin_add_self_hosted_runner_to_group_for_enterprise(enterprise, runner_group_id, runner_id)

Add a self-hosted runner to a group for an enterprise

Adds a self-hosted runner to a runner group configured in an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
runner_group_id = 56 # Integer | Unique identifier of the self-hosted runner group.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.

begin
  # Add a self-hosted runner to a group for an enterprise
  api_instance.enterprise_admin_add_self_hosted_runner_to_group_for_enterprise(enterprise, runner_group_id, runner_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_add_self_hosted_runner_to_group_for_enterprise: #{e}"
end
```

#### Using the enterprise_admin_add_self_hosted_runner_to_group_for_enterprise_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> enterprise_admin_add_self_hosted_runner_to_group_for_enterprise_with_http_info(enterprise, runner_group_id, runner_id)

```ruby
begin
  # Add a self-hosted runner to a group for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_add_self_hosted_runner_to_group_for_enterprise_with_http_info(enterprise, runner_group_id, runner_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_add_self_hosted_runner_to_group_for_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **runner_group_id** | **Integer** | Unique identifier of the self-hosted runner group. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## enterprise_admin_create_registration_token_for_enterprise

> <AuthenticationToken> enterprise_admin_create_registration_token_for_enterprise(enterprise)

Create a registration token for an enterprise

Returns a token that you can pass to the `config` script. The token expires after one hour.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.  #### Example using registration token  Configure your self-hosted runner, replacing `TOKEN` with the registration token provided by this endpoint.  ``` ./config.sh --url https://github.com/enterprises/octo-enterprise --token TOKEN ```

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.

begin
  # Create a registration token for an enterprise
  result = api_instance.enterprise_admin_create_registration_token_for_enterprise(enterprise)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_create_registration_token_for_enterprise: #{e}"
end
```

#### Using the enterprise_admin_create_registration_token_for_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<AuthenticationToken>, Integer, Hash)> enterprise_admin_create_registration_token_for_enterprise_with_http_info(enterprise)

```ruby
begin
  # Create a registration token for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_create_registration_token_for_enterprise_with_http_info(enterprise)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <AuthenticationToken>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_create_registration_token_for_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |

### Return type

[**AuthenticationToken**](AuthenticationToken.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## enterprise_admin_create_remove_token_for_enterprise

> <AuthenticationToken> enterprise_admin_create_remove_token_for_enterprise(enterprise)

Create a remove token for an enterprise

Returns a token that you can pass to the `config` script to remove a self-hosted runner from an enterprise. The token expires after one hour.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.  #### Example using remove token  To remove your self-hosted runner from an enterprise, replace `TOKEN` with the remove token provided by this endpoint.  ``` ./config.sh remove --token TOKEN ```

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.

begin
  # Create a remove token for an enterprise
  result = api_instance.enterprise_admin_create_remove_token_for_enterprise(enterprise)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_create_remove_token_for_enterprise: #{e}"
end
```

#### Using the enterprise_admin_create_remove_token_for_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<AuthenticationToken>, Integer, Hash)> enterprise_admin_create_remove_token_for_enterprise_with_http_info(enterprise)

```ruby
begin
  # Create a remove token for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_create_remove_token_for_enterprise_with_http_info(enterprise)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <AuthenticationToken>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_create_remove_token_for_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |

### Return type

[**AuthenticationToken**](AuthenticationToken.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## enterprise_admin_create_self_hosted_runner_group_for_enterprise

> <EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner> enterprise_admin_create_self_hosted_runner_group_for_enterprise(enterprise, enterprise_admin_create_self_hosted_runner_group_for_enterprise_request)

Create a self-hosted runner group for an enterprise

Creates a new self-hosted runner group for an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
enterprise_admin_create_self_hosted_runner_group_for_enterprise_request = OpenapiClient::EnterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest.new({name: 'name_example'}) # EnterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest | 

begin
  # Create a self-hosted runner group for an enterprise
  result = api_instance.enterprise_admin_create_self_hosted_runner_group_for_enterprise(enterprise, enterprise_admin_create_self_hosted_runner_group_for_enterprise_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_create_self_hosted_runner_group_for_enterprise: #{e}"
end
```

#### Using the enterprise_admin_create_self_hosted_runner_group_for_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner>, Integer, Hash)> enterprise_admin_create_self_hosted_runner_group_for_enterprise_with_http_info(enterprise, enterprise_admin_create_self_hosted_runner_group_for_enterprise_request)

```ruby
begin
  # Create a self-hosted runner group for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_create_self_hosted_runner_group_for_enterprise_with_http_info(enterprise, enterprise_admin_create_self_hosted_runner_group_for_enterprise_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_create_self_hosted_runner_group_for_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **enterprise_admin_create_self_hosted_runner_group_for_enterprise_request** | [**EnterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest**](EnterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest.md) |  |  |

### Return type

[**EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner**](EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## enterprise_admin_delete_scim_group_from_enterprise

> enterprise_admin_delete_scim_group_from_enterprise(enterprise, scim_group_id)

Delete a SCIM group from an enterprise

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
scim_group_id = 'scim_group_id_example' # String | Identifier generated by the GitHub SCIM endpoint.

begin
  # Delete a SCIM group from an enterprise
  api_instance.enterprise_admin_delete_scim_group_from_enterprise(enterprise, scim_group_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_delete_scim_group_from_enterprise: #{e}"
end
```

#### Using the enterprise_admin_delete_scim_group_from_enterprise_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> enterprise_admin_delete_scim_group_from_enterprise_with_http_info(enterprise, scim_group_id)

```ruby
begin
  # Delete a SCIM group from an enterprise
  data, status_code, headers = api_instance.enterprise_admin_delete_scim_group_from_enterprise_with_http_info(enterprise, scim_group_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_delete_scim_group_from_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **scim_group_id** | **String** | Identifier generated by the GitHub SCIM endpoint. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## enterprise_admin_delete_self_hosted_runner_from_enterprise

> enterprise_admin_delete_self_hosted_runner_from_enterprise(enterprise, runner_id)

Delete a self-hosted runner from an enterprise

Forces the removal of a self-hosted runner from an enterprise. You can use this endpoint to completely remove the runner when the machine you were using no longer exists.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.

begin
  # Delete a self-hosted runner from an enterprise
  api_instance.enterprise_admin_delete_self_hosted_runner_from_enterprise(enterprise, runner_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_delete_self_hosted_runner_from_enterprise: #{e}"
end
```

#### Using the enterprise_admin_delete_self_hosted_runner_from_enterprise_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> enterprise_admin_delete_self_hosted_runner_from_enterprise_with_http_info(enterprise, runner_id)

```ruby
begin
  # Delete a self-hosted runner from an enterprise
  data, status_code, headers = api_instance.enterprise_admin_delete_self_hosted_runner_from_enterprise_with_http_info(enterprise, runner_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_delete_self_hosted_runner_from_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## enterprise_admin_delete_self_hosted_runner_group_from_enterprise

> enterprise_admin_delete_self_hosted_runner_group_from_enterprise(enterprise, runner_group_id)

Delete a self-hosted runner group from an enterprise

Deletes a self-hosted runner group for an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
runner_group_id = 56 # Integer | Unique identifier of the self-hosted runner group.

begin
  # Delete a self-hosted runner group from an enterprise
  api_instance.enterprise_admin_delete_self_hosted_runner_group_from_enterprise(enterprise, runner_group_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_delete_self_hosted_runner_group_from_enterprise: #{e}"
end
```

#### Using the enterprise_admin_delete_self_hosted_runner_group_from_enterprise_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> enterprise_admin_delete_self_hosted_runner_group_from_enterprise_with_http_info(enterprise, runner_group_id)

```ruby
begin
  # Delete a self-hosted runner group from an enterprise
  data, status_code, headers = api_instance.enterprise_admin_delete_self_hosted_runner_group_from_enterprise_with_http_info(enterprise, runner_group_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_delete_self_hosted_runner_group_from_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **runner_group_id** | **Integer** | Unique identifier of the self-hosted runner group. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## enterprise_admin_delete_user_from_enterprise

> enterprise_admin_delete_user_from_enterprise(enterprise, scim_user_id)

Delete a SCIM user from an enterprise

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
scim_user_id = 'scim_user_id_example' # String | The unique identifier of the SCIM user.

begin
  # Delete a SCIM user from an enterprise
  api_instance.enterprise_admin_delete_user_from_enterprise(enterprise, scim_user_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_delete_user_from_enterprise: #{e}"
end
```

#### Using the enterprise_admin_delete_user_from_enterprise_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> enterprise_admin_delete_user_from_enterprise_with_http_info(enterprise, scim_user_id)

```ruby
begin
  # Delete a SCIM user from an enterprise
  data, status_code, headers = api_instance.enterprise_admin_delete_user_from_enterprise_with_http_info(enterprise, scim_user_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_delete_user_from_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **scim_user_id** | **String** | The unique identifier of the SCIM user. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## enterprise_admin_disable_selected_organization_github_actions_enterprise

> enterprise_admin_disable_selected_organization_github_actions_enterprise(enterprise, org_id)

Disable a selected organization for GitHub Actions in an enterprise

Removes an organization from the list of selected organizations that are enabled for GitHub Actions in an enterprise. To use this endpoint, the enterprise permission policy for `enabled_organizations` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\"  You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
org_id = 56 # Integer | The unique identifier of the organization.

begin
  # Disable a selected organization for GitHub Actions in an enterprise
  api_instance.enterprise_admin_disable_selected_organization_github_actions_enterprise(enterprise, org_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_disable_selected_organization_github_actions_enterprise: #{e}"
end
```

#### Using the enterprise_admin_disable_selected_organization_github_actions_enterprise_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> enterprise_admin_disable_selected_organization_github_actions_enterprise_with_http_info(enterprise, org_id)

```ruby
begin
  # Disable a selected organization for GitHub Actions in an enterprise
  data, status_code, headers = api_instance.enterprise_admin_disable_selected_organization_github_actions_enterprise_with_http_info(enterprise, org_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_disable_selected_organization_github_actions_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **org_id** | **Integer** | The unique identifier of the organization. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## enterprise_admin_enable_selected_organization_github_actions_enterprise

> enterprise_admin_enable_selected_organization_github_actions_enterprise(enterprise, org_id)

Enable a selected organization for GitHub Actions in an enterprise

Adds an organization to the list of selected organizations that are enabled for GitHub Actions in an enterprise. To use this endpoint, the enterprise permission policy for `enabled_organizations` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\"  You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
org_id = 56 # Integer | The unique identifier of the organization.

begin
  # Enable a selected organization for GitHub Actions in an enterprise
  api_instance.enterprise_admin_enable_selected_organization_github_actions_enterprise(enterprise, org_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_enable_selected_organization_github_actions_enterprise: #{e}"
end
```

#### Using the enterprise_admin_enable_selected_organization_github_actions_enterprise_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> enterprise_admin_enable_selected_organization_github_actions_enterprise_with_http_info(enterprise, org_id)

```ruby
begin
  # Enable a selected organization for GitHub Actions in an enterprise
  data, status_code, headers = api_instance.enterprise_admin_enable_selected_organization_github_actions_enterprise_with_http_info(enterprise, org_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_enable_selected_organization_github_actions_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **org_id** | **Integer** | The unique identifier of the organization. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## enterprise_admin_get_allowed_actions_enterprise

> <EnterpriseAdminGetAllowedActionsEnterprise200Response> enterprise_admin_get_allowed_actions_enterprise(enterprise)

Get allowed actions and reusable workflows for an enterprise

Gets the selected actions and reusable workflows that are allowed in an enterprise. To use this endpoint, the enterprise permission policy for `allowed_actions` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\"  You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.

begin
  # Get allowed actions and reusable workflows for an enterprise
  result = api_instance.enterprise_admin_get_allowed_actions_enterprise(enterprise)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_get_allowed_actions_enterprise: #{e}"
end
```

#### Using the enterprise_admin_get_allowed_actions_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminGetAllowedActionsEnterprise200Response>, Integer, Hash)> enterprise_admin_get_allowed_actions_enterprise_with_http_info(enterprise)

```ruby
begin
  # Get allowed actions and reusable workflows for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_get_allowed_actions_enterprise_with_http_info(enterprise)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminGetAllowedActionsEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_get_allowed_actions_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |

### Return type

[**EnterpriseAdminGetAllowedActionsEnterprise200Response**](EnterpriseAdminGetAllowedActionsEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## enterprise_admin_get_audit_log

> <Array<EnterpriseAdminGetAuditLog200ResponseInner>> enterprise_admin_get_audit_log(enterprise, opts)

Get the audit log for an enterprise

Gets the audit log for an enterprise. To use this endpoint, you must be an enterprise admin, and you must use an access token with the `admin:enterprise` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
opts = {
  phrase: 'phrase_example', # String | A search phrase. For more information, see [Searching the audit log](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/reviewing-the-audit-log-for-your-organization#searching-the-audit-log).
  include: 'web', # String | The event types to include:  - `web` - returns web (non-Git) events. - `git` - returns Git events. - `all` - returns both web and Git events.  The default is `web`.
  after: 'after_example', # String | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.
  before: 'before_example', # String | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor.
  order: 'desc', # String | The order of audit log events. To list newest events first, specify `desc`. To list oldest events first, specify `asc`.  The default is `desc`.
  page: 56, # Integer | Page number of the results to fetch.
  per_page: 56 # Integer | The number of results per page (max 100).
}

begin
  # Get the audit log for an enterprise
  result = api_instance.enterprise_admin_get_audit_log(enterprise, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_get_audit_log: #{e}"
end
```

#### Using the enterprise_admin_get_audit_log_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<EnterpriseAdminGetAuditLog200ResponseInner>>, Integer, Hash)> enterprise_admin_get_audit_log_with_http_info(enterprise, opts)

```ruby
begin
  # Get the audit log for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_get_audit_log_with_http_info(enterprise, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<EnterpriseAdminGetAuditLog200ResponseInner>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_get_audit_log_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **phrase** | **String** | A search phrase. For more information, see [Searching the audit log](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/reviewing-the-audit-log-for-your-organization#searching-the-audit-log). | [optional] |
| **include** | **String** | The event types to include:  - &#x60;web&#x60; - returns web (non-Git) events. - &#x60;git&#x60; - returns Git events. - &#x60;all&#x60; - returns both web and Git events.  The default is &#x60;web&#x60;. | [optional] |
| **after** | **String** | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor. | [optional] |
| **before** | **String** | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. | [optional] |
| **order** | **String** | The order of audit log events. To list newest events first, specify &#x60;desc&#x60;. To list oldest events first, specify &#x60;asc&#x60;.  The default is &#x60;desc&#x60;. | [optional] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |

### Return type

[**Array&lt;EnterpriseAdminGetAuditLog200ResponseInner&gt;**](EnterpriseAdminGetAuditLog200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## enterprise_admin_get_github_actions_permissions_enterprise

> <EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response> enterprise_admin_get_github_actions_permissions_enterprise(enterprise)

Get GitHub Actions permissions for an enterprise

Gets the GitHub Actions permissions policy for organizations and allowed actions and reusable workflows in an enterprise.  You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.

begin
  # Get GitHub Actions permissions for an enterprise
  result = api_instance.enterprise_admin_get_github_actions_permissions_enterprise(enterprise)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_get_github_actions_permissions_enterprise: #{e}"
end
```

#### Using the enterprise_admin_get_github_actions_permissions_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response>, Integer, Hash)> enterprise_admin_get_github_actions_permissions_enterprise_with_http_info(enterprise)

```ruby
begin
  # Get GitHub Actions permissions for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_get_github_actions_permissions_enterprise_with_http_info(enterprise)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_get_github_actions_permissions_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |

### Return type

[**EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response**](EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## enterprise_admin_get_provisioning_information_for_enterprise_group

> <EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner> enterprise_admin_get_provisioning_information_for_enterprise_group(enterprise, scim_group_id, opts)

Get SCIM provisioning information for an enterprise group

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
scim_group_id = 'scim_group_id_example' # String | Identifier generated by the GitHub SCIM endpoint.
opts = {
  excluded_attributes: 'excluded_attributes_example' # String | Attributes to exclude.
}

begin
  # Get SCIM provisioning information for an enterprise group
  result = api_instance.enterprise_admin_get_provisioning_information_for_enterprise_group(enterprise, scim_group_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_get_provisioning_information_for_enterprise_group: #{e}"
end
```

#### Using the enterprise_admin_get_provisioning_information_for_enterprise_group_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner>, Integer, Hash)> enterprise_admin_get_provisioning_information_for_enterprise_group_with_http_info(enterprise, scim_group_id, opts)

```ruby
begin
  # Get SCIM provisioning information for an enterprise group
  data, status_code, headers = api_instance.enterprise_admin_get_provisioning_information_for_enterprise_group_with_http_info(enterprise, scim_group_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_get_provisioning_information_for_enterprise_group_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **scim_group_id** | **String** | Identifier generated by the GitHub SCIM endpoint. |  |
| **excluded_attributes** | **String** | Attributes to exclude. | [optional] |

### Return type

[**EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner**](EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## enterprise_admin_get_provisioning_information_for_enterprise_user

> <EnterpriseAdminProvisionAndInviteEnterpriseUser201Response> enterprise_admin_get_provisioning_information_for_enterprise_user(enterprise, scim_user_id)

Get SCIM provisioning information for an enterprise user

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
scim_user_id = 'scim_user_id_example' # String | The unique identifier of the SCIM user.

begin
  # Get SCIM provisioning information for an enterprise user
  result = api_instance.enterprise_admin_get_provisioning_information_for_enterprise_user(enterprise, scim_user_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_get_provisioning_information_for_enterprise_user: #{e}"
end
```

#### Using the enterprise_admin_get_provisioning_information_for_enterprise_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminProvisionAndInviteEnterpriseUser201Response>, Integer, Hash)> enterprise_admin_get_provisioning_information_for_enterprise_user_with_http_info(enterprise, scim_user_id)

```ruby
begin
  # Get SCIM provisioning information for an enterprise user
  data, status_code, headers = api_instance.enterprise_admin_get_provisioning_information_for_enterprise_user_with_http_info(enterprise, scim_user_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminProvisionAndInviteEnterpriseUser201Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_get_provisioning_information_for_enterprise_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **scim_user_id** | **String** | The unique identifier of the SCIM user. |  |

### Return type

[**EnterpriseAdminProvisionAndInviteEnterpriseUser201Response**](EnterpriseAdminProvisionAndInviteEnterpriseUser201Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## enterprise_admin_get_self_hosted_runner_for_enterprise

> <SelfHostedRunners> enterprise_admin_get_self_hosted_runner_for_enterprise(enterprise, runner_id)

Get a self-hosted runner for an enterprise

Gets a specific self-hosted runner configured in an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.

begin
  # Get a self-hosted runner for an enterprise
  result = api_instance.enterprise_admin_get_self_hosted_runner_for_enterprise(enterprise, runner_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_get_self_hosted_runner_for_enterprise: #{e}"
end
```

#### Using the enterprise_admin_get_self_hosted_runner_for_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<SelfHostedRunners>, Integer, Hash)> enterprise_admin_get_self_hosted_runner_for_enterprise_with_http_info(enterprise, runner_id)

```ruby
begin
  # Get a self-hosted runner for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_get_self_hosted_runner_for_enterprise_with_http_info(enterprise, runner_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <SelfHostedRunners>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_get_self_hosted_runner_for_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |

### Return type

[**SelfHostedRunners**](SelfHostedRunners.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## enterprise_admin_get_self_hosted_runner_group_for_enterprise

> <EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner> enterprise_admin_get_self_hosted_runner_group_for_enterprise(enterprise, runner_group_id)

Get a self-hosted runner group for an enterprise

Gets a specific self-hosted runner group for an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
runner_group_id = 56 # Integer | Unique identifier of the self-hosted runner group.

begin
  # Get a self-hosted runner group for an enterprise
  result = api_instance.enterprise_admin_get_self_hosted_runner_group_for_enterprise(enterprise, runner_group_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_get_self_hosted_runner_group_for_enterprise: #{e}"
end
```

#### Using the enterprise_admin_get_self_hosted_runner_group_for_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner>, Integer, Hash)> enterprise_admin_get_self_hosted_runner_group_for_enterprise_with_http_info(enterprise, runner_group_id)

```ruby
begin
  # Get a self-hosted runner group for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_get_self_hosted_runner_group_for_enterprise_with_http_info(enterprise, runner_group_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_get_self_hosted_runner_group_for_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **runner_group_id** | **Integer** | Unique identifier of the self-hosted runner group. |  |

### Return type

[**EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner**](EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## enterprise_admin_get_server_statistics

> <Array<ServerStatisticsProxyEndpointInner>> enterprise_admin_get_server_statistics(enterprise_or_org, opts)

Get GitHub Enterprise Server statistics

Returns aggregate usage metrics for your GitHub Enterprise Server 3.5+ instance for a specified time period up to 365 days.  To use this endpoint, your GitHub Enterprise Server instance must be connected to GitHub Enterprise Cloud using GitHub Connect. You must enable Server Statistics, and for the API request provide your enterprise account name or organization name connected to the GitHub Enterprise Server. For more information, see \"[Enabling Server Statistics for your enterprise](/admin/configuration/configuring-github-connect/enabling-server-statistics-for-your-enterprise)\" in the GitHub Enterprise Server documentation.  You'll need to use a personal access token:   - If you connected your GitHub Enterprise Server to an enterprise account and enabled Server Statistics, you'll need a personal access token with the `read:enterprise` permission.   - If you connected your GitHub Enterprise Server to an organization account and enabled Server Statistics, you'll need a personal access token with the `read:org` permission.  For more information on creating a personal access token, see \"[Creating a personal access token](/authentication/keeping-your-account-and-data-secure/creating-a-personal-access-token).\"

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise_or_org = 'enterprise_or_org_example' # String | The slug version of the enterprise name or the login of an organization.
opts = {
  date_start: 'date_start_example', # String | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.
  date_end: 'date_end_example' # String | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor.
}

begin
  # Get GitHub Enterprise Server statistics
  result = api_instance.enterprise_admin_get_server_statistics(enterprise_or_org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_get_server_statistics: #{e}"
end
```

#### Using the enterprise_admin_get_server_statistics_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<ServerStatisticsProxyEndpointInner>>, Integer, Hash)> enterprise_admin_get_server_statistics_with_http_info(enterprise_or_org, opts)

```ruby
begin
  # Get GitHub Enterprise Server statistics
  data, status_code, headers = api_instance.enterprise_admin_get_server_statistics_with_http_info(enterprise_or_org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<ServerStatisticsProxyEndpointInner>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_get_server_statistics_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise_or_org** | **String** | The slug version of the enterprise name or the login of an organization. |  |
| **date_start** | **String** | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor. | [optional] |
| **date_end** | **String** | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. | [optional] |

### Return type

[**Array&lt;ServerStatisticsProxyEndpointInner&gt;**](ServerStatisticsProxyEndpointInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## enterprise_admin_list_labels_for_self_hosted_runner_for_enterprise

> <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response> enterprise_admin_list_labels_for_self_hosted_runner_for_enterprise(enterprise, runner_id)

List labels for a self-hosted runner for an enterprise

Lists all labels for a self-hosted runner configured in an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.

begin
  # List labels for a self-hosted runner for an enterprise
  result = api_instance.enterprise_admin_list_labels_for_self_hosted_runner_for_enterprise(enterprise, runner_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_list_labels_for_self_hosted_runner_for_enterprise: #{e}"
end
```

#### Using the enterprise_admin_list_labels_for_self_hosted_runner_for_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>, Integer, Hash)> enterprise_admin_list_labels_for_self_hosted_runner_for_enterprise_with_http_info(enterprise, runner_id)

```ruby
begin
  # List labels for a self-hosted runner for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_list_labels_for_self_hosted_runner_for_enterprise_with_http_info(enterprise, runner_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_list_labels_for_self_hosted_runner_for_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## enterprise_admin_list_org_access_to_self_hosted_runner_group_in_enterprise

> <EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response> enterprise_admin_list_org_access_to_self_hosted_runner_group_in_enterprise(enterprise, runner_group_id, opts)

List organization access to a self-hosted runner group in an enterprise

Lists the organizations with access to a self-hosted runner group.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
runner_group_id = 56 # Integer | Unique identifier of the self-hosted runner group.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List organization access to a self-hosted runner group in an enterprise
  result = api_instance.enterprise_admin_list_org_access_to_self_hosted_runner_group_in_enterprise(enterprise, runner_group_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_list_org_access_to_self_hosted_runner_group_in_enterprise: #{e}"
end
```

#### Using the enterprise_admin_list_org_access_to_self_hosted_runner_group_in_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response>, Integer, Hash)> enterprise_admin_list_org_access_to_self_hosted_runner_group_in_enterprise_with_http_info(enterprise, runner_group_id, opts)

```ruby
begin
  # List organization access to a self-hosted runner group in an enterprise
  data, status_code, headers = api_instance.enterprise_admin_list_org_access_to_self_hosted_runner_group_in_enterprise_with_http_info(enterprise, runner_group_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_list_org_access_to_self_hosted_runner_group_in_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **runner_group_id** | **Integer** | Unique identifier of the self-hosted runner group. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response**](EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## enterprise_admin_list_provisioned_groups_enterprise

> <EnterpriseAdminListProvisionedGroupsEnterprise200Response> enterprise_admin_list_provisioned_groups_enterprise(enterprise, opts)

List provisioned SCIM groups for an enterprise

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
opts = {
  start_index: 56, # Integer | Used for pagination: the index of the first result to return.
  count: 56, # Integer | Used for pagination: the number of results to return.
  filter: 'filter_example', # String | filter results
  excluded_attributes: 'excluded_attributes_example' # String | attributes to exclude
}

begin
  # List provisioned SCIM groups for an enterprise
  result = api_instance.enterprise_admin_list_provisioned_groups_enterprise(enterprise, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_list_provisioned_groups_enterprise: #{e}"
end
```

#### Using the enterprise_admin_list_provisioned_groups_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListProvisionedGroupsEnterprise200Response>, Integer, Hash)> enterprise_admin_list_provisioned_groups_enterprise_with_http_info(enterprise, opts)

```ruby
begin
  # List provisioned SCIM groups for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_list_provisioned_groups_enterprise_with_http_info(enterprise, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListProvisionedGroupsEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_list_provisioned_groups_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **start_index** | **Integer** | Used for pagination: the index of the first result to return. | [optional] |
| **count** | **Integer** | Used for pagination: the number of results to return. | [optional] |
| **filter** | **String** | filter results | [optional] |
| **excluded_attributes** | **String** | attributes to exclude | [optional] |

### Return type

[**EnterpriseAdminListProvisionedGroupsEnterprise200Response**](EnterpriseAdminListProvisionedGroupsEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## enterprise_admin_list_provisioned_identities_enterprise

> <EnterpriseAdminListProvisionedIdentitiesEnterprise200Response> enterprise_admin_list_provisioned_identities_enterprise(enterprise, opts)

List SCIM provisioned identities for an enterprise

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Retrieves a paginated list of all provisioned enterprise members, including pending invitations.  When a user with a SAML-provisioned external identity leaves (or is removed from) an enterprise, the account's metadata is immediately removed. However, the returned list of user accounts might not always match the organization or enterprise member list you see on GitHub. This can happen in certain cases where an external identity associated with an organization will not match an organization member:   - When a user with a SCIM-provisioned external identity is removed from an enterprise, the account's metadata is preserved to allow the user to re-join the organization in the future.   - When inviting a user to join an organization, you can expect to see their external identity in the results before they accept the invitation, or if the invitation is cancelled (or never accepted).   - When a user is invited over SCIM, an external identity is created that matches with the invitee's email address. However, this identity is only linked to a user account when the user accepts the invitation by going through SAML SSO.  The returned list of external identities can include an entry for a `null` user. These are unlinked SAML identities that are created when a user goes through the following Single Sign-On (SSO) process but does not sign in to their GitHub account after completing SSO:  1. The user is granted access by the IdP and is not a member of the GitHub enterprise.  1. The user attempts to access the GitHub enterprise and initiates the SAML SSO process, and is not currently signed in to their GitHub account.  1. After successfully authenticating with the SAML SSO IdP, the `null` external identity entry is created and the user is prompted to sign in to their GitHub account:    - If the user signs in, their GitHub account is linked to this entry.    - If the user does not sign in (or does not create a new account when prompted), they are not added to the GitHub enterprise, and the external identity `null` entry remains in place.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
opts = {
  start_index: 56, # Integer | Used for pagination: the index of the first result to return.
  count: 56, # Integer | Used for pagination: the number of results to return.
  filter: 'filter_example' # String | filter results
}

begin
  # List SCIM provisioned identities for an enterprise
  result = api_instance.enterprise_admin_list_provisioned_identities_enterprise(enterprise, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_list_provisioned_identities_enterprise: #{e}"
end
```

#### Using the enterprise_admin_list_provisioned_identities_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListProvisionedIdentitiesEnterprise200Response>, Integer, Hash)> enterprise_admin_list_provisioned_identities_enterprise_with_http_info(enterprise, opts)

```ruby
begin
  # List SCIM provisioned identities for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_list_provisioned_identities_enterprise_with_http_info(enterprise, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListProvisionedIdentitiesEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_list_provisioned_identities_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **start_index** | **Integer** | Used for pagination: the index of the first result to return. | [optional] |
| **count** | **Integer** | Used for pagination: the number of results to return. | [optional] |
| **filter** | **String** | filter results | [optional] |

### Return type

[**EnterpriseAdminListProvisionedIdentitiesEnterprise200Response**](EnterpriseAdminListProvisionedIdentitiesEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## enterprise_admin_list_runner_applications_for_enterprise

> <Array<RunnerApplication>> enterprise_admin_list_runner_applications_for_enterprise(enterprise)

List runner applications for an enterprise

Lists binaries for the runner application that you can download and run.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.

begin
  # List runner applications for an enterprise
  result = api_instance.enterprise_admin_list_runner_applications_for_enterprise(enterprise)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_list_runner_applications_for_enterprise: #{e}"
end
```

#### Using the enterprise_admin_list_runner_applications_for_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<RunnerApplication>>, Integer, Hash)> enterprise_admin_list_runner_applications_for_enterprise_with_http_info(enterprise)

```ruby
begin
  # List runner applications for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_list_runner_applications_for_enterprise_with_http_info(enterprise)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<RunnerApplication>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_list_runner_applications_for_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |

### Return type

[**Array&lt;RunnerApplication&gt;**](RunnerApplication.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## enterprise_admin_list_selected_organizations_enabled_github_actions_enterprise

> <EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response> enterprise_admin_list_selected_organizations_enabled_github_actions_enterprise(enterprise, opts)

List selected organizations enabled for GitHub Actions in an enterprise

Lists the organizations that are selected to have GitHub Actions enabled in an enterprise. To use this endpoint, the enterprise permission policy for `enabled_organizations` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\"  You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List selected organizations enabled for GitHub Actions in an enterprise
  result = api_instance.enterprise_admin_list_selected_organizations_enabled_github_actions_enterprise(enterprise, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_list_selected_organizations_enabled_github_actions_enterprise: #{e}"
end
```

#### Using the enterprise_admin_list_selected_organizations_enabled_github_actions_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response>, Integer, Hash)> enterprise_admin_list_selected_organizations_enabled_github_actions_enterprise_with_http_info(enterprise, opts)

```ruby
begin
  # List selected organizations enabled for GitHub Actions in an enterprise
  data, status_code, headers = api_instance.enterprise_admin_list_selected_organizations_enabled_github_actions_enterprise_with_http_info(enterprise, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_list_selected_organizations_enabled_github_actions_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response**](EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## enterprise_admin_list_self_hosted_runner_groups_for_enterprise

> <EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200Response> enterprise_admin_list_self_hosted_runner_groups_for_enterprise(enterprise, opts)

List self-hosted runner groups for an enterprise

Lists all self-hosted runner groups for an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56, # Integer | Page number of the results to fetch.
  visible_to_organization: 'visible_to_organization_example' # String | Only return runner groups that are allowed to be used by this organization.
}

begin
  # List self-hosted runner groups for an enterprise
  result = api_instance.enterprise_admin_list_self_hosted_runner_groups_for_enterprise(enterprise, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_list_self_hosted_runner_groups_for_enterprise: #{e}"
end
```

#### Using the enterprise_admin_list_self_hosted_runner_groups_for_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200Response>, Integer, Hash)> enterprise_admin_list_self_hosted_runner_groups_for_enterprise_with_http_info(enterprise, opts)

```ruby
begin
  # List self-hosted runner groups for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_list_self_hosted_runner_groups_for_enterprise_with_http_info(enterprise, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_list_self_hosted_runner_groups_for_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |
| **visible_to_organization** | **String** | Only return runner groups that are allowed to be used by this organization. | [optional] |

### Return type

[**EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200Response**](EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## enterprise_admin_list_self_hosted_runners_for_enterprise

> <EnterpriseAdminListSelfHostedRunnersForEnterprise200Response> enterprise_admin_list_self_hosted_runners_for_enterprise(enterprise, opts)

List self-hosted runners for an enterprise

Lists all self-hosted runners configured for an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List self-hosted runners for an enterprise
  result = api_instance.enterprise_admin_list_self_hosted_runners_for_enterprise(enterprise, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_list_self_hosted_runners_for_enterprise: #{e}"
end
```

#### Using the enterprise_admin_list_self_hosted_runners_for_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListSelfHostedRunnersForEnterprise200Response>, Integer, Hash)> enterprise_admin_list_self_hosted_runners_for_enterprise_with_http_info(enterprise, opts)

```ruby
begin
  # List self-hosted runners for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_list_self_hosted_runners_for_enterprise_with_http_info(enterprise, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListSelfHostedRunnersForEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_list_self_hosted_runners_for_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**EnterpriseAdminListSelfHostedRunnersForEnterprise200Response**](EnterpriseAdminListSelfHostedRunnersForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## enterprise_admin_list_self_hosted_runners_in_group_for_enterprise

> <EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response> enterprise_admin_list_self_hosted_runners_in_group_for_enterprise(enterprise, runner_group_id, opts)

List self-hosted runners in a group for an enterprise

Lists the self-hosted runners that are in a specific enterprise group.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
runner_group_id = 56 # Integer | Unique identifier of the self-hosted runner group.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List self-hosted runners in a group for an enterprise
  result = api_instance.enterprise_admin_list_self_hosted_runners_in_group_for_enterprise(enterprise, runner_group_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_list_self_hosted_runners_in_group_for_enterprise: #{e}"
end
```

#### Using the enterprise_admin_list_self_hosted_runners_in_group_for_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response>, Integer, Hash)> enterprise_admin_list_self_hosted_runners_in_group_for_enterprise_with_http_info(enterprise, runner_group_id, opts)

```ruby
begin
  # List self-hosted runners in a group for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_list_self_hosted_runners_in_group_for_enterprise_with_http_info(enterprise, runner_group_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_list_self_hosted_runners_in_group_for_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **runner_group_id** | **Integer** | Unique identifier of the self-hosted runner group. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response**](EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## enterprise_admin_provision_and_invite_enterprise_group

> <EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner> enterprise_admin_provision_and_invite_enterprise_group(enterprise, enterprise_admin_provision_and_invite_enterprise_group_request)

Provision a SCIM enterprise group and invite users

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Provision an enterprise group, and invite users to the group. This sends invitation emails to the email address of the invited users to join the GitHub organization that the SCIM group corresponds to.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
enterprise_admin_provision_and_invite_enterprise_group_request = OpenapiClient::EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest.new({schemas: ['schemas_example'], display_name: 'display_name_example'}) # EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest | 

begin
  # Provision a SCIM enterprise group and invite users
  result = api_instance.enterprise_admin_provision_and_invite_enterprise_group(enterprise, enterprise_admin_provision_and_invite_enterprise_group_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_provision_and_invite_enterprise_group: #{e}"
end
```

#### Using the enterprise_admin_provision_and_invite_enterprise_group_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner>, Integer, Hash)> enterprise_admin_provision_and_invite_enterprise_group_with_http_info(enterprise, enterprise_admin_provision_and_invite_enterprise_group_request)

```ruby
begin
  # Provision a SCIM enterprise group and invite users
  data, status_code, headers = api_instance.enterprise_admin_provision_and_invite_enterprise_group_with_http_info(enterprise, enterprise_admin_provision_and_invite_enterprise_group_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_provision_and_invite_enterprise_group_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **enterprise_admin_provision_and_invite_enterprise_group_request** | [**EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest**](EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest.md) |  |  |

### Return type

[**EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner**](EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## enterprise_admin_provision_and_invite_enterprise_user

> <EnterpriseAdminProvisionAndInviteEnterpriseUser201Response> enterprise_admin_provision_and_invite_enterprise_user(enterprise, enterprise_admin_provision_and_invite_enterprise_user_request)

Provision and invite a SCIM enterprise user

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Provision enterprise membership for a user, and send organization invitation emails to the email address.  You can optionally include the groups a user will be invited to join. If you do not provide a list of `groups`, the user is provisioned for the enterprise, but no organization invitation emails will be sent.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
enterprise_admin_provision_and_invite_enterprise_user_request = OpenapiClient::EnterpriseAdminProvisionAndInviteEnterpriseUserRequest.new({schemas: ['schemas_example'], user_name: 'user_name_example', name: OpenapiClient::EnterpriseAdminProvisionAndInviteEnterpriseUserRequestName.new({given_name: 'given_name_example', family_name: 'family_name_example'}), emails: [OpenapiClient::EnterpriseAdminProvisionAndInviteEnterpriseUserRequestEmailsInner.new({value: 'value_example', type: 'type_example', primary: false})]}) # EnterpriseAdminProvisionAndInviteEnterpriseUserRequest | 

begin
  # Provision and invite a SCIM enterprise user
  result = api_instance.enterprise_admin_provision_and_invite_enterprise_user(enterprise, enterprise_admin_provision_and_invite_enterprise_user_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_provision_and_invite_enterprise_user: #{e}"
end
```

#### Using the enterprise_admin_provision_and_invite_enterprise_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminProvisionAndInviteEnterpriseUser201Response>, Integer, Hash)> enterprise_admin_provision_and_invite_enterprise_user_with_http_info(enterprise, enterprise_admin_provision_and_invite_enterprise_user_request)

```ruby
begin
  # Provision and invite a SCIM enterprise user
  data, status_code, headers = api_instance.enterprise_admin_provision_and_invite_enterprise_user_with_http_info(enterprise, enterprise_admin_provision_and_invite_enterprise_user_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminProvisionAndInviteEnterpriseUser201Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_provision_and_invite_enterprise_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **enterprise_admin_provision_and_invite_enterprise_user_request** | [**EnterpriseAdminProvisionAndInviteEnterpriseUserRequest**](EnterpriseAdminProvisionAndInviteEnterpriseUserRequest.md) |  |  |

### Return type

[**EnterpriseAdminProvisionAndInviteEnterpriseUser201Response**](EnterpriseAdminProvisionAndInviteEnterpriseUser201Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## enterprise_admin_remove_all_custom_labels_from_self_hosted_runner_for_enterprise

> <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response> enterprise_admin_remove_all_custom_labels_from_self_hosted_runner_for_enterprise(enterprise, runner_id)

Remove all custom labels from a self-hosted runner for an enterprise

Remove all custom labels from a self-hosted runner configured in an enterprise. Returns the remaining read-only labels from the runner.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.

begin
  # Remove all custom labels from a self-hosted runner for an enterprise
  result = api_instance.enterprise_admin_remove_all_custom_labels_from_self_hosted_runner_for_enterprise(enterprise, runner_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_remove_all_custom_labels_from_self_hosted_runner_for_enterprise: #{e}"
end
```

#### Using the enterprise_admin_remove_all_custom_labels_from_self_hosted_runner_for_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>, Integer, Hash)> enterprise_admin_remove_all_custom_labels_from_self_hosted_runner_for_enterprise_with_http_info(enterprise, runner_id)

```ruby
begin
  # Remove all custom labels from a self-hosted runner for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_remove_all_custom_labels_from_self_hosted_runner_for_enterprise_with_http_info(enterprise, runner_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_remove_all_custom_labels_from_self_hosted_runner_for_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## enterprise_admin_remove_custom_label_from_self_hosted_runner_for_enterprise

> <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response> enterprise_admin_remove_custom_label_from_self_hosted_runner_for_enterprise(enterprise, runner_id, name)

Remove a custom label from a self-hosted runner for an enterprise

Remove a custom label from a self-hosted runner configured in an enterprise. Returns the remaining labels from the runner.  This endpoint returns a `404 Not Found` status if the custom label is not present on the runner.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.
name = 'name_example' # String | The name of a self-hosted runner's custom label.

begin
  # Remove a custom label from a self-hosted runner for an enterprise
  result = api_instance.enterprise_admin_remove_custom_label_from_self_hosted_runner_for_enterprise(enterprise, runner_id, name)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_remove_custom_label_from_self_hosted_runner_for_enterprise: #{e}"
end
```

#### Using the enterprise_admin_remove_custom_label_from_self_hosted_runner_for_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>, Integer, Hash)> enterprise_admin_remove_custom_label_from_self_hosted_runner_for_enterprise_with_http_info(enterprise, runner_id, name)

```ruby
begin
  # Remove a custom label from a self-hosted runner for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_remove_custom_label_from_self_hosted_runner_for_enterprise_with_http_info(enterprise, runner_id, name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_remove_custom_label_from_self_hosted_runner_for_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |
| **name** | **String** | The name of a self-hosted runner&#39;s custom label. |  |

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## enterprise_admin_remove_org_access_to_self_hosted_runner_group_in_enterprise

> enterprise_admin_remove_org_access_to_self_hosted_runner_group_in_enterprise(enterprise, runner_group_id, org_id)

Remove organization access to a self-hosted runner group in an enterprise

Removes an organization from the list of selected organizations that can access a self-hosted runner group. The runner group must have `visibility` set to `selected`. For more information, see \"[Create a self-hosted runner group for an enterprise](#create-a-self-hosted-runner-group-for-an-enterprise).\"  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
runner_group_id = 56 # Integer | Unique identifier of the self-hosted runner group.
org_id = 56 # Integer | The unique identifier of the organization.

begin
  # Remove organization access to a self-hosted runner group in an enterprise
  api_instance.enterprise_admin_remove_org_access_to_self_hosted_runner_group_in_enterprise(enterprise, runner_group_id, org_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_remove_org_access_to_self_hosted_runner_group_in_enterprise: #{e}"
end
```

#### Using the enterprise_admin_remove_org_access_to_self_hosted_runner_group_in_enterprise_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> enterprise_admin_remove_org_access_to_self_hosted_runner_group_in_enterprise_with_http_info(enterprise, runner_group_id, org_id)

```ruby
begin
  # Remove organization access to a self-hosted runner group in an enterprise
  data, status_code, headers = api_instance.enterprise_admin_remove_org_access_to_self_hosted_runner_group_in_enterprise_with_http_info(enterprise, runner_group_id, org_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_remove_org_access_to_self_hosted_runner_group_in_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **runner_group_id** | **Integer** | Unique identifier of the self-hosted runner group. |  |
| **org_id** | **Integer** | The unique identifier of the organization. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## enterprise_admin_remove_self_hosted_runner_from_group_for_enterprise

> enterprise_admin_remove_self_hosted_runner_from_group_for_enterprise(enterprise, runner_group_id, runner_id)

Remove a self-hosted runner from a group for an enterprise

Removes a self-hosted runner from a group configured in an enterprise. The runner is then returned to the default group.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
runner_group_id = 56 # Integer | Unique identifier of the self-hosted runner group.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.

begin
  # Remove a self-hosted runner from a group for an enterprise
  api_instance.enterprise_admin_remove_self_hosted_runner_from_group_for_enterprise(enterprise, runner_group_id, runner_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_remove_self_hosted_runner_from_group_for_enterprise: #{e}"
end
```

#### Using the enterprise_admin_remove_self_hosted_runner_from_group_for_enterprise_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> enterprise_admin_remove_self_hosted_runner_from_group_for_enterprise_with_http_info(enterprise, runner_group_id, runner_id)

```ruby
begin
  # Remove a self-hosted runner from a group for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_remove_self_hosted_runner_from_group_for_enterprise_with_http_info(enterprise, runner_group_id, runner_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_remove_self_hosted_runner_from_group_for_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **runner_group_id** | **Integer** | Unique identifier of the self-hosted runner group. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## enterprise_admin_set_allowed_actions_enterprise

> enterprise_admin_set_allowed_actions_enterprise(enterprise, enterprise_admin_get_allowed_actions_enterprise200_response)

Set allowed actions and reusable workflows for an enterprise

Sets the actions and reusable workflows that are allowed in an enterprise. To use this endpoint, the enterprise permission policy for `allowed_actions` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\"  You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
enterprise_admin_get_allowed_actions_enterprise200_response = OpenapiClient::EnterpriseAdminGetAllowedActionsEnterprise200Response.new # EnterpriseAdminGetAllowedActionsEnterprise200Response | 

begin
  # Set allowed actions and reusable workflows for an enterprise
  api_instance.enterprise_admin_set_allowed_actions_enterprise(enterprise, enterprise_admin_get_allowed_actions_enterprise200_response)
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_set_allowed_actions_enterprise: #{e}"
end
```

#### Using the enterprise_admin_set_allowed_actions_enterprise_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> enterprise_admin_set_allowed_actions_enterprise_with_http_info(enterprise, enterprise_admin_get_allowed_actions_enterprise200_response)

```ruby
begin
  # Set allowed actions and reusable workflows for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_set_allowed_actions_enterprise_with_http_info(enterprise, enterprise_admin_get_allowed_actions_enterprise200_response)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_set_allowed_actions_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **enterprise_admin_get_allowed_actions_enterprise200_response** | [**EnterpriseAdminGetAllowedActionsEnterprise200Response**](EnterpriseAdminGetAllowedActionsEnterprise200Response.md) |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise

> <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response> enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise(enterprise, runner_id, enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise_request)

Set custom labels for a self-hosted runner for an enterprise

Remove all previous custom labels and set the new custom labels for a specific self-hosted runner configured in an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
runner_id = 56 # Integer | Unique identifier of the self-hosted runner.
enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise_request = OpenapiClient::EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest.new({labels: ['labels_example']}) # EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest | 

begin
  # Set custom labels for a self-hosted runner for an enterprise
  result = api_instance.enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise(enterprise, runner_id, enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise: #{e}"
end
```

#### Using the enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>, Integer, Hash)> enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise_with_http_info(enterprise, runner_id, enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise_request)

```ruby
begin
  # Set custom labels for a self-hosted runner for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise_with_http_info(enterprise, runner_id, enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **runner_id** | **Integer** | Unique identifier of the self-hosted runner. |  |
| **enterprise_admin_set_custom_labels_for_self_hosted_runner_for_enterprise_request** | [**EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest**](EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest.md) |  |  |

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## enterprise_admin_set_github_actions_permissions_enterprise

> enterprise_admin_set_github_actions_permissions_enterprise(enterprise, enterprise_admin_set_github_actions_permissions_enterprise_request)

Set GitHub Actions permissions for an enterprise

Sets the GitHub Actions permissions policy for organizations and allowed actions and reusable workflows in an enterprise.  You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
enterprise_admin_set_github_actions_permissions_enterprise_request = OpenapiClient::EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest.new({enabled_organizations: 'all'}) # EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest | 

begin
  # Set GitHub Actions permissions for an enterprise
  api_instance.enterprise_admin_set_github_actions_permissions_enterprise(enterprise, enterprise_admin_set_github_actions_permissions_enterprise_request)
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_set_github_actions_permissions_enterprise: #{e}"
end
```

#### Using the enterprise_admin_set_github_actions_permissions_enterprise_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> enterprise_admin_set_github_actions_permissions_enterprise_with_http_info(enterprise, enterprise_admin_set_github_actions_permissions_enterprise_request)

```ruby
begin
  # Set GitHub Actions permissions for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_set_github_actions_permissions_enterprise_with_http_info(enterprise, enterprise_admin_set_github_actions_permissions_enterprise_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_set_github_actions_permissions_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **enterprise_admin_set_github_actions_permissions_enterprise_request** | [**EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest**](EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest.md) |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## enterprise_admin_set_information_for_provisioned_enterprise_group

> <EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner> enterprise_admin_set_information_for_provisioned_enterprise_group(enterprise, scim_group_id, enterprise_admin_provision_and_invite_enterprise_group_request)

Set SCIM information for a provisioned enterprise group

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Replaces an existing provisioned group’s information. You must provide all the information required for the group as if you were provisioning it for the first time. Any existing group information that you don't provide will be removed, including group membership. If you want to only update a specific attribute, use the [Update an attribute for a SCIM enterprise group](#update-an-attribute-for-a-scim-enterprise-group) endpoint instead.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
scim_group_id = 'scim_group_id_example' # String | Identifier generated by the GitHub SCIM endpoint.
enterprise_admin_provision_and_invite_enterprise_group_request = OpenapiClient::EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest.new({schemas: ['schemas_example'], display_name: 'display_name_example'}) # EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest | 

begin
  # Set SCIM information for a provisioned enterprise group
  result = api_instance.enterprise_admin_set_information_for_provisioned_enterprise_group(enterprise, scim_group_id, enterprise_admin_provision_and_invite_enterprise_group_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_set_information_for_provisioned_enterprise_group: #{e}"
end
```

#### Using the enterprise_admin_set_information_for_provisioned_enterprise_group_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner>, Integer, Hash)> enterprise_admin_set_information_for_provisioned_enterprise_group_with_http_info(enterprise, scim_group_id, enterprise_admin_provision_and_invite_enterprise_group_request)

```ruby
begin
  # Set SCIM information for a provisioned enterprise group
  data, status_code, headers = api_instance.enterprise_admin_set_information_for_provisioned_enterprise_group_with_http_info(enterprise, scim_group_id, enterprise_admin_provision_and_invite_enterprise_group_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_set_information_for_provisioned_enterprise_group_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **scim_group_id** | **String** | Identifier generated by the GitHub SCIM endpoint. |  |
| **enterprise_admin_provision_and_invite_enterprise_group_request** | [**EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest**](EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest.md) |  |  |

### Return type

[**EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner**](EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## enterprise_admin_set_information_for_provisioned_enterprise_user

> <EnterpriseAdminProvisionAndInviteEnterpriseUser201Response> enterprise_admin_set_information_for_provisioned_enterprise_user(enterprise, scim_user_id, enterprise_admin_provision_and_invite_enterprise_user_request)

Set SCIM information for a provisioned enterprise user

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Replaces an existing provisioned user's information. You must provide all the information required for the user as if you were provisioning them for the first time. Any existing user information that you don't provide will be removed. If you want to only update a specific attribute, use the [Update an attribute for a SCIM user](#update-an-attribute-for-an-enterprise-scim-user) endpoint instead.  You must at least provide the required values for the user: `userName`, `name`, and `emails`.  **Warning:** Setting `active: false` removes the user from the enterprise, deletes the external identity, and deletes the associated `{scim_user_id}`.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
scim_user_id = 'scim_user_id_example' # String | The unique identifier of the SCIM user.
enterprise_admin_provision_and_invite_enterprise_user_request = OpenapiClient::EnterpriseAdminProvisionAndInviteEnterpriseUserRequest.new({schemas: ['schemas_example'], user_name: 'user_name_example', name: OpenapiClient::EnterpriseAdminProvisionAndInviteEnterpriseUserRequestName.new({given_name: 'given_name_example', family_name: 'family_name_example'}), emails: [OpenapiClient::EnterpriseAdminProvisionAndInviteEnterpriseUserRequestEmailsInner.new({value: 'value_example', type: 'type_example', primary: false})]}) # EnterpriseAdminProvisionAndInviteEnterpriseUserRequest | 

begin
  # Set SCIM information for a provisioned enterprise user
  result = api_instance.enterprise_admin_set_information_for_provisioned_enterprise_user(enterprise, scim_user_id, enterprise_admin_provision_and_invite_enterprise_user_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_set_information_for_provisioned_enterprise_user: #{e}"
end
```

#### Using the enterprise_admin_set_information_for_provisioned_enterprise_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminProvisionAndInviteEnterpriseUser201Response>, Integer, Hash)> enterprise_admin_set_information_for_provisioned_enterprise_user_with_http_info(enterprise, scim_user_id, enterprise_admin_provision_and_invite_enterprise_user_request)

```ruby
begin
  # Set SCIM information for a provisioned enterprise user
  data, status_code, headers = api_instance.enterprise_admin_set_information_for_provisioned_enterprise_user_with_http_info(enterprise, scim_user_id, enterprise_admin_provision_and_invite_enterprise_user_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminProvisionAndInviteEnterpriseUser201Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_set_information_for_provisioned_enterprise_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **scim_user_id** | **String** | The unique identifier of the SCIM user. |  |
| **enterprise_admin_provision_and_invite_enterprise_user_request** | [**EnterpriseAdminProvisionAndInviteEnterpriseUserRequest**](EnterpriseAdminProvisionAndInviteEnterpriseUserRequest.md) |  |  |

### Return type

[**EnterpriseAdminProvisionAndInviteEnterpriseUser201Response**](EnterpriseAdminProvisionAndInviteEnterpriseUser201Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## enterprise_admin_set_org_access_to_self_hosted_runner_group_in_enterprise

> enterprise_admin_set_org_access_to_self_hosted_runner_group_in_enterprise(enterprise, runner_group_id, enterprise_admin_set_org_access_to_self_hosted_runner_group_in_enterprise_request)

Set organization access for a self-hosted runner group in an enterprise

Replaces the list of organizations that have access to a self-hosted runner configured in an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
runner_group_id = 56 # Integer | Unique identifier of the self-hosted runner group.
enterprise_admin_set_org_access_to_self_hosted_runner_group_in_enterprise_request = OpenapiClient::EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest.new({selected_organization_ids: [37]}) # EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest | 

begin
  # Set organization access for a self-hosted runner group in an enterprise
  api_instance.enterprise_admin_set_org_access_to_self_hosted_runner_group_in_enterprise(enterprise, runner_group_id, enterprise_admin_set_org_access_to_self_hosted_runner_group_in_enterprise_request)
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_set_org_access_to_self_hosted_runner_group_in_enterprise: #{e}"
end
```

#### Using the enterprise_admin_set_org_access_to_self_hosted_runner_group_in_enterprise_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> enterprise_admin_set_org_access_to_self_hosted_runner_group_in_enterprise_with_http_info(enterprise, runner_group_id, enterprise_admin_set_org_access_to_self_hosted_runner_group_in_enterprise_request)

```ruby
begin
  # Set organization access for a self-hosted runner group in an enterprise
  data, status_code, headers = api_instance.enterprise_admin_set_org_access_to_self_hosted_runner_group_in_enterprise_with_http_info(enterprise, runner_group_id, enterprise_admin_set_org_access_to_self_hosted_runner_group_in_enterprise_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_set_org_access_to_self_hosted_runner_group_in_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **runner_group_id** | **Integer** | Unique identifier of the self-hosted runner group. |  |
| **enterprise_admin_set_org_access_to_self_hosted_runner_group_in_enterprise_request** | [**EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest**](EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest.md) |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## enterprise_admin_set_selected_organizations_enabled_github_actions_enterprise

> enterprise_admin_set_selected_organizations_enabled_github_actions_enterprise(enterprise, enterprise_admin_set_selected_organizations_enabled_github_actions_enterprise_request)

Set selected organizations enabled for GitHub Actions in an enterprise

Replaces the list of selected organizations that are enabled for GitHub Actions in an enterprise. To use this endpoint, the enterprise permission policy for `enabled_organizations` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\"  You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
enterprise_admin_set_selected_organizations_enabled_github_actions_enterprise_request = OpenapiClient::EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest.new({selected_organization_ids: [37]}) # EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest | 

begin
  # Set selected organizations enabled for GitHub Actions in an enterprise
  api_instance.enterprise_admin_set_selected_organizations_enabled_github_actions_enterprise(enterprise, enterprise_admin_set_selected_organizations_enabled_github_actions_enterprise_request)
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_set_selected_organizations_enabled_github_actions_enterprise: #{e}"
end
```

#### Using the enterprise_admin_set_selected_organizations_enabled_github_actions_enterprise_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> enterprise_admin_set_selected_organizations_enabled_github_actions_enterprise_with_http_info(enterprise, enterprise_admin_set_selected_organizations_enabled_github_actions_enterprise_request)

```ruby
begin
  # Set selected organizations enabled for GitHub Actions in an enterprise
  data, status_code, headers = api_instance.enterprise_admin_set_selected_organizations_enabled_github_actions_enterprise_with_http_info(enterprise, enterprise_admin_set_selected_organizations_enabled_github_actions_enterprise_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_set_selected_organizations_enabled_github_actions_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **enterprise_admin_set_selected_organizations_enabled_github_actions_enterprise_request** | [**EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest**](EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest.md) |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## enterprise_admin_set_self_hosted_runners_in_group_for_enterprise

> enterprise_admin_set_self_hosted_runners_in_group_for_enterprise(enterprise, runner_group_id, enterprise_admin_set_self_hosted_runners_in_group_for_enterprise_request)

Set self-hosted runners in a group for an enterprise

Replaces the list of self-hosted runners that are part of an enterprise runner group.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
runner_group_id = 56 # Integer | Unique identifier of the self-hosted runner group.
enterprise_admin_set_self_hosted_runners_in_group_for_enterprise_request = OpenapiClient::EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest.new({runners: [37]}) # EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest | 

begin
  # Set self-hosted runners in a group for an enterprise
  api_instance.enterprise_admin_set_self_hosted_runners_in_group_for_enterprise(enterprise, runner_group_id, enterprise_admin_set_self_hosted_runners_in_group_for_enterprise_request)
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_set_self_hosted_runners_in_group_for_enterprise: #{e}"
end
```

#### Using the enterprise_admin_set_self_hosted_runners_in_group_for_enterprise_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> enterprise_admin_set_self_hosted_runners_in_group_for_enterprise_with_http_info(enterprise, runner_group_id, enterprise_admin_set_self_hosted_runners_in_group_for_enterprise_request)

```ruby
begin
  # Set self-hosted runners in a group for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_set_self_hosted_runners_in_group_for_enterprise_with_http_info(enterprise, runner_group_id, enterprise_admin_set_self_hosted_runners_in_group_for_enterprise_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_set_self_hosted_runners_in_group_for_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **runner_group_id** | **Integer** | Unique identifier of the self-hosted runner group. |  |
| **enterprise_admin_set_self_hosted_runners_in_group_for_enterprise_request** | [**EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest**](EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest.md) |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## enterprise_admin_update_attribute_for_enterprise_group

> <EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner> enterprise_admin_update_attribute_for_enterprise_group(enterprise, scim_group_id, enterprise_admin_update_attribute_for_enterprise_group_request)

Update an attribute for a SCIM enterprise group

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Allows you to change a provisioned group’s individual attributes. To change a group’s values, you must provide a specific Operations JSON format that contains at least one of the add, remove, or replace operations. For examples and more information on the SCIM operations format, see the [SCIM specification](https://tools.ietf.org/html/rfc7644#section-3.5.2).

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
scim_group_id = 'scim_group_id_example' # String | Identifier generated by the GitHub SCIM endpoint.
enterprise_admin_update_attribute_for_enterprise_group_request = OpenapiClient::EnterpriseAdminUpdateAttributeForEnterpriseGroupRequest.new({schemas: ['schemas_example'], operations: [OpenapiClient::EnterpriseAdminUpdateAttributeForEnterpriseGroupRequestOperationsInner.new({op: 'add'})]}) # EnterpriseAdminUpdateAttributeForEnterpriseGroupRequest | 

begin
  # Update an attribute for a SCIM enterprise group
  result = api_instance.enterprise_admin_update_attribute_for_enterprise_group(enterprise, scim_group_id, enterprise_admin_update_attribute_for_enterprise_group_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_update_attribute_for_enterprise_group: #{e}"
end
```

#### Using the enterprise_admin_update_attribute_for_enterprise_group_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner>, Integer, Hash)> enterprise_admin_update_attribute_for_enterprise_group_with_http_info(enterprise, scim_group_id, enterprise_admin_update_attribute_for_enterprise_group_request)

```ruby
begin
  # Update an attribute for a SCIM enterprise group
  data, status_code, headers = api_instance.enterprise_admin_update_attribute_for_enterprise_group_with_http_info(enterprise, scim_group_id, enterprise_admin_update_attribute_for_enterprise_group_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_update_attribute_for_enterprise_group_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **scim_group_id** | **String** | Identifier generated by the GitHub SCIM endpoint. |  |
| **enterprise_admin_update_attribute_for_enterprise_group_request** | [**EnterpriseAdminUpdateAttributeForEnterpriseGroupRequest**](EnterpriseAdminUpdateAttributeForEnterpriseGroupRequest.md) |  |  |

### Return type

[**EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner**](EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## enterprise_admin_update_attribute_for_enterprise_user

> <EnterpriseAdminProvisionAndInviteEnterpriseUser201Response> enterprise_admin_update_attribute_for_enterprise_user(enterprise, scim_user_id, enterprise_admin_update_attribute_for_enterprise_user_request)

Update an attribute for a SCIM enterprise user

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Allows you to change a provisioned user's individual attributes. To change a user's values, you must provide a specific `Operations` JSON format that contains at least one of the `add`, `remove`, or `replace` operations. For examples and more information on the SCIM operations format, see the [SCIM specification](https://tools.ietf.org/html/rfc7644#section-3.5.2).  **Note:** Complicated SCIM `path` selectors that include filters are not supported. For example, a `path` selector defined as `\"path\": \"emails[type eq \\\"work\\\"]\"` will not work.  **Warning:** If you set `active:false` using the `replace` operation (as shown in the JSON example below), it removes the user from the enterprise, deletes the external identity, and deletes the associated `:scim_user_id`.  ``` {   \"Operations\":[{     \"op\":\"replace\",     \"value\":{       \"active\":false     }   }] } ```

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
scim_user_id = 'scim_user_id_example' # String | The unique identifier of the SCIM user.
enterprise_admin_update_attribute_for_enterprise_user_request = OpenapiClient::EnterpriseAdminUpdateAttributeForEnterpriseUserRequest.new({schemas: ['schemas_example'], operations: [3.56]}) # EnterpriseAdminUpdateAttributeForEnterpriseUserRequest | 

begin
  # Update an attribute for a SCIM enterprise user
  result = api_instance.enterprise_admin_update_attribute_for_enterprise_user(enterprise, scim_user_id, enterprise_admin_update_attribute_for_enterprise_user_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_update_attribute_for_enterprise_user: #{e}"
end
```

#### Using the enterprise_admin_update_attribute_for_enterprise_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminProvisionAndInviteEnterpriseUser201Response>, Integer, Hash)> enterprise_admin_update_attribute_for_enterprise_user_with_http_info(enterprise, scim_user_id, enterprise_admin_update_attribute_for_enterprise_user_request)

```ruby
begin
  # Update an attribute for a SCIM enterprise user
  data, status_code, headers = api_instance.enterprise_admin_update_attribute_for_enterprise_user_with_http_info(enterprise, scim_user_id, enterprise_admin_update_attribute_for_enterprise_user_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminProvisionAndInviteEnterpriseUser201Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_update_attribute_for_enterprise_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **scim_user_id** | **String** | The unique identifier of the SCIM user. |  |
| **enterprise_admin_update_attribute_for_enterprise_user_request** | [**EnterpriseAdminUpdateAttributeForEnterpriseUserRequest**](EnterpriseAdminUpdateAttributeForEnterpriseUserRequest.md) |  |  |

### Return type

[**EnterpriseAdminProvisionAndInviteEnterpriseUser201Response**](EnterpriseAdminProvisionAndInviteEnterpriseUser201Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## enterprise_admin_update_self_hosted_runner_group_for_enterprise

> <EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner> enterprise_admin_update_self_hosted_runner_group_for_enterprise(enterprise, runner_group_id, opts)

Update a self-hosted runner group for an enterprise

Updates the `name` and `visibility` of a self-hosted runner group in an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::EnterpriseAdminApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
runner_group_id = 56 # Integer | Unique identifier of the self-hosted runner group.
opts = {
  enterprise_admin_update_self_hosted_runner_group_for_enterprise_request: OpenapiClient::EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest.new # EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest | 
}

begin
  # Update a self-hosted runner group for an enterprise
  result = api_instance.enterprise_admin_update_self_hosted_runner_group_for_enterprise(enterprise, runner_group_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_update_self_hosted_runner_group_for_enterprise: #{e}"
end
```

#### Using the enterprise_admin_update_self_hosted_runner_group_for_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner>, Integer, Hash)> enterprise_admin_update_self_hosted_runner_group_for_enterprise_with_http_info(enterprise, runner_group_id, opts)

```ruby
begin
  # Update a self-hosted runner group for an enterprise
  data, status_code, headers = api_instance.enterprise_admin_update_self_hosted_runner_group_for_enterprise_with_http_info(enterprise, runner_group_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner>
rescue OpenapiClient::ApiError => e
  puts "Error when calling EnterpriseAdminApi->enterprise_admin_update_self_hosted_runner_group_for_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **runner_group_id** | **Integer** | Unique identifier of the self-hosted runner group. |  |
| **enterprise_admin_update_self_hosted_runner_group_for_enterprise_request** | [**EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest**](EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest.md) |  | [optional] |

### Return type

[**EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner**](EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

