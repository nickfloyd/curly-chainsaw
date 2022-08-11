# Org.OpenAPITools.Model.CodeScanningGetSarif200Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProcessingStatus** | **string** | &#x60;pending&#x60; files have not yet been processed, while &#x60;complete&#x60; means results from the SARIF have been stored. &#x60;failed&#x60; files have either not been processed at all, or could only be partially processed. | [optional] 
**AnalysesUrl** | **string** | The REST API URL for getting the analyses associated with the upload. | [optional] [readonly] 
**Errors** | **List<string>** | Any errors that ocurred during processing of the delivery. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

