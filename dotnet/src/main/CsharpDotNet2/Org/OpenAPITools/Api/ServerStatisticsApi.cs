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
    public interface IServerStatisticsApi
    {
        /// <summary>
        /// Get GitHub Enterprise Server statistics Returns aggregate usage metrics for your GitHub Enterprise Server 3.5+ instance for a specified time period up to 365 days.  To use this endpoint, your GitHub Enterprise Server instance must be connected to GitHub Enterprise Cloud using GitHub Connect. You must enable Server Statistics, and for the API request provide your enterprise account name or organization name connected to the GitHub Enterprise Server. For more information, see \&quot;[Enabling Server Statistics for your enterprise](/admin/configuration/configuring-github-connect/enabling-server-statistics-for-your-enterprise)\&quot; in the GitHub Enterprise Server documentation.  You&#39;ll need to use a personal access token:   - If you connected your GitHub Enterprise Server to an enterprise account and enabled Server Statistics, you&#39;ll need a personal access token with the &#x60;read:enterprise&#x60; permission.   - If you connected your GitHub Enterprise Server to an organization account and enabled Server Statistics, you&#39;ll need a personal access token with the &#x60;read:org&#x60; permission.  For more information on creating a personal access token, see \&quot;[Creating a personal access token](/authentication/keeping-your-account-and-data-secure/creating-a-personal-access-token).\&quot;
        /// </summary>
        /// <param name="enterpriseOrOrg">The slug version of the enterprise name or the login of an organization.</param>
        /// <param name="dateStart">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.</param>
        /// <param name="dateEnd">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor.</param>
        /// <returns>List&lt;ServerStatisticsProxyEndpointInner&gt;</returns>
        List<ServerStatisticsProxyEndpointInner> EnterpriseAdminGetServerStatistics (string enterpriseOrOrg, string dateStart, string dateEnd);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ServerStatisticsApi : IServerStatisticsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStatisticsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ServerStatisticsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStatisticsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServerStatisticsApi(String basePath)
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
        /// Get GitHub Enterprise Server statistics Returns aggregate usage metrics for your GitHub Enterprise Server 3.5+ instance for a specified time period up to 365 days.  To use this endpoint, your GitHub Enterprise Server instance must be connected to GitHub Enterprise Cloud using GitHub Connect. You must enable Server Statistics, and for the API request provide your enterprise account name or organization name connected to the GitHub Enterprise Server. For more information, see \&quot;[Enabling Server Statistics for your enterprise](/admin/configuration/configuring-github-connect/enabling-server-statistics-for-your-enterprise)\&quot; in the GitHub Enterprise Server documentation.  You&#39;ll need to use a personal access token:   - If you connected your GitHub Enterprise Server to an enterprise account and enabled Server Statistics, you&#39;ll need a personal access token with the &#x60;read:enterprise&#x60; permission.   - If you connected your GitHub Enterprise Server to an organization account and enabled Server Statistics, you&#39;ll need a personal access token with the &#x60;read:org&#x60; permission.  For more information on creating a personal access token, see \&quot;[Creating a personal access token](/authentication/keeping-your-account-and-data-secure/creating-a-personal-access-token).\&quot;
        /// </summary>
        /// <param name="enterpriseOrOrg">The slug version of the enterprise name or the login of an organization.</param>
        /// <param name="dateStart">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.</param>
        /// <param name="dateEnd">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor.</param>
        /// <returns>List&lt;ServerStatisticsProxyEndpointInner&gt;</returns>
        public List<ServerStatisticsProxyEndpointInner> EnterpriseAdminGetServerStatistics (string enterpriseOrOrg, string dateStart, string dateEnd)
        {
            
            // verify the required parameter 'enterpriseOrOrg' is set
            if (enterpriseOrOrg == null) throw new ApiException(400, "Missing required parameter 'enterpriseOrOrg' when calling EnterpriseAdminGetServerStatistics");
            

            var path = "/enterprise-installation/{enterprise_or_org}/server-statistics";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise_or_org" + "}", ApiClient.ParameterToString(enterpriseOrOrg));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (dateStart != null) queryParams.Add("date_start", ApiClient.ParameterToString(dateStart)); // query parameter
 if (dateEnd != null) queryParams.Add("date_end", ApiClient.ParameterToString(dateEnd)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminGetServerStatistics: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnterpriseAdminGetServerStatistics: " + response.ErrorMessage, response.ErrorMessage);

            return (List<ServerStatisticsProxyEndpointInner>) ApiClient.Deserialize(response.Content, typeof(List<ServerStatisticsProxyEndpointInner>), response.Headers);
        }

    }
}
