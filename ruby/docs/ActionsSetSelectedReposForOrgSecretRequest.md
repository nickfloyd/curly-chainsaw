# OpenapiClient::ActionsSetSelectedReposForOrgSecretRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **selected_repository_ids** | **Array&lt;Integer&gt;** | An array of repository ids that can access the organization secret. You can only provide a list of repository ids when the &#x60;visibility&#x60; is set to &#x60;selected&#x60;. You can add and remove individual repositories using the [Set selected repositories for an organization secret](https://docs.github.com/rest/reference/actions#set-selected-repositories-for-an-organization-secret) and [Remove selected repository from an organization secret](https://docs.github.com/rest/reference/actions#remove-selected-repository-from-an-organization-secret) endpoints. |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ActionsSetSelectedReposForOrgSecretRequest.new(
  selected_repository_ids: null
)
```

