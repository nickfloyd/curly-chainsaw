# Org.OpenAPITools.Model.Snapshot

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**_Version** | **int?** | The version of the repository snapshot submission. | 
**Job** | [**SnapshotJob**](SnapshotJob.md) |  | 
**Sha** | **string** | The commit SHA associated with this dependency snapshot. | 
**Ref** | **string** | The repository branch that triggered this snapshot. | 
**Detector** | [**SnapshotDetector**](SnapshotDetector.md) |  | 
**Metadata** | [**Dictionary<string, Metadata>**](Metadata.md) | User-defined metadata to store domain-specific information limited to 8 keys with scalar values. | [optional] 
**Manifests** | [**Dictionary<string, SnapshotManifestsValue>**](SnapshotManifestsValue.md) | A collection of package manifests | [optional] 
**Scanned** | **DateTime?** | The time at which the snapshot was scanned. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

