# Org.OpenAPITools.Model.Codespace

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | 
**Name** | **string** | Automatically generated name of this codespace. | 
**DisplayName** | **string** | Display name for this codespace. | [optional] 
**EnvironmentId** | **string** | UUID identifying this codespace&#39;s environment. | 
**Owner** | [**SimpleUser1**](SimpleUser1.md) |  | 
**BillableOwner** | [**SimpleUser1**](SimpleUser1.md) |  | 
**Repository** | [**MinimalRepository**](MinimalRepository.md) |  | 
**Machine** | [**CodespaceMachine**](CodespaceMachine.md) |  | 
**DevcontainerPath** | **string** | Path to devcontainer.json from repo root used to create Codespace. | [optional] 
**Prebuild** | **bool?** | Whether the codespace was created from a prebuild. | 
**CreatedAt** | **DateTime?** |  | 
**UpdatedAt** | **DateTime?** |  | 
**LastUsedAt** | **DateTime?** | Last known time this codespace was started. | 
**State** | **string** | State of this codespace. | 
**Url** | **string** | API URL for this codespace. | 
**GitStatus** | [**CodespaceGitStatus**](CodespaceGitStatus.md) |  | 
**Location** | **string** | The Azure region where this codespace is located. | 
**IdleTimeoutMinutes** | **int?** | The number of minutes of inactivity after which this codespace will be automatically stopped. | 
**WebUrl** | **string** | URL to access this codespace on the web. | 
**MachinesUrl** | **string** | API URL to access available alternate machine types for this codespace. | 
**StartUrl** | **string** | API URL to start this codespace. | 
**StopUrl** | **string** | API URL to stop this codespace. | 
**PullsUrl** | **string** | API URL for the Pull Request associated with this codespace, if any. | 
**RecentFolders** | **List<string>** |  | 
**RuntimeConstraints** | [**CodespaceRuntimeConstraints**](CodespaceRuntimeConstraints.md) |  | [optional] 
**PendingOperation** | **bool?** | Whether or not a codespace has a pending async operation. This would mean that the codespace is temporarily unavailable. The only thing that you can do with a codespace in this state is delete it. | [optional] 
**PendingOperationDisabledReason** | **string** | Text to show user when codespace is disabled by a pending operation | [optional] 
**IdleTimeoutNotice** | **string** | Text to show user when codespace idle timeout minutes has been overriden by an organization policy | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

