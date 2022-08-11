# OpenapiClient::FullRepositorySecurityAndAnalysis

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **advanced_security** | [**FullRepositorySecurityAndAnalysisAdvancedSecurity**](FullRepositorySecurityAndAnalysisAdvancedSecurity.md) |  | [optional] |
| **secret_scanning** | [**FullRepositorySecurityAndAnalysisAdvancedSecurity**](FullRepositorySecurityAndAnalysisAdvancedSecurity.md) |  | [optional] |
| **secret_scanning_push_protection** | [**FullRepositorySecurityAndAnalysisAdvancedSecurity**](FullRepositorySecurityAndAnalysisAdvancedSecurity.md) |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::FullRepositorySecurityAndAnalysis.new(
  advanced_security: null,
  secret_scanning: null,
  secret_scanning_push_protection: null
)
```

