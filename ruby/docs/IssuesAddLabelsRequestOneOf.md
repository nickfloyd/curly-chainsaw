# OpenapiClient::IssuesAddLabelsRequestOneOf

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **labels** | **Array&lt;String&gt;** | The names of the labels to add to the issue&#39;s existing labels. You can pass an empty array to remove all labels. Alternatively, you can pass a single label as a &#x60;string&#x60; or an &#x60;array&#x60; of labels directly, but GitHub recommends passing an object with the &#x60;labels&#x60; key. You can also replace all of the labels for an issue. For more information, see \&quot;[Set labels for an issue](https://docs.github.com/rest/reference/issues#set-labels-for-an-issue).\&quot; | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::IssuesAddLabelsRequestOneOf.new(
  labels: null
)
```

