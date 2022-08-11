# Org.OpenAPITools.Api.MigrationsApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MigrationsCancelImport**](MigrationsApi.md#migrationscancelimport) | **DELETE** /repos/{owner}/{repo}/import | Cancel an import
[**MigrationsDeleteArchiveForAuthenticatedUser**](MigrationsApi.md#migrationsdeletearchiveforauthenticateduser) | **DELETE** /user/migrations/{migration_id}/archive | Delete a user migration archive
[**MigrationsDeleteArchiveForOrg**](MigrationsApi.md#migrationsdeletearchivefororg) | **DELETE** /orgs/{org}/migrations/{migration_id}/archive | Delete an organization migration archive
[**MigrationsDownloadArchiveForOrg**](MigrationsApi.md#migrationsdownloadarchivefororg) | **GET** /orgs/{org}/migrations/{migration_id}/archive | Download an organization migration archive
[**MigrationsGetArchiveForAuthenticatedUser**](MigrationsApi.md#migrationsgetarchiveforauthenticateduser) | **GET** /user/migrations/{migration_id}/archive | Download a user migration archive
[**MigrationsGetCommitAuthors**](MigrationsApi.md#migrationsgetcommitauthors) | **GET** /repos/{owner}/{repo}/import/authors | Get commit authors
[**MigrationsGetImportStatus**](MigrationsApi.md#migrationsgetimportstatus) | **GET** /repos/{owner}/{repo}/import | Get an import status
[**MigrationsGetLargeFiles**](MigrationsApi.md#migrationsgetlargefiles) | **GET** /repos/{owner}/{repo}/import/large_files | Get large files
[**MigrationsGetStatusForAuthenticatedUser**](MigrationsApi.md#migrationsgetstatusforauthenticateduser) | **GET** /user/migrations/{migration_id} | Get a user migration status
[**MigrationsGetStatusForOrg**](MigrationsApi.md#migrationsgetstatusfororg) | **GET** /orgs/{org}/migrations/{migration_id} | Get an organization migration status
[**MigrationsListForAuthenticatedUser**](MigrationsApi.md#migrationslistforauthenticateduser) | **GET** /user/migrations | List user migrations
[**MigrationsListForOrg**](MigrationsApi.md#migrationslistfororg) | **GET** /orgs/{org}/migrations | List organization migrations
[**MigrationsListReposForAuthenticatedUser**](MigrationsApi.md#migrationslistreposforauthenticateduser) | **GET** /user/migrations/{migration_id}/repositories | List repositories for a user migration
[**MigrationsListReposForOrg**](MigrationsApi.md#migrationslistreposfororg) | **GET** /orgs/{org}/migrations/{migration_id}/repositories | List repositories in an organization migration
[**MigrationsMapCommitAuthor**](MigrationsApi.md#migrationsmapcommitauthor) | **PATCH** /repos/{owner}/{repo}/import/authors/{author_id} | Map a commit author
[**MigrationsSetLfsPreference**](MigrationsApi.md#migrationssetlfspreference) | **PATCH** /repos/{owner}/{repo}/import/lfs | Update Git LFS preference
[**MigrationsStartForAuthenticatedUser**](MigrationsApi.md#migrationsstartforauthenticateduser) | **POST** /user/migrations | Start a user migration
[**MigrationsStartForOrg**](MigrationsApi.md#migrationsstartfororg) | **POST** /orgs/{org}/migrations | Start an organization migration
[**MigrationsStartImport**](MigrationsApi.md#migrationsstartimport) | **PUT** /repos/{owner}/{repo}/import | Start an import
[**MigrationsUnlockRepoForAuthenticatedUser**](MigrationsApi.md#migrationsunlockrepoforauthenticateduser) | **DELETE** /user/migrations/{migration_id}/repos/{repo_name}/lock | Unlock a user repository
[**MigrationsUnlockRepoForOrg**](MigrationsApi.md#migrationsunlockrepofororg) | **DELETE** /orgs/{org}/migrations/{migration_id}/repos/{repo_name}/lock | Unlock an organization repository
[**MigrationsUpdateImport**](MigrationsApi.md#migrationsupdateimport) | **PATCH** /repos/{owner}/{repo}/import | Update an import


<a name="migrationscancelimport"></a>
# **MigrationsCancelImport**
> void MigrationsCancelImport (string owner, string repo)

Cancel an import

Stop an import for a repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrationsCancelImportExample
    {
        public void main()
        {
            var apiInstance = new MigrationsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Cancel an import
                apiInstance.MigrationsCancelImport(owner, repo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationsApi.MigrationsCancelImport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migrationsdeletearchiveforauthenticateduser"></a>
# **MigrationsDeleteArchiveForAuthenticatedUser**
> void MigrationsDeleteArchiveForAuthenticatedUser (int? migrationId)

Delete a user migration archive

Deletes a previous migration archive. Downloadable migration archives are automatically deleted after seven days. Migration metadata, which is returned in the [List user migrations](https://docs.github.com/rest/reference/migrations#list-user-migrations) and [Get a user migration status](https://docs.github.com/rest/reference/migrations#get-a-user-migration-status) endpoints, will continue to be available even after an archive is deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrationsDeleteArchiveForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new MigrationsApi();
            var migrationId = 56;  // int? | The unique identifier of the migration.

            try
            {
                // Delete a user migration archive
                apiInstance.MigrationsDeleteArchiveForAuthenticatedUser(migrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationsApi.MigrationsDeleteArchiveForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **migrationId** | **int?**| The unique identifier of the migration. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migrationsdeletearchivefororg"></a>
# **MigrationsDeleteArchiveForOrg**
> void MigrationsDeleteArchiveForOrg (string org, int? migrationId)

Delete an organization migration archive

Deletes a previous migration archive. Migration archives are automatically deleted after seven days.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrationsDeleteArchiveForOrgExample
    {
        public void main()
        {
            var apiInstance = new MigrationsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var migrationId = 56;  // int? | The unique identifier of the migration.

            try
            {
                // Delete an organization migration archive
                apiInstance.MigrationsDeleteArchiveForOrg(org, migrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationsApi.MigrationsDeleteArchiveForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **migrationId** | **int?**| The unique identifier of the migration. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migrationsdownloadarchivefororg"></a>
# **MigrationsDownloadArchiveForOrg**
> void MigrationsDownloadArchiveForOrg (string org, int? migrationId)

Download an organization migration archive

Fetches the URL to a migration archive.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrationsDownloadArchiveForOrgExample
    {
        public void main()
        {
            var apiInstance = new MigrationsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var migrationId = 56;  // int? | The unique identifier of the migration.

            try
            {
                // Download an organization migration archive
                apiInstance.MigrationsDownloadArchiveForOrg(org, migrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationsApi.MigrationsDownloadArchiveForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **migrationId** | **int?**| The unique identifier of the migration. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migrationsgetarchiveforauthenticateduser"></a>
# **MigrationsGetArchiveForAuthenticatedUser**
> void MigrationsGetArchiveForAuthenticatedUser (int? migrationId)

Download a user migration archive

Fetches the URL to download the migration archive as a `tar.gz` file. Depending on the resources your repository uses, the migration archive can contain JSON files with data for these objects:  *   attachments *   bases *   commit\\_comments *   issue\\_comments *   issue\\_events *   issues *   milestones *   organizations *   projects *   protected\\_branches *   pull\\_request\\_reviews *   pull\\_requests *   releases *   repositories *   review\\_comments *   schema *   users  The archive will also contain an `attachments` directory that includes all attachment files uploaded to GitHub.com and a `repositories` directory that contains the repository's Git data.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrationsGetArchiveForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new MigrationsApi();
            var migrationId = 56;  // int? | The unique identifier of the migration.

            try
            {
                // Download a user migration archive
                apiInstance.MigrationsGetArchiveForAuthenticatedUser(migrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationsApi.MigrationsGetArchiveForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **migrationId** | **int?**| The unique identifier of the migration. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migrationsgetcommitauthors"></a>
# **MigrationsGetCommitAuthors**
> List<PorterAuthor> MigrationsGetCommitAuthors (string owner, string repo, int? since)

Get commit authors

Each type of source control system represents authors in a different way. For example, a Git commit author has a display name and an email address, but a Subversion commit author just has a username. The GitHub Importer will make the author information valid, but the author might not be correct. For example, it will change the bare Subversion username `hubot` into something like `hubot <hubot@12341234-abab-fefe-8787-fedcba987654>`.  This endpoint and the [Map a commit author](https://docs.github.com/rest/reference/migrations#map-a-commit-author) endpoint allow you to provide correct Git author information.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrationsGetCommitAuthorsExample
    {
        public void main()
        {
            var apiInstance = new MigrationsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var since = 56;  // int? | A user ID. Only return users with an ID greater than this ID. (optional) 

            try
            {
                // Get commit authors
                List&lt;PorterAuthor&gt; result = apiInstance.MigrationsGetCommitAuthors(owner, repo, since);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationsApi.MigrationsGetCommitAuthors: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **since** | **int?**| A user ID. Only return users with an ID greater than this ID. | [optional] 

### Return type

[**List<PorterAuthor>**](PorterAuthor.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migrationsgetimportstatus"></a>
# **MigrationsGetImportStatus**
> Import MigrationsGetImportStatus (string owner, string repo)

Get an import status

View the progress of an import.  **Import status**  This section includes details about the possible values of the `status` field of the Import Progress response.  An import that does not have errors will progress through these steps:  *   `detecting` - the \"detection\" step of the import is in progress because the request did not include a `vcs` parameter. The import is identifying the type of source control present at the URL. *   `importing` - the \"raw\" step of the import is in progress. This is where commit data is fetched from the original repository. The import progress response will include `commit_count` (the total number of raw commits that will be imported) and `percent` (0 - 100, the current progress through the import). *   `mapping` - the \"rewrite\" step of the import is in progress. This is where SVN branches are converted to Git branches, and where author updates are applied. The import progress response does not include progress information. *   `pushing` - the \"push\" step of the import is in progress. This is where the importer updates the repository on GitHub. The import progress response will include `push_percent`, which is the percent value reported by `git push` when it is \"Writing objects\". *   `complete` - the import is complete, and the repository is ready on GitHub.  If there are problems, you will see one of these in the `status` field:  *   `auth_failed` - the import requires authentication in order to connect to the original repository. To update authentication for the import, please see the [Update an import](https://docs.github.com/rest/reference/migrations#update-an-import) section. *   `error` - the import encountered an error. The import progress response will include the `failed_step` and an error message. Contact [GitHub Support](https://support.github.com/contact?tags=dotcom-rest-api) for more information. *   `detection_needs_auth` - the importer requires authentication for the originating repository to continue detection. To update authentication for the import, please see the [Update an import](https://docs.github.com/rest/reference/migrations#update-an-import) section. *   `detection_found_nothing` - the importer didn't recognize any source control at the URL. To resolve, [Cancel the import](https://docs.github.com/rest/reference/migrations#cancel-an-import) and [retry](https://docs.github.com/rest/reference/migrations#start-an-import) with the correct URL. *   `detection_found_multiple` - the importer found several projects or repositories at the provided URL. When this is the case, the Import Progress response will also include a `project_choices` field with the possible project choices as values. To update project choice, please see the [Update an import](https://docs.github.com/rest/reference/migrations#update-an-import) section.  **The project_choices field**  When multiple projects are found at the provided URL, the response hash will include a `project_choices` field, the value of which is an array of hashes each representing a project choice. The exact key/value pairs of the project hashes will differ depending on the version control type.  **Git LFS related fields**  This section includes details about Git LFS related fields that may be present in the Import Progress response.  *   `use_lfs` - describes whether the import has been opted in or out of using Git LFS. The value can be `opt_in`, `opt_out`, or `undecided` if no action has been taken. *   `has_large_files` - the boolean value describing whether files larger than 100MB were found during the `importing` step. *   `large_files_size` - the total size in gigabytes of files larger than 100MB found in the originating repository. *   `large_files_count` - the total number of files larger than 100MB found in the originating repository. To see a list of these files, make a \"Get Large Files\" request.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrationsGetImportStatusExample
    {
        public void main()
        {
            var apiInstance = new MigrationsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get an import status
                Import result = apiInstance.MigrationsGetImportStatus(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationsApi.MigrationsGetImportStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 

### Return type

[**Import**](Import.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migrationsgetlargefiles"></a>
# **MigrationsGetLargeFiles**
> List<PorterLargeFile> MigrationsGetLargeFiles (string owner, string repo)

Get large files

List files larger than 100MB found during the import

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrationsGetLargeFilesExample
    {
        public void main()
        {
            var apiInstance = new MigrationsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get large files
                List&lt;PorterLargeFile&gt; result = apiInstance.MigrationsGetLargeFiles(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationsApi.MigrationsGetLargeFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 

### Return type

[**List<PorterLargeFile>**](PorterLargeFile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migrationsgetstatusforauthenticateduser"></a>
# **MigrationsGetStatusForAuthenticatedUser**
> Migration MigrationsGetStatusForAuthenticatedUser (int? migrationId, List<string> exclude)

Get a user migration status

Fetches a single user migration. The response includes the `state` of the migration, which can be one of the following values:  *   `pending` - the migration hasn't started yet. *   `exporting` - the migration is in progress. *   `exported` - the migration finished successfully. *   `failed` - the migration failed.  Once the migration has been `exported` you can [download the migration archive](https://docs.github.com/rest/reference/migrations#download-a-user-migration-archive).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrationsGetStatusForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new MigrationsApi();
            var migrationId = 56;  // int? | The unique identifier of the migration.
            var exclude = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Get a user migration status
                Migration result = apiInstance.MigrationsGetStatusForAuthenticatedUser(migrationId, exclude);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationsApi.MigrationsGetStatusForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **migrationId** | **int?**| The unique identifier of the migration. | 
 **exclude** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**Migration**](Migration.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migrationsgetstatusfororg"></a>
# **MigrationsGetStatusForOrg**
> Migration MigrationsGetStatusForOrg (string org, int? migrationId, List<string> exclude)

Get an organization migration status

Fetches the status of a migration.  The `state` of a migration can be one of the following values:  *   `pending`, which means the migration hasn't started yet. *   `exporting`, which means the migration is in progress. *   `exported`, which means the migration finished successfully. *   `failed`, which means the migration failed.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrationsGetStatusForOrgExample
    {
        public void main()
        {
            var apiInstance = new MigrationsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var migrationId = 56;  // int? | The unique identifier of the migration.
            var exclude = new List<string>(); // List<string> | Exclude attributes from the API response to improve performance (optional) 

            try
            {
                // Get an organization migration status
                Migration result = apiInstance.MigrationsGetStatusForOrg(org, migrationId, exclude);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationsApi.MigrationsGetStatusForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **migrationId** | **int?**| The unique identifier of the migration. | 
 **exclude** | [**List<string>**](string.md)| Exclude attributes from the API response to improve performance | [optional] 

### Return type

[**Migration**](Migration.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migrationslistforauthenticateduser"></a>
# **MigrationsListForAuthenticatedUser**
> List<Migration> MigrationsListForAuthenticatedUser (int? perPage, int? page)

List user migrations

Lists all migrations a user has started.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrationsListForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new MigrationsApi();
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List user migrations
                List&lt;Migration&gt; result = apiInstance.MigrationsListForAuthenticatedUser(perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationsApi.MigrationsListForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Migration>**](Migration.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migrationslistfororg"></a>
# **MigrationsListForOrg**
> List<Migration> MigrationsListForOrg (string org, int? perPage, int? page, List<string> exclude)

List organization migrations

Lists the most recent migrations.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrationsListForOrgExample
    {
        public void main()
        {
            var apiInstance = new MigrationsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var exclude = new List<string>(); // List<string> | Exclude attributes from the API response to improve performance (optional) 

            try
            {
                // List organization migrations
                List&lt;Migration&gt; result = apiInstance.MigrationsListForOrg(org, perPage, page, exclude);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationsApi.MigrationsListForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **exclude** | [**List<string>**](string.md)| Exclude attributes from the API response to improve performance | [optional] 

### Return type

[**List<Migration>**](Migration.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migrationslistreposforauthenticateduser"></a>
# **MigrationsListReposForAuthenticatedUser**
> List<MinimalRepository> MigrationsListReposForAuthenticatedUser (int? migrationId, int? perPage, int? page)

List repositories for a user migration

Lists all the repositories for this user migration.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrationsListReposForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new MigrationsApi();
            var migrationId = 56;  // int? | The unique identifier of the migration.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repositories for a user migration
                List&lt;MinimalRepository&gt; result = apiInstance.MigrationsListReposForAuthenticatedUser(migrationId, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationsApi.MigrationsListReposForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **migrationId** | **int?**| The unique identifier of the migration. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<MinimalRepository>**](MinimalRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migrationslistreposfororg"></a>
# **MigrationsListReposForOrg**
> List<MinimalRepository> MigrationsListReposForOrg (string org, int? migrationId, int? perPage, int? page)

List repositories in an organization migration

List all the repositories for this organization migration.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrationsListReposForOrgExample
    {
        public void main()
        {
            var apiInstance = new MigrationsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var migrationId = 56;  // int? | The unique identifier of the migration.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repositories in an organization migration
                List&lt;MinimalRepository&gt; result = apiInstance.MigrationsListReposForOrg(org, migrationId, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationsApi.MigrationsListReposForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **migrationId** | **int?**| The unique identifier of the migration. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<MinimalRepository>**](MinimalRepository.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migrationsmapcommitauthor"></a>
# **MigrationsMapCommitAuthor**
> PorterAuthor MigrationsMapCommitAuthor (string owner, string repo, int? authorId, MigrationsMapCommitAuthorRequest migrationsMapCommitAuthorRequest)

Map a commit author

Update an author's identity for the import. Your application can continue updating authors any time before you push new commits to the repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrationsMapCommitAuthorExample
    {
        public void main()
        {
            var apiInstance = new MigrationsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var authorId = 56;  // int? | 
            var migrationsMapCommitAuthorRequest = new MigrationsMapCommitAuthorRequest(); // MigrationsMapCommitAuthorRequest |  (optional) 

            try
            {
                // Map a commit author
                PorterAuthor result = apiInstance.MigrationsMapCommitAuthor(owner, repo, authorId, migrationsMapCommitAuthorRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationsApi.MigrationsMapCommitAuthor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **authorId** | **int?**|  | 
 **migrationsMapCommitAuthorRequest** | [**MigrationsMapCommitAuthorRequest**](MigrationsMapCommitAuthorRequest.md)|  | [optional] 

### Return type

[**PorterAuthor**](PorterAuthor.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migrationssetlfspreference"></a>
# **MigrationsSetLfsPreference**
> Import MigrationsSetLfsPreference (string owner, string repo, MigrationsSetLfsPreferenceRequest migrationsSetLfsPreferenceRequest)

Update Git LFS preference

You can import repositories from Subversion, Mercurial, and TFS that include files larger than 100MB. This ability is powered by [Git LFS](https://git-lfs.github.com). You can learn more about our LFS feature and working with large files [on our help site](https://docs.github.com/articles/versioning-large-files/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrationsSetLfsPreferenceExample
    {
        public void main()
        {
            var apiInstance = new MigrationsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var migrationsSetLfsPreferenceRequest = new MigrationsSetLfsPreferenceRequest(); // MigrationsSetLfsPreferenceRequest | 

            try
            {
                // Update Git LFS preference
                Import result = apiInstance.MigrationsSetLfsPreference(owner, repo, migrationsSetLfsPreferenceRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationsApi.MigrationsSetLfsPreference: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **migrationsSetLfsPreferenceRequest** | [**MigrationsSetLfsPreferenceRequest**](MigrationsSetLfsPreferenceRequest.md)|  | 

### Return type

[**Import**](Import.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migrationsstartforauthenticateduser"></a>
# **MigrationsStartForAuthenticatedUser**
> Migration MigrationsStartForAuthenticatedUser (MigrationsStartForAuthenticatedUserRequest migrationsStartForAuthenticatedUserRequest)

Start a user migration

Initiates the generation of a user migration archive.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrationsStartForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new MigrationsApi();
            var migrationsStartForAuthenticatedUserRequest = new MigrationsStartForAuthenticatedUserRequest(); // MigrationsStartForAuthenticatedUserRequest | 

            try
            {
                // Start a user migration
                Migration result = apiInstance.MigrationsStartForAuthenticatedUser(migrationsStartForAuthenticatedUserRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationsApi.MigrationsStartForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **migrationsStartForAuthenticatedUserRequest** | [**MigrationsStartForAuthenticatedUserRequest**](MigrationsStartForAuthenticatedUserRequest.md)|  | 

### Return type

[**Migration**](Migration.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migrationsstartfororg"></a>
# **MigrationsStartForOrg**
> Migration MigrationsStartForOrg (string org, MigrationsStartForOrgRequest migrationsStartForOrgRequest)

Start an organization migration

Initiates the generation of a migration archive.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrationsStartForOrgExample
    {
        public void main()
        {
            var apiInstance = new MigrationsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var migrationsStartForOrgRequest = new MigrationsStartForOrgRequest(); // MigrationsStartForOrgRequest | 

            try
            {
                // Start an organization migration
                Migration result = apiInstance.MigrationsStartForOrg(org, migrationsStartForOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationsApi.MigrationsStartForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **migrationsStartForOrgRequest** | [**MigrationsStartForOrgRequest**](MigrationsStartForOrgRequest.md)|  | 

### Return type

[**Migration**](Migration.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migrationsstartimport"></a>
# **MigrationsStartImport**
> Import MigrationsStartImport (string owner, string repo, MigrationsStartImportRequest migrationsStartImportRequest)

Start an import

Start a source import to a GitHub repository using GitHub Importer.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrationsStartImportExample
    {
        public void main()
        {
            var apiInstance = new MigrationsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var migrationsStartImportRequest = new MigrationsStartImportRequest(); // MigrationsStartImportRequest | 

            try
            {
                // Start an import
                Import result = apiInstance.MigrationsStartImport(owner, repo, migrationsStartImportRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationsApi.MigrationsStartImport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **migrationsStartImportRequest** | [**MigrationsStartImportRequest**](MigrationsStartImportRequest.md)|  | 

### Return type

[**Import**](Import.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migrationsunlockrepoforauthenticateduser"></a>
# **MigrationsUnlockRepoForAuthenticatedUser**
> void MigrationsUnlockRepoForAuthenticatedUser (int? migrationId, string repoName)

Unlock a user repository

Unlocks a repository. You can lock repositories when you [start a user migration](https://docs.github.com/rest/reference/migrations#start-a-user-migration). Once the migration is complete you can unlock each repository to begin using it again or [delete the repository](https://docs.github.com/rest/reference/repos#delete-a-repository) if you no longer need the source data. Returns a status of `404 Not Found` if the repository is not locked.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrationsUnlockRepoForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new MigrationsApi();
            var migrationId = 56;  // int? | The unique identifier of the migration.
            var repoName = "repoName_example";  // string | repo_name parameter

            try
            {
                // Unlock a user repository
                apiInstance.MigrationsUnlockRepoForAuthenticatedUser(migrationId, repoName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationsApi.MigrationsUnlockRepoForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **migrationId** | **int?**| The unique identifier of the migration. | 
 **repoName** | **string**| repo_name parameter | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migrationsunlockrepofororg"></a>
# **MigrationsUnlockRepoForOrg**
> void MigrationsUnlockRepoForOrg (string org, int? migrationId, string repoName)

Unlock an organization repository

Unlocks a repository that was locked for migration. You should unlock each migrated repository and [delete them](https://docs.github.com/rest/reference/repos#delete-a-repository) when the migration is complete and you no longer need the source data.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrationsUnlockRepoForOrgExample
    {
        public void main()
        {
            var apiInstance = new MigrationsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var migrationId = 56;  // int? | The unique identifier of the migration.
            var repoName = "repoName_example";  // string | repo_name parameter

            try
            {
                // Unlock an organization repository
                apiInstance.MigrationsUnlockRepoForOrg(org, migrationId, repoName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationsApi.MigrationsUnlockRepoForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **migrationId** | **int?**| The unique identifier of the migration. | 
 **repoName** | **string**| repo_name parameter | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migrationsupdateimport"></a>
# **MigrationsUpdateImport**
> Import MigrationsUpdateImport (string owner, string repo, MigrationsUpdateImportRequest migrationsUpdateImportRequest)

Update an import

An import can be updated with credentials or a project choice by passing in the appropriate parameters in this API request. If no parameters are provided, the import will be restarted.  Some servers (e.g. TFS servers) can have several projects at a single URL. In those cases the import progress will have the status `detection_found_multiple` and the Import Progress response will include a `project_choices` array. You can select the project to import by providing one of the objects in the `project_choices` array in the update request.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrationsUpdateImportExample
    {
        public void main()
        {
            var apiInstance = new MigrationsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var migrationsUpdateImportRequest = new MigrationsUpdateImportRequest(); // MigrationsUpdateImportRequest |  (optional) 

            try
            {
                // Update an import
                Import result = apiInstance.MigrationsUpdateImport(owner, repo, migrationsUpdateImportRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationsApi.MigrationsUpdateImport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **migrationsUpdateImportRequest** | [**MigrationsUpdateImportRequest**](MigrationsUpdateImportRequest.md)|  | [optional] 

### Return type

[**Import**](Import.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

