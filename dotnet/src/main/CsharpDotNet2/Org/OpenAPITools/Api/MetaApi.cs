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
    public interface IMetaApi
    {
        /// <summary>
        /// Get GitHub meta information Returns meta information about GitHub, including a list of GitHub&#39;s IP addresses. For more information, see \&quot;[About GitHub&#39;s IP addresses](https://docs.github.com/articles/about-github-s-ip-addresses/).\&quot;  **Note:** The IP addresses shown in the documentation&#39;s response are only example values. You must always query the API directly to get the latest list of IP addresses.
        /// </summary>
        /// <returns>ApiOverview</returns>
        ApiOverview MetaGet ();
        /// <summary>
        /// Get Octocat Get the octocat as ASCII art
        /// </summary>
        /// <param name="s">The words to show in Octocat&#39;s speech bubble</param>
        /// <returns>string</returns>
        string MetaGetOctocat (string s);
        /// <summary>
        /// Get the Zen of GitHub Get a random sentence from the Zen of GitHub
        /// </summary>
        /// <returns>string</returns>
        string MetaGetZen ();
        /// <summary>
        /// GitHub API Root Get Hypermedia links to resources accessible in GitHub&#39;s REST API
        /// </summary>
        /// <returns>MetaRoot200Response</returns>
        MetaRoot200Response MetaRoot ();
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MetaApi : IMetaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetaApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MetaApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MetaApi(String basePath)
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
        /// Get GitHub meta information Returns meta information about GitHub, including a list of GitHub&#39;s IP addresses. For more information, see \&quot;[About GitHub&#39;s IP addresses](https://docs.github.com/articles/about-github-s-ip-addresses/).\&quot;  **Note:** The IP addresses shown in the documentation&#39;s response are only example values. You must always query the API directly to get the latest list of IP addresses.
        /// </summary>
        /// <returns>ApiOverview</returns>
        public ApiOverview MetaGet ()
        {
            

            var path = "/meta";
            path = path.Replace("{format}", "json");
            
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
                throw new ApiException ((int)response.StatusCode, "Error calling MetaGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MetaGet: " + response.ErrorMessage, response.ErrorMessage);

            return (ApiOverview) ApiClient.Deserialize(response.Content, typeof(ApiOverview), response.Headers);
        }

        /// <summary>
        /// Get Octocat Get the octocat as ASCII art
        /// </summary>
        /// <param name="s">The words to show in Octocat&#39;s speech bubble</param>
        /// <returns>string</returns>
        public string MetaGetOctocat (string s)
        {
            

            var path = "/octocat";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (s != null) queryParams.Add("s", ApiClient.ParameterToString(s)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MetaGetOctocat: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MetaGetOctocat: " + response.ErrorMessage, response.ErrorMessage);

            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }

        /// <summary>
        /// Get the Zen of GitHub Get a random sentence from the Zen of GitHub
        /// </summary>
        /// <returns>string</returns>
        public string MetaGetZen ()
        {
            

            var path = "/zen";
            path = path.Replace("{format}", "json");
            
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
                throw new ApiException ((int)response.StatusCode, "Error calling MetaGetZen: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MetaGetZen: " + response.ErrorMessage, response.ErrorMessage);

            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }

        /// <summary>
        /// GitHub API Root Get Hypermedia links to resources accessible in GitHub&#39;s REST API
        /// </summary>
        /// <returns>MetaRoot200Response</returns>
        public MetaRoot200Response MetaRoot ()
        {
            

            var path = "/";
            path = path.Replace("{format}", "json");
            
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
                throw new ApiException ((int)response.StatusCode, "Error calling MetaRoot: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MetaRoot: " + response.ErrorMessage, response.ErrorMessage);

            return (MetaRoot200Response) ApiClient.Deserialize(response.Content, typeof(MetaRoot200Response), response.Headers);
        }

    }
}
