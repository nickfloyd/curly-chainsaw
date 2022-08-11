# OpenapiClient::InteractionRestrictions

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **limit** | **String** | The type of GitHub user that can comment, open issues, or create pull requests while the interaction limit is in effect. |  |
| **expiry** | **String** | The duration of the interaction restriction. Default: &#x60;one_day&#x60;. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::InteractionRestrictions.new(
  limit: collaborators_only,
  expiry: one_month
)
```

