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
    public interface ICodesOfConductApi
    {
        /// <summary>
        /// Get all codes of conduct 
        /// </summary>
        /// <returns>List&lt;CodeOfConduct&gt;</returns>
        List<CodeOfConduct> CodesOfConductGetAllCodesOfConduct ();
        /// <summary>
        /// Get a code of conduct 
        /// </summary>
        /// <param name="key"></param>
        /// <returns>CodeOfConduct</returns>
        CodeOfConduct CodesOfConductGetConductCode (string key);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CodesOfConductApi : ICodesOfConductApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodesOfConductApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CodesOfConductApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodesOfConductApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CodesOfConductApi(String basePath)
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
        /// Get all codes of conduct 
        /// </summary>
        /// <returns>List&lt;CodeOfConduct&gt;</returns>
        public List<CodeOfConduct> CodesOfConductGetAllCodesOfConduct ()
        {
            

            var path = "/codes_of_conduct";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CodesOfConductGetAllCodesOfConduct: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodesOfConductGetAllCodesOfConduct: " + response.ErrorMessage, response.ErrorMessage);

            return (List<CodeOfConduct>) ApiClient.Deserialize(response.Content, typeof(List<CodeOfConduct>), response.Headers);
        }

        /// <summary>
        /// Get a code of conduct 
        /// </summary>
        /// <param name="key"></param>
        /// <returns>CodeOfConduct</returns>
        public CodeOfConduct CodesOfConductGetConductCode (string key)
        {
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling CodesOfConductGetConductCode");
            

            var path = "/codes_of_conduct/{key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "key" + "}", ApiClient.ParameterToString(key));

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
                throw new ApiException ((int)response.StatusCode, "Error calling CodesOfConductGetConductCode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodesOfConductGetConductCode: " + response.ErrorMessage, response.ErrorMessage);

            return (CodeOfConduct) ApiClient.Deserialize(response.Content, typeof(CodeOfConduct), response.Headers);
        }

    }
}
