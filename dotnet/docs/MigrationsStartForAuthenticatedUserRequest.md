# Org.OpenAPITools.Model.MigrationsStartForAuthenticatedUserRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LockRepositories** | **bool?** | Lock the repositories being migrated at the start of the migration | [optional] 
**ExcludeMetadata** | **bool?** | Indicates whether metadata should be excluded and only git source should be included for the migration. | [optional] 
**ExcludeGitData** | **bool?** | Indicates whether the repository git data should be excluded from the migration. | [optional] 
**ExcludeAttachments** | **bool?** | Do not include attachments in the migration | [optional] 
**ExcludeReleases** | **bool?** | Do not include releases in the migration | [optional] 
**ExcludeOwnerProjects** | **bool?** | Indicates whether projects owned by the organization or users should be excluded. | [optional] 
**OrgMetadataOnly** | **bool?** | Indicates whether this should only include organization metadata (repositories array should be empty and will ignore other flags). | [optional] [default to false]
**Exclude** | **List<string>** | Exclude attributes from the API response to improve performance | [optional] 
**Repositories** | **List<string>** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

