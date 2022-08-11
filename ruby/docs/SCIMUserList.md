# OpenapiClient::SCIMUserList

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **schemas** | **Array&lt;String&gt;** | SCIM schema used. |  |
| **total_results** | **Integer** |  |  |
| **items_per_page** | **Integer** |  |  |
| **start_index** | **Integer** |  |  |
| **resources** | [**Array&lt;SCIMUsers&gt;**](SCIMUsers.md) |  |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::SCIMUserList.new(
  schemas: null,
  total_results: 3,
  items_per_page: 10,
  start_index: 1,
  resources: null
)
```

