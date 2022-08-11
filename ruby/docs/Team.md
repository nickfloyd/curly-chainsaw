# OpenapiClient::Team

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **id** | **Integer** |  |  |
| **node_id** | **String** |  |  |
| **name** | **String** |  |  |
| **slug** | **String** |  |  |
| **description** | **String** |  |  |
| **privacy** | **String** |  | [optional] |
| **permission** | **String** |  |  |
| **permissions** | [**TeamPermissions**](TeamPermissions.md) |  | [optional] |
| **url** | **String** |  |  |
| **html_url** | **String** |  |  |
| **members_url** | **String** |  |  |
| **repositories_url** | **String** |  |  |
| **parent** | [**TeamSimple**](TeamSimple.md) |  |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::Team.new(
  id: null,
  node_id: null,
  name: null,
  slug: null,
  description: null,
  privacy: null,
  permission: null,
  permissions: null,
  url: null,
  html_url: https://github.com/orgs/rails/teams/core,
  members_url: null,
  repositories_url: null,
  parent: null
)
```

