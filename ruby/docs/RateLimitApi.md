# OpenapiClient::RateLimitApi

All URIs are relative to *https://api.github.com*

| Method | HTTP request | Description |
| ------ | ------------ | ----------- |
| [**rate_limit_get**](RateLimitApi.md#rate_limit_get) | **GET** /rate_limit | Get rate limit status for the authenticated user |


## rate_limit_get

> <RateLimitOverview> rate_limit_get

Get rate limit status for the authenticated user

**Note:** Accessing this endpoint does not count against your REST API rate limit.  **Note:** The `rate` object is deprecated. If you're writing new API client code or updating existing code, you should use the `core` object instead of the `rate` object. The `core` object contains the same information that is present in the `rate` object.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::RateLimitApi.new

begin
  # Get rate limit status for the authenticated user
  result = api_instance.rate_limit_get
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling RateLimitApi->rate_limit_get: #{e}"
end
```

#### Using the rate_limit_get_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<RateLimitOverview>, Integer, Hash)> rate_limit_get_with_http_info

```ruby
begin
  # Get rate limit status for the authenticated user
  data, status_code, headers = api_instance.rate_limit_get_with_http_info
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <RateLimitOverview>
rescue OpenapiClient::ApiError => e
  puts "Error when calling RateLimitApi->rate_limit_get_with_http_info: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**RateLimitOverview**](RateLimitOverview.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

