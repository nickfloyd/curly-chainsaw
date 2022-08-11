# OpenapiClient::SecretScanningListAlertsForRepo200ResponseInner

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **number** | **Integer** | The security alert number. | [optional][readonly] |
| **created_at** | **Time** | The time that the alert was created in ISO 8601 format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional][readonly] |
| **updated_at** | **Time** | The time that the alert was last updated in ISO 8601 format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional][readonly] |
| **url** | **String** | The REST API URL of the alert resource. | [optional][readonly] |
| **html_url** | **String** | The GitHub URL of the alert resource. | [optional][readonly] |
| **locations_url** | **String** | The REST API URL of the code locations for this alert. | [optional] |
| **state** | **String** | Sets the state of the secret scanning alert. Can be either &#x60;open&#x60; or &#x60;resolved&#x60;. You must provide &#x60;resolution&#x60; when you set the state to &#x60;resolved&#x60;. | [optional] |
| **resolution** | **String** | **Required when the &#x60;state&#x60; is &#x60;resolved&#x60;.** The reason for resolving the alert. | [optional] |
| **resolved_at** | **Time** | The time that the alert was resolved in ISO 8601 format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] |
| **resolved_by** | [**SimpleUser**](SimpleUser.md) |  | [optional] |
| **secret_type** | **String** | The type of secret that secret scanning detected. | [optional] |
| **secret_type_display_name** | **String** | User-friendly name for the detected secret, matching the &#x60;secret_type&#x60;. For a list of built-in patterns, see \&quot;[Secret scanning patterns](https://docs.github.com/code-security/secret-scanning/secret-scanning-patterns#supported-secrets-for-advanced-security).\&quot; | [optional] |
| **secret** | **String** | The secret that was detected. | [optional] |
| **push_protection_bypassed** | **Boolean** | Whether push protection was bypassed for the detected secret. | [optional] |
| **push_protection_bypassed_by** | [**SimpleUser**](SimpleUser.md) |  | [optional] |
| **push_protection_bypassed_at** | **Time** | The time that push protection was bypassed in ISO 8601 format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::SecretScanningListAlertsForRepo200ResponseInner.new(
  number: null,
  created_at: null,
  updated_at: null,
  url: null,
  html_url: null,
  locations_url: null,
  state: null,
  resolution: null,
  resolved_at: null,
  resolved_by: null,
  secret_type: null,
  secret_type_display_name: null,
  secret: null,
  push_protection_bypassed: null,
  push_protection_bypassed_by: null,
  push_protection_bypassed_at: null
)
```

