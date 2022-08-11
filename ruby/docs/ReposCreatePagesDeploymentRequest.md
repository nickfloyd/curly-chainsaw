# OpenapiClient::ReposCreatePagesDeploymentRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **artifact_url** | **String** | The URL of an artifact that contains the .zip or .tar of static assets to deploy. The artifact belongs to the repository. |  |
| **environment** | **String** | The target environment for this GitHub Pages deployment. | [optional][default to &#39;github-pages&#39;] |
| **pages_build_version** | **String** | A unique string that represents the version of the build for this deployment. | [default to &#39;GITHUB_SHA&#39;] |
| **oidc_token** | **String** | The OIDC token issued by GitHub Actions certifying the origin of the deployment. |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ReposCreatePagesDeploymentRequest.new(
  artifact_url: null,
  environment: null,
  pages_build_version: null,
  oidc_token: null
)
```

