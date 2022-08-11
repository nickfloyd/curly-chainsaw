# Org.OpenAPITools.Model.EnterpriseAdminGetAllowedActionsEnterprise200Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GithubOwnedAllowed** | **bool?** | Whether GitHub-owned actions are allowed. For example, this includes the actions in the &#x60;actions&#x60; organization. | [optional] 
**VerifiedAllowed** | **bool?** | Whether actions from GitHub Marketplace verified creators are allowed. Set to &#x60;true&#x60; to allow all actions by GitHub Marketplace verified creators. | [optional] 
**PatternsAllowed** | **List<string>** | Specifies a list of string-matching patterns to allow specific action(s) and reusable workflow(s). Wildcards, tags, and SHAs are allowed. For example, &#x60;monalisa/octocat@*&#x60;, &#x60;monalisa/octocat@v2&#x60;, &#x60;monalisa/_*&#x60;.\&quot; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

