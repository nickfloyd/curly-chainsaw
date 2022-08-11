# OpenapiClient::ReposCreateOrUpdateEnvironmentRequestReviewersInner

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **type** | **String** | The type of reviewer. | [optional] |
| **id** | **Integer** | The id of the user or team who can review the deployment | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ReposCreateOrUpdateEnvironmentRequestReviewersInner.new(
  type: User,
  id: 4532992
)
```

