# OpenapiClient::BillingGetGithubActionsBillingGhe200Response

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **total_minutes_used** | **Integer** | The sum of the free and paid GitHub Actions minutes used. |  |
| **total_paid_minutes_used** | **Integer** | The total paid GitHub Actions minutes used. |  |
| **included_minutes** | **Integer** | The amount of free GitHub Actions minutes available. |  |
| **minutes_used_breakdown** | [**BillingGetGithubActionsBillingGhe200ResponseMinutesUsedBreakdown**](BillingGetGithubActionsBillingGhe200ResponseMinutesUsedBreakdown.md) |  |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::BillingGetGithubActionsBillingGhe200Response.new(
  total_minutes_used: null,
  total_paid_minutes_used: null,
  included_minutes: null,
  minutes_used_breakdown: null
)
```

