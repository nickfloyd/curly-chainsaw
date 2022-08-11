# OpenapiClient::IssuesCreateLabelRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **name** | **String** | The name of the label. Emoji can be added to label names, using either native emoji or colon-style markup. For example, typing &#x60;:strawberry:&#x60; will render the emoji ![:strawberry:](https://github.githubassets.com/images/icons/emoji/unicode/1f353.png \&quot;:strawberry:\&quot;). For a full list of available emoji and codes, see \&quot;[Emoji cheat sheet](https://github.com/ikatyang/emoji-cheat-sheet).\&quot; |  |
| **color** | **String** | The [hexadecimal color code](http://www.color-hex.com/) for the label, without the leading &#x60;#&#x60;. | [optional] |
| **description** | **String** | A short description of the label. Must be 100 characters or fewer. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::IssuesCreateLabelRequest.new(
  name: null,
  color: null,
  description: null
)
```

