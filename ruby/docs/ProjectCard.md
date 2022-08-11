# OpenapiClient::ProjectCard

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **url** | **String** |  |  |
| **id** | **Integer** | The project card&#39;s ID |  |
| **node_id** | **String** |  |  |
| **note** | **String** |  |  |
| **creator** | [**SimpleUser**](SimpleUser.md) |  |  |
| **created_at** | **Time** |  |  |
| **updated_at** | **Time** |  |  |
| **archived** | **Boolean** | Whether or not the card is archived | [optional] |
| **column_name** | **String** |  | [optional] |
| **project_id** | **String** |  | [optional] |
| **column_url** | **String** |  |  |
| **content_url** | **String** |  | [optional] |
| **project_url** | **String** |  |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ProjectCard.new(
  url: https://api.github.com/projects/columns/cards/1478,
  id: 42,
  node_id: MDExOlByb2plY3RDYXJkMTQ3OA&#x3D;&#x3D;,
  note: Add payload for delete Project column,
  creator: null,
  created_at: 2016-09-05T14:21:06Z,
  updated_at: 2016-09-05T14:20:22Z,
  archived: false,
  column_name: null,
  project_id: null,
  column_url: https://api.github.com/projects/columns/367,
  content_url: https://api.github.com/repos/api-playground/projects-test/issues/3,
  project_url: https://api.github.com/projects/120
)
```

