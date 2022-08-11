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
    public interface IGitignoreApi
    {
        /// <summary>
        /// Get all gitignore templates List all templates available to pass as an option when [creating a repository](https://docs.github.com/rest/reference/repos#create-a-repository-for-the-authenticated-user).
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GitignoreGetAllTemplates ();
        /// <summary>
        /// Get a gitignore template The API also allows fetching the source of a single template. Use the raw [media type](https://docs.github.com/rest/overview/media-types/) to get the raw contents.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>GitignoreTemplate</returns>
        GitignoreTemplate GitignoreGetTemplate (string name);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GitignoreApi : IGitignoreApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GitignoreApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public GitignoreApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitignoreApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GitignoreApi(String basePath)
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
        /// Get all gitignore templates List all templates available to pass as an option when [creating a repository](https://docs.github.com/rest/reference/repos#create-a-repository-for-the-authenticated-user).
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> GitignoreGetAllTemplates ()
        {
            

            var path = "/gitignore/templates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GitignoreGetAllTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GitignoreGetAllTemplates: " + response.ErrorMessage, response.ErrorMessage);

            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }

        /// <summary>
        /// Get a gitignore template The API also allows fetching the source of a single template. Use the raw [media type](https://docs.github.com/rest/overview/media-types/) to get the raw contents.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>GitignoreTemplate</returns>
        public GitignoreTemplate GitignoreGetTemplate (string name)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling GitignoreGetTemplate");
            

            var path = "/gitignore/templates/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));

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
                throw new ApiException ((int)response.StatusCode, "Error calling GitignoreGetTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GitignoreGetTemplate: " + response.ErrorMessage, response.ErrorMessage);

            return (GitignoreTemplate) ApiClient.Deserialize(response.Content, typeof(GitignoreTemplate), response.Headers);
        }

    }
}
