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
    public interface IRateLimitApi
    {
        /// <summary>
        /// Get rate limit status for the authenticated user **Note:** Accessing this endpoint does not count against your REST API rate limit.  **Note:** The &#x60;rate&#x60; object is deprecated. If you&#39;re writing new API client code or updating existing code, you should use the &#x60;core&#x60; object instead of the &#x60;rate&#x60; object. The &#x60;core&#x60; object contains the same information that is present in the &#x60;rate&#x60; object.
        /// </summary>
        /// <returns>RateLimitOverview</returns>
        RateLimitOverview RateLimitGet ();
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RateLimitApi : IRateLimitApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RateLimitApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RateLimitApi(String basePath)
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
        /// Get rate limit status for the authenticated user **Note:** Accessing this endpoint does not count against your REST API rate limit.  **Note:** The &#x60;rate&#x60; object is deprecated. If you&#39;re writing new API client code or updating existing code, you should use the &#x60;core&#x60; object instead of the &#x60;rate&#x60; object. The &#x60;core&#x60; object contains the same information that is present in the &#x60;rate&#x60; object.
        /// </summary>
        /// <returns>RateLimitOverview</returns>
        public RateLimitOverview RateLimitGet ()
        {
            

            var path = "/rate_limit";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RateLimitGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RateLimitGet: " + response.ErrorMessage, response.ErrorMessage);

            return (RateLimitOverview) ApiClient.Deserialize(response.Content, typeof(RateLimitOverview), response.Headers);
        }

    }
}
