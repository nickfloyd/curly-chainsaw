# OpenapiClient::SelfHostedRunners

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **id** | **Integer** | The id of the runner. |  |
| **name** | **String** | The name of the runner. |  |
| **os** | **String** | The Operating System of the runner. |  |
| **status** | **String** | The status of the runner. |  |
| **busy** | **Boolean** |  |  |
| **labels** | [**Array&lt;SelfHostedRunnerLabel&gt;**](SelfHostedRunnerLabel.md) |  |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::SelfHostedRunners.new(
  id: 5,
  name: iMac,
  os: macos,
  status: online,
  busy: null,
  labels: null
)
```

