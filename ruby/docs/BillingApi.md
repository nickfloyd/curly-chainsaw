# OpenapiClient::BillingApi

All URIs are relative to *https://api.github.com*

| Method | HTTP request | Description |
| ------ | ------------ | ----------- |
| [**billing_get_github_actions_billing_ghe**](BillingApi.md#billing_get_github_actions_billing_ghe) | **GET** /enterprises/{enterprise}/settings/billing/actions | Get GitHub Actions billing for an enterprise |
| [**billing_get_github_actions_billing_org**](BillingApi.md#billing_get_github_actions_billing_org) | **GET** /orgs/{org}/settings/billing/actions | Get GitHub Actions billing for an organization |
| [**billing_get_github_actions_billing_user**](BillingApi.md#billing_get_github_actions_billing_user) | **GET** /users/{username}/settings/billing/actions | Get GitHub Actions billing for a user |
| [**billing_get_github_advanced_security_billing_ghe**](BillingApi.md#billing_get_github_advanced_security_billing_ghe) | **GET** /enterprises/{enterprise}/settings/billing/advanced-security | Get GitHub Advanced Security active committers for an enterprise |
| [**billing_get_github_advanced_security_billing_org**](BillingApi.md#billing_get_github_advanced_security_billing_org) | **GET** /orgs/{org}/settings/billing/advanced-security | Get GitHub Advanced Security active committers for an organization |
| [**billing_get_github_packages_billing_ghe**](BillingApi.md#billing_get_github_packages_billing_ghe) | **GET** /enterprises/{enterprise}/settings/billing/packages | Get GitHub Packages billing for an enterprise |
| [**billing_get_github_packages_billing_org**](BillingApi.md#billing_get_github_packages_billing_org) | **GET** /orgs/{org}/settings/billing/packages | Get GitHub Packages billing for an organization |
| [**billing_get_github_packages_billing_user**](BillingApi.md#billing_get_github_packages_billing_user) | **GET** /users/{username}/settings/billing/packages | Get GitHub Packages billing for a user |
| [**billing_get_shared_storage_billing_ghe**](BillingApi.md#billing_get_shared_storage_billing_ghe) | **GET** /enterprises/{enterprise}/settings/billing/shared-storage | Get shared storage billing for an enterprise |
| [**billing_get_shared_storage_billing_org**](BillingApi.md#billing_get_shared_storage_billing_org) | **GET** /orgs/{org}/settings/billing/shared-storage | Get shared storage billing for an organization |
| [**billing_get_shared_storage_billing_user**](BillingApi.md#billing_get_shared_storage_billing_user) | **GET** /users/{username}/settings/billing/shared-storage | Get shared storage billing for a user |


## billing_get_github_actions_billing_ghe

> <BillingGetGithubActionsBillingGhe200Response> billing_get_github_actions_billing_ghe(enterprise)

Get GitHub Actions billing for an enterprise

Gets the summary of the free and paid GitHub Actions minutes used.  Paid minutes only apply to workflows in private repositories that use GitHub-hosted runners. Minutes used is listed for each GitHub-hosted runner operating system. Any job re-runs are also included in the usage. The usage does not include the multiplier for macOS and Windows runners and is not rounded up to the nearest whole minute. For more information, see \"[Managing billing for GitHub Actions](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-actions)\".  The authenticated user must be an enterprise admin.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::BillingApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.

begin
  # Get GitHub Actions billing for an enterprise
  result = api_instance.billing_get_github_actions_billing_ghe(enterprise)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling BillingApi->billing_get_github_actions_billing_ghe: #{e}"
end
```

#### Using the billing_get_github_actions_billing_ghe_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<BillingGetGithubActionsBillingGhe200Response>, Integer, Hash)> billing_get_github_actions_billing_ghe_with_http_info(enterprise)

```ruby
begin
  # Get GitHub Actions billing for an enterprise
  data, status_code, headers = api_instance.billing_get_github_actions_billing_ghe_with_http_info(enterprise)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <BillingGetGithubActionsBillingGhe200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling BillingApi->billing_get_github_actions_billing_ghe_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |

### Return type

[**BillingGetGithubActionsBillingGhe200Response**](BillingGetGithubActionsBillingGhe200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## billing_get_github_actions_billing_org

> <BillingGetGithubActionsBillingGhe200Response> billing_get_github_actions_billing_org(org)

Get GitHub Actions billing for an organization

Gets the summary of the free and paid GitHub Actions minutes used.  Paid minutes only apply to workflows in private repositories that use GitHub-hosted runners. Minutes used is listed for each GitHub-hosted runner operating system. Any job re-runs are also included in the usage. The usage returned includes any minute multipliers for macOS and Windows runners, and is rounded up to the nearest whole minute. For more information, see \"[Managing billing for GitHub Actions](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-actions)\".  Access tokens must have the `repo` or `admin:org` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::BillingApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.

begin
  # Get GitHub Actions billing for an organization
  result = api_instance.billing_get_github_actions_billing_org(org)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling BillingApi->billing_get_github_actions_billing_org: #{e}"
end
```

#### Using the billing_get_github_actions_billing_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<BillingGetGithubActionsBillingGhe200Response>, Integer, Hash)> billing_get_github_actions_billing_org_with_http_info(org)

```ruby
begin
  # Get GitHub Actions billing for an organization
  data, status_code, headers = api_instance.billing_get_github_actions_billing_org_with_http_info(org)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <BillingGetGithubActionsBillingGhe200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling BillingApi->billing_get_github_actions_billing_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |

### Return type

[**BillingGetGithubActionsBillingGhe200Response**](BillingGetGithubActionsBillingGhe200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## billing_get_github_actions_billing_user

> <BillingGetGithubActionsBillingGhe200Response> billing_get_github_actions_billing_user(username)

Get GitHub Actions billing for a user

Gets the summary of the free and paid GitHub Actions minutes used.  Paid minutes only apply to workflows in private repositories that use GitHub-hosted runners. Minutes used is listed for each GitHub-hosted runner operating system. Any job re-runs are also included in the usage. The usage returned includes any minute multipliers for macOS and Windows runners, and is rounded up to the nearest whole minute. For more information, see \"[Managing billing for GitHub Actions](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-actions)\".  Access tokens must have the `user` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::BillingApi.new
username = 'username_example' # String | The handle for the GitHub user account.

begin
  # Get GitHub Actions billing for a user
  result = api_instance.billing_get_github_actions_billing_user(username)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling BillingApi->billing_get_github_actions_billing_user: #{e}"
end
```

#### Using the billing_get_github_actions_billing_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<BillingGetGithubActionsBillingGhe200Response>, Integer, Hash)> billing_get_github_actions_billing_user_with_http_info(username)

```ruby
begin
  # Get GitHub Actions billing for a user
  data, status_code, headers = api_instance.billing_get_github_actions_billing_user_with_http_info(username)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <BillingGetGithubActionsBillingGhe200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling BillingApi->billing_get_github_actions_billing_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **username** | **String** | The handle for the GitHub user account. |  |

### Return type

[**BillingGetGithubActionsBillingGhe200Response**](BillingGetGithubActionsBillingGhe200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## billing_get_github_advanced_security_billing_ghe

> <BillingGetGithubAdvancedSecurityBillingGhe200Response> billing_get_github_advanced_security_billing_ghe(enterprise, opts)

Get GitHub Advanced Security active committers for an enterprise

Gets the GitHub Advanced Security active committers for an enterprise per repository.  Each distinct user login across all repositories is counted as a single Advanced Security seat, so the `total_advanced_security_committers` is not the sum of active_users for each repository.  The total number of repositories with committer information is tracked by the `total_count` field.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::BillingApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # Get GitHub Advanced Security active committers for an enterprise
  result = api_instance.billing_get_github_advanced_security_billing_ghe(enterprise, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling BillingApi->billing_get_github_advanced_security_billing_ghe: #{e}"
end
```

#### Using the billing_get_github_advanced_security_billing_ghe_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<BillingGetGithubAdvancedSecurityBillingGhe200Response>, Integer, Hash)> billing_get_github_advanced_security_billing_ghe_with_http_info(enterprise, opts)

```ruby
begin
  # Get GitHub Advanced Security active committers for an enterprise
  data, status_code, headers = api_instance.billing_get_github_advanced_security_billing_ghe_with_http_info(enterprise, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <BillingGetGithubAdvancedSecurityBillingGhe200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling BillingApi->billing_get_github_advanced_security_billing_ghe_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**BillingGetGithubAdvancedSecurityBillingGhe200Response**](BillingGetGithubAdvancedSecurityBillingGhe200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## billing_get_github_advanced_security_billing_org

> <BillingGetGithubAdvancedSecurityBillingGhe200Response> billing_get_github_advanced_security_billing_org(org, opts)

Get GitHub Advanced Security active committers for an organization

Gets the GitHub Advanced Security active committers for an organization per repository.  Each distinct user login across all repositories is counted as a single Advanced Security seat, so the `total_advanced_security_committers` is not the sum of advanced_security_committers for each repository.  If this organization defers to an enterprise for billing, the `total_advanced_security_committers` returned from the organization API may include some users that are in more than one organization, so they will only consume a single Advanced Security seat at the enterprise level.  The total number of repositories with committer information is tracked by the `total_count` field.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::BillingApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # Get GitHub Advanced Security active committers for an organization
  result = api_instance.billing_get_github_advanced_security_billing_org(org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling BillingApi->billing_get_github_advanced_security_billing_org: #{e}"
end
```

#### Using the billing_get_github_advanced_security_billing_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<BillingGetGithubAdvancedSecurityBillingGhe200Response>, Integer, Hash)> billing_get_github_advanced_security_billing_org_with_http_info(org, opts)

```ruby
begin
  # Get GitHub Advanced Security active committers for an organization
  data, status_code, headers = api_instance.billing_get_github_advanced_security_billing_org_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <BillingGetGithubAdvancedSecurityBillingGhe200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling BillingApi->billing_get_github_advanced_security_billing_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**BillingGetGithubAdvancedSecurityBillingGhe200Response**](BillingGetGithubAdvancedSecurityBillingGhe200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## billing_get_github_packages_billing_ghe

> <BillingGetGithubPackagesBillingGhe200Response> billing_get_github_packages_billing_ghe(enterprise)

Get GitHub Packages billing for an enterprise

Gets the free and paid storage used for GitHub Packages in gigabytes.  Paid minutes only apply to packages stored for private repositories. For more information, see \"[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\"  The authenticated user must be an enterprise admin.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::BillingApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.

begin
  # Get GitHub Packages billing for an enterprise
  result = api_instance.billing_get_github_packages_billing_ghe(enterprise)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling BillingApi->billing_get_github_packages_billing_ghe: #{e}"
end
```

#### Using the billing_get_github_packages_billing_ghe_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<BillingGetGithubPackagesBillingGhe200Response>, Integer, Hash)> billing_get_github_packages_billing_ghe_with_http_info(enterprise)

```ruby
begin
  # Get GitHub Packages billing for an enterprise
  data, status_code, headers = api_instance.billing_get_github_packages_billing_ghe_with_http_info(enterprise)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <BillingGetGithubPackagesBillingGhe200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling BillingApi->billing_get_github_packages_billing_ghe_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |

### Return type

[**BillingGetGithubPackagesBillingGhe200Response**](BillingGetGithubPackagesBillingGhe200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## billing_get_github_packages_billing_org

> <BillingGetGithubPackagesBillingGhe200Response> billing_get_github_packages_billing_org(org)

Get GitHub Packages billing for an organization

Gets the free and paid storage used for GitHub Packages in gigabytes.  Paid minutes only apply to packages stored for private repositories. For more information, see \"[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\"  Access tokens must have the `repo` or `admin:org` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::BillingApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.

begin
  # Get GitHub Packages billing for an organization
  result = api_instance.billing_get_github_packages_billing_org(org)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling BillingApi->billing_get_github_packages_billing_org: #{e}"
end
```

#### Using the billing_get_github_packages_billing_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<BillingGetGithubPackagesBillingGhe200Response>, Integer, Hash)> billing_get_github_packages_billing_org_with_http_info(org)

```ruby
begin
  # Get GitHub Packages billing for an organization
  data, status_code, headers = api_instance.billing_get_github_packages_billing_org_with_http_info(org)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <BillingGetGithubPackagesBillingGhe200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling BillingApi->billing_get_github_packages_billing_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |

### Return type

[**BillingGetGithubPackagesBillingGhe200Response**](BillingGetGithubPackagesBillingGhe200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## billing_get_github_packages_billing_user

> <BillingGetGithubPackagesBillingGhe200Response> billing_get_github_packages_billing_user(username)

Get GitHub Packages billing for a user

Gets the free and paid storage used for GitHub Packages in gigabytes.  Paid minutes only apply to packages stored for private repositories. For more information, see \"[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\"  Access tokens must have the `user` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::BillingApi.new
username = 'username_example' # String | The handle for the GitHub user account.

begin
  # Get GitHub Packages billing for a user
  result = api_instance.billing_get_github_packages_billing_user(username)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling BillingApi->billing_get_github_packages_billing_user: #{e}"
end
```

#### Using the billing_get_github_packages_billing_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<BillingGetGithubPackagesBillingGhe200Response>, Integer, Hash)> billing_get_github_packages_billing_user_with_http_info(username)

```ruby
begin
  # Get GitHub Packages billing for a user
  data, status_code, headers = api_instance.billing_get_github_packages_billing_user_with_http_info(username)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <BillingGetGithubPackagesBillingGhe200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling BillingApi->billing_get_github_packages_billing_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **username** | **String** | The handle for the GitHub user account. |  |

### Return type

[**BillingGetGithubPackagesBillingGhe200Response**](BillingGetGithubPackagesBillingGhe200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## billing_get_shared_storage_billing_ghe

> <BillingGetSharedStorageBillingGhe200Response> billing_get_shared_storage_billing_ghe(enterprise)

Get shared storage billing for an enterprise

Gets the estimated paid and estimated total storage used for GitHub Actions and GitHub Packages.  Paid minutes only apply to packages stored for private repositories. For more information, see \"[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\"  The authenticated user must be an enterprise admin.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::BillingApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.

begin
  # Get shared storage billing for an enterprise
  result = api_instance.billing_get_shared_storage_billing_ghe(enterprise)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling BillingApi->billing_get_shared_storage_billing_ghe: #{e}"
end
```

#### Using the billing_get_shared_storage_billing_ghe_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<BillingGetSharedStorageBillingGhe200Response>, Integer, Hash)> billing_get_shared_storage_billing_ghe_with_http_info(enterprise)

```ruby
begin
  # Get shared storage billing for an enterprise
  data, status_code, headers = api_instance.billing_get_shared_storage_billing_ghe_with_http_info(enterprise)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <BillingGetSharedStorageBillingGhe200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling BillingApi->billing_get_shared_storage_billing_ghe_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |

### Return type

[**BillingGetSharedStorageBillingGhe200Response**](BillingGetSharedStorageBillingGhe200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## billing_get_shared_storage_billing_org

> <BillingGetSharedStorageBillingGhe200Response> billing_get_shared_storage_billing_org(org)

Get shared storage billing for an organization

Gets the estimated paid and estimated total storage used for GitHub Actions and GitHub Packages.  Paid minutes only apply to packages stored for private repositories. For more information, see \"[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\"  Access tokens must have the `repo` or `admin:org` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::BillingApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.

begin
  # Get shared storage billing for an organization
  result = api_instance.billing_get_shared_storage_billing_org(org)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling BillingApi->billing_get_shared_storage_billing_org: #{e}"
end
```

#### Using the billing_get_shared_storage_billing_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<BillingGetSharedStorageBillingGhe200Response>, Integer, Hash)> billing_get_shared_storage_billing_org_with_http_info(org)

```ruby
begin
  # Get shared storage billing for an organization
  data, status_code, headers = api_instance.billing_get_shared_storage_billing_org_with_http_info(org)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <BillingGetSharedStorageBillingGhe200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling BillingApi->billing_get_shared_storage_billing_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |

### Return type

[**BillingGetSharedStorageBillingGhe200Response**](BillingGetSharedStorageBillingGhe200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## billing_get_shared_storage_billing_user

> <BillingGetSharedStorageBillingGhe200Response> billing_get_shared_storage_billing_user(username)

Get shared storage billing for a user

Gets the estimated paid and estimated total storage used for GitHub Actions and GitHub Packages.  Paid minutes only apply to packages stored for private repositories. For more information, see \"[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\"  Access tokens must have the `user` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::BillingApi.new
username = 'username_example' # String | The handle for the GitHub user account.

begin
  # Get shared storage billing for a user
  result = api_instance.billing_get_shared_storage_billing_user(username)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling BillingApi->billing_get_shared_storage_billing_user: #{e}"
end
```

#### Using the billing_get_shared_storage_billing_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<BillingGetSharedStorageBillingGhe200Response>, Integer, Hash)> billing_get_shared_storage_billing_user_with_http_info(username)

```ruby
begin
  # Get shared storage billing for a user
  data, status_code, headers = api_instance.billing_get_shared_storage_billing_user_with_http_info(username)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <BillingGetSharedStorageBillingGhe200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling BillingApi->billing_get_shared_storage_billing_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **username** | **String** | The handle for the GitHub user account. |  |

### Return type

[**BillingGetSharedStorageBillingGhe200Response**](BillingGetSharedStorageBillingGhe200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

