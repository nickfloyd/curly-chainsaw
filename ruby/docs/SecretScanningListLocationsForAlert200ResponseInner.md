# OpenapiClient::SecretScanningListLocationsForAlert200ResponseInner

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **type** | **String** | The location type. Because secrets may be found in different types of resources (ie. code, comments, issues), this field identifies the type of resource where the secret was found. |  |
| **details** | [**SecretScanningListLocationsForAlert200ResponseInnerDetails**](SecretScanningListLocationsForAlert200ResponseInnerDetails.md) |  |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::SecretScanningListLocationsForAlert200ResponseInner.new(
  type: commit,
  details: null
)
```

