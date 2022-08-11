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
    public interface IBillingApi
    {
        /// <summary>
        /// Get GitHub Actions billing for an enterprise Gets the summary of the free and paid GitHub Actions minutes used.  Paid minutes only apply to workflows in private repositories that use GitHub-hosted runners. Minutes used is listed for each GitHub-hosted runner operating system. Any job re-runs are also included in the usage. The usage does not include the multiplier for macOS and Windows runners and is not rounded up to the nearest whole minute. For more information, see \&quot;[Managing billing for GitHub Actions](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-actions)\&quot;.  The authenticated user must be an enterprise admin.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <returns>BillingGetGithubActionsBillingGhe200Response</returns>
        BillingGetGithubActionsBillingGhe200Response BillingGetGithubActionsBillingGhe (string enterprise);
        /// <summary>
        /// Get GitHub Actions billing for an organization Gets the summary of the free and paid GitHub Actions minutes used.  Paid minutes only apply to workflows in private repositories that use GitHub-hosted runners. Minutes used is listed for each GitHub-hosted runner operating system. Any job re-runs are also included in the usage. The usage returned includes any minute multipliers for macOS and Windows runners, and is rounded up to the nearest whole minute. For more information, see \&quot;[Managing billing for GitHub Actions](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-actions)\&quot;.  Access tokens must have the &#x60;repo&#x60; or &#x60;admin:org&#x60; scope.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>BillingGetGithubActionsBillingGhe200Response</returns>
        BillingGetGithubActionsBillingGhe200Response BillingGetGithubActionsBillingOrg (string org);
        /// <summary>
        /// Get GitHub Actions billing for a user Gets the summary of the free and paid GitHub Actions minutes used.  Paid minutes only apply to workflows in private repositories that use GitHub-hosted runners. Minutes used is listed for each GitHub-hosted runner operating system. Any job re-runs are also included in the usage. The usage returned includes any minute multipliers for macOS and Windows runners, and is rounded up to the nearest whole minute. For more information, see \&quot;[Managing billing for GitHub Actions](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-actions)\&quot;.  Access tokens must have the &#x60;user&#x60; scope.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>BillingGetGithubActionsBillingGhe200Response</returns>
        BillingGetGithubActionsBillingGhe200Response BillingGetGithubActionsBillingUser (string username);
        /// <summary>
        /// Get GitHub Advanced Security active committers for an enterprise Gets the GitHub Advanced Security active committers for an enterprise per repository.  Each distinct user login across all repositories is counted as a single Advanced Security seat, so the &#x60;total_advanced_security_committers&#x60; is not the sum of active_users for each repository.  The total number of repositories with committer information is tracked by the &#x60;total_count&#x60; field.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>BillingGetGithubAdvancedSecurityBillingGhe200Response</returns>
        BillingGetGithubAdvancedSecurityBillingGhe200Response BillingGetGithubAdvancedSecurityBillingGhe (string enterprise, int? perPage, int? page);
        /// <summary>
        /// Get GitHub Advanced Security active committers for an organization Gets the GitHub Advanced Security active committers for an organization per repository.  Each distinct user login across all repositories is counted as a single Advanced Security seat, so the &#x60;total_advanced_security_committers&#x60; is not the sum of advanced_security_committers for each repository.  If this organization defers to an enterprise for billing, the &#x60;total_advanced_security_committers&#x60; returned from the organization API may include some users that are in more than one organization, so they will only consume a single Advanced Security seat at the enterprise level.  The total number of repositories with committer information is tracked by the &#x60;total_count&#x60; field.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>BillingGetGithubAdvancedSecurityBillingGhe200Response</returns>
        BillingGetGithubAdvancedSecurityBillingGhe200Response BillingGetGithubAdvancedSecurityBillingOrg (string org, int? perPage, int? page);
        /// <summary>
        /// Get GitHub Packages billing for an enterprise Gets the free and paid storage used for GitHub Packages in gigabytes.  Paid minutes only apply to packages stored for private repositories. For more information, see \&quot;[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\&quot;  The authenticated user must be an enterprise admin.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <returns>BillingGetGithubPackagesBillingGhe200Response</returns>
        BillingGetGithubPackagesBillingGhe200Response BillingGetGithubPackagesBillingGhe (string enterprise);
        /// <summary>
        /// Get GitHub Packages billing for an organization Gets the free and paid storage used for GitHub Packages in gigabytes.  Paid minutes only apply to packages stored for private repositories. For more information, see \&quot;[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\&quot;  Access tokens must have the &#x60;repo&#x60; or &#x60;admin:org&#x60; scope.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>BillingGetGithubPackagesBillingGhe200Response</returns>
        BillingGetGithubPackagesBillingGhe200Response BillingGetGithubPackagesBillingOrg (string org);
        /// <summary>
        /// Get GitHub Packages billing for a user Gets the free and paid storage used for GitHub Packages in gigabytes.  Paid minutes only apply to packages stored for private repositories. For more information, see \&quot;[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\&quot;  Access tokens must have the &#x60;user&#x60; scope.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>BillingGetGithubPackagesBillingGhe200Response</returns>
        BillingGetGithubPackagesBillingGhe200Response BillingGetGithubPackagesBillingUser (string username);
        /// <summary>
        /// Get shared storage billing for an enterprise Gets the estimated paid and estimated total storage used for GitHub Actions and GitHub Packages.  Paid minutes only apply to packages stored for private repositories. For more information, see \&quot;[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\&quot;  The authenticated user must be an enterprise admin.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <returns>BillingGetSharedStorageBillingGhe200Response</returns>
        BillingGetSharedStorageBillingGhe200Response BillingGetSharedStorageBillingGhe (string enterprise);
        /// <summary>
        /// Get shared storage billing for an organization Gets the estimated paid and estimated total storage used for GitHub Actions and GitHub Packages.  Paid minutes only apply to packages stored for private repositories. For more information, see \&quot;[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\&quot;  Access tokens must have the &#x60;repo&#x60; or &#x60;admin:org&#x60; scope.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>BillingGetSharedStorageBillingGhe200Response</returns>
        BillingGetSharedStorageBillingGhe200Response BillingGetSharedStorageBillingOrg (string org);
        /// <summary>
        /// Get shared storage billing for a user Gets the estimated paid and estimated total storage used for GitHub Actions and GitHub Packages.  Paid minutes only apply to packages stored for private repositories. For more information, see \&quot;[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\&quot;  Access tokens must have the &#x60;user&#x60; scope.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>BillingGetSharedStorageBillingGhe200Response</returns>
        BillingGetSharedStorageBillingGhe200Response BillingGetSharedStorageBillingUser (string username);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BillingApi : IBillingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BillingApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BillingApi(String basePath)
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
        /// Get GitHub Actions billing for an enterprise Gets the summary of the free and paid GitHub Actions minutes used.  Paid minutes only apply to workflows in private repositories that use GitHub-hosted runners. Minutes used is listed for each GitHub-hosted runner operating system. Any job re-runs are also included in the usage. The usage does not include the multiplier for macOS and Windows runners and is not rounded up to the nearest whole minute. For more information, see \&quot;[Managing billing for GitHub Actions](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-actions)\&quot;.  The authenticated user must be an enterprise admin.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <returns>BillingGetGithubActionsBillingGhe200Response</returns>
        public BillingGetGithubActionsBillingGhe200Response BillingGetGithubActionsBillingGhe (string enterprise)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling BillingGetGithubActionsBillingGhe");
            

            var path = "/enterprises/{enterprise}/settings/billing/actions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

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
                throw new ApiException ((int)response.StatusCode, "Error calling BillingGetGithubActionsBillingGhe: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BillingGetGithubActionsBillingGhe: " + response.ErrorMessage, response.ErrorMessage);

            return (BillingGetGithubActionsBillingGhe200Response) ApiClient.Deserialize(response.Content, typeof(BillingGetGithubActionsBillingGhe200Response), response.Headers);
        }

        /// <summary>
        /// Get GitHub Actions billing for an organization Gets the summary of the free and paid GitHub Actions minutes used.  Paid minutes only apply to workflows in private repositories that use GitHub-hosted runners. Minutes used is listed for each GitHub-hosted runner operating system. Any job re-runs are also included in the usage. The usage returned includes any minute multipliers for macOS and Windows runners, and is rounded up to the nearest whole minute. For more information, see \&quot;[Managing billing for GitHub Actions](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-actions)\&quot;.  Access tokens must have the &#x60;repo&#x60; or &#x60;admin:org&#x60; scope.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>BillingGetGithubActionsBillingGhe200Response</returns>
        public BillingGetGithubActionsBillingGhe200Response BillingGetGithubActionsBillingOrg (string org)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling BillingGetGithubActionsBillingOrg");
            

            var path = "/orgs/{org}/settings/billing/actions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling BillingGetGithubActionsBillingOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BillingGetGithubActionsBillingOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (BillingGetGithubActionsBillingGhe200Response) ApiClient.Deserialize(response.Content, typeof(BillingGetGithubActionsBillingGhe200Response), response.Headers);
        }

        /// <summary>
        /// Get GitHub Actions billing for a user Gets the summary of the free and paid GitHub Actions minutes used.  Paid minutes only apply to workflows in private repositories that use GitHub-hosted runners. Minutes used is listed for each GitHub-hosted runner operating system. Any job re-runs are also included in the usage. The usage returned includes any minute multipliers for macOS and Windows runners, and is rounded up to the nearest whole minute. For more information, see \&quot;[Managing billing for GitHub Actions](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-actions)\&quot;.  Access tokens must have the &#x60;user&#x60; scope.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>BillingGetGithubActionsBillingGhe200Response</returns>
        public BillingGetGithubActionsBillingGhe200Response BillingGetGithubActionsBillingUser (string username)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling BillingGetGithubActionsBillingUser");
            

            var path = "/users/{username}/settings/billing/actions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

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
                throw new ApiException ((int)response.StatusCode, "Error calling BillingGetGithubActionsBillingUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BillingGetGithubActionsBillingUser: " + response.ErrorMessage, response.ErrorMessage);

            return (BillingGetGithubActionsBillingGhe200Response) ApiClient.Deserialize(response.Content, typeof(BillingGetGithubActionsBillingGhe200Response), response.Headers);
        }

        /// <summary>
        /// Get GitHub Advanced Security active committers for an enterprise Gets the GitHub Advanced Security active committers for an enterprise per repository.  Each distinct user login across all repositories is counted as a single Advanced Security seat, so the &#x60;total_advanced_security_committers&#x60; is not the sum of active_users for each repository.  The total number of repositories with committer information is tracked by the &#x60;total_count&#x60; field.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>BillingGetGithubAdvancedSecurityBillingGhe200Response</returns>
        public BillingGetGithubAdvancedSecurityBillingGhe200Response BillingGetGithubAdvancedSecurityBillingGhe (string enterprise, int? perPage, int? page)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling BillingGetGithubAdvancedSecurityBillingGhe");
            

            var path = "/enterprises/{enterprise}/settings/billing/advanced-security";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

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
                throw new ApiException ((int)response.StatusCode, "Error calling BillingGetGithubAdvancedSecurityBillingGhe: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BillingGetGithubAdvancedSecurityBillingGhe: " + response.ErrorMessage, response.ErrorMessage);

            return (BillingGetGithubAdvancedSecurityBillingGhe200Response) ApiClient.Deserialize(response.Content, typeof(BillingGetGithubAdvancedSecurityBillingGhe200Response), response.Headers);
        }

        /// <summary>
        /// Get GitHub Advanced Security active committers for an organization Gets the GitHub Advanced Security active committers for an organization per repository.  Each distinct user login across all repositories is counted as a single Advanced Security seat, so the &#x60;total_advanced_security_committers&#x60; is not the sum of advanced_security_committers for each repository.  If this organization defers to an enterprise for billing, the &#x60;total_advanced_security_committers&#x60; returned from the organization API may include some users that are in more than one organization, so they will only consume a single Advanced Security seat at the enterprise level.  The total number of repositories with committer information is tracked by the &#x60;total_count&#x60; field.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>BillingGetGithubAdvancedSecurityBillingGhe200Response</returns>
        public BillingGetGithubAdvancedSecurityBillingGhe200Response BillingGetGithubAdvancedSecurityBillingOrg (string org, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling BillingGetGithubAdvancedSecurityBillingOrg");
            

            var path = "/orgs/{org}/settings/billing/advanced-security";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

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
                throw new ApiException ((int)response.StatusCode, "Error calling BillingGetGithubAdvancedSecurityBillingOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BillingGetGithubAdvancedSecurityBillingOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (BillingGetGithubAdvancedSecurityBillingGhe200Response) ApiClient.Deserialize(response.Content, typeof(BillingGetGithubAdvancedSecurityBillingGhe200Response), response.Headers);
        }

        /// <summary>
        /// Get GitHub Packages billing for an enterprise Gets the free and paid storage used for GitHub Packages in gigabytes.  Paid minutes only apply to packages stored for private repositories. For more information, see \&quot;[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\&quot;  The authenticated user must be an enterprise admin.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <returns>BillingGetGithubPackagesBillingGhe200Response</returns>
        public BillingGetGithubPackagesBillingGhe200Response BillingGetGithubPackagesBillingGhe (string enterprise)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling BillingGetGithubPackagesBillingGhe");
            

            var path = "/enterprises/{enterprise}/settings/billing/packages";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

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
                throw new ApiException ((int)response.StatusCode, "Error calling BillingGetGithubPackagesBillingGhe: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BillingGetGithubPackagesBillingGhe: " + response.ErrorMessage, response.ErrorMessage);

            return (BillingGetGithubPackagesBillingGhe200Response) ApiClient.Deserialize(response.Content, typeof(BillingGetGithubPackagesBillingGhe200Response), response.Headers);
        }

        /// <summary>
        /// Get GitHub Packages billing for an organization Gets the free and paid storage used for GitHub Packages in gigabytes.  Paid minutes only apply to packages stored for private repositories. For more information, see \&quot;[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\&quot;  Access tokens must have the &#x60;repo&#x60; or &#x60;admin:org&#x60; scope.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>BillingGetGithubPackagesBillingGhe200Response</returns>
        public BillingGetGithubPackagesBillingGhe200Response BillingGetGithubPackagesBillingOrg (string org)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling BillingGetGithubPackagesBillingOrg");
            

            var path = "/orgs/{org}/settings/billing/packages";
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
                throw new ApiException ((int)response.StatusCode, "Error calling BillingGetGithubPackagesBillingOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BillingGetGithubPackagesBillingOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (BillingGetGithubPackagesBillingGhe200Response) ApiClient.Deserialize(response.Content, typeof(BillingGetGithubPackagesBillingGhe200Response), response.Headers);
        }

        /// <summary>
        /// Get GitHub Packages billing for a user Gets the free and paid storage used for GitHub Packages in gigabytes.  Paid minutes only apply to packages stored for private repositories. For more information, see \&quot;[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\&quot;  Access tokens must have the &#x60;user&#x60; scope.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>BillingGetGithubPackagesBillingGhe200Response</returns>
        public BillingGetGithubPackagesBillingGhe200Response BillingGetGithubPackagesBillingUser (string username)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling BillingGetGithubPackagesBillingUser");
            

            var path = "/users/{username}/settings/billing/packages";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

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
                throw new ApiException ((int)response.StatusCode, "Error calling BillingGetGithubPackagesBillingUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BillingGetGithubPackagesBillingUser: " + response.ErrorMessage, response.ErrorMessage);

            return (BillingGetGithubPackagesBillingGhe200Response) ApiClient.Deserialize(response.Content, typeof(BillingGetGithubPackagesBillingGhe200Response), response.Headers);
        }

        /// <summary>
        /// Get shared storage billing for an enterprise Gets the estimated paid and estimated total storage used for GitHub Actions and GitHub Packages.  Paid minutes only apply to packages stored for private repositories. For more information, see \&quot;[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\&quot;  The authenticated user must be an enterprise admin.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <returns>BillingGetSharedStorageBillingGhe200Response</returns>
        public BillingGetSharedStorageBillingGhe200Response BillingGetSharedStorageBillingGhe (string enterprise)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling BillingGetSharedStorageBillingGhe");
            

            var path = "/enterprises/{enterprise}/settings/billing/shared-storage";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

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
                throw new ApiException ((int)response.StatusCode, "Error calling BillingGetSharedStorageBillingGhe: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BillingGetSharedStorageBillingGhe: " + response.ErrorMessage, response.ErrorMessage);

            return (BillingGetSharedStorageBillingGhe200Response) ApiClient.Deserialize(response.Content, typeof(BillingGetSharedStorageBillingGhe200Response), response.Headers);
        }

        /// <summary>
        /// Get shared storage billing for an organization Gets the estimated paid and estimated total storage used for GitHub Actions and GitHub Packages.  Paid minutes only apply to packages stored for private repositories. For more information, see \&quot;[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\&quot;  Access tokens must have the &#x60;repo&#x60; or &#x60;admin:org&#x60; scope.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>BillingGetSharedStorageBillingGhe200Response</returns>
        public BillingGetSharedStorageBillingGhe200Response BillingGetSharedStorageBillingOrg (string org)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling BillingGetSharedStorageBillingOrg");
            

            var path = "/orgs/{org}/settings/billing/shared-storage";
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
                throw new ApiException ((int)response.StatusCode, "Error calling BillingGetSharedStorageBillingOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BillingGetSharedStorageBillingOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (BillingGetSharedStorageBillingGhe200Response) ApiClient.Deserialize(response.Content, typeof(BillingGetSharedStorageBillingGhe200Response), response.Headers);
        }

        /// <summary>
        /// Get shared storage billing for a user Gets the estimated paid and estimated total storage used for GitHub Actions and GitHub Packages.  Paid minutes only apply to packages stored for private repositories. For more information, see \&quot;[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\&quot;  Access tokens must have the &#x60;user&#x60; scope.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>BillingGetSharedStorageBillingGhe200Response</returns>
        public BillingGetSharedStorageBillingGhe200Response BillingGetSharedStorageBillingUser (string username)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling BillingGetSharedStorageBillingUser");
            

            var path = "/users/{username}/settings/billing/shared-storage";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

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
                throw new ApiException ((int)response.StatusCode, "Error calling BillingGetSharedStorageBillingUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BillingGetSharedStorageBillingUser: " + response.ErrorMessage, response.ErrorMessage);

            return (BillingGetSharedStorageBillingGhe200Response) ApiClient.Deserialize(response.Content, typeof(BillingGetSharedStorageBillingGhe200Response), response.Headers);
        }

    }
}
