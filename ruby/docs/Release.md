# OpenapiClient::Release

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **url** | **String** |  |  |
| **html_url** | **String** |  |  |
| **assets_url** | **String** |  |  |
| **upload_url** | **String** |  |  |
| **tarball_url** | **String** |  |  |
| **zipball_url** | **String** |  |  |
| **id** | **Integer** |  |  |
| **node_id** | **String** |  |  |
| **tag_name** | **String** | The name of the tag. |  |
| **target_commitish** | **String** | Specifies the commitish value that determines where the Git tag is created from. |  |
| **name** | **String** |  |  |
| **body** | **String** |  | [optional] |
| **draft** | **Boolean** | true to create a draft (unpublished) release, false to create a published one. |  |
| **prerelease** | **Boolean** | Whether to identify the release as a prerelease or a full release. |  |
| **created_at** | **Time** |  |  |
| **published_at** | **Time** |  |  |
| **author** | [**SimpleUser1**](SimpleUser1.md) |  |  |
| **assets** | [**Array&lt;ReleaseAsset&gt;**](ReleaseAsset.md) |  |  |
| **body_html** | **String** |  | [optional] |
| **body_text** | **String** |  | [optional] |
| **mentions_count** | **Integer** |  | [optional] |
| **discussion_url** | **String** | The URL of the release discussion. | [optional] |
| **reactions** | [**ReactionRollup**](ReactionRollup.md) |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::Release.new(
  url: null,
  html_url: null,
  assets_url: null,
  upload_url: null,
  tarball_url: null,
  zipball_url: null,
  id: null,
  node_id: null,
  tag_name: v1.0.0,
  target_commitish: master,
  name: null,
  body: null,
  draft: false,
  prerelease: false,
  created_at: null,
  published_at: null,
  author: null,
  assets: null,
  body_html: null,
  body_text: null,
  mentions_count: null,
  discussion_url: null,
  reactions: null
)
```

