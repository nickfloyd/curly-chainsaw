# OpenapiClient::ChecksApi

All URIs are relative to *https://api.github.com*

| Method | HTTP request | Description |
| ------ | ------------ | ----------- |
| [**checks_create**](ChecksApi.md#checks_create) | **POST** /repos/{owner}/{repo}/check-runs | Create a check run |
| [**checks_create_suite**](ChecksApi.md#checks_create_suite) | **POST** /repos/{owner}/{repo}/check-suites | Create a check suite |
| [**checks_get**](ChecksApi.md#checks_get) | **GET** /repos/{owner}/{repo}/check-runs/{check_run_id} | Get a check run |
| [**checks_get_suite**](ChecksApi.md#checks_get_suite) | **GET** /repos/{owner}/{repo}/check-suites/{check_suite_id} | Get a check suite |
| [**checks_list_annotations**](ChecksApi.md#checks_list_annotations) | **GET** /repos/{owner}/{repo}/check-runs/{check_run_id}/annotations | List check run annotations |
| [**checks_list_for_ref**](ChecksApi.md#checks_list_for_ref) | **GET** /repos/{owner}/{repo}/commits/{ref}/check-runs | List check runs for a Git reference |
| [**checks_list_for_suite**](ChecksApi.md#checks_list_for_suite) | **GET** /repos/{owner}/{repo}/check-suites/{check_suite_id}/check-runs | List check runs in a check suite |
| [**checks_list_suites_for_ref**](ChecksApi.md#checks_list_suites_for_ref) | **GET** /repos/{owner}/{repo}/commits/{ref}/check-suites | List check suites for a Git reference |
| [**checks_rerequest_run**](ChecksApi.md#checks_rerequest_run) | **POST** /repos/{owner}/{repo}/check-runs/{check_run_id}/rerequest | Rerequest a check run |
| [**checks_rerequest_suite**](ChecksApi.md#checks_rerequest_suite) | **POST** /repos/{owner}/{repo}/check-suites/{check_suite_id}/rerequest | Rerequest a check suite |
| [**checks_set_suites_preferences**](ChecksApi.md#checks_set_suites_preferences) | **PATCH** /repos/{owner}/{repo}/check-suites/preferences | Update repository preferences for check suites |
| [**checks_update**](ChecksApi.md#checks_update) | **PATCH** /repos/{owner}/{repo}/check-runs/{check_run_id} | Update a check run |


## checks_create

> <CheckRun> checks_create(owner, repo, checks_create_request)

Create a check run

**Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.  Creates a new check run for a specific commit in a repository. Your GitHub App must have the `checks:write` permission to create check runs.  In a check suite, GitHub limits the number of check runs with the same name to 1000. Once these check runs exceed 1000, GitHub will start to automatically delete older check runs.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ChecksApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
checks_create_request = OpenapiClient::ChecksCreateRequestOneOf.new({status: 'completed'}) # ChecksCreateRequest | 

begin
  # Create a check run
  result = api_instance.checks_create(owner, repo, checks_create_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_create: #{e}"
end
```

#### Using the checks_create_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CheckRun>, Integer, Hash)> checks_create_with_http_info(owner, repo, checks_create_request)

```ruby
begin
  # Create a check run
  data, status_code, headers = api_instance.checks_create_with_http_info(owner, repo, checks_create_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CheckRun>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_create_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **checks_create_request** | [**ChecksCreateRequest**](ChecksCreateRequest.md) |  |  |

### Return type

[**CheckRun**](CheckRun.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## checks_create_suite

> <CheckSuite> checks_create_suite(owner, repo, checks_create_suite_request)

Create a check suite

**Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array and a `null` value for `head_branch`.  By default, check suites are automatically created when you create a [check run](https://docs.github.com/rest/reference/checks#check-runs). You only need to use this endpoint for manually creating check suites when you've disabled automatic creation using \"[Update repository preferences for check suites](https://docs.github.com/rest/reference/checks#update-repository-preferences-for-check-suites)\". Your GitHub App must have the `checks:write` permission to create check suites.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ChecksApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
checks_create_suite_request = OpenapiClient::ChecksCreateSuiteRequest.new({head_sha: 'head_sha_example'}) # ChecksCreateSuiteRequest | 

begin
  # Create a check suite
  result = api_instance.checks_create_suite(owner, repo, checks_create_suite_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_create_suite: #{e}"
end
```

#### Using the checks_create_suite_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CheckSuite>, Integer, Hash)> checks_create_suite_with_http_info(owner, repo, checks_create_suite_request)

```ruby
begin
  # Create a check suite
  data, status_code, headers = api_instance.checks_create_suite_with_http_info(owner, repo, checks_create_suite_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CheckSuite>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_create_suite_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **checks_create_suite_request** | [**ChecksCreateSuiteRequest**](ChecksCreateSuiteRequest.md) |  |  |

### Return type

[**CheckSuite**](CheckSuite.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## checks_get

> <CheckRun> checks_get(owner, repo, check_run_id)

Get a check run

**Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.  Gets a single check run using its `id`. GitHub Apps must have the `checks:read` permission on a private repository or pull access to a public repository to get check runs. OAuth Apps and authenticated users must have the `repo` scope to get check runs in a private repository.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ChecksApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
check_run_id = 56 # Integer | The unique identifier of the check run.

begin
  # Get a check run
  result = api_instance.checks_get(owner, repo, check_run_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_get: #{e}"
end
```

#### Using the checks_get_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CheckRun>, Integer, Hash)> checks_get_with_http_info(owner, repo, check_run_id)

```ruby
begin
  # Get a check run
  data, status_code, headers = api_instance.checks_get_with_http_info(owner, repo, check_run_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CheckRun>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_get_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **check_run_id** | **Integer** | The unique identifier of the check run. |  |

### Return type

[**CheckRun**](CheckRun.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## checks_get_suite

> <CheckSuite> checks_get_suite(owner, repo, check_suite_id)

Get a check suite

**Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array and a `null` value for `head_branch`.  Gets a single check suite using its `id`. GitHub Apps must have the `checks:read` permission on a private repository or pull access to a public repository to get check suites. OAuth Apps and authenticated users must have the `repo` scope to get check suites in a private repository.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ChecksApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
check_suite_id = 56 # Integer | The unique identifier of the check suite.

begin
  # Get a check suite
  result = api_instance.checks_get_suite(owner, repo, check_suite_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_get_suite: #{e}"
end
```

#### Using the checks_get_suite_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CheckSuite>, Integer, Hash)> checks_get_suite_with_http_info(owner, repo, check_suite_id)

```ruby
begin
  # Get a check suite
  data, status_code, headers = api_instance.checks_get_suite_with_http_info(owner, repo, check_suite_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CheckSuite>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_get_suite_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **check_suite_id** | **Integer** | The unique identifier of the check suite. |  |

### Return type

[**CheckSuite**](CheckSuite.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## checks_list_annotations

> <Array<CheckAnnotation>> checks_list_annotations(owner, repo, check_run_id, opts)

List check run annotations

Lists annotations for a check run using the annotation `id`. GitHub Apps must have the `checks:read` permission on a private repository or pull access to a public repository to get annotations for a check run. OAuth Apps and authenticated users must have the `repo` scope to get annotations for a check run in a private repository.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ChecksApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
check_run_id = 56 # Integer | The unique identifier of the check run.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List check run annotations
  result = api_instance.checks_list_annotations(owner, repo, check_run_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_list_annotations: #{e}"
end
```

#### Using the checks_list_annotations_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<CheckAnnotation>>, Integer, Hash)> checks_list_annotations_with_http_info(owner, repo, check_run_id, opts)

```ruby
begin
  # List check run annotations
  data, status_code, headers = api_instance.checks_list_annotations_with_http_info(owner, repo, check_run_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<CheckAnnotation>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_list_annotations_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **check_run_id** | **Integer** | The unique identifier of the check run. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**Array&lt;CheckAnnotation&gt;**](CheckAnnotation.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## checks_list_for_ref

> <ChecksListForSuite200Response> checks_list_for_ref(owner, repo, ref, opts)

List check runs for a Git reference

**Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.  Lists check runs for a commit ref. The `ref` can be a SHA, branch name, or a tag name. GitHub Apps must have the `checks:read` permission on a private repository or pull access to a public repository to get check runs. OAuth Apps and authenticated users must have the `repo` scope to get check runs in a private repository.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ChecksApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
ref = 'ref_example' # String | ref parameter
opts = {
  check_name: 'check_name_example', # String | Returns check runs with the specified `name`.
  status: 'queued', # String | Returns check runs with the specified `status`.
  filter: 'latest', # String | Filters check runs by their `completed_at` timestamp. `latest` returns the most recent check runs.
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56, # Integer | Page number of the results to fetch.
  app_id: 56 # Integer | 
}

begin
  # List check runs for a Git reference
  result = api_instance.checks_list_for_ref(owner, repo, ref, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_list_for_ref: #{e}"
end
```

#### Using the checks_list_for_ref_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ChecksListForSuite200Response>, Integer, Hash)> checks_list_for_ref_with_http_info(owner, repo, ref, opts)

```ruby
begin
  # List check runs for a Git reference
  data, status_code, headers = api_instance.checks_list_for_ref_with_http_info(owner, repo, ref, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ChecksListForSuite200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_list_for_ref_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **ref** | **String** | ref parameter |  |
| **check_name** | **String** | Returns check runs with the specified &#x60;name&#x60;. | [optional] |
| **status** | **String** | Returns check runs with the specified &#x60;status&#x60;. | [optional] |
| **filter** | **String** | Filters check runs by their &#x60;completed_at&#x60; timestamp. &#x60;latest&#x60; returns the most recent check runs. | [optional][default to &#39;latest&#39;] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |
| **app_id** | **Integer** |  | [optional] |

### Return type

[**ChecksListForSuite200Response**](ChecksListForSuite200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## checks_list_for_suite

> <ChecksListForSuite200Response> checks_list_for_suite(owner, repo, check_suite_id, opts)

List check runs in a check suite

**Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.  Lists check runs for a check suite using its `id`. GitHub Apps must have the `checks:read` permission on a private repository or pull access to a public repository to get check runs. OAuth Apps and authenticated users must have the `repo` scope to get check runs in a private repository.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ChecksApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
check_suite_id = 56 # Integer | The unique identifier of the check suite.
opts = {
  check_name: 'check_name_example', # String | Returns check runs with the specified `name`.
  status: 'queued', # String | Returns check runs with the specified `status`.
  filter: 'latest', # String | Filters check runs by their `completed_at` timestamp. `latest` returns the most recent check runs.
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List check runs in a check suite
  result = api_instance.checks_list_for_suite(owner, repo, check_suite_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_list_for_suite: #{e}"
end
```

#### Using the checks_list_for_suite_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ChecksListForSuite200Response>, Integer, Hash)> checks_list_for_suite_with_http_info(owner, repo, check_suite_id, opts)

```ruby
begin
  # List check runs in a check suite
  data, status_code, headers = api_instance.checks_list_for_suite_with_http_info(owner, repo, check_suite_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ChecksListForSuite200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_list_for_suite_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **check_suite_id** | **Integer** | The unique identifier of the check suite. |  |
| **check_name** | **String** | Returns check runs with the specified &#x60;name&#x60;. | [optional] |
| **status** | **String** | Returns check runs with the specified &#x60;status&#x60;. | [optional] |
| **filter** | **String** | Filters check runs by their &#x60;completed_at&#x60; timestamp. &#x60;latest&#x60; returns the most recent check runs. | [optional][default to &#39;latest&#39;] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**ChecksListForSuite200Response**](ChecksListForSuite200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## checks_list_suites_for_ref

> <ChecksListSuitesForRef200Response> checks_list_suites_for_ref(owner, repo, ref, opts)

List check suites for a Git reference

**Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array and a `null` value for `head_branch`.  Lists check suites for a commit `ref`. The `ref` can be a SHA, branch name, or a tag name. GitHub Apps must have the `checks:read` permission on a private repository or pull access to a public repository to list check suites. OAuth Apps and authenticated users must have the `repo` scope to get check suites in a private repository.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ChecksApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
ref = 'ref_example' # String | ref parameter
opts = {
  app_id: 1, # Integer | Filters check suites by GitHub App `id`.
  check_name: 'check_name_example', # String | Returns check runs with the specified `name`.
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List check suites for a Git reference
  result = api_instance.checks_list_suites_for_ref(owner, repo, ref, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_list_suites_for_ref: #{e}"
end
```

#### Using the checks_list_suites_for_ref_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ChecksListSuitesForRef200Response>, Integer, Hash)> checks_list_suites_for_ref_with_http_info(owner, repo, ref, opts)

```ruby
begin
  # List check suites for a Git reference
  data, status_code, headers = api_instance.checks_list_suites_for_ref_with_http_info(owner, repo, ref, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ChecksListSuitesForRef200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_list_suites_for_ref_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **ref** | **String** | ref parameter |  |
| **app_id** | **Integer** | Filters check suites by GitHub App &#x60;id&#x60;. | [optional] |
| **check_name** | **String** | Returns check runs with the specified &#x60;name&#x60;. | [optional] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**ChecksListSuitesForRef200Response**](ChecksListSuitesForRef200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## checks_rerequest_run

> Object checks_rerequest_run(owner, repo, check_run_id)

Rerequest a check run

Triggers GitHub to rerequest an existing check run, without pushing new code to a repository. This endpoint will trigger the [`check_run` webhook](https://docs.github.com/webhooks/event-payloads/#check_run) event with the action `rerequested`. When a check run is `rerequested`, its `status` is reset to `queued` and the `conclusion` is cleared.  To rerequest a check run, your GitHub App must have the `checks:read` permission on a private repository or pull access to a public repository.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ChecksApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
check_run_id = 56 # Integer | The unique identifier of the check run.

begin
  # Rerequest a check run
  result = api_instance.checks_rerequest_run(owner, repo, check_run_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_rerequest_run: #{e}"
end
```

#### Using the checks_rerequest_run_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Object, Integer, Hash)> checks_rerequest_run_with_http_info(owner, repo, check_run_id)

```ruby
begin
  # Rerequest a check run
  data, status_code, headers = api_instance.checks_rerequest_run_with_http_info(owner, repo, check_run_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Object
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_rerequest_run_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **check_run_id** | **Integer** | The unique identifier of the check run. |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## checks_rerequest_suite

> Object checks_rerequest_suite(owner, repo, check_suite_id)

Rerequest a check suite

Triggers GitHub to rerequest an existing check suite, without pushing new code to a repository. This endpoint will trigger the [`check_suite` webhook](https://docs.github.com/webhooks/event-payloads/#check_suite) event with the action `rerequested`. When a check suite is `rerequested`, its `status` is reset to `queued` and the `conclusion` is cleared.  To rerequest a check suite, your GitHub App must have the `checks:read` permission on a private repository or pull access to a public repository.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ChecksApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
check_suite_id = 56 # Integer | The unique identifier of the check suite.

begin
  # Rerequest a check suite
  result = api_instance.checks_rerequest_suite(owner, repo, check_suite_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_rerequest_suite: #{e}"
end
```

#### Using the checks_rerequest_suite_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Object, Integer, Hash)> checks_rerequest_suite_with_http_info(owner, repo, check_suite_id)

```ruby
begin
  # Rerequest a check suite
  data, status_code, headers = api_instance.checks_rerequest_suite_with_http_info(owner, repo, check_suite_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Object
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_rerequest_suite_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **check_suite_id** | **Integer** | The unique identifier of the check suite. |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## checks_set_suites_preferences

> <CheckSuitePreference> checks_set_suites_preferences(owner, repo, checks_set_suites_preferences_request)

Update repository preferences for check suites

Changes the default automatic flow when creating check suites. By default, a check suite is automatically created each time code is pushed to a repository. When you disable the automatic creation of check suites, you can manually [Create a check suite](https://docs.github.com/rest/reference/checks#create-a-check-suite). You must have admin permissions in the repository to set preferences for check suites.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ChecksApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
checks_set_suites_preferences_request = OpenapiClient::ChecksSetSuitesPreferencesRequest.new # ChecksSetSuitesPreferencesRequest | 

begin
  # Update repository preferences for check suites
  result = api_instance.checks_set_suites_preferences(owner, repo, checks_set_suites_preferences_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_set_suites_preferences: #{e}"
end
```

#### Using the checks_set_suites_preferences_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CheckSuitePreference>, Integer, Hash)> checks_set_suites_preferences_with_http_info(owner, repo, checks_set_suites_preferences_request)

```ruby
begin
  # Update repository preferences for check suites
  data, status_code, headers = api_instance.checks_set_suites_preferences_with_http_info(owner, repo, checks_set_suites_preferences_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CheckSuitePreference>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_set_suites_preferences_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **checks_set_suites_preferences_request** | [**ChecksSetSuitesPreferencesRequest**](ChecksSetSuitesPreferencesRequest.md) |  |  |

### Return type

[**CheckSuitePreference**](CheckSuitePreference.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## checks_update

> <CheckRun> checks_update(owner, repo, check_run_id, checks_update_request)

Update a check run

**Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.  Updates a check run for a specific commit in a repository. Your GitHub App must have the `checks:write` permission to edit check runs.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ChecksApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
check_run_id = 56 # Integer | The unique identifier of the check run.
checks_update_request = OpenapiClient::ChecksUpdateRequest.new # ChecksUpdateRequest | 

begin
  # Update a check run
  result = api_instance.checks_update(owner, repo, check_run_id, checks_update_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_update: #{e}"
end
```

#### Using the checks_update_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CheckRun>, Integer, Hash)> checks_update_with_http_info(owner, repo, check_run_id, checks_update_request)

```ruby
begin
  # Update a check run
  data, status_code, headers = api_instance.checks_update_with_http_info(owner, repo, check_run_id, checks_update_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CheckRun>
rescue OpenapiClient::ApiError => e
  puts "Error when calling ChecksApi->checks_update_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **check_run_id** | **Integer** | The unique identifier of the check run. |  |
| **checks_update_request** | [**ChecksUpdateRequest**](ChecksUpdateRequest.md) |  |  |

### Return type

[**CheckRun**](CheckRun.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

