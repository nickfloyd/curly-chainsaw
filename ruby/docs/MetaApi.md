# OpenapiClient::MetaApi

All URIs are relative to *https://api.github.com*

| Method | HTTP request | Description |
| ------ | ------------ | ----------- |
| [**meta_get**](MetaApi.md#meta_get) | **GET** /meta | Get GitHub meta information |
| [**meta_get_octocat**](MetaApi.md#meta_get_octocat) | **GET** /octocat | Get Octocat |
| [**meta_get_zen**](MetaApi.md#meta_get_zen) | **GET** /zen | Get the Zen of GitHub |
| [**meta_root**](MetaApi.md#meta_root) | **GET** / | GitHub API Root |


## meta_get

> <ApiOverview> meta_get

Get GitHub meta information

Returns meta information about GitHub, including a list of GitHub's IP addresses. For more information, see \"[About GitHub's IP addresses](https://docs.github.com/articles/about-github-s-ip-addresses/).\"  **Note:** The IP addresses shown in the documentation's response are only example values. You must always query the API directly to get the latest list of IP addresses.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::MetaApi.new

begin
  # Get GitHub meta information
  result = api_instance.meta_get
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling MetaApi->meta_get: #{e}"
end
```

#### Using the meta_get_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ApiOverview>, Integer, Hash)> meta_get_with_http_info

```ruby
begin
  # Get GitHub meta information
  data, status_code, headers = api_instance.meta_get_with_http_info
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ApiOverview>
rescue OpenapiClient::ApiError => e
  puts "Error when calling MetaApi->meta_get_with_http_info: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ApiOverview**](ApiOverview.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## meta_get_octocat

> String meta_get_octocat(opts)

Get Octocat

Get the octocat as ASCII art

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::MetaApi.new
opts = {
  s: 's_example' # String | The words to show in Octocat's speech bubble
}

begin
  # Get Octocat
  result = api_instance.meta_get_octocat(opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling MetaApi->meta_get_octocat: #{e}"
end
```

#### Using the meta_get_octocat_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(String, Integer, Hash)> meta_get_octocat_with_http_info(opts)

```ruby
begin
  # Get Octocat
  data, status_code, headers = api_instance.meta_get_octocat_with_http_info(opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => String
rescue OpenapiClient::ApiError => e
  puts "Error when calling MetaApi->meta_get_octocat_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **s** | **String** | The words to show in Octocat&#39;s speech bubble | [optional] |

### Return type

**String**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/octocat-stream


## meta_get_zen

> String meta_get_zen

Get the Zen of GitHub

Get a random sentence from the Zen of GitHub

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::MetaApi.new

begin
  # Get the Zen of GitHub
  result = api_instance.meta_get_zen
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling MetaApi->meta_get_zen: #{e}"
end
```

#### Using the meta_get_zen_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(String, Integer, Hash)> meta_get_zen_with_http_info

```ruby
begin
  # Get the Zen of GitHub
  data, status_code, headers = api_instance.meta_get_zen_with_http_info
  p status_code # => 2xx
  p headers # => { ... }
  p data # => String
rescue OpenapiClient::ApiError => e
  puts "Error when calling MetaApi->meta_get_zen_with_http_info: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

**String**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain


## meta_root

> <MetaRoot200Response> meta_root

GitHub API Root

Get Hypermedia links to resources accessible in GitHub's REST API

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::MetaApi.new

begin
  # GitHub API Root
  result = api_instance.meta_root
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling MetaApi->meta_root: #{e}"
end
```

#### Using the meta_root_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<MetaRoot200Response>, Integer, Hash)> meta_root_with_http_info

```ruby
begin
  # GitHub API Root
  data, status_code, headers = api_instance.meta_root_with_http_info
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <MetaRoot200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling MetaApi->meta_root_with_http_info: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**MetaRoot200Response**](MetaRoot200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

