# OpenapiClient::LicensesApi

All URIs are relative to *https://api.github.com*

| Method | HTTP request | Description |
| ------ | ------------ | ----------- |
| [**licenses_get**](LicensesApi.md#licenses_get) | **GET** /licenses/{license} | Get a license |
| [**licenses_get_all_commonly_used**](LicensesApi.md#licenses_get_all_commonly_used) | **GET** /licenses | Get all commonly used licenses |
| [**licenses_get_for_repo**](LicensesApi.md#licenses_get_for_repo) | **GET** /repos/{owner}/{repo}/license | Get the license for a repository |


## licenses_get

> <License> licenses_get(license)

Get a license



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::LicensesApi.new
license = 'license_example' # String | 

begin
  # Get a license
  result = api_instance.licenses_get(license)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling LicensesApi->licenses_get: #{e}"
end
```

#### Using the licenses_get_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<License>, Integer, Hash)> licenses_get_with_http_info(license)

```ruby
begin
  # Get a license
  data, status_code, headers = api_instance.licenses_get_with_http_info(license)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <License>
rescue OpenapiClient::ApiError => e
  puts "Error when calling LicensesApi->licenses_get_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **license** | **String** |  |  |

### Return type

[**License**](License.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## licenses_get_all_commonly_used

> <Array<LicenseSimple1>> licenses_get_all_commonly_used(opts)

Get all commonly used licenses



### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::LicensesApi.new
opts = {
  featured: true, # Boolean | 
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # Get all commonly used licenses
  result = api_instance.licenses_get_all_commonly_used(opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling LicensesApi->licenses_get_all_commonly_used: #{e}"
end
```

#### Using the licenses_get_all_commonly_used_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<LicenseSimple1>>, Integer, Hash)> licenses_get_all_commonly_used_with_http_info(opts)

```ruby
begin
  # Get all commonly used licenses
  data, status_code, headers = api_instance.licenses_get_all_commonly_used_with_http_info(opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<LicenseSimple1>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling LicensesApi->licenses_get_all_commonly_used_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **featured** | **Boolean** |  | [optional] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;LicenseSimple1&gt;**](LicenseSimple1.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## licenses_get_for_repo

> <LicenseContent> licenses_get_for_repo(owner, repo)

Get the license for a repository

This method returns the contents of the repository's license file, if one is detected.  Similar to [Get repository content](https://docs.github.com/rest/reference/repos#get-repository-content), this method also supports [custom media types](https://docs.github.com/rest/overview/media-types) for retrieving the raw license content or rendered license HTML.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::LicensesApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get the license for a repository
  result = api_instance.licenses_get_for_repo(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling LicensesApi->licenses_get_for_repo: #{e}"
end
```

#### Using the licenses_get_for_repo_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<LicenseContent>, Integer, Hash)> licenses_get_for_repo_with_http_info(owner, repo)

```ruby
begin
  # Get the license for a repository
  data, status_code, headers = api_instance.licenses_get_for_repo_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <LicenseContent>
rescue OpenapiClient::ApiError => e
  puts "Error when calling LicensesApi->licenses_get_for_repo_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**LicenseContent**](LicenseContent.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

