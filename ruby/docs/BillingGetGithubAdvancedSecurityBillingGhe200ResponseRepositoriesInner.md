# OpenapiClient::BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInner

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **name** | **String** |  |  |
| **advanced_security_committers** | **Integer** |  |  |
| **advanced_security_committers_breakdown** | [**Array&lt;BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInnerAdvancedSecurityCommittersBreakdownInner&gt;**](BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInnerAdvancedSecurityCommittersBreakdownInner.md) |  |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInner.new(
  name: octocat/Hello-World,
  advanced_security_committers: 25,
  advanced_security_committers_breakdown: null
)
```

