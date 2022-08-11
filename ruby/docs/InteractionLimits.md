# OpenapiClient::InteractionLimits

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **limit** | **String** | The type of GitHub user that can comment, open issues, or create pull requests while the interaction limit is in effect. |  |
| **origin** | **String** |  |  |
| **expires_at** | **Time** |  |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::InteractionLimits.new(
  limit: collaborators_only,
  origin: repository,
  expires_at: 2018-08-17T04:18:39Z
)
```

