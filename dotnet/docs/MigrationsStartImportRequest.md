# Org.OpenAPITools.Model.MigrationsStartImportRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VcsUrl** | **string** | The URL of the originating repository. | 
**Vcs** | **string** | The originating VCS type. Without this parameter, the import job will take additional time to detect the VCS type before beginning the import. This detection step will be reflected in the response. | [optional] 
**VcsUsername** | **string** | If authentication is required, the username to provide to &#x60;vcs_url&#x60;. | [optional] 
**VcsPassword** | **string** | If authentication is required, the password to provide to &#x60;vcs_url&#x60;. | [optional] 
**TfvcProject** | **string** | For a tfvc import, the name of the project that is being imported. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

