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
    public interface IChecksApi
    {
        /// <summary>
        /// Create a check run **Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty &#x60;pull_requests&#x60; array.  Creates a new check run for a specific commit in a repository. Your GitHub App must have the &#x60;checks:write&#x60; permission to create check runs.  In a check suite, GitHub limits the number of check runs with the same name to 1000. Once these check runs exceed 1000, GitHub will start to automatically delete older check runs.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="checksCreateRequest"></param>
        /// <returns>CheckRun</returns>
        CheckRun ChecksCreate (string owner, string repo, ChecksCreateRequest checksCreateRequest);
        /// <summary>
        /// Create a check suite **Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty &#x60;pull_requests&#x60; array and a &#x60;null&#x60; value for &#x60;head_branch&#x60;.  By default, check suites are automatically created when you create a [check run](https://docs.github.com/rest/reference/checks#check-runs). You only need to use this endpoint for manually creating check suites when you&#39;ve disabled automatic creation using \&quot;[Update repository preferences for check suites](https://docs.github.com/rest/reference/checks#update-repository-preferences-for-check-suites)\&quot;. Your GitHub App must have the &#x60;checks:write&#x60; permission to create check suites.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="checksCreateSuiteRequest"></param>
        /// <returns>CheckSuite</returns>
        CheckSuite ChecksCreateSuite (string owner, string repo, ChecksCreateSuiteRequest checksCreateSuiteRequest);
        /// <summary>
        /// Get a check run **Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty &#x60;pull_requests&#x60; array.  Gets a single check run using its &#x60;id&#x60;. GitHub Apps must have the &#x60;checks:read&#x60; permission on a private repository or pull access to a public repository to get check runs. OAuth Apps and authenticated users must have the &#x60;repo&#x60; scope to get check runs in a private repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="checkRunId">The unique identifier of the check run.</param>
        /// <returns>CheckRun</returns>
        CheckRun ChecksGet (string owner, string repo, int? checkRunId);
        /// <summary>
        /// Get a check suite **Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty &#x60;pull_requests&#x60; array and a &#x60;null&#x60; value for &#x60;head_branch&#x60;.  Gets a single check suite using its &#x60;id&#x60;. GitHub Apps must have the &#x60;checks:read&#x60; permission on a private repository or pull access to a public repository to get check suites. OAuth Apps and authenticated users must have the &#x60;repo&#x60; scope to get check suites in a private repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="checkSuiteId">The unique identifier of the check suite.</param>
        /// <returns>CheckSuite</returns>
        CheckSuite ChecksGetSuite (string owner, string repo, int? checkSuiteId);
        /// <summary>
        /// List check run annotations Lists annotations for a check run using the annotation &#x60;id&#x60;. GitHub Apps must have the &#x60;checks:read&#x60; permission on a private repository or pull access to a public repository to get annotations for a check run. OAuth Apps and authenticated users must have the &#x60;repo&#x60; scope to get annotations for a check run in a private repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="checkRunId">The unique identifier of the check run.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;CheckAnnotation&gt;</returns>
        List<CheckAnnotation> ChecksListAnnotations (string owner, string repo, int? checkRunId, int? perPage, int? page);
        /// <summary>
        /// List check runs for a Git reference **Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty &#x60;pull_requests&#x60; array.  Lists check runs for a commit ref. The &#x60;ref&#x60; can be a SHA, branch name, or a tag name. GitHub Apps must have the &#x60;checks:read&#x60; permission on a private repository or pull access to a public repository to get check runs. OAuth Apps and authenticated users must have the &#x60;repo&#x60; scope to get check runs in a private repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="_ref">ref parameter</param>
        /// <param name="checkName">Returns check runs with the specified &#x60;name&#x60;.</param>
        /// <param name="status">Returns check runs with the specified &#x60;status&#x60;.</param>
        /// <param name="filter">Filters check runs by their &#x60;completed_at&#x60; timestamp. &#x60;latest&#x60; returns the most recent check runs.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="appId"></param>
        /// <returns>ChecksListForSuite200Response</returns>
        ChecksListForSuite200Response ChecksListForRef (string owner, string repo, string _ref, string checkName, string status, string filter, int? perPage, int? page, int? appId);
        /// <summary>
        /// List check runs in a check suite **Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty &#x60;pull_requests&#x60; array.  Lists check runs for a check suite using its &#x60;id&#x60;. GitHub Apps must have the &#x60;checks:read&#x60; permission on a private repository or pull access to a public repository to get check runs. OAuth Apps and authenticated users must have the &#x60;repo&#x60; scope to get check runs in a private repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="checkSuiteId">The unique identifier of the check suite.</param>
        /// <param name="checkName">Returns check runs with the specified &#x60;name&#x60;.</param>
        /// <param name="status">Returns check runs with the specified &#x60;status&#x60;.</param>
        /// <param name="filter">Filters check runs by their &#x60;completed_at&#x60; timestamp. &#x60;latest&#x60; returns the most recent check runs.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ChecksListForSuite200Response</returns>
        ChecksListForSuite200Response ChecksListForSuite (string owner, string repo, int? checkSuiteId, string checkName, string status, string filter, int? perPage, int? page);
        /// <summary>
        /// List check suites for a Git reference **Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty &#x60;pull_requests&#x60; array and a &#x60;null&#x60; value for &#x60;head_branch&#x60;.  Lists check suites for a commit &#x60;ref&#x60;. The &#x60;ref&#x60; can be a SHA, branch name, or a tag name. GitHub Apps must have the &#x60;checks:read&#x60; permission on a private repository or pull access to a public repository to list check suites. OAuth Apps and authenticated users must have the &#x60;repo&#x60; scope to get check suites in a private repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="_ref">ref parameter</param>
        /// <param name="appId">Filters check suites by GitHub App &#x60;id&#x60;.</param>
        /// <param name="checkName">Returns check runs with the specified &#x60;name&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ChecksListSuitesForRef200Response</returns>
        ChecksListSuitesForRef200Response ChecksListSuitesForRef (string owner, string repo, string _ref, int? appId, string checkName, int? perPage, int? page);
        /// <summary>
        /// Rerequest a check run Triggers GitHub to rerequest an existing check run, without pushing new code to a repository. This endpoint will trigger the [&#x60;check_run&#x60; webhook](https://docs.github.com/webhooks/event-payloads/#check_run) event with the action &#x60;rerequested&#x60;. When a check run is &#x60;rerequested&#x60;, its &#x60;status&#x60; is reset to &#x60;queued&#x60; and the &#x60;conclusion&#x60; is cleared.  To rerequest a check run, your GitHub App must have the &#x60;checks:read&#x60; permission on a private repository or pull access to a public repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="checkRunId">The unique identifier of the check run.</param>
        /// <returns>Object</returns>
        Object ChecksRerequestRun (string owner, string repo, int? checkRunId);
        /// <summary>
        /// Rerequest a check suite Triggers GitHub to rerequest an existing check suite, without pushing new code to a repository. This endpoint will trigger the [&#x60;check_suite&#x60; webhook](https://docs.github.com/webhooks/event-payloads/#check_suite) event with the action &#x60;rerequested&#x60;. When a check suite is &#x60;rerequested&#x60;, its &#x60;status&#x60; is reset to &#x60;queued&#x60; and the &#x60;conclusion&#x60; is cleared.  To rerequest a check suite, your GitHub App must have the &#x60;checks:read&#x60; permission on a private repository or pull access to a public repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="checkSuiteId">The unique identifier of the check suite.</param>
        /// <returns>Object</returns>
        Object ChecksRerequestSuite (string owner, string repo, int? checkSuiteId);
        /// <summary>
        /// Update repository preferences for check suites Changes the default automatic flow when creating check suites. By default, a check suite is automatically created each time code is pushed to a repository. When you disable the automatic creation of check suites, you can manually [Create a check suite](https://docs.github.com/rest/reference/checks#create-a-check-suite). You must have admin permissions in the repository to set preferences for check suites.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="checksSetSuitesPreferencesRequest"></param>
        /// <returns>CheckSuitePreference</returns>
        CheckSuitePreference ChecksSetSuitesPreferences (string owner, string repo, ChecksSetSuitesPreferencesRequest checksSetSuitesPreferencesRequest);
        /// <summary>
        /// Update a check run **Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty &#x60;pull_requests&#x60; array.  Updates a check run for a specific commit in a repository. Your GitHub App must have the &#x60;checks:write&#x60; permission to edit check runs.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="checkRunId">The unique identifier of the check run.</param>
        /// <param name="checksUpdateRequest"></param>
        /// <returns>CheckRun</returns>
        CheckRun ChecksUpdate (string owner, string repo, int? checkRunId, ChecksUpdateRequest checksUpdateRequest);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ChecksApi : IChecksApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ChecksApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ChecksApi(String basePath)
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
        /// Create a check run **Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty &#x60;pull_requests&#x60; array.  Creates a new check run for a specific commit in a repository. Your GitHub App must have the &#x60;checks:write&#x60; permission to create check runs.  In a check suite, GitHub limits the number of check runs with the same name to 1000. Once these check runs exceed 1000, GitHub will start to automatically delete older check runs.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="checksCreateRequest"></param>
        /// <returns>CheckRun</returns>
        public CheckRun ChecksCreate (string owner, string repo, ChecksCreateRequest checksCreateRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ChecksCreate");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ChecksCreate");
            
            // verify the required parameter 'checksCreateRequest' is set
            if (checksCreateRequest == null) throw new ApiException(400, "Missing required parameter 'checksCreateRequest' when calling ChecksCreate");
            

            var path = "/repos/{owner}/{repo}/check-runs";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(checksCreateRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksCreate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksCreate: " + response.ErrorMessage, response.ErrorMessage);

            return (CheckRun) ApiClient.Deserialize(response.Content, typeof(CheckRun), response.Headers);
        }

        /// <summary>
        /// Create a check suite **Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty &#x60;pull_requests&#x60; array and a &#x60;null&#x60; value for &#x60;head_branch&#x60;.  By default, check suites are automatically created when you create a [check run](https://docs.github.com/rest/reference/checks#check-runs). You only need to use this endpoint for manually creating check suites when you&#39;ve disabled automatic creation using \&quot;[Update repository preferences for check suites](https://docs.github.com/rest/reference/checks#update-repository-preferences-for-check-suites)\&quot;. Your GitHub App must have the &#x60;checks:write&#x60; permission to create check suites.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="checksCreateSuiteRequest"></param>
        /// <returns>CheckSuite</returns>
        public CheckSuite ChecksCreateSuite (string owner, string repo, ChecksCreateSuiteRequest checksCreateSuiteRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ChecksCreateSuite");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ChecksCreateSuite");
            
            // verify the required parameter 'checksCreateSuiteRequest' is set
            if (checksCreateSuiteRequest == null) throw new ApiException(400, "Missing required parameter 'checksCreateSuiteRequest' when calling ChecksCreateSuite");
            

            var path = "/repos/{owner}/{repo}/check-suites";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(checksCreateSuiteRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksCreateSuite: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksCreateSuite: " + response.ErrorMessage, response.ErrorMessage);

            return (CheckSuite) ApiClient.Deserialize(response.Content, typeof(CheckSuite), response.Headers);
        }

        /// <summary>
        /// Get a check run **Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty &#x60;pull_requests&#x60; array.  Gets a single check run using its &#x60;id&#x60;. GitHub Apps must have the &#x60;checks:read&#x60; permission on a private repository or pull access to a public repository to get check runs. OAuth Apps and authenticated users must have the &#x60;repo&#x60; scope to get check runs in a private repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="checkRunId">The unique identifier of the check run.</param>
        /// <returns>CheckRun</returns>
        public CheckRun ChecksGet (string owner, string repo, int? checkRunId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ChecksGet");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ChecksGet");
            
            // verify the required parameter 'checkRunId' is set
            if (checkRunId == null) throw new ApiException(400, "Missing required parameter 'checkRunId' when calling ChecksGet");
            

            var path = "/repos/{owner}/{repo}/check-runs/{check_run_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "check_run_id" + "}", ApiClient.ParameterToString(checkRunId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksGet: " + response.ErrorMessage, response.ErrorMessage);

            return (CheckRun) ApiClient.Deserialize(response.Content, typeof(CheckRun), response.Headers);
        }

        /// <summary>
        /// Get a check suite **Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty &#x60;pull_requests&#x60; array and a &#x60;null&#x60; value for &#x60;head_branch&#x60;.  Gets a single check suite using its &#x60;id&#x60;. GitHub Apps must have the &#x60;checks:read&#x60; permission on a private repository or pull access to a public repository to get check suites. OAuth Apps and authenticated users must have the &#x60;repo&#x60; scope to get check suites in a private repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="checkSuiteId">The unique identifier of the check suite.</param>
        /// <returns>CheckSuite</returns>
        public CheckSuite ChecksGetSuite (string owner, string repo, int? checkSuiteId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ChecksGetSuite");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ChecksGetSuite");
            
            // verify the required parameter 'checkSuiteId' is set
            if (checkSuiteId == null) throw new ApiException(400, "Missing required parameter 'checkSuiteId' when calling ChecksGetSuite");
            

            var path = "/repos/{owner}/{repo}/check-suites/{check_suite_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "check_suite_id" + "}", ApiClient.ParameterToString(checkSuiteId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksGetSuite: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksGetSuite: " + response.ErrorMessage, response.ErrorMessage);

            return (CheckSuite) ApiClient.Deserialize(response.Content, typeof(CheckSuite), response.Headers);
        }

        /// <summary>
        /// List check run annotations Lists annotations for a check run using the annotation &#x60;id&#x60;. GitHub Apps must have the &#x60;checks:read&#x60; permission on a private repository or pull access to a public repository to get annotations for a check run. OAuth Apps and authenticated users must have the &#x60;repo&#x60; scope to get annotations for a check run in a private repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="checkRunId">The unique identifier of the check run.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;CheckAnnotation&gt;</returns>
        public List<CheckAnnotation> ChecksListAnnotations (string owner, string repo, int? checkRunId, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ChecksListAnnotations");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ChecksListAnnotations");
            
            // verify the required parameter 'checkRunId' is set
            if (checkRunId == null) throw new ApiException(400, "Missing required parameter 'checkRunId' when calling ChecksListAnnotations");
            

            var path = "/repos/{owner}/{repo}/check-runs/{check_run_id}/annotations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "check_run_id" + "}", ApiClient.ParameterToString(checkRunId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksListAnnotations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksListAnnotations: " + response.ErrorMessage, response.ErrorMessage);

            return (List<CheckAnnotation>) ApiClient.Deserialize(response.Content, typeof(List<CheckAnnotation>), response.Headers);
        }

        /// <summary>
        /// List check runs for a Git reference **Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty &#x60;pull_requests&#x60; array.  Lists check runs for a commit ref. The &#x60;ref&#x60; can be a SHA, branch name, or a tag name. GitHub Apps must have the &#x60;checks:read&#x60; permission on a private repository or pull access to a public repository to get check runs. OAuth Apps and authenticated users must have the &#x60;repo&#x60; scope to get check runs in a private repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="_ref">ref parameter</param>
        /// <param name="checkName">Returns check runs with the specified &#x60;name&#x60;.</param>
        /// <param name="status">Returns check runs with the specified &#x60;status&#x60;.</param>
        /// <param name="filter">Filters check runs by their &#x60;completed_at&#x60; timestamp. &#x60;latest&#x60; returns the most recent check runs.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="appId"></param>
        /// <returns>ChecksListForSuite200Response</returns>
        public ChecksListForSuite200Response ChecksListForRef (string owner, string repo, string _ref, string checkName, string status, string filter, int? perPage, int? page, int? appId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ChecksListForRef");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ChecksListForRef");
            
            // verify the required parameter '_ref' is set
            if (_ref == null) throw new ApiException(400, "Missing required parameter '_ref' when calling ChecksListForRef");
            

            var path = "/repos/{owner}/{repo}/commits/{ref}/check-runs";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "ref" + "}", ApiClient.ParameterToString(_ref));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (checkName != null) queryParams.Add("check_name", ApiClient.ParameterToString(checkName)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (appId != null) queryParams.Add("app_id", ApiClient.ParameterToString(appId)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksListForRef: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksListForRef: " + response.ErrorMessage, response.ErrorMessage);

            return (ChecksListForSuite200Response) ApiClient.Deserialize(response.Content, typeof(ChecksListForSuite200Response), response.Headers);
        }

        /// <summary>
        /// List check runs in a check suite **Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty &#x60;pull_requests&#x60; array.  Lists check runs for a check suite using its &#x60;id&#x60;. GitHub Apps must have the &#x60;checks:read&#x60; permission on a private repository or pull access to a public repository to get check runs. OAuth Apps and authenticated users must have the &#x60;repo&#x60; scope to get check runs in a private repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="checkSuiteId">The unique identifier of the check suite.</param>
        /// <param name="checkName">Returns check runs with the specified &#x60;name&#x60;.</param>
        /// <param name="status">Returns check runs with the specified &#x60;status&#x60;.</param>
        /// <param name="filter">Filters check runs by their &#x60;completed_at&#x60; timestamp. &#x60;latest&#x60; returns the most recent check runs.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ChecksListForSuite200Response</returns>
        public ChecksListForSuite200Response ChecksListForSuite (string owner, string repo, int? checkSuiteId, string checkName, string status, string filter, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ChecksListForSuite");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ChecksListForSuite");
            
            // verify the required parameter 'checkSuiteId' is set
            if (checkSuiteId == null) throw new ApiException(400, "Missing required parameter 'checkSuiteId' when calling ChecksListForSuite");
            

            var path = "/repos/{owner}/{repo}/check-suites/{check_suite_id}/check-runs";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "check_suite_id" + "}", ApiClient.ParameterToString(checkSuiteId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (checkName != null) queryParams.Add("check_name", ApiClient.ParameterToString(checkName)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksListForSuite: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksListForSuite: " + response.ErrorMessage, response.ErrorMessage);

            return (ChecksListForSuite200Response) ApiClient.Deserialize(response.Content, typeof(ChecksListForSuite200Response), response.Headers);
        }

        /// <summary>
        /// List check suites for a Git reference **Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty &#x60;pull_requests&#x60; array and a &#x60;null&#x60; value for &#x60;head_branch&#x60;.  Lists check suites for a commit &#x60;ref&#x60;. The &#x60;ref&#x60; can be a SHA, branch name, or a tag name. GitHub Apps must have the &#x60;checks:read&#x60; permission on a private repository or pull access to a public repository to list check suites. OAuth Apps and authenticated users must have the &#x60;repo&#x60; scope to get check suites in a private repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="_ref">ref parameter</param>
        /// <param name="appId">Filters check suites by GitHub App &#x60;id&#x60;.</param>
        /// <param name="checkName">Returns check runs with the specified &#x60;name&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ChecksListSuitesForRef200Response</returns>
        public ChecksListSuitesForRef200Response ChecksListSuitesForRef (string owner, string repo, string _ref, int? appId, string checkName, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ChecksListSuitesForRef");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ChecksListSuitesForRef");
            
            // verify the required parameter '_ref' is set
            if (_ref == null) throw new ApiException(400, "Missing required parameter '_ref' when calling ChecksListSuitesForRef");
            

            var path = "/repos/{owner}/{repo}/commits/{ref}/check-suites";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "ref" + "}", ApiClient.ParameterToString(_ref));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (appId != null) queryParams.Add("app_id", ApiClient.ParameterToString(appId)); // query parameter
 if (checkName != null) queryParams.Add("check_name", ApiClient.ParameterToString(checkName)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksListSuitesForRef: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksListSuitesForRef: " + response.ErrorMessage, response.ErrorMessage);

            return (ChecksListSuitesForRef200Response) ApiClient.Deserialize(response.Content, typeof(ChecksListSuitesForRef200Response), response.Headers);
        }

        /// <summary>
        /// Rerequest a check run Triggers GitHub to rerequest an existing check run, without pushing new code to a repository. This endpoint will trigger the [&#x60;check_run&#x60; webhook](https://docs.github.com/webhooks/event-payloads/#check_run) event with the action &#x60;rerequested&#x60;. When a check run is &#x60;rerequested&#x60;, its &#x60;status&#x60; is reset to &#x60;queued&#x60; and the &#x60;conclusion&#x60; is cleared.  To rerequest a check run, your GitHub App must have the &#x60;checks:read&#x60; permission on a private repository or pull access to a public repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="checkRunId">The unique identifier of the check run.</param>
        /// <returns>Object</returns>
        public Object ChecksRerequestRun (string owner, string repo, int? checkRunId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ChecksRerequestRun");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ChecksRerequestRun");
            
            // verify the required parameter 'checkRunId' is set
            if (checkRunId == null) throw new ApiException(400, "Missing required parameter 'checkRunId' when calling ChecksRerequestRun");
            

            var path = "/repos/{owner}/{repo}/check-runs/{check_run_id}/rerequest";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "check_run_id" + "}", ApiClient.ParameterToString(checkRunId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksRerequestRun: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksRerequestRun: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Rerequest a check suite Triggers GitHub to rerequest an existing check suite, without pushing new code to a repository. This endpoint will trigger the [&#x60;check_suite&#x60; webhook](https://docs.github.com/webhooks/event-payloads/#check_suite) event with the action &#x60;rerequested&#x60;. When a check suite is &#x60;rerequested&#x60;, its &#x60;status&#x60; is reset to &#x60;queued&#x60; and the &#x60;conclusion&#x60; is cleared.  To rerequest a check suite, your GitHub App must have the &#x60;checks:read&#x60; permission on a private repository or pull access to a public repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="checkSuiteId">The unique identifier of the check suite.</param>
        /// <returns>Object</returns>
        public Object ChecksRerequestSuite (string owner, string repo, int? checkSuiteId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ChecksRerequestSuite");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ChecksRerequestSuite");
            
            // verify the required parameter 'checkSuiteId' is set
            if (checkSuiteId == null) throw new ApiException(400, "Missing required parameter 'checkSuiteId' when calling ChecksRerequestSuite");
            

            var path = "/repos/{owner}/{repo}/check-suites/{check_suite_id}/rerequest";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "check_suite_id" + "}", ApiClient.ParameterToString(checkSuiteId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksRerequestSuite: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksRerequestSuite: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Update repository preferences for check suites Changes the default automatic flow when creating check suites. By default, a check suite is automatically created each time code is pushed to a repository. When you disable the automatic creation of check suites, you can manually [Create a check suite](https://docs.github.com/rest/reference/checks#create-a-check-suite). You must have admin permissions in the repository to set preferences for check suites.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="checksSetSuitesPreferencesRequest"></param>
        /// <returns>CheckSuitePreference</returns>
        public CheckSuitePreference ChecksSetSuitesPreferences (string owner, string repo, ChecksSetSuitesPreferencesRequest checksSetSuitesPreferencesRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ChecksSetSuitesPreferences");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ChecksSetSuitesPreferences");
            
            // verify the required parameter 'checksSetSuitesPreferencesRequest' is set
            if (checksSetSuitesPreferencesRequest == null) throw new ApiException(400, "Missing required parameter 'checksSetSuitesPreferencesRequest' when calling ChecksSetSuitesPreferences");
            

            var path = "/repos/{owner}/{repo}/check-suites/preferences";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(checksSetSuitesPreferencesRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksSetSuitesPreferences: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksSetSuitesPreferences: " + response.ErrorMessage, response.ErrorMessage);

            return (CheckSuitePreference) ApiClient.Deserialize(response.Content, typeof(CheckSuitePreference), response.Headers);
        }

        /// <summary>
        /// Update a check run **Note:** The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty &#x60;pull_requests&#x60; array.  Updates a check run for a specific commit in a repository. Your GitHub App must have the &#x60;checks:write&#x60; permission to edit check runs.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="checkRunId">The unique identifier of the check run.</param>
        /// <param name="checksUpdateRequest"></param>
        /// <returns>CheckRun</returns>
        public CheckRun ChecksUpdate (string owner, string repo, int? checkRunId, ChecksUpdateRequest checksUpdateRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ChecksUpdate");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ChecksUpdate");
            
            // verify the required parameter 'checkRunId' is set
            if (checkRunId == null) throw new ApiException(400, "Missing required parameter 'checkRunId' when calling ChecksUpdate");
            
            // verify the required parameter 'checksUpdateRequest' is set
            if (checksUpdateRequest == null) throw new ApiException(400, "Missing required parameter 'checksUpdateRequest' when calling ChecksUpdate");
            

            var path = "/repos/{owner}/{repo}/check-runs/{check_run_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "check_run_id" + "}", ApiClient.ParameterToString(checkRunId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(checksUpdateRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksUpdate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ChecksUpdate: " + response.ErrorMessage, response.ErrorMessage);

            return (CheckRun) ApiClient.Deserialize(response.Content, typeof(CheckRun), response.Headers);
        }

    }
}
