# OpenapiClient::CodeScanningUploadSarifRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **commit_sha** | **String** | The SHA of the commit to which the analysis you are uploading relates. |  |
| **ref** | **String** | The full Git reference, formatted as &#x60;refs/heads/&lt;branch name&gt;&#x60;, &#x60;refs/pull/&lt;number&gt;/merge&#x60;, or &#x60;refs/pull/&lt;number&gt;/head&#x60;. |  |
| **sarif** | **String** | A Base64 string representing the SARIF file to upload. You must first compress your SARIF file using [&#x60;gzip&#x60;](http://www.gnu.org/software/gzip/manual/gzip.html) and then translate the contents of the file into a Base64 encoding string. For more information, see \&quot;[SARIF support for code scanning](https://docs.github.com/code-security/secure-coding/sarif-support-for-code-scanning).\&quot; |  |
| **checkout_uri** | **String** | The base directory used in the analysis, as it appears in the SARIF file. This property is used to convert file paths from absolute to relative, so that alerts can be mapped to their correct location in the repository. | [optional] |
| **started_at** | **Time** | The time that the analysis run began. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] |
| **tool_name** | **String** | The name of the tool used to generate the code scanning analysis. If this parameter is not used, the tool name defaults to \&quot;API\&quot;. If the uploaded SARIF contains a tool GUID, this will be available for filtering using the &#x60;tool_guid&#x60; parameter of operations such as &#x60;GET /repos/{owner}/{repo}/code-scanning/alerts&#x60;. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::CodeScanningUploadSarifRequest.new(
  commit_sha: null,
  ref: null,
  sarif: null,
  checkout_uri: file:///github/workspace/,
  started_at: null,
  tool_name: null
)
```

