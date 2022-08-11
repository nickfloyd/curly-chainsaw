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
    public interface IOidcApi
    {
        /// <summary>
        /// Get the customization template for an OIDC subject claim for an organization Gets the customization template for an OpenID Connect (OIDC) subject claim. You must authenticate using an access token with the &#x60;read:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;organization_administration:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>ActionsOIDCSubjectCustomization</returns>
        ActionsOIDCSubjectCustomization OidcGetOidcCustomSubTemplateForOrg (string org);
        /// <summary>
        /// Set the customization template for an OIDC subject claim for an organization Creates or updates the customization template for an OpenID Connect (OIDC) subject claim. You must authenticate using an access token with the &#x60;write:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;admin:org&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="actionsOIDCSubjectCustomization"></param>
        /// <returns>Object</returns>
        Object OidcUpdateOidcCustomSubTemplateForOrg (string org, ActionsOIDCSubjectCustomization actionsOIDCSubjectCustomization);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OidcApi : IOidcApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OidcApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OidcApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OidcApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OidcApi(String basePath)
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
        /// Get the customization template for an OIDC subject claim for an organization Gets the customization template for an OpenID Connect (OIDC) subject claim. You must authenticate using an access token with the &#x60;read:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;organization_administration:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>ActionsOIDCSubjectCustomization</returns>
        public ActionsOIDCSubjectCustomization OidcGetOidcCustomSubTemplateForOrg (string org)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OidcGetOidcCustomSubTemplateForOrg");
            

            var path = "/orgs/{org}/actions/oidc/customization/sub";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

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
                throw new ApiException ((int)response.StatusCode, "Error calling OidcGetOidcCustomSubTemplateForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OidcGetOidcCustomSubTemplateForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsOIDCSubjectCustomization) ApiClient.Deserialize(response.Content, typeof(ActionsOIDCSubjectCustomization), response.Headers);
        }

        /// <summary>
        /// Set the customization template for an OIDC subject claim for an organization Creates or updates the customization template for an OpenID Connect (OIDC) subject claim. You must authenticate using an access token with the &#x60;write:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;admin:org&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="actionsOIDCSubjectCustomization"></param>
        /// <returns>Object</returns>
        public Object OidcUpdateOidcCustomSubTemplateForOrg (string org, ActionsOIDCSubjectCustomization actionsOIDCSubjectCustomization)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling OidcUpdateOidcCustomSubTemplateForOrg");
            
            // verify the required parameter 'actionsOIDCSubjectCustomization' is set
            if (actionsOIDCSubjectCustomization == null) throw new ApiException(400, "Missing required parameter 'actionsOIDCSubjectCustomization' when calling OidcUpdateOidcCustomSubTemplateForOrg");
            

            var path = "/orgs/{org}/actions/oidc/customization/sub";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(actionsOIDCSubjectCustomization); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OidcUpdateOidcCustomSubTemplateForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OidcUpdateOidcCustomSubTemplateForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

    }
}
