# OpenapiClient::SecretScanningUpdateAlertRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **state** | **String** | Sets the state of the secret scanning alert. Can be either &#x60;open&#x60; or &#x60;resolved&#x60;. You must provide &#x60;resolution&#x60; when you set the state to &#x60;resolved&#x60;. |  |
| **resolution** | **String** | **Required when the &#x60;state&#x60; is &#x60;resolved&#x60;.** The reason for resolving the alert. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::SecretScanningUpdateAlertRequest.new(
  state: null,
  resolution: null
)
```

