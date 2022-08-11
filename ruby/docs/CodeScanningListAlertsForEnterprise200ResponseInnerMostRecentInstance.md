# OpenapiClient::CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **ref** | **String** | The full Git reference, formatted as &#x60;refs/heads/&lt;branch name&gt;&#x60;, &#x60;refs/pull/&lt;number&gt;/merge&#x60;, or &#x60;refs/pull/&lt;number&gt;/head&#x60;. | [optional] |
| **analysis_key** | **String** | Identifies the configuration under which the analysis was executed. For example, in GitHub Actions this includes the workflow filename and job name. | [optional] |
| **environment** | **String** | Identifies the variable values associated with the environment in which the analysis that generated this alert instance was performed, such as the language that was analyzed. | [optional] |
| **category** | **String** | Identifies the configuration under which the analysis was executed. Used to distinguish between multiple analyses for the same tool and commit, but performed on different languages or different parts of the code. | [optional] |
| **state** | **String** | State of a code scanning alert. | [optional] |
| **commit_sha** | **String** |  | [optional] |
| **message** | [**CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstanceMessage**](CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstanceMessage.md) |  | [optional] |
| **location** | [**CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstanceLocation**](CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstanceLocation.md) |  | [optional] |
| **html_url** | **String** |  | [optional] |
| **classifications** | **Array&lt;String&gt;** | Classifications that have been applied to the file that triggered the alert. For example identifying it as documentation, or a generated file. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance.new(
  ref: null,
  analysis_key: null,
  environment: null,
  category: null,
  state: null,
  commit_sha: null,
  message: null,
  location: null,
  html_url: null,
  classifications: null
)
```

