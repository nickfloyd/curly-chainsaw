# OpenapiClient::ServerStatisticsProxyEndpointInner

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **server_id** | **String** |  | [optional] |
| **collection_date** | **String** |  | [optional] |
| **schema_version** | **String** |  | [optional] |
| **ghes_version** | **String** |  | [optional] |
| **host_name** | **String** |  | [optional] |
| **github_connect** | [**ServerStatisticsProxyEndpointInnerGithubConnect**](ServerStatisticsProxyEndpointInnerGithubConnect.md) |  | [optional] |
| **ghe_stats** | [**ServerStatisticsProxyEndpointInnerGheStats**](ServerStatisticsProxyEndpointInnerGheStats.md) |  | [optional] |
| **dormant_users** | [**ServerStatisticsProxyEndpointInnerDormantUsers**](ServerStatisticsProxyEndpointInnerDormantUsers.md) |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ServerStatisticsProxyEndpointInner.new(
  server_id: null,
  collection_date: null,
  schema_version: null,
  ghes_version: null,
  host_name: null,
  github_connect: null,
  ghe_stats: null,
  dormant_users: null
)
```

