# OpenapiClient::PackagesApi

All URIs are relative to *https://api.github.com*

| Method | HTTP request | Description |
| ------ | ------------ | ----------- |
| [**packages_delete_package_for_authenticated_user**](PackagesApi.md#packages_delete_package_for_authenticated_user) | **DELETE** /user/packages/{package_type}/{package_name} | Delete a package for the authenticated user |
| [**packages_delete_package_for_org**](PackagesApi.md#packages_delete_package_for_org) | **DELETE** /orgs/{org}/packages/{package_type}/{package_name} | Delete a package for an organization |
| [**packages_delete_package_for_user**](PackagesApi.md#packages_delete_package_for_user) | **DELETE** /users/{username}/packages/{package_type}/{package_name} | Delete a package for a user |
| [**packages_delete_package_version_for_authenticated_user**](PackagesApi.md#packages_delete_package_version_for_authenticated_user) | **DELETE** /user/packages/{package_type}/{package_name}/versions/{package_version_id} | Delete a package version for the authenticated user |
| [**packages_delete_package_version_for_org**](PackagesApi.md#packages_delete_package_version_for_org) | **DELETE** /orgs/{org}/packages/{package_type}/{package_name}/versions/{package_version_id} | Delete package version for an organization |
| [**packages_delete_package_version_for_user**](PackagesApi.md#packages_delete_package_version_for_user) | **DELETE** /users/{username}/packages/{package_type}/{package_name}/versions/{package_version_id} | Delete package version for a user |
| [**packages_get_all_package_versions_for_package_owned_by_authenticated_user**](PackagesApi.md#packages_get_all_package_versions_for_package_owned_by_authenticated_user) | **GET** /user/packages/{package_type}/{package_name}/versions | Get all package versions for a package owned by the authenticated user |
| [**packages_get_all_package_versions_for_package_owned_by_org**](PackagesApi.md#packages_get_all_package_versions_for_package_owned_by_org) | **GET** /orgs/{org}/packages/{package_type}/{package_name}/versions | Get all package versions for a package owned by an organization |
| [**packages_get_all_package_versions_for_package_owned_by_user**](PackagesApi.md#packages_get_all_package_versions_for_package_owned_by_user) | **GET** /users/{username}/packages/{package_type}/{package_name}/versions | Get all package versions for a package owned by a user |
| [**packages_get_package_for_authenticated_user**](PackagesApi.md#packages_get_package_for_authenticated_user) | **GET** /user/packages/{package_type}/{package_name} | Get a package for the authenticated user |
| [**packages_get_package_for_organization**](PackagesApi.md#packages_get_package_for_organization) | **GET** /orgs/{org}/packages/{package_type}/{package_name} | Get a package for an organization |
| [**packages_get_package_for_user**](PackagesApi.md#packages_get_package_for_user) | **GET** /users/{username}/packages/{package_type}/{package_name} | Get a package for a user |
| [**packages_get_package_version_for_authenticated_user**](PackagesApi.md#packages_get_package_version_for_authenticated_user) | **GET** /user/packages/{package_type}/{package_name}/versions/{package_version_id} | Get a package version for the authenticated user |
| [**packages_get_package_version_for_organization**](PackagesApi.md#packages_get_package_version_for_organization) | **GET** /orgs/{org}/packages/{package_type}/{package_name}/versions/{package_version_id} | Get a package version for an organization |
| [**packages_get_package_version_for_user**](PackagesApi.md#packages_get_package_version_for_user) | **GET** /users/{username}/packages/{package_type}/{package_name}/versions/{package_version_id} | Get a package version for a user |
| [**packages_list_packages_for_authenticated_user**](PackagesApi.md#packages_list_packages_for_authenticated_user) | **GET** /user/packages | List packages for the authenticated user&#39;s namespace |
| [**packages_list_packages_for_organization**](PackagesApi.md#packages_list_packages_for_organization) | **GET** /orgs/{org}/packages | List packages for an organization |
| [**packages_list_packages_for_user**](PackagesApi.md#packages_list_packages_for_user) | **GET** /users/{username}/packages | List packages for a user |
| [**packages_restore_package_for_authenticated_user**](PackagesApi.md#packages_restore_package_for_authenticated_user) | **POST** /user/packages/{package_type}/{package_name}/restore | Restore a package for the authenticated user |
| [**packages_restore_package_for_org**](PackagesApi.md#packages_restore_package_for_org) | **POST** /orgs/{org}/packages/{package_type}/{package_name}/restore | Restore a package for an organization |
| [**packages_restore_package_for_user**](PackagesApi.md#packages_restore_package_for_user) | **POST** /users/{username}/packages/{package_type}/{package_name}/restore | Restore a package for a user |
| [**packages_restore_package_version_for_authenticated_user**](PackagesApi.md#packages_restore_package_version_for_authenticated_user) | **POST** /user/packages/{package_type}/{package_name}/versions/{package_version_id}/restore | Restore a package version for the authenticated user |
| [**packages_restore_package_version_for_org**](PackagesApi.md#packages_restore_package_version_for_org) | **POST** /orgs/{org}/packages/{package_type}/{package_name}/versions/{package_version_id}/restore | Restore package version for an organization |
| [**packages_restore_package_version_for_user**](PackagesApi.md#packages_restore_package_version_for_user) | **POST** /users/{username}/packages/{package_type}/{package_name}/versions/{package_version_id}/restore | Restore package version for a user |


## packages_delete_package_for_authenticated_user

> packages_delete_package_for_authenticated_user(package_type, package_name)

Delete a package for the authenticated user

Deletes a package owned by the authenticated user. You cannot delete a public package if any version of the package has more than 5,000 downloads. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must authenticate using an access token with the `packages:read` and `packages:delete` scopes. If `package_type` is not `container`, your token must also include the `repo` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
package_name = 'package_name_example' # String | The name of the package.

begin
  # Delete a package for the authenticated user
  api_instance.packages_delete_package_for_authenticated_user(package_type, package_name)
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_delete_package_for_authenticated_user: #{e}"
end
```

#### Using the packages_delete_package_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> packages_delete_package_for_authenticated_user_with_http_info(package_type, package_name)

```ruby
begin
  # Delete a package for the authenticated user
  data, status_code, headers = api_instance.packages_delete_package_for_authenticated_user_with_http_info(package_type, package_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_delete_package_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **package_name** | **String** | The name of the package. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_delete_package_for_org

> packages_delete_package_for_org(package_type, package_name, org)

Delete a package for an organization

Deletes an entire package in an organization. You cannot delete a public package if any version of the package has more than 5,000 downloads. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must have admin permissions in the organization and authenticate using an access token with the `packages:read` and `packages:delete` scopes. In addition: - If `package_type` is not `container`, your token must also include the `repo` scope. - If `package_type` is `container`, you must also have admin permissions to the container you want to delete.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
package_name = 'package_name_example' # String | The name of the package.
org = 'org_example' # String | The organization name. The name is not case sensitive.

begin
  # Delete a package for an organization
  api_instance.packages_delete_package_for_org(package_type, package_name, org)
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_delete_package_for_org: #{e}"
end
```

#### Using the packages_delete_package_for_org_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> packages_delete_package_for_org_with_http_info(package_type, package_name, org)

```ruby
begin
  # Delete a package for an organization
  data, status_code, headers = api_instance.packages_delete_package_for_org_with_http_info(package_type, package_name, org)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_delete_package_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **package_name** | **String** | The name of the package. |  |
| **org** | **String** | The organization name. The name is not case sensitive. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_delete_package_for_user

> packages_delete_package_for_user(package_type, package_name, username)

Delete a package for a user

Deletes an entire package for a user. You cannot delete a public package if any version of the package has more than 5,000 downloads. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must authenticate using an access token with the `packages:read` and `packages:delete` scopes. In addition: - If `package_type` is not `container`, your token must also include the `repo` scope. - If `package_type` is `container`, you must also have admin permissions to the container you want to delete.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
package_name = 'package_name_example' # String | The name of the package.
username = 'username_example' # String | The handle for the GitHub user account.

begin
  # Delete a package for a user
  api_instance.packages_delete_package_for_user(package_type, package_name, username)
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_delete_package_for_user: #{e}"
end
```

#### Using the packages_delete_package_for_user_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> packages_delete_package_for_user_with_http_info(package_type, package_name, username)

```ruby
begin
  # Delete a package for a user
  data, status_code, headers = api_instance.packages_delete_package_for_user_with_http_info(package_type, package_name, username)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_delete_package_for_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **package_name** | **String** | The name of the package. |  |
| **username** | **String** | The handle for the GitHub user account. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_delete_package_version_for_authenticated_user

> packages_delete_package_version_for_authenticated_user(package_type, package_name, package_version_id)

Delete a package version for the authenticated user

Deletes a specific package version for a package owned by the authenticated user.  If the package is public and the package version has more than 5,000 downloads, you cannot delete the package version. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must have admin permissions in the organization and authenticate using an access token with the `packages:read` and `packages:delete` scopes. If `package_type` is not `container`, your token must also include the `repo` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
package_name = 'package_name_example' # String | The name of the package.
package_version_id = 56 # Integer | Unique identifier of the package version.

begin
  # Delete a package version for the authenticated user
  api_instance.packages_delete_package_version_for_authenticated_user(package_type, package_name, package_version_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_delete_package_version_for_authenticated_user: #{e}"
end
```

#### Using the packages_delete_package_version_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> packages_delete_package_version_for_authenticated_user_with_http_info(package_type, package_name, package_version_id)

```ruby
begin
  # Delete a package version for the authenticated user
  data, status_code, headers = api_instance.packages_delete_package_version_for_authenticated_user_with_http_info(package_type, package_name, package_version_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_delete_package_version_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **package_name** | **String** | The name of the package. |  |
| **package_version_id** | **Integer** | Unique identifier of the package version. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_delete_package_version_for_org

> packages_delete_package_version_for_org(package_type, package_name, org, package_version_id)

Delete package version for an organization

Deletes a specific package version in an organization. If the package is public and the package version has more than 5,000 downloads, you cannot delete the package version. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must have admin permissions in the organization and authenticate using an access token with the `packages:read` and `packages:delete` scopes. In addition: - If `package_type` is not `container`, your token must also include the `repo` scope. - If `package_type` is `container`, you must also have admin permissions to the container you want to delete.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
package_name = 'package_name_example' # String | The name of the package.
org = 'org_example' # String | The organization name. The name is not case sensitive.
package_version_id = 56 # Integer | Unique identifier of the package version.

begin
  # Delete package version for an organization
  api_instance.packages_delete_package_version_for_org(package_type, package_name, org, package_version_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_delete_package_version_for_org: #{e}"
end
```

#### Using the packages_delete_package_version_for_org_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> packages_delete_package_version_for_org_with_http_info(package_type, package_name, org, package_version_id)

```ruby
begin
  # Delete package version for an organization
  data, status_code, headers = api_instance.packages_delete_package_version_for_org_with_http_info(package_type, package_name, org, package_version_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_delete_package_version_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **package_name** | **String** | The name of the package. |  |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **package_version_id** | **Integer** | Unique identifier of the package version. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_delete_package_version_for_user

> packages_delete_package_version_for_user(package_type, package_name, username, package_version_id)

Delete package version for a user

Deletes a specific package version for a user. If the package is public and the package version has more than 5,000 downloads, you cannot delete the package version. In this scenario, contact GitHub support for further assistance.  To use this endpoint, you must authenticate using an access token with the `packages:read` and `packages:delete` scopes. In addition: - If `package_type` is not `container`, your token must also include the `repo` scope. - If `package_type` is `container`, you must also have admin permissions to the container you want to delete.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
package_name = 'package_name_example' # String | The name of the package.
username = 'username_example' # String | The handle for the GitHub user account.
package_version_id = 56 # Integer | Unique identifier of the package version.

begin
  # Delete package version for a user
  api_instance.packages_delete_package_version_for_user(package_type, package_name, username, package_version_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_delete_package_version_for_user: #{e}"
end
```

#### Using the packages_delete_package_version_for_user_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> packages_delete_package_version_for_user_with_http_info(package_type, package_name, username, package_version_id)

```ruby
begin
  # Delete package version for a user
  data, status_code, headers = api_instance.packages_delete_package_version_for_user_with_http_info(package_type, package_name, username, package_version_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_delete_package_version_for_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **package_name** | **String** | The name of the package. |  |
| **username** | **String** | The handle for the GitHub user account. |  |
| **package_version_id** | **Integer** | Unique identifier of the package version. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_get_all_package_versions_for_package_owned_by_authenticated_user

> <Array<PackageVersion>> packages_get_all_package_versions_for_package_owned_by_authenticated_user(package_type, package_name, opts)

Get all package versions for a package owned by the authenticated user

Returns all package versions for a package owned by the authenticated user.  To use this endpoint, you must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
package_name = 'package_name_example' # String | The name of the package.
opts = {
  page: 56, # Integer | Page number of the results to fetch.
  per_page: 56, # Integer | The number of results per page (max 100).
  state: 'active' # String | The state of the package, either active or deleted.
}

begin
  # Get all package versions for a package owned by the authenticated user
  result = api_instance.packages_get_all_package_versions_for_package_owned_by_authenticated_user(package_type, package_name, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_get_all_package_versions_for_package_owned_by_authenticated_user: #{e}"
end
```

#### Using the packages_get_all_package_versions_for_package_owned_by_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<PackageVersion>>, Integer, Hash)> packages_get_all_package_versions_for_package_owned_by_authenticated_user_with_http_info(package_type, package_name, opts)

```ruby
begin
  # Get all package versions for a package owned by the authenticated user
  data, status_code, headers = api_instance.packages_get_all_package_versions_for_package_owned_by_authenticated_user_with_http_info(package_type, package_name, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<PackageVersion>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_get_all_package_versions_for_package_owned_by_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **package_name** | **String** | The name of the package. |  |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **state** | **String** | The state of the package, either active or deleted. | [optional][default to &#39;active&#39;] |

### Return type

[**Array&lt;PackageVersion&gt;**](PackageVersion.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_get_all_package_versions_for_package_owned_by_org

> <Array<PackageVersion>> packages_get_all_package_versions_for_package_owned_by_org(package_type, package_name, org, opts)

Get all package versions for a package owned by an organization

Returns all package versions for a package owned by an organization.  To use this endpoint, you must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
package_name = 'package_name_example' # String | The name of the package.
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  page: 56, # Integer | Page number of the results to fetch.
  per_page: 56, # Integer | The number of results per page (max 100).
  state: 'active' # String | The state of the package, either active or deleted.
}

begin
  # Get all package versions for a package owned by an organization
  result = api_instance.packages_get_all_package_versions_for_package_owned_by_org(package_type, package_name, org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_get_all_package_versions_for_package_owned_by_org: #{e}"
end
```

#### Using the packages_get_all_package_versions_for_package_owned_by_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<PackageVersion>>, Integer, Hash)> packages_get_all_package_versions_for_package_owned_by_org_with_http_info(package_type, package_name, org, opts)

```ruby
begin
  # Get all package versions for a package owned by an organization
  data, status_code, headers = api_instance.packages_get_all_package_versions_for_package_owned_by_org_with_http_info(package_type, package_name, org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<PackageVersion>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_get_all_package_versions_for_package_owned_by_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **package_name** | **String** | The name of the package. |  |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **state** | **String** | The state of the package, either active or deleted. | [optional][default to &#39;active&#39;] |

### Return type

[**Array&lt;PackageVersion&gt;**](PackageVersion.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_get_all_package_versions_for_package_owned_by_user

> <Array<PackageVersion>> packages_get_all_package_versions_for_package_owned_by_user(package_type, package_name, username)

Get all package versions for a package owned by a user

Returns all package versions for a public package owned by a specified user.  To use this endpoint, you must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
package_name = 'package_name_example' # String | The name of the package.
username = 'username_example' # String | The handle for the GitHub user account.

begin
  # Get all package versions for a package owned by a user
  result = api_instance.packages_get_all_package_versions_for_package_owned_by_user(package_type, package_name, username)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_get_all_package_versions_for_package_owned_by_user: #{e}"
end
```

#### Using the packages_get_all_package_versions_for_package_owned_by_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<PackageVersion>>, Integer, Hash)> packages_get_all_package_versions_for_package_owned_by_user_with_http_info(package_type, package_name, username)

```ruby
begin
  # Get all package versions for a package owned by a user
  data, status_code, headers = api_instance.packages_get_all_package_versions_for_package_owned_by_user_with_http_info(package_type, package_name, username)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<PackageVersion>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_get_all_package_versions_for_package_owned_by_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **package_name** | **String** | The name of the package. |  |
| **username** | **String** | The handle for the GitHub user account. |  |

### Return type

[**Array&lt;PackageVersion&gt;**](PackageVersion.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_get_package_for_authenticated_user

> <Package> packages_get_package_for_authenticated_user(package_type, package_name)

Get a package for the authenticated user

Gets a specific package for a package owned by the authenticated user.  To use this endpoint, you must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
package_name = 'package_name_example' # String | The name of the package.

begin
  # Get a package for the authenticated user
  result = api_instance.packages_get_package_for_authenticated_user(package_type, package_name)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_get_package_for_authenticated_user: #{e}"
end
```

#### Using the packages_get_package_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Package>, Integer, Hash)> packages_get_package_for_authenticated_user_with_http_info(package_type, package_name)

```ruby
begin
  # Get a package for the authenticated user
  data, status_code, headers = api_instance.packages_get_package_for_authenticated_user_with_http_info(package_type, package_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Package>
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_get_package_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **package_name** | **String** | The name of the package. |  |

### Return type

[**Package**](Package.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_get_package_for_organization

> <Package> packages_get_package_for_organization(package_type, package_name, org)

Get a package for an organization

Gets a specific package in an organization.  To use this endpoint, you must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
package_name = 'package_name_example' # String | The name of the package.
org = 'org_example' # String | The organization name. The name is not case sensitive.

begin
  # Get a package for an organization
  result = api_instance.packages_get_package_for_organization(package_type, package_name, org)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_get_package_for_organization: #{e}"
end
```

#### Using the packages_get_package_for_organization_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Package>, Integer, Hash)> packages_get_package_for_organization_with_http_info(package_type, package_name, org)

```ruby
begin
  # Get a package for an organization
  data, status_code, headers = api_instance.packages_get_package_for_organization_with_http_info(package_type, package_name, org)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Package>
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_get_package_for_organization_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **package_name** | **String** | The name of the package. |  |
| **org** | **String** | The organization name. The name is not case sensitive. |  |

### Return type

[**Package**](Package.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_get_package_for_user

> <Package> packages_get_package_for_user(package_type, package_name, username)

Get a package for a user

Gets a specific package metadata for a public package owned by a user.  To use this endpoint, you must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
package_name = 'package_name_example' # String | The name of the package.
username = 'username_example' # String | The handle for the GitHub user account.

begin
  # Get a package for a user
  result = api_instance.packages_get_package_for_user(package_type, package_name, username)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_get_package_for_user: #{e}"
end
```

#### Using the packages_get_package_for_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Package>, Integer, Hash)> packages_get_package_for_user_with_http_info(package_type, package_name, username)

```ruby
begin
  # Get a package for a user
  data, status_code, headers = api_instance.packages_get_package_for_user_with_http_info(package_type, package_name, username)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Package>
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_get_package_for_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **package_name** | **String** | The name of the package. |  |
| **username** | **String** | The handle for the GitHub user account. |  |

### Return type

[**Package**](Package.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_get_package_version_for_authenticated_user

> <PackageVersion> packages_get_package_version_for_authenticated_user(package_type, package_name, package_version_id)

Get a package version for the authenticated user

Gets a specific package version for a package owned by the authenticated user.  To use this endpoint, you must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
package_name = 'package_name_example' # String | The name of the package.
package_version_id = 56 # Integer | Unique identifier of the package version.

begin
  # Get a package version for the authenticated user
  result = api_instance.packages_get_package_version_for_authenticated_user(package_type, package_name, package_version_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_get_package_version_for_authenticated_user: #{e}"
end
```

#### Using the packages_get_package_version_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<PackageVersion>, Integer, Hash)> packages_get_package_version_for_authenticated_user_with_http_info(package_type, package_name, package_version_id)

```ruby
begin
  # Get a package version for the authenticated user
  data, status_code, headers = api_instance.packages_get_package_version_for_authenticated_user_with_http_info(package_type, package_name, package_version_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <PackageVersion>
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_get_package_version_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **package_name** | **String** | The name of the package. |  |
| **package_version_id** | **Integer** | Unique identifier of the package version. |  |

### Return type

[**PackageVersion**](PackageVersion.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_get_package_version_for_organization

> <PackageVersion> packages_get_package_version_for_organization(package_type, package_name, org, package_version_id)

Get a package version for an organization

Gets a specific package version in an organization.  You must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
package_name = 'package_name_example' # String | The name of the package.
org = 'org_example' # String | The organization name. The name is not case sensitive.
package_version_id = 56 # Integer | Unique identifier of the package version.

begin
  # Get a package version for an organization
  result = api_instance.packages_get_package_version_for_organization(package_type, package_name, org, package_version_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_get_package_version_for_organization: #{e}"
end
```

#### Using the packages_get_package_version_for_organization_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<PackageVersion>, Integer, Hash)> packages_get_package_version_for_organization_with_http_info(package_type, package_name, org, package_version_id)

```ruby
begin
  # Get a package version for an organization
  data, status_code, headers = api_instance.packages_get_package_version_for_organization_with_http_info(package_type, package_name, org, package_version_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <PackageVersion>
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_get_package_version_for_organization_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **package_name** | **String** | The name of the package. |  |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **package_version_id** | **Integer** | Unique identifier of the package version. |  |

### Return type

[**PackageVersion**](PackageVersion.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_get_package_version_for_user

> <PackageVersion> packages_get_package_version_for_user(package_type, package_name, package_version_id, username)

Get a package version for a user

Gets a specific package version for a public package owned by a specified user.  At this time, to use this endpoint, you must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
package_name = 'package_name_example' # String | The name of the package.
package_version_id = 56 # Integer | Unique identifier of the package version.
username = 'username_example' # String | The handle for the GitHub user account.

begin
  # Get a package version for a user
  result = api_instance.packages_get_package_version_for_user(package_type, package_name, package_version_id, username)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_get_package_version_for_user: #{e}"
end
```

#### Using the packages_get_package_version_for_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<PackageVersion>, Integer, Hash)> packages_get_package_version_for_user_with_http_info(package_type, package_name, package_version_id, username)

```ruby
begin
  # Get a package version for a user
  data, status_code, headers = api_instance.packages_get_package_version_for_user_with_http_info(package_type, package_name, package_version_id, username)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <PackageVersion>
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_get_package_version_for_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **package_name** | **String** | The name of the package. |  |
| **package_version_id** | **Integer** | Unique identifier of the package version. |  |
| **username** | **String** | The handle for the GitHub user account. |  |

### Return type

[**PackageVersion**](PackageVersion.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_list_packages_for_authenticated_user

> <Array<Package>> packages_list_packages_for_authenticated_user(package_type, opts)

List packages for the authenticated user's namespace

Lists packages owned by the authenticated user within the user's namespace.  To use this endpoint, you must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
opts = {
  visibility: 'public' # String | The selected visibility of the packages. Only `container` package_types currently support `internal` visibility properly. For other ecosystems `internal` is synonymous with `private`. This parameter is optional and only filters an existing result set.
}

begin
  # List packages for the authenticated user's namespace
  result = api_instance.packages_list_packages_for_authenticated_user(package_type, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_list_packages_for_authenticated_user: #{e}"
end
```

#### Using the packages_list_packages_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<Package>>, Integer, Hash)> packages_list_packages_for_authenticated_user_with_http_info(package_type, opts)

```ruby
begin
  # List packages for the authenticated user's namespace
  data, status_code, headers = api_instance.packages_list_packages_for_authenticated_user_with_http_info(package_type, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<Package>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_list_packages_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **visibility** | **String** | The selected visibility of the packages. Only &#x60;container&#x60; package_types currently support &#x60;internal&#x60; visibility properly. For other ecosystems &#x60;internal&#x60; is synonymous with &#x60;private&#x60;. This parameter is optional and only filters an existing result set. | [optional] |

### Return type

[**Array&lt;Package&gt;**](Package.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_list_packages_for_organization

> <Array<Package>> packages_list_packages_for_organization(package_type, org, opts)

List packages for an organization

Lists all packages in an organization readable by the user.  To use this endpoint, you must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  visibility: 'public' # String | The selected visibility of the packages. Only `container` package_types currently support `internal` visibility properly. For other ecosystems `internal` is synonymous with `private`. This parameter is optional and only filters an existing result set.
}

begin
  # List packages for an organization
  result = api_instance.packages_list_packages_for_organization(package_type, org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_list_packages_for_organization: #{e}"
end
```

#### Using the packages_list_packages_for_organization_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<Package>>, Integer, Hash)> packages_list_packages_for_organization_with_http_info(package_type, org, opts)

```ruby
begin
  # List packages for an organization
  data, status_code, headers = api_instance.packages_list_packages_for_organization_with_http_info(package_type, org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<Package>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_list_packages_for_organization_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **visibility** | **String** | The selected visibility of the packages. Only &#x60;container&#x60; package_types currently support &#x60;internal&#x60; visibility properly. For other ecosystems &#x60;internal&#x60; is synonymous with &#x60;private&#x60;. This parameter is optional and only filters an existing result set. | [optional] |

### Return type

[**Array&lt;Package&gt;**](Package.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_list_packages_for_user

> <Array<Package>> packages_list_packages_for_user(package_type, username, opts)

List packages for a user

Lists all packages in a user's namespace for which the requesting user has access.  To use this endpoint, you must authenticate using an access token with the `packages:read` scope. If `package_type` is not `container`, your token must also include the `repo` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
username = 'username_example' # String | The handle for the GitHub user account.
opts = {
  visibility: 'public' # String | The selected visibility of the packages. Only `container` package_types currently support `internal` visibility properly. For other ecosystems `internal` is synonymous with `private`. This parameter is optional and only filters an existing result set.
}

begin
  # List packages for a user
  result = api_instance.packages_list_packages_for_user(package_type, username, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_list_packages_for_user: #{e}"
end
```

#### Using the packages_list_packages_for_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<Package>>, Integer, Hash)> packages_list_packages_for_user_with_http_info(package_type, username, opts)

```ruby
begin
  # List packages for a user
  data, status_code, headers = api_instance.packages_list_packages_for_user_with_http_info(package_type, username, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<Package>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_list_packages_for_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **username** | **String** | The handle for the GitHub user account. |  |
| **visibility** | **String** | The selected visibility of the packages. Only &#x60;container&#x60; package_types currently support &#x60;internal&#x60; visibility properly. For other ecosystems &#x60;internal&#x60; is synonymous with &#x60;private&#x60;. This parameter is optional and only filters an existing result set. | [optional] |

### Return type

[**Array&lt;Package&gt;**](Package.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_restore_package_for_authenticated_user

> packages_restore_package_for_authenticated_user(package_type, package_name, opts)

Restore a package for the authenticated user

Restores a package owned by the authenticated user.  You can restore a deleted package under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package's namespace first.  To use this endpoint, you must authenticate using an access token with the `packages:read` and `packages:write` scopes. If `package_type` is not `container`, your token must also include the `repo` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
package_name = 'package_name_example' # String | The name of the package.
opts = {
  token: 'token_example' # String | package token
}

begin
  # Restore a package for the authenticated user
  api_instance.packages_restore_package_for_authenticated_user(package_type, package_name, opts)
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_restore_package_for_authenticated_user: #{e}"
end
```

#### Using the packages_restore_package_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> packages_restore_package_for_authenticated_user_with_http_info(package_type, package_name, opts)

```ruby
begin
  # Restore a package for the authenticated user
  data, status_code, headers = api_instance.packages_restore_package_for_authenticated_user_with_http_info(package_type, package_name, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_restore_package_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **package_name** | **String** | The name of the package. |  |
| **token** | **String** | package token | [optional] |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_restore_package_for_org

> packages_restore_package_for_org(package_type, package_name, org, opts)

Restore a package for an organization

Restores an entire package in an organization.  You can restore a deleted package under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package's namespace first.  To use this endpoint, you must have admin permissions in the organization and authenticate using an access token with the `packages:read` and `packages:write` scopes. In addition: - If `package_type` is not `container`, your token must also include the `repo` scope. - If `package_type` is `container`, you must also have admin permissions to the container that you want to restore.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
package_name = 'package_name_example' # String | The name of the package.
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  token: 'token_example' # String | package token
}

begin
  # Restore a package for an organization
  api_instance.packages_restore_package_for_org(package_type, package_name, org, opts)
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_restore_package_for_org: #{e}"
end
```

#### Using the packages_restore_package_for_org_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> packages_restore_package_for_org_with_http_info(package_type, package_name, org, opts)

```ruby
begin
  # Restore a package for an organization
  data, status_code, headers = api_instance.packages_restore_package_for_org_with_http_info(package_type, package_name, org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_restore_package_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **package_name** | **String** | The name of the package. |  |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **token** | **String** | package token | [optional] |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_restore_package_for_user

> packages_restore_package_for_user(package_type, package_name, username, opts)

Restore a package for a user

Restores an entire package for a user.  You can restore a deleted package under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package's namespace first.  To use this endpoint, you must authenticate using an access token with the `packages:read` and `packages:write` scopes. In addition: - If `package_type` is not `container`, your token must also include the `repo` scope. - If `package_type` is `container`, you must also have admin permissions to the container that you want to restore.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
package_name = 'package_name_example' # String | The name of the package.
username = 'username_example' # String | The handle for the GitHub user account.
opts = {
  token: 'token_example' # String | package token
}

begin
  # Restore a package for a user
  api_instance.packages_restore_package_for_user(package_type, package_name, username, opts)
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_restore_package_for_user: #{e}"
end
```

#### Using the packages_restore_package_for_user_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> packages_restore_package_for_user_with_http_info(package_type, package_name, username, opts)

```ruby
begin
  # Restore a package for a user
  data, status_code, headers = api_instance.packages_restore_package_for_user_with_http_info(package_type, package_name, username, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_restore_package_for_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **package_name** | **String** | The name of the package. |  |
| **username** | **String** | The handle for the GitHub user account. |  |
| **token** | **String** | package token | [optional] |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_restore_package_version_for_authenticated_user

> packages_restore_package_version_for_authenticated_user(package_type, package_name, package_version_id)

Restore a package version for the authenticated user

Restores a package version owned by the authenticated user.  You can restore a deleted package version under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package's namespace first.  To use this endpoint, you must authenticate using an access token with the `packages:read` and `packages:write` scopes. If `package_type` is not `container`, your token must also include the `repo` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
package_name = 'package_name_example' # String | The name of the package.
package_version_id = 56 # Integer | Unique identifier of the package version.

begin
  # Restore a package version for the authenticated user
  api_instance.packages_restore_package_version_for_authenticated_user(package_type, package_name, package_version_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_restore_package_version_for_authenticated_user: #{e}"
end
```

#### Using the packages_restore_package_version_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> packages_restore_package_version_for_authenticated_user_with_http_info(package_type, package_name, package_version_id)

```ruby
begin
  # Restore a package version for the authenticated user
  data, status_code, headers = api_instance.packages_restore_package_version_for_authenticated_user_with_http_info(package_type, package_name, package_version_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_restore_package_version_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **package_name** | **String** | The name of the package. |  |
| **package_version_id** | **Integer** | Unique identifier of the package version. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_restore_package_version_for_org

> packages_restore_package_version_for_org(package_type, package_name, org, package_version_id)

Restore package version for an organization

Restores a specific package version in an organization.  You can restore a deleted package under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package's namespace first.  To use this endpoint, you must have admin permissions in the organization and authenticate using an access token with the `packages:read` and `packages:write` scopes. In addition: - If `package_type` is not `container`, your token must also include the `repo` scope. - If `package_type` is `container`, you must also have admin permissions to the container that you want to restore.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
package_name = 'package_name_example' # String | The name of the package.
org = 'org_example' # String | The organization name. The name is not case sensitive.
package_version_id = 56 # Integer | Unique identifier of the package version.

begin
  # Restore package version for an organization
  api_instance.packages_restore_package_version_for_org(package_type, package_name, org, package_version_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_restore_package_version_for_org: #{e}"
end
```

#### Using the packages_restore_package_version_for_org_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> packages_restore_package_version_for_org_with_http_info(package_type, package_name, org, package_version_id)

```ruby
begin
  # Restore package version for an organization
  data, status_code, headers = api_instance.packages_restore_package_version_for_org_with_http_info(package_type, package_name, org, package_version_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_restore_package_version_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **package_name** | **String** | The name of the package. |  |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **package_version_id** | **Integer** | Unique identifier of the package version. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## packages_restore_package_version_for_user

> packages_restore_package_version_for_user(package_type, package_name, username, package_version_id)

Restore package version for a user

Restores a specific package version for a user.  You can restore a deleted package under the following conditions:   - The package was deleted within the last 30 days.   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package's namespace first.  To use this endpoint, you must authenticate using an access token with the `packages:read` and `packages:write` scopes. In addition: - If `package_type` is not `container`, your token must also include the `repo` scope. - If `package_type` is `container`, you must also have admin permissions to the container that you want to restore.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::PackagesApi.new
package_type = 'npm' # String | The type of supported package. Packages in GitHub's Gradle registry have the type `maven`. Docker images pushed to GitHub's Container registry (`ghcr.io`) have the type `container`. You can use the type `docker` to find images that were pushed to GitHub's Docker registry (`docker.pkg.github.com`), even if these have now been migrated to the Container registry.
package_name = 'package_name_example' # String | The name of the package.
username = 'username_example' # String | The handle for the GitHub user account.
package_version_id = 56 # Integer | Unique identifier of the package version.

begin
  # Restore package version for a user
  api_instance.packages_restore_package_version_for_user(package_type, package_name, username, package_version_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_restore_package_version_for_user: #{e}"
end
```

#### Using the packages_restore_package_version_for_user_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> packages_restore_package_version_for_user_with_http_info(package_type, package_name, username, package_version_id)

```ruby
begin
  # Restore package version for a user
  data, status_code, headers = api_instance.packages_restore_package_version_for_user_with_http_info(package_type, package_name, username, package_version_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling PackagesApi->packages_restore_package_version_for_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **package_type** | **String** | The type of supported package. Packages in GitHub&#39;s Gradle registry have the type &#x60;maven&#x60;. Docker images pushed to GitHub&#39;s Container registry (&#x60;ghcr.io&#x60;) have the type &#x60;container&#x60;. You can use the type &#x60;docker&#x60; to find images that were pushed to GitHub&#39;s Docker registry (&#x60;docker.pkg.github.com&#x60;), even if these have now been migrated to the Container registry. |  |
| **package_name** | **String** | The name of the package. |  |
| **username** | **String** | The handle for the GitHub user account. |  |
| **package_version_id** | **Integer** | Unique identifier of the package version. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

