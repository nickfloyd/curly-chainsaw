# Org.OpenAPITools.Model.CodespacesCreateWithPrForAuthenticatedUserRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Location** | **string** | Location for this codespace. Assigned by IP if not provided | [optional] 
**ClientIp** | **string** | IP for location auto-detection when proxying a request | [optional] 
**Machine** | **string** | Machine type to use for this codespace | [optional] 
**DevcontainerPath** | **string** | Path to devcontainer.json config to use for this codespace | [optional] 
**MultiRepoPermissionsOptOut** | **bool?** | Whether to authorize requested permissions from devcontainer.json | [optional] 
**WorkingDirectory** | **string** | Working directory for this codespace | [optional] 
**IdleTimeoutMinutes** | **int?** | Time in minutes before codespace stops from inactivity | [optional] 
**DisplayName** | **string** | Display name for this codespace | [optional] 
**RetentionPeriodMinutes** | **int?** | Duration in minutes after codespace has gone idle in which it will be deleted. Must be integer minutes between 0 and 43200 (30 days). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

