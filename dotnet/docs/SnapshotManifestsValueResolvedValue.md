# Org.OpenAPITools.Model.SnapshotManifestsValueResolvedValue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PackageUrl** | **string** | Package-url (PURL) of dependency. See https://github.com/package-url/purl-spec for more details. | [optional] 
**Metadata** | [**Dictionary<string, Metadata>**](Metadata.md) | User-defined metadata to store domain-specific information limited to 8 keys with scalar values. | [optional] 
**Relationship** | **string** | A notation of whether a dependency is requested directly by this manifest or is a dependency of another dependency. | [optional] 
**Scope** | **string** | A notation of whether the dependency is required for the primary build artifact (runtime) or is only used for development. Future versions of this specification may allow for more granular scopes. | [optional] 
**Dependencies** | **List<string>** | Array of package-url (PURLs) of direct child dependencies. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

