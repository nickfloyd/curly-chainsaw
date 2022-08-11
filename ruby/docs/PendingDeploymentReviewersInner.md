# OpenapiClient::PendingDeploymentReviewersInner

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **type** | **String** | The type of reviewer. | [optional] |
| **reviewer** | [**PendingDeploymentReviewersInnerReviewer**](PendingDeploymentReviewersInnerReviewer.md) |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::PendingDeploymentReviewersInner.new(
  type: User,
  reviewer: null
)
```

