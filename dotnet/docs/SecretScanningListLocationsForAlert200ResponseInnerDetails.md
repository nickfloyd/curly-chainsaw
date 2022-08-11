# Org.OpenAPITools.Model.SecretScanningListLocationsForAlert200ResponseInnerDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | The file path in the repository | 
**StartLine** | **decimal?** | Line number at which the secret starts in the file | 
**EndLine** | **decimal?** | Line number at which the secret ends in the file | 
**StartColumn** | **decimal?** | The column at which the secret starts within the start line when the file is interpreted as 8BIT ASCII | 
**EndColumn** | **decimal?** | The column at which the secret ends within the end line when the file is interpreted as 8BIT ASCII | 
**BlobSha** | **string** | SHA-1 hash ID of the associated blob | 
**BlobUrl** | **string** | The API URL to get the associated blob resource | 
**CommitSha** | **string** | SHA-1 hash ID of the associated commit | 
**CommitUrl** | **string** | The API URL to get the associated commit resource | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

