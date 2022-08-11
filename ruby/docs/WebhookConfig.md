# OpenapiClient::WebhookConfig

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **email** | **String** |  | [optional] |
| **password** | **String** |  | [optional] |
| **room** | **String** |  | [optional] |
| **subdomain** | **String** |  | [optional] |
| **url** | **String** | The URL to which the payloads will be delivered. | [optional] |
| **insecure_ssl** | [**WebhookConfigurationInsecureSsl**](WebhookConfigurationInsecureSsl.md) |  | [optional] |
| **content_type** | **String** | The media type used to serialize the payloads. Supported values include &#x60;json&#x60; and &#x60;form&#x60;. The default is &#x60;form&#x60;. | [optional] |
| **digest** | **String** |  | [optional] |
| **secret** | **String** | If provided, the &#x60;secret&#x60; will be used as the &#x60;key&#x60; to generate the HMAC hex digest value for [delivery signature headers](https://docs.github.com/webhooks/event-payloads/#delivery-headers). | [optional] |
| **token** | **String** |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::WebhookConfig.new(
  email: &quot;foo@bar.com&quot;,
  password: &quot;foo&quot;,
  room: &quot;roomer&quot;,
  subdomain: &quot;foo&quot;,
  url: https://example.com/webhook,
  insecure_ssl: null,
  content_type: &quot;json&quot;,
  digest: &quot;sha256&quot;,
  secret: &quot;********&quot;,
  token: &quot;abc&quot;
)
```

