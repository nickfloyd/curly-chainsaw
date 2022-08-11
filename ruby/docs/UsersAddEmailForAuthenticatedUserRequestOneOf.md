# OpenapiClient::UsersAddEmailForAuthenticatedUserRequestOneOf

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **emails** | **Array&lt;String&gt;** | Adds one or more email addresses to your GitHub account. Must contain at least one email address. **Note:** Alternatively, you can pass a single email address or an &#x60;array&#x60; of emails addresses directly, but we recommend that you pass an object using the &#x60;emails&#x60; key. |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::UsersAddEmailForAuthenticatedUserRequestOneOf.new(
  emails: []
)
```

