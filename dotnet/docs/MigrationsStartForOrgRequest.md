# Org.OpenAPITools.Model.MigrationsStartForOrgRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Repositories** | **List<string>** | A list of arrays indicating which repositories should be migrated. | 
**LockRepositories** | **bool?** | Indicates whether repositories should be locked (to prevent manipulation) while migrating data. | [optional] [default to false]
**ExcludeMetadata** | **bool?** | Indicates whether metadata should be excluded and only git source should be included for the migration. | [optional] [default to false]
**ExcludeGitData** | **bool?** | Indicates whether the repository git data should be excluded from the migration. | [optional] [default to false]
**ExcludeAttachments** | **bool?** | Indicates whether attachments should be excluded from the migration (to reduce migration archive file size). | [optional] [default to false]
**ExcludeReleases** | **bool?** | Indicates whether releases should be excluded from the migration (to reduce migration archive file size). | [optional] [default to false]
**ExcludeOwnerProjects** | **bool?** | Indicates whether projects owned by the organization or users should be excluded. from the migration. | [optional] [default to false]
**OrgMetadataOnly** | **bool?** | Indicates whether this should only include organization metadata (repositories array should be empty and will ignore other flags). | [optional] [default to false]
**Exclude** | **List<string>** | Exclude related items from being returned in the response in order to improve performance of the request. The array can include any of: &#x60;\&quot;repositories\&quot;&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

