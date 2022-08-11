# OpenapiClient::ActionsGetActionsCacheUsageForEnterprise200Response

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **total_active_caches_count** | **Integer** | The count of active caches across all repositories of an enterprise or an organization. |  |
| **total_active_caches_size_in_bytes** | **Integer** | The total size in bytes of all active cache items across all repositories of an enterprise or an organization. |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ActionsGetActionsCacheUsageForEnterprise200Response.new(
  total_active_caches_count: null,
  total_active_caches_size_in_bytes: null
)
```

