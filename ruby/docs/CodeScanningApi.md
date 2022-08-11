# OpenapiClient::CodeScanningApi

All URIs are relative to *https://api.github.com*

| Method | HTTP request | Description |
| ------ | ------------ | ----------- |
| [**code_scanning_delete_analysis**](CodeScanningApi.md#code_scanning_delete_analysis) | **DELETE** /repos/{owner}/{repo}/code-scanning/analyses/{analysis_id} | Delete a code scanning analysis from a repository |
| [**code_scanning_get_alert**](CodeScanningApi.md#code_scanning_get_alert) | **GET** /repos/{owner}/{repo}/code-scanning/alerts/{alert_number} | Get a code scanning alert |
| [**code_scanning_get_analysis**](CodeScanningApi.md#code_scanning_get_analysis) | **GET** /repos/{owner}/{repo}/code-scanning/analyses/{analysis_id} | Get a code scanning analysis for a repository |
| [**code_scanning_get_sarif**](CodeScanningApi.md#code_scanning_get_sarif) | **GET** /repos/{owner}/{repo}/code-scanning/sarifs/{sarif_id} | Get information about a SARIF upload |
| [**code_scanning_list_alert_instances**](CodeScanningApi.md#code_scanning_list_alert_instances) | **GET** /repos/{owner}/{repo}/code-scanning/alerts/{alert_number}/instances | List instances of a code scanning alert |
| [**code_scanning_list_alerts_for_enterprise**](CodeScanningApi.md#code_scanning_list_alerts_for_enterprise) | **GET** /enterprises/{enterprise}/code-scanning/alerts | List code scanning alerts for an enterprise |
| [**code_scanning_list_alerts_for_org**](CodeScanningApi.md#code_scanning_list_alerts_for_org) | **GET** /orgs/{org}/code-scanning/alerts | List code scanning alerts for an organization |
| [**code_scanning_list_alerts_for_repo**](CodeScanningApi.md#code_scanning_list_alerts_for_repo) | **GET** /repos/{owner}/{repo}/code-scanning/alerts | List code scanning alerts for a repository |
| [**code_scanning_list_recent_analyses**](CodeScanningApi.md#code_scanning_list_recent_analyses) | **GET** /repos/{owner}/{repo}/code-scanning/analyses | List code scanning analyses for a repository |
| [**code_scanning_update_alert**](CodeScanningApi.md#code_scanning_update_alert) | **PATCH** /repos/{owner}/{repo}/code-scanning/alerts/{alert_number} | Update a code scanning alert |
| [**code_scanning_upload_sarif**](CodeScanningApi.md#code_scanning_upload_sarif) | **POST** /repos/{owner}/{repo}/code-scanning/sarifs | Upload an analysis as SARIF data |


## code_scanning_delete_analysis

> <AnalysisDeletion> code_scanning_delete_analysis(owner, repo, analysis_id, opts)

Delete a code scanning analysis from a repository

Deletes a specified code scanning analysis from a repository. For private repositories, you must use an access token with the `repo` scope. For public repositories, you must use an access token with `public_repo` scope. GitHub Apps must have the `security_events` write permission to use this endpoint.  You can delete one analysis at a time. To delete a series of analyses, start with the most recent analysis and work backwards. Conceptually, the process is similar to the undo function in a text editor.  When you list the analyses for a repository, one or more will be identified as deletable in the response:  ``` \"deletable\": true ```  An analysis is deletable when it's the most recent in a set of analyses. Typically, a repository will have multiple sets of analyses for each enabled code scanning tool, where a set is determined by a unique combination of analysis values:  * `ref` * `tool` * `analysis_key` * `environment`  If you attempt to delete an analysis that is not the most recent in a set, you'll get a 400 response with the message:  ``` Analysis specified is not deletable. ```  The response from a successful `DELETE` operation provides you with two alternative URLs for deleting the next analysis in the set: `next_analysis_url` and `confirm_delete_url`. Use the `next_analysis_url` URL if you want to avoid accidentally deleting the final analysis in a set. This is a useful option if you want to preserve at least one analysis for the specified tool in your repository. Use the `confirm_delete_url` URL if you are content to remove all analyses for a tool. When you delete the last analysis in a set, the value of `next_analysis_url` and `confirm_delete_url` in the 200 response is `null`.  As an example of the deletion process, let's imagine that you added a workflow that configured a particular code scanning tool to analyze the code in a repository. This tool has added 15 analyses: 10 on the default branch, and another 5 on a topic branch. You therefore have two separate sets of analyses for this tool. You've now decided that you want to remove all of the analyses for the tool. To do this you must make 15 separate deletion requests. To start, you must find an analysis that's identified as deletable. Each set of analyses always has one that's identified as deletable. Having found the deletable analysis for one of the two sets, delete this analysis and then continue deleting the next analysis in the set until they're all deleted. Then repeat the process for the second set. The procedure therefore consists of a nested loop:  **Outer loop**: * List the analyses for the repository, filtered by tool. * Parse this list to find a deletable analysis. If found:    **Inner loop**:   * Delete the identified analysis.   * Parse the response for the value of `confirm_delete_url` and, if found, use this in the next iteration.  The above process assumes that you want to remove all trace of the tool's analyses from the GitHub user interface, for the specified repository, and it therefore uses the `confirm_delete_url` value. Alternatively, you could use the `next_analysis_url` value, which would leave the last analysis in each set undeleted to avoid removing a tool's analysis entirely.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodeScanningApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
analysis_id = 56 # Integer | The ID of the analysis, as returned from the `GET /repos/{owner}/{repo}/code-scanning/analyses` operation.
opts = {
  confirm_delete: 'confirm_delete_example' # String | Allow deletion if the specified analysis is the last in a set. If you attempt to delete the final analysis in a set without setting this parameter to `true`, you'll get a 400 response with the message: `Analysis is last of its type and deletion may result in the loss of historical alert data. Please specify confirm_delete.`
}

begin
  # Delete a code scanning analysis from a repository
  result = api_instance.code_scanning_delete_analysis(owner, repo, analysis_id, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodeScanningApi->code_scanning_delete_analysis: #{e}"
end
```

#### Using the code_scanning_delete_analysis_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<AnalysisDeletion>, Integer, Hash)> code_scanning_delete_analysis_with_http_info(owner, repo, analysis_id, opts)

```ruby
begin
  # Delete a code scanning analysis from a repository
  data, status_code, headers = api_instance.code_scanning_delete_analysis_with_http_info(owner, repo, analysis_id, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <AnalysisDeletion>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodeScanningApi->code_scanning_delete_analysis_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **analysis_id** | **Integer** | The ID of the analysis, as returned from the &#x60;GET /repos/{owner}/{repo}/code-scanning/analyses&#x60; operation. |  |
| **confirm_delete** | **String** | Allow deletion if the specified analysis is the last in a set. If you attempt to delete the final analysis in a set without setting this parameter to &#x60;true&#x60;, you&#39;ll get a 400 response with the message: &#x60;Analysis is last of its type and deletion may result in the loss of historical alert data. Please specify confirm_delete.&#x60; | [optional] |

### Return type

[**AnalysisDeletion**](AnalysisDeletion.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/scim+json


## code_scanning_get_alert

> <CodeScanningGetAlert200Response> code_scanning_get_alert(owner, repo, alert_number)

Get a code scanning alert

Gets a single code scanning alert. You must use an access token with the `security_events` scope to use this endpoint with private repos, the `public_repo` scope also grants permission to read security events on public repos only. GitHub Apps must have the `security_events` read permission to use this endpoint.  **Deprecation notice**: The instances field is deprecated and will, in future, not be included in the response for this endpoint. The example response reflects this change. The same information can now be retrieved via a GET request to the URL specified by `instances_url`.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodeScanningApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
alert_number = 56 # Integer | The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the `number` field in the response from the `GET /repos/{owner}/{repo}/code-scanning/alerts` operation.

begin
  # Get a code scanning alert
  result = api_instance.code_scanning_get_alert(owner, repo, alert_number)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodeScanningApi->code_scanning_get_alert: #{e}"
end
```

#### Using the code_scanning_get_alert_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CodeScanningGetAlert200Response>, Integer, Hash)> code_scanning_get_alert_with_http_info(owner, repo, alert_number)

```ruby
begin
  # Get a code scanning alert
  data, status_code, headers = api_instance.code_scanning_get_alert_with_http_info(owner, repo, alert_number)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CodeScanningGetAlert200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodeScanningApi->code_scanning_get_alert_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **alert_number** | **Integer** | The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the &#x60;number&#x60; field in the response from the &#x60;GET /repos/{owner}/{repo}/code-scanning/alerts&#x60; operation. |  |

### Return type

[**CodeScanningGetAlert200Response**](CodeScanningGetAlert200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## code_scanning_get_analysis

> <CodeScanningListRecentAnalyses200ResponseInner> code_scanning_get_analysis(owner, repo, analysis_id)

Get a code scanning analysis for a repository

Gets a specified code scanning analysis for a repository. You must use an access token with the `security_events` scope to use this endpoint with private repos, the `public_repo` scope also grants permission to read security events on public repos only. GitHub Apps must have the `security_events` read permission to use this endpoint.  The default JSON response contains fields that describe the analysis. This includes the Git reference and commit SHA to which the analysis relates, the datetime of the analysis, the name of the code scanning tool, and the number of alerts.  The `rules_count` field in the default response give the number of rules that were run in the analysis. For very old analyses this data is not available, and `0` is returned in this field.  If you use the Accept header `application/sarif+json`, the response contains the analysis data that was uploaded. This is formatted as [SARIF version 2.1.0](https://docs.oasis-open.org/sarif/sarif/v2.1.0/cs01/sarif-v2.1.0-cs01.html).

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodeScanningApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
analysis_id = 56 # Integer | The ID of the analysis, as returned from the `GET /repos/{owner}/{repo}/code-scanning/analyses` operation.

begin
  # Get a code scanning analysis for a repository
  result = api_instance.code_scanning_get_analysis(owner, repo, analysis_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodeScanningApi->code_scanning_get_analysis: #{e}"
end
```

#### Using the code_scanning_get_analysis_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CodeScanningListRecentAnalyses200ResponseInner>, Integer, Hash)> code_scanning_get_analysis_with_http_info(owner, repo, analysis_id)

```ruby
begin
  # Get a code scanning analysis for a repository
  data, status_code, headers = api_instance.code_scanning_get_analysis_with_http_info(owner, repo, analysis_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CodeScanningListRecentAnalyses200ResponseInner>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodeScanningApi->code_scanning_get_analysis_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **analysis_id** | **Integer** | The ID of the analysis, as returned from the &#x60;GET /repos/{owner}/{repo}/code-scanning/analyses&#x60; operation. |  |

### Return type

[**CodeScanningListRecentAnalyses200ResponseInner**](CodeScanningListRecentAnalyses200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json+sarif


## code_scanning_get_sarif

> <CodeScanningGetSarif200Response> code_scanning_get_sarif(owner, repo, sarif_id)

Get information about a SARIF upload

Gets information about a SARIF upload, including the status and the URL of the analysis that was uploaded so that you can retrieve details of the analysis. For more information, see \"[Get a code scanning analysis for a repository](/rest/reference/code-scanning#get-a-code-scanning-analysis-for-a-repository).\" You must use an access token with the `security_events` scope to use this endpoint with private repos, the `public_repo` scope also grants permission to read security events on public repos only. GitHub Apps must have the `security_events` read permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodeScanningApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
sarif_id = 'sarif_id_example' # String | The SARIF ID obtained after uploading.

begin
  # Get information about a SARIF upload
  result = api_instance.code_scanning_get_sarif(owner, repo, sarif_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodeScanningApi->code_scanning_get_sarif: #{e}"
end
```

#### Using the code_scanning_get_sarif_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CodeScanningGetSarif200Response>, Integer, Hash)> code_scanning_get_sarif_with_http_info(owner, repo, sarif_id)

```ruby
begin
  # Get information about a SARIF upload
  data, status_code, headers = api_instance.code_scanning_get_sarif_with_http_info(owner, repo, sarif_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CodeScanningGetSarif200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodeScanningApi->code_scanning_get_sarif_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **sarif_id** | **String** | The SARIF ID obtained after uploading. |  |

### Return type

[**CodeScanningGetSarif200Response**](CodeScanningGetSarif200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## code_scanning_list_alert_instances

> <Array<CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance>> code_scanning_list_alert_instances(owner, repo, alert_number, opts)

List instances of a code scanning alert

Lists all instances of the specified code scanning alert. You must use an access token with the `security_events` scope to use this endpoint with private repos, the `public_repo` scope also grants permission to read security events on public repos only. GitHub Apps must have the `security_events` read permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodeScanningApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
alert_number = 56 # Integer | The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the `number` field in the response from the `GET /repos/{owner}/{repo}/code-scanning/alerts` operation.
opts = {
  page: 56, # Integer | Page number of the results to fetch.
  per_page: 56, # Integer | The number of results per page (max 100).
  ref: 'ref_example' # String | The Git reference for the results you want to list. The `ref` for a branch can be formatted either as `refs/heads/<branch name>` or simply `<branch name>`. To reference a pull request use `refs/pull/<number>/merge`.
}

begin
  # List instances of a code scanning alert
  result = api_instance.code_scanning_list_alert_instances(owner, repo, alert_number, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodeScanningApi->code_scanning_list_alert_instances: #{e}"
end
```

#### Using the code_scanning_list_alert_instances_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance>>, Integer, Hash)> code_scanning_list_alert_instances_with_http_info(owner, repo, alert_number, opts)

```ruby
begin
  # List instances of a code scanning alert
  data, status_code, headers = api_instance.code_scanning_list_alert_instances_with_http_info(owner, repo, alert_number, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodeScanningApi->code_scanning_list_alert_instances_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **alert_number** | **Integer** | The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the &#x60;number&#x60; field in the response from the &#x60;GET /repos/{owner}/{repo}/code-scanning/alerts&#x60; operation. |  |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **ref** | **String** | The Git reference for the results you want to list. The &#x60;ref&#x60; for a branch can be formatted either as &#x60;refs/heads/&lt;branch name&gt;&#x60; or simply &#x60;&lt;branch name&gt;&#x60;. To reference a pull request use &#x60;refs/pull/&lt;number&gt;/merge&#x60;. | [optional] |

### Return type

[**Array&lt;CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance&gt;**](CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## code_scanning_list_alerts_for_enterprise

> <Array<CodeScanningListAlertsForEnterprise200ResponseInner>> code_scanning_list_alerts_for_enterprise(enterprise, opts)

List code scanning alerts for an enterprise

Lists code scanning alerts for the default branch for all eligible repositories in an enterprise. Eligible repositories are repositories that are owned by organizations that you own or for which you are a security manager. For more information, see \"[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).\"  To use this endpoint, you must be a member of the enterprise, and you must use an access token with the `repo` scope or `security_events` scope.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodeScanningApi.new
enterprise = 'enterprise_example' # String | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
opts = {
  tool_name: 'tool_name_example', # String | The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either `tool_name` or `tool_guid`, but not both.
  tool_guid: 'tool_guid_example', # String | The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either `tool_guid` or `tool_name`, but not both.
  before: 'before_example', # String | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor.
  after: 'after_example', # String | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.
  page: 56, # Integer | Page number of the results to fetch.
  per_page: 56, # Integer | The number of results per page (max 100).
  direction: 'asc', # String | The direction to sort the results by.
  state: 'open', # String | If specified, only code scanning alerts with this state will be returned.
  sort: 'created' # String | The property by which to sort the results.
}

begin
  # List code scanning alerts for an enterprise
  result = api_instance.code_scanning_list_alerts_for_enterprise(enterprise, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodeScanningApi->code_scanning_list_alerts_for_enterprise: #{e}"
end
```

#### Using the code_scanning_list_alerts_for_enterprise_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<CodeScanningListAlertsForEnterprise200ResponseInner>>, Integer, Hash)> code_scanning_list_alerts_for_enterprise_with_http_info(enterprise, opts)

```ruby
begin
  # List code scanning alerts for an enterprise
  data, status_code, headers = api_instance.code_scanning_list_alerts_for_enterprise_with_http_info(enterprise, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<CodeScanningListAlertsForEnterprise200ResponseInner>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodeScanningApi->code_scanning_list_alerts_for_enterprise_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **enterprise** | **String** | The slug version of the enterprise name. You can also substitute this value with the enterprise id. |  |
| **tool_name** | **String** | The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either &#x60;tool_name&#x60; or &#x60;tool_guid&#x60;, but not both. | [optional] |
| **tool_guid** | **String** | The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either &#x60;tool_guid&#x60; or &#x60;tool_name&#x60;, but not both. | [optional] |
| **before** | **String** | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. | [optional] |
| **after** | **String** | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor. | [optional] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **direction** | **String** | The direction to sort the results by. | [optional][default to &#39;desc&#39;] |
| **state** | **String** | If specified, only code scanning alerts with this state will be returned. | [optional] |
| **sort** | **String** | The property by which to sort the results. | [optional][default to &#39;created&#39;] |

### Return type

[**Array&lt;CodeScanningListAlertsForEnterprise200ResponseInner&gt;**](CodeScanningListAlertsForEnterprise200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## code_scanning_list_alerts_for_org

> <Array<CodeScanningListAlertsForEnterprise200ResponseInner>> code_scanning_list_alerts_for_org(org, opts)

List code scanning alerts for an organization

Lists code scanning alerts for the default branch for all eligible repositories in an organization. Eligible repositories are repositories that are owned by organizations that you own or for which you are a security manager. For more information, see \"[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).\"  To use this endpoint, you must be an owner or security manager for the organization, and you must use an access token with the `repo` scope or `security_events` scope.  For public repositories, you may instead use the `public_repo` scope.  GitHub Apps must have the `security_events` read permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodeScanningApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  tool_name: 'tool_name_example', # String | The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either `tool_name` or `tool_guid`, but not both.
  tool_guid: 'tool_guid_example', # String | The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either `tool_guid` or `tool_name`, but not both.
  before: 'before_example', # String | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor.
  after: 'after_example', # String | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.
  page: 56, # Integer | Page number of the results to fetch.
  per_page: 56, # Integer | The number of results per page (max 100).
  direction: 'asc', # String | The direction to sort the results by.
  state: 'open', # String | If specified, only code scanning alerts with this state will be returned.
  sort: 'created' # String | The property by which to sort the results.
}

begin
  # List code scanning alerts for an organization
  result = api_instance.code_scanning_list_alerts_for_org(org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodeScanningApi->code_scanning_list_alerts_for_org: #{e}"
end
```

#### Using the code_scanning_list_alerts_for_org_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<CodeScanningListAlertsForEnterprise200ResponseInner>>, Integer, Hash)> code_scanning_list_alerts_for_org_with_http_info(org, opts)

```ruby
begin
  # List code scanning alerts for an organization
  data, status_code, headers = api_instance.code_scanning_list_alerts_for_org_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<CodeScanningListAlertsForEnterprise200ResponseInner>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodeScanningApi->code_scanning_list_alerts_for_org_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **tool_name** | **String** | The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either &#x60;tool_name&#x60; or &#x60;tool_guid&#x60;, but not both. | [optional] |
| **tool_guid** | **String** | The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either &#x60;tool_guid&#x60; or &#x60;tool_name&#x60;, but not both. | [optional] |
| **before** | **String** | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. | [optional] |
| **after** | **String** | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor. | [optional] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **direction** | **String** | The direction to sort the results by. | [optional][default to &#39;desc&#39;] |
| **state** | **String** | If specified, only code scanning alerts with this state will be returned. | [optional] |
| **sort** | **String** | The property by which to sort the results. | [optional][default to &#39;created&#39;] |

### Return type

[**Array&lt;CodeScanningListAlertsForEnterprise200ResponseInner&gt;**](CodeScanningListAlertsForEnterprise200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## code_scanning_list_alerts_for_repo

> <Array<CodeScanningListAlertsForRepo200ResponseInner>> code_scanning_list_alerts_for_repo(owner, repo, opts)

List code scanning alerts for a repository

Lists code scanning alerts.  To use this endpoint, you must use an access token with the `security_events` scope or, for alerts from public repositories only, an access token with the `public_repo` scope.  GitHub Apps must have the `security_events` read permission to use this endpoint.  The response includes a `most_recent_instance` object. This provides details of the most recent instance of this alert for the default branch (or for the specified Git reference if you used `ref` in the request).

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodeScanningApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  tool_name: 'tool_name_example', # String | The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either `tool_name` or `tool_guid`, but not both.
  tool_guid: 'tool_guid_example', # String | The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either `tool_guid` or `tool_name`, but not both.
  page: 56, # Integer | Page number of the results to fetch.
  per_page: 56, # Integer | The number of results per page (max 100).
  ref: 'ref_example', # String | The Git reference for the results you want to list. The `ref` for a branch can be formatted either as `refs/heads/<branch name>` or simply `<branch name>`. To reference a pull request use `refs/pull/<number>/merge`.
  direction: 'asc', # String | The direction to sort the results by.
  sort: 'created', # String | The property by which to sort the results.
  state: 'open' # String | If specified, only code scanning alerts with this state will be returned.
}

begin
  # List code scanning alerts for a repository
  result = api_instance.code_scanning_list_alerts_for_repo(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodeScanningApi->code_scanning_list_alerts_for_repo: #{e}"
end
```

#### Using the code_scanning_list_alerts_for_repo_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<CodeScanningListAlertsForRepo200ResponseInner>>, Integer, Hash)> code_scanning_list_alerts_for_repo_with_http_info(owner, repo, opts)

```ruby
begin
  # List code scanning alerts for a repository
  data, status_code, headers = api_instance.code_scanning_list_alerts_for_repo_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<CodeScanningListAlertsForRepo200ResponseInner>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodeScanningApi->code_scanning_list_alerts_for_repo_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **tool_name** | **String** | The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either &#x60;tool_name&#x60; or &#x60;tool_guid&#x60;, but not both. | [optional] |
| **tool_guid** | **String** | The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either &#x60;tool_guid&#x60; or &#x60;tool_name&#x60;, but not both. | [optional] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **ref** | **String** | The Git reference for the results you want to list. The &#x60;ref&#x60; for a branch can be formatted either as &#x60;refs/heads/&lt;branch name&gt;&#x60; or simply &#x60;&lt;branch name&gt;&#x60;. To reference a pull request use &#x60;refs/pull/&lt;number&gt;/merge&#x60;. | [optional] |
| **direction** | **String** | The direction to sort the results by. | [optional][default to &#39;desc&#39;] |
| **sort** | **String** | The property by which to sort the results. | [optional][default to &#39;created&#39;] |
| **state** | **String** | If specified, only code scanning alerts with this state will be returned. | [optional] |

### Return type

[**Array&lt;CodeScanningListAlertsForRepo200ResponseInner&gt;**](CodeScanningListAlertsForRepo200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## code_scanning_list_recent_analyses

> <Array<CodeScanningListRecentAnalyses200ResponseInner>> code_scanning_list_recent_analyses(owner, repo, opts)

List code scanning analyses for a repository

Lists the details of all code scanning analyses for a repository, starting with the most recent. The response is paginated and you can use the `page` and `per_page` parameters to list the analyses you're interested in. By default 30 analyses are listed per page.  The `rules_count` field in the response give the number of rules that were run in the analysis. For very old analyses this data is not available, and `0` is returned in this field.  You must use an access token with the `security_events` scope to use this endpoint with private repos, the `public_repo` scope also grants permission to read security events on public repos only. GitHub Apps must have the `security_events` read permission to use this endpoint.  **Deprecation notice**: The `tool_name` field is deprecated and will, in future, not be included in the response for this endpoint. The example response reflects this change. The tool name can now be found inside the `tool` field.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodeScanningApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  tool_name: 'tool_name_example', # String | The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either `tool_name` or `tool_guid`, but not both.
  tool_guid: 'tool_guid_example', # String | The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either `tool_guid` or `tool_name`, but not both.
  page: 56, # Integer | Page number of the results to fetch.
  per_page: 56, # Integer | The number of results per page (max 100).
  ref: 'ref_example', # String | The Git reference for the analyses you want to list. The `ref` for a branch can be formatted either as `refs/heads/<branch name>` or simply `<branch name>`. To reference a pull request use `refs/pull/<number>/merge`.
  sarif_id: '6c81cd8e-b078-4ac3-a3be-1dad7dbd0b53' # String | Filter analyses belonging to the same SARIF upload.
}

begin
  # List code scanning analyses for a repository
  result = api_instance.code_scanning_list_recent_analyses(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodeScanningApi->code_scanning_list_recent_analyses: #{e}"
end
```

#### Using the code_scanning_list_recent_analyses_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Array<CodeScanningListRecentAnalyses200ResponseInner>>, Integer, Hash)> code_scanning_list_recent_analyses_with_http_info(owner, repo, opts)

```ruby
begin
  # List code scanning analyses for a repository
  data, status_code, headers = api_instance.code_scanning_list_recent_analyses_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Array<CodeScanningListRecentAnalyses200ResponseInner>>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodeScanningApi->code_scanning_list_recent_analyses_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **tool_name** | **String** | The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either &#x60;tool_name&#x60; or &#x60;tool_guid&#x60;, but not both. | [optional] |
| **tool_guid** | **String** | The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either &#x60;tool_guid&#x60; or &#x60;tool_name&#x60;, but not both. | [optional] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **ref** | **String** | The Git reference for the analyses you want to list. The &#x60;ref&#x60; for a branch can be formatted either as &#x60;refs/heads/&lt;branch name&gt;&#x60; or simply &#x60;&lt;branch name&gt;&#x60;. To reference a pull request use &#x60;refs/pull/&lt;number&gt;/merge&#x60;. | [optional] |
| **sarif_id** | **String** | Filter analyses belonging to the same SARIF upload. | [optional] |

### Return type

[**Array&lt;CodeScanningListRecentAnalyses200ResponseInner&gt;**](CodeScanningListRecentAnalyses200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## code_scanning_update_alert

> <CodeScanningGetAlert200Response> code_scanning_update_alert(owner, repo, alert_number, code_scanning_update_alert_request)

Update a code scanning alert

Updates the status of a single code scanning alert. You must use an access token with the `security_events` scope to use this endpoint with private repositories. You can also use tokens with the `public_repo` scope for public repositories only. GitHub Apps must have the `security_events` write permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodeScanningApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
alert_number = 56 # Integer | The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the `number` field in the response from the `GET /repos/{owner}/{repo}/code-scanning/alerts` operation.
code_scanning_update_alert_request = OpenapiClient::CodeScanningUpdateAlertRequest.new({state: 'open'}) # CodeScanningUpdateAlertRequest | 

begin
  # Update a code scanning alert
  result = api_instance.code_scanning_update_alert(owner, repo, alert_number, code_scanning_update_alert_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodeScanningApi->code_scanning_update_alert: #{e}"
end
```

#### Using the code_scanning_update_alert_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CodeScanningGetAlert200Response>, Integer, Hash)> code_scanning_update_alert_with_http_info(owner, repo, alert_number, code_scanning_update_alert_request)

```ruby
begin
  # Update a code scanning alert
  data, status_code, headers = api_instance.code_scanning_update_alert_with_http_info(owner, repo, alert_number, code_scanning_update_alert_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CodeScanningGetAlert200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodeScanningApi->code_scanning_update_alert_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **alert_number** | **Integer** | The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the &#x60;number&#x60; field in the response from the &#x60;GET /repos/{owner}/{repo}/code-scanning/alerts&#x60; operation. |  |
| **code_scanning_update_alert_request** | [**CodeScanningUpdateAlertRequest**](CodeScanningUpdateAlertRequest.md) |  |  |

### Return type

[**CodeScanningGetAlert200Response**](CodeScanningGetAlert200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## code_scanning_upload_sarif

> <CodeScanningUploadSarif202Response> code_scanning_upload_sarif(owner, repo, code_scanning_upload_sarif_request)

Upload an analysis as SARIF data

Uploads SARIF data containing the results of a code scanning analysis to make the results available in a repository. You must use an access token with the `security_events` scope to use this endpoint for private repositories. You can also use tokens with the `public_repo` scope for public repositories only. GitHub Apps must have the `security_events` write permission to use this endpoint.  There are two places where you can upload code scanning results.  - If you upload to a pull request, for example `--ref refs/pull/42/merge` or `--ref refs/pull/42/head`, then the results appear as alerts in a pull request check. For more information, see \"[Triaging code scanning alerts in pull requests](/code-security/secure-coding/triaging-code-scanning-alerts-in-pull-requests).\"  - If you upload to a branch, for example `--ref refs/heads/my-branch`, then the results appear in the **Security** tab for your repository. For more information, see \"[Managing code scanning alerts for your repository](/code-security/secure-coding/managing-code-scanning-alerts-for-your-repository#viewing-the-alerts-for-a-repository).\"  You must compress the SARIF-formatted analysis data that you want to upload, using `gzip`, and then encode it as a Base64 format string. For example:  ``` gzip -c analysis-data.sarif | base64 -w0 ```  SARIF upload supports a maximum of 5000 results per analysis run. Any results over this limit are ignored and any SARIF uploads with more than 25,000 results are rejected. Typically, but not necessarily, a SARIF file contains a single run of a single tool. If a code scanning tool generates too many results, you should update the analysis configuration to run only the most important rules or queries.  The `202 Accepted`, response includes an `id` value. You can use this ID to check the status of the upload by using this for the `/sarifs/{sarif_id}` endpoint. For more information, see \"[Get information about a SARIF upload](/rest/reference/code-scanning#get-information-about-a-sarif-upload).\"

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodeScanningApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
code_scanning_upload_sarif_request = OpenapiClient::CodeScanningUploadSarifRequest.new({commit_sha: 'commit_sha_example', ref: 'ref_example', sarif: 'sarif_example'}) # CodeScanningUploadSarifRequest | 

begin
  # Upload an analysis as SARIF data
  result = api_instance.code_scanning_upload_sarif(owner, repo, code_scanning_upload_sarif_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodeScanningApi->code_scanning_upload_sarif: #{e}"
end
```

#### Using the code_scanning_upload_sarif_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CodeScanningUploadSarif202Response>, Integer, Hash)> code_scanning_upload_sarif_with_http_info(owner, repo, code_scanning_upload_sarif_request)

```ruby
begin
  # Upload an analysis as SARIF data
  data, status_code, headers = api_instance.code_scanning_upload_sarif_with_http_info(owner, repo, code_scanning_upload_sarif_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CodeScanningUploadSarif202Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodeScanningApi->code_scanning_upload_sarif_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **code_scanning_upload_sarif_request** | [**CodeScanningUploadSarifRequest**](CodeScanningUploadSarifRequest.md) |  |  |

### Return type

[**CodeScanningUploadSarif202Response**](CodeScanningUploadSarif202Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

