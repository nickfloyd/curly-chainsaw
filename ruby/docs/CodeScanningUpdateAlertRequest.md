# OpenapiClient::CodeScanningUpdateAlertRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **state** | **String** | Sets the state of the code scanning alert. You must provide &#x60;dismissed_reason&#x60; when you set the state to &#x60;dismissed&#x60;. |  |
| **dismissed_reason** | **String** | **Required when the state is dismissed.** The reason for dismissing or closing the alert. | [optional] |
| **dismissed_comment** | **String** | The dismissal comment associated with the dismissal of the alert. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::CodeScanningUpdateAlertRequest.new(
  state: null,
  dismissed_reason: null,
  dismissed_comment: null
)
```

