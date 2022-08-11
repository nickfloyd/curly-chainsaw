# Org.OpenAPITools.Model.GitHubPages

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | The API address for accessing this Page resource. | 
**Status** | **string** | The status of the most recent build of the Page. | 
**Cname** | **string** | The Pages site&#39;s custom domain | 
**ProtectedDomainState** | **string** | The state if the domain is verified | [optional] 
**PendingDomainUnverifiedAt** | **DateTime?** | The timestamp when a pending domain becomes unverified. | [optional] 
**Custom404** | **bool?** | Whether the Page has a custom 404 page. | [default to false]
**HtmlUrl** | **string** | The web address the Page can be accessed from. | [optional] 
**BuildType** | **string** | The process in which the Page will be built. | [optional] 
**Source** | [**PagesSourceHash**](PagesSourceHash.md) |  | [optional] 
**Public** | **bool?** | Whether the GitHub Pages site is publicly visible. If set to &#x60;true&#x60;, the site is accessible to anyone on the internet. If set to &#x60;false&#x60;, the site will only be accessible to users who have at least &#x60;read&#x60; access to the repository that published the site. | 
**HttpsCertificate** | [**PagesHttpsCertificate**](PagesHttpsCertificate.md) |  | [optional] 
**HttpsEnforced** | **bool?** | Whether https is enabled on the domain | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

