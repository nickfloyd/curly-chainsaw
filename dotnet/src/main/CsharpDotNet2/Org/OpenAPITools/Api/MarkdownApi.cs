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
    public interface IMarkdownApi
    {
        /// <summary>
        /// Render a Markdown document 
        /// </summary>
        /// <param name="markdownRenderRequest"></param>
        /// <returns>string</returns>
        string MarkdownRender (MarkdownRenderRequest markdownRenderRequest);
        /// <summary>
        /// Render a Markdown document in raw mode You must send Markdown as plain text (using a &#x60;Content-Type&#x60; header of &#x60;text/plain&#x60; or &#x60;text/x-markdown&#x60;) to this endpoint, rather than using JSON format. In raw mode, [GitHub Flavored Markdown](https://github.github.com/gfm/) is not supported and Markdown will be rendered in plain format like a README.md file. Markdown content must be 400 KB or less.
        /// </summary>
        /// <param name="body"></param>
        /// <returns>string</returns>
        string MarkdownRenderRaw (string body);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MarkdownApi : IMarkdownApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MarkdownApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MarkdownApi(String basePath)
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
        /// Render a Markdown document 
        /// </summary>
        /// <param name="markdownRenderRequest"></param>
        /// <returns>string</returns>
        public string MarkdownRender (MarkdownRenderRequest markdownRenderRequest)
        {
            
            // verify the required parameter 'markdownRenderRequest' is set
            if (markdownRenderRequest == null) throw new ApiException(400, "Missing required parameter 'markdownRenderRequest' when calling MarkdownRender");
            

            var path = "/markdown";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(markdownRenderRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarkdownRender: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarkdownRender: " + response.ErrorMessage, response.ErrorMessage);

            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }

        /// <summary>
        /// Render a Markdown document in raw mode You must send Markdown as plain text (using a &#x60;Content-Type&#x60; header of &#x60;text/plain&#x60; or &#x60;text/x-markdown&#x60;) to this endpoint, rather than using JSON format. In raw mode, [GitHub Flavored Markdown](https://github.github.com/gfm/) is not supported and Markdown will be rendered in plain format like a README.md file. Markdown content must be 400 KB or less.
        /// </summary>
        /// <param name="body"></param>
        /// <returns>string</returns>
        public string MarkdownRenderRaw (string body)
        {
            

            var path = "/markdown/raw";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MarkdownRenderRaw: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MarkdownRenderRaw: " + response.ErrorMessage, response.ErrorMessage);

            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }

    }
}
