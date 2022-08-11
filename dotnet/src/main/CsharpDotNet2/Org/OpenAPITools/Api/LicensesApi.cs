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
    public interface ILicensesApi
    {
        /// <summary>
        /// Get a license 
        /// </summary>
        /// <param name="license"></param>
        /// <returns>License</returns>
        License LicensesGet (string license);
        /// <summary>
        /// Get all commonly used licenses 
        /// </summary>
        /// <param name="featured"></param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;LicenseSimple1&gt;</returns>
        List<LicenseSimple1> LicensesGetAllCommonlyUsed (bool? featured, int? perPage, int? page);
        /// <summary>
        /// Get the license for a repository This method returns the contents of the repository&#39;s license file, if one is detected.  Similar to [Get repository content](https://docs.github.com/rest/reference/repos#get-repository-content), this method also supports [custom media types](https://docs.github.com/rest/overview/media-types) for retrieving the raw license content or rendered license HTML.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>LicenseContent</returns>
        LicenseContent LicensesGetForRepo (string owner, string repo);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LicensesApi : ILicensesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public LicensesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LicensesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LicensesApi(String basePath)
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
        /// Get a license 
        /// </summary>
        /// <param name="license"></param>
        /// <returns>License</returns>
        public License LicensesGet (string license)
        {
            
            // verify the required parameter 'license' is set
            if (license == null) throw new ApiException(400, "Missing required parameter 'license' when calling LicensesGet");
            

            var path = "/licenses/{license}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "license" + "}", ApiClient.ParameterToString(license));

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
                throw new ApiException ((int)response.StatusCode, "Error calling LicensesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LicensesGet: " + response.ErrorMessage, response.ErrorMessage);

            return (License) ApiClient.Deserialize(response.Content, typeof(License), response.Headers);
        }

        /// <summary>
        /// Get all commonly used licenses 
        /// </summary>
        /// <param name="featured"></param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;LicenseSimple1&gt;</returns>
        public List<LicenseSimple1> LicensesGetAllCommonlyUsed (bool? featured, int? perPage, int? page)
        {
            

            var path = "/licenses";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (featured != null) queryParams.Add("featured", ApiClient.ParameterToString(featured)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling LicensesGetAllCommonlyUsed: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LicensesGetAllCommonlyUsed: " + response.ErrorMessage, response.ErrorMessage);

            return (List<LicenseSimple1>) ApiClient.Deserialize(response.Content, typeof(List<LicenseSimple1>), response.Headers);
        }

        /// <summary>
        /// Get the license for a repository This method returns the contents of the repository&#39;s license file, if one is detected.  Similar to [Get repository content](https://docs.github.com/rest/reference/repos#get-repository-content), this method also supports [custom media types](https://docs.github.com/rest/overview/media-types) for retrieving the raw license content or rendered license HTML.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>LicenseContent</returns>
        public LicenseContent LicensesGetForRepo (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling LicensesGetForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling LicensesGetForRepo");
            

            var path = "/repos/{owner}/{repo}/license";
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
                throw new ApiException ((int)response.StatusCode, "Error calling LicensesGetForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LicensesGetForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (LicenseContent) ApiClient.Deserialize(response.Content, typeof(LicenseContent), response.Headers);
        }

    }
}
