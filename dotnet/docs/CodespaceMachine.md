# Org.OpenAPITools.Model.CodespaceMachine

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the machine. | 
**DisplayName** | **string** | The display name of the machine includes cores, memory, and storage. | 
**OperatingSystem** | **string** | The operating system of the machine. | 
**StorageInBytes** | **int?** | How much storage is available to the codespace. | 
**MemoryInBytes** | **int?** | How much memory is available to the codespace. | 
**Cpus** | **int?** | How many cores are available to the codespace. | 
**PrebuildAvailability** | **string** | Whether a prebuild is currently available when creating a codespace for this machine and repository. If a branch was not specified as a ref, the default branch will be assumed. Value will be \&quot;null\&quot; if prebuilds are not supported or prebuild availability could not be determined. Value will be \&quot;none\&quot; if no prebuild is available. Latest values \&quot;ready\&quot; and \&quot;in_progress\&quot; indicate the prebuild availability status. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

