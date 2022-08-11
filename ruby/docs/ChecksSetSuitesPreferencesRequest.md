# OpenapiClient::ChecksSetSuitesPreferencesRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **auto_trigger_checks** | [**Array&lt;ChecksSetSuitesPreferencesRequestAutoTriggerChecksInner&gt;**](ChecksSetSuitesPreferencesRequestAutoTriggerChecksInner.md) | Enables or disables automatic creation of CheckSuite events upon pushes to the repository. Enabled by default. See the [&#x60;auto_trigger_checks&#x60; object](https://docs.github.com/rest/reference/checks#auto_trigger_checks-object) description for details. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ChecksSetSuitesPreferencesRequest.new(
  auto_trigger_checks: null
)
```

