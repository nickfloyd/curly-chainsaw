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
    public interface IDependencyGraphApi
    {
        /// <summary>
        /// Create a snapshot of dependencies for a repository Create a new snapshot of a repository&#39;s dependencies. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint for a repository that the requesting user has access to.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="snapshot"></param>
        /// <returns>DependencyGraphCreateRepositorySnapshot201Response</returns>
        DependencyGraphCreateRepositorySnapshot201Response DependencyGraphCreateRepositorySnapshot (string owner, string repo, Snapshot snapshot);
        /// <summary>
        /// Get a diff of the dependencies between commits Gets the diff of the dependency changes between two commits of a repository, based on the changes to the dependency manifests made in those commits.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="basehead">The base and head Git revisions to compare. The Git revisions will be resolved to commit SHAs. Named revisions will be resolved to their corresponding HEAD commits, and an appropriate merge base will be determined. This parameter expects the format &#x60;{base}...{head}&#x60;.</param>
        /// <param name="name">The full path, relative to the repository root, of the dependency manifest file.</param>
        /// <returns>List&lt;DependencyGraphDiffInner&gt;</returns>
        List<DependencyGraphDiffInner> DependencyGraphDiffRange (string owner, string repo, string basehead, string name);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DependencyGraphApi : IDependencyGraphApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DependencyGraphApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DependencyGraphApi(String basePath)
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
        /// Create a snapshot of dependencies for a repository Create a new snapshot of a repository&#39;s dependencies. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint for a repository that the requesting user has access to.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="snapshot"></param>
        /// <returns>DependencyGraphCreateRepositorySnapshot201Response</returns>
        public DependencyGraphCreateRepositorySnapshot201Response DependencyGraphCreateRepositorySnapshot (string owner, string repo, Snapshot snapshot)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling DependencyGraphCreateRepositorySnapshot");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling DependencyGraphCreateRepositorySnapshot");
            
            // verify the required parameter 'snapshot' is set
            if (snapshot == null) throw new ApiException(400, "Missing required parameter 'snapshot' when calling DependencyGraphCreateRepositorySnapshot");
            

            var path = "/repos/{owner}/{repo}/dependency-graph/snapshots";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(snapshot); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DependencyGraphCreateRepositorySnapshot: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DependencyGraphCreateRepositorySnapshot: " + response.ErrorMessage, response.ErrorMessage);

            return (DependencyGraphCreateRepositorySnapshot201Response) ApiClient.Deserialize(response.Content, typeof(DependencyGraphCreateRepositorySnapshot201Response), response.Headers);
        }

        /// <summary>
        /// Get a diff of the dependencies between commits Gets the diff of the dependency changes between two commits of a repository, based on the changes to the dependency manifests made in those commits.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="basehead">The base and head Git revisions to compare. The Git revisions will be resolved to commit SHAs. Named revisions will be resolved to their corresponding HEAD commits, and an appropriate merge base will be determined. This parameter expects the format &#x60;{base}...{head}&#x60;.</param>
        /// <param name="name">The full path, relative to the repository root, of the dependency manifest file.</param>
        /// <returns>List&lt;DependencyGraphDiffInner&gt;</returns>
        public List<DependencyGraphDiffInner> DependencyGraphDiffRange (string owner, string repo, string basehead, string name)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling DependencyGraphDiffRange");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling DependencyGraphDiffRange");
            
            // verify the required parameter 'basehead' is set
            if (basehead == null) throw new ApiException(400, "Missing required parameter 'basehead' when calling DependencyGraphDiffRange");
            

            var path = "/repos/{owner}/{repo}/dependency-graph/compare/{basehead}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "basehead" + "}", ApiClient.ParameterToString(basehead));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DependencyGraphDiffRange: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DependencyGraphDiffRange: " + response.ErrorMessage, response.ErrorMessage);

            return (List<DependencyGraphDiffInner>) ApiClient.Deserialize(response.Content, typeof(List<DependencyGraphDiffInner>), response.Headers);
        }

    }
}
