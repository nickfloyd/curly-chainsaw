# OpenapiClient::GitCreateRefRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **ref** | **String** | The name of the fully qualified reference (ie: &#x60;refs/heads/master&#x60;). If it doesn&#39;t start with &#39;refs&#39; and have at least two slashes, it will be rejected. |  |
| **sha** | **String** | The SHA1 value for this reference. |  |
| **key** | **String** |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::GitCreateRefRequest.new(
  ref: null,
  sha: null,
  key: &quot;refs/heads/newbranch&quot;
)
```

