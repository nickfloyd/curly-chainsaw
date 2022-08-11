# OpenapiClient::ReposTransferRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **new_owner** | **String** | The username or organization name the repository will be transferred to. |  |
| **team_ids** | **Array&lt;Integer&gt;** | ID of the team or teams to add to the repository. Teams can only be added to organization-owned repositories. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ReposTransferRequest.new(
  new_owner: null,
  team_ids: null
)
```

