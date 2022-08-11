# OpenapiClient::ReposUpdateInformationAboutPagesSiteRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **cname** | **String** | Specify a custom domain for the repository. Sending a &#x60;null&#x60; value will remove the custom domain. For more about custom domains, see \&quot;[Using a custom domain with GitHub Pages](https://docs.github.com/articles/using-a-custom-domain-with-github-pages/).\&quot; | [optional] |
| **https_enforced** | **Boolean** | Specify whether HTTPS should be enforced for the repository. | [optional] |
| **public** | **Boolean** | Configures access controls for the GitHub Pages site. If public is set to &#x60;true&#x60;, the site is accessible to anyone on the internet. If set to &#x60;false&#x60;, the site will only be accessible to users who have at least &#x60;read&#x60; access to the repository that published the site. This includes anyone in your Enterprise if the repository is set to &#x60;internal&#x60; visibility. This feature is only available to repositories in an organization on an Enterprise plan. | [optional] |
| **build_type** | **String** | The process by which the GitHub Pages site will be built. &#x60;workflow&#x60; means that the site is built by a custom GitHub Actions workflow. &#x60;legacy&#x60; means that the site is built by GitHub when changes are pushed to a specific branch. | [optional] |
| **source** | [**ReposUpdateInformationAboutPagesSiteRequestSource**](ReposUpdateInformationAboutPagesSiteRequestSource.md) |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ReposUpdateInformationAboutPagesSiteRequest.new(
  cname: null,
  https_enforced: null,
  public: null,
  build_type: null,
  source: null
)
```

