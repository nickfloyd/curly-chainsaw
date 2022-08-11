# OpenapiClient::CodeScanningListAlertsForRepo200ResponseInnerRule

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **id** | **String** | A unique identifier for the rule used to detect the alert. | [optional] |
| **name** | **String** | The name of the rule used to detect the alert. | [optional] |
| **tags** | **Array&lt;String&gt;** | A set of tags applicable for the rule. | [optional] |
| **severity** | **String** | The severity of the alert. | [optional] |
| **description** | **String** | A short description of the rule used to detect the alert. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::CodeScanningListAlertsForRepo200ResponseInnerRule.new(
  id: null,
  name: null,
  tags: null,
  severity: null,
  description: null
)
```

