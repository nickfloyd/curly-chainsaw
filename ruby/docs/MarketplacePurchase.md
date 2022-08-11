# OpenapiClient::MarketplacePurchase

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **url** | **String** |  |  |
| **type** | **String** |  |  |
| **id** | **Integer** |  |  |
| **login** | **String** |  |  |
| **organization_billing_email** | **String** |  | [optional] |
| **email** | **String** |  | [optional] |
| **marketplace_pending_change** | [**MarketplacePurchaseMarketplacePendingChange**](MarketplacePurchaseMarketplacePendingChange.md) |  | [optional] |
| **marketplace_purchase** | [**MarketplacePurchaseMarketplacePurchase**](MarketplacePurchaseMarketplacePurchase.md) |  |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::MarketplacePurchase.new(
  url: null,
  type: null,
  id: null,
  login: null,
  organization_billing_email: null,
  email: null,
  marketplace_pending_change: null,
  marketplace_purchase: null
)
```

