# OpenapiClient::OidcApi

All URIs are relative to *https://api.github.com*

| Method | HTTP request | Description |
| ------ | ------------ | ----------- |
| [**oidc_get_oidc_custom_sub_template_for_org**](OidcApi.md#oidc_get_oidc_custom_sub_template_for_org) | **GET** /orgs/{org}/actions/oidc/customization/sub | Get the customization template for an OIDC subject claim for an organization |
| [**oidc_update_oidc_custom_sub_template_for_org**](OidcApi.md#oidc_update_oidc_custom_sub_template_for_org) | **PUT** /orgs/{org}/actions/oidc/customization/sub | Set the customization template for an OIDC subject claim for an organization |


## oidc_get_oidc_custom_sub_template_for_org

> <ActionsOIDCSubjectCustomization> oidc_get_oidc_custom_sub_template_for_org(org)

Get the customization template for an OIDC subject claim for an organization

Gets the customization template for an OpenID Connect (OIDC) subject claim. You must authenticate using an access token with the `read:org` scope to use this endpoint. GitHub Apps must have the `organization_administration:write` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OidcApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.

begin
  # Get the customization template for an OIDC subject claim for an organization
  result = api_instance.oidc_get_oidc_custom_sub_template_for_org(org)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OidcApi->oidc_get_oidc_custom_sub_template_for_org: #{e}"
end
```

#### Using the oidc_get_oidc_custom_sub_template_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsOIDCSubjectCustomization>, Integer, Hash)> oidc_get_oidc_custom_sub_template_for_org_with_http_info(org)

```ruby
begin
  # Get the customization template for an OIDC subject claim for an organization
  data, status_code, headers = api_instance.oidc_get_oidc_custom_sub_template_for_org_with_http_info(org)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsOIDCSubjectCustomization>
rescue OpenapiClient::ApiError => e
  puts "Error when calling OidcApi->oidc_get_oidc_custom_sub_template_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |

### Return type

[**ActionsOIDCSubjectCustomization**](ActionsOIDCSubjectCustomization.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## oidc_update_oidc_custom_sub_template_for_org

> Object oidc_update_oidc_custom_sub_template_for_org(org, actions_oidc_subject_customization)

Set the customization template for an OIDC subject claim for an organization

Creates or updates the customization template for an OpenID Connect (OIDC) subject claim. You must authenticate using an access token with the `write:org` scope to use this endpoint. GitHub Apps must have the `admin:org` permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::OidcApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
actions_oidc_subject_customization = OpenapiClient::ActionsOIDCSubjectCustomization.new({include_claim_keys: ['include_claim_keys_example']}) # ActionsOIDCSubjectCustomization | 

begin
  # Set the customization template for an OIDC subject claim for an organization
  result = api_instance.oidc_update_oidc_custom_sub_template_for_org(org, actions_oidc_subject_customization)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling OidcApi->oidc_update_oidc_custom_sub_template_for_org: #{e}"
end
```

#### Using the oidc_update_oidc_custom_sub_template_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Object, Integer, Hash)> oidc_update_oidc_custom_sub_template_for_org_with_http_info(org, actions_oidc_subject_customization)

```ruby
begin
  # Set the customization template for an OIDC subject claim for an organization
  data, status_code, headers = api_instance.oidc_update_oidc_custom_sub_template_for_org_with_http_info(org, actions_oidc_subject_customization)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Object
rescue OpenapiClient::ApiError => e
  puts "Error when calling OidcApi->oidc_update_oidc_custom_sub_template_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **actions_oidc_subject_customization** | [**ActionsOIDCSubjectCustomization**](ActionsOIDCSubjectCustomization.md) |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

