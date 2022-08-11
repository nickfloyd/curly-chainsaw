# OpenapiClient::PullsCreateReviewRequestCommentsInner

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **path** | **String** | The relative path to the file that necessitates a review comment. |  |
| **position** | **Integer** | The position in the diff where you want to add a review comment. Note this value is not the same as the line number in the file. For help finding the position value, read the note below. | [optional] |
| **body** | **String** | Text of the review comment. |  |
| **line** | **Integer** |  | [optional] |
| **side** | **String** |  | [optional] |
| **start_line** | **Integer** |  | [optional] |
| **start_side** | **String** |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::PullsCreateReviewRequestCommentsInner.new(
  path: null,
  position: null,
  body: null,
  line: 28,
  side: RIGHT,
  start_line: 26,
  start_side: LEFT
)
```

