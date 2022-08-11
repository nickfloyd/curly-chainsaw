using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMigrationsApi
    {
        /// <summary>
        /// Cancel an import Stop an import for a repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        void MigrationsCancelImport (string owner, string repo);
        /// <summary>
        /// Delete a user migration archive Deletes a previous migration archive. Downloadable migration archives are automatically deleted after seven days. Migration metadata, which is returned in the [List user migrations](https://docs.github.com/rest/reference/migrations#list-user-migrations) and [Get a user migration status](https://docs.github.com/rest/reference/migrations#get-a-user-migration-status) endpoints, will continue to be available even after an archive is deleted.
        /// </summary>
        /// <param name="migrationId">The unique identifier of the migration.</param>
        /// <returns></returns>
        void MigrationsDeleteArchiveForAuthenticatedUser (int? migrationId);
        /// <summary>
        /// Delete an organization migration archive Deletes a previous migration archive. Migration archives are automatically deleted after seven days.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="migrationId">The unique identifier of the migration.</param>
        /// <returns></returns>
        void MigrationsDeleteArchiveForOrg (string org, int? migrationId);
        /// <summary>
        /// Download an organization migration archive Fetches the URL to a migration archive.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="migrationId">The unique identifier of the migration.</param>
        /// <returns></returns>
        void MigrationsDownloadArchiveForOrg (string org, int? migrationId);
        /// <summary>
        /// Download a user migration archive Fetches the URL to download the migration archive as a &#x60;tar.gz&#x60; file. Depending on the resources your repository uses, the migration archive can contain JSON files with data for these objects:  *   attachments *   bases *   commit\\_comments *   issue\\_comments *   issue\\_events *   issues *   milestones *   organizations *   projects *   protected\\_branches *   pull\\_request\\_reviews *   pull\\_requests *   releases *   repositories *   review\\_comments *   schema *   users  The archive will also contain an &#x60;attachments&#x60; directory that includes all attachment files uploaded to GitHub.com and a &#x60;repositories&#x60; directory that contains the repository&#39;s Git data.
        /// </summary>
        /// <param name="migrationId">The unique identifier of the migration.</param>
        /// <returns></returns>
        void MigrationsGetArchiveForAuthenticatedUser (int? migrationId);
        /// <summary>
        /// Get commit authors Each type of source control system represents authors in a different way. For example, a Git commit author has a display name and an email address, but a Subversion commit author just has a username. The GitHub Importer will make the author information valid, but the author might not be correct. For example, it will change the bare Subversion username &#x60;hubot&#x60; into something like &#x60;hubot &lt;hubot@12341234-abab-fefe-8787-fedcba987654&gt;&#x60;.  This endpoint and the [Map a commit author](https://docs.github.com/rest/reference/migrations#map-a-commit-author) endpoint allow you to provide correct Git author information.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="since">A user ID. Only return users with an ID greater than this ID.</param>
        /// <returns>List&lt;PorterAuthor&gt;</returns>
        List<PorterAuthor> MigrationsGetCommitAuthors (string owner, string repo, int? since);
        /// <summary>
        /// Get an import status View the progress of an import.  **Import status**  This section includes details about the possible values of the &#x60;status&#x60; field of the Import Progress response.  An import that does not have errors will progress through these steps:  *   &#x60;detecting&#x60; - the \&quot;detection\&quot; step of the import is in progress because the request did not include a &#x60;vcs&#x60; parameter. The import is identifying the type of source control present at the URL. *   &#x60;importing&#x60; - the \&quot;raw\&quot; step of the import is in progress. This is where commit data is fetched from the original repository. The import progress response will include &#x60;commit_count&#x60; (the total number of raw commits that will be imported) and &#x60;percent&#x60; (0 - 100, the current progress through the import). *   &#x60;mapping&#x60; - the \&quot;rewrite\&quot; step of the import is in progress. This is where SVN branches are converted to Git branches, and where author updates are applied. The import progress response does not include progress information. *   &#x60;pushing&#x60; - the \&quot;push\&quot; step of the import is in progress. This is where the importer updates the repository on GitHub. The import progress response will include &#x60;push_percent&#x60;, which is the percent value reported by &#x60;git push&#x60; when it is \&quot;Writing objects\&quot;. *   &#x60;complete&#x60; - the import is complete, and the repository is ready on GitHub.  If there are problems, you will see one of these in the &#x60;status&#x60; field:  *   &#x60;auth_failed&#x60; - the import requires authentication in order to connect to the original repository. To update authentication for the import, please see the [Update an import](https://docs.github.com/rest/reference/migrations#update-an-import) section. *   &#x60;error&#x60; - the import encountered an error. The import progress response will include the &#x60;failed_step&#x60; and an error message. Contact [GitHub Support](https://support.github.com/contact?tags&#x3D;dotcom-rest-api) for more information. *   &#x60;detection_needs_auth&#x60; - the importer requires authentication for the originating repository to continue detection. To update authentication for the import, please see the [Update an import](https://docs.github.com/rest/reference/migrations#update-an-import) section. *   &#x60;detection_found_nothing&#x60; - the importer didn&#39;t recognize any source control at the URL. To resolve, [Cancel the import](https://docs.github.com/rest/reference/migrations#cancel-an-import) and [retry](https://docs.github.com/rest/reference/migrations#start-an-import) with the correct URL. *   &#x60;detection_found_multiple&#x60; - the importer found several projects or repositories at the provided URL. When this is the case, the Import Progress response will also include a &#x60;project_choices&#x60; field with the possible project choices as values. To update project choice, please see the [Update an import](https://docs.github.com/rest/reference/migrations#update-an-import) section.  **The project_choices field**  When multiple projects are found at the provided URL, the response hash will include a &#x60;project_choices&#x60; field, the value of which is an array of hashes each representing a project choice. The exact key/value pairs of the project hashes will differ depending on the version control type.  **Git LFS related fields**  This section includes details about Git LFS related fields that may be present in the Import Progress response.  *   &#x60;use_lfs&#x60; - describes whether the import has been opted in or out of using Git LFS. The value can be &#x60;opt_in&#x60;, &#x60;opt_out&#x60;, or &#x60;undecided&#x60; if no action has been taken. *   &#x60;has_large_files&#x60; - the boolean value describing whether files larger than 100MB were found during the &#x60;importing&#x60; step. *   &#x60;large_files_size&#x60; - the total size in gigabytes of files larger than 100MB found in the originating repository. *   &#x60;large_files_count&#x60; - the total number of files larger than 100MB found in the originating repository. To see a list of these files, make a \&quot;Get Large Files\&quot; request.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>Import</returns>
        Import MigrationsGetImportStatus (string owner, string repo);
        /// <summary>
        /// Get large files List files larger than 100MB found during the import
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>List&lt;PorterLargeFile&gt;</returns>
        List<PorterLargeFile> MigrationsGetLargeFiles (string owner, string repo);
        /// <summary>
        /// Get a user migration status Fetches a single user migration. The response includes the &#x60;state&#x60; of the migration, which can be one of the following values:  *   &#x60;pending&#x60; - the migration hasn&#39;t started yet. *   &#x60;exporting&#x60; - the migration is in progress. *   &#x60;exported&#x60; - the migration finished successfully. *   &#x60;failed&#x60; - the migration failed.  Once the migration has been &#x60;exported&#x60; you can [download the migration archive](https://docs.github.com/rest/reference/migrations#download-a-user-migration-archive).
        /// </summary>
        /// <param name="migrationId">The unique identifier of the migration.</param>
        /// <param name="exclude"></param>
        /// <returns>Migration</returns>
        Migration MigrationsGetStatusForAuthenticatedUser (int? migrationId, List<string> exclude);
        /// <summary>
        /// Get an organization migration status Fetches the status of a migration.  The &#x60;state&#x60; of a migration can be one of the following values:  *   &#x60;pending&#x60;, which means the migration hasn&#39;t started yet. *   &#x60;exporting&#x60;, which means the migration is in progress. *   &#x60;exported&#x60;, which means the migration finished successfully. *   &#x60;failed&#x60;, which means the migration failed.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="migrationId">The unique identifier of the migration.</param>
        /// <param name="exclude">Exclude attributes from the API response to improve performance</param>
        /// <returns>Migration</returns>
        Migration MigrationsGetStatusForOrg (string org, int? migrationId, List<string> exclude);
        /// <summary>
        /// List user migrations Lists all migrations a user has started.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Migration&gt;</returns>
        List<Migration> MigrationsListForAuthenticatedUser (int? perPage, int? page);
        /// <summary>
        /// List organization migrations Lists the most recent migrations.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="exclude">Exclude attributes from the API response to improve performance</param>
        /// <returns>List&lt;Migration&gt;</returns>
        List<Migration> MigrationsListForOrg (string org, int? perPage, int? page, List<string> exclude);
        /// <summary>
        /// List repositories for a user migration Lists all the repositories for this user migration.
        /// </summary>
        /// <param name="migrationId">The unique identifier of the migration.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MinimalRepository&gt;</returns>
        List<MinimalRepository> MigrationsListReposForAuthenticatedUser (int? migrationId, int? perPage, int? page);
        /// <summary>
        /// List repositories in an organization migration List all the repositories for this organization migration.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="migrationId">The unique identifier of the migration.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MinimalRepository&gt;</returns>
        List<MinimalRepository> MigrationsListReposForOrg (string org, int? migrationId, int? perPage, int? page);
        /// <summary>
        /// Map a commit author Update an author&#39;s identity for the import. Your application can continue updating authors any time before you push new commits to the repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="authorId"></param>
        /// <param name="migrationsMapCommitAuthorRequest"></param>
        /// <returns>PorterAuthor</returns>
        PorterAuthor MigrationsMapCommitAuthor (string owner, string repo, int? authorId, MigrationsMapCommitAuthorRequest migrationsMapCommitAuthorRequest);
        /// <summary>
        /// Update Git LFS preference You can import repositories from Subversion, Mercurial, and TFS that include files larger than 100MB. This ability is powered by [Git LFS](https://git-lfs.github.com). You can learn more about our LFS feature and working with large files [on our help site](https://docs.github.com/articles/versioning-large-files/).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="migrationsSetLfsPreferenceRequest"></param>
        /// <returns>Import</returns>
        Import MigrationsSetLfsPreference (string owner, string repo, MigrationsSetLfsPreferenceRequest migrationsSetLfsPreferenceRequest);
        /// <summary>
        /// Start a user migration Initiates the generation of a user migration archive.
        /// </summary>
        /// <param name="migrationsStartForAuthenticatedUserRequest"></param>
        /// <returns>Migration</returns>
        Migration MigrationsStartForAuthenticatedUser (MigrationsStartForAuthenticatedUserRequest migrationsStartForAuthenticatedUserRequest);
        /// <summary>
        /// Start an organization migration Initiates the generation of a migration archive.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="migrationsStartForOrgRequest"></param>
        /// <returns>Migration</returns>
        Migration MigrationsStartForOrg (string org, MigrationsStartForOrgRequest migrationsStartForOrgRequest);
        /// <summary>
        /// Start an import Start a source import to a GitHub repository using GitHub Importer.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="migrationsStartImportRequest"></param>
        /// <returns>Import</returns>
        Import MigrationsStartImport (string owner, string repo, MigrationsStartImportRequest migrationsStartImportRequest);
        /// <summary>
        /// Unlock a user repository Unlocks a repository. You can lock repositories when you [start a user migration](https://docs.github.com/rest/reference/migrations#start-a-user-migration). Once the migration is complete you can unlock each repository to begin using it again or [delete the repository](https://docs.github.com/rest/reference/repos#delete-a-repository) if you no longer need the source data. Returns a status of &#x60;404 Not Found&#x60; if the repository is not locked.
        /// </summary>
        /// <param name="migrationId">The unique identifier of the migration.</param>
        /// <param name="repoName">repo_name parameter</param>
        /// <returns></returns>
        void MigrationsUnlockRepoForAuthenticatedUser (int? migrationId, string repoName);
        /// <summary>
        /// Unlock an organization repository Unlocks a repository that was locked for migration. You should unlock each migrated repository and [delete them](https://docs.github.com/rest/reference/repos#delete-a-repository) when the migration is complete and you no longer need the source data.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="migrationId">The unique identifier of the migration.</param>
        /// <param name="repoName">repo_name parameter</param>
        /// <returns></returns>
        void MigrationsUnlockRepoForOrg (string org, int? migrationId, string repoName);
        /// <summary>
        /// Update an import An import can be updated with credentials or a project choice by passing in the appropriate parameters in this API request. If no parameters are provided, the import will be restarted.  Some servers (e.g. TFS servers) can have several projects at a single URL. In those cases the import progress will have the status &#x60;detection_found_multiple&#x60; and the Import Progress response will include a &#x60;project_choices&#x60; array. You can select the project to import by providing one of the objects in the &#x60;project_choices&#x60; array in the update request.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="migrationsUpdateImportRequest"></param>
        /// <returns>Import</returns>
        Import MigrationsUpdateImport (string owner, string repo, MigrationsUpdateImportRequest migrationsUpdateImportRequest);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MigrationsApi : IMigrationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MigrationsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MigrationsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }

        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}

        /// <summary>
        /// Cancel an import Stop an import for a repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        public void MigrationsCancelImport (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling MigrationsCancelImport");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling MigrationsCancelImport");
            

            var path = "/repos/{owner}/{repo}/import";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsCancelImport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsCancelImport: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a user migration archive Deletes a previous migration archive. Downloadable migration archives are automatically deleted after seven days. Migration metadata, which is returned in the [List user migrations](https://docs.github.com/rest/reference/migrations#list-user-migrations) and [Get a user migration status](https://docs.github.com/rest/reference/migrations#get-a-user-migration-status) endpoints, will continue to be available even after an archive is deleted.
        /// </summary>
        /// <param name="migrationId">The unique identifier of the migration.</param>
        /// <returns></returns>
        public void MigrationsDeleteArchiveForAuthenticatedUser (int? migrationId)
        {
            
            // verify the required parameter 'migrationId' is set
            if (migrationId == null) throw new ApiException(400, "Missing required parameter 'migrationId' when calling MigrationsDeleteArchiveForAuthenticatedUser");
            

            var path = "/user/migrations/{migration_id}/archive";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "migration_id" + "}", ApiClient.ParameterToString(migrationId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsDeleteArchiveForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsDeleteArchiveForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete an organization migration archive Deletes a previous migration archive. Migration archives are automatically deleted after seven days.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="migrationId">The unique identifier of the migration.</param>
        /// <returns></returns>
        public void MigrationsDeleteArchiveForOrg (string org, int? migrationId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling MigrationsDeleteArchiveForOrg");
            
            // verify the required parameter 'migrationId' is set
            if (migrationId == null) throw new ApiException(400, "Missing required parameter 'migrationId' when calling MigrationsDeleteArchiveForOrg");
            

            var path = "/orgs/{org}/migrations/{migration_id}/archive";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "migration_id" + "}", ApiClient.ParameterToString(migrationId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsDeleteArchiveForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsDeleteArchiveForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Download an organization migration archive Fetches the URL to a migration archive.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="migrationId">The unique identifier of the migration.</param>
        /// <returns></returns>
        public void MigrationsDownloadArchiveForOrg (string org, int? migrationId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling MigrationsDownloadArchiveForOrg");
            
            // verify the required parameter 'migrationId' is set
            if (migrationId == null) throw new ApiException(400, "Missing required parameter 'migrationId' when calling MigrationsDownloadArchiveForOrg");
            

            var path = "/orgs/{org}/migrations/{migration_id}/archive";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "migration_id" + "}", ApiClient.ParameterToString(migrationId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsDownloadArchiveForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsDownloadArchiveForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Download a user migration archive Fetches the URL to download the migration archive as a &#x60;tar.gz&#x60; file. Depending on the resources your repository uses, the migration archive can contain JSON files with data for these objects:  *   attachments *   bases *   commit\\_comments *   issue\\_comments *   issue\\_events *   issues *   milestones *   organizations *   projects *   protected\\_branches *   pull\\_request\\_reviews *   pull\\_requests *   releases *   repositories *   review\\_comments *   schema *   users  The archive will also contain an &#x60;attachments&#x60; directory that includes all attachment files uploaded to GitHub.com and a &#x60;repositories&#x60; directory that contains the repository&#39;s Git data.
        /// </summary>
        /// <param name="migrationId">The unique identifier of the migration.</param>
        /// <returns></returns>
        public void MigrationsGetArchiveForAuthenticatedUser (int? migrationId)
        {
            
            // verify the required parameter 'migrationId' is set
            if (migrationId == null) throw new ApiException(400, "Missing required parameter 'migrationId' when calling MigrationsGetArchiveForAuthenticatedUser");
            

            var path = "/user/migrations/{migration_id}/archive";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "migration_id" + "}", ApiClient.ParameterToString(migrationId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsGetArchiveForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsGetArchiveForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get commit authors Each type of source control system represents authors in a different way. For example, a Git commit author has a display name and an email address, but a Subversion commit author just has a username. The GitHub Importer will make the author information valid, but the author might not be correct. For example, it will change the bare Subversion username &#x60;hubot&#x60; into something like &#x60;hubot &lt;hubot@12341234-abab-fefe-8787-fedcba987654&gt;&#x60;.  This endpoint and the [Map a commit author](https://docs.github.com/rest/reference/migrations#map-a-commit-author) endpoint allow you to provide correct Git author information.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="since">A user ID. Only return users with an ID greater than this ID.</param>
        /// <returns>List&lt;PorterAuthor&gt;</returns>
        public List<PorterAuthor> MigrationsGetCommitAuthors (string owner, string repo, int? since)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling MigrationsGetCommitAuthors");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling MigrationsGetCommitAuthors");
            

            var path = "/repos/{owner}/{repo}/import/authors";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsGetCommitAuthors: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsGetCommitAuthors: " + response.ErrorMessage, response.ErrorMessage);

            return (List<PorterAuthor>) ApiClient.Deserialize(response.Content, typeof(List<PorterAuthor>), response.Headers);
        }

        /// <summary>
        /// Get an import status View the progress of an import.  **Import status**  This section includes details about the possible values of the &#x60;status&#x60; field of the Import Progress response.  An import that does not have errors will progress through these steps:  *   &#x60;detecting&#x60; - the \&quot;detection\&quot; step of the import is in progress because the request did not include a &#x60;vcs&#x60; parameter. The import is identifying the type of source control present at the URL. *   &#x60;importing&#x60; - the \&quot;raw\&quot; step of the import is in progress. This is where commit data is fetched from the original repository. The import progress response will include &#x60;commit_count&#x60; (the total number of raw commits that will be imported) and &#x60;percent&#x60; (0 - 100, the current progress through the import). *   &#x60;mapping&#x60; - the \&quot;rewrite\&quot; step of the import is in progress. This is where SVN branches are converted to Git branches, and where author updates are applied. The import progress response does not include progress information. *   &#x60;pushing&#x60; - the \&quot;push\&quot; step of the import is in progress. This is where the importer updates the repository on GitHub. The import progress response will include &#x60;push_percent&#x60;, which is the percent value reported by &#x60;git push&#x60; when it is \&quot;Writing objects\&quot;. *   &#x60;complete&#x60; - the import is complete, and the repository is ready on GitHub.  If there are problems, you will see one of these in the &#x60;status&#x60; field:  *   &#x60;auth_failed&#x60; - the import requires authentication in order to connect to the original repository. To update authentication for the import, please see the [Update an import](https://docs.github.com/rest/reference/migrations#update-an-import) section. *   &#x60;error&#x60; - the import encountered an error. The import progress response will include the &#x60;failed_step&#x60; and an error message. Contact [GitHub Support](https://support.github.com/contact?tags&#x3D;dotcom-rest-api) for more information. *   &#x60;detection_needs_auth&#x60; - the importer requires authentication for the originating repository to continue detection. To update authentication for the import, please see the [Update an import](https://docs.github.com/rest/reference/migrations#update-an-import) section. *   &#x60;detection_found_nothing&#x60; - the importer didn&#39;t recognize any source control at the URL. To resolve, [Cancel the import](https://docs.github.com/rest/reference/migrations#cancel-an-import) and [retry](https://docs.github.com/rest/reference/migrations#start-an-import) with the correct URL. *   &#x60;detection_found_multiple&#x60; - the importer found several projects or repositories at the provided URL. When this is the case, the Import Progress response will also include a &#x60;project_choices&#x60; field with the possible project choices as values. To update project choice, please see the [Update an import](https://docs.github.com/rest/reference/migrations#update-an-import) section.  **The project_choices field**  When multiple projects are found at the provided URL, the response hash will include a &#x60;project_choices&#x60; field, the value of which is an array of hashes each representing a project choice. The exact key/value pairs of the project hashes will differ depending on the version control type.  **Git LFS related fields**  This section includes details about Git LFS related fields that may be present in the Import Progress response.  *   &#x60;use_lfs&#x60; - describes whether the import has been opted in or out of using Git LFS. The value can be &#x60;opt_in&#x60;, &#x60;opt_out&#x60;, or &#x60;undecided&#x60; if no action has been taken. *   &#x60;has_large_files&#x60; - the boolean value describing whether files larger than 100MB were found during the &#x60;importing&#x60; step. *   &#x60;large_files_size&#x60; - the total size in gigabytes of files larger than 100MB found in the originating repository. *   &#x60;large_files_count&#x60; - the total number of files larger than 100MB found in the originating repository. To see a list of these files, make a \&quot;Get Large Files\&quot; request.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>Import</returns>
        public Import MigrationsGetImportStatus (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling MigrationsGetImportStatus");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling MigrationsGetImportStatus");
            

            var path = "/repos/{owner}/{repo}/import";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsGetImportStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsGetImportStatus: " + response.ErrorMessage, response.ErrorMessage);

            return (Import) ApiClient.Deserialize(response.Content, typeof(Import), response.Headers);
        }

        /// <summary>
        /// Get large files List files larger than 100MB found during the import
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>List&lt;PorterLargeFile&gt;</returns>
        public List<PorterLargeFile> MigrationsGetLargeFiles (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling MigrationsGetLargeFiles");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling MigrationsGetLargeFiles");
            

            var path = "/repos/{owner}/{repo}/import/large_files";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsGetLargeFiles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsGetLargeFiles: " + response.ErrorMessage, response.ErrorMessage);

            return (List<PorterLargeFile>) ApiClient.Deserialize(response.Content, typeof(List<PorterLargeFile>), response.Headers);
        }

        /// <summary>
        /// Get a user migration status Fetches a single user migration. The response includes the &#x60;state&#x60; of the migration, which can be one of the following values:  *   &#x60;pending&#x60; - the migration hasn&#39;t started yet. *   &#x60;exporting&#x60; - the migration is in progress. *   &#x60;exported&#x60; - the migration finished successfully. *   &#x60;failed&#x60; - the migration failed.  Once the migration has been &#x60;exported&#x60; you can [download the migration archive](https://docs.github.com/rest/reference/migrations#download-a-user-migration-archive).
        /// </summary>
        /// <param name="migrationId">The unique identifier of the migration.</param>
        /// <param name="exclude"></param>
        /// <returns>Migration</returns>
        public Migration MigrationsGetStatusForAuthenticatedUser (int? migrationId, List<string> exclude)
        {
            
            // verify the required parameter 'migrationId' is set
            if (migrationId == null) throw new ApiException(400, "Missing required parameter 'migrationId' when calling MigrationsGetStatusForAuthenticatedUser");
            

            var path = "/user/migrations/{migration_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "migration_id" + "}", ApiClient.ParameterToString(migrationId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (exclude != null) queryParams.Add("exclude", ApiClient.ParameterToString(exclude)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsGetStatusForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsGetStatusForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (Migration) ApiClient.Deserialize(response.Content, typeof(Migration), response.Headers);
        }

        /// <summary>
        /// Get an organization migration status Fetches the status of a migration.  The &#x60;state&#x60; of a migration can be one of the following values:  *   &#x60;pending&#x60;, which means the migration hasn&#39;t started yet. *   &#x60;exporting&#x60;, which means the migration is in progress. *   &#x60;exported&#x60;, which means the migration finished successfully. *   &#x60;failed&#x60;, which means the migration failed.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="migrationId">The unique identifier of the migration.</param>
        /// <param name="exclude">Exclude attributes from the API response to improve performance</param>
        /// <returns>Migration</returns>
        public Migration MigrationsGetStatusForOrg (string org, int? migrationId, List<string> exclude)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling MigrationsGetStatusForOrg");
            
            // verify the required parameter 'migrationId' is set
            if (migrationId == null) throw new ApiException(400, "Missing required parameter 'migrationId' when calling MigrationsGetStatusForOrg");
            

            var path = "/orgs/{org}/migrations/{migration_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "migration_id" + "}", ApiClient.ParameterToString(migrationId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (exclude != null) queryParams.Add("exclude", ApiClient.ParameterToString(exclude)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsGetStatusForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsGetStatusForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (Migration) ApiClient.Deserialize(response.Content, typeof(Migration), response.Headers);
        }

        /// <summary>
        /// List user migrations Lists all migrations a user has started.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Migration&gt;</returns>
        public List<Migration> MigrationsListForAuthenticatedUser (int? perPage, int? page)
        {
            

            var path = "/user/migrations";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsListForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsListForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Migration>) ApiClient.Deserialize(response.Content, typeof(List<Migration>), response.Headers);
        }

        /// <summary>
        /// List organization migrations Lists the most recent migrations.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="exclude">Exclude attributes from the API response to improve performance</param>
        /// <returns>List&lt;Migration&gt;</returns>
        public List<Migration> MigrationsListForOrg (string org, int? perPage, int? page, List<string> exclude)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling MigrationsListForOrg");
            

            var path = "/orgs/{org}/migrations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (exclude != null) queryParams.Add("exclude", ApiClient.ParameterToString(exclude)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsListForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsListForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Migration>) ApiClient.Deserialize(response.Content, typeof(List<Migration>), response.Headers);
        }

        /// <summary>
        /// List repositories for a user migration Lists all the repositories for this user migration.
        /// </summary>
        /// <param name="migrationId">The unique identifier of the migration.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MinimalRepository&gt;</returns>
        public List<MinimalRepository> MigrationsListReposForAuthenticatedUser (int? migrationId, int? perPage, int? page)
        {
            
            // verify the required parameter 'migrationId' is set
            if (migrationId == null) throw new ApiException(400, "Missing required parameter 'migrationId' when calling MigrationsListReposForAuthenticatedUser");
            

            var path = "/user/migrations/{migration_id}/repositories";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "migration_id" + "}", ApiClient.ParameterToString(migrationId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsListReposForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsListReposForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<MinimalRepository>) ApiClient.Deserialize(response.Content, typeof(List<MinimalRepository>), response.Headers);
        }

        /// <summary>
        /// List repositories in an organization migration List all the repositories for this organization migration.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="migrationId">The unique identifier of the migration.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;MinimalRepository&gt;</returns>
        public List<MinimalRepository> MigrationsListReposForOrg (string org, int? migrationId, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling MigrationsListReposForOrg");
            
            // verify the required parameter 'migrationId' is set
            if (migrationId == null) throw new ApiException(400, "Missing required parameter 'migrationId' when calling MigrationsListReposForOrg");
            

            var path = "/orgs/{org}/migrations/{migration_id}/repositories";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "migration_id" + "}", ApiClient.ParameterToString(migrationId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsListReposForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsListReposForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (List<MinimalRepository>) ApiClient.Deserialize(response.Content, typeof(List<MinimalRepository>), response.Headers);
        }

        /// <summary>
        /// Map a commit author Update an author&#39;s identity for the import. Your application can continue updating authors any time before you push new commits to the repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="authorId"></param>
        /// <param name="migrationsMapCommitAuthorRequest"></param>
        /// <returns>PorterAuthor</returns>
        public PorterAuthor MigrationsMapCommitAuthor (string owner, string repo, int? authorId, MigrationsMapCommitAuthorRequest migrationsMapCommitAuthorRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling MigrationsMapCommitAuthor");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling MigrationsMapCommitAuthor");
            
            // verify the required parameter 'authorId' is set
            if (authorId == null) throw new ApiException(400, "Missing required parameter 'authorId' when calling MigrationsMapCommitAuthor");
            

            var path = "/repos/{owner}/{repo}/import/authors/{author_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "author_id" + "}", ApiClient.ParameterToString(authorId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(migrationsMapCommitAuthorRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsMapCommitAuthor: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsMapCommitAuthor: " + response.ErrorMessage, response.ErrorMessage);

            return (PorterAuthor) ApiClient.Deserialize(response.Content, typeof(PorterAuthor), response.Headers);
        }

        /// <summary>
        /// Update Git LFS preference You can import repositories from Subversion, Mercurial, and TFS that include files larger than 100MB. This ability is powered by [Git LFS](https://git-lfs.github.com). You can learn more about our LFS feature and working with large files [on our help site](https://docs.github.com/articles/versioning-large-files/).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="migrationsSetLfsPreferenceRequest"></param>
        /// <returns>Import</returns>
        public Import MigrationsSetLfsPreference (string owner, string repo, MigrationsSetLfsPreferenceRequest migrationsSetLfsPreferenceRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling MigrationsSetLfsPreference");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling MigrationsSetLfsPreference");
            
            // verify the required parameter 'migrationsSetLfsPreferenceRequest' is set
            if (migrationsSetLfsPreferenceRequest == null) throw new ApiException(400, "Missing required parameter 'migrationsSetLfsPreferenceRequest' when calling MigrationsSetLfsPreference");
            

            var path = "/repos/{owner}/{repo}/import/lfs";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(migrationsSetLfsPreferenceRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsSetLfsPreference: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsSetLfsPreference: " + response.ErrorMessage, response.ErrorMessage);

            return (Import) ApiClient.Deserialize(response.Content, typeof(Import), response.Headers);
        }

        /// <summary>
        /// Start a user migration Initiates the generation of a user migration archive.
        /// </summary>
        /// <param name="migrationsStartForAuthenticatedUserRequest"></param>
        /// <returns>Migration</returns>
        public Migration MigrationsStartForAuthenticatedUser (MigrationsStartForAuthenticatedUserRequest migrationsStartForAuthenticatedUserRequest)
        {
            
            // verify the required parameter 'migrationsStartForAuthenticatedUserRequest' is set
            if (migrationsStartForAuthenticatedUserRequest == null) throw new ApiException(400, "Missing required parameter 'migrationsStartForAuthenticatedUserRequest' when calling MigrationsStartForAuthenticatedUser");
            

            var path = "/user/migrations";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(migrationsStartForAuthenticatedUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsStartForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsStartForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (Migration) ApiClient.Deserialize(response.Content, typeof(Migration), response.Headers);
        }

        /// <summary>
        /// Start an organization migration Initiates the generation of a migration archive.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="migrationsStartForOrgRequest"></param>
        /// <returns>Migration</returns>
        public Migration MigrationsStartForOrg (string org, MigrationsStartForOrgRequest migrationsStartForOrgRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling MigrationsStartForOrg");
            
            // verify the required parameter 'migrationsStartForOrgRequest' is set
            if (migrationsStartForOrgRequest == null) throw new ApiException(400, "Missing required parameter 'migrationsStartForOrgRequest' when calling MigrationsStartForOrg");
            

            var path = "/orgs/{org}/migrations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(migrationsStartForOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsStartForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsStartForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (Migration) ApiClient.Deserialize(response.Content, typeof(Migration), response.Headers);
        }

        /// <summary>
        /// Start an import Start a source import to a GitHub repository using GitHub Importer.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="migrationsStartImportRequest"></param>
        /// <returns>Import</returns>
        public Import MigrationsStartImport (string owner, string repo, MigrationsStartImportRequest migrationsStartImportRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling MigrationsStartImport");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling MigrationsStartImport");
            
            // verify the required parameter 'migrationsStartImportRequest' is set
            if (migrationsStartImportRequest == null) throw new ApiException(400, "Missing required parameter 'migrationsStartImportRequest' when calling MigrationsStartImport");
            

            var path = "/repos/{owner}/{repo}/import";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(migrationsStartImportRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsStartImport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsStartImport: " + response.ErrorMessage, response.ErrorMessage);

            return (Import) ApiClient.Deserialize(response.Content, typeof(Import), response.Headers);
        }

        /// <summary>
        /// Unlock a user repository Unlocks a repository. You can lock repositories when you [start a user migration](https://docs.github.com/rest/reference/migrations#start-a-user-migration). Once the migration is complete you can unlock each repository to begin using it again or [delete the repository](https://docs.github.com/rest/reference/repos#delete-a-repository) if you no longer need the source data. Returns a status of &#x60;404 Not Found&#x60; if the repository is not locked.
        /// </summary>
        /// <param name="migrationId">The unique identifier of the migration.</param>
        /// <param name="repoName">repo_name parameter</param>
        /// <returns></returns>
        public void MigrationsUnlockRepoForAuthenticatedUser (int? migrationId, string repoName)
        {
            
            // verify the required parameter 'migrationId' is set
            if (migrationId == null) throw new ApiException(400, "Missing required parameter 'migrationId' when calling MigrationsUnlockRepoForAuthenticatedUser");
            
            // verify the required parameter 'repoName' is set
            if (repoName == null) throw new ApiException(400, "Missing required parameter 'repoName' when calling MigrationsUnlockRepoForAuthenticatedUser");
            

            var path = "/user/migrations/{migration_id}/repos/{repo_name}/lock";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "migration_id" + "}", ApiClient.ParameterToString(migrationId));
path = path.Replace("{" + "repo_name" + "}", ApiClient.ParameterToString(repoName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsUnlockRepoForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsUnlockRepoForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Unlock an organization repository Unlocks a repository that was locked for migration. You should unlock each migrated repository and [delete them](https://docs.github.com/rest/reference/repos#delete-a-repository) when the migration is complete and you no longer need the source data.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="migrationId">The unique identifier of the migration.</param>
        /// <param name="repoName">repo_name parameter</param>
        /// <returns></returns>
        public void MigrationsUnlockRepoForOrg (string org, int? migrationId, string repoName)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling MigrationsUnlockRepoForOrg");
            
            // verify the required parameter 'migrationId' is set
            if (migrationId == null) throw new ApiException(400, "Missing required parameter 'migrationId' when calling MigrationsUnlockRepoForOrg");
            
            // verify the required parameter 'repoName' is set
            if (repoName == null) throw new ApiException(400, "Missing required parameter 'repoName' when calling MigrationsUnlockRepoForOrg");
            

            var path = "/orgs/{org}/migrations/{migration_id}/repos/{repo_name}/lock";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "migration_id" + "}", ApiClient.ParameterToString(migrationId));
path = path.Replace("{" + "repo_name" + "}", ApiClient.ParameterToString(repoName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsUnlockRepoForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsUnlockRepoForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Update an import An import can be updated with credentials or a project choice by passing in the appropriate parameters in this API request. If no parameters are provided, the import will be restarted.  Some servers (e.g. TFS servers) can have several projects at a single URL. In those cases the import progress will have the status &#x60;detection_found_multiple&#x60; and the Import Progress response will include a &#x60;project_choices&#x60; array. You can select the project to import by providing one of the objects in the &#x60;project_choices&#x60; array in the update request.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="migrationsUpdateImportRequest"></param>
        /// <returns>Import</returns>
        public Import MigrationsUpdateImport (string owner, string repo, MigrationsUpdateImportRequest migrationsUpdateImportRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling MigrationsUpdateImport");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling MigrationsUpdateImport");
            

            var path = "/repos/{owner}/{repo}/import";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(migrationsUpdateImportRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsUpdateImport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MigrationsUpdateImport: " + response.ErrorMessage, response.ErrorMessage);

            return (Import) ApiClient.Deserialize(response.Content, typeof(Import), response.Headers);
        }

    }
}
