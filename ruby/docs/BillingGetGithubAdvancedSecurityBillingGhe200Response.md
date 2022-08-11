# OpenapiClient::BillingGetGithubAdvancedSecurityBillingGhe200Response

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **total_advanced_security_committers** | **Integer** |  | [optional] |
| **total_count** | **Integer** |  | [optional] |
| **repositories** | [**Array&lt;BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInner&gt;**](BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInner.md) |  |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::BillingGetGithubAdvancedSecurityBillingGhe200Response.new(
  total_advanced_security_committers: 25,
  total_count: 2,
  repositories: null
)
```

