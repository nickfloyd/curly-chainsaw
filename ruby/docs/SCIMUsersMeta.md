# OpenapiClient::SCIMUsersMeta

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **resource_type** | **String** |  | [optional] |
| **created** | **Time** |  | [optional] |
| **last_modified** | **Time** |  | [optional] |
| **location** | **String** |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::SCIMUsersMeta.new(
  resource_type: User,
  created: 2019-01-24T22:45:36Z,
  last_modified: 2019-01-24T22:45:36Z,
  location: https://api.github.com/scim/v2/organizations/myorg-123abc55141bfd8f/Users/c42772b5-2029-11e9-8543-9264a97dec8d
)
```

