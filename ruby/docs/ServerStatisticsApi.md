# OpenapiClient::ServerStatisticsApi

All URIs are relative to *https://api.github.com*

| Method | HTTP request | Description |
| ------ | ------------ | ----------- |
| [**enterprise_admin_get_server_statistics**](ServerStatisticsApi.md#enterprise_admin_get_server_statistics) | **GET** /enterprise-installation/{enterprise_or_org}/server-statistics | Get GitHub Enterprise Server statistics |


## enterprise_admin_get_server_statistics

> <Array<ServerStatisticsProxyEndpointInner>> enterprise_admin_get_server_statistics(enterprise_or_org, opts)

Get GitHub Enterprise Server statistics

Returns aggregate usage metrics for your GitHub Enterprise Server 3.5+ instance for a specified time period up to 365 days.  To use this endpoint, your GitHub Enterprise Server instance must be connected to GitHub Enterprise Cloud using GitHub Connect. You must enable Server Statistics, and for the API request provide your enterprise account name or organization name connected to the GitHub Enterprise Server. For more information, see \"[Enabling Server Statistics for your enterprise](/admin/configuration/configuring-github-connect/enabling-server-statistics-for-your-enterprise)\" in the GitHub Enterprise Server documentation.  You'll need to use a personal access token:   - If you connected your GitHub Enterprise Server to an enterprise account and enabled Server Statistics, you'll need a personal access token with the `read:enterprise` permission.   - If you connected your GitHub Enterprise Server to an organization account and enabled Server Statistics, you'll need a personal access token with the `read:org` permission.  For more information on creating a personal access token, see \"[Creating a personal access token](/authentication/keeping-your-account-and-data-secure/creating-a-personal-access-token).\"

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::ServerStatisticsApi.new
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
  puts "Error when calling ServerStatisticsApi->enterprise_admin_get_server_statistics: #{e}"
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
  puts "Error when calling ServerStatisticsApi->enterprise_admin_get_server_statistics_with_http_info: #{e}"
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

