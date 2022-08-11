# Org.OpenAPITools.Model.ReposCreatePagesDeploymentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArtifactUrl** | **string** | The URL of an artifact that contains the .zip or .tar of static assets to deploy. The artifact belongs to the repository. | 
**Environment** | **string** | The target environment for this GitHub Pages deployment. | [optional] [default to "github-pages"]
**PagesBuildVersion** | **string** | A unique string that represents the version of the build for this deployment. | [default to "GITHUB_SHA"]
**OidcToken** | **string** | The OIDC token issued by GitHub Actions certifying the origin of the deployment. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

