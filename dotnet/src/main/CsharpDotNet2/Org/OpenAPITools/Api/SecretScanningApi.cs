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
    public interface ISecretScanningApi
    {
        /// <summary>
        /// Get a secret scanning alert Gets a single secret scanning alert detected in an eligible repository. To use this endpoint, you must be an administrator for the repository or for the organization that owns the repository, and you must use a personal access token with the &#x60;repo&#x60; scope or &#x60;security_events&#x60; scope. For public repositories, you may instead use the &#x60;public_repo&#x60; scope.  GitHub Apps must have the &#x60;secret_scanning_alerts&#x60; read permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="alertNumber">The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the &#x60;number&#x60; field in the response from the &#x60;GET /repos/{owner}/{repo}/code-scanning/alerts&#x60; operation.</param>
        /// <returns>SecretScanningListAlertsForRepo200ResponseInner</returns>
        SecretScanningListAlertsForRepo200ResponseInner SecretScanningGetAlert (string owner, string repo, int? alertNumber);
        /// <summary>
        /// List secret scanning alerts for an enterprise Lists secret scanning alerts for eligible repositories in an enterprise, from newest to oldest. To use this endpoint, you must be a member of the enterprise, and you must use an access token with the &#x60;repo&#x60; scope or &#x60;security_events&#x60; scope. Alerts are only returned for organizations in the enterprise for which you are an organization owner or a [security manager](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="state">Set to &#x60;open&#x60; or &#x60;resolved&#x60; to only list secret scanning alerts in a specific state.</param>
        /// <param name="secretType">A comma-separated list of secret types to return. By default all secret types are returned. See \&quot;[Secret scanning patterns](https://docs.github.com/code-security/secret-scanning/secret-scanning-patterns#supported-secrets-for-advanced-security)\&quot; for a complete list of secret types.</param>
        /// <param name="resolution">A comma-separated list of resolutions. Only secret scanning alerts with one of these resolutions are listed. Valid resolutions are &#x60;false_positive&#x60;, &#x60;wont_fix&#x60;, &#x60;revoked&#x60;, &#x60;pattern_edited&#x60;, &#x60;pattern_deleted&#x60; or &#x60;used_in_tests&#x60;.</param>
        /// <param name="sort">The property to sort the results by. &#x60;created&#x60; means when the alert was created. &#x60;updated&#x60; means when the alert was updated or resolved.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="before">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor.</param>
        /// <param name="after">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.</param>
        /// <returns>List&lt;SecretScanningListAlertsForEnterprise200ResponseInner&gt;</returns>
        List<SecretScanningListAlertsForEnterprise200ResponseInner> SecretScanningListAlertsForEnterprise (string enterprise, string state, string secretType, string resolution, string sort, string direction, int? perPage, string before, string after);
        /// <summary>
        /// List secret scanning alerts for an organization Lists secret scanning alerts for eligible repositories in an organization, from newest to oldest. To use this endpoint, you must be an administrator or security manager for the organization, and you must use an access token with the &#x60;repo&#x60; scope or &#x60;security_events&#x60; scope. For public repositories, you may instead use the &#x60;public_repo&#x60; scope.  GitHub Apps must have the &#x60;secret_scanning_alerts&#x60; read permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="state">Set to &#x60;open&#x60; or &#x60;resolved&#x60; to only list secret scanning alerts in a specific state.</param>
        /// <param name="secretType">A comma-separated list of secret types to return. By default all secret types are returned. See \&quot;[Secret scanning patterns](https://docs.github.com/code-security/secret-scanning/secret-scanning-patterns#supported-secrets-for-advanced-security)\&quot; for a complete list of secret types.</param>
        /// <param name="resolution">A comma-separated list of resolutions. Only secret scanning alerts with one of these resolutions are listed. Valid resolutions are &#x60;false_positive&#x60;, &#x60;wont_fix&#x60;, &#x60;revoked&#x60;, &#x60;pattern_edited&#x60;, &#x60;pattern_deleted&#x60; or &#x60;used_in_tests&#x60;.</param>
        /// <param name="sort">The property to sort the results by. &#x60;created&#x60; means when the alert was created. &#x60;updated&#x60; means when the alert was updated or resolved.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="before">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. To receive an initial cursor on your first request, include an empty \&quot;before\&quot; query string.</param>
        /// <param name="after">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.  To receive an initial cursor on your first request, include an empty \&quot;after\&quot; query string.</param>
        /// <returns>List&lt;SecretScanningListAlertsForEnterprise200ResponseInner&gt;</returns>
        List<SecretScanningListAlertsForEnterprise200ResponseInner> SecretScanningListAlertsForOrg (string org, string state, string secretType, string resolution, string sort, string direction, int? page, int? perPage, string before, string after);
        /// <summary>
        /// List secret scanning alerts for a repository Lists secret scanning alerts for an eligible repository, from newest to oldest. To use this endpoint, you must be an administrator for the repository or for the organization that owns the repository, and you must use a personal access token with the &#x60;repo&#x60; scope or &#x60;security_events&#x60; scope. For public repositories, you may instead use the &#x60;public_repo&#x60; scope.  GitHub Apps must have the &#x60;secret_scanning_alerts&#x60; read permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="state">Set to &#x60;open&#x60; or &#x60;resolved&#x60; to only list secret scanning alerts in a specific state.</param>
        /// <param name="secretType">A comma-separated list of secret types to return. By default all secret types are returned. See \&quot;[Secret scanning patterns](https://docs.github.com/code-security/secret-scanning/secret-scanning-patterns#supported-secrets-for-advanced-security)\&quot; for a complete list of secret types.</param>
        /// <param name="resolution">A comma-separated list of resolutions. Only secret scanning alerts with one of these resolutions are listed. Valid resolutions are &#x60;false_positive&#x60;, &#x60;wont_fix&#x60;, &#x60;revoked&#x60;, &#x60;pattern_edited&#x60;, &#x60;pattern_deleted&#x60; or &#x60;used_in_tests&#x60;.</param>
        /// <param name="sort">The property to sort the results by. &#x60;created&#x60; means when the alert was created. &#x60;updated&#x60; means when the alert was updated or resolved.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="before">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. To receive an initial cursor on your first request, include an empty \&quot;before\&quot; query string.</param>
        /// <param name="after">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.  To receive an initial cursor on your first request, include an empty \&quot;after\&quot; query string.</param>
        /// <returns>List&lt;SecretScanningListAlertsForRepo200ResponseInner&gt;</returns>
        List<SecretScanningListAlertsForRepo200ResponseInner> SecretScanningListAlertsForRepo (string owner, string repo, string state, string secretType, string resolution, string sort, string direction, int? page, int? perPage, string before, string after);
        /// <summary>
        /// List locations for a secret scanning alert Lists all locations for a given secret scanning alert for an eligible repository. To use this endpoint, you must be an administrator for the repository or for the organization that owns the repository, and you must use a personal access token with the &#x60;repo&#x60; scope or &#x60;security_events&#x60; scope. For public repositories, you may instead use the &#x60;public_repo&#x60; scope.  GitHub Apps must have the &#x60;secret_scanning_alerts&#x60; read permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="alertNumber">The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the &#x60;number&#x60; field in the response from the &#x60;GET /repos/{owner}/{repo}/code-scanning/alerts&#x60; operation.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <returns>List&lt;SecretScanningListLocationsForAlert200ResponseInner&gt;</returns>
        List<SecretScanningListLocationsForAlert200ResponseInner> SecretScanningListLocationsForAlert (string owner, string repo, int? alertNumber, int? page, int? perPage);
        /// <summary>
        /// Update a secret scanning alert Updates the status of a secret scanning alert in an eligible repository. To use this endpoint, you must be an administrator for the repository or for the organization that owns the repository, and you must use a personal access token with the &#x60;repo&#x60; scope or &#x60;security_events&#x60; scope. For public repositories, you may instead use the &#x60;public_repo&#x60; scope.  GitHub Apps must have the &#x60;secret_scanning_alerts&#x60; write permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="alertNumber">The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the &#x60;number&#x60; field in the response from the &#x60;GET /repos/{owner}/{repo}/code-scanning/alerts&#x60; operation.</param>
        /// <param name="secretScanningUpdateAlertRequest"></param>
        /// <returns>SecretScanningListAlertsForRepo200ResponseInner</returns>
        SecretScanningListAlertsForRepo200ResponseInner SecretScanningUpdateAlert (string owner, string repo, int? alertNumber, SecretScanningUpdateAlertRequest secretScanningUpdateAlertRequest);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SecretScanningApi : ISecretScanningApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SecretScanningApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SecretScanningApi(String basePath)
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
        /// Get a secret scanning alert Gets a single secret scanning alert detected in an eligible repository. To use this endpoint, you must be an administrator for the repository or for the organization that owns the repository, and you must use a personal access token with the &#x60;repo&#x60; scope or &#x60;security_events&#x60; scope. For public repositories, you may instead use the &#x60;public_repo&#x60; scope.  GitHub Apps must have the &#x60;secret_scanning_alerts&#x60; read permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="alertNumber">The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the &#x60;number&#x60; field in the response from the &#x60;GET /repos/{owner}/{repo}/code-scanning/alerts&#x60; operation.</param>
        /// <returns>SecretScanningListAlertsForRepo200ResponseInner</returns>
        public SecretScanningListAlertsForRepo200ResponseInner SecretScanningGetAlert (string owner, string repo, int? alertNumber)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling SecretScanningGetAlert");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling SecretScanningGetAlert");
            
            // verify the required parameter 'alertNumber' is set
            if (alertNumber == null) throw new ApiException(400, "Missing required parameter 'alertNumber' when calling SecretScanningGetAlert");
            

            var path = "/repos/{owner}/{repo}/secret-scanning/alerts/{alert_number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "alert_number" + "}", ApiClient.ParameterToString(alertNumber));

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
                throw new ApiException ((int)response.StatusCode, "Error calling SecretScanningGetAlert: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SecretScanningGetAlert: " + response.ErrorMessage, response.ErrorMessage);

            return (SecretScanningListAlertsForRepo200ResponseInner) ApiClient.Deserialize(response.Content, typeof(SecretScanningListAlertsForRepo200ResponseInner), response.Headers);
        }

        /// <summary>
        /// List secret scanning alerts for an enterprise Lists secret scanning alerts for eligible repositories in an enterprise, from newest to oldest. To use this endpoint, you must be a member of the enterprise, and you must use an access token with the &#x60;repo&#x60; scope or &#x60;security_events&#x60; scope. Alerts are only returned for organizations in the enterprise for which you are an organization owner or a [security manager](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="state">Set to &#x60;open&#x60; or &#x60;resolved&#x60; to only list secret scanning alerts in a specific state.</param>
        /// <param name="secretType">A comma-separated list of secret types to return. By default all secret types are returned. See \&quot;[Secret scanning patterns](https://docs.github.com/code-security/secret-scanning/secret-scanning-patterns#supported-secrets-for-advanced-security)\&quot; for a complete list of secret types.</param>
        /// <param name="resolution">A comma-separated list of resolutions. Only secret scanning alerts with one of these resolutions are listed. Valid resolutions are &#x60;false_positive&#x60;, &#x60;wont_fix&#x60;, &#x60;revoked&#x60;, &#x60;pattern_edited&#x60;, &#x60;pattern_deleted&#x60; or &#x60;used_in_tests&#x60;.</param>
        /// <param name="sort">The property to sort the results by. &#x60;created&#x60; means when the alert was created. &#x60;updated&#x60; means when the alert was updated or resolved.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="before">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor.</param>
        /// <param name="after">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.</param>
        /// <returns>List&lt;SecretScanningListAlertsForEnterprise200ResponseInner&gt;</returns>
        public List<SecretScanningListAlertsForEnterprise200ResponseInner> SecretScanningListAlertsForEnterprise (string enterprise, string state, string secretType, string resolution, string sort, string direction, int? perPage, string before, string after)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling SecretScanningListAlertsForEnterprise");
            

            var path = "/enterprises/{enterprise}/secret-scanning/alerts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
 if (secretType != null) queryParams.Add("secret_type", ApiClient.ParameterToString(secretType)); // query parameter
 if (resolution != null) queryParams.Add("resolution", ApiClient.ParameterToString(resolution)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (before != null) queryParams.Add("before", ApiClient.ParameterToString(before)); // query parameter
 if (after != null) queryParams.Add("after", ApiClient.ParameterToString(after)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SecretScanningListAlertsForEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SecretScanningListAlertsForEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SecretScanningListAlertsForEnterprise200ResponseInner>) ApiClient.Deserialize(response.Content, typeof(List<SecretScanningListAlertsForEnterprise200ResponseInner>), response.Headers);
        }

        /// <summary>
        /// List secret scanning alerts for an organization Lists secret scanning alerts for eligible repositories in an organization, from newest to oldest. To use this endpoint, you must be an administrator or security manager for the organization, and you must use an access token with the &#x60;repo&#x60; scope or &#x60;security_events&#x60; scope. For public repositories, you may instead use the &#x60;public_repo&#x60; scope.  GitHub Apps must have the &#x60;secret_scanning_alerts&#x60; read permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="state">Set to &#x60;open&#x60; or &#x60;resolved&#x60; to only list secret scanning alerts in a specific state.</param>
        /// <param name="secretType">A comma-separated list of secret types to return. By default all secret types are returned. See \&quot;[Secret scanning patterns](https://docs.github.com/code-security/secret-scanning/secret-scanning-patterns#supported-secrets-for-advanced-security)\&quot; for a complete list of secret types.</param>
        /// <param name="resolution">A comma-separated list of resolutions. Only secret scanning alerts with one of these resolutions are listed. Valid resolutions are &#x60;false_positive&#x60;, &#x60;wont_fix&#x60;, &#x60;revoked&#x60;, &#x60;pattern_edited&#x60;, &#x60;pattern_deleted&#x60; or &#x60;used_in_tests&#x60;.</param>
        /// <param name="sort">The property to sort the results by. &#x60;created&#x60; means when the alert was created. &#x60;updated&#x60; means when the alert was updated or resolved.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="before">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. To receive an initial cursor on your first request, include an empty \&quot;before\&quot; query string.</param>
        /// <param name="after">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.  To receive an initial cursor on your first request, include an empty \&quot;after\&quot; query string.</param>
        /// <returns>List&lt;SecretScanningListAlertsForEnterprise200ResponseInner&gt;</returns>
        public List<SecretScanningListAlertsForEnterprise200ResponseInner> SecretScanningListAlertsForOrg (string org, string state, string secretType, string resolution, string sort, string direction, int? page, int? perPage, string before, string after)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling SecretScanningListAlertsForOrg");
            

            var path = "/orgs/{org}/secret-scanning/alerts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
 if (secretType != null) queryParams.Add("secret_type", ApiClient.ParameterToString(secretType)); // query parameter
 if (resolution != null) queryParams.Add("resolution", ApiClient.ParameterToString(resolution)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (before != null) queryParams.Add("before", ApiClient.ParameterToString(before)); // query parameter
 if (after != null) queryParams.Add("after", ApiClient.ParameterToString(after)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SecretScanningListAlertsForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SecretScanningListAlertsForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SecretScanningListAlertsForEnterprise200ResponseInner>) ApiClient.Deserialize(response.Content, typeof(List<SecretScanningListAlertsForEnterprise200ResponseInner>), response.Headers);
        }

        /// <summary>
        /// List secret scanning alerts for a repository Lists secret scanning alerts for an eligible repository, from newest to oldest. To use this endpoint, you must be an administrator for the repository or for the organization that owns the repository, and you must use a personal access token with the &#x60;repo&#x60; scope or &#x60;security_events&#x60; scope. For public repositories, you may instead use the &#x60;public_repo&#x60; scope.  GitHub Apps must have the &#x60;secret_scanning_alerts&#x60; read permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="state">Set to &#x60;open&#x60; or &#x60;resolved&#x60; to only list secret scanning alerts in a specific state.</param>
        /// <param name="secretType">A comma-separated list of secret types to return. By default all secret types are returned. See \&quot;[Secret scanning patterns](https://docs.github.com/code-security/secret-scanning/secret-scanning-patterns#supported-secrets-for-advanced-security)\&quot; for a complete list of secret types.</param>
        /// <param name="resolution">A comma-separated list of resolutions. Only secret scanning alerts with one of these resolutions are listed. Valid resolutions are &#x60;false_positive&#x60;, &#x60;wont_fix&#x60;, &#x60;revoked&#x60;, &#x60;pattern_edited&#x60;, &#x60;pattern_deleted&#x60; or &#x60;used_in_tests&#x60;.</param>
        /// <param name="sort">The property to sort the results by. &#x60;created&#x60; means when the alert was created. &#x60;updated&#x60; means when the alert was updated or resolved.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="before">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. To receive an initial cursor on your first request, include an empty \&quot;before\&quot; query string.</param>
        /// <param name="after">A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor.  To receive an initial cursor on your first request, include an empty \&quot;after\&quot; query string.</param>
        /// <returns>List&lt;SecretScanningListAlertsForRepo200ResponseInner&gt;</returns>
        public List<SecretScanningListAlertsForRepo200ResponseInner> SecretScanningListAlertsForRepo (string owner, string repo, string state, string secretType, string resolution, string sort, string direction, int? page, int? perPage, string before, string after)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling SecretScanningListAlertsForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling SecretScanningListAlertsForRepo");
            

            var path = "/repos/{owner}/{repo}/secret-scanning/alerts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
 if (secretType != null) queryParams.Add("secret_type", ApiClient.ParameterToString(secretType)); // query parameter
 if (resolution != null) queryParams.Add("resolution", ApiClient.ParameterToString(resolution)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (before != null) queryParams.Add("before", ApiClient.ParameterToString(before)); // query parameter
 if (after != null) queryParams.Add("after", ApiClient.ParameterToString(after)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SecretScanningListAlertsForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SecretScanningListAlertsForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SecretScanningListAlertsForRepo200ResponseInner>) ApiClient.Deserialize(response.Content, typeof(List<SecretScanningListAlertsForRepo200ResponseInner>), response.Headers);
        }

        /// <summary>
        /// List locations for a secret scanning alert Lists all locations for a given secret scanning alert for an eligible repository. To use this endpoint, you must be an administrator for the repository or for the organization that owns the repository, and you must use a personal access token with the &#x60;repo&#x60; scope or &#x60;security_events&#x60; scope. For public repositories, you may instead use the &#x60;public_repo&#x60; scope.  GitHub Apps must have the &#x60;secret_scanning_alerts&#x60; read permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="alertNumber">The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the &#x60;number&#x60; field in the response from the &#x60;GET /repos/{owner}/{repo}/code-scanning/alerts&#x60; operation.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <returns>List&lt;SecretScanningListLocationsForAlert200ResponseInner&gt;</returns>
        public List<SecretScanningListLocationsForAlert200ResponseInner> SecretScanningListLocationsForAlert (string owner, string repo, int? alertNumber, int? page, int? perPage)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling SecretScanningListLocationsForAlert");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling SecretScanningListLocationsForAlert");
            
            // verify the required parameter 'alertNumber' is set
            if (alertNumber == null) throw new ApiException(400, "Missing required parameter 'alertNumber' when calling SecretScanningListLocationsForAlert");
            

            var path = "/repos/{owner}/{repo}/secret-scanning/alerts/{alert_number}/locations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "alert_number" + "}", ApiClient.ParameterToString(alertNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SecretScanningListLocationsForAlert: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SecretScanningListLocationsForAlert: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SecretScanningListLocationsForAlert200ResponseInner>) ApiClient.Deserialize(response.Content, typeof(List<SecretScanningListLocationsForAlert200ResponseInner>), response.Headers);
        }

        /// <summary>
        /// Update a secret scanning alert Updates the status of a secret scanning alert in an eligible repository. To use this endpoint, you must be an administrator for the repository or for the organization that owns the repository, and you must use a personal access token with the &#x60;repo&#x60; scope or &#x60;security_events&#x60; scope. For public repositories, you may instead use the &#x60;public_repo&#x60; scope.  GitHub Apps must have the &#x60;secret_scanning_alerts&#x60; write permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="alertNumber">The number that identifies an alert. You can find this at the end of the URL for a code scanning alert within GitHub, and in the &#x60;number&#x60; field in the response from the &#x60;GET /repos/{owner}/{repo}/code-scanning/alerts&#x60; operation.</param>
        /// <param name="secretScanningUpdateAlertRequest"></param>
        /// <returns>SecretScanningListAlertsForRepo200ResponseInner</returns>
        public SecretScanningListAlertsForRepo200ResponseInner SecretScanningUpdateAlert (string owner, string repo, int? alertNumber, SecretScanningUpdateAlertRequest secretScanningUpdateAlertRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling SecretScanningUpdateAlert");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling SecretScanningUpdateAlert");
            
            // verify the required parameter 'alertNumber' is set
            if (alertNumber == null) throw new ApiException(400, "Missing required parameter 'alertNumber' when calling SecretScanningUpdateAlert");
            
            // verify the required parameter 'secretScanningUpdateAlertRequest' is set
            if (secretScanningUpdateAlertRequest == null) throw new ApiException(400, "Missing required parameter 'secretScanningUpdateAlertRequest' when calling SecretScanningUpdateAlert");
            

            var path = "/repos/{owner}/{repo}/secret-scanning/alerts/{alert_number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "alert_number" + "}", ApiClient.ParameterToString(alertNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(secretScanningUpdateAlertRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SecretScanningUpdateAlert: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SecretScanningUpdateAlert: " + response.ErrorMessage, response.ErrorMessage);

            return (SecretScanningListAlertsForRepo200ResponseInner) ApiClient.Deserialize(response.Content, typeof(SecretScanningListAlertsForRepo200ResponseInner), response.Headers);
        }

    }
}
